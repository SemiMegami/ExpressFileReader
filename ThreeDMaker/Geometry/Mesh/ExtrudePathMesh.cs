using System;
using System.Collections.Generic;
using System.Numerics;
using ThreeDMaker.Geometry.Dimension2;
namespace ThreeDMaker.Geometry
{
    public class ExtrudePathMesh:Mesh3D
    {
        public ExtrudePathMesh()
        {
           
        }
      

        public ExtrudePathMesh(Shape2D section, Path3D path)
        {
            Generate(section, path);
        }
        public ExtrudePathMesh(Shape2D section, List<Shape2D> holes, Path3D path)
        {
            Generate(section, holes, path);
        }

        public void Generate(Shape2D section, Path3D path)
        {
            Vertices = new List<Vector3>();
            Triangles = new List<int>();
            int ni = section.Count;
            int nj = path.Count;

            for (int i = 0; i < ni; i++)
            {
                for (int j = 0; j < nj - 1; j++)
                {
                    int index = Vertices.Count;
                    AxisPoint3D axis1 = path[j];
                    AxisPoint3D axis2 = path[j + 1];
                    Vector3 local1 = new Vector3(section.points[i], 0);
                    int k = i + 1;
                    if (k == ni)
                    {
                        k = 0;
                    }
                    Vector3 local2 = new Vector3(section.points[k], 0);
                    Vector3 v0 = axis1.GetWorld(local1);
                    Vector3 v1 = axis1.GetWorld(local2);
                    Vector3 v2 = axis2.GetWorld(local1);
                    Vector3 v3 = axis2.GetWorld(local2);
                    Vertices.AddRange(new List<Vector3>() { v0, v1, v2, v3 });
                    Triangles.AddRange(new List<int>() { index, index + 1, index + 2, index + 1, index + 3, index + 2 });
                }
            }


            OutlineMesh outlineMesh = new OutlineMesh(section);

            int nv = Vertices.Count;

            AxisPoint3D lastAxis = path[nj - 1];
            foreach (var v in outlineMesh.Vertices)
            {
                Vertices.Add(lastAxis.GetWorld(v));
            }
            for (int i = 0; i < outlineMesh.Triangles.Count; i++)
            {
                Triangles.Add(outlineMesh.Triangles[i] + nv);
            }


            nv = Vertices.Count;
            AxisPoint3D firstAxis = path[0];

            foreach (var v in outlineMesh.Vertices)
            {
                Vertices.Add(firstAxis.GetWorld(v));
            }
            for (int i = 0; i < outlineMesh.Triangles.Count; i += 3)
            {
                Triangles.Add(outlineMesh.Triangles[i] + nv);
                Triangles.Add(outlineMesh.Triangles[i + 2] + nv);
                Triangles.Add(outlineMesh.Triangles[i + 1] + nv);
            }
        }



        public void Generate(Shape2D section,List<Shape2D> holes, Path3D path)
        {
            Vertices = new List<Vector3>();
            Triangles = new List<int>();
            int ni = section.Count;
            int nj = path.Count;

            for (int i = 0; i < ni - 1; i++)
            {
                for (int j = 0; j < nj - 1; j++)
                {
                    int index = Vertices.Count;
                    AxisPoint3D axis1 = path[j];
                    AxisPoint3D axis2 = path[j + 1];
                    Vector3 local1 = new Vector3(section.points[i], 0);
                    int k = i + 1;

                    Vector3 local2 = new Vector3(section.points[k], 0);
                    Vector3 v0 = axis1.GetWorld(local1);
                    Vector3 v1 = axis1.GetWorld(local2);
                    Vector3 v2 = axis2.GetWorld(local1);
                    Vector3 v3 = axis2.GetWorld(local2);
                    Vertices.AddRange(new List<Vector3>() { v0, v1, v2, v3 });
                    Triangles.AddRange(new List<int>() { index, index + 1, index + 2, index + 1, index + 3, index + 2 });
                }
            }


            OutlineMesh outlineMesh = new OutlineMesh(section, holes);

            int nv = Vertices.Count;

            AxisPoint3D lastAxis = path[nj - 1];
            foreach (var v in outlineMesh.Vertices)
            {
                Vertices.Add(lastAxis.GetWorld(v));
            }
            for (int i = 0; i < outlineMesh.Triangles.Count; i++)
            {
                Triangles.Add(outlineMesh.Triangles[i] + nv);
            }


            nv = Vertices.Count;
            AxisPoint3D firstAxis = path[0];

            foreach (var v in outlineMesh.Vertices)
            {
                Vertices.Add(firstAxis.GetWorld(v));
            }
            for (int i = 0; i < outlineMesh.Triangles.Count; i += 3)
            {
                Triangles.Add(outlineMesh.Triangles[i] + nv);
                Triangles.Add(outlineMesh.Triangles[i + 2] + nv);
                Triangles.Add(outlineMesh.Triangles[i + 1] + nv);
            }
        }



    }
}
