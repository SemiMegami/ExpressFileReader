using System;
using System.Collections.Generic;
using System.Numerics;
namespace ThreeDMaker.Geometry
{
    public class PolyLine2D : List<Vector2>
    {
        public PolyLine2D()
        {

        }

        public PolyLine2D(List<Vector2> vector2s)
        {
            foreach (var v in vector2s)
            {
                Add(v);
            }
        }

        public bool Close { get; set; }
        private int NextIndex(int i)
        {
            return i < Count - 1 ? (i + 1) : 0;
        }
        private int PrevIndex(int i)
        {
            return i > 1 ? (i - 1) : Count - 1;
        }

        public void Add(float x, float y)
        {
            Add(new Vector2(x, y));
        }

        public List<Line2D> GetLines()
        {
            List<Line2D> lines = new List<Line2D>();
            for (int i = 0; i < Count - 1; i++)
            {
                lines.Add(new Line2D(this[i].X, this[i].Y, this[i + 1].X, this[i + 1].Y));
            }
            return lines;
        }

        public PolyLine2D GetOffSetLine(float d)
        {
            List<Line2D> lines = GetLines();


            List<Line2D> offestlines = new List<Line2D>();
            for (int i = 0; i < lines.Count; i++)
            {
                offestlines.Add(lines[i].GetOffSetLine(d));
            }

            PolyLine2D points = new PolyLine2D();

            points.Add(offestlines[0][0]);

            for (int i = 0; i < offestlines.Count - 1; i++)
            {
                Vector2 point = offestlines[i].GetLineInterSec(offestlines[i + 1]);
                if(float.IsNaN(point.X) || float.IsNaN(point.Y))
                {
                    points.Add(offestlines[i][1]);
                }
                else
                {
                    points.Add(point);
                }
            }

            points.Add(offestlines[Count - 1][1]);
            return points;
        }
    }
}

