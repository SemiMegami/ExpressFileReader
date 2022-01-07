﻿using System;
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
            testHole();
       //     TestLoadProject("20190104WestRiverSide Hospital - IFC4-Autodesk_Hospital_Metric_Architecture");
            //  TestLoadProject("20160125Autodesk_Hospital_Parking Garage_2015 - IFC4");
        //    TestLoadProject("20210219Architecture");
        }

        static void testHole()
        {
            Random ran = new Random();

            float routter = 50;
            float rrinner = 5;

            for(int outterside = 4; outterside < 8; outterside++)
            {
                for (int innerside = 4; innerside < 8; innerside++)
                {
                    for(int s = 0; s < 360; s+= 45)
                    {
                       

                        List<Vector2> outter = new List<Vector2>();
                        float dANgle = 360f / outterside;
                        for(int i = 0; i < outterside; i++)
                        {
                            double angle = (dANgle * i + s) * Math.PI / 180;
                            outter.Add(new Vector2(routter * (float)Math.Cos(angle), routter * (float)Math.Sin(angle)));
                        }
                        dANgle = 360f / innerside;

                        
                        List<List<Vector2>> inners = new List<List<Vector2>>();
                        for(int j = -1; j <=1; j++)
                        {
                            for (int k= -1; k <= 1; k++)
                            {
                                List<Vector2> inner = new List<Vector2>();
                                for (int i = 0; i < innerside; i++)
                                {
                                    double angle = -(dANgle * i) * Math.PI / 180;
                                    inner.Add(new Vector2(3 * rrinner * j + rrinner * (float)Math.Cos(angle), 3 * rrinner * k + rrinner * (float)Math.Sin(angle)));
                                }
                                inners.Add(inner);
                            }
                        }
                       


                     
                        OutlineMesh mesh = new OutlineMesh(outter, inners);
                        mesh.ExportToObj("../../../../../Hole Test/polygon_" + outterside + "_" + innerside + "_" + + s + ".obj");
                    }
                }
            }
        }

        static void TestLoadProject(string filename)
        {
          //  string filename = "20181220Holter_Tower_10";
            // string filename = "20190104WestRiverSide Hospital - IFC4-Autodesk_Hospital_Metric_Architecture";
           //   string filename = "20160125WestRiverSide Hospital - IFC4-Autodesk_Hospital_Metric_Structural";
            // string filename = "20160125OTC-Conference Center - IFC4";
         //   "20160125Autodesk_Hospital_Parking Garage_2015 - IFC4"
           //        string filename = "20160125Autodesk_Hospital_Parking Garage_2015 - IFC4";

            Model model = new Model();
           model.ImportIFC("../../../../../Open IFC Model/"+ filename + ".ifc");
            //model.ImportIFC("../../../../../Open IFC Model/20160125Autodesk_Hospital_Parking Garage_2015 - IFC4.ifc");





            var elemments = model.GetInstances<IfcElement>();
            var walls = model.GetInstances<IfcWall>();
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
