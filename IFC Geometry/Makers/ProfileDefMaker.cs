using IFC4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

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
                case EntityName.IFCCOMPOSITEPROFILEDEF: return GetProfileDef((IfcCompositeProfileDef)ProfileDef);
                case EntityName.IFCDERIVEDPROFILEDEF:return GetProfileDef((IfcDerivedProfileDef)ProfileDef);
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

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcprofileresource/lexical/ifcarbitraryclosedprofiledef.htm
        public static ProfileDef GetProfileDef(IfcArbitraryClosedProfileDef ArbitraryClosedProfileDef)
        {
            var outer = CurveMaker.GetCurve(ArbitraryClosedProfileDef.OuterCurve);
            List<Vector2> vector2s = new List<Vector2>();
            for (int i = 0; i < outer.Count; i++)
            {
                vector2s.Add(new Vector2(outer[i].X,outer[i].Y));
            }
            ProfileDef profileDef = new ProfileDef();
            profileDef.OutterCurve = vector2s;
            return profileDef;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcprofileresource/lexical/ifcarbitraryprofiledefwithvoids.htm
        public static ProfileDef GetProfileDef(IfcArbitraryProfileDefWithVoids ArbitraryProfileDefWithVoids)
        {
            ProfileDef profileDef = new ProfileDef();
            return profileDef;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcprofileresource/lexical/ifcarbitraryopenprofiledef.htm
        public static ProfileDef GetProfileDef(IfcArbitraryOpenProfileDef ArbitraryOpenProfileDef)
        {
            ProfileDef profileDef = new ProfileDef();
            return profileDef;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcprofileresource/lexical/ifccenterlineprofiledef.htm
        public static ProfileDef GetProfileDef(IfcCenterLineProfileDef CenterLineProfileDef)
        {
            ProfileDef profileDef = new ProfileDef();
            return profileDef;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcprofileresource/lexical/ifccompositeprofiledef.htm
        public static ProfileDef GetProfileDef(IfcCompositeProfileDef CompositeProfileDef)
        {
            ProfileDef profileDef = new ProfileDef();
            return profileDef;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcprofileresource/lexical/ifcderivedprofiledef.htm
        public static ProfileDef GetProfileDef(IfcDerivedProfileDef DerivedProfileDef)
        {
            ProfileDef profileDef = new ProfileDef();
            return profileDef;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcprofileresource/lexical/ifcmirroredprofiledef.htm
        public static ProfileDef GetProfileDef(IfcMirroredProfileDef MirroredProfileDef)
        {
            ProfileDef profileDef = new ProfileDef();
            return profileDef;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcprofileresource/lexical/ifcasymmetricishapeprofiledef.htm
        public static ProfileDef GetProfileDef(IfcAsymmetricIShapeProfileDef AsymmetricIShapeProfileDef)
        {
            ProfileDef profileDef = new ProfileDef();
            return profileDef;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcprofileresource/lexical/ifccshapeprofiledef.htm
        public static ProfileDef GetProfileDef(IfcCShapeProfileDef CShapeProfileDef)
        {
            ProfileDef profileDef = new ProfileDef();
            return profileDef;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcprofileresource/lexical/ifccircleprofiledef.htm
        public static ProfileDef GetProfileDef(IfcCircleProfileDef CircleProfileDef)
        {
            double r = CircleProfileDef.Radius;
            var location = CircleProfileDef.Position.Location;
            double x = location.Coordinates[0];
            double y = location.Coordinates[1];
            int n = pfm.curveDetail * 4;
            double dTheta = 2 * Math.PI / n;
            List<Vector2> vector2s = new List<Vector2>();
            double theta;
            for(int i = 0; i < n; i++)
            {
                theta = i * dTheta / n;
                vector2s.Add(new Vector2((float) (x + r * Math.Cos(theta)), (float)(y + r * Math.Cos(theta))));

            }
            ProfileDef profileDef = new ProfileDef();
            profileDef.OutterCurve = vector2s;
            return profileDef;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcprofileresource/lexical/ifccirclehollowprofiledef.htm
        public static ProfileDef GetProfileDef(IfcCircleHollowProfileDef CircleHollowProfileDef)
        {
            ProfileDef profileDef = new ProfileDef();
            return profileDef;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcprofileresource/lexical/ifcellipseprofiledef.htm
        public static ProfileDef GetProfileDef(IfcEllipseProfileDef EllipseProfileDef)
        {
            ProfileDef profileDef = new ProfileDef();
            return profileDef;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcprofileresource/lexical/ifcishapeprofiledef.htm
        public static ProfileDef GetProfileDef(IfcIShapeProfileDef IShapeProfileDef)
        {
            ProfileDef profileDef = new ProfileDef();
            return profileDef;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcprofileresource/lexical/ifclshapeprofiledef.htm
        public static ProfileDef GetProfileDef(IfcLShapeProfileDef LShapeProfileDef)
        {
            ProfileDef profileDef = new ProfileDef();
            return profileDef;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcprofileresource/lexical/ifcrectangleprofiledef.htm
        public static ProfileDef GetProfileDef(IfcRectangleProfileDef RectangleProfileDef)
        {
            double w = RectangleProfileDef.XDim;
            double h = RectangleProfileDef.YDim;
            double x = RectangleProfileDef.Position.Location.Coordinates[0];
            double y = RectangleProfileDef.Position.Location.Coordinates[1];
            double dirx1 = RectangleProfileDef.Position.P[0].DirectionRatios[0];
            double diry1 = RectangleProfileDef.Position.P[0].DirectionRatios[1];
            double dirx2 = RectangleProfileDef.Position.P[1].DirectionRatios[0];
            double diry2 = RectangleProfileDef.Position.P[1].DirectionRatios[1];
            
            ProfileDef profileDef = new ProfileDef();
            return profileDef;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcprofileresource/lexical/ifcrectanglehollowprofiledef.htm
        public static ProfileDef GetProfileDef(IfcRectangleHollowProfileDef RectangleHollowProfileDef)
        {
            ProfileDef profileDef = new ProfileDef();
            return profileDef;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcprofileresource/lexical/ifcroundedrectangleprofiledef.htm
        public static ProfileDef GetProfileDef(IfcRoundedRectangleProfileDef RoundedRectangleProfileDef)
        {
            ProfileDef profileDef = new ProfileDef();
            return profileDef;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcprofileresource/lexical/ifctshapeprofiledef.htm
        public static ProfileDef GetProfileDef(IfcTShapeProfileDef TShapeProfileDef)
        {
            ProfileDef profileDef = new ProfileDef();
            return profileDef;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcprofileresource/lexical/ifctrapeziumprofiledef.htm
        public static ProfileDef GetProfileDef(IfcTrapeziumProfileDef TrapeziumProfileDef)
        {
            ProfileDef profileDef = new ProfileDef();
            return profileDef;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcprofileresource/lexical/ifcushapeprofiledef.htm
        public static ProfileDef GetProfileDef(IfcUShapeProfileDef UShapeProfileDef)
        {
            ProfileDef profileDef = new ProfileDef();
            return profileDef;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcprofileresource/lexical/ifczshapeprofiledef.htm
        public static ProfileDef GetProfileDef(IfcZShapeProfileDef ZShapeProfileDef)
        {
            ProfileDef profileDef = new ProfileDef();
            return profileDef;
        }


    }
}
