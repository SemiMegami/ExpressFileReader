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
        public static int circlesections = 16;
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

                foreach (var p in sectorpoints)
                {
                    if(points.Count == 0 || Vector2.DistanceSquared(points.Last(), p) > 0.001)
                    {
                        points.Add(p);
                    }
                    
                }
                
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
            IfcCartesianPointList2D pointList2D = (IfcCartesianPointList2D)pointList;
          
            foreach (var segment in segments)
            {
                switch (segment.GetType().Name)
                {
                    case EntityName.IFCLINEINDEX:
                        var lineIndex = (IfcLineIndex)segment;
                        foreach (var i in lineIndex)
                        {
                            int j = i - 1;
                            var x = pointList2D.CoordList[j][0];
                            var y = pointList2D.CoordList[j][1];
                            points.Add(new Vector2(x, y));
                        }
                        break;
                    case EntityName.IFCARCINDEX:
                        var arcIndex = (IfcArcIndex)segment;
                        foreach (var i in arcIndex)
                        {
                            int j = i - 1;
                            var x = pointList2D.CoordList[j][0];
                            var y = pointList2D.CoordList[j][1];
                            points.Add(new Vector2(x, y));
                        }
                        break;
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
                points.Add(new Vector2(p.Coordinates[0], p.Coordinates[1]));
            }
            return points;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcgeometryresource/lexical/ifctrimmedcurve.htm
        public static List<Vector2> GetCurve(IfcTrimmedCurve TrimmedCurve)
        {
            var basisCurve = TrimmedCurve.BasisCurve;
            var trim1 = TrimmedCurve.Trim1[0];
            var trim2 = TrimmedCurve.Trim2[0];
            var senseArgreement = TrimmedCurve.SenseAgreement;
            var masterRepresentation = TrimmedCurve.MasterRepresentation;
            List<Vector2> localPoints = new List<Vector2>();
            List<Vector2> points = new List<Vector2>();
            switch (masterRepresentation)
            {
                case IfcTrimmingPreference.CARTESIAN:
                    break;
                case IfcTrimmingPreference.PARAMETER:
                    float t1 = (IfcParameterValue)trim1;
                    float t2 = (IfcParameterValue)trim2;
                    switch (basisCurve.GetType().Name)
                    {     
                        case "IfcCircle":
                            IfcCircle circle = (IfcCircle)basisCurve;
                            float r = circle.Radius;

                            if (senseArgreement)
                            {
                                while (t2 < t1) 
                                {
                                    t2 += 360;
                                }
                                float dt = (t2 - t1) % 360;
                                int sections = (int) MathF.Ceiling(dt / 360 * circlesections);
                                if (sections < 2) sections = 2;
                                float dtheta = dt / sections;
                                
                                for(int i = 0; i <= sections; i++)
                                {
                                    float theta = (t1 + dtheta * i) * MathF.PI / 180;
                                    localPoints.Add(new Vector2(r * MathF.Cos(theta), r * MathF.Sin(theta)));
                                }

                            }
                            else
                            {
                                while (t1 < t2)
                                {
                                    t1 += 360;
                                }
                                float dt = (t1 - t2) % 360;
                                int sections = (int)MathF.Ceiling(dt / 360 * circlesections);
                                if (sections < 2) sections = 2;
                                float dtheta = dt / sections;
                                for (int i = 0; i <= sections; i++)
                                {
                                    float theta = (t1 - dtheta * i) * MathF.PI / 180;
                                    localPoints.Add(new Vector2(r * MathF.Cos(theta), r * MathF.Sin(theta)));
                                }
                               
                            }
                            return IFCGeoUtil.TransformPoints((IfcAxis2Placement2D)circle.Position, localPoints);
                        default:

                             break;

                    }



                    break;
                case IfcTrimmingPreference.UNSPECIFIED:
                    break;
            }
            

           
            return points;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcgeometryresource/lexical/ifccircle.htm
        public static List<Vector2> GetCurve(IfcCircle Circle)
        {
           
            List<Vector2> points = IFCGeoUtil.TransformPoints((IfcAxis2Placement2D)Circle.Position, new Circle2D(Circle.Radius, circlesections).points);
            return points;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcgeometryresource/lexical/ifcellipse.htm
        public static List<Vector2> GetCurve(IfcEllipse Ellipse)
        {
            List<Vector2> points = IFCGeoUtil.TransformPoints((IfcAxis2Placement2D)Ellipse.Position, new Ellipse2D(Ellipse.SemiAxis1, Ellipse.SemiAxis2, circlesections).points) ;
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
                new Vector2(point[0],point[1]),
                new Vector2(point[0] + l *  dir[0],point[1] + l *  dir[1]),
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
            // only 3d
            List<Vector2> points = new List<Vector2>();
            return points;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcgeometryresource/lexical/ifcsurfacecurve.htm
        public static List<Vector2> GetCurve(IfcSurfaceCurve SurfaceCurve)
        {
            // only 3d
            List<Vector2> points = new List<Vector2>();
            return points;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcgeometryresource/lexical/ifcintersectioncurve.htm
        public static List<Vector2> GetCurve(IfcIntersectionCurve IntersectionCurve)
        {
            // only 3d
            List<Vector2> points = new List<Vector2>();
            return points;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcgeometryresource/lexical/ifcseamcurve.htm
        public static List<Vector2> GetCurve(IfcSeamCurve SeamCurve)
        {
            // only 3d
            List<Vector2> points = new List<Vector2>();
            return points;
        }

    }
}
