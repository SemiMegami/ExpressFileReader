using System;
using System.Collections.Generic;
using System.Linq;
namespace IFC4
{
    public class Ifc4
    {
      
        IfcDict instances;
        public Ifc4()
        {
            instances = new IfcDict();
        }
        public void ImportIFC(string path)
        {  
            instances.ImportIFC(path,this);
        }

        public List<T> GetInstances<T>()
        {
            return instances.Values.OfType<T>().ToList();
        }
    }
}
