using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IFC4
{
    class IfcDict:Dictionary<string,IfcBase>
    {
        public void ImportIFC(string path)
        {
            
            
            // read ifc file
            using (StreamReader reader = new StreamReader(path))
            {
                while (!(reader.ReadLine() == "DATA;") && !reader.EndOfStream)
                {
                    // text
                }

                string ifcText;
                while (!reader.EndOfStream)
                {
                    ifcText = reader.ReadLine();
                    if (ifcText == "ENDSEC;") break;
                    ReadDataline(ifcText);
                }
                reader.Close();
            }

            // map ifcdata
            List<IfcBase> items = Values.ToList();
            Console.WriteLine("end reading");
            foreach (var item in items)
            {
                MapAandSetProperties(item);
            }
        }

        private void ReadDataline(string ifcText)
        {

            string[] leftright = ifcText.Split('=');
            string key = leftright[0];
            string data = leftright[1].Substring(1);
            int nameLenght = data.IndexOf('(');
            string name = data.Substring(0, nameLenght);
            string paraText = data.Substring(nameLenght + 1, data.Length - 3 - nameLenght);
            List<string> paramList = SplitParamText(paraText);
            IfcBase item = CreateNewInstant(name);
            item.textParameters = paramList;
            Add(key, item);
        }

        public List<PropertyInfo> GetProperyList(string name)
        {
            Console.WriteLine(name);
            List<PropertyInfo> propertyInfos = new List<PropertyInfo>();
            if (name == "IfcBase")
            {
                return propertyInfos;
            }
            Type objectType = Type.GetType(name);
            if (objectType.BaseType != null)
            {
                propertyInfos = GetProperyList(objectType.BaseType.Name);
            }
 
            propertyInfos.AddRange(objectType.GetProperties());
            return propertyInfos;
        }
        public void MapAandSetProperties(IfcBase item)
        {
            var textParameters = item.textParameters;
            var itemType = item.GetType();
            var constructors = itemType.GetConstructors();
        //    Console.WriteLine(itemType.Name);
            for (int i = 0; i < constructors.Length; i++)
            {
                var parameters = constructors[i].GetParameters();
                if(parameters.Length == textParameters.Count)
                {
                    for(int j = 0; j < textParameters.Count; j++)
                    {
                       // Console.WriteLine("\t" + j + ":\t" + parameters[j].Name + " = " + textParameters[j]);
                        var property= itemType.GetProperty(parameters[j].Name);
                        var value = GetInstance(textParameters[j], parameters[j].ParameterType);
                        property.SetValue(item, value);
                    }
                    break;
                }
            }
        //    Console.WriteLine();
        }



        private List<string> SplitParamText(string paramText)
        {
            List<string> outputText = new List<string>();
            int bracketCount = 0;
            bool readingString = false;
            char[] chars = paramText.ToCharArray();
            int n = chars.Length;
            char c;
            string scanningText = "";
            for (int i = 0; i < n; i++)
            {
                c = chars[i];
                if(c == '\'')
                {
                    readingString = !readingString; // toggle 
                    scanningText += c;
                }
                else if(!readingString && c == '(')
                {
                    if(bracketCount == 0)
                    {
                        scanningText += c;
                    }
                    bracketCount++;
                }
                else if (!readingString && c == ')')
                {
                    bracketCount--;
                    if (bracketCount == 0)
                    {
                        scanningText += c;
                    }
                }
                else if (!readingString && c == ',' && bracketCount == 0)
                {

                }
                else
                {
                    scanningText += c;
                }

                if(i == n -1 || (!readingString && c == ',' && bracketCount == 0))
                {
                    outputText.Add(scanningText);
                    scanningText = "";
                }
            }
            return outputText;
        }
        public T CastObject<T>(object input) {   
    return (T) input;   
}
        private dynamic GetInstance(string input, Type type)
        {
            if(input.Length == 0)
            {
                return null;
            }
            if (input == "*")
            {
                return null;
            }
            if (input == "$")
            {
                return CreateNewInstant(type.Name.ToUpper());
            }
            if(input.Substring(0, 1) == "'")
            {

                switch (type.Name)
                {
                    case "IfcDate": return (IfcDate)input.Substring(1, input.Length - 2);
                    case "IfcDateTime": return (IfcDateTime)input.Substring(1, input.Length - 2);
                    case "IfcDescriptiveMeasure": return (IfcDescriptiveMeasure)input.Substring(1, input.Length - 2);
                    case "IfcDuration": return (IfcDuration)input.Substring(1, input.Length - 2);
                    case "IfcFontStyle": return (IfcFontStyle)input.Substring(1, input.Length - 2);
                    case "IfcFontVariant": return (IfcFontVariant)input.Substring(1, input.Length - 2);
                    case "IfcFontWeight": return (IfcFontWeight)input.Substring(1, input.Length - 2);
                    case "IfcGloballyUniqueId": return (IfcGloballyUniqueId)input.Substring(1, input.Length - 2);
                    case "IfcIdentifier": return (IfcIdentifier)input.Substring(1, input.Length - 2);
                    case "IfcLabel": return (IfcLabel)input.Substring(1, input.Length - 2);
                    case "IfcPresentableText": return (IfcPresentableText)input.Substring(1, input.Length - 2);
                    case "IfcText": return (IfcText)input.Substring(1, input.Length - 2);
                    case "IfcTextAlignment": return (IfcTextAlignment)input.Substring(1, input.Length - 2);
                    case "IfcTextDecoration": return (IfcTextDecoration)input.Substring(1, input.Length - 2);
                    case "IfcTextFontName": return (IfcTextFontName)input.Substring(1, input.Length - 2);
                    case "IfcTextTransformation": return (IfcTextTransformation)input.Substring(1, input.Length - 2);
                    case "IfcTime": return (IfcTime)input.Substring(1, input.Length - 2);
                    case "IfcURIReference": return (IfcURIReference)input.Substring(1, input.Length - 2);
                }


            }
            
            if (input.Substring(0,1) == "#")
            {
                if(TryGetValue(input,out IfcBase value))
                {
                    return value;
                }
                else
                {
                    return null;
                }
                
            }
            if (input.Substring(0, 1) == "(")
            {
                var words = SplitParamText(input.Substring(1, input.Length - 2));

            }

            if (int.TryParse(input, out int result))
            {
                switch (type.Name)
                {
                    case "IfcAbsorbedDoseMeasure": return (IfcAbsorbedDoseMeasure)result;
                    case "IfcAccelerationMeasure": return (IfcAccelerationMeasure)result;
                    case "IfcAmountOfSubstanceMeasure": return (IfcAmountOfSubstanceMeasure)result;
                    case "IfcAngularVelocityMeasure": return (IfcAngularVelocityMeasure)result;
                 //   case "IfcArcIndex": return (IfcArcIndex)result;
                    case "IfcAreaDensityMeasure": return (IfcAreaDensityMeasure)result;
                    case "IfcAreaMeasure": return (IfcAreaMeasure)result;
                    case "IfcBinary": return (IfcBinary)result;
                 //   case "IfcBoolean": return (IfcBoolean)result;
                  //  case "IfcBoxAlignment": return (IfcBoxAlignment)result;
                    case "IfcCardinalPointReference": return (IfcCardinalPointReference)result;
                 //   case "IfcComplexNumber": return (IfcComplexNumber)result;
                 //   case "IfcCompoundPlaneAngleMeasure": return (IfcCompoundPlaneAngleMeasure)result;
                    case "IfcContextDependentMeasure": return (IfcContextDependentMeasure)result;
                    case "IfcCountMeasure": return (IfcCountMeasure)result;
                    case "IfcCurvatureMeasure": return (IfcCurvatureMeasure)result;
                    case "IfcDayInMonthNumber": return (IfcDayInMonthNumber)result;
                    case "IfcDayInWeekNumber": return (IfcDayInWeekNumber)result;
                    case "IfcDimensionCount": return (IfcDimensionCount)result;
                    case "IfcDoseEquivalentMeasure": return (IfcDoseEquivalentMeasure)result;
                    case "IfcDynamicViscosityMeasure": return (IfcDynamicViscosityMeasure)result;
                    case "IfcElectricCapacitanceMeasure": return (IfcElectricCapacitanceMeasure)result;
                    case "IfcElectricChargeMeasure": return (IfcElectricChargeMeasure)result;
                    case "IfcElectricConductanceMeasure": return (IfcElectricConductanceMeasure)result;
                    case "IfcElectricCurrentMeasure": return (IfcElectricCurrentMeasure)result;
                    case "IfcElectricResistanceMeasure": return (IfcElectricResistanceMeasure)result;
                    case "IfcElectricVoltageMeasure": return (IfcElectricVoltageMeasure)result;
                    case "IfcEnergyMeasure": return (IfcEnergyMeasure)result;
                    case "IfcForceMeasure": return (IfcForceMeasure)result;
                    case "IfcFrequencyMeasure": return (IfcFrequencyMeasure)result;
                    case "IfcHeatFluxDensityMeasure": return (IfcHeatFluxDensityMeasure)result;
                    case "IfcHeatingValueMeasure": return (IfcHeatingValueMeasure)result;
                    case "IfcIlluminanceMeasure": return (IfcIlluminanceMeasure)result;
                    case "IfcInductanceMeasure": return (IfcInductanceMeasure)result;
                    case "IfcInteger": return (IfcInteger)result;
                    case "IfcIntegerCountRateMeasure": return (IfcIntegerCountRateMeasure)result;
                    case "IfcIonConcentrationMeasure": return (IfcIonConcentrationMeasure)result;
                    case "IfcIsothermalMoistureCapacityMeasure": return (IfcIsothermalMoistureCapacityMeasure)result;
                    case "IfcKinematicViscosityMeasure": return (IfcKinematicViscosityMeasure)result;
                  //  case "IfcLanguageId": return (IfcLanguageId)result;
                    case "IfcLengthMeasure": return (IfcLengthMeasure)result;
                   // case "IfcLineIndex": return (IfcLineIndex)result;
                    case "IfcLinearForceMeasure": return (IfcLinearForceMeasure)result;
                    case "IfcLinearMomentMeasure": return (IfcLinearMomentMeasure)result;
                    case "IfcLinearStiffnessMeasure": return (IfcLinearStiffnessMeasure)result;
                    case "IfcLinearVelocityMeasure": return (IfcLinearVelocityMeasure)result;
                  //  case "IfcLogical": return (IfcLogical)result;
                    case "IfcLuminousFluxMeasure": return (IfcLuminousFluxMeasure)result;
                    case "IfcLuminousIntensityDistributionMeasure": return (IfcLuminousIntensityDistributionMeasure)result;
                    case "IfcLuminousIntensityMeasure": return (IfcLuminousIntensityMeasure)result;
                    case "IfcMagneticFluxDensityMeasure": return (IfcMagneticFluxDensityMeasure)result;
                    case "IfcMagneticFluxMeasure": return (IfcMagneticFluxMeasure)result;
                    case "IfcMassDensityMeasure": return (IfcMassDensityMeasure)result;
                    case "IfcMassFlowRateMeasure": return (IfcMassFlowRateMeasure)result;
                    case "IfcMassMeasure": return (IfcMassMeasure)result;
                    case "IfcMassPerLengthMeasure": return (IfcMassPerLengthMeasure)result;
                    case "IfcModulusOfElasticityMeasure": return (IfcModulusOfElasticityMeasure)result;
                    case "IfcModulusOfLinearSubgradeReactionMeasure": return (IfcModulusOfLinearSubgradeReactionMeasure)result;
                    case "IfcModulusOfRotationalSubgradeReactionMeasure": return (IfcModulusOfRotationalSubgradeReactionMeasure)result;
                    case "IfcModulusOfSubgradeReactionMeasure": return (IfcModulusOfSubgradeReactionMeasure)result;
                    case "IfcMoistureDiffusivityMeasure": return (IfcMoistureDiffusivityMeasure)result;
                    case "IfcMolecularWeightMeasure": return (IfcMolecularWeightMeasure)result;
                    case "IfcMomentOfInertiaMeasure": return (IfcMomentOfInertiaMeasure)result;
                    case "IfcMonetaryMeasure": return (IfcMonetaryMeasure)result;
                    case "IfcMonthInYearNumber": return (IfcMonthInYearNumber)result;
                    case "IfcNonNegativeLengthMeasure": return (IfcNonNegativeLengthMeasure)result;
                    case "IfcNormalisedRatioMeasure": return (IfcNormalisedRatioMeasure)result;
                    case "IfcNumericMeasure": return (IfcNumericMeasure)result;
                    case "IfcPHMeasure": return (IfcPHMeasure)result;
                    case "IfcParameterValue": return (IfcParameterValue)result;
                    case "IfcPlanarForceMeasure": return (IfcPlanarForceMeasure)result;
                    case "IfcPlaneAngleMeasure": return (IfcPlaneAngleMeasure)result;
                    case "IfcPositiveInteger": return (IfcPositiveInteger)result;
                    case "IfcPositiveLengthMeasure": return (IfcPositiveLengthMeasure)result;
                    case "IfcPositivePlaneAngleMeasure": return (IfcPositivePlaneAngleMeasure)result;
                    case "IfcPositiveRatioMeasure": return (IfcPositiveRatioMeasure)result;
                    case "IfcPowerMeasure": return (IfcPowerMeasure)result;
                    case "IfcPressureMeasure": return (IfcPressureMeasure)result;
                   // case "IfcPropertySetDefinitionSet": return (IfcPropertySetDefinitionSet)result;
                    case "IfcRadioActivityMeasure": return (IfcRadioActivityMeasure)result;
                    case "IfcRatioMeasure": return (IfcRatioMeasure)result;
                    case "IfcReal": return (IfcReal)result;
                    case "IfcRotationalFrequencyMeasure": return (IfcRotationalFrequencyMeasure)result;
                    case "IfcRotationalMassMeasure": return (IfcRotationalMassMeasure)result;
                    case "IfcRotationalStiffnessMeasure": return (IfcRotationalStiffnessMeasure)result;
                    case "IfcSectionModulusMeasure": return (IfcSectionModulusMeasure)result;
                    case "IfcSectionalAreaIntegralMeasure": return (IfcSectionalAreaIntegralMeasure)result;
                    case "IfcShearModulusMeasure": return (IfcShearModulusMeasure)result;
                    case "IfcSolidAngleMeasure": return (IfcSolidAngleMeasure)result;
                    case "IfcSoundPowerLevelMeasure": return (IfcSoundPowerLevelMeasure)result;
                    case "IfcSoundPowerMeasure": return (IfcSoundPowerMeasure)result;
                    case "IfcSoundPressureLevelMeasure": return (IfcSoundPressureLevelMeasure)result;
                    case "IfcSoundPressureMeasure": return (IfcSoundPressureMeasure)result;
                    case "IfcSpecificHeatCapacityMeasure": return (IfcSpecificHeatCapacityMeasure)result;
                    case "IfcSpecularExponent": return (IfcSpecularExponent)result;
                    case "IfcSpecularRoughness": return (IfcSpecularRoughness)result;
                    case "IfcTemperatureGradientMeasure": return (IfcTemperatureGradientMeasure)result;
                    case "IfcTemperatureRateOfChangeMeasure": return (IfcTemperatureRateOfChangeMeasure)result;
                    case "IfcThermalAdmittanceMeasure": return (IfcThermalAdmittanceMeasure)result;
                    case "IfcThermalConductivityMeasure": return (IfcThermalConductivityMeasure)result;
                    case "IfcThermalExpansionCoefficientMeasure": return (IfcThermalExpansionCoefficientMeasure)result;
                    case "IfcThermalResistanceMeasure": return (IfcThermalResistanceMeasure)result;
                    case "IfcThermalTransmittanceMeasure": return (IfcThermalTransmittanceMeasure)result;
                    case "IfcThermodynamicTemperatureMeasure": return (IfcThermodynamicTemperatureMeasure)result;
                    case "IfcTimeMeasure": return (IfcTimeMeasure)result;
                    case "IfcTimeStamp": return (IfcTimeStamp)result;
                    case "IfcTorqueMeasure": return (IfcTorqueMeasure)result;
                    case "IfcVaporPermeabilityMeasure": return (IfcVaporPermeabilityMeasure)result;
                    case "IfcVolumeMeasure": return (IfcVolumeMeasure)result;
                    case "IfcVolumetricFlowRateMeasure": return (IfcVolumetricFlowRateMeasure)result;
                    case "IfcWarpingConstantMeasure": return (IfcWarpingConstantMeasure)result;
                    case "IfcWarpingMomentMeasure": return (IfcWarpingMomentMeasure)result;
                  




                }
            }


            if (double.TryParse(input, out double result))
            {
                switch (type.Name)
                {
                    case "IfcAbsorbedDoseMeasure": return (IfcAbsorbedDoseMeasure)result;
                    case "IfcAccelerationMeasure": return (IfcAccelerationMeasure)result;
                    case "IfcAmountOfSubstanceMeasure": return (IfcAmountOfSubstanceMeasure)result;
                    case "IfcAngularVelocityMeasure": return (IfcAngularVelocityMeasure)result;
                    //   case "IfcArcIndex": return (IfcArcIndex)result;
                    case "IfcAreaDensityMeasure": return (IfcAreaDensityMeasure)result;
                    case "IfcAreaMeasure": return (IfcAreaMeasure)result;
                    case "IfcBinary": return (IfcBinary)result;
                    //   case "IfcBoolean": return (IfcBoolean)result;
                    //  case "IfcBoxAlignment": return (IfcBoxAlignment)result;
                    case "IfcCardinalPointReference": return (IfcCardinalPointReference)result;
                    //   case "IfcComplexNumber": return (IfcComplexNumber)result;
                    //   case "IfcCompoundPlaneAngleMeasure": return (IfcCompoundPlaneAngleMeasure)result;
                    case "IfcContextDependentMeasure": return (IfcContextDependentMeasure)result;
                    case "IfcCountMeasure": return (IfcCountMeasure)result;
                    case "IfcCurvatureMeasure": return (IfcCurvatureMeasure)result;
                    case "IfcDayInMonthNumber": return (IfcDayInMonthNumber)result;
                    case "IfcDayInWeekNumber": return (IfcDayInWeekNumber)result;
                    case "IfcDimensionCount": return (IfcDimensionCount)result;
                    case "IfcDoseEquivalentMeasure": return (IfcDoseEquivalentMeasure)result;
                    case "IfcDynamicViscosityMeasure": return (IfcDynamicViscosityMeasure)result;
                    case "IfcElectricCapacitanceMeasure": return (IfcElectricCapacitanceMeasure)result;
                    case "IfcElectricChargeMeasure": return (IfcElectricChargeMeasure)result;
                    case "IfcElectricConductanceMeasure": return (IfcElectricConductanceMeasure)result;
                    case "IfcElectricCurrentMeasure": return (IfcElectricCurrentMeasure)result;
                    case "IfcElectricResistanceMeasure": return (IfcElectricResistanceMeasure)result;
                    case "IfcElectricVoltageMeasure": return (IfcElectricVoltageMeasure)result;
                    case "IfcEnergyMeasure": return (IfcEnergyMeasure)result;
                    case "IfcForceMeasure": return (IfcForceMeasure)result;
                    case "IfcFrequencyMeasure": return (IfcFrequencyMeasure)result;
                    case "IfcHeatFluxDensityMeasure": return (IfcHeatFluxDensityMeasure)result;
                    case "IfcHeatingValueMeasure": return (IfcHeatingValueMeasure)result;
                    case "IfcIlluminanceMeasure": return (IfcIlluminanceMeasure)result;
                    case "IfcInductanceMeasure": return (IfcInductanceMeasure)result;
                    case "IfcInteger": return (IfcInteger)result;
                    case "IfcIntegerCountRateMeasure": return (IfcIntegerCountRateMeasure)result;
                    case "IfcIonConcentrationMeasure": return (IfcIonConcentrationMeasure)result;
                    case "IfcIsothermalMoistureCapacityMeasure": return (IfcIsothermalMoistureCapacityMeasure)result;
                    case "IfcKinematicViscosityMeasure": return (IfcKinematicViscosityMeasure)result;
                    //  case "IfcLanguageId": return (IfcLanguageId)result;
                    case "IfcLengthMeasure": return (IfcLengthMeasure)result;
                    // case "IfcLineIndex": return (IfcLineIndex)result;
                    case "IfcLinearForceMeasure": return (IfcLinearForceMeasure)result;
                    case "IfcLinearMomentMeasure": return (IfcLinearMomentMeasure)result;
                    case "IfcLinearStiffnessMeasure": return (IfcLinearStiffnessMeasure)result;
                    case "IfcLinearVelocityMeasure": return (IfcLinearVelocityMeasure)result;
                    //  case "IfcLogical": return (IfcLogical)result;
                    case "IfcLuminousFluxMeasure": return (IfcLuminousFluxMeasure)result;
                    case "IfcLuminousIntensityDistributionMeasure": return (IfcLuminousIntensityDistributionMeasure)result;
                    case "IfcLuminousIntensityMeasure": return (IfcLuminousIntensityMeasure)result;
                    case "IfcMagneticFluxDensityMeasure": return (IfcMagneticFluxDensityMeasure)result;
                    case "IfcMagneticFluxMeasure": return (IfcMagneticFluxMeasure)result;
                    case "IfcMassDensityMeasure": return (IfcMassDensityMeasure)result;
                    case "IfcMassFlowRateMeasure": return (IfcMassFlowRateMeasure)result;
                    case "IfcMassMeasure": return (IfcMassMeasure)result;
                    case "IfcMassPerLengthMeasure": return (IfcMassPerLengthMeasure)result;
                    case "IfcModulusOfElasticityMeasure": return (IfcModulusOfElasticityMeasure)result;
                    case "IfcModulusOfLinearSubgradeReactionMeasure": return (IfcModulusOfLinearSubgradeReactionMeasure)result;
                    case "IfcModulusOfRotationalSubgradeReactionMeasure": return (IfcModulusOfRotationalSubgradeReactionMeasure)result;
                    case "IfcModulusOfSubgradeReactionMeasure": return (IfcModulusOfSubgradeReactionMeasure)result;
                    case "IfcMoistureDiffusivityMeasure": return (IfcMoistureDiffusivityMeasure)result;
                    case "IfcMolecularWeightMeasure": return (IfcMolecularWeightMeasure)result;
                    case "IfcMomentOfInertiaMeasure": return (IfcMomentOfInertiaMeasure)result;
                    case "IfcMonetaryMeasure": return (IfcMonetaryMeasure)result;
                    case "IfcMonthInYearNumber": return (IfcMonthInYearNumber)result;
                    case "IfcNonNegativeLengthMeasure": return (IfcNonNegativeLengthMeasure)result;
                    case "IfcNormalisedRatioMeasure": return (IfcNormalisedRatioMeasure)result;
                    case "IfcNumericMeasure": return (IfcNumericMeasure)result;
                    case "IfcPHMeasure": return (IfcPHMeasure)result;
                    case "IfcParameterValue": return (IfcParameterValue)result;
                    case "IfcPlanarForceMeasure": return (IfcPlanarForceMeasure)result;
                    case "IfcPlaneAngleMeasure": return (IfcPlaneAngleMeasure)result;
                    case "IfcPositiveInteger": return (IfcPositiveInteger)result;
                    case "IfcPositiveLengthMeasure": return (IfcPositiveLengthMeasure)result;
                    case "IfcPositivePlaneAngleMeasure": return (IfcPositivePlaneAngleMeasure)result;
                    case "IfcPositiveRatioMeasure": return (IfcPositiveRatioMeasure)result;
                    case "IfcPowerMeasure": return (IfcPowerMeasure)result;
                    case "IfcPressureMeasure": return (IfcPressureMeasure)result;
                    // case "IfcPropertySetDefinitionSet": return (IfcPropertySetDefinitionSet)result;
                    case "IfcRadioActivityMeasure": return (IfcRadioActivityMeasure)result;
                    case "IfcRatioMeasure": return (IfcRatioMeasure)result;
                    case "IfcReal": return (IfcReal)result;
                    case "IfcRotationalFrequencyMeasure": return (IfcRotationalFrequencyMeasure)result;
                    case "IfcRotationalMassMeasure": return (IfcRotationalMassMeasure)result;
                    case "IfcRotationalStiffnessMeasure": return (IfcRotationalStiffnessMeasure)result;
                    case "IfcSectionModulusMeasure": return (IfcSectionModulusMeasure)result;
                    case "IfcSectionalAreaIntegralMeasure": return (IfcSectionalAreaIntegralMeasure)result;
                    case "IfcShearModulusMeasure": return (IfcShearModulusMeasure)result;
                    case "IfcSolidAngleMeasure": return (IfcSolidAngleMeasure)result;
                    case "IfcSoundPowerLevelMeasure": return (IfcSoundPowerLevelMeasure)result;
                    case "IfcSoundPowerMeasure": return (IfcSoundPowerMeasure)result;
                    case "IfcSoundPressureLevelMeasure": return (IfcSoundPressureLevelMeasure)result;
                    case "IfcSoundPressureMeasure": return (IfcSoundPressureMeasure)result;
                    case "IfcSpecificHeatCapacityMeasure": return (IfcSpecificHeatCapacityMeasure)result;
                    case "IfcSpecularExponent": return (IfcSpecularExponent)result;
                    case "IfcSpecularRoughness": return (IfcSpecularRoughness)result;
                    case "IfcTemperatureGradientMeasure": return (IfcTemperatureGradientMeasure)result;
                    case "IfcTemperatureRateOfChangeMeasure": return (IfcTemperatureRateOfChangeMeasure)result;
                    case "IfcThermalAdmittanceMeasure": return (IfcThermalAdmittanceMeasure)result;
                    case "IfcThermalConductivityMeasure": return (IfcThermalConductivityMeasure)result;
                    case "IfcThermalExpansionCoefficientMeasure": return (IfcThermalExpansionCoefficientMeasure)result;
                    case "IfcThermalResistanceMeasure": return (IfcThermalResistanceMeasure)result;
                    case "IfcThermalTransmittanceMeasure": return (IfcThermalTransmittanceMeasure)result;
                    case "IfcThermodynamicTemperatureMeasure": return (IfcThermodynamicTemperatureMeasure)result;
                    case "IfcTimeMeasure": return (IfcTimeMeasure)result;
                    case "IfcTimeStamp": return (IfcTimeStamp)result;
                    case "IfcTorqueMeasure": return (IfcTorqueMeasure)result;
                    case "IfcVaporPermeabilityMeasure": return (IfcVaporPermeabilityMeasure)result;
                    case "IfcVolumeMeasure": return (IfcVolumeMeasure)result;
                    case "IfcVolumetricFlowRateMeasure": return (IfcVolumetricFlowRateMeasure)result;
                    case "IfcWarpingConstantMeasure": return (IfcWarpingConstantMeasure)result;
                    case "IfcWarpingMomentMeasure": return (IfcWarpingMomentMeasure)result;





                }
            }

            return null;
        }

        private IfcBase CreateNewInstant(string name)
        {
            switch (name)
            {    
                case "IFCACTIONREQUEST":
                    return new IfcActionRequest();
                case "IFCACTOR":
                    return new IfcActor();
                case "IFCACTORROLE":
                    return new IfcActorRole();
                case "IFCACTUATOR":
                    return new IfcActuator();
                case "IFCACTUATORTYPE":
                    return new IfcActuatorType();
                case "IFCADVANCEDBREP":
                    return new IfcAdvancedBrep();
                case "IFCADVANCEDBREPWITHVOIDS":
                    return new IfcAdvancedBrepWithVoids();
                case "IFCADVANCEDFACE":
                    return new IfcAdvancedFace();
                case "IFCAIRTERMINAL":
                    return new IfcAirTerminal();
                case "IFCAIRTERMINALBOX":
                    return new IfcAirTerminalBox();
                case "IFCAIRTERMINALBOXTYPE":
                    return new IfcAirTerminalBoxType();
                case "IFCAIRTERMINALTYPE":
                    return new IfcAirTerminalType();
                case "IFCAIRTOAIRHEATRECOVERY":
                    return new IfcAirToAirHeatRecovery();
                case "IFCAIRTOAIRHEATRECOVERYTYPE":
                    return new IfcAirToAirHeatRecoveryType();
                case "IFCALARM":
                    return new IfcAlarm();
                case "IFCALARMTYPE":
                    return new IfcAlarmType();
                case "IFCANNOTATION":
                    return new IfcAnnotation();
                case "IFCANNOTATIONFILLAREA":
                    return new IfcAnnotationFillArea();
                case "IFCAPPLICATION":
                    return new IfcApplication();
                case "IFCAPPLIEDVALUE":
                    return new IfcAppliedValue();
                case "IFCAPPROVAL":
                    return new IfcApproval();
                case "IFCAPPROVALRELATIONSHIP":
                    return new IfcApprovalRelationship();
                case "IFCARBITRARYCLOSEDPROFILEDEF":
                    return new IfcArbitraryClosedProfileDef();
                case "IFCARBITRARYOPENPROFILEDEF":
                    return new IfcArbitraryOpenProfileDef();
                case "IFCARBITRARYPROFILEDEFWITHVOIDS":
                    return new IfcArbitraryProfileDefWithVoids();
                case "IFCASSET":
                    return new IfcAsset();
                case "IFCASYMMETRICISHAPEPROFILEDEF":
                    return new IfcAsymmetricIShapeProfileDef();
                case "IFCAUDIOVISUALAPPLIANCE":
                    return new IfcAudioVisualAppliance();
                case "IFCAUDIOVISUALAPPLIANCETYPE":
                    return new IfcAudioVisualApplianceType();
                case "IFCAXIS1PLACEMENT":
                    return new IfcAxis1Placement();
                case "IFCAXIS2PLACEMENT2D":
                    return new IfcAxis2Placement2D();
                case "IFCAXIS2PLACEMENT3D":
                    return new IfcAxis2Placement3D();
                case "IFCBSPLINECURVEWITHKNOTS":
                    return new IfcBSplineCurveWithKnots();
                case "IFCBSPLINESURFACEWITHKNOTS":
                    return new IfcBSplineSurfaceWithKnots();
                case "IFCBEAM":
                    return new IfcBeam();
                case "IFCBEAMSTANDARDCASE":
                    return new IfcBeamStandardCase();
                case "IFCBEAMTYPE":
                    return new IfcBeamType();
                case "IFCBLOBTEXTURE":
                    return new IfcBlobTexture();
                case "IFCBLOCK":
                    return new IfcBlock();
                case "IFCBOILER":
                    return new IfcBoiler();
                case "IFCBOILERTYPE":
                    return new IfcBoilerType();
                case "IFCBOOLEANCLIPPINGRESULT":
                    return new IfcBooleanClippingResult();
                case "IFCBOOLEANRESULT":
                    return new IfcBooleanResult();
                case "IFCBOUNDARYCURVE":
                    return new IfcBoundaryCurve();
                case "IFCBOUNDARYEDGECONDITION":
                    return new IfcBoundaryEdgeCondition();
                case "IFCBOUNDARYFACECONDITION":
                    return new IfcBoundaryFaceCondition();
                case "IFCBOUNDARYNODECONDITION":
                    return new IfcBoundaryNodeCondition();
                case "IFCBOUNDARYNODECONDITIONWARPING":
                    return new IfcBoundaryNodeConditionWarping();
                case "IFCBOUNDINGBOX":
                    return new IfcBoundingBox();
                case "IFCBOXEDHALFSPACE":
                    return new IfcBoxedHalfSpace();
                case "IFCBUILDING":
                    return new IfcBuilding();
                case "IFCBUILDINGELEMENTPART":
                    return new IfcBuildingElementPart();
                case "IFCBUILDINGELEMENTPARTTYPE":
                    return new IfcBuildingElementPartType();
                case "IFCBUILDINGELEMENTPROXY":
                    return new IfcBuildingElementProxy();
                case "IFCBUILDINGELEMENTPROXYTYPE":
                    return new IfcBuildingElementProxyType();
                case "IFCBUILDINGSTOREY":
                    return new IfcBuildingStorey();
                case "IFCBUILDINGSYSTEM":
                    return new IfcBuildingSystem();
                case "IFCBURNER":
                    return new IfcBurner();
                case "IFCBURNERTYPE":
                    return new IfcBurnerType();
                case "IFCCSHAPEPROFILEDEF":
                    return new IfcCShapeProfileDef();
                case "IFCCABLECARRIERFITTING":
                    return new IfcCableCarrierFitting();
                case "IFCCABLECARRIERFITTINGTYPE":
                    return new IfcCableCarrierFittingType();
                case "IFCCABLECARRIERSEGMENT":
                    return new IfcCableCarrierSegment();
                case "IFCCABLECARRIERSEGMENTTYPE":
                    return new IfcCableCarrierSegmentType();
                case "IFCCABLEFITTING":
                    return new IfcCableFitting();
                case "IFCCABLEFITTINGTYPE":
                    return new IfcCableFittingType();
                case "IFCCABLESEGMENT":
                    return new IfcCableSegment();
                case "IFCCABLESEGMENTTYPE":
                    return new IfcCableSegmentType();
                case "IFCCARTESIANPOINT":
                    return new IfcCartesianPoint();
                case "IFCCARTESIANPOINTLIST2D":
                    return new IfcCartesianPointList2D();
                case "IFCCARTESIANPOINTLIST3D":
                    return new IfcCartesianPointList3D();
                case "IFCCARTESIANTRANSFORMATIONOPERATOR2D":
                    return new IfcCartesianTransformationOperator2D();
                case "IFCCARTESIANTRANSFORMATIONOPERATOR2DNONUNIFORM":
                    return new IfcCartesianTransformationOperator2DnonUniform();
                case "IFCCARTESIANTRANSFORMATIONOPERATOR3D":
                    return new IfcCartesianTransformationOperator3D();
                case "IFCCARTESIANTRANSFORMATIONOPERATOR3DNONUNIFORM":
                    return new IfcCartesianTransformationOperator3DnonUniform();
                case "IFCCENTERLINEPROFILEDEF":
                    return new IfcCenterLineProfileDef();
                case "IFCCHILLER":
                    return new IfcChiller();
                case "IFCCHILLERTYPE":
                    return new IfcChillerType();
                case "IFCCHIMNEY":
                    return new IfcChimney();
                case "IFCCHIMNEYTYPE":
                    return new IfcChimneyType();
                case "IFCCIRCLE":
                    return new IfcCircle();
                case "IFCCIRCLEHOLLOWPROFILEDEF":
                    return new IfcCircleHollowProfileDef();
                case "IFCCIRCLEPROFILEDEF":
                    return new IfcCircleProfileDef();
                case "IFCCIVILELEMENT":
                    return new IfcCivilElement();
                case "IFCCIVILELEMENTTYPE":
                    return new IfcCivilElementType();
                case "IFCCLASSIFICATION":
                    return new IfcClassification();
                case "IFCCLASSIFICATIONREFERENCE":
                    return new IfcClassificationReference();
                case "IFCCLOSEDSHELL":
                    return new IfcClosedShell();
                case "IFCCOIL":
                    return new IfcCoil();
                case "IFCCOILTYPE":
                    return new IfcCoilType();
                case "IFCCOLOURRGB":
                    return new IfcColourRgb();
                case "IFCCOLOURRGBLIST":
                    return new IfcColourRgbList();
                case "IFCCOLUMN":
                    return new IfcColumn();
                case "IFCCOLUMNSTANDARDCASE":
                    return new IfcColumnStandardCase();
                case "IFCCOLUMNTYPE":
                    return new IfcColumnType();
                case "IFCCOMMUNICATIONSAPPLIANCE":
                    return new IfcCommunicationsAppliance();
                case "IFCCOMMUNICATIONSAPPLIANCETYPE":
                    return new IfcCommunicationsApplianceType();
                case "IFCCOMPLEXPROPERTY":
                    return new IfcComplexProperty();
                case "IFCCOMPLEXPROPERTYTEMPLATE":
                    return new IfcComplexPropertyTemplate();
                case "IFCCOMPOSITECURVE":
                    return new IfcCompositeCurve();
                case "IFCCOMPOSITECURVEONSURFACE":
                    return new IfcCompositeCurveOnSurface();
                case "IFCCOMPOSITECURVESEGMENT":
                    return new IfcCompositeCurveSegment();
                case "IFCCOMPOSITEPROFILEDEF":
                    return new IfcCompositeProfileDef();
                case "IFCCOMPRESSOR":
                    return new IfcCompressor();
                case "IFCCOMPRESSORTYPE":
                    return new IfcCompressorType();
                case "IFCCONDENSER":
                    return new IfcCondenser();
                case "IFCCONDENSERTYPE":
                    return new IfcCondenserType();
                case "IFCCONNECTEDFACESET":
                    return new IfcConnectedFaceSet();
                case "IFCCONNECTIONCURVEGEOMETRY":
                    return new IfcConnectionCurveGeometry();
                case "IFCCONNECTIONPOINTECCENTRICITY":
                    return new IfcConnectionPointEccentricity();
                case "IFCCONNECTIONPOINTGEOMETRY":
                    return new IfcConnectionPointGeometry();
                case "IFCCONNECTIONSURFACEGEOMETRY":
                    return new IfcConnectionSurfaceGeometry();
                case "IFCCONNECTIONVOLUMEGEOMETRY":
                    return new IfcConnectionVolumeGeometry();
                case "IFCCONSTRUCTIONEQUIPMENTRESOURCE":
                    return new IfcConstructionEquipmentResource();
                case "IFCCONSTRUCTIONEQUIPMENTRESOURCETYPE":
                    return new IfcConstructionEquipmentResourceType();
                case "IFCCONSTRUCTIONMATERIALRESOURCE":
                    return new IfcConstructionMaterialResource();
                case "IFCCONSTRUCTIONMATERIALRESOURCETYPE":
                    return new IfcConstructionMaterialResourceType();
                case "IFCCONSTRUCTIONPRODUCTRESOURCE":
                    return new IfcConstructionProductResource();
                case "IFCCONSTRUCTIONPRODUCTRESOURCETYPE":
                    return new IfcConstructionProductResourceType();
                case "IFCCONTEXTDEPENDENTUNIT":
                    return new IfcContextDependentUnit();
                case "IFCCONTROLLER":
                    return new IfcController();
                case "IFCCONTROLLERTYPE":
                    return new IfcControllerType();
                case "IFCCONVERSIONBASEDUNIT":
                    return new IfcConversionBasedUnit();
                case "IFCCONVERSIONBASEDUNITWITHOFFSET":
                    return new IfcConversionBasedUnitWithOffset();
                case "IFCCOOLEDBEAM":
                    return new IfcCooledBeam();
                case "IFCCOOLEDBEAMTYPE":
                    return new IfcCooledBeamType();
                case "IFCCOOLINGTOWER":
                    return new IfcCoolingTower();
                case "IFCCOOLINGTOWERTYPE":
                    return new IfcCoolingTowerType();
                case "IFCCOSTITEM":
                    return new IfcCostItem();
                case "IFCCOSTSCHEDULE":
                    return new IfcCostSchedule();
                case "IFCCOSTVALUE":
                    return new IfcCostValue();
                case "IFCCOVERING":
                    return new IfcCovering();
                case "IFCCOVERINGTYPE":
                    return new IfcCoveringType();
                case "IFCCREWRESOURCE":
                    return new IfcCrewResource();
                case "IFCCREWRESOURCETYPE":
                    return new IfcCrewResourceType();
                case "IFCCSGSOLID":
                    return new IfcCsgSolid();
                case "IFCCURRENCYRELATIONSHIP":
                    return new IfcCurrencyRelationship();
                case "IFCCURTAINWALL":
                    return new IfcCurtainWall();
                case "IFCCURTAINWALLTYPE":
                    return new IfcCurtainWallType();
                case "IFCCURVEBOUNDEDPLANE":
                    return new IfcCurveBoundedPlane();
                case "IFCCURVEBOUNDEDSURFACE":
                    return new IfcCurveBoundedSurface();
                case "IFCCURVESTYLE":
                    return new IfcCurveStyle();
                case "IFCCURVESTYLEFONT":
                    return new IfcCurveStyleFont();
                case "IFCCURVESTYLEFONTANDSCALING":
                    return new IfcCurveStyleFontAndScaling();
                case "IFCCURVESTYLEFONTPATTERN":
                    return new IfcCurveStyleFontPattern();
                case "IFCCYLINDRICALSURFACE":
                    return new IfcCylindricalSurface();
                case "IFCDAMPER":
                    return new IfcDamper();
                case "IFCDAMPERTYPE":
                    return new IfcDamperType();
                case "IFCDERIVEDPROFILEDEF":
                    return new IfcDerivedProfileDef();
                case "IFCDERIVEDUNIT":
                    return new IfcDerivedUnit();
                case "IFCDERIVEDUNITELEMENT":
                    return new IfcDerivedUnitElement();
                case "IFCDIMENSIONALEXPONENTS":
                    return new IfcDimensionalExponents();
                case "IFCDIRECTION":
                    return new IfcDirection();
                case "IFCDISCRETEACCESSORY":
                    return new IfcDiscreteAccessory();
                case "IFCDISCRETEACCESSORYTYPE":
                    return new IfcDiscreteAccessoryType();
                case "IFCDISTRIBUTIONCHAMBERELEMENT":
                    return new IfcDistributionChamberElement();
                case "IFCDISTRIBUTIONCHAMBERELEMENTTYPE":
                    return new IfcDistributionChamberElementType();
                case "IFCDISTRIBUTIONCIRCUIT":
                    return new IfcDistributionCircuit();
                case "IFCDISTRIBUTIONCONTROLELEMENT":
                    return new IfcDistributionControlElement();
                case "IFCDISTRIBUTIONELEMENT":
                    return new IfcDistributionElement();
                case "IFCDISTRIBUTIONELEMENTTYPE":
                    return new IfcDistributionElementType();
                case "IFCDISTRIBUTIONFLOWELEMENT":
                    return new IfcDistributionFlowElement();
                case "IFCDISTRIBUTIONPORT":
                    return new IfcDistributionPort();
                case "IFCDISTRIBUTIONSYSTEM":
                    return new IfcDistributionSystem();
                case "IFCDOCUMENTINFORMATION":
                    return new IfcDocumentInformation();
                case "IFCDOCUMENTINFORMATIONRELATIONSHIP":
                    return new IfcDocumentInformationRelationship();
                case "IFCDOCUMENTREFERENCE":
                    return new IfcDocumentReference();
                case "IFCDOOR":
                    return new IfcDoor();
                case "IFCDOORLININGPROPERTIES":
                    return new IfcDoorLiningProperties();
                case "IFCDOORPANELPROPERTIES":
                    return new IfcDoorPanelProperties();
                case "IFCDOORSTANDARDCASE":
                    return new IfcDoorStandardCase();
                case "IFCDOORSTYLE":
                    return new IfcDoorStyle();
                case "IFCDOORTYPE":
                    return new IfcDoorType();
                case "IFCDRAUGHTINGPREDEFINEDCOLOUR":
                    return new IfcDraughtingPreDefinedColour();
                case "IFCDRAUGHTINGPREDEFINEDCURVEFONT":
                    return new IfcDraughtingPreDefinedCurveFont();
                case "IFCDUCTFITTING":
                    return new IfcDuctFitting();
                case "IFCDUCTFITTINGTYPE":
                    return new IfcDuctFittingType();
                case "IFCDUCTSEGMENT":
                    return new IfcDuctSegment();
                case "IFCDUCTSEGMENTTYPE":
                    return new IfcDuctSegmentType();
                case "IFCDUCTSILENCER":
                    return new IfcDuctSilencer();
                case "IFCDUCTSILENCERTYPE":
                    return new IfcDuctSilencerType();
                case "IFCEDGE":
                    return new IfcEdge();
                case "IFCEDGECURVE":
                    return new IfcEdgeCurve();
                case "IFCEDGELOOP":
                    return new IfcEdgeLoop();
                case "IFCELECTRICAPPLIANCE":
                    return new IfcElectricAppliance();
                case "IFCELECTRICAPPLIANCETYPE":
                    return new IfcElectricApplianceType();
                case "IFCELECTRICDISTRIBUTIONBOARD":
                    return new IfcElectricDistributionBoard();
                case "IFCELECTRICDISTRIBUTIONBOARDTYPE":
                    return new IfcElectricDistributionBoardType();
                case "IFCELECTRICFLOWSTORAGEDEVICE":
                    return new IfcElectricFlowStorageDevice();
                case "IFCELECTRICFLOWSTORAGEDEVICETYPE":
                    return new IfcElectricFlowStorageDeviceType();
                case "IFCELECTRICGENERATOR":
                    return new IfcElectricGenerator();
                case "IFCELECTRICGENERATORTYPE":
                    return new IfcElectricGeneratorType();
                case "IFCELECTRICMOTOR":
                    return new IfcElectricMotor();
                case "IFCELECTRICMOTORTYPE":
                    return new IfcElectricMotorType();
                case "IFCELECTRICTIMECONTROL":
                    return new IfcElectricTimeControl();
                case "IFCELECTRICTIMECONTROLTYPE":
                    return new IfcElectricTimeControlType();
                case "IFCELEMENTASSEMBLY":
                    return new IfcElementAssembly();
                case "IFCELEMENTASSEMBLYTYPE":
                    return new IfcElementAssemblyType();
                case "IFCELEMENTQUANTITY":
                    return new IfcElementQuantity();
                case "IFCELLIPSE":
                    return new IfcEllipse();
                case "IFCELLIPSEPROFILEDEF":
                    return new IfcEllipseProfileDef();
                case "IFCENERGYCONVERSIONDEVICE":
                    return new IfcEnergyConversionDevice();
                case "IFCENGINE":
                    return new IfcEngine();
                case "IFCENGINETYPE":
                    return new IfcEngineType();
                case "IFCEVAPORATIVECOOLER":
                    return new IfcEvaporativeCooler();
                case "IFCEVAPORATIVECOOLERTYPE":
                    return new IfcEvaporativeCoolerType();
                case "IFCEVAPORATOR":
                    return new IfcEvaporator();
                case "IFCEVAPORATORTYPE":
                    return new IfcEvaporatorType();
                case "IFCEVENT":
                    return new IfcEvent();
                case "IFCEVENTTIME":
                    return new IfcEventTime();
                case "IFCEVENTTYPE":
                    return new IfcEventType();
                case "IFCEXTERNALREFERENCERELATIONSHIP":
                    return new IfcExternalReferenceRelationship();
                case "IFCEXTERNALSPATIALELEMENT":
                    return new IfcExternalSpatialElement();
                case "IFCEXTERNALLYDEFINEDHATCHSTYLE":
                    return new IfcExternallyDefinedHatchStyle();
                case "IFCEXTERNALLYDEFINEDSURFACESTYLE":
                    return new IfcExternallyDefinedSurfaceStyle();
                case "IFCEXTERNALLYDEFINEDTEXTFONT":
                    return new IfcExternallyDefinedTextFont();
                case "IFCEXTRUDEDAREASOLID":
                    return new IfcExtrudedAreaSolid();
                case "IFCEXTRUDEDAREASOLIDTAPERED":
                    return new IfcExtrudedAreaSolidTapered();
                case "IFCFACE":
                    return new IfcFace();
                case "IFCFACEBASEDSURFACEMODEL":
                    return new IfcFaceBasedSurfaceModel();
                case "IFCFACEBOUND":
                    return new IfcFaceBound();
                case "IFCFACEOUTERBOUND":
                    return new IfcFaceOuterBound();
                case "IFCFACESURFACE":
                    return new IfcFaceSurface();
                case "IFCFACETEDBREP":
                    return new IfcFacetedBrep();
                case "IFCFACETEDBREPWITHVOIDS":
                    return new IfcFacetedBrepWithVoids();
                case "IFCFAILURECONNECTIONCONDITION":
                    return new IfcFailureConnectionCondition();
                case "IFCFAN":
                    return new IfcFan();
                case "IFCFANTYPE":
                    return new IfcFanType();
                case "IFCFASTENER":
                    return new IfcFastener();
                case "IFCFASTENERTYPE":
                    return new IfcFastenerType();
                case "IFCFILLAREASTYLE":
                    return new IfcFillAreaStyle();
                case "IFCFILLAREASTYLEHATCHING":
                    return new IfcFillAreaStyleHatching();
                case "IFCFILLAREASTYLETILES":
                    return new IfcFillAreaStyleTiles();
                case "IFCFILTER":
                    return new IfcFilter();
                case "IFCFILTERTYPE":
                    return new IfcFilterType();
                case "IFCFIRESUPPRESSIONTERMINAL":
                    return new IfcFireSuppressionTerminal();
                case "IFCFIRESUPPRESSIONTERMINALTYPE":
                    return new IfcFireSuppressionTerminalType();
                case "IFCFIXEDREFERENCESWEPTAREASOLID":
                    return new IfcFixedReferenceSweptAreaSolid();
                case "IFCFLOWCONTROLLER":
                    return new IfcFlowController();
                case "IFCFLOWFITTING":
                    return new IfcFlowFitting();
                case "IFCFLOWINSTRUMENT":
                    return new IfcFlowInstrument();
                case "IFCFLOWINSTRUMENTTYPE":
                    return new IfcFlowInstrumentType();
                case "IFCFLOWMETER":
                    return new IfcFlowMeter();
                case "IFCFLOWMETERTYPE":
                    return new IfcFlowMeterType();
                case "IFCFLOWMOVINGDEVICE":
                    return new IfcFlowMovingDevice();
                case "IFCFLOWSEGMENT":
                    return new IfcFlowSegment();
                case "IFCFLOWSTORAGEDEVICE":
                    return new IfcFlowStorageDevice();
                case "IFCFLOWTERMINAL":
                    return new IfcFlowTerminal();
                case "IFCFLOWTREATMENTDEVICE":
                    return new IfcFlowTreatmentDevice();
                case "IFCFOOTING":
                    return new IfcFooting();
                case "IFCFOOTINGTYPE":
                    return new IfcFootingType();
                case "IFCFURNISHINGELEMENT":
                    return new IfcFurnishingElement();
                case "IFCFURNISHINGELEMENTTYPE":
                    return new IfcFurnishingElementType();
                case "IFCFURNITURE":
                    return new IfcFurniture();
                case "IFCFURNITURETYPE":
                    return new IfcFurnitureType();
                case "IFCGEOGRAPHICELEMENT":
                    return new IfcGeographicElement();
                case "IFCGEOGRAPHICELEMENTTYPE":
                    return new IfcGeographicElementType();
                case "IFCGEOMETRICCURVESET":
                    return new IfcGeometricCurveSet();
                case "IFCGEOMETRICREPRESENTATIONCONTEXT":
                    return new IfcGeometricRepresentationContext();
                case "IFCGEOMETRICREPRESENTATIONSUBCONTEXT":
                    return new IfcGeometricRepresentationSubContext();
                case "IFCGEOMETRICSET":
                    return new IfcGeometricSet();
                case "IFCGRID":
                    return new IfcGrid();
                case "IFCGRIDAXIS":
                    return new IfcGridAxis();
                case "IFCGRIDPLACEMENT":
                    return new IfcGridPlacement();
                case "IFCGROUP":
                    return new IfcGroup();
                case "IFCHALFSPACESOLID":
                    return new IfcHalfSpaceSolid();
                case "IFCHEATEXCHANGER":
                    return new IfcHeatExchanger();
                case "IFCHEATEXCHANGERTYPE":
                    return new IfcHeatExchangerType();
                case "IFCHUMIDIFIER":
                    return new IfcHumidifier();
                case "IFCHUMIDIFIERTYPE":
                    return new IfcHumidifierType();
                case "IFCISHAPEPROFILEDEF":
                    return new IfcIShapeProfileDef();
                case "IFCIMAGETEXTURE":
                    return new IfcImageTexture();
                case "IFCINDEXEDCOLOURMAP":
                    return new IfcIndexedColourMap();
                case "IFCINDEXEDPOLYCURVE":
                    return new IfcIndexedPolyCurve();
                case "IFCINDEXEDPOLYGONALFACE":
                    return new IfcIndexedPolygonalFace();
                case "IFCINDEXEDPOLYGONALFACEWITHVOIDS":
                    return new IfcIndexedPolygonalFaceWithVoids();
                case "IFCINDEXEDTRIANGLETEXTUREMAP":
                    return new IfcIndexedTriangleTextureMap();
                case "IFCINTERCEPTOR":
                    return new IfcInterceptor();
                case "IFCINTERCEPTORTYPE":
                    return new IfcInterceptorType();
                case "IFCINTERSECTIONCURVE":
                    return new IfcIntersectionCurve();
                case "IFCINVENTORY":
                    return new IfcInventory();
                case "IFCIRREGULARTIMESERIES":
                    return new IfcIrregularTimeSeries();
                case "IFCIRREGULARTIMESERIESVALUE":
                    return new IfcIrregularTimeSeriesValue();
                case "IFCJUNCTIONBOX":
                    return new IfcJunctionBox();
                case "IFCJUNCTIONBOXTYPE":
                    return new IfcJunctionBoxType();
                case "IFCLSHAPEPROFILEDEF":
                    return new IfcLShapeProfileDef();
                case "IFCLABORRESOURCE":
                    return new IfcLaborResource();
                case "IFCLABORRESOURCETYPE":
                    return new IfcLaborResourceType();
                case "IFCLAGTIME":
                    return new IfcLagTime();
                case "IFCLAMP":
                    return new IfcLamp();
                case "IFCLAMPTYPE":
                    return new IfcLampType();
                case "IFCLIBRARYINFORMATION":
                    return new IfcLibraryInformation();
                case "IFCLIBRARYREFERENCE":
                    return new IfcLibraryReference();
                case "IFCLIGHTDISTRIBUTIONDATA":
                    return new IfcLightDistributionData();
                case "IFCLIGHTFIXTURE":
                    return new IfcLightFixture();
                case "IFCLIGHTFIXTURETYPE":
                    return new IfcLightFixtureType();
                case "IFCLIGHTINTENSITYDISTRIBUTION":
                    return new IfcLightIntensityDistribution();
                case "IFCLIGHTSOURCEAMBIENT":
                    return new IfcLightSourceAmbient();
                case "IFCLIGHTSOURCEDIRECTIONAL":
                    return new IfcLightSourceDirectional();
                case "IFCLIGHTSOURCEGONIOMETRIC":
                    return new IfcLightSourceGoniometric();
                case "IFCLIGHTSOURCEPOSITIONAL":
                    return new IfcLightSourcePositional();
                case "IFCLIGHTSOURCESPOT":
                    return new IfcLightSourceSpot();
                case "IFCLINE":
                    return new IfcLine();
                case "IFCLOCALPLACEMENT":
                    return new IfcLocalPlacement();
                case "IFCLOOP":
                    return new IfcLoop();
                case "IFCMAPCONVERSION":
                    return new IfcMapConversion();
                case "IFCMAPPEDITEM":
                    return new IfcMappedItem();
                case "IFCMATERIAL":
                    return new IfcMaterial();
                case "IFCMATERIALCLASSIFICATIONRELATIONSHIP":
                    return new IfcMaterialClassificationRelationship();
                case "IFCMATERIALCONSTITUENT":
                    return new IfcMaterialConstituent();
                case "IFCMATERIALCONSTITUENTSET":
                    return new IfcMaterialConstituentSet();
                case "IFCMATERIALDEFINITIONREPRESENTATION":
                    return new IfcMaterialDefinitionRepresentation();
                case "IFCMATERIALLAYER":
                    return new IfcMaterialLayer();
                case "IFCMATERIALLAYERSET":
                    return new IfcMaterialLayerSet();
                case "IFCMATERIALLAYERSETUSAGE":
                    return new IfcMaterialLayerSetUsage();
                case "IFCMATERIALLAYERWITHOFFSETS":
                    return new IfcMaterialLayerWithOffsets();
                case "IFCMATERIALLIST":
                    return new IfcMaterialList();
                case "IFCMATERIALPROFILE":
                    return new IfcMaterialProfile();
                case "IFCMATERIALPROFILESET":
                    return new IfcMaterialProfileSet();
                case "IFCMATERIALPROFILESETUSAGE":
                    return new IfcMaterialProfileSetUsage();
                case "IFCMATERIALPROFILESETUSAGETAPERING":
                    return new IfcMaterialProfileSetUsageTapering();
                case "IFCMATERIALPROFILEWITHOFFSETS":
                    return new IfcMaterialProfileWithOffsets();
                case "IFCMATERIALPROPERTIES":
                    return new IfcMaterialProperties();
                case "IFCMATERIALRELATIONSHIP":
                    return new IfcMaterialRelationship();
                case "IFCMEASUREWITHUNIT":
                    return new IfcMeasureWithUnit();
                case "IFCMECHANICALFASTENER":
                    return new IfcMechanicalFastener();
                case "IFCMECHANICALFASTENERTYPE":
                    return new IfcMechanicalFastenerType();
                case "IFCMEDICALDEVICE":
                    return new IfcMedicalDevice();
                case "IFCMEDICALDEVICETYPE":
                    return new IfcMedicalDeviceType();
                case "IFCMEMBER":
                    return new IfcMember();
                case "IFCMEMBERSTANDARDCASE":
                    return new IfcMemberStandardCase();
                case "IFCMEMBERTYPE":
                    return new IfcMemberType();
                case "IFCMETRIC":
                    return new IfcMetric();
                case "IFCMIRROREDPROFILEDEF":
                    return new IfcMirroredProfileDef();
                case "IFCMONETARYUNIT":
                    return new IfcMonetaryUnit();
                case "IFCMOTORCONNECTION":
                    return new IfcMotorConnection();
                case "IFCMOTORCONNECTIONTYPE":
                    return new IfcMotorConnectionType();
                case "IFCOBJECTIVE":
                    return new IfcObjective();
                case "IFCOCCUPANT":
                    return new IfcOccupant();
                case "IFCOFFSETCURVE2D":
                    return new IfcOffsetCurve2D();
                case "IFCOFFSETCURVE3D":
                    return new IfcOffsetCurve3D();
                case "IFCOPENSHELL":
                    return new IfcOpenShell();
                case "IFCOPENINGELEMENT":
                    return new IfcOpeningElement();
                case "IFCOPENINGSTANDARDCASE":
                    return new IfcOpeningStandardCase();
                case "IFCORGANIZATION":
                    return new IfcOrganization();
                case "IFCORGANIZATIONRELATIONSHIP":
                    return new IfcOrganizationRelationship();
                case "IFCORIENTEDEDGE":
                    return new IfcOrientedEdge();
                case "IFCOUTERBOUNDARYCURVE":
                    return new IfcOuterBoundaryCurve();
                case "IFCOUTLET":
                    return new IfcOutlet();
                case "IFCOUTLETTYPE":
                    return new IfcOutletType();
                case "IFCOWNERHISTORY":
                    return new IfcOwnerHistory();
                case "IFCPATH":
                    return new IfcPath();
                case "IFCPCURVE":
                    return new IfcPcurve();
                case "IFCPERFORMANCEHISTORY":
                    return new IfcPerformanceHistory();
                case "IFCPERMEABLECOVERINGPROPERTIES":
                    return new IfcPermeableCoveringProperties();
                case "IFCPERMIT":
                    return new IfcPermit();
                case "IFCPERSON":
                    return new IfcPerson();
                case "IFCPERSONANDORGANIZATION":
                    return new IfcPersonAndOrganization();
                case "IFCPHYSICALCOMPLEXQUANTITY":
                    return new IfcPhysicalComplexQuantity();
                case "IFCPILE":
                    return new IfcPile();
                case "IFCPILETYPE":
                    return new IfcPileType();
                case "IFCPIPEFITTING":
                    return new IfcPipeFitting();
                case "IFCPIPEFITTINGTYPE":
                    return new IfcPipeFittingType();
                case "IFCPIPESEGMENT":
                    return new IfcPipeSegment();
                case "IFCPIPESEGMENTTYPE":
                    return new IfcPipeSegmentType();
                case "IFCPIXELTEXTURE":
                    return new IfcPixelTexture();
                case "IFCPLANARBOX":
                    return new IfcPlanarBox();
                case "IFCPLANAREXTENT":
                    return new IfcPlanarExtent();
                case "IFCPLANE":
                    return new IfcPlane();
                case "IFCPLATE":
                    return new IfcPlate();
                case "IFCPLATESTANDARDCASE":
                    return new IfcPlateStandardCase();
                case "IFCPLATETYPE":
                    return new IfcPlateType();
                case "IFCPOINTONCURVE":
                    return new IfcPointOnCurve();
                case "IFCPOINTONSURFACE":
                    return new IfcPointOnSurface();
                case "IFCPOLYLOOP":
                    return new IfcPolyLoop();
                case "IFCPOLYGONALBOUNDEDHALFSPACE":
                    return new IfcPolygonalBoundedHalfSpace();
                case "IFCPOLYGONALFACESET":
                    return new IfcPolygonalFaceSet();
                case "IFCPOLYLINE":
                    return new IfcPolyline();
                case "IFCPOSTALADDRESS":
                    return new IfcPostalAddress();
                case "IFCPRESENTATIONLAYERASSIGNMENT":
                    return new IfcPresentationLayerAssignment();
                case "IFCPRESENTATIONLAYERWITHSTYLE":
                    return new IfcPresentationLayerWithStyle();
                case "IFCPRESENTATIONSTYLEASSIGNMENT":
                    return new IfcPresentationStyleAssignment();
                case "IFCPROCEDURE":
                    return new IfcProcedure();
                case "IFCPROCEDURETYPE":
                    return new IfcProcedureType();
                case "IFCPRODUCTDEFINITIONSHAPE":
                    return new IfcProductDefinitionShape();
                case "IFCPROFILEDEF":
                    return new IfcProfileDef();
                case "IFCPROFILEPROPERTIES":
                    return new IfcProfileProperties();
                case "IFCPROJECT":
                    return new IfcProject();
                case "IFCPROJECTLIBRARY":
                    return new IfcProjectLibrary();
                case "IFCPROJECTORDER":
                    return new IfcProjectOrder();
                case "IFCPROJECTEDCRS":
                    return new IfcProjectedCRS();
                case "IFCPROJECTIONELEMENT":
                    return new IfcProjectionElement();
                case "IFCPROPERTYBOUNDEDVALUE":
                    return new IfcPropertyBoundedValue();
                case "IFCPROPERTYDEPENDENCYRELATIONSHIP":
                    return new IfcPropertyDependencyRelationship();
                case "IFCPROPERTYENUMERATEDVALUE":
                    return new IfcPropertyEnumeratedValue();
                case "IFCPROPERTYENUMERATION":
                    return new IfcPropertyEnumeration();
                case "IFCPROPERTYLISTVALUE":
                    return new IfcPropertyListValue();
                case "IFCPROPERTYREFERENCEVALUE":
                    return new IfcPropertyReferenceValue();
                case "IFCPROPERTYSET":
                    return new IfcPropertySet();
                case "IFCPROPERTYSETTEMPLATE":
                    return new IfcPropertySetTemplate();
                case "IFCPROPERTYSINGLEVALUE":
                    return new IfcPropertySingleValue();
                case "IFCPROPERTYTABLEVALUE":
                    return new IfcPropertyTableValue();
                case "IFCPROTECTIVEDEVICE":
                    return new IfcProtectiveDevice();
                case "IFCPROTECTIVEDEVICETRIPPINGUNIT":
                    return new IfcProtectiveDeviceTrippingUnit();
                case "IFCPROTECTIVEDEVICETRIPPINGUNITTYPE":
                    return new IfcProtectiveDeviceTrippingUnitType();
                case "IFCPROTECTIVEDEVICETYPE":
                    return new IfcProtectiveDeviceType();
                case "IFCPROXY":
                    return new IfcProxy();
                case "IFCPUMP":
                    return new IfcPump();
                case "IFCPUMPTYPE":
                    return new IfcPumpType();
                case "IFCQUANTITYAREA":
                    return new IfcQuantityArea();
                case "IFCQUANTITYCOUNT":
                    return new IfcQuantityCount();
                case "IFCQUANTITYLENGTH":
                    return new IfcQuantityLength();
                case "IFCQUANTITYTIME":
                    return new IfcQuantityTime();
                case "IFCQUANTITYVOLUME":
                    return new IfcQuantityVolume();
                case "IFCQUANTITYWEIGHT":
                    return new IfcQuantityWeight();
                case "IFCRAILING":
                    return new IfcRailing();
                case "IFCRAILINGTYPE":
                    return new IfcRailingType();
                case "IFCRAMP":
                    return new IfcRamp();
                case "IFCRAMPFLIGHT":
                    return new IfcRampFlight();
                case "IFCRAMPFLIGHTTYPE":
                    return new IfcRampFlightType();
                case "IFCRAMPTYPE":
                    return new IfcRampType();
                case "IFCRATIONALBSPLINECURVEWITHKNOTS":
                    return new IfcRationalBSplineCurveWithKnots();
                case "IFCRATIONALBSPLINESURFACEWITHKNOTS":
                    return new IfcRationalBSplineSurfaceWithKnots();
                case "IFCRECTANGLEHOLLOWPROFILEDEF":
                    return new IfcRectangleHollowProfileDef();
                case "IFCRECTANGLEPROFILEDEF":
                    return new IfcRectangleProfileDef();
                case "IFCRECTANGULARPYRAMID":
                    return new IfcRectangularPyramid();
                case "IFCRECTANGULARTRIMMEDSURFACE":
                    return new IfcRectangularTrimmedSurface();
                case "IFCRECURRENCEPATTERN":
                    return new IfcRecurrencePattern();
                case "IFCREFERENCE":
                    return new IfcReference();
                case "IFCREGULARTIMESERIES":
                    return new IfcRegularTimeSeries();
                case "IFCREINFORCEMENTBARPROPERTIES":
                    return new IfcReinforcementBarProperties();
                case "IFCREINFORCEMENTDEFINITIONPROPERTIES":
                    return new IfcReinforcementDefinitionProperties();
                case "IFCREINFORCINGBAR":
                    return new IfcReinforcingBar();
                case "IFCREINFORCINGBARTYPE":
                    return new IfcReinforcingBarType();
                case "IFCREINFORCINGMESH":
                    return new IfcReinforcingMesh();
                case "IFCREINFORCINGMESHTYPE":
                    return new IfcReinforcingMeshType();
                case "IFCRELAGGREGATES":
                    return new IfcRelAggregates();
                case "IFCRELASSIGNSTOACTOR":
                    return new IfcRelAssignsToActor();
                case "IFCRELASSIGNSTOCONTROL":
                    return new IfcRelAssignsToControl();
                case "IFCRELASSIGNSTOGROUP":
                    return new IfcRelAssignsToGroup();
                case "IFCRELASSIGNSTOGROUPBYFACTOR":
                    return new IfcRelAssignsToGroupByFactor();
                case "IFCRELASSIGNSTOPROCESS":
                    return new IfcRelAssignsToProcess();
                case "IFCRELASSIGNSTOPRODUCT":
                    return new IfcRelAssignsToProduct();
                case "IFCRELASSIGNSTORESOURCE":
                    return new IfcRelAssignsToResource();
                case "IFCRELASSOCIATESAPPROVAL":
                    return new IfcRelAssociatesApproval();
                case "IFCRELASSOCIATESCLASSIFICATION":
                    return new IfcRelAssociatesClassification();
                case "IFCRELASSOCIATESCONSTRAINT":
                    return new IfcRelAssociatesConstraint();
                case "IFCRELASSOCIATESDOCUMENT":
                    return new IfcRelAssociatesDocument();
                case "IFCRELASSOCIATESLIBRARY":
                    return new IfcRelAssociatesLibrary();
                case "IFCRELASSOCIATESMATERIAL":
                    return new IfcRelAssociatesMaterial();
                case "IFCRELCONNECTSELEMENTS":
                    return new IfcRelConnectsElements();
                case "IFCRELCONNECTSPATHELEMENTS":
                    return new IfcRelConnectsPathElements();
                case "IFCRELCONNECTSPORTTOELEMENT":
                    return new IfcRelConnectsPortToElement();
                case "IFCRELCONNECTSPORTS":
                    return new IfcRelConnectsPorts();
                case "IFCRELCONNECTSSTRUCTURALACTIVITY":
                    return new IfcRelConnectsStructuralActivity();
                case "IFCRELCONNECTSSTRUCTURALMEMBER":
                    return new IfcRelConnectsStructuralMember();
                case "IFCRELCONNECTSWITHECCENTRICITY":
                    return new IfcRelConnectsWithEccentricity();
                case "IFCRELCONNECTSWITHREALIZINGELEMENTS":
                    return new IfcRelConnectsWithRealizingElements();
                case "IFCRELCONTAINEDINSPATIALSTRUCTURE":
                    return new IfcRelContainedInSpatialStructure();
                case "IFCRELCOVERSBLDGELEMENTS":
                    return new IfcRelCoversBldgElements();
                case "IFCRELCOVERSSPACES":
                    return new IfcRelCoversSpaces();
                case "IFCRELDECLARES":
                    return new IfcRelDeclares();
                case "IFCRELDEFINESBYOBJECT":
                    return new IfcRelDefinesByObject();
                case "IFCRELDEFINESBYPROPERTIES":
                    return new IfcRelDefinesByProperties();
                case "IFCRELDEFINESBYTEMPLATE":
                    return new IfcRelDefinesByTemplate();
                case "IFCRELDEFINESBYTYPE":
                    return new IfcRelDefinesByType();
                case "IFCRELFILLSELEMENT":
                    return new IfcRelFillsElement();
                case "IFCRELFLOWCONTROLELEMENTS":
                    return new IfcRelFlowControlElements();
                case "IFCRELINTERFERESELEMENTS":
                    return new IfcRelInterferesElements();
                case "IFCRELNESTS":
                    return new IfcRelNests();
                case "IFCRELPROJECTSELEMENT":
                    return new IfcRelProjectsElement();
                case "IFCRELREFERENCEDINSPATIALSTRUCTURE":
                    return new IfcRelReferencedInSpatialStructure();
                case "IFCRELSEQUENCE":
                    return new IfcRelSequence();
                case "IFCRELSERVICESBUILDINGS":
                    return new IfcRelServicesBuildings();
                case "IFCRELSPACEBOUNDARY":
                    return new IfcRelSpaceBoundary();
                case "IFCRELSPACEBOUNDARY1STLEVEL":
                    return new IfcRelSpaceBoundary1stLevel();
                case "IFCRELSPACEBOUNDARY2NDLEVEL":
                    return new IfcRelSpaceBoundary2ndLevel();
                case "IFCRELVOIDSELEMENT":
                    return new IfcRelVoidsElement();
                case "IFCREPARAMETRISEDCOMPOSITECURVESEGMENT":
                    return new IfcReparametrisedCompositeCurveSegment();
                case "IFCREPRESENTATIONMAP":
                    return new IfcRepresentationMap();
                case "IFCRESOURCEAPPROVALRELATIONSHIP":
                    return new IfcResourceApprovalRelationship();
                case "IFCRESOURCECONSTRAINTRELATIONSHIP":
                    return new IfcResourceConstraintRelationship();
                case "IFCRESOURCETIME":
                    return new IfcResourceTime();
                case "IFCREVOLVEDAREASOLID":
                    return new IfcRevolvedAreaSolid();
                case "IFCREVOLVEDAREASOLIDTAPERED":
                    return new IfcRevolvedAreaSolidTapered();
                case "IFCRIGHTCIRCULARCONE":
                    return new IfcRightCircularCone();
                case "IFCRIGHTCIRCULARCYLINDER":
                    return new IfcRightCircularCylinder();
                case "IFCROOF":
                    return new IfcRoof();
                case "IFCROOFTYPE":
                    return new IfcRoofType();
                case "IFCROUNDEDRECTANGLEPROFILEDEF":
                    return new IfcRoundedRectangleProfileDef();
                case "IFCSIUNIT":
                    return new IfcSIUnit();
                case "IFCSANITARYTERMINAL":
                    return new IfcSanitaryTerminal();
                case "IFCSANITARYTERMINALTYPE":
                    return new IfcSanitaryTerminalType();
                case "IFCSEAMCURVE":
                    return new IfcSeamCurve();
                case "IFCSECTIONPROPERTIES":
                    return new IfcSectionProperties();
                case "IFCSECTIONREINFORCEMENTPROPERTIES":
                    return new IfcSectionReinforcementProperties();
                case "IFCSECTIONEDSPINE":
                    return new IfcSectionedSpine();
                case "IFCSENSOR":
                    return new IfcSensor();
                case "IFCSENSORTYPE":
                    return new IfcSensorType();
                case "IFCSHADINGDEVICE":
                    return new IfcShadingDevice();
                case "IFCSHADINGDEVICETYPE":
                    return new IfcShadingDeviceType();
                case "IFCSHAPEASPECT":
                    return new IfcShapeAspect();
                case "IFCSHAPEREPRESENTATION":
                    return new IfcShapeRepresentation();
                case "IFCSHELLBASEDSURFACEMODEL":
                    return new IfcShellBasedSurfaceModel();
                case "IFCSIMPLEPROPERTYTEMPLATE":
                    return new IfcSimplePropertyTemplate();
                case "IFCSITE":
                    return new IfcSite();
                case "IFCSLAB":
                    return new IfcSlab();
                case "IFCSLABELEMENTEDCASE":
                    return new IfcSlabElementedCase();
                case "IFCSLABSTANDARDCASE":
                    return new IfcSlabStandardCase();
                case "IFCSLABTYPE":
                    return new IfcSlabType();
                case "IFCSLIPPAGECONNECTIONCONDITION":
                    return new IfcSlippageConnectionCondition();
                case "IFCSOLARDEVICE":
                    return new IfcSolarDevice();
                case "IFCSOLARDEVICETYPE":
                    return new IfcSolarDeviceType();
                case "IFCSPACE":
                    return new IfcSpace();
                case "IFCSPACEHEATER":
                    return new IfcSpaceHeater();
                case "IFCSPACEHEATERTYPE":
                    return new IfcSpaceHeaterType();
                case "IFCSPACETYPE":
                    return new IfcSpaceType();
                case "IFCSPATIALZONE":
                    return new IfcSpatialZone();
                case "IFCSPATIALZONETYPE":
                    return new IfcSpatialZoneType();
                case "IFCSPHERE":
                    return new IfcSphere();
                case "IFCSPHERICALSURFACE":
                    return new IfcSphericalSurface();
                case "IFCSTACKTERMINAL":
                    return new IfcStackTerminal();
                case "IFCSTACKTERMINALTYPE":
                    return new IfcStackTerminalType();
                case "IFCSTAIR":
                    return new IfcStair();
                case "IFCSTAIRFLIGHT":
                    return new IfcStairFlight();
                case "IFCSTAIRFLIGHTTYPE":
                    return new IfcStairFlightType();
                case "IFCSTAIRTYPE":
                    return new IfcStairType();
                case "IFCSTRUCTURALANALYSISMODEL":
                    return new IfcStructuralAnalysisModel();
                case "IFCSTRUCTURALCURVEACTION":
                    return new IfcStructuralCurveAction();
                case "IFCSTRUCTURALCURVECONNECTION":
                    return new IfcStructuralCurveConnection();
                case "IFCSTRUCTURALCURVEMEMBER":
                    return new IfcStructuralCurveMember();
                case "IFCSTRUCTURALCURVEMEMBERVARYING":
                    return new IfcStructuralCurveMemberVarying();
                case "IFCSTRUCTURALCURVEREACTION":
                    return new IfcStructuralCurveReaction();
                case "IFCSTRUCTURALLINEARACTION":
                    return new IfcStructuralLinearAction();
                case "IFCSTRUCTURALLOADCASE":
                    return new IfcStructuralLoadCase();
                case "IFCSTRUCTURALLOADCONFIGURATION":
                    return new IfcStructuralLoadConfiguration();
                case "IFCSTRUCTURALLOADGROUP":
                    return new IfcStructuralLoadGroup();
                case "IFCSTRUCTURALLOADLINEARFORCE":
                    return new IfcStructuralLoadLinearForce();
                case "IFCSTRUCTURALLOADPLANARFORCE":
                    return new IfcStructuralLoadPlanarForce();
                case "IFCSTRUCTURALLOADSINGLEDISPLACEMENT":
                    return new IfcStructuralLoadSingleDisplacement();
                case "IFCSTRUCTURALLOADSINGLEDISPLACEMENTDISTORTION":
                    return new IfcStructuralLoadSingleDisplacementDistortion();
                case "IFCSTRUCTURALLOADSINGLEFORCE":
                    return new IfcStructuralLoadSingleForce();
                case "IFCSTRUCTURALLOADSINGLEFORCEWARPING":
                    return new IfcStructuralLoadSingleForceWarping();
                case "IFCSTRUCTURALLOADTEMPERATURE":
                    return new IfcStructuralLoadTemperature();
                case "IFCSTRUCTURALPLANARACTION":
                    return new IfcStructuralPlanarAction();
                case "IFCSTRUCTURALPOINTACTION":
                    return new IfcStructuralPointAction();
                case "IFCSTRUCTURALPOINTCONNECTION":
                    return new IfcStructuralPointConnection();
                case "IFCSTRUCTURALPOINTREACTION":
                    return new IfcStructuralPointReaction();
                case "IFCSTRUCTURALRESULTGROUP":
                    return new IfcStructuralResultGroup();
                case "IFCSTRUCTURALSURFACEACTION":
                    return new IfcStructuralSurfaceAction();
                case "IFCSTRUCTURALSURFACECONNECTION":
                    return new IfcStructuralSurfaceConnection();
                case "IFCSTRUCTURALSURFACEMEMBER":
                    return new IfcStructuralSurfaceMember();
                case "IFCSTRUCTURALSURFACEMEMBERVARYING":
                    return new IfcStructuralSurfaceMemberVarying();
                case "IFCSTRUCTURALSURFACEREACTION":
                    return new IfcStructuralSurfaceReaction();
                case "IFCSTYLEDITEM":
                    return new IfcStyledItem();
                case "IFCSTYLEDREPRESENTATION":
                    return new IfcStyledRepresentation();
                case "IFCSUBCONTRACTRESOURCE":
                    return new IfcSubContractResource();
                case "IFCSUBCONTRACTRESOURCETYPE":
                    return new IfcSubContractResourceType();
                case "IFCSUBEDGE":
                    return new IfcSubedge();
                case "IFCSURFACECURVE":
                    return new IfcSurfaceCurve();
                case "IFCSURFACECURVESWEPTAREASOLID":
                    return new IfcSurfaceCurveSweptAreaSolid();
                case "IFCSURFACEFEATURE":
                    return new IfcSurfaceFeature();
                case "IFCSURFACEOFLINEAREXTRUSION":
                    return new IfcSurfaceOfLinearExtrusion();
                case "IFCSURFACEOFREVOLUTION":
                    return new IfcSurfaceOfRevolution();
                case "IFCSURFACEREINFORCEMENTAREA":
                    return new IfcSurfaceReinforcementArea();
                case "IFCSURFACESTYLE":
                    return new IfcSurfaceStyle();
                case "IFCSURFACESTYLELIGHTING":
                    return new IfcSurfaceStyleLighting();
                case "IFCSURFACESTYLEREFRACTION":
                    return new IfcSurfaceStyleRefraction();
                case "IFCSURFACESTYLERENDERING":
                    return new IfcSurfaceStyleRendering();
                case "IFCSURFACESTYLESHADING":
                    return new IfcSurfaceStyleShading();
                case "IFCSURFACESTYLEWITHTEXTURES":
                    return new IfcSurfaceStyleWithTextures();
                case "IFCSWEPTDISKSOLID":
                    return new IfcSweptDiskSolid();
                case "IFCSWEPTDISKSOLIDPOLYGONAL":
                    return new IfcSweptDiskSolidPolygonal();
                case "IFCSWITCHINGDEVICE":
                    return new IfcSwitchingDevice();
                case "IFCSWITCHINGDEVICETYPE":
                    return new IfcSwitchingDeviceType();
                case "IFCSYSTEM":
                    return new IfcSystem();
                case "IFCSYSTEMFURNITUREELEMENT":
                    return new IfcSystemFurnitureElement();
                case "IFCSYSTEMFURNITUREELEMENTTYPE":
                    return new IfcSystemFurnitureElementType();
                case "IFCTSHAPEPROFILEDEF":
                    return new IfcTShapeProfileDef();
                case "IFCTABLE":
                    return new IfcTable();
                case "IFCTABLECOLUMN":
                    return new IfcTableColumn();
                case "IFCTABLEROW":
                    return new IfcTableRow();
                case "IFCTANK":
                    return new IfcTank();
                case "IFCTANKTYPE":
                    return new IfcTankType();
                case "IFCTASK":
                    return new IfcTask();
                case "IFCTASKTIME":
                    return new IfcTaskTime();
                case "IFCTASKTIMERECURRING":
                    return new IfcTaskTimeRecurring();
                case "IFCTASKTYPE":
                    return new IfcTaskType();
                case "IFCTELECOMADDRESS":
                    return new IfcTelecomAddress();
                case "IFCTENDON":
                    return new IfcTendon();
                case "IFCTENDONANCHOR":
                    return new IfcTendonAnchor();
                case "IFCTENDONANCHORTYPE":
                    return new IfcTendonAnchorType();
                case "IFCTENDONTYPE":
                    return new IfcTendonType();
                case "IFCTEXTLITERAL":
                    return new IfcTextLiteral();
                case "IFCTEXTLITERALWITHEXTENT":
                    return new IfcTextLiteralWithExtent();
                case "IFCTEXTSTYLE":
                    return new IfcTextStyle();
                case "IFCTEXTSTYLEFONTMODEL":
                    return new IfcTextStyleFontModel();
                case "IFCTEXTSTYLEFORDEFINEDFONT":
                    return new IfcTextStyleForDefinedFont();
                case "IFCTEXTSTYLETEXTMODEL":
                    return new IfcTextStyleTextModel();
                case "IFCTEXTURECOORDINATEGENERATOR":
                    return new IfcTextureCoordinateGenerator();
                case "IFCTEXTUREMAP":
                    return new IfcTextureMap();
                case "IFCTEXTUREVERTEX":
                    return new IfcTextureVertex();
                case "IFCTEXTUREVERTEXLIST":
                    return new IfcTextureVertexList();
                case "IFCTIMEPERIOD":
                    return new IfcTimePeriod();
                case "IFCTIMESERIESVALUE":
                    return new IfcTimeSeriesValue();
                case "IFCTOPOLOGYREPRESENTATION":
                    return new IfcTopologyRepresentation();
                case "IFCTOROIDALSURFACE":
                    return new IfcToroidalSurface();
                case "IFCTRANSFORMER":
                    return new IfcTransformer();
                case "IFCTRANSFORMERTYPE":
                    return new IfcTransformerType();
                case "IFCTRANSPORTELEMENT":
                    return new IfcTransportElement();
                case "IFCTRANSPORTELEMENTTYPE":
                    return new IfcTransportElementType();
                case "IFCTRAPEZIUMPROFILEDEF":
                    return new IfcTrapeziumProfileDef();
                case "IFCTRIANGULATEDFACESET":
                    return new IfcTriangulatedFaceSet();
                case "IFCTRIMMEDCURVE":
                    return new IfcTrimmedCurve();
                case "IFCTUBEBUNDLE":
                    return new IfcTubeBundle();
                case "IFCTUBEBUNDLETYPE":
                    return new IfcTubeBundleType();
                case "IFCTYPEOBJECT":
                    return new IfcTypeObject();
                case "IFCTYPEPRODUCT":
                    return new IfcTypeProduct();
                case "IFCUSHAPEPROFILEDEF":
                    return new IfcUShapeProfileDef();
                case "IFCUNITASSIGNMENT":
                    return new IfcUnitAssignment();
                case "IFCUNITARYCONTROLELEMENT":
                    return new IfcUnitaryControlElement();
                case "IFCUNITARYCONTROLELEMENTTYPE":
                    return new IfcUnitaryControlElementType();
                case "IFCUNITARYEQUIPMENT":
                    return new IfcUnitaryEquipment();
                case "IFCUNITARYEQUIPMENTTYPE":
                    return new IfcUnitaryEquipmentType();
                case "IFCVALVE":
                    return new IfcValve();
                case "IFCVALVETYPE":
                    return new IfcValveType();
                case "IFCVECTOR":
                    return new IfcVector();
                case "IFCVERTEX":
                    return new IfcVertex();
                case "IFCVERTEXLOOP":
                    return new IfcVertexLoop();
                case "IFCVERTEXPOINT":
                    return new IfcVertexPoint();
                case "IFCVIBRATIONISOLATOR":
                    return new IfcVibrationIsolator();
                case "IFCVIBRATIONISOLATORTYPE":
                    return new IfcVibrationIsolatorType();
                case "IFCVIRTUALELEMENT":
                    return new IfcVirtualElement();
                case "IFCVIRTUALGRIDINTERSECTION":
                    return new IfcVirtualGridIntersection();
                case "IFCVOIDINGFEATURE":
                    return new IfcVoidingFeature();
                case "IFCWALL":
                    return new IfcWall();
                case "IFCWALLELEMENTEDCASE":
                    return new IfcWallElementedCase();
                case "IFCWALLSTANDARDCASE":
                    return new IfcWallStandardCase();
                case "IFCWALLTYPE":
                    return new IfcWallType();
                case "IFCWASTETERMINAL":
                    return new IfcWasteTerminal();
                case "IFCWASTETERMINALTYPE":
                    return new IfcWasteTerminalType();
                case "IFCWINDOW":
                    return new IfcWindow();
                case "IFCWINDOWLININGPROPERTIES":
                    return new IfcWindowLiningProperties();
                case "IFCWINDOWPANELPROPERTIES":
                    return new IfcWindowPanelProperties();
                case "IFCWINDOWSTANDARDCASE":
                    return new IfcWindowStandardCase();
                case "IFCWINDOWSTYLE":
                    return new IfcWindowStyle();
                case "IFCWINDOWTYPE":
                    return new IfcWindowType();
                case "IFCWORKCALENDAR":
                    return new IfcWorkCalendar();
                case "IFCWORKPLAN":
                    return new IfcWorkPlan();
                case "IFCWORKSCHEDULE":
                    return new IfcWorkSchedule();
                case "IFCWORKTIME":
                    return new IfcWorkTime();
                case "IFCZSHAPEPROFILEDEF":
                    return new IfcZShapeProfileDef();
                case "IFCZONE":
                    return new IfcZone();
                default:
                    return null;
            }

        }
    }
}
