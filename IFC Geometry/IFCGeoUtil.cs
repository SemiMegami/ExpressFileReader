using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IFC4;
using System.Numerics;
using ThreeDMaker.Geometry.Dimension2;
namespace IFC_Geometry.IFCGeoReader
{
    public class IFCGeoUtil
    {


        static Dictionary<IfcLocalPlacement, List <Matrix4x4>> SetLocalMats (List <IfcLocalPlacement> placements)
        {
           Dictionary<IfcLocalPlacement, List <Matrix4x4>> dict = new Dictionary<IfcLocalPlacement, List <Matrix4x4>>();
            // 0 local
            // 1 global
            foreach(var placement in placements)
            {
                if (IfcBase.InTypeOf<IfcAxis2Placement3D>(placement.RelativePlacement))
                {
                    var mat = ToMatrix((IfcAxis2Placement3D)placement.RelativePlacement);
                    dict.Add(placement, new List <Matrix4x4>() { mat, mat });
                }
               
            }

            return dict;
          
        }

        static void UpdateGlobalMat(Dictionary<IfcLocalPlacement, List <Matrix4x4>> dict, IfcLocalPlacement head)
        {
          //  if (head.ReferencedByPlacements == null) return;
            var headMat = dict[head][1];
            var children = dict.Keys.Where(p => p.PlacementRelTo == head).ToList();          
            foreach (var child in children)
            {
                dict[child][1] = Matrix4x4.Multiply(headMat, dict[child][0]);
                UpdateGlobalMat(dict, child);
            }
        }

        public static Dictionary<IfcLocalPlacement, List <Matrix4x4>> SetGlobalMat(List<IfcLocalPlacement> placements)
        {
            Dictionary<IfcLocalPlacement, List <Matrix4x4>> dict = SetLocalMats(placements);

            var heads = dict.Keys.Where(p => p.PlacementRelTo == null).ToList();
            foreach (var head in heads)
            {
                UpdateGlobalMat(dict, head);
            }
            return dict;
          
        }

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

        public static Vector2 TransformPoint(IfcLocalPlacement localplacemnt, Vector2 v)
        {
            var relativePlacement = (IfcAxis2Placement2D)localplacemnt.RelativePlacement;
            if (relativePlacement == null)
            {
                return v;
            }
            Vector2 v1 = TransformPoint(relativePlacement, v);
            if (localplacemnt.PlacementRelTo == null)
            {
                return v1;
            }
            return TransformPoint((IfcLocalPlacement)localplacemnt.PlacementRelTo, v1);
        }

        public static Matrix4x4 ToMatrix(IfcAxis2Placement3D position)
        {
            var coordinate = position.Location.Coordinates;
            var P = position.P;
            Matrix4x4 M = new Matrix4x4()
            {
                M11 = (float)P[0].DirectionRatios[0],
                M12 = (float)P[1].DirectionRatios[0],
                M13 = (float)P[2].DirectionRatios[0],
                M14 = (float)coordinate[0],

                M21 = (float)P[0].DirectionRatios[1],
                M22 = (float)P[1].DirectionRatios[1],
                M23 = (float)P[2].DirectionRatios[1],
                M24 = (float)coordinate[1],

                M31 = (float)P[0].DirectionRatios[2],
                M32 = (float)P[1].DirectionRatios[2],
                M33 = (float)P[2].DirectionRatios[2],
                M34 = (float)coordinate[2],

                M41 = 0,
                M42 = 0,
                M43 = 0,
                M44 = 1,
            };

            return M;
        }

        public static Vector3 TransformPoint(IfcAxis2Placement3D position, Vector3 v)
        {
            var coordinate = position.Location.Coordinates;
            var P = position.P;
            var x = coordinate[0] + P[0].DirectionRatios[0] * v.X + P[1].DirectionRatios[0] * v.Y + P[2].DirectionRatios[0] * v.Z;
            var y = coordinate[1] + P[0].DirectionRatios[1] * v.X + P[1].DirectionRatios[1] * v.Y + P[2].DirectionRatios[1] * v.Z;
            var z = coordinate[2] + P[0].DirectionRatios[2] * v.X + P[1].DirectionRatios[2] * v.Y + P[2].DirectionRatios[2] * v.Z;

            return new Vector3((float)x, (float)y, (float)z);
        }
        public static Vector2 TransformPoint(IfcAxis2Placement2D position, Vector2 v)
        {
            var coordinate = position.Location.Coordinates;
            var P = position.P;
            var x = coordinate[0] + P[0].DirectionRatios[0] * v.X + P[1].DirectionRatios[0] * v.Y;
            var y = coordinate[1] + P[0].DirectionRatios[1] * v.X + P[1].DirectionRatios[1] * v.Y;
            return new Vector2((float)x, (float)y);
        }

        public static List<Vector2> TransformPoints(IfcAxis2Placement2D position, List<Vector2> vs)
        {
            var coordinate = position.Location.Coordinates;
            var P = position.P;
            List<Vector2> V2 = new List<Vector2>();
            foreach (var v in vs)
            {
                var x = coordinate[0] + P[0].DirectionRatios[0] * v.X + P[1].DirectionRatios[0] * v.Y;
                var y = coordinate[1] + P[0].DirectionRatios[1] * v.X + P[1].DirectionRatios[1] * v.Y;
                V2.Add(new Vector2((float)x, (float)y));
            }

            return V2;
        }

        public static List<Vector2> TransformPoints(IfcAxis2Placement2D position, Shape2D vs)
        {
            var coordinate = position.Location.Coordinates;
            var P = position.P;
            List<Vector2> V2 = new List<Vector2>();
            foreach (var v in vs.points)
            {
                var x = coordinate[0] + P[0].DirectionRatios[0] * v.X + P[1].DirectionRatios[0] * v.Y;
                var y = coordinate[1] + P[0].DirectionRatios[1] * v.X + P[1].DirectionRatios[1] * v.Y;
                V2.Add(new Vector2((float)x, (float)y));
            }

            return V2;
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

       
    }
}
