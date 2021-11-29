using IFCReader;
using System;

using IFC4;
namespace Express_File_Reader
{
    class Program
    {
        static void Main(string[] args)
        {


            new IfcDict().ImportIFC("Open IFC Model/20190104WestRiverSide Hospital - IFC4-Autodesk_Hospital_Metric_Architecture.ifc");
         //   ExpToIfc.CreateClassFromExpress("ifc4-add2-tc1/IFC4.exp", "IFC4.txt");


           // ExpToIfc.CreateClassFromExpress("IFC2X3_TC1.exp", "IFC2x3.txt");
        }
    }
}
