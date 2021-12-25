using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IFC4;
using System.Numerics;
namespace IFC_Geometry.IFCGeoReader
{
    public class IFCGeoUtil
    {



        public static Vector3 TransformPoint(IfcElement element, Vector3 v)
        {

           var objectPlacement = element.ObjectPlacement;
          
            if (objectPlacement.InTypeOf(EntityName.IFCLOCALPLACEMENT)){
                return TransformPoint((IfcLocalPlacement)objectPlacement, v);
            }
            return v;
        }

        public static Vector3 TransformPoint(IfcLocalPlacement localplacemnt, Vector3 v)
        {

            var relativePlacement = (IfcAxis2Placement3D)localplacemnt.RelativePlacement;
            if(relativePlacement == null)
            {
                return v;
            }
            Vector3 v1 = TransformPoint(relativePlacement, v);
            if (localplacemnt.PlacementRelTo == null)
            {
                return v1;
            }

            return TransformPoint((IfcLocalPlacement)localplacemnt.PlacementRelTo, v1);

        }


        public static Vector3 TransformPoint(IfcAxis2Placement3D position, Vector3 V)
        {

            var coordinate = position.Location.Coordinates;
            var P = position.P;

            var x = coordinate[0] + P[0].DirectionRatios[0] * V.X + P[1].DirectionRatios[0] * V.Y + P[2].DirectionRatios[0] * V.Z;
            var y = coordinate[1] + P[0].DirectionRatios[1] * V.X + P[1].DirectionRatios[1] * V.Y + P[2].DirectionRatios[1] * V.Z;
            var z = coordinate[2] + P[0].DirectionRatios[2] * V.X + P[1].DirectionRatios[2] * V.Y + P[2].DirectionRatios[2] * V.Z;

            return new Vector3((float)x, (float)y, (float)z);
        }



        public static Vector3 TransformVector(IfcAxis2Placement3D position, Vector3 V)
        {
            var P = position.P;

            var x = P[0].DirectionRatios[0] * V.X + P[0].DirectionRatios[1] * V.Y + P[0].DirectionRatios[2] * V.Z;
            var y = P[1].DirectionRatios[0] * V.X + P[1].DirectionRatios[1] * V.Y + P[1].DirectionRatios[2] * V.Z;
            var z = P[2].DirectionRatios[0] * V.X + P[2].DirectionRatios[1] * V.Y + P[2].DirectionRatios[2] * V.Z;

            return new Vector3((float)x, (float)y, (float)z);
        }

        public static Vector3 TransformPoint(IfcCartesianTransformationOperator2D transform, Vector3 v)
        {

            return v;
        }
        public static Vector3 TransformPoint(IfcCartesianTransformationOperator3D transform, Vector3 V)
        {
            var U = transform.U;
            var s = transform.Scl;
            var origin = transform.LocalOrigin.Coordinates;
            var x = origin[0] + s * (U[0].DirectionRatios[0] * V.X + U[0].DirectionRatios[1] * V.Y + U[0].DirectionRatios[2] * V.Z);
            var y = origin[1] + s * (U[1].DirectionRatios[0] * V.X + U[1].DirectionRatios[1] * V.Y + U[1].DirectionRatios[2] * V.Z);
            var z = origin[2] + s * (U[2].DirectionRatios[0] * V.X + U[2].DirectionRatios[1] * V.Y + U[2].DirectionRatios[2] * V.Z);
            return new Vector3((float)x, (float)y, (float)z);
        }

        Vector2 TransformPoint(IfcCartesianTransformationOperator2D transform, Vector2 vector)
        {
            var u = transform.U;
            // transform.a
            return new Vector2();
        }

        

        Vector2 GetAxisChange(IfcDirection axis1, IfcDirection axis2, Vector2 vector)
        {
            // transform.a
            return new Vector2();
        }
        Vector2 GetTranslate(IfcCartesianPoint LocalOrigin, Vector2 vector)
        {
            // transform.a
            return new Vector2(vector.X * (float)LocalOrigin.Coordinates[0], vector.Y * (float)LocalOrigin.Coordinates[1]);
        
        }
        Vector2 GetScale(IfcReal scale, Vector2 vector)
        {
            // transform.a
            return new Vector2(vector.X * (float)scale,  vector.Y * (float)scale);
        }
    }
}
