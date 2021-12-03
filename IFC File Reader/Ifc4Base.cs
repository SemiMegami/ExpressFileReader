using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFC4
{
	public abstract class IfcBase
	{

		protected static List<string> ReadIFCDataLine(string ifcText)
        {
			List<string> outputText = new List<string>();

			char[] chars = ifcText.ToCharArray();


			int n = chars.Length;



			for(int i = 0; i < n; i++)
            {
				IfcRepresentationItem a;

				IfcDirection b;
			}



			return outputText;

		}

		public object NVL(object a, object b)
        {
			return a == null ? b : a;
        }




		public IfcSurface IfcAssociatedSurface(IfcPcurve Arg)
		{
			IfcSurface Surf;
			Surf = Arg.BasisSurface;
			return Surf;
		}

		public void IfcBaseAxis()
		{
		}

		public void IfcBooleanChoose()
		{
		}

		public void IfcBuild2Axes()
		{
		}

		public void IfcBuildAxes()
		{
		}

		public void IfcConsecutiveSegments()
		{
		}

		public void IfcConstraintsParamBSpline()
		{
		}

		public void IfcConvertDirectionInto2D()
		{
		}

		public void IfcCorrectDimensions()
		{
		}

		public void IfcCorrectFillAreaStyle()
		{
		}

		public void IfcCorrectLocalPlacement()
		{
		}

		public void IfcCorrectObjectAssignment()
		{
		}

		public void IfcCorrectUnitAssignment()
		{
		}

		public void IfcCrossProduct()
		{
		}

		public void IfcCurveDim()
		{
		}

		public void IfcCurveWeightsPositive()
		{
		}

		public void IfcDeriveDimensionalExponents()
		{
		}

		public void IfcDimensionsForSiUnit()
		{
		}

		public void IfcDotProduct()
		{
		}

		public void IfcFirstProjAxis()
		{
		}

		public void IfcGetBasisSurface()
		{
		}

		public void IfcListToArray()
		{
		}

		public void IfcLoopHeadToTail()
		{
		}

		public void IfcMakeArrayOfArray()
		{
		}

		public void IfcMlsTotalThickness()
		{
		}

		public void IfcNormalise()
		{
		}

		public void IfcOrthogonalComplement()
		{
		}

		public void IfcPathHeadToTail()
		{
		}

		public void IfcPointListDim()
		{
		}

		public void IfcSameAxis2Placement()
		{
		}

		public void IfcSameCartesianPoint()
		{
		}

		public void IfcSameDirection()
		{
		}

		public void IfcSameValidPrecision()
		{
		}

		public void IfcSameValue()
		{
		}

		public void IfcScalarTimesVector()
		{
		}

		public void IfcSecondProjAxis()
		{
		}

		public void IfcShapeRepresentationTypes()
		{
		}

		public void IfcSurfaceWeightsPositive()
		{
		}

		public void IfcTaperedSweptAreaProfiles()
		{
		}

		public void IfcTopologyRepresentationTypes()
		{
		}

		public void IfcUniqueDefinitionNames()
		{
		}

		public void IfcUniquePropertyName()
		{
		}

		public void IfcUniquePropertySetNames()
		{
		}

		public void IfcUniquePropertyTemplateNames()
		{
		}

		public void IfcUniqueQuantityNames()
		{
		}

		public void IfcVectorDifference()
		{
		}

		public void IfcVectorSum()
		{
		}



	}

}
