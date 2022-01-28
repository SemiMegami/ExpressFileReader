using System;
using ThreeDMaker.Geometry;
using ThreeDMaker.Geometry.Dimension2;
using OSM_File_Reader;
using System.Collections.Generic;
using System.Numerics;
using System.Linq;

namespace OSM_Geometry
{
    public class MeshMaker
    {
        osm osm;
        double lat0 = 0;
        double lon0 = 0;
        Dictionary<long, node> nodeDict;
        Dictionary<long, way> wayDict;
        Dictionary<long, relation> relationDict;

        List<element> buildings;

        public MeshMaker(osm osm)
        {
            this.osm = osm;
            nodeDict = new Dictionary<long, node>();
            wayDict = new Dictionary<long, way>();
            relationDict = new Dictionary<long, relation>();
            foreach (var n in osm.node)
            {
                nodeDict.Add(n.id, n);
            }
            foreach (var n in osm.way)
            {
                wayDict.Add(n.id, n);
            }
            foreach (var n in osm.relation)
            {
                relationDict.Add(n.id, n);
            }
            ExtractData();

            lat0 = 0.5 * (osm.bounds.maxlat + osm.bounds.minlat);
            lon0 = 0.5 * (osm.bounds.maxlon + osm.bounds.minlon);
        }

        public MeshMaker(osm osm, double lat, double lon)
        {
            this.osm = osm;
            nodeDict = new Dictionary<long, node>();

            foreach (var n in osm.node)
            {
                nodeDict.Add(n.id, n);
            }
            ExtractData();

            lat0 = lat;
            lon0 = lon;
        }

        private List<Vector2> GetNodeVec(List<node> nodes, bool counterclockwise = true)
        {
            
            List<Vector2> vertices = new List<Vector2>();
            foreach(var node in nodes)
            {
                vertices.Add(osm.GetXYfromLatLon(node.lat, node.lon, lat0, lon0));
            }
            double A = 0;

            for(int i = 0; i <vertices.Count; i++)
            {
                int j = i + 1;
                if (j == vertices.Count) j = 0;
                A += vertices[i].X * vertices[j].Y - vertices[j].X * vertices[i].Y;
            }
            if ((A < 0 && counterclockwise) || (A > 0 && !counterclockwise))
            {
                List<Vector2> reverses = new List<Vector2>();
                for (int i = vertices.Count - 1; i >= 0; i--)
                {
                    reverses.Add(vertices[i]);
                }
                vertices = reverses;
            }
            if(Vector2.Distance(vertices[0], vertices.Last()) < 0.01)
            {
                vertices.RemoveAt(vertices.Count - 1);
            }
            return vertices;
        }

        public List<Vector2> GetNodeVec( way way, bool counterclockwise = true)
        {
           
            List<node> nodes = new List<node>();

            foreach (var n in way.nd)
            {
                nodes.Add(nodeDict[n.@ref]);
            }

            return GetNodeVec(nodes, counterclockwise);
        }

        void ExtractData()
        {
            var way = osm.way;
            buildings = new List<element>();
            foreach (var w in way)
            {
                var v = w.GetTagValue("building");
                if( v!= null)
                {
                    buildings.Add(w);
                }
            }
            var relation = osm.relation;
            foreach (var w in relation)
            {
                var v = w.GetTagValue("building");
                if (v != null)
                {
                    buildings.Add(w);
                }
            }
        }

        double GetHight(element element)
        {
            
            int lv = 2;
            if( int.TryParse(element.GetTagValue("level"), out lv)){
                return 3 * lv;
            }
            if (int.TryParse(element.GetTagValue("building:levels"), out lv))
            {
                return 3 * lv;
            }
            return 6;
        }

        Mesh3D GetExtrude(way way, float h, float z = 0)
        {
            var vec = GetNodeVec(way);
            Polygon2D polygon = new Polygon2D(vec);


            List<Vector3> core = new List<Vector3>()
            {
                new Vector3(0,0,z),
                new Vector3(0,0,z + h),
            };
            Path3D p = new Path3D(core);
            return new ExtrudePathMesh(polygon, p);
        }

        Mesh3D GetExtrude(relation relation, float h, float z = 0)
        {
           

            List<Vector2> outer = new List<Vector2>();

            List<List<Vector2>> inners = new List<List< Vector2 >>();

            var members = relation.member;
            foreach (var member in members)
            {
                if(member.type == "way")
                {
                    var way = wayDict[member.@ref];
                    switch (member.role)
                    {
                        case "outer":
                            outer = GetNodeVec(way);
                            break;
                        case "inner":
                            inners.Add(GetNodeVec(way, false));
                            break;
                    }
                }
            }

            Profile2D profile = new Profile2D(outer, inners);


            List<Vector3> core = new List<Vector3>()
            {
                new Vector3(0,0,z),
                new Vector3(0,0,z + h),
            };
            Path3D p = new Path3D(core);
            return new ExtrudePathMesh(profile.OutterCurve, p,profile.InnerCurves);
        }

        public Mesh3D GetBuildings()
        {
            List<Mesh3D> meshs = new List<Mesh3D>();
            double h;
            foreach(var b in buildings)
            {
                h = GetHight(b);
                if(b.GetType().Name == "way")
                {
                    meshs.Add(GetExtrude((way)b, (float) h));
                }
                else if (b.GetType().Name == "relation")
                {
                    meshs.Add(GetExtrude((relation)b, 6));
                }

            }
           
            return new Mesh3D(meshs);
        }

    }
}
