﻿using System;
using System.Collections.Generic;
using System.Linq;
namespace IFC4
{
    public class IfcModel
    {
      
        IfcDict instances;
        public IfcModel()
        {
            instances = new IfcDict();
        }
        public void ImportIFC(string path)
        {  
            instances.ImportIFC(path);
        }

        public List<T> GetInstances<T>()
        {
            return instances.OfType<T>().ToList();
        }
    }
}
