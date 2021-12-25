using System;
using System.Collections.Generic;
using System.Numerics;

namespace ThreeDMaker.Geometry
{
    public class Polygon:PolyLine2D
    {
        public Polygon(float r, int n, float startAngle = 0, bool startWithCorner = false, bool isCentertoFaceSize = true)
        {
            this.Clear();

            float dAngle = 2 * (float)Math.PI / n;
            if (isCentertoFaceSize)
            {
                r *= (float) Math.Cos(dAngle / 2);
            }

            float startAngle2 = startAngle - (float)Math.PI / 2 ;

            if (!startWithCorner)
            {
                startAngle2 += dAngle / 2;
            }
            for (int i = 0; i < n; i++)
            {
                float angle = dAngle * i;
                float x = r * (float)Math.Cos(angle+ startAngle2);
                float y = r * (float)Math.Sin(angle + startAngle2);
                Add(x,y);
            }
        }
    }
}
