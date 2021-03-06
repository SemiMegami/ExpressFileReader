using IFC_Geometry.IFCGeoReader;
using IFC4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using ThreeDMaker.Geometry;
using ThreeDMaker.Geometry.Dimension2;
namespace IFC_Geometry
{
    public class SolidModelMaker
    {

        public static List<Mesh3D> GetSolids(IfcMappedItem mappedItem, Dictionary<IfcSolidModel, Mesh3D> solidDict)
        {
            List<Mesh3D> meshes = new List<Mesh3D>();
            var mappedItems = mappedItem.MappingSource.MappedRepresentation.Items;
            var origin = mappedItem.MappingSource.MappingOrigin;
            var t = mappedItem.MappingTarget;

            foreach (var item in mappedItems)
            {

                if (item.InTypeOf(EntityName.IFCSOLIDMODEL))
                {


                    Mesh3D mesh = new Mesh3D(solidDict[(IfcSolidModel)item]);
                    if (mesh != null)
                    {
                        meshes.Add(mesh);
                    }
                }
                else if (item.InTypeOf(EntityName.IFCMAPPEDITEM))
                {
                    meshes.AddRange(GetSolids((IfcMappedItem)item, solidDict));
                }
                else
                {

                }
            }
          //  int count = 0;
            foreach (var mesh in meshes)
            {
                var vertices = mesh.Vertices;
                for (int i = 0; i < vertices.Count; i++)
                {
                    vertices[i] = IFCGeoUtil.TransformPoint((IfcAxis2Placement3D) origin, vertices[i]);
                    if(t!= null)
                    {
                        vertices[i] = IFCGeoUtil.TransformPoint((IfcCartesianTransformationOperator3D)t, vertices[i]);
                    }
               //     vertices[i] += new Vector3(0, 0, count * 500);
                }
          //      count++;
            }


            return meshes;
        }

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
            var outters = FacetedBrep.Outer.CfsFaces;
            int counter;
            ProfileMesh m;
            foreach (var outter in outters)
            {
                var bounds = outter.Bounds;
                foreach (var bound in bounds)
                {
                    var loop = (IfcPolyLoop)bound.Bound;
                    var points = loop.Polygon;
                    List<Vector3> meshPoints = new List<Vector3>();
                    var orientation = bound.Orientation;
                    foreach (var p in points)
                    { 
                        meshPoints.Add(new Vector3(p.Coordinates[0], p.Coordinates[1], p.Coordinates[2]));
                    }
                    m = new ProfileMesh(meshPoints);
                    counter = Mesh3D.Vertices.Count;
                    Mesh3D.Vertices.AddRange(m.Vertices);
                    foreach(var i in m.Triangles)
                    {
                        Mesh3D.Triangles.Add(i + counter);
                    }
                   
                }
                
            }
            
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
            var profileDef = ProfileMaker.GetProfile(sweptArea);
            if(profileDef.OutterCurve == null)
            {
                return new Mesh3D() ;
            }

            float d = ExtrudedAreaSolid.Depth;
            var direction = ExtrudedAreaSolid.ExtrudedDirection.DirectionRatios;


            Path3D path = new Path3D();
            path.Add(new AxisPoint3D());


          
            Vector3 right = new Vector3(1, 0, 0);
            Vector3 up = new Vector3(0, 1, 0);
            Vector3 front = new Vector3(0, 0, 1);
            AxisPoint3D p0 = new AxisPoint3D()
            {
                Position = new Vector3(0, 0, 0),
                Front = front,
                Right = right,
                Up = up

            };
            AxisPoint3D p1 = new AxisPoint3D()
            {
                Position = new Vector3(direction[0] * d, direction[1] * d, direction[2] * d),
                Front = front,
                Right = right,
                Up = up

            };

            //AxisPoint3D p1 = new AxisPoint3D()
            //{
            //    Position = new Vector3(0, 0, 1),
            //    Front = front,
            //    Right = right,
            //    Up = up

            //};
            Path3D point3Ds = new Path3D() { p0, p1 };

           
          //  Mesh3D Mesh3D = new ExtrudePathMesh(profileDef.OutterCurve, point3Ds);
            Mesh3D Mesh3D = new ExtrudePathMesh(profileDef.OutterCurve, point3Ds, profileDef.InnerCurves);
            if(direction[2] < 0)
            {
                Mesh3D.FlipFace();
            }
            var vertices = Mesh3D.Vertices;
            for (int i = 0; i < vertices.Count; i++)
            {
                vertices[i] = IFCGeoUtil.TransformPoint(ExtrudedAreaSolid.Position, vertices[i]);
            }


            //  return new Mesh3D();

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

        public static Mesh3D GetSolid(IfcTessellatedItem SolidModel)
        {
            switch (SolidModel.GetType().Name)
            {
                case EntityName.IFCINDEXEDPOLYGONALFACE: return GetSolid((IfcIndexedPolygonalFace)SolidModel);
                case EntityName.IFCPOLYGONALFACESET: return GetSolid((IfcPolygonalFaceSet)SolidModel);
                case EntityName.IFCTRIANGULATEDFACESET: return GetSolid((IfcTriangulatedFaceSet)SolidModel);
                default: return null;
            }
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcgeometricmodelresource/lexical/ifcindexedpolygonalface.htm
        public static Mesh3D GetSolid(IfcIndexedPolygonalFace indexedPolygonalFace)
        {
            var indice = indexedPolygonalFace.CoordIndex;

            var faceset = indexedPolygonalFace.ToFaceSet;

            Mesh3D Mesh3D = new Mesh3D();
            foreach (var face in faceset)
            {
                //face.Coordinates

                var points = face.Coordinates.CoordList;
                List<Vector3> facePoints = new List<Vector3>();
            
                foreach (var p in points)
                {
                    facePoints.Add(new Vector3(p[0], p[1], p[2]));
                }
                if( face.PnIndex!= null)
                {
                    foreach(var index in face.PnIndex)
                    {
                        facePoints.Add(new Vector3(points[index - 1][0], points[index - 1][1], points[index - 1][2]));
                    }
                }
                else
                {
                    foreach (var p in points)
                    {
                        facePoints.Add(new Vector3(p[0], p[1], p[2]));
                    }
                }
                List<Vector3> meshPoints;

                if(indice!= null)
                {
                    meshPoints = new List<Vector3>();
                    foreach (var index in indice)
                    {
                        meshPoints.Add(facePoints[index - 1]);
                    }
                }
                else
                {
                    meshPoints = facePoints;
                }

                var m = new ProfileMesh(meshPoints);
                var counter = Mesh3D.Vertices.Count;
                Mesh3D.Vertices.AddRange(m.Vertices);
                foreach (var i in m.Triangles)
                {
                    Mesh3D.Triangles.Add(i + counter);
                }

            }
          
            return Mesh3D;
        }

        //https://standards.buildingsmart.org/IFC/DEV/IFC4_3/RC1/HTML/schema/ifcgeometricmodelresource/lexical/ifcpolygonalfaceset.htm
        public static Mesh3D GetSolid(IfcPolygonalFaceSet polygonalFaceSet)
        {
            var points = polygonalFaceSet.Coordinates.CoordList;
            List<Vector3> facePoints = new List<Vector3>();

            foreach (var p in points)
            {
                facePoints.Add(new Vector3(p[0], p[1], p[2]));
            }
            if (polygonalFaceSet.PnIndex != null)
            {
                foreach (var index in polygonalFaceSet.PnIndex)
                {
                    facePoints.Add(new Vector3(points[index - 1][0], points[index - 1][1], points[index - 1][2]));
                }
            }
            else
            {
                foreach (var p in points)
                {
                    facePoints.Add(new Vector3(p[0], p[1], p[2]));
                }
            }
  

            var Mesh3D = new ProfileMesh(facePoints);
            return Mesh3D;
        }

        //http://docs.buildingsmartalliance.org/MVD_SPARKIE/schema/ifcgeometricmodelresource/lexical/ifctriangulatedfaceset.htm
        public static Mesh3D GetSolid(IfcTriangulatedFaceSet triangulatedFaceSet)
        {
            Mesh3D Mesh3D = new Mesh3D();
            return Mesh3D;
        }
    }
}
