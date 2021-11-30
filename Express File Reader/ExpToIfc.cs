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

            IFCClasses.Add("IfcBase", new IFCClass("class", "IfcBase", "") { isAbstract = true });


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


            using (StreamReader reader = new StreamReader(input))
            {
                string rawText;
                string[] texts;
                string[] entityTexts;
                IFCClass currentClass;
                string currentline;
                string currentrule = "";
                string className;



                try
                {
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
                                        IFCClasses.Add(texts[1], new IFCClass("class", texts[1]));
                                        currentClass = IFCClasses.Last().Value;
                                        currentClass.propElement.Add("Value", "List<" + texts[6].Replace(";", "") + ">");
                                        break;

                                    case "ENUMERATION":
                                        IFCClasses.Add(texts[1], new IFCClass("enum", texts[1]));
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
                                        IFCClasses.Add(texts[1], new IFCClass("interface", texts[1]));

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
                                        if (texts[3].Contains("STRING"))
                                        {
                                            IFCClasses.Add(texts[1], new IFCClass("class", texts[1], "STRING"));

                                        }
                                        else
                                        {
                                            IFCClasses.Add(texts[1], new IFCClass("class", texts[1], texts[3].Replace(";", "")));

                                        }


                                        break;
                                }
                                break;


                            case "ENTITY":

                                IFCClasses.Add(texts[1], new IFCClass("class", texts[1].Replace(";", ""), "IfcBase"));
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
                                            currentClass.subOf = entityTexts[3].Replace("(", "").Replace(")", "").Replace(";", "");
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

                                        string elemeentName = entityTexts[0].Replace("\t", "").Replace(",", "");


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

                                        currentClass.propElement.Add(elemeentName, elementType);
                                        if(currentrule == "SUPERTYPE" || currentrule == "SUBTYPE" || currentrule == "")
                                        {
                                            currentClass.consElement.Add(elemeentName, elementType);
                                        }
                                    }
                                    else if (currentrule == "UNIQUE")
                                    {
                                        for (int i = 2; i < entityTexts.Length; i++)
                                        {
                                            string staticName = entityTexts[i].Replace(";", "").Replace(",", "");

                                            currentClass.propElement[staticName] = "static " + currentClass.propElement[staticName];
                                        }
                                        continue;
                                    }
                                }

                                break;

                            case "FUNCTION":

                                IFCFunctions.Add(texts[1], new IfcFunction(texts[1]));



                                //while (true)
                                //{
                                //    currentline = reader.ReadLine();

                                //    entityTexts = currentline.Split(' ');

                                //    if (entityTexts[0] == "END_ENTITY;")
                                //    {
                                //        currentrule = "";
                                //        break;
                                //    }
                                //}








                                    break;
                            case "":

                                break;
                            default:
                                break;
                        }

                    }

                    Dictionary<string, string> candidateElements;
                    Dictionary<string, string> commonElements;
                    List<IFCClass> childrenClass;

                    foreach (var cls in IFCClasses)
                    {
                        if (cls.Value.dataType == "interface")
                        {

                            var interfaceClass = cls.Value;

                            candidateElements = new Dictionary<string, string>();
                            commonElements = new Dictionary<string, string>();
                            childrenClass = new List<IFCClass>();
                            var children = cls.Value.selectElements;

                            foreach (var child in children)
                            {
                                if (IFCClasses.TryGetValue(child, out IFCClass childClass))
                                {
                                    childrenClass.Add(childClass);
                                    childClass.interfaces.Add(interfaceClass.name);

                                    var eles = childClass.propElement;

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
                                    if (!childClass.propElement.ContainsKey(candidate.Key))
                                    {
                                        forAll = false;
                                        break;
                                    }
                                    else if (childClass.propElement[candidate.Key] != candidate.Value)
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
                                        var newKey = "Get" + candidate.Key + "(){return  " + candidate.Key + "; }";
                                        if (!childClass.propElement.ContainsKey(newKey))
                                        {
                                            childClass.propElement.Add(newKey, candidate.Value);
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







                    using (StreamWriter writer = new StreamWriter(output))
                    {
                        writer.WriteLine("using System.Collections.Generic;");

                        writer.WriteLine("namespace IFC4");
                        writer.WriteLine("{");
                        foreach (var cls in IFCClasses)
                        {
                            Console.WriteLine(cls.Value);
                            writer.WriteLine(cls.Value);
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
                        //string name = "dummy";
                        //switch (name)
                        //{
                        //    case "IFC1":
                        //        //n
                        //        break;
                        //}

                        writer.WriteLine("switch (name)");
                        writer.WriteLine("{");


                        foreach (var cls in IFCClasses)
                        {
                            if (!cls.Value.isAbstract && cls.Value.dataType == "class")
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

                    reader.Close();
                }
                catch
                {
                    reader.Close();
                }

            }
        }
    }

}