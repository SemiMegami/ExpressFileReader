using System;
using System.Collections.Generic;
namespace IFC4
{
    public class IfcModel:List<IfcBase>
    {
        public IfcModel()
        {
            
        }
        public void ImportIFC(string path)
        {
            Clear();
            IfcDict dict = new IfcDict();
            dict.ImportIFC(path);
            AddRange(dict.Values);
        }
    }
}
