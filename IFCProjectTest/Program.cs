using System;
using IFC4;
using ThreeDMaker.Geometry;
using IFC_Geometry;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using IFC_Geometry.IFCGeoReader;
namespace IFCProjectTest
{
    class Program
    {
        static void Main(string[] args)
        {
        
            TestLoadProject();
        }


        static void TestLoadProject()
        {
          //  string filename = "20181220Holter_Tower_10";
            // string filename = "20190104WestRiverSide Hospital - IFC4-Autodesk_Hospital_Metric_Architecture";
            //  string filename = "20160125WestRiverSide Hospital - IFC4-Autodesk_Hospital_Metric_Structural";
            string filename = "20160125OTC-Conference Center - IFC4";
           
            IfcModel model = new IfcModel();
           model.ImportIFC("../../../../../Open IFC Model/"+ filename + ".ifc");
            //model.ImportIFC("../../../../../Open IFC Model/20160125Autodesk_Hospital_Parking Garage_2015 - IFC4.ifc");





            var elemments = model.GetInstances<IfcElement>();
            var localplacements = model.GetInstances<IfcLocalPlacement>();

            var placementToMat = IFCGeoUtil.SetGlobalMat(localplacements);

        //    var solidModels = model.GetInstances<IfcSolidModel>();

            List<Mesh3D> meshes = new List<Mesh3D>() ;
            foreach (var element in elemments)
            {

                if (element.Representation != null)
                {
                    var representations = element.Representation.Representations;

                    foreach (var representation in representations)
                    {

                        var items = representation.Items;

                        foreach (var item in items)
                        {
                            List<Mesh3D> addingMeshes = new List<Mesh3D>();
                            if (item.InTypeOf(EntityName.IFCSOLIDMODEL))
                            {
                                var solid = (IfcSolidModel)item;

                                if (solid.InTypeOf(EntityName.IFCEXTRUDEDAREASOLID))
                                {
                                    var extrude = (IfcExtrudedAreaSolid)solid;
                                    Mesh3D mesh = SolidModelMaker.GetSolid(extrude);
                                    if (mesh != null)
                                    {
                                        addingMeshes.Add(mesh);

                                    }
                                }
                            }

                            else if (item.InTypeOf(EntityName.IFCMAPPEDITEM))
                            {
                                var addings = SolidModelMaker.GetSolids((IfcMappedItem)item);
                                if (addings != null)
                                {
                                    addingMeshes.AddRange(addings);
                                }
                            }


                            var objectPlacement = element.ObjectPlacement;
                            if (objectPlacement.InTypeOf(EntityName.IFCLOCALPLACEMENT))
                            {
                                var globalmat = Matrix4x4.Transpose(placementToMat[(IfcLocalPlacement)objectPlacement][1]);
                                foreach (var mesh in addingMeshes)
                                {
                                    var vertives = mesh.Vertices;                      
                                    for (int i = 0; i < vertives.Count; i++)
                                    {
                                       // vertives[i] = IFCGeoUtil.TransformPoint(element, vertives[i]);
                                        vertives[i] = Vector3.Transform(vertives[i], globalmat);
                                    }
                                }

                            }

                            meshes.AddRange(addingMeshes);
                        }
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
            fullmesh.ExportToObj("../../../../../" + filename +".obj", true);
           
        }
    }
}
