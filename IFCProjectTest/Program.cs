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
            TestLoadProject("20181220Holter_Tower_10");
            TestLoadProject("20190104WestRiverSide Hospital - IFC4-Autodesk_Hospital_Metric_Architecture");
         //   TestLoadProject2();
            //TestLoadProject("AITS existing");
            //TestLoadProject("AITIS new");
            TestLoadProject("20160125WestRiverSide Hospital - IFC4-Autodesk_Hospital_Metric_Structural");
            TestLoadProject("20160125Autodesk_Hospital_Parking Garage_2015 - IFC4");
            TestLoadProject("20210219Architecture");
            //TestLoadProject("20201208DigitalHub_ARC");
            //testHole();
            //TestHole2();
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
