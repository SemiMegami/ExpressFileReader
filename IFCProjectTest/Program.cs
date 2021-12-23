using System;
using IFC4;
using ThreeDMaker.Geometry;
using IFC_Geometry;
using System.Collections.Generic;
using System.Linq;

namespace IFCProjectTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            TestLoadProject();
        }



        static void TestLoadProject()
        {
            IfcModel model = new IfcModel();
          //  model.ImportIFC("../../../../../Open IFC Model/20160125WestRiverSide Hospital - IFC4-Autodesk_Hospital_Metric_Structural.ifc");
            model.ImportIFC("../../../../../Open IFC Model/20160125Autodesk_Hospital_Parking Garage_2015 - IFC4.ifc");
            var elements = model.GetInstances<IfcArbitraryClosedProfileDef>() ;
          foreach (var e in elements)
            {
                ProfileDef profileDef = ProfileDefMaker.GetProfileDef( e);
            }

        }
    }
}
