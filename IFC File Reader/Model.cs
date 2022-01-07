using System;
using System.Collections.Generic;
using System.Linq;
namespace IFC4
{
    public class Model
    {
      
        IfcDict instances;
        public Model()
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
