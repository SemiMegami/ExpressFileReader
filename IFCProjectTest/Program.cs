using System;
using IFC4;
using ThreeDMaker.Geometry;
using ThreeDMaker.Geometry.Dimension3;
using IFC_Geometry;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using IFC_Geometry.IFCGeoReader;
using ThreeDMaker.Geometry.Dimension2;

namespace IFCProjectTest
{
    class Program
    {
        static void Main(string[] args)
        {
           // TestPlane();
            TestMerged2();
         //   TestLoadProject("20181220Holter_Tower_10");
       //     TestLoadProject("20190104WestRiverSide Hospital - IFC4-Autodesk_Hospital_Metric_Architecture");
         //   TestLoadProject2();
            //TestLoadProject("AITS existing");
            //TestLoadProject("AITIS new");
        //    TestLoadProject("20160125WestRiverSide Hospital - IFC4-Autodesk_Hospital_Metric_Structural");
        //    TestLoadProject("20160125Autodesk_Hospital_Parking Garage_2015 - IFC4");
         //   TestLoadProject("20210219Architecture");
            //TestLoadProject("20201208DigitalHub_ARC");
            //testHole();
            //TestHole2();
        }

      

        static void TestMerged()
        {


            //Sphere sphere1 = new Sphere(10, 32);
            //Sphere sphere2 = new Sphere(10, 32, 10, 0, 0);
            //var sphereUnion = sphere1.GetUnion(sphere2);
            //sphereUnion.ExportToObj("../../../../../" + "Boolean Union sphere" + ".obj");
            //var sphereIntersect = sphere1.GetIntersection(sphere2);
            //sphereIntersect.ExportToObj("../../../../../" + "Boolean Intersect sphere" + ".obj");

            //var sphereDiff1 = sphere1.GetSubstract(sphere2);
            //sphereDiff1.ExportToObj("../../../../../" + "Boolean Difference sphere 1" + ".obj");

            //var sphereDiff2 = sphere2.GetSubstract(sphere1);
            //sphereDiff2.ExportToObj("../../../../../" + "Boolean Difference sphere 2" + ".obj");

            //List<Mesh3D> AllSpheres = new List<Mesh3D>()
            //{
            //    sphereUnion, sphereIntersect, sphereDiff1, sphereDiff2
            //};

            //for (int i = 0; i < AllSpheres.Count; i++)
            //{
            //    for (int j = 0; j < AllSpheres[i].Vertices.Count; j++)
            //    {
            //        AllSpheres[i].Vertices[j] += 30 * i * Vector3.UnitX;
            //    }
            //}
            //new Mesh3D(AllSpheres).ExportToObj("../../../../../" + "Boolean All sphere" + ".obj");
            Box box1 = new Box(10, 10, 1, 0, 0, 0);
            Box box2 = new Box(1, 1, 1f, 2.5f, -2.5f, 0);
   
   
            var intersectBox = box1.GetIntersection(box2);
            intersectBox.ExportToObj("../../../../../" + "Boolean Box Intersect" + ".obj");
            var uniontBox = box1.GetUnion(box2);
            uniontBox.ExportToObj("../../../../../" + "Boolean Box Union 1" + ".obj");
           
            var substractBox = box1.GetSubstract(box2);
            substractBox.ExportToObj("../../../../../" + "Boolean Box Substract 1" + ".obj");
            var substractBox2 = box2.GetSubstract(box1);
            substractBox2.ExportToObj("../../../../../" + "Boolean Box Substract 2" + ".obj");




            Box cube = new Box(10, 10, 10, 0, 0, 0);

            Sphere sphere3 = new Sphere(6f, 32, 0, 0, 0);
            var cs = cube.GetSubstract(sphere3);
            cs.ExportToObj("../../../../../" + "cs" + ".obj");

            var cs2 = sphere3.GetSubstract(cube);
            cs2.ExportToObj("../../../../../" + "cs2" + ".obj");

        }

        static List<Mesh3D> TestBoolean(Mesh3D mesh1, Mesh3D mesh2)
        {
            var union = mesh1.GetUnion(mesh2);
            var intersect = mesh1.GetIntersection(mesh2);
            var sub1 = mesh1.GetSubstract(mesh2);
            var sub2 = mesh2.GetSubstract(mesh1);
            return new List<Mesh3D>() { union,intersect,sub1,sub2 };
        }

        static void TestMerged2()
        {
            Mesh3D allMesh = new Mesh3D();

            Sphere sphere1 = new Sphere(10, 32);
            Sphere sphere2 = new Sphere(10, 32, 10, 0, 0);
            List<Mesh3D> AllSpheres = TestBoolean(sphere1, sphere2);
           
           

            for (int i = 0; i < AllSpheres.Count; i++)
            {
                for (int j = 0; j < AllSpheres[i].Vertices.Count; j++)
                {
                    AllSpheres[i].Vertices[j] += 30 * i * Vector3.UnitX;
                }
                allMesh.AddMesh(AllSpheres[i]);
            }
           
           





            Box cube = new Box(10, 10, 10, 0, 0, 0);

            Sphere sphere3 = new Sphere(6f, 32, 0, 0, 0);
        
            List<Mesh3D> cubespheres = TestBoolean(cube, sphere3);

            for (int i = 0; i < cubespheres.Count; i++)
            {
                for (int j = 0; j < cubespheres[i].Vertices.Count; j++)
                {
                    cubespheres[i].Vertices[j] += 30 * i * Vector3.UnitX + 30 * Vector3.UnitZ;
                }
                allMesh.AddMesh(cubespheres[i]);
            }
            allMesh.ExportToObj("../../../../../" + "Boolean All" + ".obj");

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
                       


                     
                        ProfileMesh mesh = new ProfileMesh(outter, inners);
                        mesh.ExportToObj("../../../../../Hole Test/polygon_" + outterside + "_" + innerside + "_" + + s + ".obj");
                    }
                }
            }
        }

        static void TestHole2()
        {


            float a = 1;
            float dt = 0.001f;

            for (int i = 1; i < 50; i++)
            {
                float b = a - dt * i;
                List<Vector2> outer = new List<Vector2>()
                {
                    new Vector2(-a, -a),
                    new Vector2(a, -a),
                    new Vector2(a, a),
                    new Vector2(-a, a)
                };
                List<Vector2> inner = new List<Vector2>()
                {
                    new Vector2(-b, -b),
                    new Vector2(-b, b),
                    new Vector2(b, b),
                    new Vector2(b, -b)
        };
                ProfileMesh mesh = new ProfileMesh(outer, new List<List<Vector2>>() { inner });
                mesh.ExportToObj("../../../../../Hole Test/Rect" + i  + ".obj");
            }
        }

        static void TestLoadProject(string filename)
        {
            Console.WriteLine("Loading : " + filename);
            GeoMetricModel geoMetricModel = new GeoMetricModel();
            geoMetricModel.LoadModel("../../../../../Open IFC Model/" + filename + ".ifc");
            geoMetricModel.ExportFullBuildingAsObj("../../../../../" + filename + ".obj",true);
        }

        static void TestLoadProject2()
        {
            string filename = "20190104WestRiverSide Hospital - IFC4-Autodesk_Hospital_Metric_Architecture";
            Console.WriteLine("Loading : " + filename);
            GeoMetricModel geoMetricModel = new GeoMetricModel();
            geoMetricModel.LoadModel("../../../../../Open IFC Model/" + filename + ".ifc");
            // if (element.ifcid != "#1426558") continue;
            geoMetricModel.ExportAnObjectAsObj("../../../../../" + "Test" + ".obj", "#1426558");
          
        }
    }
}
