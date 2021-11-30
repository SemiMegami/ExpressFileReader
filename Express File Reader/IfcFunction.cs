using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFCReader
{
    class IfcFunction
    {
        public string name;
        Dictionary<string, string> Args;
        Dictionary<string, string> Locals;

        List<string> expressions;

        public string returnType;
        public string returnValue;

        public IfcFunction (string name)
        {
            Args = new Dictionary<string, string>();
            returnType = "void";
            this.name = name;
        }

        public override string ToString()
        {
            string s = "public " + returnType + " " + name + "(";

            for(int i =0; i < Args.Count; i++)
            {
                s += Args.Values + " " + Args.Keys;
                if(i < Args.Count - 1)
                {
                    s += ", ";
                }
            }
            s += ")\n";
            s += "{\n";




            if(returnType != "void")
            {
                s += "\treturn " + returnValue + ";\n";
            }
            s += "}\n";
            return s;
        }
    }
}
