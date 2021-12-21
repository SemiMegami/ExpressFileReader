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
            model.ImportIFC("../../../../Open IFC Model/20160125WestRiverSide Hospital - IFC4-Autodesk_Hospital_Sprinkle.ifc");
            foreach (var item in model)
            {
                if (item.InTypeOf("IfcBase"))
                {

                }
            }
            var geo = model.Where(geo=> geo is IfcBeam) as List<IfcBeam>;
        }
    }
}
