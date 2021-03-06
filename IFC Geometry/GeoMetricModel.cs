using System;
using IFC4;
using ThreeDMaker.Geometry;
using IFC_Geometry;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using IFC_Geometry.IFCGeoReader;
namespace IFC_Geometry
{
    public class GeoMetricModel
    {
        Ifc4 model;
        Dictionary<IfcProductRepresentation, List<Mesh3D>> productRepresentationDict;

        public void LoadModel(string filePath)
        {
            model = new Ifc4();
            model.ImportIFC(filePath);

            ConstructGeometry();
        }

        
        void ConstructGeometry()
        {
            var solidModels = model.GetInstances<IfcSolidModel>();
            if (solidModels.Count == 0) return;
            Dictionary<IfcSolidModel, Mesh3D>  solidDict = new Dictionary<IfcSolidModel, Mesh3D>();
          
            foreach (var solid in solidModels)
            {
                Mesh3D mesh = SolidModelMaker.GetSolid(solid);
                solidDict.Add(solid, mesh);
            }
            var mappedItems = model.GetInstances<IfcMappedItem>();
            Dictionary<IfcMappedItem, List<Mesh3D>> mappedDict = new Dictionary<IfcMappedItem, List<Mesh3D>>();
            foreach (var mapped in mappedItems)
            {
                mappedDict.Add(mapped, SolidModelMaker.GetSolids(mapped, solidDict));
            }

            var tessellatedItems = model.GetInstances<IfcTessellatedItem>();
            Dictionary<IfcTessellatedItem, Mesh3D> tessellatedDict = new Dictionary<IfcTessellatedItem, Mesh3D>();
            foreach (var solid in tessellatedItems)
            {
                tessellatedDict.Add(solid, SolidModelMaker.GetSolid(solid));
            }


            var productRepresentations= model.GetInstances<IfcProductRepresentation>();
            productRepresentationDict = new Dictionary<IfcProductRepresentation, List<Mesh3D>>();


            foreach (var productRepresentation in productRepresentations)
            {
                var representations = productRepresentation.Representations;
                List<Mesh3D> meshs = new List<Mesh3D>();
                foreach (var representation in representations)
                {
                    
                    var items = representation.Items;

                    foreach (var item in items)
                    {
                     
                        if (item.InTypeOf<IfcSolidModel>())
                        {
                            meshs.Add(new Mesh3D(solidDict[(IfcSolidModel)item]));
                        }
                        else if (item.InTypeOf<IfcTessellatedItem>())
                        {
                            meshs.Add(tessellatedDict[(IfcTessellatedItem)item]);
                        }

                        else if (item.InTypeOf<IfcMappedItem>())
                        {
                            meshs.AddRange(mappedDict[(IfcMappedItem)item]);
                        }

                        
                    }
                }
                productRepresentationDict.Add(productRepresentation, meshs);
            }
            
        }

        public void ExportFullBuildingAsObj(string filePath, bool includSpace = false)
        {
            var elemments = model.GetInstances<IfcElement>();
            var localplacements = model.GetInstances<IfcLocalPlacement>();
            var placementToMat = IFCGeoUtil.SetGlobalMat(localplacements);
            List<Mesh3D> meshes = new List<Mesh3D>();
            foreach (var element in elemments)
            {
                if (includSpace && element.InTypeOf<IfcSpace>())
                {
                    continue;
                }
                var objectPlacement = element.ObjectPlacement;
                Matrix4x4 globalmat;
                if (objectPlacement != null)
                {
                    globalmat = Matrix4x4.Transpose(placementToMat[(IfcLocalPlacement)objectPlacement][1]);
                }
                else
                {
                    globalmat = Matrix4x4.Identity;
                }
                if (element.Representation != null)
                {
                    List<Mesh3D> meshs = productRepresentationDict[element.Representation];
                    int j = 0;
                    foreach (var mesh in meshs)
                    {
                        var cloneMesh = new Mesh3D(mesh);
                        var vertives = cloneMesh.Vertices;
                        for (int i = 0; i < vertives.Count; i++)
                        {
                            vertives[i] = Vector3.Transform(vertives[i], globalmat);
                       //     vertives[i] += new Vector3(0, 0, 1000 * j);
                        }
                        meshes.Add(cloneMesh);
                        j++;
                    }  
                }
            }

          
            Mesh3D fullmesh = new Mesh3D(meshes);
          
            fullmesh.ReCalculateNormal();
            fullmesh.ExportToObj(filePath, true);
        }



        public void ExportAnObjectAsObj(string filePath, string id)
        {
            var elemments = model.GetInstances<IfcElement>();
            var localplacements = model.GetInstances<IfcLocalPlacement>();
            var placementToMat = IFCGeoUtil.SetGlobalMat(localplacements);
          
            List<Mesh3D> meshes = new List<Mesh3D>();

            var item = model.GetInstance(id);

            if (item.InTypeOf<IfcProductRepresentation>())
            {
                meshes = productRepresentationDict[(IfcProductRepresentation)item];
            }
            else if (item.InTypeOf<IfcElement>())
            {
                var element = (IfcElement)item;        
                var objectPlacement = element.ObjectPlacement;
                Matrix4x4 globalmat;
                if (objectPlacement != null)
                {
                    globalmat = Matrix4x4.Transpose(placementToMat[(IfcLocalPlacement)objectPlacement][1]);
                }
                else
                {
                    globalmat = Matrix4x4.Identity;
                }
                if (element.Representation != null)
                {
                    List<Mesh3D> meshs = productRepresentationDict[element.Representation];
                    int j = 0;
                    foreach (var mesh in meshs)
                    {
                        var cloneMesh = new Mesh3D(mesh);
                        var vertives = cloneMesh.Vertices;
                        for (int i = 0; i < vertives.Count; i++)
                        {
                            vertives[i] = Vector3.Transform(vertives[i], globalmat);
                            //     vertives[i] += new Vector3(0, 0, 1000 * j);
                        }
                        meshes.Add(cloneMesh);
                        j++;
                    }
                }
            }
            if(meshes.Count > 0)
            {
                Mesh3D fullmesh = new Mesh3D(meshes);
                fullmesh.ReCalculateNormal();
                fullmesh.ExportToObj(filePath, true);
            }
           
        }
    }
}
