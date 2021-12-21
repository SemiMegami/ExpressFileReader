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

        public List<IfcBase> GetInstances<T>()
        {
            string name = typeof(T).Name;
            List<IfcBase> result = new List<IfcBase>();
            foreach (var item in this)
            {
                if (item.InTypeOf(name))
                {
                    result.Add(item);
                }

            }
            return result;
        }
    }
}
