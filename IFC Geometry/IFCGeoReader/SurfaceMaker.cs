using IFC4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThreeDMaker.Geometry;

namespace IFC_Geometry.IFCGeoReader
{
    class SurfaceMaker
    {
        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcgeometryresource/lexical/ifcsurface.htm
        public static Mesh3D GetSurface(IfcSurface Surface)
        {
            Mesh3D mesh = new Mesh3D();
            return mesh;
        }
        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcgeometryresource/lexical/ifcbsplinesurfacewithknots.htm
        public static Mesh3D GetSurface(IfcBSplineSurfaceWithKnots BSplineSurfaceWithKnots)
        {
            Mesh3D mesh = new Mesh3D();
            return mesh;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcgeometryresource/lexical/ifcrationalbsplinesurfacewithknots.htm
        public static Mesh3D GetSurface(IfcRationalBSplineSurfaceWithKnots RationalBSplineSurfaceWithKnots)
        {
            Mesh3D mesh = new Mesh3D();
            return mesh;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcgeometryresource/lexical/ifccurveboundedplane.htm
        public static Mesh3D GetSurface(IfcCurveBoundedPlane CurveBoundedPlane)
        {
            Mesh3D mesh = new Mesh3D();
            return mesh;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcgeometryresource/lexical/ifccurveboundedsurface.htm
        public static Mesh3D GetSurface(IfcCurveBoundedSurface CurveBoundedSurface)
        {
            Mesh3D mesh = new Mesh3D();
            return mesh;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcgeometryresource/lexical/ifcrectangulartrimmedsurface.htm
        public static Mesh3D GetSurface(IfcRectangularTrimmedSurface RectangularTrimmedSurface)
        {
            Mesh3D mesh = new Mesh3D();
            return mesh;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcgeometryresource/lexical/ifccylindricalsurface.htm
        public static Mesh3D GetSurface(IfcCylindricalSurface CylindricalSurface)
        {
            Mesh3D mesh = new Mesh3D();
            return mesh;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcgeometryresource/lexical/ifcplane.htm
        public static Mesh3D GetSurface(IfcPlane Plane)
        {
            Mesh3D mesh = new Mesh3D();
            return mesh;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcgeometryresource/lexical/ifcsphericalsurface.htm
        public static Mesh3D GetSurface(IfcSphericalSurface SphericalSurface)
        {
            Mesh3D mesh = new Mesh3D();
            return mesh;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcgeometryresource/lexical/ifctoroidalsurface.htm
        public static Mesh3D GetSurface(IfcToroidalSurface ToroidalSurface)
        {
            Mesh3D mesh = new Mesh3D();
            return mesh;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcgeometryresource/lexical/ifcsurfaceoflinearextrusion.htm
        public static Mesh3D GetSurface(IfcSurfaceOfLinearExtrusion SurfaceOfLinearExtrusion)
        {
            Mesh3D mesh = new Mesh3D();
            return mesh;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcgeometryresource/lexical/ifcsurfaceofrevolution.htm
        public static Mesh3D GetSurface(IfcSurfaceOfRevolution SurfaceOfRevolution)
        {
            Mesh3D mesh = new Mesh3D();
            return mesh;
        }


    }
}
