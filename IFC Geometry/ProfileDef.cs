using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using ThreeDMaker.Geometry;
namespace IFC_Geometry
{
    public class ProfileDef
    {
        List<Vector2> outterCurve;
        List<List<Vector2>> innerCurves;
        public List<Vector2> OutterCurve { get { return outterCurve; } set { outterCurve = value; UpdateMesh(); } }
        public List<List<Vector2>> InnerCurves { get { return innerCurves; } set { innerCurves = value; UpdateMesh(); } }
        OutlineMesh mesh;
        public ProfileDef()
        {
            OutterCurve = new List<Vector2>();
            InnerCurves = new List<List<Vector2>>();
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
