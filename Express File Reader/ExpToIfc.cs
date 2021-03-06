using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFCReader
{

    class ExpToIfc
    {




        public static void CreateClassFromExpress(string input, string output)
        {

            Dictionary<string, IFCClass> IFCClasses = new Dictionary<string, IFCClass>();


            Dictionary<string, IfcFunction> IFCFunctions = new Dictionary<string, IfcFunction>();


            Dictionary<string, string> basicTypes = new Dictionary<string, string>()
                {
                    {"REAL","double"},
                    {"INTEGER","int"},
                    {"NUMBER","double"},
                    {"LOGICAL","bool"},
                    {"BOOLEAN","bool"},
                    {"BINARY","int"},
                    {"STRING","string"},

                };

            Dictionary<string, string> deriveMapping = DeriveMapping.GetIFC4DeriveMapping();

            using (StreamReader reader = new StreamReader(input))
            {
                string rawText;
                string[] texts;
                string[] entityTexts;
                IFCClass currentClass;
                string currentline;
                string currentrule = "";
                string className;

                while (!reader.EndOfStream)
                {
                    rawText = reader.ReadLine();
                    if (rawText.Length == 0) continue;
                    texts = rawText.Split(' ').ToArray();
                    if (texts.Length == 0) continue;
                    switch (texts[0])
                    {
                        case "TYPE":
                            className = texts[1];
                            if(className == "IfcPropertySetDefinitionSet")
                            {

                            }
                            switch (texts[3])
                            {
                                case "SET":
                                case "ARRAY":
                                case "LIST":
                                    IFCClasses.Add(texts[1].Replace(";", ""), new IFCClass("class", texts[1]));
                                    currentClass = IFCClasses.Last().Value;
                                    string listType = texts[6].Replace(";", "");
                                    string superlist = "List<" + texts[6].Replace(";", "") + ">";
                                   // currentClass.propElement.Add("Value", superlist);
                                    currentClass.allElements.Add("Value", superlist);
                                    currentClass.superclassname = superlist;

                                    
                                    string listextText = "public {1}({0} value) \n{\nClear();\nforeach (var v in value)\n{\nAdd(v);\n}\n }\n";
                                    listextText = listextText.Replace("{1}", texts[1]).Replace("{0}", superlist);
                                   
                                    //     "public static implicit operator {1}({0} x) { return new {1}(x); }\n" +
                                    //     "public static implicit operator {0}({1} x) { return x.Value; }\n";
                                    //if (basicTypes.TryGetValue(listType, out string lvalue))
                                    //{

                                    //}

                                    //    if (basicTypes.TryGetValue(listType, out string lvalue))
                                    //{
                                    //    listextText = listextText.Replace("{1}", texts[1]).Replace("{0}", "List<" + lvalue + ">");
                                    //    currentClass.extraText = listextText;
                                    //}
                                    //else
                                    //{
                                    //    listextText = listextText.Replace("{1}", texts[1]).Replace("{0}", superlist);
                                    //    
                                    //}

                                    currentClass.extraText = listextText;
                                    break;

                                case "ENUMERATION":
                                    //  IFCClasses.Add(texts[1], new IFCClass("enum", texts[1]));
                                    IFCClass enumClass = new IFCClass("enum", texts[1]);
                                    string infExtext = " private string Value;\n" +
                                        "public {1}(string value) { Value = value; }\n" +
                                        "public static implicit operator {1}(string x) { return new {1}(x); }\n" +
                                        " public static implicit operator string({1} x) { return x.Value; }\n";
                                    infExtext = infExtext.Replace("{1}", texts[1]);
                                    enumClass.extraText = infExtext;
                                    IFCClasses.Add(texts[1].Replace(";", ""), enumClass);

                                    currentClass = IFCClasses.Last().Value;
                                    while (true)
                                    {
                                        currentline = reader.ReadLine().Replace("\t", "").Replace("(", "").Replace(")", "").Replace(",", "");

                                        if (currentline != "END_TYPE;")
                                        {
                                            currentClass.enumElements.Add(currentline.Replace(";", ""));
                                        }
                                        else
                                        {
                                            break;
                                        }
                                    }

                                    break;
                                case "SELECT":
                                    IFCClass infClass = new IFCClass("interface", texts[1]);

                                    IFCClasses.Add(texts[1].Replace(";", ""), infClass);

                                    currentClass = IFCClasses.Last().Value;
                                    while (true)
                                    {
                                        currentline = reader.ReadLine().Replace("\t", "").Replace("(", "").Replace(")", "").Replace(",", "");

                                        if (currentline != "END_TYPE;")
                                        {
                                            currentClass.selectElements.Add(currentline.Replace(";", ""));
                                        }
                                        else
                                        {
                                            break;
                                        }
                                    }
                                    break;
                                default:
                                    string basictype = texts[3].Contains("STRING") ? "STRING" : texts[3].Replace(";", "");
                                    IFCClass basicClass = new IFCClass("class", texts[1], basictype);
                                    string extText = "public {1}({0} value) { Value = value; }\n" +
                                                       "public static implicit operator {1}({0} x) { return new {1}(x); }\n" +
                                                       "public static implicit operator {0}({1} x) { return x.Value; }\n";
                                    if (basicTypes.TryGetValue(basictype, out string value))
                                    {
                                        extText = extText.Replace("{1}", texts[1]).Replace("{0}", value);
                                        basicClass.extraText = extText;
                                    }

                                    IFCClasses.Add(texts[1].Replace(";", ""), basicClass);
                                    break;
                            }
                            break;


                        case "ENTITY":

                            IFCClasses.Add(texts[1].Replace(";", ""), new IFCClass("class", texts[1].Replace(";", ""), "IfcBase"));
                            currentClass = IFCClasses.Last().Value;
                            while (true)
                            {
                                currentline = reader.ReadLine();

                                entityTexts = currentline.Split(' ');

                                if (entityTexts[0] == "END_ENTITY;")
                                {
                                    currentrule = "";
                                    break;
                                }

                                if (entityTexts.Length > 1 && (entityTexts[1] == "SUPERTYPE" || entityTexts[1] == "SUBTYPE" || entityTexts[1] == "DERIVE" || entityTexts[1] == "WHERE" || entityTexts[1] == "INVERSE" || entityTexts[1] == "UNIQUE"))
                                {
                                    currentrule = entityTexts[1];
                                    if (currentrule == "SUBTYPE")
                                    {
                                      
                                        
                                            currentClass.superclassname = entityTexts[3].Replace("(", "").Replace(")", "").Replace(";", "");
                                        
                                      
                                    }
                                }


                                else if (entityTexts.Length > 1 && entityTexts[1] == "ABSTRACT")
                                {
                                    currentClass.isAbstract = true;
                                    currentrule = "SUPERTYPE";
                                }


                                else if (currentrule == "SUPERTYPE" || currentrule == "SUBTYPE" || currentrule == "INVERSE" || currentrule == "DERIVE" || currentrule == "")
                                {
                                    if (entityTexts.Length < 3) continue;
                                    if (currentrule == "" && !entityTexts[0].Contains("\t")) continue;
                                    if (currentrule == "SUPERTYPE" && !entityTexts[0].Contains("\t")) continue;
                                    if (currentrule == "DERIVE" && !entityTexts[0].Contains("\t")) continue;
                                    if (entityTexts[0].Contains("\\")) continue;

                                    int typeIndex = 2;

                                    string elementName = entityTexts[0].Replace("\t", "").Replace(",", "");


                                    string elementType = entityTexts[typeIndex].Replace(";", "").Replace(",", "");

                                    if (elementType == "OPTIONAL" || elementType == "UNIQUE")
                                    {
                                        typeIndex++;
                                        elementType = entityTexts[typeIndex].Replace(";", "").Replace(",", "");
                                    }



                                    if (entityTexts.Length > typeIndex + 3 && (elementType == "SET" || elementType == "ARRAY" || elementType == "LIST"))
                                    {

                                        typeIndex += 3;
                                        var elementType2 = entityTexts[typeIndex].Replace(";", "").Replace(",", "");

                                        if (elementType2 == "OPTIONAL" || elementType2 == "UNIQUE")
                                        {
                                            typeIndex++;
                                            elementType2 = entityTexts[typeIndex].Replace(";", "").Replace(",", "");
                                        }

                                        if (elementType2 == "SET" || elementType2 == "ARRAY" || elementType2 == "LIST")
                                        {
                                            typeIndex += 3;
                                            var elementType3 = entityTexts[typeIndex].Replace(";", "").Replace(",", "");

                                            if (elementType3 == "OPTIONAL" || elementType3 == "UNIQUE")
                                            {
                                                typeIndex++;
                                                elementType3 = entityTexts[typeIndex].Replace(";", "").Replace(",", "");
                                            }
                                            elementType = "List<List<" + elementType3 + ">>";
                                        }
                                        else
                                        {
                                            if (elementType2 == "UNIQUE")
                                            {
                                                elementType = "List<" + entityTexts[typeIndex + 1].Replace(";", "") + ">";
                                            }
                                            else
                                            {
                                                elementType = "List<" + entityTexts[typeIndex + 0].Replace(";", "") + ">";
                                            }
                                        }
                                    }

                                    if (currentrule == "DERIVE")
                                    {
                                      //  elemeentName += "=> new " + elementType + "();\n// (DERIVE)" + currentline;
                                        currentClass.deriveElements.Add(elementName, elementType);
                                        currentClass.deriveTexts.Add(elementName,currentline.Replace("\t", ""));
                                        currentClass.allElements.Add(elementName, elementType);
                                    }
                                    else if (currentrule == "INVERSE")
                                    {
                                      //  elemeentName += ";//" + entityTexts[entityTexts.Length - 1].Replace(";", "");
                                        currentClass.inverseElements.Add(elementName, elementType);
                                        currentClass.inverseText.Add(elementName, currentline.Replace("\t", ""));
                                        currentClass.allElements.Add(elementName, elementType);
                                    }
                                    else
                                    {
                                        currentClass.propElement.Add(elementName, elementType);
                                        currentClass.allElements.Add(elementName, elementType);
                                    }

                                    if (currentrule == "SUPERTYPE" || currentrule == "SUBTYPE" || currentrule == "")
                                    {
                                        currentClass.consElement.Add(elementName, elementType);
                                        if (!currentClass.allElements.ContainsKey(elementName))
                                        {
                                            currentClass.allElements.Add(elementName, elementType);
                                        }
                                    }
                                }
                                //else if (currentrule == "UNIQUE")
                                //{
                                //    for (int i = 2; i < entityTexts.Length; i++)
                                //    {
                                //        string staticName = entityTexts[i].Replace(";", "").Replace(",", "");

                                //        currentClass.propElement[staticName] = "static " + currentClass.propElement[staticName];
                                //    }
                                //    continue;
                                //}
                            }

                            break;

                        case "FUNCTION":
                            var function = new IfcFunction(texts[1]);

                            IFCFunctions.Add(texts[1], function);


                            string wholeText = "";
                            currentline = "";
                            while (!currentline.Contains("END_FUNCTION;"))
                            {
                                currentline = reader.ReadLine();
                                function.rawText += currentline + "\n";
                                wholeText += currentline;
                            }
                            wholeText = wholeText.Replace("\t", " ");

                            var spiltwhole = wholeText.Split(" ").ToList();
                            wholeText = "";
                            foreach (var ele in spiltwhole)
                            {
                                if (ele != "")
                                    wholeText += ele + " ";
                            }
                            //    function.expressions.Add("\t//" + wholeText);

                            string inout = wholeText.Substring(1, wholeText.IndexOf(")") - 1);
                            string[] inputs = inout.Split(";");
                            Dictionary<string, string> inputDict = new Dictionary<string, string>();

                            for (int i = 0; i < inputs.Length; i++)
                            {
                                string[] names = inputs[i].Substring(0, inputs[i].IndexOf(":")).Split(",");
                                string inputType = inputs[i].Substring(inputs[i].IndexOf(":") + 1);
                                for (int j = 0; j < names.Length; j++)
                                {
                                    function.Args.Add(names[j], inputType);
                                }
                            }





                            wholeText = wholeText.Substring(wholeText.IndexOf(")") + 1);
                            string outputType = wholeText.Substring(0, wholeText.IndexOf(";"));
                            outputType = outputType.Substring(outputType.IndexOf(":") + 1);
                            function.returnType = outputType;
                            wholeText = wholeText.Substring(wholeText.IndexOf(";") + 1);
                            wholeText = wholeText.Replace("END_FUNCTION;", "");

                            if (wholeText.Contains("END_LOCAL;"))
                            {
                                string[] localExpresses = wholeText.Split("END_LOCAL;");
                                string local = localExpresses[0].Replace("LOCAL", "");
                                string[] locals = local.Split(";");

                                for (int i = 0; i < locals.Length; i++)
                                {
                                    var l = locals[i];

                                    if (l.Contains(":"))
                                    {

                                        var leftright = l.Split(":");

                                        var datanames = l.Substring(0, l.IndexOf(":"));
                                        var datatype = l.Substring(l.IndexOf(":") + 1);
                                        var lefts = datanames.Split(",");
                                        if (datatype.Contains(":="))
                                        {
                                            string defaultValue = datatype.Substring(datatype.IndexOf(":") + 1);
                                            datatype = datatype.Substring(0, datatype.IndexOf(":"));
                                            for (int j = 0; j < lefts.Length; j++)
                                            {
                                                lefts[j] += defaultValue;
                                            }
                                        }

                                        for (int j = 0; j < lefts.Length; j++)
                                        {
                                            function.Locals.Add(lefts[j], datatype);
                                        }
                                    }
                                }
                                wholeText = localExpresses[1];
                                //    function.expressions.Add("\t//" + local);
                            }

                            function.expressions.Add(wholeText.Replace(";", ";\n").Replace("*)", "*)\n"));


                            //   function.expressions.Add("\treturn null;");

                            break;
                        case "":

                            break;
                        default:
                            break;
                    }

                }



                // set extratext for list type

                foreach (var ifcclass in IFCClasses.Values)
                {
                    string superName = ifcclass.superclassname;
                    
                    if (superName.Contains("List") && superName.Contains("<") && superName.Contains(">"))
                    {
                        int index1 = superName.IndexOf("<");
                        int index2 = superName.IndexOf(">");

                        var listType = superName.Substring(index1 + 1, index2 - index1 - 1);
                        var superbaseName = "";

                        if (basicTypes.ContainsKey(listType))
                        {
                            superbaseName = basicTypes[listType];
                        }
                        else if (IFCClasses.ContainsKey(listType))
                        {
                            superbaseName = IFCClasses[listType].GetbaseClassName(IFCClasses, basicTypes);
                        }
                        else
                        {
                            superbaseName = listType;
                        }
                        if (basicTypes.ContainsValue(superbaseName))
                        {
                            string listextText = "public {1}({0} value) \n{\nClear();\nforeach (var v in value)\n{\nAdd(({2}) v);\n}\n }\n"
                              +   "public static implicit operator {1}({0} x) { return new {1}(x); }\n"
                            +     "public static implicit operator {0}({1} x)\n{\n {1} y = new {1}();\nforeach (var v in x)\n{\ny.Add(v);\n}\nreturn y; }\n";


                            listextText = listextText.Replace("{1}", ifcclass.name).Replace("{0}", "List<"+ superbaseName + ">").Replace("{2}", listType);

                            ifcclass.extraText += listextText;
                        }
                    }
                    else
                    {
                        var superbaseName = ifcclass.GetbaseClassName(IFCClasses, basicTypes);
                        if (basicTypes.ContainsValue(superbaseName))
                        {
                            string extText = "public {1}({0} value) { Value = value; }\n" +
                                               "public static implicit operator {1}({0} x) { return new {1}(x); }\n" +
                                               "public static implicit operator {0}({1} x) { return x.Value; }\n";
                            extText = extText.Replace("{1}", ifcclass.name).Replace("{0}", superbaseName);
                            ifcclass.extraText = extText;
                        }
                    }
                }


                    // Set SubclassList to class

                    Dictionary<string, List<string>> SubclassLists = new Dictionary<string, List<string>>();

                foreach (var ifcclass in IFCClasses.Values)
                {
                    string superName = ifcclass.superclassname;

                    if (IFCClasses.TryGetValue(superName, out IFCClass iFCClass))
                    {
                        if (!SubclassLists.ContainsKey(superName))
                        {
                            SubclassLists.Add(superName, new List<string>());
                        }
                        SubclassLists[superName].Add(ifcclass.name);
                    }
                }

                foreach (var SubclassList in SubclassLists)
                {
                    if(SubclassList.Value.Count > 0)
                    {
                        var ifcclass = IFCClasses[SubclassList.Key];
                        ifcclass.subclasses = SubclassList.Value;
                    }
                }




              



                void GetSubNames(List<string> results, string name)
                {
                    if (IFCClasses.TryGetValue(name, out IFCClass iFCClass))
                    {
                        results.Add(name);
                        if (SubclassLists.TryGetValue(name, out List<string> subs))
                        {
                            foreach (var sub in subs)
                            {
                                GetSubNames(results, sub);
                            }
                        }
                    }

                }



              


                void AddChildrenToSelectElement(IFCClass itf, IFCClass cls)
                {
                    var children = cls.subclasses;
                    foreach (var child in children) { 

                        if (!itf.selectElements.Contains(child))
                        {
                            itf.selectElements.Add(child);
                        }
                        
                        AddChildrenToSelectElement(itf, IFCClasses[child]);
                    }
                }

              
                foreach (var cls in IFCClasses)
                {
                    if (cls.Value.dataType == "class")
                    {
                        cls.Value.fullAllElements = cls.Value.GetFullAlls(IFCClasses);
                    }

                }

                foreach (var cls in IFCClasses)
                {
                    if (cls.Value.dataType == "interface")
                    {

                        var interfaceClass = cls.Value;
                        var children = interfaceClass.selectElements.ToList();
                       
                        foreach (var child in children)
                        {
                            AddChildrenToSelectElement(interfaceClass, IFCClasses[child]);
                        }
                    }

                }

                // interface

                Dictionary<string, string> candidateElements;
               
                List<IFCClass> childrenClass;
                foreach (var cls in IFCClasses)
                {
                    if (cls.Value.dataType == "interface")
                    {

                        var interfaceClass = cls.Value;

                        candidateElements = new Dictionary<string, string>();
                     
                        childrenClass = new List<IFCClass>();
                        var selecteds = interfaceClass.selectElements;

                        foreach (var selected in selecteds)
                        {
                            List<string> allClasses = new List<string>(); // class including all childrens
                            GetSubNames(allClasses, selected);


                            foreach (var ac in allClasses)
                            {
                                var selectedclass = IFCClasses[ac];

                                if (childrenClass.Contains(selectedclass))
                                {
                                    continue;
                                }
                                childrenClass.Add(selectedclass);
                                selectedclass.interfaces.Add(interfaceClass.name);
                                var eles = selectedclass.fullAllElements;
                                foreach (var e in eles)
                                {
                                    if (!e.Key.Contains("(") && !candidateElements.ContainsKey(e.Key))
                                    {
                                        candidateElements.Add(e.Key, e.Value);
                                    }
                                }
                            }
                        }
                        foreach (var candidate in candidateElements)
                        {
                            bool forAll = true;
                            foreach (var childClass in childrenClass)
                            {
                                if(childClass.isAbstract) continue;
                                if (!childClass.fullAllElements.ContainsKey(candidate.Key))
                                {
                                    forAll = false;
                                    break;
                                }
                                else if (childClass.fullAllElements[candidate.Key] != candidate.Value)
                                {
                                    forAll = false;
                                    break;
                                }
                            }

                            if (forAll)
                            {
                               
                                interfaceClass.propElement.Add(candidate.Key, candidate.Value);
                                foreach (var childClass in childrenClass)
                                {
                                    var newKey = "Get" + candidate.Key + "(){return " + candidate.Key + "; }";
                                    if (!childClass.getElements.ContainsKey(newKey))
                                    {
                                        childClass.getElements.Add(newKey, candidate.Value);
                                    }
                                }
                            }
                        }
                    }
                    if (cls.Value.dataType == "class")
                    {
                        cls.Value.GetFullCons(IFCClasses);
                    }
                }

                foreach (var cls in IFCClasses)
                {
                    cls.Value.CleanGetElement(IFCClasses);
                }







                void CreateSeperateClassFile(string name, string codeText)
                {
                    using (StreamWriter writer = new StreamWriter(name + " ClassList.txt"))
                    {

                        List<string> GeometricRepresentationItemName = new List<string>();
                        GetSubNames(GeometricRepresentationItemName, name);

                        foreach (var g in GeometricRepresentationItemName)
                        {
                            if (!IFCClasses[g].isAbstract)
                            {
                                writer.WriteLine("//https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcgeometryresource/lexical/{0}.htm".Replace("{0}", g.ToLower()));
                                writer.WriteLine(codeText.Replace("{0}", g).Replace("{1}", g.Replace("Ifc", "").Replace("{2}", g.ToLower())));
                                //  writer.WriteLine(IFCClasses[g]);
                            }

                        }
                    }
                }

                CreateSeperateClassFile("IfcCurve", "public static List<Vector3> GetCurve({0} {1})\n{\n List<Vector3> points = new List<Vector3>();\n return points;\n}\n");

                CreateSeperateClassFile("IfcSolidModel", "public static Mesh GetSolid({0} {1})\n{\n Mesh mesh = new Mesh();\n return mesh;\n}\n");

                CreateSeperateClassFile("IfcProfileDef", "public static List<Vector3> GetCurve({0} {1})\n{\n List<Vector3> points = new List<Vector3>();\n return points;\n}\n");

                CreateSeperateClassFile("IfcSurface", "public static Mesh GetSurface({0} {1})\n{\n Mesh mesh = new Mesh();\n return mesh;\n}\n");





                using (StreamWriter writer = new StreamWriter(output))
                {
                    writer.WriteLine("using System;");
                    writer.WriteLine("using System.Linq;");
                    writer.WriteLine("using System.Collections.Generic;");
                    
                    writer.WriteLine("namespace IFC4");
                    writer.WriteLine("{");
                    foreach (var cls in IFCClasses)
                    {
                        cls.Value.SetString(IFCClasses);
                        string text = cls.Value.ToString();
                        //  Console.WriteLine("sss");
                        //   Console.WriteLine(text.Length);
                        Console.WriteLine(text);
                        writer.WriteLine(text);
                    }
                    writer.WriteLine("}");
                    writer.Close();
                }

                using (StreamWriter writer = new StreamWriter("FIC4Functions.txt"))
                {

                    foreach (var func in IFCFunctions)
                    {
                        Console.WriteLine(func.Value);
                        writer.WriteLine(func.Value);
                    }

                }

                // output
                using (StreamWriter writer = new StreamWriter("IFC4CreateFunction.txt"))
                {
                    writer.WriteLine("switch (name)");
                    writer.WriteLine("{");


                    foreach (var cls in IFCClasses)
                    {
                        if ((!cls.Value.isAbstract && cls.Value.dataType == "class"))
                        {
                            writer.WriteLine("case \"" + cls.Value.name.ToUpper() + "\" :");
                            writer.WriteLine("return new " + cls.Value.name + "();");
                        }

                    }

                    writer.WriteLine("default :");
                    writer.WriteLine("return null;");
                    writer.WriteLine("}");

                    writer.Close();
                }

                using (StreamWriter writer = new StreamWriter("IFC4CreateListFunction.txt"))
                {

                    writer.WriteLine("switch (name)");
                    writer.WriteLine("{");


                    foreach (var cls in IFCClasses)
                    {

                        writer.WriteLine("case \"" + cls.Value.name + "\" :");
                        writer.WriteLine("return new List<" + cls.Value.name + ">();");


                    }

                    writer.WriteLine("default :");
                    writer.WriteLine("return null;");
                    writer.WriteLine("}");

                    writer.Close();
                }





                reader.Close();
            }
        }




        public static void CreateStringCastterFromExpress(string input, string output)
        {
            Dictionary<string, string> basicTypes = new Dictionary<string, string>()
                {
                    {"REAL","double"},
                    {"INTEGER","int"},
                    {"NUMBER","double"},
                    {"LOGICAL","bool"},
                    {"BOOLEAN","bool"},
                    {"BINARY","int"},
                    {"STRING","string"},

                };


            using (StreamReader reader = new StreamReader(input))
            {
                string rawText;
                string[] texts;
                string results = "";
                string className;



                //try
                //{
                while (!reader.EndOfStream)
                {
                    rawText = reader.ReadLine();
                    if (rawText.Length == 0) continue;
                    texts = rawText.Split(' ').ToArray();
                    if (texts.Length == 0) continue;
                    switch (texts[0])
                    {
                        case "TYPE":
                            className = texts[1];

                            switch (texts[3])
                            {
                                case "SET":
                                case "ARRAY":
                                case "LIST":

                                case "ENUMERATION":

                                case "SELECT":

                                default:
                                    string basictype = texts[3].Contains("STRING") ? "STRING" : texts[3].Replace(";", "");
                                    if (basictype == "STRING")
                                    {
                                        results += " case \"" + className + "\": return (" + className + ")input.Substring(1, input.Length - 2);\n";
                                    }

                                    break;
                            }
                            break;


                    }

                }



                using (StreamWriter writer = new StreamWriter(output))
                {
                    writer.WriteLine(results);
                    writer.Close();
                }
                reader.Close();
            }
        }




        public static void CreateEnumCastterFromExpress(string input, string output)
        {
            Dictionary<string, string> basicTypes = new Dictionary<string, string>()
                {
                    {"REAL","double"},
                    {"INTEGER","int"},
                    {"NUMBER","double"},
                    {"LOGICAL","bool"},
                    {"BOOLEAN","bool"},
                    {"BINARY","int"},
                    {"STRING","string"},

                };


            using (StreamReader reader = new StreamReader(input))
            {
                string rawText;
                string[] texts;
                string results = "";
                string className;



                //try
                //{
                while (!reader.EndOfStream)
                {
                    rawText = reader.ReadLine();
                    if (rawText.Length == 0) continue;
                    texts = rawText.Split(' ').ToArray();
                    if (texts.Length == 0) continue;
                    switch (texts[0])
                    {
                        case "TYPE":
                            className = texts[1];

                            switch (texts[3])
                            {

                                case "ENUMERATION":
                                    results += " case \"" + className + "\": return (" + className + ")input.Substring(1, input.Length - 2);\n";

                                    break;
                            }
                            break;


                    }

                }



                using (StreamWriter writer = new StreamWriter(output))
                {
                    writer.WriteLine(results);
                    writer.Close();
                }
                reader.Close();
            }
        }




        public static void CreateNumericCastterFromExpress(string input, string output)
        {
            Dictionary<string, string> basicTypes = new Dictionary<string, string>()
                {
                    {"REAL","double"},
                    {"INTEGER","int"},
                    {"NUMBER","double"},
                    {"LOGICAL","bool"},
                    {"BOOLEAN","bool"},
                    {"BINARY","int"},
                    {"STRING","string"},

                };


            using (StreamReader reader = new StreamReader(input))
            {
                string rawText;
                string[] texts;
                string results = "";
                string className;



                //try
                //{
                while (!reader.EndOfStream)
                {
                    rawText = reader.ReadLine();
                    if (rawText.Length == 0) continue;
                    texts = rawText.Split(' ').ToArray();
                    if (texts.Length == 0) continue;
                    switch (texts[0])
                    {
                        case "TYPE":
                            className = texts[1];

                            switch (texts[3])
                            {
                                case "SET":
                                case "ARRAY":
                                case "LIST":

                                case "ENUMERATION":

                                case "SELECT":

                                default:
                                    string basictype = texts[3].Contains("STRING") ? "STRING" : texts[3].Replace(";", "");
                                    if (basictype != "STRING")
                                    {
                                        results += " case \"" + className + "\": return (" + className + ")numericResult;\n";
                                    }

                                    break;
                            }
                            break;


                    }

                }



                using (StreamWriter writer = new StreamWriter(output))
                {
                    writer.WriteLine(results);
                    writer.Close();
                }
                reader.Close();
            }
        }



        public static void CreateIfcCorrectDimensionTextFromExpress(string input, string output)
        {
            using (StreamReader reader = new StreamReader(input))
            {
                string rawText;
                string results = "";
                while (!reader.EndOfStream)
                {
                    rawText = reader.ReadLine();

                    if (rawText == "FUNCTION IfcCorrectDimensions")
                    {
                        while (!reader.EndOfStream)
                        {
                            rawText = reader.ReadLine();
                            if (rawText.Contains(" : IF"))
                            {
                                string dimName = rawText.Split(":")[0].Replace(" ", "");
                                rawText = reader.ReadLine();
                                int index1 = rawText.LastIndexOf("(");
                                int index2 = rawText.IndexOf(")");
                                string parameters = rawText.Substring(index1, index2 - index1 + 1);
                                results += "case IfcUnitEnum." + dimName + " : return Dim.Compare" + parameters + ";\n";
                            }
                        }
                    }
                }
                using (StreamWriter writer = new StreamWriter(output))
                {
                    writer.WriteLine(results);
                    writer.Close();
                }
                reader.Close();
            }
        }

        public static void CreateIfcDimensionsForSiUnit(string input, string output)
        {
            using (StreamReader reader = new StreamReader(input))
            {
                string rawText;
                string results = "";
                while (!reader.EndOfStream)
                {
                    rawText = reader.ReadLine();

                    if (rawText == "FUNCTION IfcDimensionsForSiUnit")
                    {
                        while (!reader.EndOfStream)
                        {
                            rawText = reader.ReadLine();
                            if (rawText.Contains("RETURN"))
                            {
                                string dimName = rawText.Split(":")[0].Replace(" ", "");
                                rawText = reader.ReadLine();
                                int index1 = rawText.LastIndexOf("(");
                                int index2 = rawText.IndexOf(")");
                                string parameters = rawText.Substring(index1, index2 - index1 + 1);
                                results += "case \"" + dimName + "\" : return new IfcDimensionalExponents" + parameters + ";\n";
                            }
                            if (rawText.Contains("END_CASE;"))
                            {
                                break;
                            }
                        }
                    }
                }
                using (StreamWriter writer = new StreamWriter(output))
                {
                    writer.WriteLine(results);
                    writer.Close();
                }
                reader.Close();
            }
        }
    }

}