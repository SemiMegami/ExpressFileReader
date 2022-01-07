using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using ThreeDMaker.Geometry;
namespace ThreeDMaker.Geometry
{
    public class Profile2D
    {
        List<Vector2> outterCurve;
        List<List<Vector2>> innerCurves;
        public List<Vector2> OutterCurve { get { return outterCurve; } set { outterCurve = value; UpdateMesh(); } }
        public List<List<Vector2>> InnerCurves { get { return innerCurves; } set { innerCurves = value; UpdateMesh(); } }

        public List<Profile2D> Composites;
        OutlineMesh mesh;
        public Profile2D()
        {
            OutterCurve = new List<Vector2>();
            InnerCurves = new List<List<Vector2>>();
            Composites = new List<Profile2D>();
        }

        private void UpdateMesh()
        {
            if(outterCurve.Count > 2)
            {
                mesh = new OutlineMesh(new PolyLine2D(OutterCurve));
            }
        }
        public Mesh3D Mesh => mesh;


    }
}
