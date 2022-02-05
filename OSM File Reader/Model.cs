using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using System.Numerics;
using System.IO;

namespace OSM_File_Reader
{


    public class Model
    {


        public osm osm { get; private set; }
        // Start is called before the first frame update


        public void ImportXML(string path)
        {
            var serializer = new XmlSerializer(typeof(osm));
            var stream = new FileStream(path, FileMode.Open);

            osm = serializer.Deserialize(stream) as osm;
            stream.Close();

        }
    }
}