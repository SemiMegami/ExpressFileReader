using System;
using System.Collections.Generic;
using System.Numerics;
namespace ThreeDMaker.Geometry.Dimension2
{
    public class Ellipse2D:Shape2D
    {    
        public float Rx { get; set; }
        public float Ry { get; set; }
        public int Sections { get; set; }
        public float X { get; set; }
        public float Y { get; set; }
        public float RotationDegree { get; set; }
        public Ellipse2D(float rx, float ry, int sections = 16, float x = 0, float y = 0, float rotationDegree = 0)
        {
            Rx = rx;
            Ry = ry;
            Sections = sections;
            X = x;
            Y = y;
            RotationDegree = rotationDegree;
        }

        public override void UpdatePoints()
        {
            points.Clear();

            float dAngle = 2 * MathF.PI / Sections;


            float startAngle2 = (-RotationDegree) * MathF.PI / 2;

            for (int i = 0; i <= Sections; i++)
            {
                float angle = dAngle * i;
                float x = X + Rx * MathF.Cos(angle + startAngle2);
                float y = Y + Ry * MathF.Sin(angle + startAngle2);
                Add(x, y);
            }
        }

        public override Ellipse2D GetOffSet(float d)
        {
            return new Ellipse2D(Rx + d,Ry + d, Sections, X, Y);
        }
    }
}
