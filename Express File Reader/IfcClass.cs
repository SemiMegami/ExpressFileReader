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
        public string superclassname;
        public List<string> subclasses;
        public List<string> interfaces; // interface
        public Dictionary<string, string> deriveElements;
        public Dictionary<string, string> inverseElements;

        public Dictionary<string, string> deriveTexts;
        public Dictionary<string, string> inverseText;

        public Dictionary<string, string> propElement; // get set
        public Dictionary<string, string> getElements; // get set
        public Dictionary<string, string> consElement; // inout element in ifc files
        public Dictionary<string, string> fullConsElement; // inout element in ifc files including super class
        public Dictionary<string, string> allElements;
        public Dictionary<string, string> fullAllElements; // inout element in ifc files including super class
        public List<string> enumElements;
        public List<string> selectElements;
        public string dataType; // interface enum or class
        public bool isAbstract;
        public string extraText;

        public IFCClass(string dataType, string name, string subOf = "")
        {
            extraText = "";
            interfaces = new List<string>();
            subclasses = new List<string>();
            propElement = new Dictionary<string, string>();
            allElements= new Dictionary<string, string>();
            getElements = new Dictionary<string, string>();
            consElement = new Dictionary<string, string>();
            fullConsElement = new Dictionary<string, string>();
            fullAllElements = new Dictionary<string, string>();
            deriveElements = new Dictionary<string, string>();

            deriveTexts = new Dictionary<string, string>();
            inverseText = new Dictionary<string, string>();

            inverseElements = new Dictionary<string, string>();
            enumElements = new List<string>();
            selectElements = new List<string>();
            this.dataType = dataType;
            this.name = name;
            isAbstract = false;

            this.superclassname = subOf;

        }


        public Dictionary<string, string> GetFullAlls(Dictionary<string, IFCClass> IFCClasses)
        {
            Dictionary<string, string> fullAll = new Dictionary<string, string>();

            if (IFCClasses.ContainsKey(superclassname))
            {
                var superClass = IFCClasses[superclassname];
                Dictionary<string, string> superfullCons = superClass.GetFullAlls(IFCClasses);
                foreach (var s in superfullCons)
                {
                    fullAll.Add(s.Key, s.Value);
                }
            }

            foreach (var c in allElements)
            {
             
                fullAll.Add(c.Key, c.Value);
            }
            fullConsElement = fullAll;
            return fullAll;
        }


        public Dictionary<string, string> GetFullCons(Dictionary<string, IFCClass> IFCClasses)
        {
            Dictionary<string, string> fullCons = new Dictionary<string, string>();

            if (IFCClasses.ContainsKey(superclassname))
            {
                var superClass = IFCClasses[superclassname];
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


        public void CleanGetElement(Dictionary<string, IFCClass> IFCClasses, string superclassname = null)
        {
            if(superclassname == null)
            {
                superclassname = this.superclassname;
            }
            if (IFCClasses.ContainsKey(superclassname))
            {
                var superClass = IFCClasses[superclassname];
                Dictionary<string, string> superElements = superClass.getElements;


                foreach (var s in superElements)
                {
                    getElements.Remove(s.Key);
                }
                CleanGetElement(IFCClasses, superClass.superclassname);
            }
        }

        public string GetbaseClassName(Dictionary<string, IFCClass> IFCClasses, Dictionary<string, string> basicTypes)
        {
            if (basicTypes.ContainsKey(name))
            {
                return basicTypes[name];
            }
            //if (superclassname == "")
            //{
            //    return name;
            //}

            if (basicTypes.ContainsKey(superclassname))
            {
                return basicTypes[superclassname];
            }
            if (IFCClasses.ContainsKey(superclassname))
            {
                return IFCClasses[superclassname].GetbaseClassName(IFCClasses, basicTypes);
            }
            return name;
        }

        public override string ToString()
        {
            Dictionary<string, string> deriveMapping = DeriveMapping.GetIFC4DeriveMapping();
            string str = "\tpublic " + (isAbstract ? "abstract " : "") + (dataType == "interface" ? dataType : "class") + " " + name;
            if (superclassname.Length > 0)
            {
                str += " : " + superclassname;
            }

            if (interfaces.Count > 0)
            {
                for (int i = 0; i < interfaces.Count; i++)
                {
                    if (i == 0)
                    {
                        str += superclassname.Length > 0 ? ", " : " : ";
                    }

                    str += interfaces[i];
                    if (i < interfaces.Count - 1)
                    {
                        str += ", ";
                    }
                }
            }
            str += "\n\t{\n";

            // show list of ifc prop
           

            //if (subclasses.Count > 0)
            //{
            //    str += "//Superclass of : ";
            //    foreach (var f in subclasses)
            //    {
            //        str += " " + f + ",";
            //    }
            //    str += "\n";
            //}
          
          

            //int count = 1;
            //if (fullConsElement.Count > 0)
            //{
            //    str += "//Property list\n";
            //}
           
            //foreach (var f in fullConsElement)
            //{
            //    str += "\t\t//" + count + "\t" + f.Key + " : " + f.Value + "\n";
            //    count++;
            //}
            //if (fullConsElement.Count > 0)
            //{
            //    str += "\n";
            //}


            switch (dataType)
            {
                case "class":
                case "struct":
                    // case "interface":
                    foreach (var ce in propElement)
                    {

                      
                        str += "\t\tpublic " + ce.Value + " " + ce.Key + " {get;set;}\n";
                        
                    }
                    foreach (var ce in deriveElements)
                    {
                        var expText = deriveTexts[ce.Key].Substring(deriveTexts[ce.Key].LastIndexOf(":") + 3);
                        if (deriveMapping.ContainsKey(expText))
                        {
                            str += "\t\tpublic " + ce.Value + " " + ce.Key +  " => " + deriveMapping[expText] + "\n";
                        }
                        else
                        {
                            str += "\t\tpublic " + ce.Value + " " + ce.Key + ";\n";
                        }
                        str += "// DERIVE : " + deriveTexts[ce.Key] + "\n";

                    }
                    foreach (var ce in inverseElements)
                    {
                        str += "\t\tpublic " + ce.Value + " " + ce.Key + ";\n// INVERSE : " + inverseText[ce.Key] + "\n";
                    }

                    foreach (var ce in getElements)
                    {
                        str += "\t\tpublic " + ce.Value + " " + ce.Key + "\n";
                    }
                    if (propElement.Count > 0)
                    {
                        str += "\n";
                    }
                    str += "\t\tpublic " + name + "(){}\n";
                   
                    //constructor
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

                    str += extraText;
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
                    str += extraText;
                    break;
                  
            }
            str += "\t}\n";

            if (superclassname.Contains("List"))
            {
                str = str.Replace("return Value", "return this");
            }
            return str;
        }
    }

}
