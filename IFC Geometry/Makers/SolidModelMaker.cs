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
    public class SolidModelMaker
    {
        public static Mesh3D GetSolid(IfcSolidModel SolidModel)
        {
            switch (SolidModel.GetType().Name)
            {
                case EntityName.IFCCSGSOLID:return GetSolid((IfcCsgSolid)SolidModel);
                case EntityName.IFCADVANCEDBREP: return GetSolid((IfcAdvancedBrep)SolidModel);
                case EntityName.IFCADVANCEDBREPWITHVOIDS: return GetSolid((IfcAdvancedBrepWithVoids)SolidModel);
                case EntityName.IFCFACETEDBREP: return GetSolid((IfcFacetedBrep)SolidModel);
                case EntityName.IFCFACETEDBREPWITHVOIDS: return GetSolid((IfcFacetedBrepWithVoids)SolidModel);
                case EntityName.IFCEXTRUDEDAREASOLID: return GetSolid((IfcExtrudedAreaSolid)SolidModel);
                case EntityName.IFCEXTRUDEDAREASOLIDTAPERED: return GetSolid((IfcExtrudedAreaSolidTapered)SolidModel);
                case EntityName.IFCFIXEDREFERENCESWEPTAREASOLID: return GetSolid((IfcFixedReferenceSweptAreaSolid)SolidModel);
                case EntityName.IFCREVOLVEDAREASOLID: return GetSolid((IfcRevolvedAreaSolid)SolidModel);
                case EntityName.IFCREVOLVEDAREASOLIDTAPERED: return GetSolid((IfcRevolvedAreaSolidTapered)SolidModel);
                case EntityName.IFCSURFACECURVESWEPTAREASOLID: return GetSolid((IfcSurfaceCurveSweptAreaSolid)SolidModel);
                case EntityName.IFCSWEPTDISKSOLID: return GetSolid((IfcSweptDiskSolid)SolidModel);
                case EntityName.IFCSWEPTDISKSOLIDPOLYGONAL: return GetSolid((IfcSweptDiskSolidPolygonal)SolidModel);
                default: return null;
            }
        }
        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcgeometricmodelresource/lexical/ifccsgsolid.htm
        public static Mesh3D GetSolid(IfcCsgSolid CsgSolid)
        {
            Mesh3D Mesh3D = new Mesh3D();
            return Mesh3D;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcgeometricmodelresource/lexical/ifcadvancedbrep.htm
        public static Mesh3D GetSolid(IfcAdvancedBrep AdvancedBrep)
        {
            Mesh3D Mesh3D = new Mesh3D();
            return Mesh3D;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcgeometricmodelresource/lexical/ifcadvancedbrepwithvoids.htm
        public static Mesh3D GetSolid(IfcAdvancedBrepWithVoids AdvancedBrepWithVoids)
        {
            Mesh3D Mesh3D = new Mesh3D();
            return Mesh3D;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcgeometricmodelresource/lexical/ifcfacetedbrep.htm
        public static Mesh3D GetSolid(IfcFacetedBrep FacetedBrep)
        {
            Mesh3D Mesh3D = new Mesh3D();
            return Mesh3D;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcgeometricmodelresource/lexical/ifcfacetedbrepwithvoids.htm
        public static Mesh3D GetSolid(IfcFacetedBrepWithVoids FacetedBrepWithVoids)
        {
            Mesh3D Mesh3D = new Mesh3D();
            return Mesh3D;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcgeometricmodelresource/lexical/ifcextrudedareasolid.htm
        public static Mesh3D GetSolid(IfcExtrudedAreaSolid ExtrudedAreaSolid)
        {
            var sweptArea = ExtrudedAreaSolid.SweptArea;
            var profileDef = ProfileDefMaker.GetProfileDef(sweptArea);
            Mesh3D Mesh3D = new Mesh3D();
            return Mesh3D;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcgeometricmodelresource/lexical/ifcextrudedareasolidtapered.htm
        public static Mesh3D GetSolid(IfcExtrudedAreaSolidTapered ExtrudedAreaSolidTapered)
        {
            Mesh3D Mesh3D = new Mesh3D();
            return Mesh3D;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcgeometricmodelresource/lexical/ifcfixedreferencesweptareasolid.htm
        public static Mesh3D GetSolid(IfcFixedReferenceSweptAreaSolid FixedReferenceSweptAreaSolid)
        {
            Mesh3D Mesh3D = new Mesh3D();
            return Mesh3D;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcgeometricmodelresource/lexical/ifcrevolvedareasolid.htm
        public static Mesh3D GetSolid(IfcRevolvedAreaSolid RevolvedAreaSolid)
        {
            Mesh3D Mesh3D = new Mesh3D();
            return Mesh3D;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcgeometricmodelresource/lexical/ifcrevolvedareasolidtapered.htm
        public static Mesh3D GetSolid(IfcRevolvedAreaSolidTapered RevolvedAreaSolidTapered)
        {
            Mesh3D Mesh3D = new Mesh3D();
            return Mesh3D;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcgeometricmodelresource/lexical/ifcsurfacecurvesweptareasolid.htm
        public static Mesh3D GetSolid(IfcSurfaceCurveSweptAreaSolid SurfaceCurveSweptAreaSolid)
        {
            Mesh3D Mesh3D = new Mesh3D();
            return Mesh3D;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcgeometricmodelresource/lexical/ifcsweptdisksolid.htm
        public static Mesh3D GetSolid(IfcSweptDiskSolid SweptDiskSolid)
        {
            Mesh3D Mesh3D = new Mesh3D();
            return Mesh3D;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcgeometricmodelresource/lexical/ifcsweptdisksolidpolygonal.htm
        public static Mesh3D GetSolid(IfcSweptDiskSolidPolygonal SweptDiskSolidPolygonal)
        {
            Mesh3D Mesh3D = new Mesh3D();
            return Mesh3D;
        }




    }
}
