using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace IFC4
{
	public abstract class IfcBase
	{
        public Model Model;

        public List<string> textParameters;

        public string ifcid = "";

        public override string ToString()
        {
            return ifcid + " : " + GetType().Name;
        }

        public  bool InTypeOf<T>()
        {
            return InTypeOf(this, typeof(T).Name);
        }
        public bool InTypeOf( string typeName)
        {
            return InTypeOf(this, typeName);
        }
        public static bool InTypeOf<T>(object a)
        {
            return InTypeOf(a, typeof(T).Name);
        }

        public static bool InTypeOf(object a, string typeName)
        {
            if (a.GetType().Name == typeName)
            {
                return true;
            }
            var type = Type.GetType("IFC4." + typeName);
            if (type.IsInterface)
            {
                return a.GetType().GetInterface("IFC4." + typeName) != null;
            }
            return a.GetType().IsSubclassOf(type);
        }


        static bool CompareDimensionalExponents(IfcDimensionalExponents Dim, int LengthExponent, int MassExponent, int TimeExponent, int ElectricCurrentExponent, int ThermodynamicTemperatureExponent, int AmountOfSubstanceExponent, int LuminousIntensityExponent)
        {
            return Dim.LengthExponent == LengthExponent &&
            Dim.MassExponent == MassExponent &&
            Dim.TimeExponent == TimeExponent &&
            Dim.ElectricCurrentExponent == ElectricCurrentExponent &&
            Dim.ThermodynamicTemperatureExponent == ThermodynamicTemperatureExponent &&
            Dim.AmountOfSubstanceExponent == AmountOfSubstanceExponent &&
            Dim.LuminousIntensityExponent == LuminousIntensityExponent;
        }

        public static IfcDirection GetDirection(float x, float y)
        {
            return new IfcDirection(new List<IfcReal>() { x, y});
        }
        public static IfcDirection GetDirection(float x, float y, float z)
        {
            return new IfcDirection(new List<IfcReal>() { x, y, z });
        }

        protected static T NVL<T>(T a, T b)
        {
            return a == null ? b : a;
        }
        //


        protected static IfcSurface IfcAssociatedSurface(IfcPcurve Arg)
        {
            IfcSurface Surf;
            Surf = Arg.BasisSurface;
            return Surf;
        }
        /*
        (Arg : IfcPcurve) : IfcSurface;

           LOCAL
             Surf : IfcSurface;
           END_LOCAL;

           Surf := Arg\IfcPcurve.BasisSurface;

           RETURN(Surf);
        END_FUNCTION;
        */

        protected static List<IfcDirection> IfcBaseAxis(INTEGER Dim, IfcDirection Axis1, IfcDirection Axis2, IfcDirection Axis3)
        {
            List<IfcDirection> U;
            REAL Factor;
            IfcDirection D1;
            IfcDirection D2;

            if(Dim == 3)
            {
                if(Axis1 == null && Axis1 == null && Axis1 == null) // shortcut
                {
                    U = new List<IfcDirection>() { 
                        new IfcDirection(new List<IfcReal>() { 1, 0, 0 }),
                        new IfcDirection(new List<IfcReal>() { 0, 1, 0 }),
                        new IfcDirection(new List<IfcReal>() { 0, 0, 1 }),
                    };
                }
                else
                {
                    D1 = NVL(IfcNormalise(Axis3), GetDirection(0, 0, 1));
                    D2 = IfcFirstProjAxis(D1, Axis1);
                    U = new List<IfcDirection>() { D2, IfcSecondProjAxis(D1, D2, Axis2), D1 };
                }
            }
            else
            {
                if(Axis1!= null)
                {
                    D1 = IfcNormalise(Axis1);
                    U = new List<IfcDirection>() { D1, IfcOrthogonalComplement(D1) };
                    if (Axis2 != null)
                    {
                        Factor = IfcDotProduct(Axis2, U[2]);
                        if(Factor < 0)
                        {
                            U[1].DirectionRatios[0] = -U[1].DirectionRatios[0];
                            U[1].DirectionRatios[1] = -U[1].DirectionRatios[1];
                        }
                    }
                }
               else if (Axis2 != null)
                {
                    D1 = IfcNormalise(Axis2);
                    U = new List<IfcDirection>() { D1, IfcOrthogonalComplement(D1) };
                    if (Axis2 != null)
                    {
                        Factor = IfcDotProduct(Axis2, U[2]);
                        if (Factor < 0)
                        {
                            U[0].DirectionRatios[0] = -U[0].DirectionRatios[0];
                            U[0].DirectionRatios[1] = -U[0].DirectionRatios[1];
                        }
                    }
                }
                else
                {
                    U = new List<IfcDirection>() { GetDirection(1,0), GetDirection(0, 1) };
                }
               
            }

            return U;
        }
        /*
        (Dim : INTEGER; 
           Axis1, Axis2, Axis3 : IfcDirection) 
            : LIST [2:3] OF IfcDirection;

        LOCAL
          U : LIST [2:3] OF IfcDirection;
          Factor : REAL;
          D1, D2 : IfcDirection;
        END_LOCAL;

          IF (Dim = 3) THEN 
            D1 := NVL(IfcNormalise(Axis3), IfcRepresentationItem() || IfcGeometricRepresentationItem () || IfcDirection([0.0,0.0,1.0]));
            D2 := IfcFirstProjAxis(D1, Axis1);
            U  := [D2, IfcSecondProjAxis(D1, D2, Axis2), D1];
          ELSE
            IF EXISTS(Axis1) THEN
              D1 := IfcNormalise(Axis1);
              U  := [D1, IfcOrthogonalComplement(D1)];
              IF EXISTS(Axis2) THEN
                Factor := IfcDotProduct(Axis2, U[2]);
                IF (Factor < 0.0) THEN
                  U[2].DirectionRatios[1] := -U[2].DirectionRatios[1];
                  U[2].DirectionRatios[2] := -U[2].DirectionRatios[2];
                END_IF;
              END_IF;
            ELSE
              IF EXISTS(Axis2) THEN
                D1 := IfcNormalise(Axis2);
                U  := [IfcOrthogonalComplement(D1), D1];
                U[1].DirectionRatios[1] := -U[1].DirectionRatios[1];
                U[1].DirectionRatios[2] := -U[1].DirectionRatios[2];
                ELSE
                  U := [IfcRepresentationItem() || IfcGeometricRepresentationItem () || IfcDirection([1.0, 0.0]), 
                        IfcRepresentationItem() || IfcGeometricRepresentationItem () || IfcDirection([0.0, 1.0])];
              END_IF;
            END_IF;
          END_IF;
          RETURN(U);
        END_FUNCTION;
        */

        protected static IfcBase IfcBooleanChoose(BOOLEAN B, IfcBase Choice1, IfcBase Choice2)
        {
            if (B)
            {
                return Choice1;
            }
            else
            {
                return Choice2;
            }
        }
        /*
        (B : BOOLEAN ;
             Choice1, Choice2 : GENERIC : Item) : GENERIC : Item;
          IF B THEN
             RETURN (Choice1);
          ELSE
             RETURN (Choice2);
          END_IF;
        END_FUNCTION;
        */

        protected static List<IfcDirection> IfcBuild2Axes(IfcDirection RefDirection)
        {
            IfcDirection D =  NVL( IfcNormalise(RefDirection), GetDirection(1f, 0f));

            return new List<IfcDirection>() { D, IfcOrthogonalComplement(D)};
        }
        /*
        (RefDirection : IfcDirection)
            : LIST [2:2] OF IfcDirection;
        LOCAL
          D : IfcDirection := NVL(IfcNormalise(RefDirection),
              IfcRepresentationItem() || IfcGeometricRepresentationItem () || IfcDirection([1.0,0.0]));
        END_LOCAL;
          RETURN([D, IfcOrthogonalComplement(D)]);
        END_FUNCTION;
        */

        protected static List<IfcDirection> IfcBuildAxes(IfcDirection Axis, IfcDirection RefDirection)
        {
            IfcDirection D1;
            IfcDirection D2;
            D1 = NVL(IfcNormalise(Axis), GetDirection(0f, 0f, 1f));
            D2 = IfcFirstProjAxis(D1, RefDirection);
            return new List<IfcDirection>() { D2, ( IfcNormalise(IfcCrossProduct(D1, D2))).Orientation , D1}; ;
        }
        /*
        (Axis, RefDirection : IfcDirection) 
            : LIST [3:3] OF IfcDirection;
        LOCAL
          D1, D2 : IfcDirection;
        END_LOCAL;
          D1 := NVL(IfcNormalise(Axis), IfcRepresentationItem() || IfcGeometricRepresentationItem () || IfcDirection([0.0,0.0,1.0]));
          D2 := IfcFirstProjAxis(D1, RefDirection);
          RETURN ([D2, IfcNormalise(IfcCrossProduct(D1,D2))\IfcVector.Orientation, D1]);
        END_FUNCTION;
        */

        protected static BOOLEAN IfcConsecutiveSegments(List<IfcSegmentIndexSelect> Segments)
        {
            BOOLEAN Result = true;
            for(int i = 0; i < Segments.Count - 1; i++)
            {
                if(Segments[i].GetValue()[Segments[i].GetValue().Count - 1] != Segments[i + 1].GetValue()[0])
                {
                    Result = false;
                    break;
                }
            }
            return Result;
        }
        /*
        (Segments : LIST [1:?] OF IfcSegmentIndexSelect)
          : BOOLEAN;

         LOCAL
          Result : BOOLEAN := TRUE;
         END_LOCAL;

          REPEAT i := 1 TO (HIINDEX(Segments)-1);
            IF Segments[i][HIINDEX(Segments[i])] <> Segments[i+1][1] THEN
              BEGIN
                Result := FALSE;
                ESCAPE;
              END;
            END_IF;
          END_REPEAT;

          RETURN (Result);
        END_FUNCTION;
        */

        protected static BOOLEAN IfcConstraintsParamBSpline(INTEGER Degree, INTEGER UpKnots, INTEGER UpCp, List<INTEGER> KnotMult, List<IfcParameterValue> Knots)
        {
            BOOLEAN Result = true;
            INTEGER K;
            INTEGER Sum;
            Sum = KnotMult[0];
            for(int i = 1; i < UpKnots; i++)
            {
                Sum += KnotMult[i];
            }

            if(Degree < 1 || UpKnots < 2 || UpCp < Degree || Sum != Degree + UpCp + 2)
            {
                Result = false;
                return Result;
            }

            K = KnotMult[0];
            if(K<1 || K > Degree + 1)
            {
                Result = false;
                return Result;
            }
            for (int i = 1; i < UpKnots; i++)
            {
                if(KnotMult[i] < 1 || Knots[i] <= Knots[i - 1])
                {
                    Result = false;
                    return Result;
                }
                K = KnotMult[i];
                if (K < 1 || K > Degree + 1)
                {
                    Result = false;
                    return Result;
                }

            }
            //Find sum of knot multiplicities.

            return Result;
        }
        /*
        ( Degree, UpKnots, UpCp : INTEGER;
          KnotMult : LIST OF INTEGER;
          Knots : LIST OF IfcParameterValue ) 
        : BOOLEAN;


          LOCAL
            Result : BOOLEAN := TRUE;
            K, Sum : INTEGER;
          END_LOCAL;

          (* Find sum of knot multiplicities. *)
          Sum := KnotMult[1];
          REPEAT i := 2 TO UpKnots;
            Sum := Sum + KnotMult[i];
          END_REPEAT;

          (* Check limits holding for all B-spline parametrisations *)
          IF (Degree < 1) OR (UpKnots < 2) OR (UpCp < Degree) OR
            (Sum <> (Degree + UpCp + 2)) THEN
            Result := FALSE;
            RETURN(Result);
          END_IF;

          K := KnotMult[1];
          IF (K < 1) OR (K > Degree + 1) THEN
            Result := FALSE;
            RETURN(Result);
          END_IF;

          REPEAT i := 2 TO UpKnots;
            IF (KnotMult[i] < 1) OR (Knots[i] <= Knots[i-1]) THEN
              Result := FALSE;
              RETURN(Result);
            END_IF;
            K := KnotMult[i];
            IF (i < UpKnots) AND (K > Degree) THEN
              Result := FALSE;
              RETURN(Result);
            END_IF;
            IF (i = UpKnots) AND (K > Degree + 1) THEN
              Result := FALSE;
              RETURN(Result);
            END_IF;
          END_REPEAT;

          RETURN(result);
        END_FUNCTION;
        */

        protected static IfcDirection IfcConvertDirectionInto2D(IfcDirection Direction)
        {
            IfcDirection Direction2D = GetDirection(0, 1);
            Direction2D.DirectionRatios[0] = Direction.DirectionRatios[0];
            Direction2D.DirectionRatios[1] = Direction.DirectionRatios[1];
            return Direction2D;
        }
        /*
        (Direction : IfcDirection)
            : IfcDirection;

          LOCAL
            Direction2D : IfcDirection := IfcRepresentationItem() || IfcGeometricRepresentationItem () || IfcDirection([0.,1.]);
          END_LOCAL;

          Direction2D.DirectionRatios[1] := Direction.DirectionRatios[1];
          Direction2D.DirectionRatios[2] := Direction.DirectionRatios[2];

          RETURN (Direction2D);
        END_FUNCTION;
        */

        protected static LOGICAL IfcCorrectDimensions(IfcUnitEnum m, IfcDimensionalExponents Dim)
        {

            switch (m)
            {
                case IfcUnitEnum.LENGTHUNIT: return CompareDimensionalExponents(Dim, 1, 0, 0, 0, 0, 0, 0);
                case IfcUnitEnum.MASSUNIT: return CompareDimensionalExponents(Dim,0, 1, 0, 0, 0, 0, 0);
                case IfcUnitEnum.TIMEUNIT: return CompareDimensionalExponents(Dim,0, 0, 1, 0, 0, 0, 0);
                case IfcUnitEnum.ELECTRICCURRENTUNIT: return CompareDimensionalExponents(Dim,0, 0, 0, 1, 0, 0, 0);
                case IfcUnitEnum.THERMODYNAMICTEMPERATUREUNIT: return CompareDimensionalExponents(Dim,0, 0, 0, 0, 1, 0, 0);
                case IfcUnitEnum.AMOUNTOFSUBSTANCEUNIT: return CompareDimensionalExponents(Dim,0, 0, 0, 0, 0, 1, 0);
                case IfcUnitEnum.LUMINOUSINTENSITYUNIT: return CompareDimensionalExponents(Dim,0, 0, 0, 0, 0, 0, 1);
                case IfcUnitEnum.PLANEANGLEUNIT: return CompareDimensionalExponents(Dim,0, 0, 0, 0, 0, 0, 0);
                case IfcUnitEnum.SOLIDANGLEUNIT: return CompareDimensionalExponents(Dim,0, 0, 0, 0, 0, 0, 0);
                case IfcUnitEnum.AREAUNIT: return CompareDimensionalExponents(Dim,2, 0, 0, 0, 0, 0, 0);
                case IfcUnitEnum.VOLUMEUNIT: return CompareDimensionalExponents(Dim,3, 0, 0, 0, 0, 0, 0);
                case IfcUnitEnum.ABSORBEDDOSEUNIT: return CompareDimensionalExponents(Dim,2, 0, -2, 0, 0, 0, 0);
                case IfcUnitEnum.RADIOACTIVITYUNIT: return CompareDimensionalExponents(Dim,0, 0, -1, 0, 0, 0, 0);
                case IfcUnitEnum.ELECTRICCAPACITANCEUNIT: return CompareDimensionalExponents(Dim,-2, -1, 4, 2, 0, 0, 0);
                case IfcUnitEnum.DOSEEQUIVALENTUNIT: return CompareDimensionalExponents(Dim,2, 0, -2, 0, 0, 0, 0);
                case IfcUnitEnum.ELECTRICCHARGEUNIT: return CompareDimensionalExponents(Dim,0, 0, 1, 1, 0, 0, 0);
                case IfcUnitEnum.ELECTRICCONDUCTANCEUNIT: return CompareDimensionalExponents(Dim,-2, -1, 3, 2, 0, 0, 0);
                case IfcUnitEnum.ELECTRICVOLTAGEUNIT: return CompareDimensionalExponents(Dim,2, 1, -3, -1, 0, 0, 0);
                case IfcUnitEnum.ELECTRICRESISTANCEUNIT: return CompareDimensionalExponents(Dim,2, 1, -3, -2, 0, 0, 0);
                case IfcUnitEnum.ENERGYUNIT: return CompareDimensionalExponents(Dim,2, 1, -2, 0, 0, 0, 0);
                case IfcUnitEnum.FORCEUNIT: return CompareDimensionalExponents(Dim,1, 1, -2, 0, 0, 0, 0);
                case IfcUnitEnum.FREQUENCYUNIT: return CompareDimensionalExponents(Dim,0, 0, -1, 0, 0, 0, 0);
                case IfcUnitEnum.INDUCTANCEUNIT: return CompareDimensionalExponents(Dim,2, 1, -2, -2, 0, 0, 0);
                case IfcUnitEnum.ILLUMINANCEUNIT: return CompareDimensionalExponents(Dim,-2, 0, 0, 0, 0, 0, 1);
                case IfcUnitEnum.LUMINOUSFLUXUNIT: return CompareDimensionalExponents(Dim,0, 0, 0, 0, 0, 0, 1);
                case IfcUnitEnum.MAGNETICFLUXUNIT: return CompareDimensionalExponents(Dim,2, 1, -2, -1, 0, 0, 0);
                case IfcUnitEnum.MAGNETICFLUXDENSITYUNIT: return CompareDimensionalExponents(Dim,0, 1, -2, -1, 0, 0, 0);
                case IfcUnitEnum.POWERUNIT: return CompareDimensionalExponents(Dim,2, 1, -3, 0, 0, 0, 0);
                case IfcUnitEnum.PRESSUREUNIT: return CompareDimensionalExponents(Dim,-1, 1, -2, 0, 0, 0, 0);

                default: return null;
            }
            
        }
        /*
        (m   : IfcUnitEnum; Dim : IfcDimensionalExponents) : LOGICAL;  
        CASE m OF
          LENGTHUNIT : IF
            Dim = (IfcDimensionalExponents (1, 0, 0, 0, 0, 0, 0))
              THEN RETURN(TRUE);
              ELSE RETURN(FALSE);
            END_IF;
          MASSUNIT : IF
            Dim = (IfcDimensionalExponents (0, 1, 0, 0, 0, 0, 0))
              THEN RETURN(TRUE);
              ELSE RETURN(FALSE);
            END_IF;
          TIMEUNIT : IF
            Dim = (IfcDimensionalExponents (0, 0, 1, 0, 0, 0, 0))
              THEN RETURN(TRUE);
              ELSE RETURN(FALSE);
            END_IF;
          ELECTRICCURRENTUNIT : IF
            Dim = (IfcDimensionalExponents (0, 0, 0, 1, 0, 0, 0))
              THEN RETURN(TRUE);
              ELSE RETURN(FALSE);
            END_IF;
          THERMODYNAMICTEMPERATUREUNIT : IF
            Dim = (IfcDimensionalExponents (0, 0, 0, 0, 1, 0, 0))
              THEN RETURN(TRUE);
              ELSE RETURN(FALSE);
            END_IF;
          AMOUNTOFSUBSTANCEUNIT : IF
            Dim = (IfcDimensionalExponents (0, 0, 0, 0, 0, 1, 0))
              THEN RETURN(TRUE);
              ELSE RETURN(FALSE);
            END_IF;
          LUMINOUSINTENSITYUNIT : IF
            Dim = (IfcDimensionalExponents (0, 0, 0, 0, 0, 0, 1))
              THEN RETURN(TRUE);
              ELSE RETURN(FALSE);
            END_IF;
          PLANEANGLEUNIT : IF
            Dim = (IfcDimensionalExponents (0, 0, 0, 0, 0, 0, 0))
              THEN RETURN(TRUE);
              ELSE RETURN(FALSE);
            END_IF;
          SOLIDANGLEUNIT : IF
            Dim = (IfcDimensionalExponents (0, 0, 0, 0, 0, 0, 0))
              THEN RETURN(TRUE);
              ELSE RETURN(FALSE);
            END_IF;
          AREAUNIT : IF
            Dim = (IfcDimensionalExponents (2, 0, 0, 0, 0, 0, 0))
              THEN RETURN(TRUE);
              ELSE RETURN(FALSE);
            END_IF;
          VOLUMEUNIT : IF
            Dim = (IfcDimensionalExponents (3, 0, 0, 0, 0, 0, 0))
              THEN RETURN(TRUE);
              ELSE RETURN(FALSE);
            END_IF;

          ABSORBEDDOSEUNIT : IF
            Dim = (IfcDimensionalExponents (2, 0, -2, 0, 0, 0, 0))
              THEN RETURN(TRUE);
              ELSE RETURN(FALSE);
            END_IF;
          RADIOACTIVITYUNIT : IF
            Dim = (IfcDimensionalExponents (0, 0, -1, 0, 0, 0, 0))
              THEN RETURN(TRUE);
              ELSE RETURN(FALSE);
            END_IF;
          ELECTRICCAPACITANCEUNIT : IF
            Dim = (IfcDimensionalExponents (-2, -1, 4, 2, 0, 0, 0))
              THEN RETURN(TRUE);
              ELSE RETURN(FALSE);
            END_IF;
          DOSEEQUIVALENTUNIT : IF
            Dim = (IfcDimensionalExponents (2, 0, -2, 0, 0, 0, 0))
              THEN RETURN(TRUE);
              ELSE RETURN(FALSE);
            END_IF;
          ELECTRICCHARGEUNIT : IF
            Dim = (IfcDimensionalExponents (0, 0, 1, 1, 0, 0, 0))
              THEN RETURN(TRUE);
              ELSE RETURN(FALSE);
            END_IF;
          ELECTRICCONDUCTANCEUNIT : IF
            Dim = (IfcDimensionalExponents (-2, -1, 3, 2, 0, 0, 0))
              THEN RETURN(TRUE);
              ELSE RETURN(FALSE);
            END_IF;
          ELECTRICVOLTAGEUNIT : IF
            Dim = (IfcDimensionalExponents (2, 1, -3, -1, 0, 0, 0))
              THEN RETURN(TRUE);
              ELSE RETURN(FALSE);
            END_IF;
          ELECTRICRESISTANCEUNIT : IF
            Dim = (IfcDimensionalExponents (2, 1, -3, -2, 0, 0, 0))
              THEN RETURN(TRUE);
              ELSE RETURN(FALSE);
            END_IF;
          ENERGYUNIT : IF
            Dim = (IfcDimensionalExponents (2, 1, -2, 0, 0, 0, 0))
              THEN RETURN(TRUE);
              ELSE RETURN(FALSE);
            END_IF;
          FORCEUNIT : IF
            Dim = (IfcDimensionalExponents (1, 1, -2, 0, 0, 0, 0))
              THEN RETURN(TRUE);
              ELSE RETURN(FALSE);
            END_IF;
          FREQUENCYUNIT : IF
            Dim = (IfcDimensionalExponents (0, 0, -1, 0, 0, 0, 0))
              THEN RETURN(TRUE);
              ELSE RETURN(FALSE);
            END_IF;
          INDUCTANCEUNIT : IF
            Dim = (IfcDimensionalExponents (2, 1, -2, -2, 0, 0, 0))
              THEN RETURN(TRUE);
              ELSE RETURN(FALSE);
            END_IF;
          ILLUMINANCEUNIT : IF
            Dim = (IfcDimensionalExponents (-2, 0, 0, 0, 0, 0, 1))
              THEN RETURN(TRUE);
              ELSE RETURN(FALSE);
            END_IF;
          LUMINOUSFLUXUNIT : IF
            Dim = (IfcDimensionalExponents (0, 0, 0, 0, 0, 0, 1))
              THEN RETURN(TRUE);
              ELSE RETURN(FALSE);
            END_IF;
          MAGNETICFLUXUNIT : IF
            Dim = (IfcDimensionalExponents (2, 1, -2, -1, 0, 0, 0))
              THEN RETURN(TRUE);
              ELSE RETURN(FALSE);
            END_IF;
          MAGNETICFLUXDENSITYUNIT : IF
            Dim = (IfcDimensionalExponents (0, 1, -2, -1, 0, 0, 0))
              THEN RETURN(TRUE);
              ELSE RETURN(FALSE);
            END_IF;
          POWERUNIT : IF
            Dim = (IfcDimensionalExponents (2, 1, -3, 0, 0, 0, 0))
              THEN RETURN(TRUE);
              ELSE RETURN(FALSE);
            END_IF;
          PRESSUREUNIT : IF
            Dim = (IfcDimensionalExponents (-1, 1, -2, 0, 0, 0, 0))
              THEN RETURN(TRUE);
              ELSE RETURN(FALSE);
            END_IF;

          OTHERWISE :
            RETURN (UNKNOWN);
        END_CASE;
        END_FUNCTION;
        */

        protected static LOGICAL IfcCorrectFillAreaStyle(List< IfcFillStyleSelect> Styles)
        {
            INTEGER Hatching = 0;
            INTEGER Tiles = 0;
            INTEGER Colour = 0;
            INTEGER External = 0;


            External = Styles.Where(e => InTypeOf(e, EntityName.IFCEXTERNALLYDEFINEDHATCHSTYLE)).Count();
            Hatching = Styles.Where(e => InTypeOf(e, EntityName.IFCFILLAREASTYLEHATCHING)).Count();
            Tiles = Styles.Where(e => InTypeOf(e, EntityName.IFCFILLAREASTYLETILES)).Count();
            Colour = Styles.Where(e => InTypeOf(e, EntityName.IFCCOLOUR)).Count();

            if(External > 1)
            {
                return false;
            }

            if(External == 1 && (Hatching > 0 || Tiles > 0 || Colour > 0)){
                return false;
            }
            if(Colour > 1)
            {
                return false;
            }
            if(Hatching > 0 && Tiles > 0)
            {
                return false;
            }
            return true;
        }
        /*
        (Styles : SET[1:?] OF IfcFillStyleSelect)
          :LOGICAL;

        LOCAL
           Hatching : INTEGER := 0;
           Tiles    : INTEGER := 0;
           Colour   : INTEGER := 0;
           External : INTEGER := 0;
        END_LOCAL;


        External := SIZEOF(QUERY(Style <* Styles |
          'IFC4.IFCEXTERNALLYDEFINEDHATCHSTYLE' IN
           TYPEOF(Style)));

        Hatching  := SIZEOF(QUERY(Style <* Styles |
          'IFC4.IFCFILLAREASTYLEHATCHING' IN
           TYPEOF(Style)));

        Tiles     := SIZEOF(QUERY(Style <* Styles |
          'IFC4.IFCFILLAREASTYLETILES' IN
           TYPEOF(Style)));

        Colour    := SIZEOF(QUERY(Style <* Styles |
          'IFC4.IFCCOLOUR' IN
           TYPEOF(Style)));


        IF (External > 1) THEN
          RETURN (FALSE);
        END_IF;


        IF ((External = 1) AND ((Hatching > 0) OR (Tiles > 0) OR (Colour > 0))) THEN
          RETURN (FALSE);
        END_IF;


        IF (Colour > 1) THEN
          RETURN (FALSE);
        END_IF;

        IF ((Hatching > 0) AND (Tiles >0)) THEN
          RETURN (FALSE);
        END_IF;

        RETURN(TRUE);
        END_FUNCTION;
        */

        protected static LOGICAL IfcCorrectLocalPlacement(IfcAxis2Placement AxisPlacement, IfcObjectPlacement RelPlacement)
        {
            if(RelPlacement!= null)
            {
                if (InTypeOf(RelPlacement, EntityName.IFCGRIDPLACEMENT))
                {
                    return null;
                }
                if (InTypeOf(RelPlacement, EntityName.IFCLOCALPLACEMENT))
                {
                    if (InTypeOf(AxisPlacement, EntityName.IFCAXIS2PLACEMENT2D))
                    {
                        return true;
                    }
                    if (InTypeOf(AxisPlacement, EntityName.IFCAXIS2PLACEMENT3D))
                    {
                        if( ((IfcPlacement) ((IfcLocalPlacement) RelPlacement).RelativePlacement).Dim ==3)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            else
            {
                return true;
            }
            return null;
        }
        /*
        (AxisPlacement:IfcAxis2Placement; 
           RelPlacement : IfcObjectPlacement):LOGICAL;

          IF (EXISTS(RelPlacement)) THEN
            IF ('IFC4.IFCGRIDPLACEMENT' IN TYPEOF(RelPlacement)) THEN
              RETURN(?);
            END_IF;
            IF ('IFC4.IFCLOCALPLACEMENT' IN TYPEOF(RelPlacement)) THEN
              IF ('IFC4.IFCAXIS2PLACEMENT2D' IN TYPEOF(AxisPlacement)) THEN
                RETURN(TRUE);
              END_IF;
              IF ('IFC4.IFCAXIS2PLACEMENT3D' IN TYPEOF(AxisPlacement)) THEN
                IF (RelPlacement\IfcLocalPlacement.RelativePlacement.Dim = 3) THEN
                  RETURN(TRUE);
                ELSE
                  RETURN(FALSE);
                END_IF;
              END_IF;
            END_IF;
          ELSE
            RETURN(TRUE);  
          END_IF;
          RETURN(?);
        END_FUNCTION;
        */

        protected static LOGICAL IfcCorrectObjectAssignment(IfcObjectTypeEnum Constraint, List<IfcObjectDefinition> Objects)
        {
            if (Constraint == null) return true;

            INTEGER Count = 0;
            switch (Constraint)
            {
                case IfcObjectTypeEnum.NOTDEFINED:
                    return true;
                case IfcObjectTypeEnum.PRODUCT:
                    Count = Objects.Where(temp => InTypeOf(temp, EntityName.IFCPRODUCT)).Count();
                    return Count == 0;
                case IfcObjectTypeEnum.PROCESS:
                    Count = Objects.Where(temp => InTypeOf(temp, EntityName.IFCPROCESS)).Count();
                    return Count == 0;
                case IfcObjectTypeEnum.CONTROL:
                    Count = Objects.Where(temp => InTypeOf(temp, EntityName.IFCCONTROL)).Count();
                    return Count == 0;
                case IfcObjectTypeEnum.RESOURCE:
                    Count = Objects.Where(temp => InTypeOf(temp, EntityName.IFCRESOURCE)).Count();
                    return Count == 0;
                case IfcObjectTypeEnum.ACTOR:
                    Count = Objects.Where(temp => InTypeOf(temp, EntityName.IFCACTOR)).Count();
                    return Count == 0;
                case IfcObjectTypeEnum.GROUP:
                    Count = Objects.Where(temp => InTypeOf(temp, EntityName.IFCGROUP)).Count();
                    return Count == 0;
                case IfcObjectTypeEnum.PROJECT:
                    Count = Objects.Where(temp => InTypeOf(temp, EntityName.IFCPROJECT)).Count();
                    return Count == 0;
                default:
                    return null;
            }
        }
        /*
        (Constraint: IfcObjectTypeEnum; Objects : SET[1:?] OF IfcObjectDefinition)
          : LOGICAL ;

        LOCAL
          Count : INTEGER := 0;
        END_LOCAL;

            IF NOT(EXISTS(Constraint)) THEN 
              RETURN(TRUE);
            END_IF;

            CASE Constraint OF
              IfcObjectTypeEnum.NOTDEFINED : RETURN(TRUE);
              IfcObjectTypeEnum.PRODUCT :
                BEGIN
                  Count := SIZEOF(QUERY(temp <* Objects | NOT('IFC4.IFCPRODUCT' IN TYPEOF(temp))));
                  RETURN(Count = 0);
                END;
              IfcObjectTypeEnum.PROCESS :
                BEGIN
                  Count := SIZEOF(QUERY(temp <* Objects | NOT('IFC4.IFCPROCESS' IN TYPEOF(temp))));
                  RETURN(Count = 0);
                END;
              IfcObjectTypeEnum.CONTROL :
                BEGIN
                  Count := SIZEOF(QUERY(temp <* Objects | NOT('IFC4.IFCCONTROL' IN TYPEOF(temp))));
                  RETURN(Count = 0);
                END;
              IfcObjectTypeEnum.RESOURCE :
                BEGIN
                  Count := SIZEOF(QUERY(temp <* Objects | NOT('IFC4.IFCRESOURCE' IN TYPEOF(temp))));
                  RETURN(Count = 0);
                END;
              IfcObjectTypeEnum.ACTOR :
                BEGIN
                  Count := SIZEOF(QUERY(temp <* Objects | NOT('IFC4.IFCACTOR' IN TYPEOF(temp))));
                  RETURN(Count = 0);
                END;
              IfcObjectTypeEnum.GROUP :
                BEGIN
                  Count := SIZEOF(QUERY(temp <* Objects | NOT('IFC4.IFCGROUP' IN TYPEOF(temp))));
                  RETURN(Count = 0);
                END;
              IfcObjectTypeEnum.PROJECT :
                BEGIN
                  Count := SIZEOF(QUERY(temp <* Objects | NOT('IFC4.IFCPROJECT' IN TYPEOF(temp))));
                  RETURN(Count = 0);
                END;
              OTHERWISE : RETURN(?);
            END_CASE;
        END_FUNCTION;
        */

        protected static LOGICAL IfcCorrectUnitAssignment(List< IfcUnit> Units)
        {
            INTEGER NamedUnitNumber = 0;
            INTEGER DerivedUnitNumber = 0;
            INTEGER MonetaryUnitNumber = 0;
            List<IfcUnitEnum> NamedUnitNames = new List<IfcUnitEnum> ();
            List<IfcDerivedUnitEnum> DerivedUnitNames = new List<IfcDerivedUnitEnum>();
            NamedUnitNumber = Units.Where(temp => InTypeOf(temp, EntityName.IFCNAMEDUNIT) && !(((IfcNamedUnit)temp).UnitType == IfcUnitEnum.USERDEFINED)).Count();
            DerivedUnitNumber = Units.Where(temp => InTypeOf(temp,EntityName.IFCDERIVEDUNIT) && !(((IfcDerivedUnit)temp).UnitType == IfcDerivedUnitEnum.USERDEFINED)).Count();
            MonetaryUnitNumber = Units.Where(temp => InTypeOf(temp, EntityName.IFCMONETARYUNIT)).Count();


            for (int i = 0; i < Units.Count; i++)
            {
                if (InTypeOf(Units[i], EntityName.IFCNAMEDUNIT) && !(((IfcNamedUnit)Units[i]).UnitType == IfcUnitEnum.USERDEFINED))
                {
                    NamedUnitNames.Add(((IfcNamedUnit) Units[i]).UnitType);
                }
                if (InTypeOf(Units[i], EntityName.IFCDERIVEDUNIT) && !(((IfcDerivedUnit)Units[i]).UnitType == IfcDerivedUnitEnum.USERDEFINED))
                {
                    DerivedUnitNames.Add(((IfcDerivedUnit)Units[i]).UnitType);
                }
            }
            return NamedUnitNames.Count == NamedUnitNumber && DerivedUnitNames.Count == DerivedUnitNumber && MonetaryUnitNumber <=1;
        }
        /*
        (Units : SET [1:?] OF IfcUnit)
           : LOGICAL;

          LOCAL
            NamedUnitNumber    : INTEGER := 0;
            DerivedUnitNumber  : INTEGER := 0;
            MonetaryUnitNumber : INTEGER := 0;
            NamedUnitNames     : SET OF IfcUnitEnum := [];
            DerivedUnitNames   : SET OF IfcDerivedUnitEnum := [];
          END_LOCAL;

          NamedUnitNumber    := SIZEOF(QUERY(temp <* Units | ('IFC4.IFCNAMEDUNIT' IN TYPEOF(temp)) AND NOT(temp\IfcNamedUnit.UnitType = IfcUnitEnum.USERDEFINED)));
          DerivedUnitNumber  := SIZEOF(QUERY(temp <* Units | ('IFC4.IFCDERIVEDUNIT' IN TYPEOF(temp)) AND NOT(temp\IfcDerivedUnit.UnitType = IfcDerivedUnitEnum.USERDEFINED)));
          MonetaryUnitNumber := SIZEOF(QUERY(temp <* Units |  'IFC4.IFCMONETARYUNIT' IN TYPEOF(temp)));

          REPEAT i := 1 TO SIZEOF(Units);
            IF (('IFC4.IFCNAMEDUNIT' IN TYPEOF(Units[i])) AND NOT(Units[i]\IfcNamedUnit.UnitType = IfcUnitEnum.USERDEFINED)) THEN
                NamedUnitNames := NamedUnitNames + Units[i]\IfcNamedUnit.UnitType;
            END_IF;
            IF (('IFC4.IFCDERIVEDUNIT' IN TYPEOF(Units[i])) AND NOT(Units[i]\IfcDerivedUnit.UnitType = IfcDerivedUnitEnum.USERDEFINED)) THEN
                DerivedUnitNames := DerivedUnitNames + Units[i]\IfcDerivedUnit.UnitType;
            END_IF;
          END_REPEAT;

          RETURN((SIZEOF(NamedUnitNames) = NamedUnitNumber) AND (SIZEOF(DerivedUnitNames) = DerivedUnitNumber) AND (MonetaryUnitNumber <= 1));
        END_FUNCTION;
        */

        protected static IfcVector IfcCrossProduct(IfcDirection Arg1, IfcDirection Arg2)
        {
            REAL Mag;
            IfcDirection Res;
            List<IfcReal>  V1;
            List<IfcReal>  V2;
            IfcVector Result;
            if(Arg1 == null || Arg1.Dim == 2 || Arg2 == null || Arg2.Dim == 2)
            {
                return null;
            }

            V1 = IfcNormalise(Arg1).DirectionRatios;
            V2 = IfcNormalise(Arg2).DirectionRatios;
            Res = GetDirection(V1[1] * V2[2] - V1[2] * V2[1], V1[2] * V2[0] - V1[0] * V2[2], V1[0] * V2[1] - V1[1] * V2[0]);
            Mag = 0;

            for(int i = 0; i < 3; i++)
            {
                Mag += Res.DirectionRatios[i] * Res.DirectionRatios[i];
            }
            if(Mag > 0)
            {
                Result = new IfcVector(Res, MathF.Sqrt(Mag));
            }
            else
            {
                Result = new IfcVector(Arg1, MathF.Sqrt(0));
            }
            return Result;
        }
        /*
        (Arg1, Arg2 : IfcDirection) 
            : IfcVector;
        LOCAL
          Mag : REAL;
          Res : IfcDirection;
          V1,V2  : LIST[3:3] OF REAL;
          Result : IfcVector;
        END_LOCAL;

          IF (NOT EXISTS (Arg1) OR (Arg1.Dim = 2)) OR (NOT EXISTS (Arg2) OR (Arg2.Dim = 2)) THEN
            RETURN(?);
          ELSE
            BEGIN
              V1  := IfcNormalise(Arg1)\IfcDirection.DirectionRatios;

              V2  := IfcNormalise(Arg2)\IfcDirection.DirectionRatios;
              Res := IfcRepresentationItem() || IfcGeometricRepresentationItem () 
                     || IfcDirection([(V1[2]*V2[3] - V1[3]*V2[2]), (V1[3]*V2[1] - V1[1]*V2[3]), (V1[1]*V2[2] - V1[2]*V2[1])]);
              Mag := 0.0;
              REPEAT i := 1 TO 3;
                Mag := Mag + Res.DirectionRatios[i]*Res.DirectionRatios[i];
              END_REPEAT;
              IF (Mag > 0.0) THEN
                Result := IfcRepresentationItem() || IfcGeometricRepresentationItem () || IfcVector(Res, SQRT(Mag));
              ELSE
                Result := IfcRepresentationItem() || IfcGeometricRepresentationItem () || IfcVector(Arg1, 0.0);
              END_IF;
              RETURN(Result);
            END;
          END_IF;
        END_FUNCTION;
        */

        protected static IfcDimensionCount IfcCurveDim(IfcCurve Curve)
        {
            if (InTypeOf(Curve, EntityName.IFCLINE))
            {
                return ((IfcLine)Curve).Pnt.Dim;
            }
            if (InTypeOf(Curve, EntityName.IFCCONIC))
            {
                return ((IfcPlacement)((IfcConic)Curve).Position).Dim;
            }
            if (InTypeOf(Curve, EntityName.IFCPOLYLINE))
            {
                return ((IfcPolyline)Curve).Points[0].Dim;
            }
            if (InTypeOf(Curve, EntityName.IFCTRIMMEDCURVE))
            {
                return IfcCurveDim(((IfcTrimmedCurve)Curve).BasisCurve);
            }
            if (InTypeOf(Curve, EntityName.IFCCOMPOSITECURVE))
            {
                return ((IfcCompositeCurve)Curve).Segments[0].Dim;
            }
            if (InTypeOf(Curve, EntityName.IFCBSPLINECURVE))
            {
                return ((IfcBSplineCurve)Curve).ControlPointsList[0].Dim;
            }
            if (InTypeOf(Curve, EntityName.IFCOFFSETCURVE2D))
            {
                return 2;
            }
            if (InTypeOf(Curve,  EntityName.IFCOFFSETCURVE3D))
            {
                return  3;
            }
            if (InTypeOf(Curve, EntityName.IFCPCURVE))
            {
                return 3;
            }
            if (InTypeOf(Curve, EntityName.IFCINDEXEDPOLYCURVE))
            {
                return   ((IfcIndexedPolyCurve)Curve).Points.Dim;
            }
            return null;
            
            
        
        }
        /*
        (Curve : IfcCurve)
               : IfcDimensionCount;

          IF ('IFC4.IFCLINE' IN TYPEOF(Curve))
            THEN RETURN(Curve\IfcLine.Pnt.Dim);
          END_IF;
          IF ('IFC4.IFCCONIC' IN TYPEOF(Curve))
            THEN RETURN(Curve\IfcConic.Position.Dim);
          END_IF;
          IF ('IFC4.IFCPOLYLINE' IN TYPEOF(Curve))
            THEN RETURN(Curve\IfcPolyline.Points[1].Dim);
          END_IF;
          IF ('IFC4.IFCTRIMMEDCURVE' IN TYPEOF(Curve))
            THEN RETURN(IfcCurveDim(Curve\IfcTrimmedCurve.BasisCurve));
          END_IF;
          IF ('IFC4.IFCCOMPOSITECURVE' IN TYPEOF(Curve))
            THEN RETURN(Curve\IfcCompositeCurve.Segments[1].Dim);
          END_IF;
          IF ('IFC4.IFCBSPLINECURVE' IN TYPEOF(Curve))
            THEN RETURN(Curve\IfcBSplineCurve.ControlPointsList[1].Dim);
          END_IF;
          IF ('IFC4.IFCOFFSETCURVE2D' IN TYPEOF(Curve))
            THEN RETURN(2); 
          END_IF;
          IF ('IFC4.IFCOFFSETCURVE3D' IN TYPEOF(Curve))
            THEN RETURN(3);
          END_IF;
          IF ('IFC4.IFCPCURVE' IN TYPEOF(Curve))
            THEN RETURN(3);
          END_IF;
          IF ('IFC4.IFCINDEXEDPOLYCURVE' IN TYPEOF(Curve))
            THEN RETURN(Curve\IfcIndexedPolyCurve.Points.Dim);
          END_IF;
        RETURN (?);
        END_FUNCTION;
        */

        protected static BOOLEAN IfcCurveWeightsPositive(IfcRationalBSplineCurveWithKnots B)
        {
            BOOLEAN Result = true;

            for(int i = 0; i< B.UpperIndexOnControlPoints; i++)
            {
                if (B.Weights[i] < 0)
                {
                    Result = false;
                    return Result;
                }
            }

            return Result;
        }
        /*
        ( B: IfcRationalBSplineCurveWithKnots)
        : BOOLEAN;

          LOCAL
            Result : BOOLEAN := TRUE;
          END_LOCAL;

          REPEAT i := 0 TO B.UpperIndexOnControlPoints;
            IF B.Weights[i] <= 0.0  THEN
              Result := FALSE;
              RETURN(Result);
            END_IF;
          END_REPEAT;
          RETURN(Result);
        END_FUNCTION;
        */

        protected static IfcDimensionalExponents IfcDeriveDimensionalExponents(List<IfcDerivedUnitElement> UnitElements)
        {
            IfcDimensionalExponents Result = new IfcDimensionalExponents(0, 0, 0, 0, 0, 0, 0);
            for(int i = 0; i < UnitElements.Count; i++)
            {
                Result.LengthExponent += UnitElements[i].Exponent * UnitElements[i].Unit.Dimensions.LengthExponent;
                Result.MassExponent += UnitElements[i].Exponent * UnitElements[i].Unit.Dimensions.MassExponent;
                Result.TimeExponent += UnitElements[i].Exponent * UnitElements[i].Unit.Dimensions.TimeExponent;
                Result.ElectricCurrentExponent += UnitElements[i].Exponent * UnitElements[i].Unit.Dimensions.ElectricCurrentExponent;
                Result.ThermodynamicTemperatureExponent += UnitElements[i].Exponent * UnitElements[i].Unit.Dimensions.ThermodynamicTemperatureExponent;
                Result.AmountOfSubstanceExponent += UnitElements[i].Exponent * UnitElements[i].Unit.Dimensions.AmountOfSubstanceExponent;
                Result.LuminousIntensityExponent += UnitElements[i].Exponent * UnitElements[i].Unit.Dimensions.LuminousIntensityExponent;

            }

            return Result;
        }
        /*
        (UnitElements : SET [1:?] OF IfcDerivedUnitElement)
            : IfcDimensionalExponents;  
            LOCAL
            Result : IfcDimensionalExponents :=
                    IfcDimensionalExponents(0, 0, 0, 0, 0, 0, 0);  
            END_LOCAL;
            REPEAT i := LOINDEX(UnitElements) TO HIINDEX(UnitElements);
                Result.LengthExponent := Result.LengthExponent +
                  (UnitElements[i].Exponent *
                   UnitElements[i].Unit.Dimensions.LengthExponent);
                Result.MassExponent := Result.MassExponent  +
                  (UnitElements[i].Exponent *
                   UnitElements[i].Unit.Dimensions.MassExponent);
                Result.TimeExponent := Result.TimeExponent +
                  (UnitElements[i].Exponent *
                   UnitElements[i].Unit.Dimensions.TimeExponent);
                Result.ElectricCurrentExponent := Result.ElectricCurrentExponent +
                  (UnitElements[i].Exponent *
                   UnitElements[i].Unit.Dimensions.ElectricCurrentExponent);
                Result.ThermodynamicTemperatureExponent := Result.ThermodynamicTemperatureExponent +
                  (UnitElements[i].Exponent *
                   UnitElements[i].Unit.Dimensions.ThermodynamicTemperatureExponent);
                Result.AmountOfSubstanceExponent := Result.AmountOfSubstanceExponent +
                  (UnitElements[i].Exponent *
                   UnitElements[i].Unit.Dimensions.AmountOfSubstanceExponent);
                Result.LuminousIntensityExponent := Result.LuminousIntensityExponent +
                  (UnitElements[i].Exponent *
                   UnitElements[i].Unit.Dimensions.LuminousIntensityExponent);
            END_REPEAT;  
            RETURN (Result);
        END_FUNCTION;
        */

        protected static IfcDimensionalExponents IfcDimensionsForSiUnit(IfcSIUnitName n)
        {
            switch (n)
            {
                case "METRE": return new IfcDimensionalExponents(1, 0, 0, 0, 0, 0, 0);
                case "SQUARE_METRE": return new IfcDimensionalExponents(2, 0, 0, 0, 0, 0, 0);
                case "CUBIC_METRE": return new IfcDimensionalExponents(3, 0, 0, 0, 0, 0, 0);
                case "GRAM": return new IfcDimensionalExponents(0, 1, 0, 0, 0, 0, 0);
                case "SECOND": return new IfcDimensionalExponents(0, 0, 1, 0, 0, 0, 0);
                case "AMPERE": return new IfcDimensionalExponents(0, 0, 0, 1, 0, 0, 0);
                case "KELVIN": return new IfcDimensionalExponents(0, 0, 0, 0, 1, 0, 0);
                case "MOLE": return new IfcDimensionalExponents(0, 0, 0, 0, 0, 1, 0);
                case "CANDELA": return new IfcDimensionalExponents(0, 0, 0, 0, 0, 0, 1);
                case "RADIAN": return new IfcDimensionalExponents(0, 0, 0, 0, 0, 0, 0);
                case "STERADIAN": return new IfcDimensionalExponents(0, 0, 0, 0, 0, 0, 0);
                case "HERTZ": return new IfcDimensionalExponents(0, 0, -1, 0, 0, 0, 0);
                case "NEWTON": return new IfcDimensionalExponents(1, 1, -2, 0, 0, 0, 0);
                case "PASCAL": return new IfcDimensionalExponents(-1, 1, -2, 0, 0, 0, 0);
                case "JOULE": return new IfcDimensionalExponents(2, 1, -2, 0, 0, 0, 0);
                case "WATT": return new IfcDimensionalExponents(2, 1, -3, 0, 0, 0, 0);
                case "COULOMB": return new IfcDimensionalExponents(0, 0, 1, 1, 0, 0, 0);
                case "VOLT": return new IfcDimensionalExponents(2, 1, -3, -1, 0, 0, 0);
                case "FARAD": return new IfcDimensionalExponents(-2, -1, 4, 2, 0, 0, 0);
                case "OHM": return new IfcDimensionalExponents(2, 1, -3, -2, 0, 0, 0);
                case "SIEMENS": return new IfcDimensionalExponents(-2, -1, 3, 2, 0, 0, 0);
                case "WEBER": return new IfcDimensionalExponents(2, 1, -2, -1, 0, 0, 0);
                case "TESLA": return new IfcDimensionalExponents(0, 1, -2, -1, 0, 0, 0);
                case "HENRY": return new IfcDimensionalExponents(2, 1, -2, -2, 0, 0, 0);
                case "DEGREE_CELSIUS": return new IfcDimensionalExponents(0, 0, 0, 0, 1, 0, 0);
                case "LUMEN": return new IfcDimensionalExponents(0, 0, 0, 0, 0, 0, 1);
                case "LUX": return new IfcDimensionalExponents(-2, 0, 0, 0, 0, 0, 1);
                case "BECQUEREL": return new IfcDimensionalExponents(0, 0, -1, 0, 0, 0, 0);
                case "GRAY": return new IfcDimensionalExponents(2, 0, -2, 0, 0, 0, 0);
                case "SIEVERT": return new IfcDimensionalExponents(2, 0, -2, 0, 0, 0, 0);
                case "OTHERWISE": return new IfcDimensionalExponents(0, 0, 0, 0, 0, 0, 0);
            }
            return null;
        }
        /*
        (n : IfcSiUnitName )     : IfcDimensionalExponents;
          CASE n OF
            METRE          : RETURN (IfcDimensionalExponents
                                     (1, 0, 0, 0, 0, 0, 0));
            SQUARE_METRE   : RETURN (IfcDimensionalExponents
                                     (2, 0, 0, 0, 0, 0, 0));
            CUBIC_METRE    : RETURN (IfcDimensionalExponents
                                     (3, 0, 0, 0, 0, 0, 0));
            GRAM           : RETURN (IfcDimensionalExponents
                                     (0, 1, 0, 0, 0, 0, 0));
            SECOND         : RETURN (IfcDimensionalExponents
                                     (0, 0, 1, 0, 0, 0, 0));
            AMPERE         : RETURN (IfcDimensionalExponents
                                     (0, 0, 0, 1, 0, 0, 0));
            KELVIN         : RETURN (IfcDimensionalExponents
                                     (0, 0, 0, 0, 1, 0, 0));
            MOLE           : RETURN (IfcDimensionalExponents
                                     (0, 0, 0, 0, 0, 1, 0));
            CANDELA        : RETURN (IfcDimensionalExponents
                                     (0, 0, 0, 0, 0, 0, 1));
            RADIAN         : RETURN (IfcDimensionalExponents
                                     (0, 0, 0, 0, 0, 0, 0));
            STERADIAN      : RETURN (IfcDimensionalExponents
                                     (0, 0, 0, 0, 0, 0, 0));
            HERTZ          : RETURN (IfcDimensionalExponents
                                     (0, 0, -1, 0, 0, 0, 0));
            NEWTON         : RETURN (IfcDimensionalExponents
                                     (1, 1, -2, 0, 0, 0, 0));
            PASCAL         : RETURN (IfcDimensionalExponents
                                     (-1, 1, -2, 0, 0, 0, 0));
            JOULE          : RETURN (IfcDimensionalExponents
                                     (2, 1, -2, 0, 0, 0, 0));
            WATT           : RETURN (IfcDimensionalExponents
                                     (2, 1, -3, 0, 0, 0, 0));
            COULOMB        : RETURN (IfcDimensionalExponents
                                     (0, 0, 1, 1, 0, 0, 0));
            VOLT           : RETURN (IfcDimensionalExponents
                                     (2, 1, -3, -1, 0, 0, 0));
            FARAD          : RETURN (IfcDimensionalExponents
                                     (-2, -1, 4, 2, 0, 0, 0));
            OHM            : RETURN (IfcDimensionalExponents
                                     (2, 1, -3, -2, 0, 0, 0));
            SIEMENS        : RETURN (IfcDimensionalExponents
                                     (-2, -1, 3, 2, 0, 0, 0));
            WEBER          : RETURN (IfcDimensionalExponents
                                     (2, 1, -2, -1, 0, 0, 0));
            TESLA          : RETURN (IfcDimensionalExponents
                                     (0, 1, -2, -1, 0, 0, 0));
            HENRY          : RETURN (IfcDimensionalExponents
                                     (2, 1, -2, -2, 0, 0, 0));
            DEGREE_CELSIUS : RETURN (IfcDimensionalExponents
                                     (0, 0, 0, 0, 1, 0, 0));
            LUMEN          : RETURN (IfcDimensionalExponents
                                     (0, 0, 0, 0, 0, 0, 1));
            LUX            : RETURN (IfcDimensionalExponents
                                     (-2, 0, 0, 0, 0, 0, 1));
            BECQUEREL      : RETURN (IfcDimensionalExponents
                                     (0, 0, -1, 0, 0, 0, 0));
            GRAY           : RETURN (IfcDimensionalExponents
                                     (2, 0, -2, 0, 0, 0, 0));
            SIEVERT        : RETURN (IfcDimensionalExponents
                                     (2, 0, -2, 0, 0, 0, 0));
            OTHERWISE      : RETURN (IfcDimensionalExponents
                                     (0, 0, 0, 0, 0, 0, 0));
          END_CASE;
        END_FUNCTION;
        */

        protected static REAL IfcDotProduct(IfcDirection Arg1, IfcDirection Arg2)
        {
            REAL Scalar;
            IfcDirection Vec1;
            IfcDirection Vec2;
            INTEGER Ndim;
            if(Arg1 == null || Arg2 == null)
            {
                Scalar = null;
            }
            else if ((float) Arg1.Dim != (float)Arg2.Dim)
            {
                Scalar = null;
            }
            else
            {
                Vec1 = IfcNormalise(Arg1);
                Vec2 = IfcNormalise(Arg2);
                Ndim = Arg1.Dim;
                Scalar = 0;
                for(int i =0; i < Ndim;i++)
                {
                    Scalar += Vec1.DirectionRatios[i] * Vec2.DirectionRatios[i];
                }          
            }
            return Scalar;
        }
        /*
        (Arg1, Arg2 : IfcDirection) 
            : REAL;
        LOCAL
          Scalar : REAL;
          Vec1, Vec2 : IfcDirection;
          Ndim   : INTEGER;
        END_LOCAL;

          IF NOT EXISTS (Arg1) OR NOT EXISTS (Arg2) THEN
            Scalar := ?;
          ELSE
            IF (Arg1.Dim <> Arg2.Dim) THEN
              Scalar := ?;
            ELSE
              BEGIN
                Vec1 := IfcNormalise(Arg1);
                Vec2 := IfcNormalise(Arg2);
                Ndim := Arg1.Dim;
                Scalar := 0.0;
                REPEAT i := 1 TO Ndim;
                  Scalar := Scalar + Vec1.DirectionRatios[i]*Vec2.DirectionRatios[i];
                END_REPEAT;
              END;
            END_IF;
          END_IF;
          RETURN (Scalar);
        END_FUNCTION;
        */

        protected static IfcDirection IfcFirstProjAxis(IfcDirection ZAxis, IfcDirection Arg)
        {
            IfcDirection XAxis;
            IfcDirection V;
            IfcDirection Z;
            IfcVector XVec;
            if(ZAxis == null)
            {
                return null;
            }
            else
            {
                Z = IfcNormalise(ZAxis);
                if(Arg == null)
                {
                    if(Z.DirectionRatios[0]!= 1 || Z.DirectionRatios[0] != 0 || Z.DirectionRatios[0] != 0)
                    {
                        V = GetDirection(1, 0, 0);
                    }
                    else
                    {
                        V = GetDirection(0, 1, 0);
                    }
                }
                else
                {
                    if(Arg.Dim!= 3)
                    {
                        return null;
                    }
                    if(IfcCrossProduct(Arg,Z).Magnitude == 0)
                    {
                        return null;
                    }
                    else
                    {
                        V = IfcNormalise(Arg);
                    }
                }
                XVec = IfcScalarTimesVector(IfcDotProduct(V, Z), Z);
                XAxis = IfcVectorDifference(V, XVec).Orientation;
                XAxis = IfcNormalise(XAxis);
                return XAxis;
            }
        }
        /*
        (ZAxis, Arg : IfcDirection) : IfcDirection;
        LOCAL
          XAxis : IfcDirection;
          V     : IfcDirection;
          Z     : IfcDirection;
          XVec  : IfcVector;
        END_LOCAL;

          IF (NOT EXISTS(ZAxis)) THEN
            RETURN (?) ;
          ELSE
            Z := IfcNormalise(ZAxis);
            IF NOT EXISTS(Arg) THEN
              IF (Z.DirectionRatios <> [1.0,0.0,0.0]) THEN
                V := IfcRepresentationItem() || IfcGeometricRepresentationItem () || IfcDirection([1.0,0.0,0.0]);
              ELSE
                V := IfcRepresentationItem() || IfcGeometricRepresentationItem () || IfcDirection([0.0,1.0,0.0]);
              END_IF;
            ELSE
              IF (Arg.Dim <> 3) THEN
                RETURN (?) ;
              END_IF;
              IF ((IfcCrossProduct(Arg,Z).Magnitude) = 0.0) THEN
                RETURN (?);
              ELSE
                V := IfcNormalise(Arg);
              END_IF;
            END_IF;
            XVec  := IfcScalarTimesVector(IfcDotProduct(V, Z), Z);
            XAxis := IfcVectorDifference(V, XVec).Orientation;
            XAxis := IfcNormalise(XAxis);
          END_IF;
          RETURN(XAxis);
        END_FUNCTION;
        */

        protected static List<IfcSurface> IfcGetBasisSurface(IfcCurveOnSurface C)
        {
            //NeedCheck
            List<IfcSurface> Surfs;
            INTEGER N;
            Surfs = new List<IfcSurface>();

            if (InTypeOf(C, EntityName.IFCPCURVE)){
                Surfs = new List<IfcSurface>() { ((IfcPcurve)C).BasisSurface };
            }
            else if(InTypeOf(C, EntityName.IFCSURFACECURVE))
            {
                N = ((IfcSurfaceCurve)C).AssociatedGeometry.Count;
                for(int i = 0; i < N; i++)
                {
                    Surfs.Add(IfcAssociatedSurface(((IfcSurfaceCurve)C).AssociatedGeometry[i]));
                }
            }
            if(InTypeOf(C, EntityName.IFCCOMPOSITECURVEONSURFACE))
            {
                // (* For an IfcCompositeCurveOnSurface the BasisSurface is the intersection of the BasisSurface of all the segments. *)
                N = ((IfcCompositeCurve)C).Segments.Count;
                Surfs = IfcGetBasisSurface((IfcCurveOnSurface)((IfcCompositeCurve)C).Segments[0].ParentCurve);
                if(N > 1)
                {
                    for(int i = 1; i < N; i++)
                    {
                        Surfs.AddRange(IfcGetBasisSurface((IfcCurveOnSurface)((IfcCompositeCurve)C).Segments[i].ParentCurve));
                    }
                }
            }


            return Surfs;
         
        }
        /*
        (C : IfcCurveOnSurface) : SET[0:2] OF IfcSurface;

          LOCAL
            Surfs : SET[0:2] OF IfcSurface;
            N : INTEGER;
          END_LOCAL;

          Surfs := [];
          IF 'IFC4.IFCPCURVE' IN TYPEOF (C) THEN
            Surfs := [C\IfcPCurve.BasisSurface];
          ELSE
            IF 'IFC4.IFCSURFACECURVE' IN TYPEOF (C) THEN
              N := SIZEOF(C\IfcSurfaceCurve.AssociatedGeometry);
              REPEAT i := 1 TO N;
              Surfs := Surfs + IfcAssociatedSurface(C\IfcSurfaceCurve.AssociatedGeometry[i]);
              END_REPEAT;
            END_IF;
          END_IF;
          IF 'IFC4.IFCCOMPOSITECURVEONSURFACE' IN TYPEOF (C) THEN

            (* For an IfcCompositeCurveOnSurface the BasisSurface is the intersection of the BasisSurface of all the segments. *)

            N := SIZEOF(C\IfcCompositeCurve.Segments);
            Surfs := IfcGetBasisSurface(C\IfcCompositeCurve.Segments[1].ParentCurve);
            IF N > 1 THEN
              REPEAT i := 2 TO N;
                Surfs := Surfs * IfcGetBasisSurface(C\IfcCompositeCurve.Segments[1].ParentCurve);
              END_REPEAT;
            END_IF;
          END_IF;
          RETURN(Surfs);
        END_FUNCTION;
        */

        protected static List<T> IfcListToArray<T>(List<T> Lis, INTEGER Low, INTEGER U)
        {
            //NeedCheck
            INTEGER N;
            List<T> Res;
            N = Lis.Count;
            if(N!= U-Low + 1)
            {
                return null;
            }
            else
            {
                Res = new List<T>();
                for(int i = 1; i < N; i++)
                {
                    Res[Low + i - 1] = Lis[i];
                }
                return Res;
            }
          
        }
        /*
        (Lis : LIST [0:?] OF GENERIC : T;
               Low,U : INTEGER) : ARRAY OF GENERIC : T;
           LOCAL
             N   : INTEGER;
             Res : ARRAY [Low:U] OF GENERIC : T;
           END_LOCAL;

           N := SIZEOF(Lis);
           IF (N <> (U-Low +1)) THEN
             RETURN(?);
           ELSE
             Res := [Lis[1] : N];
             REPEAT i := 2 TO N;
               Res[Low+i-1] := Lis[i];
             END_REPEAT;
             RETURN(Res);
           END_IF;
        END_FUNCTION;
        */

        protected static LOGICAL IfcLoopHeadToTail(IfcEdgeLoop ALoop)
        {
            INTEGER N;
            LOGICAL P = true;

            N = ALoop.EdgeList.Count();
            for(int i = 1; i < N; i++)
            {
                P = P && ALoop.EdgeList[i - 1].EdgeEnd == ALoop.EdgeList[i].EdgeStart;
            }

            return null;
        }
        /*
        (ALoop : IfcEdgeLoop) : LOGICAL;
           LOCAL
             N : INTEGER;
             P : LOGICAL := TRUE;
           END_LOCAL;

             N := SIZEOF (ALoop.EdgeList);
             REPEAT i := 2 TO N;
               P := P AND (ALoop.EdgeList[i-1].EdgeEnd :=:
                           ALoop.EdgeList[i].EdgeStart);
             END_REPEAT;     
             RETURN (P);
        END_FUNCTION;
        */

        protected static List<List<T>> IfcMakeArrayOfArray<T>(List<List<T>> Lis, INTEGER Low1, INTEGER U1, INTEGER Low2, INTEGER U2)
        {
            //Later
            List<List<object>> Res;

            return null;
        }
        /*
        (Lis : LIST[1:?] OF LIST [1:?] OF GENERIC : T;
         Low1, U1, Low2, U2 : INTEGER):
        ARRAY [Low1:U1] OF ARRAY [Low2:U2] OF GENERIC : T;

          LOCAL
            Res : ARRAY[Low1:U1] OF ARRAY [Low2:U2] OF GENERIC : T;
          END_LOCAL;

          (* Check input dimensions for consistency *)
          IF (U1-Low1+1) <> SIZEOF(Lis) THEN
            RETURN (?);
          END_IF;
          IF (U2 - Low2 + 1 ) <> SIZEOF(Lis[1]) THEN
            RETURN (?) ;
          END_IF;

          (* Initialise Res with values from Lis[1] *)
          Res := [IfcListToArray(Lis[1], Low2, U2) : (U1-Low1 + 1)];
          REPEAT i := 2 TO HIINDEX(Lis);
            IF (U2-Low2+1) <> SIZEOF(Lis[i]) THEN
              RETURN (?);
            END_IF;
            Res[Low1+i-1] := IfcListToArray(Lis[i], Low2, U2);
          END_REPEAT;
          RETURN (Res);
        END_FUNCTION;
        */

        protected static IfcLengthMeasure IfcMlsTotalThickness(IfcMaterialLayerSet LayerSet)
        {
            IfcLengthMeasure Max = LayerSet.MaterialLayers[0].LayerThickness;
            if(LayerSet.MaterialLayers.Count > 0)
            {
                for(int i = 1; i < LayerSet.MaterialLayers.Count; i++)
                {
                    Max += LayerSet.MaterialLayers[i].LayerThickness;
                }
            }

            return Max;
        }
        /*
        (LayerSet : IfcMaterialLayerSet) : IfcLengthMeasure;
          LOCAL
            Max : IfcLengthMeasure := LayerSet.MaterialLayers[1].LayerThickness;    
          END_LOCAL;

          IF SIZEOF(LayerSet.MaterialLayers) > 1 THEN
            REPEAT i := 2 TO HIINDEX(LayerSet.MaterialLayers);
               Max := Max + LayerSet.MaterialLayers[i].LayerThickness;
            END_REPEAT;
          END_IF;
          RETURN (Max);
        END_FUNCTION;
        */
        protected static IfcVector IfcNormalise(IfcVector Arg)
        {
            return (IfcVector)IfcNormalise((IfcVectorOrDirection)Arg);
        }
        protected static IfcDirection IfcNormalise(IfcDirection Arg)
        {
            return (IfcDirection)IfcNormalise((IfcVectorOrDirection)Arg);
        }
        protected static IfcVectorOrDirection IfcNormalise(IfcVectorOrDirection Arg)
        {
            INTEGER Ndim;
            IfcDirection V =GetDirection(1, 0);
            IfcVector Vec =new IfcVector( GetDirection(1 , 0), 1);
            REAL Mag;
            IfcVectorOrDirection Result = V;
            if(Arg== null)
            {
                return null;
            }
            else
            {
                if (InTypeOf(Arg, EntityName.IFCVECTOR))
                {
                    IfcVector ArgVec = (IfcVector)Arg;
                    Ndim = Arg.GetDim();
                    V.DirectionRatios = ArgVec.Orientation.DirectionRatios;
                    Vec.Orientation = V;
                    if (ArgVec.Magnitude == 0)
                    {
                        return null;
                    }
                    else
                    {
                        Vec.Magnitude = 1;
                    }
                }
                else
                {
                    Ndim = Arg.GetDim();
                    IfcDirection ArgDir = (IfcDirection)Arg;
                    V.DirectionRatios = ArgDir.DirectionRatios;
                }

                Mag = 0;
                for (int i = 0; i < Ndim; i++)
                {
                    Mag += V.DirectionRatios[i] * V.DirectionRatios[i];
                }
                if (Mag > 0)
                {
                    Mag = MathF.Sqrt(Mag);
                }
                for (int i = 0; i < Ndim; i++)
                {
                    V.DirectionRatios[i] = (IfcReal)(V.DirectionRatios[i] / Mag);
                }
                if (InTypeOf(Arg, EntityName.IFCVECTOR))
                {
                    Vec.Orientation = V;
                    Result = Vec;
                }
                else
                {
                    Result = V;
                }
                return Result;
            }
        }
        /*
        (Arg : IfcVectorOrDirection) 
            : IfcVectorOrDirection;
        LOCAL
          Ndim : INTEGER;
          V    : IfcDirection
                 := IfcRepresentationItem() || IfcGeometricRepresentationItem () || IfcDirection([1.,0.]); 
          Vec  : IfcVector 
                 := IfcRepresentationItem() || IfcGeometricRepresentationItem () || IfcVector (
                    IfcRepresentationItem() || IfcGeometricRepresentationItem () || IfcDirection([1.,0.]), 1.);
          Mag  : REAL;
          Result : IfcVectorOrDirection
                 := V;
        END_LOCAL;

          IF NOT EXISTS (Arg) THEN
            RETURN (?);
          ELSE
            IF 'IFC4.IFCVECTOR' IN TYPEOF(Arg) THEN
              BEGIN
                Ndim := Arg\IfcVector.Dim;
                V.DirectionRatios := Arg\IfcVector.Orientation.DirectionRatios;
                Vec.Magnitude := Arg\IfcVector.Magnitude;
                Vec.Orientation := V;
                IF Arg\IfcVector.Magnitude = 0.0 THEN
                  RETURN(?);
                ELSE
                  Vec.Magnitude := 1.0;
                END_IF;
              END;
            ELSE
              BEGIN
                Ndim := Arg\IfcDirection.Dim;
                V.DirectionRatios := Arg\IfcDirection.DirectionRatios;
              END;
            END_IF;

            Mag := 0.0;
              REPEAT i := 1 TO Ndim;
                Mag := Mag + V.DirectionRatios[i]*V.DirectionRatios[i];
              END_REPEAT;
            IF Mag > 0.0 THEN
              Mag := SQRT(Mag);
              REPEAT i := 1 TO Ndim;
                V.DirectionRatios[i] := V.DirectionRatios[i]/Mag;
              END_REPEAT;
              IF 'IFC4.IFCVECTOR' IN TYPEOF(arg) THEN
                Vec.Orientation := V;
                Result := Vec;
              ELSE
                Result := V;
              END_IF;
            ELSE
              RETURN(?);
            END_IF;
          END_IF;
          RETURN (Result);
        END_FUNCTION;
        */

        protected static IfcDirection IfcOrthogonalComplement(IfcDirection Vec)
        {
            IfcDirection Result;
            if(Vec == null || Vec.Dim != 2)
            {
                return null;
            }
            else
            {
                Result = GetDirection(-Vec.DirectionRatios[1], Vec.DirectionRatios[0]);
            }
            return Result;
        }
        /*
        (Vec : IfcDirection) 
            : IfcDirection;
        LOCAL
          Result : IfcDirection ;
        END_LOCAL;
          IF NOT EXISTS (Vec) OR (Vec.Dim <> 2) THEN
            RETURN(?);
          ELSE
            Result := IfcRepresentationItem() || IfcGeometricRepresentationItem () || IfcDirection([-Vec.DirectionRatios[2], Vec.DirectionRatios[1]]);
            RETURN(Result);
          END_IF;
        END_FUNCTION;
        */

        protected static LOGICAL IfcPathHeadToTail(IfcPath APath)
        {
            INTEGER N = 0;
            LOGICAL P = null;
            N = APath.EdgeList.Count;
            for(int i = 2; i < N; i++)
            {
                if(P == null)
                {
                    P = APath.EdgeList[i - 1].EdgeEnd == APath.EdgeList[i].EdgeEnd;
                }
                else
                {
                    P = P && APath.EdgeList[i - 1].EdgeEnd == APath.EdgeList[i].EdgeEnd;
                }
            }
            return P;
        }
        /*
        (APath : IfcPath) : LOGICAL;
           LOCAL
             N : INTEGER := 0;
             P : LOGICAL := UNKNOWN;
           END_LOCAL;
             N := SIZEOF (APath.EdgeList);
           REPEAT i := 2 TO N;
              P := P AND (APath.EdgeList[i-1].EdgeEnd :=:
                          APath.EdgeList[i].EdgeStart);
           END_REPEAT;
           RETURN (P);
        END_FUNCTION;
        */

        protected static IfcDimensionCount IfcPointListDim(IfcCartesianPointList PointList)
        {
            if (InTypeOf(PointList, EntityName.IFCCARTESIANPOINTLIST2D))
            {
                return 2;
            }
            if (InTypeOf(PointList, EntityName.IFCCARTESIANPOINTLIST3D))
            {
                return 3;
            }
            return null;
        }
        /*
        (PointList : IfcCartesianPointList)
                   : IfcDimensionCount;

          IF ('IFC4.IFCCARTESIANPOINTLIST2D' IN TYPEOF(PointList))
            THEN RETURN(2);
          END_IF;		   
          IF ('IFC4.IFCCARTESIANPOINTLIST3D' IN TYPEOF(PointList))
            THEN RETURN(3);
          END_IF;		   
          RETURN (?);
        END_FUNCTION;
        */

        protected static LOGICAL IfcSameAxis2Placement(IfcAxis2Placement ap1, IfcAxis2Placement ap2, REAL Epsilon)
        {
            return (IfcSameDirection(ap1.GetP()[0], ap2.GetP()[0], Epsilon) &&
                  IfcSameDirection(ap1.GetP()[1], ap2.GetP()[1], Epsilon) &&
                  IfcSameCartesianPoint(ap1.GetLocation(), ap1.GetLocation(), Epsilon));
        }
        /*
        (ap1, ap2 : IfcAxis2Placement; Epsilon : REAL)
          : LOGICAL ;

          RETURN (IfcSameDirection(ap1.P[1],ap2.P[1],Epsilon) AND
                  IfcSameDirection(ap1.P[2],ap2.P[2],Epsilon) AND
                  IfcSameCartesianPoint(ap1.Location,ap1.Location,Epsilon));
        END_FUNCTION;
        */

        protected static LOGICAL IfcSameCartesianPoint(IfcCartesianPoint cp1, IfcCartesianPoint cp2, REAL Epsilon)
        {
            REAL cp1x = cp1.Coordinates[0];
            REAL cp1y = cp1.Coordinates[1];
            REAL cp1z = 0;
            REAL cp2x = cp2.Coordinates[0];
            REAL cp2y = cp2.Coordinates[1];
            REAL cp2z = 0;
            if(cp1.Coordinates.Count >2)
            {
                cp1z = cp1.Coordinates[2];
            }
            if (cp2.Coordinates.Count > 2)
            {
                cp2z = cp2.Coordinates[2];
            }
            return IfcSameValue(cp1x, cp2x, Epsilon) &&
                  IfcSameValue(cp1y, cp2y, Epsilon) &&
                  IfcSameValue(cp1z, cp2z, Epsilon);
        }
        /*
        (cp1, cp2 : IfcCartesianPoint; Epsilon : REAL)
            : LOGICAL;

          LOCAL
            cp1x : REAL := cp1.Coordinates[1];
            cp1y : REAL := cp1.Coordinates[2];
            cp1z : REAL := 0;
            cp2x : REAL := cp2.Coordinates[1];
            cp2y : REAL := cp2.Coordinates[2];
            cp2z : REAL := 0;
          END_LOCAL;

          IF (SIZEOF(cp1.Coordinates) > 2) THEN
            cp1z := cp1.Coordinates[3];
          END_IF;

          IF (SIZEOF(cp2.Coordinates) > 2) THEN
            cp2z := cp2.Coordinates[3];
          END_IF;

          RETURN (IfcSameValue(cp1x,cp2x,Epsilon) AND
                  IfcSameValue(cp1y,cp2y,Epsilon) AND
                  IfcSameValue(cp1z,cp2z,Epsilon));
        END_FUNCTION;
        */

        protected static LOGICAL IfcSameDirection(IfcDirection dir1, IfcDirection dir2, REAL Epsilon)
        {
            REAL dir1x = dir1.DirectionRatios[1];
            REAL dir1y = dir1.DirectionRatios[2];
            REAL dir1z = 0;
            REAL dir2x = dir2.DirectionRatios[1];
            REAL dir2y = dir2.DirectionRatios[2];
            REAL dir2z = 0;
            if (dir1.DirectionRatios.Count > 2)
            {
                dir1z = dir1.DirectionRatios[2];
            }
            if (dir2.DirectionRatios.Count > 2)
            {
                dir2z = dir2.DirectionRatios[2];
            }
            return IfcSameValue(dir1x, dir2x, Epsilon) &&
                   IfcSameValue(dir1y, dir2y, Epsilon) &&
                   IfcSameValue(dir1z, dir2z, Epsilon);
        }
        /*
        (dir1, dir2 : IfcDirection; Epsilon : REAL)
            : LOGICAL;
          LOCAL
            dir1x : REAL := dir1.DirectionRatios[1];
            dir1y : REAL := dir1.DirectionRatios[2];
            dir1z : REAL := 0;
            dir2x : REAL := dir2.DirectionRatios[1];
            dir2y : REAL := dir2.DirectionRatios[2];
            dir2z : REAL := 0;
          END_LOCAL;

          IF (SIZEOF(dir1.DirectionRatios) > 2) THEN
            dir1z := dir1.DirectionRatios[3];
          END_IF;

          IF (SIZEOF(dir2.DirectionRatios) > 2) THEN
            dir2z := dir2.DirectionRatios[3];
          END_IF;

          RETURN (IfcSameValue(dir1x,dir2x,Epsilon) AND
                  IfcSameValue(dir1y,dir2y,Epsilon) AND
                  IfcSameValue(dir1z,dir2z,Epsilon));
        END_FUNCTION;
        */

        protected static LOGICAL IfcSameValidPrecision(REAL Epsilon1, REAL Epsilon2)
        {
            REAL ValidEps1;
            REAL ValidEps2;
            REAL DefaultEps = 0.000001f;
            REAL DerivationOfEps = 1.001f;
            REAL UpperEps = 1.0f;
            ValidEps1 =  NVL(Epsilon1, DefaultEps);
            ValidEps2 = NVL(Epsilon2, DefaultEps);
            return((0.0 < ValidEps1) && (ValidEps1 <= (DerivationOfEps * ValidEps2)) &&
                   (ValidEps2 <= (DerivationOfEps * ValidEps1)) &&(ValidEps2 < UpperEps));
        }
        /*
        (Epsilon1, Epsilon2 : REAL) : LOGICAL ;
          LOCAL
            ValidEps1, ValidEps2 : REAL;
            DefaultEps           : REAL := 0.000001;
            DerivationOfEps      : REAL := 1.001;
            UpperEps             : REAL := 1.0;
          END_LOCAL;

            ValidEps1 := NVL(Epsilon1, DefaultEps);
            ValidEps2 := NVL(Epsilon2, DefaultEps);
            RETURN ((0.0 < ValidEps1) AND (ValidEps1 <= (DerivationOfEps * ValidEps2)) AND 
                    (ValidEps2 <= (DerivationOfEps * ValidEps1)) AND (ValidEps2 < UpperEps));
        END_FUNCTION;
        */

        protected static LOGICAL IfcSameValue(REAL Value1, REAL Value2, REAL Epsilon)
        {
            REAL ValidEps;
            REAL DefaultEps = 0.000001f;
            ValidEps = NVL(Epsilon, DefaultEps);

            return (Value1 + ValidEps > Value2) && (Value1 < Value2 + ValidEps);
        }
        /*
        (Value1, Value2 : REAL; Epsilon : REAL)
            : LOGICAL;
          LOCAL
            ValidEps    : REAL;
            DefaultEps  : REAL := 0.000001;
          END_LOCAL;

          ValidEps := NVL(Epsilon, DefaultEps);
          RETURN ((Value1 + ValidEps > Value2) AND (Value1 < Value2 + ValidEps));
        END_FUNCTION;
        */

        protected static IfcVector IfcScalarTimesVector(REAL Scalar, IfcVectorOrDirection Vec)
        {
            IfcDirection V;
            REAL Mag;
            IfcVector Result;

            if(Scalar == null || Vec == null)
            {
                return null;
            }
            else
            {
                if (InTypeOf(Vec, EntityName.IFCVECTOR))
                {
                    V = ((IfcVector)Vec).Orientation;
                    Mag = Scalar * ((IfcVector)Vec).Magnitude;
                }
                else
                {
                    V = (IfcDirection) Vec;
                    Mag = Scalar;
                    
                }
                if (Mag < 0)
                {
                    for (int i = 0; i < V.DirectionRatios.Count; i++)
                    {
                        V.DirectionRatios[i] = (-V.DirectionRatios[i]);
                    }
                    Mag = -Mag;
                }
                Result = new IfcVector(IfcNormalise(V), (float) Mag);
                return Result;
            }
        }
        /*
        (Scalar : REAL; Vec : IfcVectorOrDirection)
            : IfcVector;
        LOCAL
          V : IfcDirection;
          Mag : REAL;
          Result : IfcVector;
        END_LOCAL;

          IF NOT EXISTS (Scalar) OR NOT EXISTS (Vec) THEN
            RETURN (?) ;
          ELSE
            IF 'IFC4.IFCVECTOR' IN TYPEOF (Vec) THEN
              V := Vec\IfcVector.Orientation;
              Mag := Scalar * Vec\IfcVector.Magnitude;
            ELSE
              V := Vec;
              Mag := Scalar;
            END_IF;
            IF (Mag < 0.0 ) THEN
              REPEAT i := 1 TO SIZEOF(V.DirectionRatios);
                V.DirectionRatios[i] := -V.DirectionRatios[i];
              END_REPEAT;
              Mag := -Mag;
            END_IF;
            Result := IfcRepresentationItem() || IfcGeometricRepresentationItem () || IfcVector(IfcNormalise(V), Mag);
          END_IF;
          RETURN (Result);
        END_FUNCTION;
        */

        protected static IfcDirection IfcSecondProjAxis(IfcDirection ZAxis, IfcDirection XAxis, IfcDirection Arg)
        {
            IfcVector YAxis;
            IfcDirection V;
            IfcVector Temp;
            if(Arg == null)
            {
                V = GetDirection(0, 1, 0);
            }
            else
            {
                V = Arg;
            }

            Temp = IfcScalarTimesVector(IfcDotProduct(V, ZAxis), ZAxis);
            YAxis = IfcVectorDifference(V, Temp);
            Temp = IfcScalarTimesVector(IfcDotProduct(V, XAxis), XAxis);
            YAxis = IfcVectorDifference(YAxis, Temp);
            YAxis = IfcNormalise(YAxis);
            return YAxis.Orientation;
        }
        /*
        (ZAxis, XAxis, Arg: IfcDirection) 
            : IfcDirection;
        LOCAL
          YAxis : IfcVector;
          V     : IfcDirection;
          Temp  : IfcVector;
        END_LOCAL;

          IF NOT EXISTS(Arg) THEN
            V := IfcRepresentationItem() || IfcGeometricRepresentationItem () || IfcDirection([0.0,1.0,0.0]);
          ELSE
            V := Arg;
          END_IF;
          Temp  := IfcScalarTimesVector(IfcDotProduct(V, ZAxis), ZAxis);
          YAxis := IfcVectorDifference(V, Temp);
          Temp  := IfcScalarTimesVector(IfcDotProduct(V, XAxis), XAxis);
          YAxis := IfcVectorDifference(YAxis, Temp);
          YAxis := IfcNormalise(YAxis);
          RETURN(YAxis.Orientation);
        END_FUNCTION;
        */

        protected static LOGICAL IfcShapeRepresentationTypes(IfcLabel RepType, List<IfcRepresentationItem> Items)
        {
            INTEGER Count = 0;
            switch ((string) RepType)
            {
                case "Point":
                    Count = Items.Where(temp => InTypeOf(temp, EntityName.IFCPOINT)).Count();
                    break;
                case "PointCloud":
                    Count = Items.Where(temp => InTypeOf(temp, EntityName.IFCCARTESIANPOINTLIST3D)).Count();
                    break;
                case "Curve": 
                    Count = Items.Where(temp => InTypeOf(temp, EntityName.IFCCURVE)).Count();
                    break;
                case "Curve2D":
                    Count = Items.Where(temp => InTypeOf(temp, EntityName.IFCCURVE) && ((IfcCurve)temp).Dim == 2).Count();
                    break;
                case "Curve3D":
                    Count = Items.Where(temp => InTypeOf(temp, EntityName.IFCCURVE) && ((IfcCurve)temp).Dim == 3).Count();
                    break;
                case "Surface":
                    Count = Items.Where(temp => InTypeOf(temp, EntityName.IFCSURFACE)).Count();
                    break;
                case "Surface2D":
                    Count = Items.Where(temp => InTypeOf(temp, EntityName.IFCSURFACE) && ((IfcSurface)temp).Dim == 2).Count();
                    break;
                case "Surface3D":
                    Count = Items.Where(temp => InTypeOf(temp, EntityName.IFCSURFACE) && ((IfcSurface)temp).Dim == 3).Count();
                    break;
                case "FillArea":
                    Count = Items.Where(temp => InTypeOf(temp, EntityName.IFCANNOTATIONFILLAREA)).Count();
                    break;
                case "Text":
                    Count = Items.Where(temp => InTypeOf(temp, EntityName.IFCTEXTLITERAL)).Count();
                    break;
                case "AdvancedSurface": 
                    Count = Items.Where(temp => InTypeOf(temp, EntityName.IFCBSPLINESURFACE)).Count();
                    break;
                case "Annotation2D":
                    // needcheck
                    Count = Items.Where(temp =>
                    InTypeOf(temp, EntityName.IFCPOINT) ||
                    InTypeOf(temp, EntityName.IFCCURVE) ||
                    InTypeOf(temp, EntityName.IFCGEOMETRICCURVESET) ||
                    InTypeOf(temp, EntityName.IFCANNOTATIONFILLAREA) ||
                    InTypeOf(temp, EntityName.IFCTEXTLITERAL)
                    ).Count();
                    break;
                case "GeometricSet":
                    Count = Items.Where(temp =>
                    InTypeOf(temp, EntityName.IFCGEOMETRICSET) ||
                    InTypeOf(temp, EntityName.IFCPOINT) ||
                    InTypeOf(temp, EntityName.IFCCURVE) ||
                    InTypeOf(temp, EntityName.IFCSURFACE)
                    ).Count();
                    break;

                case "GeometricCurveSet":
                    Count = Items.Where(temp =>
                    InTypeOf(temp, EntityName.IFCGEOMETRICCURVESET) ||
                    InTypeOf(temp, EntityName.IFCGEOMETRICSET) ||
                    InTypeOf(temp, EntityName.IFCPOINT) ||
                    InTypeOf(temp, EntityName.IFCCURVE)
                    ).Count();
                    for(int i = 0; i < Items.Count; i++)
                    {
                        if(InTypeOf(Items[i], EntityName.IFCGEOMETRICSET))
                        {
                            if (((IfcGeometricSet)Items[i]).Elements.Where(temp =>InTypeOf(temp, EntityName.IFCSURFACE)).Count()> 0)
                            {
                                Count--;
                            }
                        }
                    }
                    break;
                case "Tessellation":
                    Count = Items.Where(temp => InTypeOf(temp, EntityName.IFCTESSELLATEDITEM)).Count();
                    break;
                case "SurfaceOrSolidModel":
                    // needcheck
                    Count = Items.Where(temp =>
                    InTypeOf(temp, EntityName.IFCTESSELLATEDITEM) ||
                    InTypeOf(temp, EntityName.IFCSHELLBASEDSURFACEMODEL) ||
                    InTypeOf(temp, EntityName.IFCFACEBASEDSURFACEMODEL) ||
                    InTypeOf(temp, EntityName.IFCSOLIDMODEL)
                    ).Count();
                    break;

                case "SurfaceModel":
                    // needcheck
                    Count = Items.Where(temp =>
                    InTypeOf(temp, EntityName.IFCTESSELLATEDITEM) ||
                    InTypeOf(temp, EntityName.IFCSHELLBASEDSURFACEMODEL) ||
                    InTypeOf(temp, EntityName.IFCFACEBASEDSURFACEMODEL)
                    ).Count();
                    break;
                case "SolidModel":
                    Count = Items.Where(temp => InTypeOf(temp, EntityName.IFCSOLIDMODEL)).Count();
                    break;
                case "SweptSolid":
                    Count = Items.Where(temp =>(
                        InTypeOf(temp, EntityName.IFCEXTRUDEDAREASOLID) ||
                        InTypeOf(temp, EntityName.IFCREVOLVEDAREASOLID)
                    ) &&(
                        !InTypeOf(temp, EntityName.IFCEXTRUDEDAREASOLIDTAPERED) &&
                        !InTypeOf(temp, EntityName.IFCREVOLVEDAREASOLIDTAPERED)
                    )
                    ).Count();
                    break; ;
                case "AdvancedSweptSolid":
                    Count = Items.Where(temp =>
                    InTypeOf(temp, EntityName.IFCSWEPTAREASOLID) ||
                    InTypeOf(temp, EntityName.IFCSWEPTDISKSOLID)
                    ).Count();
                    break;
                case "CSG":
                    Count = Items.Where(temp =>
                    InTypeOf(temp, EntityName.IFCBOOLEANRESULT) ||
                    InTypeOf(temp, EntityName.IFCCSGPRIMITIVE3D) ||
                    InTypeOf(temp, EntityName.IFCCSGSOLID)
                    ).Count();
                    break;
                case "Clipping":
                    Count = Items.Where(temp =>
                    InTypeOf(temp, EntityName.IFCCSGSOLID) ||
                    InTypeOf(temp, EntityName.IFCBOOLEANCLIPPINGRESULT)
                    ).Count();
                    break;
                case "Brep":
                    Count = Items.Where(temp => InTypeOf(temp, EntityName.IFCFACETEDBREP)).Count();
                    break;
                case "AdvancedBrep":
                    Count = Items.Where(temp => InTypeOf(temp, EntityName.IFCMANIFOLDSOLIDBREP)).Count();
                    break;
                case "BoundingBox":
                    Count = Items.Where(temp => InTypeOf(temp, EntityName.IFCBOUNDINGBOX)).Count();
                    if(Items.Count > 1)
                    {
                        Count = 0;
                    }
                    break;
                case "SectionedSpine":
                    Count = Items.Where(temp => InTypeOf(temp, EntityName.IFCSECTIONEDSPINE)).Count();
                    break;
                case "LightSource":
                    Count = Items.Where(temp => InTypeOf(temp, EntityName.IFCLIGHTSOURCE)).Count();
                    break;
                case "MappedRepresentation":
                    Count = Items.Where(temp => InTypeOf(temp, EntityName.IFCMAPPEDITEM)).Count();
                    break;
                default: break;
            }
            return Count == Items.Count;
        }
        /*
        (RepType : IfcLabel; Items : SET OF IfcRepresentationItem) : LOGICAL;

            LOCAL
              Count : INTEGER := 0;
            END_LOCAL;

            CASE RepType OF 
            'Point' :
              BEGIN 
                Count := SIZEOF(QUERY(temp <* Items | ('IFC4.IFCPOINT' IN TYPEOF(temp))));
              END;

            'PointCloud' :
              BEGIN 
                Count := SIZEOF(QUERY(temp <* Items | ('IFC4.IFCCARTESIANPOINTLIST3D' IN TYPEOF(temp))));
              END;

            'Curve' :
              BEGIN 
                Count := SIZEOF(QUERY(temp <* Items | ('IFC4.IFCCURVE' IN TYPEOF(temp))));
              END;

            'Curve2D' :
              BEGIN 
                Count := SIZEOF(QUERY(temp <* Items | ('IFC4.IFCCURVE' IN TYPEOF(temp)) 
                         AND (temp\IfcCurve.Dim = 2)));
              END;

            'Curve3D' :
              BEGIN 
                Count := SIZEOF(QUERY(temp <* Items | ('IFC4.IFCCURVE' IN TYPEOF(temp)) 
                         AND (temp\IfcCurve.Dim = 3)));
              END;

            'Surface' :
              BEGIN 
                Count := SIZEOF(QUERY(temp <* Items | ('IFC4.IFCSURFACE' IN TYPEOF(temp))));
              END;

            'Surface2D' :
              BEGIN 
                Count := SIZEOF(QUERY(temp <* Items | ('IFC4.IFCSURFACE' IN TYPEOF(temp)) 
                         AND (temp\IfcSurface.Dim = 2)));
              END;

            'Surface3D' :
              BEGIN 
                Count := SIZEOF(QUERY(temp <* Items | ('IFC4.IFCSURFACE' IN TYPEOF(temp)) 
                         AND (temp\IfcSurface.Dim = 3)));
              END;

            'FillArea' :
              BEGIN 
                Count := SIZEOF(QUERY(temp <* Items | ('IFC4.IFCANNOTATIONFILLAREA' IN TYPEOF(temp))));
              END;

            'Text' :
              BEGIN 
                Count := SIZEOF(QUERY(temp <* Items | ('IFC4.IFCTEXTLITERAL' IN TYPEOF(temp))));
              END;

            'AdvancedSurface' :
              BEGIN 
                Count := SIZEOF(QUERY(temp <* Items | 'IFC4.IFCBSPLINESURFACE' IN TYPEOF(temp)));
              END;

            'Annotation2D' :
              BEGIN
                Count := SIZEOF(QUERY(temp <* Items | (
                          SIZEOF(TYPEOF(temp) * [
                           'IFC4.IFCPOINT',
                           'IFC4.IFCCURVE',
                           'IFC4.IFCGEOMETRICCURVESET',
                           'IFC4.IFCANNOTATIONFILLAREA',
                           'IFC4.IFCTEXTLITERAL']) = 1)
                         ));
              END;

            'GeometricSet' : 
              BEGIN 
                Count := SIZEOF(QUERY(temp <* Items | ('IFC4.IFCGEOMETRICSET' IN TYPEOF(temp))
                         OR ('IFC4.IFCPOINT' IN TYPEOF(temp))
                         OR ('IFC4.IFCCURVE' IN TYPEOF(temp))
                         OR ('IFC4.IFCSURFACE' IN TYPEOF(temp))));
              END;

            'GeometricCurveSet' :
              BEGIN
                Count := SIZEOF(QUERY(temp <* Items | ('IFC4.IFCGEOMETRICCURVESET' IN TYPEOF(temp))
                         OR ('IFC4.IFCGEOMETRICSET' IN TYPEOF(temp))
                         OR ('IFC4.IFCPOINT' IN TYPEOF(temp))
                         OR ('IFC4.IFCCURVE' IN TYPEOF(temp))));
                 REPEAT i:=1 TO HIINDEX(Items);  
                   IF ('IFC4.IFCGEOMETRICSET' IN TYPEOF(Items[i]))
                   THEN
                     IF (SIZEOF(QUERY(temp <* Items[i]\IfcGeometricSet.Elements | 'IFC4.IFCSURFACE' IN TYPEOF(temp))) > 0)
                     THEN
                       Count := Count - 1;
                     END_IF;
                   END_IF;
                 END_REPEAT;
              END;

            'Tessellation' :
              BEGIN 
                Count := SIZEOF(QUERY(temp <* Items | 'IFC4.IFCTESSELLATEDITEM' IN TYPEOF(temp)));
              END;

            'SurfaceOrSolidModel' :
              BEGIN
                Count := SIZEOF(QUERY(temp <* Items | SIZEOF([
                           'IFC4.IFCTESSELLATEDITEM',
                           'IFC4.IFCSHELLBASEDSURFACEMODEL',
                           'IFC4.IFCFACEBASEDSURFACEMODEL',
                           'IFC4.IFCSOLIDMODEL'] * TYPEOF(temp)) >= 1
                         ));      
              END;

            'SurfaceModel' :
              BEGIN
                Count := SIZEOF(QUERY(temp <* Items | SIZEOF([
                           'IFC4.IFCTESSELLATEDITEM',
                           'IFC4.IFCSHELLBASEDSURFACEMODEL',
                           'IFC4.IFCFACEBASEDSURFACEMODEL'] * TYPEOF(temp)) >= 1
                         ));      
              END;

            'SolidModel' :
              BEGIN
                Count := SIZEOF(QUERY(temp <* Items | ('IFC4.IFCSOLIDMODEL' IN TYPEOF(temp))));            
              END;

            'SweptSolid' :
              BEGIN
                Count := SIZEOF(QUERY(temp <* Items | (SIZEOF([
                           'IFC4.IFCEXTRUDEDAREASOLID',
                           'IFC4.IFCREVOLVEDAREASOLID'] * TYPEOF(temp)) >= 1
                           ) AND (SIZEOF([
                           'IFC4.IFCEXTRUDEDAREASOLIDTAPERED',
                           'IFC4.IFCREVOLVEDAREASOLIDTAPERED'] * TYPEOF(temp)) = 0
                           )
                         ));                             
              END;

            'AdvancedSweptSolid' :
              BEGIN
                Count := SIZEOF(QUERY(temp <* Items | SIZEOF([
                           'IFC4.IFCSWEPTAREASOLID',
                           'IFC4.IFCSWEPTDISKSOLID'] *  TYPEOF(temp)) >= 1
                         ));      
              END;

            'CSG' :
              BEGIN
                Count := SIZEOF(QUERY(temp <* Items | SIZEOF([
                           'IFC4.IFCBOOLEANRESULT',
                           'IFC4.IFCCSGPRIMITIVE3D',
                           'IFC4.IFCCSGSOLID'] *  TYPEOF(temp)) >= 1
                         ));            
              END;

            'Clipping' :
              BEGIN
                Count := SIZEOF(QUERY(temp <* Items | SIZEOF([
                           'IFC4.IFCCSGSOLID',
                           'IFC4.IFCBOOLEANCLIPPINGRESULT'] * TYPEOF(temp)) >= 1
                         )); 
              END;

            'Brep' :
              BEGIN
                Count := SIZEOF(QUERY(temp <* Items | ('IFC4.IFCFACETEDBREP' IN TYPEOF(temp))));      
              END;

            'AdvancedBrep' :
              BEGIN
                Count := SIZEOF(QUERY(temp <* Items | ('IFC4.IFCMANIFOLDSOLIDBREP' IN TYPEOF(temp))));      
              END;

            'BoundingBox' :
              BEGIN
                Count := SIZEOF(QUERY(temp <* Items | ('IFC4.IFCBOUNDINGBOX' IN TYPEOF(temp))));
                IF (SIZEOF(Items) > 1)
                THEN
                  Count := 0;
                END_IF;   
              END;

            'SectionedSpine' :
              BEGIN
                Count := SIZEOF(QUERY(temp <* Items | ('IFC4.IFCSECTIONEDSPINE' IN TYPEOF(temp))));      
              END;

            'LightSource' :
              BEGIN
                Count := SIZEOF(QUERY(temp <* Items | ('IFC4.IFCLIGHTSOURCE' IN TYPEOF(temp))));      
              END;

            'MappedRepresentation' :
              BEGIN
                Count := SIZEOF(QUERY(temp <* Items | ('IFC4.IFCMAPPEDITEM' IN TYPEOF(temp))));  
              END;

             OTHERWISE : RETURN(?);
            END_CASE;
            RETURN (Count = SIZEOF(Items));
        END_FUNCTION;
        */

        protected static BOOLEAN IfcSurfaceWeightsPositive(IfcRationalBSplineSurfaceWithKnots B)
        {
            BOOLEAN Result = true;
            List<List<IfcReal>> Weights = B.Weights;

            for(int i = 0; i < B.UUpper; i++)
            {
                for (int j = 0; j < B.VUpper; j++)
                {
                    if (Weights[i][j] < 0)
                    {
                        Result = false;
                        return Result;
                    }    
                }
            }

            return Result;
        }
        /*
        ( B: IfcRationalBSplineSurfaceWithKnots) 
        : BOOLEAN;

          LOCAL
            Result : BOOLEAN := TRUE;
            Weights : ARRAY [ 0 : B\IfcBSplineSurface.UUpper ] OF ARRAY [ 0 : B\IfcBSplineSurface.VUpper ] OF REAL := B.Weights;
          END_LOCAL;

          REPEAT i := 0 TO B\IfcBSplineSurface.UUpper;
            REPEAT j := 0 TO B\IfcBSplineSurface.VUpper;
              IF (Weights[i][j] <= 0.0) THEN
                Result := FALSE;
                RETURN(Result);
              END_IF;
            END_REPEAT;
          END_REPEAT;
          RETURN(Result);
        END_FUNCTION;
        */

        protected static LOGICAL IfcTaperedSweptAreaProfiles(IfcProfileDef StartArea, IfcProfileDef EndArea)
        {
            LOGICAL Result = false;

            if (InTypeOf(StartArea, EntityName.IFCPARAMETERIZEDPROFILEDEF))
            {
                if (InTypeOf(EndArea, EntityName.IFCDERIVEDPROFILEDEF))
                {
                    Result= StartArea == ((IfcDerivedProfileDef)EndArea).ParentProfile;
                }
                else
                {
                    Result =StartArea.GetType() == EndArea.GetType();
                }
            }
            else
            {
                if (InTypeOf(EndArea, EntityName.IFCDERIVEDPROFILEDEF))
                {
                    Result = StartArea == ((IfcDerivedProfileDef)EndArea).ParentProfile;
                }
                else
                {
                    Result = false;
                }
            }
            return Result;
        }
        /*
        (StartArea, EndArea : IfcProfileDef)
         : LOGICAL;

        LOCAL
           Result : LOGICAL := FALSE;
        END_LOCAL;

        IF ('IFC4.IFCPARAMETERIZEDPROFILEDEF' IN TYPEOF(StartArea)) THEN
           IF ('IFC4.IFCDERIVEDPROFILEDEF' IN TYPEOF(EndArea)) THEN
              Result := (StartArea :=: EndArea\IfcDerivedProfileDef.ParentProfile);
           ELSE
              Result := (TYPEOF(StartArea) = TYPEOF(EndArea));
           END_IF;
        ELSE
           IF ('IFC4.IFCDERIVEDPROFILEDEF' IN TYPEOF(EndArea)) THEN
              Result := (StartArea :=: EndArea\IfcDerivedProfileDef.ParentProfile);
           ELSE
              Result := FALSE;
           END_IF;
        END_IF;

        RETURN(Result);
        END_FUNCTION;
        */

        protected static LOGICAL IfcTopologyRepresentationTypes(IfcLabel RepType, List<IfcRepresentationItem>Items)
        {
            INTEGER Count = 0;
            switch ((string) RepType)
            {
                case "Vertex":
                    Count = Items.Where(temp => InTypeOf(temp, EntityName.IFCVERTEX)).Count();
                    break;
                case "Edge":
                    Count = Items.Where(temp => InTypeOf(temp, EntityName.IFCEDGE)).Count();
                    break;
                case "Path":
                    Count = Items.Where(temp => InTypeOf(temp, EntityName.IFCPATH)).Count();
                    break;
                case "Face":
                    Count = Items.Where(temp => InTypeOf(temp, EntityName.IFCFACE) ).Count();
                    break;
                case "Shell":
                    Count = Items.Where(temp => InTypeOf(temp, EntityName.IFCOPENSHELL) || InTypeOf(temp, EntityName.IFCCLOSEDSHELL)).Count();
                    break;
                case "Undefined":
                    return true;
                default:
                    return null;
                  
            }
            return Count == Items.Count;
        }
        /*
        (RepType : IfcLabel; Items : SET OF IfcRepresentationItem) : LOGICAL;

            LOCAL
              Count : INTEGER := 0;
            END_LOCAL;

            CASE RepType OF 
            'Vertex' :
              BEGIN 
                Count := SIZEOF(QUERY(temp <* Items | 
                          ('IFC4.IFCVERTEX' IN TYPEOF(temp))));
              END;
            'Edge' : 
              BEGIN 
                Count := SIZEOF(QUERY(temp <* Items | 
                          ('IFC4.IFCEDGE' IN TYPEOF(temp))));
              END;
            'Path' : 
              BEGIN 
                Count := SIZEOF(QUERY(temp <* Items | 
                          ('IFC4.IFCPATH' IN TYPEOF(temp))));
              END;
            'Face' : 
              BEGIN 
                Count := SIZEOF(QUERY(temp <* Items | 
                          ('IFC4.IFCFACE' IN TYPEOF(temp))));
              END;
            'Shell' :
              BEGIN
                Count := SIZEOF(QUERY(temp <* Items | 
                          ('IFC4.IFCOPENSHELL' IN TYPEOF(temp))
                            OR ('IFC4.IFCCLOSEDSHELL' IN TYPEOF(temp))));
              END;
            'Undefined': RETURN(TRUE);
             OTHERWISE : RETURN(?);
            END_CASE;
            RETURN (Count = SIZEOF(Items));
        END_FUNCTION;
        */

        protected static LOGICAL IfcUniqueDefinitionNames(List< IfcRelDefinesByProperties> Relations)
        {
            IfcPropertySetDefinitionSelect Definition;
            IfcPropertySetDefinitionSet DefinitionSet;
            List<IfcPropertySetDefinition> Properties = new List<IfcPropertySetDefinition>();
            LOGICAL Result;
            if(Relations.Count == 0)
            {
                return true;
            }
            for(int i = 0;i < Relations.Count; i++)
            {
                Definition = Relations[i].RelatingPropertyDefinition;
                if (InTypeOf(Definition, EntityName.IFCPROPERTYSETDEFINITION))
                {
                    Properties.Add((IfcPropertySetDefinition) Definition);
                }
                else
                {
                    if (InTypeOf(Definition, EntityName.IFCPROPERTYSETDEFINITIONSET))
                    {
                        DefinitionSet = (IfcPropertySetDefinitionSet)Definition;
                        for(int j = 0; j < DefinitionSet.Count; i++)
                        {
                            Properties.Add(DefinitionSet[i]);
                        }
                    }
                }
            }
            Result = IfcUniquePropertySetNames(Properties);
            return Result;
        }
        /*
        (Relations : SET [1:?] OF IfcRelDefinesByProperties)
        :LOGICAL;

        LOCAL
          Definition : IfcPropertySetDefinitionSelect;
          DefinitionSet : IfcPropertySetDefinitionSet;
          Properties : SET OF IfcPropertySetDefinition := [];
          Result : LOGICAL;
        END_LOCAL;

        IF SIZEOF(Relations) = 0 THEN
          RETURN(TRUE);
        END_IF;

        REPEAT i:=1 TO HIINDEX(Relations);
          Definition := Relations[i].RelatingPropertyDefinition;
          IF 'IFC4.IFCPROPERTYSETDEFINITION' IN TYPEOF(Definition) THEN
            Properties := Properties + Definition;
          ELSE 
            IF 'IFC4.IFCPROPERTYSETDEFINITIONSET' IN TYPEOF(Definition) THEN
              BEGIN
                DefinitionSet := Definition;
                REPEAT j:= 1 TO HIINDEX(DefinitionSet);
                  Properties := Properties + DefinitionSet[j];
                END_REPEAT;
              END;
            END_IF;
          END_IF;
        END_REPEAT;

        Result := IfcUniquePropertySetNames(Properties);
        RETURN (Result);
        END_FUNCTION;
        */

        protected static LOGICAL IfcUniquePropertyName(List< IfcProperty> Properties)
        {
            List<IfcIdentifier> Names = new List<IfcIdentifier>() ;
            for (int i = 0; i < Properties.Count; i++)
            {
                var name = Properties[i].Name;
                if (!Names.Contains(name))
                {
                    Names.Add(name);
                }
            }
            return Names.Count == Properties.Count;
        }
        /*
        (Properties : SET [1:?] OF IfcProperty)
         :LOGICAL;

         LOCAL
           Names : SET OF IfcIdentifier := [];
         END_LOCAL;

         REPEAT i:=1 TO HIINDEX(Properties);
           Names := Names + Properties[i].Name;
         END_REPEAT;

         RETURN (SIZEOF(Names) = SIZEOF(Properties));
        END_FUNCTION;
        */

        protected static LOGICAL IfcUniquePropertySetNames(List<IfcPropertySetDefinition> Properties)
        {
            List<IfcLabel> Names = new List<IfcLabel>();
            INTEGER Unnamed = 0;
            for(int i = 0; i < Properties.Count; i++)
            {
                if (InTypeOf(Properties[i],EntityName.IFCPROPERTYSET))
                {
                    var name = Properties[i].Name;
                    if (!Names.Contains(name))
                    {
                        Names.Add(name);
                    }
                }
                else
                {
                    Unnamed++;
                }
               
            }
            return Names.Count + Unnamed == Properties.Count;
        }
        /*
        (Properties : SET [1:?] OF IfcPropertySetDefinition)
        :LOGICAL;

        LOCAL
          Names : SET OF IfcLabel := [];
          Unnamed : INTEGER := 0;
        END_LOCAL;

        REPEAT i:=1 TO HIINDEX(Properties);
          IF 'IFC4.IFCPROPERTYSET' IN TYPEOF(Properties[i]) THEN
            Names := Names + Properties[i]\IfcRoot.Name;
          ELSE
            Unnamed := Unnamed + 1;
          END_IF;
        END_REPEAT;

        RETURN (SIZEOF(Names) + Unnamed = SIZEOF(Properties));
        END_FUNCTION;
        */

        protected static LOGICAL IfcUniquePropertyTemplateNames(List<IfcPropertyTemplate> Properties)
        {
            List<IfcLabel> Names = new List<IfcLabel>();
            for (int i = 0; i < Properties.Count; i++)
            {
                var name = Properties[i].Name;
                if (!Names.Contains(name))
                {
                    Names.Add(name);
                }
            }
            return Names.Count == Properties.Count;
        }
        /*
        (Properties : SET [1:?] OF IfcPropertyTemplate)
        :LOGICAL;

        LOCAL
          Names : SET OF IfcLabel := [];
        END_LOCAL;

        REPEAT i:=1 TO HIINDEX(Properties);
          Names := Names + Properties[i].Name;
        END_REPEAT;
        RETURN (SIZEOF(Names) = SIZEOF(Properties));
        END_FUNCTION;
        */

        protected static LOGICAL IfcUniqueQuantityNames(List<IfcPhysicalQuantity> Properties)
        {
            List<IfcLabel> Names = new List<IfcLabel>();
            for (int i = 0; i < Properties.Count; i++)
            {
                var name = Properties[i].Name;
                if (!Names.Contains(name))
                {
                    Names.Add(name);
                }
            }
            return Names.Count == Properties.Count;
        }
        /*
        (Properties : SET [1:?] OF IfcPhysicalQuantity)
        :LOGICAL;

        LOCAL
          Names : SET OF IfcLabel := [];
        END_LOCAL;

        REPEAT i:=1 TO HIINDEX(Properties);
          Names := Names + Properties[i].Name;
        END_REPEAT;
        RETURN (SIZEOF(Names) = SIZEOF(Properties));
        END_FUNCTION;
        */

        protected static IfcVector IfcVectorDifference(IfcVectorOrDirection Arg1, IfcVectorOrDirection Arg2)
        {
            IfcVector Result;
            IfcDirection Res;
            IfcDirection Vec1;
            IfcDirection Vec2;
            REAL Mag;
            REAL Mag1;
            REAL Mag2;
            INTEGER Ndim;
            if(Arg1 == null || Arg2 == null || (float) Arg1.GetDim()!= (float) Arg2.GetDim())
            {
                return null;
            }
            else
            {
                if (InTypeOf(Arg1, EntityName.IFCVECTOR))
                {
                    Mag1 = ((IfcVector)Arg1).Magnitude;
                    Vec1 = ((IfcVector)Arg1).Orientation;
                }
                else
                {
                    Mag1 = 1;
                    Vec1 = (IfcDirection) Arg1;
                }
                if (InTypeOf(Arg2, EntityName.IFCVECTOR))
                {
                    Mag2 = ((IfcVector)Arg2).Magnitude;
                    Vec2 = ((IfcVector)Arg2).Orientation;
                }
                else
                {
                    Mag2 = 1;
                    Vec2 = (IfcDirection)Arg2;
                }
                Vec1 = IfcNormalise(Vec1);
                Vec2 = IfcNormalise(Vec2);
                Ndim = Vec1.DirectionRatios.Count;
                Mag = 0;
                Res = Ndim == 2? GetDirection(0, 0): GetDirection(0, 0, 0);
                
                for(int i = 0; i < Ndim; i++)
                {
                    Res.DirectionRatios[i] = (IfcReal) (Mag1 * Vec1.DirectionRatios[i] - Mag2 * Vec2.DirectionRatios[i]);
                    Mag += (IfcReal)(Res.DirectionRatios[i] * Res.DirectionRatios[i]);
                }
                if(Mag > 0)
                {
                    Result = new IfcVector(Res, MathF.Sqrt(Mag));
                }
                else
                {
                    Result = new IfcVector(Vec1, 0);
                }
            }
            return Result;
        }
        /*
        (Arg1, Arg2 : IfcVectorOrDirection)
            : IfcVector;
        LOCAL
          Result : IfcVector;
          Res, Vec1, Vec2 : IfcDirection;
          Mag, Mag1, Mag2 : REAL;
          Ndim : INTEGER;
        END_LOCAL;

          IF ((NOT EXISTS (Arg1)) OR (NOT EXISTS (Arg2))) OR (Arg1.Dim <> Arg2.Dim) THEN
            RETURN (?) ;
          ELSE
            BEGIN
              IF 'IFC4.IFCVECTOR' IN TYPEOF(Arg1) THEN
                Mag1 := Arg1\IfcVector.Magnitude;
                Vec1 := Arg1\IfcVector.Orientation;
              ELSE
                Mag1 := 1.0;
                Vec1 := Arg1;
              END_IF;
              IF 'IFC4.IFCVECTOR' IN TYPEOF(Arg2) THEN
                Mag2 := Arg2\IfcVector.Magnitude;
                Vec2 := Arg2\IfcVector.Orientation;
              ELSE
                Mag2 := 1.0;
                Vec2 := Arg2;
              END_IF;
              Vec1 := IfcNormalise (Vec1);
              Vec2 := IfcNormalise (Vec2);
              Ndim := SIZEOF(Vec1.DirectionRatios);
              Mag  := 0.0;
              Res  := IfcRepresentationItem() || IfcGeometricRepresentationItem () || IfcDirection([0.0:Ndim]);

              REPEAT i := 1 TO Ndim;
                Res.DirectionRatios[i] := Mag1*Vec1.DirectionRatios[i] - Mag2*Vec2.DirectionRatios[i];
                Mag := Mag + (Res.DirectionRatios[i]*Res.DirectionRatios[i]);
              END_REPEAT;

              IF (Mag > 0.0 ) THEN
                Result := IfcRepresentationItem() || IfcGeometricRepresentationItem () || IfcVector( Res, SQRT(Mag));
              ELSE
                Result := IfcRepresentationItem() || IfcGeometricRepresentationItem () || IfcVector( Vec1, 0.0);
              END_IF;
            END;
          END_IF;
          RETURN (Result);
        END_FUNCTION;
        */

        protected static IfcVector IfcVectorSum(IfcVectorOrDirection Arg1, IfcVectorOrDirection Arg2)
        {
            IfcVector Result;
            IfcDirection Res;
            IfcDirection Vec1;
            IfcDirection Vec2;
            REAL Mag;
            REAL Mag1;
            REAL Mag2;
            INTEGER Ndim;
            if (Arg1 == null || Arg2 == null || Arg1.GetDim() != Arg2.GetDim())
            {
                return null;
            }
            else
            {
                if (InTypeOf(Arg1, EntityName.IFCVECTOR))
                {
                    Mag1 = ((IfcVector)Arg1).Magnitude;
                    Vec1 = ((IfcVector)Arg1).Orientation;
                }
                else
                {
                    Mag1 = 1;
                    Vec1 = (IfcDirection)Arg1;
                }
                if (InTypeOf(Arg2, EntityName.IFCVECTOR))
                {
                    Mag2 = ((IfcVector)Arg2).Magnitude;
                    Vec2 = ((IfcVector)Arg2).Orientation;
                }
                else
                {
                    Mag2 = 1;
                    Vec2 = (IfcDirection)Arg2;
                }
                Vec1 = IfcNormalise(Vec1);
                Vec2 = IfcNormalise(Vec2);
                Ndim = Vec1.DirectionRatios.Count;
                Mag = 0;
                Res = Ndim == 2 ? GetDirection(0, 0) : GetDirection(0, 0, 0);

                for (int i = 0; i < Ndim; i++)
                {
                    Res.DirectionRatios[i] = (IfcReal)(Mag1 * Vec1.DirectionRatios[i] + Mag2 * Vec2.DirectionRatios[i]);
                    Mag += (IfcReal)(Res.DirectionRatios[i] * Res.DirectionRatios[i]);
                }
                if (Mag > 0)
                {
                    Result = new IfcVector(Res, MathF.Sqrt(Mag));
                }
                else
                {
                    Result = new IfcVector(Vec1, 0);
                }
            }
            return Result;
        }
        /*
        (Arg1, Arg2 : IfcVectorOrDirection) 
            : IfcVector;
        LOCAL
          Result : IfcVector;
          Res, Vec1, Vec2 : IfcDirection;
          Mag, Mag1, Mag2 : REAL;
          Ndim : INTEGER;
        END_LOCAL;

          IF ((NOT EXISTS (Arg1)) OR (NOT EXISTS (Arg2))) OR (Arg1.Dim <> Arg2.Dim) THEN
            RETURN (?) ;
          ELSE
            BEGIN
              IF 'IFC4.IFCVECTOR' IN TYPEOF(Arg1) THEN
                Mag1 := Arg1\IfcVector.Magnitude;
                Vec1 := Arg1\IfcVector.Orientation;
              ELSE
                Mag1 := 1.0;
                Vec1 := Arg1;
              END_IF;
              IF 'IFC4.IFCVECTOR' IN TYPEOF(Arg2) THEN
                Mag2 := Arg2\IfcVector.Magnitude;
                Vec2 := Arg2\IfcVector.Orientation;
              ELSE
                Mag2 := 1.0;
                Vec2 := Arg2;
              END_IF;
              Vec1 := IfcNormalise (Vec1);
              Vec2 := IfcNormalise (Vec2);
              Ndim := SIZEOF(Vec1.DirectionRatios);
              Mag  := 0.0;
              Res  := IfcRepresentationItem() || IfcGeometricRepresentationItem () || IfcDirection([0.0:Ndim]);

              REPEAT i := 1 TO Ndim;
                Res.DirectionRatios[i] := Mag1*Vec1.DirectionRatios[i] + Mag2*Vec2.DirectionRatios[i];
                Mag := Mag + (Res.DirectionRatios[i]*Res.DirectionRatios[i]);
              END_REPEAT;

              IF (Mag > 0.0 ) THEN
                Result := IfcRepresentationItem() || IfcGeometricRepresentationItem () || IfcVector( Res, SQRT(Mag));
              ELSE
                Result := IfcRepresentationItem() || IfcGeometricRepresentationItem () || IfcVector( Vec1, 0.0);
              END_IF;
            END;
          END_IF;
          RETURN (Result);
        END_FUNCTION;
        */











    }

}
