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
     
        public Shape2D OutterCurve { get; set; }
        public List<Shape2D> InnerCurves { get; set; }

        public List<Profile2D> Composites;
       
        public Profile2D()
        {
            InnerCurves = new List<Shape2D>();
            Composites = new List<Profile2D>();
        }
        public Profile2D(Shape2D OutterCurve, List<Shape2D> InnerCurves)
        {
            this.OutterCurve = OutterCurve;
            this.InnerCurves = InnerCurves;
        }

        public Profile2D(List<Vector2> OutterCurve, List<List<Vector2>> InnerCurves)
        {
            this.OutterCurve = new Polygon2D(OutterCurve);
            
            this.InnerCurves = new List<Shape2D>();
            foreach(var inner in InnerCurves)
            {
                this.InnerCurves.Add(new Polygon2D(inner));
            }
        }
    }
}
