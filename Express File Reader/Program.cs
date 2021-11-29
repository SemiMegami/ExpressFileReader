using IFCReader;
using System;

namespace Express_File_Reader
{
    class Program
    {
        static void Main(string[] args)
        {
       
         //   ExpToIfc.CreateClassFromExpress("ifc4-add2-tc1/IFC4.exp", "IFC4.txt");
            ExpToIfc.CreateClassFromExpress("IFC2X3_TC1.exp", "IFC2x3.txt");
        }
    }
}
