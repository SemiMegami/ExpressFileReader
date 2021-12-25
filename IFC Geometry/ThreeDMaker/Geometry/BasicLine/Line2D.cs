using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ThreeDMaker.Geometry
{
    public class Line2D:PolyLine2D
    {
        float x1 => this[0].X;
        float y1 => this[0].Y;
        float x2 => this[1].X;
        float y2 => this[1].Y;

        float dx => x2 - x1;
        float dy => y2 - y1;

        public Line2D(float x1, float y1, float x2, float y2)
        {
            Add(x1, y1);
            Add(x2, y2);     
        }

        // offsetLine
        public float GetY(float x)
        {
            return dy / dx * (x - x1) + y1;
        }
        public float GetX(float y)
        {
            return dx / dy * (y - y1) + x1;
        }
        public Vector2 GetV()
        {
            return new  Vector2(dx, dy);
        }
       
        public Line2D GetOffSetLine(float d)
        {
            Vector2 v = GetV();
            Vector2 n = d * GeometryUtil.GetRight(v);
            return new Line2D(x1 +  n.X, y1  + n.Y, x2 + n.X, y2 + n.Y);
        }

        public Vector2 GetLineInterSec(Line2D l, bool noCheckIntersec = false)
        {
            //https://en.wikipedia.org/wiki/Line%E2%80%93line_intersection
            float x3 = l.x1;
            float y3 = l.y1;
            float x4 = l.x2;
            float y4 = l.y2;

            float x12 = x1 - x2;
            float y12 = y1 - y2;
            float x34 = x3 - x4;
            float y34 = y3 - y4;
            float D = x12 * y34 - y12 * x34;

            if (Math.Abs(D) < GeometryUtil.AreaTol)
            {
                return new Vector2 (float.NaN, float.NaN);
            }
            float xy12 = x1 * y2 - y1 * x2;
            float xy34 = x3 * y4 - y3 * x4;
            return new Vector2((xy12 * x34 - x12 * xy34) / D, (xy12 * y34 - y12 * xy34) / D);
        }
    }
}
