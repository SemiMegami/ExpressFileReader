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
        List<element> parkings;
        List<element> grasslands;
        List<element> highways;
        List<element> waters;
        List<element> parks;
        List<element> pitchs;

        public MeshMaker(osm osm)
        {
            this.osm = osm;
            nodeDict = new Dictionary<long, node>();
            wayDict = new Dictionary<long, way>();
            relationDict = new Dictionary<long, relation>();
            parkings = new List<element>();
            grasslands = new List<element>();
            parks = new List<element>();
            pitchs = new List<element>();
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

        public void SetLatlong(long wayid)
        {
            if(wayDict.TryGetValue(wayid, out way way))
            {
                var latlons = GetNodeLatLonVec(way);

                float x = 0;
                float y = 0;
                foreach(var latlon in latlons)
                {
                    x += latlon.X;
                    y += latlon.Y;
                }
                lat0 = x / latlons.Count;
                lon0 = y / latlons.Count;
            }
        }

        private List<Vector2> GetNodeLatLonVec(List<node> nodes, bool counterclockwise = true)
        {

            List<Vector2> vertices = new List<Vector2>();
            foreach (var node in nodes)
            {
                vertices.Add(new Vector2((float) node.lat, (float)node.lon));
            }
            double A = 0;

            for (int i = 0; i < vertices.Count; i++)
            {
                int j = i + 1;
                if (j == vertices.Count) j = 0;
                A += vertices[i].X * vertices[j].Y - vertices[j].X * vertices[i].Y;
            }
            if ((A > 0 && counterclockwise) || (A < 0 && !counterclockwise))
            {
                List<Vector2> reverses = new List<Vector2>();
                for (int i = vertices.Count - 1; i >= 0; i--)
                {
                    reverses.Add(vertices[i]);
                }
                vertices = reverses;
            }
            if (Vector2.Distance(vertices[0], vertices.Last()) < 0.01)
            {
                vertices.RemoveAt(vertices.Count - 1);
            }
            return vertices;
        }
        public List<Vector2> GetNodeLatLonVec(way way, bool counterclockwise = true)
        {

            List<node> nodes = new List<node>();

            foreach (var n in way.nd)
            {
                nodes.Add(nodeDict[n.@ref]);
            }

            return GetNodeLatLonVec(nodes, counterclockwise);
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
            highways = new List<element>(); 
            waters = new List<element>();
            foreach (var w in way)
            {
                var v = w.GetTagValue("building");
                if( v!= null)
                {
                    buildings.Add(w);
                }
                v = w.GetTagValue("highway");
                if (v != null)
                {
                    highways.Add(w);
                }
                v = w.GetTagValue("water");
                if (v != null)
                {
                    waters.Add(w);
                }
                
                v = w.GetTagValue("natural");
                if (v == "water")
                {
                    waters.Add(w);
                }
                v = w.GetTagValue("natural");
                if (v == "grassland")
                {
                    grasslands.Add(w);
                }

                v = w.GetTagValue("amenity");
                if (v == "parking")
                {
                    parkings.Add(w);
                }

                v = w.GetTagValue("leisure");
                if (v == "park")
                {
                    parks.Add(w);
                }
                if (v == "pitch")
                {
                    pitchs.Add(w);
                }
                if (v == "golf_course")
                {
                    grasslands.Add(w);
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

        double GetHighwayWidth(element element)
        {

            int lane = 1;
            if (int.TryParse(element.GetTagValue("level"), out lane))
            {
                return 3.7 * lane;
            }
            
            return 3.7 * 2;
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
        Mesh3D GetPath(way way, float w, float h=0.1f, float z = 0)
        {
            float a = w / 2;
            var vec = GetNodeVec(way);
            List<Vector3> vec3 = new List<Vector3>();

            foreach(var v in vec)
            {
                vec3.Add(new Vector3(v, 0));
            }
            Path3D p = new Path3D(vec3);

            List<Vector2> sections = new List<Vector2>();
            sections.Add(new Vector2(a, 0));
            sections.Add(new Vector2(a, h));
            sections.Add(new Vector2(-a, h));
            sections.Add(new Vector2(-a, 0));
            Polygon2D polygon = new Polygon2D(sections);


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
                    if (wayDict.TryGetValue(member.@ref, out var way))
                    {
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
                    meshs.Add(GetExtrude((relation)b, (float)h));
                }

            }
           
            return new Mesh3D(meshs);
        }
        public Mesh3D GetParkings()
        {
            List<Mesh3D> meshs = new List<Mesh3D>();
            double h;
            foreach (var b in parkings)
            {
                h = GetHight(b);
                if (b.GetType().Name == "way")
                {
                    meshs.Add(GetExtrude((way)b, 0.1f));
                }
                else if (b.GetType().Name == "relation")
                {
                    meshs.Add(GetExtrude((relation)b, 0.1f));
                }

            }

            return new Mesh3D(meshs);
        }

        public Mesh3D GetPitch()
        {
            List<Mesh3D> meshs = new List<Mesh3D>();
            double h;
            foreach (var b in pitchs)
            {
                h = GetHight(b);
                if (b.GetType().Name == "way")
                {
                    meshs.Add(GetExtrude((way)b, 0.1f));
                }
                else if (b.GetType().Name == "relation")
                {
                    meshs.Add(GetExtrude((relation)b, 0.1f));
                }

            }

            return new Mesh3D(meshs);
        }

        public Mesh3D GetParks()
        {
            List<Mesh3D> meshs = new List<Mesh3D>();
            double h;
            foreach (var b in parks)
            {
                h = GetHight(b);
                if (b.GetType().Name == "way")
                {
                    meshs.Add(GetExtrude((way)b, 0.05f));
                }
                else if (b.GetType().Name == "relation")
                {
                    meshs.Add(GetExtrude((relation)b, 0.05f));
                }

            }

            return new Mesh3D(meshs);
        }

        public Mesh3D GetGrasslands()
        {
            List<Mesh3D> meshs = new List<Mesh3D>();
            double h;
            foreach (var b in grasslands)
            {
                h = GetHight(b);
                if (b.GetType().Name == "way")
                {
                    meshs.Add(GetExtrude((way)b, 0.05f));
                }
                else if (b.GetType().Name == "relation")
                {
                    meshs.Add(GetExtrude((relation)b, 0.05f));
                }

            }

            return new Mesh3D(meshs);
        }

        public Mesh3D GetRoad()
        {
            List<Mesh3D> meshs = new List<Mesh3D>();
            double h;
            foreach (var b in highways)
            {
            
              //  h = GetHight(b);
                if (b.GetType().Name == "way")
                {
                    h = GetHighwayWidth(b);
                    meshs.Add(GetPath((way)b, (float)h));
                }
                //else if (b.GetType().Name == "relation")
                //{
                //    meshs.Add(GetExtrude((relation)b, (float)h));
                //}

            }

            return new Mesh3D(meshs);
        }

        public Mesh3D GetWater()
        {
            List<Mesh3D> meshs = new List<Mesh3D>();
            double h;
            foreach (var b in waters)
            {
                h = GetHight(b);
                if (b.GetType().Name == "way")
                {
                    meshs.Add(GetExtrude((way)b, 0.2f, - 0.2f));
                }
                else if (b.GetType().Name == "relation")
                {
                    meshs.Add(GetExtrude((relation)b, 0.2f, -0.2f));
                }

            }

            return new Mesh3D(meshs);
        }

    }
}
