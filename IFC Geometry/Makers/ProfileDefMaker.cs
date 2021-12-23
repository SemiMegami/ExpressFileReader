﻿using IFC4;
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
           
            ProfileDef profileDef = new ProfileDef();
            return profileDef;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcprofileresource/lexical/ifcarbitraryclosedprofiledef.htm
        public static ProfileDef GetProfileDef(IfcArbitraryClosedProfileDef ArbitraryClosedProfileDef)
        {
            var outer = CurveMaker.GetCurve((IfcPolyline) ArbitraryClosedProfileDef.OuterCurve);
            // IfcCurve outerCurve =;
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