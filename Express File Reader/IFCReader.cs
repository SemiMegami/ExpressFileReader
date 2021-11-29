using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace IFC4
{
    class IFCReader
    {
        public static void Read( string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {

            }
        }

        static List<string> ExtractsProperties(string input)
        {
            List<string> inputs = new List<string>();

            int bracketCount = 0;

            var charArr = input.ToCharArray();

            string inputText = "";
            bool started = false;
            for(int i = 0; i < charArr.Length; i++)
            {
                var c = charArr[i];

                switch (c)
                {
                    case '(':
                        bracketCount++;
                        break;
                    case ')':
                        bracketCount--;
                        break;
                    default:
                        if(bracketCount > 0)
                        {

                        }
                        break;
                }
            }



            return inputs;
        }
    }
}
