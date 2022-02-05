using System.Collections;
using System.Collections.Generic;

using System.Xml;
using System.Xml.Serialization;
using System.Numerics;
using System;
using System.IO;

namespace OSM_File_Reader
{
    [XmlRoot("osm")]
    public class osm
    {

        public static float earthRad = 6371000;
        [XmlAttribute("version")]
        public string version;
        [XmlAttribute("generator")]
        public string generator;
        [XmlAttribute("copyright")]
        public string copyright;
        [XmlAttribute("attribution")]
        public string attribution;
        [XmlAttribute("license")]
        public string license;

        public bounds bounds { get; set; }

        [XmlElement]
        public List<node> node { get; set; }

        [XmlElement]
        public List<way> way { get; set; }

        [XmlElement]
        public List<relation> relation { get; set; }

        public Dictionary<long, node> GetNodeDict()
        {
            Dictionary<long, node> dict = new Dictionary<long, node>();

            foreach (var n in node)
            {
                dict.Add(n.id, n);
            }
            return dict;
        }

        public static Vector2 GetXYfromLatLon(double lat, double lon, double lat0 = 0, double lon0 = 0)
        {
            var latR = (lat - lat0) * Math.PI / 180;
            var lonR = (lon - lon0) * Math.PI / 180;
            return new Vector2((float)(lonR * earthRad * Math.Cos(latR)), (float)(latR * earthRad));
        }

        public void ImportXML(string path)
        {
            var serializer = new XmlSerializer(typeof(osm));
            var stream = new FileStream(path, FileMode.Open);

            osm osm = serializer.Deserialize(stream) as osm;

            version = osm.version;
            generator = osm.generator;
            copyright = osm.copyright;
            attribution = osm.attribution;
            license = osm.license;
            node = osm.node;
            way = osm.way;
            bounds = osm.bounds;
            relation = osm.relation;
            stream.Close();

        }
    }

    public class bounds
    {
        [XmlAttribute("minlat")]
        public double minlat { get; set; }
        [XmlAttribute("minlon")]
        public double minlon { get; set; }
        [XmlAttribute("maxlat")]
        public double maxlat { get; set; }
        [XmlAttribute("maxlon")]
        public double maxlon { get; set; }
    }

    public class element
    {
        [XmlAttribute("id")]
        public long id { get; set; }

        [XmlAttribute("visible")]
        public bool visible { get; set; }

        [XmlAttribute("version")]
        public int version { get; set; }

        [XmlAttribute("changeset")]
        public int changeset { get; set; }

        [XmlAttribute("timestamp")]
        public string timestamp { get; set; }

        [XmlAttribute("user")]
        public string user { get; set; }

        [XmlAttribute("uid")]
        public int uid { get; set; }

        [XmlElement]
        public List<tag> tag { get; set; }

        public string GetTagValue(string tag)
        {
            if (tag == null)
            {
                return null;
            }
            else
            {
                var found = this.tag.Find(t => t.k == tag);
                if (found != null)
                {
                    return found.v;
                }
                else
                {
                    return null;
                }

            }

        }

    }

    public class node : element
    {
        [XmlAttribute("lat")]
        public double lat { get; set; }

        [XmlAttribute("lon")]
        public double lon { get; set; }



    }

    public class way : element
    {
        [XmlElement]
        public List<nd> nd { get; set; }

        public List<node> GetNodes(Dictionary<long, node> nodedict)
        {
            List<node> nodes = new List<node>();

            foreach (var n in nd)
            {
                nodes.Add(nodedict[n.@ref]);
            }
            return nodes;
        }
    }


    public class relation : element
    {
        [XmlElement]
        public List<member> member { get; set; }
    }
    public class tag
    {
        [XmlAttribute("k")]
        public string k { get; set; }

        [XmlAttribute("v")]
        public string v { get; set; }

        public override string ToString()
        {
            return k + " : \t" + v;
        }
    }

    public class nd
    {
        [XmlAttribute("ref")]
        public long @ref { get; set; }

    }
    public class member
    {
        [XmlAttribute("type")]
        public string @type { get; set; }

        [XmlAttribute("ref")]
        public long @ref { get; set; }

        [XmlAttribute("role")]
        public string role { get; set; }
    }
}

