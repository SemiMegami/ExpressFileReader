using System;
using IFC4;
using ThreeDMaker.Geometry;
using IFC_Geometry;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using IFC_Geometry.IFCGeoReader;
namespace IFC_Viewer
{
    class Controller
    {
        Model model;

        public void LoadModel(string filePath)
        {
            model = new Model();
            model.ImportIFC(filePath);

            var elemments = model.GetInstances<IfcElement>();
            var localplacements = model.GetInstances<IfcLocalPlacement>();


            var placementToMat = IFCGeoUtil.SetGlobalMat(localplacements);

            var solidModels = model.GetInstances<IfcSolidModel>();
            if (solidModels.Count == 0) return;
            Dictionary<IfcSolidModel, Mesh3D> solidDict = new Dictionary<IfcSolidModel, Mesh3D>();
            List<string> UnsupportedSolid = new List<string>();
            foreach (var solid in solidModels)
            {
                Mesh3D mesh = SolidModelMaker.GetSolid(solid);
                if (mesh.Vertices.Count == 0)
                {
                    var solidtype = solid.GetType().Name;
                    if (!UnsupportedSolid.Contains(solidtype))
                    {
                        UnsupportedSolid.Add(solidtype);
                    }
                }
                solidDict.Add(solid, mesh);
            }
            var mappedItems = model.GetInstances<IfcMappedItem>();
            Dictionary<IfcMappedItem, List<Mesh3D>> mappedDict = new Dictionary<IfcMappedItem, List<Mesh3D>>();
            foreach (var mapped in mappedItems)
            {
                mappedDict.Add(mapped, SolidModelMaker.GetSolids(mapped));
            }

            List<Mesh3D> meshes = new List<Mesh3D>();
            foreach (var element in elemments)
            {
                if (element.InTypeOf<IfcSpace>())
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
                    var representations = element.Representation.Representations;


                    foreach (var representation in representations)
                    {
                        List<Mesh3D> addingMeshes = new List<Mesh3D>();
                        var items = representation.Items;

                        foreach (var item in items)
                        {

                            if (item.InTypeOf<IfcSolidModel>())
                            {
                                addingMeshes.Add(new Mesh3D(solidDict[(IfcSolidModel)item]));
                            }

                            else if (item.InTypeOf<IfcMappedItem>())
                            {
                                addingMeshes.AddRange(mappedDict[(IfcMappedItem)item]);
                            }
                        }


                        foreach (var mesh in addingMeshes)
                        {
                            var vertives = mesh.Vertices;
                            for (int i = 0; i < vertives.Count; i++)
                            {
                                vertives[i] = Vector3.Transform(vertives[i], globalmat);
                            }
                        }
                        meshes.AddRange(addingMeshes);
                    }
                }
            }


            List<int> indices = new List<int>();
            List<Vector3> vertices = new List<Vector3>();
            int vertextCount = 0;
            foreach (var mesh in meshes)
            {
                vertices.AddRange(mesh.Vertices);
                foreach (var i in mesh.Triangles)
                {
                    indices.Add(i + vertextCount);
                }
                vertextCount = vertices.Count;
            }
            Mesh3D fullmesh = new Mesh3D()
            {
                Triangles = indices,
                Vertices = vertices
            };
            fullmesh.ReCalculateNormal();
            var fileName = filePath.Split("\\").Last().Replace(".ifc","");
            fullmesh.ExportToObj("../../../../../" + fileName + ".obj", true);

            Console.WriteLine("Unsuppported solid list:");
            foreach (var un in UnsupportedSolid)
            {
                Console.WriteLine("\t" + un);
            }
            Console.WriteLine("Finished");
        }
    }
}
