using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using ThreeDMaker.Geometry.Util;
namespace ThreeDMaker.Geometry
{
    public class Line2D:PolyLine2D
    {
        private static int tolFactor = 10000;
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

        public Line2D(Vector2 v1, Vector2 v2)
        {
            Add(v1.X, v1.Y);
            Add(v2.X, v2.Y);
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
        public Vector2 GetNormolizedV()
        {
            return Vector2.Normalize(GetV());
        }

        public Vector2 GetP1()
        {
            return new Vector2(x1, y1);
        }

        public Vector2 GetP2()
        {
            return new Vector2(x2, y2);
        }

        public float GetLenght()
        {
            return GetV().Length();
        }

        public float GetLenghtSq()
        {
            return GetV().LengthSquared();
        }
        public Line2D GetOffSetLine(float d)
        {
            Vector2 v = GetV();
            Vector2 n = d * GeometryUtil.GetRight(v);
            return new Line2D(x1 + n.X, y1 + n.Y, x2 + n.X, y2 + n.Y);
        }
        public bool IsLineInterSec(Line2D l)
        {
            var v = GetLineInterSec(l);
            return float.IsFinite(v.X);
        }

        public bool IsLineCross(Line2D l)
        {
            var v = GetLineInterSec(l);
            if (float.IsNaN(v.X)) return false;

            if(l.IsPointOnline(x1,y1) || l.IsPointOnline(x2, y2) || IsPointOnline(l.x1, l.y1) || IsPointOnline(l.x2, l.y2))
            {
                return false;
            }
            return true;
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
            float x = (xy12 * x34 - x12 * xy34) / D;
            float y = (xy12 * y34 - y12 * xy34) / D;
            if (noCheckIntersec)
            {
                return new Vector2(x, y);
            }
            if (IsPointOnline(x,y) && l.IsPointOnline(x,y))
            {
                return new Vector2(x, y);
            }
            return new Vector2(float.NaN, float.NaN);
        }
        public float GetPointDistance(float x, float y, bool absolute = true)
        {
            var v12 = new Vector3(GetNormolizedV(),0);
            var v = new Vector3(x - x1, y - y1,0);
            var d = Vector3.Cross(v12,v).Z;
            if (absolute)
            {
                return MathF.Abs(d);
            }
            else
            {
                return d;
            }
        }

        private float GetTol()
        {
            return GetV().Length() / tolFactor;
        }

        public bool IsPointOnline(float x, float y)
        {
            var tol = GetTol();

            var d = GetPointDistance(x, y);
            if(d <= tol)
            {
                var v1 = new Vector2(x - x1, y - y1);
                var v2 = new Vector2(x - x2, y - y2);
                if(Vector2.Dot(v1,v2) < 0 || v1.LengthSquared() < tol * tol || v2.LengthSquared() < tol * tol)
                {
                    return true;
                }
                
            }
            return false;
        }

        public bool IsPointSplitline(float x, float y)
        {
            var tol = GetTol();

            var d = GetPointDistance(x, y);
            if (d <= tol)
            {
                var v1 = new Vector2(x - x1, y - y1);
                var v2 = new Vector2(x - x2, y - y2);
                
                if (Vector2.Dot(v1, v2) < 0 && !(v1.LengthSquared() < tol * tol || v2.LengthSquared() < tol * tol))
                {
                    return true;
                }

            }
            return false;
        }
    }
}
