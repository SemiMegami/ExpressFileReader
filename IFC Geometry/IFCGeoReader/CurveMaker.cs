using IFC4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace IFC_Geometry
{
    class CurveMaker
    {
        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcgeometryresource/lexical/ifcbsplinecurvewithknots.htm
        public static List<Vector3> GetCurve(IfcCurve Curve)
        {
            switch (Curve.GetType().Name)
            {
                case EntityName.IFCBSPLINECURVEWITHKNOTS: return GetCurve((IfcBSplineCurveWithKnots)Curve);
                case EntityName.IFCRATIONALBSPLINECURVEWITHKNOTS: return GetCurve((IfcRationalBSplineCurveWithKnots)Curve);
                case EntityName.IFCCOMPOSITECURVE: return GetCurve((IfcCompositeCurve)Curve);
                case EntityName.IFCCOMPOSITECURVEONSURFACE: return GetCurve((IfcCompositeCurveOnSurface)Curve);
                case EntityName.IFCBOUNDARYCURVE: return GetCurve((IfcBoundaryCurve)Curve);
                case EntityName.IFCOUTERBOUNDARYCURVE: return GetCurve((IfcOuterBoundaryCurve)Curve);
                case EntityName.IFCINDEXEDPOLYCURVE: return GetCurve((IfcIndexedPolyCurve)Curve);
                case EntityName.IFCPOLYLINE: return GetCurve((IfcPolyline)Curve);
                case EntityName.IFCTRIMMEDCURVE: return GetCurve((IfcTrimmedCurve)Curve);
                case EntityName.IFCCIRCLE: return GetCurve((IfcCircle)Curve);
                case EntityName.IFCELLIPSE: return GetCurve((IfcEllipse)Curve);
                case EntityName.IFCLINE: return GetCurve((IfcLine)Curve);
                case EntityName.IFCOFFSETCURVE2D: return GetCurve((IfcOffsetCurve2D)Curve);
                case EntityName.IFCOFFSETCURVE3D: return GetCurve((IfcOffsetCurve3D)Curve);
                case EntityName.IFCPCURVE: return GetCurve((IfcPcurve)Curve);
                case EntityName.IFCSURFACECURVE: return GetCurve((IfcSurfaceCurve)Curve);
                case EntityName.IFCINTERSECTIONCURVE: return GetCurve((IfcIntersectionCurve)Curve);
                case EntityName.IFCSEAMCURVE: return GetCurve((IfcSeamCurve)Curve);
            }
            return null;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcgeometryresource/lexical/ifcbsplinecurvewithknots.htm
        public static List<Vector3> GetCurve(IfcBSplineCurveWithKnots BSplineCurveWithKnots)
        {
            List<Vector3> points = new List<Vector3>();
            return points;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcgeometryresource/lexical/ifcrationalbsplinecurvewithknots.htm
        public static List<Vector3> GetCurve(IfcRationalBSplineCurveWithKnots RationalBSplineCurveWithKnots)
        {
            List<Vector3> points = new List<Vector3>();
            return points;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcgeometryresource/lexical/ifccompositecurve.htm
        public static List<Vector3> GetCurve(IfcCompositeCurve CompositeCurve)
        {
            List<Vector3> points = new List<Vector3>();
            return points;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcgeometryresource/lexical/ifccompositecurveonsurface.htm
        public static List<Vector3> GetCurve(IfcCompositeCurveOnSurface CompositeCurveOnSurface)
        {
            List<Vector3> points = new List<Vector3>();
            return points;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcgeometryresource/lexical/ifcboundarycurve.htm
        public static List<Vector3> GetCurve(IfcBoundaryCurve BoundaryCurve)
        {
            List<Vector3> points = new List<Vector3>();
            return points;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcgeometryresource/lexical/ifcouterboundarycurve.htm
        public static List<Vector3> GetCurve(IfcOuterBoundaryCurve OuterBoundaryCurve)
        {
            List<Vector3> points = new List<Vector3>();
            return points;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcgeometryresource/lexical/ifcindexedpolycurve.htm
        public static List<Vector3> GetCurve(IfcIndexedPolyCurve IndexedPolyCurve)
        {
            List<Vector3> points = new List<Vector3>();
            return points;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcgeometryresource/lexical/ifcpolyline.htm
        public static List<Vector3> GetCurve(IfcPolyline Polyline)
        {

            List<Vector3> points = new List<Vector3>();
           
            foreach (var p in Polyline.Points)
            {
                if(p.Dim == 2)
                {
                    points.Add(new Vector3((float)p.Coordinates[0], (float)p.Coordinates[1],0));
                }
                else
                {
                    points.Add(new Vector3((float)p.Coordinates[0], (float)p.Coordinates[1], (float)p.Coordinates[2]));
                }
               
            }
            return points;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcgeometryresource/lexical/ifctrimmedcurve.htm
        public static List<Vector3> GetCurve(IfcTrimmedCurve TrimmedCurve)
        {
            List<Vector3> points = new List<Vector3>();
            return points;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcgeometryresource/lexical/ifccircle.htm
        public static List<Vector3> GetCurve(IfcCircle Circle)
        {
            List<Vector3> points = new List<Vector3>();
            return points;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcgeometryresource/lexical/ifcellipse.htm
        public static List<Vector3> GetCurve(IfcEllipse Ellipse)
        {
            List<Vector3> points = new List<Vector3>();
            return points;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcgeometryresource/lexical/ifcline.htm
        public static List<Vector3> GetCurve(IfcLine Line)
        {
            List<Vector3> points = new List<Vector3>();
            return points;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcgeometryresource/lexical/ifcoffsetcurve2d.htm
        public static List<Vector3> GetCurve(IfcOffsetCurve2D OffsetCurve2D)
        {
            List<Vector3> points = new List<Vector3>();
            return points;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcgeometryresource/lexical/ifcoffsetcurve3d.htm
        public static List<Vector3> GetCurve(IfcOffsetCurve3D OffsetCurve3D)
        {
            List<Vector3> points = new List<Vector3>();
            return points;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcgeometryresource/lexical/ifcpcurve.htm
        public static List<Vector3> GetCurve(IfcPcurve Pcurve)
        {
            List<Vector3> points = new List<Vector3>();
            return points;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcgeometryresource/lexical/ifcsurfacecurve.htm
        public static List<Vector3> GetCurve(IfcSurfaceCurve SurfaceCurve)
        {
            List<Vector3> points = new List<Vector3>();
            return points;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcgeometryresource/lexical/ifcintersectioncurve.htm
        public static List<Vector3> GetCurve(IfcIntersectionCurve IntersectionCurve)
        {
            List<Vector3> points = new List<Vector3>();
            return points;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcgeometryresource/lexical/ifcseamcurve.htm
        public static List<Vector3> GetCurve(IfcSeamCurve SeamCurve)
        {
            List<Vector3> points = new List<Vector3>();
            return points;
        }

    }
}
