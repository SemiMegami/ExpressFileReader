using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using ThreeDMaker.Geometry;
namespace ThreeDMaker.Geometry.Dimension2
{
    public class Profile2D
    {
        Shape2D outterCurve;
        List<Shape2D> innerCurves;
        public Shape2D OutterCurve { get { return outterCurve; } set { outterCurve = value; UpdateMesh(); } }
        public List<Shape2D> InnerCurves { get { return innerCurves; } set { innerCurves = value; UpdateMesh(); } }

        public List<Profile2D> Composites;
        Mesh3D mesh;
        public Profile2D()
        {
            InnerCurves = new List<Shape2D>();
            Composites = new List<Profile2D>();
        }

        private void UpdateMesh()
        {
            mesh = new Mesh3D();
            //if(outterCurve.Count > 2)
            //{
            //   // mesh = new OutlineMesh(new Shape2D(OutterCurve));
            //}
        }
        public Mesh3D Mesh => mesh;


    }
}
