using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFCReader
{
    class DeriveMapping
    {

        public static Dictionary<string, string> GetIFC4DeriveMapping()
        {
            var results = new Dictionary<string, string>() {
                {"NVL (IfcNormalise(Axis), IfcRepresentationItem() || IfcGeometricRepresentationItem () || IfcDirection([0.0,0.0,1.0]));","GetDirection(0, 0, 1);"},
                {"IfcBuild2Axes(RefDirection);","IfcBuild2Axes(RefDirection);"},
                {"IfcBuildAxes(Axis, RefDirection);","Axis != null? IfcBuildAxes(Axis, RefDirection): new List<IfcDirection>() {GetDirection(1,0,0), GetDirection(0, 1, 0), GetDirection(0, 0, 1) };"},
                {"(SIZEOF(ControlPointsList) - 1);","ControlPointsList.Count;"},
                {"SIZEOF(ControlPointsList) - 1;","ControlPointsList.Count;"},
                {"IfcListToArray(ControlPointsList,0,UpperIndexOnControlPoints);","IfcListToArray(ControlPointsList, 0, UpperIndexOnControlPoints);"},
                {"SIZEOF(Knots);","Knots.Count;"},
                {"SIZEOF(ControlPointsList[1]) - 1;","ControlPointsList[0].Count;"},
                {"IfcMakeArrayOfArray(ControlPointsList,","IfcMakeArrayOfArray(ControlPointsList, 0, UUpper, 0, VUpper);"},
                {"SIZEOF(VKnots);","VKnots.Count;"},
                {"SIZEOF(UKnots);","UKnots.Count;"},
                {"FirstOperand.Dim;","FirstOperand.GetDim();"},
                {"HIINDEX(Coordinates);","Coordinates.Count;"},
                {"IfcPointListDim(SELF);","IfcPointListDim(this);"},
                {"NVL(Scale, 1.0);","NVL(Scale, 1);"},
                {"LocalOrigin.Dim;","LocalOrigin.Dim;"},
                {"IfcBaseAxis(2,SELF\\IfcCartesianTransformationOperator.Axis1,","IfcBaseAxis(2, Axis1, Axis2, null);"},
                {"NVL(Scale2, SELF\\IfcCartesianTransformationOperator.Scl);","NVL(Scale2, Scl);"},
                {"IfcBaseAxis(3,SELF\\IfcCartesianTransformationOperator.Axis1,","IfcBaseAxis(3, Axis1, Axis2, Axis3);" },
                {"NVL(Scale3, SELF\\IfcCartesianTransformationOperator.Scl);","NVL(Scale3, Scl);" },
                {"SIZEOF(Segments);","(IfcInteger)Segments.Count;" },
                {"Segments[NSegments].Transition <> Discontinuous;","(IfcLogical)(Segments[Segments.Count - 1].Transition != IfcTransitionCode.DISCONTINUOUS);" },
                {"IfcGetBasisSurface(SELF);","IfcGetBasisSurface(this);" },
                {"3;","(IfcDimensionCount)3;" },
                {"IfcCurveDim(SELF);","IfcCurveDim(this);" },
                {"IfcDeriveDimensionalExponents(Elements);","IfcDeriveDimensionalExponents(Elements);"},
                {"HIINDEX(DirectionRatios);","(IfcDimensionCount)DirectionRatios.Count;"},
                {"SIZEOF(EdgeList);","(IfcInteger)EdgeList.Count;"},
                {"Elements[1].Dim;","Elements[0].GetDim();"},
                {"IfcMlsTotalThickness(SELF);","IfcMlsTotalThickness(this);"},
                {"Location.Dim;","Location.Dim;"},
                {"BasisCurve.Dim;","BasisCurve.Dim;"},
                {"BasisSurface.Dim;","BasisSurface.Dim;"},
                {"IfcListToArray(WeightsData,0,SELF\\IfcBSplineCurve.UpperIndexOnControlPoints);","IfcListToArray(WeightsData, 0, UpperIndexOnControlPoints);"},
                {"IfcMakeArrayOfArray(WeightsData,0,UUpper,0,VUpper);","IfcMakeArrayOfArray(WeightsData, 0, UUpper, 0, VUpper);"},
                {"IfcRepresentationItem() || IfcGeometricRepresentationItem () || IfcCurve() || IfcLine(Axis.Location, ","new IfcLine(Axis.Location, new IfcVector(Axis.Z, 1));"},
                {"IfcRepresentationItem() || IfcGeometricRepresentationItem () || IfcVector (ExtrudedDirection, Depth);","new IfcVector(ExtrudedDirection, Depth);"},
                {"IfcRepresentationItem() || IfcGeometricRepresentationItem () || IfcCurve() || IfcLine(AxisPosition.Location, ","new IfcLine(AxisPosition.Location, new IfcVector(AxisPosition.Z, 1));"},
                {"HIINDEX(Rows[1].RowCells);","(IfcInteger)Rows[0].RowCells.Count;"},
                {"SIZEOF(QUERY( Temp <* Rows | Temp.IsHeading));","(IfcInteger)Rows.Where(Temp => Temp.IsHeading).Count();"},
                {"SIZEOF(QUERY( Temp <* Rows | NOT(Temp.IsHeading)));","(IfcInteger)Rows.Where(Temp => !Temp.IsHeading).Count();"},
                {"SIZEOF(CoordIndex);","(IfcInteger)CoordIndex.Count();"},
                {"Orientation.Dim;","Orientation.Dim;"},

                {"ParentCurve.Dim;","ParentCurve.Dim;"}

            };
            return results;
        }
    }
    
}
