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
        public Dictionary<string, string> Args;
        public Dictionary<string, string> Locals;

        public List<string> expressions;

        public string returnType;

        public IfcFunction (string name)
        {
            Args = new Dictionary<string, string>();
            Locals = new Dictionary<string, string>();
            returnType = "void";
            expressions = new List<string>();
            this.name = name;
        }

        public override string ToString()
        {
            string s = "public " + returnType + " " + name + "(";

            for (int i = 0; i < Args.Count; i++)
            {
                s += Args.Values.ToArray()[i] + " " + Args.Keys.ToArray()[i];
                if (i < Args.Count - 1)
                {
                    s += ", ";
                }
            }
            s += ")\n";
            s += "{\n";
            foreach (var l in Locals)
            {
                s += l.Value +" " + l.Key + ";\n";
            }
            if(Locals.Count > 0)
            {
                s += "\n";
            }
            foreach (var e in expressions)
            {
                s += e + "\n";
            }


            s += "}\n";
            return s;
        }
    }
}
