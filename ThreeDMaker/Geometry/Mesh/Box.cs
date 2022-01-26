using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace ThreeDMaker.Geometry
{
    class Box: Mesh3D
    {
        public Box(float w, float d, float h, float x = 0, float y = 0, float z = 0)
        {
            //PolyLine2D section = new PolyLine2D();

            //section.Add(- w / 2,- d / 2);
            //section.Add(+ w / 2,- d / 2);
            //section.Add(+ w / 2,+ d / 2);
            //section.Add(- w / 2,+ d / 2);

            //List<Vector3> lines = new List<Vector3>()
            //{
            //    new Vector3(x,y,z),
            //    new Vector3(x,y,z + h),
            //};

            //Path3D axisPoints = new Path3D(lines);

            //Generate(section, axisPoints, true);
        }

    }
}
