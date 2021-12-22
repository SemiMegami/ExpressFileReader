using IFCReader;
using System;


namespace Express_File_Reader
{
    class Program
    {
        static void Main(string[] args)
        {
            ExpToIfc.CreateClassFromExpress("ifc4-add2-tc1/IFC4.exp", "IFC4.txt");
          //  ExpToIfc.CreateEnumClassFromExpress("ifc4-add2-tc1/IFC4.exp", "IFC4Enum.txt");
            // ExpToIfc.CreateStringCastterFromExpress("ifc4-add2-tc1/IFC4.exp", "IFC4StringCast.txt");
            // ExpToIfc.CreateNumericCastterFromExpress("ifc4-add2-tc1/IFC4.exp", "IFC4NumericCast.txt");
            //   ExpToIfc.CreateIfcCorrectDimensionTextFromExpress("ifc4-add2-tc1/IFC4.exp", "IfcCorrectDimensionText.txt");

            //   ExpToIfc.CreateIfcDimensionsForSiUnit("ifc4-add2-tc1/IFC4.exp", "IfcDimensionsForSiUnit.txt");
            //   ExpToIfc.CreateEnumCastterFromExpress("ifc4-add2-tc1/IFC4.exp", "IFC4EnumCast.txt");
        }

    }
}
