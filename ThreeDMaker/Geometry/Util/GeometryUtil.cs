using System.Numerics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeDMaker.Geometry.Util
{
    class GeometryUtil
    {
        public const float lengthTol = 0.001f;
        public const float AreaTol = 0.000001f;
        public static bool IsonTriangle(Vector2 p, Vector2 p1, Vector2 p2, Vector2 p3, bool includeOnLine = true)
        {
            float A = TriangleArea(p1, p2, p3);
            float A1 = TriangleArea(p, p2, p3) / A;
            float A2 = TriangleArea(p, p3, p1) / A;
            float A3 = TriangleArea(p, p1, p2) / A;
            float tol = AreaTol;
            if (includeOnLine)
            {
              
                return (A1 >= -tol && A2 >= -tol && A3 >= -tol);
            }
            else
            {
                return (A1 >= tol && A2 >= tol && A3 >= tol);
            }
        }

        public static float TriangleArea(Vector2 p1, Vector2 p2, Vector2 p3)
        {
            return 0.5f *( p1.X * p2.Y + p2.X * p3.Y + p3.X * p1.Y - p1.X * p3.Y - p2.X * p1.Y - p3.X * p2.Y);
        }

        public static float TurnAngle(Vector2 p1, Vector2 p2, Vector2 p3)
        {
            var p12 = Vector2.Normalize(p2 - p1);
            var p23 = Vector2.Normalize(p3 - p2);
            var sinAngle = p12.X * p23.Y - p12.Y * p23.X;
            var cosAngle = Vector2.Dot (p12,p23);
            return (float) Math.Atan2(sinAngle, cosAngle);
        }

        public static bool IsTurningLeft(Vector2 p1, Vector2 p2, Vector2 p3)
        {
            var p12 = Vector2.Normalize(p2 - p1);
            var p23 = Vector2.Normalize(p3 - p2);
            return p12.X * p23.Y - p12.Y * p23.X > 0;
        }

        public static bool IsTurningRight(Vector2 p1, Vector2 p2, Vector2 p3)
        {
            var p12 = Vector2.Normalize(p2 - p1);
            var p23 = Vector2.Normalize(p3 - p2);
            return p12.X * p23.Y - p12.Y * p23.X < 0;
        }

        public static bool IsLineIntereced(Vector2 line1P1, Vector2 line1P2, Vector2 line2P1, Vector2 line2P2, bool inCludeTouch = true)
        {
            float A1 = TriangleArea(line1P1, line1P2, line2P1);
            float A2 = TriangleArea(line1P1, line1P2, line2P2);

            float B1 = TriangleArea(line2P1, line2P2, line1P1);
            float B2 = TriangleArea(line2P1, line2P2, line1P2);


            if (inCludeTouch)
            {
                return (A1 * A2 <= 0 && B1 * B2 <= 0);
            }
            else
            {
                return (A1 * A2 < 0 && B1 * B2 < 0);
            }
        }

        public static Vector2 GetRight(Vector2 v)
        {
            if (v.X == 0 && v.Y == 0)
            {
                return Vector2.Zero;
            }
            else
            {
                return Vector2.Normalize(new Vector2(v.Y,-v.X));
            }
        }

        public static Vector3 GetRight(Vector3 v)
        {
            if(v.X == 0 && v.Y == 0)
            {
                return Vector3.UnitX;
            }
            else
            {
                return Vector3.Normalize(Vector3.Cross(v, Vector3.UnitZ));
            }
        }
    }
}
