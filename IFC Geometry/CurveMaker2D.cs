using IFC4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using ThreeDMaker.Geometry.Dimension2;
using IFC_Geometry.IFCGeoReader;
namespace IFC_Geometry
{
    class CurveMaker2D
    {
        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcgeometryresource/lexical/ifcbsplinecurvewithknots.htm
        public static List<Vector2> GetCurve(IfcCurve Curve)
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
        public static List<Vector2> GetCurve(IfcBSplineCurveWithKnots BSplineCurveWithKnots)
        {
            //var P = BSplineCurveWithKnots.ControlPoints;
            //var d = BSplineCurveWithKnots.Degree;
            //BSplineCurveWithKnots.Knots
            List<Vector2> points = new List<Vector2>();
            return points;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcgeometryresource/lexical/ifcrationalbsplinecurvewithknots.htm
        public static List<Vector2> GetCurve(IfcRationalBSplineCurveWithKnots RationalBSplineCurveWithKnots)
        {
            List<Vector2> points = new List<Vector2>();
            return points;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcgeometryresource/lexical/ifccompositecurve.htm
        public static List<Vector2> GetCurve(IfcCompositeCurve CompositeCurve)
        {
            List<Vector2> points = new List<Vector2>();
            foreach (var secment in CompositeCurve.Segments)
            {
                var curve = secment.ParentCurve; 
                List<Vector2> sectorpoints = GetCurve(curve);
                points.AddRange(sectorpoints);
            }
            return points;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcgeometryresource/lexical/ifccompositecurveonsurface.htm
        public static List<Vector2> GetCurve(IfcCompositeCurveOnSurface CompositeCurveOnSurface)
        {
            List<Vector2> points = new List<Vector2>();
            return points;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcgeometryresource/lexical/ifcboundarycurve.htm
        public static List<Vector2> GetCurve(IfcBoundaryCurve BoundaryCurve)
        {
           
            List<Vector2> points = new List<Vector2>();
            return points;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcgeometryresource/lexical/ifcouterboundarycurve.htm
        public static List<Vector2> GetCurve(IfcOuterBoundaryCurve OuterBoundaryCurve)
        {
            List<Vector2> points = new List<Vector2>();
            return points;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcgeometryresource/lexical/ifcindexedpolycurve.htm
        public static List<Vector2> GetCurve(IfcIndexedPolyCurve IndexedPolyCurve)
        {
            List<Vector2> points = new List<Vector2>();
            var pointList = IndexedPolyCurve.Points;
            var segments = IndexedPolyCurve.Segments;
            IfcCartesianPointList2D pointList2D = null;
            IfcCartesianPointList3D pointList3D = null;
            if(IndexedPolyCurve.Dim == 2)
            {
                pointList2D = (IfcCartesianPointList2D)pointList;
            }
            if (IndexedPolyCurve.Dim == 3)
            {
                pointList3D = (IfcCartesianPointList3D)pointList;
            }
            foreach (var segment in segments)
            {
                if (IfcBase.InTypeOf<IfcLineIndex>(segment))
                {
                    var lineIndex = (IfcLineIndex)segment;
                    foreach(var i in lineIndex)
                    {
                        int j = i - 1;
                        var x = pointList2D.CoordList[j][0];
                        var y = pointList2D.CoordList[j][1];
                        points.Add(new Vector2((float)x, (float)y));
                    }
                }
                else if (IfcBase.InTypeOf<IfcArcIndex>(segment))
                {
                    var arcIndex = (IfcArcIndex)segment;
                    foreach (var i in arcIndex)
                    {
                        int j = i - 1;
                        var x = pointList2D.CoordList[j][0];
                        var y = pointList2D.CoordList[j][1];
                        points.Add(new Vector2((float)x, (float)y));
                    }
                }
            }
           
            return points;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcgeometryresource/lexical/ifcpolyline.htm
        public static List<Vector2> GetCurve(IfcPolyline Polyline)
        {

            List<Vector2> points = new List<Vector2>();
           
            foreach (var p in Polyline.Points)
            {
                points.Add(new Vector2((float)p.Coordinates[0], (float)p.Coordinates[1]));
            }
            return points;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcgeometryresource/lexical/ifctrimmedcurve.htm
        public static List<Vector2> GetCurve(IfcTrimmedCurve TrimmedCurve)
        {
            List<Vector2> points = new List<Vector2>();

           
            return points;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcgeometryresource/lexical/ifccircle.htm
        public static List<Vector2> GetCurve(IfcCircle Circle)
        {
           
            List<Vector2> points = IFCGeoUtil.TransformPoints((IfcAxis2Placement2D)Circle.Position, new Circle2D((float)Circle.Radius).points);
            return points;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcgeometryresource/lexical/ifcellipse.htm
        public static List<Vector2> GetCurve(IfcEllipse Ellipse)
        {
            List<Vector2> points = IFCGeoUtil.TransformPoints((IfcAxis2Placement2D)Ellipse.Position, new Ellipse2D((float)Ellipse.SemiAxis1, (float)Ellipse.SemiAxis2).points) ;
            return points;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcgeometryresource/lexical/ifcline.htm
        public static List<Vector2> GetCurve(IfcLine Line)
        {
            
            var dir = Line.Dir.Orientation.DirectionRatios;
            var point = Line.Pnt.Coordinates;
            float l = 10000;
            List<Vector2> points = new List<Vector2>() 
            {
                new Vector2((float)point[0],(float)point[1]),
                new Vector2((float)point[0] + l * (float) dir[0],(float)point[1] + l * (float) dir[1]),
            };
            return points;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcgeometryresource/lexical/ifcoffsetcurve2d.htm
        public static List<Vector2> GetCurve(IfcOffsetCurve2D OffsetCurve2D)
        {
            List<Vector2> points = new List<Vector2>();
            return points;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcgeometryresource/lexical/ifcoffsetcurve3d.htm
        public static List<Vector2> GetCurve(IfcOffsetCurve3D OffsetCurve3D)
        {
            List<Vector2> points = new List<Vector2>();
            return points;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcgeometryresource/lexical/ifcpcurve.htm
        public static List<Vector2> GetCurve(IfcPcurve Pcurve)
        {
            List<Vector2> points = new List<Vector2>();
            return points;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcgeometryresource/lexical/ifcsurfacecurve.htm
        public static List<Vector2> GetCurve(IfcSurfaceCurve SurfaceCurve)
        {
            List<Vector2> points = new List<Vector2>();
            return points;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcgeometryresource/lexical/ifcintersectioncurve.htm
        public static List<Vector2> GetCurve(IfcIntersectionCurve IntersectionCurve)
        {
            List<Vector2> points = new List<Vector2>();
            return points;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcgeometryresource/lexical/ifcseamcurve.htm
        public static List<Vector2> GetCurve(IfcSeamCurve SeamCurve)
        {
            List<Vector2> points = new List<Vector2>();
            return points;
        }

    }
}
