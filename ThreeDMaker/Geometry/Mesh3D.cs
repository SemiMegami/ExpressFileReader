using System;
using System.Collections.Generic;
using System.Numerics;

using System.IO;
namespace ThreeDMaker.Geometry
{
  
    public partial class Mesh3D
    {
        public List<Vector3> Vertices { get; set; }
        public List<Vector3> Normals { get; set; }
        public List<Vector2> UVs { get; set; }
        public List<int> Triangles { get; set; }
        public List<int> Lines { get; set; }
        public List<int> FirstIndice { get; set; }

        public Mesh3D()
        {
            
            Vertices = new List<Vector3>();
            Normals = new List<Vector3>();
            Triangles = new List<int>();
            UVs = new List<Vector2>();
            FirstIndice = new List<int>();
            Lines = new List<int>();
        }


        public void ReCalculateNormal()
        {
            Normals.Clear();
            
            int n = Vertices.Count;

            for(int i = 0; i < n; i++)
            {
                Normals.Add(new Vector3());
            }

            var triangleNormals = FaceNormals();

            for (int i = 0; i < n; i+=3)
            {
                var fNormal = triangleNormals[i / 3];



                Normals[Triangles[i]] += fNormal;
                Normals[Triangles[i + 1]] += fNormal;
                Normals[Triangles[i + 2]] += fNormal;
            }


            for (int i = 0; i < n; i++)
            {
                Normals[i] = Vector3.Normalize(Normals[i]);
            }

        }

        public List<float> FaceAreas()
        {
            List<float> areas = new List<float>();
            int n = Triangles.Count;

            for(int i =0; i < n; i += 3)
            {
                var v1 = Vertices[Triangles[i]];
                var v2 = Vertices[Triangles[i + 1]];
                var v3 = Vertices[Triangles[i + 2]];
                areas.Add(Vector3.Cross(v2 - v1, v3 - v1).Length() * 0.5f);
            }
            return areas;
        }

        public List<Vector3> FaceNormals()
        {
            List<Vector3> normals = new List<Vector3>();
            int n = Triangles.Count;
            for (int i = 0; i < n; i += 3)
            {
                var v1 = Vertices[Triangles[i]];
                var v2 = Vertices[Triangles[i + 1]];
                var v3 = Vertices[Triangles[i + 2]];
                normals.Add(Vector3.Cross(v2 - v1, v3 - v1));
            }
            return normals;
        }

        public List<Vector3> NormalizedFaceNormals()
        {
            List<Vector3> normals = new List<Vector3>();
            int n = Triangles.Count;
            for (int i = 0; i < n; i += 3)
            {
                var v1 = Vertices[Triangles[i]];
                var v2 = Vertices[Triangles[i + 1]];
                var v3 = Vertices[Triangles[i + 2]];
                normals.Add(Vector3.Normalize(Vector3.Cross(v2 - v1, v3 - v1)));
            }
            return normals;
        }

        public string ToObjText()
        {
            string text = "";
            
            foreach(var v in Vertices)
            {
                text += "v " + v.X + " " + v.Y + " " + v.Z + "\n";
            }

            foreach (var v in Normals)
            {
                text += "vn " + v.X + " " + v.Y + " " + v.Z + "\n";
            }

            foreach (var v in UVs)
            {
                text += "vt " + v.X + " " + v.Y + "\n";
            }

            int n = Triangles.Count;

            for(int i = 0; i < n; i += 3)
            {
                int f1 = Triangles[i] + 1;
                int f2 = Triangles[i + 1] + 1;
                int f3 = Triangles[i + 2] + 1;
                text += "f " + f1 + " " + f3 + " " + f2 + "\n";
            }
            return text;
        }

      

        public void ExportToObj(string path, bool swapxyz = false)
        {
            using (StreamWriter writer = new StreamWriter(path))
            {

                if (swapxyz)
                {
                    foreach (var v in Vertices)
                    {
                        writer.Write("v " + v.X + " " + (v.Z) + " " + (-v.Y) + "\n");
                    }

                    foreach (var v in Normals)
                    {
                        writer.Write("vn " + v.X + " " + (v.Z) + " " + (-v.Y) + "\n");
                    }

                    foreach (var v in UVs)
                    {
                        writer.Write("vt " + v.X + " " + v.Y + "\n");
                    }

                    int n = Triangles.Count;

                    for (int i = 0; i < n; i += 3)
                    {
                        int f1 = Triangles[i] + 1;
                        int f2 = Triangles[i + 1] + 1;
                        int f3 = Triangles[i + 2] + 1;
                        writer.Write("f " + f1 + " " + f2 + " " + f3 + "\n");
                    }
                }
                else
                {
                    foreach (var v in Vertices)
                    {
                        writer.Write("v " + v.X + " " + v.Y + " " + v.Z + "\n");
                    }

                    foreach (var v in Normals)
                    {
                        writer.Write("vn " + v.X + " " + v.Y + " " + v.Z + "\n");
                    }

                    foreach (var v in UVs)
                    {
                        writer.Write("vt " + v.X + " " + v.Y + "\n");
                    }

                    int n = Triangles.Count;

                    for (int i = 0; i < n; i += 3)
                    {
                        int f1 = Triangles[i] + 1;
                        int f2 = Triangles[i + 1] + 1;
                        int f3 = Triangles[i + 2] + 1;
                        writer.Write("f " + f1 + " " + f3 + " " + f2 + "\n");
                    }
                }
                
            }
        }
    }
}
