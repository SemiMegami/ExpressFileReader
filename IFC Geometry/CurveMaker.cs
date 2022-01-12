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
            //var P = BSplineCurveWithKnots.ControlPoints;
            //var d = BSplineCurveWithKnots.Degree;
            //BSplineCurveWithKnots.Knots
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
            int i;
            foreach (var secment in CompositeCurve.Segments)
            {
                var curve = secment.ParentCurve; 
                List<Vector3> sectorpoints = GetCurve(curve);
                foreach (var point in sectorpoints)
                {
                    i = points.Count - 1;
                    if(i == -1 || Math.Abs(points[i].X - point.X) > 0.00001 || Math.Abs(points[i].Y - point.Y) > 0.00001 || Math.Abs(points[i].Z - point.Z) > 0.00001)
                    {
                        points.Add(point);
                    }
                }

            }
            i = points.Count - 1;

            if(points.Count > 1)
            {
                if (Math.Abs(points[i].X - points[0].X) > 0.00001 && Math.Abs(points[i].Y - points[0].Y) > 0.00001 && Math.Abs(points[i].Z - points[0].Z) > 0.00001)
                {
                    points.RemoveAt(i);
                }
            }
          
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
                        if (IndexedPolyCurve.Dim == 2)
                        {
                            
                            var x = pointList2D.CoordList[j][0];
                            var y = pointList2D.CoordList[j][1];
                            points.Add(new Vector3((float)x, (float)y,0));
                        }
                        if (IndexedPolyCurve.Dim == 3)
                        {
                            var x = pointList3D.CoordList[j][0];
                            var y = pointList3D.CoordList[j][1];
                            var z = pointList3D.CoordList[j][2];
                            points.Add(new Vector3((float)x, (float)y, (float)z));
                        }
                    }
                }
                else if (IfcBase.InTypeOf<IfcArcIndex>(segment))
                {
                    var arcIndex = (IfcArcIndex)segment;
                    foreach (var i in arcIndex)
                    {
                        int j = i - 1;
                        if (IndexedPolyCurve.Dim == 2)
                        {
                            var x = pointList2D.CoordList[j][0];
                            var y = pointList2D.CoordList[j][1];
                            points.Add(new Vector3((float)x, (float)y, 0));
                        }
                        if (IndexedPolyCurve.Dim == 3)
                        {
                            var x = pointList3D.CoordList[j][0];
                            var y = pointList3D.CoordList[j][1];
                            var z = pointList3D.CoordList[j][2];
                            points.Add(new Vector3((float)x, (float)y, (float)z));
                        }
                    }
                }
            }
           
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
