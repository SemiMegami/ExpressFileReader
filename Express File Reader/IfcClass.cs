using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFCReader
{

    public class IFCClass
    {
        public string name;
        public string subOf;
        public List<string> interfaces; // interface
        public Dictionary<string, string> propElement;
        public Dictionary<string, string> consElement; // inout element in ifc files
        public Dictionary<string, string> fullConsElement; // inout element in ifc files including super class

        public List<string> enumElements;
        public List<string> selectElements;
        public string dataType; // interface enum or class
        public bool isAbstract;

        public IFCClass(string dataType, string name, string subOf = "")
        {
            interfaces = new List<string>();
            propElement = new Dictionary<string, string>();
            consElement = new Dictionary<string, string>();
            fullConsElement = new Dictionary<string, string>();
            enumElements = new List<string>();
            selectElements = new List<string>();
            this.dataType = dataType;
            this.name = name;
            isAbstract = false;

            this.subOf = subOf;

        }


        public Dictionary<string, string> GetFullCons(Dictionary<string, IFCClass> IFCClasses)
        {
            Dictionary<string, string> fullCons = new Dictionary<string, string>();

            if (IFCClasses.ContainsKey(subOf))
            {
                var superClass = IFCClasses[subOf];
                Dictionary<string, string> superfullCons = superClass.GetFullCons(IFCClasses);
                foreach (var s in superfullCons)
                {
                    fullCons.Add(s.Key, s.Value);
                }
            }

            foreach(var c in consElement)
            {
                fullCons.Add(c.Key, c.Value);
            }
            fullConsElement = fullCons;
            return fullCons;
        }

        public override string ToString()
        {
            string str = "\tpublic " + (isAbstract ? "abstract " : "") + (dataType == "interface" ? dataType : "class") + " " + name;
            if (subOf.Length > 0)
            {
                str += " : " + subOf;
            }

            if (interfaces.Count > 0)
            {
                for (int i = 0; i < interfaces.Count; i++)
                {
                    if (i == 0)
                    {
                        str += subOf.Length > 0 ? ", " : " : ";
                    }

                    str += interfaces[i];
                    if (i < interfaces.Count - 1)
                    {
                        str += ", ";
                    }
                }
            }
            str += "\n\t{\n";

            /// show list of ifc prop
            int count = 1;
            foreach (var f in fullConsElement)
            {
                str += "\t\t//" + count + "\t" + f.Key + " : " + f.Value + "\n";
                count++;
            }
            if(fullConsElement.Count > 0)
            {
                str += "\n";
            }


            switch (dataType)
            {
                case "class":
                case "struct":
                    // case "interface":
                    foreach (var ce in propElement)
                    {

                        if (ce.Key.Contains("{"))
                        {
                            str += "\t\tpublic " + ce.Value + " " + ce.Key + "\n";
                        }
                        else
                        {
                            str += "\t\tpublic " + ce.Value + " " + ce.Key + " {get;set;}\n";
                        }
                    }
                    if (propElement.Count > 0)
                    {
                        str += "\n";
                    }
                    str += "\t\tpublic " + name + "(){}\n";
                   

                    if(fullConsElement.Count > 0)
                    {
                        str += "\n";
                        str += "\t\tpublic " + name + "(";

                        var keys = fullConsElement.Keys.ToList();
                        for(int i = 0; i < fullConsElement.Count; i++)
                        {
                            str += fullConsElement[keys[i]] + " " + keys[i];
                            if(i < fullConsElement.Count - 1)
                            {
                                str += ",";
                            }  
                        }
                        str += "){\n";
                        foreach (var k in keys)
                        {
                            str += "\t\t\tthis." + k + " = " + k + ";\n";
                        }

                       

                        str += "\t\t}\n";
                    }
                   
                    break;
                case "interface":
                    foreach (var ce in propElement)
                    {
                        str += "\t\t" + ce.Value + " Get" + ce.Key + "();\n";
                    }
                    break;

                case "enum":
                    for (int i = 0; i < enumElements.Count; i++)
                    {
                        str += "\t\tpublic const string " + enumElements[i] + " = \"" + enumElements[i] + "\";\n";
                    }
                    break;
                  
            }
            str += "\t}\n";

            return str;
        }
    }

}
