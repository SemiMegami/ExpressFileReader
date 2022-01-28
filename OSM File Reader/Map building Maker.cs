using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Numerics;

namespace OSM_File_Reader {
    public class MapbuildingMaker
    {
        public way way;

        public double lat0;
        public double lon0;
        public List<node> nodes;

        public bool generated = true;
 

        public void GenerataMapObjects()
        {
            List<Vector2> line = new List<Vector2>();
            for (int i = nodes.Count - 1; i > 0; i--)
            {
                line.Add(osm.GetXYfromLatLon(nodes[i].lat, nodes[i].lon, lat0, lon0));
            }

            // check tag
            var buildingType = way.GetTagValue("building");

            if (buildingType != null)
            {
                float h = 6;
                var levels = way.GetTagValue("building:levels");

                if (levels != null && float.TryParse(levels, out float result))
                {
                    h = 3 * result;
                }
            }


            generated = true;


        }
    }
}
