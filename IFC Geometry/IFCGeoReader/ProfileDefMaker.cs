using IFC_Geometry.IFCGeoReader;
using IFC4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using ThreeDMaker.Geometry;
namespace IFC_Geometry
{
    public static class ProfileDefMaker
    {
        static Performance pfm = new Performance();

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcprofileresource/lexical/ifcprofiledef.htm;
        public static ProfileDef GetProfileDef(IfcProfileDef ProfileDef)
        {
            switch (ProfileDef.GetType().Name)
            {
                case EntityName.IFCARBITRARYCLOSEDPROFILEDEF: return GetProfileDef((IfcArbitraryClosedProfileDef)ProfileDef);
                case EntityName.IFCARBITRARYPROFILEDEFWITHVOIDS: return GetProfileDef((IfcArbitraryProfileDefWithVoids)ProfileDef);
                case EntityName.IFCARBITRARYOPENPROFILEDEF: return GetProfileDef((IfcArbitraryOpenProfileDef)ProfileDef);
                case EntityName.IFCCENTERLINEPROFILEDEF: return GetProfileDef((IfcCenterLineProfileDef)ProfileDef);
          //      case EntityName.IFCCOMPOSITEPROFILEDEF: return GetProfileDef((IfcCompositeProfileDef)ProfileDef);
          //      case EntityName.IFCDERIVEDPROFILEDEF:return GetProfileDef((IfcDerivedProfileDef)ProfileDef);
                case EntityName.IFCMIRROREDPROFILEDEF: return GetProfileDef((IfcMirroredProfileDef)ProfileDef);
                case EntityName.IFCASYMMETRICISHAPEPROFILEDEF: return GetProfileDef((IfcAsymmetricIShapeProfileDef)ProfileDef);
                case EntityName.IFCCSHAPEPROFILEDEF: return GetProfileDef((IfcCShapeProfileDef)ProfileDef);
                case EntityName.IFCCIRCLEPROFILEDEF: return GetProfileDef((IfcCircleProfileDef)ProfileDef);
                case EntityName.IFCCIRCLEHOLLOWPROFILEDEF:return GetProfileDef((IfcCircleHollowProfileDef)ProfileDef);
                case EntityName.IFCELLIPSEPROFILEDEF: return GetProfileDef((IfcEllipseProfileDef)ProfileDef);
                case EntityName.IFCISHAPEPROFILEDEF: return GetProfileDef((IfcIShapeProfileDef)ProfileDef);
                case EntityName.IFCLSHAPEPROFILEDEF: return GetProfileDef((IfcLShapeProfileDef)ProfileDef);
                case EntityName.IFCRECTANGLEPROFILEDEF: return GetProfileDef((IfcRectangleProfileDef)ProfileDef);
                case EntityName.IFCRECTANGLEHOLLOWPROFILEDEF: return GetProfileDef((IfcRectangleHollowProfileDef)ProfileDef);
                case EntityName.IFCROUNDEDRECTANGLEPROFILEDEF: return GetProfileDef((IfcRoundedRectangleProfileDef)ProfileDef);
                case EntityName.IFCTSHAPEPROFILEDEF: return GetProfileDef((IfcTShapeProfileDef)ProfileDef);
                case EntityName.IFCTRAPEZIUMPROFILEDEF: return GetProfileDef((IfcTrapeziumProfileDef)ProfileDef);
                case EntityName.IFCUSHAPEPROFILEDEF: return GetProfileDef((IfcUShapeProfileDef)ProfileDef);
                case EntityName.IFCZSHAPEPROFILEDEF: return GetProfileDef((IfcZShapeProfileDef)ProfileDef);
                default:return null;
            }
        }

        public static List<ProfileDef> GetProfileDefs(IfcProfileDef ProfileDef)
        {
            switch (ProfileDef.GetType().Name)
            {
                case EntityName.IFCARBITRARYCLOSEDPROFILEDEF: return new List<ProfileDef>() { GetProfileDef((IfcArbitraryClosedProfileDef)ProfileDef)};
                case EntityName.IFCARBITRARYPROFILEDEFWITHVOIDS: return new List<ProfileDef>() { GetProfileDef((IfcArbitraryProfileDefWithVoids)ProfileDef)};
                case EntityName.IFCARBITRARYOPENPROFILEDEF: return new List<ProfileDef>() { GetProfileDef((IfcArbitraryOpenProfileDef)ProfileDef)};
                case EntityName.IFCCENTERLINEPROFILEDEF: return new List<ProfileDef>() { GetProfileDef((IfcCenterLineProfileDef)ProfileDef) };
                      //case EntityName.IFCCOMPOSITEPROFILEDEF: return GetProfileDef((IfcCompositeProfileDef)ProfileDef);
                      //case EntityName.IFCDERIVEDPROFILEDEF:return GetProfileDef((IfcDerivedProfileDef)ProfileDef);
                case EntityName.IFCMIRROREDPROFILEDEF: return new List<ProfileDef>() { GetProfileDef((IfcMirroredProfileDef)ProfileDef) };
                case EntityName.IFCASYMMETRICISHAPEPROFILEDEF: return new List<ProfileDef>() { GetProfileDef((IfcAsymmetricIShapeProfileDef)ProfileDef) };
                case EntityName.IFCCSHAPEPROFILEDEF: return new List<ProfileDef>() { GetProfileDef((IfcCShapeProfileDef)ProfileDef) };
                case EntityName.IFCCIRCLEPROFILEDEF: return new List<ProfileDef>() { GetProfileDef((IfcCircleProfileDef)ProfileDef) };
                case EntityName.IFCCIRCLEHOLLOWPROFILEDEF: return new List<ProfileDef>() { GetProfileDef((IfcCircleHollowProfileDef)ProfileDef) };
                case EntityName.IFCELLIPSEPROFILEDEF: return new List<ProfileDef>() { GetProfileDef((IfcEllipseProfileDef)ProfileDef) };
                case EntityName.IFCISHAPEPROFILEDEF: return new List<ProfileDef>() { GetProfileDef((IfcIShapeProfileDef)ProfileDef) };
                case EntityName.IFCLSHAPEPROFILEDEF: return new List<ProfileDef>() { GetProfileDef((IfcLShapeProfileDef)ProfileDef) };
                case EntityName.IFCRECTANGLEPROFILEDEF: return new List<ProfileDef>() { GetProfileDef((IfcRectangleProfileDef)ProfileDef) };
                case EntityName.IFCRECTANGLEHOLLOWPROFILEDEF: return new List<ProfileDef>() { GetProfileDef((IfcRectangleHollowProfileDef)ProfileDef) };
                case EntityName.IFCROUNDEDRECTANGLEPROFILEDEF: return new List<ProfileDef>() { GetProfileDef((IfcRoundedRectangleProfileDef)ProfileDef) };
                case EntityName.IFCTSHAPEPROFILEDEF: return new List<ProfileDef>() { GetProfileDef((IfcTShapeProfileDef)ProfileDef) };
                case EntityName.IFCTRAPEZIUMPROFILEDEF: return new List<ProfileDef>() { GetProfileDef((IfcTrapeziumProfileDef)ProfileDef) };
                case EntityName.IFCUSHAPEPROFILEDEF: return new List<ProfileDef>() { GetProfileDef((IfcUShapeProfileDef)ProfileDef) };
                case EntityName.IFCZSHAPEPROFILEDEF: return new List<ProfileDef>() { GetProfileDef((IfcZShapeProfileDef)ProfileDef) };
                default: return null;
            }
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcprofileresource/lexical/ifcarbitraryclosedprofiledef.htm
        public static ProfileDef GetProfileDef(IfcArbitraryClosedProfileDef ArbitraryClosedProfileDef)
        {
         
             var outer = CurveMaker.GetCurve(ArbitraryClosedProfileDef.OuterCurve);
            List<Vector2> vector2s = new List<Vector2>();
            for (int i = 0; i < outer.Count; i++)
            {
                vector2s.Add(new Vector2(outer[i].X,outer[i].Y));
                if(i == outer.Count - 1)
                {
                    if(Math.Abs(outer[i].X - vector2s[0].X) < 0.00001 && Math.Abs(outer[i].Y - vector2s[0].Y) < 0.00001)
                    {
                        vector2s.RemoveAt(i);
                    }
                }
            }
            ProfileDef profileDef = new ProfileDef();
            profileDef.OutterCurve = vector2s;
            return profileDef;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcprofileresource/lexical/ifcarbitraryprofiledefwithvoids.htm
        public static ProfileDef GetProfileDef(IfcArbitraryProfileDefWithVoids ArbitraryProfileDefWithVoids)
        {
            
            var outer = CurveMaker.GetCurve(ArbitraryProfileDefWithVoids.OuterCurve);
            List<Vector2> vector2s = new List<Vector2>();
            for (int i = 0; i < outer.Count; i++)
            {
                vector2s.Add(new Vector2(outer[i].X, outer[i].Y));
                if (i == outer.Count - 1)
                {
                    if (Math.Abs(outer[i].X - vector2s[0].X) < 0.00001 && Math.Abs(outer[i].Y - vector2s[0].Y) < 0.00001)
                    {
                        vector2s.RemoveAt(i);
                    }
                }
            }

            List< List<Vector2>> innervector2s = new List<List<Vector2>>();
            foreach(var innerCurve in ArbitraryProfileDefWithVoids.InnerCurves)
            {
                List<Vector2> innervecs = new List<Vector2>();
                var inner = CurveMaker.GetCurve(innerCurve);
                for (int i = 0; i < inner.Count; i++)
                {
                    innervecs.Add(new Vector2(inner[i].X, inner[i].Y));
                    if (i == inner.Count - 1)
                    {
                        if (Math.Abs(inner[i].X - innervecs[0].X) < 0.00001 && Math.Abs(inner[i].Y - innervecs[0].Y) < 0.00001)
                        {
                            innervecs.RemoveAt(i);
                        }
                    }
                }
                innervector2s.Add(innervecs);
            }

            ProfileDef profileDef = new ProfileDef();
            profileDef.OutterCurve = vector2s;
            profileDef.InnerCurves = innervector2s;
            return profileDef;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcprofileresource/lexical/ifcarbitraryopenprofiledef.htm
        public static ProfileDef GetProfileDef(IfcArbitraryOpenProfileDef ArbitraryOpenProfileDef)
        {
            var outer = CurveMaker.GetCurve(ArbitraryOpenProfileDef.Curve);
            List<Vector2> vector2s = new List<Vector2>();
            for (int i = 0; i < outer.Count; i++)
            {
                vector2s.Add(new Vector2(outer[i].X, outer[i].Y));
            }
            ProfileDef profileDef = new ProfileDef();
            profileDef.OutterCurve = vector2s;
            return profileDef;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcprofileresource/lexical/ifccenterlineprofiledef.htm
        public static ProfileDef GetProfileDef(IfcCenterLineProfileDef CenterLineProfileDef)
        {
           
            ProfileDef profileDef = new ProfileDef();

            var curve = CurveMaker.GetCurve(CenterLineProfileDef.Curve);
            var t = CenterLineProfileDef.Thickness;
         

            List<Vector2> centerVector2s = new List<Vector2>();
            for (int i = 0; i < curve.Count; i++)
            {
                centerVector2s.Add(new Vector2(curve[i].X, curve[i].Y));
            }
            PolyLine2D polyline = new PolyLine2D(centerVector2s);
            PolyLine2D polyline1 = polyline.GetOffSetLine((float) t / 2);
            PolyLine2D polyline2 = polyline.GetOffSetLine(-(float)t / 2);

            List<Vector2> vector2s = new List<Vector2>();
            for (int i = 0; i < curve.Count; i++)
            {
                vector2s.Add(polyline1[i]);
            }
            for (int i = curve.Count - 1; i >= 0; i--)
            {
                vector2s.Add(polyline2[i]);
            }

            profileDef.OutterCurve = vector2s;

            return profileDef;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcprofileresource/lexical/ifccompositeprofiledef.htm
        public static ProfileDef GetProfileDef(IfcCompositeProfileDef CompositeProfileDef)
        {
            //TO DO it should return multiple profile instead
            ProfileDef profileDef = new ProfileDef();
            return profileDef;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcprofileresource/lexical/ifcderivedprofiledef.htm
        public static ProfileDef GetProfileDef(IfcDerivedProfileDef DerivedProfileDef)
        {
            // TO DO
            IfcProfileDef parent = DerivedProfileDef.ParentProfile;
            IfcCartesianTransformationOperator2D transform = DerivedProfileDef.Operator;

            ProfileDef parentDef = GetProfileDef(parent);
            var inners = parentDef.InnerCurves;
            var outter = parentDef.OutterCurve;


            ProfileDef profileDef = new ProfileDef();

            return profileDef;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcprofileresource/lexical/ifcmirroredprofiledef.htm
        public static ProfileDef GetProfileDef(IfcMirroredProfileDef MirroredProfileDef)
        {
            // TO DO
            ProfileDef profileDef = new ProfileDef();
            return profileDef;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcprofileresource/lexical/ifcasymmetricishapeprofiledef.htm
        public static ProfileDef GetProfileDef(IfcAsymmetricIShapeProfileDef AsymmetricIShapeProfileDef)
        {

            float x1 = (float) AsymmetricIShapeProfileDef.WebThickness / 2;
            float x2 = (float)AsymmetricIShapeProfileDef.TopFlangeWidth / 2;
            float x3 = (float)AsymmetricIShapeProfileDef.BottomFlangeWidth / 2;
            float y1 = - (float)AsymmetricIShapeProfileDef.OverallDepth / 2;
            float y2 = y1 + (float)AsymmetricIShapeProfileDef.BottomFlangeThickness;       
            float y3 = - (float)AsymmetricIShapeProfileDef.TopFlangeThickness- y1;
            float y4 =  - y1;
            // Ignoring Curve
            PolyLine2D line = new PolyLine2D
            {
                { x3, y1 },
                { x3, y2 },
                { x1, y2 },
                { x1, y3 },
                { x2, y3 },
                { x2, y4 },
                { -x2, y4 },
                { -x2, y3 },
                { -x1, y3 },
                { -x1, y2 },
                { -x3, y2 },
                { -x3, y1 },
            };

            var moved = IFCGeoUtil.TransformPoints(AsymmetricIShapeProfileDef.Position, line);
            line = new PolyLine2D(moved);
            ProfileDef profileDef = new ProfileDef()
            {
                OutterCurve = line
            };
            return profileDef;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcprofileresource/lexical/ifccshapeprofiledef.htm
        public static ProfileDef GetProfileDef(IfcCShapeProfileDef CShapeProfileDef)
        {
            // Assume no mirror
            // Ignore curve
            float x1 = (float)(CShapeProfileDef.Width / 2 - CShapeProfileDef.WallThickness);
            float x2 = (float)(CShapeProfileDef.Width / 2);
            float y1 = (float)(CShapeProfileDef.Depth / 2 - CShapeProfileDef.Girth);
            float y2 = (float)(CShapeProfileDef.Depth / 2 - CShapeProfileDef.WallThickness);
            float y3 = (float)(CShapeProfileDef.Depth / 2);

            PolyLine2D line = new PolyLine2D
            {
                { x2, -y3 },
                { x2, -y1 },
                { x1, -y1 },
                { x1, -y2 },
                { -x1, -y2 },
                { -x1, y2 },
                { x1, y2 },
                { x1, y1 },
                { x2, y1 },
                { x2, y3 },
                { -x2, y3 },
                { -x2, -y3 },
            };
            var moved = IFCGeoUtil.TransformPoints(CShapeProfileDef.Position, line);
            line = new PolyLine2D(moved);
            ProfileDef profileDef = new ProfileDef()
            {
                OutterCurve = line
            };
            return profileDef;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcprofileresource/lexical/ifccircleprofiledef.htm
        public static ProfileDef GetProfileDef(IfcCircleProfileDef CircleProfileDef)
        {
            double r = CircleProfileDef.Radius;
          
            int n = pfm.curveDetail * 4;
            double dTheta = 2 * Math.PI / n;
            List<Vector2> vector2s = new List<Vector2>();
            double theta;
            for(int i = 0; i < n; i++)
            {
                theta = i * dTheta / n;
                vector2s.Add(new Vector2((float) ( r * Math.Cos(theta)), (float)( r * Math.Cos(theta))));

            }
            var moved = IFCGeoUtil.TransformPoints(CircleProfileDef.Position, vector2s);
            var line = new PolyLine2D(moved);
            ProfileDef profileDef = new ProfileDef();
            profileDef.OutterCurve = line;
            return profileDef;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcprofileresource/lexical/ifccirclehollowprofiledef.htm
        public static ProfileDef GetProfileDef(IfcCircleHollowProfileDef CircleHollowProfileDef)
        {
            //Ignore hollow
            double r = CircleHollowProfileDef.Radius;
            var location = CircleHollowProfileDef.Position.Location;
            double x = location.Coordinates[0];
            double y = location.Coordinates[1];
            int n = pfm.curveDetail * 4;
            double dTheta = 2 * Math.PI / n;
            List<Vector2> vector2s = new List<Vector2>();
            double theta;
            for (int i = 0; i < n; i++)
            {
                theta = i * dTheta / n;
                vector2s.Add(new Vector2((float)( r * Math.Cos(theta)), (float)( r * Math.Cos(theta))));

            }
            var moved = IFCGeoUtil.TransformPoints(CircleHollowProfileDef.Position, vector2s);
            var line = new PolyLine2D(moved);
            ProfileDef profileDef = new ProfileDef();
            profileDef.OutterCurve = line;
            return profileDef;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcprofileresource/lexical/ifcellipseprofiledef.htm
        public static ProfileDef GetProfileDef(IfcEllipseProfileDef EllipseProfileDef)
        {

            double r1 = EllipseProfileDef.SemiAxis1;
            double r2 = EllipseProfileDef.SemiAxis1;
          
            int n = pfm.curveDetail * 4;
            double dTheta = 2 * Math.PI / n;
            List<Vector2> vector2s = new List<Vector2>();
            double theta;
            for (int i = 0; i < n; i++)
            {
                theta = i * dTheta / n;
                vector2s.Add(new Vector2((float)( r1 * Math.Cos(theta)), (float)( r2 * Math.Cos(theta))));

            }
            var moved = IFCGeoUtil.TransformPoints(EllipseProfileDef.Position, vector2s);
            var line = new PolyLine2D(moved);
            ProfileDef profileDef = new ProfileDef();
            profileDef.OutterCurve = line;
            return profileDef;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcprofileresource/lexical/ifcishapeprofiledef.htm
        public static ProfileDef GetProfileDef(IfcIShapeProfileDef IShapeProfileDef)
        {
            float x1 = (float)IShapeProfileDef.WebThickness / 2;
            float x2 = (float)IShapeProfileDef.FlangeThickness / 2;
            float x3 = (float)IShapeProfileDef.OverallWidth / 2;
            float y1 = -(float)IShapeProfileDef.OverallDepth / 2;
            float y2 = y1 + (float)IShapeProfileDef.OverallWidth;
            float y3 = -(float)IShapeProfileDef.FlangeThickness - y1;
            float y4 = -y1;
            // Ignoring Curve
            PolyLine2D line = new PolyLine2D
            {
                { x3, y1 },
                { x3, y2 },
                { x1, y2 },
                { x1, y3 },
                { x2, y3 },
                { x2, y4 },
                { -x2, y4 },
                { -x2, y3 },
                { -x1, y3 },
                { -x1, y2 },
                { -x3, y2 },
                { -x3, y1 },
            };
            var moved = IFCGeoUtil.TransformPoints(IShapeProfileDef.Position, line);
            line = new PolyLine2D(moved);
            ProfileDef profileDef = new ProfileDef()
            {
                OutterCurve = line
            };
            return profileDef;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcprofileresource/lexical/ifclshapeprofiledef.htm
        public static ProfileDef GetProfileDef(IfcLShapeProfileDef LShapeProfileDef)
        {
            float x1 = (float)(LShapeProfileDef.Width / 2 - LShapeProfileDef.Thickness);
            float x2 = (float)(LShapeProfileDef.Width / 2);
            float y1 = (float)(LShapeProfileDef.Depth / 2 - LShapeProfileDef.Thickness);
            float y2 = (float)(LShapeProfileDef.Depth / 2);





            PolyLine2D line = new PolyLine2D
            {
                { x2, -y2 },
                { x2, -y1 },
                { -x1, -y1 },
               { -x1, y2 },
               { -x2, y2 },
               { -x2, -y2 },
            };
            var moved = IFCGeoUtil.TransformPoints(LShapeProfileDef.Position, line);
            line = new PolyLine2D(moved);
            ProfileDef profileDef = new ProfileDef()
            {
                OutterCurve = line
            };
            return profileDef;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcprofileresource/lexical/ifcrectangleprofiledef.htm
        public static ProfileDef GetProfileDef(IfcRectangleProfileDef RectangleProfileDef)
        {
            float w = (float) RectangleProfileDef.XDim / 2;
            float h = (float) RectangleProfileDef.YDim / 2;
            
          

            PolyLine2D line = new PolyLine2D
            {
                {w,-h },
                {w,h },
                {-w,h },
                {-w,-h },

            };
            var moved = IFCGeoUtil.TransformPoints(RectangleProfileDef.Position, line);
            line = new PolyLine2D(moved);
            ProfileDef profileDef = new ProfileDef()
            {
                OutterCurve = line
            };
            return profileDef;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcprofileresource/lexical/ifcrectanglehollowprofiledef.htm
        public static ProfileDef GetProfileDef(IfcRectangleHollowProfileDef RectangleHollowProfileDef)
        {
            float w = (float)RectangleHollowProfileDef.XDim / 2;
            float h = (float)RectangleHollowProfileDef.YDim / 2;
            float x = (float)RectangleHollowProfileDef.Position.Location.Coordinates[0];
            float y = (float)RectangleHollowProfileDef.Position.Location.Coordinates[1];


            PolyLine2D line = new PolyLine2D
            {
                {w,-h },
                {w,h },
                {-w,h },
                {-w,-h },

            };
            var moved = IFCGeoUtil.TransformPoints(RectangleHollowProfileDef.Position, line);
            line = new PolyLine2D(moved);
            ProfileDef profileDef = new ProfileDef()
            {
                OutterCurve = line
            };
            return profileDef;
       
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcprofileresource/lexical/ifcroundedrectangleprofiledef.htm
        public static ProfileDef GetProfileDef(IfcRoundedRectangleProfileDef RoundedRectangleProfileDef)
        {
            float w = (float)RoundedRectangleProfileDef.XDim / 2;
            float h = (float)RoundedRectangleProfileDef.YDim / 2;
            float r = (float)RoundedRectangleProfileDef.RoundingRadius;
        
            PolyLine2D line = new PolyLine2D
            {
                {w - r,-h },
                {w,-h + r},
                {w,h - r },
                {w - r,h },
                {-w + r,h },
                {-w,h - r },
                {-w,-h +r},
                {-w + r,-h},
            };
            var moved = IFCGeoUtil.TransformPoints(RoundedRectangleProfileDef.Position, line);
            line = new PolyLine2D(moved);
            ProfileDef profileDef = new ProfileDef()
            {
                OutterCurve = line
            };
            return profileDef;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcprofileresource/lexical/ifctshapeprofiledef.htm
        public static ProfileDef GetProfileDef(IfcTShapeProfileDef TShapeProfileDef)
        {
            float x1 = (float)TShapeProfileDef.WebThickness / 2;
            float x2 = (float)TShapeProfileDef.FlangeWidth / 2;
            float y1 = (float)(TShapeProfileDef.Depth / 2 - TShapeProfileDef.FlangeThickness);
            float y2 = (float)(TShapeProfileDef.Depth / 2 - TShapeProfileDef.FlangeThickness);

            PolyLine2D line = new PolyLine2D
            {
                {x1,-y2 },
                {x1,y1 },
                {x2,y1 },
                {x2,y2 },
                {-x2,y2 },
                {-x2,y1 },
                {-x1,y1 },
                {-x1,-y2 },
            };
            var moved = IFCGeoUtil.TransformPoints(TShapeProfileDef.Position, line);
            line = new PolyLine2D(moved);
            ProfileDef profileDef = new ProfileDef()
            {
                OutterCurve = line
            };
            return profileDef;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcprofileresource/lexical/ifctrapeziumprofiledef.htm
        public static ProfileDef GetProfileDef(IfcTrapeziumProfileDef TrapeziumProfileDef)
        {
            // Later
            ProfileDef profileDef = new ProfileDef();
            return profileDef;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcprofileresource/lexical/ifcushapeprofiledef.htm
        public static ProfileDef GetProfileDef(IfcUShapeProfileDef UShapeProfileDef)
        {
            float x1 = (float)(UShapeProfileDef.FlangeWidth / 2 - UShapeProfileDef.WebThickness);
            float x2 = (float)UShapeProfileDef.FlangeWidth / 2;
            float y1 = (float)(UShapeProfileDef.Depth / 2 - UShapeProfileDef.FlangeThickness);
            float y2 = (float)(UShapeProfileDef.Depth / 2);

            PolyLine2D line = new PolyLine2D
            {
                {x2,-y2 },
                {x2, -y1 },
                {-x1, -y1 },
                {-x1, y1 },
                {x2, y1 },
                {x2, y2 },
                {-x2, y2 },
                {-x1, y2 },
            };
            var moved = IFCGeoUtil.TransformPoints(UShapeProfileDef.Position, line);
            line = new PolyLine2D(moved);
            ProfileDef profileDef = new ProfileDef()
            {
                OutterCurve = line
            };
            return profileDef;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcprofileresource/lexical/ifczshapeprofiledef.htm
        public static ProfileDef GetProfileDef(IfcZShapeProfileDef ZShapeProfileDef)
        {
            float x1 = (float) ZShapeProfileDef.WebThickness;
            float x2 = (float)(ZShapeProfileDef.FlangeWidth - ZShapeProfileDef.WebThickness);
            float y1 = (float)(ZShapeProfileDef.Depth / 2 - ZShapeProfileDef.FlangeThickness);
            float y2 = (float)(ZShapeProfileDef.Depth / 2);
            PolyLine2D line = new PolyLine2D
            {
                {x2,-y2 },
                {x2, -y1 },
                {x1, -y1 },
                {x1, y2 },
                {-x2, y2 },
                {-x2, y1 },
                {-x1, y1 },
                {-x1, -y2 },
            };
            var moved = IFCGeoUtil.TransformPoints(ZShapeProfileDef.Position, line);
            line = new PolyLine2D(moved);
            ProfileDef profileDef = new ProfileDef()
            {
                OutterCurve = line
            };
            return profileDef;
        }


    }
}
