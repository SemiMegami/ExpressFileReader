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
    }
}
