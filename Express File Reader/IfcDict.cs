using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IFC4
{
    class IfcDict:Dictionary<string,IfcBase>
    {
        public void ImportIFC(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                while (!(reader.ReadLine() == "DATA;") && !reader.EndOfStream)
                {
                    // text
                }

                string ifcText;
                while (!reader.EndOfStream)
                {
                    ifcText = reader.ReadLine();
                    if (ifcText == "ENDSEC;") break;
                    ReadDataline(ifcText);


                }

            }
        }

        private void ReadDataline(string ifcText)
        {
           // Console.WriteLine(ifcText);
            string[] leftright = ifcText.Split('=');
            string key = leftright[0];
            string data = leftright[1].Substring(1);
            int nameLenght = data.IndexOf('(');
            string name = data.Substring(0, nameLenght);
            string paraText = data.Substring(nameLenght + 1, data.Length - 3 - nameLenght);
            List<string> paramList = SplitParamText(paraText);
        }

        private List<string> SplitParamText(string paramText)
        {
            List<string> outputText = new List<string>();
            int bracketCount = 0;
            bool readingString = false;
            char[] chars = paramText.ToCharArray();
            int n = chars.Length;
            char c;
            string scanningText = "";
            for (int i = 0; i < n; i++)
            {
                c = chars[i];
                if(c == '\'')
                {
                    readingString = !readingString; // toggle 
                }
                else if(!readingString && c == '(')
                {
                    if(bracketCount == 0)
                    {
                        scanningText += c;
                    }
                    bracketCount++;
                }
                else if (!readingString && c == ')')
                {
                    bracketCount--;
                    if (bracketCount == 0)
                    {
                        scanningText += c;
                    }
                }
                else if (!readingString && c == ',' && bracketCount == 0)
                {

                }
                else
                {
                    scanningText += c;
                }

                if(i == n -1 || (!readingString && c == ',' && bracketCount == 0))
                {
                    outputText.Add(scanningText);
                    scanningText = "";
                }
            }
            return outputText;
        }

        private IfcBase CreateNewInstant(string name, string paramlist)
        {
            return null;
        }
    }
}
