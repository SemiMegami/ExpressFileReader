using System;
using IFC4;
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
            model.ImportIFC("../../../../../Open IFC Model/20160125WestRiverSide Hospital - IFC4-Autodesk_Hospital_Metric_Structural.ifc");
            var elements = model.GetInstances<IfcBuildingElement>() ;

        }
    }
}
