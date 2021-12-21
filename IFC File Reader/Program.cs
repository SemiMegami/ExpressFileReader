using System;
using IFC4;
namespace IFC_File_Reader
{
    class Program
    {
        static void Main(string[] args)
        {
            

            IfcDict IFC = new IfcDict();

           // IFC.ImportIFC("Open IFC Model/20190104WestRiverSide Hospital - IFC4-Autodesk_Hospital_Metric_Architecture.ifc");
           // IFC.ImportIFC("Open IFC Model/20181220Holter_Tower_10.ifc");
            IFC.ImportIFC("../../../../../Open IFC Model/20160125WestRiverSide Hospital - IFC4-Autodesk_Hospital_Sprinkle.ifc");
        }
    }
}
