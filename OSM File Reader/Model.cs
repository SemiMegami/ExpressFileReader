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






        private IEnumerator GenerataNodeObjects(List<node> nodes)
        {
            var lat0 = 0.5 * (osm.bounds.minlat + osm.bounds.maxlat);
            var lon0 = 0.5 * (osm.bounds.minlon + osm.bounds.maxlon);
            foreach (var node in nodes)
            {
                var tag = node.GetTagValue("natural");
                if (tag != null && tag == "tree")
                {

                    var xy = osm.GetXYfromLatLon(node.lat, node.lon, lat0, lon0);

                }
                yield return null;
            }
        }
        private IEnumerator GenerataMapObjects(List<way> ways)
        {
            var lat0 = 0.5 * (osm.bounds.minlat + osm.bounds.maxlat);
            var lon0 = 0.5 * (osm.bounds.minlon + osm.bounds.maxlon);
            var nodeDicts = osm.GetNodeDict();

            string buildingType;

            List<node> nodes;
            List<Vector3> section;
            List<Vector3> core;

            foreach (var way in ways)
            {
                buildingType = way.GetTagValue("building");
                nodes = way.GetNodes(nodeDicts);


                section = new List<Vector3>();

                if (nodes.Count > 2 && buildingType != null)
                {

                    for (int i = nodes.Count - 1; i > 0; i--)
                    {
                        var xy = osm.GetXYfromLatLon(nodes[i].lat, nodes[i].lon, lat0, lon0);
                        section.Add(new Vector3(xy.X, 0, xy.Y));
                    }
                    // wayObject.name = "building " + buildingType;
                    float h = 6;
                    var levels = way.GetTagValue("building:levels");

                    if (levels != null && float.TryParse(levels, out float result))
                    {
                        h = 3 * result;
                    }


                }




                var roadTyoe = way.GetTagValue("highway");
                if (nodes.Count > 1 && roadTyoe != null)
                {
                    float w = 3;

                    core = new List<Vector3>();
                    for (int i = nodes.Count - 1; i >= 0; i--)
                    {
                        var xy = osm.GetXYfromLatLon(nodes[i].lat, nodes[i].lon, lat0, lon0);
                        core.Add(new Vector3(xy.X, 0, xy.Y));
                    }



                }



                //tree


                yield return null;
            }
        }
    }
}