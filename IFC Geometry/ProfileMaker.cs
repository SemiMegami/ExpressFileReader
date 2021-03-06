using IFC_Geometry.IFCGeoReader;
using IFC4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using ThreeDMaker.Geometry.Dimension2;
using ThreeDMaker.Config;
namespace IFC_Geometry
{
    public static class ProfileMaker
    {
        static Performance pfm = new Performance();

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcprofileresource/lexical/ifcprofiledef.htm;
        public static Profile2D GetProfile(IfcProfileDef ProfileDef)
        {
            switch (ProfileDef.GetType().Name)
            {
                case EntityName.IFCARBITRARYCLOSEDPROFILEDEF: return GetProfile((IfcArbitraryClosedProfileDef)ProfileDef);
                case EntityName.IFCARBITRARYPROFILEDEFWITHVOIDS: return GetProfile((IfcArbitraryProfileDefWithVoids)ProfileDef);
                case EntityName.IFCARBITRARYOPENPROFILEDEF: return GetProfile((IfcArbitraryOpenProfileDef)ProfileDef);
                case EntityName.IFCCENTERLINEPROFILEDEF: return GetProfile((IfcCenterLineProfileDef)ProfileDef);
                case EntityName.IFCCOMPOSITEPROFILEDEF: return GetProfile((IfcCompositeProfileDef)ProfileDef);
                case EntityName.IFCDERIVEDPROFILEDEF:return GetProfile((IfcDerivedProfileDef)ProfileDef);
                case EntityName.IFCMIRROREDPROFILEDEF: return GetProfile((IfcMirroredProfileDef)ProfileDef);
                case EntityName.IFCASYMMETRICISHAPEPROFILEDEF: return GetProfile((IfcAsymmetricIShapeProfileDef)ProfileDef);
                case EntityName.IFCCSHAPEPROFILEDEF: return GetProfile((IfcCShapeProfileDef)ProfileDef);
                case EntityName.IFCCIRCLEPROFILEDEF: return GetProfile((IfcCircleProfileDef)ProfileDef);
                case EntityName.IFCCIRCLEHOLLOWPROFILEDEF:return GetProfile((IfcCircleHollowProfileDef)ProfileDef);
                case EntityName.IFCELLIPSEPROFILEDEF: return GetProfile((IfcEllipseProfileDef)ProfileDef);
                case EntityName.IFCISHAPEPROFILEDEF: return GetProfile((IfcIShapeProfileDef)ProfileDef);
                case EntityName.IFCLSHAPEPROFILEDEF: return GetProfile((IfcLShapeProfileDef)ProfileDef);
                case EntityName.IFCRECTANGLEPROFILEDEF: return GetProfile((IfcRectangleProfileDef)ProfileDef);
                case EntityName.IFCRECTANGLEHOLLOWPROFILEDEF: return GetProfile((IfcRectangleHollowProfileDef)ProfileDef);
                case EntityName.IFCROUNDEDRECTANGLEPROFILEDEF: return GetProfile((IfcRoundedRectangleProfileDef)ProfileDef);
                case EntityName.IFCTSHAPEPROFILEDEF: return GetProfile((IfcTShapeProfileDef)ProfileDef);
                case EntityName.IFCTRAPEZIUMPROFILEDEF: return GetProfile((IfcTrapeziumProfileDef)ProfileDef);
                case EntityName.IFCUSHAPEPROFILEDEF: return GetProfile((IfcUShapeProfileDef)ProfileDef);
                case EntityName.IFCZSHAPEPROFILEDEF: return GetProfile((IfcZShapeProfileDef)ProfileDef);
                default:return null;
            }
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcprofileresource/lexical/ifcarbitraryclosedprofiledef.htm
        public static Profile2D GetProfile(IfcArbitraryClosedProfileDef ArbitraryClosedProfileDef)
        {
            var outer = CurveMaker2D.GetCurve(ArbitraryClosedProfileDef.OuterCurve);
            //if(outer.Count == 0)
            //{
            //    return new Profile2D();
            //}
            List<Vector2> outerModified = new List<Vector2>() { outer[0] };
            for(int i = 1; i < outer.Count; i++)
            {
                var previous = outerModified[outerModified.Count - 1];
                if(Vector2.DistanceSquared(previous,outer[i]) > 0.0001)
                {
                    outerModified.Add(outer[i]);
                }
            }
            // make it close
            //if (Vector2.DistanceSquared(outerModified[outerModified.Count - 1], outerModified[0]) > 0.0001)
            //{
            //    outerModified.Add(outerModified[0]);
            //}

            Profile2D profileDef = new Profile2D();
            profileDef.OutterCurve = new Polygon2D(outerModified);
            return profileDef;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcprofileresource/lexical/ifcarbitraryprofiledefwithvoids.htm
        public static Profile2D GetProfile(IfcArbitraryProfileDefWithVoids ArbitraryProfileDefWithVoids)
        {
            Profile2D profileDef = new Profile2D();
            List<Vector2> outerModified = new List<Vector2>();
            var outer = CurveMaker2D.GetCurve(ArbitraryProfileDefWithVoids.OuterCurve);
            if(outer.Count > 0)
            {
                outerModified = new List<Vector2>() { outer[0] };
                for (int i = 1; i < outer.Count; i++)
                {
                    var previous = outerModified[outerModified.Count - 1];
                    if (Vector2.DistanceSquared(previous, outer[i]) > 0.0001)
                    {
                        outerModified.Add(outer[i]);
                    }

                }
            }
           
            //if (Vector2.DistanceSquared(outerModified[outerModified.Count - 1], outerModified[0]) > 0.0001)
            //{
            //    outerModified.Add(outerModified[0]);
            //}
            foreach (var innerCurve in ArbitraryProfileDefWithVoids.InnerCurves)
            {
                var inner = CurveMaker2D.GetCurve(innerCurve);

                if(inner.Count > 0)
                {
                    List<Vector2> innerModified = new List<Vector2>() { inner[0] };
                    for (int i = 1; i < inner.Count; i++)
                    {
                        var previous = innerModified[innerModified.Count - 1];
                        if (Vector2.DistanceSquared(previous, inner[i]) > 0.0001)
                        {
                            innerModified.Add(inner[i]);
                        }
                    }
                    profileDef.InnerCurves.Add(new Polygon2D(inner));
                }
                //if (Vector2.DistanceSquared(innerModified[innerModified.Count - 1], innerModified[0]) > 0.0001)
                //{
                //    innerModified.Add(innerModified[0]);
                //}
            }
            profileDef.OutterCurve = new Polygon2D(outerModified);


            if(ArbitraryProfileDefWithVoids.ifcid == "#1425969")
            {

            }
            return profileDef;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcprofileresource/lexical/ifcarbitraryopenprofiledef.htm
        public static Profile2D GetProfile(IfcArbitraryOpenProfileDef ArbitraryOpenProfileDef)
        {
            var outer = CurveMaker2D.GetCurve(ArbitraryOpenProfileDef.Curve);
            Profile2D profileDef = new Profile2D();
            profileDef.OutterCurve = new Polygon2D(outer);
            return profileDef;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcprofileresource/lexical/ifccenterlineprofiledef.htm
        public static Profile2D GetProfile(IfcCenterLineProfileDef CenterLineProfileDef)
        {
           
            Profile2D profileDef = new Profile2D();

            var curve = CurveMaker2D.GetCurve(CenterLineProfileDef.Curve);
            var t = CenterLineProfileDef.Thickness;
            Polyline2D polyline = new Polyline2D(curve);
            Polyline2D polyline1 = (Polyline2D) polyline.GetOffSet( t / 2);
            Polyline2D polyline2 = (Polyline2D) polyline.GetOffSet(-t / 2);
            List<Vector2> vector2s = new List<Vector2>();
            for (int i = 0; i < curve.Count; i++)
            {
                vector2s.Add(polyline1.points[i]);
            }
            for (int i = curve.Count - 1; i >= 0; i--)
            {
                vector2s.Add(polyline2.points[i]);
            }
            profileDef.OutterCurve = new Polygon2D(vector2s);

            return profileDef;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcprofileresource/lexical/ifccompositeprofiledef.htm
        public static Profile2D GetProfile(IfcCompositeProfileDef CompositeProfileDef)
        {
            //TO DO it should return multiple profile instead
            var profiles = CompositeProfileDef.Profiles;
            Profile2D profileDef = new Profile2D();
            foreach(var profile in profiles)
            {
                profileDef.Composites.Add(GetProfile(profile));
            }
            return profileDef;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcprofileresource/lexical/ifcderivedprofiledef.htm
        public static Profile2D GetProfile(IfcDerivedProfileDef DerivedProfileDef)
        {
            // TO DO
            IfcProfileDef parent = DerivedProfileDef.ParentProfile;
            IfcCartesianTransformationOperator2D transform = DerivedProfileDef.Operator;

            Profile2D parentDef = GetProfile(parent);
            var inners = parentDef.InnerCurves;
            var outter = parentDef.OutterCurve;


            Profile2D profileDef = new Profile2D();

            return profileDef;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcprofileresource/lexical/ifcmirroredprofiledef.htm
        public static Profile2D GetProfile(IfcMirroredProfileDef MirroredProfileDef)
        {
            // TO DO
            Profile2D profileDef = new Profile2D();
            return profileDef;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcprofileresource/lexical/ifcasymmetricishapeprofiledef.htm
        public static Profile2D GetProfile(IfcAsymmetricIShapeProfileDef AsymmetricIShapeProfileDef)
        {

            float x1 =  AsymmetricIShapeProfileDef.WebThickness / 2;
            float x2 = AsymmetricIShapeProfileDef.TopFlangeWidth / 2;
            float x3 = AsymmetricIShapeProfileDef.BottomFlangeWidth / 2;
            float y1 = - AsymmetricIShapeProfileDef.OverallDepth / 2;
            float y2 = y1 + AsymmetricIShapeProfileDef.BottomFlangeThickness;       
            float y3 = - AsymmetricIShapeProfileDef.TopFlangeThickness- y1;
            float y4 =  - y1;
            // Ignoring Curve
            Vector2s line = new Vector2s() {
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
            Profile2D profileDef = new Profile2D()
            {
                OutterCurve = new Polygon2D(moved)
            };
            return profileDef;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcprofileresource/lexical/ifccshapeprofiledef.htm
        public static Profile2D GetProfile(IfcCShapeProfileDef CShapeProfileDef)
        {
            // Assume no mirror
            // Ignore curve
            float x1 = (CShapeProfileDef.Width / 2 - CShapeProfileDef.WallThickness);
            float x2 = (CShapeProfileDef.Width / 2);
            float y1 = (CShapeProfileDef.Depth / 2 - CShapeProfileDef.Girth);
            float y2 = (CShapeProfileDef.Depth / 2 - CShapeProfileDef.WallThickness);
            float y3 = (CShapeProfileDef.Depth / 2);

            Vector2s line = new Vector2s()
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
            Profile2D profileDef = new Profile2D()
            {
                OutterCurve = new Polyline2D(moved)
            };
            return profileDef;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcprofileresource/lexical/ifccircleprofiledef.htm
        public static Profile2D GetProfile(IfcCircleProfileDef CircleProfileDef)
        {
            float r = CircleProfileDef.Radius;
          
            int n = pfm.curveDetail * 4;
            float dTheta = 2 * MathF.PI / n;
            List<Vector2> vector2s = new List<Vector2>();
            float theta;
            for(int i = 0; i < n; i++)
            {
                theta = i * dTheta / n;
                vector2s.Add(new Vector2(  r * MathF.Cos(theta),  r * MathF.Sin(theta)));

            }
            var moved = IFCGeoUtil.TransformPoints(CircleProfileDef.Position, vector2s);
            var line = new Polyline2D(moved);
            Profile2D profileDef = new Profile2D();
            profileDef.OutterCurve = line;
            return profileDef;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcprofileresource/lexical/ifccirclehollowprofiledef.htm
        public static Profile2D GetProfile(IfcCircleHollowProfileDef CircleHollowProfileDef)
        {
            //Ignore hollow
            float r = CircleHollowProfileDef.Radius;
            var location = CircleHollowProfileDef.Position.Location;
            float x = location.Coordinates[0];
            float y = location.Coordinates[1];
            int n = pfm.curveDetail * 4;
            float dTheta = 2 * MathF.PI / n;
            List<Vector2> vector2s = new List<Vector2>();
            float theta;
            for (int i = 0; i < n; i++)
            {
                theta = i * dTheta / n;
                vector2s.Add(new Vector2( r * MathF.Cos(theta),  r * MathF.Sin(theta)));

            }
            var moved = IFCGeoUtil.TransformPoints(CircleHollowProfileDef.Position, vector2s);
            var line = new Polyline2D(moved);
            Profile2D profileDef = new Profile2D();
            profileDef.OutterCurve = line;
            return profileDef;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcprofileresource/lexical/ifcellipseprofiledef.htm
        public static Profile2D GetProfile(IfcEllipseProfileDef EllipseProfileDef)
        {

            float r1 = EllipseProfileDef.SemiAxis1;
            float r2 = EllipseProfileDef.SemiAxis1;
          
            int n = pfm.curveDetail * 4;
            float dTheta = 2 * MathF.PI / n;
            List<Vector2> vector2s = new List<Vector2>();
            float theta;
            for (int i = 0; i < n; i++)
            {
                theta = i * dTheta / n;
                vector2s.Add(new Vector2( r1 * MathF.Cos(theta),  r2 * MathF.Sin(theta)));

            }
            var moved = IFCGeoUtil.TransformPoints(EllipseProfileDef.Position, vector2s);
            var line = new Polyline2D(moved);
            Profile2D profileDef = new Profile2D();
            profileDef.OutterCurve = line;
            return profileDef;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcprofileresource/lexical/ifcishapeprofiledef.htm
        public static Profile2D GetProfile(IfcIShapeProfileDef IShapeProfileDef)
        {
            float x1 = IShapeProfileDef.WebThickness / 2;
            float x2 = IShapeProfileDef.FlangeThickness / 2;
            float x3 = IShapeProfileDef.OverallWidth / 2;
            float y1 = -IShapeProfileDef.OverallDepth / 2;
            float y2 = y1 + IShapeProfileDef.OverallWidth;
            float y3 = -IShapeProfileDef.FlangeThickness - y1;
            float y4 = -y1;
            // Ignoring Curve
            Vector2s line = new Vector2s()
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
            Profile2D profileDef = new Profile2D()
            {
                OutterCurve = new Polyline2D(moved)
            };
            return profileDef;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcprofileresource/lexical/ifclshapeprofiledef.htm
        public static Profile2D GetProfile(IfcLShapeProfileDef LShapeProfileDef)
        {
            float x1 = (LShapeProfileDef.Width / 2 - LShapeProfileDef.Thickness);
            float x2 = (LShapeProfileDef.Width / 2);
            float y1 = (LShapeProfileDef.Depth / 2 - LShapeProfileDef.Thickness);
            float y2 = (LShapeProfileDef.Depth / 2);

            Vector2s line = new Vector2s()
            {
                { x2, -y2 },
                { x2, -y1 },
                { -x1, -y1 },
               { -x1, y2 },
               { -x2, y2 },
               { -x2, -y2 },
            };
            var moved = IFCGeoUtil.TransformPoints(LShapeProfileDef.Position, line);
            Profile2D profileDef = new Profile2D()
            {
                OutterCurve = new Polyline2D(moved)
            };
            return profileDef;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcprofileresource/lexical/ifcrectangleprofiledef.htm
        public static Profile2D GetProfile(IfcRectangleProfileDef RectangleProfileDef)
        {
            float w =  RectangleProfileDef.XDim / 2;
            float h =  RectangleProfileDef.YDim / 2;



            Vector2s line = new Vector2s()
            {
                {w,-h },
                {w,h },
                {-w,h },
                {-w,-h },
            };
            var moved = IFCGeoUtil.TransformPoints(RectangleProfileDef.Position, line);
            Profile2D profileDef = new Profile2D()
            {
                OutterCurve = new Polyline2D(moved)
            };
            return profileDef;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcprofileresource/lexical/ifcrectanglehollowprofiledef.htm
        public static Profile2D GetProfile(IfcRectangleHollowProfileDef RectangleHollowProfileDef)
        {
            float w = RectangleHollowProfileDef.XDim / 2;
            float h = RectangleHollowProfileDef.YDim / 2;
            float x = RectangleHollowProfileDef.Position.Location.Coordinates[0];
            float y = RectangleHollowProfileDef.Position.Location.Coordinates[1];


            Vector2s line = new Vector2s()
            {
                {w,-h },
                {w,h },
                {-w,h },
                {-w,-h },
            };
            var moved = IFCGeoUtil.TransformPoints(RectangleHollowProfileDef.Position, line);
            Profile2D profileDef = new Profile2D()
            {
                OutterCurve = new Polyline2D(moved)
            };
            return profileDef;
       
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcprofileresource/lexical/ifcroundedrectangleprofiledef.htm
        public static Profile2D GetProfile(IfcRoundedRectangleProfileDef RoundedRectangleProfileDef)
        {
            float w = RoundedRectangleProfileDef.XDim / 2;
            float h = RoundedRectangleProfileDef.YDim / 2;
            float r = RoundedRectangleProfileDef.RoundingRadius;

            Vector2s line = new Vector2s()
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
            Profile2D profileDef = new Profile2D()
            {
                OutterCurve = new Polyline2D(moved)
            };
            return profileDef;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcprofileresource/lexical/ifctshapeprofiledef.htm
        public static Profile2D GetProfile(IfcTShapeProfileDef TShapeProfileDef)
        {
            float x1 = TShapeProfileDef.WebThickness / 2;
            float x2 = TShapeProfileDef.FlangeWidth / 2;
            float y1 = (TShapeProfileDef.Depth / 2 - TShapeProfileDef.FlangeThickness);
            float y2 = (TShapeProfileDef.Depth / 2 - TShapeProfileDef.FlangeThickness);

            Vector2s line = new Vector2s()
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
            Profile2D profileDef = new Profile2D()
            {
                OutterCurve = new Polyline2D(moved)
            };
            return profileDef;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcprofileresource/lexical/ifctrapeziumprofiledef.htm
        public static Profile2D GetProfile(IfcTrapeziumProfileDef TrapeziumProfileDef)
        {
            // Later
            Profile2D profileDef = new Profile2D();
            return profileDef;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcprofileresource/lexical/ifcushapeprofiledef.htm
        public static Profile2D GetProfile(IfcUShapeProfileDef UShapeProfileDef)
        {
            float x1 = (UShapeProfileDef.FlangeWidth / 2 - UShapeProfileDef.WebThickness);
            float x2 = UShapeProfileDef.FlangeWidth / 2;
            float y1 = (UShapeProfileDef.Depth / 2 - UShapeProfileDef.FlangeThickness);
            float y2 = (UShapeProfileDef.Depth / 2);

            Vector2s line = new Vector2s()
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
            Profile2D profileDef = new Profile2D()
            {
                OutterCurve = new Polyline2D(moved)
            };
            return profileDef;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcprofileresource/lexical/ifczshapeprofiledef.htm
        public static Profile2D GetProfile(IfcZShapeProfileDef ZShapeProfileDef)
        {
            float x1 =  ZShapeProfileDef.WebThickness;
            float x2 = (ZShapeProfileDef.FlangeWidth - ZShapeProfileDef.WebThickness);
            float y1 = (ZShapeProfileDef.Depth / 2 - ZShapeProfileDef.FlangeThickness);
            float y2 = (ZShapeProfileDef.Depth / 2);
            Vector2s line = new Vector2s()
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
            Profile2D profileDef = new Profile2D()
            {
                OutterCurve = new Polyline2D(moved)
        };
            return profileDef;
        }


    }
}
