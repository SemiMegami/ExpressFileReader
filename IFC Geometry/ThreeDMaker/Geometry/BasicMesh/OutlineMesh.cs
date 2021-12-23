using System;
using System.Collections.Generic;
using System.Numerics;
namespace ThreeDMaker.Geometry
{
    public class OutlineMesh:Mesh3D
    {


        public OutlineMesh(Line2D section)
        {
            Vertices.Clear();
            foreach (var s in section)
            {
                Vertices.Add(new Vector3(s,0));
            }
            Triangles = EarClippingAlgorithm(section);
        }

        public OutlineMesh(Line3D section)
        {
            Vertices.Clear();
            List<Vector2> Vector2s = new List<Vector2>();
            foreach (var s in section)
            {
                Vertices.Add(s);
                Vector2s.Add(new Vector2(s.X, s.Y));
            }

            Triangles = EarClippingAlgorithm(Vector2s);
        }


        public static List<int> EarClippingAlgorithm(List<Vector2> vertices)
        {
            int n = vertices.Count;
            List<int> indices = new List<int>();

            for (int i = 0; i < n; i++)
            {
                indices.Add(i);
            }
            return EarClippingAlgorithm(vertices, indices);
        }
        public static List<int> EarClippingAlgorithm(List<Vector2> vertices, List<List<Vector2>> holesholes)
        {
            int n = vertices.Count;
            List<int> indices = new List<int>();

            for (int i = 0; i < n; i++)
            {
                indices.Add(i);
            }
            return EarClippingAlgorithm(vertices, indices);
        }

        public static List<int> EarClippingAlgorithm(List<Vector2> vertices, List<int> indices)
        {
            if (vertices.Count == 3)
            {
                return indices;
            }
            List<int> triangle = new List<int>();
            int n = vertices.Count;
            for (int i = 0; i < n; i++)
            {
                int j = i + 1;
                int k = i + 2;
                if (j >= n) j -= n;
                if (k >= n) k -= n;
                if (GeometryUtil.IsTurningLeft(vertices[i], vertices[j], vertices[k]))
                {
                    bool foundInside = false;
                    for (int l = 0; l < n; l++)
                    {
                        if (l != i && l != j && l != k && GeometryUtil.IsonTriangle(vertices[l], vertices[i], vertices[j], vertices[k]))
                        {
                            foundInside = true;
                            break;
                        }
                    }
                    if (!foundInside)
                    {
                        List<int> subIndices = new List<int>();
                        List<Vector2> subVertices = new List<Vector2>();
                        for (int l = 0; l < n; l++)
                        {
                            if (l != j)
                            {
                                subIndices.Add(indices[l]);
                                subVertices.Add(vertices[l]);
                            }
                        }
                        triangle = EarClippingAlgorithm(subVertices, subIndices);
                        triangle.Add(indices[i]);
                        triangle.Add(indices[j]);
                        triangle.Add(indices[k]);
                        return triangle;
                    }
                }

            }
            return triangle;
        }
    }
}
