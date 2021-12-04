using System.Collections.Generic;
namespace IFC4
{
	public class IfcAbsorbedDoseMeasure : REAL, IfcDerivedMeasureValue
	{
		public IfcAbsorbedDoseMeasure() { }
	}

	public class IfcAccelerationMeasure : REAL, IfcDerivedMeasureValue
	{
		public IfcAccelerationMeasure() { }
	}

	public class IfcAmountOfSubstanceMeasure : REAL, IfcMeasureValue
	{
		public IfcAmountOfSubstanceMeasure() { }
	}

	public class IfcAngularVelocityMeasure : REAL, IfcDerivedMeasureValue
	{
		public IfcAngularVelocityMeasure() { }
	}

	public class IfcArcIndex : IfcSegmentIndexSelect
	{
		public List<IfcPositiveInteger> Value { get; set; }
		public List<IfcPositiveInteger> GetValue() { return Value; }

		public IfcArcIndex() { }
	}

	public class IfcAreaDensityMeasure : REAL, IfcDerivedMeasureValue
	{
		public IfcAreaDensityMeasure() { }
	}

	public class IfcAreaMeasure : REAL, IfcMeasureValue
	{
		public IfcAreaMeasure() { }
	}

	public class IfcBinary : BINARY, IfcSimpleValue
	{
		public IfcBinary() { }
	}

	public class IfcBoolean : BOOLEAN, IfcModulusOfRotationalSubgradeReactionSelect, IfcModulusOfSubgradeReactionSelect, IfcModulusOfTranslationalSubgradeReactionSelect, IfcRotationalStiffnessSelect, IfcSimpleValue, IfcTranslationalStiffnessSelect, IfcWarpingStiffnessSelect
	{
		public IfcBoolean() { }
	}

	public class IfcBoxAlignment : IfcLabel
	{
		public IfcBoxAlignment() { }
	}

	public class IfcCardinalPointReference : INTEGER
	{
		public IfcCardinalPointReference() { }
	}

	public class IfcComplexNumber : IfcMeasureValue
	{
		public List<REAL> Value { get; set; }

		public IfcComplexNumber() { }
	}

	public class IfcCompoundPlaneAngleMeasure : IfcDerivedMeasureValue
	{
		public List<INTEGER> Value { get; set; }

		public IfcCompoundPlaneAngleMeasure() { }
	}

	public class IfcContextDependentMeasure : REAL, IfcMeasureValue
	{
		public IfcContextDependentMeasure() { }
	}

	public class IfcCountMeasure : NUMBER, IfcMeasureValue
	{
		public IfcCountMeasure() { }
	}

	public class IfcCurvatureMeasure : REAL, IfcDerivedMeasureValue
	{
		public IfcCurvatureMeasure() { }
	}

	public class IfcDate : STRING, IfcSimpleValue
	{
		public IfcDate() { }
	}

	public class IfcDateTime : STRING, IfcSimpleValue
	{
		public IfcDateTime() { }
	}

	public class IfcDayInMonthNumber : INTEGER
	{
		public IfcDayInMonthNumber() { }
	}

	public class IfcDayInWeekNumber : INTEGER
	{
		public IfcDayInWeekNumber() { }
	}

	public class IfcDescriptiveMeasure : STRING, IfcMeasureValue, IfcSizeSelect
	{
		public IfcDescriptiveMeasure() { }
	}

	public class IfcDimensionCount : INTEGER
	{
		public IfcDimensionCount() { }
	}

	public class IfcDoseEquivalentMeasure : REAL, IfcDerivedMeasureValue
	{
		public IfcDoseEquivalentMeasure() { }
	}

	public class IfcDuration : STRING, IfcSimpleValue, IfcTimeOrRatioSelect
	{
		public IfcDuration() { }
	}

	public class IfcDynamicViscosityMeasure : REAL, IfcDerivedMeasureValue
	{
		public IfcDynamicViscosityMeasure() { }
	}

	public class IfcElectricCapacitanceMeasure : REAL, IfcDerivedMeasureValue
	{
		public IfcElectricCapacitanceMeasure() { }
	}

	public class IfcElectricChargeMeasure : REAL, IfcDerivedMeasureValue
	{
		public IfcElectricChargeMeasure() { }
	}

	public class IfcElectricConductanceMeasure : REAL, IfcDerivedMeasureValue
	{
		public IfcElectricConductanceMeasure() { }
	}

	public class IfcElectricCurrentMeasure : REAL, IfcMeasureValue
	{
		public IfcElectricCurrentMeasure() { }
	}

	public class IfcElectricResistanceMeasure : REAL, IfcDerivedMeasureValue
	{
		public IfcElectricResistanceMeasure() { }
	}

	public class IfcElectricVoltageMeasure : REAL, IfcDerivedMeasureValue
	{
		public IfcElectricVoltageMeasure() { }
	}

	public class IfcEnergyMeasure : REAL, IfcDerivedMeasureValue
	{
		public IfcEnergyMeasure() { }
	}

	public class IfcFontStyle : STRING
	{
		public IfcFontStyle() { }
	}

	public class IfcFontVariant : STRING
	{
		public IfcFontVariant() { }
	}

	public class IfcFontWeight : STRING
	{
		public IfcFontWeight() { }
	}

	public class IfcForceMeasure : REAL, IfcDerivedMeasureValue
	{
		public IfcForceMeasure() { }
	}

	public class IfcFrequencyMeasure : REAL, IfcDerivedMeasureValue
	{
		public IfcFrequencyMeasure() { }
	}

	public class IfcGloballyUniqueId : STRING
	{
		public IfcGloballyUniqueId() { }
	}

	public class IfcHeatFluxDensityMeasure : REAL, IfcDerivedMeasureValue
	{
		public IfcHeatFluxDensityMeasure() { }
	}

	public class IfcHeatingValueMeasure : REAL, IfcDerivedMeasureValue
	{
		public IfcHeatingValueMeasure() { }
	}

	public class IfcIdentifier : STRING, IfcSimpleValue
	{
		public IfcIdentifier() { }
	}

	public class IfcIlluminanceMeasure : REAL, IfcDerivedMeasureValue
	{
		public IfcIlluminanceMeasure() { }
	}

	public class IfcInductanceMeasure : REAL, IfcDerivedMeasureValue
	{
		public IfcInductanceMeasure() { }
	}

	public class IfcInteger : INTEGER, IfcSimpleValue
	{
		public IfcInteger() { }
	}

	public class IfcIntegerCountRateMeasure : INTEGER, IfcDerivedMeasureValue
	{
		public IfcIntegerCountRateMeasure() { }
	}

	public class IfcIonConcentrationMeasure : REAL, IfcDerivedMeasureValue
	{
		public IfcIonConcentrationMeasure() { }
	}

	public class IfcIsothermalMoistureCapacityMeasure : REAL, IfcDerivedMeasureValue
	{
		public IfcIsothermalMoistureCapacityMeasure() { }
	}

	public class IfcKinematicViscosityMeasure : REAL, IfcDerivedMeasureValue
	{
		public IfcKinematicViscosityMeasure() { }
	}

	public class IfcLabel : STRING, IfcSimpleValue
	{
		public IfcLabel() { }
	}

	public class IfcLanguageId : IfcIdentifier
	{
		public IfcLanguageId() { }
	}

	public class IfcLengthMeasure : REAL, IfcBendingParameterSelect, IfcMeasureValue, IfcSizeSelect
	{
		public IfcLengthMeasure() { }
	}

	public class IfcLineIndex : IfcSegmentIndexSelect
	{
		public List<IfcPositiveInteger> Value { get; set; }
		public List<IfcPositiveInteger> GetValue() { return Value; }

		public IfcLineIndex() { }
	}

	public class IfcLinearForceMeasure : REAL, IfcDerivedMeasureValue
	{
		public IfcLinearForceMeasure() { }
	}

	public class IfcLinearMomentMeasure : REAL, IfcDerivedMeasureValue
	{
		public IfcLinearMomentMeasure() { }
	}

	public class IfcLinearStiffnessMeasure : REAL, IfcDerivedMeasureValue, IfcTranslationalStiffnessSelect
	{
		public IfcLinearStiffnessMeasure() { }
	}

	public class IfcLinearVelocityMeasure : REAL, IfcDerivedMeasureValue
	{
		public IfcLinearVelocityMeasure() { }
	}

	public class IfcLogical : LOGICAL, IfcSimpleValue
	{
		public IfcLogical() { }
	}

	public class IfcLuminousFluxMeasure : REAL, IfcDerivedMeasureValue
	{
		public IfcLuminousFluxMeasure() { }
	}

	public class IfcLuminousIntensityDistributionMeasure : REAL, IfcDerivedMeasureValue
	{
		public IfcLuminousIntensityDistributionMeasure() { }
	}

	public class IfcLuminousIntensityMeasure : REAL, IfcMeasureValue
	{
		public IfcLuminousIntensityMeasure() { }
	}

	public class IfcMagneticFluxDensityMeasure : REAL, IfcDerivedMeasureValue
	{
		public IfcMagneticFluxDensityMeasure() { }
	}

	public class IfcMagneticFluxMeasure : REAL, IfcDerivedMeasureValue
	{
		public IfcMagneticFluxMeasure() { }
	}

	public class IfcMassDensityMeasure : REAL, IfcDerivedMeasureValue
	{
		public IfcMassDensityMeasure() { }
	}

	public class IfcMassFlowRateMeasure : REAL, IfcDerivedMeasureValue
	{
		public IfcMassFlowRateMeasure() { }
	}

	public class IfcMassMeasure : REAL, IfcMeasureValue
	{
		public IfcMassMeasure() { }
	}

	public class IfcMassPerLengthMeasure : REAL, IfcDerivedMeasureValue
	{
		public IfcMassPerLengthMeasure() { }
	}

	public class IfcModulusOfElasticityMeasure : REAL, IfcDerivedMeasureValue
	{
		public IfcModulusOfElasticityMeasure() { }
	}

	public class IfcModulusOfLinearSubgradeReactionMeasure : REAL, IfcDerivedMeasureValue, IfcModulusOfTranslationalSubgradeReactionSelect
	{
		public IfcModulusOfLinearSubgradeReactionMeasure() { }
	}

	public class IfcModulusOfRotationalSubgradeReactionMeasure : REAL, IfcDerivedMeasureValue, IfcModulusOfRotationalSubgradeReactionSelect
	{
		public IfcModulusOfRotationalSubgradeReactionMeasure() { }
	}

	public class IfcModulusOfSubgradeReactionMeasure : REAL, IfcDerivedMeasureValue, IfcModulusOfSubgradeReactionSelect
	{
		public IfcModulusOfSubgradeReactionMeasure() { }
	}

	public class IfcMoistureDiffusivityMeasure : REAL, IfcDerivedMeasureValue
	{
		public IfcMoistureDiffusivityMeasure() { }
	}

	public class IfcMolecularWeightMeasure : REAL, IfcDerivedMeasureValue
	{
		public IfcMolecularWeightMeasure() { }
	}

	public class IfcMomentOfInertiaMeasure : REAL, IfcDerivedMeasureValue
	{
		public IfcMomentOfInertiaMeasure() { }
	}

	public class IfcMonetaryMeasure : REAL, IfcDerivedMeasureValue
	{
		public IfcMonetaryMeasure() { }
	}

	public class IfcMonthInYearNumber : INTEGER
	{
		public IfcMonthInYearNumber() { }
	}

	public class IfcNonNegativeLengthMeasure : IfcLengthMeasure, IfcMeasureValue
	{
		public IfcNonNegativeLengthMeasure() { }
	}

	public class IfcNormalisedRatioMeasure : IfcRatioMeasure, IfcColourOrFactor, IfcMeasureValue, IfcSizeSelect
	{
		public IfcNormalisedRatioMeasure() { }
	}

	public class IfcNumericMeasure : NUMBER, IfcMeasureValue
	{
		public IfcNumericMeasure() { }
	}

	public class IfcPHMeasure : REAL, IfcDerivedMeasureValue
	{
		public IfcPHMeasure() { }
	}

	public class IfcParameterValue : REAL, IfcMeasureValue, IfcTrimmingSelect
	{
		public IfcParameterValue() { }
	}

	public class IfcPlanarForceMeasure : REAL, IfcDerivedMeasureValue
	{
		public IfcPlanarForceMeasure() { }
	}

	public class IfcPlaneAngleMeasure : REAL, IfcBendingParameterSelect, IfcMeasureValue
	{
		public IfcPlaneAngleMeasure() { }
	}

	public class IfcPositiveInteger : IfcInteger, IfcSimpleValue
	{
		public IfcPositiveInteger() { }
	}

	public class IfcPositiveLengthMeasure : IfcLengthMeasure, IfcHatchLineDistanceSelect, IfcMeasureValue, IfcSizeSelect
	{
		public IfcPositiveLengthMeasure() { }
	}

	public class IfcPositivePlaneAngleMeasure : IfcPlaneAngleMeasure, IfcMeasureValue
	{
		public IfcPositivePlaneAngleMeasure() { }
	}

	public class IfcPositiveRatioMeasure : IfcRatioMeasure, IfcMeasureValue, IfcSizeSelect
	{
		public IfcPositiveRatioMeasure() { }
	}

	public class IfcPowerMeasure : REAL, IfcDerivedMeasureValue
	{
		public IfcPowerMeasure() { }
	}

	public class IfcPresentableText : STRING
	{
		public IfcPresentableText() { }
	}

	public class IfcPressureMeasure : REAL, IfcDerivedMeasureValue
	{
		public IfcPressureMeasure() { }
	}

	public class IfcPropertySetDefinitionSet : IfcPropertySetDefinitionSelect
	{
		public List<IfcPropertySetDefinition> Value { get; set; }

		public IfcPropertySetDefinitionSet() { }
	}

	public class IfcRadioActivityMeasure : REAL, IfcDerivedMeasureValue
	{
		public IfcRadioActivityMeasure() { }
	}

	public class IfcRatioMeasure : REAL, IfcMeasureValue, IfcSizeSelect, IfcTimeOrRatioSelect
	{
		public IfcRatioMeasure() { }
	}

	public class IfcReal : REAL, IfcSimpleValue
	{
		public IfcReal() { }
	}

	public class IfcRotationalFrequencyMeasure : REAL, IfcDerivedMeasureValue
	{
		public IfcRotationalFrequencyMeasure() { }
	}

	public class IfcRotationalMassMeasure : REAL, IfcDerivedMeasureValue
	{
		public IfcRotationalMassMeasure() { }
	}

	public class IfcRotationalStiffnessMeasure : REAL, IfcDerivedMeasureValue, IfcRotationalStiffnessSelect
	{
		public IfcRotationalStiffnessMeasure() { }
	}

	public class IfcSectionModulusMeasure : REAL, IfcDerivedMeasureValue
	{
		public IfcSectionModulusMeasure() { }
	}

	public class IfcSectionalAreaIntegralMeasure : REAL, IfcDerivedMeasureValue
	{
		public IfcSectionalAreaIntegralMeasure() { }
	}

	public class IfcShearModulusMeasure : REAL, IfcDerivedMeasureValue
	{
		public IfcShearModulusMeasure() { }
	}

	public class IfcSolidAngleMeasure : REAL, IfcMeasureValue
	{
		public IfcSolidAngleMeasure() { }
	}

	public class IfcSoundPowerLevelMeasure : REAL, IfcDerivedMeasureValue
	{
		public IfcSoundPowerLevelMeasure() { }
	}

	public class IfcSoundPowerMeasure : REAL, IfcDerivedMeasureValue
	{
		public IfcSoundPowerMeasure() { }
	}

	public class IfcSoundPressureLevelMeasure : REAL, IfcDerivedMeasureValue
	{
		public IfcSoundPressureLevelMeasure() { }
	}

	public class IfcSoundPressureMeasure : REAL, IfcDerivedMeasureValue
	{
		public IfcSoundPressureMeasure() { }
	}

	public class IfcSpecificHeatCapacityMeasure : REAL, IfcDerivedMeasureValue
	{
		public IfcSpecificHeatCapacityMeasure() { }
	}

	public class IfcSpecularExponent : REAL, IfcSpecularHighlightSelect
	{
		public IfcSpecularExponent() { }
	}

	public class IfcSpecularRoughness : REAL, IfcSpecularHighlightSelect
	{
		public IfcSpecularRoughness() { }
	}

	public class IfcTemperatureGradientMeasure : REAL, IfcDerivedMeasureValue
	{
		public IfcTemperatureGradientMeasure() { }
	}

	public class IfcTemperatureRateOfChangeMeasure : REAL, IfcDerivedMeasureValue
	{
		public IfcTemperatureRateOfChangeMeasure() { }
	}

	public class IfcText : STRING, IfcSimpleValue
	{
		public IfcText() { }
	}

	public class IfcTextAlignment : STRING
	{
		public IfcTextAlignment() { }
	}

	public class IfcTextDecoration : STRING
	{
		public IfcTextDecoration() { }
	}

	public class IfcTextFontName : STRING
	{
		public IfcTextFontName() { }
	}

	public class IfcTextTransformation : STRING
	{
		public IfcTextTransformation() { }
	}

	public class IfcThermalAdmittanceMeasure : REAL, IfcDerivedMeasureValue
	{
		public IfcThermalAdmittanceMeasure() { }
	}

	public class IfcThermalConductivityMeasure : REAL, IfcDerivedMeasureValue
	{
		public IfcThermalConductivityMeasure() { }
	}

	public class IfcThermalExpansionCoefficientMeasure : REAL, IfcDerivedMeasureValue
	{
		public IfcThermalExpansionCoefficientMeasure() { }
	}

	public class IfcThermalResistanceMeasure : REAL, IfcDerivedMeasureValue
	{
		public IfcThermalResistanceMeasure() { }
	}

	public class IfcThermalTransmittanceMeasure : REAL, IfcDerivedMeasureValue
	{
		public IfcThermalTransmittanceMeasure() { }
	}

	public class IfcThermodynamicTemperatureMeasure : REAL, IfcMeasureValue
	{
		public IfcThermodynamicTemperatureMeasure() { }
	}

	public class IfcTime : STRING, IfcSimpleValue
	{
		public IfcTime() { }
	}

	public class IfcTimeMeasure : REAL, IfcMeasureValue
	{
		public IfcTimeMeasure() { }
	}

	public class IfcTimeStamp : INTEGER, IfcSimpleValue
	{
		public IfcTimeStamp() { }
	}

	public class IfcTorqueMeasure : REAL, IfcDerivedMeasureValue
	{
		public IfcTorqueMeasure() { }
	}

	public class IfcURIReference : STRING
	{
		public IfcURIReference() { }
	}

	public class IfcVaporPermeabilityMeasure : REAL, IfcDerivedMeasureValue
	{
		public IfcVaporPermeabilityMeasure() { }
	}

	public class IfcVolumeMeasure : REAL, IfcMeasureValue
	{
		public IfcVolumeMeasure() { }
	}

	public class IfcVolumetricFlowRateMeasure : REAL, IfcDerivedMeasureValue
	{
		public IfcVolumetricFlowRateMeasure() { }
	}

	public class IfcWarpingConstantMeasure : REAL, IfcDerivedMeasureValue
	{
		public IfcWarpingConstantMeasure() { }
	}

	public class IfcWarpingMomentMeasure : REAL, IfcDerivedMeasureValue, IfcWarpingStiffnessSelect
	{
		public IfcWarpingMomentMeasure() { }
	}

	public class IfcActionRequestTypeEnum
	{
		public const string EMAIL = "EMAIL";
		public const string FAX = "FAX";
		public const string PHONE = "PHONE";
		public const string POST = "POST";
		public const string VERBAL = "VERBAL";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcActionSourceTypeEnum
	{
		public const string DEAD_LOAD_G = "DEAD_LOAD_G";
		public const string COMPLETION_G1 = "COMPLETION_G1";
		public const string LIVE_LOAD_Q = "LIVE_LOAD_Q";
		public const string SNOW_S = "SNOW_S";
		public const string WIND_W = "WIND_W";
		public const string PRESTRESSING_P = "PRESTRESSING_P";
		public const string SETTLEMENT_U = "SETTLEMENT_U";
		public const string TEMPERATURE_T = "TEMPERATURE_T";
		public const string EARTHQUAKE_E = "EARTHQUAKE_E";
		public const string FIRE = "FIRE";
		public const string IMPULSE = "IMPULSE";
		public const string IMPACT = "IMPACT";
		public const string TRANSPORT = "TRANSPORT";
		public const string ERECTION = "ERECTION";
		public const string PROPPING = "PROPPING";
		public const string SYSTEM_IMPERFECTION = "SYSTEM_IMPERFECTION";
		public const string SHRINKAGE = "SHRINKAGE";
		public const string CREEP = "CREEP";
		public const string LACK_OF_FIT = "LACK_OF_FIT";
		public const string BUOYANCY = "BUOYANCY";
		public const string ICE = "ICE";
		public const string CURRENT = "CURRENT";
		public const string WAVE = "WAVE";
		public const string RAIN = "RAIN";
		public const string BRAKES = "BRAKES";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcActionTypeEnum
	{
		public const string PERMANENT_G = "PERMANENT_G";
		public const string VARIABLE_Q = "VARIABLE_Q";
		public const string EXTRAORDINARY_A = "EXTRAORDINARY_A";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcActuatorTypeEnum
	{
		public const string ELECTRICACTUATOR = "ELECTRICACTUATOR";
		public const string HANDOPERATEDACTUATOR = "HANDOPERATEDACTUATOR";
		public const string HYDRAULICACTUATOR = "HYDRAULICACTUATOR";
		public const string PNEUMATICACTUATOR = "PNEUMATICACTUATOR";
		public const string THERMOSTATICACTUATOR = "THERMOSTATICACTUATOR";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcAddressTypeEnum
	{
		public const string OFFICE = "OFFICE";
		public const string SITE = "SITE";
		public const string HOME = "HOME";
		public const string DISTRIBUTIONPOINT = "DISTRIBUTIONPOINT";
		public const string USERDEFINED = "USERDEFINED";
	}

	public class IfcAirTerminalBoxTypeEnum
	{
		public const string CONSTANTFLOW = "CONSTANTFLOW";
		public const string VARIABLEFLOWPRESSUREDEPENDANT = "VARIABLEFLOWPRESSUREDEPENDANT";
		public const string VARIABLEFLOWPRESSUREINDEPENDANT = "VARIABLEFLOWPRESSUREINDEPENDANT";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcAirTerminalTypeEnum
	{
		public const string DIFFUSER = "DIFFUSER";
		public const string GRILLE = "GRILLE";
		public const string LOUVRE = "LOUVRE";
		public const string REGISTER = "REGISTER";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcAirToAirHeatRecoveryTypeEnum
	{
		public const string FIXEDPLATECOUNTERFLOWEXCHANGER = "FIXEDPLATECOUNTERFLOWEXCHANGER";
		public const string FIXEDPLATECROSSFLOWEXCHANGER = "FIXEDPLATECROSSFLOWEXCHANGER";
		public const string FIXEDPLATEPARALLELFLOWEXCHANGER = "FIXEDPLATEPARALLELFLOWEXCHANGER";
		public const string ROTARYWHEEL = "ROTARYWHEEL";
		public const string RUNAROUNDCOILLOOP = "RUNAROUNDCOILLOOP";
		public const string HEATPIPE = "HEATPIPE";
		public const string TWINTOWERENTHALPYRECOVERYLOOPS = "TWINTOWERENTHALPYRECOVERYLOOPS";
		public const string THERMOSIPHONSEALEDTUBEHEATEXCHANGERS = "THERMOSIPHONSEALEDTUBEHEATEXCHANGERS";
		public const string THERMOSIPHONCOILTYPEHEATEXCHANGERS = "THERMOSIPHONCOILTYPEHEATEXCHANGERS";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcAlarmTypeEnum
	{
		public const string BELL = "BELL";
		public const string BREAKGLASSBUTTON = "BREAKGLASSBUTTON";
		public const string LIGHT = "LIGHT";
		public const string MANUALPULLBOX = "MANUALPULLBOX";
		public const string SIREN = "SIREN";
		public const string WHISTLE = "WHISTLE";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcAnalysisModelTypeEnum
	{
		public const string IN_PLANE_LOADING_2D = "IN_PLANE_LOADING_2D";
		public const string OUT_PLANE_LOADING_2D = "OUT_PLANE_LOADING_2D";
		public const string LOADING_3D = "LOADING_3D";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcAnalysisTheoryTypeEnum
	{
		public const string FIRST_ORDER_THEORY = "FIRST_ORDER_THEORY";
		public const string SECOND_ORDER_THEORY = "SECOND_ORDER_THEORY";
		public const string THIRD_ORDER_THEORY = "THIRD_ORDER_THEORY";
		public const string FULL_NONLINEAR_THEORY = "FULL_NONLINEAR_THEORY";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcArithmeticOperatorEnum
	{
		public const string ADD = "ADD";
		public const string DIVIDE = "DIVIDE";
		public const string MULTIPLY = "MULTIPLY";
		public const string SUBTRACT = "SUBTRACT";
	}

	public class IfcAssemblyPlaceEnum
	{
		public const string SITE = "SITE";
		public const string FACTORY = "FACTORY";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcAudioVisualApplianceTypeEnum
	{
		public const string AMPLIFIER = "AMPLIFIER";
		public const string CAMERA = "CAMERA";
		public const string DISPLAY = "DISPLAY";
		public const string MICROPHONE = "MICROPHONE";
		public const string PLAYER = "PLAYER";
		public const string PROJECTOR = "PROJECTOR";
		public const string RECEIVER = "RECEIVER";
		public const string SPEAKER = "SPEAKER";
		public const string SWITCHER = "SWITCHER";
		public const string TELEPHONE = "TELEPHONE";
		public const string TUNER = "TUNER";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcBSplineCurveForm
	{
		public const string POLYLINE_FORM = "POLYLINE_FORM";
		public const string CIRCULAR_ARC = "CIRCULAR_ARC";
		public const string ELLIPTIC_ARC = "ELLIPTIC_ARC";
		public const string PARABOLIC_ARC = "PARABOLIC_ARC";
		public const string HYPERBOLIC_ARC = "HYPERBOLIC_ARC";
		public const string UNSPECIFIED = "UNSPECIFIED";
	}

	public class IfcBSplineSurfaceForm
	{
		public const string PLANE_SURF = "PLANE_SURF";
		public const string CYLINDRICAL_SURF = "CYLINDRICAL_SURF";
		public const string CONICAL_SURF = "CONICAL_SURF";
		public const string SPHERICAL_SURF = "SPHERICAL_SURF";
		public const string TOROIDAL_SURF = "TOROIDAL_SURF";
		public const string SURF_OF_REVOLUTION = "SURF_OF_REVOLUTION";
		public const string RULED_SURF = "RULED_SURF";
		public const string GENERALISED_CONE = "GENERALISED_CONE";
		public const string QUADRIC_SURF = "QUADRIC_SURF";
		public const string SURF_OF_LINEAR_EXTRUSION = "SURF_OF_LINEAR_EXTRUSION";
		public const string UNSPECIFIED = "UNSPECIFIED";
	}

	public class IfcBeamTypeEnum
	{
		public const string BEAM = "BEAM";
		public const string JOIST = "JOIST";
		public const string HOLLOWCORE = "HOLLOWCORE";
		public const string LINTEL = "LINTEL";
		public const string SPANDREL = "SPANDREL";
		public const string T_BEAM = "T_BEAM";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcBenchmarkEnum
	{
		public const string GREATERTHAN = "GREATERTHAN";
		public const string GREATERTHANOREQUALTO = "GREATERTHANOREQUALTO";
		public const string LESSTHAN = "LESSTHAN";
		public const string LESSTHANOREQUALTO = "LESSTHANOREQUALTO";
		public const string EQUALTO = "EQUALTO";
		public const string NOTEQUALTO = "NOTEQUALTO";
		public const string INCLUDES = "INCLUDES";
		public const string NOTINCLUDES = "NOTINCLUDES";
		public const string INCLUDEDIN = "INCLUDEDIN";
		public const string NOTINCLUDEDIN = "NOTINCLUDEDIN";
	}

	public class IfcBoilerTypeEnum
	{
		public const string WATER = "WATER";
		public const string STEAM = "STEAM";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcBooleanOperator
	{
		public const string UNION = "UNION";
		public const string INTERSECTION = "INTERSECTION";
		public const string DIFFERENCE = "DIFFERENCE";
	}

	public class IfcBuildingElementPartTypeEnum
	{
		public const string INSULATION = "INSULATION";
		public const string PRECASTPANEL = "PRECASTPANEL";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcBuildingElementProxyTypeEnum
	{
		public const string COMPLEX = "COMPLEX";
		public const string ELEMENT = "ELEMENT";
		public const string PARTIAL = "PARTIAL";
		public const string PROVISIONFORVOID = "PROVISIONFORVOID";
		public const string PROVISIONFORSPACE = "PROVISIONFORSPACE";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcBuildingSystemTypeEnum
	{
		public const string FENESTRATION = "FENESTRATION";
		public const string FOUNDATION = "FOUNDATION";
		public const string LOADBEARING = "LOADBEARING";
		public const string OUTERSHELL = "OUTERSHELL";
		public const string SHADING = "SHADING";
		public const string TRANSPORT = "TRANSPORT";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcBurnerTypeEnum
	{
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcCableCarrierFittingTypeEnum
	{
		public const string BEND = "BEND";
		public const string CROSS = "CROSS";
		public const string REDUCER = "REDUCER";
		public const string TEE = "TEE";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcCableCarrierSegmentTypeEnum
	{
		public const string CABLELADDERSEGMENT = "CABLELADDERSEGMENT";
		public const string CABLETRAYSEGMENT = "CABLETRAYSEGMENT";
		public const string CABLETRUNKINGSEGMENT = "CABLETRUNKINGSEGMENT";
		public const string CONDUITSEGMENT = "CONDUITSEGMENT";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcCableFittingTypeEnum
	{
		public const string CONNECTOR = "CONNECTOR";
		public const string ENTRY = "ENTRY";
		public const string EXIT = "EXIT";
		public const string JUNCTION = "JUNCTION";
		public const string TRANSITION = "TRANSITION";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcCableSegmentTypeEnum
	{
		public const string BUSBARSEGMENT = "BUSBARSEGMENT";
		public const string CABLESEGMENT = "CABLESEGMENT";
		public const string CONDUCTORSEGMENT = "CONDUCTORSEGMENT";
		public const string CORESEGMENT = "CORESEGMENT";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcChangeActionEnum
	{
		public const string NOCHANGE = "NOCHANGE";
		public const string MODIFIED = "MODIFIED";
		public const string ADDED = "ADDED";
		public const string DELETED = "DELETED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcChillerTypeEnum
	{
		public const string AIRCOOLED = "AIRCOOLED";
		public const string WATERCOOLED = "WATERCOOLED";
		public const string HEATRECOVERY = "HEATRECOVERY";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcChimneyTypeEnum
	{
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcCoilTypeEnum
	{
		public const string DXCOOLINGCOIL = "DXCOOLINGCOIL";
		public const string ELECTRICHEATINGCOIL = "ELECTRICHEATINGCOIL";
		public const string GASHEATINGCOIL = "GASHEATINGCOIL";
		public const string HYDRONICCOIL = "HYDRONICCOIL";
		public const string STEAMHEATINGCOIL = "STEAMHEATINGCOIL";
		public const string WATERCOOLINGCOIL = "WATERCOOLINGCOIL";
		public const string WATERHEATINGCOIL = "WATERHEATINGCOIL";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcColumnTypeEnum
	{
		public const string COLUMN = "COLUMN";
		public const string PILASTER = "PILASTER";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcCommunicationsApplianceTypeEnum
	{
		public const string ANTENNA = "ANTENNA";
		public const string COMPUTER = "COMPUTER";
		public const string FAX = "FAX";
		public const string GATEWAY = "GATEWAY";
		public const string MODEM = "MODEM";
		public const string NETWORKAPPLIANCE = "NETWORKAPPLIANCE";
		public const string NETWORKBRIDGE = "NETWORKBRIDGE";
		public const string NETWORKHUB = "NETWORKHUB";
		public const string PRINTER = "PRINTER";
		public const string REPEATER = "REPEATER";
		public const string ROUTER = "ROUTER";
		public const string SCANNER = "SCANNER";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcComplexPropertyTemplateTypeEnum
	{
		public const string P_COMPLEX = "P_COMPLEX";
		public const string Q_COMPLEX = "Q_COMPLEX";
	}

	public class IfcCompressorTypeEnum
	{
		public const string DYNAMIC = "DYNAMIC";
		public const string RECIPROCATING = "RECIPROCATING";
		public const string ROTARY = "ROTARY";
		public const string SCROLL = "SCROLL";
		public const string TROCHOIDAL = "TROCHOIDAL";
		public const string SINGLESTAGE = "SINGLESTAGE";
		public const string BOOSTER = "BOOSTER";
		public const string OPENTYPE = "OPENTYPE";
		public const string HERMETIC = "HERMETIC";
		public const string SEMIHERMETIC = "SEMIHERMETIC";
		public const string WELDEDSHELLHERMETIC = "WELDEDSHELLHERMETIC";
		public const string ROLLINGPISTON = "ROLLINGPISTON";
		public const string ROTARYVANE = "ROTARYVANE";
		public const string SINGLESCREW = "SINGLESCREW";
		public const string TWINSCREW = "TWINSCREW";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcCondenserTypeEnum
	{
		public const string AIRCOOLED = "AIRCOOLED";
		public const string EVAPORATIVECOOLED = "EVAPORATIVECOOLED";
		public const string WATERCOOLED = "WATERCOOLED";
		public const string WATERCOOLEDBRAZEDPLATE = "WATERCOOLEDBRAZEDPLATE";
		public const string WATERCOOLEDSHELLCOIL = "WATERCOOLEDSHELLCOIL";
		public const string WATERCOOLEDSHELLTUBE = "WATERCOOLEDSHELLTUBE";
		public const string WATERCOOLEDTUBEINTUBE = "WATERCOOLEDTUBEINTUBE";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcConnectionTypeEnum
	{
		public const string ATPATH = "ATPATH";
		public const string ATSTART = "ATSTART";
		public const string ATEND = "ATEND";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcConstraintEnum
	{
		public const string HARD = "HARD";
		public const string SOFT = "SOFT";
		public const string ADVISORY = "ADVISORY";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcConstructionEquipmentResourceTypeEnum
	{
		public const string DEMOLISHING = "DEMOLISHING";
		public const string EARTHMOVING = "EARTHMOVING";
		public const string ERECTING = "ERECTING";
		public const string HEATING = "HEATING";
		public const string LIGHTING = "LIGHTING";
		public const string PAVING = "PAVING";
		public const string PUMPING = "PUMPING";
		public const string TRANSPORTING = "TRANSPORTING";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcConstructionMaterialResourceTypeEnum
	{
		public const string AGGREGATES = "AGGREGATES";
		public const string CONCRETE = "CONCRETE";
		public const string DRYWALL = "DRYWALL";
		public const string FUEL = "FUEL";
		public const string GYPSUM = "GYPSUM";
		public const string MASONRY = "MASONRY";
		public const string METAL = "METAL";
		public const string PLASTIC = "PLASTIC";
		public const string WOOD = "WOOD";
		public const string NOTDEFINED = "NOTDEFINED";
		public const string USERDEFINED = "USERDEFINED";
	}

	public class IfcConstructionProductResourceTypeEnum
	{
		public const string ASSEMBLY = "ASSEMBLY";
		public const string FORMWORK = "FORMWORK";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcControllerTypeEnum
	{
		public const string FLOATING = "FLOATING";
		public const string PROGRAMMABLE = "PROGRAMMABLE";
		public const string PROPORTIONAL = "PROPORTIONAL";
		public const string MULTIPOSITION = "MULTIPOSITION";
		public const string TWOPOSITION = "TWOPOSITION";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcCooledBeamTypeEnum
	{
		public const string ACTIVE = "ACTIVE";
		public const string PASSIVE = "PASSIVE";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcCoolingTowerTypeEnum
	{
		public const string NATURALDRAFT = "NATURALDRAFT";
		public const string MECHANICALINDUCEDDRAFT = "MECHANICALINDUCEDDRAFT";
		public const string MECHANICALFORCEDDRAFT = "MECHANICALFORCEDDRAFT";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcCostItemTypeEnum
	{
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcCostScheduleTypeEnum
	{
		public const string BUDGET = "BUDGET";
		public const string COSTPLAN = "COSTPLAN";
		public const string ESTIMATE = "ESTIMATE";
		public const string TENDER = "TENDER";
		public const string PRICEDBILLOFQUANTITIES = "PRICEDBILLOFQUANTITIES";
		public const string UNPRICEDBILLOFQUANTITIES = "UNPRICEDBILLOFQUANTITIES";
		public const string SCHEDULEOFRATES = "SCHEDULEOFRATES";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcCoveringTypeEnum
	{
		public const string CEILING = "CEILING";
		public const string FLOORING = "FLOORING";
		public const string CLADDING = "CLADDING";
		public const string ROOFING = "ROOFING";
		public const string MOLDING = "MOLDING";
		public const string SKIRTINGBOARD = "SKIRTINGBOARD";
		public const string INSULATION = "INSULATION";
		public const string MEMBRANE = "MEMBRANE";
		public const string SLEEVING = "SLEEVING";
		public const string WRAPPING = "WRAPPING";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcCrewResourceTypeEnum
	{
		public const string OFFICE = "OFFICE";
		public const string SITE = "SITE";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcCurtainWallTypeEnum
	{
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcCurveInterpolationEnum
	{
		public const string LINEAR = "LINEAR";
		public const string LOG_LINEAR = "LOG_LINEAR";
		public const string LOG_LOG = "LOG_LOG";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcDamperTypeEnum
	{
		public const string BACKDRAFTDAMPER = "BACKDRAFTDAMPER";
		public const string BALANCINGDAMPER = "BALANCINGDAMPER";
		public const string BLASTDAMPER = "BLASTDAMPER";
		public const string CONTROLDAMPER = "CONTROLDAMPER";
		public const string FIREDAMPER = "FIREDAMPER";
		public const string FIRESMOKEDAMPER = "FIRESMOKEDAMPER";
		public const string FUMEHOODEXHAUST = "FUMEHOODEXHAUST";
		public const string GRAVITYDAMPER = "GRAVITYDAMPER";
		public const string GRAVITYRELIEFDAMPER = "GRAVITYRELIEFDAMPER";
		public const string RELIEFDAMPER = "RELIEFDAMPER";
		public const string SMOKEDAMPER = "SMOKEDAMPER";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcDataOriginEnum
	{
		public const string MEASURED = "MEASURED";
		public const string PREDICTED = "PREDICTED";
		public const string SIMULATED = "SIMULATED";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcDerivedUnitEnum
	{
		public const string ANGULARVELOCITYUNIT = "ANGULARVELOCITYUNIT";
		public const string AREADENSITYUNIT = "AREADENSITYUNIT";
		public const string COMPOUNDPLANEANGLEUNIT = "COMPOUNDPLANEANGLEUNIT";
		public const string DYNAMICVISCOSITYUNIT = "DYNAMICVISCOSITYUNIT";
		public const string HEATFLUXDENSITYUNIT = "HEATFLUXDENSITYUNIT";
		public const string INTEGERCOUNTRATEUNIT = "INTEGERCOUNTRATEUNIT";
		public const string ISOTHERMALMOISTURECAPACITYUNIT = "ISOTHERMALMOISTURECAPACITYUNIT";
		public const string KINEMATICVISCOSITYUNIT = "KINEMATICVISCOSITYUNIT";
		public const string LINEARVELOCITYUNIT = "LINEARVELOCITYUNIT";
		public const string MASSDENSITYUNIT = "MASSDENSITYUNIT";
		public const string MASSFLOWRATEUNIT = "MASSFLOWRATEUNIT";
		public const string MOISTUREDIFFUSIVITYUNIT = "MOISTUREDIFFUSIVITYUNIT";
		public const string MOLECULARWEIGHTUNIT = "MOLECULARWEIGHTUNIT";
		public const string SPECIFICHEATCAPACITYUNIT = "SPECIFICHEATCAPACITYUNIT";
		public const string THERMALADMITTANCEUNIT = "THERMALADMITTANCEUNIT";
		public const string THERMALCONDUCTANCEUNIT = "THERMALCONDUCTANCEUNIT";
		public const string THERMALRESISTANCEUNIT = "THERMALRESISTANCEUNIT";
		public const string THERMALTRANSMITTANCEUNIT = "THERMALTRANSMITTANCEUNIT";
		public const string VAPORPERMEABILITYUNIT = "VAPORPERMEABILITYUNIT";
		public const string VOLUMETRICFLOWRATEUNIT = "VOLUMETRICFLOWRATEUNIT";
		public const string ROTATIONALFREQUENCYUNIT = "ROTATIONALFREQUENCYUNIT";
		public const string TORQUEUNIT = "TORQUEUNIT";
		public const string MOMENTOFINERTIAUNIT = "MOMENTOFINERTIAUNIT";
		public const string LINEARMOMENTUNIT = "LINEARMOMENTUNIT";
		public const string LINEARFORCEUNIT = "LINEARFORCEUNIT";
		public const string PLANARFORCEUNIT = "PLANARFORCEUNIT";
		public const string MODULUSOFELASTICITYUNIT = "MODULUSOFELASTICITYUNIT";
		public const string SHEARMODULUSUNIT = "SHEARMODULUSUNIT";
		public const string LINEARSTIFFNESSUNIT = "LINEARSTIFFNESSUNIT";
		public const string ROTATIONALSTIFFNESSUNIT = "ROTATIONALSTIFFNESSUNIT";
		public const string MODULUSOFSUBGRADEREACTIONUNIT = "MODULUSOFSUBGRADEREACTIONUNIT";
		public const string ACCELERATIONUNIT = "ACCELERATIONUNIT";
		public const string CURVATUREUNIT = "CURVATUREUNIT";
		public const string HEATINGVALUEUNIT = "HEATINGVALUEUNIT";
		public const string IONCONCENTRATIONUNIT = "IONCONCENTRATIONUNIT";
		public const string LUMINOUSINTENSITYDISTRIBUTIONUNIT = "LUMINOUSINTENSITYDISTRIBUTIONUNIT";
		public const string MASSPERLENGTHUNIT = "MASSPERLENGTHUNIT";
		public const string MODULUSOFLINEARSUBGRADEREACTIONUNIT = "MODULUSOFLINEARSUBGRADEREACTIONUNIT";
		public const string MODULUSOFROTATIONALSUBGRADEREACTIONUNIT = "MODULUSOFROTATIONALSUBGRADEREACTIONUNIT";
		public const string PHUNIT = "PHUNIT";
		public const string ROTATIONALMASSUNIT = "ROTATIONALMASSUNIT";
		public const string SECTIONAREAINTEGRALUNIT = "SECTIONAREAINTEGRALUNIT";
		public const string SECTIONMODULUSUNIT = "SECTIONMODULUSUNIT";
		public const string SOUNDPOWERLEVELUNIT = "SOUNDPOWERLEVELUNIT";
		public const string SOUNDPOWERUNIT = "SOUNDPOWERUNIT";
		public const string SOUNDPRESSURELEVELUNIT = "SOUNDPRESSURELEVELUNIT";
		public const string SOUNDPRESSUREUNIT = "SOUNDPRESSUREUNIT";
		public const string TEMPERATUREGRADIENTUNIT = "TEMPERATUREGRADIENTUNIT";
		public const string TEMPERATURERATEOFCHANGEUNIT = "TEMPERATURERATEOFCHANGEUNIT";
		public const string THERMALEXPANSIONCOEFFICIENTUNIT = "THERMALEXPANSIONCOEFFICIENTUNIT";
		public const string WARPINGCONSTANTUNIT = "WARPINGCONSTANTUNIT";
		public const string WARPINGMOMENTUNIT = "WARPINGMOMENTUNIT";
		public const string USERDEFINED = "USERDEFINED";
	}

	public class IfcDirectionSenseEnum
	{
		public const string POSITIVE = "POSITIVE";
		public const string NEGATIVE = "NEGATIVE";
	}

	public class IfcDiscreteAccessoryTypeEnum
	{
		public const string ANCHORPLATE = "ANCHORPLATE";
		public const string BRACKET = "BRACKET";
		public const string SHOE = "SHOE";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcDistributionChamberElementTypeEnum
	{
		public const string FORMEDDUCT = "FORMEDDUCT";
		public const string INSPECTIONCHAMBER = "INSPECTIONCHAMBER";
		public const string INSPECTIONPIT = "INSPECTIONPIT";
		public const string MANHOLE = "MANHOLE";
		public const string METERCHAMBER = "METERCHAMBER";
		public const string SUMP = "SUMP";
		public const string TRENCH = "TRENCH";
		public const string VALVECHAMBER = "VALVECHAMBER";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcDistributionPortTypeEnum
	{
		public const string CABLE = "CABLE";
		public const string CABLECARRIER = "CABLECARRIER";
		public const string DUCT = "DUCT";
		public const string PIPE = "PIPE";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcDistributionSystemEnum
	{
		public const string AIRCONDITIONING = "AIRCONDITIONING";
		public const string AUDIOVISUAL = "AUDIOVISUAL";
		public const string CHEMICAL = "CHEMICAL";
		public const string CHILLEDWATER = "CHILLEDWATER";
		public const string COMMUNICATION = "COMMUNICATION";
		public const string COMPRESSEDAIR = "COMPRESSEDAIR";
		public const string CONDENSERWATER = "CONDENSERWATER";
		public const string CONTROL = "CONTROL";
		public const string CONVEYING = "CONVEYING";
		public const string DATA = "DATA";
		public const string DISPOSAL = "DISPOSAL";
		public const string DOMESTICCOLDWATER = "DOMESTICCOLDWATER";
		public const string DOMESTICHOTWATER = "DOMESTICHOTWATER";
		public const string DRAINAGE = "DRAINAGE";
		public const string EARTHING = "EARTHING";
		public const string ELECTRICAL = "ELECTRICAL";
		public const string ELECTROACOUSTIC = "ELECTROACOUSTIC";
		public const string EXHAUST = "EXHAUST";
		public const string FIREPROTECTION = "FIREPROTECTION";
		public const string FUEL = "FUEL";
		public const string GAS = "GAS";
		public const string HAZARDOUS = "HAZARDOUS";
		public const string HEATING = "HEATING";
		public const string LIGHTING = "LIGHTING";
		public const string LIGHTNINGPROTECTION = "LIGHTNINGPROTECTION";
		public const string MUNICIPALSOLIDWASTE = "MUNICIPALSOLIDWASTE";
		public const string OIL = "OIL";
		public const string OPERATIONAL = "OPERATIONAL";
		public const string POWERGENERATION = "POWERGENERATION";
		public const string RAINWATER = "RAINWATER";
		public const string REFRIGERATION = "REFRIGERATION";
		public const string SECURITY = "SECURITY";
		public const string SEWAGE = "SEWAGE";
		public const string SIGNAL = "SIGNAL";
		public const string STORMWATER = "STORMWATER";
		public const string TELEPHONE = "TELEPHONE";
		public const string TV = "TV";
		public const string VACUUM = "VACUUM";
		public const string VENT = "VENT";
		public const string VENTILATION = "VENTILATION";
		public const string WASTEWATER = "WASTEWATER";
		public const string WATERSUPPLY = "WATERSUPPLY";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcDocumentConfidentialityEnum
	{
		public const string PUBLIC = "PUBLIC";
		public const string RESTRICTED = "RESTRICTED";
		public const string CONFIDENTIAL = "CONFIDENTIAL";
		public const string PERSONAL = "PERSONAL";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcDocumentStatusEnum
	{
		public const string DRAFT = "DRAFT";
		public const string FINALDRAFT = "FINALDRAFT";
		public const string FINAL = "FINAL";
		public const string REVISION = "REVISION";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcDoorPanelOperationEnum
	{
		public const string SWINGING = "SWINGING";
		public const string DOUBLE_ACTING = "DOUBLE_ACTING";
		public const string SLIDING = "SLIDING";
		public const string FOLDING = "FOLDING";
		public const string REVOLVING = "REVOLVING";
		public const string ROLLINGUP = "ROLLINGUP";
		public const string FIXEDPANEL = "FIXEDPANEL";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcDoorPanelPositionEnum
	{
		public const string LEFT = "LEFT";
		public const string MIDDLE = "MIDDLE";
		public const string RIGHT = "RIGHT";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcDoorStyleConstructionEnum
	{
		public const string ALUMINIUM = "ALUMINIUM";
		public const string HIGH_GRADE_STEEL = "HIGH_GRADE_STEEL";
		public const string STEEL = "STEEL";
		public const string WOOD = "WOOD";
		public const string ALUMINIUM_WOOD = "ALUMINIUM_WOOD";
		public const string ALUMINIUM_PLASTIC = "ALUMINIUM_PLASTIC";
		public const string PLASTIC = "PLASTIC";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcDoorStyleOperationEnum
	{
		public const string SINGLE_SWING_LEFT = "SINGLE_SWING_LEFT";
		public const string SINGLE_SWING_RIGHT = "SINGLE_SWING_RIGHT";
		public const string DOUBLE_DOOR_SINGLE_SWING = "DOUBLE_DOOR_SINGLE_SWING";
		public const string DOUBLE_DOOR_SINGLE_SWING_OPPOSITE_LEFT = "DOUBLE_DOOR_SINGLE_SWING_OPPOSITE_LEFT";
		public const string DOUBLE_DOOR_SINGLE_SWING_OPPOSITE_RIGHT = "DOUBLE_DOOR_SINGLE_SWING_OPPOSITE_RIGHT";
		public const string DOUBLE_SWING_LEFT = "DOUBLE_SWING_LEFT";
		public const string DOUBLE_SWING_RIGHT = "DOUBLE_SWING_RIGHT";
		public const string DOUBLE_DOOR_DOUBLE_SWING = "DOUBLE_DOOR_DOUBLE_SWING";
		public const string SLIDING_TO_LEFT = "SLIDING_TO_LEFT";
		public const string SLIDING_TO_RIGHT = "SLIDING_TO_RIGHT";
		public const string DOUBLE_DOOR_SLIDING = "DOUBLE_DOOR_SLIDING";
		public const string FOLDING_TO_LEFT = "FOLDING_TO_LEFT";
		public const string FOLDING_TO_RIGHT = "FOLDING_TO_RIGHT";
		public const string DOUBLE_DOOR_FOLDING = "DOUBLE_DOOR_FOLDING";
		public const string REVOLVING = "REVOLVING";
		public const string ROLLINGUP = "ROLLINGUP";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcDoorTypeEnum
	{
		public const string DOOR = "DOOR";
		public const string GATE = "GATE";
		public const string TRAPDOOR = "TRAPDOOR";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcDoorTypeOperationEnum
	{
		public const string SINGLE_SWING_LEFT = "SINGLE_SWING_LEFT";
		public const string SINGLE_SWING_RIGHT = "SINGLE_SWING_RIGHT";
		public const string DOUBLE_DOOR_SINGLE_SWING = "DOUBLE_DOOR_SINGLE_SWING";
		public const string DOUBLE_DOOR_SINGLE_SWING_OPPOSITE_LEFT = "DOUBLE_DOOR_SINGLE_SWING_OPPOSITE_LEFT";
		public const string DOUBLE_DOOR_SINGLE_SWING_OPPOSITE_RIGHT = "DOUBLE_DOOR_SINGLE_SWING_OPPOSITE_RIGHT";
		public const string DOUBLE_SWING_LEFT = "DOUBLE_SWING_LEFT";
		public const string DOUBLE_SWING_RIGHT = "DOUBLE_SWING_RIGHT";
		public const string DOUBLE_DOOR_DOUBLE_SWING = "DOUBLE_DOOR_DOUBLE_SWING";
		public const string SLIDING_TO_LEFT = "SLIDING_TO_LEFT";
		public const string SLIDING_TO_RIGHT = "SLIDING_TO_RIGHT";
		public const string DOUBLE_DOOR_SLIDING = "DOUBLE_DOOR_SLIDING";
		public const string FOLDING_TO_LEFT = "FOLDING_TO_LEFT";
		public const string FOLDING_TO_RIGHT = "FOLDING_TO_RIGHT";
		public const string DOUBLE_DOOR_FOLDING = "DOUBLE_DOOR_FOLDING";
		public const string REVOLVING = "REVOLVING";
		public const string ROLLINGUP = "ROLLINGUP";
		public const string SWING_FIXED_LEFT = "SWING_FIXED_LEFT";
		public const string SWING_FIXED_RIGHT = "SWING_FIXED_RIGHT";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcDuctFittingTypeEnum
	{
		public const string BEND = "BEND";
		public const string CONNECTOR = "CONNECTOR";
		public const string ENTRY = "ENTRY";
		public const string EXIT = "EXIT";
		public const string JUNCTION = "JUNCTION";
		public const string OBSTRUCTION = "OBSTRUCTION";
		public const string TRANSITION = "TRANSITION";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcDuctSegmentTypeEnum
	{
		public const string RIGIDSEGMENT = "RIGIDSEGMENT";
		public const string FLEXIBLESEGMENT = "FLEXIBLESEGMENT";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcDuctSilencerTypeEnum
	{
		public const string FLATOVAL = "FLATOVAL";
		public const string RECTANGULAR = "RECTANGULAR";
		public const string ROUND = "ROUND";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcElectricApplianceTypeEnum
	{
		public const string DISHWASHER = "DISHWASHER";
		public const string ELECTRICCOOKER = "ELECTRICCOOKER";
		public const string FREESTANDINGELECTRICHEATER = "FREESTANDINGELECTRICHEATER";
		public const string FREESTANDINGFAN = "FREESTANDINGFAN";
		public const string FREESTANDINGWATERHEATER = "FREESTANDINGWATERHEATER";
		public const string FREESTANDINGWATERCOOLER = "FREESTANDINGWATERCOOLER";
		public const string FREEZER = "FREEZER";
		public const string FRIDGE_FREEZER = "FRIDGE_FREEZER";
		public const string HANDDRYER = "HANDDRYER";
		public const string KITCHENMACHINE = "KITCHENMACHINE";
		public const string MICROWAVE = "MICROWAVE";
		public const string PHOTOCOPIER = "PHOTOCOPIER";
		public const string REFRIGERATOR = "REFRIGERATOR";
		public const string TUMBLEDRYER = "TUMBLEDRYER";
		public const string VENDINGMACHINE = "VENDINGMACHINE";
		public const string WASHINGMACHINE = "WASHINGMACHINE";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcElectricDistributionBoardTypeEnum
	{
		public const string CONSUMERUNIT = "CONSUMERUNIT";
		public const string DISTRIBUTIONBOARD = "DISTRIBUTIONBOARD";
		public const string MOTORCONTROLCENTRE = "MOTORCONTROLCENTRE";
		public const string SWITCHBOARD = "SWITCHBOARD";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcElectricFlowStorageDeviceTypeEnum
	{
		public const string BATTERY = "BATTERY";
		public const string CAPACITORBANK = "CAPACITORBANK";
		public const string HARMONICFILTER = "HARMONICFILTER";
		public const string INDUCTORBANK = "INDUCTORBANK";
		public const string UPS = "UPS";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcElectricGeneratorTypeEnum
	{
		public const string CHP = "CHP";
		public const string ENGINEGENERATOR = "ENGINEGENERATOR";
		public const string STANDALONE = "STANDALONE";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcElectricMotorTypeEnum
	{
		public const string DC = "DC";
		public const string INDUCTION = "INDUCTION";
		public const string POLYPHASE = "POLYPHASE";
		public const string RELUCTANCESYNCHRONOUS = "RELUCTANCESYNCHRONOUS";
		public const string SYNCHRONOUS = "SYNCHRONOUS";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcElectricTimeControlTypeEnum
	{
		public const string TIMECLOCK = "TIMECLOCK";
		public const string TIMEDELAY = "TIMEDELAY";
		public const string RELAY = "RELAY";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcElementAssemblyTypeEnum
	{
		public const string ACCESSORY_ASSEMBLY = "ACCESSORY_ASSEMBLY";
		public const string ARCH = "ARCH";
		public const string BEAM_GRID = "BEAM_GRID";
		public const string BRACED_FRAME = "BRACED_FRAME";
		public const string GIRDER = "GIRDER";
		public const string REINFORCEMENT_UNIT = "REINFORCEMENT_UNIT";
		public const string RIGID_FRAME = "RIGID_FRAME";
		public const string SLAB_FIELD = "SLAB_FIELD";
		public const string TRUSS = "TRUSS";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcElementCompositionEnum
	{
		public const string COMPLEX = "COMPLEX";
		public const string ELEMENT = "ELEMENT";
		public const string PARTIAL = "PARTIAL";
	}

	public class IfcEngineTypeEnum
	{
		public const string EXTERNALCOMBUSTION = "EXTERNALCOMBUSTION";
		public const string INTERNALCOMBUSTION = "INTERNALCOMBUSTION";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcEvaporativeCoolerTypeEnum
	{
		public const string DIRECTEVAPORATIVERANDOMMEDIAAIRCOOLER = "DIRECTEVAPORATIVERANDOMMEDIAAIRCOOLER";
		public const string DIRECTEVAPORATIVERIGIDMEDIAAIRCOOLER = "DIRECTEVAPORATIVERIGIDMEDIAAIRCOOLER";
		public const string DIRECTEVAPORATIVESLINGERSPACKAGEDAIRCOOLER = "DIRECTEVAPORATIVESLINGERSPACKAGEDAIRCOOLER";
		public const string DIRECTEVAPORATIVEPACKAGEDROTARYAIRCOOLER = "DIRECTEVAPORATIVEPACKAGEDROTARYAIRCOOLER";
		public const string DIRECTEVAPORATIVEAIRWASHER = "DIRECTEVAPORATIVEAIRWASHER";
		public const string INDIRECTEVAPORATIVEPACKAGEAIRCOOLER = "INDIRECTEVAPORATIVEPACKAGEAIRCOOLER";
		public const string INDIRECTEVAPORATIVEWETCOIL = "INDIRECTEVAPORATIVEWETCOIL";
		public const string INDIRECTEVAPORATIVECOOLINGTOWERORCOILCOOLER = "INDIRECTEVAPORATIVECOOLINGTOWERORCOILCOOLER";
		public const string INDIRECTDIRECTCOMBINATION = "INDIRECTDIRECTCOMBINATION";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcEvaporatorTypeEnum
	{
		public const string DIRECTEXPANSION = "DIRECTEXPANSION";
		public const string DIRECTEXPANSIONSHELLANDTUBE = "DIRECTEXPANSIONSHELLANDTUBE";
		public const string DIRECTEXPANSIONTUBEINTUBE = "DIRECTEXPANSIONTUBEINTUBE";
		public const string DIRECTEXPANSIONBRAZEDPLATE = "DIRECTEXPANSIONBRAZEDPLATE";
		public const string FLOODEDSHELLANDTUBE = "FLOODEDSHELLANDTUBE";
		public const string SHELLANDCOIL = "SHELLANDCOIL";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcEventTriggerTypeEnum
	{
		public const string EVENTRULE = "EVENTRULE";
		public const string EVENTMESSAGE = "EVENTMESSAGE";
		public const string EVENTTIME = "EVENTTIME";
		public const string EVENTCOMPLEX = "EVENTCOMPLEX";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcEventTypeEnum
	{
		public const string STARTEVENT = "STARTEVENT";
		public const string ENDEVENT = "ENDEVENT";
		public const string INTERMEDIATEEVENT = "INTERMEDIATEEVENT";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcExternalSpatialElementTypeEnum
	{
		public const string EXTERNAL = "EXTERNAL";
		public const string EXTERNAL_EARTH = "EXTERNAL_EARTH";
		public const string EXTERNAL_WATER = "EXTERNAL_WATER";
		public const string EXTERNAL_FIRE = "EXTERNAL_FIRE";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcFanTypeEnum
	{
		public const string CENTRIFUGALFORWARDCURVED = "CENTRIFUGALFORWARDCURVED";
		public const string CENTRIFUGALRADIAL = "CENTRIFUGALRADIAL";
		public const string CENTRIFUGALBACKWARDINCLINEDCURVED = "CENTRIFUGALBACKWARDINCLINEDCURVED";
		public const string CENTRIFUGALAIRFOIL = "CENTRIFUGALAIRFOIL";
		public const string TUBEAXIAL = "TUBEAXIAL";
		public const string VANEAXIAL = "VANEAXIAL";
		public const string PROPELLORAXIAL = "PROPELLORAXIAL";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcFastenerTypeEnum
	{
		public const string GLUE = "GLUE";
		public const string MORTAR = "MORTAR";
		public const string WELD = "WELD";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcFilterTypeEnum
	{
		public const string AIRPARTICLEFILTER = "AIRPARTICLEFILTER";
		public const string COMPRESSEDAIRFILTER = "COMPRESSEDAIRFILTER";
		public const string ODORFILTER = "ODORFILTER";
		public const string OILFILTER = "OILFILTER";
		public const string STRAINER = "STRAINER";
		public const string WATERFILTER = "WATERFILTER";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcFireSuppressionTerminalTypeEnum
	{
		public const string BREECHINGINLET = "BREECHINGINLET";
		public const string FIREHYDRANT = "FIREHYDRANT";
		public const string HOSEREEL = "HOSEREEL";
		public const string SPRINKLER = "SPRINKLER";
		public const string SPRINKLERDEFLECTOR = "SPRINKLERDEFLECTOR";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcFlowDirectionEnum
	{
		public const string SOURCE = "SOURCE";
		public const string SINK = "SINK";
		public const string SOURCEANDSINK = "SOURCEANDSINK";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcFlowInstrumentTypeEnum
	{
		public const string PRESSUREGAUGE = "PRESSUREGAUGE";
		public const string THERMOMETER = "THERMOMETER";
		public const string AMMETER = "AMMETER";
		public const string FREQUENCYMETER = "FREQUENCYMETER";
		public const string POWERFACTORMETER = "POWERFACTORMETER";
		public const string PHASEANGLEMETER = "PHASEANGLEMETER";
		public const string VOLTMETER_PEAK = "VOLTMETER_PEAK";
		public const string VOLTMETER_RMS = "VOLTMETER_RMS";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcFlowMeterTypeEnum
	{
		public const string ENERGYMETER = "ENERGYMETER";
		public const string GASMETER = "GASMETER";
		public const string OILMETER = "OILMETER";
		public const string WATERMETER = "WATERMETER";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcFootingTypeEnum
	{
		public const string CAISSON_FOUNDATION = "CAISSON_FOUNDATION";
		public const string FOOTING_BEAM = "FOOTING_BEAM";
		public const string PAD_FOOTING = "PAD_FOOTING";
		public const string PILE_CAP = "PILE_CAP";
		public const string STRIP_FOOTING = "STRIP_FOOTING";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcFurnitureTypeEnum
	{
		public const string CHAIR = "CHAIR";
		public const string TABLE = "TABLE";
		public const string DESK = "DESK";
		public const string BED = "BED";
		public const string FILECABINET = "FILECABINET";
		public const string SHELF = "SHELF";
		public const string SOFA = "SOFA";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcGeographicElementTypeEnum
	{
		public const string TERRAIN = "TERRAIN";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcGeometricProjectionEnum
	{
		public const string GRAPH_VIEW = "GRAPH_VIEW";
		public const string SKETCH_VIEW = "SKETCH_VIEW";
		public const string MODEL_VIEW = "MODEL_VIEW";
		public const string PLAN_VIEW = "PLAN_VIEW";
		public const string REFLECTED_PLAN_VIEW = "REFLECTED_PLAN_VIEW";
		public const string SECTION_VIEW = "SECTION_VIEW";
		public const string ELEVATION_VIEW = "ELEVATION_VIEW";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcGlobalOrLocalEnum
	{
		public const string GLOBAL_COORDS = "GLOBAL_COORDS";
		public const string LOCAL_COORDS = "LOCAL_COORDS";
	}

	public class IfcGridTypeEnum
	{
		public const string RECTANGULAR = "RECTANGULAR";
		public const string RADIAL = "RADIAL";
		public const string TRIANGULAR = "TRIANGULAR";
		public const string IRREGULAR = "IRREGULAR";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcHeatExchangerTypeEnum
	{
		public const string PLATE = "PLATE";
		public const string SHELLANDTUBE = "SHELLANDTUBE";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcHumidifierTypeEnum
	{
		public const string STEAMINJECTION = "STEAMINJECTION";
		public const string ADIABATICAIRWASHER = "ADIABATICAIRWASHER";
		public const string ADIABATICPAN = "ADIABATICPAN";
		public const string ADIABATICWETTEDELEMENT = "ADIABATICWETTEDELEMENT";
		public const string ADIABATICATOMIZING = "ADIABATICATOMIZING";
		public const string ADIABATICULTRASONIC = "ADIABATICULTRASONIC";
		public const string ADIABATICRIGIDMEDIA = "ADIABATICRIGIDMEDIA";
		public const string ADIABATICCOMPRESSEDAIRNOZZLE = "ADIABATICCOMPRESSEDAIRNOZZLE";
		public const string ASSISTEDELECTRIC = "ASSISTEDELECTRIC";
		public const string ASSISTEDNATURALGAS = "ASSISTEDNATURALGAS";
		public const string ASSISTEDPROPANE = "ASSISTEDPROPANE";
		public const string ASSISTEDBUTANE = "ASSISTEDBUTANE";
		public const string ASSISTEDSTEAM = "ASSISTEDSTEAM";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcInterceptorTypeEnum
	{
		public const string CYCLONIC = "CYCLONIC";
		public const string GREASE = "GREASE";
		public const string OIL = "OIL";
		public const string PETROL = "PETROL";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcInternalOrExternalEnum
	{
		public const string INTERNAL = "INTERNAL";
		public const string EXTERNAL = "EXTERNAL";
		public const string EXTERNAL_EARTH = "EXTERNAL_EARTH";
		public const string EXTERNAL_WATER = "EXTERNAL_WATER";
		public const string EXTERNAL_FIRE = "EXTERNAL_FIRE";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcInventoryTypeEnum
	{
		public const string ASSETINVENTORY = "ASSETINVENTORY";
		public const string SPACEINVENTORY = "SPACEINVENTORY";
		public const string FURNITUREINVENTORY = "FURNITUREINVENTORY";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcJunctionBoxTypeEnum
	{
		public const string DATA = "DATA";
		public const string POWER = "POWER";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcKnotType
	{
		public const string UNIFORM_KNOTS = "UNIFORM_KNOTS";
		public const string QUASI_UNIFORM_KNOTS = "QUASI_UNIFORM_KNOTS";
		public const string PIECEWISE_BEZIER_KNOTS = "PIECEWISE_BEZIER_KNOTS";
		public const string UNSPECIFIED = "UNSPECIFIED";
	}

	public class IfcLaborResourceTypeEnum
	{
		public const string ADMINISTRATION = "ADMINISTRATION";
		public const string CARPENTRY = "CARPENTRY";
		public const string CLEANING = "CLEANING";
		public const string CONCRETE = "CONCRETE";
		public const string DRYWALL = "DRYWALL";
		public const string ELECTRIC = "ELECTRIC";
		public const string FINISHING = "FINISHING";
		public const string FLOORING = "FLOORING";
		public const string GENERAL = "GENERAL";
		public const string HVAC = "HVAC";
		public const string LANDSCAPING = "LANDSCAPING";
		public const string MASONRY = "MASONRY";
		public const string PAINTING = "PAINTING";
		public const string PAVING = "PAVING";
		public const string PLUMBING = "PLUMBING";
		public const string ROOFING = "ROOFING";
		public const string SITEGRADING = "SITEGRADING";
		public const string STEELWORK = "STEELWORK";
		public const string SURVEYING = "SURVEYING";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcLampTypeEnum
	{
		public const string COMPACTFLUORESCENT = "COMPACTFLUORESCENT";
		public const string FLUORESCENT = "FLUORESCENT";
		public const string HALOGEN = "HALOGEN";
		public const string HIGHPRESSUREMERCURY = "HIGHPRESSUREMERCURY";
		public const string HIGHPRESSURESODIUM = "HIGHPRESSURESODIUM";
		public const string LED = "LED";
		public const string METALHALIDE = "METALHALIDE";
		public const string OLED = "OLED";
		public const string TUNGSTENFILAMENT = "TUNGSTENFILAMENT";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcLayerSetDirectionEnum
	{
		public const string AXIS1 = "AXIS1";
		public const string AXIS2 = "AXIS2";
		public const string AXIS3 = "AXIS3";
	}

	public class IfcLightDistributionCurveEnum
	{
		public const string TYPE_A = "TYPE_A";
		public const string TYPE_B = "TYPE_B";
		public const string TYPE_C = "TYPE_C";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcLightEmissionSourceEnum
	{
		public const string COMPACTFLUORESCENT = "COMPACTFLUORESCENT";
		public const string FLUORESCENT = "FLUORESCENT";
		public const string HIGHPRESSUREMERCURY = "HIGHPRESSUREMERCURY";
		public const string HIGHPRESSURESODIUM = "HIGHPRESSURESODIUM";
		public const string LIGHTEMITTINGDIODE = "LIGHTEMITTINGDIODE";
		public const string LOWPRESSURESODIUM = "LOWPRESSURESODIUM";
		public const string LOWVOLTAGEHALOGEN = "LOWVOLTAGEHALOGEN";
		public const string MAINVOLTAGEHALOGEN = "MAINVOLTAGEHALOGEN";
		public const string METALHALIDE = "METALHALIDE";
		public const string TUNGSTENFILAMENT = "TUNGSTENFILAMENT";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcLightFixtureTypeEnum
	{
		public const string POINTSOURCE = "POINTSOURCE";
		public const string DIRECTIONSOURCE = "DIRECTIONSOURCE";
		public const string SECURITYLIGHTING = "SECURITYLIGHTING";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcLoadGroupTypeEnum
	{
		public const string LOAD_GROUP = "LOAD_GROUP";
		public const string LOAD_CASE = "LOAD_CASE";
		public const string LOAD_COMBINATION = "LOAD_COMBINATION";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcLogicalOperatorEnum
	{
		public const string LOGICALAND = "LOGICALAND";
		public const string LOGICALOR = "LOGICALOR";
		public const string LOGICALXOR = "LOGICALXOR";
		public const string LOGICALNOTAND = "LOGICALNOTAND";
		public const string LOGICALNOTOR = "LOGICALNOTOR";
	}

	public class IfcMechanicalFastenerTypeEnum
	{
		public const string ANCHORBOLT = "ANCHORBOLT";
		public const string BOLT = "BOLT";
		public const string DOWEL = "DOWEL";
		public const string NAIL = "NAIL";
		public const string NAILPLATE = "NAILPLATE";
		public const string RIVET = "RIVET";
		public const string SCREW = "SCREW";
		public const string SHEARCONNECTOR = "SHEARCONNECTOR";
		public const string STAPLE = "STAPLE";
		public const string STUDSHEARCONNECTOR = "STUDSHEARCONNECTOR";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcMedicalDeviceTypeEnum
	{
		public const string AIRSTATION = "AIRSTATION";
		public const string FEEDAIRUNIT = "FEEDAIRUNIT";
		public const string OXYGENGENERATOR = "OXYGENGENERATOR";
		public const string OXYGENPLANT = "OXYGENPLANT";
		public const string VACUUMSTATION = "VACUUMSTATION";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcMemberTypeEnum
	{
		public const string BRACE = "BRACE";
		public const string CHORD = "CHORD";
		public const string COLLAR = "COLLAR";
		public const string MEMBER = "MEMBER";
		public const string MULLION = "MULLION";
		public const string PLATE = "PLATE";
		public const string POST = "POST";
		public const string PURLIN = "PURLIN";
		public const string RAFTER = "RAFTER";
		public const string STRINGER = "STRINGER";
		public const string STRUT = "STRUT";
		public const string STUD = "STUD";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcMotorConnectionTypeEnum
	{
		public const string BELTDRIVE = "BELTDRIVE";
		public const string COUPLING = "COUPLING";
		public const string DIRECTDRIVE = "DIRECTDRIVE";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcNullStyle : IfcPresentationStyleSelect
	{
		public const string NULL = "NULL";
	}

	public class IfcObjectTypeEnum
	{
		public const string PRODUCT = "PRODUCT";
		public const string PROCESS = "PROCESS";
		public const string CONTROL = "CONTROL";
		public const string RESOURCE = "RESOURCE";
		public const string ACTOR = "ACTOR";
		public const string GROUP = "GROUP";
		public const string PROJECT = "PROJECT";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcObjectiveEnum
	{
		public const string CODECOMPLIANCE = "CODECOMPLIANCE";
		public const string CODEWAIVER = "CODEWAIVER";
		public const string DESIGNINTENT = "DESIGNINTENT";
		public const string EXTERNAL = "EXTERNAL";
		public const string HEALTHANDSAFETY = "HEALTHANDSAFETY";
		public const string MERGECONFLICT = "MERGECONFLICT";
		public const string MODELVIEW = "MODELVIEW";
		public const string PARAMETER = "PARAMETER";
		public const string REQUIREMENT = "REQUIREMENT";
		public const string SPECIFICATION = "SPECIFICATION";
		public const string TRIGGERCONDITION = "TRIGGERCONDITION";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcOccupantTypeEnum
	{
		public const string ASSIGNEE = "ASSIGNEE";
		public const string ASSIGNOR = "ASSIGNOR";
		public const string LESSEE = "LESSEE";
		public const string LESSOR = "LESSOR";
		public const string LETTINGAGENT = "LETTINGAGENT";
		public const string OWNER = "OWNER";
		public const string TENANT = "TENANT";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcOpeningElementTypeEnum
	{
		public const string OPENING = "OPENING";
		public const string RECESS = "RECESS";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcOutletTypeEnum
	{
		public const string AUDIOVISUALOUTLET = "AUDIOVISUALOUTLET";
		public const string COMMUNICATIONSOUTLET = "COMMUNICATIONSOUTLET";
		public const string POWEROUTLET = "POWEROUTLET";
		public const string DATAOUTLET = "DATAOUTLET";
		public const string TELEPHONEOUTLET = "TELEPHONEOUTLET";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcPerformanceHistoryTypeEnum
	{
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcPermeableCoveringOperationEnum
	{
		public const string GRILL = "GRILL";
		public const string LOUVER = "LOUVER";
		public const string SCREEN = "SCREEN";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcPermitTypeEnum
	{
		public const string ACCESS = "ACCESS";
		public const string BUILDING = "BUILDING";
		public const string WORK = "WORK";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcPhysicalOrVirtualEnum
	{
		public const string PHYSICAL = "PHYSICAL";
		public const string VIRTUAL = "VIRTUAL";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcPileConstructionEnum
	{
		public const string CAST_IN_PLACE = "CAST_IN_PLACE";
		public const string COMPOSITE = "COMPOSITE";
		public const string PRECAST_CONCRETE = "PRECAST_CONCRETE";
		public const string PREFAB_STEEL = "PREFAB_STEEL";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcPileTypeEnum
	{
		public const string BORED = "BORED";
		public const string DRIVEN = "DRIVEN";
		public const string JETGROUTING = "JETGROUTING";
		public const string COHESION = "COHESION";
		public const string FRICTION = "FRICTION";
		public const string SUPPORT = "SUPPORT";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcPipeFittingTypeEnum
	{
		public const string BEND = "BEND";
		public const string CONNECTOR = "CONNECTOR";
		public const string ENTRY = "ENTRY";
		public const string EXIT = "EXIT";
		public const string JUNCTION = "JUNCTION";
		public const string OBSTRUCTION = "OBSTRUCTION";
		public const string TRANSITION = "TRANSITION";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcPipeSegmentTypeEnum
	{
		public const string CULVERT = "CULVERT";
		public const string FLEXIBLESEGMENT = "FLEXIBLESEGMENT";
		public const string RIGIDSEGMENT = "RIGIDSEGMENT";
		public const string GUTTER = "GUTTER";
		public const string SPOOL = "SPOOL";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcPlateTypeEnum
	{
		public const string CURTAIN_PANEL = "CURTAIN_PANEL";
		public const string SHEET = "SHEET";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcPreferredSurfaceCurveRepresentation
	{
		public const string CURVE3D = "CURVE3D";
		public const string PCURVE_S1 = "PCURVE_S1";
		public const string PCURVE_S2 = "PCURVE_S2";
	}

	public class IfcProcedureTypeEnum
	{
		public const string ADVICE_CAUTION = "ADVICE_CAUTION";
		public const string ADVICE_NOTE = "ADVICE_NOTE";
		public const string ADVICE_WARNING = "ADVICE_WARNING";
		public const string CALIBRATION = "CALIBRATION";
		public const string DIAGNOSTIC = "DIAGNOSTIC";
		public const string SHUTDOWN = "SHUTDOWN";
		public const string STARTUP = "STARTUP";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcProfileTypeEnum
	{
		public const string CURVE = "CURVE";
		public const string AREA = "AREA";
	}

	public class IfcProjectOrderTypeEnum
	{
		public const string CHANGEORDER = "CHANGEORDER";
		public const string MAINTENANCEWORKORDER = "MAINTENANCEWORKORDER";
		public const string MOVEORDER = "MOVEORDER";
		public const string PURCHASEORDER = "PURCHASEORDER";
		public const string WORKORDER = "WORKORDER";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcProjectedOrTrueLengthEnum
	{
		public const string PROJECTED_LENGTH = "PROJECTED_LENGTH";
		public const string TRUE_LENGTH = "TRUE_LENGTH";
	}

	public class IfcProjectionElementTypeEnum
	{
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcPropertySetTemplateTypeEnum
	{
		public const string PSET_TYPEDRIVENONLY = "PSET_TYPEDRIVENONLY";
		public const string PSET_TYPEDRIVENOVERRIDE = "PSET_TYPEDRIVENOVERRIDE";
		public const string PSET_OCCURRENCEDRIVEN = "PSET_OCCURRENCEDRIVEN";
		public const string PSET_PERFORMANCEDRIVEN = "PSET_PERFORMANCEDRIVEN";
		public const string QTO_TYPEDRIVENONLY = "QTO_TYPEDRIVENONLY";
		public const string QTO_TYPEDRIVENOVERRIDE = "QTO_TYPEDRIVENOVERRIDE";
		public const string QTO_OCCURRENCEDRIVEN = "QTO_OCCURRENCEDRIVEN";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcProtectiveDeviceTrippingUnitTypeEnum
	{
		public const string ELECTRONIC = "ELECTRONIC";
		public const string ELECTROMAGNETIC = "ELECTROMAGNETIC";
		public const string RESIDUALCURRENT = "RESIDUALCURRENT";
		public const string THERMAL = "THERMAL";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcProtectiveDeviceTypeEnum
	{
		public const string CIRCUITBREAKER = "CIRCUITBREAKER";
		public const string EARTHLEAKAGECIRCUITBREAKER = "EARTHLEAKAGECIRCUITBREAKER";
		public const string EARTHINGSWITCH = "EARTHINGSWITCH";
		public const string FUSEDISCONNECTOR = "FUSEDISCONNECTOR";
		public const string RESIDUALCURRENTCIRCUITBREAKER = "RESIDUALCURRENTCIRCUITBREAKER";
		public const string RESIDUALCURRENTSWITCH = "RESIDUALCURRENTSWITCH";
		public const string VARISTOR = "VARISTOR";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcPumpTypeEnum
	{
		public const string CIRCULATOR = "CIRCULATOR";
		public const string ENDSUCTION = "ENDSUCTION";
		public const string SPLITCASE = "SPLITCASE";
		public const string SUBMERSIBLEPUMP = "SUBMERSIBLEPUMP";
		public const string SUMPPUMP = "SUMPPUMP";
		public const string VERTICALINLINE = "VERTICALINLINE";
		public const string VERTICALTURBINE = "VERTICALTURBINE";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcRailingTypeEnum
	{
		public const string HANDRAIL = "HANDRAIL";
		public const string GUARDRAIL = "GUARDRAIL";
		public const string BALUSTRADE = "BALUSTRADE";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcRampFlightTypeEnum
	{
		public const string STRAIGHT = "STRAIGHT";
		public const string SPIRAL = "SPIRAL";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcRampTypeEnum
	{
		public const string STRAIGHT_RUN_RAMP = "STRAIGHT_RUN_RAMP";
		public const string TWO_STRAIGHT_RUN_RAMP = "TWO_STRAIGHT_RUN_RAMP";
		public const string QUARTER_TURN_RAMP = "QUARTER_TURN_RAMP";
		public const string TWO_QUARTER_TURN_RAMP = "TWO_QUARTER_TURN_RAMP";
		public const string HALF_TURN_RAMP = "HALF_TURN_RAMP";
		public const string SPIRAL_RAMP = "SPIRAL_RAMP";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcRecurrenceTypeEnum
	{
		public const string DAILY = "DAILY";
		public const string WEEKLY = "WEEKLY";
		public const string MONTHLY_BY_DAY_OF_MONTH = "MONTHLY_BY_DAY_OF_MONTH";
		public const string MONTHLY_BY_POSITION = "MONTHLY_BY_POSITION";
		public const string BY_DAY_COUNT = "BY_DAY_COUNT";
		public const string BY_WEEKDAY_COUNT = "BY_WEEKDAY_COUNT";
		public const string YEARLY_BY_DAY_OF_MONTH = "YEARLY_BY_DAY_OF_MONTH";
		public const string YEARLY_BY_POSITION = "YEARLY_BY_POSITION";
	}

	public class IfcReflectanceMethodEnum
	{
		public const string BLINN = "BLINN";
		public const string FLAT = "FLAT";
		public const string GLASS = "GLASS";
		public const string MATT = "MATT";
		public const string METAL = "METAL";
		public const string MIRROR = "MIRROR";
		public const string PHONG = "PHONG";
		public const string PLASTIC = "PLASTIC";
		public const string STRAUSS = "STRAUSS";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcReinforcingBarRoleEnum
	{
		public const string MAIN = "MAIN";
		public const string SHEAR = "SHEAR";
		public const string LIGATURE = "LIGATURE";
		public const string STUD = "STUD";
		public const string PUNCHING = "PUNCHING";
		public const string EDGE = "EDGE";
		public const string RING = "RING";
		public const string ANCHORING = "ANCHORING";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcReinforcingBarSurfaceEnum
	{
		public const string PLAIN = "PLAIN";
		public const string TEXTURED = "TEXTURED";
	}

	public class IfcReinforcingBarTypeEnum
	{
		public const string ANCHORING = "ANCHORING";
		public const string EDGE = "EDGE";
		public const string LIGATURE = "LIGATURE";
		public const string MAIN = "MAIN";
		public const string PUNCHING = "PUNCHING";
		public const string RING = "RING";
		public const string SHEAR = "SHEAR";
		public const string STUD = "STUD";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcReinforcingMeshTypeEnum
	{
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcRoleEnum
	{
		public const string SUPPLIER = "SUPPLIER";
		public const string MANUFACTURER = "MANUFACTURER";
		public const string CONTRACTOR = "CONTRACTOR";
		public const string SUBCONTRACTOR = "SUBCONTRACTOR";
		public const string ARCHITECT = "ARCHITECT";
		public const string STRUCTURALENGINEER = "STRUCTURALENGINEER";
		public const string COSTENGINEER = "COSTENGINEER";
		public const string CLIENT = "CLIENT";
		public const string BUILDINGOWNER = "BUILDINGOWNER";
		public const string BUILDINGOPERATOR = "BUILDINGOPERATOR";
		public const string MECHANICALENGINEER = "MECHANICALENGINEER";
		public const string ELECTRICALENGINEER = "ELECTRICALENGINEER";
		public const string PROJECTMANAGER = "PROJECTMANAGER";
		public const string FACILITIESMANAGER = "FACILITIESMANAGER";
		public const string CIVILENGINEER = "CIVILENGINEER";
		public const string COMMISSIONINGENGINEER = "COMMISSIONINGENGINEER";
		public const string ENGINEER = "ENGINEER";
		public const string OWNER = "OWNER";
		public const string CONSULTANT = "CONSULTANT";
		public const string CONSTRUCTIONMANAGER = "CONSTRUCTIONMANAGER";
		public const string FIELDCONSTRUCTIONMANAGER = "FIELDCONSTRUCTIONMANAGER";
		public const string RESELLER = "RESELLER";
		public const string USERDEFINED = "USERDEFINED";
	}

	public class IfcRoofTypeEnum
	{
		public const string FLAT_ROOF = "FLAT_ROOF";
		public const string SHED_ROOF = "SHED_ROOF";
		public const string GABLE_ROOF = "GABLE_ROOF";
		public const string HIP_ROOF = "HIP_ROOF";
		public const string HIPPED_GABLE_ROOF = "HIPPED_GABLE_ROOF";
		public const string GAMBREL_ROOF = "GAMBREL_ROOF";
		public const string MANSARD_ROOF = "MANSARD_ROOF";
		public const string BARREL_ROOF = "BARREL_ROOF";
		public const string RAINBOW_ROOF = "RAINBOW_ROOF";
		public const string BUTTERFLY_ROOF = "BUTTERFLY_ROOF";
		public const string PAVILION_ROOF = "PAVILION_ROOF";
		public const string DOME_ROOF = "DOME_ROOF";
		public const string FREEFORM = "FREEFORM";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcSIPrefix
	{
		public const string EXA = "EXA";
		public const string PETA = "PETA";
		public const string TERA = "TERA";
		public const string GIGA = "GIGA";
		public const string MEGA = "MEGA";
		public const string KILO = "KILO";
		public const string HECTO = "HECTO";
		public const string DECA = "DECA";
		public const string DECI = "DECI";
		public const string CENTI = "CENTI";
		public const string MILLI = "MILLI";
		public const string MICRO = "MICRO";
		public const string NANO = "NANO";
		public const string PICO = "PICO";
		public const string FEMTO = "FEMTO";
		public const string ATTO = "ATTO";
	}

	public class IfcSIUnitName
	{
		public const string AMPERE = "AMPERE";
		public const string BECQUEREL = "BECQUEREL";
		public const string CANDELA = "CANDELA";
		public const string COULOMB = "COULOMB";
		public const string CUBIC_METRE = "CUBIC_METRE";
		public const string DEGREE_CELSIUS = "DEGREE_CELSIUS";
		public const string FARAD = "FARAD";
		public const string GRAM = "GRAM";
		public const string GRAY = "GRAY";
		public const string HENRY = "HENRY";
		public const string HERTZ = "HERTZ";
		public const string JOULE = "JOULE";
		public const string KELVIN = "KELVIN";
		public const string LUMEN = "LUMEN";
		public const string LUX = "LUX";
		public const string METRE = "METRE";
		public const string MOLE = "MOLE";
		public const string NEWTON = "NEWTON";
		public const string OHM = "OHM";
		public const string PASCAL = "PASCAL";
		public const string RADIAN = "RADIAN";
		public const string SECOND = "SECOND";
		public const string SIEMENS = "SIEMENS";
		public const string SIEVERT = "SIEVERT";
		public const string SQUARE_METRE = "SQUARE_METRE";
		public const string STERADIAN = "STERADIAN";
		public const string TESLA = "TESLA";
		public const string VOLT = "VOLT";
		public const string WATT = "WATT";
		public const string WEBER = "WEBER";
	}

	public class IfcSanitaryTerminalTypeEnum
	{
		public const string BATH = "BATH";
		public const string BIDET = "BIDET";
		public const string CISTERN = "CISTERN";
		public const string SHOWER = "SHOWER";
		public const string SINK = "SINK";
		public const string SANITARYFOUNTAIN = "SANITARYFOUNTAIN";
		public const string TOILETPAN = "TOILETPAN";
		public const string URINAL = "URINAL";
		public const string WASHHANDBASIN = "WASHHANDBASIN";
		public const string WCSEAT = "WCSEAT";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcSectionTypeEnum
	{
		public const string UNIFORM = "UNIFORM";
		public const string TAPERED = "TAPERED";
	}

	public class IfcSensorTypeEnum
	{
		public const string COSENSOR = "COSENSOR";
		public const string CO2SENSOR = "CO2SENSOR";
		public const string CONDUCTANCESENSOR = "CONDUCTANCESENSOR";
		public const string CONTACTSENSOR = "CONTACTSENSOR";
		public const string FIRESENSOR = "FIRESENSOR";
		public const string FLOWSENSOR = "FLOWSENSOR";
		public const string FROSTSENSOR = "FROSTSENSOR";
		public const string GASSENSOR = "GASSENSOR";
		public const string HEATSENSOR = "HEATSENSOR";
		public const string HUMIDITYSENSOR = "HUMIDITYSENSOR";
		public const string IDENTIFIERSENSOR = "IDENTIFIERSENSOR";
		public const string IONCONCENTRATIONSENSOR = "IONCONCENTRATIONSENSOR";
		public const string LEVELSENSOR = "LEVELSENSOR";
		public const string LIGHTSENSOR = "LIGHTSENSOR";
		public const string MOISTURESENSOR = "MOISTURESENSOR";
		public const string MOVEMENTSENSOR = "MOVEMENTSENSOR";
		public const string PHSENSOR = "PHSENSOR";
		public const string PRESSURESENSOR = "PRESSURESENSOR";
		public const string RADIATIONSENSOR = "RADIATIONSENSOR";
		public const string RADIOACTIVITYSENSOR = "RADIOACTIVITYSENSOR";
		public const string SMOKESENSOR = "SMOKESENSOR";
		public const string SOUNDSENSOR = "SOUNDSENSOR";
		public const string TEMPERATURESENSOR = "TEMPERATURESENSOR";
		public const string WINDSENSOR = "WINDSENSOR";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcSequenceEnum
	{
		public const string START_START = "START_START";
		public const string START_FINISH = "START_FINISH";
		public const string FINISH_START = "FINISH_START";
		public const string FINISH_FINISH = "FINISH_FINISH";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcShadingDeviceTypeEnum
	{
		public const string JALOUSIE = "JALOUSIE";
		public const string SHUTTER = "SHUTTER";
		public const string AWNING = "AWNING";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcSimplePropertyTemplateTypeEnum
	{
		public const string P_SINGLEVALUE = "P_SINGLEVALUE";
		public const string P_ENUMERATEDVALUE = "P_ENUMERATEDVALUE";
		public const string P_BOUNDEDVALUE = "P_BOUNDEDVALUE";
		public const string P_LISTVALUE = "P_LISTVALUE";
		public const string P_TABLEVALUE = "P_TABLEVALUE";
		public const string P_REFERENCEVALUE = "P_REFERENCEVALUE";
		public const string Q_LENGTH = "Q_LENGTH";
		public const string Q_AREA = "Q_AREA";
		public const string Q_VOLUME = "Q_VOLUME";
		public const string Q_COUNT = "Q_COUNT";
		public const string Q_WEIGHT = "Q_WEIGHT";
		public const string Q_TIME = "Q_TIME";
	}

	public class IfcSlabTypeEnum
	{
		public const string FLOOR = "FLOOR";
		public const string ROOF = "ROOF";
		public const string LANDING = "LANDING";
		public const string BASESLAB = "BASESLAB";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcSolarDeviceTypeEnum
	{
		public const string SOLARCOLLECTOR = "SOLARCOLLECTOR";
		public const string SOLARPANEL = "SOLARPANEL";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcSpaceHeaterTypeEnum
	{
		public const string CONVECTOR = "CONVECTOR";
		public const string RADIATOR = "RADIATOR";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcSpaceTypeEnum
	{
		public const string SPACE = "SPACE";
		public const string PARKING = "PARKING";
		public const string GFA = "GFA";
		public const string INTERNAL = "INTERNAL";
		public const string EXTERNAL = "EXTERNAL";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcSpatialZoneTypeEnum
	{
		public const string CONSTRUCTION = "CONSTRUCTION";
		public const string FIRESAFETY = "FIRESAFETY";
		public const string LIGHTING = "LIGHTING";
		public const string OCCUPANCY = "OCCUPANCY";
		public const string SECURITY = "SECURITY";
		public const string THERMAL = "THERMAL";
		public const string TRANSPORT = "TRANSPORT";
		public const string VENTILATION = "VENTILATION";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcStackTerminalTypeEnum
	{
		public const string BIRDCAGE = "BIRDCAGE";
		public const string COWL = "COWL";
		public const string RAINWATERHOPPER = "RAINWATERHOPPER";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcStairFlightTypeEnum
	{
		public const string STRAIGHT = "STRAIGHT";
		public const string WINDER = "WINDER";
		public const string SPIRAL = "SPIRAL";
		public const string CURVED = "CURVED";
		public const string FREEFORM = "FREEFORM";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcStairTypeEnum
	{
		public const string STRAIGHT_RUN_STAIR = "STRAIGHT_RUN_STAIR";
		public const string TWO_STRAIGHT_RUN_STAIR = "TWO_STRAIGHT_RUN_STAIR";
		public const string QUARTER_WINDING_STAIR = "QUARTER_WINDING_STAIR";
		public const string QUARTER_TURN_STAIR = "QUARTER_TURN_STAIR";
		public const string HALF_WINDING_STAIR = "HALF_WINDING_STAIR";
		public const string HALF_TURN_STAIR = "HALF_TURN_STAIR";
		public const string TWO_QUARTER_WINDING_STAIR = "TWO_QUARTER_WINDING_STAIR";
		public const string TWO_QUARTER_TURN_STAIR = "TWO_QUARTER_TURN_STAIR";
		public const string THREE_QUARTER_WINDING_STAIR = "THREE_QUARTER_WINDING_STAIR";
		public const string THREE_QUARTER_TURN_STAIR = "THREE_QUARTER_TURN_STAIR";
		public const string SPIRAL_STAIR = "SPIRAL_STAIR";
		public const string DOUBLE_RETURN_STAIR = "DOUBLE_RETURN_STAIR";
		public const string CURVED_RUN_STAIR = "CURVED_RUN_STAIR";
		public const string TWO_CURVED_RUN_STAIR = "TWO_CURVED_RUN_STAIR";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcStateEnum
	{
		public const string READWRITE = "READWRITE";
		public const string READONLY = "READONLY";
		public const string LOCKED = "LOCKED";
		public const string READWRITELOCKED = "READWRITELOCKED";
		public const string READONLYLOCKED = "READONLYLOCKED";
	}

	public class IfcStructuralCurveActivityTypeEnum
	{
		public const string CONST = "CONST";
		public const string LINEAR = "LINEAR";
		public const string POLYGONAL = "POLYGONAL";
		public const string EQUIDISTANT = "EQUIDISTANT";
		public const string SINUS = "SINUS";
		public const string PARABOLA = "PARABOLA";
		public const string DISCRETE = "DISCRETE";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcStructuralCurveMemberTypeEnum
	{
		public const string RIGID_JOINED_MEMBER = "RIGID_JOINED_MEMBER";
		public const string PIN_JOINED_MEMBER = "PIN_JOINED_MEMBER";
		public const string CABLE = "CABLE";
		public const string TENSION_MEMBER = "TENSION_MEMBER";
		public const string COMPRESSION_MEMBER = "COMPRESSION_MEMBER";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcStructuralSurfaceActivityTypeEnum
	{
		public const string CONST = "CONST";
		public const string BILINEAR = "BILINEAR";
		public const string DISCRETE = "DISCRETE";
		public const string ISOCONTOUR = "ISOCONTOUR";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcStructuralSurfaceMemberTypeEnum
	{
		public const string BENDING_ELEMENT = "BENDING_ELEMENT";
		public const string MEMBRANE_ELEMENT = "MEMBRANE_ELEMENT";
		public const string SHELL = "SHELL";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcSubContractResourceTypeEnum
	{
		public const string PURCHASE = "PURCHASE";
		public const string WORK = "WORK";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcSurfaceFeatureTypeEnum
	{
		public const string MARK = "MARK";
		public const string TAG = "TAG";
		public const string TREATMENT = "TREATMENT";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcSurfaceSide
	{
		public const string POSITIVE = "POSITIVE";
		public const string NEGATIVE = "NEGATIVE";
		public const string BOTH = "BOTH";
	}

	public class IfcSwitchingDeviceTypeEnum
	{
		public const string CONTACTOR = "CONTACTOR";
		public const string DIMMERSWITCH = "DIMMERSWITCH";
		public const string EMERGENCYSTOP = "EMERGENCYSTOP";
		public const string KEYPAD = "KEYPAD";
		public const string MOMENTARYSWITCH = "MOMENTARYSWITCH";
		public const string SELECTORSWITCH = "SELECTORSWITCH";
		public const string STARTER = "STARTER";
		public const string SWITCHDISCONNECTOR = "SWITCHDISCONNECTOR";
		public const string TOGGLESWITCH = "TOGGLESWITCH";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcSystemFurnitureElementTypeEnum
	{
		public const string PANEL = "PANEL";
		public const string WORKSURFACE = "WORKSURFACE";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcTankTypeEnum
	{
		public const string BASIN = "BASIN";
		public const string BREAKPRESSURE = "BREAKPRESSURE";
		public const string EXPANSION = "EXPANSION";
		public const string FEEDANDEXPANSION = "FEEDANDEXPANSION";
		public const string PRESSUREVESSEL = "PRESSUREVESSEL";
		public const string STORAGE = "STORAGE";
		public const string VESSEL = "VESSEL";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcTaskDurationEnum
	{
		public const string ELAPSEDTIME = "ELAPSEDTIME";
		public const string WORKTIME = "WORKTIME";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcTaskTypeEnum
	{
		public const string ATTENDANCE = "ATTENDANCE";
		public const string CONSTRUCTION = "CONSTRUCTION";
		public const string DEMOLITION = "DEMOLITION";
		public const string DISMANTLE = "DISMANTLE";
		public const string DISPOSAL = "DISPOSAL";
		public const string INSTALLATION = "INSTALLATION";
		public const string LOGISTIC = "LOGISTIC";
		public const string MAINTENANCE = "MAINTENANCE";
		public const string MOVE = "MOVE";
		public const string OPERATION = "OPERATION";
		public const string REMOVAL = "REMOVAL";
		public const string RENOVATION = "RENOVATION";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcTendonAnchorTypeEnum
	{
		public const string COUPLER = "COUPLER";
		public const string FIXED_END = "FIXED_END";
		public const string TENSIONING_END = "TENSIONING_END";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcTendonTypeEnum
	{
		public const string BAR = "BAR";
		public const string COATED = "COATED";
		public const string STRAND = "STRAND";
		public const string WIRE = "WIRE";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcTextPath
	{
		public const string LEFT = "LEFT";
		public const string RIGHT = "RIGHT";
		public const string UP = "UP";
		public const string DOWN = "DOWN";
	}

	public class IfcTimeSeriesDataTypeEnum
	{
		public const string CONTINUOUS = "CONTINUOUS";
		public const string DISCRETE = "DISCRETE";
		public const string DISCRETEBINARY = "DISCRETEBINARY";
		public const string PIECEWISEBINARY = "PIECEWISEBINARY";
		public const string PIECEWISECONSTANT = "PIECEWISECONSTANT";
		public const string PIECEWISECONTINUOUS = "PIECEWISECONTINUOUS";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcTransformerTypeEnum
	{
		public const string CURRENT = "CURRENT";
		public const string FREQUENCY = "FREQUENCY";
		public const string INVERTER = "INVERTER";
		public const string RECTIFIER = "RECTIFIER";
		public const string VOLTAGE = "VOLTAGE";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcTransitionCode
	{
		public const string DISCONTINUOUS = "DISCONTINUOUS";
		public const string CONTINUOUS = "CONTINUOUS";
		public const string CONTSAMEGRADIENT = "CONTSAMEGRADIENT";
		public const string CONTSAMEGRADIENTSAMECURVATURE = "CONTSAMEGRADIENTSAMECURVATURE";
	}

	public class IfcTransportElementTypeEnum
	{
		public const string ELEVATOR = "ELEVATOR";
		public const string ESCALATOR = "ESCALATOR";
		public const string MOVINGWALKWAY = "MOVINGWALKWAY";
		public const string CRANEWAY = "CRANEWAY";
		public const string LIFTINGGEAR = "LIFTINGGEAR";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcTrimmingPreference
	{
		public const string CARTESIAN = "CARTESIAN";
		public const string PARAMETER = "PARAMETER";
		public const string UNSPECIFIED = "UNSPECIFIED";
	}

	public class IfcTubeBundleTypeEnum
	{
		public const string FINNED = "FINNED";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcUnitEnum
	{
		public const string ABSORBEDDOSEUNIT = "ABSORBEDDOSEUNIT";
		public const string AMOUNTOFSUBSTANCEUNIT = "AMOUNTOFSUBSTANCEUNIT";
		public const string AREAUNIT = "AREAUNIT";
		public const string DOSEEQUIVALENTUNIT = "DOSEEQUIVALENTUNIT";
		public const string ELECTRICCAPACITANCEUNIT = "ELECTRICCAPACITANCEUNIT";
		public const string ELECTRICCHARGEUNIT = "ELECTRICCHARGEUNIT";
		public const string ELECTRICCONDUCTANCEUNIT = "ELECTRICCONDUCTANCEUNIT";
		public const string ELECTRICCURRENTUNIT = "ELECTRICCURRENTUNIT";
		public const string ELECTRICRESISTANCEUNIT = "ELECTRICRESISTANCEUNIT";
		public const string ELECTRICVOLTAGEUNIT = "ELECTRICVOLTAGEUNIT";
		public const string ENERGYUNIT = "ENERGYUNIT";
		public const string FORCEUNIT = "FORCEUNIT";
		public const string FREQUENCYUNIT = "FREQUENCYUNIT";
		public const string ILLUMINANCEUNIT = "ILLUMINANCEUNIT";
		public const string INDUCTANCEUNIT = "INDUCTANCEUNIT";
		public const string LENGTHUNIT = "LENGTHUNIT";
		public const string LUMINOUSFLUXUNIT = "LUMINOUSFLUXUNIT";
		public const string LUMINOUSINTENSITYUNIT = "LUMINOUSINTENSITYUNIT";
		public const string MAGNETICFLUXDENSITYUNIT = "MAGNETICFLUXDENSITYUNIT";
		public const string MAGNETICFLUXUNIT = "MAGNETICFLUXUNIT";
		public const string MASSUNIT = "MASSUNIT";
		public const string PLANEANGLEUNIT = "PLANEANGLEUNIT";
		public const string POWERUNIT = "POWERUNIT";
		public const string PRESSUREUNIT = "PRESSUREUNIT";
		public const string RADIOACTIVITYUNIT = "RADIOACTIVITYUNIT";
		public const string SOLIDANGLEUNIT = "SOLIDANGLEUNIT";
		public const string THERMODYNAMICTEMPERATUREUNIT = "THERMODYNAMICTEMPERATUREUNIT";
		public const string TIMEUNIT = "TIMEUNIT";
		public const string VOLUMEUNIT = "VOLUMEUNIT";
		public const string USERDEFINED = "USERDEFINED";
	}

	public class IfcUnitaryControlElementTypeEnum
	{
		public const string ALARMPANEL = "ALARMPANEL";
		public const string CONTROLPANEL = "CONTROLPANEL";
		public const string GASDETECTIONPANEL = "GASDETECTIONPANEL";
		public const string INDICATORPANEL = "INDICATORPANEL";
		public const string MIMICPANEL = "MIMICPANEL";
		public const string HUMIDISTAT = "HUMIDISTAT";
		public const string THERMOSTAT = "THERMOSTAT";
		public const string WEATHERSTATION = "WEATHERSTATION";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcUnitaryEquipmentTypeEnum
	{
		public const string AIRHANDLER = "AIRHANDLER";
		public const string AIRCONDITIONINGUNIT = "AIRCONDITIONINGUNIT";
		public const string DEHUMIDIFIER = "DEHUMIDIFIER";
		public const string SPLITSYSTEM = "SPLITSYSTEM";
		public const string ROOFTOPUNIT = "ROOFTOPUNIT";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcValveTypeEnum
	{
		public const string AIRRELEASE = "AIRRELEASE";
		public const string ANTIVACUUM = "ANTIVACUUM";
		public const string CHANGEOVER = "CHANGEOVER";
		public const string CHECK = "CHECK";
		public const string COMMISSIONING = "COMMISSIONING";
		public const string DIVERTING = "DIVERTING";
		public const string DRAWOFFCOCK = "DRAWOFFCOCK";
		public const string DOUBLECHECK = "DOUBLECHECK";
		public const string DOUBLEREGULATING = "DOUBLEREGULATING";
		public const string FAUCET = "FAUCET";
		public const string FLUSHING = "FLUSHING";
		public const string GASCOCK = "GASCOCK";
		public const string GASTAP = "GASTAP";
		public const string ISOLATING = "ISOLATING";
		public const string MIXING = "MIXING";
		public const string PRESSUREREDUCING = "PRESSUREREDUCING";
		public const string PRESSURERELIEF = "PRESSURERELIEF";
		public const string REGULATING = "REGULATING";
		public const string SAFETYCUTOFF = "SAFETYCUTOFF";
		public const string STEAMTRAP = "STEAMTRAP";
		public const string STOPCOCK = "STOPCOCK";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcVibrationIsolatorTypeEnum
	{
		public const string COMPRESSION = "COMPRESSION";
		public const string SPRING = "SPRING";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcVoidingFeatureTypeEnum
	{
		public const string CUTOUT = "CUTOUT";
		public const string NOTCH = "NOTCH";
		public const string HOLE = "HOLE";
		public const string MITER = "MITER";
		public const string CHAMFER = "CHAMFER";
		public const string EDGE = "EDGE";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcWallTypeEnum
	{
		public const string MOVABLE = "MOVABLE";
		public const string PARAPET = "PARAPET";
		public const string PARTITIONING = "PARTITIONING";
		public const string PLUMBINGWALL = "PLUMBINGWALL";
		public const string SHEAR = "SHEAR";
		public const string SOLIDWALL = "SOLIDWALL";
		public const string STANDARD = "STANDARD";
		public const string POLYGONAL = "POLYGONAL";
		public const string ELEMENTEDWALL = "ELEMENTEDWALL";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcWasteTerminalTypeEnum
	{
		public const string FLOORTRAP = "FLOORTRAP";
		public const string FLOORWASTE = "FLOORWASTE";
		public const string GULLYSUMP = "GULLYSUMP";
		public const string GULLYTRAP = "GULLYTRAP";
		public const string ROOFDRAIN = "ROOFDRAIN";
		public const string WASTEDISPOSALUNIT = "WASTEDISPOSALUNIT";
		public const string WASTETRAP = "WASTETRAP";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcWindowPanelOperationEnum
	{
		public const string SIDEHUNGRIGHTHAND = "SIDEHUNGRIGHTHAND";
		public const string SIDEHUNGLEFTHAND = "SIDEHUNGLEFTHAND";
		public const string TILTANDTURNRIGHTHAND = "TILTANDTURNRIGHTHAND";
		public const string TILTANDTURNLEFTHAND = "TILTANDTURNLEFTHAND";
		public const string TOPHUNG = "TOPHUNG";
		public const string BOTTOMHUNG = "BOTTOMHUNG";
		public const string PIVOTHORIZONTAL = "PIVOTHORIZONTAL";
		public const string PIVOTVERTICAL = "PIVOTVERTICAL";
		public const string SLIDINGHORIZONTAL = "SLIDINGHORIZONTAL";
		public const string SLIDINGVERTICAL = "SLIDINGVERTICAL";
		public const string REMOVABLECASEMENT = "REMOVABLECASEMENT";
		public const string FIXEDCASEMENT = "FIXEDCASEMENT";
		public const string OTHEROPERATION = "OTHEROPERATION";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcWindowPanelPositionEnum
	{
		public const string LEFT = "LEFT";
		public const string MIDDLE = "MIDDLE";
		public const string RIGHT = "RIGHT";
		public const string BOTTOM = "BOTTOM";
		public const string TOP = "TOP";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcWindowStyleConstructionEnum
	{
		public const string ALUMINIUM = "ALUMINIUM";
		public const string HIGH_GRADE_STEEL = "HIGH_GRADE_STEEL";
		public const string STEEL = "STEEL";
		public const string WOOD = "WOOD";
		public const string ALUMINIUM_WOOD = "ALUMINIUM_WOOD";
		public const string PLASTIC = "PLASTIC";
		public const string OTHER_CONSTRUCTION = "OTHER_CONSTRUCTION";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcWindowStyleOperationEnum
	{
		public const string SINGLE_PANEL = "SINGLE_PANEL";
		public const string DOUBLE_PANEL_VERTICAL = "DOUBLE_PANEL_VERTICAL";
		public const string DOUBLE_PANEL_HORIZONTAL = "DOUBLE_PANEL_HORIZONTAL";
		public const string TRIPLE_PANEL_VERTICAL = "TRIPLE_PANEL_VERTICAL";
		public const string TRIPLE_PANEL_BOTTOM = "TRIPLE_PANEL_BOTTOM";
		public const string TRIPLE_PANEL_TOP = "TRIPLE_PANEL_TOP";
		public const string TRIPLE_PANEL_LEFT = "TRIPLE_PANEL_LEFT";
		public const string TRIPLE_PANEL_RIGHT = "TRIPLE_PANEL_RIGHT";
		public const string TRIPLE_PANEL_HORIZONTAL = "TRIPLE_PANEL_HORIZONTAL";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcWindowTypeEnum
	{
		public const string WINDOW = "WINDOW";
		public const string SKYLIGHT = "SKYLIGHT";
		public const string LIGHTDOME = "LIGHTDOME";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcWindowTypePartitioningEnum
	{
		public const string SINGLE_PANEL = "SINGLE_PANEL";
		public const string DOUBLE_PANEL_VERTICAL = "DOUBLE_PANEL_VERTICAL";
		public const string DOUBLE_PANEL_HORIZONTAL = "DOUBLE_PANEL_HORIZONTAL";
		public const string TRIPLE_PANEL_VERTICAL = "TRIPLE_PANEL_VERTICAL";
		public const string TRIPLE_PANEL_BOTTOM = "TRIPLE_PANEL_BOTTOM";
		public const string TRIPLE_PANEL_TOP = "TRIPLE_PANEL_TOP";
		public const string TRIPLE_PANEL_LEFT = "TRIPLE_PANEL_LEFT";
		public const string TRIPLE_PANEL_RIGHT = "TRIPLE_PANEL_RIGHT";
		public const string TRIPLE_PANEL_HORIZONTAL = "TRIPLE_PANEL_HORIZONTAL";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcWorkCalendarTypeEnum
	{
		public const string FIRSTSHIFT = "FIRSTSHIFT";
		public const string SECONDSHIFT = "SECONDSHIFT";
		public const string THIRDSHIFT = "THIRDSHIFT";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcWorkPlanTypeEnum
	{
		public const string ACTUAL = "ACTUAL";
		public const string BASELINE = "BASELINE";
		public const string PLANNED = "PLANNED";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public class IfcWorkScheduleTypeEnum
	{
		public const string ACTUAL = "ACTUAL";
		public const string BASELINE = "BASELINE";
		public const string PLANNED = "PLANNED";
		public const string USERDEFINED = "USERDEFINED";
		public const string NOTDEFINED = "NOTDEFINED";
	}

	public interface IfcActorSelect
	{
	}

	public interface IfcAppliedValueSelect
	{
	}

	public interface IfcAxis2Placement
	{
		IfcDirection GetRefDirection();
		List<IfcDirection> GetP();
	}

	public interface IfcBendingParameterSelect
	{
	}

	public interface IfcBooleanOperand
	{
		IfcDimensionCount GetDim();
	}

	public interface IfcClassificationReferenceSelect
	{
		IfcText GetDescription();
		List<IfcClassificationReference> GetHasReferences();
	}

	public interface IfcClassificationSelect
	{
		IfcText GetDescription();
		List<IfcClassificationReference> GetHasReferences();
	}

	public interface IfcColour : IfcFillStyleSelect
	{
	}

	public interface IfcColourOrFactor
	{
	}

	public interface IfcCoordinateReferenceSystemSelect
	{
		List<IfcCoordinateOperation> GetHasCoordinateOperation();
	}

	public interface IfcCsgSelect
	{
		IfcDimensionCount GetDim();
	}

	public interface IfcCurveFontOrScaledCurveFontSelect
	{
	}

	public interface IfcCurveOnSurface
	{
	}

	public interface IfcCurveOrEdgeCurve
	{
	}

	public interface IfcCurveStyleFontSelect : IfcCurveFontOrScaledCurveFontSelect
	{
	}

	public interface IfcDefinitionSelect
	{
		List<IfcRelDeclares> GetHasContext();
		List<IfcRelAssociates> GetHasAssociations();
	}

	public interface IfcDerivedMeasureValue : IfcValue
	{
	}

	public interface IfcDocumentSelect
	{
		IfcText GetDescription();
	}

	public interface IfcFillStyleSelect
	{
	}

	public interface IfcGeometricSetSelect
	{
	}

	public interface IfcGridPlacementDirectionSelect
	{
		List<IfcReal> GetDirectionRatios();
		IfcDimensionCount GetDim();
	}

	public interface IfcHatchLineDistanceSelect
	{
	}

	public interface IfcLayeredItem
	{
	}

	public interface IfcLibrarySelect
	{
		IfcText GetDescription();
	}

	public interface IfcLightDistributionDataSourceSelect
	{
		IfcURIReference GetLocation();
		IfcIdentifier GetIdentification();
		IfcLabel GetName();
		List<IfcExternalReferenceRelationship> GetExternalReferenceForResources();
	}

	public interface IfcMaterialSelect
	{
		List<IfcRelAssociatesMaterial> GetAssociatedTo();
	}

	public interface IfcMeasureValue : IfcValue
	{
	}

	public interface IfcMetricValueSelect
	{
	}

	public interface IfcModulusOfRotationalSubgradeReactionSelect
	{
	}

	public interface IfcModulusOfSubgradeReactionSelect
	{
	}

	public interface IfcModulusOfTranslationalSubgradeReactionSelect
	{
	}

	public interface IfcObjectReferenceSelect
	{
	}

	public interface IfcPointOrVertexPoint
	{
	}

	public interface IfcPresentationStyleSelect
	{
	}

	public interface IfcProcessSelect
	{
		IfcIdentifier GetIdentification();
		IfcText GetLongDescription();
		List<IfcRelAssignsToProcess> GetOperatesOn();
	}

	public interface IfcProductRepresentationSelect
	{
		List<IfcProduct> GetShapeOfProduct();
		List<IfcShapeAspect> GetHasShapeAspects();
	}

	public interface IfcProductSelect
	{
		List<IfcRelAssignsToProduct> GetReferencedBy();
	}

	public interface IfcPropertySetDefinitionSelect
	{
	}

	public interface IfcResourceObjectSelect
	{
	}

	public interface IfcResourceSelect
	{
		IfcIdentifier GetIdentification();
		IfcText GetLongDescription();
		List<IfcRelAssignsToResource> GetResourceOf();
	}

	public interface IfcRotationalStiffnessSelect
	{
	}

	public interface IfcSegmentIndexSelect
	{
		List<IfcPositiveInteger> GetValue();
	}

	public interface IfcShell
	{
	}

	public interface IfcSimpleValue : IfcValue
	{
	}

	public interface IfcSizeSelect
	{
	}

	public interface IfcSolidOrShell
	{
	}

	public interface IfcSpaceBoundarySelect
	{
		List<IfcRelSpaceBoundary> GetBoundedBy();
	}

	public interface IfcSpecularHighlightSelect
	{
	}

	public interface IfcStructuralActivityAssignmentSelect
	{
	}

	public interface IfcStyleAssignmentSelect
	{
		IfcLabel GetName();
	}

	public interface IfcSurfaceOrFaceSurface
	{
	}

	public interface IfcSurfaceStyleElementSelect
	{
	}

	public interface IfcTextFontSelect
	{
	}

	public interface IfcTimeOrRatioSelect
	{
	}

	public interface IfcTranslationalStiffnessSelect
	{
	}

	public interface IfcTrimmingSelect
	{
	}

	public interface IfcUnit
	{
		IfcDimensionalExponents GetDimensions();
		IfcUnitEnum GetUnitType();
	}

	public interface IfcValue : IfcAppliedValueSelect, IfcMetricValueSelect
	{
	}

	public interface IfcVectorOrDirection
	{
		IfcDimensionCount GetDim();
	}

	public interface IfcWarpingStiffnessSelect
	{
	}

	public class IfcActionRequest : IfcControl
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	Identification : IfcIdentifier
		//7	PredefinedType : IfcActionRequestTypeEnum
		//8	Status : IfcLabel
		//9	LongDescription : IfcText

		public IfcActionRequestTypeEnum PredefinedType { get; set; }
		public IfcLabel Status { get; set; }
		public IfcText LongDescription { get; set; }

		public IfcActionRequest() { }

		public IfcActionRequest(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcIdentifier Identification, IfcActionRequestTypeEnum PredefinedType, IfcLabel Status, IfcText LongDescription)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.Identification = Identification;
			this.PredefinedType = PredefinedType;
			this.Status = Status;
			this.LongDescription = LongDescription;
		}
	}

	public class IfcActor : IfcObject
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	TheActor : IfcActorSelect

		public IfcActorSelect TheActor { get; set; }
		public List<IfcRelAssignsToActor> IsActingUpon { get; set; }

		public IfcActor() { }

		public IfcActor(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcActorSelect TheActor)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.TheActor = TheActor;
		}
	}

	public class IfcActorRole : IfcBase
	{
		//1	Role : IfcRoleEnum
		//2	UserDefinedRole : IfcLabel
		//3	Description : IfcText

		public IfcRoleEnum Role { get; set; }
		public IfcLabel UserDefinedRole { get; set; }
		public IfcText Description { get; set; }
		public List<IfcExternalReferenceRelationship> HasExternalReference { get; set; }

		public IfcActorRole() { }

		public IfcActorRole(IfcRoleEnum Role, IfcLabel UserDefinedRole, IfcText Description)
		{
			this.Role = Role;
			this.UserDefinedRole = UserDefinedRole;
			this.Description = Description;
		}
	}

	public class IfcActuator : IfcDistributionControlElement
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	PredefinedType : IfcActuatorTypeEnum

		public IfcActuatorTypeEnum PredefinedType { get; set; }

		public IfcActuator() { }

		public IfcActuator(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcActuatorTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcActuatorType : IfcDistributionControlElementType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel
		//10	PredefinedType : IfcActuatorTypeEnum

		public IfcActuatorTypeEnum PredefinedType { get; set; }

		public IfcActuatorType() { }

		public IfcActuatorType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType, IfcActuatorTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
			this.PredefinedType = PredefinedType;
		}
	}

	public abstract class IfcAddress : IfcBase, IfcObjectReferenceSelect
	{
		//1	Purpose : IfcAddressTypeEnum
		//2	Description : IfcText
		//3	UserDefinedPurpose : IfcLabel

		public IfcAddressTypeEnum Purpose { get; set; }
		public IfcText Description { get; set; }
		public IfcLabel UserDefinedPurpose { get; set; }
		public List<IfcPerson> OfPerson { get; set; }
		public List<IfcOrganization> OfOrganization { get; set; }

		public IfcAddress() { }

		public IfcAddress(IfcAddressTypeEnum Purpose, IfcText Description, IfcLabel UserDefinedPurpose)
		{
			this.Purpose = Purpose;
			this.Description = Description;
			this.UserDefinedPurpose = UserDefinedPurpose;
		}
	}

	public class IfcAdvancedBrep : IfcManifoldSolidBrep
	{
		//1	Outer : IfcClosedShell

		public IfcAdvancedBrep() { }

		public IfcAdvancedBrep(IfcClosedShell Outer)
		{
			this.Outer = Outer;
		}
	}

	public class IfcAdvancedBrepWithVoids : IfcAdvancedBrep
	{
		//1	Outer : IfcClosedShell
		//2	Voids : List<IfcClosedShell>

		public List<IfcClosedShell> Voids { get; set; }

		public IfcAdvancedBrepWithVoids() { }

		public IfcAdvancedBrepWithVoids(IfcClosedShell Outer, List<IfcClosedShell> Voids)
		{
			this.Outer = Outer;
			this.Voids = Voids;
		}
	}

	public class IfcAdvancedFace : IfcFaceSurface
	{
		//1	Bounds : List<IfcFaceBound>
		//2	FaceSurface : IfcSurface
		//3	SameSense : IfcBoolean

		public IfcAdvancedFace() { }

		public IfcAdvancedFace(List<IfcFaceBound> Bounds, IfcSurface FaceSurface, IfcBoolean SameSense)
		{
			this.Bounds = Bounds;
			this.FaceSurface = FaceSurface;
			this.SameSense = SameSense;
		}
	}

	public class IfcAirTerminal : IfcFlowTerminal
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	PredefinedType : IfcAirTerminalTypeEnum

		public IfcAirTerminalTypeEnum PredefinedType { get; set; }

		public IfcAirTerminal() { }

		public IfcAirTerminal(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcAirTerminalTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcAirTerminalBox : IfcFlowController
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	PredefinedType : IfcAirTerminalBoxTypeEnum

		public IfcAirTerminalBoxTypeEnum PredefinedType { get; set; }

		public IfcAirTerminalBox() { }

		public IfcAirTerminalBox(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcAirTerminalBoxTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcAirTerminalBoxType : IfcFlowControllerType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel
		//10	PredefinedType : IfcAirTerminalBoxTypeEnum

		public IfcAirTerminalBoxTypeEnum PredefinedType { get; set; }

		public IfcAirTerminalBoxType() { }

		public IfcAirTerminalBoxType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType, IfcAirTerminalBoxTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcAirTerminalType : IfcFlowTerminalType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel
		//10	PredefinedType : IfcAirTerminalTypeEnum

		public IfcAirTerminalTypeEnum PredefinedType { get; set; }

		public IfcAirTerminalType() { }

		public IfcAirTerminalType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType, IfcAirTerminalTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcAirToAirHeatRecovery : IfcEnergyConversionDevice
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	PredefinedType : IfcAirToAirHeatRecoveryTypeEnum

		public IfcAirToAirHeatRecoveryTypeEnum PredefinedType { get; set; }

		public IfcAirToAirHeatRecovery() { }

		public IfcAirToAirHeatRecovery(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcAirToAirHeatRecoveryTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcAirToAirHeatRecoveryType : IfcEnergyConversionDeviceType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel
		//10	PredefinedType : IfcAirToAirHeatRecoveryTypeEnum

		public IfcAirToAirHeatRecoveryTypeEnum PredefinedType { get; set; }

		public IfcAirToAirHeatRecoveryType() { }

		public IfcAirToAirHeatRecoveryType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType, IfcAirToAirHeatRecoveryTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcAlarm : IfcDistributionControlElement
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	PredefinedType : IfcAlarmTypeEnum

		public IfcAlarmTypeEnum PredefinedType { get; set; }

		public IfcAlarm() { }

		public IfcAlarm(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcAlarmTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcAlarmType : IfcDistributionControlElementType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel
		//10	PredefinedType : IfcAlarmTypeEnum

		public IfcAlarmTypeEnum PredefinedType { get; set; }

		public IfcAlarmType() { }

		public IfcAlarmType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType, IfcAlarmTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcAnnotation : IfcProduct
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation

		public List<IfcRelContainedInSpatialStructure> ContainedInStructure { get; set; }

		public IfcAnnotation() { }

		public IfcAnnotation(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
		}
	}

	public class IfcAnnotationFillArea : IfcGeometricRepresentationItem
	{
		//1	OuterBoundary : IfcCurve
		//2	InnerBoundaries : List<IfcCurve>

		public IfcCurve OuterBoundary { get; set; }
		public List<IfcCurve> InnerBoundaries { get; set; }

		public IfcAnnotationFillArea() { }

		public IfcAnnotationFillArea(IfcCurve OuterBoundary, List<IfcCurve> InnerBoundaries)
		{
			this.OuterBoundary = OuterBoundary;
			this.InnerBoundaries = InnerBoundaries;
		}
	}

	public class IfcApplication : IfcBase
	{
		//1	ApplicationDeveloper : IfcOrganization
		//2	Version : IfcLabel
		//3	ApplicationFullName : IfcLabel
		//4	ApplicationIdentifier : IfcIdentifier

		public IfcOrganization ApplicationDeveloper { get; set; }
		public IfcLabel Version { get; set; }
		public IfcLabel ApplicationFullName { get; set; }
		public IfcIdentifier ApplicationIdentifier { get; set; }

		public IfcApplication() { }

		public IfcApplication(IfcOrganization ApplicationDeveloper, IfcLabel Version, IfcLabel ApplicationFullName, IfcIdentifier ApplicationIdentifier)
		{
			this.ApplicationDeveloper = ApplicationDeveloper;
			this.Version = Version;
			this.ApplicationFullName = ApplicationFullName;
			this.ApplicationIdentifier = ApplicationIdentifier;
		}
	}

	public class IfcAppliedValue : IfcBase, IfcMetricValueSelect, IfcObjectReferenceSelect, IfcResourceObjectSelect
	{
		//1	Name : IfcLabel
		//2	Description : IfcText
		//3	AppliedValue : IfcAppliedValueSelect
		//4	UnitBasis : IfcMeasureWithUnit
		//5	ApplicableDate : IfcDate
		//6	FixedUntilDate : IfcDate
		//7	Category : IfcLabel
		//8	Condition : IfcLabel
		//9	ArithmeticOperator : IfcArithmeticOperatorEnum
		//10	Components : List<IfcAppliedValue>

		public IfcLabel Name { get; set; }
		public IfcText Description { get; set; }
		public IfcAppliedValueSelect AppliedValue { get; set; }
		public IfcMeasureWithUnit UnitBasis { get; set; }
		public IfcDate ApplicableDate { get; set; }
		public IfcDate FixedUntilDate { get; set; }
		public IfcLabel Category { get; set; }
		public IfcLabel Condition { get; set; }
		public IfcArithmeticOperatorEnum ArithmeticOperator { get; set; }
		public List<IfcAppliedValue> Components { get; set; }
		public List<IfcExternalReferenceRelationship> HasExternalReference { get; set; }

		public IfcAppliedValue() { }

		public IfcAppliedValue(IfcLabel Name, IfcText Description, IfcAppliedValueSelect AppliedValue, IfcMeasureWithUnit UnitBasis, IfcDate ApplicableDate, IfcDate FixedUntilDate, IfcLabel Category, IfcLabel Condition, IfcArithmeticOperatorEnum ArithmeticOperator, List<IfcAppliedValue> Components)
		{
			this.Name = Name;
			this.Description = Description;
			this.AppliedValue = AppliedValue;
			this.UnitBasis = UnitBasis;
			this.ApplicableDate = ApplicableDate;
			this.FixedUntilDate = FixedUntilDate;
			this.Category = Category;
			this.Condition = Condition;
			this.ArithmeticOperator = ArithmeticOperator;
			this.Components = Components;
		}
	}

	public class IfcApproval : IfcBase
	{
		//1	Identifier : IfcIdentifier
		//2	Name : IfcLabel
		//3	Description : IfcText
		//4	TimeOfApproval : IfcDateTime
		//5	Status : IfcLabel
		//6	Level : IfcLabel
		//7	Qualifier : IfcText
		//8	RequestingApproval : IfcActorSelect
		//9	GivingApproval : IfcActorSelect

		public IfcIdentifier Identifier { get; set; }
		public IfcLabel Name { get; set; }
		public IfcText Description { get; set; }
		public IfcDateTime TimeOfApproval { get; set; }
		public IfcLabel Status { get; set; }
		public IfcLabel Level { get; set; }
		public IfcText Qualifier { get; set; }
		public IfcActorSelect RequestingApproval { get; set; }
		public IfcActorSelect GivingApproval { get; set; }
		public List<IfcExternalReferenceRelationship> HasExternalReferences { get; set; }
		public List<IfcRelAssociatesApproval> ApprovedObjects { get; set; }
		public List<IfcResourceApprovalRelationship> ApprovedResources { get; set; }
		public List<IfcApprovalRelationship> IsRelatedWith { get; set; }
		public List<IfcApprovalRelationship> Relates { get; set; }

		public IfcApproval() { }

		public IfcApproval(IfcIdentifier Identifier, IfcLabel Name, IfcText Description, IfcDateTime TimeOfApproval, IfcLabel Status, IfcLabel Level, IfcText Qualifier, IfcActorSelect RequestingApproval, IfcActorSelect GivingApproval)
		{
			this.Identifier = Identifier;
			this.Name = Name;
			this.Description = Description;
			this.TimeOfApproval = TimeOfApproval;
			this.Status = Status;
			this.Level = Level;
			this.Qualifier = Qualifier;
			this.RequestingApproval = RequestingApproval;
			this.GivingApproval = GivingApproval;
		}
	}

	public class IfcApprovalRelationship : IfcResourceLevelRelationship
	{
		//1	Name : IfcLabel
		//2	Description : IfcText
		//3	RelatingApproval : IfcApproval
		//4	RelatedApprovals : List<IfcApproval>

		public IfcApproval RelatingApproval { get; set; }
		public List<IfcApproval> RelatedApprovals { get; set; }

		public IfcApprovalRelationship() { }

		public IfcApprovalRelationship(IfcLabel Name, IfcText Description, IfcApproval RelatingApproval, List<IfcApproval> RelatedApprovals)
		{
			this.Name = Name;
			this.Description = Description;
			this.RelatingApproval = RelatingApproval;
			this.RelatedApprovals = RelatedApprovals;
		}
	}

	public class IfcArbitraryClosedProfileDef : IfcProfileDef
	{
		//1	ProfileType : IfcProfileTypeEnum
		//2	ProfileName : IfcLabel
		//3	OuterCurve : IfcCurve

		public IfcCurve OuterCurve { get; set; }

		public IfcArbitraryClosedProfileDef() { }

		public IfcArbitraryClosedProfileDef(IfcProfileTypeEnum ProfileType, IfcLabel ProfileName, IfcCurve OuterCurve)
		{
			this.ProfileType = ProfileType;
			this.ProfileName = ProfileName;
			this.OuterCurve = OuterCurve;
		}
	}

	public class IfcArbitraryOpenProfileDef : IfcProfileDef
	{
		//1	ProfileType : IfcProfileTypeEnum
		//2	ProfileName : IfcLabel
		//3	Curve : IfcBoundedCurve

		public IfcBoundedCurve Curve { get; set; }

		public IfcArbitraryOpenProfileDef() { }

		public IfcArbitraryOpenProfileDef(IfcProfileTypeEnum ProfileType, IfcLabel ProfileName, IfcBoundedCurve Curve)
		{
			this.ProfileType = ProfileType;
			this.ProfileName = ProfileName;
			this.Curve = Curve;
		}
	}

	public class IfcArbitraryProfileDefWithVoids : IfcArbitraryClosedProfileDef
	{
		//1	ProfileType : IfcProfileTypeEnum
		//2	ProfileName : IfcLabel
		//3	OuterCurve : IfcCurve
		//4	InnerCurves : List<IfcCurve>

		public List<IfcCurve> InnerCurves { get; set; }

		public IfcArbitraryProfileDefWithVoids() { }

		public IfcArbitraryProfileDefWithVoids(IfcProfileTypeEnum ProfileType, IfcLabel ProfileName, IfcCurve OuterCurve, List<IfcCurve> InnerCurves)
		{
			this.ProfileType = ProfileType;
			this.ProfileName = ProfileName;
			this.OuterCurve = OuterCurve;
			this.InnerCurves = InnerCurves;
		}
	}

	public class IfcAsset : IfcGroup
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	Identification : IfcIdentifier
		//7	OriginalValue : IfcCostValue
		//8	CurrentValue : IfcCostValue
		//9	TotalReplacementCost : IfcCostValue
		//10	Owner : IfcActorSelect
		//11	User : IfcActorSelect
		//12	ResponsiblePerson : IfcPerson
		//13	IncorporationDate : IfcDate
		//14	DepreciatedValue : IfcCostValue

		public IfcIdentifier Identification { get; set; }
		public IfcCostValue OriginalValue { get; set; }
		public IfcCostValue CurrentValue { get; set; }
		public IfcCostValue TotalReplacementCost { get; set; }
		public IfcActorSelect Owner { get; set; }
		public IfcActorSelect User { get; set; }
		public IfcPerson ResponsiblePerson { get; set; }
		public IfcDate IncorporationDate { get; set; }
		public IfcCostValue DepreciatedValue { get; set; }

		public IfcAsset() { }

		public IfcAsset(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcIdentifier Identification, IfcCostValue OriginalValue, IfcCostValue CurrentValue, IfcCostValue TotalReplacementCost, IfcActorSelect Owner, IfcActorSelect User, IfcPerson ResponsiblePerson, IfcDate IncorporationDate, IfcCostValue DepreciatedValue)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.Identification = Identification;
			this.OriginalValue = OriginalValue;
			this.CurrentValue = CurrentValue;
			this.TotalReplacementCost = TotalReplacementCost;
			this.Owner = Owner;
			this.User = User;
			this.ResponsiblePerson = ResponsiblePerson;
			this.IncorporationDate = IncorporationDate;
			this.DepreciatedValue = DepreciatedValue;
		}
	}

	public class IfcAsymmetricIShapeProfileDef : IfcParameterizedProfileDef
	{
		//1	ProfileType : IfcProfileTypeEnum
		//2	ProfileName : IfcLabel
		//3	Position : IfcAxis2Placement2D
		//4	BottomFlangeWidth : IfcPositiveLengthMeasure
		//5	OverallDepth : IfcPositiveLengthMeasure
		//6	WebThickness : IfcPositiveLengthMeasure
		//7	BottomFlangeThickness : IfcPositiveLengthMeasure
		//8	BottomFlangeFilletRadius : IfcNonNegativeLengthMeasure
		//9	TopFlangeWidth : IfcPositiveLengthMeasure
		//10	TopFlangeThickness : IfcPositiveLengthMeasure
		//11	TopFlangeFilletRadius : IfcNonNegativeLengthMeasure
		//12	BottomFlangeEdgeRadius : IfcNonNegativeLengthMeasure
		//13	BottomFlangeSlope : IfcPlaneAngleMeasure
		//14	TopFlangeEdgeRadius : IfcNonNegativeLengthMeasure
		//15	TopFlangeSlope : IfcPlaneAngleMeasure

		public IfcPositiveLengthMeasure BottomFlangeWidth { get; set; }
		public IfcPositiveLengthMeasure OverallDepth { get; set; }
		public IfcPositiveLengthMeasure WebThickness { get; set; }
		public IfcPositiveLengthMeasure BottomFlangeThickness { get; set; }
		public IfcNonNegativeLengthMeasure BottomFlangeFilletRadius { get; set; }
		public IfcPositiveLengthMeasure TopFlangeWidth { get; set; }
		public IfcPositiveLengthMeasure TopFlangeThickness { get; set; }
		public IfcNonNegativeLengthMeasure TopFlangeFilletRadius { get; set; }
		public IfcNonNegativeLengthMeasure BottomFlangeEdgeRadius { get; set; }
		public IfcPlaneAngleMeasure BottomFlangeSlope { get; set; }
		public IfcNonNegativeLengthMeasure TopFlangeEdgeRadius { get; set; }
		public IfcPlaneAngleMeasure TopFlangeSlope { get; set; }

		public IfcAsymmetricIShapeProfileDef() { }

		public IfcAsymmetricIShapeProfileDef(IfcProfileTypeEnum ProfileType, IfcLabel ProfileName, IfcAxis2Placement2D Position, IfcPositiveLengthMeasure BottomFlangeWidth, IfcPositiveLengthMeasure OverallDepth, IfcPositiveLengthMeasure WebThickness, IfcPositiveLengthMeasure BottomFlangeThickness, IfcNonNegativeLengthMeasure BottomFlangeFilletRadius, IfcPositiveLengthMeasure TopFlangeWidth, IfcPositiveLengthMeasure TopFlangeThickness, IfcNonNegativeLengthMeasure TopFlangeFilletRadius, IfcNonNegativeLengthMeasure BottomFlangeEdgeRadius, IfcPlaneAngleMeasure BottomFlangeSlope, IfcNonNegativeLengthMeasure TopFlangeEdgeRadius, IfcPlaneAngleMeasure TopFlangeSlope)
		{
			this.ProfileType = ProfileType;
			this.ProfileName = ProfileName;
			this.Position = Position;
			this.BottomFlangeWidth = BottomFlangeWidth;
			this.OverallDepth = OverallDepth;
			this.WebThickness = WebThickness;
			this.BottomFlangeThickness = BottomFlangeThickness;
			this.BottomFlangeFilletRadius = BottomFlangeFilletRadius;
			this.TopFlangeWidth = TopFlangeWidth;
			this.TopFlangeThickness = TopFlangeThickness;
			this.TopFlangeFilletRadius = TopFlangeFilletRadius;
			this.BottomFlangeEdgeRadius = BottomFlangeEdgeRadius;
			this.BottomFlangeSlope = BottomFlangeSlope;
			this.TopFlangeEdgeRadius = TopFlangeEdgeRadius;
			this.TopFlangeSlope = TopFlangeSlope;
		}
	}

	public class IfcAudioVisualAppliance : IfcFlowTerminal
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	PredefinedType : IfcAudioVisualApplianceTypeEnum

		public IfcAudioVisualApplianceTypeEnum PredefinedType { get; set; }

		public IfcAudioVisualAppliance() { }

		public IfcAudioVisualAppliance(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcAudioVisualApplianceTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcAudioVisualApplianceType : IfcFlowTerminalType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel
		//10	PredefinedType : IfcAudioVisualApplianceTypeEnum

		public IfcAudioVisualApplianceTypeEnum PredefinedType { get; set; }

		public IfcAudioVisualApplianceType() { }

		public IfcAudioVisualApplianceType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType, IfcAudioVisualApplianceTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcAxis1Placement : IfcPlacement
	{
		//1	Location : IfcCartesianPoint
		//2	Axis : IfcDirection

		public IfcDirection Axis { get; set; }
		public IfcDirection Z { get; set; }

		public IfcAxis1Placement() { }

		public IfcAxis1Placement(IfcCartesianPoint Location, IfcDirection Axis)
		{
			this.Location = Location;
			this.Axis = Axis;
		}
	}

	public class IfcAxis2Placement2D : IfcPlacement, IfcAxis2Placement
	{
		//1	Location : IfcCartesianPoint
		//2	RefDirection : IfcDirection

		public IfcDirection RefDirection { get; set; }
		public List<IfcDirection> P { get; set; }
		public IfcDirection GetRefDirection() { return RefDirection; }
		public List<IfcDirection> GetP() { return P; }

		public IfcAxis2Placement2D() { }

		public IfcAxis2Placement2D(IfcCartesianPoint Location, IfcDirection RefDirection)
		{
			this.Location = Location;
			this.RefDirection = RefDirection;
		}
	}

	public class IfcAxis2Placement3D : IfcPlacement, IfcAxis2Placement
	{
		//1	Location : IfcCartesianPoint
		//2	Axis : IfcDirection
		//3	RefDirection : IfcDirection

		public IfcDirection Axis { get; set; }
		public IfcDirection RefDirection { get; set; }
		public List<IfcDirection> P { get; set; }
		public IfcDirection GetRefDirection() { return RefDirection; }
		public List<IfcDirection> GetP() { return P; }

		public IfcAxis2Placement3D() { }

		public IfcAxis2Placement3D(IfcCartesianPoint Location, IfcDirection Axis, IfcDirection RefDirection)
		{
			this.Location = Location;
			this.Axis = Axis;
			this.RefDirection = RefDirection;
		}
	}

	public abstract class IfcBSplineCurve : IfcBoundedCurve
	{
		//1	Degree : IfcInteger
		//2	ControlPointsList : List<IfcCartesianPoint>
		//3	CurveForm : IfcBSplineCurveForm
		//4	ClosedCurve : IfcLogical
		//5	SelfIntersect : IfcLogical

		public IfcInteger Degree { get; set; }
		public List<IfcCartesianPoint> ControlPointsList { get; set; }
		public IfcBSplineCurveForm CurveForm { get; set; }
		public IfcLogical ClosedCurve { get; set; }
		public IfcLogical SelfIntersect { get; set; }
		public IfcInteger UpperIndexOnControlPoints { get; set; }
		public List<IfcCartesianPoint> ControlPoints { get; set; }

		public IfcBSplineCurve() { }

		public IfcBSplineCurve(IfcInteger Degree, List<IfcCartesianPoint> ControlPointsList, IfcBSplineCurveForm CurveForm, IfcLogical ClosedCurve, IfcLogical SelfIntersect)
		{
			this.Degree = Degree;
			this.ControlPointsList = ControlPointsList;
			this.CurveForm = CurveForm;
			this.ClosedCurve = ClosedCurve;
			this.SelfIntersect = SelfIntersect;
		}
	}

	public class IfcBSplineCurveWithKnots : IfcBSplineCurve
	{
		//1	Degree : IfcInteger
		//2	ControlPointsList : List<IfcCartesianPoint>
		//3	CurveForm : IfcBSplineCurveForm
		//4	ClosedCurve : IfcLogical
		//5	SelfIntersect : IfcLogical
		//6	KnotMultiplicities : List<IfcInteger>
		//7	Knots : List<IfcParameterValue>
		//8	KnotSpec : IfcKnotType

		public List<IfcInteger> KnotMultiplicities { get; set; }
		public List<IfcParameterValue> Knots { get; set; }
		public IfcKnotType KnotSpec { get; set; }
		public IfcInteger UpperIndexOnKnots { get; set; }

		public IfcBSplineCurveWithKnots() { }

		public IfcBSplineCurveWithKnots(IfcInteger Degree, List<IfcCartesianPoint> ControlPointsList, IfcBSplineCurveForm CurveForm, IfcLogical ClosedCurve, IfcLogical SelfIntersect, List<IfcInteger> KnotMultiplicities, List<IfcParameterValue> Knots, IfcKnotType KnotSpec)
		{
			this.Degree = Degree;
			this.ControlPointsList = ControlPointsList;
			this.CurveForm = CurveForm;
			this.ClosedCurve = ClosedCurve;
			this.SelfIntersect = SelfIntersect;
			this.KnotMultiplicities = KnotMultiplicities;
			this.Knots = Knots;
			this.KnotSpec = KnotSpec;
		}
	}

	public abstract class IfcBSplineSurface : IfcBoundedSurface
	{
		//1	UDegree : IfcInteger
		//2	VDegree : IfcInteger
		//3	ControlPointsList : List<List<IfcCartesianPoint>>
		//4	SurfaceForm : IfcBSplineSurfaceForm
		//5	UClosed : IfcLogical
		//6	VClosed : IfcLogical
		//7	SelfIntersect : IfcLogical

		public IfcInteger UDegree { get; set; }
		public IfcInteger VDegree { get; set; }
		public List<List<IfcCartesianPoint>> ControlPointsList { get; set; }
		public IfcBSplineSurfaceForm SurfaceForm { get; set; }
		public IfcLogical UClosed { get; set; }
		public IfcLogical VClosed { get; set; }
		public IfcLogical SelfIntersect { get; set; }
		public IfcInteger UUpper { get; set; }
		public IfcInteger VUpper { get; set; }
		public List<List<IfcCartesianPoint>> ControlPoints { get; set; }

		public IfcBSplineSurface() { }

		public IfcBSplineSurface(IfcInteger UDegree, IfcInteger VDegree, List<List<IfcCartesianPoint>> ControlPointsList, IfcBSplineSurfaceForm SurfaceForm, IfcLogical UClosed, IfcLogical VClosed, IfcLogical SelfIntersect)
		{
			this.UDegree = UDegree;
			this.VDegree = VDegree;
			this.ControlPointsList = ControlPointsList;
			this.SurfaceForm = SurfaceForm;
			this.UClosed = UClosed;
			this.VClosed = VClosed;
			this.SelfIntersect = SelfIntersect;
		}
	}

	public class IfcBSplineSurfaceWithKnots : IfcBSplineSurface
	{
		//1	UDegree : IfcInteger
		//2	VDegree : IfcInteger
		//3	ControlPointsList : List<List<IfcCartesianPoint>>
		//4	SurfaceForm : IfcBSplineSurfaceForm
		//5	UClosed : IfcLogical
		//6	VClosed : IfcLogical
		//7	SelfIntersect : IfcLogical
		//8	UMultiplicities : List<IfcInteger>
		//9	VMultiplicities : List<IfcInteger>
		//10	UKnots : List<IfcParameterValue>
		//11	VKnots : List<IfcParameterValue>
		//12	KnotSpec : IfcKnotType

		public List<IfcInteger> UMultiplicities { get; set; }
		public List<IfcInteger> VMultiplicities { get; set; }
		public List<IfcParameterValue> UKnots { get; set; }
		public List<IfcParameterValue> VKnots { get; set; }
		public IfcKnotType KnotSpec { get; set; }
		public IfcInteger KnotVUpper { get; set; }
		public IfcInteger KnotUUpper { get; set; }

		public IfcBSplineSurfaceWithKnots() { }

		public IfcBSplineSurfaceWithKnots(IfcInteger UDegree, IfcInteger VDegree, List<List<IfcCartesianPoint>> ControlPointsList, IfcBSplineSurfaceForm SurfaceForm, IfcLogical UClosed, IfcLogical VClosed, IfcLogical SelfIntersect, List<IfcInteger> UMultiplicities, List<IfcInteger> VMultiplicities, List<IfcParameterValue> UKnots, List<IfcParameterValue> VKnots, IfcKnotType KnotSpec)
		{
			this.UDegree = UDegree;
			this.VDegree = VDegree;
			this.ControlPointsList = ControlPointsList;
			this.SurfaceForm = SurfaceForm;
			this.UClosed = UClosed;
			this.VClosed = VClosed;
			this.SelfIntersect = SelfIntersect;
			this.UMultiplicities = UMultiplicities;
			this.VMultiplicities = VMultiplicities;
			this.UKnots = UKnots;
			this.VKnots = VKnots;
			this.KnotSpec = KnotSpec;
		}
	}

	public class IfcBeam : IfcBuildingElement
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	PredefinedType : IfcBeamTypeEnum

		public IfcBeamTypeEnum PredefinedType { get; set; }

		public IfcBeam() { }

		public IfcBeam(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcBeamTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcBeamStandardCase : IfcBeam
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	PredefinedType : IfcBeamTypeEnum

		public IfcBeamStandardCase() { }

		public IfcBeamStandardCase(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcBeamTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcBeamType : IfcBuildingElementType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel
		//10	PredefinedType : IfcBeamTypeEnum

		public IfcBeamTypeEnum PredefinedType { get; set; }

		public IfcBeamType() { }

		public IfcBeamType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType, IfcBeamTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcBlobTexture : IfcSurfaceTexture
	{
		//1	RepeatS : IfcBoolean
		//2	RepeatT : IfcBoolean
		//3	Mode : IfcIdentifier
		//4	TextureTransform : IfcCartesianTransformationOperator2D
		//5	Parameter : List<IfcIdentifier>
		//6	RasterFormat : IfcIdentifier
		//7	RasterCode : IfcBinary

		public IfcIdentifier RasterFormat { get; set; }
		public IfcBinary RasterCode { get; set; }

		public IfcBlobTexture() { }

		public IfcBlobTexture(IfcBoolean RepeatS, IfcBoolean RepeatT, IfcIdentifier Mode, IfcCartesianTransformationOperator2D TextureTransform, List<IfcIdentifier> Parameter, IfcIdentifier RasterFormat, IfcBinary RasterCode)
		{
			this.RepeatS = RepeatS;
			this.RepeatT = RepeatT;
			this.Mode = Mode;
			this.TextureTransform = TextureTransform;
			this.Parameter = Parameter;
			this.RasterFormat = RasterFormat;
			this.RasterCode = RasterCode;
		}
	}

	public class IfcBlock : IfcCsgPrimitive3D
	{
		//1	Position : IfcAxis2Placement3D
		//2	XLength : IfcPositiveLengthMeasure
		//3	YLength : IfcPositiveLengthMeasure
		//4	ZLength : IfcPositiveLengthMeasure

		public IfcPositiveLengthMeasure XLength { get; set; }
		public IfcPositiveLengthMeasure YLength { get; set; }
		public IfcPositiveLengthMeasure ZLength { get; set; }

		public IfcBlock() { }

		public IfcBlock(IfcAxis2Placement3D Position, IfcPositiveLengthMeasure XLength, IfcPositiveLengthMeasure YLength, IfcPositiveLengthMeasure ZLength)
		{
			this.Position = Position;
			this.XLength = XLength;
			this.YLength = YLength;
			this.ZLength = ZLength;
		}
	}

	public class IfcBoiler : IfcEnergyConversionDevice
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	PredefinedType : IfcBoilerTypeEnum

		public IfcBoilerTypeEnum PredefinedType { get; set; }

		public IfcBoiler() { }

		public IfcBoiler(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcBoilerTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcBoilerType : IfcEnergyConversionDeviceType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel
		//10	PredefinedType : IfcBoilerTypeEnum

		public IfcBoilerTypeEnum PredefinedType { get; set; }

		public IfcBoilerType() { }

		public IfcBoilerType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType, IfcBoilerTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcBooleanClippingResult : IfcBooleanResult
	{
		//1	Operator : IfcBooleanOperator
		//2	FirstOperand : IfcBooleanOperand
		//3	SecondOperand : IfcBooleanOperand

		public IfcBooleanClippingResult() { }

		public IfcBooleanClippingResult(IfcBooleanOperator Operator, IfcBooleanOperand FirstOperand, IfcBooleanOperand SecondOperand)
		{
			this.Operator = Operator;
			this.FirstOperand = FirstOperand;
			this.SecondOperand = SecondOperand;
		}
	}

	public class IfcBooleanResult : IfcGeometricRepresentationItem, IfcBooleanOperand, IfcCsgSelect
	{
		//1	Operator : IfcBooleanOperator
		//2	FirstOperand : IfcBooleanOperand
		//3	SecondOperand : IfcBooleanOperand

		public IfcBooleanOperator Operator { get; set; }
		public IfcBooleanOperand FirstOperand { get; set; }
		public IfcBooleanOperand SecondOperand { get; set; }
		public IfcDimensionCount Dim { get; set; }
		public IfcDimensionCount GetDim() { return Dim; }

		public IfcBooleanResult() { }

		public IfcBooleanResult(IfcBooleanOperator Operator, IfcBooleanOperand FirstOperand, IfcBooleanOperand SecondOperand)
		{
			this.Operator = Operator;
			this.FirstOperand = FirstOperand;
			this.SecondOperand = SecondOperand;
		}
	}

	public abstract class IfcBoundaryCondition : IfcBase
	{
		//1	Name : IfcLabel

		public IfcLabel Name { get; set; }

		public IfcBoundaryCondition() { }

		public IfcBoundaryCondition(IfcLabel Name)
		{
			this.Name = Name;
		}
	}

	public class IfcBoundaryCurve : IfcCompositeCurveOnSurface
	{
		//1	Segments : List<IfcCompositeCurveSegment>
		//2	SelfIntersect : IfcLogical

		public IfcBoundaryCurve() { }

		public IfcBoundaryCurve(List<IfcCompositeCurveSegment> Segments, IfcLogical SelfIntersect)
		{
			this.Segments = Segments;
			this.SelfIntersect = SelfIntersect;
		}
	}

	public class IfcBoundaryEdgeCondition : IfcBoundaryCondition
	{
		//1	Name : IfcLabel
		//2	TranslationalStiffnessByLengthX : IfcModulusOfTranslationalSubgradeReactionSelect
		//3	TranslationalStiffnessByLengthY : IfcModulusOfTranslationalSubgradeReactionSelect
		//4	TranslationalStiffnessByLengthZ : IfcModulusOfTranslationalSubgradeReactionSelect
		//5	RotationalStiffnessByLengthX : IfcModulusOfRotationalSubgradeReactionSelect
		//6	RotationalStiffnessByLengthY : IfcModulusOfRotationalSubgradeReactionSelect
		//7	RotationalStiffnessByLengthZ : IfcModulusOfRotationalSubgradeReactionSelect

		public IfcModulusOfTranslationalSubgradeReactionSelect TranslationalStiffnessByLengthX { get; set; }
		public IfcModulusOfTranslationalSubgradeReactionSelect TranslationalStiffnessByLengthY { get; set; }
		public IfcModulusOfTranslationalSubgradeReactionSelect TranslationalStiffnessByLengthZ { get; set; }
		public IfcModulusOfRotationalSubgradeReactionSelect RotationalStiffnessByLengthX { get; set; }
		public IfcModulusOfRotationalSubgradeReactionSelect RotationalStiffnessByLengthY { get; set; }
		public IfcModulusOfRotationalSubgradeReactionSelect RotationalStiffnessByLengthZ { get; set; }

		public IfcBoundaryEdgeCondition() { }

		public IfcBoundaryEdgeCondition(IfcLabel Name, IfcModulusOfTranslationalSubgradeReactionSelect TranslationalStiffnessByLengthX, IfcModulusOfTranslationalSubgradeReactionSelect TranslationalStiffnessByLengthY, IfcModulusOfTranslationalSubgradeReactionSelect TranslationalStiffnessByLengthZ, IfcModulusOfRotationalSubgradeReactionSelect RotationalStiffnessByLengthX, IfcModulusOfRotationalSubgradeReactionSelect RotationalStiffnessByLengthY, IfcModulusOfRotationalSubgradeReactionSelect RotationalStiffnessByLengthZ)
		{
			this.Name = Name;
			this.TranslationalStiffnessByLengthX = TranslationalStiffnessByLengthX;
			this.TranslationalStiffnessByLengthY = TranslationalStiffnessByLengthY;
			this.TranslationalStiffnessByLengthZ = TranslationalStiffnessByLengthZ;
			this.RotationalStiffnessByLengthX = RotationalStiffnessByLengthX;
			this.RotationalStiffnessByLengthY = RotationalStiffnessByLengthY;
			this.RotationalStiffnessByLengthZ = RotationalStiffnessByLengthZ;
		}
	}

	public class IfcBoundaryFaceCondition : IfcBoundaryCondition
	{
		//1	Name : IfcLabel
		//2	TranslationalStiffnessByAreaX : IfcModulusOfSubgradeReactionSelect
		//3	TranslationalStiffnessByAreaY : IfcModulusOfSubgradeReactionSelect
		//4	TranslationalStiffnessByAreaZ : IfcModulusOfSubgradeReactionSelect

		public IfcModulusOfSubgradeReactionSelect TranslationalStiffnessByAreaX { get; set; }
		public IfcModulusOfSubgradeReactionSelect TranslationalStiffnessByAreaY { get; set; }
		public IfcModulusOfSubgradeReactionSelect TranslationalStiffnessByAreaZ { get; set; }

		public IfcBoundaryFaceCondition() { }

		public IfcBoundaryFaceCondition(IfcLabel Name, IfcModulusOfSubgradeReactionSelect TranslationalStiffnessByAreaX, IfcModulusOfSubgradeReactionSelect TranslationalStiffnessByAreaY, IfcModulusOfSubgradeReactionSelect TranslationalStiffnessByAreaZ)
		{
			this.Name = Name;
			this.TranslationalStiffnessByAreaX = TranslationalStiffnessByAreaX;
			this.TranslationalStiffnessByAreaY = TranslationalStiffnessByAreaY;
			this.TranslationalStiffnessByAreaZ = TranslationalStiffnessByAreaZ;
		}
	}

	public class IfcBoundaryNodeCondition : IfcBoundaryCondition
	{
		//1	Name : IfcLabel
		//2	TranslationalStiffnessX : IfcTranslationalStiffnessSelect
		//3	TranslationalStiffnessY : IfcTranslationalStiffnessSelect
		//4	TranslationalStiffnessZ : IfcTranslationalStiffnessSelect
		//5	RotationalStiffnessX : IfcRotationalStiffnessSelect
		//6	RotationalStiffnessY : IfcRotationalStiffnessSelect
		//7	RotationalStiffnessZ : IfcRotationalStiffnessSelect

		public IfcTranslationalStiffnessSelect TranslationalStiffnessX { get; set; }
		public IfcTranslationalStiffnessSelect TranslationalStiffnessY { get; set; }
		public IfcTranslationalStiffnessSelect TranslationalStiffnessZ { get; set; }
		public IfcRotationalStiffnessSelect RotationalStiffnessX { get; set; }
		public IfcRotationalStiffnessSelect RotationalStiffnessY { get; set; }
		public IfcRotationalStiffnessSelect RotationalStiffnessZ { get; set; }

		public IfcBoundaryNodeCondition() { }

		public IfcBoundaryNodeCondition(IfcLabel Name, IfcTranslationalStiffnessSelect TranslationalStiffnessX, IfcTranslationalStiffnessSelect TranslationalStiffnessY, IfcTranslationalStiffnessSelect TranslationalStiffnessZ, IfcRotationalStiffnessSelect RotationalStiffnessX, IfcRotationalStiffnessSelect RotationalStiffnessY, IfcRotationalStiffnessSelect RotationalStiffnessZ)
		{
			this.Name = Name;
			this.TranslationalStiffnessX = TranslationalStiffnessX;
			this.TranslationalStiffnessY = TranslationalStiffnessY;
			this.TranslationalStiffnessZ = TranslationalStiffnessZ;
			this.RotationalStiffnessX = RotationalStiffnessX;
			this.RotationalStiffnessY = RotationalStiffnessY;
			this.RotationalStiffnessZ = RotationalStiffnessZ;
		}
	}

	public class IfcBoundaryNodeConditionWarping : IfcBoundaryNodeCondition
	{
		//1	Name : IfcLabel
		//2	TranslationalStiffnessX : IfcTranslationalStiffnessSelect
		//3	TranslationalStiffnessY : IfcTranslationalStiffnessSelect
		//4	TranslationalStiffnessZ : IfcTranslationalStiffnessSelect
		//5	RotationalStiffnessX : IfcRotationalStiffnessSelect
		//6	RotationalStiffnessY : IfcRotationalStiffnessSelect
		//7	RotationalStiffnessZ : IfcRotationalStiffnessSelect
		//8	WarpingStiffness : IfcWarpingStiffnessSelect

		public IfcWarpingStiffnessSelect WarpingStiffness { get; set; }

		public IfcBoundaryNodeConditionWarping() { }

		public IfcBoundaryNodeConditionWarping(IfcLabel Name, IfcTranslationalStiffnessSelect TranslationalStiffnessX, IfcTranslationalStiffnessSelect TranslationalStiffnessY, IfcTranslationalStiffnessSelect TranslationalStiffnessZ, IfcRotationalStiffnessSelect RotationalStiffnessX, IfcRotationalStiffnessSelect RotationalStiffnessY, IfcRotationalStiffnessSelect RotationalStiffnessZ, IfcWarpingStiffnessSelect WarpingStiffness)
		{
			this.Name = Name;
			this.TranslationalStiffnessX = TranslationalStiffnessX;
			this.TranslationalStiffnessY = TranslationalStiffnessY;
			this.TranslationalStiffnessZ = TranslationalStiffnessZ;
			this.RotationalStiffnessX = RotationalStiffnessX;
			this.RotationalStiffnessY = RotationalStiffnessY;
			this.RotationalStiffnessZ = RotationalStiffnessZ;
			this.WarpingStiffness = WarpingStiffness;
		}
	}

	public abstract class IfcBoundedCurve : IfcCurve, IfcCurveOrEdgeCurve
	{
		public IfcBoundedCurve() { }
	}

	public abstract class IfcBoundedSurface : IfcSurface
	{
		public IfcBoundedSurface() { }
	}

	public class IfcBoundingBox : IfcGeometricRepresentationItem
	{
		//1	Corner : IfcCartesianPoint
		//2	XDim : IfcPositiveLengthMeasure
		//3	YDim : IfcPositiveLengthMeasure
		//4	ZDim : IfcPositiveLengthMeasure

		public IfcCartesianPoint Corner { get; set; }
		public IfcPositiveLengthMeasure XDim { get; set; }
		public IfcPositiveLengthMeasure YDim { get; set; }
		public IfcPositiveLengthMeasure ZDim { get; set; }
		public IfcDimensionCount Dim { get; set; }

		public IfcBoundingBox() { }

		public IfcBoundingBox(IfcCartesianPoint Corner, IfcPositiveLengthMeasure XDim, IfcPositiveLengthMeasure YDim, IfcPositiveLengthMeasure ZDim)
		{
			this.Corner = Corner;
			this.XDim = XDim;
			this.YDim = YDim;
			this.ZDim = ZDim;
		}
	}

	public class IfcBoxedHalfSpace : IfcHalfSpaceSolid
	{
		//1	BaseSurface : IfcSurface
		//2	AgreementFlag : IfcBoolean
		//3	Enclosure : IfcBoundingBox

		public IfcBoundingBox Enclosure { get; set; }

		public IfcBoxedHalfSpace() { }

		public IfcBoxedHalfSpace(IfcSurface BaseSurface, IfcBoolean AgreementFlag, IfcBoundingBox Enclosure)
		{
			this.BaseSurface = BaseSurface;
			this.AgreementFlag = AgreementFlag;
			this.Enclosure = Enclosure;
		}
	}

	public class IfcBuilding : IfcSpatialStructureElement
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	LongName : IfcLabel
		//9	CompositionType : IfcElementCompositionEnum
		//10	ElevationOfRefHeight : IfcLengthMeasure
		//11	ElevationOfTerrain : IfcLengthMeasure
		//12	BuildingAddress : IfcPostalAddress

		public IfcLengthMeasure ElevationOfRefHeight { get; set; }
		public IfcLengthMeasure ElevationOfTerrain { get; set; }
		public IfcPostalAddress BuildingAddress { get; set; }

		public IfcBuilding() { }

		public IfcBuilding(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcLabel LongName, IfcElementCompositionEnum CompositionType, IfcLengthMeasure ElevationOfRefHeight, IfcLengthMeasure ElevationOfTerrain, IfcPostalAddress BuildingAddress)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.LongName = LongName;
			this.CompositionType = CompositionType;
			this.ElevationOfRefHeight = ElevationOfRefHeight;
			this.ElevationOfTerrain = ElevationOfTerrain;
			this.BuildingAddress = BuildingAddress;
		}
	}

	public abstract class IfcBuildingElement : IfcElement
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier

		public IfcBuildingElement() { }

		public IfcBuildingElement(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
		}
	}

	public class IfcBuildingElementPart : IfcElementComponent
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	PredefinedType : IfcBuildingElementPartTypeEnum

		public IfcBuildingElementPartTypeEnum PredefinedType { get; set; }

		public IfcBuildingElementPart() { }

		public IfcBuildingElementPart(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcBuildingElementPartTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcBuildingElementPartType : IfcElementComponentType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel
		//10	PredefinedType : IfcBuildingElementPartTypeEnum

		public IfcBuildingElementPartTypeEnum PredefinedType { get; set; }

		public IfcBuildingElementPartType() { }

		public IfcBuildingElementPartType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType, IfcBuildingElementPartTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcBuildingElementProxy : IfcBuildingElement
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	PredefinedType : IfcBuildingElementProxyTypeEnum

		public IfcBuildingElementProxyTypeEnum PredefinedType { get; set; }

		public IfcBuildingElementProxy() { }

		public IfcBuildingElementProxy(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcBuildingElementProxyTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcBuildingElementProxyType : IfcBuildingElementType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel
		//10	PredefinedType : IfcBuildingElementProxyTypeEnum

		public IfcBuildingElementProxyTypeEnum PredefinedType { get; set; }

		public IfcBuildingElementProxyType() { }

		public IfcBuildingElementProxyType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType, IfcBuildingElementProxyTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
			this.PredefinedType = PredefinedType;
		}
	}

	public abstract class IfcBuildingElementType : IfcElementType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel

		public IfcBuildingElementType() { }

		public IfcBuildingElementType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
		}
	}

	public class IfcBuildingStorey : IfcSpatialStructureElement
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	LongName : IfcLabel
		//9	CompositionType : IfcElementCompositionEnum
		//10	Elevation : IfcLengthMeasure

		public IfcLengthMeasure Elevation { get; set; }

		public IfcBuildingStorey() { }

		public IfcBuildingStorey(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcLabel LongName, IfcElementCompositionEnum CompositionType, IfcLengthMeasure Elevation)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.LongName = LongName;
			this.CompositionType = CompositionType;
			this.Elevation = Elevation;
		}
	}

	public class IfcBuildingSystem : IfcSystem
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	PredefinedType : IfcBuildingSystemTypeEnum
		//7	LongName : IfcLabel

		public IfcBuildingSystemTypeEnum PredefinedType { get; set; }
		public IfcLabel LongName { get; set; }

		public IfcBuildingSystem() { }

		public IfcBuildingSystem(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcBuildingSystemTypeEnum PredefinedType, IfcLabel LongName)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.PredefinedType = PredefinedType;
			this.LongName = LongName;
		}
	}

	public class IfcBurner : IfcEnergyConversionDevice
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	PredefinedType : IfcBurnerTypeEnum

		public IfcBurnerTypeEnum PredefinedType { get; set; }

		public IfcBurner() { }

		public IfcBurner(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcBurnerTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcBurnerType : IfcEnergyConversionDeviceType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel
		//10	PredefinedType : IfcBurnerTypeEnum

		public IfcBurnerTypeEnum PredefinedType { get; set; }

		public IfcBurnerType() { }

		public IfcBurnerType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType, IfcBurnerTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcCShapeProfileDef : IfcParameterizedProfileDef
	{
		//1	ProfileType : IfcProfileTypeEnum
		//2	ProfileName : IfcLabel
		//3	Position : IfcAxis2Placement2D
		//4	Depth : IfcPositiveLengthMeasure
		//5	Width : IfcPositiveLengthMeasure
		//6	WallThickness : IfcPositiveLengthMeasure
		//7	Girth : IfcPositiveLengthMeasure
		//8	InternalFilletRadius : IfcNonNegativeLengthMeasure

		public IfcPositiveLengthMeasure Depth { get; set; }
		public IfcPositiveLengthMeasure Width { get; set; }
		public IfcPositiveLengthMeasure WallThickness { get; set; }
		public IfcPositiveLengthMeasure Girth { get; set; }
		public IfcNonNegativeLengthMeasure InternalFilletRadius { get; set; }

		public IfcCShapeProfileDef() { }

		public IfcCShapeProfileDef(IfcProfileTypeEnum ProfileType, IfcLabel ProfileName, IfcAxis2Placement2D Position, IfcPositiveLengthMeasure Depth, IfcPositiveLengthMeasure Width, IfcPositiveLengthMeasure WallThickness, IfcPositiveLengthMeasure Girth, IfcNonNegativeLengthMeasure InternalFilletRadius)
		{
			this.ProfileType = ProfileType;
			this.ProfileName = ProfileName;
			this.Position = Position;
			this.Depth = Depth;
			this.Width = Width;
			this.WallThickness = WallThickness;
			this.Girth = Girth;
			this.InternalFilletRadius = InternalFilletRadius;
		}
	}

	public class IfcCableCarrierFitting : IfcFlowFitting
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	PredefinedType : IfcCableCarrierFittingTypeEnum

		public IfcCableCarrierFittingTypeEnum PredefinedType { get; set; }

		public IfcCableCarrierFitting() { }

		public IfcCableCarrierFitting(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcCableCarrierFittingTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcCableCarrierFittingType : IfcFlowFittingType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel
		//10	PredefinedType : IfcCableCarrierFittingTypeEnum

		public IfcCableCarrierFittingTypeEnum PredefinedType { get; set; }

		public IfcCableCarrierFittingType() { }

		public IfcCableCarrierFittingType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType, IfcCableCarrierFittingTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcCableCarrierSegment : IfcFlowSegment
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	PredefinedType : IfcCableCarrierSegmentTypeEnum

		public IfcCableCarrierSegmentTypeEnum PredefinedType { get; set; }

		public IfcCableCarrierSegment() { }

		public IfcCableCarrierSegment(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcCableCarrierSegmentTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcCableCarrierSegmentType : IfcFlowSegmentType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel
		//10	PredefinedType : IfcCableCarrierSegmentTypeEnum

		public IfcCableCarrierSegmentTypeEnum PredefinedType { get; set; }

		public IfcCableCarrierSegmentType() { }

		public IfcCableCarrierSegmentType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType, IfcCableCarrierSegmentTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcCableFitting : IfcFlowFitting
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	PredefinedType : IfcCableFittingTypeEnum

		public IfcCableFittingTypeEnum PredefinedType { get; set; }

		public IfcCableFitting() { }

		public IfcCableFitting(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcCableFittingTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcCableFittingType : IfcFlowFittingType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel
		//10	PredefinedType : IfcCableFittingTypeEnum

		public IfcCableFittingTypeEnum PredefinedType { get; set; }

		public IfcCableFittingType() { }

		public IfcCableFittingType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType, IfcCableFittingTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcCableSegment : IfcFlowSegment
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	PredefinedType : IfcCableSegmentTypeEnum

		public IfcCableSegmentTypeEnum PredefinedType { get; set; }

		public IfcCableSegment() { }

		public IfcCableSegment(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcCableSegmentTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcCableSegmentType : IfcFlowSegmentType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel
		//10	PredefinedType : IfcCableSegmentTypeEnum

		public IfcCableSegmentTypeEnum PredefinedType { get; set; }

		public IfcCableSegmentType() { }

		public IfcCableSegmentType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType, IfcCableSegmentTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcCartesianPoint : IfcPoint, IfcTrimmingSelect
	{
		//1	Coordinates : List<IfcLengthMeasure>

		public List<IfcLengthMeasure> Coordinates { get; set; }
		public IfcDimensionCount Dim { get; set; }

		public IfcCartesianPoint() { }

		public IfcCartesianPoint(List<IfcLengthMeasure> Coordinates)
		{
			this.Coordinates = Coordinates;
		}
	}

	public abstract class IfcCartesianPointList : IfcGeometricRepresentationItem
	{
		public IfcDimensionCount Dim { get; set; }

		public IfcCartesianPointList() { }
	}

	public class IfcCartesianPointList2D : IfcCartesianPointList
	{
		//1	CoordList : List<List<IfcLengthMeasure>>

		public List<List<IfcLengthMeasure>> CoordList { get; set; }

		public IfcCartesianPointList2D() { }

		public IfcCartesianPointList2D(List<List<IfcLengthMeasure>> CoordList)
		{
			this.CoordList = CoordList;
		}
	}

	public class IfcCartesianPointList3D : IfcCartesianPointList
	{
		//1	CoordList : List<List<IfcLengthMeasure>>

		public List<List<IfcLengthMeasure>> CoordList { get; set; }

		public IfcCartesianPointList3D() { }

		public IfcCartesianPointList3D(List<List<IfcLengthMeasure>> CoordList)
		{
			this.CoordList = CoordList;
		}
	}

	public abstract class IfcCartesianTransformationOperator : IfcGeometricRepresentationItem
	{
		//1	Axis1 : IfcDirection
		//2	Axis2 : IfcDirection
		//3	LocalOrigin : IfcCartesianPoint
		//4	Scale : IfcReal

		public IfcDirection Axis1 { get; set; }
		public IfcDirection Axis2 { get; set; }
		public IfcCartesianPoint LocalOrigin { get; set; }
		public IfcReal Scale { get; set; }
		public IfcReal Scl { get; set; }
		public IfcDimensionCount Dim { get; set; }

		public IfcCartesianTransformationOperator() { }

		public IfcCartesianTransformationOperator(IfcDirection Axis1, IfcDirection Axis2, IfcCartesianPoint LocalOrigin, IfcReal Scale)
		{
			this.Axis1 = Axis1;
			this.Axis2 = Axis2;
			this.LocalOrigin = LocalOrigin;
			this.Scale = Scale;
		}
	}

	public class IfcCartesianTransformationOperator2D : IfcCartesianTransformationOperator
	{
		//1	Axis1 : IfcDirection
		//2	Axis2 : IfcDirection
		//3	LocalOrigin : IfcCartesianPoint
		//4	Scale : IfcReal

		public List<IfcDirection> U { get; set; }

		public IfcCartesianTransformationOperator2D() { }

		public IfcCartesianTransformationOperator2D(IfcDirection Axis1, IfcDirection Axis2, IfcCartesianPoint LocalOrigin, IfcReal Scale)
		{
			this.Axis1 = Axis1;
			this.Axis2 = Axis2;
			this.LocalOrigin = LocalOrigin;
			this.Scale = Scale;
		}
	}

	public class IfcCartesianTransformationOperator2DnonUniform : IfcCartesianTransformationOperator2D
	{
		//1	Axis1 : IfcDirection
		//2	Axis2 : IfcDirection
		//3	LocalOrigin : IfcCartesianPoint
		//4	Scale : IfcReal
		//5	Scale2 : IfcReal

		public IfcReal Scale2 { get; set; }
		public IfcReal Scl2 { get; set; }

		public IfcCartesianTransformationOperator2DnonUniform() { }

		public IfcCartesianTransformationOperator2DnonUniform(IfcDirection Axis1, IfcDirection Axis2, IfcCartesianPoint LocalOrigin, IfcReal Scale, IfcReal Scale2)
		{
			this.Axis1 = Axis1;
			this.Axis2 = Axis2;
			this.LocalOrigin = LocalOrigin;
			this.Scale = Scale;
			this.Scale2 = Scale2;
		}
	}

	public class IfcCartesianTransformationOperator3D : IfcCartesianTransformationOperator
	{
		//1	Axis1 : IfcDirection
		//2	Axis2 : IfcDirection
		//3	LocalOrigin : IfcCartesianPoint
		//4	Scale : IfcReal
		//5	Axis3 : IfcDirection

		public IfcDirection Axis3 { get; set; }
		public List<IfcDirection> U { get; set; }

		public IfcCartesianTransformationOperator3D() { }

		public IfcCartesianTransformationOperator3D(IfcDirection Axis1, IfcDirection Axis2, IfcCartesianPoint LocalOrigin, IfcReal Scale, IfcDirection Axis3)
		{
			this.Axis1 = Axis1;
			this.Axis2 = Axis2;
			this.LocalOrigin = LocalOrigin;
			this.Scale = Scale;
			this.Axis3 = Axis3;
		}
	}

	public class IfcCartesianTransformationOperator3DnonUniform : IfcCartesianTransformationOperator3D
	{
		//1	Axis1 : IfcDirection
		//2	Axis2 : IfcDirection
		//3	LocalOrigin : IfcCartesianPoint
		//4	Scale : IfcReal
		//5	Axis3 : IfcDirection
		//6	Scale2 : IfcReal
		//7	Scale3 : IfcReal

		public IfcReal Scale2 { get; set; }
		public IfcReal Scale3 { get; set; }
		public IfcReal Scl2 { get; set; }
		public IfcReal Scl3 { get; set; }

		public IfcCartesianTransformationOperator3DnonUniform() { }

		public IfcCartesianTransformationOperator3DnonUniform(IfcDirection Axis1, IfcDirection Axis2, IfcCartesianPoint LocalOrigin, IfcReal Scale, IfcDirection Axis3, IfcReal Scale2, IfcReal Scale3)
		{
			this.Axis1 = Axis1;
			this.Axis2 = Axis2;
			this.LocalOrigin = LocalOrigin;
			this.Scale = Scale;
			this.Axis3 = Axis3;
			this.Scale2 = Scale2;
			this.Scale3 = Scale3;
		}
	}

	public class IfcCenterLineProfileDef : IfcArbitraryOpenProfileDef
	{
		//1	ProfileType : IfcProfileTypeEnum
		//2	ProfileName : IfcLabel
		//3	Curve : IfcBoundedCurve
		//4	Thickness : IfcPositiveLengthMeasure

		public IfcPositiveLengthMeasure Thickness { get; set; }

		public IfcCenterLineProfileDef() { }

		public IfcCenterLineProfileDef(IfcProfileTypeEnum ProfileType, IfcLabel ProfileName, IfcBoundedCurve Curve, IfcPositiveLengthMeasure Thickness)
		{
			this.ProfileType = ProfileType;
			this.ProfileName = ProfileName;
			this.Curve = Curve;
			this.Thickness = Thickness;
		}
	}

	public class IfcChiller : IfcEnergyConversionDevice
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	PredefinedType : IfcChillerTypeEnum

		public IfcChillerTypeEnum PredefinedType { get; set; }

		public IfcChiller() { }

		public IfcChiller(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcChillerTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcChillerType : IfcEnergyConversionDeviceType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel
		//10	PredefinedType : IfcChillerTypeEnum

		public IfcChillerTypeEnum PredefinedType { get; set; }

		public IfcChillerType() { }

		public IfcChillerType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType, IfcChillerTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcChimney : IfcBuildingElement
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	PredefinedType : IfcChimneyTypeEnum

		public IfcChimneyTypeEnum PredefinedType { get; set; }

		public IfcChimney() { }

		public IfcChimney(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcChimneyTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcChimneyType : IfcBuildingElementType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel
		//10	PredefinedType : IfcChimneyTypeEnum

		public IfcChimneyTypeEnum PredefinedType { get; set; }

		public IfcChimneyType() { }

		public IfcChimneyType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType, IfcChimneyTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcCircle : IfcConic
	{
		//1	Position : IfcAxis2Placement
		//2	Radius : IfcPositiveLengthMeasure

		public IfcPositiveLengthMeasure Radius { get; set; }

		public IfcCircle() { }

		public IfcCircle(IfcAxis2Placement Position, IfcPositiveLengthMeasure Radius)
		{
			this.Position = Position;
			this.Radius = Radius;
		}
	}

	public class IfcCircleHollowProfileDef : IfcCircleProfileDef
	{
		//1	ProfileType : IfcProfileTypeEnum
		//2	ProfileName : IfcLabel
		//3	Position : IfcAxis2Placement2D
		//4	Radius : IfcPositiveLengthMeasure
		//5	WallThickness : IfcPositiveLengthMeasure

		public IfcPositiveLengthMeasure WallThickness { get; set; }

		public IfcCircleHollowProfileDef() { }

		public IfcCircleHollowProfileDef(IfcProfileTypeEnum ProfileType, IfcLabel ProfileName, IfcAxis2Placement2D Position, IfcPositiveLengthMeasure Radius, IfcPositiveLengthMeasure WallThickness)
		{
			this.ProfileType = ProfileType;
			this.ProfileName = ProfileName;
			this.Position = Position;
			this.Radius = Radius;
			this.WallThickness = WallThickness;
		}
	}

	public class IfcCircleProfileDef : IfcParameterizedProfileDef
	{
		//1	ProfileType : IfcProfileTypeEnum
		//2	ProfileName : IfcLabel
		//3	Position : IfcAxis2Placement2D
		//4	Radius : IfcPositiveLengthMeasure

		public IfcPositiveLengthMeasure Radius { get; set; }

		public IfcCircleProfileDef() { }

		public IfcCircleProfileDef(IfcProfileTypeEnum ProfileType, IfcLabel ProfileName, IfcAxis2Placement2D Position, IfcPositiveLengthMeasure Radius)
		{
			this.ProfileType = ProfileType;
			this.ProfileName = ProfileName;
			this.Position = Position;
			this.Radius = Radius;
		}
	}

	public class IfcCivilElement : IfcElement
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier

		public IfcCivilElement() { }

		public IfcCivilElement(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
		}
	}

	public class IfcCivilElementType : IfcElementType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel

		public IfcCivilElementType() { }

		public IfcCivilElementType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
		}
	}

	public class IfcClassification : IfcExternalInformation, IfcClassificationReferenceSelect, IfcClassificationSelect
	{
		//1	Source : IfcLabel
		//2	Edition : IfcLabel
		//3	EditionDate : IfcDate
		//4	Name : IfcLabel
		//5	Description : IfcText
		//6	Location : IfcURIReference
		//7	ReferenceTokens : List<IfcIdentifier>

		public IfcLabel Source { get; set; }
		public IfcLabel Edition { get; set; }
		public IfcDate EditionDate { get; set; }
		public IfcLabel Name { get; set; }
		public IfcText Description { get; set; }
		public IfcURIReference Location { get; set; }
		public List<IfcIdentifier> ReferenceTokens { get; set; }
		public List<IfcRelAssociatesClassification> ClassificationForObjects { get; set; }
		public List<IfcClassificationReference> HasReferences { get; set; }
		public IfcText GetDescription() { return Description; }
		public List<IfcClassificationReference> GetHasReferences() { return HasReferences; }

		public IfcClassification() { }

		public IfcClassification(IfcLabel Source, IfcLabel Edition, IfcDate EditionDate, IfcLabel Name, IfcText Description, IfcURIReference Location, List<IfcIdentifier> ReferenceTokens)
		{
			this.Source = Source;
			this.Edition = Edition;
			this.EditionDate = EditionDate;
			this.Name = Name;
			this.Description = Description;
			this.Location = Location;
			this.ReferenceTokens = ReferenceTokens;
		}
	}

	public class IfcClassificationReference : IfcExternalReference, IfcClassificationReferenceSelect, IfcClassificationSelect
	{
		//1	Location : IfcURIReference
		//2	Identification : IfcIdentifier
		//3	Name : IfcLabel
		//4	ReferencedSource : IfcClassificationReferenceSelect
		//5	Description : IfcText
		//6	Sort : IfcIdentifier

		public IfcClassificationReferenceSelect ReferencedSource { get; set; }
		public IfcText Description { get; set; }
		public IfcIdentifier Sort { get; set; }
		public List<IfcRelAssociatesClassification> ClassificationRefForObjects { get; set; }
		public List<IfcClassificationReference> HasReferences { get; set; }
		public IfcText GetDescription() { return Description; }
		public List<IfcClassificationReference> GetHasReferences() { return HasReferences; }

		public IfcClassificationReference() { }

		public IfcClassificationReference(IfcURIReference Location, IfcIdentifier Identification, IfcLabel Name, IfcClassificationReferenceSelect ReferencedSource, IfcText Description, IfcIdentifier Sort)
		{
			this.Location = Location;
			this.Identification = Identification;
			this.Name = Name;
			this.ReferencedSource = ReferencedSource;
			this.Description = Description;
			this.Sort = Sort;
		}
	}

	public class IfcClosedShell : IfcConnectedFaceSet, IfcShell, IfcSolidOrShell
	{
		//1	CfsFaces : List<IfcFace>

		public IfcClosedShell() { }

		public IfcClosedShell(List<IfcFace> CfsFaces)
		{
			this.CfsFaces = CfsFaces;
		}
	}

	public class IfcCoil : IfcEnergyConversionDevice
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	PredefinedType : IfcCoilTypeEnum

		public IfcCoilTypeEnum PredefinedType { get; set; }

		public IfcCoil() { }

		public IfcCoil(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcCoilTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcCoilType : IfcEnergyConversionDeviceType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel
		//10	PredefinedType : IfcCoilTypeEnum

		public IfcCoilTypeEnum PredefinedType { get; set; }

		public IfcCoilType() { }

		public IfcCoilType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType, IfcCoilTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcColourRgb : IfcColourSpecification, IfcColourOrFactor
	{
		//1	Name : IfcLabel
		//2	Red : IfcNormalisedRatioMeasure
		//3	Green : IfcNormalisedRatioMeasure
		//4	Blue : IfcNormalisedRatioMeasure

		public IfcNormalisedRatioMeasure Red { get; set; }
		public IfcNormalisedRatioMeasure Green { get; set; }
		public IfcNormalisedRatioMeasure Blue { get; set; }

		public IfcColourRgb() { }

		public IfcColourRgb(IfcLabel Name, IfcNormalisedRatioMeasure Red, IfcNormalisedRatioMeasure Green, IfcNormalisedRatioMeasure Blue)
		{
			this.Name = Name;
			this.Red = Red;
			this.Green = Green;
			this.Blue = Blue;
		}
	}

	public class IfcColourRgbList : IfcPresentationItem
	{
		//1	ColourList : List<List<IfcNormalisedRatioMeasure>>

		public List<List<IfcNormalisedRatioMeasure>> ColourList { get; set; }

		public IfcColourRgbList() { }

		public IfcColourRgbList(List<List<IfcNormalisedRatioMeasure>> ColourList)
		{
			this.ColourList = ColourList;
		}
	}

	public abstract class IfcColourSpecification : IfcPresentationItem, IfcColour
	{
		//1	Name : IfcLabel

		public IfcLabel Name { get; set; }

		public IfcColourSpecification() { }

		public IfcColourSpecification(IfcLabel Name)
		{
			this.Name = Name;
		}
	}

	public class IfcColumn : IfcBuildingElement
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	PredefinedType : IfcColumnTypeEnum

		public IfcColumnTypeEnum PredefinedType { get; set; }

		public IfcColumn() { }

		public IfcColumn(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcColumnTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcColumnStandardCase : IfcColumn
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	PredefinedType : IfcColumnTypeEnum

		public IfcColumnStandardCase() { }

		public IfcColumnStandardCase(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcColumnTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcColumnType : IfcBuildingElementType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel
		//10	PredefinedType : IfcColumnTypeEnum

		public IfcColumnTypeEnum PredefinedType { get; set; }

		public IfcColumnType() { }

		public IfcColumnType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType, IfcColumnTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcCommunicationsAppliance : IfcFlowTerminal
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	PredefinedType : IfcCommunicationsApplianceTypeEnum

		public IfcCommunicationsApplianceTypeEnum PredefinedType { get; set; }

		public IfcCommunicationsAppliance() { }

		public IfcCommunicationsAppliance(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcCommunicationsApplianceTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcCommunicationsApplianceType : IfcFlowTerminalType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel
		//10	PredefinedType : IfcCommunicationsApplianceTypeEnum

		public IfcCommunicationsApplianceTypeEnum PredefinedType { get; set; }

		public IfcCommunicationsApplianceType() { }

		public IfcCommunicationsApplianceType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType, IfcCommunicationsApplianceTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcComplexProperty : IfcProperty
	{
		//1	Name : IfcIdentifier
		//2	Description : IfcText
		//3	UsageName : IfcIdentifier
		//4	HasProperties : List<IfcProperty>

		public IfcIdentifier UsageName { get; set; }
		public List<IfcProperty> HasProperties { get; set; }

		public IfcComplexProperty() { }

		public IfcComplexProperty(IfcIdentifier Name, IfcText Description, IfcIdentifier UsageName, List<IfcProperty> HasProperties)
		{
			this.Name = Name;
			this.Description = Description;
			this.UsageName = UsageName;
			this.HasProperties = HasProperties;
		}
	}

	public class IfcComplexPropertyTemplate : IfcPropertyTemplate
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	UsageName : IfcLabel
		//6	TemplateType : IfcComplexPropertyTemplateTypeEnum
		//7	HasPropertyTemplates : List<IfcPropertyTemplate>

		public IfcLabel UsageName { get; set; }
		public IfcComplexPropertyTemplateTypeEnum TemplateType { get; set; }
		public List<IfcPropertyTemplate> HasPropertyTemplates { get; set; }

		public IfcComplexPropertyTemplate() { }

		public IfcComplexPropertyTemplate(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel UsageName, IfcComplexPropertyTemplateTypeEnum TemplateType, List<IfcPropertyTemplate> HasPropertyTemplates)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.UsageName = UsageName;
			this.TemplateType = TemplateType;
			this.HasPropertyTemplates = HasPropertyTemplates;
		}
	}

	public class IfcCompositeCurve : IfcBoundedCurve
	{
		//1	Segments : List<IfcCompositeCurveSegment>
		//2	SelfIntersect : IfcLogical

		public List<IfcCompositeCurveSegment> Segments { get; set; }
		public IfcLogical SelfIntersect { get; set; }
		public IfcInteger NSegments { get; set; }
		public IfcLogical ClosedCurve { get; set; }

		public IfcCompositeCurve() { }

		public IfcCompositeCurve(List<IfcCompositeCurveSegment> Segments, IfcLogical SelfIntersect)
		{
			this.Segments = Segments;
			this.SelfIntersect = SelfIntersect;
		}
	}

	public class IfcCompositeCurveOnSurface : IfcCompositeCurve, IfcCurveOnSurface
	{
		//1	Segments : List<IfcCompositeCurveSegment>
		//2	SelfIntersect : IfcLogical

		public List<IfcSurface> BasisSurface { get; set; }

		public IfcCompositeCurveOnSurface() { }

		public IfcCompositeCurveOnSurface(List<IfcCompositeCurveSegment> Segments, IfcLogical SelfIntersect)
		{
			this.Segments = Segments;
			this.SelfIntersect = SelfIntersect;
		}
	}

	public class IfcCompositeCurveSegment : IfcGeometricRepresentationItem
	{
		//1	Transition : IfcTransitionCode
		//2	SameSense : IfcBoolean
		//3	ParentCurve : IfcCurve

		public IfcTransitionCode Transition { get; set; }
		public IfcBoolean SameSense { get; set; }
		public IfcCurve ParentCurve { get; set; }
		public IfcDimensionCount Dim { get; set; }
		public List<IfcCompositeCurve> UsingCurves { get; set; }

		public IfcCompositeCurveSegment() { }

		public IfcCompositeCurveSegment(IfcTransitionCode Transition, IfcBoolean SameSense, IfcCurve ParentCurve)
		{
			this.Transition = Transition;
			this.SameSense = SameSense;
			this.ParentCurve = ParentCurve;
		}
	}

	public class IfcCompositeProfileDef : IfcProfileDef
	{
		//1	ProfileType : IfcProfileTypeEnum
		//2	ProfileName : IfcLabel
		//3	Profiles : List<IfcProfileDef>
		//4	Label : IfcLabel

		public List<IfcProfileDef> Profiles { get; set; }
		public IfcLabel Label { get; set; }

		public IfcCompositeProfileDef() { }

		public IfcCompositeProfileDef(IfcProfileTypeEnum ProfileType, IfcLabel ProfileName, List<IfcProfileDef> Profiles, IfcLabel Label)
		{
			this.ProfileType = ProfileType;
			this.ProfileName = ProfileName;
			this.Profiles = Profiles;
			this.Label = Label;
		}
	}

	public class IfcCompressor : IfcFlowMovingDevice
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	PredefinedType : IfcCompressorTypeEnum

		public IfcCompressorTypeEnum PredefinedType { get; set; }

		public IfcCompressor() { }

		public IfcCompressor(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcCompressorTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcCompressorType : IfcFlowMovingDeviceType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel
		//10	PredefinedType : IfcCompressorTypeEnum

		public IfcCompressorTypeEnum PredefinedType { get; set; }

		public IfcCompressorType() { }

		public IfcCompressorType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType, IfcCompressorTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcCondenser : IfcEnergyConversionDevice
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	PredefinedType : IfcCondenserTypeEnum

		public IfcCondenserTypeEnum PredefinedType { get; set; }

		public IfcCondenser() { }

		public IfcCondenser(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcCondenserTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcCondenserType : IfcEnergyConversionDeviceType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel
		//10	PredefinedType : IfcCondenserTypeEnum

		public IfcCondenserTypeEnum PredefinedType { get; set; }

		public IfcCondenserType() { }

		public IfcCondenserType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType, IfcCondenserTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
			this.PredefinedType = PredefinedType;
		}
	}

	public abstract class IfcConic : IfcCurve
	{
		//1	Position : IfcAxis2Placement

		public IfcAxis2Placement Position { get; set; }

		public IfcConic() { }

		public IfcConic(IfcAxis2Placement Position)
		{
			this.Position = Position;
		}
	}

	public class IfcConnectedFaceSet : IfcTopologicalRepresentationItem
	{
		//1	CfsFaces : List<IfcFace>

		public List<IfcFace> CfsFaces { get; set; }

		public IfcConnectedFaceSet() { }

		public IfcConnectedFaceSet(List<IfcFace> CfsFaces)
		{
			this.CfsFaces = CfsFaces;
		}
	}

	public class IfcConnectionCurveGeometry : IfcConnectionGeometry
	{
		//1	CurveOnRelatingElement : IfcCurveOrEdgeCurve
		//2	CurveOnRelatedElement : IfcCurveOrEdgeCurve

		public IfcCurveOrEdgeCurve CurveOnRelatingElement { get; set; }
		public IfcCurveOrEdgeCurve CurveOnRelatedElement { get; set; }

		public IfcConnectionCurveGeometry() { }

		public IfcConnectionCurveGeometry(IfcCurveOrEdgeCurve CurveOnRelatingElement, IfcCurveOrEdgeCurve CurveOnRelatedElement)
		{
			this.CurveOnRelatingElement = CurveOnRelatingElement;
			this.CurveOnRelatedElement = CurveOnRelatedElement;
		}
	}

	public abstract class IfcConnectionGeometry : IfcBase
	{
		public IfcConnectionGeometry() { }
	}

	public class IfcConnectionPointEccentricity : IfcConnectionPointGeometry
	{
		//1	PointOnRelatingElement : IfcPointOrVertexPoint
		//2	PointOnRelatedElement : IfcPointOrVertexPoint
		//3	EccentricityInX : IfcLengthMeasure
		//4	EccentricityInY : IfcLengthMeasure
		//5	EccentricityInZ : IfcLengthMeasure

		public IfcLengthMeasure EccentricityInX { get; set; }
		public IfcLengthMeasure EccentricityInY { get; set; }
		public IfcLengthMeasure EccentricityInZ { get; set; }

		public IfcConnectionPointEccentricity() { }

		public IfcConnectionPointEccentricity(IfcPointOrVertexPoint PointOnRelatingElement, IfcPointOrVertexPoint PointOnRelatedElement, IfcLengthMeasure EccentricityInX, IfcLengthMeasure EccentricityInY, IfcLengthMeasure EccentricityInZ)
		{
			this.PointOnRelatingElement = PointOnRelatingElement;
			this.PointOnRelatedElement = PointOnRelatedElement;
			this.EccentricityInX = EccentricityInX;
			this.EccentricityInY = EccentricityInY;
			this.EccentricityInZ = EccentricityInZ;
		}
	}

	public class IfcConnectionPointGeometry : IfcConnectionGeometry
	{
		//1	PointOnRelatingElement : IfcPointOrVertexPoint
		//2	PointOnRelatedElement : IfcPointOrVertexPoint

		public IfcPointOrVertexPoint PointOnRelatingElement { get; set; }
		public IfcPointOrVertexPoint PointOnRelatedElement { get; set; }

		public IfcConnectionPointGeometry() { }

		public IfcConnectionPointGeometry(IfcPointOrVertexPoint PointOnRelatingElement, IfcPointOrVertexPoint PointOnRelatedElement)
		{
			this.PointOnRelatingElement = PointOnRelatingElement;
			this.PointOnRelatedElement = PointOnRelatedElement;
		}
	}

	public class IfcConnectionSurfaceGeometry : IfcConnectionGeometry
	{
		//1	SurfaceOnRelatingElement : IfcSurfaceOrFaceSurface
		//2	SurfaceOnRelatedElement : IfcSurfaceOrFaceSurface

		public IfcSurfaceOrFaceSurface SurfaceOnRelatingElement { get; set; }
		public IfcSurfaceOrFaceSurface SurfaceOnRelatedElement { get; set; }

		public IfcConnectionSurfaceGeometry() { }

		public IfcConnectionSurfaceGeometry(IfcSurfaceOrFaceSurface SurfaceOnRelatingElement, IfcSurfaceOrFaceSurface SurfaceOnRelatedElement)
		{
			this.SurfaceOnRelatingElement = SurfaceOnRelatingElement;
			this.SurfaceOnRelatedElement = SurfaceOnRelatedElement;
		}
	}

	public class IfcConnectionVolumeGeometry : IfcConnectionGeometry
	{
		//1	VolumeOnRelatingElement : IfcSolidOrShell
		//2	VolumeOnRelatedElement : IfcSolidOrShell

		public IfcSolidOrShell VolumeOnRelatingElement { get; set; }
		public IfcSolidOrShell VolumeOnRelatedElement { get; set; }

		public IfcConnectionVolumeGeometry() { }

		public IfcConnectionVolumeGeometry(IfcSolidOrShell VolumeOnRelatingElement, IfcSolidOrShell VolumeOnRelatedElement)
		{
			this.VolumeOnRelatingElement = VolumeOnRelatingElement;
			this.VolumeOnRelatedElement = VolumeOnRelatedElement;
		}
	}

	public abstract class IfcConstraint : IfcBase, IfcResourceObjectSelect
	{
		//1	Name : IfcLabel
		//2	Description : IfcText
		//3	ConstraintGrade : IfcConstraintEnum
		//4	ConstraintSource : IfcLabel
		//5	CreatingActor : IfcActorSelect
		//6	CreationTime : IfcDateTime
		//7	UserDefinedGrade : IfcLabel

		public IfcLabel Name { get; set; }
		public IfcText Description { get; set; }
		public IfcConstraintEnum ConstraintGrade { get; set; }
		public IfcLabel ConstraintSource { get; set; }
		public IfcActorSelect CreatingActor { get; set; }
		public IfcDateTime CreationTime { get; set; }
		public IfcLabel UserDefinedGrade { get; set; }
		public List<IfcExternalReferenceRelationship> HasExternalReferences { get; set; }
		public List<IfcResourceConstraintRelationship> PropertiesForConstraint { get; set; }

		public IfcConstraint() { }

		public IfcConstraint(IfcLabel Name, IfcText Description, IfcConstraintEnum ConstraintGrade, IfcLabel ConstraintSource, IfcActorSelect CreatingActor, IfcDateTime CreationTime, IfcLabel UserDefinedGrade)
		{
			this.Name = Name;
			this.Description = Description;
			this.ConstraintGrade = ConstraintGrade;
			this.ConstraintSource = ConstraintSource;
			this.CreatingActor = CreatingActor;
			this.CreationTime = CreationTime;
			this.UserDefinedGrade = UserDefinedGrade;
		}
	}

	public class IfcConstructionEquipmentResource : IfcConstructionResource
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	Identification : IfcIdentifier
		//7	LongDescription : IfcText
		//8	Usage : IfcResourceTime
		//9	BaseCosts : List<IfcAppliedValue>
		//10	BaseQuantity : IfcPhysicalQuantity
		//11	PredefinedType : IfcConstructionEquipmentResourceTypeEnum

		public IfcConstructionEquipmentResourceTypeEnum PredefinedType { get; set; }

		public IfcConstructionEquipmentResource() { }

		public IfcConstructionEquipmentResource(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcIdentifier Identification, IfcText LongDescription, IfcResourceTime Usage, List<IfcAppliedValue> BaseCosts, IfcPhysicalQuantity BaseQuantity, IfcConstructionEquipmentResourceTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.Identification = Identification;
			this.LongDescription = LongDescription;
			this.Usage = Usage;
			this.BaseCosts = BaseCosts;
			this.BaseQuantity = BaseQuantity;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcConstructionEquipmentResourceType : IfcConstructionResourceType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	Identification : IfcIdentifier
		//8	LongDescription : IfcText
		//9	ResourceType : IfcLabel
		//10	BaseCosts : List<IfcAppliedValue>
		//11	BaseQuantity : IfcPhysicalQuantity
		//12	PredefinedType : IfcConstructionEquipmentResourceTypeEnum

		public IfcConstructionEquipmentResourceTypeEnum PredefinedType { get; set; }

		public IfcConstructionEquipmentResourceType() { }

		public IfcConstructionEquipmentResourceType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcIdentifier Identification, IfcText LongDescription, IfcLabel ResourceType, List<IfcAppliedValue> BaseCosts, IfcPhysicalQuantity BaseQuantity, IfcConstructionEquipmentResourceTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.Identification = Identification;
			this.LongDescription = LongDescription;
			this.ResourceType = ResourceType;
			this.BaseCosts = BaseCosts;
			this.BaseQuantity = BaseQuantity;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcConstructionMaterialResource : IfcConstructionResource
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	Identification : IfcIdentifier
		//7	LongDescription : IfcText
		//8	Usage : IfcResourceTime
		//9	BaseCosts : List<IfcAppliedValue>
		//10	BaseQuantity : IfcPhysicalQuantity
		//11	PredefinedType : IfcConstructionMaterialResourceTypeEnum

		public IfcConstructionMaterialResourceTypeEnum PredefinedType { get; set; }

		public IfcConstructionMaterialResource() { }

		public IfcConstructionMaterialResource(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcIdentifier Identification, IfcText LongDescription, IfcResourceTime Usage, List<IfcAppliedValue> BaseCosts, IfcPhysicalQuantity BaseQuantity, IfcConstructionMaterialResourceTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.Identification = Identification;
			this.LongDescription = LongDescription;
			this.Usage = Usage;
			this.BaseCosts = BaseCosts;
			this.BaseQuantity = BaseQuantity;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcConstructionMaterialResourceType : IfcConstructionResourceType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	Identification : IfcIdentifier
		//8	LongDescription : IfcText
		//9	ResourceType : IfcLabel
		//10	BaseCosts : List<IfcAppliedValue>
		//11	BaseQuantity : IfcPhysicalQuantity
		//12	PredefinedType : IfcConstructionMaterialResourceTypeEnum

		public IfcConstructionMaterialResourceTypeEnum PredefinedType { get; set; }

		public IfcConstructionMaterialResourceType() { }

		public IfcConstructionMaterialResourceType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcIdentifier Identification, IfcText LongDescription, IfcLabel ResourceType, List<IfcAppliedValue> BaseCosts, IfcPhysicalQuantity BaseQuantity, IfcConstructionMaterialResourceTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.Identification = Identification;
			this.LongDescription = LongDescription;
			this.ResourceType = ResourceType;
			this.BaseCosts = BaseCosts;
			this.BaseQuantity = BaseQuantity;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcConstructionProductResource : IfcConstructionResource
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	Identification : IfcIdentifier
		//7	LongDescription : IfcText
		//8	Usage : IfcResourceTime
		//9	BaseCosts : List<IfcAppliedValue>
		//10	BaseQuantity : IfcPhysicalQuantity
		//11	PredefinedType : IfcConstructionProductResourceTypeEnum

		public IfcConstructionProductResourceTypeEnum PredefinedType { get; set; }

		public IfcConstructionProductResource() { }

		public IfcConstructionProductResource(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcIdentifier Identification, IfcText LongDescription, IfcResourceTime Usage, List<IfcAppliedValue> BaseCosts, IfcPhysicalQuantity BaseQuantity, IfcConstructionProductResourceTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.Identification = Identification;
			this.LongDescription = LongDescription;
			this.Usage = Usage;
			this.BaseCosts = BaseCosts;
			this.BaseQuantity = BaseQuantity;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcConstructionProductResourceType : IfcConstructionResourceType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	Identification : IfcIdentifier
		//8	LongDescription : IfcText
		//9	ResourceType : IfcLabel
		//10	BaseCosts : List<IfcAppliedValue>
		//11	BaseQuantity : IfcPhysicalQuantity
		//12	PredefinedType : IfcConstructionProductResourceTypeEnum

		public IfcConstructionProductResourceTypeEnum PredefinedType { get; set; }

		public IfcConstructionProductResourceType() { }

		public IfcConstructionProductResourceType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcIdentifier Identification, IfcText LongDescription, IfcLabel ResourceType, List<IfcAppliedValue> BaseCosts, IfcPhysicalQuantity BaseQuantity, IfcConstructionProductResourceTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.Identification = Identification;
			this.LongDescription = LongDescription;
			this.ResourceType = ResourceType;
			this.BaseCosts = BaseCosts;
			this.BaseQuantity = BaseQuantity;
			this.PredefinedType = PredefinedType;
		}
	}

	public abstract class IfcConstructionResource : IfcResource
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	Identification : IfcIdentifier
		//7	LongDescription : IfcText
		//8	Usage : IfcResourceTime
		//9	BaseCosts : List<IfcAppliedValue>
		//10	BaseQuantity : IfcPhysicalQuantity

		public IfcResourceTime Usage { get; set; }
		public List<IfcAppliedValue> BaseCosts { get; set; }
		public IfcPhysicalQuantity BaseQuantity { get; set; }

		public IfcConstructionResource() { }

		public IfcConstructionResource(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcIdentifier Identification, IfcText LongDescription, IfcResourceTime Usage, List<IfcAppliedValue> BaseCosts, IfcPhysicalQuantity BaseQuantity)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.Identification = Identification;
			this.LongDescription = LongDescription;
			this.Usage = Usage;
			this.BaseCosts = BaseCosts;
			this.BaseQuantity = BaseQuantity;
		}
	}

	public abstract class IfcConstructionResourceType : IfcTypeResource
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	Identification : IfcIdentifier
		//8	LongDescription : IfcText
		//9	ResourceType : IfcLabel
		//10	BaseCosts : List<IfcAppliedValue>
		//11	BaseQuantity : IfcPhysicalQuantity

		public List<IfcAppliedValue> BaseCosts { get; set; }
		public IfcPhysicalQuantity BaseQuantity { get; set; }

		public IfcConstructionResourceType() { }

		public IfcConstructionResourceType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcIdentifier Identification, IfcText LongDescription, IfcLabel ResourceType, List<IfcAppliedValue> BaseCosts, IfcPhysicalQuantity BaseQuantity)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.Identification = Identification;
			this.LongDescription = LongDescription;
			this.ResourceType = ResourceType;
			this.BaseCosts = BaseCosts;
			this.BaseQuantity = BaseQuantity;
		}
	}

	public abstract class IfcContext : IfcObjectDefinition
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	LongName : IfcLabel
		//7	Phase : IfcLabel
		//8	RepresentationContexts : List<IfcRepresentationContext>
		//9	UnitsInContext : IfcUnitAssignment

		public IfcLabel ObjectType { get; set; }
		public IfcLabel LongName { get; set; }
		public IfcLabel Phase { get; set; }
		public List<IfcRepresentationContext> RepresentationContexts { get; set; }
		public IfcUnitAssignment UnitsInContext { get; set; }
		public List<IfcRelDefinesByProperties> IsDefinedBy { get; set; }
		public List<IfcRelDeclares> Declares { get; set; }

		public IfcContext() { }

		public IfcContext(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcLabel LongName, IfcLabel Phase, List<IfcRepresentationContext> RepresentationContexts, IfcUnitAssignment UnitsInContext)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.LongName = LongName;
			this.Phase = Phase;
			this.RepresentationContexts = RepresentationContexts;
			this.UnitsInContext = UnitsInContext;
		}
	}

	public class IfcContextDependentUnit : IfcNamedUnit, IfcResourceObjectSelect
	{
		//1	Dimensions : IfcDimensionalExponents
		//2	UnitType : IfcUnitEnum
		//3	Name : IfcLabel

		public IfcLabel Name { get; set; }
		public List<IfcExternalReferenceRelationship> HasExternalReference { get; set; }

		public IfcContextDependentUnit() { }

		public IfcContextDependentUnit(IfcDimensionalExponents Dimensions, IfcUnitEnum UnitType, IfcLabel Name)
		{
			this.Dimensions = Dimensions;
			this.UnitType = UnitType;
			this.Name = Name;
		}
	}

	public abstract class IfcControl : IfcObject
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	Identification : IfcIdentifier

		public IfcIdentifier Identification { get; set; }
		public List<IfcRelAssignsToControl> Controls { get; set; }

		public IfcControl() { }

		public IfcControl(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcIdentifier Identification)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.Identification = Identification;
		}
	}

	public class IfcController : IfcDistributionControlElement
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	PredefinedType : IfcControllerTypeEnum

		public IfcControllerTypeEnum PredefinedType { get; set; }

		public IfcController() { }

		public IfcController(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcControllerTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcControllerType : IfcDistributionControlElementType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel
		//10	PredefinedType : IfcControllerTypeEnum

		public IfcControllerTypeEnum PredefinedType { get; set; }

		public IfcControllerType() { }

		public IfcControllerType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType, IfcControllerTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcConversionBasedUnit : IfcNamedUnit, IfcResourceObjectSelect
	{
		//1	Dimensions : IfcDimensionalExponents
		//2	UnitType : IfcUnitEnum
		//3	Name : IfcLabel
		//4	ConversionFactor : IfcMeasureWithUnit

		public IfcLabel Name { get; set; }
		public IfcMeasureWithUnit ConversionFactor { get; set; }
		public List<IfcExternalReferenceRelationship> HasExternalReference { get; set; }

		public IfcConversionBasedUnit() { }

		public IfcConversionBasedUnit(IfcDimensionalExponents Dimensions, IfcUnitEnum UnitType, IfcLabel Name, IfcMeasureWithUnit ConversionFactor)
		{
			this.Dimensions = Dimensions;
			this.UnitType = UnitType;
			this.Name = Name;
			this.ConversionFactor = ConversionFactor;
		}
	}

	public class IfcConversionBasedUnitWithOffset : IfcConversionBasedUnit
	{
		//1	Dimensions : IfcDimensionalExponents
		//2	UnitType : IfcUnitEnum
		//3	Name : IfcLabel
		//4	ConversionFactor : IfcMeasureWithUnit
		//5	ConversionOffset : IfcReal

		public IfcReal ConversionOffset { get; set; }

		public IfcConversionBasedUnitWithOffset() { }

		public IfcConversionBasedUnitWithOffset(IfcDimensionalExponents Dimensions, IfcUnitEnum UnitType, IfcLabel Name, IfcMeasureWithUnit ConversionFactor, IfcReal ConversionOffset)
		{
			this.Dimensions = Dimensions;
			this.UnitType = UnitType;
			this.Name = Name;
			this.ConversionFactor = ConversionFactor;
			this.ConversionOffset = ConversionOffset;
		}
	}

	public class IfcCooledBeam : IfcEnergyConversionDevice
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	PredefinedType : IfcCooledBeamTypeEnum

		public IfcCooledBeamTypeEnum PredefinedType { get; set; }

		public IfcCooledBeam() { }

		public IfcCooledBeam(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcCooledBeamTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcCooledBeamType : IfcEnergyConversionDeviceType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel
		//10	PredefinedType : IfcCooledBeamTypeEnum

		public IfcCooledBeamTypeEnum PredefinedType { get; set; }

		public IfcCooledBeamType() { }

		public IfcCooledBeamType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType, IfcCooledBeamTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcCoolingTower : IfcEnergyConversionDevice
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	PredefinedType : IfcCoolingTowerTypeEnum

		public IfcCoolingTowerTypeEnum PredefinedType { get; set; }

		public IfcCoolingTower() { }

		public IfcCoolingTower(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcCoolingTowerTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcCoolingTowerType : IfcEnergyConversionDeviceType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel
		//10	PredefinedType : IfcCoolingTowerTypeEnum

		public IfcCoolingTowerTypeEnum PredefinedType { get; set; }

		public IfcCoolingTowerType() { }

		public IfcCoolingTowerType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType, IfcCoolingTowerTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
			this.PredefinedType = PredefinedType;
		}
	}

	public abstract class IfcCoordinateOperation : IfcBase
	{
		//1	SourceCRS : IfcCoordinateReferenceSystemSelect
		//2	TargetCRS : IfcCoordinateReferenceSystem

		public IfcCoordinateReferenceSystemSelect SourceCRS { get; set; }
		public IfcCoordinateReferenceSystem TargetCRS { get; set; }

		public IfcCoordinateOperation() { }

		public IfcCoordinateOperation(IfcCoordinateReferenceSystemSelect SourceCRS, IfcCoordinateReferenceSystem TargetCRS)
		{
			this.SourceCRS = SourceCRS;
			this.TargetCRS = TargetCRS;
		}
	}

	public abstract class IfcCoordinateReferenceSystem : IfcBase, IfcCoordinateReferenceSystemSelect
	{
		//1	Name : IfcLabel
		//2	Description : IfcText
		//3	GeodeticDatum : IfcIdentifier
		//4	VerticalDatum : IfcIdentifier

		public IfcLabel Name { get; set; }
		public IfcText Description { get; set; }
		public IfcIdentifier GeodeticDatum { get; set; }
		public IfcIdentifier VerticalDatum { get; set; }
		public List<IfcCoordinateOperation> HasCoordinateOperation { get; set; }
		public List<IfcCoordinateOperation> GetHasCoordinateOperation() { return HasCoordinateOperation; }

		public IfcCoordinateReferenceSystem() { }

		public IfcCoordinateReferenceSystem(IfcLabel Name, IfcText Description, IfcIdentifier GeodeticDatum, IfcIdentifier VerticalDatum)
		{
			this.Name = Name;
			this.Description = Description;
			this.GeodeticDatum = GeodeticDatum;
			this.VerticalDatum = VerticalDatum;
		}
	}

	public class IfcCostItem : IfcControl
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	Identification : IfcIdentifier
		//7	PredefinedType : IfcCostItemTypeEnum
		//8	CostValues : List<IfcCostValue>
		//9	CostQuantities : List<IfcPhysicalQuantity>

		public IfcCostItemTypeEnum PredefinedType { get; set; }
		public List<IfcCostValue> CostValues { get; set; }
		public List<IfcPhysicalQuantity> CostQuantities { get; set; }

		public IfcCostItem() { }

		public IfcCostItem(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcIdentifier Identification, IfcCostItemTypeEnum PredefinedType, List<IfcCostValue> CostValues, List<IfcPhysicalQuantity> CostQuantities)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.Identification = Identification;
			this.PredefinedType = PredefinedType;
			this.CostValues = CostValues;
			this.CostQuantities = CostQuantities;
		}
	}

	public class IfcCostSchedule : IfcControl
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	Identification : IfcIdentifier
		//7	PredefinedType : IfcCostScheduleTypeEnum
		//8	Status : IfcLabel
		//9	SubmittedOn : IfcDateTime
		//10	UpdateDate : IfcDateTime

		public IfcCostScheduleTypeEnum PredefinedType { get; set; }
		public IfcLabel Status { get; set; }
		public IfcDateTime SubmittedOn { get; set; }
		public IfcDateTime UpdateDate { get; set; }

		public IfcCostSchedule() { }

		public IfcCostSchedule(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcIdentifier Identification, IfcCostScheduleTypeEnum PredefinedType, IfcLabel Status, IfcDateTime SubmittedOn, IfcDateTime UpdateDate)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.Identification = Identification;
			this.PredefinedType = PredefinedType;
			this.Status = Status;
			this.SubmittedOn = SubmittedOn;
			this.UpdateDate = UpdateDate;
		}
	}

	public class IfcCostValue : IfcAppliedValue
	{
		//1	Name : IfcLabel
		//2	Description : IfcText
		//3	AppliedValue : IfcAppliedValueSelect
		//4	UnitBasis : IfcMeasureWithUnit
		//5	ApplicableDate : IfcDate
		//6	FixedUntilDate : IfcDate
		//7	Category : IfcLabel
		//8	Condition : IfcLabel
		//9	ArithmeticOperator : IfcArithmeticOperatorEnum
		//10	Components : List<IfcAppliedValue>

		public IfcCostValue() { }

		public IfcCostValue(IfcLabel Name, IfcText Description, IfcAppliedValueSelect AppliedValue, IfcMeasureWithUnit UnitBasis, IfcDate ApplicableDate, IfcDate FixedUntilDate, IfcLabel Category, IfcLabel Condition, IfcArithmeticOperatorEnum ArithmeticOperator, List<IfcAppliedValue> Components)
		{
			this.Name = Name;
			this.Description = Description;
			this.AppliedValue = AppliedValue;
			this.UnitBasis = UnitBasis;
			this.ApplicableDate = ApplicableDate;
			this.FixedUntilDate = FixedUntilDate;
			this.Category = Category;
			this.Condition = Condition;
			this.ArithmeticOperator = ArithmeticOperator;
			this.Components = Components;
		}
	}

	public class IfcCovering : IfcBuildingElement
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	PredefinedType : IfcCoveringTypeEnum

		public IfcCoveringTypeEnum PredefinedType { get; set; }
		public List<IfcRelCoversSpaces> CoversSpaces { get; set; }
		public List<IfcRelCoversBldgElements> CoversElements { get; set; }

		public IfcCovering() { }

		public IfcCovering(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcCoveringTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcCoveringType : IfcBuildingElementType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel
		//10	PredefinedType : IfcCoveringTypeEnum

		public IfcCoveringTypeEnum PredefinedType { get; set; }

		public IfcCoveringType() { }

		public IfcCoveringType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType, IfcCoveringTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcCrewResource : IfcConstructionResource
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	Identification : IfcIdentifier
		//7	LongDescription : IfcText
		//8	Usage : IfcResourceTime
		//9	BaseCosts : List<IfcAppliedValue>
		//10	BaseQuantity : IfcPhysicalQuantity
		//11	PredefinedType : IfcCrewResourceTypeEnum

		public IfcCrewResourceTypeEnum PredefinedType { get; set; }

		public IfcCrewResource() { }

		public IfcCrewResource(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcIdentifier Identification, IfcText LongDescription, IfcResourceTime Usage, List<IfcAppliedValue> BaseCosts, IfcPhysicalQuantity BaseQuantity, IfcCrewResourceTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.Identification = Identification;
			this.LongDescription = LongDescription;
			this.Usage = Usage;
			this.BaseCosts = BaseCosts;
			this.BaseQuantity = BaseQuantity;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcCrewResourceType : IfcConstructionResourceType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	Identification : IfcIdentifier
		//8	LongDescription : IfcText
		//9	ResourceType : IfcLabel
		//10	BaseCosts : List<IfcAppliedValue>
		//11	BaseQuantity : IfcPhysicalQuantity
		//12	PredefinedType : IfcCrewResourceTypeEnum

		public IfcCrewResourceTypeEnum PredefinedType { get; set; }

		public IfcCrewResourceType() { }

		public IfcCrewResourceType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcIdentifier Identification, IfcText LongDescription, IfcLabel ResourceType, List<IfcAppliedValue> BaseCosts, IfcPhysicalQuantity BaseQuantity, IfcCrewResourceTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.Identification = Identification;
			this.LongDescription = LongDescription;
			this.ResourceType = ResourceType;
			this.BaseCosts = BaseCosts;
			this.BaseQuantity = BaseQuantity;
			this.PredefinedType = PredefinedType;
		}
	}

	public abstract class IfcCsgPrimitive3D : IfcGeometricRepresentationItem, IfcBooleanOperand, IfcCsgSelect
	{
		//1	Position : IfcAxis2Placement3D

		public IfcAxis2Placement3D Position { get; set; }
		public IfcDimensionCount Dim { get; set; }
		public IfcDimensionCount GetDim() { return Dim; }

		public IfcCsgPrimitive3D() { }

		public IfcCsgPrimitive3D(IfcAxis2Placement3D Position)
		{
			this.Position = Position;
		}
	}

	public class IfcCsgSolid : IfcSolidModel
	{
		//1	TreeRootExpression : IfcCsgSelect

		public IfcCsgSelect TreeRootExpression { get; set; }

		public IfcCsgSolid() { }

		public IfcCsgSolid(IfcCsgSelect TreeRootExpression)
		{
			this.TreeRootExpression = TreeRootExpression;
		}
	}

	public class IfcCurrencyRelationship : IfcResourceLevelRelationship
	{
		//1	Name : IfcLabel
		//2	Description : IfcText
		//3	RelatingMonetaryUnit : IfcMonetaryUnit
		//4	RelatedMonetaryUnit : IfcMonetaryUnit
		//5	ExchangeRate : IfcPositiveRatioMeasure
		//6	RateDateTime : IfcDateTime
		//7	RateSource : IfcLibraryInformation

		public IfcMonetaryUnit RelatingMonetaryUnit { get; set; }
		public IfcMonetaryUnit RelatedMonetaryUnit { get; set; }
		public IfcPositiveRatioMeasure ExchangeRate { get; set; }
		public IfcDateTime RateDateTime { get; set; }
		public IfcLibraryInformation RateSource { get; set; }

		public IfcCurrencyRelationship() { }

		public IfcCurrencyRelationship(IfcLabel Name, IfcText Description, IfcMonetaryUnit RelatingMonetaryUnit, IfcMonetaryUnit RelatedMonetaryUnit, IfcPositiveRatioMeasure ExchangeRate, IfcDateTime RateDateTime, IfcLibraryInformation RateSource)
		{
			this.Name = Name;
			this.Description = Description;
			this.RelatingMonetaryUnit = RelatingMonetaryUnit;
			this.RelatedMonetaryUnit = RelatedMonetaryUnit;
			this.ExchangeRate = ExchangeRate;
			this.RateDateTime = RateDateTime;
			this.RateSource = RateSource;
		}
	}

	public class IfcCurtainWall : IfcBuildingElement
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	PredefinedType : IfcCurtainWallTypeEnum

		public IfcCurtainWallTypeEnum PredefinedType { get; set; }

		public IfcCurtainWall() { }

		public IfcCurtainWall(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcCurtainWallTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcCurtainWallType : IfcBuildingElementType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel
		//10	PredefinedType : IfcCurtainWallTypeEnum

		public IfcCurtainWallTypeEnum PredefinedType { get; set; }

		public IfcCurtainWallType() { }

		public IfcCurtainWallType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType, IfcCurtainWallTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
			this.PredefinedType = PredefinedType;
		}
	}

	public abstract class IfcCurve : IfcGeometricRepresentationItem, IfcGeometricSetSelect
	{
		public IfcDimensionCount Dim { get; set; }

		public IfcCurve() { }
	}

	public class IfcCurveBoundedPlane : IfcBoundedSurface
	{
		//1	BasisSurface : IfcPlane
		//2	OuterBoundary : IfcCurve
		//3	InnerBoundaries : List<IfcCurve>

		public IfcPlane BasisSurface { get; set; }
		public IfcCurve OuterBoundary { get; set; }
		public List<IfcCurve> InnerBoundaries { get; set; }

		public IfcCurveBoundedPlane() { }

		public IfcCurveBoundedPlane(IfcPlane BasisSurface, IfcCurve OuterBoundary, List<IfcCurve> InnerBoundaries)
		{
			this.BasisSurface = BasisSurface;
			this.OuterBoundary = OuterBoundary;
			this.InnerBoundaries = InnerBoundaries;
		}
	}

	public class IfcCurveBoundedSurface : IfcBoundedSurface
	{
		//1	BasisSurface : IfcSurface
		//2	Boundaries : List<IfcBoundaryCurve>
		//3	ImplicitOuter : IfcBoolean

		public IfcSurface BasisSurface { get; set; }
		public List<IfcBoundaryCurve> Boundaries { get; set; }
		public IfcBoolean ImplicitOuter { get; set; }

		public IfcCurveBoundedSurface() { }

		public IfcCurveBoundedSurface(IfcSurface BasisSurface, List<IfcBoundaryCurve> Boundaries, IfcBoolean ImplicitOuter)
		{
			this.BasisSurface = BasisSurface;
			this.Boundaries = Boundaries;
			this.ImplicitOuter = ImplicitOuter;
		}
	}

	public class IfcCurveStyle : IfcPresentationStyle, IfcPresentationStyleSelect
	{
		//1	Name : IfcLabel
		//2	CurveFont : IfcCurveFontOrScaledCurveFontSelect
		//3	CurveWidth : IfcSizeSelect
		//4	CurveColour : IfcColour
		//5	ModelOrDraughting : IfcBoolean

		public IfcCurveFontOrScaledCurveFontSelect CurveFont { get; set; }
		public IfcSizeSelect CurveWidth { get; set; }
		public IfcColour CurveColour { get; set; }
		public IfcBoolean ModelOrDraughting { get; set; }

		public IfcCurveStyle() { }

		public IfcCurveStyle(IfcLabel Name, IfcCurveFontOrScaledCurveFontSelect CurveFont, IfcSizeSelect CurveWidth, IfcColour CurveColour, IfcBoolean ModelOrDraughting)
		{
			this.Name = Name;
			this.CurveFont = CurveFont;
			this.CurveWidth = CurveWidth;
			this.CurveColour = CurveColour;
			this.ModelOrDraughting = ModelOrDraughting;
		}
	}

	public class IfcCurveStyleFont : IfcPresentationItem, IfcCurveStyleFontSelect
	{
		//1	Name : IfcLabel
		//2	PatternList : List<IfcCurveStyleFontPattern>

		public IfcLabel Name { get; set; }
		public List<IfcCurveStyleFontPattern> PatternList { get; set; }

		public IfcCurveStyleFont() { }

		public IfcCurveStyleFont(IfcLabel Name, List<IfcCurveStyleFontPattern> PatternList)
		{
			this.Name = Name;
			this.PatternList = PatternList;
		}
	}

	public class IfcCurveStyleFontAndScaling : IfcPresentationItem, IfcCurveFontOrScaledCurveFontSelect
	{
		//1	Name : IfcLabel
		//2	CurveFont : IfcCurveStyleFontSelect
		//3	CurveFontScaling : IfcPositiveRatioMeasure

		public IfcLabel Name { get; set; }
		public IfcCurveStyleFontSelect CurveFont { get; set; }
		public IfcPositiveRatioMeasure CurveFontScaling { get; set; }

		public IfcCurveStyleFontAndScaling() { }

		public IfcCurveStyleFontAndScaling(IfcLabel Name, IfcCurveStyleFontSelect CurveFont, IfcPositiveRatioMeasure CurveFontScaling)
		{
			this.Name = Name;
			this.CurveFont = CurveFont;
			this.CurveFontScaling = CurveFontScaling;
		}
	}

	public class IfcCurveStyleFontPattern : IfcPresentationItem
	{
		//1	VisibleSegmentLength : IfcLengthMeasure
		//2	InvisibleSegmentLength : IfcPositiveLengthMeasure

		public IfcLengthMeasure VisibleSegmentLength { get; set; }
		public IfcPositiveLengthMeasure InvisibleSegmentLength { get; set; }

		public IfcCurveStyleFontPattern() { }

		public IfcCurveStyleFontPattern(IfcLengthMeasure VisibleSegmentLength, IfcPositiveLengthMeasure InvisibleSegmentLength)
		{
			this.VisibleSegmentLength = VisibleSegmentLength;
			this.InvisibleSegmentLength = InvisibleSegmentLength;
		}
	}

	public class IfcCylindricalSurface : IfcElementarySurface
	{
		//1	Position : IfcAxis2Placement3D
		//2	Radius : IfcPositiveLengthMeasure

		public IfcPositiveLengthMeasure Radius { get; set; }

		public IfcCylindricalSurface() { }

		public IfcCylindricalSurface(IfcAxis2Placement3D Position, IfcPositiveLengthMeasure Radius)
		{
			this.Position = Position;
			this.Radius = Radius;
		}
	}

	public class IfcDamper : IfcFlowController
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	PredefinedType : IfcDamperTypeEnum

		public IfcDamperTypeEnum PredefinedType { get; set; }

		public IfcDamper() { }

		public IfcDamper(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcDamperTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcDamperType : IfcFlowControllerType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel
		//10	PredefinedType : IfcDamperTypeEnum

		public IfcDamperTypeEnum PredefinedType { get; set; }

		public IfcDamperType() { }

		public IfcDamperType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType, IfcDamperTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcDerivedProfileDef : IfcProfileDef
	{
		//1	ProfileType : IfcProfileTypeEnum
		//2	ProfileName : IfcLabel
		//3	ParentProfile : IfcProfileDef
		//4	Operator : IfcCartesianTransformationOperator2D
		//5	Label : IfcLabel

		public IfcProfileDef ParentProfile { get; set; }
		public IfcCartesianTransformationOperator2D Operator { get; set; }
		public IfcLabel Label { get; set; }

		public IfcDerivedProfileDef() { }

		public IfcDerivedProfileDef(IfcProfileTypeEnum ProfileType, IfcLabel ProfileName, IfcProfileDef ParentProfile, IfcCartesianTransformationOperator2D Operator, IfcLabel Label)
		{
			this.ProfileType = ProfileType;
			this.ProfileName = ProfileName;
			this.ParentProfile = ParentProfile;
			this.Operator = Operator;
			this.Label = Label;
		}
	}

	public class IfcDerivedUnit : IfcBase
	{
		//1	Elements : List<IfcDerivedUnitElement>
		//2	UnitType : IfcDerivedUnitEnum
		//3	UserDefinedType : IfcLabel

		public List<IfcDerivedUnitElement> Elements { get; set; }
		public IfcDerivedUnitEnum UnitType { get; set; }
		public IfcLabel UserDefinedType { get; set; }
		public IfcDimensionalExponents Dimensions { get; set; }

		public IfcDerivedUnit() { }

		public IfcDerivedUnit(List<IfcDerivedUnitElement> Elements, IfcDerivedUnitEnum UnitType, IfcLabel UserDefinedType)
		{
			this.Elements = Elements;
			this.UnitType = UnitType;
			this.UserDefinedType = UserDefinedType;
		}
	}

	public class IfcDerivedUnitElement : IfcBase
	{
		//1	Unit : IfcNamedUnit
		//2	Exponent : INTEGER

		public IfcNamedUnit Unit { get; set; }
		public INTEGER Exponent { get; set; }

		public IfcDerivedUnitElement() { }

		public IfcDerivedUnitElement(IfcNamedUnit Unit, INTEGER Exponent)
		{
			this.Unit = Unit;
			this.Exponent = Exponent;
		}
	}

	public class IfcDimensionalExponents : IfcBase
	{
		//1	LengthExponent : INTEGER
		//2	MassExponent : INTEGER
		//3	TimeExponent : INTEGER
		//4	ElectricCurrentExponent : INTEGER
		//5	ThermodynamicTemperatureExponent : INTEGER
		//6	AmountOfSubstanceExponent : INTEGER
		//7	LuminousIntensityExponent : INTEGER

		public INTEGER LengthExponent { get; set; }
		public INTEGER MassExponent { get; set; }
		public INTEGER TimeExponent { get; set; }
		public INTEGER ElectricCurrentExponent { get; set; }
		public INTEGER ThermodynamicTemperatureExponent { get; set; }
		public INTEGER AmountOfSubstanceExponent { get; set; }
		public INTEGER LuminousIntensityExponent { get; set; }

		public IfcDimensionalExponents() { }
		public IfcDimensionalExponents(int LengthExponent, int MassExponent, int TimeExponent, int ElectricCurrentExponent, int ThermodynamicTemperatureExponent, int AmountOfSubstanceExponent, int LuminousIntensityExponent)
		{
			this.LengthExponent = LengthExponent;
			this.MassExponent = MassExponent;
			this.TimeExponent = TimeExponent;
			this.ElectricCurrentExponent = ElectricCurrentExponent;
			this.ThermodynamicTemperatureExponent = ThermodynamicTemperatureExponent;
			this.AmountOfSubstanceExponent = AmountOfSubstanceExponent;
			this.LuminousIntensityExponent = LuminousIntensityExponent;
		}
		public IfcDimensionalExponents(INTEGER LengthExponent, INTEGER MassExponent, INTEGER TimeExponent, INTEGER ElectricCurrentExponent, INTEGER ThermodynamicTemperatureExponent, INTEGER AmountOfSubstanceExponent, INTEGER LuminousIntensityExponent)
		{
			this.LengthExponent = LengthExponent;
			this.MassExponent = MassExponent;
			this.TimeExponent = TimeExponent;
			this.ElectricCurrentExponent = ElectricCurrentExponent;
			this.ThermodynamicTemperatureExponent = ThermodynamicTemperatureExponent;
			this.AmountOfSubstanceExponent = AmountOfSubstanceExponent;
			this.LuminousIntensityExponent = LuminousIntensityExponent;
		}

		public bool Compare(int LengthExponent, int MassExponent, int TimeExponent, int ElectricCurrentExponent, int ThermodynamicTemperatureExponent, int AmountOfSubstanceExponent, int LuminousIntensityExponent)
        {
			return this.LengthExponent == LengthExponent &&
			this.MassExponent == MassExponent &&
			this.TimeExponent == TimeExponent &&
			this.ElectricCurrentExponent == ElectricCurrentExponent &&
			this.ThermodynamicTemperatureExponent == ThermodynamicTemperatureExponent &&
			this.AmountOfSubstanceExponent == AmountOfSubstanceExponent &&
			this.LuminousIntensityExponent == LuminousIntensityExponent;
		}
	}

	public class IfcDirection : IfcGeometricRepresentationItem, IfcGridPlacementDirectionSelect, IfcVectorOrDirection
	{
		//1	DirectionRatios : List<IfcReal>

		public List<IfcReal> DirectionRatios { get; set; }
		public IfcDimensionCount Dim { get; set; }
		public List<IfcReal> GetDirectionRatios() { return DirectionRatios; }
		public IfcDimensionCount GetDim() { return Dim; }

		public IfcDirection() { }
		public IfcDirection(double a, double b)
		{
			this.DirectionRatios = new List<IfcReal>() { (IfcReal)a, (IfcReal)b };
		}
		public IfcDirection(double a, double b, double c) {
			this.DirectionRatios = new List<IfcReal>() { (IfcReal)a, (IfcReal)b, (IfcReal)c } ;
		}
		public IfcDirection(List<IfcReal> DirectionRatios)
		{
			this.DirectionRatios = DirectionRatios;
		}
	}

	public class IfcDiscreteAccessory : IfcElementComponent
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	PredefinedType : IfcDiscreteAccessoryTypeEnum

		public IfcDiscreteAccessoryTypeEnum PredefinedType { get; set; }

		public IfcDiscreteAccessory() { }

		public IfcDiscreteAccessory(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcDiscreteAccessoryTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcDiscreteAccessoryType : IfcElementComponentType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel
		//10	PredefinedType : IfcDiscreteAccessoryTypeEnum

		public IfcDiscreteAccessoryTypeEnum PredefinedType { get; set; }

		public IfcDiscreteAccessoryType() { }

		public IfcDiscreteAccessoryType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType, IfcDiscreteAccessoryTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcDistributionChamberElement : IfcDistributionFlowElement
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	PredefinedType : IfcDistributionChamberElementTypeEnum

		public IfcDistributionChamberElementTypeEnum PredefinedType { get; set; }

		public IfcDistributionChamberElement() { }

		public IfcDistributionChamberElement(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcDistributionChamberElementTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcDistributionChamberElementType : IfcDistributionFlowElementType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel
		//10	PredefinedType : IfcDistributionChamberElementTypeEnum

		public IfcDistributionChamberElementTypeEnum PredefinedType { get; set; }

		public IfcDistributionChamberElementType() { }

		public IfcDistributionChamberElementType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType, IfcDistributionChamberElementTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcDistributionCircuit : IfcDistributionSystem
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	LongName : IfcLabel
		//7	PredefinedType : IfcDistributionSystemEnum

		public IfcDistributionCircuit() { }

		public IfcDistributionCircuit(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcLabel LongName, IfcDistributionSystemEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.LongName = LongName;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcDistributionControlElement : IfcDistributionElement
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier

		public List<IfcRelFlowControlElements> AssignedToFlowElement { get; set; }

		public IfcDistributionControlElement() { }

		public IfcDistributionControlElement(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
		}
	}

	public abstract class IfcDistributionControlElementType : IfcDistributionElementType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel

		public IfcDistributionControlElementType() { }

		public IfcDistributionControlElementType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
		}
	}

	public class IfcDistributionElement : IfcElement
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier

		public List<IfcRelConnectsPortToElement> HasPorts { get; set; }

		public IfcDistributionElement() { }

		public IfcDistributionElement(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
		}
	}

	public class IfcDistributionElementType : IfcElementType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel

		public IfcDistributionElementType() { }

		public IfcDistributionElementType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
		}
	}

	public class IfcDistributionFlowElement : IfcDistributionElement
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier

		public List<IfcRelFlowControlElements> HasControlElements { get; set; }

		public IfcDistributionFlowElement() { }

		public IfcDistributionFlowElement(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
		}
	}

	public abstract class IfcDistributionFlowElementType : IfcDistributionElementType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel

		public IfcDistributionFlowElementType() { }

		public IfcDistributionFlowElementType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
		}
	}

	public class IfcDistributionPort : IfcPort
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	FlowDirection : IfcFlowDirectionEnum
		//9	PredefinedType : IfcDistributionPortTypeEnum
		//10	SystemType : IfcDistributionSystemEnum

		public IfcFlowDirectionEnum FlowDirection { get; set; }
		public IfcDistributionPortTypeEnum PredefinedType { get; set; }
		public IfcDistributionSystemEnum SystemType { get; set; }

		public IfcDistributionPort() { }

		public IfcDistributionPort(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcFlowDirectionEnum FlowDirection, IfcDistributionPortTypeEnum PredefinedType, IfcDistributionSystemEnum SystemType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.FlowDirection = FlowDirection;
			this.PredefinedType = PredefinedType;
			this.SystemType = SystemType;
		}
	}

	public class IfcDistributionSystem : IfcSystem
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	LongName : IfcLabel
		//7	PredefinedType : IfcDistributionSystemEnum

		public IfcLabel LongName { get; set; }
		public IfcDistributionSystemEnum PredefinedType { get; set; }

		public IfcDistributionSystem() { }

		public IfcDistributionSystem(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcLabel LongName, IfcDistributionSystemEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.LongName = LongName;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcDocumentInformation : IfcExternalInformation, IfcDocumentSelect
	{
		//1	Identification : IfcIdentifier
		//2	Name : IfcLabel
		//3	Description : IfcText
		//4	Location : IfcURIReference
		//5	Purpose : IfcText
		//6	IntendedUse : IfcText
		//7	Scope : IfcText
		//8	Revision : IfcLabel
		//9	DocumentOwner : IfcActorSelect
		//10	Editors : List<IfcActorSelect>
		//11	CreationTime : IfcDateTime
		//12	LastRevisionTime : IfcDateTime
		//13	ElectronicFormat : IfcIdentifier
		//14	ValidFrom : IfcDate
		//15	ValidUntil : IfcDate
		//16	Confidentiality : IfcDocumentConfidentialityEnum
		//17	Status : IfcDocumentStatusEnum

		public IfcIdentifier Identification { get; set; }
		public IfcLabel Name { get; set; }
		public IfcText Description { get; set; }
		public IfcURIReference Location { get; set; }
		public IfcText Purpose { get; set; }
		public IfcText IntendedUse { get; set; }
		public IfcText Scope { get; set; }
		public IfcLabel Revision { get; set; }
		public IfcActorSelect DocumentOwner { get; set; }
		public List<IfcActorSelect> Editors { get; set; }
		public IfcDateTime CreationTime { get; set; }
		public IfcDateTime LastRevisionTime { get; set; }
		public IfcIdentifier ElectronicFormat { get; set; }
		public IfcDate ValidFrom { get; set; }
		public IfcDate ValidUntil { get; set; }
		public IfcDocumentConfidentialityEnum Confidentiality { get; set; }
		public IfcDocumentStatusEnum Status { get; set; }
		public List<IfcRelAssociatesDocument> DocumentInfoForObjects { get; set; }
		public List<IfcDocumentReference> HasDocumentReferences { get; set; }
		public List<IfcDocumentInformationRelationship> IsPointedTo { get; set; }
		public List<IfcDocumentInformationRelationship> IsPointer { get; set; }
		public IfcText GetDescription() { return Description; }

		public IfcDocumentInformation() { }

		public IfcDocumentInformation(IfcIdentifier Identification, IfcLabel Name, IfcText Description, IfcURIReference Location, IfcText Purpose, IfcText IntendedUse, IfcText Scope, IfcLabel Revision, IfcActorSelect DocumentOwner, List<IfcActorSelect> Editors, IfcDateTime CreationTime, IfcDateTime LastRevisionTime, IfcIdentifier ElectronicFormat, IfcDate ValidFrom, IfcDate ValidUntil, IfcDocumentConfidentialityEnum Confidentiality, IfcDocumentStatusEnum Status)
		{
			this.Identification = Identification;
			this.Name = Name;
			this.Description = Description;
			this.Location = Location;
			this.Purpose = Purpose;
			this.IntendedUse = IntendedUse;
			this.Scope = Scope;
			this.Revision = Revision;
			this.DocumentOwner = DocumentOwner;
			this.Editors = Editors;
			this.CreationTime = CreationTime;
			this.LastRevisionTime = LastRevisionTime;
			this.ElectronicFormat = ElectronicFormat;
			this.ValidFrom = ValidFrom;
			this.ValidUntil = ValidUntil;
			this.Confidentiality = Confidentiality;
			this.Status = Status;
		}
	}

	public class IfcDocumentInformationRelationship : IfcResourceLevelRelationship
	{
		//1	Name : IfcLabel
		//2	Description : IfcText
		//3	RelatingDocument : IfcDocumentInformation
		//4	RelatedDocuments : List<IfcDocumentInformation>
		//5	RelationshipType : IfcLabel

		public IfcDocumentInformation RelatingDocument { get; set; }
		public List<IfcDocumentInformation> RelatedDocuments { get; set; }
		public IfcLabel RelationshipType { get; set; }

		public IfcDocumentInformationRelationship() { }

		public IfcDocumentInformationRelationship(IfcLabel Name, IfcText Description, IfcDocumentInformation RelatingDocument, List<IfcDocumentInformation> RelatedDocuments, IfcLabel RelationshipType)
		{
			this.Name = Name;
			this.Description = Description;
			this.RelatingDocument = RelatingDocument;
			this.RelatedDocuments = RelatedDocuments;
			this.RelationshipType = RelationshipType;
		}
	}

	public class IfcDocumentReference : IfcExternalReference, IfcDocumentSelect
	{
		//1	Location : IfcURIReference
		//2	Identification : IfcIdentifier
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ReferencedDocument : IfcDocumentInformation

		public IfcText Description { get; set; }
		public IfcDocumentInformation ReferencedDocument { get; set; }
		public List<IfcRelAssociatesDocument> DocumentRefForObjects { get; set; }
		public IfcText GetDescription() { return Description; }

		public IfcDocumentReference() { }

		public IfcDocumentReference(IfcURIReference Location, IfcIdentifier Identification, IfcLabel Name, IfcText Description, IfcDocumentInformation ReferencedDocument)
		{
			this.Location = Location;
			this.Identification = Identification;
			this.Name = Name;
			this.Description = Description;
			this.ReferencedDocument = ReferencedDocument;
		}
	}

	public class IfcDoor : IfcBuildingElement
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	OverallHeight : IfcPositiveLengthMeasure
		//10	OverallWidth : IfcPositiveLengthMeasure
		//11	PredefinedType : IfcDoorTypeEnum
		//12	OperationType : IfcDoorTypeOperationEnum
		//13	UserDefinedOperationType : IfcLabel

		public IfcPositiveLengthMeasure OverallHeight { get; set; }
		public IfcPositiveLengthMeasure OverallWidth { get; set; }
		public IfcDoorTypeEnum PredefinedType { get; set; }
		public IfcDoorTypeOperationEnum OperationType { get; set; }
		public IfcLabel UserDefinedOperationType { get; set; }

		public IfcDoor() { }

		public IfcDoor(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcPositiveLengthMeasure OverallHeight, IfcPositiveLengthMeasure OverallWidth, IfcDoorTypeEnum PredefinedType, IfcDoorTypeOperationEnum OperationType, IfcLabel UserDefinedOperationType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.OverallHeight = OverallHeight;
			this.OverallWidth = OverallWidth;
			this.PredefinedType = PredefinedType;
			this.OperationType = OperationType;
			this.UserDefinedOperationType = UserDefinedOperationType;
		}
	}

	public class IfcDoorLiningProperties : IfcPreDefinedPropertySet
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	LiningDepth : IfcPositiveLengthMeasure
		//6	LiningThickness : IfcNonNegativeLengthMeasure
		//7	ThresholdDepth : IfcPositiveLengthMeasure
		//8	ThresholdThickness : IfcNonNegativeLengthMeasure
		//9	TransomThickness : IfcNonNegativeLengthMeasure
		//10	TransomOffset : IfcLengthMeasure
		//11	LiningOffset : IfcLengthMeasure
		//12	ThresholdOffset : IfcLengthMeasure
		//13	CasingThickness : IfcPositiveLengthMeasure
		//14	CasingDepth : IfcPositiveLengthMeasure
		//15	ShapeAspectStyle : IfcShapeAspect
		//16	LiningToPanelOffsetX : IfcLengthMeasure
		//17	LiningToPanelOffsetY : IfcLengthMeasure

		public IfcPositiveLengthMeasure LiningDepth { get; set; }
		public IfcNonNegativeLengthMeasure LiningThickness { get; set; }
		public IfcPositiveLengthMeasure ThresholdDepth { get; set; }
		public IfcNonNegativeLengthMeasure ThresholdThickness { get; set; }
		public IfcNonNegativeLengthMeasure TransomThickness { get; set; }
		public IfcLengthMeasure TransomOffset { get; set; }
		public IfcLengthMeasure LiningOffset { get; set; }
		public IfcLengthMeasure ThresholdOffset { get; set; }
		public IfcPositiveLengthMeasure CasingThickness { get; set; }
		public IfcPositiveLengthMeasure CasingDepth { get; set; }
		public IfcShapeAspect ShapeAspectStyle { get; set; }
		public IfcLengthMeasure LiningToPanelOffsetX { get; set; }
		public IfcLengthMeasure LiningToPanelOffsetY { get; set; }

		public IfcDoorLiningProperties() { }

		public IfcDoorLiningProperties(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcPositiveLengthMeasure LiningDepth, IfcNonNegativeLengthMeasure LiningThickness, IfcPositiveLengthMeasure ThresholdDepth, IfcNonNegativeLengthMeasure ThresholdThickness, IfcNonNegativeLengthMeasure TransomThickness, IfcLengthMeasure TransomOffset, IfcLengthMeasure LiningOffset, IfcLengthMeasure ThresholdOffset, IfcPositiveLengthMeasure CasingThickness, IfcPositiveLengthMeasure CasingDepth, IfcShapeAspect ShapeAspectStyle, IfcLengthMeasure LiningToPanelOffsetX, IfcLengthMeasure LiningToPanelOffsetY)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.LiningDepth = LiningDepth;
			this.LiningThickness = LiningThickness;
			this.ThresholdDepth = ThresholdDepth;
			this.ThresholdThickness = ThresholdThickness;
			this.TransomThickness = TransomThickness;
			this.TransomOffset = TransomOffset;
			this.LiningOffset = LiningOffset;
			this.ThresholdOffset = ThresholdOffset;
			this.CasingThickness = CasingThickness;
			this.CasingDepth = CasingDepth;
			this.ShapeAspectStyle = ShapeAspectStyle;
			this.LiningToPanelOffsetX = LiningToPanelOffsetX;
			this.LiningToPanelOffsetY = LiningToPanelOffsetY;
		}
	}

	public class IfcDoorPanelProperties : IfcPreDefinedPropertySet
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	PanelDepth : IfcPositiveLengthMeasure
		//6	PanelOperation : IfcDoorPanelOperationEnum
		//7	PanelWidth : IfcNormalisedRatioMeasure
		//8	PanelPosition : IfcDoorPanelPositionEnum
		//9	ShapeAspectStyle : IfcShapeAspect

		public IfcPositiveLengthMeasure PanelDepth { get; set; }
		public IfcDoorPanelOperationEnum PanelOperation { get; set; }
		public IfcNormalisedRatioMeasure PanelWidth { get; set; }
		public IfcDoorPanelPositionEnum PanelPosition { get; set; }
		public IfcShapeAspect ShapeAspectStyle { get; set; }

		public IfcDoorPanelProperties() { }

		public IfcDoorPanelProperties(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcPositiveLengthMeasure PanelDepth, IfcDoorPanelOperationEnum PanelOperation, IfcNormalisedRatioMeasure PanelWidth, IfcDoorPanelPositionEnum PanelPosition, IfcShapeAspect ShapeAspectStyle)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.PanelDepth = PanelDepth;
			this.PanelOperation = PanelOperation;
			this.PanelWidth = PanelWidth;
			this.PanelPosition = PanelPosition;
			this.ShapeAspectStyle = ShapeAspectStyle;
		}
	}

	public class IfcDoorStandardCase : IfcDoor
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	OverallHeight : IfcPositiveLengthMeasure
		//10	OverallWidth : IfcPositiveLengthMeasure
		//11	PredefinedType : IfcDoorTypeEnum
		//12	OperationType : IfcDoorTypeOperationEnum
		//13	UserDefinedOperationType : IfcLabel

		public IfcDoorStandardCase() { }

		public IfcDoorStandardCase(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcPositiveLengthMeasure OverallHeight, IfcPositiveLengthMeasure OverallWidth, IfcDoorTypeEnum PredefinedType, IfcDoorTypeOperationEnum OperationType, IfcLabel UserDefinedOperationType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.OverallHeight = OverallHeight;
			this.OverallWidth = OverallWidth;
			this.PredefinedType = PredefinedType;
			this.OperationType = OperationType;
			this.UserDefinedOperationType = UserDefinedOperationType;
		}
	}

	public class IfcDoorStyle : IfcTypeProduct
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	OperationType : IfcDoorStyleOperationEnum
		//10	ConstructionType : IfcDoorStyleConstructionEnum
		//11	ParameterTakesPrecedence : IfcBoolean
		//12	Sizeable : IfcBoolean

		public IfcDoorStyleOperationEnum OperationType { get; set; }
		public IfcDoorStyleConstructionEnum ConstructionType { get; set; }
		public IfcBoolean ParameterTakesPrecedence { get; set; }
		public IfcBoolean Sizeable { get; set; }

		public IfcDoorStyle() { }

		public IfcDoorStyle(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcDoorStyleOperationEnum OperationType, IfcDoorStyleConstructionEnum ConstructionType, IfcBoolean ParameterTakesPrecedence, IfcBoolean Sizeable)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.OperationType = OperationType;
			this.ConstructionType = ConstructionType;
			this.ParameterTakesPrecedence = ParameterTakesPrecedence;
			this.Sizeable = Sizeable;
		}
	}

	public class IfcDoorType : IfcBuildingElementType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel
		//10	PredefinedType : IfcDoorTypeEnum
		//11	OperationType : IfcDoorTypeOperationEnum
		//12	ParameterTakesPrecedence : IfcBoolean
		//13	UserDefinedOperationType : IfcLabel

		public IfcDoorTypeEnum PredefinedType { get; set; }
		public IfcDoorTypeOperationEnum OperationType { get; set; }
		public IfcBoolean ParameterTakesPrecedence { get; set; }
		public IfcLabel UserDefinedOperationType { get; set; }

		public IfcDoorType() { }

		public IfcDoorType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType, IfcDoorTypeEnum PredefinedType, IfcDoorTypeOperationEnum OperationType, IfcBoolean ParameterTakesPrecedence, IfcLabel UserDefinedOperationType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
			this.PredefinedType = PredefinedType;
			this.OperationType = OperationType;
			this.ParameterTakesPrecedence = ParameterTakesPrecedence;
			this.UserDefinedOperationType = UserDefinedOperationType;
		}
	}

	public class IfcDraughtingPreDefinedColour : IfcPreDefinedColour
	{
		//1	Name : IfcLabel

		public IfcDraughtingPreDefinedColour() { }

		public IfcDraughtingPreDefinedColour(IfcLabel Name)
		{
			this.Name = Name;
		}
	}

	public class IfcDraughtingPreDefinedCurveFont : IfcPreDefinedCurveFont
	{
		//1	Name : IfcLabel

		public IfcDraughtingPreDefinedCurveFont() { }

		public IfcDraughtingPreDefinedCurveFont(IfcLabel Name)
		{
			this.Name = Name;
		}
	}

	public class IfcDuctFitting : IfcFlowFitting
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	PredefinedType : IfcDuctFittingTypeEnum

		public IfcDuctFittingTypeEnum PredefinedType { get; set; }

		public IfcDuctFitting() { }

		public IfcDuctFitting(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcDuctFittingTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcDuctFittingType : IfcFlowFittingType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel
		//10	PredefinedType : IfcDuctFittingTypeEnum

		public IfcDuctFittingTypeEnum PredefinedType { get; set; }

		public IfcDuctFittingType() { }

		public IfcDuctFittingType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType, IfcDuctFittingTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcDuctSegment : IfcFlowSegment
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	PredefinedType : IfcDuctSegmentTypeEnum

		public IfcDuctSegmentTypeEnum PredefinedType { get; set; }

		public IfcDuctSegment() { }

		public IfcDuctSegment(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcDuctSegmentTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcDuctSegmentType : IfcFlowSegmentType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel
		//10	PredefinedType : IfcDuctSegmentTypeEnum

		public IfcDuctSegmentTypeEnum PredefinedType { get; set; }

		public IfcDuctSegmentType() { }

		public IfcDuctSegmentType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType, IfcDuctSegmentTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcDuctSilencer : IfcFlowTreatmentDevice
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	PredefinedType : IfcDuctSilencerTypeEnum

		public IfcDuctSilencerTypeEnum PredefinedType { get; set; }

		public IfcDuctSilencer() { }

		public IfcDuctSilencer(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcDuctSilencerTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcDuctSilencerType : IfcFlowTreatmentDeviceType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel
		//10	PredefinedType : IfcDuctSilencerTypeEnum

		public IfcDuctSilencerTypeEnum PredefinedType { get; set; }

		public IfcDuctSilencerType() { }

		public IfcDuctSilencerType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType, IfcDuctSilencerTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcEdge : IfcTopologicalRepresentationItem
	{
		//1	EdgeStart : IfcVertex
		//2	EdgeEnd : IfcVertex

		public IfcVertex EdgeStart { get; set; }
		public IfcVertex EdgeEnd { get; set; }

		public IfcEdge() { }

		public IfcEdge(IfcVertex EdgeStart, IfcVertex EdgeEnd)
		{
			this.EdgeStart = EdgeStart;
			this.EdgeEnd = EdgeEnd;
		}
	}

	public class IfcEdgeCurve : IfcEdge, IfcCurveOrEdgeCurve
	{
		//1	EdgeStart : IfcVertex
		//2	EdgeEnd : IfcVertex
		//3	EdgeGeometry : IfcCurve
		//4	SameSense : IfcBoolean

		public IfcCurve EdgeGeometry { get; set; }
		public IfcBoolean SameSense { get; set; }

		public IfcEdgeCurve() { }

		public IfcEdgeCurve(IfcVertex EdgeStart, IfcVertex EdgeEnd, IfcCurve EdgeGeometry, IfcBoolean SameSense)
		{
			this.EdgeStart = EdgeStart;
			this.EdgeEnd = EdgeEnd;
			this.EdgeGeometry = EdgeGeometry;
			this.SameSense = SameSense;
		}
	}

	public class IfcEdgeLoop : IfcLoop
	{
		//1	EdgeList : List<IfcOrientedEdge>

		public List<IfcOrientedEdge> EdgeList { get; set; }
		public IfcInteger Ne { get; set; }

		public IfcEdgeLoop() { }

		public IfcEdgeLoop(List<IfcOrientedEdge> EdgeList)
		{
			this.EdgeList = EdgeList;
		}
	}

	public class IfcElectricAppliance : IfcFlowTerminal
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	PredefinedType : IfcElectricApplianceTypeEnum

		public IfcElectricApplianceTypeEnum PredefinedType { get; set; }

		public IfcElectricAppliance() { }

		public IfcElectricAppliance(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcElectricApplianceTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcElectricApplianceType : IfcFlowTerminalType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel
		//10	PredefinedType : IfcElectricApplianceTypeEnum

		public IfcElectricApplianceTypeEnum PredefinedType { get; set; }

		public IfcElectricApplianceType() { }

		public IfcElectricApplianceType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType, IfcElectricApplianceTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcElectricDistributionBoard : IfcFlowController
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	PredefinedType : IfcElectricDistributionBoardTypeEnum

		public IfcElectricDistributionBoardTypeEnum PredefinedType { get; set; }

		public IfcElectricDistributionBoard() { }

		public IfcElectricDistributionBoard(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcElectricDistributionBoardTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcElectricDistributionBoardType : IfcFlowControllerType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel
		//10	PredefinedType : IfcElectricDistributionBoardTypeEnum

		public IfcElectricDistributionBoardTypeEnum PredefinedType { get; set; }

		public IfcElectricDistributionBoardType() { }

		public IfcElectricDistributionBoardType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType, IfcElectricDistributionBoardTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcElectricFlowStorageDevice : IfcFlowStorageDevice
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	PredefinedType : IfcElectricFlowStorageDeviceTypeEnum

		public IfcElectricFlowStorageDeviceTypeEnum PredefinedType { get; set; }

		public IfcElectricFlowStorageDevice() { }

		public IfcElectricFlowStorageDevice(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcElectricFlowStorageDeviceTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcElectricFlowStorageDeviceType : IfcFlowStorageDeviceType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel
		//10	PredefinedType : IfcElectricFlowStorageDeviceTypeEnum

		public IfcElectricFlowStorageDeviceTypeEnum PredefinedType { get; set; }

		public IfcElectricFlowStorageDeviceType() { }

		public IfcElectricFlowStorageDeviceType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType, IfcElectricFlowStorageDeviceTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcElectricGenerator : IfcEnergyConversionDevice
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	PredefinedType : IfcElectricGeneratorTypeEnum

		public IfcElectricGeneratorTypeEnum PredefinedType { get; set; }

		public IfcElectricGenerator() { }

		public IfcElectricGenerator(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcElectricGeneratorTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcElectricGeneratorType : IfcEnergyConversionDeviceType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel
		//10	PredefinedType : IfcElectricGeneratorTypeEnum

		public IfcElectricGeneratorTypeEnum PredefinedType { get; set; }

		public IfcElectricGeneratorType() { }

		public IfcElectricGeneratorType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType, IfcElectricGeneratorTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcElectricMotor : IfcEnergyConversionDevice
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	PredefinedType : IfcElectricMotorTypeEnum

		public IfcElectricMotorTypeEnum PredefinedType { get; set; }

		public IfcElectricMotor() { }

		public IfcElectricMotor(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcElectricMotorTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcElectricMotorType : IfcEnergyConversionDeviceType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel
		//10	PredefinedType : IfcElectricMotorTypeEnum

		public IfcElectricMotorTypeEnum PredefinedType { get; set; }

		public IfcElectricMotorType() { }

		public IfcElectricMotorType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType, IfcElectricMotorTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcElectricTimeControl : IfcFlowController
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	PredefinedType : IfcElectricTimeControlTypeEnum

		public IfcElectricTimeControlTypeEnum PredefinedType { get; set; }

		public IfcElectricTimeControl() { }

		public IfcElectricTimeControl(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcElectricTimeControlTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcElectricTimeControlType : IfcFlowControllerType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel
		//10	PredefinedType : IfcElectricTimeControlTypeEnum

		public IfcElectricTimeControlTypeEnum PredefinedType { get; set; }

		public IfcElectricTimeControlType() { }

		public IfcElectricTimeControlType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType, IfcElectricTimeControlTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
			this.PredefinedType = PredefinedType;
		}
	}

	public abstract class IfcElement : IfcProduct, IfcStructuralActivityAssignmentSelect
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier

		public IfcIdentifier Tag { get; set; }
		public List<IfcRelFillsElement> FillsVoids { get; set; }
		public List<IfcRelConnectsElements> ConnectedTo { get; set; }
		public List<IfcRelInterferesElements> IsInterferedByElements { get; set; }
		public List<IfcRelInterferesElements> InterferesElements { get; set; }
		public List<IfcRelProjectsElement> HasProjections { get; set; }
		public List<IfcRelReferencedInSpatialStructure> ReferencedInStructures { get; set; }
		public List<IfcRelVoidsElement> HasOpenings { get; set; }
		public List<IfcRelConnectsWithRealizingElements> IsConnectionRealization { get; set; }
		public List<IfcRelSpaceBoundary> ProvidesBoundaries { get; set; }
		public List<IfcRelConnectsElements> ConnectedFrom { get; set; }
		public List<IfcRelContainedInSpatialStructure> ContainedInStructure { get; set; }
		public List<IfcRelCoversBldgElements> HasCoverings { get; set; }

		public IfcElement() { }

		public IfcElement(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
		}
	}

	public class IfcElementAssembly : IfcElement
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	AssemblyPlace : IfcAssemblyPlaceEnum
		//10	PredefinedType : IfcElementAssemblyTypeEnum

		public IfcAssemblyPlaceEnum AssemblyPlace { get; set; }
		public IfcElementAssemblyTypeEnum PredefinedType { get; set; }

		public IfcElementAssembly() { }

		public IfcElementAssembly(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcAssemblyPlaceEnum AssemblyPlace, IfcElementAssemblyTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.AssemblyPlace = AssemblyPlace;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcElementAssemblyType : IfcElementType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel
		//10	PredefinedType : IfcElementAssemblyTypeEnum

		public IfcElementAssemblyTypeEnum PredefinedType { get; set; }

		public IfcElementAssemblyType() { }

		public IfcElementAssemblyType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType, IfcElementAssemblyTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
			this.PredefinedType = PredefinedType;
		}
	}

	public abstract class IfcElementComponent : IfcElement
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier

		public IfcElementComponent() { }

		public IfcElementComponent(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
		}
	}

	public abstract class IfcElementComponentType : IfcElementType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel

		public IfcElementComponentType() { }

		public IfcElementComponentType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
		}
	}

	public class IfcElementQuantity : IfcQuantitySet
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	MethodOfMeasurement : IfcLabel
		//6	Quantities : List<IfcPhysicalQuantity>

		public IfcLabel MethodOfMeasurement { get; set; }
		public List<IfcPhysicalQuantity> Quantities { get; set; }

		public IfcElementQuantity() { }

		public IfcElementQuantity(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel MethodOfMeasurement, List<IfcPhysicalQuantity> Quantities)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.MethodOfMeasurement = MethodOfMeasurement;
			this.Quantities = Quantities;
		}
	}

	public abstract class IfcElementType : IfcTypeProduct
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel

		public IfcLabel ElementType { get; set; }

		public IfcElementType() { }

		public IfcElementType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
		}
	}

	public abstract class IfcElementarySurface : IfcSurface
	{
		//1	Position : IfcAxis2Placement3D

		public IfcAxis2Placement3D Position { get; set; }

		public IfcElementarySurface() { }

		public IfcElementarySurface(IfcAxis2Placement3D Position)
		{
			this.Position = Position;
		}
	}

	public class IfcEllipse : IfcConic
	{
		//1	Position : IfcAxis2Placement
		//2	SemiAxis1 : IfcPositiveLengthMeasure
		//3	SemiAxis2 : IfcPositiveLengthMeasure

		public IfcPositiveLengthMeasure SemiAxis1 { get; set; }
		public IfcPositiveLengthMeasure SemiAxis2 { get; set; }

		public IfcEllipse() { }

		public IfcEllipse(IfcAxis2Placement Position, IfcPositiveLengthMeasure SemiAxis1, IfcPositiveLengthMeasure SemiAxis2)
		{
			this.Position = Position;
			this.SemiAxis1 = SemiAxis1;
			this.SemiAxis2 = SemiAxis2;
		}
	}

	public class IfcEllipseProfileDef : IfcParameterizedProfileDef
	{
		//1	ProfileType : IfcProfileTypeEnum
		//2	ProfileName : IfcLabel
		//3	Position : IfcAxis2Placement2D
		//4	SemiAxis1 : IfcPositiveLengthMeasure
		//5	SemiAxis2 : IfcPositiveLengthMeasure

		public IfcPositiveLengthMeasure SemiAxis1 { get; set; }
		public IfcPositiveLengthMeasure SemiAxis2 { get; set; }

		public IfcEllipseProfileDef() { }

		public IfcEllipseProfileDef(IfcProfileTypeEnum ProfileType, IfcLabel ProfileName, IfcAxis2Placement2D Position, IfcPositiveLengthMeasure SemiAxis1, IfcPositiveLengthMeasure SemiAxis2)
		{
			this.ProfileType = ProfileType;
			this.ProfileName = ProfileName;
			this.Position = Position;
			this.SemiAxis1 = SemiAxis1;
			this.SemiAxis2 = SemiAxis2;
		}
	}

	public class IfcEnergyConversionDevice : IfcDistributionFlowElement
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier

		public IfcEnergyConversionDevice() { }

		public IfcEnergyConversionDevice(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
		}
	}

	public abstract class IfcEnergyConversionDeviceType : IfcDistributionFlowElementType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel

		public IfcEnergyConversionDeviceType() { }

		public IfcEnergyConversionDeviceType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
		}
	}

	public class IfcEngine : IfcEnergyConversionDevice
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	PredefinedType : IfcEngineTypeEnum

		public IfcEngineTypeEnum PredefinedType { get; set; }

		public IfcEngine() { }

		public IfcEngine(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcEngineTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcEngineType : IfcEnergyConversionDeviceType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel
		//10	PredefinedType : IfcEngineTypeEnum

		public IfcEngineTypeEnum PredefinedType { get; set; }

		public IfcEngineType() { }

		public IfcEngineType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType, IfcEngineTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcEvaporativeCooler : IfcEnergyConversionDevice
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	PredefinedType : IfcEvaporativeCoolerTypeEnum

		public IfcEvaporativeCoolerTypeEnum PredefinedType { get; set; }

		public IfcEvaporativeCooler() { }

		public IfcEvaporativeCooler(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcEvaporativeCoolerTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcEvaporativeCoolerType : IfcEnergyConversionDeviceType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel
		//10	PredefinedType : IfcEvaporativeCoolerTypeEnum

		public IfcEvaporativeCoolerTypeEnum PredefinedType { get; set; }

		public IfcEvaporativeCoolerType() { }

		public IfcEvaporativeCoolerType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType, IfcEvaporativeCoolerTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcEvaporator : IfcEnergyConversionDevice
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	PredefinedType : IfcEvaporatorTypeEnum

		public IfcEvaporatorTypeEnum PredefinedType { get; set; }

		public IfcEvaporator() { }

		public IfcEvaporator(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcEvaporatorTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcEvaporatorType : IfcEnergyConversionDeviceType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel
		//10	PredefinedType : IfcEvaporatorTypeEnum

		public IfcEvaporatorTypeEnum PredefinedType { get; set; }

		public IfcEvaporatorType() { }

		public IfcEvaporatorType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType, IfcEvaporatorTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcEvent : IfcProcess
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	Identification : IfcIdentifier
		//7	LongDescription : IfcText
		//8	PredefinedType : IfcEventTypeEnum
		//9	EventTriggerType : IfcEventTriggerTypeEnum
		//10	UserDefinedEventTriggerType : IfcLabel
		//11	EventOccurenceTime : IfcEventTime

		public IfcEventTypeEnum PredefinedType { get; set; }
		public IfcEventTriggerTypeEnum EventTriggerType { get; set; }
		public IfcLabel UserDefinedEventTriggerType { get; set; }
		public IfcEventTime EventOccurenceTime { get; set; }

		public IfcEvent() { }

		public IfcEvent(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcIdentifier Identification, IfcText LongDescription, IfcEventTypeEnum PredefinedType, IfcEventTriggerTypeEnum EventTriggerType, IfcLabel UserDefinedEventTriggerType, IfcEventTime EventOccurenceTime)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.Identification = Identification;
			this.LongDescription = LongDescription;
			this.PredefinedType = PredefinedType;
			this.EventTriggerType = EventTriggerType;
			this.UserDefinedEventTriggerType = UserDefinedEventTriggerType;
			this.EventOccurenceTime = EventOccurenceTime;
		}
	}

	public class IfcEventTime : IfcSchedulingTime
	{
		//1	Name : IfcLabel
		//2	DataOrigin : IfcDataOriginEnum
		//3	UserDefinedDataOrigin : IfcLabel
		//4	ActualDate : IfcDateTime
		//5	EarlyDate : IfcDateTime
		//6	LateDate : IfcDateTime
		//7	ScheduleDate : IfcDateTime

		public IfcDateTime ActualDate { get; set; }
		public IfcDateTime EarlyDate { get; set; }
		public IfcDateTime LateDate { get; set; }
		public IfcDateTime ScheduleDate { get; set; }

		public IfcEventTime() { }

		public IfcEventTime(IfcLabel Name, IfcDataOriginEnum DataOrigin, IfcLabel UserDefinedDataOrigin, IfcDateTime ActualDate, IfcDateTime EarlyDate, IfcDateTime LateDate, IfcDateTime ScheduleDate)
		{
			this.Name = Name;
			this.DataOrigin = DataOrigin;
			this.UserDefinedDataOrigin = UserDefinedDataOrigin;
			this.ActualDate = ActualDate;
			this.EarlyDate = EarlyDate;
			this.LateDate = LateDate;
			this.ScheduleDate = ScheduleDate;
		}
	}

	public class IfcEventType : IfcTypeProcess
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	Identification : IfcIdentifier
		//8	LongDescription : IfcText
		//9	ProcessType : IfcLabel
		//10	PredefinedType : IfcEventTypeEnum
		//11	EventTriggerType : IfcEventTriggerTypeEnum
		//12	UserDefinedEventTriggerType : IfcLabel

		public IfcEventTypeEnum PredefinedType { get; set; }
		public IfcEventTriggerTypeEnum EventTriggerType { get; set; }
		public IfcLabel UserDefinedEventTriggerType { get; set; }

		public IfcEventType() { }

		public IfcEventType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcIdentifier Identification, IfcText LongDescription, IfcLabel ProcessType, IfcEventTypeEnum PredefinedType, IfcEventTriggerTypeEnum EventTriggerType, IfcLabel UserDefinedEventTriggerType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.Identification = Identification;
			this.LongDescription = LongDescription;
			this.ProcessType = ProcessType;
			this.PredefinedType = PredefinedType;
			this.EventTriggerType = EventTriggerType;
			this.UserDefinedEventTriggerType = UserDefinedEventTriggerType;
		}
	}

	public abstract class IfcExtendedProperties : IfcPropertyAbstraction
	{
		//1	Name : IfcIdentifier
		//2	Description : IfcText
		//3	Properties : List<IfcProperty>

		public IfcIdentifier Name { get; set; }
		public IfcText Description { get; set; }
		public List<IfcProperty> Properties { get; set; }

		public IfcExtendedProperties() { }

		public IfcExtendedProperties(IfcIdentifier Name, IfcText Description, List<IfcProperty> Properties)
		{
			this.Name = Name;
			this.Description = Description;
			this.Properties = Properties;
		}
	}

	public abstract class IfcExternalInformation : IfcBase, IfcResourceObjectSelect
	{
		public IfcExternalInformation() { }
	}

	public abstract class IfcExternalReference : IfcBase, IfcLightDistributionDataSourceSelect, IfcObjectReferenceSelect, IfcResourceObjectSelect
	{
		//1	Location : IfcURIReference
		//2	Identification : IfcIdentifier
		//3	Name : IfcLabel

		public IfcURIReference Location { get; set; }
		public IfcIdentifier Identification { get; set; }
		public IfcLabel Name { get; set; }
		public List<IfcExternalReferenceRelationship> ExternalReferenceForResources { get; set; }
		public IfcURIReference GetLocation() { return Location; }
		public IfcIdentifier GetIdentification() { return Identification; }
		public IfcLabel GetName() { return Name; }
		public List<IfcExternalReferenceRelationship> GetExternalReferenceForResources() { return ExternalReferenceForResources; }

		public IfcExternalReference() { }

		public IfcExternalReference(IfcURIReference Location, IfcIdentifier Identification, IfcLabel Name)
		{
			this.Location = Location;
			this.Identification = Identification;
			this.Name = Name;
		}
	}

	public class IfcExternalReferenceRelationship : IfcResourceLevelRelationship
	{
		//1	Name : IfcLabel
		//2	Description : IfcText
		//3	RelatingReference : IfcExternalReference
		//4	RelatedResourceObjects : List<IfcResourceObjectSelect>

		public IfcExternalReference RelatingReference { get; set; }
		public List<IfcResourceObjectSelect> RelatedResourceObjects { get; set; }

		public IfcExternalReferenceRelationship() { }

		public IfcExternalReferenceRelationship(IfcLabel Name, IfcText Description, IfcExternalReference RelatingReference, List<IfcResourceObjectSelect> RelatedResourceObjects)
		{
			this.Name = Name;
			this.Description = Description;
			this.RelatingReference = RelatingReference;
			this.RelatedResourceObjects = RelatedResourceObjects;
		}
	}

	public class IfcExternalSpatialElement : IfcExternalSpatialStructureElement, IfcSpaceBoundarySelect
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	LongName : IfcLabel
		//9	PredefinedType : IfcExternalSpatialElementTypeEnum

		public IfcExternalSpatialElementTypeEnum PredefinedType { get; set; }
		public List<IfcRelSpaceBoundary> BoundedBy { get; set; }
		public List<IfcRelSpaceBoundary> GetBoundedBy() { return BoundedBy; }

		public IfcExternalSpatialElement() { }

		public IfcExternalSpatialElement(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcLabel LongName, IfcExternalSpatialElementTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.LongName = LongName;
			this.PredefinedType = PredefinedType;
		}
	}

	public abstract class IfcExternalSpatialStructureElement : IfcSpatialElement
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	LongName : IfcLabel

		public IfcExternalSpatialStructureElement() { }

		public IfcExternalSpatialStructureElement(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcLabel LongName)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.LongName = LongName;
		}
	}

	public class IfcExternallyDefinedHatchStyle : IfcExternalReference, IfcFillStyleSelect
	{
		//1	Location : IfcURIReference
		//2	Identification : IfcIdentifier
		//3	Name : IfcLabel

		public IfcExternallyDefinedHatchStyle() { }

		public IfcExternallyDefinedHatchStyle(IfcURIReference Location, IfcIdentifier Identification, IfcLabel Name)
		{
			this.Location = Location;
			this.Identification = Identification;
			this.Name = Name;
		}
	}

	public class IfcExternallyDefinedSurfaceStyle : IfcExternalReference, IfcSurfaceStyleElementSelect
	{
		//1	Location : IfcURIReference
		//2	Identification : IfcIdentifier
		//3	Name : IfcLabel

		public IfcExternallyDefinedSurfaceStyle() { }

		public IfcExternallyDefinedSurfaceStyle(IfcURIReference Location, IfcIdentifier Identification, IfcLabel Name)
		{
			this.Location = Location;
			this.Identification = Identification;
			this.Name = Name;
		}
	}

	public class IfcExternallyDefinedTextFont : IfcExternalReference, IfcTextFontSelect
	{
		//1	Location : IfcURIReference
		//2	Identification : IfcIdentifier
		//3	Name : IfcLabel

		public IfcExternallyDefinedTextFont() { }

		public IfcExternallyDefinedTextFont(IfcURIReference Location, IfcIdentifier Identification, IfcLabel Name)
		{
			this.Location = Location;
			this.Identification = Identification;
			this.Name = Name;
		}
	}

	public class IfcExtrudedAreaSolid : IfcSweptAreaSolid
	{
		//1	SweptArea : IfcProfileDef
		//2	Position : IfcAxis2Placement3D
		//3	ExtrudedDirection : IfcDirection
		//4	Depth : IfcPositiveLengthMeasure

		public IfcDirection ExtrudedDirection { get; set; }
		public IfcPositiveLengthMeasure Depth { get; set; }

		public IfcExtrudedAreaSolid() { }

		public IfcExtrudedAreaSolid(IfcProfileDef SweptArea, IfcAxis2Placement3D Position, IfcDirection ExtrudedDirection, IfcPositiveLengthMeasure Depth)
		{
			this.SweptArea = SweptArea;
			this.Position = Position;
			this.ExtrudedDirection = ExtrudedDirection;
			this.Depth = Depth;
		}
	}

	public class IfcExtrudedAreaSolidTapered : IfcExtrudedAreaSolid
	{
		//1	SweptArea : IfcProfileDef
		//2	Position : IfcAxis2Placement3D
		//3	ExtrudedDirection : IfcDirection
		//4	Depth : IfcPositiveLengthMeasure
		//5	EndSweptArea : IfcProfileDef

		public IfcProfileDef EndSweptArea { get; set; }

		public IfcExtrudedAreaSolidTapered() { }

		public IfcExtrudedAreaSolidTapered(IfcProfileDef SweptArea, IfcAxis2Placement3D Position, IfcDirection ExtrudedDirection, IfcPositiveLengthMeasure Depth, IfcProfileDef EndSweptArea)
		{
			this.SweptArea = SweptArea;
			this.Position = Position;
			this.ExtrudedDirection = ExtrudedDirection;
			this.Depth = Depth;
			this.EndSweptArea = EndSweptArea;
		}
	}

	public class IfcFace : IfcTopologicalRepresentationItem
	{
		//1	Bounds : List<IfcFaceBound>

		public List<IfcFaceBound> Bounds { get; set; }
		public List<IfcTextureMap> HasTextureMaps { get; set; }

		public IfcFace() { }

		public IfcFace(List<IfcFaceBound> Bounds)
		{
			this.Bounds = Bounds;
		}
	}

	public class IfcFaceBasedSurfaceModel : IfcGeometricRepresentationItem, IfcSurfaceOrFaceSurface
	{
		//1	FbsmFaces : List<IfcConnectedFaceSet>

		public List<IfcConnectedFaceSet> FbsmFaces { get; set; }
		public IfcDimensionCount Dim { get; set; }

		public IfcFaceBasedSurfaceModel() { }

		public IfcFaceBasedSurfaceModel(List<IfcConnectedFaceSet> FbsmFaces)
		{
			this.FbsmFaces = FbsmFaces;
		}
	}

	public class IfcFaceBound : IfcTopologicalRepresentationItem
	{
		//1	Bound : IfcLoop
		//2	Orientation : IfcBoolean

		public IfcLoop Bound { get; set; }
		public IfcBoolean Orientation { get; set; }

		public IfcFaceBound() { }

		public IfcFaceBound(IfcLoop Bound, IfcBoolean Orientation)
		{
			this.Bound = Bound;
			this.Orientation = Orientation;
		}
	}

	public class IfcFaceOuterBound : IfcFaceBound
	{
		//1	Bound : IfcLoop
		//2	Orientation : IfcBoolean

		public IfcFaceOuterBound() { }

		public IfcFaceOuterBound(IfcLoop Bound, IfcBoolean Orientation)
		{
			this.Bound = Bound;
			this.Orientation = Orientation;
		}
	}

	public class IfcFaceSurface : IfcFace, IfcSurfaceOrFaceSurface
	{
		//1	Bounds : List<IfcFaceBound>
		//2	FaceSurface : IfcSurface
		//3	SameSense : IfcBoolean

		public IfcSurface FaceSurface { get; set; }
		public IfcBoolean SameSense { get; set; }

		public IfcFaceSurface() { }

		public IfcFaceSurface(List<IfcFaceBound> Bounds, IfcSurface FaceSurface, IfcBoolean SameSense)
		{
			this.Bounds = Bounds;
			this.FaceSurface = FaceSurface;
			this.SameSense = SameSense;
		}
	}

	public class IfcFacetedBrep : IfcManifoldSolidBrep
	{
		//1	Outer : IfcClosedShell

		public IfcFacetedBrep() { }

		public IfcFacetedBrep(IfcClosedShell Outer)
		{
			this.Outer = Outer;
		}
	}

	public class IfcFacetedBrepWithVoids : IfcFacetedBrep
	{
		//1	Outer : IfcClosedShell
		//2	Voids : List<IfcClosedShell>

		public List<IfcClosedShell> Voids { get; set; }

		public IfcFacetedBrepWithVoids() { }

		public IfcFacetedBrepWithVoids(IfcClosedShell Outer, List<IfcClosedShell> Voids)
		{
			this.Outer = Outer;
			this.Voids = Voids;
		}
	}

	public class IfcFailureConnectionCondition : IfcStructuralConnectionCondition
	{
		//1	Name : IfcLabel
		//2	TensionFailureX : IfcForceMeasure
		//3	TensionFailureY : IfcForceMeasure
		//4	TensionFailureZ : IfcForceMeasure
		//5	CompressionFailureX : IfcForceMeasure
		//6	CompressionFailureY : IfcForceMeasure
		//7	CompressionFailureZ : IfcForceMeasure

		public IfcForceMeasure TensionFailureX { get; set; }
		public IfcForceMeasure TensionFailureY { get; set; }
		public IfcForceMeasure TensionFailureZ { get; set; }
		public IfcForceMeasure CompressionFailureX { get; set; }
		public IfcForceMeasure CompressionFailureY { get; set; }
		public IfcForceMeasure CompressionFailureZ { get; set; }

		public IfcFailureConnectionCondition() { }

		public IfcFailureConnectionCondition(IfcLabel Name, IfcForceMeasure TensionFailureX, IfcForceMeasure TensionFailureY, IfcForceMeasure TensionFailureZ, IfcForceMeasure CompressionFailureX, IfcForceMeasure CompressionFailureY, IfcForceMeasure CompressionFailureZ)
		{
			this.Name = Name;
			this.TensionFailureX = TensionFailureX;
			this.TensionFailureY = TensionFailureY;
			this.TensionFailureZ = TensionFailureZ;
			this.CompressionFailureX = CompressionFailureX;
			this.CompressionFailureY = CompressionFailureY;
			this.CompressionFailureZ = CompressionFailureZ;
		}
	}

	public class IfcFan : IfcFlowMovingDevice
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	PredefinedType : IfcFanTypeEnum

		public IfcFanTypeEnum PredefinedType { get; set; }

		public IfcFan() { }

		public IfcFan(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcFanTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcFanType : IfcFlowMovingDeviceType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel
		//10	PredefinedType : IfcFanTypeEnum

		public IfcFanTypeEnum PredefinedType { get; set; }

		public IfcFanType() { }

		public IfcFanType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType, IfcFanTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcFastener : IfcElementComponent
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	PredefinedType : IfcFastenerTypeEnum

		public IfcFastenerTypeEnum PredefinedType { get; set; }

		public IfcFastener() { }

		public IfcFastener(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcFastenerTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcFastenerType : IfcElementComponentType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel
		//10	PredefinedType : IfcFastenerTypeEnum

		public IfcFastenerTypeEnum PredefinedType { get; set; }

		public IfcFastenerType() { }

		public IfcFastenerType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType, IfcFastenerTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
			this.PredefinedType = PredefinedType;
		}
	}

	public abstract class IfcFeatureElement : IfcElement
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier

		public IfcFeatureElement() { }

		public IfcFeatureElement(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
		}
	}

	public abstract class IfcFeatureElementAddition : IfcFeatureElement
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier

		public IfcRelProjectsElement ProjectsElements { get; set; }

		public IfcFeatureElementAddition() { }

		public IfcFeatureElementAddition(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
		}
	}

	public abstract class IfcFeatureElementSubtraction : IfcFeatureElement
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier

		public IfcRelVoidsElement VoidsElements { get; set; }

		public IfcFeatureElementSubtraction() { }

		public IfcFeatureElementSubtraction(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
		}
	}

	public class IfcFillAreaStyle : IfcPresentationStyle, IfcPresentationStyleSelect
	{
		//1	Name : IfcLabel
		//2	FillStyles : List<IfcFillStyleSelect>
		//3	ModelorDraughting : IfcBoolean

		public List<IfcFillStyleSelect> FillStyles { get; set; }
		public IfcBoolean ModelorDraughting { get; set; }

		public IfcFillAreaStyle() { }

		public IfcFillAreaStyle(IfcLabel Name, List<IfcFillStyleSelect> FillStyles, IfcBoolean ModelorDraughting)
		{
			this.Name = Name;
			this.FillStyles = FillStyles;
			this.ModelorDraughting = ModelorDraughting;
		}
	}

	public class IfcFillAreaStyleHatching : IfcGeometricRepresentationItem, IfcFillStyleSelect
	{
		//1	HatchLineAppearance : IfcCurveStyle
		//2	StartOfNextHatchLine : IfcHatchLineDistanceSelect
		//3	PointOfReferenceHatchLine : IfcCartesianPoint
		//4	PatternStart : IfcCartesianPoint
		//5	HatchLineAngle : IfcPlaneAngleMeasure

		public IfcCurveStyle HatchLineAppearance { get; set; }
		public IfcHatchLineDistanceSelect StartOfNextHatchLine { get; set; }
		public IfcCartesianPoint PointOfReferenceHatchLine { get; set; }
		public IfcCartesianPoint PatternStart { get; set; }
		public IfcPlaneAngleMeasure HatchLineAngle { get; set; }

		public IfcFillAreaStyleHatching() { }

		public IfcFillAreaStyleHatching(IfcCurveStyle HatchLineAppearance, IfcHatchLineDistanceSelect StartOfNextHatchLine, IfcCartesianPoint PointOfReferenceHatchLine, IfcCartesianPoint PatternStart, IfcPlaneAngleMeasure HatchLineAngle)
		{
			this.HatchLineAppearance = HatchLineAppearance;
			this.StartOfNextHatchLine = StartOfNextHatchLine;
			this.PointOfReferenceHatchLine = PointOfReferenceHatchLine;
			this.PatternStart = PatternStart;
			this.HatchLineAngle = HatchLineAngle;
		}
	}

	public class IfcFillAreaStyleTiles : IfcGeometricRepresentationItem, IfcFillStyleSelect
	{
		//1	TilingPattern : List<IfcVector>
		//2	Tiles : List<IfcStyledItem>
		//3	TilingScale : IfcPositiveRatioMeasure

		public List<IfcVector> TilingPattern { get; set; }
		public List<IfcStyledItem> Tiles { get; set; }
		public IfcPositiveRatioMeasure TilingScale { get; set; }

		public IfcFillAreaStyleTiles() { }

		public IfcFillAreaStyleTiles(List<IfcVector> TilingPattern, List<IfcStyledItem> Tiles, IfcPositiveRatioMeasure TilingScale)
		{
			this.TilingPattern = TilingPattern;
			this.Tiles = Tiles;
			this.TilingScale = TilingScale;
		}
	}

	public class IfcFilter : IfcFlowTreatmentDevice
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	PredefinedType : IfcFilterTypeEnum

		public IfcFilterTypeEnum PredefinedType { get; set; }

		public IfcFilter() { }

		public IfcFilter(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcFilterTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcFilterType : IfcFlowTreatmentDeviceType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel
		//10	PredefinedType : IfcFilterTypeEnum

		public IfcFilterTypeEnum PredefinedType { get; set; }

		public IfcFilterType() { }

		public IfcFilterType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType, IfcFilterTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcFireSuppressionTerminal : IfcFlowTerminal
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	PredefinedType : IfcFireSuppressionTerminalTypeEnum

		public IfcFireSuppressionTerminalTypeEnum PredefinedType { get; set; }

		public IfcFireSuppressionTerminal() { }

		public IfcFireSuppressionTerminal(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcFireSuppressionTerminalTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcFireSuppressionTerminalType : IfcFlowTerminalType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel
		//10	PredefinedType : IfcFireSuppressionTerminalTypeEnum

		public IfcFireSuppressionTerminalTypeEnum PredefinedType { get; set; }

		public IfcFireSuppressionTerminalType() { }

		public IfcFireSuppressionTerminalType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType, IfcFireSuppressionTerminalTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcFixedReferenceSweptAreaSolid : IfcSweptAreaSolid
	{
		//1	SweptArea : IfcProfileDef
		//2	Position : IfcAxis2Placement3D
		//3	Directrix : IfcCurve
		//4	StartParam : IfcParameterValue
		//5	EndParam : IfcParameterValue
		//6	FixedReference : IfcDirection

		public IfcCurve Directrix { get; set; }
		public IfcParameterValue StartParam { get; set; }
		public IfcParameterValue EndParam { get; set; }
		public IfcDirection FixedReference { get; set; }

		public IfcFixedReferenceSweptAreaSolid() { }

		public IfcFixedReferenceSweptAreaSolid(IfcProfileDef SweptArea, IfcAxis2Placement3D Position, IfcCurve Directrix, IfcParameterValue StartParam, IfcParameterValue EndParam, IfcDirection FixedReference)
		{
			this.SweptArea = SweptArea;
			this.Position = Position;
			this.Directrix = Directrix;
			this.StartParam = StartParam;
			this.EndParam = EndParam;
			this.FixedReference = FixedReference;
		}
	}

	public class IfcFlowController : IfcDistributionFlowElement
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier

		public IfcFlowController() { }

		public IfcFlowController(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
		}
	}

	public abstract class IfcFlowControllerType : IfcDistributionFlowElementType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel

		public IfcFlowControllerType() { }

		public IfcFlowControllerType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
		}
	}

	public class IfcFlowFitting : IfcDistributionFlowElement
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier

		public IfcFlowFitting() { }

		public IfcFlowFitting(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
		}
	}

	public abstract class IfcFlowFittingType : IfcDistributionFlowElementType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel

		public IfcFlowFittingType() { }

		public IfcFlowFittingType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
		}
	}

	public class IfcFlowInstrument : IfcDistributionControlElement
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	PredefinedType : IfcFlowInstrumentTypeEnum

		public IfcFlowInstrumentTypeEnum PredefinedType { get; set; }

		public IfcFlowInstrument() { }

		public IfcFlowInstrument(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcFlowInstrumentTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcFlowInstrumentType : IfcDistributionControlElementType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel
		//10	PredefinedType : IfcFlowInstrumentTypeEnum

		public IfcFlowInstrumentTypeEnum PredefinedType { get; set; }

		public IfcFlowInstrumentType() { }

		public IfcFlowInstrumentType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType, IfcFlowInstrumentTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcFlowMeter : IfcFlowController
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	PredefinedType : IfcFlowMeterTypeEnum

		public IfcFlowMeterTypeEnum PredefinedType { get; set; }

		public IfcFlowMeter() { }

		public IfcFlowMeter(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcFlowMeterTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcFlowMeterType : IfcFlowControllerType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel
		//10	PredefinedType : IfcFlowMeterTypeEnum

		public IfcFlowMeterTypeEnum PredefinedType { get; set; }

		public IfcFlowMeterType() { }

		public IfcFlowMeterType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType, IfcFlowMeterTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcFlowMovingDevice : IfcDistributionFlowElement
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier

		public IfcFlowMovingDevice() { }

		public IfcFlowMovingDevice(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
		}
	}

	public abstract class IfcFlowMovingDeviceType : IfcDistributionFlowElementType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel

		public IfcFlowMovingDeviceType() { }

		public IfcFlowMovingDeviceType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
		}
	}

	public class IfcFlowSegment : IfcDistributionFlowElement
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier

		public IfcFlowSegment() { }

		public IfcFlowSegment(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
		}
	}

	public abstract class IfcFlowSegmentType : IfcDistributionFlowElementType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel

		public IfcFlowSegmentType() { }

		public IfcFlowSegmentType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
		}
	}

	public class IfcFlowStorageDevice : IfcDistributionFlowElement
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier

		public IfcFlowStorageDevice() { }

		public IfcFlowStorageDevice(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
		}
	}

	public abstract class IfcFlowStorageDeviceType : IfcDistributionFlowElementType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel

		public IfcFlowStorageDeviceType() { }

		public IfcFlowStorageDeviceType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
		}
	}

	public class IfcFlowTerminal : IfcDistributionFlowElement
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier

		public IfcFlowTerminal() { }

		public IfcFlowTerminal(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
		}
	}

	public abstract class IfcFlowTerminalType : IfcDistributionFlowElementType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel

		public IfcFlowTerminalType() { }

		public IfcFlowTerminalType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
		}
	}

	public class IfcFlowTreatmentDevice : IfcDistributionFlowElement
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier

		public IfcFlowTreatmentDevice() { }

		public IfcFlowTreatmentDevice(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
		}
	}

	public abstract class IfcFlowTreatmentDeviceType : IfcDistributionFlowElementType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel

		public IfcFlowTreatmentDeviceType() { }

		public IfcFlowTreatmentDeviceType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
		}
	}

	public class IfcFooting : IfcBuildingElement
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	PredefinedType : IfcFootingTypeEnum

		public IfcFootingTypeEnum PredefinedType { get; set; }

		public IfcFooting() { }

		public IfcFooting(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcFootingTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcFootingType : IfcBuildingElementType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel
		//10	PredefinedType : IfcFootingTypeEnum

		public IfcFootingTypeEnum PredefinedType { get; set; }

		public IfcFootingType() { }

		public IfcFootingType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType, IfcFootingTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcFurnishingElement : IfcElement
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier

		public IfcFurnishingElement() { }

		public IfcFurnishingElement(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
		}
	}

	public class IfcFurnishingElementType : IfcElementType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel

		public IfcFurnishingElementType() { }

		public IfcFurnishingElementType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
		}
	}

	public class IfcFurniture : IfcFurnishingElement
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	PredefinedType : IfcFurnitureTypeEnum

		public IfcFurnitureTypeEnum PredefinedType { get; set; }

		public IfcFurniture() { }

		public IfcFurniture(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcFurnitureTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcFurnitureType : IfcFurnishingElementType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel
		//10	AssemblyPlace : IfcAssemblyPlaceEnum
		//11	PredefinedType : IfcFurnitureTypeEnum

		public IfcAssemblyPlaceEnum AssemblyPlace { get; set; }
		public IfcFurnitureTypeEnum PredefinedType { get; set; }

		public IfcFurnitureType() { }

		public IfcFurnitureType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType, IfcAssemblyPlaceEnum AssemblyPlace, IfcFurnitureTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
			this.AssemblyPlace = AssemblyPlace;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcGeographicElement : IfcElement
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	PredefinedType : IfcGeographicElementTypeEnum

		public IfcGeographicElementTypeEnum PredefinedType { get; set; }

		public IfcGeographicElement() { }

		public IfcGeographicElement(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcGeographicElementTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcGeographicElementType : IfcElementType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel
		//10	PredefinedType : IfcGeographicElementTypeEnum

		public IfcGeographicElementTypeEnum PredefinedType { get; set; }

		public IfcGeographicElementType() { }

		public IfcGeographicElementType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType, IfcGeographicElementTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcGeometricCurveSet : IfcGeometricSet
	{
		//1	Elements : List<IfcGeometricSetSelect>

		public IfcGeometricCurveSet() { }

		public IfcGeometricCurveSet(List<IfcGeometricSetSelect> Elements)
		{
			this.Elements = Elements;
		}
	}

	public class IfcGeometricRepresentationContext : IfcRepresentationContext, IfcCoordinateReferenceSystemSelect
	{
		//1	ContextIdentifier : IfcLabel
		//2	ContextType : IfcLabel
		//3	CoordinateSpaceDimension : IfcDimensionCount
		//4	Precision : IfcReal
		//5	WorldCoordinateSystem : IfcAxis2Placement
		//6	TrueNorth : IfcDirection

		public IfcDimensionCount CoordinateSpaceDimension { get; set; }
		public IfcReal Precision { get; set; }
		public IfcAxis2Placement WorldCoordinateSystem { get; set; }
		public IfcDirection TrueNorth { get; set; }
		public List<IfcGeometricRepresentationSubContext> HasSubContexts { get; set; }
		public List<IfcCoordinateOperation> HasCoordinateOperation { get; set; }
		public List<IfcCoordinateOperation> GetHasCoordinateOperation() { return HasCoordinateOperation; }

		public IfcGeometricRepresentationContext() { }

		public IfcGeometricRepresentationContext(IfcLabel ContextIdentifier, IfcLabel ContextType, IfcDimensionCount CoordinateSpaceDimension, IfcReal Precision, IfcAxis2Placement WorldCoordinateSystem, IfcDirection TrueNorth)
		{
			this.ContextIdentifier = ContextIdentifier;
			this.ContextType = ContextType;
			this.CoordinateSpaceDimension = CoordinateSpaceDimension;
			this.Precision = Precision;
			this.WorldCoordinateSystem = WorldCoordinateSystem;
			this.TrueNorth = TrueNorth;
		}
	}

	public abstract class IfcGeometricRepresentationItem : IfcRepresentationItem
	{
		public IfcGeometricRepresentationItem() { }
	}

	public class IfcGeometricRepresentationSubContext : IfcGeometricRepresentationContext
	{
		//1	ContextIdentifier : IfcLabel
		//2	ContextType : IfcLabel
		//3	CoordinateSpaceDimension : IfcDimensionCount
		//4	Precision : IfcReal
		//5	WorldCoordinateSystem : IfcAxis2Placement
		//6	TrueNorth : IfcDirection
		//7	ParentContext : IfcGeometricRepresentationContext
		//8	TargetScale : IfcPositiveRatioMeasure
		//9	TargetView : IfcGeometricProjectionEnum
		//10	UserDefinedTargetView : IfcLabel

		public IfcGeometricRepresentationContext ParentContext { get; set; }
		public IfcPositiveRatioMeasure TargetScale { get; set; }
		public IfcGeometricProjectionEnum TargetView { get; set; }
		public IfcLabel UserDefinedTargetView { get; set; }

		public IfcGeometricRepresentationSubContext() { }

		public IfcGeometricRepresentationSubContext(IfcLabel ContextIdentifier, IfcLabel ContextType, IfcDimensionCount CoordinateSpaceDimension, IfcReal Precision, IfcAxis2Placement WorldCoordinateSystem, IfcDirection TrueNorth, IfcGeometricRepresentationContext ParentContext, IfcPositiveRatioMeasure TargetScale, IfcGeometricProjectionEnum TargetView, IfcLabel UserDefinedTargetView)
		{
			this.ContextIdentifier = ContextIdentifier;
			this.ContextType = ContextType;
			this.CoordinateSpaceDimension = CoordinateSpaceDimension;
			this.Precision = Precision;
			this.WorldCoordinateSystem = WorldCoordinateSystem;
			this.TrueNorth = TrueNorth;
			this.ParentContext = ParentContext;
			this.TargetScale = TargetScale;
			this.TargetView = TargetView;
			this.UserDefinedTargetView = UserDefinedTargetView;
		}
	}

	public class IfcGeometricSet : IfcGeometricRepresentationItem
	{
		//1	Elements : List<IfcGeometricSetSelect>

		public List<IfcGeometricSetSelect> Elements { get; set; }
		public IfcDimensionCount Dim { get; set; }

		public IfcGeometricSet() { }

		public IfcGeometricSet(List<IfcGeometricSetSelect> Elements)
		{
			this.Elements = Elements;
		}
	}

	public class IfcGrid : IfcProduct
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	UAxes : List<IfcGridAxis>
		//9	VAxes : List<IfcGridAxis>
		//10	WAxes : List<IfcGridAxis>
		//11	PredefinedType : IfcGridTypeEnum

		public List<IfcGridAxis> UAxes { get; set; }
		public List<IfcGridAxis> VAxes { get; set; }
		public List<IfcGridAxis> WAxes { get; set; }
		public IfcGridTypeEnum PredefinedType { get; set; }
		public List<IfcRelContainedInSpatialStructure> ContainedInStructure { get; set; }

		public IfcGrid() { }

		public IfcGrid(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, List<IfcGridAxis> UAxes, List<IfcGridAxis> VAxes, List<IfcGridAxis> WAxes, IfcGridTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.UAxes = UAxes;
			this.VAxes = VAxes;
			this.WAxes = WAxes;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcGridAxis : IfcBase
	{
		//1	AxisTag : IfcLabel
		//2	AxisCurve : IfcCurve
		//3	SameSense : IfcBoolean

		public IfcLabel AxisTag { get; set; }
		public IfcCurve AxisCurve { get; set; }
		public IfcBoolean SameSense { get; set; }
		public List<IfcGrid> PartOfW { get; set; }
		public List<IfcGrid> PartOfV { get; set; }
		public List<IfcGrid> PartOfU { get; set; }
		public List<IfcVirtualGridIntersection> HasIntersections { get; set; }

		public IfcGridAxis() { }

		public IfcGridAxis(IfcLabel AxisTag, IfcCurve AxisCurve, IfcBoolean SameSense)
		{
			this.AxisTag = AxisTag;
			this.AxisCurve = AxisCurve;
			this.SameSense = SameSense;
		}
	}

	public class IfcGridPlacement : IfcObjectPlacement
	{
		//1	PlacementLocation : IfcVirtualGridIntersection
		//2	PlacementRefDirection : IfcGridPlacementDirectionSelect

		public IfcVirtualGridIntersection PlacementLocation { get; set; }
		public IfcGridPlacementDirectionSelect PlacementRefDirection { get; set; }

		public IfcGridPlacement() { }

		public IfcGridPlacement(IfcVirtualGridIntersection PlacementLocation, IfcGridPlacementDirectionSelect PlacementRefDirection)
		{
			this.PlacementLocation = PlacementLocation;
			this.PlacementRefDirection = PlacementRefDirection;
		}
	}

	public class IfcGroup : IfcObject
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel

		public List<IfcRelAssignsToGroup> IsGroupedBy { get; set; }

		public IfcGroup() { }

		public IfcGroup(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
		}
	}

	public class IfcHalfSpaceSolid : IfcGeometricRepresentationItem, IfcBooleanOperand
	{
		//1	BaseSurface : IfcSurface
		//2	AgreementFlag : IfcBoolean

		public IfcSurface BaseSurface { get; set; }
		public IfcBoolean AgreementFlag { get; set; }
		public IfcDimensionCount Dim { get; set; }
		public IfcDimensionCount GetDim() { return Dim; }

		public IfcHalfSpaceSolid() { }

		public IfcHalfSpaceSolid(IfcSurface BaseSurface, IfcBoolean AgreementFlag)
		{
			this.BaseSurface = BaseSurface;
			this.AgreementFlag = AgreementFlag;
		}
	}

	public class IfcHeatExchanger : IfcEnergyConversionDevice
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	PredefinedType : IfcHeatExchangerTypeEnum

		public IfcHeatExchangerTypeEnum PredefinedType { get; set; }

		public IfcHeatExchanger() { }

		public IfcHeatExchanger(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcHeatExchangerTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcHeatExchangerType : IfcEnergyConversionDeviceType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel
		//10	PredefinedType : IfcHeatExchangerTypeEnum

		public IfcHeatExchangerTypeEnum PredefinedType { get; set; }

		public IfcHeatExchangerType() { }

		public IfcHeatExchangerType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType, IfcHeatExchangerTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcHumidifier : IfcEnergyConversionDevice
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	PredefinedType : IfcHumidifierTypeEnum

		public IfcHumidifierTypeEnum PredefinedType { get; set; }

		public IfcHumidifier() { }

		public IfcHumidifier(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcHumidifierTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcHumidifierType : IfcEnergyConversionDeviceType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel
		//10	PredefinedType : IfcHumidifierTypeEnum

		public IfcHumidifierTypeEnum PredefinedType { get; set; }

		public IfcHumidifierType() { }

		public IfcHumidifierType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType, IfcHumidifierTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcIShapeProfileDef : IfcParameterizedProfileDef
	{
		//1	ProfileType : IfcProfileTypeEnum
		//2	ProfileName : IfcLabel
		//3	Position : IfcAxis2Placement2D
		//4	OverallWidth : IfcPositiveLengthMeasure
		//5	OverallDepth : IfcPositiveLengthMeasure
		//6	WebThickness : IfcPositiveLengthMeasure
		//7	FlangeThickness : IfcPositiveLengthMeasure
		//8	FilletRadius : IfcNonNegativeLengthMeasure
		//9	FlangeEdgeRadius : IfcNonNegativeLengthMeasure
		//10	FlangeSlope : IfcPlaneAngleMeasure

		public IfcPositiveLengthMeasure OverallWidth { get; set; }
		public IfcPositiveLengthMeasure OverallDepth { get; set; }
		public IfcPositiveLengthMeasure WebThickness { get; set; }
		public IfcPositiveLengthMeasure FlangeThickness { get; set; }
		public IfcNonNegativeLengthMeasure FilletRadius { get; set; }
		public IfcNonNegativeLengthMeasure FlangeEdgeRadius { get; set; }
		public IfcPlaneAngleMeasure FlangeSlope { get; set; }

		public IfcIShapeProfileDef() { }

		public IfcIShapeProfileDef(IfcProfileTypeEnum ProfileType, IfcLabel ProfileName, IfcAxis2Placement2D Position, IfcPositiveLengthMeasure OverallWidth, IfcPositiveLengthMeasure OverallDepth, IfcPositiveLengthMeasure WebThickness, IfcPositiveLengthMeasure FlangeThickness, IfcNonNegativeLengthMeasure FilletRadius, IfcNonNegativeLengthMeasure FlangeEdgeRadius, IfcPlaneAngleMeasure FlangeSlope)
		{
			this.ProfileType = ProfileType;
			this.ProfileName = ProfileName;
			this.Position = Position;
			this.OverallWidth = OverallWidth;
			this.OverallDepth = OverallDepth;
			this.WebThickness = WebThickness;
			this.FlangeThickness = FlangeThickness;
			this.FilletRadius = FilletRadius;
			this.FlangeEdgeRadius = FlangeEdgeRadius;
			this.FlangeSlope = FlangeSlope;
		}
	}

	public class IfcImageTexture : IfcSurfaceTexture
	{
		//1	RepeatS : IfcBoolean
		//2	RepeatT : IfcBoolean
		//3	Mode : IfcIdentifier
		//4	TextureTransform : IfcCartesianTransformationOperator2D
		//5	Parameter : List<IfcIdentifier>
		//6	URLReference : IfcURIReference

		public IfcURIReference URLReference { get; set; }

		public IfcImageTexture() { }

		public IfcImageTexture(IfcBoolean RepeatS, IfcBoolean RepeatT, IfcIdentifier Mode, IfcCartesianTransformationOperator2D TextureTransform, List<IfcIdentifier> Parameter, IfcURIReference URLReference)
		{
			this.RepeatS = RepeatS;
			this.RepeatT = RepeatT;
			this.Mode = Mode;
			this.TextureTransform = TextureTransform;
			this.Parameter = Parameter;
			this.URLReference = URLReference;
		}
	}

	public class IfcIndexedColourMap : IfcPresentationItem
	{
		//1	MappedTo : IfcTessellatedFaceSet
		//2	Opacity : IfcNormalisedRatioMeasure
		//3	Colours : IfcColourRgbList
		//4	ColourIndex : List<IfcPositiveInteger>

		public IfcTessellatedFaceSet MappedTo { get; set; }
		public IfcNormalisedRatioMeasure Opacity { get; set; }
		public IfcColourRgbList Colours { get; set; }
		public List<IfcPositiveInteger> ColourIndex { get; set; }

		public IfcIndexedColourMap() { }

		public IfcIndexedColourMap(IfcTessellatedFaceSet MappedTo, IfcNormalisedRatioMeasure Opacity, IfcColourRgbList Colours, List<IfcPositiveInteger> ColourIndex)
		{
			this.MappedTo = MappedTo;
			this.Opacity = Opacity;
			this.Colours = Colours;
			this.ColourIndex = ColourIndex;
		}
	}

	public class IfcIndexedPolyCurve : IfcBoundedCurve
	{
		//1	Points : IfcCartesianPointList
		//2	Segments : List<IfcSegmentIndexSelect>
		//3	SelfIntersect : IfcBoolean

		public IfcCartesianPointList Points { get; set; }
		public List<IfcSegmentIndexSelect> Segments { get; set; }
		public IfcBoolean SelfIntersect { get; set; }

		public IfcIndexedPolyCurve() { }

		public IfcIndexedPolyCurve(IfcCartesianPointList Points, List<IfcSegmentIndexSelect> Segments, IfcBoolean SelfIntersect)
		{
			this.Points = Points;
			this.Segments = Segments;
			this.SelfIntersect = SelfIntersect;
		}
	}

	public class IfcIndexedPolygonalFace : IfcTessellatedItem
	{
		//1	CoordIndex : List<IfcPositiveInteger>

		public List<IfcPositiveInteger> CoordIndex { get; set; }
		public List<IfcPolygonalFaceSet> ToFaceSet { get; set; }

		public IfcIndexedPolygonalFace() { }

		public IfcIndexedPolygonalFace(List<IfcPositiveInteger> CoordIndex)
		{
			this.CoordIndex = CoordIndex;
		}
	}

	public class IfcIndexedPolygonalFaceWithVoids : IfcIndexedPolygonalFace
	{
		//1	CoordIndex : List<IfcPositiveInteger>
		//2	InnerCoordIndices : List<List<IfcPositiveInteger>>

		public List<List<IfcPositiveInteger>> InnerCoordIndices { get; set; }

		public IfcIndexedPolygonalFaceWithVoids() { }

		public IfcIndexedPolygonalFaceWithVoids(List<IfcPositiveInteger> CoordIndex, List<List<IfcPositiveInteger>> InnerCoordIndices)
		{
			this.CoordIndex = CoordIndex;
			this.InnerCoordIndices = InnerCoordIndices;
		}
	}

	public abstract class IfcIndexedTextureMap : IfcTextureCoordinate
	{
		//1	Maps : List<IfcSurfaceTexture>
		//2	MappedTo : IfcTessellatedFaceSet
		//3	TexCoords : IfcTextureVertexList

		public IfcTessellatedFaceSet MappedTo { get; set; }
		public IfcTextureVertexList TexCoords { get; set; }

		public IfcIndexedTextureMap() { }

		public IfcIndexedTextureMap(List<IfcSurfaceTexture> Maps, IfcTessellatedFaceSet MappedTo, IfcTextureVertexList TexCoords)
		{
			this.Maps = Maps;
			this.MappedTo = MappedTo;
			this.TexCoords = TexCoords;
		}
	}

	public class IfcIndexedTriangleTextureMap : IfcIndexedTextureMap
	{
		//1	Maps : List<IfcSurfaceTexture>
		//2	MappedTo : IfcTessellatedFaceSet
		//3	TexCoords : IfcTextureVertexList
		//4	TexCoordIndex : List<List<IfcPositiveInteger>>

		public List<List<IfcPositiveInteger>> TexCoordIndex { get; set; }

		public IfcIndexedTriangleTextureMap() { }

		public IfcIndexedTriangleTextureMap(List<IfcSurfaceTexture> Maps, IfcTessellatedFaceSet MappedTo, IfcTextureVertexList TexCoords, List<List<IfcPositiveInteger>> TexCoordIndex)
		{
			this.Maps = Maps;
			this.MappedTo = MappedTo;
			this.TexCoords = TexCoords;
			this.TexCoordIndex = TexCoordIndex;
		}
	}

	public class IfcInterceptor : IfcFlowTreatmentDevice
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	PredefinedType : IfcInterceptorTypeEnum

		public IfcInterceptorTypeEnum PredefinedType { get; set; }

		public IfcInterceptor() { }

		public IfcInterceptor(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcInterceptorTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcInterceptorType : IfcFlowTreatmentDeviceType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel
		//10	PredefinedType : IfcInterceptorTypeEnum

		public IfcInterceptorTypeEnum PredefinedType { get; set; }

		public IfcInterceptorType() { }

		public IfcInterceptorType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType, IfcInterceptorTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcIntersectionCurve : IfcSurfaceCurve
	{
		//1	Curve3D : IfcCurve
		//2	AssociatedGeometry : List<IfcPcurve>
		//3	MasterRepresentation : IfcPreferredSurfaceCurveRepresentation

		public IfcIntersectionCurve() { }

		public IfcIntersectionCurve(IfcCurve Curve3D, List<IfcPcurve> AssociatedGeometry, IfcPreferredSurfaceCurveRepresentation MasterRepresentation)
		{
			this.Curve3D = Curve3D;
			this.AssociatedGeometry = AssociatedGeometry;
			this.MasterRepresentation = MasterRepresentation;
		}
	}

	public class IfcInventory : IfcGroup
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	PredefinedType : IfcInventoryTypeEnum
		//7	Jurisdiction : IfcActorSelect
		//8	ResponsiblePersons : List<IfcPerson>
		//9	LastUpdateDate : IfcDate
		//10	CurrentValue : IfcCostValue
		//11	OriginalValue : IfcCostValue

		public IfcInventoryTypeEnum PredefinedType { get; set; }
		public IfcActorSelect Jurisdiction { get; set; }
		public List<IfcPerson> ResponsiblePersons { get; set; }
		public IfcDate LastUpdateDate { get; set; }
		public IfcCostValue CurrentValue { get; set; }
		public IfcCostValue OriginalValue { get; set; }

		public IfcInventory() { }

		public IfcInventory(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcInventoryTypeEnum PredefinedType, IfcActorSelect Jurisdiction, List<IfcPerson> ResponsiblePersons, IfcDate LastUpdateDate, IfcCostValue CurrentValue, IfcCostValue OriginalValue)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.PredefinedType = PredefinedType;
			this.Jurisdiction = Jurisdiction;
			this.ResponsiblePersons = ResponsiblePersons;
			this.LastUpdateDate = LastUpdateDate;
			this.CurrentValue = CurrentValue;
			this.OriginalValue = OriginalValue;
		}
	}

	public class IfcIrregularTimeSeries : IfcTimeSeries
	{
		//1	Name : IfcLabel
		//2	Description : IfcText
		//3	StartTime : IfcDateTime
		//4	EndTime : IfcDateTime
		//5	TimeSeriesDataType : IfcTimeSeriesDataTypeEnum
		//6	DataOrigin : IfcDataOriginEnum
		//7	UserDefinedDataOrigin : IfcLabel
		//8	Unit : IfcUnit
		//9	Values : List<IfcIrregularTimeSeriesValue>

		public List<IfcIrregularTimeSeriesValue> Values { get; set; }

		public IfcIrregularTimeSeries() { }

		public IfcIrregularTimeSeries(IfcLabel Name, IfcText Description, IfcDateTime StartTime, IfcDateTime EndTime, IfcTimeSeriesDataTypeEnum TimeSeriesDataType, IfcDataOriginEnum DataOrigin, IfcLabel UserDefinedDataOrigin, IfcUnit Unit, List<IfcIrregularTimeSeriesValue> Values)
		{
			this.Name = Name;
			this.Description = Description;
			this.StartTime = StartTime;
			this.EndTime = EndTime;
			this.TimeSeriesDataType = TimeSeriesDataType;
			this.DataOrigin = DataOrigin;
			this.UserDefinedDataOrigin = UserDefinedDataOrigin;
			this.Unit = Unit;
			this.Values = Values;
		}
	}

	public class IfcIrregularTimeSeriesValue : IfcBase
	{
		//1	TimeStamp : IfcDateTime
		//2	ListValues : List<IfcValue>

		public IfcDateTime TimeStamp { get; set; }
		public List<IfcValue> ListValues { get; set; }

		public IfcIrregularTimeSeriesValue() { }

		public IfcIrregularTimeSeriesValue(IfcDateTime TimeStamp, List<IfcValue> ListValues)
		{
			this.TimeStamp = TimeStamp;
			this.ListValues = ListValues;
		}
	}

	public class IfcJunctionBox : IfcFlowFitting
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	PredefinedType : IfcJunctionBoxTypeEnum

		public IfcJunctionBoxTypeEnum PredefinedType { get; set; }

		public IfcJunctionBox() { }

		public IfcJunctionBox(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcJunctionBoxTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcJunctionBoxType : IfcFlowFittingType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel
		//10	PredefinedType : IfcJunctionBoxTypeEnum

		public IfcJunctionBoxTypeEnum PredefinedType { get; set; }

		public IfcJunctionBoxType() { }

		public IfcJunctionBoxType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType, IfcJunctionBoxTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcLShapeProfileDef : IfcParameterizedProfileDef
	{
		//1	ProfileType : IfcProfileTypeEnum
		//2	ProfileName : IfcLabel
		//3	Position : IfcAxis2Placement2D
		//4	Depth : IfcPositiveLengthMeasure
		//5	Width : IfcPositiveLengthMeasure
		//6	Thickness : IfcPositiveLengthMeasure
		//7	FilletRadius : IfcNonNegativeLengthMeasure
		//8	EdgeRadius : IfcNonNegativeLengthMeasure
		//9	LegSlope : IfcPlaneAngleMeasure

		public IfcPositiveLengthMeasure Depth { get; set; }
		public IfcPositiveLengthMeasure Width { get; set; }
		public IfcPositiveLengthMeasure Thickness { get; set; }
		public IfcNonNegativeLengthMeasure FilletRadius { get; set; }
		public IfcNonNegativeLengthMeasure EdgeRadius { get; set; }
		public IfcPlaneAngleMeasure LegSlope { get; set; }

		public IfcLShapeProfileDef() { }

		public IfcLShapeProfileDef(IfcProfileTypeEnum ProfileType, IfcLabel ProfileName, IfcAxis2Placement2D Position, IfcPositiveLengthMeasure Depth, IfcPositiveLengthMeasure Width, IfcPositiveLengthMeasure Thickness, IfcNonNegativeLengthMeasure FilletRadius, IfcNonNegativeLengthMeasure EdgeRadius, IfcPlaneAngleMeasure LegSlope)
		{
			this.ProfileType = ProfileType;
			this.ProfileName = ProfileName;
			this.Position = Position;
			this.Depth = Depth;
			this.Width = Width;
			this.Thickness = Thickness;
			this.FilletRadius = FilletRadius;
			this.EdgeRadius = EdgeRadius;
			this.LegSlope = LegSlope;
		}
	}

	public class IfcLaborResource : IfcConstructionResource
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	Identification : IfcIdentifier
		//7	LongDescription : IfcText
		//8	Usage : IfcResourceTime
		//9	BaseCosts : List<IfcAppliedValue>
		//10	BaseQuantity : IfcPhysicalQuantity
		//11	PredefinedType : IfcLaborResourceTypeEnum

		public IfcLaborResourceTypeEnum PredefinedType { get; set; }

		public IfcLaborResource() { }

		public IfcLaborResource(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcIdentifier Identification, IfcText LongDescription, IfcResourceTime Usage, List<IfcAppliedValue> BaseCosts, IfcPhysicalQuantity BaseQuantity, IfcLaborResourceTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.Identification = Identification;
			this.LongDescription = LongDescription;
			this.Usage = Usage;
			this.BaseCosts = BaseCosts;
			this.BaseQuantity = BaseQuantity;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcLaborResourceType : IfcConstructionResourceType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	Identification : IfcIdentifier
		//8	LongDescription : IfcText
		//9	ResourceType : IfcLabel
		//10	BaseCosts : List<IfcAppliedValue>
		//11	BaseQuantity : IfcPhysicalQuantity
		//12	PredefinedType : IfcLaborResourceTypeEnum

		public IfcLaborResourceTypeEnum PredefinedType { get; set; }

		public IfcLaborResourceType() { }

		public IfcLaborResourceType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcIdentifier Identification, IfcText LongDescription, IfcLabel ResourceType, List<IfcAppliedValue> BaseCosts, IfcPhysicalQuantity BaseQuantity, IfcLaborResourceTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.Identification = Identification;
			this.LongDescription = LongDescription;
			this.ResourceType = ResourceType;
			this.BaseCosts = BaseCosts;
			this.BaseQuantity = BaseQuantity;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcLagTime : IfcSchedulingTime
	{
		//1	Name : IfcLabel
		//2	DataOrigin : IfcDataOriginEnum
		//3	UserDefinedDataOrigin : IfcLabel
		//4	LagValue : IfcTimeOrRatioSelect
		//5	DurationType : IfcTaskDurationEnum

		public IfcTimeOrRatioSelect LagValue { get; set; }
		public IfcTaskDurationEnum DurationType { get; set; }

		public IfcLagTime() { }

		public IfcLagTime(IfcLabel Name, IfcDataOriginEnum DataOrigin, IfcLabel UserDefinedDataOrigin, IfcTimeOrRatioSelect LagValue, IfcTaskDurationEnum DurationType)
		{
			this.Name = Name;
			this.DataOrigin = DataOrigin;
			this.UserDefinedDataOrigin = UserDefinedDataOrigin;
			this.LagValue = LagValue;
			this.DurationType = DurationType;
		}
	}

	public class IfcLamp : IfcFlowTerminal
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	PredefinedType : IfcLampTypeEnum

		public IfcLampTypeEnum PredefinedType { get; set; }

		public IfcLamp() { }

		public IfcLamp(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcLampTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcLampType : IfcFlowTerminalType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel
		//10	PredefinedType : IfcLampTypeEnum

		public IfcLampTypeEnum PredefinedType { get; set; }

		public IfcLampType() { }

		public IfcLampType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType, IfcLampTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcLibraryInformation : IfcExternalInformation, IfcLibrarySelect
	{
		//1	Name : IfcLabel
		//2	Version : IfcLabel
		//3	Publisher : IfcActorSelect
		//4	VersionDate : IfcDateTime
		//5	Location : IfcURIReference
		//6	Description : IfcText

		public IfcLabel Name { get; set; }
		public IfcLabel Version { get; set; }
		public IfcActorSelect Publisher { get; set; }
		public IfcDateTime VersionDate { get; set; }
		public IfcURIReference Location { get; set; }
		public IfcText Description { get; set; }
		public List<IfcRelAssociatesLibrary> LibraryInfoForObjects { get; set; }
		public List<IfcLibraryReference> HasLibraryReferences { get; set; }
		public IfcText GetDescription() { return Description; }

		public IfcLibraryInformation() { }

		public IfcLibraryInformation(IfcLabel Name, IfcLabel Version, IfcActorSelect Publisher, IfcDateTime VersionDate, IfcURIReference Location, IfcText Description)
		{
			this.Name = Name;
			this.Version = Version;
			this.Publisher = Publisher;
			this.VersionDate = VersionDate;
			this.Location = Location;
			this.Description = Description;
		}
	}

	public class IfcLibraryReference : IfcExternalReference, IfcLibrarySelect
	{
		//1	Location : IfcURIReference
		//2	Identification : IfcIdentifier
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	Language : IfcLanguageId
		//6	ReferencedLibrary : IfcLibraryInformation

		public IfcText Description { get; set; }
		public IfcLanguageId Language { get; set; }
		public IfcLibraryInformation ReferencedLibrary { get; set; }
		public List<IfcRelAssociatesLibrary> LibraryRefForObjects { get; set; }
		public IfcText GetDescription() { return Description; }

		public IfcLibraryReference() { }

		public IfcLibraryReference(IfcURIReference Location, IfcIdentifier Identification, IfcLabel Name, IfcText Description, IfcLanguageId Language, IfcLibraryInformation ReferencedLibrary)
		{
			this.Location = Location;
			this.Identification = Identification;
			this.Name = Name;
			this.Description = Description;
			this.Language = Language;
			this.ReferencedLibrary = ReferencedLibrary;
		}
	}

	public class IfcLightDistributionData : IfcBase
	{
		//1	MainPlaneAngle : IfcPlaneAngleMeasure
		//2	SecondaryPlaneAngle : List<IfcPlaneAngleMeasure>
		//3	LuminousIntensity : List<IfcLuminousIntensityDistributionMeasure>

		public IfcPlaneAngleMeasure MainPlaneAngle { get; set; }
		public List<IfcPlaneAngleMeasure> SecondaryPlaneAngle { get; set; }
		public List<IfcLuminousIntensityDistributionMeasure> LuminousIntensity { get; set; }

		public IfcLightDistributionData() { }

		public IfcLightDistributionData(IfcPlaneAngleMeasure MainPlaneAngle, List<IfcPlaneAngleMeasure> SecondaryPlaneAngle, List<IfcLuminousIntensityDistributionMeasure> LuminousIntensity)
		{
			this.MainPlaneAngle = MainPlaneAngle;
			this.SecondaryPlaneAngle = SecondaryPlaneAngle;
			this.LuminousIntensity = LuminousIntensity;
		}
	}

	public class IfcLightFixture : IfcFlowTerminal
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	PredefinedType : IfcLightFixtureTypeEnum

		public IfcLightFixtureTypeEnum PredefinedType { get; set; }

		public IfcLightFixture() { }

		public IfcLightFixture(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcLightFixtureTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcLightFixtureType : IfcFlowTerminalType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel
		//10	PredefinedType : IfcLightFixtureTypeEnum

		public IfcLightFixtureTypeEnum PredefinedType { get; set; }

		public IfcLightFixtureType() { }

		public IfcLightFixtureType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType, IfcLightFixtureTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcLightIntensityDistribution : IfcBase
	{
		//1	LightDistributionCurve : IfcLightDistributionCurveEnum
		//2	DistributionData : List<IfcLightDistributionData>

		public IfcLightDistributionCurveEnum LightDistributionCurve { get; set; }
		public List<IfcLightDistributionData> DistributionData { get; set; }

		public IfcLightIntensityDistribution() { }

		public IfcLightIntensityDistribution(IfcLightDistributionCurveEnum LightDistributionCurve, List<IfcLightDistributionData> DistributionData)
		{
			this.LightDistributionCurve = LightDistributionCurve;
			this.DistributionData = DistributionData;
		}
	}

	public abstract class IfcLightSource : IfcGeometricRepresentationItem
	{
		//1	Name : IfcLabel
		//2	LightColour : IfcColourRgb
		//3	AmbientIntensity : IfcNormalisedRatioMeasure
		//4	Intensity : IfcNormalisedRatioMeasure

		public IfcLabel Name { get; set; }
		public IfcColourRgb LightColour { get; set; }
		public IfcNormalisedRatioMeasure AmbientIntensity { get; set; }
		public IfcNormalisedRatioMeasure Intensity { get; set; }

		public IfcLightSource() { }

		public IfcLightSource(IfcLabel Name, IfcColourRgb LightColour, IfcNormalisedRatioMeasure AmbientIntensity, IfcNormalisedRatioMeasure Intensity)
		{
			this.Name = Name;
			this.LightColour = LightColour;
			this.AmbientIntensity = AmbientIntensity;
			this.Intensity = Intensity;
		}
	}

	public class IfcLightSourceAmbient : IfcLightSource
	{
		//1	Name : IfcLabel
		//2	LightColour : IfcColourRgb
		//3	AmbientIntensity : IfcNormalisedRatioMeasure
		//4	Intensity : IfcNormalisedRatioMeasure

		public IfcLightSourceAmbient() { }

		public IfcLightSourceAmbient(IfcLabel Name, IfcColourRgb LightColour, IfcNormalisedRatioMeasure AmbientIntensity, IfcNormalisedRatioMeasure Intensity)
		{
			this.Name = Name;
			this.LightColour = LightColour;
			this.AmbientIntensity = AmbientIntensity;
			this.Intensity = Intensity;
		}
	}

	public class IfcLightSourceDirectional : IfcLightSource
	{
		//1	Name : IfcLabel
		//2	LightColour : IfcColourRgb
		//3	AmbientIntensity : IfcNormalisedRatioMeasure
		//4	Intensity : IfcNormalisedRatioMeasure
		//5	Orientation : IfcDirection

		public IfcDirection Orientation { get; set; }

		public IfcLightSourceDirectional() { }

		public IfcLightSourceDirectional(IfcLabel Name, IfcColourRgb LightColour, IfcNormalisedRatioMeasure AmbientIntensity, IfcNormalisedRatioMeasure Intensity, IfcDirection Orientation)
		{
			this.Name = Name;
			this.LightColour = LightColour;
			this.AmbientIntensity = AmbientIntensity;
			this.Intensity = Intensity;
			this.Orientation = Orientation;
		}
	}

	public class IfcLightSourceGoniometric : IfcLightSource
	{
		//1	Name : IfcLabel
		//2	LightColour : IfcColourRgb
		//3	AmbientIntensity : IfcNormalisedRatioMeasure
		//4	Intensity : IfcNormalisedRatioMeasure
		//5	Position : IfcAxis2Placement3D
		//6	ColourAppearance : IfcColourRgb
		//7	ColourTemperature : IfcThermodynamicTemperatureMeasure
		//8	LuminousFlux : IfcLuminousFluxMeasure
		//9	LightEmissionSource : IfcLightEmissionSourceEnum
		//10	LightDistributionDataSource : IfcLightDistributionDataSourceSelect

		public IfcAxis2Placement3D Position { get; set; }
		public IfcColourRgb ColourAppearance { get; set; }
		public IfcThermodynamicTemperatureMeasure ColourTemperature { get; set; }
		public IfcLuminousFluxMeasure LuminousFlux { get; set; }
		public IfcLightEmissionSourceEnum LightEmissionSource { get; set; }
		public IfcLightDistributionDataSourceSelect LightDistributionDataSource { get; set; }

		public IfcLightSourceGoniometric() { }

		public IfcLightSourceGoniometric(IfcLabel Name, IfcColourRgb LightColour, IfcNormalisedRatioMeasure AmbientIntensity, IfcNormalisedRatioMeasure Intensity, IfcAxis2Placement3D Position, IfcColourRgb ColourAppearance, IfcThermodynamicTemperatureMeasure ColourTemperature, IfcLuminousFluxMeasure LuminousFlux, IfcLightEmissionSourceEnum LightEmissionSource, IfcLightDistributionDataSourceSelect LightDistributionDataSource)
		{
			this.Name = Name;
			this.LightColour = LightColour;
			this.AmbientIntensity = AmbientIntensity;
			this.Intensity = Intensity;
			this.Position = Position;
			this.ColourAppearance = ColourAppearance;
			this.ColourTemperature = ColourTemperature;
			this.LuminousFlux = LuminousFlux;
			this.LightEmissionSource = LightEmissionSource;
			this.LightDistributionDataSource = LightDistributionDataSource;
		}
	}

	public class IfcLightSourcePositional : IfcLightSource
	{
		//1	Name : IfcLabel
		//2	LightColour : IfcColourRgb
		//3	AmbientIntensity : IfcNormalisedRatioMeasure
		//4	Intensity : IfcNormalisedRatioMeasure
		//5	Position : IfcCartesianPoint
		//6	Radius : IfcPositiveLengthMeasure
		//7	ConstantAttenuation : IfcReal
		//8	DistanceAttenuation : IfcReal
		//9	QuadricAttenuation : IfcReal

		public IfcCartesianPoint Position { get; set; }
		public IfcPositiveLengthMeasure Radius { get; set; }
		public IfcReal ConstantAttenuation { get; set; }
		public IfcReal DistanceAttenuation { get; set; }
		public IfcReal QuadricAttenuation { get; set; }

		public IfcLightSourcePositional() { }

		public IfcLightSourcePositional(IfcLabel Name, IfcColourRgb LightColour, IfcNormalisedRatioMeasure AmbientIntensity, IfcNormalisedRatioMeasure Intensity, IfcCartesianPoint Position, IfcPositiveLengthMeasure Radius, IfcReal ConstantAttenuation, IfcReal DistanceAttenuation, IfcReal QuadricAttenuation)
		{
			this.Name = Name;
			this.LightColour = LightColour;
			this.AmbientIntensity = AmbientIntensity;
			this.Intensity = Intensity;
			this.Position = Position;
			this.Radius = Radius;
			this.ConstantAttenuation = ConstantAttenuation;
			this.DistanceAttenuation = DistanceAttenuation;
			this.QuadricAttenuation = QuadricAttenuation;
		}
	}

	public class IfcLightSourceSpot : IfcLightSourcePositional
	{
		//1	Name : IfcLabel
		//2	LightColour : IfcColourRgb
		//3	AmbientIntensity : IfcNormalisedRatioMeasure
		//4	Intensity : IfcNormalisedRatioMeasure
		//5	Position : IfcCartesianPoint
		//6	Radius : IfcPositiveLengthMeasure
		//7	ConstantAttenuation : IfcReal
		//8	DistanceAttenuation : IfcReal
		//9	QuadricAttenuation : IfcReal
		//10	Orientation : IfcDirection
		//11	ConcentrationExponent : IfcReal
		//12	SpreadAngle : IfcPositivePlaneAngleMeasure
		//13	BeamWidthAngle : IfcPositivePlaneAngleMeasure

		public IfcDirection Orientation { get; set; }
		public IfcReal ConcentrationExponent { get; set; }
		public IfcPositivePlaneAngleMeasure SpreadAngle { get; set; }
		public IfcPositivePlaneAngleMeasure BeamWidthAngle { get; set; }

		public IfcLightSourceSpot() { }

		public IfcLightSourceSpot(IfcLabel Name, IfcColourRgb LightColour, IfcNormalisedRatioMeasure AmbientIntensity, IfcNormalisedRatioMeasure Intensity, IfcCartesianPoint Position, IfcPositiveLengthMeasure Radius, IfcReal ConstantAttenuation, IfcReal DistanceAttenuation, IfcReal QuadricAttenuation, IfcDirection Orientation, IfcReal ConcentrationExponent, IfcPositivePlaneAngleMeasure SpreadAngle, IfcPositivePlaneAngleMeasure BeamWidthAngle)
		{
			this.Name = Name;
			this.LightColour = LightColour;
			this.AmbientIntensity = AmbientIntensity;
			this.Intensity = Intensity;
			this.Position = Position;
			this.Radius = Radius;
			this.ConstantAttenuation = ConstantAttenuation;
			this.DistanceAttenuation = DistanceAttenuation;
			this.QuadricAttenuation = QuadricAttenuation;
			this.Orientation = Orientation;
			this.ConcentrationExponent = ConcentrationExponent;
			this.SpreadAngle = SpreadAngle;
			this.BeamWidthAngle = BeamWidthAngle;
		}
	}

	public class IfcLine : IfcCurve
	{
		//1	Pnt : IfcCartesianPoint
		//2	Dir : IfcVector

		public IfcCartesianPoint Pnt { get; set; }
		public IfcVector Dir { get; set; }

		public IfcLine() { }

		public IfcLine(IfcCartesianPoint Pnt, IfcVector Dir)
		{
			this.Pnt = Pnt;
			this.Dir = Dir;
		}
	}

	public class IfcLocalPlacement : IfcObjectPlacement
	{
		//1	PlacementRelTo : IfcObjectPlacement
		//2	RelativePlacement : IfcAxis2Placement

		public IfcObjectPlacement PlacementRelTo { get; set; }
		public IfcAxis2Placement RelativePlacement { get; set; }

		public IfcLocalPlacement() { }

		public IfcLocalPlacement(IfcObjectPlacement PlacementRelTo, IfcAxis2Placement RelativePlacement)
		{
			this.PlacementRelTo = PlacementRelTo;
			this.RelativePlacement = RelativePlacement;
		}
	}

	public class IfcLoop : IfcTopologicalRepresentationItem
	{
		public IfcLoop() { }
	}

	public abstract class IfcManifoldSolidBrep : IfcSolidModel
	{
		//1	Outer : IfcClosedShell

		public IfcClosedShell Outer { get; set; }

		public IfcManifoldSolidBrep() { }

		public IfcManifoldSolidBrep(IfcClosedShell Outer)
		{
			this.Outer = Outer;
		}
	}

	public class IfcMapConversion : IfcCoordinateOperation
	{
		//1	SourceCRS : IfcCoordinateReferenceSystemSelect
		//2	TargetCRS : IfcCoordinateReferenceSystem
		//3	Eastings : IfcLengthMeasure
		//4	Northings : IfcLengthMeasure
		//5	OrthogonalHeight : IfcLengthMeasure
		//6	XAxisAbscissa : IfcReal
		//7	XAxisOrdinate : IfcReal
		//8	Scale : IfcReal

		public IfcLengthMeasure Eastings { get; set; }
		public IfcLengthMeasure Northings { get; set; }
		public IfcLengthMeasure OrthogonalHeight { get; set; }
		public IfcReal XAxisAbscissa { get; set; }
		public IfcReal XAxisOrdinate { get; set; }
		public IfcReal Scale { get; set; }

		public IfcMapConversion() { }

		public IfcMapConversion(IfcCoordinateReferenceSystemSelect SourceCRS, IfcCoordinateReferenceSystem TargetCRS, IfcLengthMeasure Eastings, IfcLengthMeasure Northings, IfcLengthMeasure OrthogonalHeight, IfcReal XAxisAbscissa, IfcReal XAxisOrdinate, IfcReal Scale)
		{
			this.SourceCRS = SourceCRS;
			this.TargetCRS = TargetCRS;
			this.Eastings = Eastings;
			this.Northings = Northings;
			this.OrthogonalHeight = OrthogonalHeight;
			this.XAxisAbscissa = XAxisAbscissa;
			this.XAxisOrdinate = XAxisOrdinate;
			this.Scale = Scale;
		}
	}

	public class IfcMappedItem : IfcRepresentationItem
	{
		//1	MappingSource : IfcRepresentationMap
		//2	MappingTarget : IfcCartesianTransformationOperator

		public IfcRepresentationMap MappingSource { get; set; }
		public IfcCartesianTransformationOperator MappingTarget { get; set; }

		public IfcMappedItem() { }

		public IfcMappedItem(IfcRepresentationMap MappingSource, IfcCartesianTransformationOperator MappingTarget)
		{
			this.MappingSource = MappingSource;
			this.MappingTarget = MappingTarget;
		}
	}

	public class IfcMaterial : IfcMaterialDefinition
	{
		//1	Name : IfcLabel
		//2	Description : IfcText
		//3	Category : IfcLabel

		public IfcLabel Name { get; set; }
		public IfcText Description { get; set; }
		public IfcLabel Category { get; set; }
		public List<IfcMaterialDefinitionRepresentation> HasRepresentation { get; set; }
		public List<IfcMaterialRelationship> IsRelatedWith { get; set; }
		public List<IfcMaterialRelationship> RelatesTo { get; set; }

		public IfcMaterial() { }

		public IfcMaterial(IfcLabel Name, IfcText Description, IfcLabel Category)
		{
			this.Name = Name;
			this.Description = Description;
			this.Category = Category;
		}
	}

	public class IfcMaterialClassificationRelationship : IfcBase
	{
		//1	MaterialClassifications : List<IfcClassificationSelect>
		//2	ClassifiedMaterial : IfcMaterial

		public List<IfcClassificationSelect> MaterialClassifications { get; set; }
		public IfcMaterial ClassifiedMaterial { get; set; }

		public IfcMaterialClassificationRelationship() { }

		public IfcMaterialClassificationRelationship(List<IfcClassificationSelect> MaterialClassifications, IfcMaterial ClassifiedMaterial)
		{
			this.MaterialClassifications = MaterialClassifications;
			this.ClassifiedMaterial = ClassifiedMaterial;
		}
	}

	public class IfcMaterialConstituent : IfcMaterialDefinition
	{
		//1	Name : IfcLabel
		//2	Description : IfcText
		//3	Material : IfcMaterial
		//4	Fraction : IfcNormalisedRatioMeasure
		//5	Category : IfcLabel

		public IfcLabel Name { get; set; }
		public IfcText Description { get; set; }
		public IfcMaterial Material { get; set; }
		public IfcNormalisedRatioMeasure Fraction { get; set; }
		public IfcLabel Category { get; set; }
		public IfcMaterialConstituentSet ToMaterialConstituentSet { get; set; }

		public IfcMaterialConstituent() { }

		public IfcMaterialConstituent(IfcLabel Name, IfcText Description, IfcMaterial Material, IfcNormalisedRatioMeasure Fraction, IfcLabel Category)
		{
			this.Name = Name;
			this.Description = Description;
			this.Material = Material;
			this.Fraction = Fraction;
			this.Category = Category;
		}
	}

	public class IfcMaterialConstituentSet : IfcMaterialDefinition
	{
		//1	Name : IfcLabel
		//2	Description : IfcText
		//3	MaterialConstituents : List<IfcMaterialConstituent>

		public IfcLabel Name { get; set; }
		public IfcText Description { get; set; }
		public List<IfcMaterialConstituent> MaterialConstituents { get; set; }

		public IfcMaterialConstituentSet() { }

		public IfcMaterialConstituentSet(IfcLabel Name, IfcText Description, List<IfcMaterialConstituent> MaterialConstituents)
		{
			this.Name = Name;
			this.Description = Description;
			this.MaterialConstituents = MaterialConstituents;
		}
	}

	public abstract class IfcMaterialDefinition : IfcBase, IfcMaterialSelect, IfcObjectReferenceSelect, IfcResourceObjectSelect
	{
		public List<IfcRelAssociatesMaterial> AssociatedTo { get; set; }
		public List<IfcExternalReferenceRelationship> HasExternalReferences { get; set; }
		public List<IfcMaterialProperties> HasProperties { get; set; }
		public List<IfcRelAssociatesMaterial> GetAssociatedTo() { return AssociatedTo; }

		public IfcMaterialDefinition() { }
	}

	public class IfcMaterialDefinitionRepresentation : IfcProductRepresentation
	{
		//1	Name : IfcLabel
		//2	Description : IfcText
		//3	Representations : List<IfcRepresentation>
		//4	RepresentedMaterial : IfcMaterial

		public IfcMaterial RepresentedMaterial { get; set; }

		public IfcMaterialDefinitionRepresentation() { }

		public IfcMaterialDefinitionRepresentation(IfcLabel Name, IfcText Description, List<IfcRepresentation> Representations, IfcMaterial RepresentedMaterial)
		{
			this.Name = Name;
			this.Description = Description;
			this.Representations = Representations;
			this.RepresentedMaterial = RepresentedMaterial;
		}
	}

	public class IfcMaterialLayer : IfcMaterialDefinition
	{
		//1	Material : IfcMaterial
		//2	LayerThickness : IfcNonNegativeLengthMeasure
		//3	IsVentilated : IfcLogical
		//4	Name : IfcLabel
		//5	Description : IfcText
		//6	Category : IfcLabel
		//7	Priority : IfcInteger

		public IfcMaterial Material { get; set; }
		public IfcNonNegativeLengthMeasure LayerThickness { get; set; }
		public IfcLogical IsVentilated { get; set; }
		public IfcLabel Name { get; set; }
		public IfcText Description { get; set; }
		public IfcLabel Category { get; set; }
		public IfcInteger Priority { get; set; }
		public IfcMaterialLayerSet ToMaterialLayerSet { get; set; }

		public IfcMaterialLayer() { }

		public IfcMaterialLayer(IfcMaterial Material, IfcNonNegativeLengthMeasure LayerThickness, IfcLogical IsVentilated, IfcLabel Name, IfcText Description, IfcLabel Category, IfcInteger Priority)
		{
			this.Material = Material;
			this.LayerThickness = LayerThickness;
			this.IsVentilated = IsVentilated;
			this.Name = Name;
			this.Description = Description;
			this.Category = Category;
			this.Priority = Priority;
		}
	}

	public class IfcMaterialLayerSet : IfcMaterialDefinition
	{
		//1	MaterialLayers : List<IfcMaterialLayer>
		//2	LayerSetName : IfcLabel
		//3	Description : IfcText

		public List<IfcMaterialLayer> MaterialLayers { get; set; }
		public IfcLabel LayerSetName { get; set; }
		public IfcText Description { get; set; }
		public IfcLengthMeasure TotalThickness { get; set; }

		public IfcMaterialLayerSet() { }

		public IfcMaterialLayerSet(List<IfcMaterialLayer> MaterialLayers, IfcLabel LayerSetName, IfcText Description)
		{
			this.MaterialLayers = MaterialLayers;
			this.LayerSetName = LayerSetName;
			this.Description = Description;
		}
	}

	public class IfcMaterialLayerSetUsage : IfcMaterialUsageDefinition
	{
		//1	ForLayerSet : IfcMaterialLayerSet
		//2	LayerSetDirection : IfcLayerSetDirectionEnum
		//3	DirectionSense : IfcDirectionSenseEnum
		//4	OffsetFromReferenceLine : IfcLengthMeasure
		//5	ReferenceExtent : IfcPositiveLengthMeasure

		public IfcMaterialLayerSet ForLayerSet { get; set; }
		public IfcLayerSetDirectionEnum LayerSetDirection { get; set; }
		public IfcDirectionSenseEnum DirectionSense { get; set; }
		public IfcLengthMeasure OffsetFromReferenceLine { get; set; }
		public IfcPositiveLengthMeasure ReferenceExtent { get; set; }

		public IfcMaterialLayerSetUsage() { }

		public IfcMaterialLayerSetUsage(IfcMaterialLayerSet ForLayerSet, IfcLayerSetDirectionEnum LayerSetDirection, IfcDirectionSenseEnum DirectionSense, IfcLengthMeasure OffsetFromReferenceLine, IfcPositiveLengthMeasure ReferenceExtent)
		{
			this.ForLayerSet = ForLayerSet;
			this.LayerSetDirection = LayerSetDirection;
			this.DirectionSense = DirectionSense;
			this.OffsetFromReferenceLine = OffsetFromReferenceLine;
			this.ReferenceExtent = ReferenceExtent;
		}
	}

	public class IfcMaterialLayerWithOffsets : IfcMaterialLayer
	{
		//1	Material : IfcMaterial
		//2	LayerThickness : IfcNonNegativeLengthMeasure
		//3	IsVentilated : IfcLogical
		//4	Name : IfcLabel
		//5	Description : IfcText
		//6	Category : IfcLabel
		//7	Priority : IfcInteger
		//8	OffsetDirection : IfcLayerSetDirectionEnum
		//9	OffsetValues : List<IfcLengthMeasure>

		public IfcLayerSetDirectionEnum OffsetDirection { get; set; }
		public List<IfcLengthMeasure> OffsetValues { get; set; }

		public IfcMaterialLayerWithOffsets() { }

		public IfcMaterialLayerWithOffsets(IfcMaterial Material, IfcNonNegativeLengthMeasure LayerThickness, IfcLogical IsVentilated, IfcLabel Name, IfcText Description, IfcLabel Category, IfcInteger Priority, IfcLayerSetDirectionEnum OffsetDirection, List<IfcLengthMeasure> OffsetValues)
		{
			this.Material = Material;
			this.LayerThickness = LayerThickness;
			this.IsVentilated = IsVentilated;
			this.Name = Name;
			this.Description = Description;
			this.Category = Category;
			this.Priority = Priority;
			this.OffsetDirection = OffsetDirection;
			this.OffsetValues = OffsetValues;
		}
	}

	public class IfcMaterialList : IfcBase
	{
		//1	Materials : List<IfcMaterial>

		public List<IfcMaterial> Materials { get; set; }

		public IfcMaterialList() { }

		public IfcMaterialList(List<IfcMaterial> Materials)
		{
			this.Materials = Materials;
		}
	}

	public class IfcMaterialProfile : IfcMaterialDefinition
	{
		//1	Name : IfcLabel
		//2	Description : IfcText
		//3	Material : IfcMaterial
		//4	Profile : IfcProfileDef
		//5	Priority : IfcInteger
		//6	Category : IfcLabel

		public IfcLabel Name { get; set; }
		public IfcText Description { get; set; }
		public IfcMaterial Material { get; set; }
		public IfcProfileDef Profile { get; set; }
		public IfcInteger Priority { get; set; }
		public IfcLabel Category { get; set; }
		public IfcMaterialProfileSet ToMaterialProfileSet { get; set; }

		public IfcMaterialProfile() { }

		public IfcMaterialProfile(IfcLabel Name, IfcText Description, IfcMaterial Material, IfcProfileDef Profile, IfcInteger Priority, IfcLabel Category)
		{
			this.Name = Name;
			this.Description = Description;
			this.Material = Material;
			this.Profile = Profile;
			this.Priority = Priority;
			this.Category = Category;
		}
	}

	public class IfcMaterialProfileSet : IfcMaterialDefinition
	{
		//1	Name : IfcLabel
		//2	Description : IfcText
		//3	MaterialProfiles : List<IfcMaterialProfile>
		//4	CompositeProfile : IfcCompositeProfileDef

		public IfcLabel Name { get; set; }
		public IfcText Description { get; set; }
		public List<IfcMaterialProfile> MaterialProfiles { get; set; }
		public IfcCompositeProfileDef CompositeProfile { get; set; }

		public IfcMaterialProfileSet() { }

		public IfcMaterialProfileSet(IfcLabel Name, IfcText Description, List<IfcMaterialProfile> MaterialProfiles, IfcCompositeProfileDef CompositeProfile)
		{
			this.Name = Name;
			this.Description = Description;
			this.MaterialProfiles = MaterialProfiles;
			this.CompositeProfile = CompositeProfile;
		}
	}

	public class IfcMaterialProfileSetUsage : IfcMaterialUsageDefinition
	{
		//1	ForProfileSet : IfcMaterialProfileSet
		//2	CardinalPoint : IfcCardinalPointReference
		//3	ReferenceExtent : IfcPositiveLengthMeasure

		public IfcMaterialProfileSet ForProfileSet { get; set; }
		public IfcCardinalPointReference CardinalPoint { get; set; }
		public IfcPositiveLengthMeasure ReferenceExtent { get; set; }

		public IfcMaterialProfileSetUsage() { }

		public IfcMaterialProfileSetUsage(IfcMaterialProfileSet ForProfileSet, IfcCardinalPointReference CardinalPoint, IfcPositiveLengthMeasure ReferenceExtent)
		{
			this.ForProfileSet = ForProfileSet;
			this.CardinalPoint = CardinalPoint;
			this.ReferenceExtent = ReferenceExtent;
		}
	}

	public class IfcMaterialProfileSetUsageTapering : IfcMaterialProfileSetUsage
	{
		//1	ForProfileSet : IfcMaterialProfileSet
		//2	CardinalPoint : IfcCardinalPointReference
		//3	ReferenceExtent : IfcPositiveLengthMeasure
		//4	ForProfileEndSet : IfcMaterialProfileSet
		//5	CardinalEndPoint : IfcCardinalPointReference

		public IfcMaterialProfileSet ForProfileEndSet { get; set; }
		public IfcCardinalPointReference CardinalEndPoint { get; set; }

		public IfcMaterialProfileSetUsageTapering() { }

		public IfcMaterialProfileSetUsageTapering(IfcMaterialProfileSet ForProfileSet, IfcCardinalPointReference CardinalPoint, IfcPositiveLengthMeasure ReferenceExtent, IfcMaterialProfileSet ForProfileEndSet, IfcCardinalPointReference CardinalEndPoint)
		{
			this.ForProfileSet = ForProfileSet;
			this.CardinalPoint = CardinalPoint;
			this.ReferenceExtent = ReferenceExtent;
			this.ForProfileEndSet = ForProfileEndSet;
			this.CardinalEndPoint = CardinalEndPoint;
		}
	}

	public class IfcMaterialProfileWithOffsets : IfcMaterialProfile
	{
		//1	Name : IfcLabel
		//2	Description : IfcText
		//3	Material : IfcMaterial
		//4	Profile : IfcProfileDef
		//5	Priority : IfcInteger
		//6	Category : IfcLabel
		//7	OffsetValues : List<IfcLengthMeasure>

		public List<IfcLengthMeasure> OffsetValues { get; set; }

		public IfcMaterialProfileWithOffsets() { }

		public IfcMaterialProfileWithOffsets(IfcLabel Name, IfcText Description, IfcMaterial Material, IfcProfileDef Profile, IfcInteger Priority, IfcLabel Category, List<IfcLengthMeasure> OffsetValues)
		{
			this.Name = Name;
			this.Description = Description;
			this.Material = Material;
			this.Profile = Profile;
			this.Priority = Priority;
			this.Category = Category;
			this.OffsetValues = OffsetValues;
		}
	}

	public class IfcMaterialProperties : IfcExtendedProperties
	{
		//1	Name : IfcIdentifier
		//2	Description : IfcText
		//3	Properties : List<IfcProperty>
		//4	Material : IfcMaterialDefinition

		public IfcMaterialDefinition Material { get; set; }

		public IfcMaterialProperties() { }

		public IfcMaterialProperties(IfcIdentifier Name, IfcText Description, List<IfcProperty> Properties, IfcMaterialDefinition Material)
		{
			this.Name = Name;
			this.Description = Description;
			this.Properties = Properties;
			this.Material = Material;
		}
	}

	public class IfcMaterialRelationship : IfcResourceLevelRelationship
	{
		//1	Name : IfcLabel
		//2	Description : IfcText
		//3	RelatingMaterial : IfcMaterial
		//4	RelatedMaterials : List<IfcMaterial>
		//5	Expression : IfcLabel

		public IfcMaterial RelatingMaterial { get; set; }
		public List<IfcMaterial> RelatedMaterials { get; set; }
		public IfcLabel Expression { get; set; }

		public IfcMaterialRelationship() { }

		public IfcMaterialRelationship(IfcLabel Name, IfcText Description, IfcMaterial RelatingMaterial, List<IfcMaterial> RelatedMaterials, IfcLabel Expression)
		{
			this.Name = Name;
			this.Description = Description;
			this.RelatingMaterial = RelatingMaterial;
			this.RelatedMaterials = RelatedMaterials;
			this.Expression = Expression;
		}
	}

	public abstract class IfcMaterialUsageDefinition : IfcBase, IfcMaterialSelect
	{
		public List<IfcRelAssociatesMaterial> AssociatedTo { get; set; }
		public List<IfcRelAssociatesMaterial> GetAssociatedTo() { return AssociatedTo; }

		public IfcMaterialUsageDefinition() { }
	}

	public class IfcMeasureWithUnit : IfcBase
	{
		//1	ValueComponent : IfcValue
		//2	UnitComponent : IfcUnit

		public IfcValue ValueComponent { get; set; }
		public IfcUnit UnitComponent { get; set; }

		public IfcMeasureWithUnit() { }

		public IfcMeasureWithUnit(IfcValue ValueComponent, IfcUnit UnitComponent)
		{
			this.ValueComponent = ValueComponent;
			this.UnitComponent = UnitComponent;
		}
	}

	public class IfcMechanicalFastener : IfcElementComponent
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	NominalDiameter : IfcPositiveLengthMeasure
		//10	NominalLength : IfcPositiveLengthMeasure
		//11	PredefinedType : IfcMechanicalFastenerTypeEnum

		public IfcPositiveLengthMeasure NominalDiameter { get; set; }
		public IfcPositiveLengthMeasure NominalLength { get; set; }
		public IfcMechanicalFastenerTypeEnum PredefinedType { get; set; }

		public IfcMechanicalFastener() { }

		public IfcMechanicalFastener(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcPositiveLengthMeasure NominalDiameter, IfcPositiveLengthMeasure NominalLength, IfcMechanicalFastenerTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.NominalDiameter = NominalDiameter;
			this.NominalLength = NominalLength;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcMechanicalFastenerType : IfcElementComponentType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel
		//10	PredefinedType : IfcMechanicalFastenerTypeEnum
		//11	NominalDiameter : IfcPositiveLengthMeasure
		//12	NominalLength : IfcPositiveLengthMeasure

		public IfcMechanicalFastenerTypeEnum PredefinedType { get; set; }
		public IfcPositiveLengthMeasure NominalDiameter { get; set; }
		public IfcPositiveLengthMeasure NominalLength { get; set; }

		public IfcMechanicalFastenerType() { }

		public IfcMechanicalFastenerType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType, IfcMechanicalFastenerTypeEnum PredefinedType, IfcPositiveLengthMeasure NominalDiameter, IfcPositiveLengthMeasure NominalLength)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
			this.PredefinedType = PredefinedType;
			this.NominalDiameter = NominalDiameter;
			this.NominalLength = NominalLength;
		}
	}

	public class IfcMedicalDevice : IfcFlowTerminal
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	PredefinedType : IfcMedicalDeviceTypeEnum

		public IfcMedicalDeviceTypeEnum PredefinedType { get; set; }

		public IfcMedicalDevice() { }

		public IfcMedicalDevice(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcMedicalDeviceTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcMedicalDeviceType : IfcFlowTerminalType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel
		//10	PredefinedType : IfcMedicalDeviceTypeEnum

		public IfcMedicalDeviceTypeEnum PredefinedType { get; set; }

		public IfcMedicalDeviceType() { }

		public IfcMedicalDeviceType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType, IfcMedicalDeviceTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcMember : IfcBuildingElement
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	PredefinedType : IfcMemberTypeEnum

		public IfcMemberTypeEnum PredefinedType { get; set; }

		public IfcMember() { }

		public IfcMember(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcMemberTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcMemberStandardCase : IfcMember
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	PredefinedType : IfcMemberTypeEnum

		public IfcMemberStandardCase() { }

		public IfcMemberStandardCase(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcMemberTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcMemberType : IfcBuildingElementType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel
		//10	PredefinedType : IfcMemberTypeEnum

		public IfcMemberTypeEnum PredefinedType { get; set; }

		public IfcMemberType() { }

		public IfcMemberType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType, IfcMemberTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcMetric : IfcConstraint
	{
		//1	Name : IfcLabel
		//2	Description : IfcText
		//3	ConstraintGrade : IfcConstraintEnum
		//4	ConstraintSource : IfcLabel
		//5	CreatingActor : IfcActorSelect
		//6	CreationTime : IfcDateTime
		//7	UserDefinedGrade : IfcLabel
		//8	Benchmark : IfcBenchmarkEnum
		//9	ValueSource : IfcLabel
		//10	DataValue : IfcMetricValueSelect
		//11	ReferencePath : IfcReference

		public IfcBenchmarkEnum Benchmark { get; set; }
		public IfcLabel ValueSource { get; set; }
		public IfcMetricValueSelect DataValue { get; set; }
		public IfcReference ReferencePath { get; set; }

		public IfcMetric() { }

		public IfcMetric(IfcLabel Name, IfcText Description, IfcConstraintEnum ConstraintGrade, IfcLabel ConstraintSource, IfcActorSelect CreatingActor, IfcDateTime CreationTime, IfcLabel UserDefinedGrade, IfcBenchmarkEnum Benchmark, IfcLabel ValueSource, IfcMetricValueSelect DataValue, IfcReference ReferencePath)
		{
			this.Name = Name;
			this.Description = Description;
			this.ConstraintGrade = ConstraintGrade;
			this.ConstraintSource = ConstraintSource;
			this.CreatingActor = CreatingActor;
			this.CreationTime = CreationTime;
			this.UserDefinedGrade = UserDefinedGrade;
			this.Benchmark = Benchmark;
			this.ValueSource = ValueSource;
			this.DataValue = DataValue;
			this.ReferencePath = ReferencePath;
		}
	}

	public class IfcMirroredProfileDef : IfcDerivedProfileDef
	{
		//1	ProfileType : IfcProfileTypeEnum
		//2	ProfileName : IfcLabel
		//3	ParentProfile : IfcProfileDef
		//4	Operator : IfcCartesianTransformationOperator2D
		//5	Label : IfcLabel

		public IfcMirroredProfileDef() { }

		public IfcMirroredProfileDef(IfcProfileTypeEnum ProfileType, IfcLabel ProfileName, IfcProfileDef ParentProfile, IfcCartesianTransformationOperator2D Operator, IfcLabel Label)
		{
			this.ProfileType = ProfileType;
			this.ProfileName = ProfileName;
			this.ParentProfile = ParentProfile;
			this.Operator = Operator;
			this.Label = Label;
		}
	}

	public class IfcMonetaryUnit : IfcBase
	{
		//1	Currency : IfcLabel

		public IfcLabel Currency { get; set; }

		public IfcMonetaryUnit() { }

		public IfcMonetaryUnit(IfcLabel Currency)
		{
			this.Currency = Currency;
		}
	}

	public class IfcMotorConnection : IfcEnergyConversionDevice
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	PredefinedType : IfcMotorConnectionTypeEnum

		public IfcMotorConnectionTypeEnum PredefinedType { get; set; }

		public IfcMotorConnection() { }

		public IfcMotorConnection(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcMotorConnectionTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcMotorConnectionType : IfcEnergyConversionDeviceType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel
		//10	PredefinedType : IfcMotorConnectionTypeEnum

		public IfcMotorConnectionTypeEnum PredefinedType { get; set; }

		public IfcMotorConnectionType() { }

		public IfcMotorConnectionType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType, IfcMotorConnectionTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
			this.PredefinedType = PredefinedType;
		}
	}

	public abstract class IfcNamedUnit : IfcBase, IfcUnit
	{
		//1	Dimensions : IfcDimensionalExponents
		//2	UnitType : IfcUnitEnum

		public IfcDimensionalExponents Dimensions { get; set; }
		public IfcUnitEnum UnitType { get; set; }
		public IfcDimensionalExponents GetDimensions() { return Dimensions; }
		public IfcUnitEnum GetUnitType() { return UnitType; }

		public IfcNamedUnit() { }

		public IfcNamedUnit(IfcDimensionalExponents Dimensions, IfcUnitEnum UnitType)
		{
			this.Dimensions = Dimensions;
			this.UnitType = UnitType;
		}
	}

	public abstract class IfcObject : IfcObjectDefinition
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel

		public IfcLabel ObjectType { get; set; }
		public List<IfcRelDefinesByObject> IsDeclaredBy { get; set; }
		public List<IfcRelDefinesByObject> Declares { get; set; }
		public List<IfcRelDefinesByType> IsTypedBy { get; set; }
		public List<IfcRelDefinesByProperties> IsDefinedBy { get; set; }

		public IfcObject() { }

		public IfcObject(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
		}
	}

	public abstract class IfcObjectDefinition : IfcRoot, IfcDefinitionSelect
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText

		public List<IfcRelAssigns> HasAssignments { get; set; }
		public List<IfcRelNests> Nests { get; set; }
		public List<IfcRelNests> IsNestedBy { get; set; }
		public List<IfcRelDeclares> HasContext { get; set; }
		public List<IfcRelAggregates> IsDecomposedBy { get; set; }
		public List<IfcRelAggregates> Decomposes { get; set; }
		public List<IfcRelAssociates> HasAssociations { get; set; }
		public List<IfcRelDeclares> GetHasContext() { return HasContext; }
		public List<IfcRelAssociates> GetHasAssociations() { return HasAssociations; }

		public IfcObjectDefinition() { }

		public IfcObjectDefinition(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
		}
	}

	public abstract class IfcObjectPlacement : IfcBase
	{
		public List<IfcProduct> PlacesObject { get; set; }
		public List<IfcLocalPlacement> ReferencedByPlacements { get; set; }

		public IfcObjectPlacement() { }
	}

	public class IfcObjective : IfcConstraint
	{
		//1	Name : IfcLabel
		//2	Description : IfcText
		//3	ConstraintGrade : IfcConstraintEnum
		//4	ConstraintSource : IfcLabel
		//5	CreatingActor : IfcActorSelect
		//6	CreationTime : IfcDateTime
		//7	UserDefinedGrade : IfcLabel
		//8	BenchmarkValues : List<IfcConstraint>
		//9	LogicalAggregator : IfcLogicalOperatorEnum
		//10	ObjectiveQualifier : IfcObjectiveEnum
		//11	UserDefinedQualifier : IfcLabel

		public List<IfcConstraint> BenchmarkValues { get; set; }
		public IfcLogicalOperatorEnum LogicalAggregator { get; set; }
		public IfcObjectiveEnum ObjectiveQualifier { get; set; }
		public IfcLabel UserDefinedQualifier { get; set; }

		public IfcObjective() { }

		public IfcObjective(IfcLabel Name, IfcText Description, IfcConstraintEnum ConstraintGrade, IfcLabel ConstraintSource, IfcActorSelect CreatingActor, IfcDateTime CreationTime, IfcLabel UserDefinedGrade, List<IfcConstraint> BenchmarkValues, IfcLogicalOperatorEnum LogicalAggregator, IfcObjectiveEnum ObjectiveQualifier, IfcLabel UserDefinedQualifier)
		{
			this.Name = Name;
			this.Description = Description;
			this.ConstraintGrade = ConstraintGrade;
			this.ConstraintSource = ConstraintSource;
			this.CreatingActor = CreatingActor;
			this.CreationTime = CreationTime;
			this.UserDefinedGrade = UserDefinedGrade;
			this.BenchmarkValues = BenchmarkValues;
			this.LogicalAggregator = LogicalAggregator;
			this.ObjectiveQualifier = ObjectiveQualifier;
			this.UserDefinedQualifier = UserDefinedQualifier;
		}
	}

	public class IfcOccupant : IfcActor
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	TheActor : IfcActorSelect
		//7	PredefinedType : IfcOccupantTypeEnum

		public IfcOccupantTypeEnum PredefinedType { get; set; }

		public IfcOccupant() { }

		public IfcOccupant(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcActorSelect TheActor, IfcOccupantTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.TheActor = TheActor;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcOffsetCurve2D : IfcCurve
	{
		//1	BasisCurve : IfcCurve
		//2	Distance : IfcLengthMeasure
		//3	SelfIntersect : IfcLogical

		public IfcCurve BasisCurve { get; set; }
		public IfcLengthMeasure Distance { get; set; }
		public IfcLogical SelfIntersect { get; set; }

		public IfcOffsetCurve2D() { }

		public IfcOffsetCurve2D(IfcCurve BasisCurve, IfcLengthMeasure Distance, IfcLogical SelfIntersect)
		{
			this.BasisCurve = BasisCurve;
			this.Distance = Distance;
			this.SelfIntersect = SelfIntersect;
		}
	}

	public class IfcOffsetCurve3D : IfcCurve
	{
		//1	BasisCurve : IfcCurve
		//2	Distance : IfcLengthMeasure
		//3	SelfIntersect : IfcLogical
		//4	RefDirection : IfcDirection

		public IfcCurve BasisCurve { get; set; }
		public IfcLengthMeasure Distance { get; set; }
		public IfcLogical SelfIntersect { get; set; }
		public IfcDirection RefDirection { get; set; }

		public IfcOffsetCurve3D() { }

		public IfcOffsetCurve3D(IfcCurve BasisCurve, IfcLengthMeasure Distance, IfcLogical SelfIntersect, IfcDirection RefDirection)
		{
			this.BasisCurve = BasisCurve;
			this.Distance = Distance;
			this.SelfIntersect = SelfIntersect;
			this.RefDirection = RefDirection;
		}
	}

	public class IfcOpenShell : IfcConnectedFaceSet, IfcShell
	{
		//1	CfsFaces : List<IfcFace>

		public IfcOpenShell() { }

		public IfcOpenShell(List<IfcFace> CfsFaces)
		{
			this.CfsFaces = CfsFaces;
		}
	}

	public class IfcOpeningElement : IfcFeatureElementSubtraction
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	PredefinedType : IfcOpeningElementTypeEnum

		public IfcOpeningElementTypeEnum PredefinedType { get; set; }
		public List<IfcRelFillsElement> HasFillings { get; set; }

		public IfcOpeningElement() { }

		public IfcOpeningElement(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcOpeningElementTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcOpeningStandardCase : IfcOpeningElement
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	PredefinedType : IfcOpeningElementTypeEnum

		public IfcOpeningStandardCase() { }

		public IfcOpeningStandardCase(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcOpeningElementTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcOrganization : IfcBase
	{
		//1	Identification : IfcIdentifier
		//2	Name : IfcLabel
		//3	Description : IfcText
		//4	Roles : List<IfcActorRole>
		//5	Addresses : List<IfcAddress>

		public IfcIdentifier Identification { get; set; }
		public IfcLabel Name { get; set; }
		public IfcText Description { get; set; }
		public List<IfcActorRole> Roles { get; set; }
		public List<IfcAddress> Addresses { get; set; }
		public List<IfcOrganizationRelationship> IsRelatedBy { get; set; }
		public List<IfcOrganizationRelationship> Relates { get; set; }
		public List<IfcPersonAndOrganization> Engages { get; set; }

		public IfcOrganization() { }

		public IfcOrganization(IfcIdentifier Identification, IfcLabel Name, IfcText Description, List<IfcActorRole> Roles, List<IfcAddress> Addresses)
		{
			this.Identification = Identification;
			this.Name = Name;
			this.Description = Description;
			this.Roles = Roles;
			this.Addresses = Addresses;
		}
	}

	public class IfcOrganizationRelationship : IfcResourceLevelRelationship
	{
		//1	Name : IfcLabel
		//2	Description : IfcText
		//3	RelatingOrganization : IfcOrganization
		//4	RelatedOrganizations : List<IfcOrganization>

		public IfcOrganization RelatingOrganization { get; set; }
		public List<IfcOrganization> RelatedOrganizations { get; set; }

		public IfcOrganizationRelationship() { }

		public IfcOrganizationRelationship(IfcLabel Name, IfcText Description, IfcOrganization RelatingOrganization, List<IfcOrganization> RelatedOrganizations)
		{
			this.Name = Name;
			this.Description = Description;
			this.RelatingOrganization = RelatingOrganization;
			this.RelatedOrganizations = RelatedOrganizations;
		}
	}

	public class IfcOrientedEdge : IfcEdge
	{
		//1	EdgeStart : IfcVertex
		//2	EdgeEnd : IfcVertex
		//3	EdgeElement : IfcEdge
		//4	Orientation : IfcBoolean

		public IfcEdge EdgeElement { get; set; }
		public IfcBoolean Orientation { get; set; }

		public IfcOrientedEdge() { }

		public IfcOrientedEdge(IfcVertex EdgeStart, IfcVertex EdgeEnd, IfcEdge EdgeElement, IfcBoolean Orientation)
		{
			this.EdgeStart = EdgeStart;
			this.EdgeEnd = EdgeEnd;
			this.EdgeElement = EdgeElement;
			this.Orientation = Orientation;
		}
	}

	public class IfcOuterBoundaryCurve : IfcBoundaryCurve
	{
		//1	Segments : List<IfcCompositeCurveSegment>
		//2	SelfIntersect : IfcLogical

		public IfcOuterBoundaryCurve() { }

		public IfcOuterBoundaryCurve(List<IfcCompositeCurveSegment> Segments, IfcLogical SelfIntersect)
		{
			this.Segments = Segments;
			this.SelfIntersect = SelfIntersect;
		}
	}

	public class IfcOutlet : IfcFlowTerminal
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	PredefinedType : IfcOutletTypeEnum

		public IfcOutletTypeEnum PredefinedType { get; set; }

		public IfcOutlet() { }

		public IfcOutlet(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcOutletTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcOutletType : IfcFlowTerminalType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel
		//10	PredefinedType : IfcOutletTypeEnum

		public IfcOutletTypeEnum PredefinedType { get; set; }

		public IfcOutletType() { }

		public IfcOutletType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType, IfcOutletTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcOwnerHistory : IfcBase
	{
		//1	OwningUser : IfcPersonAndOrganization
		//2	OwningApplication : IfcApplication
		//3	State : IfcStateEnum
		//4	ChangeAction : IfcChangeActionEnum
		//5	LastModifiedDate : IfcTimeStamp
		//6	LastModifyingUser : IfcPersonAndOrganization
		//7	LastModifyingApplication : IfcApplication
		//8	CreationDate : IfcTimeStamp

		public IfcPersonAndOrganization OwningUser { get; set; }
		public IfcApplication OwningApplication { get; set; }
		public IfcStateEnum State { get; set; }
		public IfcChangeActionEnum ChangeAction { get; set; }
		public IfcTimeStamp LastModifiedDate { get; set; }
		public IfcPersonAndOrganization LastModifyingUser { get; set; }
		public IfcApplication LastModifyingApplication { get; set; }
		public IfcTimeStamp CreationDate { get; set; }

		public IfcOwnerHistory() { }

		public IfcOwnerHistory(IfcPersonAndOrganization OwningUser, IfcApplication OwningApplication, IfcStateEnum State, IfcChangeActionEnum ChangeAction, IfcTimeStamp LastModifiedDate, IfcPersonAndOrganization LastModifyingUser, IfcApplication LastModifyingApplication, IfcTimeStamp CreationDate)
		{
			this.OwningUser = OwningUser;
			this.OwningApplication = OwningApplication;
			this.State = State;
			this.ChangeAction = ChangeAction;
			this.LastModifiedDate = LastModifiedDate;
			this.LastModifyingUser = LastModifyingUser;
			this.LastModifyingApplication = LastModifyingApplication;
			this.CreationDate = CreationDate;
		}
	}

	public abstract class IfcParameterizedProfileDef : IfcProfileDef
	{
		//1	ProfileType : IfcProfileTypeEnum
		//2	ProfileName : IfcLabel
		//3	Position : IfcAxis2Placement2D

		public IfcAxis2Placement2D Position { get; set; }

		public IfcParameterizedProfileDef() { }

		public IfcParameterizedProfileDef(IfcProfileTypeEnum ProfileType, IfcLabel ProfileName, IfcAxis2Placement2D Position)
		{
			this.ProfileType = ProfileType;
			this.ProfileName = ProfileName;
			this.Position = Position;
		}
	}

	public class IfcPath : IfcTopologicalRepresentationItem
	{
		//1	EdgeList : List<IfcOrientedEdge>

		public List<IfcOrientedEdge> EdgeList { get; set; }

		public IfcPath() { }

		public IfcPath(List<IfcOrientedEdge> EdgeList)
		{
			this.EdgeList = EdgeList;
		}
	}

	public class IfcPcurve : IfcCurve, IfcCurveOnSurface
	{
		//1	BasisSurface : IfcSurface
		//2	ReferenceCurve : IfcCurve

		public IfcSurface BasisSurface { get; set; }
		public IfcCurve ReferenceCurve { get; set; }

		public IfcPcurve() { }

		public IfcPcurve(IfcSurface BasisSurface, IfcCurve ReferenceCurve)
		{
			this.BasisSurface = BasisSurface;
			this.ReferenceCurve = ReferenceCurve;
		}
	}

	public class IfcPerformanceHistory : IfcControl
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	Identification : IfcIdentifier
		//7	LifeCyclePhase : IfcLabel
		//8	PredefinedType : IfcPerformanceHistoryTypeEnum

		public IfcLabel LifeCyclePhase { get; set; }
		public IfcPerformanceHistoryTypeEnum PredefinedType { get; set; }

		public IfcPerformanceHistory() { }

		public IfcPerformanceHistory(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcIdentifier Identification, IfcLabel LifeCyclePhase, IfcPerformanceHistoryTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.Identification = Identification;
			this.LifeCyclePhase = LifeCyclePhase;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcPermeableCoveringProperties : IfcPreDefinedPropertySet
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	OperationType : IfcPermeableCoveringOperationEnum
		//6	PanelPosition : IfcWindowPanelPositionEnum
		//7	FrameDepth : IfcPositiveLengthMeasure
		//8	FrameThickness : IfcPositiveLengthMeasure
		//9	ShapeAspectStyle : IfcShapeAspect

		public IfcPermeableCoveringOperationEnum OperationType { get; set; }
		public IfcWindowPanelPositionEnum PanelPosition { get; set; }
		public IfcPositiveLengthMeasure FrameDepth { get; set; }
		public IfcPositiveLengthMeasure FrameThickness { get; set; }
		public IfcShapeAspect ShapeAspectStyle { get; set; }

		public IfcPermeableCoveringProperties() { }

		public IfcPermeableCoveringProperties(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcPermeableCoveringOperationEnum OperationType, IfcWindowPanelPositionEnum PanelPosition, IfcPositiveLengthMeasure FrameDepth, IfcPositiveLengthMeasure FrameThickness, IfcShapeAspect ShapeAspectStyle)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.OperationType = OperationType;
			this.PanelPosition = PanelPosition;
			this.FrameDepth = FrameDepth;
			this.FrameThickness = FrameThickness;
			this.ShapeAspectStyle = ShapeAspectStyle;
		}
	}

	public class IfcPermit : IfcControl
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	Identification : IfcIdentifier
		//7	PredefinedType : IfcPermitTypeEnum
		//8	Status : IfcLabel
		//9	LongDescription : IfcText

		public IfcPermitTypeEnum PredefinedType { get; set; }
		public IfcLabel Status { get; set; }
		public IfcText LongDescription { get; set; }

		public IfcPermit() { }

		public IfcPermit(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcIdentifier Identification, IfcPermitTypeEnum PredefinedType, IfcLabel Status, IfcText LongDescription)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.Identification = Identification;
			this.PredefinedType = PredefinedType;
			this.Status = Status;
			this.LongDescription = LongDescription;
		}
	}

	public class IfcPerson : IfcBase
	{
		//1	Identification : IfcIdentifier
		//2	FamilyName : IfcLabel
		//3	GivenName : IfcLabel
		//4	MiddleNames : List<IfcLabel>
		//5	PrefixTitles : List<IfcLabel>
		//6	SuffixTitles : List<IfcLabel>
		//7	Roles : List<IfcActorRole>
		//8	Addresses : List<IfcAddress>

		public IfcIdentifier Identification { get; set; }
		public IfcLabel FamilyName { get; set; }
		public IfcLabel GivenName { get; set; }
		public List<IfcLabel> MiddleNames { get; set; }
		public List<IfcLabel> PrefixTitles { get; set; }
		public List<IfcLabel> SuffixTitles { get; set; }
		public List<IfcActorRole> Roles { get; set; }
		public List<IfcAddress> Addresses { get; set; }
		public List<IfcPersonAndOrganization> EngagedIn { get; set; }

		public IfcPerson() { }

		public IfcPerson(IfcIdentifier Identification, IfcLabel FamilyName, IfcLabel GivenName, List<IfcLabel> MiddleNames, List<IfcLabel> PrefixTitles, List<IfcLabel> SuffixTitles, List<IfcActorRole> Roles, List<IfcAddress> Addresses)
		{
			this.Identification = Identification;
			this.FamilyName = FamilyName;
			this.GivenName = GivenName;
			this.MiddleNames = MiddleNames;
			this.PrefixTitles = PrefixTitles;
			this.SuffixTitles = SuffixTitles;
			this.Roles = Roles;
			this.Addresses = Addresses;
		}
	}

	public class IfcPersonAndOrganization : IfcBase
	{
		//1	ThePerson : IfcPerson
		//2	TheOrganization : IfcOrganization
		//3	Roles : List<IfcActorRole>

		public IfcPerson ThePerson { get; set; }
		public IfcOrganization TheOrganization { get; set; }
		public List<IfcActorRole> Roles { get; set; }

		public IfcPersonAndOrganization() { }

		public IfcPersonAndOrganization(IfcPerson ThePerson, IfcOrganization TheOrganization, List<IfcActorRole> Roles)
		{
			this.ThePerson = ThePerson;
			this.TheOrganization = TheOrganization;
			this.Roles = Roles;
		}
	}

	public class IfcPhysicalComplexQuantity : IfcPhysicalQuantity
	{
		//1	Name : IfcLabel
		//2	Description : IfcText
		//3	HasQuantities : List<IfcPhysicalQuantity>
		//4	Discrimination : IfcLabel
		//5	Quality : IfcLabel
		//6	Usage : IfcLabel

		public List<IfcPhysicalQuantity> HasQuantities { get; set; }
		public IfcLabel Discrimination { get; set; }
		public IfcLabel Quality { get; set; }
		public IfcLabel Usage { get; set; }

		public IfcPhysicalComplexQuantity() { }

		public IfcPhysicalComplexQuantity(IfcLabel Name, IfcText Description, List<IfcPhysicalQuantity> HasQuantities, IfcLabel Discrimination, IfcLabel Quality, IfcLabel Usage)
		{
			this.Name = Name;
			this.Description = Description;
			this.HasQuantities = HasQuantities;
			this.Discrimination = Discrimination;
			this.Quality = Quality;
			this.Usage = Usage;
		}
	}

	public abstract class IfcPhysicalQuantity : IfcBase, IfcResourceObjectSelect
	{
		//1	Name : IfcLabel
		//2	Description : IfcText

		public IfcLabel Name { get; set; }
		public IfcText Description { get; set; }
		public List<IfcExternalReferenceRelationship> HasExternalReferences { get; set; }
		public List<IfcPhysicalComplexQuantity> PartOfComplex { get; set; }

		public IfcPhysicalQuantity() { }

		public IfcPhysicalQuantity(IfcLabel Name, IfcText Description)
		{
			this.Name = Name;
			this.Description = Description;
		}
	}

	public abstract class IfcPhysicalSimpleQuantity : IfcPhysicalQuantity
	{
		//1	Name : IfcLabel
		//2	Description : IfcText
		//3	Unit : IfcNamedUnit

		public IfcNamedUnit Unit { get; set; }

		public IfcPhysicalSimpleQuantity() { }

		public IfcPhysicalSimpleQuantity(IfcLabel Name, IfcText Description, IfcNamedUnit Unit)
		{
			this.Name = Name;
			this.Description = Description;
			this.Unit = Unit;
		}
	}

	public class IfcPile : IfcBuildingElement
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	PredefinedType : IfcPileTypeEnum
		//10	ConstructionType : IfcPileConstructionEnum

		public IfcPileTypeEnum PredefinedType { get; set; }
		public IfcPileConstructionEnum ConstructionType { get; set; }

		public IfcPile() { }

		public IfcPile(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcPileTypeEnum PredefinedType, IfcPileConstructionEnum ConstructionType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.PredefinedType = PredefinedType;
			this.ConstructionType = ConstructionType;
		}
	}

	public class IfcPileType : IfcBuildingElementType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel
		//10	PredefinedType : IfcPileTypeEnum

		public IfcPileTypeEnum PredefinedType { get; set; }

		public IfcPileType() { }

		public IfcPileType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType, IfcPileTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcPipeFitting : IfcFlowFitting
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	PredefinedType : IfcPipeFittingTypeEnum

		public IfcPipeFittingTypeEnum PredefinedType { get; set; }

		public IfcPipeFitting() { }

		public IfcPipeFitting(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcPipeFittingTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcPipeFittingType : IfcFlowFittingType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel
		//10	PredefinedType : IfcPipeFittingTypeEnum

		public IfcPipeFittingTypeEnum PredefinedType { get; set; }

		public IfcPipeFittingType() { }

		public IfcPipeFittingType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType, IfcPipeFittingTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcPipeSegment : IfcFlowSegment
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	PredefinedType : IfcPipeSegmentTypeEnum

		public IfcPipeSegmentTypeEnum PredefinedType { get; set; }

		public IfcPipeSegment() { }

		public IfcPipeSegment(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcPipeSegmentTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcPipeSegmentType : IfcFlowSegmentType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel
		//10	PredefinedType : IfcPipeSegmentTypeEnum

		public IfcPipeSegmentTypeEnum PredefinedType { get; set; }

		public IfcPipeSegmentType() { }

		public IfcPipeSegmentType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType, IfcPipeSegmentTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcPixelTexture : IfcSurfaceTexture
	{
		//1	RepeatS : IfcBoolean
		//2	RepeatT : IfcBoolean
		//3	Mode : IfcIdentifier
		//4	TextureTransform : IfcCartesianTransformationOperator2D
		//5	Parameter : List<IfcIdentifier>
		//6	Width : IfcInteger
		//7	Height : IfcInteger
		//8	ColourComponents : IfcInteger
		//9	Pixel : List<IfcBinary>

		public IfcInteger Width { get; set; }
		public IfcInteger Height { get; set; }
		public IfcInteger ColourComponents { get; set; }
		public List<IfcBinary> Pixel { get; set; }

		public IfcPixelTexture() { }

		public IfcPixelTexture(IfcBoolean RepeatS, IfcBoolean RepeatT, IfcIdentifier Mode, IfcCartesianTransformationOperator2D TextureTransform, List<IfcIdentifier> Parameter, IfcInteger Width, IfcInteger Height, IfcInteger ColourComponents, List<IfcBinary> Pixel)
		{
			this.RepeatS = RepeatS;
			this.RepeatT = RepeatT;
			this.Mode = Mode;
			this.TextureTransform = TextureTransform;
			this.Parameter = Parameter;
			this.Width = Width;
			this.Height = Height;
			this.ColourComponents = ColourComponents;
			this.Pixel = Pixel;
		}
	}

	public abstract class IfcPlacement : IfcGeometricRepresentationItem
	{
		//1	Location : IfcCartesianPoint

		public IfcCartesianPoint Location { get; set; }
		public IfcDimensionCount Dim { get; set; }

		public IfcPlacement() { }

		public IfcPlacement(IfcCartesianPoint Location)
		{
			this.Location = Location;
		}
	}

	public class IfcPlanarBox : IfcPlanarExtent
	{
		//1	SizeInX : IfcLengthMeasure
		//2	SizeInY : IfcLengthMeasure
		//3	Placement : IfcAxis2Placement

		public IfcAxis2Placement Placement { get; set; }

		public IfcPlanarBox() { }

		public IfcPlanarBox(IfcLengthMeasure SizeInX, IfcLengthMeasure SizeInY, IfcAxis2Placement Placement)
		{
			this.SizeInX = SizeInX;
			this.SizeInY = SizeInY;
			this.Placement = Placement;
		}
	}

	public class IfcPlanarExtent : IfcGeometricRepresentationItem
	{
		//1	SizeInX : IfcLengthMeasure
		//2	SizeInY : IfcLengthMeasure

		public IfcLengthMeasure SizeInX { get; set; }
		public IfcLengthMeasure SizeInY { get; set; }

		public IfcPlanarExtent() { }

		public IfcPlanarExtent(IfcLengthMeasure SizeInX, IfcLengthMeasure SizeInY)
		{
			this.SizeInX = SizeInX;
			this.SizeInY = SizeInY;
		}
	}

	public class IfcPlane : IfcElementarySurface
	{
		//1	Position : IfcAxis2Placement3D

		public IfcPlane() { }

		public IfcPlane(IfcAxis2Placement3D Position)
		{
			this.Position = Position;
		}
	}

	public class IfcPlate : IfcBuildingElement
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	PredefinedType : IfcPlateTypeEnum

		public IfcPlateTypeEnum PredefinedType { get; set; }

		public IfcPlate() { }

		public IfcPlate(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcPlateTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcPlateStandardCase : IfcPlate
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	PredefinedType : IfcPlateTypeEnum

		public IfcPlateStandardCase() { }

		public IfcPlateStandardCase(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcPlateTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcPlateType : IfcBuildingElementType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel
		//10	PredefinedType : IfcPlateTypeEnum

		public IfcPlateTypeEnum PredefinedType { get; set; }

		public IfcPlateType() { }

		public IfcPlateType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType, IfcPlateTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
			this.PredefinedType = PredefinedType;
		}
	}

	public abstract class IfcPoint : IfcGeometricRepresentationItem, IfcGeometricSetSelect, IfcPointOrVertexPoint
	{
		public IfcPoint() { }
	}

	public class IfcPointOnCurve : IfcPoint
	{
		//1	BasisCurve : IfcCurve
		//2	PointParameter : IfcParameterValue

		public IfcCurve BasisCurve { get; set; }
		public IfcParameterValue PointParameter { get; set; }
		public IfcDimensionCount Dim { get; set; }

		public IfcPointOnCurve() { }

		public IfcPointOnCurve(IfcCurve BasisCurve, IfcParameterValue PointParameter)
		{
			this.BasisCurve = BasisCurve;
			this.PointParameter = PointParameter;
		}
	}

	public class IfcPointOnSurface : IfcPoint
	{
		//1	BasisSurface : IfcSurface
		//2	PointParameterU : IfcParameterValue
		//3	PointParameterV : IfcParameterValue

		public IfcSurface BasisSurface { get; set; }
		public IfcParameterValue PointParameterU { get; set; }
		public IfcParameterValue PointParameterV { get; set; }
		public IfcDimensionCount Dim { get; set; }

		public IfcPointOnSurface() { }

		public IfcPointOnSurface(IfcSurface BasisSurface, IfcParameterValue PointParameterU, IfcParameterValue PointParameterV)
		{
			this.BasisSurface = BasisSurface;
			this.PointParameterU = PointParameterU;
			this.PointParameterV = PointParameterV;
		}
	}

	public class IfcPolyLoop : IfcLoop
	{
		//1	Polygon : List<IfcCartesianPoint>

		public List<IfcCartesianPoint> Polygon { get; set; }

		public IfcPolyLoop() { }

		public IfcPolyLoop(List<IfcCartesianPoint> Polygon)
		{
			this.Polygon = Polygon;
		}
	}

	public class IfcPolygonalBoundedHalfSpace : IfcHalfSpaceSolid
	{
		//1	BaseSurface : IfcSurface
		//2	AgreementFlag : IfcBoolean
		//3	Position : IfcAxis2Placement3D
		//4	PolygonalBoundary : IfcBoundedCurve

		public IfcAxis2Placement3D Position { get; set; }
		public IfcBoundedCurve PolygonalBoundary { get; set; }

		public IfcPolygonalBoundedHalfSpace() { }

		public IfcPolygonalBoundedHalfSpace(IfcSurface BaseSurface, IfcBoolean AgreementFlag, IfcAxis2Placement3D Position, IfcBoundedCurve PolygonalBoundary)
		{
			this.BaseSurface = BaseSurface;
			this.AgreementFlag = AgreementFlag;
			this.Position = Position;
			this.PolygonalBoundary = PolygonalBoundary;
		}
	}

	public class IfcPolygonalFaceSet : IfcTessellatedFaceSet
	{
		//1	Coordinates : IfcCartesianPointList3D
		//2	Closed : IfcBoolean
		//3	Faces : List<IfcIndexedPolygonalFace>
		//4	PnIndex : List<IfcPositiveInteger>

		public IfcBoolean Closed { get; set; }
		public List<IfcIndexedPolygonalFace> Faces { get; set; }
		public List<IfcPositiveInteger> PnIndex { get; set; }

		public IfcPolygonalFaceSet() { }

		public IfcPolygonalFaceSet(IfcCartesianPointList3D Coordinates, IfcBoolean Closed, List<IfcIndexedPolygonalFace> Faces, List<IfcPositiveInteger> PnIndex)
		{
			this.Coordinates = Coordinates;
			this.Closed = Closed;
			this.Faces = Faces;
			this.PnIndex = PnIndex;
		}
	}

	public class IfcPolyline : IfcBoundedCurve
	{
		//1	Points : List<IfcCartesianPoint>

		public List<IfcCartesianPoint> Points { get; set; }

		public IfcPolyline() { }

		public IfcPolyline(List<IfcCartesianPoint> Points)
		{
			this.Points = Points;
		}
	}

	public abstract class IfcPort : IfcProduct
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation

		public List<IfcRelConnectsPortToElement> ContainedIn { get; set; }
		public List<IfcRelConnectsPorts> ConnectedFrom { get; set; }
		public List<IfcRelConnectsPorts> ConnectedTo { get; set; }

		public IfcPort() { }

		public IfcPort(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
		}
	}

	public class IfcPostalAddress : IfcAddress
	{
		//1	Purpose : IfcAddressTypeEnum
		//2	Description : IfcText
		//3	UserDefinedPurpose : IfcLabel
		//4	InternalLocation : IfcLabel
		//5	AddressLines : List<IfcLabel>
		//6	PostalBox : IfcLabel
		//7	Town : IfcLabel
		//8	Region : IfcLabel
		//9	PostalCode : IfcLabel
		//10	Country : IfcLabel

		public IfcLabel InternalLocation { get; set; }
		public List<IfcLabel> AddressLines { get; set; }
		public IfcLabel PostalBox { get; set; }
		public IfcLabel Town { get; set; }
		public IfcLabel Region { get; set; }
		public IfcLabel PostalCode { get; set; }
		public IfcLabel Country { get; set; }

		public IfcPostalAddress() { }

		public IfcPostalAddress(IfcAddressTypeEnum Purpose, IfcText Description, IfcLabel UserDefinedPurpose, IfcLabel InternalLocation, List<IfcLabel> AddressLines, IfcLabel PostalBox, IfcLabel Town, IfcLabel Region, IfcLabel PostalCode, IfcLabel Country)
		{
			this.Purpose = Purpose;
			this.Description = Description;
			this.UserDefinedPurpose = UserDefinedPurpose;
			this.InternalLocation = InternalLocation;
			this.AddressLines = AddressLines;
			this.PostalBox = PostalBox;
			this.Town = Town;
			this.Region = Region;
			this.PostalCode = PostalCode;
			this.Country = Country;
		}
	}

	public abstract class IfcPreDefinedColour : IfcPreDefinedItem, IfcColour
	{
		//1	Name : IfcLabel

		public IfcPreDefinedColour() { }

		public IfcPreDefinedColour(IfcLabel Name)
		{
			this.Name = Name;
		}
	}

	public abstract class IfcPreDefinedCurveFont : IfcPreDefinedItem, IfcCurveStyleFontSelect
	{
		//1	Name : IfcLabel

		public IfcPreDefinedCurveFont() { }

		public IfcPreDefinedCurveFont(IfcLabel Name)
		{
			this.Name = Name;
		}
	}

	public abstract class IfcPreDefinedItem : IfcPresentationItem
	{
		//1	Name : IfcLabel

		public IfcLabel Name { get; set; }

		public IfcPreDefinedItem() { }

		public IfcPreDefinedItem(IfcLabel Name)
		{
			this.Name = Name;
		}
	}

	public abstract class IfcPreDefinedProperties : IfcPropertyAbstraction
	{
		public IfcPreDefinedProperties() { }
	}

	public abstract class IfcPreDefinedPropertySet : IfcPropertySetDefinition
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText

		public IfcPreDefinedPropertySet() { }

		public IfcPreDefinedPropertySet(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
		}
	}

	public abstract class IfcPreDefinedTextFont : IfcPreDefinedItem, IfcTextFontSelect
	{
		//1	Name : IfcLabel

		public IfcPreDefinedTextFont() { }

		public IfcPreDefinedTextFont(IfcLabel Name)
		{
			this.Name = Name;
		}
	}

	public abstract class IfcPresentationItem : IfcBase
	{
		public IfcPresentationItem() { }
	}

	public class IfcPresentationLayerAssignment : IfcBase
	{
		//1	Name : IfcLabel
		//2	Description : IfcText
		//3	AssignedItems : List<IfcLayeredItem>
		//4	Identifier : IfcIdentifier

		public IfcLabel Name { get; set; }
		public IfcText Description { get; set; }
		public List<IfcLayeredItem> AssignedItems { get; set; }
		public IfcIdentifier Identifier { get; set; }

		public IfcPresentationLayerAssignment() { }

		public IfcPresentationLayerAssignment(IfcLabel Name, IfcText Description, List<IfcLayeredItem> AssignedItems, IfcIdentifier Identifier)
		{
			this.Name = Name;
			this.Description = Description;
			this.AssignedItems = AssignedItems;
			this.Identifier = Identifier;
		}
	}

	public class IfcPresentationLayerWithStyle : IfcPresentationLayerAssignment
	{
		//1	Name : IfcLabel
		//2	Description : IfcText
		//3	AssignedItems : List<IfcLayeredItem>
		//4	Identifier : IfcIdentifier
		//5	LayerOn : IfcLogical
		//6	LayerFrozen : IfcLogical
		//7	LayerBlocked : IfcLogical
		//8	LayerStyles : List<IfcPresentationStyle>

		public IfcLogical LayerOn { get; set; }
		public IfcLogical LayerFrozen { get; set; }
		public IfcLogical LayerBlocked { get; set; }
		public List<IfcPresentationStyle> LayerStyles { get; set; }

		public IfcPresentationLayerWithStyle() { }

		public IfcPresentationLayerWithStyle(IfcLabel Name, IfcText Description, List<IfcLayeredItem> AssignedItems, IfcIdentifier Identifier, IfcLogical LayerOn, IfcLogical LayerFrozen, IfcLogical LayerBlocked, List<IfcPresentationStyle> LayerStyles)
		{
			this.Name = Name;
			this.Description = Description;
			this.AssignedItems = AssignedItems;
			this.Identifier = Identifier;
			this.LayerOn = LayerOn;
			this.LayerFrozen = LayerFrozen;
			this.LayerBlocked = LayerBlocked;
			this.LayerStyles = LayerStyles;
		}
	}

	public abstract class IfcPresentationStyle : IfcBase, IfcStyleAssignmentSelect
	{
		//1	Name : IfcLabel

		public IfcLabel Name { get; set; }
		public IfcLabel GetName() { return Name; }

		public IfcPresentationStyle() { }

		public IfcPresentationStyle(IfcLabel Name)
		{
			this.Name = Name;
		}
	}

	public class IfcPresentationStyleAssignment : IfcBase
	{
		//1	Styles : List<IfcPresentationStyleSelect>

		public List<IfcPresentationStyleSelect> Styles { get; set; }

		public IfcPresentationStyleAssignment() { }

		public IfcPresentationStyleAssignment(List<IfcPresentationStyleSelect> Styles)
		{
			this.Styles = Styles;
		}
	}

	public class IfcProcedure : IfcProcess
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	Identification : IfcIdentifier
		//7	LongDescription : IfcText
		//8	PredefinedType : IfcProcedureTypeEnum

		public IfcProcedureTypeEnum PredefinedType { get; set; }

		public IfcProcedure() { }

		public IfcProcedure(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcIdentifier Identification, IfcText LongDescription, IfcProcedureTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.Identification = Identification;
			this.LongDescription = LongDescription;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcProcedureType : IfcTypeProcess
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	Identification : IfcIdentifier
		//8	LongDescription : IfcText
		//9	ProcessType : IfcLabel
		//10	PredefinedType : IfcProcedureTypeEnum

		public IfcProcedureTypeEnum PredefinedType { get; set; }

		public IfcProcedureType() { }

		public IfcProcedureType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcIdentifier Identification, IfcText LongDescription, IfcLabel ProcessType, IfcProcedureTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.Identification = Identification;
			this.LongDescription = LongDescription;
			this.ProcessType = ProcessType;
			this.PredefinedType = PredefinedType;
		}
	}

	public abstract class IfcProcess : IfcObject, IfcProcessSelect
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	Identification : IfcIdentifier
		//7	LongDescription : IfcText

		public IfcIdentifier Identification { get; set; }
		public IfcText LongDescription { get; set; }
		public List<IfcRelSequence> IsPredecessorTo { get; set; }
		public List<IfcRelSequence> IsSuccessorFrom { get; set; }
		public List<IfcRelAssignsToProcess> OperatesOn { get; set; }
		public IfcIdentifier GetIdentification() { return Identification; }
		public IfcText GetLongDescription() { return LongDescription; }
		public List<IfcRelAssignsToProcess> GetOperatesOn() { return OperatesOn; }

		public IfcProcess() { }

		public IfcProcess(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcIdentifier Identification, IfcText LongDescription)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.Identification = Identification;
			this.LongDescription = LongDescription;
		}
	}

	public abstract class IfcProduct : IfcObject, IfcProductSelect
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation

		public IfcObjectPlacement ObjectPlacement { get; set; }
		public IfcProductRepresentation Representation { get; set; }
		public List<IfcRelAssignsToProduct> ReferencedBy { get; set; }
		public List<IfcRelAssignsToProduct> GetReferencedBy() { return ReferencedBy; }

		public IfcProduct() { }

		public IfcProduct(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
		}
	}

	public class IfcProductDefinitionShape : IfcProductRepresentation, IfcProductRepresentationSelect
	{
		//1	Name : IfcLabel
		//2	Description : IfcText
		//3	Representations : List<IfcRepresentation>

		public List<IfcProduct> ShapeOfProduct { get; set; }
		public List<IfcShapeAspect> HasShapeAspects { get; set; }
		public List<IfcProduct> GetShapeOfProduct() { return ShapeOfProduct; }
		public List<IfcShapeAspect> GetHasShapeAspects() { return HasShapeAspects; }

		public IfcProductDefinitionShape() { }

		public IfcProductDefinitionShape(IfcLabel Name, IfcText Description, List<IfcRepresentation> Representations)
		{
			this.Name = Name;
			this.Description = Description;
			this.Representations = Representations;
		}
	}

	public abstract class IfcProductRepresentation : IfcBase
	{
		//1	Name : IfcLabel
		//2	Description : IfcText
		//3	Representations : List<IfcRepresentation>

		public IfcLabel Name { get; set; }
		public IfcText Description { get; set; }
		public List<IfcRepresentation> Representations { get; set; }

		public IfcProductRepresentation() { }

		public IfcProductRepresentation(IfcLabel Name, IfcText Description, List<IfcRepresentation> Representations)
		{
			this.Name = Name;
			this.Description = Description;
			this.Representations = Representations;
		}
	}

	public class IfcProfileDef : IfcBase, IfcResourceObjectSelect
	{
		//1	ProfileType : IfcProfileTypeEnum
		//2	ProfileName : IfcLabel

		public IfcProfileTypeEnum ProfileType { get; set; }
		public IfcLabel ProfileName { get; set; }
		public List<IfcExternalReferenceRelationship> HasExternalReference { get; set; }
		public List<IfcProfileProperties> HasProperties { get; set; }

		public IfcProfileDef() { }

		public IfcProfileDef(IfcProfileTypeEnum ProfileType, IfcLabel ProfileName)
		{
			this.ProfileType = ProfileType;
			this.ProfileName = ProfileName;
		}
	}

	public class IfcProfileProperties : IfcExtendedProperties
	{
		//1	Name : IfcIdentifier
		//2	Description : IfcText
		//3	Properties : List<IfcProperty>
		//4	ProfileDefinition : IfcProfileDef

		public IfcProfileDef ProfileDefinition { get; set; }

		public IfcProfileProperties() { }

		public IfcProfileProperties(IfcIdentifier Name, IfcText Description, List<IfcProperty> Properties, IfcProfileDef ProfileDefinition)
		{
			this.Name = Name;
			this.Description = Description;
			this.Properties = Properties;
			this.ProfileDefinition = ProfileDefinition;
		}
	}

	public class IfcProject : IfcContext
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	LongName : IfcLabel
		//7	Phase : IfcLabel
		//8	RepresentationContexts : List<IfcRepresentationContext>
		//9	UnitsInContext : IfcUnitAssignment

		public IfcProject() { }

		public IfcProject(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcLabel LongName, IfcLabel Phase, List<IfcRepresentationContext> RepresentationContexts, IfcUnitAssignment UnitsInContext)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.LongName = LongName;
			this.Phase = Phase;
			this.RepresentationContexts = RepresentationContexts;
			this.UnitsInContext = UnitsInContext;
		}
	}

	public class IfcProjectLibrary : IfcContext
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	LongName : IfcLabel
		//7	Phase : IfcLabel
		//8	RepresentationContexts : List<IfcRepresentationContext>
		//9	UnitsInContext : IfcUnitAssignment

		public IfcProjectLibrary() { }

		public IfcProjectLibrary(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcLabel LongName, IfcLabel Phase, List<IfcRepresentationContext> RepresentationContexts, IfcUnitAssignment UnitsInContext)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.LongName = LongName;
			this.Phase = Phase;
			this.RepresentationContexts = RepresentationContexts;
			this.UnitsInContext = UnitsInContext;
		}
	}

	public class IfcProjectOrder : IfcControl
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	Identification : IfcIdentifier
		//7	PredefinedType : IfcProjectOrderTypeEnum
		//8	Status : IfcLabel
		//9	LongDescription : IfcText

		public IfcProjectOrderTypeEnum PredefinedType { get; set; }
		public IfcLabel Status { get; set; }
		public IfcText LongDescription { get; set; }

		public IfcProjectOrder() { }

		public IfcProjectOrder(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcIdentifier Identification, IfcProjectOrderTypeEnum PredefinedType, IfcLabel Status, IfcText LongDescription)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.Identification = Identification;
			this.PredefinedType = PredefinedType;
			this.Status = Status;
			this.LongDescription = LongDescription;
		}
	}

	public class IfcProjectedCRS : IfcCoordinateReferenceSystem
	{
		//1	Name : IfcLabel
		//2	Description : IfcText
		//3	GeodeticDatum : IfcIdentifier
		//4	VerticalDatum : IfcIdentifier
		//5	MapProjection : IfcIdentifier
		//6	MapZone : IfcIdentifier
		//7	MapUnit : IfcNamedUnit

		public IfcIdentifier MapProjection { get; set; }
		public IfcIdentifier MapZone { get; set; }
		public IfcNamedUnit MapUnit { get; set; }

		public IfcProjectedCRS() { }

		public IfcProjectedCRS(IfcLabel Name, IfcText Description, IfcIdentifier GeodeticDatum, IfcIdentifier VerticalDatum, IfcIdentifier MapProjection, IfcIdentifier MapZone, IfcNamedUnit MapUnit)
		{
			this.Name = Name;
			this.Description = Description;
			this.GeodeticDatum = GeodeticDatum;
			this.VerticalDatum = VerticalDatum;
			this.MapProjection = MapProjection;
			this.MapZone = MapZone;
			this.MapUnit = MapUnit;
		}
	}

	public class IfcProjectionElement : IfcFeatureElementAddition
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	PredefinedType : IfcProjectionElementTypeEnum

		public IfcProjectionElementTypeEnum PredefinedType { get; set; }

		public IfcProjectionElement() { }

		public IfcProjectionElement(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcProjectionElementTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.PredefinedType = PredefinedType;
		}
	}

	public abstract class IfcProperty : IfcPropertyAbstraction
	{
		//1	Name : IfcIdentifier
		//2	Description : IfcText

		public IfcIdentifier Name { get; set; }
		public IfcText Description { get; set; }
		public List<IfcPropertySet> PartOfPset { get; set; }
		public List<IfcPropertyDependencyRelationship> PropertyForDependance { get; set; }
		public List<IfcPropertyDependencyRelationship> PropertyDependsOn { get; set; }
		public List<IfcComplexProperty> PartOfComplex { get; set; }
		public List<IfcResourceConstraintRelationship> HasConstraints { get; set; }
		public List<IfcResourceApprovalRelationship> HasApprovals { get; set; }

		public IfcProperty() { }

		public IfcProperty(IfcIdentifier Name, IfcText Description)
		{
			this.Name = Name;
			this.Description = Description;
		}
	}

	public abstract class IfcPropertyAbstraction : IfcBase, IfcResourceObjectSelect
	{
		public List<IfcExternalReferenceRelationship> HasExternalReferences { get; set; }

		public IfcPropertyAbstraction() { }
	}

	public class IfcPropertyBoundedValue : IfcSimpleProperty
	{
		//1	Name : IfcIdentifier
		//2	Description : IfcText
		//3	UpperBoundValue : IfcValue
		//4	LowerBoundValue : IfcValue
		//5	Unit : IfcUnit
		//6	SetPointValue : IfcValue

		public IfcValue UpperBoundValue { get; set; }
		public IfcValue LowerBoundValue { get; set; }
		public IfcUnit Unit { get; set; }
		public IfcValue SetPointValue { get; set; }

		public IfcPropertyBoundedValue() { }

		public IfcPropertyBoundedValue(IfcIdentifier Name, IfcText Description, IfcValue UpperBoundValue, IfcValue LowerBoundValue, IfcUnit Unit, IfcValue SetPointValue)
		{
			this.Name = Name;
			this.Description = Description;
			this.UpperBoundValue = UpperBoundValue;
			this.LowerBoundValue = LowerBoundValue;
			this.Unit = Unit;
			this.SetPointValue = SetPointValue;
		}
	}

	public abstract class IfcPropertyDefinition : IfcRoot, IfcDefinitionSelect
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText

		public List<IfcRelDeclares> HasContext { get; set; }
		public List<IfcRelAssociates> HasAssociations { get; set; }
		public List<IfcRelDeclares> GetHasContext() { return HasContext; }
		public List<IfcRelAssociates> GetHasAssociations() { return HasAssociations; }

		public IfcPropertyDefinition() { }

		public IfcPropertyDefinition(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
		}
	}

	public class IfcPropertyDependencyRelationship : IfcResourceLevelRelationship
	{
		//1	Name : IfcLabel
		//2	Description : IfcText
		//3	DependingProperty : IfcProperty
		//4	DependantProperty : IfcProperty
		//5	Expression : IfcText

		public IfcProperty DependingProperty { get; set; }
		public IfcProperty DependantProperty { get; set; }
		public IfcText Expression { get; set; }

		public IfcPropertyDependencyRelationship() { }

		public IfcPropertyDependencyRelationship(IfcLabel Name, IfcText Description, IfcProperty DependingProperty, IfcProperty DependantProperty, IfcText Expression)
		{
			this.Name = Name;
			this.Description = Description;
			this.DependingProperty = DependingProperty;
			this.DependantProperty = DependantProperty;
			this.Expression = Expression;
		}
	}

	public class IfcPropertyEnumeratedValue : IfcSimpleProperty
	{
		//1	Name : IfcIdentifier
		//2	Description : IfcText
		//3	EnumerationValues : List<IfcValue>
		//4	EnumerationReference : IfcPropertyEnumeration

		public List<IfcValue> EnumerationValues { get; set; }
		public IfcPropertyEnumeration EnumerationReference { get; set; }

		public IfcPropertyEnumeratedValue() { }

		public IfcPropertyEnumeratedValue(IfcIdentifier Name, IfcText Description, List<IfcValue> EnumerationValues, IfcPropertyEnumeration EnumerationReference)
		{
			this.Name = Name;
			this.Description = Description;
			this.EnumerationValues = EnumerationValues;
			this.EnumerationReference = EnumerationReference;
		}
	}

	public class IfcPropertyEnumeration : IfcPropertyAbstraction
	{
		//1	Name : IfcLabel
		//2	EnumerationValues : List<IfcValue>
		//3	Unit : IfcUnit

		public IfcLabel Name { get; set; }
		public List<IfcValue> EnumerationValues { get; set; }
		public IfcUnit Unit { get; set; }

		public IfcPropertyEnumeration() { }

		public IfcPropertyEnumeration(IfcLabel Name, List<IfcValue> EnumerationValues, IfcUnit Unit)
		{
			this.Name = Name;
			this.EnumerationValues = EnumerationValues;
			this.Unit = Unit;
		}
	}

	public class IfcPropertyListValue : IfcSimpleProperty
	{
		//1	Name : IfcIdentifier
		//2	Description : IfcText
		//3	ListValues : List<IfcValue>
		//4	Unit : IfcUnit

		public List<IfcValue> ListValues { get; set; }
		public IfcUnit Unit { get; set; }

		public IfcPropertyListValue() { }

		public IfcPropertyListValue(IfcIdentifier Name, IfcText Description, List<IfcValue> ListValues, IfcUnit Unit)
		{
			this.Name = Name;
			this.Description = Description;
			this.ListValues = ListValues;
			this.Unit = Unit;
		}
	}

	public class IfcPropertyReferenceValue : IfcSimpleProperty
	{
		//1	Name : IfcIdentifier
		//2	Description : IfcText
		//3	UsageName : IfcText
		//4	PropertyReference : IfcObjectReferenceSelect

		public IfcText UsageName { get; set; }
		public IfcObjectReferenceSelect PropertyReference { get; set; }

		public IfcPropertyReferenceValue() { }

		public IfcPropertyReferenceValue(IfcIdentifier Name, IfcText Description, IfcText UsageName, IfcObjectReferenceSelect PropertyReference)
		{
			this.Name = Name;
			this.Description = Description;
			this.UsageName = UsageName;
			this.PropertyReference = PropertyReference;
		}
	}

	public class IfcPropertySet : IfcPropertySetDefinition
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	HasProperties : List<IfcProperty>

		public List<IfcProperty> HasProperties { get; set; }

		public IfcPropertySet() { }

		public IfcPropertySet(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, List<IfcProperty> HasProperties)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.HasProperties = HasProperties;
		}
	}

	public abstract class IfcPropertySetDefinition : IfcPropertyDefinition, IfcPropertySetDefinitionSelect
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText

		public List<IfcTypeObject> DefinesType { get; set; }
		public List<IfcRelDefinesByTemplate> IsDefinedBy { get; set; }
		public List<IfcRelDefinesByProperties> DefinesOccurrence { get; set; }

		public IfcPropertySetDefinition() { }

		public IfcPropertySetDefinition(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
		}
	}

	public class IfcPropertySetTemplate : IfcPropertyTemplateDefinition
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	TemplateType : IfcPropertySetTemplateTypeEnum
		//6	ApplicableEntity : IfcIdentifier
		//7	HasPropertyTemplates : List<IfcPropertyTemplate>

		public IfcPropertySetTemplateTypeEnum TemplateType { get; set; }
		public IfcIdentifier ApplicableEntity { get; set; }
		public List<IfcPropertyTemplate> HasPropertyTemplates { get; set; }
		public List<IfcRelDefinesByTemplate> Defines { get; set; }

		public IfcPropertySetTemplate() { }

		public IfcPropertySetTemplate(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcPropertySetTemplateTypeEnum TemplateType, IfcIdentifier ApplicableEntity, List<IfcPropertyTemplate> HasPropertyTemplates)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.TemplateType = TemplateType;
			this.ApplicableEntity = ApplicableEntity;
			this.HasPropertyTemplates = HasPropertyTemplates;
		}
	}

	public class IfcPropertySingleValue : IfcSimpleProperty
	{
		//1	Name : IfcIdentifier
		//2	Description : IfcText
		//3	NominalValue : IfcValue
		//4	Unit : IfcUnit

		public IfcValue NominalValue { get; set; }
		public IfcUnit Unit { get; set; }

		public IfcPropertySingleValue() { }

		public IfcPropertySingleValue(IfcIdentifier Name, IfcText Description, IfcValue NominalValue, IfcUnit Unit)
		{
			this.Name = Name;
			this.Description = Description;
			this.NominalValue = NominalValue;
			this.Unit = Unit;
		}
	}

	public class IfcPropertyTableValue : IfcSimpleProperty
	{
		//1	Name : IfcIdentifier
		//2	Description : IfcText
		//3	DefiningValues : List<IfcValue>
		//4	DefinedValues : List<IfcValue>
		//5	Expression : IfcText
		//6	DefiningUnit : IfcUnit
		//7	DefinedUnit : IfcUnit
		//8	CurveInterpolation : IfcCurveInterpolationEnum

		public List<IfcValue> DefiningValues { get; set; }
		public List<IfcValue> DefinedValues { get; set; }
		public IfcText Expression { get; set; }
		public IfcUnit DefiningUnit { get; set; }
		public IfcUnit DefinedUnit { get; set; }
		public IfcCurveInterpolationEnum CurveInterpolation { get; set; }

		public IfcPropertyTableValue() { }

		public IfcPropertyTableValue(IfcIdentifier Name, IfcText Description, List<IfcValue> DefiningValues, List<IfcValue> DefinedValues, IfcText Expression, IfcUnit DefiningUnit, IfcUnit DefinedUnit, IfcCurveInterpolationEnum CurveInterpolation)
		{
			this.Name = Name;
			this.Description = Description;
			this.DefiningValues = DefiningValues;
			this.DefinedValues = DefinedValues;
			this.Expression = Expression;
			this.DefiningUnit = DefiningUnit;
			this.DefinedUnit = DefinedUnit;
			this.CurveInterpolation = CurveInterpolation;
		}
	}

	public abstract class IfcPropertyTemplate : IfcPropertyTemplateDefinition
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText

		public List<IfcComplexPropertyTemplate> PartOfComplexTemplate { get; set; }
		public List<IfcPropertySetTemplate> PartOfPsetTemplate { get; set; }

		public IfcPropertyTemplate() { }

		public IfcPropertyTemplate(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
		}
	}

	public abstract class IfcPropertyTemplateDefinition : IfcPropertyDefinition
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText

		public IfcPropertyTemplateDefinition() { }

		public IfcPropertyTemplateDefinition(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
		}
	}

	public class IfcProtectiveDevice : IfcFlowController
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	PredefinedType : IfcProtectiveDeviceTypeEnum

		public IfcProtectiveDeviceTypeEnum PredefinedType { get; set; }

		public IfcProtectiveDevice() { }

		public IfcProtectiveDevice(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcProtectiveDeviceTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcProtectiveDeviceTrippingUnit : IfcDistributionControlElement
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	PredefinedType : IfcProtectiveDeviceTrippingUnitTypeEnum

		public IfcProtectiveDeviceTrippingUnitTypeEnum PredefinedType { get; set; }

		public IfcProtectiveDeviceTrippingUnit() { }

		public IfcProtectiveDeviceTrippingUnit(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcProtectiveDeviceTrippingUnitTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcProtectiveDeviceTrippingUnitType : IfcDistributionControlElementType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel
		//10	PredefinedType : IfcProtectiveDeviceTrippingUnitTypeEnum

		public IfcProtectiveDeviceTrippingUnitTypeEnum PredefinedType { get; set; }

		public IfcProtectiveDeviceTrippingUnitType() { }

		public IfcProtectiveDeviceTrippingUnitType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType, IfcProtectiveDeviceTrippingUnitTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcProtectiveDeviceType : IfcFlowControllerType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel
		//10	PredefinedType : IfcProtectiveDeviceTypeEnum

		public IfcProtectiveDeviceTypeEnum PredefinedType { get; set; }

		public IfcProtectiveDeviceType() { }

		public IfcProtectiveDeviceType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType, IfcProtectiveDeviceTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcProxy : IfcProduct
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	ProxyType : IfcObjectTypeEnum
		//9	Tag : IfcLabel

		public IfcObjectTypeEnum ProxyType { get; set; }
		public IfcLabel Tag { get; set; }

		public IfcProxy() { }

		public IfcProxy(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcObjectTypeEnum ProxyType, IfcLabel Tag)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.ProxyType = ProxyType;
			this.Tag = Tag;
		}
	}

	public class IfcPump : IfcFlowMovingDevice
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	PredefinedType : IfcPumpTypeEnum

		public IfcPumpTypeEnum PredefinedType { get; set; }

		public IfcPump() { }

		public IfcPump(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcPumpTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcPumpType : IfcFlowMovingDeviceType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel
		//10	PredefinedType : IfcPumpTypeEnum

		public IfcPumpTypeEnum PredefinedType { get; set; }

		public IfcPumpType() { }

		public IfcPumpType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType, IfcPumpTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcQuantityArea : IfcPhysicalSimpleQuantity
	{
		//1	Name : IfcLabel
		//2	Description : IfcText
		//3	Unit : IfcNamedUnit
		//4	AreaValue : IfcAreaMeasure
		//5	Formula : IfcLabel

		public IfcAreaMeasure AreaValue { get; set; }
		public IfcLabel Formula { get; set; }

		public IfcQuantityArea() { }

		public IfcQuantityArea(IfcLabel Name, IfcText Description, IfcNamedUnit Unit, IfcAreaMeasure AreaValue, IfcLabel Formula)
		{
			this.Name = Name;
			this.Description = Description;
			this.Unit = Unit;
			this.AreaValue = AreaValue;
			this.Formula = Formula;
		}
	}

	public class IfcQuantityCount : IfcPhysicalSimpleQuantity
	{
		//1	Name : IfcLabel
		//2	Description : IfcText
		//3	Unit : IfcNamedUnit
		//4	CountValue : IfcCountMeasure
		//5	Formula : IfcLabel

		public IfcCountMeasure CountValue { get; set; }
		public IfcLabel Formula { get; set; }

		public IfcQuantityCount() { }

		public IfcQuantityCount(IfcLabel Name, IfcText Description, IfcNamedUnit Unit, IfcCountMeasure CountValue, IfcLabel Formula)
		{
			this.Name = Name;
			this.Description = Description;
			this.Unit = Unit;
			this.CountValue = CountValue;
			this.Formula = Formula;
		}
	}

	public class IfcQuantityLength : IfcPhysicalSimpleQuantity
	{
		//1	Name : IfcLabel
		//2	Description : IfcText
		//3	Unit : IfcNamedUnit
		//4	LengthValue : IfcLengthMeasure
		//5	Formula : IfcLabel

		public IfcLengthMeasure LengthValue { get; set; }
		public IfcLabel Formula { get; set; }

		public IfcQuantityLength() { }

		public IfcQuantityLength(IfcLabel Name, IfcText Description, IfcNamedUnit Unit, IfcLengthMeasure LengthValue, IfcLabel Formula)
		{
			this.Name = Name;
			this.Description = Description;
			this.Unit = Unit;
			this.LengthValue = LengthValue;
			this.Formula = Formula;
		}
	}

	public abstract class IfcQuantitySet : IfcPropertySetDefinition
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText

		public IfcQuantitySet() { }

		public IfcQuantitySet(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
		}
	}

	public class IfcQuantityTime : IfcPhysicalSimpleQuantity
	{
		//1	Name : IfcLabel
		//2	Description : IfcText
		//3	Unit : IfcNamedUnit
		//4	TimeValue : IfcTimeMeasure
		//5	Formula : IfcLabel

		public IfcTimeMeasure TimeValue { get; set; }
		public IfcLabel Formula { get; set; }

		public IfcQuantityTime() { }

		public IfcQuantityTime(IfcLabel Name, IfcText Description, IfcNamedUnit Unit, IfcTimeMeasure TimeValue, IfcLabel Formula)
		{
			this.Name = Name;
			this.Description = Description;
			this.Unit = Unit;
			this.TimeValue = TimeValue;
			this.Formula = Formula;
		}
	}

	public class IfcQuantityVolume : IfcPhysicalSimpleQuantity
	{
		//1	Name : IfcLabel
		//2	Description : IfcText
		//3	Unit : IfcNamedUnit
		//4	VolumeValue : IfcVolumeMeasure
		//5	Formula : IfcLabel

		public IfcVolumeMeasure VolumeValue { get; set; }
		public IfcLabel Formula { get; set; }

		public IfcQuantityVolume() { }

		public IfcQuantityVolume(IfcLabel Name, IfcText Description, IfcNamedUnit Unit, IfcVolumeMeasure VolumeValue, IfcLabel Formula)
		{
			this.Name = Name;
			this.Description = Description;
			this.Unit = Unit;
			this.VolumeValue = VolumeValue;
			this.Formula = Formula;
		}
	}

	public class IfcQuantityWeight : IfcPhysicalSimpleQuantity
	{
		//1	Name : IfcLabel
		//2	Description : IfcText
		//3	Unit : IfcNamedUnit
		//4	WeightValue : IfcMassMeasure
		//5	Formula : IfcLabel

		public IfcMassMeasure WeightValue { get; set; }
		public IfcLabel Formula { get; set; }

		public IfcQuantityWeight() { }

		public IfcQuantityWeight(IfcLabel Name, IfcText Description, IfcNamedUnit Unit, IfcMassMeasure WeightValue, IfcLabel Formula)
		{
			this.Name = Name;
			this.Description = Description;
			this.Unit = Unit;
			this.WeightValue = WeightValue;
			this.Formula = Formula;
		}
	}

	public class IfcRailing : IfcBuildingElement
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	PredefinedType : IfcRailingTypeEnum

		public IfcRailingTypeEnum PredefinedType { get; set; }

		public IfcRailing() { }

		public IfcRailing(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcRailingTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcRailingType : IfcBuildingElementType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel
		//10	PredefinedType : IfcRailingTypeEnum

		public IfcRailingTypeEnum PredefinedType { get; set; }

		public IfcRailingType() { }

		public IfcRailingType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType, IfcRailingTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcRamp : IfcBuildingElement
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	PredefinedType : IfcRampTypeEnum

		public IfcRampTypeEnum PredefinedType { get; set; }

		public IfcRamp() { }

		public IfcRamp(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcRampTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcRampFlight : IfcBuildingElement
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	PredefinedType : IfcRampFlightTypeEnum

		public IfcRampFlightTypeEnum PredefinedType { get; set; }

		public IfcRampFlight() { }

		public IfcRampFlight(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcRampFlightTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcRampFlightType : IfcBuildingElementType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel
		//10	PredefinedType : IfcRampFlightTypeEnum

		public IfcRampFlightTypeEnum PredefinedType { get; set; }

		public IfcRampFlightType() { }

		public IfcRampFlightType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType, IfcRampFlightTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcRampType : IfcBuildingElementType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel
		//10	PredefinedType : IfcRampTypeEnum

		public IfcRampTypeEnum PredefinedType { get; set; }

		public IfcRampType() { }

		public IfcRampType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType, IfcRampTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcRationalBSplineCurveWithKnots : IfcBSplineCurveWithKnots
	{
		//1	Degree : IfcInteger
		//2	ControlPointsList : List<IfcCartesianPoint>
		//3	CurveForm : IfcBSplineCurveForm
		//4	ClosedCurve : IfcLogical
		//5	SelfIntersect : IfcLogical
		//6	KnotMultiplicities : List<IfcInteger>
		//7	Knots : List<IfcParameterValue>
		//8	KnotSpec : IfcKnotType
		//9	WeightsData : List<IfcReal>

		public List<IfcReal> WeightsData { get; set; }
		public List<IfcReal> Weights { get; set; }

		public IfcRationalBSplineCurveWithKnots() { }

		public IfcRationalBSplineCurveWithKnots(IfcInteger Degree, List<IfcCartesianPoint> ControlPointsList, IfcBSplineCurveForm CurveForm, IfcLogical ClosedCurve, IfcLogical SelfIntersect, List<IfcInteger> KnotMultiplicities, List<IfcParameterValue> Knots, IfcKnotType KnotSpec, List<IfcReal> WeightsData)
		{
			this.Degree = Degree;
			this.ControlPointsList = ControlPointsList;
			this.CurveForm = CurveForm;
			this.ClosedCurve = ClosedCurve;
			this.SelfIntersect = SelfIntersect;
			this.KnotMultiplicities = KnotMultiplicities;
			this.Knots = Knots;
			this.KnotSpec = KnotSpec;
			this.WeightsData = WeightsData;
		}
	}

	public class IfcRationalBSplineSurfaceWithKnots : IfcBSplineSurfaceWithKnots
	{
		//1	UDegree : IfcInteger
		//2	VDegree : IfcInteger
		//3	ControlPointsList : List<List<IfcCartesianPoint>>
		//4	SurfaceForm : IfcBSplineSurfaceForm
		//5	UClosed : IfcLogical
		//6	VClosed : IfcLogical
		//7	SelfIntersect : IfcLogical
		//8	UMultiplicities : List<IfcInteger>
		//9	VMultiplicities : List<IfcInteger>
		//10	UKnots : List<IfcParameterValue>
		//11	VKnots : List<IfcParameterValue>
		//12	KnotSpec : IfcKnotType
		//13	WeightsData : List<List<IfcReal>>

		public List<List<IfcReal>> WeightsData { get; set; }
		public List<List<IfcReal>> Weights { get; set; }

		public IfcRationalBSplineSurfaceWithKnots() { }

		public IfcRationalBSplineSurfaceWithKnots(IfcInteger UDegree, IfcInteger VDegree, List<List<IfcCartesianPoint>> ControlPointsList, IfcBSplineSurfaceForm SurfaceForm, IfcLogical UClosed, IfcLogical VClosed, IfcLogical SelfIntersect, List<IfcInteger> UMultiplicities, List<IfcInteger> VMultiplicities, List<IfcParameterValue> UKnots, List<IfcParameterValue> VKnots, IfcKnotType KnotSpec, List<List<IfcReal>> WeightsData)
		{
			this.UDegree = UDegree;
			this.VDegree = VDegree;
			this.ControlPointsList = ControlPointsList;
			this.SurfaceForm = SurfaceForm;
			this.UClosed = UClosed;
			this.VClosed = VClosed;
			this.SelfIntersect = SelfIntersect;
			this.UMultiplicities = UMultiplicities;
			this.VMultiplicities = VMultiplicities;
			this.UKnots = UKnots;
			this.VKnots = VKnots;
			this.KnotSpec = KnotSpec;
			this.WeightsData = WeightsData;
		}
	}

	public class IfcRectangleHollowProfileDef : IfcRectangleProfileDef
	{
		//1	ProfileType : IfcProfileTypeEnum
		//2	ProfileName : IfcLabel
		//3	Position : IfcAxis2Placement2D
		//4	XDim : IfcPositiveLengthMeasure
		//5	YDim : IfcPositiveLengthMeasure
		//6	WallThickness : IfcPositiveLengthMeasure
		//7	InnerFilletRadius : IfcNonNegativeLengthMeasure
		//8	OuterFilletRadius : IfcNonNegativeLengthMeasure

		public IfcPositiveLengthMeasure WallThickness { get; set; }
		public IfcNonNegativeLengthMeasure InnerFilletRadius { get; set; }
		public IfcNonNegativeLengthMeasure OuterFilletRadius { get; set; }

		public IfcRectangleHollowProfileDef() { }

		public IfcRectangleHollowProfileDef(IfcProfileTypeEnum ProfileType, IfcLabel ProfileName, IfcAxis2Placement2D Position, IfcPositiveLengthMeasure XDim, IfcPositiveLengthMeasure YDim, IfcPositiveLengthMeasure WallThickness, IfcNonNegativeLengthMeasure InnerFilletRadius, IfcNonNegativeLengthMeasure OuterFilletRadius)
		{
			this.ProfileType = ProfileType;
			this.ProfileName = ProfileName;
			this.Position = Position;
			this.XDim = XDim;
			this.YDim = YDim;
			this.WallThickness = WallThickness;
			this.InnerFilletRadius = InnerFilletRadius;
			this.OuterFilletRadius = OuterFilletRadius;
		}
	}

	public class IfcRectangleProfileDef : IfcParameterizedProfileDef
	{
		//1	ProfileType : IfcProfileTypeEnum
		//2	ProfileName : IfcLabel
		//3	Position : IfcAxis2Placement2D
		//4	XDim : IfcPositiveLengthMeasure
		//5	YDim : IfcPositiveLengthMeasure

		public IfcPositiveLengthMeasure XDim { get; set; }
		public IfcPositiveLengthMeasure YDim { get; set; }

		public IfcRectangleProfileDef() { }

		public IfcRectangleProfileDef(IfcProfileTypeEnum ProfileType, IfcLabel ProfileName, IfcAxis2Placement2D Position, IfcPositiveLengthMeasure XDim, IfcPositiveLengthMeasure YDim)
		{
			this.ProfileType = ProfileType;
			this.ProfileName = ProfileName;
			this.Position = Position;
			this.XDim = XDim;
			this.YDim = YDim;
		}
	}

	public class IfcRectangularPyramid : IfcCsgPrimitive3D
	{
		//1	Position : IfcAxis2Placement3D
		//2	XLength : IfcPositiveLengthMeasure
		//3	YLength : IfcPositiveLengthMeasure
		//4	Height : IfcPositiveLengthMeasure

		public IfcPositiveLengthMeasure XLength { get; set; }
		public IfcPositiveLengthMeasure YLength { get; set; }
		public IfcPositiveLengthMeasure Height { get; set; }

		public IfcRectangularPyramid() { }

		public IfcRectangularPyramid(IfcAxis2Placement3D Position, IfcPositiveLengthMeasure XLength, IfcPositiveLengthMeasure YLength, IfcPositiveLengthMeasure Height)
		{
			this.Position = Position;
			this.XLength = XLength;
			this.YLength = YLength;
			this.Height = Height;
		}
	}

	public class IfcRectangularTrimmedSurface : IfcBoundedSurface
	{
		//1	BasisSurface : IfcSurface
		//2	U1 : IfcParameterValue
		//3	V1 : IfcParameterValue
		//4	U2 : IfcParameterValue
		//5	V2 : IfcParameterValue
		//6	Usense : IfcBoolean
		//7	Vsense : IfcBoolean

		public IfcSurface BasisSurface { get; set; }
		public IfcParameterValue U1 { get; set; }
		public IfcParameterValue V1 { get; set; }
		public IfcParameterValue U2 { get; set; }
		public IfcParameterValue V2 { get; set; }
		public IfcBoolean Usense { get; set; }
		public IfcBoolean Vsense { get; set; }

		public IfcRectangularTrimmedSurface() { }

		public IfcRectangularTrimmedSurface(IfcSurface BasisSurface, IfcParameterValue U1, IfcParameterValue V1, IfcParameterValue U2, IfcParameterValue V2, IfcBoolean Usense, IfcBoolean Vsense)
		{
			this.BasisSurface = BasisSurface;
			this.U1 = U1;
			this.V1 = V1;
			this.U2 = U2;
			this.V2 = V2;
			this.Usense = Usense;
			this.Vsense = Vsense;
		}
	}

	public class IfcRecurrencePattern : IfcBase
	{
		//1	RecurrenceType : IfcRecurrenceTypeEnum
		//2	DayComponent : List<IfcDayInMonthNumber>
		//3	WeekdayComponent : List<IfcDayInWeekNumber>
		//4	MonthComponent : List<IfcMonthInYearNumber>
		//5	Position : IfcInteger
		//6	Interval : IfcInteger
		//7	Occurrences : IfcInteger
		//8	TimePeriods : List<IfcTimePeriod>

		public IfcRecurrenceTypeEnum RecurrenceType { get; set; }
		public List<IfcDayInMonthNumber> DayComponent { get; set; }
		public List<IfcDayInWeekNumber> WeekdayComponent { get; set; }
		public List<IfcMonthInYearNumber> MonthComponent { get; set; }
		public IfcInteger Position { get; set; }
		public IfcInteger Interval { get; set; }
		public IfcInteger Occurrences { get; set; }
		public List<IfcTimePeriod> TimePeriods { get; set; }

		public IfcRecurrencePattern() { }

		public IfcRecurrencePattern(IfcRecurrenceTypeEnum RecurrenceType, List<IfcDayInMonthNumber> DayComponent, List<IfcDayInWeekNumber> WeekdayComponent, List<IfcMonthInYearNumber> MonthComponent, IfcInteger Position, IfcInteger Interval, IfcInteger Occurrences, List<IfcTimePeriod> TimePeriods)
		{
			this.RecurrenceType = RecurrenceType;
			this.DayComponent = DayComponent;
			this.WeekdayComponent = WeekdayComponent;
			this.MonthComponent = MonthComponent;
			this.Position = Position;
			this.Interval = Interval;
			this.Occurrences = Occurrences;
			this.TimePeriods = TimePeriods;
		}
	}

	public class IfcReference : IfcBase
	{
		//1	TypeIdentifier : IfcIdentifier
		//2	AttributeIdentifier : IfcIdentifier
		//3	InstanceName : IfcLabel
		//4	ListPositions : List<IfcInteger>
		//5	InnerReference : IfcReference

		public IfcIdentifier TypeIdentifier { get; set; }
		public IfcIdentifier AttributeIdentifier { get; set; }
		public IfcLabel InstanceName { get; set; }
		public List<IfcInteger> ListPositions { get; set; }
		public IfcReference InnerReference { get; set; }

		public IfcReference() { }

		public IfcReference(IfcIdentifier TypeIdentifier, IfcIdentifier AttributeIdentifier, IfcLabel InstanceName, List<IfcInteger> ListPositions, IfcReference InnerReference)
		{
			this.TypeIdentifier = TypeIdentifier;
			this.AttributeIdentifier = AttributeIdentifier;
			this.InstanceName = InstanceName;
			this.ListPositions = ListPositions;
			this.InnerReference = InnerReference;
		}
	}

	public class IfcRegularTimeSeries : IfcTimeSeries
	{
		//1	Name : IfcLabel
		//2	Description : IfcText
		//3	StartTime : IfcDateTime
		//4	EndTime : IfcDateTime
		//5	TimeSeriesDataType : IfcTimeSeriesDataTypeEnum
		//6	DataOrigin : IfcDataOriginEnum
		//7	UserDefinedDataOrigin : IfcLabel
		//8	Unit : IfcUnit
		//9	TimeStep : IfcTimeMeasure
		//10	Values : List<IfcTimeSeriesValue>

		public IfcTimeMeasure TimeStep { get; set; }
		public List<IfcTimeSeriesValue> Values { get; set; }

		public IfcRegularTimeSeries() { }

		public IfcRegularTimeSeries(IfcLabel Name, IfcText Description, IfcDateTime StartTime, IfcDateTime EndTime, IfcTimeSeriesDataTypeEnum TimeSeriesDataType, IfcDataOriginEnum DataOrigin, IfcLabel UserDefinedDataOrigin, IfcUnit Unit, IfcTimeMeasure TimeStep, List<IfcTimeSeriesValue> Values)
		{
			this.Name = Name;
			this.Description = Description;
			this.StartTime = StartTime;
			this.EndTime = EndTime;
			this.TimeSeriesDataType = TimeSeriesDataType;
			this.DataOrigin = DataOrigin;
			this.UserDefinedDataOrigin = UserDefinedDataOrigin;
			this.Unit = Unit;
			this.TimeStep = TimeStep;
			this.Values = Values;
		}
	}

	public class IfcReinforcementBarProperties : IfcPreDefinedProperties
	{
		//1	TotalCrossSectionArea : IfcAreaMeasure
		//2	SteelGrade : IfcLabel
		//3	BarSurface : IfcReinforcingBarSurfaceEnum
		//4	EffectiveDepth : IfcLengthMeasure
		//5	NominalBarDiameter : IfcPositiveLengthMeasure
		//6	BarCount : IfcCountMeasure

		public IfcAreaMeasure TotalCrossSectionArea { get; set; }
		public IfcLabel SteelGrade { get; set; }
		public IfcReinforcingBarSurfaceEnum BarSurface { get; set; }
		public IfcLengthMeasure EffectiveDepth { get; set; }
		public IfcPositiveLengthMeasure NominalBarDiameter { get; set; }
		public IfcCountMeasure BarCount { get; set; }

		public IfcReinforcementBarProperties() { }

		public IfcReinforcementBarProperties(IfcAreaMeasure TotalCrossSectionArea, IfcLabel SteelGrade, IfcReinforcingBarSurfaceEnum BarSurface, IfcLengthMeasure EffectiveDepth, IfcPositiveLengthMeasure NominalBarDiameter, IfcCountMeasure BarCount)
		{
			this.TotalCrossSectionArea = TotalCrossSectionArea;
			this.SteelGrade = SteelGrade;
			this.BarSurface = BarSurface;
			this.EffectiveDepth = EffectiveDepth;
			this.NominalBarDiameter = NominalBarDiameter;
			this.BarCount = BarCount;
		}
	}

	public class IfcReinforcementDefinitionProperties : IfcPreDefinedPropertySet
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	DefinitionType : IfcLabel
		//6	ReinforcementSectionDefinitions : List<IfcSectionReinforcementProperties>

		public IfcLabel DefinitionType { get; set; }
		public List<IfcSectionReinforcementProperties> ReinforcementSectionDefinitions { get; set; }

		public IfcReinforcementDefinitionProperties() { }

		public IfcReinforcementDefinitionProperties(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel DefinitionType, List<IfcSectionReinforcementProperties> ReinforcementSectionDefinitions)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.DefinitionType = DefinitionType;
			this.ReinforcementSectionDefinitions = ReinforcementSectionDefinitions;
		}
	}

	public class IfcReinforcingBar : IfcReinforcingElement
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	SteelGrade : IfcLabel
		//10	NominalDiameter : IfcPositiveLengthMeasure
		//11	CrossSectionArea : IfcAreaMeasure
		//12	BarLength : IfcPositiveLengthMeasure
		//13	PredefinedType : IfcReinforcingBarTypeEnum
		//14	BarSurface : IfcReinforcingBarSurfaceEnum

		public IfcPositiveLengthMeasure NominalDiameter { get; set; }
		public IfcAreaMeasure CrossSectionArea { get; set; }
		public IfcPositiveLengthMeasure BarLength { get; set; }
		public IfcReinforcingBarTypeEnum PredefinedType { get; set; }
		public IfcReinforcingBarSurfaceEnum BarSurface { get; set; }

		public IfcReinforcingBar() { }

		public IfcReinforcingBar(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcLabel SteelGrade, IfcPositiveLengthMeasure NominalDiameter, IfcAreaMeasure CrossSectionArea, IfcPositiveLengthMeasure BarLength, IfcReinforcingBarTypeEnum PredefinedType, IfcReinforcingBarSurfaceEnum BarSurface)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.SteelGrade = SteelGrade;
			this.NominalDiameter = NominalDiameter;
			this.CrossSectionArea = CrossSectionArea;
			this.BarLength = BarLength;
			this.PredefinedType = PredefinedType;
			this.BarSurface = BarSurface;
		}
	}

	public class IfcReinforcingBarType : IfcReinforcingElementType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel
		//10	PredefinedType : IfcReinforcingBarTypeEnum
		//11	NominalDiameter : IfcPositiveLengthMeasure
		//12	CrossSectionArea : IfcAreaMeasure
		//13	BarLength : IfcPositiveLengthMeasure
		//14	BarSurface : IfcReinforcingBarSurfaceEnum
		//15	BendingShapeCode : IfcLabel
		//16	BendingParameters : List<IfcBendingParameterSelect>

		public IfcReinforcingBarTypeEnum PredefinedType { get; set; }
		public IfcPositiveLengthMeasure NominalDiameter { get; set; }
		public IfcAreaMeasure CrossSectionArea { get; set; }
		public IfcPositiveLengthMeasure BarLength { get; set; }
		public IfcReinforcingBarSurfaceEnum BarSurface { get; set; }
		public IfcLabel BendingShapeCode { get; set; }
		public List<IfcBendingParameterSelect> BendingParameters { get; set; }

		public IfcReinforcingBarType() { }

		public IfcReinforcingBarType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType, IfcReinforcingBarTypeEnum PredefinedType, IfcPositiveLengthMeasure NominalDiameter, IfcAreaMeasure CrossSectionArea, IfcPositiveLengthMeasure BarLength, IfcReinforcingBarSurfaceEnum BarSurface, IfcLabel BendingShapeCode, List<IfcBendingParameterSelect> BendingParameters)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
			this.PredefinedType = PredefinedType;
			this.NominalDiameter = NominalDiameter;
			this.CrossSectionArea = CrossSectionArea;
			this.BarLength = BarLength;
			this.BarSurface = BarSurface;
			this.BendingShapeCode = BendingShapeCode;
			this.BendingParameters = BendingParameters;
		}
	}

	public abstract class IfcReinforcingElement : IfcElementComponent
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	SteelGrade : IfcLabel

		public IfcLabel SteelGrade { get; set; }

		public IfcReinforcingElement() { }

		public IfcReinforcingElement(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcLabel SteelGrade)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.SteelGrade = SteelGrade;
		}
	}

	public abstract class IfcReinforcingElementType : IfcElementComponentType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel

		public IfcReinforcingElementType() { }

		public IfcReinforcingElementType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
		}
	}

	public class IfcReinforcingMesh : IfcReinforcingElement
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	SteelGrade : IfcLabel
		//10	MeshLength : IfcPositiveLengthMeasure
		//11	MeshWidth : IfcPositiveLengthMeasure
		//12	LongitudinalBarNominalDiameter : IfcPositiveLengthMeasure
		//13	TransverseBarNominalDiameter : IfcPositiveLengthMeasure
		//14	LongitudinalBarCrossSectionArea : IfcAreaMeasure
		//15	TransverseBarCrossSectionArea : IfcAreaMeasure
		//16	LongitudinalBarSpacing : IfcPositiveLengthMeasure
		//17	TransverseBarSpacing : IfcPositiveLengthMeasure
		//18	PredefinedType : IfcReinforcingMeshTypeEnum

		public IfcPositiveLengthMeasure MeshLength { get; set; }
		public IfcPositiveLengthMeasure MeshWidth { get; set; }
		public IfcPositiveLengthMeasure LongitudinalBarNominalDiameter { get; set; }
		public IfcPositiveLengthMeasure TransverseBarNominalDiameter { get; set; }
		public IfcAreaMeasure LongitudinalBarCrossSectionArea { get; set; }
		public IfcAreaMeasure TransverseBarCrossSectionArea { get; set; }
		public IfcPositiveLengthMeasure LongitudinalBarSpacing { get; set; }
		public IfcPositiveLengthMeasure TransverseBarSpacing { get; set; }
		public IfcReinforcingMeshTypeEnum PredefinedType { get; set; }

		public IfcReinforcingMesh() { }

		public IfcReinforcingMesh(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcLabel SteelGrade, IfcPositiveLengthMeasure MeshLength, IfcPositiveLengthMeasure MeshWidth, IfcPositiveLengthMeasure LongitudinalBarNominalDiameter, IfcPositiveLengthMeasure TransverseBarNominalDiameter, IfcAreaMeasure LongitudinalBarCrossSectionArea, IfcAreaMeasure TransverseBarCrossSectionArea, IfcPositiveLengthMeasure LongitudinalBarSpacing, IfcPositiveLengthMeasure TransverseBarSpacing, IfcReinforcingMeshTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.SteelGrade = SteelGrade;
			this.MeshLength = MeshLength;
			this.MeshWidth = MeshWidth;
			this.LongitudinalBarNominalDiameter = LongitudinalBarNominalDiameter;
			this.TransverseBarNominalDiameter = TransverseBarNominalDiameter;
			this.LongitudinalBarCrossSectionArea = LongitudinalBarCrossSectionArea;
			this.TransverseBarCrossSectionArea = TransverseBarCrossSectionArea;
			this.LongitudinalBarSpacing = LongitudinalBarSpacing;
			this.TransverseBarSpacing = TransverseBarSpacing;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcReinforcingMeshType : IfcReinforcingElementType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel
		//10	PredefinedType : IfcReinforcingMeshTypeEnum
		//11	MeshLength : IfcPositiveLengthMeasure
		//12	MeshWidth : IfcPositiveLengthMeasure
		//13	LongitudinalBarNominalDiameter : IfcPositiveLengthMeasure
		//14	TransverseBarNominalDiameter : IfcPositiveLengthMeasure
		//15	LongitudinalBarCrossSectionArea : IfcAreaMeasure
		//16	TransverseBarCrossSectionArea : IfcAreaMeasure
		//17	LongitudinalBarSpacing : IfcPositiveLengthMeasure
		//18	TransverseBarSpacing : IfcPositiveLengthMeasure
		//19	BendingShapeCode : IfcLabel
		//20	BendingParameters : List<IfcBendingParameterSelect>

		public IfcReinforcingMeshTypeEnum PredefinedType { get; set; }
		public IfcPositiveLengthMeasure MeshLength { get; set; }
		public IfcPositiveLengthMeasure MeshWidth { get; set; }
		public IfcPositiveLengthMeasure LongitudinalBarNominalDiameter { get; set; }
		public IfcPositiveLengthMeasure TransverseBarNominalDiameter { get; set; }
		public IfcAreaMeasure LongitudinalBarCrossSectionArea { get; set; }
		public IfcAreaMeasure TransverseBarCrossSectionArea { get; set; }
		public IfcPositiveLengthMeasure LongitudinalBarSpacing { get; set; }
		public IfcPositiveLengthMeasure TransverseBarSpacing { get; set; }
		public IfcLabel BendingShapeCode { get; set; }
		public List<IfcBendingParameterSelect> BendingParameters { get; set; }

		public IfcReinforcingMeshType() { }

		public IfcReinforcingMeshType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType, IfcReinforcingMeshTypeEnum PredefinedType, IfcPositiveLengthMeasure MeshLength, IfcPositiveLengthMeasure MeshWidth, IfcPositiveLengthMeasure LongitudinalBarNominalDiameter, IfcPositiveLengthMeasure TransverseBarNominalDiameter, IfcAreaMeasure LongitudinalBarCrossSectionArea, IfcAreaMeasure TransverseBarCrossSectionArea, IfcPositiveLengthMeasure LongitudinalBarSpacing, IfcPositiveLengthMeasure TransverseBarSpacing, IfcLabel BendingShapeCode, List<IfcBendingParameterSelect> BendingParameters)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
			this.PredefinedType = PredefinedType;
			this.MeshLength = MeshLength;
			this.MeshWidth = MeshWidth;
			this.LongitudinalBarNominalDiameter = LongitudinalBarNominalDiameter;
			this.TransverseBarNominalDiameter = TransverseBarNominalDiameter;
			this.LongitudinalBarCrossSectionArea = LongitudinalBarCrossSectionArea;
			this.TransverseBarCrossSectionArea = TransverseBarCrossSectionArea;
			this.LongitudinalBarSpacing = LongitudinalBarSpacing;
			this.TransverseBarSpacing = TransverseBarSpacing;
			this.BendingShapeCode = BendingShapeCode;
			this.BendingParameters = BendingParameters;
		}
	}

	public class IfcRelAggregates : IfcRelDecomposes
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	RelatingObject : IfcObjectDefinition
		//6	RelatedObjects : List<IfcObjectDefinition>

		public IfcObjectDefinition RelatingObject { get; set; }
		public List<IfcObjectDefinition> RelatedObjects { get; set; }

		public IfcRelAggregates() { }

		public IfcRelAggregates(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcObjectDefinition RelatingObject, List<IfcObjectDefinition> RelatedObjects)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.RelatingObject = RelatingObject;
			this.RelatedObjects = RelatedObjects;
		}
	}

	public abstract class IfcRelAssigns : IfcRelationship
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	RelatedObjects : List<IfcObjectDefinition>
		//6	RelatedObjectsType : IfcObjectTypeEnum

		public List<IfcObjectDefinition> RelatedObjects { get; set; }
		public IfcObjectTypeEnum RelatedObjectsType { get; set; }

		public IfcRelAssigns() { }

		public IfcRelAssigns(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, List<IfcObjectDefinition> RelatedObjects, IfcObjectTypeEnum RelatedObjectsType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.RelatedObjects = RelatedObjects;
			this.RelatedObjectsType = RelatedObjectsType;
		}
	}

	public class IfcRelAssignsToActor : IfcRelAssigns
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	RelatedObjects : List<IfcObjectDefinition>
		//6	RelatedObjectsType : IfcObjectTypeEnum
		//7	RelatingActor : IfcActor
		//8	ActingRole : IfcActorRole

		public IfcActor RelatingActor { get; set; }
		public IfcActorRole ActingRole { get; set; }

		public IfcRelAssignsToActor() { }

		public IfcRelAssignsToActor(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, List<IfcObjectDefinition> RelatedObjects, IfcObjectTypeEnum RelatedObjectsType, IfcActor RelatingActor, IfcActorRole ActingRole)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.RelatedObjects = RelatedObjects;
			this.RelatedObjectsType = RelatedObjectsType;
			this.RelatingActor = RelatingActor;
			this.ActingRole = ActingRole;
		}
	}

	public class IfcRelAssignsToControl : IfcRelAssigns
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	RelatedObjects : List<IfcObjectDefinition>
		//6	RelatedObjectsType : IfcObjectTypeEnum
		//7	RelatingControl : IfcControl

		public IfcControl RelatingControl { get; set; }

		public IfcRelAssignsToControl() { }

		public IfcRelAssignsToControl(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, List<IfcObjectDefinition> RelatedObjects, IfcObjectTypeEnum RelatedObjectsType, IfcControl RelatingControl)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.RelatedObjects = RelatedObjects;
			this.RelatedObjectsType = RelatedObjectsType;
			this.RelatingControl = RelatingControl;
		}
	}

	public class IfcRelAssignsToGroup : IfcRelAssigns
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	RelatedObjects : List<IfcObjectDefinition>
		//6	RelatedObjectsType : IfcObjectTypeEnum
		//7	RelatingGroup : IfcGroup

		public IfcGroup RelatingGroup { get; set; }

		public IfcRelAssignsToGroup() { }

		public IfcRelAssignsToGroup(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, List<IfcObjectDefinition> RelatedObjects, IfcObjectTypeEnum RelatedObjectsType, IfcGroup RelatingGroup)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.RelatedObjects = RelatedObjects;
			this.RelatedObjectsType = RelatedObjectsType;
			this.RelatingGroup = RelatingGroup;
		}
	}

	public class IfcRelAssignsToGroupByFactor : IfcRelAssignsToGroup
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	RelatedObjects : List<IfcObjectDefinition>
		//6	RelatedObjectsType : IfcObjectTypeEnum
		//7	RelatingGroup : IfcGroup
		//8	Factor : IfcRatioMeasure

		public IfcRatioMeasure Factor { get; set; }

		public IfcRelAssignsToGroupByFactor() { }

		public IfcRelAssignsToGroupByFactor(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, List<IfcObjectDefinition> RelatedObjects, IfcObjectTypeEnum RelatedObjectsType, IfcGroup RelatingGroup, IfcRatioMeasure Factor)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.RelatedObjects = RelatedObjects;
			this.RelatedObjectsType = RelatedObjectsType;
			this.RelatingGroup = RelatingGroup;
			this.Factor = Factor;
		}
	}

	public class IfcRelAssignsToProcess : IfcRelAssigns
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	RelatedObjects : List<IfcObjectDefinition>
		//6	RelatedObjectsType : IfcObjectTypeEnum
		//7	RelatingProcess : IfcProcessSelect
		//8	QuantityInProcess : IfcMeasureWithUnit

		public IfcProcessSelect RelatingProcess { get; set; }
		public IfcMeasureWithUnit QuantityInProcess { get; set; }

		public IfcRelAssignsToProcess() { }

		public IfcRelAssignsToProcess(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, List<IfcObjectDefinition> RelatedObjects, IfcObjectTypeEnum RelatedObjectsType, IfcProcessSelect RelatingProcess, IfcMeasureWithUnit QuantityInProcess)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.RelatedObjects = RelatedObjects;
			this.RelatedObjectsType = RelatedObjectsType;
			this.RelatingProcess = RelatingProcess;
			this.QuantityInProcess = QuantityInProcess;
		}
	}

	public class IfcRelAssignsToProduct : IfcRelAssigns
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	RelatedObjects : List<IfcObjectDefinition>
		//6	RelatedObjectsType : IfcObjectTypeEnum
		//7	RelatingProduct : IfcProductSelect

		public IfcProductSelect RelatingProduct { get; set; }

		public IfcRelAssignsToProduct() { }

		public IfcRelAssignsToProduct(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, List<IfcObjectDefinition> RelatedObjects, IfcObjectTypeEnum RelatedObjectsType, IfcProductSelect RelatingProduct)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.RelatedObjects = RelatedObjects;
			this.RelatedObjectsType = RelatedObjectsType;
			this.RelatingProduct = RelatingProduct;
		}
	}

	public class IfcRelAssignsToResource : IfcRelAssigns
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	RelatedObjects : List<IfcObjectDefinition>
		//6	RelatedObjectsType : IfcObjectTypeEnum
		//7	RelatingResource : IfcResourceSelect

		public IfcResourceSelect RelatingResource { get; set; }

		public IfcRelAssignsToResource() { }

		public IfcRelAssignsToResource(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, List<IfcObjectDefinition> RelatedObjects, IfcObjectTypeEnum RelatedObjectsType, IfcResourceSelect RelatingResource)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.RelatedObjects = RelatedObjects;
			this.RelatedObjectsType = RelatedObjectsType;
			this.RelatingResource = RelatingResource;
		}
	}

	public abstract class IfcRelAssociates : IfcRelationship
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	RelatedObjects : List<IfcDefinitionSelect>

		public List<IfcDefinitionSelect> RelatedObjects { get; set; }

		public IfcRelAssociates() { }

		public IfcRelAssociates(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, List<IfcDefinitionSelect> RelatedObjects)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.RelatedObjects = RelatedObjects;
		}
	}

	public class IfcRelAssociatesApproval : IfcRelAssociates
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	RelatedObjects : List<IfcDefinitionSelect>
		//6	RelatingApproval : IfcApproval

		public IfcApproval RelatingApproval { get; set; }

		public IfcRelAssociatesApproval() { }

		public IfcRelAssociatesApproval(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, List<IfcDefinitionSelect> RelatedObjects, IfcApproval RelatingApproval)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.RelatedObjects = RelatedObjects;
			this.RelatingApproval = RelatingApproval;
		}
	}

	public class IfcRelAssociatesClassification : IfcRelAssociates
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	RelatedObjects : List<IfcDefinitionSelect>
		//6	RelatingClassification : IfcClassificationSelect

		public IfcClassificationSelect RelatingClassification { get; set; }

		public IfcRelAssociatesClassification() { }

		public IfcRelAssociatesClassification(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, List<IfcDefinitionSelect> RelatedObjects, IfcClassificationSelect RelatingClassification)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.RelatedObjects = RelatedObjects;
			this.RelatingClassification = RelatingClassification;
		}
	}

	public class IfcRelAssociatesConstraint : IfcRelAssociates
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	RelatedObjects : List<IfcDefinitionSelect>
		//6	Intent : IfcLabel
		//7	RelatingConstraint : IfcConstraint

		public IfcLabel Intent { get; set; }
		public IfcConstraint RelatingConstraint { get; set; }

		public IfcRelAssociatesConstraint() { }

		public IfcRelAssociatesConstraint(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, List<IfcDefinitionSelect> RelatedObjects, IfcLabel Intent, IfcConstraint RelatingConstraint)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.RelatedObjects = RelatedObjects;
			this.Intent = Intent;
			this.RelatingConstraint = RelatingConstraint;
		}
	}

	public class IfcRelAssociatesDocument : IfcRelAssociates
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	RelatedObjects : List<IfcDefinitionSelect>
		//6	RelatingDocument : IfcDocumentSelect

		public IfcDocumentSelect RelatingDocument { get; set; }

		public IfcRelAssociatesDocument() { }

		public IfcRelAssociatesDocument(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, List<IfcDefinitionSelect> RelatedObjects, IfcDocumentSelect RelatingDocument)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.RelatedObjects = RelatedObjects;
			this.RelatingDocument = RelatingDocument;
		}
	}

	public class IfcRelAssociatesLibrary : IfcRelAssociates
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	RelatedObjects : List<IfcDefinitionSelect>
		//6	RelatingLibrary : IfcLibrarySelect

		public IfcLibrarySelect RelatingLibrary { get; set; }

		public IfcRelAssociatesLibrary() { }

		public IfcRelAssociatesLibrary(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, List<IfcDefinitionSelect> RelatedObjects, IfcLibrarySelect RelatingLibrary)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.RelatedObjects = RelatedObjects;
			this.RelatingLibrary = RelatingLibrary;
		}
	}

	public class IfcRelAssociatesMaterial : IfcRelAssociates
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	RelatedObjects : List<IfcDefinitionSelect>
		//6	RelatingMaterial : IfcMaterialSelect

		public IfcMaterialSelect RelatingMaterial { get; set; }

		public IfcRelAssociatesMaterial() { }

		public IfcRelAssociatesMaterial(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, List<IfcDefinitionSelect> RelatedObjects, IfcMaterialSelect RelatingMaterial)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.RelatedObjects = RelatedObjects;
			this.RelatingMaterial = RelatingMaterial;
		}
	}

	public abstract class IfcRelConnects : IfcRelationship
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText

		public IfcRelConnects() { }

		public IfcRelConnects(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
		}
	}

	public class IfcRelConnectsElements : IfcRelConnects
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ConnectionGeometry : IfcConnectionGeometry
		//6	RelatingElement : IfcElement
		//7	RelatedElement : IfcElement

		public IfcConnectionGeometry ConnectionGeometry { get; set; }
		public IfcElement RelatingElement { get; set; }
		public IfcElement RelatedElement { get; set; }

		public IfcRelConnectsElements() { }

		public IfcRelConnectsElements(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcConnectionGeometry ConnectionGeometry, IfcElement RelatingElement, IfcElement RelatedElement)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ConnectionGeometry = ConnectionGeometry;
			this.RelatingElement = RelatingElement;
			this.RelatedElement = RelatedElement;
		}
	}

	public class IfcRelConnectsPathElements : IfcRelConnectsElements
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ConnectionGeometry : IfcConnectionGeometry
		//6	RelatingElement : IfcElement
		//7	RelatedElement : IfcElement
		//8	RelatingPriorities : List<IfcInteger>
		//9	RelatedPriorities : List<IfcInteger>
		//10	RelatedConnectionType : IfcConnectionTypeEnum
		//11	RelatingConnectionType : IfcConnectionTypeEnum

		public List<IfcInteger> RelatingPriorities { get; set; }
		public List<IfcInteger> RelatedPriorities { get; set; }
		public IfcConnectionTypeEnum RelatedConnectionType { get; set; }
		public IfcConnectionTypeEnum RelatingConnectionType { get; set; }

		public IfcRelConnectsPathElements() { }

		public IfcRelConnectsPathElements(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcConnectionGeometry ConnectionGeometry, IfcElement RelatingElement, IfcElement RelatedElement, List<IfcInteger> RelatingPriorities, List<IfcInteger> RelatedPriorities, IfcConnectionTypeEnum RelatedConnectionType, IfcConnectionTypeEnum RelatingConnectionType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ConnectionGeometry = ConnectionGeometry;
			this.RelatingElement = RelatingElement;
			this.RelatedElement = RelatedElement;
			this.RelatingPriorities = RelatingPriorities;
			this.RelatedPriorities = RelatedPriorities;
			this.RelatedConnectionType = RelatedConnectionType;
			this.RelatingConnectionType = RelatingConnectionType;
		}
	}

	public class IfcRelConnectsPortToElement : IfcRelConnects
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	RelatingPort : IfcPort
		//6	RelatedElement : IfcDistributionElement

		public IfcPort RelatingPort { get; set; }
		public IfcDistributionElement RelatedElement { get; set; }

		public IfcRelConnectsPortToElement() { }

		public IfcRelConnectsPortToElement(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcPort RelatingPort, IfcDistributionElement RelatedElement)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.RelatingPort = RelatingPort;
			this.RelatedElement = RelatedElement;
		}
	}

	public class IfcRelConnectsPorts : IfcRelConnects
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	RelatingPort : IfcPort
		//6	RelatedPort : IfcPort
		//7	RealizingElement : IfcElement

		public IfcPort RelatingPort { get; set; }
		public IfcPort RelatedPort { get; set; }
		public IfcElement RealizingElement { get; set; }

		public IfcRelConnectsPorts() { }

		public IfcRelConnectsPorts(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcPort RelatingPort, IfcPort RelatedPort, IfcElement RealizingElement)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.RelatingPort = RelatingPort;
			this.RelatedPort = RelatedPort;
			this.RealizingElement = RealizingElement;
		}
	}

	public class IfcRelConnectsStructuralActivity : IfcRelConnects
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	RelatingElement : IfcStructuralActivityAssignmentSelect
		//6	RelatedStructuralActivity : IfcStructuralActivity

		public IfcStructuralActivityAssignmentSelect RelatingElement { get; set; }
		public IfcStructuralActivity RelatedStructuralActivity { get; set; }

		public IfcRelConnectsStructuralActivity() { }

		public IfcRelConnectsStructuralActivity(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcStructuralActivityAssignmentSelect RelatingElement, IfcStructuralActivity RelatedStructuralActivity)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.RelatingElement = RelatingElement;
			this.RelatedStructuralActivity = RelatedStructuralActivity;
		}
	}

	public class IfcRelConnectsStructuralMember : IfcRelConnects
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	RelatingStructuralMember : IfcStructuralMember
		//6	RelatedStructuralConnection : IfcStructuralConnection
		//7	AppliedCondition : IfcBoundaryCondition
		//8	AdditionalConditions : IfcStructuralConnectionCondition
		//9	SupportedLength : IfcLengthMeasure
		//10	ConditionCoordinateSystem : IfcAxis2Placement3D

		public IfcStructuralMember RelatingStructuralMember { get; set; }
		public IfcStructuralConnection RelatedStructuralConnection { get; set; }
		public IfcBoundaryCondition AppliedCondition { get; set; }
		public IfcStructuralConnectionCondition AdditionalConditions { get; set; }
		public IfcLengthMeasure SupportedLength { get; set; }
		public IfcAxis2Placement3D ConditionCoordinateSystem { get; set; }

		public IfcRelConnectsStructuralMember() { }

		public IfcRelConnectsStructuralMember(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcStructuralMember RelatingStructuralMember, IfcStructuralConnection RelatedStructuralConnection, IfcBoundaryCondition AppliedCondition, IfcStructuralConnectionCondition AdditionalConditions, IfcLengthMeasure SupportedLength, IfcAxis2Placement3D ConditionCoordinateSystem)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.RelatingStructuralMember = RelatingStructuralMember;
			this.RelatedStructuralConnection = RelatedStructuralConnection;
			this.AppliedCondition = AppliedCondition;
			this.AdditionalConditions = AdditionalConditions;
			this.SupportedLength = SupportedLength;
			this.ConditionCoordinateSystem = ConditionCoordinateSystem;
		}
	}

	public class IfcRelConnectsWithEccentricity : IfcRelConnectsStructuralMember
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	RelatingStructuralMember : IfcStructuralMember
		//6	RelatedStructuralConnection : IfcStructuralConnection
		//7	AppliedCondition : IfcBoundaryCondition
		//8	AdditionalConditions : IfcStructuralConnectionCondition
		//9	SupportedLength : IfcLengthMeasure
		//10	ConditionCoordinateSystem : IfcAxis2Placement3D
		//11	ConnectionConstraint : IfcConnectionGeometry

		public IfcConnectionGeometry ConnectionConstraint { get; set; }

		public IfcRelConnectsWithEccentricity() { }

		public IfcRelConnectsWithEccentricity(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcStructuralMember RelatingStructuralMember, IfcStructuralConnection RelatedStructuralConnection, IfcBoundaryCondition AppliedCondition, IfcStructuralConnectionCondition AdditionalConditions, IfcLengthMeasure SupportedLength, IfcAxis2Placement3D ConditionCoordinateSystem, IfcConnectionGeometry ConnectionConstraint)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.RelatingStructuralMember = RelatingStructuralMember;
			this.RelatedStructuralConnection = RelatedStructuralConnection;
			this.AppliedCondition = AppliedCondition;
			this.AdditionalConditions = AdditionalConditions;
			this.SupportedLength = SupportedLength;
			this.ConditionCoordinateSystem = ConditionCoordinateSystem;
			this.ConnectionConstraint = ConnectionConstraint;
		}
	}

	public class IfcRelConnectsWithRealizingElements : IfcRelConnectsElements
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ConnectionGeometry : IfcConnectionGeometry
		//6	RelatingElement : IfcElement
		//7	RelatedElement : IfcElement
		//8	RealizingElements : List<IfcElement>
		//9	ConnectionType : IfcLabel

		public List<IfcElement> RealizingElements { get; set; }
		public IfcLabel ConnectionType { get; set; }

		public IfcRelConnectsWithRealizingElements() { }

		public IfcRelConnectsWithRealizingElements(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcConnectionGeometry ConnectionGeometry, IfcElement RelatingElement, IfcElement RelatedElement, List<IfcElement> RealizingElements, IfcLabel ConnectionType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ConnectionGeometry = ConnectionGeometry;
			this.RelatingElement = RelatingElement;
			this.RelatedElement = RelatedElement;
			this.RealizingElements = RealizingElements;
			this.ConnectionType = ConnectionType;
		}
	}

	public class IfcRelContainedInSpatialStructure : IfcRelConnects
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	RelatedElements : List<IfcProduct>
		//6	RelatingStructure : IfcSpatialElement

		public List<IfcProduct> RelatedElements { get; set; }
		public IfcSpatialElement RelatingStructure { get; set; }

		public IfcRelContainedInSpatialStructure() { }

		public IfcRelContainedInSpatialStructure(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, List<IfcProduct> RelatedElements, IfcSpatialElement RelatingStructure)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.RelatedElements = RelatedElements;
			this.RelatingStructure = RelatingStructure;
		}
	}

	public class IfcRelCoversBldgElements : IfcRelConnects
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	RelatingBuildingElement : IfcElement
		//6	RelatedCoverings : List<IfcCovering>

		public IfcElement RelatingBuildingElement { get; set; }
		public List<IfcCovering> RelatedCoverings { get; set; }

		public IfcRelCoversBldgElements() { }

		public IfcRelCoversBldgElements(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcElement RelatingBuildingElement, List<IfcCovering> RelatedCoverings)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.RelatingBuildingElement = RelatingBuildingElement;
			this.RelatedCoverings = RelatedCoverings;
		}
	}

	public class IfcRelCoversSpaces : IfcRelConnects
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	RelatingSpace : IfcSpace
		//6	RelatedCoverings : List<IfcCovering>

		public IfcSpace RelatingSpace { get; set; }
		public List<IfcCovering> RelatedCoverings { get; set; }

		public IfcRelCoversSpaces() { }

		public IfcRelCoversSpaces(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcSpace RelatingSpace, List<IfcCovering> RelatedCoverings)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.RelatingSpace = RelatingSpace;
			this.RelatedCoverings = RelatedCoverings;
		}
	}

	public class IfcRelDeclares : IfcRelationship
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	RelatingContext : IfcContext
		//6	RelatedDefinitions : List<IfcDefinitionSelect>

		public IfcContext RelatingContext { get; set; }
		public List<IfcDefinitionSelect> RelatedDefinitions { get; set; }

		public IfcRelDeclares() { }

		public IfcRelDeclares(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcContext RelatingContext, List<IfcDefinitionSelect> RelatedDefinitions)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.RelatingContext = RelatingContext;
			this.RelatedDefinitions = RelatedDefinitions;
		}
	}

	public abstract class IfcRelDecomposes : IfcRelationship
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText

		public IfcRelDecomposes() { }

		public IfcRelDecomposes(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
		}
	}

	public abstract class IfcRelDefines : IfcRelationship
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText

		public IfcRelDefines() { }

		public IfcRelDefines(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
		}
	}

	public class IfcRelDefinesByObject : IfcRelDefines
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	RelatedObjects : List<IfcObject>
		//6	RelatingObject : IfcObject

		public List<IfcObject> RelatedObjects { get; set; }
		public IfcObject RelatingObject { get; set; }

		public IfcRelDefinesByObject() { }

		public IfcRelDefinesByObject(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, List<IfcObject> RelatedObjects, IfcObject RelatingObject)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.RelatedObjects = RelatedObjects;
			this.RelatingObject = RelatingObject;
		}
	}

	public class IfcRelDefinesByProperties : IfcRelDefines
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	RelatedObjects : List<IfcObjectDefinition>
		//6	RelatingPropertyDefinition : IfcPropertySetDefinitionSelect

		public List<IfcObjectDefinition> RelatedObjects { get; set; }
		public IfcPropertySetDefinitionSelect RelatingPropertyDefinition { get; set; }

		public IfcRelDefinesByProperties() { }

		public IfcRelDefinesByProperties(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, List<IfcObjectDefinition> RelatedObjects, IfcPropertySetDefinitionSelect RelatingPropertyDefinition)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.RelatedObjects = RelatedObjects;
			this.RelatingPropertyDefinition = RelatingPropertyDefinition;
		}
	}

	public class IfcRelDefinesByTemplate : IfcRelDefines
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	RelatedPropertySets : List<IfcPropertySetDefinition>
		//6	RelatingTemplate : IfcPropertySetTemplate

		public List<IfcPropertySetDefinition> RelatedPropertySets { get; set; }
		public IfcPropertySetTemplate RelatingTemplate { get; set; }

		public IfcRelDefinesByTemplate() { }

		public IfcRelDefinesByTemplate(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, List<IfcPropertySetDefinition> RelatedPropertySets, IfcPropertySetTemplate RelatingTemplate)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.RelatedPropertySets = RelatedPropertySets;
			this.RelatingTemplate = RelatingTemplate;
		}
	}

	public class IfcRelDefinesByType : IfcRelDefines
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	RelatedObjects : List<IfcObject>
		//6	RelatingType : IfcTypeObject

		public List<IfcObject> RelatedObjects { get; set; }
		public IfcTypeObject RelatingType { get; set; }

		public IfcRelDefinesByType() { }

		public IfcRelDefinesByType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, List<IfcObject> RelatedObjects, IfcTypeObject RelatingType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.RelatedObjects = RelatedObjects;
			this.RelatingType = RelatingType;
		}
	}

	public class IfcRelFillsElement : IfcRelConnects
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	RelatingOpeningElement : IfcOpeningElement
		//6	RelatedBuildingElement : IfcElement

		public IfcOpeningElement RelatingOpeningElement { get; set; }
		public IfcElement RelatedBuildingElement { get; set; }

		public IfcRelFillsElement() { }

		public IfcRelFillsElement(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcOpeningElement RelatingOpeningElement, IfcElement RelatedBuildingElement)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.RelatingOpeningElement = RelatingOpeningElement;
			this.RelatedBuildingElement = RelatedBuildingElement;
		}
	}

	public class IfcRelFlowControlElements : IfcRelConnects
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	RelatedControlElements : List<IfcDistributionControlElement>
		//6	RelatingFlowElement : IfcDistributionFlowElement

		public List<IfcDistributionControlElement> RelatedControlElements { get; set; }
		public IfcDistributionFlowElement RelatingFlowElement { get; set; }

		public IfcRelFlowControlElements() { }

		public IfcRelFlowControlElements(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, List<IfcDistributionControlElement> RelatedControlElements, IfcDistributionFlowElement RelatingFlowElement)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.RelatedControlElements = RelatedControlElements;
			this.RelatingFlowElement = RelatingFlowElement;
		}
	}

	public class IfcRelInterferesElements : IfcRelConnects
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	RelatingElement : IfcElement
		//6	RelatedElement : IfcElement
		//7	InterferenceGeometry : IfcConnectionGeometry
		//8	InterferenceType : IfcIdentifier
		//9	ImpliedOrder : LOGICAL

		public IfcElement RelatingElement { get; set; }
		public IfcElement RelatedElement { get; set; }
		public IfcConnectionGeometry InterferenceGeometry { get; set; }
		public IfcIdentifier InterferenceType { get; set; }
		public LOGICAL ImpliedOrder { get; set; }

		public IfcRelInterferesElements() { }

		public IfcRelInterferesElements(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcElement RelatingElement, IfcElement RelatedElement, IfcConnectionGeometry InterferenceGeometry, IfcIdentifier InterferenceType, LOGICAL ImpliedOrder)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.RelatingElement = RelatingElement;
			this.RelatedElement = RelatedElement;
			this.InterferenceGeometry = InterferenceGeometry;
			this.InterferenceType = InterferenceType;
			this.ImpliedOrder = ImpliedOrder;
		}
	}

	public class IfcRelNests : IfcRelDecomposes
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	RelatingObject : IfcObjectDefinition
		//6	RelatedObjects : List<IfcObjectDefinition>

		public IfcObjectDefinition RelatingObject { get; set; }
		public List<IfcObjectDefinition> RelatedObjects { get; set; }

		public IfcRelNests() { }

		public IfcRelNests(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcObjectDefinition RelatingObject, List<IfcObjectDefinition> RelatedObjects)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.RelatingObject = RelatingObject;
			this.RelatedObjects = RelatedObjects;
		}
	}

	public class IfcRelProjectsElement : IfcRelDecomposes
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	RelatingElement : IfcElement
		//6	RelatedFeatureElement : IfcFeatureElementAddition

		public IfcElement RelatingElement { get; set; }
		public IfcFeatureElementAddition RelatedFeatureElement { get; set; }

		public IfcRelProjectsElement() { }

		public IfcRelProjectsElement(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcElement RelatingElement, IfcFeatureElementAddition RelatedFeatureElement)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.RelatingElement = RelatingElement;
			this.RelatedFeatureElement = RelatedFeatureElement;
		}
	}

	public class IfcRelReferencedInSpatialStructure : IfcRelConnects
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	RelatedElements : List<IfcProduct>
		//6	RelatingStructure : IfcSpatialElement

		public List<IfcProduct> RelatedElements { get; set; }
		public IfcSpatialElement RelatingStructure { get; set; }

		public IfcRelReferencedInSpatialStructure() { }

		public IfcRelReferencedInSpatialStructure(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, List<IfcProduct> RelatedElements, IfcSpatialElement RelatingStructure)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.RelatedElements = RelatedElements;
			this.RelatingStructure = RelatingStructure;
		}
	}

	public class IfcRelSequence : IfcRelConnects
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	RelatingProcess : IfcProcess
		//6	RelatedProcess : IfcProcess
		//7	TimeLag : IfcLagTime
		//8	SequenceType : IfcSequenceEnum
		//9	UserDefinedSequenceType : IfcLabel

		public IfcProcess RelatingProcess { get; set; }
		public IfcProcess RelatedProcess { get; set; }
		public IfcLagTime TimeLag { get; set; }
		public IfcSequenceEnum SequenceType { get; set; }
		public IfcLabel UserDefinedSequenceType { get; set; }

		public IfcRelSequence() { }

		public IfcRelSequence(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcProcess RelatingProcess, IfcProcess RelatedProcess, IfcLagTime TimeLag, IfcSequenceEnum SequenceType, IfcLabel UserDefinedSequenceType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.RelatingProcess = RelatingProcess;
			this.RelatedProcess = RelatedProcess;
			this.TimeLag = TimeLag;
			this.SequenceType = SequenceType;
			this.UserDefinedSequenceType = UserDefinedSequenceType;
		}
	}

	public class IfcRelServicesBuildings : IfcRelConnects
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	RelatingSystem : IfcSystem
		//6	RelatedBuildings : List<IfcSpatialElement>

		public IfcSystem RelatingSystem { get; set; }
		public List<IfcSpatialElement> RelatedBuildings { get; set; }

		public IfcRelServicesBuildings() { }

		public IfcRelServicesBuildings(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcSystem RelatingSystem, List<IfcSpatialElement> RelatedBuildings)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.RelatingSystem = RelatingSystem;
			this.RelatedBuildings = RelatedBuildings;
		}
	}

	public class IfcRelSpaceBoundary : IfcRelConnects
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	RelatingSpace : IfcSpaceBoundarySelect
		//6	RelatedBuildingElement : IfcElement
		//7	ConnectionGeometry : IfcConnectionGeometry
		//8	PhysicalOrVirtualBoundary : IfcPhysicalOrVirtualEnum
		//9	InternalOrExternalBoundary : IfcInternalOrExternalEnum

		public IfcSpaceBoundarySelect RelatingSpace { get; set; }
		public IfcElement RelatedBuildingElement { get; set; }
		public IfcConnectionGeometry ConnectionGeometry { get; set; }
		public IfcPhysicalOrVirtualEnum PhysicalOrVirtualBoundary { get; set; }
		public IfcInternalOrExternalEnum InternalOrExternalBoundary { get; set; }

		public IfcRelSpaceBoundary() { }

		public IfcRelSpaceBoundary(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcSpaceBoundarySelect RelatingSpace, IfcElement RelatedBuildingElement, IfcConnectionGeometry ConnectionGeometry, IfcPhysicalOrVirtualEnum PhysicalOrVirtualBoundary, IfcInternalOrExternalEnum InternalOrExternalBoundary)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.RelatingSpace = RelatingSpace;
			this.RelatedBuildingElement = RelatedBuildingElement;
			this.ConnectionGeometry = ConnectionGeometry;
			this.PhysicalOrVirtualBoundary = PhysicalOrVirtualBoundary;
			this.InternalOrExternalBoundary = InternalOrExternalBoundary;
		}
	}

	public class IfcRelSpaceBoundary1stLevel : IfcRelSpaceBoundary
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	RelatingSpace : IfcSpaceBoundarySelect
		//6	RelatedBuildingElement : IfcElement
		//7	ConnectionGeometry : IfcConnectionGeometry
		//8	PhysicalOrVirtualBoundary : IfcPhysicalOrVirtualEnum
		//9	InternalOrExternalBoundary : IfcInternalOrExternalEnum
		//10	ParentBoundary : IfcRelSpaceBoundary1stLevel

		public IfcRelSpaceBoundary1stLevel ParentBoundary { get; set; }
		public List<IfcRelSpaceBoundary1stLevel> InnerBoundaries { get; set; }

		public IfcRelSpaceBoundary1stLevel() { }

		public IfcRelSpaceBoundary1stLevel(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcSpaceBoundarySelect RelatingSpace, IfcElement RelatedBuildingElement, IfcConnectionGeometry ConnectionGeometry, IfcPhysicalOrVirtualEnum PhysicalOrVirtualBoundary, IfcInternalOrExternalEnum InternalOrExternalBoundary, IfcRelSpaceBoundary1stLevel ParentBoundary)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.RelatingSpace = RelatingSpace;
			this.RelatedBuildingElement = RelatedBuildingElement;
			this.ConnectionGeometry = ConnectionGeometry;
			this.PhysicalOrVirtualBoundary = PhysicalOrVirtualBoundary;
			this.InternalOrExternalBoundary = InternalOrExternalBoundary;
			this.ParentBoundary = ParentBoundary;
		}
	}

	public class IfcRelSpaceBoundary2ndLevel : IfcRelSpaceBoundary1stLevel
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	RelatingSpace : IfcSpaceBoundarySelect
		//6	RelatedBuildingElement : IfcElement
		//7	ConnectionGeometry : IfcConnectionGeometry
		//8	PhysicalOrVirtualBoundary : IfcPhysicalOrVirtualEnum
		//9	InternalOrExternalBoundary : IfcInternalOrExternalEnum
		//10	ParentBoundary : IfcRelSpaceBoundary1stLevel
		//11	CorrespondingBoundary : IfcRelSpaceBoundary2ndLevel

		public IfcRelSpaceBoundary2ndLevel CorrespondingBoundary { get; set; }
		public List<IfcRelSpaceBoundary2ndLevel> Corresponds { get; set; }

		public IfcRelSpaceBoundary2ndLevel() { }

		public IfcRelSpaceBoundary2ndLevel(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcSpaceBoundarySelect RelatingSpace, IfcElement RelatedBuildingElement, IfcConnectionGeometry ConnectionGeometry, IfcPhysicalOrVirtualEnum PhysicalOrVirtualBoundary, IfcInternalOrExternalEnum InternalOrExternalBoundary, IfcRelSpaceBoundary1stLevel ParentBoundary, IfcRelSpaceBoundary2ndLevel CorrespondingBoundary)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.RelatingSpace = RelatingSpace;
			this.RelatedBuildingElement = RelatedBuildingElement;
			this.ConnectionGeometry = ConnectionGeometry;
			this.PhysicalOrVirtualBoundary = PhysicalOrVirtualBoundary;
			this.InternalOrExternalBoundary = InternalOrExternalBoundary;
			this.ParentBoundary = ParentBoundary;
			this.CorrespondingBoundary = CorrespondingBoundary;
		}
	}

	public class IfcRelVoidsElement : IfcRelDecomposes
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	RelatingBuildingElement : IfcElement
		//6	RelatedOpeningElement : IfcFeatureElementSubtraction

		public IfcElement RelatingBuildingElement { get; set; }
		public IfcFeatureElementSubtraction RelatedOpeningElement { get; set; }

		public IfcRelVoidsElement() { }

		public IfcRelVoidsElement(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcElement RelatingBuildingElement, IfcFeatureElementSubtraction RelatedOpeningElement)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.RelatingBuildingElement = RelatingBuildingElement;
			this.RelatedOpeningElement = RelatedOpeningElement;
		}
	}

	public abstract class IfcRelationship : IfcRoot
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText

		public IfcRelationship() { }

		public IfcRelationship(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
		}
	}

	public class IfcReparametrisedCompositeCurveSegment : IfcCompositeCurveSegment
	{
		//1	Transition : IfcTransitionCode
		//2	SameSense : IfcBoolean
		//3	ParentCurve : IfcCurve
		//4	ParamLength : IfcParameterValue

		public IfcParameterValue ParamLength { get; set; }

		public IfcReparametrisedCompositeCurveSegment() { }

		public IfcReparametrisedCompositeCurveSegment(IfcTransitionCode Transition, IfcBoolean SameSense, IfcCurve ParentCurve, IfcParameterValue ParamLength)
		{
			this.Transition = Transition;
			this.SameSense = SameSense;
			this.ParentCurve = ParentCurve;
			this.ParamLength = ParamLength;
		}
	}

	public abstract class IfcRepresentation : IfcBase, IfcLayeredItem
	{
		//1	ContextOfItems : IfcRepresentationContext
		//2	RepresentationIdentifier : IfcLabel
		//3	RepresentationType : IfcLabel
		//4	Items : List<IfcRepresentationItem>

		public IfcRepresentationContext ContextOfItems { get; set; }
		public IfcLabel RepresentationIdentifier { get; set; }
		public IfcLabel RepresentationType { get; set; }
		public List<IfcRepresentationItem> Items { get; set; }
		public List<IfcRepresentationMap> RepresentationMap { get; set; }
		public List<IfcPresentationLayerAssignment> LayerAssignments { get; set; }
		public List<IfcProductRepresentation> OfProductRepresentation { get; set; }

		public IfcRepresentation() { }

		public IfcRepresentation(IfcRepresentationContext ContextOfItems, IfcLabel RepresentationIdentifier, IfcLabel RepresentationType, List<IfcRepresentationItem> Items)
		{
			this.ContextOfItems = ContextOfItems;
			this.RepresentationIdentifier = RepresentationIdentifier;
			this.RepresentationType = RepresentationType;
			this.Items = Items;
		}
	}

	public abstract class IfcRepresentationContext : IfcBase
	{
		//1	ContextIdentifier : IfcLabel
		//2	ContextType : IfcLabel

		public IfcLabel ContextIdentifier { get; set; }
		public IfcLabel ContextType { get; set; }
		public List<IfcRepresentation> RepresentationsInContext { get; set; }

		public IfcRepresentationContext() { }

		public IfcRepresentationContext(IfcLabel ContextIdentifier, IfcLabel ContextType)
		{
			this.ContextIdentifier = ContextIdentifier;
			this.ContextType = ContextType;
		}
	}

	public abstract class IfcRepresentationItem : IfcBase, IfcLayeredItem
	{
		public List<IfcPresentationLayerAssignment> LayerAssignment { get; set; }
		public List<IfcStyledItem> StyledByItem { get; set; }

		public IfcRepresentationItem() { }
	}

	public class IfcRepresentationMap : IfcBase
	{
		//1	MappingOrigin : IfcAxis2Placement
		//2	MappedRepresentation : IfcRepresentation

		public IfcAxis2Placement MappingOrigin { get; set; }
		public IfcRepresentation MappedRepresentation { get; set; }
		public List<IfcShapeAspect> HasShapeAspects { get; set; }
		public List<IfcMappedItem> MapUsage { get; set; }

		public IfcRepresentationMap() { }

		public IfcRepresentationMap(IfcAxis2Placement MappingOrigin, IfcRepresentation MappedRepresentation)
		{
			this.MappingOrigin = MappingOrigin;
			this.MappedRepresentation = MappedRepresentation;
		}
	}

	public abstract class IfcResource : IfcObject, IfcResourceSelect
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	Identification : IfcIdentifier
		//7	LongDescription : IfcText

		public IfcIdentifier Identification { get; set; }
		public IfcText LongDescription { get; set; }
		public List<IfcRelAssignsToResource> ResourceOf { get; set; }
		public IfcIdentifier GetIdentification() { return Identification; }
		public IfcText GetLongDescription() { return LongDescription; }
		public List<IfcRelAssignsToResource> GetResourceOf() { return ResourceOf; }

		public IfcResource() { }

		public IfcResource(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcIdentifier Identification, IfcText LongDescription)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.Identification = Identification;
			this.LongDescription = LongDescription;
		}
	}

	public class IfcResourceApprovalRelationship : IfcResourceLevelRelationship
	{
		//1	Name : IfcLabel
		//2	Description : IfcText
		//3	RelatedResourceObjects : List<IfcResourceObjectSelect>
		//4	RelatingApproval : IfcApproval

		public List<IfcResourceObjectSelect> RelatedResourceObjects { get; set; }
		public IfcApproval RelatingApproval { get; set; }

		public IfcResourceApprovalRelationship() { }

		public IfcResourceApprovalRelationship(IfcLabel Name, IfcText Description, List<IfcResourceObjectSelect> RelatedResourceObjects, IfcApproval RelatingApproval)
		{
			this.Name = Name;
			this.Description = Description;
			this.RelatedResourceObjects = RelatedResourceObjects;
			this.RelatingApproval = RelatingApproval;
		}
	}

	public class IfcResourceConstraintRelationship : IfcResourceLevelRelationship
	{
		//1	Name : IfcLabel
		//2	Description : IfcText
		//3	RelatingConstraint : IfcConstraint
		//4	RelatedResourceObjects : List<IfcResourceObjectSelect>

		public IfcConstraint RelatingConstraint { get; set; }
		public List<IfcResourceObjectSelect> RelatedResourceObjects { get; set; }

		public IfcResourceConstraintRelationship() { }

		public IfcResourceConstraintRelationship(IfcLabel Name, IfcText Description, IfcConstraint RelatingConstraint, List<IfcResourceObjectSelect> RelatedResourceObjects)
		{
			this.Name = Name;
			this.Description = Description;
			this.RelatingConstraint = RelatingConstraint;
			this.RelatedResourceObjects = RelatedResourceObjects;
		}
	}

	public abstract class IfcResourceLevelRelationship : IfcBase
	{
		//1	Name : IfcLabel
		//2	Description : IfcText

		public IfcLabel Name { get; set; }
		public IfcText Description { get; set; }

		public IfcResourceLevelRelationship() { }

		public IfcResourceLevelRelationship(IfcLabel Name, IfcText Description)
		{
			this.Name = Name;
			this.Description = Description;
		}
	}

	public class IfcResourceTime : IfcSchedulingTime
	{
		//1	Name : IfcLabel
		//2	DataOrigin : IfcDataOriginEnum
		//3	UserDefinedDataOrigin : IfcLabel
		//4	ScheduleWork : IfcDuration
		//5	ScheduleUsage : IfcPositiveRatioMeasure
		//6	ScheduleStart : IfcDateTime
		//7	ScheduleFinish : IfcDateTime
		//8	ScheduleContour : IfcLabel
		//9	LevelingDelay : IfcDuration
		//10	IsOverAllocated : IfcBoolean
		//11	StatusTime : IfcDateTime
		//12	ActualWork : IfcDuration
		//13	ActualUsage : IfcPositiveRatioMeasure
		//14	ActualStart : IfcDateTime
		//15	ActualFinish : IfcDateTime
		//16	RemainingWork : IfcDuration
		//17	RemainingUsage : IfcPositiveRatioMeasure
		//18	Completion : IfcPositiveRatioMeasure

		public IfcDuration ScheduleWork { get; set; }
		public IfcPositiveRatioMeasure ScheduleUsage { get; set; }
		public IfcDateTime ScheduleStart { get; set; }
		public IfcDateTime ScheduleFinish { get; set; }
		public IfcLabel ScheduleContour { get; set; }
		public IfcDuration LevelingDelay { get; set; }
		public IfcBoolean IsOverAllocated { get; set; }
		public IfcDateTime StatusTime { get; set; }
		public IfcDuration ActualWork { get; set; }
		public IfcPositiveRatioMeasure ActualUsage { get; set; }
		public IfcDateTime ActualStart { get; set; }
		public IfcDateTime ActualFinish { get; set; }
		public IfcDuration RemainingWork { get; set; }
		public IfcPositiveRatioMeasure RemainingUsage { get; set; }
		public IfcPositiveRatioMeasure Completion { get; set; }

		public IfcResourceTime() { }

		public IfcResourceTime(IfcLabel Name, IfcDataOriginEnum DataOrigin, IfcLabel UserDefinedDataOrigin, IfcDuration ScheduleWork, IfcPositiveRatioMeasure ScheduleUsage, IfcDateTime ScheduleStart, IfcDateTime ScheduleFinish, IfcLabel ScheduleContour, IfcDuration LevelingDelay, IfcBoolean IsOverAllocated, IfcDateTime StatusTime, IfcDuration ActualWork, IfcPositiveRatioMeasure ActualUsage, IfcDateTime ActualStart, IfcDateTime ActualFinish, IfcDuration RemainingWork, IfcPositiveRatioMeasure RemainingUsage, IfcPositiveRatioMeasure Completion)
		{
			this.Name = Name;
			this.DataOrigin = DataOrigin;
			this.UserDefinedDataOrigin = UserDefinedDataOrigin;
			this.ScheduleWork = ScheduleWork;
			this.ScheduleUsage = ScheduleUsage;
			this.ScheduleStart = ScheduleStart;
			this.ScheduleFinish = ScheduleFinish;
			this.ScheduleContour = ScheduleContour;
			this.LevelingDelay = LevelingDelay;
			this.IsOverAllocated = IsOverAllocated;
			this.StatusTime = StatusTime;
			this.ActualWork = ActualWork;
			this.ActualUsage = ActualUsage;
			this.ActualStart = ActualStart;
			this.ActualFinish = ActualFinish;
			this.RemainingWork = RemainingWork;
			this.RemainingUsage = RemainingUsage;
			this.Completion = Completion;
		}
	}

	public class IfcRevolvedAreaSolid : IfcSweptAreaSolid
	{
		//1	SweptArea : IfcProfileDef
		//2	Position : IfcAxis2Placement3D
		//3	Axis : IfcAxis1Placement
		//4	Angle : IfcPlaneAngleMeasure

		public IfcAxis1Placement Axis { get; set; }
		public IfcPlaneAngleMeasure Angle { get; set; }
		public IfcLine AxisLine { get; set; }

		public IfcRevolvedAreaSolid() { }

		public IfcRevolvedAreaSolid(IfcProfileDef SweptArea, IfcAxis2Placement3D Position, IfcAxis1Placement Axis, IfcPlaneAngleMeasure Angle)
		{
			this.SweptArea = SweptArea;
			this.Position = Position;
			this.Axis = Axis;
			this.Angle = Angle;
		}
	}

	public class IfcRevolvedAreaSolidTapered : IfcRevolvedAreaSolid
	{
		//1	SweptArea : IfcProfileDef
		//2	Position : IfcAxis2Placement3D
		//3	Axis : IfcAxis1Placement
		//4	Angle : IfcPlaneAngleMeasure
		//5	EndSweptArea : IfcProfileDef

		public IfcProfileDef EndSweptArea { get; set; }

		public IfcRevolvedAreaSolidTapered() { }

		public IfcRevolvedAreaSolidTapered(IfcProfileDef SweptArea, IfcAxis2Placement3D Position, IfcAxis1Placement Axis, IfcPlaneAngleMeasure Angle, IfcProfileDef EndSweptArea)
		{
			this.SweptArea = SweptArea;
			this.Position = Position;
			this.Axis = Axis;
			this.Angle = Angle;
			this.EndSweptArea = EndSweptArea;
		}
	}

	public class IfcRightCircularCone : IfcCsgPrimitive3D
	{
		//1	Position : IfcAxis2Placement3D
		//2	Height : IfcPositiveLengthMeasure
		//3	BottomRadius : IfcPositiveLengthMeasure

		public IfcPositiveLengthMeasure Height { get; set; }
		public IfcPositiveLengthMeasure BottomRadius { get; set; }

		public IfcRightCircularCone() { }

		public IfcRightCircularCone(IfcAxis2Placement3D Position, IfcPositiveLengthMeasure Height, IfcPositiveLengthMeasure BottomRadius)
		{
			this.Position = Position;
			this.Height = Height;
			this.BottomRadius = BottomRadius;
		}
	}

	public class IfcRightCircularCylinder : IfcCsgPrimitive3D
	{
		//1	Position : IfcAxis2Placement3D
		//2	Height : IfcPositiveLengthMeasure
		//3	Radius : IfcPositiveLengthMeasure

		public IfcPositiveLengthMeasure Height { get; set; }
		public IfcPositiveLengthMeasure Radius { get; set; }

		public IfcRightCircularCylinder() { }

		public IfcRightCircularCylinder(IfcAxis2Placement3D Position, IfcPositiveLengthMeasure Height, IfcPositiveLengthMeasure Radius)
		{
			this.Position = Position;
			this.Height = Height;
			this.Radius = Radius;
		}
	}

	public class IfcRoof : IfcBuildingElement
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	PredefinedType : IfcRoofTypeEnum

		public IfcRoofTypeEnum PredefinedType { get; set; }

		public IfcRoof() { }

		public IfcRoof(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcRoofTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcRoofType : IfcBuildingElementType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel
		//10	PredefinedType : IfcRoofTypeEnum

		public IfcRoofTypeEnum PredefinedType { get; set; }

		public IfcRoofType() { }

		public IfcRoofType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType, IfcRoofTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
			this.PredefinedType = PredefinedType;
		}
	}

	public abstract class IfcRoot : IfcBase
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText

		public IfcGloballyUniqueId GlobalId { get; set; }
		public IfcOwnerHistory OwnerHistory { get; set; }
		public IfcLabel Name { get; set; }
		public IfcText Description { get; set; }

		public IfcRoot() { }

		public IfcRoot(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
		}
	}

	public class IfcRoundedRectangleProfileDef : IfcRectangleProfileDef
	{
		//1	ProfileType : IfcProfileTypeEnum
		//2	ProfileName : IfcLabel
		//3	Position : IfcAxis2Placement2D
		//4	XDim : IfcPositiveLengthMeasure
		//5	YDim : IfcPositiveLengthMeasure
		//6	RoundingRadius : IfcPositiveLengthMeasure

		public IfcPositiveLengthMeasure RoundingRadius { get; set; }

		public IfcRoundedRectangleProfileDef() { }

		public IfcRoundedRectangleProfileDef(IfcProfileTypeEnum ProfileType, IfcLabel ProfileName, IfcAxis2Placement2D Position, IfcPositiveLengthMeasure XDim, IfcPositiveLengthMeasure YDim, IfcPositiveLengthMeasure RoundingRadius)
		{
			this.ProfileType = ProfileType;
			this.ProfileName = ProfileName;
			this.Position = Position;
			this.XDim = XDim;
			this.YDim = YDim;
			this.RoundingRadius = RoundingRadius;
		}
	}

	public class IfcSIUnit : IfcNamedUnit
	{
		//1	Dimensions : IfcDimensionalExponents
		//2	UnitType : IfcUnitEnum
		//3	Prefix : IfcSIPrefix
		//4	Name : IfcSIUnitName

		public IfcSIPrefix Prefix { get; set; }
		public IfcSIUnitName Name { get; set; }

		public IfcSIUnit() { }

		public IfcSIUnit(IfcDimensionalExponents Dimensions, IfcUnitEnum UnitType, IfcSIPrefix Prefix, IfcSIUnitName Name)
		{
			this.Dimensions = Dimensions;
			this.UnitType = UnitType;
			this.Prefix = Prefix;
			this.Name = Name;
		}
	}

	public class IfcSanitaryTerminal : IfcFlowTerminal
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	PredefinedType : IfcSanitaryTerminalTypeEnum

		public IfcSanitaryTerminalTypeEnum PredefinedType { get; set; }

		public IfcSanitaryTerminal() { }

		public IfcSanitaryTerminal(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcSanitaryTerminalTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcSanitaryTerminalType : IfcFlowTerminalType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel
		//10	PredefinedType : IfcSanitaryTerminalTypeEnum

		public IfcSanitaryTerminalTypeEnum PredefinedType { get; set; }

		public IfcSanitaryTerminalType() { }

		public IfcSanitaryTerminalType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType, IfcSanitaryTerminalTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
			this.PredefinedType = PredefinedType;
		}
	}

	public abstract class IfcSchedulingTime : IfcBase
	{
		//1	Name : IfcLabel
		//2	DataOrigin : IfcDataOriginEnum
		//3	UserDefinedDataOrigin : IfcLabel

		public IfcLabel Name { get; set; }
		public IfcDataOriginEnum DataOrigin { get; set; }
		public IfcLabel UserDefinedDataOrigin { get; set; }

		public IfcSchedulingTime() { }

		public IfcSchedulingTime(IfcLabel Name, IfcDataOriginEnum DataOrigin, IfcLabel UserDefinedDataOrigin)
		{
			this.Name = Name;
			this.DataOrigin = DataOrigin;
			this.UserDefinedDataOrigin = UserDefinedDataOrigin;
		}
	}

	public class IfcSeamCurve : IfcSurfaceCurve
	{
		//1	Curve3D : IfcCurve
		//2	AssociatedGeometry : List<IfcPcurve>
		//3	MasterRepresentation : IfcPreferredSurfaceCurveRepresentation

		public IfcSeamCurve() { }

		public IfcSeamCurve(IfcCurve Curve3D, List<IfcPcurve> AssociatedGeometry, IfcPreferredSurfaceCurveRepresentation MasterRepresentation)
		{
			this.Curve3D = Curve3D;
			this.AssociatedGeometry = AssociatedGeometry;
			this.MasterRepresentation = MasterRepresentation;
		}
	}

	public class IfcSectionProperties : IfcPreDefinedProperties
	{
		//1	SectionType : IfcSectionTypeEnum
		//2	StartProfile : IfcProfileDef
		//3	EndProfile : IfcProfileDef

		public IfcSectionTypeEnum SectionType { get; set; }
		public IfcProfileDef StartProfile { get; set; }
		public IfcProfileDef EndProfile { get; set; }

		public IfcSectionProperties() { }

		public IfcSectionProperties(IfcSectionTypeEnum SectionType, IfcProfileDef StartProfile, IfcProfileDef EndProfile)
		{
			this.SectionType = SectionType;
			this.StartProfile = StartProfile;
			this.EndProfile = EndProfile;
		}
	}

	public class IfcSectionReinforcementProperties : IfcPreDefinedProperties
	{
		//1	LongitudinalStartPosition : IfcLengthMeasure
		//2	LongitudinalEndPosition : IfcLengthMeasure
		//3	TransversePosition : IfcLengthMeasure
		//4	ReinforcementRole : IfcReinforcingBarRoleEnum
		//5	SectionDefinition : IfcSectionProperties
		//6	CrossSectionReinforcementDefinitions : List<IfcReinforcementBarProperties>

		public IfcLengthMeasure LongitudinalStartPosition { get; set; }
		public IfcLengthMeasure LongitudinalEndPosition { get; set; }
		public IfcLengthMeasure TransversePosition { get; set; }
		public IfcReinforcingBarRoleEnum ReinforcementRole { get; set; }
		public IfcSectionProperties SectionDefinition { get; set; }
		public List<IfcReinforcementBarProperties> CrossSectionReinforcementDefinitions { get; set; }

		public IfcSectionReinforcementProperties() { }

		public IfcSectionReinforcementProperties(IfcLengthMeasure LongitudinalStartPosition, IfcLengthMeasure LongitudinalEndPosition, IfcLengthMeasure TransversePosition, IfcReinforcingBarRoleEnum ReinforcementRole, IfcSectionProperties SectionDefinition, List<IfcReinforcementBarProperties> CrossSectionReinforcementDefinitions)
		{
			this.LongitudinalStartPosition = LongitudinalStartPosition;
			this.LongitudinalEndPosition = LongitudinalEndPosition;
			this.TransversePosition = TransversePosition;
			this.ReinforcementRole = ReinforcementRole;
			this.SectionDefinition = SectionDefinition;
			this.CrossSectionReinforcementDefinitions = CrossSectionReinforcementDefinitions;
		}
	}

	public class IfcSectionedSpine : IfcGeometricRepresentationItem
	{
		//1	SpineCurve : IfcCompositeCurve
		//2	CrossSections : List<IfcProfileDef>
		//3	CrossSectionPositions : List<IfcAxis2Placement3D>

		public IfcCompositeCurve SpineCurve { get; set; }
		public List<IfcProfileDef> CrossSections { get; set; }
		public List<IfcAxis2Placement3D> CrossSectionPositions { get; set; }
		public IfcDimensionCount Dim { get; set; }

		public IfcSectionedSpine() { }

		public IfcSectionedSpine(IfcCompositeCurve SpineCurve, List<IfcProfileDef> CrossSections, List<IfcAxis2Placement3D> CrossSectionPositions)
		{
			this.SpineCurve = SpineCurve;
			this.CrossSections = CrossSections;
			this.CrossSectionPositions = CrossSectionPositions;
		}
	}

	public class IfcSensor : IfcDistributionControlElement
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	PredefinedType : IfcSensorTypeEnum

		public IfcSensorTypeEnum PredefinedType { get; set; }

		public IfcSensor() { }

		public IfcSensor(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcSensorTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcSensorType : IfcDistributionControlElementType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel
		//10	PredefinedType : IfcSensorTypeEnum

		public IfcSensorTypeEnum PredefinedType { get; set; }

		public IfcSensorType() { }

		public IfcSensorType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType, IfcSensorTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcShadingDevice : IfcBuildingElement
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	PredefinedType : IfcShadingDeviceTypeEnum

		public IfcShadingDeviceTypeEnum PredefinedType { get; set; }

		public IfcShadingDevice() { }

		public IfcShadingDevice(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcShadingDeviceTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcShadingDeviceType : IfcBuildingElementType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel
		//10	PredefinedType : IfcShadingDeviceTypeEnum

		public IfcShadingDeviceTypeEnum PredefinedType { get; set; }

		public IfcShadingDeviceType() { }

		public IfcShadingDeviceType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType, IfcShadingDeviceTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcShapeAspect : IfcBase
	{
		//1	ShapeRepresentations : List<IfcShapeModel>
		//2	Name : IfcLabel
		//3	Description : IfcText
		//4	ProductDefinitional : IfcLogical
		//5	PartOfProductDefinitionShape : IfcProductRepresentationSelect

		public List<IfcShapeModel> ShapeRepresentations { get; set; }
		public IfcLabel Name { get; set; }
		public IfcText Description { get; set; }
		public IfcLogical ProductDefinitional { get; set; }
		public IfcProductRepresentationSelect PartOfProductDefinitionShape { get; set; }

		public IfcShapeAspect() { }

		public IfcShapeAspect(List<IfcShapeModel> ShapeRepresentations, IfcLabel Name, IfcText Description, IfcLogical ProductDefinitional, IfcProductRepresentationSelect PartOfProductDefinitionShape)
		{
			this.ShapeRepresentations = ShapeRepresentations;
			this.Name = Name;
			this.Description = Description;
			this.ProductDefinitional = ProductDefinitional;
			this.PartOfProductDefinitionShape = PartOfProductDefinitionShape;
		}
	}

	public abstract class IfcShapeModel : IfcRepresentation
	{
		//1	ContextOfItems : IfcRepresentationContext
		//2	RepresentationIdentifier : IfcLabel
		//3	RepresentationType : IfcLabel
		//4	Items : List<IfcRepresentationItem>

		public List<IfcShapeAspect> OfShapeAspect { get; set; }

		public IfcShapeModel() { }

		public IfcShapeModel(IfcRepresentationContext ContextOfItems, IfcLabel RepresentationIdentifier, IfcLabel RepresentationType, List<IfcRepresentationItem> Items)
		{
			this.ContextOfItems = ContextOfItems;
			this.RepresentationIdentifier = RepresentationIdentifier;
			this.RepresentationType = RepresentationType;
			this.Items = Items;
		}
	}

	public class IfcShapeRepresentation : IfcShapeModel
	{
		//1	ContextOfItems : IfcRepresentationContext
		//2	RepresentationIdentifier : IfcLabel
		//3	RepresentationType : IfcLabel
		//4	Items : List<IfcRepresentationItem>

		public IfcShapeRepresentation() { }

		public IfcShapeRepresentation(IfcRepresentationContext ContextOfItems, IfcLabel RepresentationIdentifier, IfcLabel RepresentationType, List<IfcRepresentationItem> Items)
		{
			this.ContextOfItems = ContextOfItems;
			this.RepresentationIdentifier = RepresentationIdentifier;
			this.RepresentationType = RepresentationType;
			this.Items = Items;
		}
	}

	public class IfcShellBasedSurfaceModel : IfcGeometricRepresentationItem
	{
		//1	SbsmBoundary : List<IfcShell>

		public List<IfcShell> SbsmBoundary { get; set; }
		public IfcDimensionCount Dim { get; set; }

		public IfcShellBasedSurfaceModel() { }

		public IfcShellBasedSurfaceModel(List<IfcShell> SbsmBoundary)
		{
			this.SbsmBoundary = SbsmBoundary;
		}
	}

	public abstract class IfcSimpleProperty : IfcProperty
	{
		//1	Name : IfcIdentifier
		//2	Description : IfcText

		public IfcSimpleProperty() { }

		public IfcSimpleProperty(IfcIdentifier Name, IfcText Description)
		{
			this.Name = Name;
			this.Description = Description;
		}
	}

	public class IfcSimplePropertyTemplate : IfcPropertyTemplate
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	TemplateType : IfcSimplePropertyTemplateTypeEnum
		//6	PrimaryMeasureType : IfcLabel
		//7	SecondaryMeasureType : IfcLabel
		//8	Enumerators : IfcPropertyEnumeration
		//9	PrimaryUnit : IfcUnit
		//10	SecondaryUnit : IfcUnit
		//11	Expression : IfcLabel
		//12	AccessState : IfcStateEnum

		public IfcSimplePropertyTemplateTypeEnum TemplateType { get; set; }
		public IfcLabel PrimaryMeasureType { get; set; }
		public IfcLabel SecondaryMeasureType { get; set; }
		public IfcPropertyEnumeration Enumerators { get; set; }
		public IfcUnit PrimaryUnit { get; set; }
		public IfcUnit SecondaryUnit { get; set; }
		public IfcLabel Expression { get; set; }
		public IfcStateEnum AccessState { get; set; }

		public IfcSimplePropertyTemplate() { }

		public IfcSimplePropertyTemplate(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcSimplePropertyTemplateTypeEnum TemplateType, IfcLabel PrimaryMeasureType, IfcLabel SecondaryMeasureType, IfcPropertyEnumeration Enumerators, IfcUnit PrimaryUnit, IfcUnit SecondaryUnit, IfcLabel Expression, IfcStateEnum AccessState)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.TemplateType = TemplateType;
			this.PrimaryMeasureType = PrimaryMeasureType;
			this.SecondaryMeasureType = SecondaryMeasureType;
			this.Enumerators = Enumerators;
			this.PrimaryUnit = PrimaryUnit;
			this.SecondaryUnit = SecondaryUnit;
			this.Expression = Expression;
			this.AccessState = AccessState;
		}
	}

	public class IfcSite : IfcSpatialStructureElement
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	LongName : IfcLabel
		//9	CompositionType : IfcElementCompositionEnum
		//10	RefLatitude : IfcCompoundPlaneAngleMeasure
		//11	RefLongitude : IfcCompoundPlaneAngleMeasure
		//12	RefElevation : IfcLengthMeasure
		//13	LandTitleNumber : IfcLabel
		//14	SiteAddress : IfcPostalAddress

		public IfcCompoundPlaneAngleMeasure RefLatitude { get; set; }
		public IfcCompoundPlaneAngleMeasure RefLongitude { get; set; }
		public IfcLengthMeasure RefElevation { get; set; }
		public IfcLabel LandTitleNumber { get; set; }
		public IfcPostalAddress SiteAddress { get; set; }

		public IfcSite() { }

		public IfcSite(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcLabel LongName, IfcElementCompositionEnum CompositionType, IfcCompoundPlaneAngleMeasure RefLatitude, IfcCompoundPlaneAngleMeasure RefLongitude, IfcLengthMeasure RefElevation, IfcLabel LandTitleNumber, IfcPostalAddress SiteAddress)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.LongName = LongName;
			this.CompositionType = CompositionType;
			this.RefLatitude = RefLatitude;
			this.RefLongitude = RefLongitude;
			this.RefElevation = RefElevation;
			this.LandTitleNumber = LandTitleNumber;
			this.SiteAddress = SiteAddress;
		}
	}

	public class IfcSlab : IfcBuildingElement
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	PredefinedType : IfcSlabTypeEnum

		public IfcSlabTypeEnum PredefinedType { get; set; }

		public IfcSlab() { }

		public IfcSlab(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcSlabTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcSlabElementedCase : IfcSlab
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	PredefinedType : IfcSlabTypeEnum

		public IfcSlabElementedCase() { }

		public IfcSlabElementedCase(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcSlabTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcSlabStandardCase : IfcSlab
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	PredefinedType : IfcSlabTypeEnum

		public IfcSlabStandardCase() { }

		public IfcSlabStandardCase(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcSlabTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcSlabType : IfcBuildingElementType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel
		//10	PredefinedType : IfcSlabTypeEnum

		public IfcSlabTypeEnum PredefinedType { get; set; }

		public IfcSlabType() { }

		public IfcSlabType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType, IfcSlabTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcSlippageConnectionCondition : IfcStructuralConnectionCondition
	{
		//1	Name : IfcLabel
		//2	SlippageX : IfcLengthMeasure
		//3	SlippageY : IfcLengthMeasure
		//4	SlippageZ : IfcLengthMeasure

		public IfcLengthMeasure SlippageX { get; set; }
		public IfcLengthMeasure SlippageY { get; set; }
		public IfcLengthMeasure SlippageZ { get; set; }

		public IfcSlippageConnectionCondition() { }

		public IfcSlippageConnectionCondition(IfcLabel Name, IfcLengthMeasure SlippageX, IfcLengthMeasure SlippageY, IfcLengthMeasure SlippageZ)
		{
			this.Name = Name;
			this.SlippageX = SlippageX;
			this.SlippageY = SlippageY;
			this.SlippageZ = SlippageZ;
		}
	}

	public class IfcSolarDevice : IfcEnergyConversionDevice
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	PredefinedType : IfcSolarDeviceTypeEnum

		public IfcSolarDeviceTypeEnum PredefinedType { get; set; }

		public IfcSolarDevice() { }

		public IfcSolarDevice(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcSolarDeviceTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcSolarDeviceType : IfcEnergyConversionDeviceType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel
		//10	PredefinedType : IfcSolarDeviceTypeEnum

		public IfcSolarDeviceTypeEnum PredefinedType { get; set; }

		public IfcSolarDeviceType() { }

		public IfcSolarDeviceType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType, IfcSolarDeviceTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
			this.PredefinedType = PredefinedType;
		}
	}

	public abstract class IfcSolidModel : IfcGeometricRepresentationItem, IfcBooleanOperand, IfcSolidOrShell
	{
		public IfcDimensionCount Dim { get; set; }
		public IfcDimensionCount GetDim() { return Dim; }

		public IfcSolidModel() { }
	}

	public class IfcSpace : IfcSpatialStructureElement, IfcSpaceBoundarySelect
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	LongName : IfcLabel
		//9	CompositionType : IfcElementCompositionEnum
		//10	PredefinedType : IfcSpaceTypeEnum
		//11	ElevationWithFlooring : IfcLengthMeasure

		public IfcSpaceTypeEnum PredefinedType { get; set; }
		public IfcLengthMeasure ElevationWithFlooring { get; set; }
		public List<IfcRelCoversSpaces> HasCoverings { get; set; }
		public List<IfcRelSpaceBoundary> BoundedBy { get; set; }
		public List<IfcRelSpaceBoundary> GetBoundedBy() { return BoundedBy; }

		public IfcSpace() { }

		public IfcSpace(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcLabel LongName, IfcElementCompositionEnum CompositionType, IfcSpaceTypeEnum PredefinedType, IfcLengthMeasure ElevationWithFlooring)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.LongName = LongName;
			this.CompositionType = CompositionType;
			this.PredefinedType = PredefinedType;
			this.ElevationWithFlooring = ElevationWithFlooring;
		}
	}

	public class IfcSpaceHeater : IfcFlowTerminal
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	PredefinedType : IfcSpaceHeaterTypeEnum

		public IfcSpaceHeaterTypeEnum PredefinedType { get; set; }

		public IfcSpaceHeater() { }

		public IfcSpaceHeater(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcSpaceHeaterTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcSpaceHeaterType : IfcFlowTerminalType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel
		//10	PredefinedType : IfcSpaceHeaterTypeEnum

		public IfcSpaceHeaterTypeEnum PredefinedType { get; set; }

		public IfcSpaceHeaterType() { }

		public IfcSpaceHeaterType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType, IfcSpaceHeaterTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcSpaceType : IfcSpatialStructureElementType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel
		//10	PredefinedType : IfcSpaceTypeEnum
		//11	LongName : IfcLabel

		public IfcSpaceTypeEnum PredefinedType { get; set; }
		public IfcLabel LongName { get; set; }

		public IfcSpaceType() { }

		public IfcSpaceType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType, IfcSpaceTypeEnum PredefinedType, IfcLabel LongName)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
			this.PredefinedType = PredefinedType;
			this.LongName = LongName;
		}
	}

	public abstract class IfcSpatialElement : IfcProduct
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	LongName : IfcLabel

		public IfcLabel LongName { get; set; }
		public List<IfcRelContainedInSpatialStructure> ContainsElements { get; set; }
		public List<IfcRelServicesBuildings> ServicedBySystems { get; set; }
		public List<IfcRelReferencedInSpatialStructure> ReferencesElements { get; set; }

		public IfcSpatialElement() { }

		public IfcSpatialElement(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcLabel LongName)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.LongName = LongName;
		}
	}

	public abstract class IfcSpatialElementType : IfcTypeProduct
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel

		public IfcLabel ElementType { get; set; }

		public IfcSpatialElementType() { }

		public IfcSpatialElementType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
		}
	}

	public abstract class IfcSpatialStructureElement : IfcSpatialElement
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	LongName : IfcLabel
		//9	CompositionType : IfcElementCompositionEnum

		public IfcElementCompositionEnum CompositionType { get; set; }

		public IfcSpatialStructureElement() { }

		public IfcSpatialStructureElement(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcLabel LongName, IfcElementCompositionEnum CompositionType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.LongName = LongName;
			this.CompositionType = CompositionType;
		}
	}

	public abstract class IfcSpatialStructureElementType : IfcSpatialElementType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel

		public IfcSpatialStructureElementType() { }

		public IfcSpatialStructureElementType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
		}
	}

	public class IfcSpatialZone : IfcSpatialElement
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	LongName : IfcLabel
		//9	PredefinedType : IfcSpatialZoneTypeEnum

		public IfcSpatialZoneTypeEnum PredefinedType { get; set; }

		public IfcSpatialZone() { }

		public IfcSpatialZone(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcLabel LongName, IfcSpatialZoneTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.LongName = LongName;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcSpatialZoneType : IfcSpatialElementType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel
		//10	PredefinedType : IfcSpatialZoneTypeEnum
		//11	LongName : IfcLabel

		public IfcSpatialZoneTypeEnum PredefinedType { get; set; }
		public IfcLabel LongName { get; set; }

		public IfcSpatialZoneType() { }

		public IfcSpatialZoneType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType, IfcSpatialZoneTypeEnum PredefinedType, IfcLabel LongName)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
			this.PredefinedType = PredefinedType;
			this.LongName = LongName;
		}
	}

	public class IfcSphere : IfcCsgPrimitive3D
	{
		//1	Position : IfcAxis2Placement3D
		//2	Radius : IfcPositiveLengthMeasure

		public IfcPositiveLengthMeasure Radius { get; set; }

		public IfcSphere() { }

		public IfcSphere(IfcAxis2Placement3D Position, IfcPositiveLengthMeasure Radius)
		{
			this.Position = Position;
			this.Radius = Radius;
		}
	}

	public class IfcSphericalSurface : IfcElementarySurface
	{
		//1	Position : IfcAxis2Placement3D
		//2	Radius : IfcPositiveLengthMeasure

		public IfcPositiveLengthMeasure Radius { get; set; }

		public IfcSphericalSurface() { }

		public IfcSphericalSurface(IfcAxis2Placement3D Position, IfcPositiveLengthMeasure Radius)
		{
			this.Position = Position;
			this.Radius = Radius;
		}
	}

	public class IfcStackTerminal : IfcFlowTerminal
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	PredefinedType : IfcStackTerminalTypeEnum

		public IfcStackTerminalTypeEnum PredefinedType { get; set; }

		public IfcStackTerminal() { }

		public IfcStackTerminal(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcStackTerminalTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcStackTerminalType : IfcFlowTerminalType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel
		//10	PredefinedType : IfcStackTerminalTypeEnum

		public IfcStackTerminalTypeEnum PredefinedType { get; set; }

		public IfcStackTerminalType() { }

		public IfcStackTerminalType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType, IfcStackTerminalTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcStair : IfcBuildingElement
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	PredefinedType : IfcStairTypeEnum

		public IfcStairTypeEnum PredefinedType { get; set; }

		public IfcStair() { }

		public IfcStair(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcStairTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcStairFlight : IfcBuildingElement
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	NumberOfRisers : IfcInteger
		//10	NumberOfTreads : IfcInteger
		//11	RiserHeight : IfcPositiveLengthMeasure
		//12	TreadLength : IfcPositiveLengthMeasure
		//13	PredefinedType : IfcStairFlightTypeEnum

		public IfcInteger NumberOfRisers { get; set; }
		public IfcInteger NumberOfTreads { get; set; }
		public IfcPositiveLengthMeasure RiserHeight { get; set; }
		public IfcPositiveLengthMeasure TreadLength { get; set; }
		public IfcStairFlightTypeEnum PredefinedType { get; set; }

		public IfcStairFlight() { }

		public IfcStairFlight(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcInteger NumberOfRisers, IfcInteger NumberOfTreads, IfcPositiveLengthMeasure RiserHeight, IfcPositiveLengthMeasure TreadLength, IfcStairFlightTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.NumberOfRisers = NumberOfRisers;
			this.NumberOfTreads = NumberOfTreads;
			this.RiserHeight = RiserHeight;
			this.TreadLength = TreadLength;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcStairFlightType : IfcBuildingElementType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel
		//10	PredefinedType : IfcStairFlightTypeEnum

		public IfcStairFlightTypeEnum PredefinedType { get; set; }

		public IfcStairFlightType() { }

		public IfcStairFlightType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType, IfcStairFlightTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcStairType : IfcBuildingElementType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel
		//10	PredefinedType : IfcStairTypeEnum

		public IfcStairTypeEnum PredefinedType { get; set; }

		public IfcStairType() { }

		public IfcStairType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType, IfcStairTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
			this.PredefinedType = PredefinedType;
		}
	}

	public abstract class IfcStructuralAction : IfcStructuralActivity
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	AppliedLoad : IfcStructuralLoad
		//9	GlobalOrLocal : IfcGlobalOrLocalEnum
		//10	DestabilizingLoad : IfcBoolean

		public IfcBoolean DestabilizingLoad { get; set; }

		public IfcStructuralAction() { }

		public IfcStructuralAction(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcStructuralLoad AppliedLoad, IfcGlobalOrLocalEnum GlobalOrLocal, IfcBoolean DestabilizingLoad)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.AppliedLoad = AppliedLoad;
			this.GlobalOrLocal = GlobalOrLocal;
			this.DestabilizingLoad = DestabilizingLoad;
		}
	}

	public abstract class IfcStructuralActivity : IfcProduct
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	AppliedLoad : IfcStructuralLoad
		//9	GlobalOrLocal : IfcGlobalOrLocalEnum

		public IfcStructuralLoad AppliedLoad { get; set; }
		public IfcGlobalOrLocalEnum GlobalOrLocal { get; set; }
		public List<IfcRelConnectsStructuralActivity> AssignedToStructuralItem { get; set; }

		public IfcStructuralActivity() { }

		public IfcStructuralActivity(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcStructuralLoad AppliedLoad, IfcGlobalOrLocalEnum GlobalOrLocal)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.AppliedLoad = AppliedLoad;
			this.GlobalOrLocal = GlobalOrLocal;
		}
	}

	public class IfcStructuralAnalysisModel : IfcSystem
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	PredefinedType : IfcAnalysisModelTypeEnum
		//7	OrientationOf2DPlane : IfcAxis2Placement3D
		//8	LoadedBy : List<IfcStructuralLoadGroup>
		//9	HasResults : List<IfcStructuralResultGroup>
		//10	SharedPlacement : IfcObjectPlacement

		public IfcAnalysisModelTypeEnum PredefinedType { get; set; }
		public IfcAxis2Placement3D OrientationOf2DPlane { get; set; }
		public List<IfcStructuralLoadGroup> LoadedBy { get; set; }
		public List<IfcStructuralResultGroup> HasResults { get; set; }
		public IfcObjectPlacement SharedPlacement { get; set; }

		public IfcStructuralAnalysisModel() { }

		public IfcStructuralAnalysisModel(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcAnalysisModelTypeEnum PredefinedType, IfcAxis2Placement3D OrientationOf2DPlane, List<IfcStructuralLoadGroup> LoadedBy, List<IfcStructuralResultGroup> HasResults, IfcObjectPlacement SharedPlacement)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.PredefinedType = PredefinedType;
			this.OrientationOf2DPlane = OrientationOf2DPlane;
			this.LoadedBy = LoadedBy;
			this.HasResults = HasResults;
			this.SharedPlacement = SharedPlacement;
		}
	}

	public abstract class IfcStructuralConnection : IfcStructuralItem
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	AppliedCondition : IfcBoundaryCondition

		public IfcBoundaryCondition AppliedCondition { get; set; }
		public List<IfcRelConnectsStructuralMember> ConnectsStructuralMembers { get; set; }

		public IfcStructuralConnection() { }

		public IfcStructuralConnection(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcBoundaryCondition AppliedCondition)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.AppliedCondition = AppliedCondition;
		}
	}

	public abstract class IfcStructuralConnectionCondition : IfcBase
	{
		//1	Name : IfcLabel

		public IfcLabel Name { get; set; }

		public IfcStructuralConnectionCondition() { }

		public IfcStructuralConnectionCondition(IfcLabel Name)
		{
			this.Name = Name;
		}
	}

	public class IfcStructuralCurveAction : IfcStructuralAction
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	AppliedLoad : IfcStructuralLoad
		//9	GlobalOrLocal : IfcGlobalOrLocalEnum
		//10	DestabilizingLoad : IfcBoolean
		//11	ProjectedOrTrue : IfcProjectedOrTrueLengthEnum
		//12	PredefinedType : IfcStructuralCurveActivityTypeEnum

		public IfcProjectedOrTrueLengthEnum ProjectedOrTrue { get; set; }
		public IfcStructuralCurveActivityTypeEnum PredefinedType { get; set; }

		public IfcStructuralCurveAction() { }

		public IfcStructuralCurveAction(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcStructuralLoad AppliedLoad, IfcGlobalOrLocalEnum GlobalOrLocal, IfcBoolean DestabilizingLoad, IfcProjectedOrTrueLengthEnum ProjectedOrTrue, IfcStructuralCurveActivityTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.AppliedLoad = AppliedLoad;
			this.GlobalOrLocal = GlobalOrLocal;
			this.DestabilizingLoad = DestabilizingLoad;
			this.ProjectedOrTrue = ProjectedOrTrue;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcStructuralCurveConnection : IfcStructuralConnection
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	AppliedCondition : IfcBoundaryCondition
		//9	Axis : IfcDirection

		public IfcDirection Axis { get; set; }

		public IfcStructuralCurveConnection() { }

		public IfcStructuralCurveConnection(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcBoundaryCondition AppliedCondition, IfcDirection Axis)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.AppliedCondition = AppliedCondition;
			this.Axis = Axis;
		}
	}

	public class IfcStructuralCurveMember : IfcStructuralMember
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	PredefinedType : IfcStructuralCurveMemberTypeEnum
		//9	Axis : IfcDirection

		public IfcStructuralCurveMemberTypeEnum PredefinedType { get; set; }
		public IfcDirection Axis { get; set; }

		public IfcStructuralCurveMember() { }

		public IfcStructuralCurveMember(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcStructuralCurveMemberTypeEnum PredefinedType, IfcDirection Axis)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.PredefinedType = PredefinedType;
			this.Axis = Axis;
		}
	}

	public class IfcStructuralCurveMemberVarying : IfcStructuralCurveMember
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	PredefinedType : IfcStructuralCurveMemberTypeEnum
		//9	Axis : IfcDirection

		public IfcStructuralCurveMemberVarying() { }

		public IfcStructuralCurveMemberVarying(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcStructuralCurveMemberTypeEnum PredefinedType, IfcDirection Axis)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.PredefinedType = PredefinedType;
			this.Axis = Axis;
		}
	}

	public class IfcStructuralCurveReaction : IfcStructuralReaction
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	AppliedLoad : IfcStructuralLoad
		//9	GlobalOrLocal : IfcGlobalOrLocalEnum
		//10	PredefinedType : IfcStructuralCurveActivityTypeEnum

		public IfcStructuralCurveActivityTypeEnum PredefinedType { get; set; }

		public IfcStructuralCurveReaction() { }

		public IfcStructuralCurveReaction(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcStructuralLoad AppliedLoad, IfcGlobalOrLocalEnum GlobalOrLocal, IfcStructuralCurveActivityTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.AppliedLoad = AppliedLoad;
			this.GlobalOrLocal = GlobalOrLocal;
			this.PredefinedType = PredefinedType;
		}
	}

	public abstract class IfcStructuralItem : IfcProduct, IfcStructuralActivityAssignmentSelect
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation

		public List<IfcRelConnectsStructuralActivity> AssignedStructuralActivity { get; set; }

		public IfcStructuralItem() { }

		public IfcStructuralItem(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
		}
	}

	public class IfcStructuralLinearAction : IfcStructuralCurveAction
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	AppliedLoad : IfcStructuralLoad
		//9	GlobalOrLocal : IfcGlobalOrLocalEnum
		//10	DestabilizingLoad : IfcBoolean
		//11	ProjectedOrTrue : IfcProjectedOrTrueLengthEnum
		//12	PredefinedType : IfcStructuralCurveActivityTypeEnum

		public IfcStructuralLinearAction() { }

		public IfcStructuralLinearAction(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcStructuralLoad AppliedLoad, IfcGlobalOrLocalEnum GlobalOrLocal, IfcBoolean DestabilizingLoad, IfcProjectedOrTrueLengthEnum ProjectedOrTrue, IfcStructuralCurveActivityTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.AppliedLoad = AppliedLoad;
			this.GlobalOrLocal = GlobalOrLocal;
			this.DestabilizingLoad = DestabilizingLoad;
			this.ProjectedOrTrue = ProjectedOrTrue;
			this.PredefinedType = PredefinedType;
		}
	}

	public abstract class IfcStructuralLoad : IfcBase
	{
		//1	Name : IfcLabel

		public IfcLabel Name { get; set; }

		public IfcStructuralLoad() { }

		public IfcStructuralLoad(IfcLabel Name)
		{
			this.Name = Name;
		}
	}

	public class IfcStructuralLoadCase : IfcStructuralLoadGroup
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	PredefinedType : IfcLoadGroupTypeEnum
		//7	ActionType : IfcActionTypeEnum
		//8	ActionSource : IfcActionSourceTypeEnum
		//9	Coefficient : IfcRatioMeasure
		//10	Purpose : IfcLabel
		//11	SelfWeightCoefficients : List<IfcRatioMeasure>

		public List<IfcRatioMeasure> SelfWeightCoefficients { get; set; }

		public IfcStructuralLoadCase() { }

		public IfcStructuralLoadCase(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcLoadGroupTypeEnum PredefinedType, IfcActionTypeEnum ActionType, IfcActionSourceTypeEnum ActionSource, IfcRatioMeasure Coefficient, IfcLabel Purpose, List<IfcRatioMeasure> SelfWeightCoefficients)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.PredefinedType = PredefinedType;
			this.ActionType = ActionType;
			this.ActionSource = ActionSource;
			this.Coefficient = Coefficient;
			this.Purpose = Purpose;
			this.SelfWeightCoefficients = SelfWeightCoefficients;
		}
	}

	public class IfcStructuralLoadConfiguration : IfcStructuralLoad
	{
		//1	Name : IfcLabel
		//2	Values : List<IfcStructuralLoadOrResult>
		//3	Locations : List<List<IfcLengthMeasure>>

		public List<IfcStructuralLoadOrResult> Values { get; set; }
		public List<List<IfcLengthMeasure>> Locations { get; set; }

		public IfcStructuralLoadConfiguration() { }

		public IfcStructuralLoadConfiguration(IfcLabel Name, List<IfcStructuralLoadOrResult> Values, List<List<IfcLengthMeasure>> Locations)
		{
			this.Name = Name;
			this.Values = Values;
			this.Locations = Locations;
		}
	}

	public class IfcStructuralLoadGroup : IfcGroup
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	PredefinedType : IfcLoadGroupTypeEnum
		//7	ActionType : IfcActionTypeEnum
		//8	ActionSource : IfcActionSourceTypeEnum
		//9	Coefficient : IfcRatioMeasure
		//10	Purpose : IfcLabel

		public IfcLoadGroupTypeEnum PredefinedType { get; set; }
		public IfcActionTypeEnum ActionType { get; set; }
		public IfcActionSourceTypeEnum ActionSource { get; set; }
		public IfcRatioMeasure Coefficient { get; set; }
		public IfcLabel Purpose { get; set; }
		public List<IfcStructuralResultGroup> SourceOfResultGroup { get; set; }
		public List<IfcStructuralAnalysisModel> LoadGroupFor { get; set; }

		public IfcStructuralLoadGroup() { }

		public IfcStructuralLoadGroup(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcLoadGroupTypeEnum PredefinedType, IfcActionTypeEnum ActionType, IfcActionSourceTypeEnum ActionSource, IfcRatioMeasure Coefficient, IfcLabel Purpose)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.PredefinedType = PredefinedType;
			this.ActionType = ActionType;
			this.ActionSource = ActionSource;
			this.Coefficient = Coefficient;
			this.Purpose = Purpose;
		}
	}

	public class IfcStructuralLoadLinearForce : IfcStructuralLoadStatic
	{
		//1	Name : IfcLabel
		//2	LinearForceX : IfcLinearForceMeasure
		//3	LinearForceY : IfcLinearForceMeasure
		//4	LinearForceZ : IfcLinearForceMeasure
		//5	LinearMomentX : IfcLinearMomentMeasure
		//6	LinearMomentY : IfcLinearMomentMeasure
		//7	LinearMomentZ : IfcLinearMomentMeasure

		public IfcLinearForceMeasure LinearForceX { get; set; }
		public IfcLinearForceMeasure LinearForceY { get; set; }
		public IfcLinearForceMeasure LinearForceZ { get; set; }
		public IfcLinearMomentMeasure LinearMomentX { get; set; }
		public IfcLinearMomentMeasure LinearMomentY { get; set; }
		public IfcLinearMomentMeasure LinearMomentZ { get; set; }

		public IfcStructuralLoadLinearForce() { }

		public IfcStructuralLoadLinearForce(IfcLabel Name, IfcLinearForceMeasure LinearForceX, IfcLinearForceMeasure LinearForceY, IfcLinearForceMeasure LinearForceZ, IfcLinearMomentMeasure LinearMomentX, IfcLinearMomentMeasure LinearMomentY, IfcLinearMomentMeasure LinearMomentZ)
		{
			this.Name = Name;
			this.LinearForceX = LinearForceX;
			this.LinearForceY = LinearForceY;
			this.LinearForceZ = LinearForceZ;
			this.LinearMomentX = LinearMomentX;
			this.LinearMomentY = LinearMomentY;
			this.LinearMomentZ = LinearMomentZ;
		}
	}

	public abstract class IfcStructuralLoadOrResult : IfcStructuralLoad
	{
		//1	Name : IfcLabel

		public IfcStructuralLoadOrResult() { }

		public IfcStructuralLoadOrResult(IfcLabel Name)
		{
			this.Name = Name;
		}
	}

	public class IfcStructuralLoadPlanarForce : IfcStructuralLoadStatic
	{
		//1	Name : IfcLabel
		//2	PlanarForceX : IfcPlanarForceMeasure
		//3	PlanarForceY : IfcPlanarForceMeasure
		//4	PlanarForceZ : IfcPlanarForceMeasure

		public IfcPlanarForceMeasure PlanarForceX { get; set; }
		public IfcPlanarForceMeasure PlanarForceY { get; set; }
		public IfcPlanarForceMeasure PlanarForceZ { get; set; }

		public IfcStructuralLoadPlanarForce() { }

		public IfcStructuralLoadPlanarForce(IfcLabel Name, IfcPlanarForceMeasure PlanarForceX, IfcPlanarForceMeasure PlanarForceY, IfcPlanarForceMeasure PlanarForceZ)
		{
			this.Name = Name;
			this.PlanarForceX = PlanarForceX;
			this.PlanarForceY = PlanarForceY;
			this.PlanarForceZ = PlanarForceZ;
		}
	}

	public class IfcStructuralLoadSingleDisplacement : IfcStructuralLoadStatic
	{
		//1	Name : IfcLabel
		//2	DisplacementX : IfcLengthMeasure
		//3	DisplacementY : IfcLengthMeasure
		//4	DisplacementZ : IfcLengthMeasure
		//5	RotationalDisplacementRX : IfcPlaneAngleMeasure
		//6	RotationalDisplacementRY : IfcPlaneAngleMeasure
		//7	RotationalDisplacementRZ : IfcPlaneAngleMeasure

		public IfcLengthMeasure DisplacementX { get; set; }
		public IfcLengthMeasure DisplacementY { get; set; }
		public IfcLengthMeasure DisplacementZ { get; set; }
		public IfcPlaneAngleMeasure RotationalDisplacementRX { get; set; }
		public IfcPlaneAngleMeasure RotationalDisplacementRY { get; set; }
		public IfcPlaneAngleMeasure RotationalDisplacementRZ { get; set; }

		public IfcStructuralLoadSingleDisplacement() { }

		public IfcStructuralLoadSingleDisplacement(IfcLabel Name, IfcLengthMeasure DisplacementX, IfcLengthMeasure DisplacementY, IfcLengthMeasure DisplacementZ, IfcPlaneAngleMeasure RotationalDisplacementRX, IfcPlaneAngleMeasure RotationalDisplacementRY, IfcPlaneAngleMeasure RotationalDisplacementRZ)
		{
			this.Name = Name;
			this.DisplacementX = DisplacementX;
			this.DisplacementY = DisplacementY;
			this.DisplacementZ = DisplacementZ;
			this.RotationalDisplacementRX = RotationalDisplacementRX;
			this.RotationalDisplacementRY = RotationalDisplacementRY;
			this.RotationalDisplacementRZ = RotationalDisplacementRZ;
		}
	}

	public class IfcStructuralLoadSingleDisplacementDistortion : IfcStructuralLoadSingleDisplacement
	{
		//1	Name : IfcLabel
		//2	DisplacementX : IfcLengthMeasure
		//3	DisplacementY : IfcLengthMeasure
		//4	DisplacementZ : IfcLengthMeasure
		//5	RotationalDisplacementRX : IfcPlaneAngleMeasure
		//6	RotationalDisplacementRY : IfcPlaneAngleMeasure
		//7	RotationalDisplacementRZ : IfcPlaneAngleMeasure
		//8	Distortion : IfcCurvatureMeasure

		public IfcCurvatureMeasure Distortion { get; set; }

		public IfcStructuralLoadSingleDisplacementDistortion() { }

		public IfcStructuralLoadSingleDisplacementDistortion(IfcLabel Name, IfcLengthMeasure DisplacementX, IfcLengthMeasure DisplacementY, IfcLengthMeasure DisplacementZ, IfcPlaneAngleMeasure RotationalDisplacementRX, IfcPlaneAngleMeasure RotationalDisplacementRY, IfcPlaneAngleMeasure RotationalDisplacementRZ, IfcCurvatureMeasure Distortion)
		{
			this.Name = Name;
			this.DisplacementX = DisplacementX;
			this.DisplacementY = DisplacementY;
			this.DisplacementZ = DisplacementZ;
			this.RotationalDisplacementRX = RotationalDisplacementRX;
			this.RotationalDisplacementRY = RotationalDisplacementRY;
			this.RotationalDisplacementRZ = RotationalDisplacementRZ;
			this.Distortion = Distortion;
		}
	}

	public class IfcStructuralLoadSingleForce : IfcStructuralLoadStatic
	{
		//1	Name : IfcLabel
		//2	ForceX : IfcForceMeasure
		//3	ForceY : IfcForceMeasure
		//4	ForceZ : IfcForceMeasure
		//5	MomentX : IfcTorqueMeasure
		//6	MomentY : IfcTorqueMeasure
		//7	MomentZ : IfcTorqueMeasure

		public IfcForceMeasure ForceX { get; set; }
		public IfcForceMeasure ForceY { get; set; }
		public IfcForceMeasure ForceZ { get; set; }
		public IfcTorqueMeasure MomentX { get; set; }
		public IfcTorqueMeasure MomentY { get; set; }
		public IfcTorqueMeasure MomentZ { get; set; }

		public IfcStructuralLoadSingleForce() { }

		public IfcStructuralLoadSingleForce(IfcLabel Name, IfcForceMeasure ForceX, IfcForceMeasure ForceY, IfcForceMeasure ForceZ, IfcTorqueMeasure MomentX, IfcTorqueMeasure MomentY, IfcTorqueMeasure MomentZ)
		{
			this.Name = Name;
			this.ForceX = ForceX;
			this.ForceY = ForceY;
			this.ForceZ = ForceZ;
			this.MomentX = MomentX;
			this.MomentY = MomentY;
			this.MomentZ = MomentZ;
		}
	}

	public class IfcStructuralLoadSingleForceWarping : IfcStructuralLoadSingleForce
	{
		//1	Name : IfcLabel
		//2	ForceX : IfcForceMeasure
		//3	ForceY : IfcForceMeasure
		//4	ForceZ : IfcForceMeasure
		//5	MomentX : IfcTorqueMeasure
		//6	MomentY : IfcTorqueMeasure
		//7	MomentZ : IfcTorqueMeasure
		//8	WarpingMoment : IfcWarpingMomentMeasure

		public IfcWarpingMomentMeasure WarpingMoment { get; set; }

		public IfcStructuralLoadSingleForceWarping() { }

		public IfcStructuralLoadSingleForceWarping(IfcLabel Name, IfcForceMeasure ForceX, IfcForceMeasure ForceY, IfcForceMeasure ForceZ, IfcTorqueMeasure MomentX, IfcTorqueMeasure MomentY, IfcTorqueMeasure MomentZ, IfcWarpingMomentMeasure WarpingMoment)
		{
			this.Name = Name;
			this.ForceX = ForceX;
			this.ForceY = ForceY;
			this.ForceZ = ForceZ;
			this.MomentX = MomentX;
			this.MomentY = MomentY;
			this.MomentZ = MomentZ;
			this.WarpingMoment = WarpingMoment;
		}
	}

	public abstract class IfcStructuralLoadStatic : IfcStructuralLoadOrResult
	{
		//1	Name : IfcLabel

		public IfcStructuralLoadStatic() { }

		public IfcStructuralLoadStatic(IfcLabel Name)
		{
			this.Name = Name;
		}
	}

	public class IfcStructuralLoadTemperature : IfcStructuralLoadStatic
	{
		//1	Name : IfcLabel
		//2	DeltaTConstant : IfcThermodynamicTemperatureMeasure
		//3	DeltaTY : IfcThermodynamicTemperatureMeasure
		//4	DeltaTZ : IfcThermodynamicTemperatureMeasure

		public IfcThermodynamicTemperatureMeasure DeltaTConstant { get; set; }
		public IfcThermodynamicTemperatureMeasure DeltaTY { get; set; }
		public IfcThermodynamicTemperatureMeasure DeltaTZ { get; set; }

		public IfcStructuralLoadTemperature() { }

		public IfcStructuralLoadTemperature(IfcLabel Name, IfcThermodynamicTemperatureMeasure DeltaTConstant, IfcThermodynamicTemperatureMeasure DeltaTY, IfcThermodynamicTemperatureMeasure DeltaTZ)
		{
			this.Name = Name;
			this.DeltaTConstant = DeltaTConstant;
			this.DeltaTY = DeltaTY;
			this.DeltaTZ = DeltaTZ;
		}
	}

	public abstract class IfcStructuralMember : IfcStructuralItem
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation

		public List<IfcRelConnectsStructuralMember> ConnectedBy { get; set; }

		public IfcStructuralMember() { }

		public IfcStructuralMember(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
		}
	}

	public class IfcStructuralPlanarAction : IfcStructuralSurfaceAction
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	AppliedLoad : IfcStructuralLoad
		//9	GlobalOrLocal : IfcGlobalOrLocalEnum
		//10	DestabilizingLoad : IfcBoolean
		//11	ProjectedOrTrue : IfcProjectedOrTrueLengthEnum
		//12	PredefinedType : IfcStructuralSurfaceActivityTypeEnum

		public IfcStructuralPlanarAction() { }

		public IfcStructuralPlanarAction(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcStructuralLoad AppliedLoad, IfcGlobalOrLocalEnum GlobalOrLocal, IfcBoolean DestabilizingLoad, IfcProjectedOrTrueLengthEnum ProjectedOrTrue, IfcStructuralSurfaceActivityTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.AppliedLoad = AppliedLoad;
			this.GlobalOrLocal = GlobalOrLocal;
			this.DestabilizingLoad = DestabilizingLoad;
			this.ProjectedOrTrue = ProjectedOrTrue;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcStructuralPointAction : IfcStructuralAction
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	AppliedLoad : IfcStructuralLoad
		//9	GlobalOrLocal : IfcGlobalOrLocalEnum
		//10	DestabilizingLoad : IfcBoolean

		public IfcStructuralPointAction() { }

		public IfcStructuralPointAction(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcStructuralLoad AppliedLoad, IfcGlobalOrLocalEnum GlobalOrLocal, IfcBoolean DestabilizingLoad)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.AppliedLoad = AppliedLoad;
			this.GlobalOrLocal = GlobalOrLocal;
			this.DestabilizingLoad = DestabilizingLoad;
		}
	}

	public class IfcStructuralPointConnection : IfcStructuralConnection
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	AppliedCondition : IfcBoundaryCondition
		//9	ConditionCoordinateSystem : IfcAxis2Placement3D

		public IfcAxis2Placement3D ConditionCoordinateSystem { get; set; }

		public IfcStructuralPointConnection() { }

		public IfcStructuralPointConnection(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcBoundaryCondition AppliedCondition, IfcAxis2Placement3D ConditionCoordinateSystem)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.AppliedCondition = AppliedCondition;
			this.ConditionCoordinateSystem = ConditionCoordinateSystem;
		}
	}

	public class IfcStructuralPointReaction : IfcStructuralReaction
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	AppliedLoad : IfcStructuralLoad
		//9	GlobalOrLocal : IfcGlobalOrLocalEnum

		public IfcStructuralPointReaction() { }

		public IfcStructuralPointReaction(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcStructuralLoad AppliedLoad, IfcGlobalOrLocalEnum GlobalOrLocal)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.AppliedLoad = AppliedLoad;
			this.GlobalOrLocal = GlobalOrLocal;
		}
	}

	public abstract class IfcStructuralReaction : IfcStructuralActivity
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	AppliedLoad : IfcStructuralLoad
		//9	GlobalOrLocal : IfcGlobalOrLocalEnum

		public IfcStructuralReaction() { }

		public IfcStructuralReaction(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcStructuralLoad AppliedLoad, IfcGlobalOrLocalEnum GlobalOrLocal)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.AppliedLoad = AppliedLoad;
			this.GlobalOrLocal = GlobalOrLocal;
		}
	}

	public class IfcStructuralResultGroup : IfcGroup
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	TheoryType : IfcAnalysisTheoryTypeEnum
		//7	ResultForLoadGroup : IfcStructuralLoadGroup
		//8	IsLinear : IfcBoolean

		public IfcAnalysisTheoryTypeEnum TheoryType { get; set; }
		public IfcStructuralLoadGroup ResultForLoadGroup { get; set; }
		public IfcBoolean IsLinear { get; set; }
		public List<IfcStructuralAnalysisModel> ResultGroupFor { get; set; }

		public IfcStructuralResultGroup() { }

		public IfcStructuralResultGroup(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcAnalysisTheoryTypeEnum TheoryType, IfcStructuralLoadGroup ResultForLoadGroup, IfcBoolean IsLinear)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.TheoryType = TheoryType;
			this.ResultForLoadGroup = ResultForLoadGroup;
			this.IsLinear = IsLinear;
		}
	}

	public class IfcStructuralSurfaceAction : IfcStructuralAction
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	AppliedLoad : IfcStructuralLoad
		//9	GlobalOrLocal : IfcGlobalOrLocalEnum
		//10	DestabilizingLoad : IfcBoolean
		//11	ProjectedOrTrue : IfcProjectedOrTrueLengthEnum
		//12	PredefinedType : IfcStructuralSurfaceActivityTypeEnum

		public IfcProjectedOrTrueLengthEnum ProjectedOrTrue { get; set; }
		public IfcStructuralSurfaceActivityTypeEnum PredefinedType { get; set; }

		public IfcStructuralSurfaceAction() { }

		public IfcStructuralSurfaceAction(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcStructuralLoad AppliedLoad, IfcGlobalOrLocalEnum GlobalOrLocal, IfcBoolean DestabilizingLoad, IfcProjectedOrTrueLengthEnum ProjectedOrTrue, IfcStructuralSurfaceActivityTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.AppliedLoad = AppliedLoad;
			this.GlobalOrLocal = GlobalOrLocal;
			this.DestabilizingLoad = DestabilizingLoad;
			this.ProjectedOrTrue = ProjectedOrTrue;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcStructuralSurfaceConnection : IfcStructuralConnection
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	AppliedCondition : IfcBoundaryCondition

		public IfcStructuralSurfaceConnection() { }

		public IfcStructuralSurfaceConnection(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcBoundaryCondition AppliedCondition)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.AppliedCondition = AppliedCondition;
		}
	}

	public class IfcStructuralSurfaceMember : IfcStructuralMember
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	PredefinedType : IfcStructuralSurfaceMemberTypeEnum
		//9	Thickness : IfcPositiveLengthMeasure

		public IfcStructuralSurfaceMemberTypeEnum PredefinedType { get; set; }
		public IfcPositiveLengthMeasure Thickness { get; set; }

		public IfcStructuralSurfaceMember() { }

		public IfcStructuralSurfaceMember(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcStructuralSurfaceMemberTypeEnum PredefinedType, IfcPositiveLengthMeasure Thickness)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.PredefinedType = PredefinedType;
			this.Thickness = Thickness;
		}
	}

	public class IfcStructuralSurfaceMemberVarying : IfcStructuralSurfaceMember
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	PredefinedType : IfcStructuralSurfaceMemberTypeEnum
		//9	Thickness : IfcPositiveLengthMeasure

		public IfcStructuralSurfaceMemberVarying() { }

		public IfcStructuralSurfaceMemberVarying(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcStructuralSurfaceMemberTypeEnum PredefinedType, IfcPositiveLengthMeasure Thickness)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.PredefinedType = PredefinedType;
			this.Thickness = Thickness;
		}
	}

	public class IfcStructuralSurfaceReaction : IfcStructuralReaction
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	AppliedLoad : IfcStructuralLoad
		//9	GlobalOrLocal : IfcGlobalOrLocalEnum
		//10	PredefinedType : IfcStructuralSurfaceActivityTypeEnum

		public IfcStructuralSurfaceActivityTypeEnum PredefinedType { get; set; }

		public IfcStructuralSurfaceReaction() { }

		public IfcStructuralSurfaceReaction(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcStructuralLoad AppliedLoad, IfcGlobalOrLocalEnum GlobalOrLocal, IfcStructuralSurfaceActivityTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.AppliedLoad = AppliedLoad;
			this.GlobalOrLocal = GlobalOrLocal;
			this.PredefinedType = PredefinedType;
		}
	}

	public abstract class IfcStyleModel : IfcRepresentation
	{
		//1	ContextOfItems : IfcRepresentationContext
		//2	RepresentationIdentifier : IfcLabel
		//3	RepresentationType : IfcLabel
		//4	Items : List<IfcRepresentationItem>

		public IfcStyleModel() { }

		public IfcStyleModel(IfcRepresentationContext ContextOfItems, IfcLabel RepresentationIdentifier, IfcLabel RepresentationType, List<IfcRepresentationItem> Items)
		{
			this.ContextOfItems = ContextOfItems;
			this.RepresentationIdentifier = RepresentationIdentifier;
			this.RepresentationType = RepresentationType;
			this.Items = Items;
		}
	}

	public class IfcStyledItem : IfcRepresentationItem
	{
		//1	Item : IfcRepresentationItem
		//2	Styles : List<IfcStyleAssignmentSelect>
		//3	Name : IfcLabel

		public IfcRepresentationItem Item { get; set; }
		public List<IfcStyleAssignmentSelect> Styles { get; set; }
		public IfcLabel Name { get; set; }

		public IfcStyledItem() { }

		public IfcStyledItem(IfcRepresentationItem Item, List<IfcStyleAssignmentSelect> Styles, IfcLabel Name)
		{
			this.Item = Item;
			this.Styles = Styles;
			this.Name = Name;
		}
	}

	public class IfcStyledRepresentation : IfcStyleModel
	{
		//1	ContextOfItems : IfcRepresentationContext
		//2	RepresentationIdentifier : IfcLabel
		//3	RepresentationType : IfcLabel
		//4	Items : List<IfcRepresentationItem>

		public IfcStyledRepresentation() { }

		public IfcStyledRepresentation(IfcRepresentationContext ContextOfItems, IfcLabel RepresentationIdentifier, IfcLabel RepresentationType, List<IfcRepresentationItem> Items)
		{
			this.ContextOfItems = ContextOfItems;
			this.RepresentationIdentifier = RepresentationIdentifier;
			this.RepresentationType = RepresentationType;
			this.Items = Items;
		}
	}

	public class IfcSubContractResource : IfcConstructionResource
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	Identification : IfcIdentifier
		//7	LongDescription : IfcText
		//8	Usage : IfcResourceTime
		//9	BaseCosts : List<IfcAppliedValue>
		//10	BaseQuantity : IfcPhysicalQuantity
		//11	PredefinedType : IfcSubContractResourceTypeEnum

		public IfcSubContractResourceTypeEnum PredefinedType { get; set; }

		public IfcSubContractResource() { }

		public IfcSubContractResource(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcIdentifier Identification, IfcText LongDescription, IfcResourceTime Usage, List<IfcAppliedValue> BaseCosts, IfcPhysicalQuantity BaseQuantity, IfcSubContractResourceTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.Identification = Identification;
			this.LongDescription = LongDescription;
			this.Usage = Usage;
			this.BaseCosts = BaseCosts;
			this.BaseQuantity = BaseQuantity;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcSubContractResourceType : IfcConstructionResourceType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	Identification : IfcIdentifier
		//8	LongDescription : IfcText
		//9	ResourceType : IfcLabel
		//10	BaseCosts : List<IfcAppliedValue>
		//11	BaseQuantity : IfcPhysicalQuantity
		//12	PredefinedType : IfcSubContractResourceTypeEnum

		public IfcSubContractResourceTypeEnum PredefinedType { get; set; }

		public IfcSubContractResourceType() { }

		public IfcSubContractResourceType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcIdentifier Identification, IfcText LongDescription, IfcLabel ResourceType, List<IfcAppliedValue> BaseCosts, IfcPhysicalQuantity BaseQuantity, IfcSubContractResourceTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.Identification = Identification;
			this.LongDescription = LongDescription;
			this.ResourceType = ResourceType;
			this.BaseCosts = BaseCosts;
			this.BaseQuantity = BaseQuantity;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcSubedge : IfcEdge
	{
		//1	EdgeStart : IfcVertex
		//2	EdgeEnd : IfcVertex
		//3	ParentEdge : IfcEdge

		public IfcEdge ParentEdge { get; set; }

		public IfcSubedge() { }

		public IfcSubedge(IfcVertex EdgeStart, IfcVertex EdgeEnd, IfcEdge ParentEdge)
		{
			this.EdgeStart = EdgeStart;
			this.EdgeEnd = EdgeEnd;
			this.ParentEdge = ParentEdge;
		}
	}

	public abstract class IfcSurface : IfcGeometricRepresentationItem, IfcGeometricSetSelect, IfcSurfaceOrFaceSurface
	{
		public IfcDimensionCount Dim { get; set; }

		public IfcSurface() { }
	}

	public class IfcSurfaceCurve : IfcCurve, IfcCurveOnSurface
	{
		//1	Curve3D : IfcCurve
		//2	AssociatedGeometry : List<IfcPcurve>
		//3	MasterRepresentation : IfcPreferredSurfaceCurveRepresentation

		public IfcCurve Curve3D { get; set; }
		public List<IfcPcurve> AssociatedGeometry { get; set; }
		public IfcPreferredSurfaceCurveRepresentation MasterRepresentation { get; set; }
		public List<IfcSurface> BasisSurface { get; set; }

		public IfcSurfaceCurve() { }

		public IfcSurfaceCurve(IfcCurve Curve3D, List<IfcPcurve> AssociatedGeometry, IfcPreferredSurfaceCurveRepresentation MasterRepresentation)
		{
			this.Curve3D = Curve3D;
			this.AssociatedGeometry = AssociatedGeometry;
			this.MasterRepresentation = MasterRepresentation;
		}
	}

	public class IfcSurfaceCurveSweptAreaSolid : IfcSweptAreaSolid
	{
		//1	SweptArea : IfcProfileDef
		//2	Position : IfcAxis2Placement3D
		//3	Directrix : IfcCurve
		//4	StartParam : IfcParameterValue
		//5	EndParam : IfcParameterValue
		//6	ReferenceSurface : IfcSurface

		public IfcCurve Directrix { get; set; }
		public IfcParameterValue StartParam { get; set; }
		public IfcParameterValue EndParam { get; set; }
		public IfcSurface ReferenceSurface { get; set; }

		public IfcSurfaceCurveSweptAreaSolid() { }

		public IfcSurfaceCurveSweptAreaSolid(IfcProfileDef SweptArea, IfcAxis2Placement3D Position, IfcCurve Directrix, IfcParameterValue StartParam, IfcParameterValue EndParam, IfcSurface ReferenceSurface)
		{
			this.SweptArea = SweptArea;
			this.Position = Position;
			this.Directrix = Directrix;
			this.StartParam = StartParam;
			this.EndParam = EndParam;
			this.ReferenceSurface = ReferenceSurface;
		}
	}

	public class IfcSurfaceFeature : IfcFeatureElement
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	PredefinedType : IfcSurfaceFeatureTypeEnum

		public IfcSurfaceFeatureTypeEnum PredefinedType { get; set; }

		public IfcSurfaceFeature() { }

		public IfcSurfaceFeature(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcSurfaceFeatureTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcSurfaceOfLinearExtrusion : IfcSweptSurface
	{
		//1	SweptCurve : IfcProfileDef
		//2	Position : IfcAxis2Placement3D
		//3	ExtrudedDirection : IfcDirection
		//4	Depth : IfcLengthMeasure

		public IfcDirection ExtrudedDirection { get; set; }
		public IfcLengthMeasure Depth { get; set; }
		public IfcVector ExtrusionAxis { get; set; }

		public IfcSurfaceOfLinearExtrusion() { }

		public IfcSurfaceOfLinearExtrusion(IfcProfileDef SweptCurve, IfcAxis2Placement3D Position, IfcDirection ExtrudedDirection, IfcLengthMeasure Depth)
		{
			this.SweptCurve = SweptCurve;
			this.Position = Position;
			this.ExtrudedDirection = ExtrudedDirection;
			this.Depth = Depth;
		}
	}

	public class IfcSurfaceOfRevolution : IfcSweptSurface
	{
		//1	SweptCurve : IfcProfileDef
		//2	Position : IfcAxis2Placement3D
		//3	AxisPosition : IfcAxis1Placement

		public IfcAxis1Placement AxisPosition { get; set; }
		public IfcLine AxisLine { get; set; }

		public IfcSurfaceOfRevolution() { }

		public IfcSurfaceOfRevolution(IfcProfileDef SweptCurve, IfcAxis2Placement3D Position, IfcAxis1Placement AxisPosition)
		{
			this.SweptCurve = SweptCurve;
			this.Position = Position;
			this.AxisPosition = AxisPosition;
		}
	}

	public class IfcSurfaceReinforcementArea : IfcStructuralLoadOrResult
	{
		//1	Name : IfcLabel
		//2	SurfaceReinforcement1 : List<IfcLengthMeasure>
		//3	SurfaceReinforcement2 : List<IfcLengthMeasure>
		//4	ShearReinforcement : IfcRatioMeasure

		public List<IfcLengthMeasure> SurfaceReinforcement1 { get; set; }
		public List<IfcLengthMeasure> SurfaceReinforcement2 { get; set; }
		public IfcRatioMeasure ShearReinforcement { get; set; }

		public IfcSurfaceReinforcementArea() { }

		public IfcSurfaceReinforcementArea(IfcLabel Name, List<IfcLengthMeasure> SurfaceReinforcement1, List<IfcLengthMeasure> SurfaceReinforcement2, IfcRatioMeasure ShearReinforcement)
		{
			this.Name = Name;
			this.SurfaceReinforcement1 = SurfaceReinforcement1;
			this.SurfaceReinforcement2 = SurfaceReinforcement2;
			this.ShearReinforcement = ShearReinforcement;
		}
	}

	public class IfcSurfaceStyle : IfcPresentationStyle, IfcPresentationStyleSelect
	{
		//1	Name : IfcLabel
		//2	Side : IfcSurfaceSide
		//3	Styles : List<IfcSurfaceStyleElementSelect>

		public IfcSurfaceSide Side { get; set; }
		public List<IfcSurfaceStyleElementSelect> Styles { get; set; }

		public IfcSurfaceStyle() { }

		public IfcSurfaceStyle(IfcLabel Name, IfcSurfaceSide Side, List<IfcSurfaceStyleElementSelect> Styles)
		{
			this.Name = Name;
			this.Side = Side;
			this.Styles = Styles;
		}
	}

	public class IfcSurfaceStyleLighting : IfcPresentationItem, IfcSurfaceStyleElementSelect
	{
		//1	DiffuseTransmissionColour : IfcColourRgb
		//2	DiffuseReflectionColour : IfcColourRgb
		//3	TransmissionColour : IfcColourRgb
		//4	ReflectanceColour : IfcColourRgb

		public IfcColourRgb DiffuseTransmissionColour { get; set; }
		public IfcColourRgb DiffuseReflectionColour { get; set; }
		public IfcColourRgb TransmissionColour { get; set; }
		public IfcColourRgb ReflectanceColour { get; set; }

		public IfcSurfaceStyleLighting() { }

		public IfcSurfaceStyleLighting(IfcColourRgb DiffuseTransmissionColour, IfcColourRgb DiffuseReflectionColour, IfcColourRgb TransmissionColour, IfcColourRgb ReflectanceColour)
		{
			this.DiffuseTransmissionColour = DiffuseTransmissionColour;
			this.DiffuseReflectionColour = DiffuseReflectionColour;
			this.TransmissionColour = TransmissionColour;
			this.ReflectanceColour = ReflectanceColour;
		}
	}

	public class IfcSurfaceStyleRefraction : IfcPresentationItem, IfcSurfaceStyleElementSelect
	{
		//1	RefractionIndex : IfcReal
		//2	DispersionFactor : IfcReal

		public IfcReal RefractionIndex { get; set; }
		public IfcReal DispersionFactor { get; set; }

		public IfcSurfaceStyleRefraction() { }

		public IfcSurfaceStyleRefraction(IfcReal RefractionIndex, IfcReal DispersionFactor)
		{
			this.RefractionIndex = RefractionIndex;
			this.DispersionFactor = DispersionFactor;
		}
	}

	public class IfcSurfaceStyleRendering : IfcSurfaceStyleShading
	{
		//1	SurfaceColour : IfcColourRgb
		//2	Transparency : IfcNormalisedRatioMeasure
		//3	DiffuseColour : IfcColourOrFactor
		//4	TransmissionColour : IfcColourOrFactor
		//5	DiffuseTransmissionColour : IfcColourOrFactor
		//6	ReflectionColour : IfcColourOrFactor
		//7	SpecularColour : IfcColourOrFactor
		//8	SpecularHighlight : IfcSpecularHighlightSelect
		//9	ReflectanceMethod : IfcReflectanceMethodEnum

		public IfcColourOrFactor DiffuseColour { get; set; }
		public IfcColourOrFactor TransmissionColour { get; set; }
		public IfcColourOrFactor DiffuseTransmissionColour { get; set; }
		public IfcColourOrFactor ReflectionColour { get; set; }
		public IfcColourOrFactor SpecularColour { get; set; }
		public IfcSpecularHighlightSelect SpecularHighlight { get; set; }
		public IfcReflectanceMethodEnum ReflectanceMethod { get; set; }

		public IfcSurfaceStyleRendering() { }

		public IfcSurfaceStyleRendering(IfcColourRgb SurfaceColour, IfcNormalisedRatioMeasure Transparency, IfcColourOrFactor DiffuseColour, IfcColourOrFactor TransmissionColour, IfcColourOrFactor DiffuseTransmissionColour, IfcColourOrFactor ReflectionColour, IfcColourOrFactor SpecularColour, IfcSpecularHighlightSelect SpecularHighlight, IfcReflectanceMethodEnum ReflectanceMethod)
		{
			this.SurfaceColour = SurfaceColour;
			this.Transparency = Transparency;
			this.DiffuseColour = DiffuseColour;
			this.TransmissionColour = TransmissionColour;
			this.DiffuseTransmissionColour = DiffuseTransmissionColour;
			this.ReflectionColour = ReflectionColour;
			this.SpecularColour = SpecularColour;
			this.SpecularHighlight = SpecularHighlight;
			this.ReflectanceMethod = ReflectanceMethod;
		}
	}

	public class IfcSurfaceStyleShading : IfcPresentationItem, IfcSurfaceStyleElementSelect
	{
		//1	SurfaceColour : IfcColourRgb
		//2	Transparency : IfcNormalisedRatioMeasure

		public IfcColourRgb SurfaceColour { get; set; }
		public IfcNormalisedRatioMeasure Transparency { get; set; }

		public IfcSurfaceStyleShading() { }

		public IfcSurfaceStyleShading(IfcColourRgb SurfaceColour, IfcNormalisedRatioMeasure Transparency)
		{
			this.SurfaceColour = SurfaceColour;
			this.Transparency = Transparency;
		}
	}

	public class IfcSurfaceStyleWithTextures : IfcPresentationItem, IfcSurfaceStyleElementSelect
	{
		//1	Textures : List<IfcSurfaceTexture>

		public List<IfcSurfaceTexture> Textures { get; set; }

		public IfcSurfaceStyleWithTextures() { }

		public IfcSurfaceStyleWithTextures(List<IfcSurfaceTexture> Textures)
		{
			this.Textures = Textures;
		}
	}

	public abstract class IfcSurfaceTexture : IfcPresentationItem
	{
		//1	RepeatS : IfcBoolean
		//2	RepeatT : IfcBoolean
		//3	Mode : IfcIdentifier
		//4	TextureTransform : IfcCartesianTransformationOperator2D
		//5	Parameter : List<IfcIdentifier>

		public IfcBoolean RepeatS { get; set; }
		public IfcBoolean RepeatT { get; set; }
		public IfcIdentifier Mode { get; set; }
		public IfcCartesianTransformationOperator2D TextureTransform { get; set; }
		public List<IfcIdentifier> Parameter { get; set; }
		public List<IfcTextureCoordinate> IsMappedBy { get; set; }
		public List<IfcSurfaceStyleWithTextures> UsedInStyles { get; set; }

		public IfcSurfaceTexture() { }

		public IfcSurfaceTexture(IfcBoolean RepeatS, IfcBoolean RepeatT, IfcIdentifier Mode, IfcCartesianTransformationOperator2D TextureTransform, List<IfcIdentifier> Parameter)
		{
			this.RepeatS = RepeatS;
			this.RepeatT = RepeatT;
			this.Mode = Mode;
			this.TextureTransform = TextureTransform;
			this.Parameter = Parameter;
		}
	}

	public abstract class IfcSweptAreaSolid : IfcSolidModel
	{
		//1	SweptArea : IfcProfileDef
		//2	Position : IfcAxis2Placement3D

		public IfcProfileDef SweptArea { get; set; }
		public IfcAxis2Placement3D Position { get; set; }

		public IfcSweptAreaSolid() { }

		public IfcSweptAreaSolid(IfcProfileDef SweptArea, IfcAxis2Placement3D Position)
		{
			this.SweptArea = SweptArea;
			this.Position = Position;
		}
	}

	public class IfcSweptDiskSolid : IfcSolidModel
	{
		//1	Directrix : IfcCurve
		//2	Radius : IfcPositiveLengthMeasure
		//3	InnerRadius : IfcPositiveLengthMeasure
		//4	StartParam : IfcParameterValue
		//5	EndParam : IfcParameterValue

		public IfcCurve Directrix { get; set; }
		public IfcPositiveLengthMeasure Radius { get; set; }
		public IfcPositiveLengthMeasure InnerRadius { get; set; }
		public IfcParameterValue StartParam { get; set; }
		public IfcParameterValue EndParam { get; set; }

		public IfcSweptDiskSolid() { }

		public IfcSweptDiskSolid(IfcCurve Directrix, IfcPositiveLengthMeasure Radius, IfcPositiveLengthMeasure InnerRadius, IfcParameterValue StartParam, IfcParameterValue EndParam)
		{
			this.Directrix = Directrix;
			this.Radius = Radius;
			this.InnerRadius = InnerRadius;
			this.StartParam = StartParam;
			this.EndParam = EndParam;
		}
	}

	public class IfcSweptDiskSolidPolygonal : IfcSweptDiskSolid
	{
		//1	Directrix : IfcCurve
		//2	Radius : IfcPositiveLengthMeasure
		//3	InnerRadius : IfcPositiveLengthMeasure
		//4	StartParam : IfcParameterValue
		//5	EndParam : IfcParameterValue
		//6	FilletRadius : IfcPositiveLengthMeasure

		public IfcPositiveLengthMeasure FilletRadius { get; set; }

		public IfcSweptDiskSolidPolygonal() { }

		public IfcSweptDiskSolidPolygonal(IfcCurve Directrix, IfcPositiveLengthMeasure Radius, IfcPositiveLengthMeasure InnerRadius, IfcParameterValue StartParam, IfcParameterValue EndParam, IfcPositiveLengthMeasure FilletRadius)
		{
			this.Directrix = Directrix;
			this.Radius = Radius;
			this.InnerRadius = InnerRadius;
			this.StartParam = StartParam;
			this.EndParam = EndParam;
			this.FilletRadius = FilletRadius;
		}
	}

	public abstract class IfcSweptSurface : IfcSurface
	{
		//1	SweptCurve : IfcProfileDef
		//2	Position : IfcAxis2Placement3D

		public IfcProfileDef SweptCurve { get; set; }
		public IfcAxis2Placement3D Position { get; set; }

		public IfcSweptSurface() { }

		public IfcSweptSurface(IfcProfileDef SweptCurve, IfcAxis2Placement3D Position)
		{
			this.SweptCurve = SweptCurve;
			this.Position = Position;
		}
	}

	public class IfcSwitchingDevice : IfcFlowController
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	PredefinedType : IfcSwitchingDeviceTypeEnum

		public IfcSwitchingDeviceTypeEnum PredefinedType { get; set; }

		public IfcSwitchingDevice() { }

		public IfcSwitchingDevice(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcSwitchingDeviceTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcSwitchingDeviceType : IfcFlowControllerType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel
		//10	PredefinedType : IfcSwitchingDeviceTypeEnum

		public IfcSwitchingDeviceTypeEnum PredefinedType { get; set; }

		public IfcSwitchingDeviceType() { }

		public IfcSwitchingDeviceType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType, IfcSwitchingDeviceTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcSystem : IfcGroup
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel

		public List<IfcRelServicesBuildings> ServicesBuildings { get; set; }

		public IfcSystem() { }

		public IfcSystem(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
		}
	}

	public class IfcSystemFurnitureElement : IfcFurnishingElement
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	PredefinedType : IfcSystemFurnitureElementTypeEnum

		public IfcSystemFurnitureElementTypeEnum PredefinedType { get; set; }

		public IfcSystemFurnitureElement() { }

		public IfcSystemFurnitureElement(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcSystemFurnitureElementTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcSystemFurnitureElementType : IfcFurnishingElementType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel
		//10	PredefinedType : IfcSystemFurnitureElementTypeEnum

		public IfcSystemFurnitureElementTypeEnum PredefinedType { get; set; }

		public IfcSystemFurnitureElementType() { }

		public IfcSystemFurnitureElementType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType, IfcSystemFurnitureElementTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcTShapeProfileDef : IfcParameterizedProfileDef
	{
		//1	ProfileType : IfcProfileTypeEnum
		//2	ProfileName : IfcLabel
		//3	Position : IfcAxis2Placement2D
		//4	Depth : IfcPositiveLengthMeasure
		//5	FlangeWidth : IfcPositiveLengthMeasure
		//6	WebThickness : IfcPositiveLengthMeasure
		//7	FlangeThickness : IfcPositiveLengthMeasure
		//8	FilletRadius : IfcNonNegativeLengthMeasure
		//9	FlangeEdgeRadius : IfcNonNegativeLengthMeasure
		//10	WebEdgeRadius : IfcNonNegativeLengthMeasure
		//11	WebSlope : IfcPlaneAngleMeasure
		//12	FlangeSlope : IfcPlaneAngleMeasure

		public IfcPositiveLengthMeasure Depth { get; set; }
		public IfcPositiveLengthMeasure FlangeWidth { get; set; }
		public IfcPositiveLengthMeasure WebThickness { get; set; }
		public IfcPositiveLengthMeasure FlangeThickness { get; set; }
		public IfcNonNegativeLengthMeasure FilletRadius { get; set; }
		public IfcNonNegativeLengthMeasure FlangeEdgeRadius { get; set; }
		public IfcNonNegativeLengthMeasure WebEdgeRadius { get; set; }
		public IfcPlaneAngleMeasure WebSlope { get; set; }
		public IfcPlaneAngleMeasure FlangeSlope { get; set; }

		public IfcTShapeProfileDef() { }

		public IfcTShapeProfileDef(IfcProfileTypeEnum ProfileType, IfcLabel ProfileName, IfcAxis2Placement2D Position, IfcPositiveLengthMeasure Depth, IfcPositiveLengthMeasure FlangeWidth, IfcPositiveLengthMeasure WebThickness, IfcPositiveLengthMeasure FlangeThickness, IfcNonNegativeLengthMeasure FilletRadius, IfcNonNegativeLengthMeasure FlangeEdgeRadius, IfcNonNegativeLengthMeasure WebEdgeRadius, IfcPlaneAngleMeasure WebSlope, IfcPlaneAngleMeasure FlangeSlope)
		{
			this.ProfileType = ProfileType;
			this.ProfileName = ProfileName;
			this.Position = Position;
			this.Depth = Depth;
			this.FlangeWidth = FlangeWidth;
			this.WebThickness = WebThickness;
			this.FlangeThickness = FlangeThickness;
			this.FilletRadius = FilletRadius;
			this.FlangeEdgeRadius = FlangeEdgeRadius;
			this.WebEdgeRadius = WebEdgeRadius;
			this.WebSlope = WebSlope;
			this.FlangeSlope = FlangeSlope;
		}
	}

	public class IfcTable : IfcBase
	{
		//1	Name : IfcLabel
		//2	Rows : List<IfcTableRow>
		//3	Columns : List<IfcTableColumn>

		public IfcLabel Name { get; set; }
		public List<IfcTableRow> Rows { get; set; }
		public List<IfcTableColumn> Columns { get; set; }
		public IfcInteger NumberOfCellsInRow { get; set; }
		public IfcInteger NumberOfHeadings { get; set; }
		public IfcInteger NumberOfDataRows { get; set; }

		public IfcTable() { }

		public IfcTable(IfcLabel Name, List<IfcTableRow> Rows, List<IfcTableColumn> Columns)
		{
			this.Name = Name;
			this.Rows = Rows;
			this.Columns = Columns;
		}
	}

	public class IfcTableColumn : IfcBase
	{
		//1	Identifier : IfcIdentifier
		//2	Name : IfcLabel
		//3	Description : IfcText
		//4	Unit : IfcUnit
		//5	ReferencePath : IfcReference

		public IfcIdentifier Identifier { get; set; }
		public IfcLabel Name { get; set; }
		public IfcText Description { get; set; }
		public IfcUnit Unit { get; set; }
		public IfcReference ReferencePath { get; set; }

		public IfcTableColumn() { }

		public IfcTableColumn(IfcIdentifier Identifier, IfcLabel Name, IfcText Description, IfcUnit Unit, IfcReference ReferencePath)
		{
			this.Identifier = Identifier;
			this.Name = Name;
			this.Description = Description;
			this.Unit = Unit;
			this.ReferencePath = ReferencePath;
		}
	}

	public class IfcTableRow : IfcBase
	{
		//1	RowCells : List<IfcValue>
		//2	IsHeading : IfcBoolean

		public List<IfcValue> RowCells { get; set; }
		public IfcBoolean IsHeading { get; set; }

		public IfcTableRow() { }

		public IfcTableRow(List<IfcValue> RowCells, IfcBoolean IsHeading)
		{
			this.RowCells = RowCells;
			this.IsHeading = IsHeading;
		}
	}

	public class IfcTank : IfcFlowStorageDevice
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	PredefinedType : IfcTankTypeEnum

		public IfcTankTypeEnum PredefinedType { get; set; }

		public IfcTank() { }

		public IfcTank(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcTankTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcTankType : IfcFlowStorageDeviceType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel
		//10	PredefinedType : IfcTankTypeEnum

		public IfcTankTypeEnum PredefinedType { get; set; }

		public IfcTankType() { }

		public IfcTankType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType, IfcTankTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcTask : IfcProcess
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	Identification : IfcIdentifier
		//7	LongDescription : IfcText
		//8	Status : IfcLabel
		//9	WorkMethod : IfcLabel
		//10	IsMilestone : IfcBoolean
		//11	Priority : IfcInteger
		//12	TaskTime : IfcTaskTime
		//13	PredefinedType : IfcTaskTypeEnum

		public IfcLabel Status { get; set; }
		public IfcLabel WorkMethod { get; set; }
		public IfcBoolean IsMilestone { get; set; }
		public IfcInteger Priority { get; set; }
		public IfcTaskTime TaskTime { get; set; }
		public IfcTaskTypeEnum PredefinedType { get; set; }

		public IfcTask() { }

		public IfcTask(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcIdentifier Identification, IfcText LongDescription, IfcLabel Status, IfcLabel WorkMethod, IfcBoolean IsMilestone, IfcInteger Priority, IfcTaskTime TaskTime, IfcTaskTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.Identification = Identification;
			this.LongDescription = LongDescription;
			this.Status = Status;
			this.WorkMethod = WorkMethod;
			this.IsMilestone = IsMilestone;
			this.Priority = Priority;
			this.TaskTime = TaskTime;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcTaskTime : IfcSchedulingTime
	{
		//1	Name : IfcLabel
		//2	DataOrigin : IfcDataOriginEnum
		//3	UserDefinedDataOrigin : IfcLabel
		//4	DurationType : IfcTaskDurationEnum
		//5	ScheduleDuration : IfcDuration
		//6	ScheduleStart : IfcDateTime
		//7	ScheduleFinish : IfcDateTime
		//8	EarlyStart : IfcDateTime
		//9	EarlyFinish : IfcDateTime
		//10	LateStart : IfcDateTime
		//11	LateFinish : IfcDateTime
		//12	FreeFloat : IfcDuration
		//13	TotalFloat : IfcDuration
		//14	IsCritical : IfcBoolean
		//15	StatusTime : IfcDateTime
		//16	ActualDuration : IfcDuration
		//17	ActualStart : IfcDateTime
		//18	ActualFinish : IfcDateTime
		//19	RemainingTime : IfcDuration
		//20	Completion : IfcPositiveRatioMeasure

		public IfcTaskDurationEnum DurationType { get; set; }
		public IfcDuration ScheduleDuration { get; set; }
		public IfcDateTime ScheduleStart { get; set; }
		public IfcDateTime ScheduleFinish { get; set; }
		public IfcDateTime EarlyStart { get; set; }
		public IfcDateTime EarlyFinish { get; set; }
		public IfcDateTime LateStart { get; set; }
		public IfcDateTime LateFinish { get; set; }
		public IfcDuration FreeFloat { get; set; }
		public IfcDuration TotalFloat { get; set; }
		public IfcBoolean IsCritical { get; set; }
		public IfcDateTime StatusTime { get; set; }
		public IfcDuration ActualDuration { get; set; }
		public IfcDateTime ActualStart { get; set; }
		public IfcDateTime ActualFinish { get; set; }
		public IfcDuration RemainingTime { get; set; }
		public IfcPositiveRatioMeasure Completion { get; set; }

		public IfcTaskTime() { }

		public IfcTaskTime(IfcLabel Name, IfcDataOriginEnum DataOrigin, IfcLabel UserDefinedDataOrigin, IfcTaskDurationEnum DurationType, IfcDuration ScheduleDuration, IfcDateTime ScheduleStart, IfcDateTime ScheduleFinish, IfcDateTime EarlyStart, IfcDateTime EarlyFinish, IfcDateTime LateStart, IfcDateTime LateFinish, IfcDuration FreeFloat, IfcDuration TotalFloat, IfcBoolean IsCritical, IfcDateTime StatusTime, IfcDuration ActualDuration, IfcDateTime ActualStart, IfcDateTime ActualFinish, IfcDuration RemainingTime, IfcPositiveRatioMeasure Completion)
		{
			this.Name = Name;
			this.DataOrigin = DataOrigin;
			this.UserDefinedDataOrigin = UserDefinedDataOrigin;
			this.DurationType = DurationType;
			this.ScheduleDuration = ScheduleDuration;
			this.ScheduleStart = ScheduleStart;
			this.ScheduleFinish = ScheduleFinish;
			this.EarlyStart = EarlyStart;
			this.EarlyFinish = EarlyFinish;
			this.LateStart = LateStart;
			this.LateFinish = LateFinish;
			this.FreeFloat = FreeFloat;
			this.TotalFloat = TotalFloat;
			this.IsCritical = IsCritical;
			this.StatusTime = StatusTime;
			this.ActualDuration = ActualDuration;
			this.ActualStart = ActualStart;
			this.ActualFinish = ActualFinish;
			this.RemainingTime = RemainingTime;
			this.Completion = Completion;
		}
	}

	public class IfcTaskTimeRecurring : IfcTaskTime
	{
		//1	Name : IfcLabel
		//2	DataOrigin : IfcDataOriginEnum
		//3	UserDefinedDataOrigin : IfcLabel
		//4	DurationType : IfcTaskDurationEnum
		//5	ScheduleDuration : IfcDuration
		//6	ScheduleStart : IfcDateTime
		//7	ScheduleFinish : IfcDateTime
		//8	EarlyStart : IfcDateTime
		//9	EarlyFinish : IfcDateTime
		//10	LateStart : IfcDateTime
		//11	LateFinish : IfcDateTime
		//12	FreeFloat : IfcDuration
		//13	TotalFloat : IfcDuration
		//14	IsCritical : IfcBoolean
		//15	StatusTime : IfcDateTime
		//16	ActualDuration : IfcDuration
		//17	ActualStart : IfcDateTime
		//18	ActualFinish : IfcDateTime
		//19	RemainingTime : IfcDuration
		//20	Completion : IfcPositiveRatioMeasure
		//21	Recurrence : IfcRecurrencePattern

		public IfcRecurrencePattern Recurrence { get; set; }

		public IfcTaskTimeRecurring() { }

		public IfcTaskTimeRecurring(IfcLabel Name, IfcDataOriginEnum DataOrigin, IfcLabel UserDefinedDataOrigin, IfcTaskDurationEnum DurationType, IfcDuration ScheduleDuration, IfcDateTime ScheduleStart, IfcDateTime ScheduleFinish, IfcDateTime EarlyStart, IfcDateTime EarlyFinish, IfcDateTime LateStart, IfcDateTime LateFinish, IfcDuration FreeFloat, IfcDuration TotalFloat, IfcBoolean IsCritical, IfcDateTime StatusTime, IfcDuration ActualDuration, IfcDateTime ActualStart, IfcDateTime ActualFinish, IfcDuration RemainingTime, IfcPositiveRatioMeasure Completion, IfcRecurrencePattern Recurrence)
		{
			this.Name = Name;
			this.DataOrigin = DataOrigin;
			this.UserDefinedDataOrigin = UserDefinedDataOrigin;
			this.DurationType = DurationType;
			this.ScheduleDuration = ScheduleDuration;
			this.ScheduleStart = ScheduleStart;
			this.ScheduleFinish = ScheduleFinish;
			this.EarlyStart = EarlyStart;
			this.EarlyFinish = EarlyFinish;
			this.LateStart = LateStart;
			this.LateFinish = LateFinish;
			this.FreeFloat = FreeFloat;
			this.TotalFloat = TotalFloat;
			this.IsCritical = IsCritical;
			this.StatusTime = StatusTime;
			this.ActualDuration = ActualDuration;
			this.ActualStart = ActualStart;
			this.ActualFinish = ActualFinish;
			this.RemainingTime = RemainingTime;
			this.Completion = Completion;
			this.Recurrence = Recurrence;
		}
	}

	public class IfcTaskType : IfcTypeProcess
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	Identification : IfcIdentifier
		//8	LongDescription : IfcText
		//9	ProcessType : IfcLabel
		//10	PredefinedType : IfcTaskTypeEnum
		//11	WorkMethod : IfcLabel

		public IfcTaskTypeEnum PredefinedType { get; set; }
		public IfcLabel WorkMethod { get; set; }

		public IfcTaskType() { }

		public IfcTaskType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcIdentifier Identification, IfcText LongDescription, IfcLabel ProcessType, IfcTaskTypeEnum PredefinedType, IfcLabel WorkMethod)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.Identification = Identification;
			this.LongDescription = LongDescription;
			this.ProcessType = ProcessType;
			this.PredefinedType = PredefinedType;
			this.WorkMethod = WorkMethod;
		}
	}

	public class IfcTelecomAddress : IfcAddress
	{
		//1	Purpose : IfcAddressTypeEnum
		//2	Description : IfcText
		//3	UserDefinedPurpose : IfcLabel
		//4	TelephoneNumbers : List<IfcLabel>
		//5	FacsimileNumbers : List<IfcLabel>
		//6	PagerNumber : IfcLabel
		//7	ElectronicMailAddresses : List<IfcLabel>
		//8	WWWHomePageURL : IfcURIReference
		//9	MessagingIDs : List<IfcURIReference>

		public List<IfcLabel> TelephoneNumbers { get; set; }
		public List<IfcLabel> FacsimileNumbers { get; set; }
		public IfcLabel PagerNumber { get; set; }
		public List<IfcLabel> ElectronicMailAddresses { get; set; }
		public IfcURIReference WWWHomePageURL { get; set; }
		public List<IfcURIReference> MessagingIDs { get; set; }

		public IfcTelecomAddress() { }

		public IfcTelecomAddress(IfcAddressTypeEnum Purpose, IfcText Description, IfcLabel UserDefinedPurpose, List<IfcLabel> TelephoneNumbers, List<IfcLabel> FacsimileNumbers, IfcLabel PagerNumber, List<IfcLabel> ElectronicMailAddresses, IfcURIReference WWWHomePageURL, List<IfcURIReference> MessagingIDs)
		{
			this.Purpose = Purpose;
			this.Description = Description;
			this.UserDefinedPurpose = UserDefinedPurpose;
			this.TelephoneNumbers = TelephoneNumbers;
			this.FacsimileNumbers = FacsimileNumbers;
			this.PagerNumber = PagerNumber;
			this.ElectronicMailAddresses = ElectronicMailAddresses;
			this.WWWHomePageURL = WWWHomePageURL;
			this.MessagingIDs = MessagingIDs;
		}
	}

	public class IfcTendon : IfcReinforcingElement
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	SteelGrade : IfcLabel
		//10	PredefinedType : IfcTendonTypeEnum
		//11	NominalDiameter : IfcPositiveLengthMeasure
		//12	CrossSectionArea : IfcAreaMeasure
		//13	TensionForce : IfcForceMeasure
		//14	PreStress : IfcPressureMeasure
		//15	FrictionCoefficient : IfcNormalisedRatioMeasure
		//16	AnchorageSlip : IfcPositiveLengthMeasure
		//17	MinCurvatureRadius : IfcPositiveLengthMeasure

		public IfcTendonTypeEnum PredefinedType { get; set; }
		public IfcPositiveLengthMeasure NominalDiameter { get; set; }
		public IfcAreaMeasure CrossSectionArea { get; set; }
		public IfcForceMeasure TensionForce { get; set; }
		public IfcPressureMeasure PreStress { get; set; }
		public IfcNormalisedRatioMeasure FrictionCoefficient { get; set; }
		public IfcPositiveLengthMeasure AnchorageSlip { get; set; }
		public IfcPositiveLengthMeasure MinCurvatureRadius { get; set; }

		public IfcTendon() { }

		public IfcTendon(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcLabel SteelGrade, IfcTendonTypeEnum PredefinedType, IfcPositiveLengthMeasure NominalDiameter, IfcAreaMeasure CrossSectionArea, IfcForceMeasure TensionForce, IfcPressureMeasure PreStress, IfcNormalisedRatioMeasure FrictionCoefficient, IfcPositiveLengthMeasure AnchorageSlip, IfcPositiveLengthMeasure MinCurvatureRadius)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.SteelGrade = SteelGrade;
			this.PredefinedType = PredefinedType;
			this.NominalDiameter = NominalDiameter;
			this.CrossSectionArea = CrossSectionArea;
			this.TensionForce = TensionForce;
			this.PreStress = PreStress;
			this.FrictionCoefficient = FrictionCoefficient;
			this.AnchorageSlip = AnchorageSlip;
			this.MinCurvatureRadius = MinCurvatureRadius;
		}
	}

	public class IfcTendonAnchor : IfcReinforcingElement
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	SteelGrade : IfcLabel
		//10	PredefinedType : IfcTendonAnchorTypeEnum

		public IfcTendonAnchorTypeEnum PredefinedType { get; set; }

		public IfcTendonAnchor() { }

		public IfcTendonAnchor(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcLabel SteelGrade, IfcTendonAnchorTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.SteelGrade = SteelGrade;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcTendonAnchorType : IfcReinforcingElementType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel
		//10	PredefinedType : IfcTendonAnchorTypeEnum

		public IfcTendonAnchorTypeEnum PredefinedType { get; set; }

		public IfcTendonAnchorType() { }

		public IfcTendonAnchorType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType, IfcTendonAnchorTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcTendonType : IfcReinforcingElementType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel
		//10	PredefinedType : IfcTendonTypeEnum
		//11	NominalDiameter : IfcPositiveLengthMeasure
		//12	CrossSectionArea : IfcAreaMeasure
		//13	SheathDiameter : IfcPositiveLengthMeasure

		public IfcTendonTypeEnum PredefinedType { get; set; }
		public IfcPositiveLengthMeasure NominalDiameter { get; set; }
		public IfcAreaMeasure CrossSectionArea { get; set; }
		public IfcPositiveLengthMeasure SheathDiameter { get; set; }

		public IfcTendonType() { }

		public IfcTendonType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType, IfcTendonTypeEnum PredefinedType, IfcPositiveLengthMeasure NominalDiameter, IfcAreaMeasure CrossSectionArea, IfcPositiveLengthMeasure SheathDiameter)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
			this.PredefinedType = PredefinedType;
			this.NominalDiameter = NominalDiameter;
			this.CrossSectionArea = CrossSectionArea;
			this.SheathDiameter = SheathDiameter;
		}
	}

	public abstract class IfcTessellatedFaceSet : IfcTessellatedItem, IfcBooleanOperand
	{
		//1	Coordinates : IfcCartesianPointList3D

		public IfcCartesianPointList3D Coordinates { get; set; }
		public IfcDimensionCount Dim { get; set; }
		public List<IfcIndexedColourMap> HasColours { get; set; }
		public List<IfcIndexedTextureMap> HasTextures { get; set; }
		public IfcDimensionCount GetDim() { return Dim; }

		public IfcTessellatedFaceSet() { }

		public IfcTessellatedFaceSet(IfcCartesianPointList3D Coordinates)
		{
			this.Coordinates = Coordinates;
		}
	}

	public abstract class IfcTessellatedItem : IfcGeometricRepresentationItem
	{
		public IfcTessellatedItem() { }
	}

	public class IfcTextLiteral : IfcGeometricRepresentationItem
	{
		//1	Literal : IfcPresentableText
		//2	Placement : IfcAxis2Placement
		//3	Path : IfcTextPath

		public IfcPresentableText Literal { get; set; }
		public IfcAxis2Placement Placement { get; set; }
		public IfcTextPath Path { get; set; }

		public IfcTextLiteral() { }

		public IfcTextLiteral(IfcPresentableText Literal, IfcAxis2Placement Placement, IfcTextPath Path)
		{
			this.Literal = Literal;
			this.Placement = Placement;
			this.Path = Path;
		}
	}

	public class IfcTextLiteralWithExtent : IfcTextLiteral
	{
		//1	Literal : IfcPresentableText
		//2	Placement : IfcAxis2Placement
		//3	Path : IfcTextPath
		//4	Extent : IfcPlanarExtent
		//5	BoxAlignment : IfcBoxAlignment

		public IfcPlanarExtent Extent { get; set; }
		public IfcBoxAlignment BoxAlignment { get; set; }

		public IfcTextLiteralWithExtent() { }

		public IfcTextLiteralWithExtent(IfcPresentableText Literal, IfcAxis2Placement Placement, IfcTextPath Path, IfcPlanarExtent Extent, IfcBoxAlignment BoxAlignment)
		{
			this.Literal = Literal;
			this.Placement = Placement;
			this.Path = Path;
			this.Extent = Extent;
			this.BoxAlignment = BoxAlignment;
		}
	}

	public class IfcTextStyle : IfcPresentationStyle, IfcPresentationStyleSelect
	{
		//1	Name : IfcLabel
		//2	TextCharacterAppearance : IfcTextStyleForDefinedFont
		//3	TextStyle : IfcTextStyleTextModel
		//4	TextFontStyle : IfcTextFontSelect
		//5	ModelOrDraughting : IfcBoolean

		public IfcTextStyleForDefinedFont TextCharacterAppearance { get; set; }
		public IfcTextStyleTextModel TextStyle { get; set; }
		public IfcTextFontSelect TextFontStyle { get; set; }
		public IfcBoolean ModelOrDraughting { get; set; }

		public IfcTextStyle() { }

		public IfcTextStyle(IfcLabel Name, IfcTextStyleForDefinedFont TextCharacterAppearance, IfcTextStyleTextModel TextStyle, IfcTextFontSelect TextFontStyle, IfcBoolean ModelOrDraughting)
		{
			this.Name = Name;
			this.TextCharacterAppearance = TextCharacterAppearance;
			this.TextStyle = TextStyle;
			this.TextFontStyle = TextFontStyle;
			this.ModelOrDraughting = ModelOrDraughting;
		}
	}

	public class IfcTextStyleFontModel : IfcPreDefinedTextFont
	{
		//1	Name : IfcLabel
		//2	FontFamily : List<IfcTextFontName>
		//3	FontStyle : IfcFontStyle
		//4	FontVariant : IfcFontVariant
		//5	FontWeight : IfcFontWeight
		//6	FontSize : IfcSizeSelect

		public List<IfcTextFontName> FontFamily { get; set; }
		public IfcFontStyle FontStyle { get; set; }
		public IfcFontVariant FontVariant { get; set; }
		public IfcFontWeight FontWeight { get; set; }
		public IfcSizeSelect FontSize { get; set; }

		public IfcTextStyleFontModel() { }

		public IfcTextStyleFontModel(IfcLabel Name, List<IfcTextFontName> FontFamily, IfcFontStyle FontStyle, IfcFontVariant FontVariant, IfcFontWeight FontWeight, IfcSizeSelect FontSize)
		{
			this.Name = Name;
			this.FontFamily = FontFamily;
			this.FontStyle = FontStyle;
			this.FontVariant = FontVariant;
			this.FontWeight = FontWeight;
			this.FontSize = FontSize;
		}
	}

	public class IfcTextStyleForDefinedFont : IfcPresentationItem
	{
		//1	Colour : IfcColour
		//2	BackgroundColour : IfcColour

		public IfcColour Colour { get; set; }
		public IfcColour BackgroundColour { get; set; }

		public IfcTextStyleForDefinedFont() { }

		public IfcTextStyleForDefinedFont(IfcColour Colour, IfcColour BackgroundColour)
		{
			this.Colour = Colour;
			this.BackgroundColour = BackgroundColour;
		}
	}

	public class IfcTextStyleTextModel : IfcPresentationItem
	{
		//1	TextIndent : IfcSizeSelect
		//2	TextAlign : IfcTextAlignment
		//3	TextDecoration : IfcTextDecoration
		//4	LetterSpacing : IfcSizeSelect
		//5	WordSpacing : IfcSizeSelect
		//6	TextTransform : IfcTextTransformation
		//7	LineHeight : IfcSizeSelect

		public IfcSizeSelect TextIndent { get; set; }
		public IfcTextAlignment TextAlign { get; set; }
		public IfcTextDecoration TextDecoration { get; set; }
		public IfcSizeSelect LetterSpacing { get; set; }
		public IfcSizeSelect WordSpacing { get; set; }
		public IfcTextTransformation TextTransform { get; set; }
		public IfcSizeSelect LineHeight { get; set; }

		public IfcTextStyleTextModel() { }

		public IfcTextStyleTextModel(IfcSizeSelect TextIndent, IfcTextAlignment TextAlign, IfcTextDecoration TextDecoration, IfcSizeSelect LetterSpacing, IfcSizeSelect WordSpacing, IfcTextTransformation TextTransform, IfcSizeSelect LineHeight)
		{
			this.TextIndent = TextIndent;
			this.TextAlign = TextAlign;
			this.TextDecoration = TextDecoration;
			this.LetterSpacing = LetterSpacing;
			this.WordSpacing = WordSpacing;
			this.TextTransform = TextTransform;
			this.LineHeight = LineHeight;
		}
	}

	public abstract class IfcTextureCoordinate : IfcPresentationItem
	{
		//1	Maps : List<IfcSurfaceTexture>

		public List<IfcSurfaceTexture> Maps { get; set; }

		public IfcTextureCoordinate() { }

		public IfcTextureCoordinate(List<IfcSurfaceTexture> Maps)
		{
			this.Maps = Maps;
		}
	}

	public class IfcTextureCoordinateGenerator : IfcTextureCoordinate
	{
		//1	Maps : List<IfcSurfaceTexture>
		//2	Mode : IfcLabel
		//3	Parameter : List<IfcReal>

		public IfcLabel Mode { get; set; }
		public List<IfcReal> Parameter { get; set; }

		public IfcTextureCoordinateGenerator() { }

		public IfcTextureCoordinateGenerator(List<IfcSurfaceTexture> Maps, IfcLabel Mode, List<IfcReal> Parameter)
		{
			this.Maps = Maps;
			this.Mode = Mode;
			this.Parameter = Parameter;
		}
	}

	public class IfcTextureMap : IfcTextureCoordinate
	{
		//1	Maps : List<IfcSurfaceTexture>
		//2	Vertices : List<IfcTextureVertex>
		//3	MappedTo : IfcFace

		public List<IfcTextureVertex> Vertices { get; set; }
		public IfcFace MappedTo { get; set; }

		public IfcTextureMap() { }

		public IfcTextureMap(List<IfcSurfaceTexture> Maps, List<IfcTextureVertex> Vertices, IfcFace MappedTo)
		{
			this.Maps = Maps;
			this.Vertices = Vertices;
			this.MappedTo = MappedTo;
		}
	}

	public class IfcTextureVertex : IfcPresentationItem
	{
		//1	Coordinates : List<IfcParameterValue>

		public List<IfcParameterValue> Coordinates { get; set; }

		public IfcTextureVertex() { }

		public IfcTextureVertex(List<IfcParameterValue> Coordinates)
		{
			this.Coordinates = Coordinates;
		}
	}

	public class IfcTextureVertexList : IfcPresentationItem
	{
		//1	TexCoordsList : List<List<IfcParameterValue>>

		public List<List<IfcParameterValue>> TexCoordsList { get; set; }

		public IfcTextureVertexList() { }

		public IfcTextureVertexList(List<List<IfcParameterValue>> TexCoordsList)
		{
			this.TexCoordsList = TexCoordsList;
		}
	}

	public class IfcTimePeriod : IfcBase
	{
		//1	StartTime : IfcTime
		//2	EndTime : IfcTime

		public IfcTime StartTime { get; set; }
		public IfcTime EndTime { get; set; }

		public IfcTimePeriod() { }

		public IfcTimePeriod(IfcTime StartTime, IfcTime EndTime)
		{
			this.StartTime = StartTime;
			this.EndTime = EndTime;
		}
	}

	public abstract class IfcTimeSeries : IfcBase, IfcMetricValueSelect, IfcObjectReferenceSelect, IfcResourceObjectSelect
	{
		//1	Name : IfcLabel
		//2	Description : IfcText
		//3	StartTime : IfcDateTime
		//4	EndTime : IfcDateTime
		//5	TimeSeriesDataType : IfcTimeSeriesDataTypeEnum
		//6	DataOrigin : IfcDataOriginEnum
		//7	UserDefinedDataOrigin : IfcLabel
		//8	Unit : IfcUnit

		public IfcLabel Name { get; set; }
		public IfcText Description { get; set; }
		public IfcDateTime StartTime { get; set; }
		public IfcDateTime EndTime { get; set; }
		public IfcTimeSeriesDataTypeEnum TimeSeriesDataType { get; set; }
		public IfcDataOriginEnum DataOrigin { get; set; }
		public IfcLabel UserDefinedDataOrigin { get; set; }
		public IfcUnit Unit { get; set; }
		public List<IfcExternalReferenceRelationship> HasExternalReference { get; set; }

		public IfcTimeSeries() { }

		public IfcTimeSeries(IfcLabel Name, IfcText Description, IfcDateTime StartTime, IfcDateTime EndTime, IfcTimeSeriesDataTypeEnum TimeSeriesDataType, IfcDataOriginEnum DataOrigin, IfcLabel UserDefinedDataOrigin, IfcUnit Unit)
		{
			this.Name = Name;
			this.Description = Description;
			this.StartTime = StartTime;
			this.EndTime = EndTime;
			this.TimeSeriesDataType = TimeSeriesDataType;
			this.DataOrigin = DataOrigin;
			this.UserDefinedDataOrigin = UserDefinedDataOrigin;
			this.Unit = Unit;
		}
	}

	public class IfcTimeSeriesValue : IfcBase
	{
		//1	ListValues : List<IfcValue>

		public List<IfcValue> ListValues { get; set; }

		public IfcTimeSeriesValue() { }

		public IfcTimeSeriesValue(List<IfcValue> ListValues)
		{
			this.ListValues = ListValues;
		}
	}

	public abstract class IfcTopologicalRepresentationItem : IfcRepresentationItem
	{
		public IfcTopologicalRepresentationItem() { }
	}

	public class IfcTopologyRepresentation : IfcShapeModel
	{
		//1	ContextOfItems : IfcRepresentationContext
		//2	RepresentationIdentifier : IfcLabel
		//3	RepresentationType : IfcLabel
		//4	Items : List<IfcRepresentationItem>

		public IfcTopologyRepresentation() { }

		public IfcTopologyRepresentation(IfcRepresentationContext ContextOfItems, IfcLabel RepresentationIdentifier, IfcLabel RepresentationType, List<IfcRepresentationItem> Items)
		{
			this.ContextOfItems = ContextOfItems;
			this.RepresentationIdentifier = RepresentationIdentifier;
			this.RepresentationType = RepresentationType;
			this.Items = Items;
		}
	}

	public class IfcToroidalSurface : IfcElementarySurface
	{
		//1	Position : IfcAxis2Placement3D
		//2	MajorRadius : IfcPositiveLengthMeasure
		//3	MinorRadius : IfcPositiveLengthMeasure

		public IfcPositiveLengthMeasure MajorRadius { get; set; }
		public IfcPositiveLengthMeasure MinorRadius { get; set; }

		public IfcToroidalSurface() { }

		public IfcToroidalSurface(IfcAxis2Placement3D Position, IfcPositiveLengthMeasure MajorRadius, IfcPositiveLengthMeasure MinorRadius)
		{
			this.Position = Position;
			this.MajorRadius = MajorRadius;
			this.MinorRadius = MinorRadius;
		}
	}

	public class IfcTransformer : IfcEnergyConversionDevice
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	PredefinedType : IfcTransformerTypeEnum

		public IfcTransformerTypeEnum PredefinedType { get; set; }

		public IfcTransformer() { }

		public IfcTransformer(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcTransformerTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcTransformerType : IfcEnergyConversionDeviceType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel
		//10	PredefinedType : IfcTransformerTypeEnum

		public IfcTransformerTypeEnum PredefinedType { get; set; }

		public IfcTransformerType() { }

		public IfcTransformerType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType, IfcTransformerTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcTransportElement : IfcElement
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	PredefinedType : IfcTransportElementTypeEnum

		public IfcTransportElementTypeEnum PredefinedType { get; set; }

		public IfcTransportElement() { }

		public IfcTransportElement(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcTransportElementTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcTransportElementType : IfcElementType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel
		//10	PredefinedType : IfcTransportElementTypeEnum

		public IfcTransportElementTypeEnum PredefinedType { get; set; }

		public IfcTransportElementType() { }

		public IfcTransportElementType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType, IfcTransportElementTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcTrapeziumProfileDef : IfcParameterizedProfileDef
	{
		//1	ProfileType : IfcProfileTypeEnum
		//2	ProfileName : IfcLabel
		//3	Position : IfcAxis2Placement2D
		//4	BottomXDim : IfcPositiveLengthMeasure
		//5	TopXDim : IfcPositiveLengthMeasure
		//6	YDim : IfcPositiveLengthMeasure
		//7	TopXOffset : IfcLengthMeasure

		public IfcPositiveLengthMeasure BottomXDim { get; set; }
		public IfcPositiveLengthMeasure TopXDim { get; set; }
		public IfcPositiveLengthMeasure YDim { get; set; }
		public IfcLengthMeasure TopXOffset { get; set; }

		public IfcTrapeziumProfileDef() { }

		public IfcTrapeziumProfileDef(IfcProfileTypeEnum ProfileType, IfcLabel ProfileName, IfcAxis2Placement2D Position, IfcPositiveLengthMeasure BottomXDim, IfcPositiveLengthMeasure TopXDim, IfcPositiveLengthMeasure YDim, IfcLengthMeasure TopXOffset)
		{
			this.ProfileType = ProfileType;
			this.ProfileName = ProfileName;
			this.Position = Position;
			this.BottomXDim = BottomXDim;
			this.TopXDim = TopXDim;
			this.YDim = YDim;
			this.TopXOffset = TopXOffset;
		}
	}

	public class IfcTriangulatedFaceSet : IfcTessellatedFaceSet
	{
		//1	Coordinates : IfcCartesianPointList3D
		//2	Normals : List<List<IfcParameterValue>>
		//3	Closed : IfcBoolean
		//4	CoordIndex : List<List<IfcPositiveInteger>>
		//5	PnIndex : List<IfcPositiveInteger>

		public List<List<IfcParameterValue>> Normals { get; set; }
		public IfcBoolean Closed { get; set; }
		public List<List<IfcPositiveInteger>> CoordIndex { get; set; }
		public List<IfcPositiveInteger> PnIndex { get; set; }
		public IfcInteger NumberOfTriangles { get; set; }

		public IfcTriangulatedFaceSet() { }

		public IfcTriangulatedFaceSet(IfcCartesianPointList3D Coordinates, List<List<IfcParameterValue>> Normals, IfcBoolean Closed, List<List<IfcPositiveInteger>> CoordIndex, List<IfcPositiveInteger> PnIndex)
		{
			this.Coordinates = Coordinates;
			this.Normals = Normals;
			this.Closed = Closed;
			this.CoordIndex = CoordIndex;
			this.PnIndex = PnIndex;
		}
	}

	public class IfcTrimmedCurve : IfcBoundedCurve
	{
		//1	BasisCurve : IfcCurve
		//2	Trim1 : List<IfcTrimmingSelect>
		//3	Trim2 : List<IfcTrimmingSelect>
		//4	SenseAgreement : IfcBoolean
		//5	MasterRepresentation : IfcTrimmingPreference

		public IfcCurve BasisCurve { get; set; }
		public List<IfcTrimmingSelect> Trim1 { get; set; }
		public List<IfcTrimmingSelect> Trim2 { get; set; }
		public IfcBoolean SenseAgreement { get; set; }
		public IfcTrimmingPreference MasterRepresentation { get; set; }

		public IfcTrimmedCurve() { }

		public IfcTrimmedCurve(IfcCurve BasisCurve, List<IfcTrimmingSelect> Trim1, List<IfcTrimmingSelect> Trim2, IfcBoolean SenseAgreement, IfcTrimmingPreference MasterRepresentation)
		{
			this.BasisCurve = BasisCurve;
			this.Trim1 = Trim1;
			this.Trim2 = Trim2;
			this.SenseAgreement = SenseAgreement;
			this.MasterRepresentation = MasterRepresentation;
		}
	}

	public class IfcTubeBundle : IfcEnergyConversionDevice
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	PredefinedType : IfcTubeBundleTypeEnum

		public IfcTubeBundleTypeEnum PredefinedType { get; set; }

		public IfcTubeBundle() { }

		public IfcTubeBundle(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcTubeBundleTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcTubeBundleType : IfcEnergyConversionDeviceType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel
		//10	PredefinedType : IfcTubeBundleTypeEnum

		public IfcTubeBundleTypeEnum PredefinedType { get; set; }

		public IfcTubeBundleType() { }

		public IfcTubeBundleType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType, IfcTubeBundleTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcTypeObject : IfcObjectDefinition
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>

		public IfcIdentifier ApplicableOccurrence { get; set; }
		public List<IfcPropertySetDefinition> HasPropertySets { get; set; }
		public List<IfcRelDefinesByType> Types { get; set; }

		public IfcTypeObject() { }

		public IfcTypeObject(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
		}
	}

	public abstract class IfcTypeProcess : IfcTypeObject, IfcProcessSelect
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	Identification : IfcIdentifier
		//8	LongDescription : IfcText
		//9	ProcessType : IfcLabel

		public IfcIdentifier Identification { get; set; }
		public IfcText LongDescription { get; set; }
		public IfcLabel ProcessType { get; set; }
		public List<IfcRelAssignsToProcess> OperatesOn { get; set; }
		public IfcIdentifier GetIdentification() { return Identification; }
		public IfcText GetLongDescription() { return LongDescription; }
		public List<IfcRelAssignsToProcess> GetOperatesOn() { return OperatesOn; }

		public IfcTypeProcess() { }

		public IfcTypeProcess(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcIdentifier Identification, IfcText LongDescription, IfcLabel ProcessType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.Identification = Identification;
			this.LongDescription = LongDescription;
			this.ProcessType = ProcessType;
		}
	}

	public class IfcTypeProduct : IfcTypeObject, IfcProductSelect
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel

		public List<IfcRepresentationMap> RepresentationMaps { get; set; }
		public IfcLabel Tag { get; set; }
		public List<IfcRelAssignsToProduct> ReferencedBy { get; set; }
		public List<IfcRelAssignsToProduct> GetReferencedBy() { return ReferencedBy; }

		public IfcTypeProduct() { }

		public IfcTypeProduct(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
		}
	}

	public abstract class IfcTypeResource : IfcTypeObject, IfcResourceSelect
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	Identification : IfcIdentifier
		//8	LongDescription : IfcText
		//9	ResourceType : IfcLabel

		public IfcIdentifier Identification { get; set; }
		public IfcText LongDescription { get; set; }
		public IfcLabel ResourceType { get; set; }
		public List<IfcRelAssignsToResource> ResourceOf { get; set; }
		public IfcIdentifier GetIdentification() { return Identification; }
		public IfcText GetLongDescription() { return LongDescription; }
		public List<IfcRelAssignsToResource> GetResourceOf() { return ResourceOf; }

		public IfcTypeResource() { }

		public IfcTypeResource(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcIdentifier Identification, IfcText LongDescription, IfcLabel ResourceType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.Identification = Identification;
			this.LongDescription = LongDescription;
			this.ResourceType = ResourceType;
		}
	}

	public class IfcUShapeProfileDef : IfcParameterizedProfileDef
	{
		//1	ProfileType : IfcProfileTypeEnum
		//2	ProfileName : IfcLabel
		//3	Position : IfcAxis2Placement2D
		//4	Depth : IfcPositiveLengthMeasure
		//5	FlangeWidth : IfcPositiveLengthMeasure
		//6	WebThickness : IfcPositiveLengthMeasure
		//7	FlangeThickness : IfcPositiveLengthMeasure
		//8	FilletRadius : IfcNonNegativeLengthMeasure
		//9	EdgeRadius : IfcNonNegativeLengthMeasure
		//10	FlangeSlope : IfcPlaneAngleMeasure

		public IfcPositiveLengthMeasure Depth { get; set; }
		public IfcPositiveLengthMeasure FlangeWidth { get; set; }
		public IfcPositiveLengthMeasure WebThickness { get; set; }
		public IfcPositiveLengthMeasure FlangeThickness { get; set; }
		public IfcNonNegativeLengthMeasure FilletRadius { get; set; }
		public IfcNonNegativeLengthMeasure EdgeRadius { get; set; }
		public IfcPlaneAngleMeasure FlangeSlope { get; set; }

		public IfcUShapeProfileDef() { }

		public IfcUShapeProfileDef(IfcProfileTypeEnum ProfileType, IfcLabel ProfileName, IfcAxis2Placement2D Position, IfcPositiveLengthMeasure Depth, IfcPositiveLengthMeasure FlangeWidth, IfcPositiveLengthMeasure WebThickness, IfcPositiveLengthMeasure FlangeThickness, IfcNonNegativeLengthMeasure FilletRadius, IfcNonNegativeLengthMeasure EdgeRadius, IfcPlaneAngleMeasure FlangeSlope)
		{
			this.ProfileType = ProfileType;
			this.ProfileName = ProfileName;
			this.Position = Position;
			this.Depth = Depth;
			this.FlangeWidth = FlangeWidth;
			this.WebThickness = WebThickness;
			this.FlangeThickness = FlangeThickness;
			this.FilletRadius = FilletRadius;
			this.EdgeRadius = EdgeRadius;
			this.FlangeSlope = FlangeSlope;
		}
	}

	public class IfcUnitAssignment : IfcBase
	{
		//1	Units : List<IfcUnit>

		public List<IfcUnit> Units { get; set; }

		public IfcUnitAssignment() { }

		public IfcUnitAssignment(List<IfcUnit> Units)
		{
			this.Units = Units;
		}
	}

	public class IfcUnitaryControlElement : IfcDistributionControlElement
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	PredefinedType : IfcUnitaryControlElementTypeEnum

		public IfcUnitaryControlElementTypeEnum PredefinedType { get; set; }

		public IfcUnitaryControlElement() { }

		public IfcUnitaryControlElement(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcUnitaryControlElementTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcUnitaryControlElementType : IfcDistributionControlElementType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel
		//10	PredefinedType : IfcUnitaryControlElementTypeEnum

		public IfcUnitaryControlElementTypeEnum PredefinedType { get; set; }

		public IfcUnitaryControlElementType() { }

		public IfcUnitaryControlElementType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType, IfcUnitaryControlElementTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcUnitaryEquipment : IfcEnergyConversionDevice
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	PredefinedType : IfcUnitaryEquipmentTypeEnum

		public IfcUnitaryEquipmentTypeEnum PredefinedType { get; set; }

		public IfcUnitaryEquipment() { }

		public IfcUnitaryEquipment(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcUnitaryEquipmentTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcUnitaryEquipmentType : IfcEnergyConversionDeviceType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel
		//10	PredefinedType : IfcUnitaryEquipmentTypeEnum

		public IfcUnitaryEquipmentTypeEnum PredefinedType { get; set; }

		public IfcUnitaryEquipmentType() { }

		public IfcUnitaryEquipmentType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType, IfcUnitaryEquipmentTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcValve : IfcFlowController
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	PredefinedType : IfcValveTypeEnum

		public IfcValveTypeEnum PredefinedType { get; set; }

		public IfcValve() { }

		public IfcValve(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcValveTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcValveType : IfcFlowControllerType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel
		//10	PredefinedType : IfcValveTypeEnum

		public IfcValveTypeEnum PredefinedType { get; set; }

		public IfcValveType() { }

		public IfcValveType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType, IfcValveTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcVector : IfcGeometricRepresentationItem, IfcHatchLineDistanceSelect, IfcVectorOrDirection
	{
		//1	Orientation : IfcDirection
		//2	Magnitude : IfcLengthMeasure

		public IfcDirection Orientation { get; set; }
		public IfcLengthMeasure Magnitude { get; set; }
		public IfcDimensionCount Dim { get; set; }
		public IfcDimensionCount GetDim() { return Dim; }

		public IfcVector() { }
		public IfcVector(IfcDirection Orientation, double Magnitude)
		{
			this.Orientation = Orientation;
			this.Magnitude = (IfcLengthMeasure) Magnitude;
		}
		public IfcVector(IfcDirection Orientation, IfcLengthMeasure Magnitude)
		{
			this.Orientation = Orientation;
			this.Magnitude = Magnitude;
		}
	}

	public class IfcVertex : IfcTopologicalRepresentationItem
	{
		public IfcVertex() { }
	}

	public class IfcVertexLoop : IfcLoop
	{
		//1	LoopVertex : IfcVertex

		public IfcVertex LoopVertex { get; set; }

		public IfcVertexLoop() { }

		public IfcVertexLoop(IfcVertex LoopVertex)
		{
			this.LoopVertex = LoopVertex;
		}
	}

	public class IfcVertexPoint : IfcVertex, IfcPointOrVertexPoint
	{
		//1	VertexGeometry : IfcPoint

		public IfcPoint VertexGeometry { get; set; }

		public IfcVertexPoint() { }

		public IfcVertexPoint(IfcPoint VertexGeometry)
		{
			this.VertexGeometry = VertexGeometry;
		}
	}

	public class IfcVibrationIsolator : IfcElementComponent
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	PredefinedType : IfcVibrationIsolatorTypeEnum

		public IfcVibrationIsolatorTypeEnum PredefinedType { get; set; }

		public IfcVibrationIsolator() { }

		public IfcVibrationIsolator(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcVibrationIsolatorTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcVibrationIsolatorType : IfcElementComponentType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel
		//10	PredefinedType : IfcVibrationIsolatorTypeEnum

		public IfcVibrationIsolatorTypeEnum PredefinedType { get; set; }

		public IfcVibrationIsolatorType() { }

		public IfcVibrationIsolatorType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType, IfcVibrationIsolatorTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcVirtualElement : IfcElement
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier

		public IfcVirtualElement() { }

		public IfcVirtualElement(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
		}
	}

	public class IfcVirtualGridIntersection : IfcBase
	{
		//1	IntersectingAxes : List<IfcGridAxis>
		//2	OffsetDistances : List<IfcLengthMeasure>

		public List<IfcGridAxis> IntersectingAxes { get; set; }
		public List<IfcLengthMeasure> OffsetDistances { get; set; }

		public IfcVirtualGridIntersection() { }

		public IfcVirtualGridIntersection(List<IfcGridAxis> IntersectingAxes, List<IfcLengthMeasure> OffsetDistances)
		{
			this.IntersectingAxes = IntersectingAxes;
			this.OffsetDistances = OffsetDistances;
		}
	}

	public class IfcVoidingFeature : IfcFeatureElementSubtraction
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	PredefinedType : IfcVoidingFeatureTypeEnum

		public IfcVoidingFeatureTypeEnum PredefinedType { get; set; }

		public IfcVoidingFeature() { }

		public IfcVoidingFeature(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcVoidingFeatureTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcWall : IfcBuildingElement
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	PredefinedType : IfcWallTypeEnum

		public IfcWallTypeEnum PredefinedType { get; set; }

		public IfcWall() { }

		public IfcWall(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcWallTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcWallElementedCase : IfcWall
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	PredefinedType : IfcWallTypeEnum

		public IfcWallElementedCase() { }

		public IfcWallElementedCase(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcWallTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcWallStandardCase : IfcWall
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	PredefinedType : IfcWallTypeEnum

		public IfcWallStandardCase() { }

		public IfcWallStandardCase(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcWallTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcWallType : IfcBuildingElementType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel
		//10	PredefinedType : IfcWallTypeEnum

		public IfcWallTypeEnum PredefinedType { get; set; }

		public IfcWallType() { }

		public IfcWallType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType, IfcWallTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcWasteTerminal : IfcFlowTerminal
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	PredefinedType : IfcWasteTerminalTypeEnum

		public IfcWasteTerminalTypeEnum PredefinedType { get; set; }

		public IfcWasteTerminal() { }

		public IfcWasteTerminal(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcWasteTerminalTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcWasteTerminalType : IfcFlowTerminalType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel
		//10	PredefinedType : IfcWasteTerminalTypeEnum

		public IfcWasteTerminalTypeEnum PredefinedType { get; set; }

		public IfcWasteTerminalType() { }

		public IfcWasteTerminalType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType, IfcWasteTerminalTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcWindow : IfcBuildingElement
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	OverallHeight : IfcPositiveLengthMeasure
		//10	OverallWidth : IfcPositiveLengthMeasure
		//11	PredefinedType : IfcWindowTypeEnum
		//12	PartitioningType : IfcWindowTypePartitioningEnum
		//13	UserDefinedPartitioningType : IfcLabel

		public IfcPositiveLengthMeasure OverallHeight { get; set; }
		public IfcPositiveLengthMeasure OverallWidth { get; set; }
		public IfcWindowTypeEnum PredefinedType { get; set; }
		public IfcWindowTypePartitioningEnum PartitioningType { get; set; }
		public IfcLabel UserDefinedPartitioningType { get; set; }

		public IfcWindow() { }

		public IfcWindow(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcPositiveLengthMeasure OverallHeight, IfcPositiveLengthMeasure OverallWidth, IfcWindowTypeEnum PredefinedType, IfcWindowTypePartitioningEnum PartitioningType, IfcLabel UserDefinedPartitioningType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.OverallHeight = OverallHeight;
			this.OverallWidth = OverallWidth;
			this.PredefinedType = PredefinedType;
			this.PartitioningType = PartitioningType;
			this.UserDefinedPartitioningType = UserDefinedPartitioningType;
		}
	}

	public class IfcWindowLiningProperties : IfcPreDefinedPropertySet
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	LiningDepth : IfcPositiveLengthMeasure
		//6	LiningThickness : IfcNonNegativeLengthMeasure
		//7	TransomThickness : IfcNonNegativeLengthMeasure
		//8	MullionThickness : IfcNonNegativeLengthMeasure
		//9	FirstTransomOffset : IfcNormalisedRatioMeasure
		//10	SecondTransomOffset : IfcNormalisedRatioMeasure
		//11	FirstMullionOffset : IfcNormalisedRatioMeasure
		//12	SecondMullionOffset : IfcNormalisedRatioMeasure
		//13	ShapeAspectStyle : IfcShapeAspect
		//14	LiningOffset : IfcLengthMeasure
		//15	LiningToPanelOffsetX : IfcLengthMeasure
		//16	LiningToPanelOffsetY : IfcLengthMeasure

		public IfcPositiveLengthMeasure LiningDepth { get; set; }
		public IfcNonNegativeLengthMeasure LiningThickness { get; set; }
		public IfcNonNegativeLengthMeasure TransomThickness { get; set; }
		public IfcNonNegativeLengthMeasure MullionThickness { get; set; }
		public IfcNormalisedRatioMeasure FirstTransomOffset { get; set; }
		public IfcNormalisedRatioMeasure SecondTransomOffset { get; set; }
		public IfcNormalisedRatioMeasure FirstMullionOffset { get; set; }
		public IfcNormalisedRatioMeasure SecondMullionOffset { get; set; }
		public IfcShapeAspect ShapeAspectStyle { get; set; }
		public IfcLengthMeasure LiningOffset { get; set; }
		public IfcLengthMeasure LiningToPanelOffsetX { get; set; }
		public IfcLengthMeasure LiningToPanelOffsetY { get; set; }

		public IfcWindowLiningProperties() { }

		public IfcWindowLiningProperties(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcPositiveLengthMeasure LiningDepth, IfcNonNegativeLengthMeasure LiningThickness, IfcNonNegativeLengthMeasure TransomThickness, IfcNonNegativeLengthMeasure MullionThickness, IfcNormalisedRatioMeasure FirstTransomOffset, IfcNormalisedRatioMeasure SecondTransomOffset, IfcNormalisedRatioMeasure FirstMullionOffset, IfcNormalisedRatioMeasure SecondMullionOffset, IfcShapeAspect ShapeAspectStyle, IfcLengthMeasure LiningOffset, IfcLengthMeasure LiningToPanelOffsetX, IfcLengthMeasure LiningToPanelOffsetY)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.LiningDepth = LiningDepth;
			this.LiningThickness = LiningThickness;
			this.TransomThickness = TransomThickness;
			this.MullionThickness = MullionThickness;
			this.FirstTransomOffset = FirstTransomOffset;
			this.SecondTransomOffset = SecondTransomOffset;
			this.FirstMullionOffset = FirstMullionOffset;
			this.SecondMullionOffset = SecondMullionOffset;
			this.ShapeAspectStyle = ShapeAspectStyle;
			this.LiningOffset = LiningOffset;
			this.LiningToPanelOffsetX = LiningToPanelOffsetX;
			this.LiningToPanelOffsetY = LiningToPanelOffsetY;
		}
	}

	public class IfcWindowPanelProperties : IfcPreDefinedPropertySet
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	OperationType : IfcWindowPanelOperationEnum
		//6	PanelPosition : IfcWindowPanelPositionEnum
		//7	FrameDepth : IfcPositiveLengthMeasure
		//8	FrameThickness : IfcPositiveLengthMeasure
		//9	ShapeAspectStyle : IfcShapeAspect

		public IfcWindowPanelOperationEnum OperationType { get; set; }
		public IfcWindowPanelPositionEnum PanelPosition { get; set; }
		public IfcPositiveLengthMeasure FrameDepth { get; set; }
		public IfcPositiveLengthMeasure FrameThickness { get; set; }
		public IfcShapeAspect ShapeAspectStyle { get; set; }

		public IfcWindowPanelProperties() { }

		public IfcWindowPanelProperties(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcWindowPanelOperationEnum OperationType, IfcWindowPanelPositionEnum PanelPosition, IfcPositiveLengthMeasure FrameDepth, IfcPositiveLengthMeasure FrameThickness, IfcShapeAspect ShapeAspectStyle)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.OperationType = OperationType;
			this.PanelPosition = PanelPosition;
			this.FrameDepth = FrameDepth;
			this.FrameThickness = FrameThickness;
			this.ShapeAspectStyle = ShapeAspectStyle;
		}
	}

	public class IfcWindowStandardCase : IfcWindow
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	ObjectPlacement : IfcObjectPlacement
		//7	Representation : IfcProductRepresentation
		//8	Tag : IfcIdentifier
		//9	OverallHeight : IfcPositiveLengthMeasure
		//10	OverallWidth : IfcPositiveLengthMeasure
		//11	PredefinedType : IfcWindowTypeEnum
		//12	PartitioningType : IfcWindowTypePartitioningEnum
		//13	UserDefinedPartitioningType : IfcLabel

		public IfcWindowStandardCase() { }

		public IfcWindowStandardCase(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcPositiveLengthMeasure OverallHeight, IfcPositiveLengthMeasure OverallWidth, IfcWindowTypeEnum PredefinedType, IfcWindowTypePartitioningEnum PartitioningType, IfcLabel UserDefinedPartitioningType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
			this.Tag = Tag;
			this.OverallHeight = OverallHeight;
			this.OverallWidth = OverallWidth;
			this.PredefinedType = PredefinedType;
			this.PartitioningType = PartitioningType;
			this.UserDefinedPartitioningType = UserDefinedPartitioningType;
		}
	}

	public class IfcWindowStyle : IfcTypeProduct
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ConstructionType : IfcWindowStyleConstructionEnum
		//10	OperationType : IfcWindowStyleOperationEnum
		//11	ParameterTakesPrecedence : IfcBoolean
		//12	Sizeable : IfcBoolean

		public IfcWindowStyleConstructionEnum ConstructionType { get; set; }
		public IfcWindowStyleOperationEnum OperationType { get; set; }
		public IfcBoolean ParameterTakesPrecedence { get; set; }
		public IfcBoolean Sizeable { get; set; }

		public IfcWindowStyle() { }

		public IfcWindowStyle(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcWindowStyleConstructionEnum ConstructionType, IfcWindowStyleOperationEnum OperationType, IfcBoolean ParameterTakesPrecedence, IfcBoolean Sizeable)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ConstructionType = ConstructionType;
			this.OperationType = OperationType;
			this.ParameterTakesPrecedence = ParameterTakesPrecedence;
			this.Sizeable = Sizeable;
		}
	}

	public class IfcWindowType : IfcBuildingElementType
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ApplicableOccurrence : IfcIdentifier
		//6	HasPropertySets : List<IfcPropertySetDefinition>
		//7	RepresentationMaps : List<IfcRepresentationMap>
		//8	Tag : IfcLabel
		//9	ElementType : IfcLabel
		//10	PredefinedType : IfcWindowTypeEnum
		//11	PartitioningType : IfcWindowTypePartitioningEnum
		//12	ParameterTakesPrecedence : IfcBoolean
		//13	UserDefinedPartitioningType : IfcLabel

		public IfcWindowTypeEnum PredefinedType { get; set; }
		public IfcWindowTypePartitioningEnum PartitioningType { get; set; }
		public IfcBoolean ParameterTakesPrecedence { get; set; }
		public IfcLabel UserDefinedPartitioningType { get; set; }

		public IfcWindowType() { }

		public IfcWindowType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcIdentifier ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, List<IfcRepresentationMap> RepresentationMaps, IfcLabel Tag, IfcLabel ElementType, IfcWindowTypeEnum PredefinedType, IfcWindowTypePartitioningEnum PartitioningType, IfcBoolean ParameterTakesPrecedence, IfcLabel UserDefinedPartitioningType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
			this.RepresentationMaps = RepresentationMaps;
			this.Tag = Tag;
			this.ElementType = ElementType;
			this.PredefinedType = PredefinedType;
			this.PartitioningType = PartitioningType;
			this.ParameterTakesPrecedence = ParameterTakesPrecedence;
			this.UserDefinedPartitioningType = UserDefinedPartitioningType;
		}
	}

	public class IfcWorkCalendar : IfcControl
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	Identification : IfcIdentifier
		//7	WorkingTimes : List<IfcWorkTime>
		//8	ExceptionTimes : List<IfcWorkTime>
		//9	PredefinedType : IfcWorkCalendarTypeEnum

		public List<IfcWorkTime> WorkingTimes { get; set; }
		public List<IfcWorkTime> ExceptionTimes { get; set; }
		public IfcWorkCalendarTypeEnum PredefinedType { get; set; }

		public IfcWorkCalendar() { }

		public IfcWorkCalendar(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcIdentifier Identification, List<IfcWorkTime> WorkingTimes, List<IfcWorkTime> ExceptionTimes, IfcWorkCalendarTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.Identification = Identification;
			this.WorkingTimes = WorkingTimes;
			this.ExceptionTimes = ExceptionTimes;
			this.PredefinedType = PredefinedType;
		}
	}

	public abstract class IfcWorkControl : IfcControl
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	Identification : IfcIdentifier
		//7	CreationDate : IfcDateTime
		//8	Creators : List<IfcPerson>
		//9	Purpose : IfcLabel
		//10	Duration : IfcDuration
		//11	TotalFloat : IfcDuration
		//12	StartTime : IfcDateTime
		//13	FinishTime : IfcDateTime

		public IfcDateTime CreationDate { get; set; }
		public List<IfcPerson> Creators { get; set; }
		public IfcLabel Purpose { get; set; }
		public IfcDuration Duration { get; set; }
		public IfcDuration TotalFloat { get; set; }
		public IfcDateTime StartTime { get; set; }
		public IfcDateTime FinishTime { get; set; }

		public IfcWorkControl() { }

		public IfcWorkControl(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcIdentifier Identification, IfcDateTime CreationDate, List<IfcPerson> Creators, IfcLabel Purpose, IfcDuration Duration, IfcDuration TotalFloat, IfcDateTime StartTime, IfcDateTime FinishTime)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.Identification = Identification;
			this.CreationDate = CreationDate;
			this.Creators = Creators;
			this.Purpose = Purpose;
			this.Duration = Duration;
			this.TotalFloat = TotalFloat;
			this.StartTime = StartTime;
			this.FinishTime = FinishTime;
		}
	}

	public class IfcWorkPlan : IfcWorkControl
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	Identification : IfcIdentifier
		//7	CreationDate : IfcDateTime
		//8	Creators : List<IfcPerson>
		//9	Purpose : IfcLabel
		//10	Duration : IfcDuration
		//11	TotalFloat : IfcDuration
		//12	StartTime : IfcDateTime
		//13	FinishTime : IfcDateTime
		//14	PredefinedType : IfcWorkPlanTypeEnum

		public IfcWorkPlanTypeEnum PredefinedType { get; set; }

		public IfcWorkPlan() { }

		public IfcWorkPlan(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcIdentifier Identification, IfcDateTime CreationDate, List<IfcPerson> Creators, IfcLabel Purpose, IfcDuration Duration, IfcDuration TotalFloat, IfcDateTime StartTime, IfcDateTime FinishTime, IfcWorkPlanTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.Identification = Identification;
			this.CreationDate = CreationDate;
			this.Creators = Creators;
			this.Purpose = Purpose;
			this.Duration = Duration;
			this.TotalFloat = TotalFloat;
			this.StartTime = StartTime;
			this.FinishTime = FinishTime;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcWorkSchedule : IfcWorkControl
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	Identification : IfcIdentifier
		//7	CreationDate : IfcDateTime
		//8	Creators : List<IfcPerson>
		//9	Purpose : IfcLabel
		//10	Duration : IfcDuration
		//11	TotalFloat : IfcDuration
		//12	StartTime : IfcDateTime
		//13	FinishTime : IfcDateTime
		//14	PredefinedType : IfcWorkScheduleTypeEnum

		public IfcWorkScheduleTypeEnum PredefinedType { get; set; }

		public IfcWorkSchedule() { }

		public IfcWorkSchedule(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcIdentifier Identification, IfcDateTime CreationDate, List<IfcPerson> Creators, IfcLabel Purpose, IfcDuration Duration, IfcDuration TotalFloat, IfcDateTime StartTime, IfcDateTime FinishTime, IfcWorkScheduleTypeEnum PredefinedType)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.Identification = Identification;
			this.CreationDate = CreationDate;
			this.Creators = Creators;
			this.Purpose = Purpose;
			this.Duration = Duration;
			this.TotalFloat = TotalFloat;
			this.StartTime = StartTime;
			this.FinishTime = FinishTime;
			this.PredefinedType = PredefinedType;
		}
	}

	public class IfcWorkTime : IfcSchedulingTime
	{
		//1	Name : IfcLabel
		//2	DataOrigin : IfcDataOriginEnum
		//3	UserDefinedDataOrigin : IfcLabel
		//4	RecurrencePattern : IfcRecurrencePattern
		//5	Start : IfcDate
		//6	Finish : IfcDate

		public IfcRecurrencePattern RecurrencePattern { get; set; }
		public IfcDate Start { get; set; }
		public IfcDate Finish { get; set; }

		public IfcWorkTime() { }

		public IfcWorkTime(IfcLabel Name, IfcDataOriginEnum DataOrigin, IfcLabel UserDefinedDataOrigin, IfcRecurrencePattern RecurrencePattern, IfcDate Start, IfcDate Finish)
		{
			this.Name = Name;
			this.DataOrigin = DataOrigin;
			this.UserDefinedDataOrigin = UserDefinedDataOrigin;
			this.RecurrencePattern = RecurrencePattern;
			this.Start = Start;
			this.Finish = Finish;
		}
	}

	public class IfcZShapeProfileDef : IfcParameterizedProfileDef
	{
		//1	ProfileType : IfcProfileTypeEnum
		//2	ProfileName : IfcLabel
		//3	Position : IfcAxis2Placement2D
		//4	Depth : IfcPositiveLengthMeasure
		//5	FlangeWidth : IfcPositiveLengthMeasure
		//6	WebThickness : IfcPositiveLengthMeasure
		//7	FlangeThickness : IfcPositiveLengthMeasure
		//8	FilletRadius : IfcNonNegativeLengthMeasure
		//9	EdgeRadius : IfcNonNegativeLengthMeasure

		public IfcPositiveLengthMeasure Depth { get; set; }
		public IfcPositiveLengthMeasure FlangeWidth { get; set; }
		public IfcPositiveLengthMeasure WebThickness { get; set; }
		public IfcPositiveLengthMeasure FlangeThickness { get; set; }
		public IfcNonNegativeLengthMeasure FilletRadius { get; set; }
		public IfcNonNegativeLengthMeasure EdgeRadius { get; set; }

		public IfcZShapeProfileDef() { }

		public IfcZShapeProfileDef(IfcProfileTypeEnum ProfileType, IfcLabel ProfileName, IfcAxis2Placement2D Position, IfcPositiveLengthMeasure Depth, IfcPositiveLengthMeasure FlangeWidth, IfcPositiveLengthMeasure WebThickness, IfcPositiveLengthMeasure FlangeThickness, IfcNonNegativeLengthMeasure FilletRadius, IfcNonNegativeLengthMeasure EdgeRadius)
		{
			this.ProfileType = ProfileType;
			this.ProfileName = ProfileName;
			this.Position = Position;
			this.Depth = Depth;
			this.FlangeWidth = FlangeWidth;
			this.WebThickness = WebThickness;
			this.FlangeThickness = FlangeThickness;
			this.FilletRadius = FilletRadius;
			this.EdgeRadius = EdgeRadius;
		}
	}

	public class IfcZone : IfcSystem
	{
		//1	GlobalId : IfcGloballyUniqueId
		//2	OwnerHistory : IfcOwnerHistory
		//3	Name : IfcLabel
		//4	Description : IfcText
		//5	ObjectType : IfcLabel
		//6	LongName : IfcLabel

		public IfcLabel LongName { get; set; }

		public IfcZone() { }

		public IfcZone(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcLabel LongName)
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
			this.ObjectType = ObjectType;
			this.LongName = LongName;
		}
	}

}
