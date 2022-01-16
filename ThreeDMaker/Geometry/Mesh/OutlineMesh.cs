using System;
using System.Collections.Generic;
using System.Numerics;
using ThreeDMaker.Geometry.Dimension2;
namespace ThreeDMaker.Geometry
{
    public class OutlineMesh:Mesh3D
    {


        public OutlineMesh(Shape2D section)
        {
            Vertices.Clear();
            foreach (var s in section.points)
            {
                Vertices.Add(new Vector3(s,0));
            }
            Triangles = Mesh2DGeometryUtil.EarClippingAlgorithm(section.points);
        }

        public OutlineMesh(List<Vector2> section)
        {
            Vertices.Clear();
            foreach (var s in section)
            {
                Vertices.Add(new Vector3(s, 0));
            }
            Triangles = Mesh2DGeometryUtil.EarClippingAlgorithm(section);
        }

        public OutlineMesh(List<Vector2> section, List<Vector2> hole)
        {
            var v2 = GetMergedVertices(section, new List< List<Vector2>>() { hole});
            Vertices.Clear();
            foreach (var s in v2)
            {
                Vertices.Add(new Vector3(s, 0));
            }
            Triangles = Mesh2DGeometryUtil.EarClippingAlgorithm(v2);
        }
        public OutlineMesh(List<Vector2> section, List<List<Vector2>> hole)
        {
            var v2 = GetMergedVertices(section, hole );
            Vertices.Clear();
            foreach (var s in v2)
            {
                Vertices.Add(new Vector3(s, 0));
            }
            Triangles = Mesh2DGeometryUtil.EarClippingAlgorithm(v2);
            ReCalculateNormal();
          
        }


        public OutlineMesh(List<Vector3> section)
        {// they shold be the same plan
            Vertices.Clear();
            Vertices.AddRange(section);
            Triangles.Clear();
            if (section.Count == 3)
            {
                Triangles.Add(0);
                Triangles.Add(1);
                Triangles.Add(2);
            }
            if (section.Count == 4)
            {
                Triangles.Add(0);
                Triangles.Add(1);
                Triangles.Add(2);

                Triangles.Add(0);
                Triangles.Add(2);
                Triangles.Add(3);

            }
            else
            {
                // get normal vector
                Vector3 n = Vector3.Zero;
                for(int i = 0; i < section.Count - 1; i++)
                {
                    n += Vector3.Cross(section[i], section[i + 1]);
                }
                n = Vector3.Normalize(n);

                Vector3 a;
                Vector3 b;
                if(n.X == 0 && n.Y == 0)
                {
                    a = new Vector3(1, 0, 0);
                }
                else
                {
                    a = Vector3.Normalize(Vector3.Cross(Vector3.UnitZ, n));
                }
                b = Vector3.Cross(n, a);

                List<Vector2> progs = new List<Vector2>();

                foreach (var v in section)
                {
                    progs.Add(new Vector2(Vector3.Dot(v, a), Vector3.Dot(v, b)));
                }


                OutlineMesh mesh2 = new OutlineMesh(progs);

                Triangles.AddRange(mesh2.Triangles);
            }
        }


        static List<Vector2> GetMergedVertices(List<Vector2> vertices, List<Vector2> holeVertice)
        {
            return GetMergedVertices(vertices, new List<List<Vector2>> { holeVertice });
        }


        static List<Vector2> GetMergedVertices(List<Vector2> vertices, List<List<Vector2>> holes)
        {

            int n = vertices.Count;

            for (int e = 0; e < holes.Count; e++)
            {
                var holeVertice = holes[e];
                int h = holeVertice.Count;


                for (int i = 0; i < n; i++)
                {
                    bool founddub = false;
                    for (int g = 0; g < n; g++)
                    {
                        if (g != i && Vector2.Distance(vertices[i], vertices[g]) < 0.0001)
                        {
                            founddub = true;
                            continue;
                        }
                    }
                    if (founddub) continue;
                    for (int j = 0; j < h; j++)
                    {
                        Line2D line = new Line2D(vertices[i], holeVertice[j]);

                        bool isIntersect = false;
                        for (int k = 0; k < n; k++)
                        {
                            int l = k + 1;
                            if (l == n) l = 0;
                            if (k != i && l != i)
                            {
                                Line2D outline = new Line2D(vertices[k], vertices[l]);

                                if (line.IsLineInterSec(outline))
                                {
                                    isIntersect = true;
                                    break;
                                }
                            }
                        }

                        if (!isIntersect)
                        {
                            for (int f = 0; f < holes.Count; f++)
                            {
                                var checkhole = holes[f];
                                for (int k = 0; k < checkhole.Count; k++)
                                {
                                    int l = k + 1;
                                    if (l == checkhole.Count) l = 0;
                                    if (f != e)
                                    {
                                        Line2D outline = new Line2D(checkhole[k], checkhole[l]);
                                        if (line.IsLineInterSec(outline))
                                        {
                                            isIntersect = true;
                                            break;
                                        }
                                    }

                                    if (k != j && l != j)
                                    {
                                        Line2D outline = new Line2D(checkhole[k], checkhole[l]);
                                        if (line.IsLineInterSec(outline))
                                        {
                                            isIntersect = true;
                                            break;
                                        }
                                    }


                                }
                                if (isIntersect)
                                {
                                    break;
                                }
                            }

                        }

                        if (!isIntersect)
                        {
                            List<Vector2> merged = new List<Vector2>();

                            for (int a = 0; a <= i; a++)
                            {
                                merged.Add(vertices[a]);
                            }

                            for (int a = j; a < h; a++)
                            {
                                merged.Add(holeVertice[a]);
                            }
                            for (int a = 0; a <= j; a++)
                            {
                                merged.Add(holeVertice[a]);
                            }
                            for (int a = i; a < n; a++)
                            {
                                merged.Add(vertices[a]);
                            }
                            if (holes.Count == 1)
                            {
                                return merged;
                            }
                            else
                            {
                                List<List<Vector2>> otherholes = new List<List<Vector2>>(holes);
                                otherholes.Remove(holeVertice);
                                return GetMergedVertices(merged, otherholes);
                            }
                        }

                    }
                }




            }

            return new List<Vector2>();
        }


    }
}
