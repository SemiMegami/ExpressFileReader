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
            IfcBase item = CreateNew(name);
            item.textParameters = paramList;
            Add(key, item);
        }

        private List<PropertyInfo> GetProperyList(string name)
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
        private void MapAandSetProperties(IfcBase item)
        {
            var textParameters = item.textParameters;
            var itemType = item.GetType();
            var constructors = itemType.GetConstructors();
            for (int i = 0; i < constructors.Length; i++)
            {
                var parameters = constructors[i].GetParameters();
                if(parameters.Length == textParameters.Count)
                {
                    for(int j = 0; j < textParameters.Count; j++)
                    {
                        var property= itemType.GetProperty(parameters[j].Name);
                        var value = GetInstance(textParameters[j], parameters[j].ParameterType);
                        property.SetValue(item, value);
                    }
                    break;
                }
            }
        }



        public List<string> SplitParamText(string paramText)
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
                    //if(bracketCount == 0)
                    //{
                    //    scanningText += c;
                    //}
                    scanningText += c;
                    bracketCount++;
                }
                else if (!readingString && c == ')')
                {
                    bracketCount--;
                    //if (bracketCount == 0)
                    //{
                    //    scanningText += c;
                    //}
                    scanningText += c;
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
                return CreateNew(type.Name.ToUpper());
            }
            if(input.Substring(0, 1) == "'")
            {

                switch (type.Name)
                {
                    case "IfcBoxAlignment": return (IfcBoxAlignment)input.Substring(1, input.Length - 2);
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
                    case "IfcLanguageId": return (IfcLanguageId)input.Substring(1, input.Length - 2);
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
           
            //int
            if (int.TryParse(input, out int result))
            {
                switch (type.Name)
                {
                    case "Int32": return (INTEGER) result;
                    case "INTEGER": return (INTEGER) result;
                    case "BINARY": return (BINARY)result;
                    case "IfcAbsorbedDoseMeasure": return (IfcAbsorbedDoseMeasure)result;
                    case "IfcAccelerationMeasure": return (IfcAccelerationMeasure)result;
                    case "IfcAmountOfSubstanceMeasure": return (IfcAmountOfSubstanceMeasure)result;
                    case "IfcAngularVelocityMeasure": return (IfcAngularVelocityMeasure)result;
                    case "IfcAreaDensityMeasure": return (IfcAreaDensityMeasure)result;
                    case "IfcAreaMeasure": return (IfcAreaMeasure)result;
                    case "IfcBinary": return (IfcBinary)result;
                    case "IfcCardinalPointReference": return (IfcCardinalPointReference)result;
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
                    case "IfcLengthMeasure": return (IfcLengthMeasure)result;
                    case "IfcLinearForceMeasure": return (IfcLinearForceMeasure)result;
                    case "IfcLinearMomentMeasure": return (IfcLinearMomentMeasure)result;
                    case "IfcLinearStiffnessMeasure": return (IfcLinearStiffnessMeasure)result;
                    case "IfcLinearVelocityMeasure": return (IfcLinearVelocityMeasure)result;
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

            //double
            if (double.TryParse(input, out double numericResult))
            {
                switch (type.Name)
                {
                   // case "Int32": return (INTEGER)result;
                    case "NUMBER": return (NUMBER)result;
                    case "REAL": return (REAL)result;
                    case "IfcAbsorbedDoseMeasure": return (IfcAbsorbedDoseMeasure)numericResult;
                    case "IfcAccelerationMeasure": return (IfcAccelerationMeasure)numericResult;
                    case "IfcAmountOfSubstanceMeasure": return (IfcAmountOfSubstanceMeasure)numericResult;
                    case "IfcAngularVelocityMeasure": return (IfcAngularVelocityMeasure)numericResult;
                    case "IfcAreaDensityMeasure": return (IfcAreaDensityMeasure)numericResult;
                    case "IfcAreaMeasure": return (IfcAreaMeasure)numericResult;
                    case "IfcBinary": return (IfcBinary)numericResult;
                    case "IfcCardinalPointReference": return (IfcCardinalPointReference)numericResult;
                    case "IfcContextDependentMeasure": return (IfcContextDependentMeasure)numericResult;
                    case "IfcCountMeasure": return (IfcCountMeasure)numericResult;
                    case "IfcCurvatureMeasure": return (IfcCurvatureMeasure)numericResult;
                    case "IfcDayInMonthNumber": return (IfcDayInMonthNumber)numericResult;
                    case "IfcDayInWeekNumber": return (IfcDayInWeekNumber)numericResult;
                    case "IfcDimensionCount": return (IfcDimensionCount)numericResult;
                    case "IfcDoseEquivalentMeasure": return (IfcDoseEquivalentMeasure)numericResult;
                    case "IfcDynamicViscosityMeasure": return (IfcDynamicViscosityMeasure)numericResult;
                    case "IfcElectricCapacitanceMeasure": return (IfcElectricCapacitanceMeasure)numericResult;
                    case "IfcElectricChargeMeasure": return (IfcElectricChargeMeasure)numericResult;
                    case "IfcElectricConductanceMeasure": return (IfcElectricConductanceMeasure)numericResult;
                    case "IfcElectricCurrentMeasure": return (IfcElectricCurrentMeasure)numericResult;
                    case "IfcElectricResistanceMeasure": return (IfcElectricResistanceMeasure)numericResult;
                    case "IfcElectricVoltageMeasure": return (IfcElectricVoltageMeasure)numericResult;
                    case "IfcEnergyMeasure": return (IfcEnergyMeasure)numericResult;
                    case "IfcForceMeasure": return (IfcForceMeasure)numericResult;
                    case "IfcFrequencyMeasure": return (IfcFrequencyMeasure)numericResult;
                    case "IfcHeatFluxDensityMeasure": return (IfcHeatFluxDensityMeasure)numericResult;
                    case "IfcHeatingValueMeasure": return (IfcHeatingValueMeasure)numericResult;
                    case "IfcIlluminanceMeasure": return (IfcIlluminanceMeasure)numericResult;
                    case "IfcInductanceMeasure": return (IfcInductanceMeasure)numericResult;
                    case "IfcInteger": return (IfcInteger)numericResult;
                    case "IfcIntegerCountRateMeasure": return (IfcIntegerCountRateMeasure)numericResult;
                    case "IfcIonConcentrationMeasure": return (IfcIonConcentrationMeasure)numericResult;
                    case "IfcIsothermalMoistureCapacityMeasure": return (IfcIsothermalMoistureCapacityMeasure)numericResult;
                    case "IfcKinematicViscosityMeasure": return (IfcKinematicViscosityMeasure)numericResult;
                    case "IfcLengthMeasure": return (IfcLengthMeasure)numericResult;
                    case "IfcLinearForceMeasure": return (IfcLinearForceMeasure)numericResult;
                    case "IfcLinearMomentMeasure": return (IfcLinearMomentMeasure)numericResult;
                    case "IfcLinearStiffnessMeasure": return (IfcLinearStiffnessMeasure)numericResult;
                    case "IfcLinearVelocityMeasure": return (IfcLinearVelocityMeasure)numericResult;
                    case "IfcLuminousFluxMeasure": return (IfcLuminousFluxMeasure)numericResult;
                    case "IfcLuminousIntensityDistributionMeasure": return (IfcLuminousIntensityDistributionMeasure)numericResult;
                    case "IfcLuminousIntensityMeasure": return (IfcLuminousIntensityMeasure)numericResult;
                    case "IfcMagneticFluxDensityMeasure": return (IfcMagneticFluxDensityMeasure)numericResult;
                    case "IfcMagneticFluxMeasure": return (IfcMagneticFluxMeasure)numericResult;
                    case "IfcMassDensityMeasure": return (IfcMassDensityMeasure)numericResult;
                    case "IfcMassFlowRateMeasure": return (IfcMassFlowRateMeasure)numericResult;
                    case "IfcMassMeasure": return (IfcMassMeasure)numericResult;
                    case "IfcMassPerLengthMeasure": return (IfcMassPerLengthMeasure)numericResult;
                    case "IfcModulusOfElasticityMeasure": return (IfcModulusOfElasticityMeasure)numericResult;
                    case "IfcModulusOfLinearSubgradeReactionMeasure": return (IfcModulusOfLinearSubgradeReactionMeasure)numericResult;
                    case "IfcModulusOfRotationalSubgradeReactionMeasure": return (IfcModulusOfRotationalSubgradeReactionMeasure)numericResult;
                    case "IfcModulusOfSubgradeReactionMeasure": return (IfcModulusOfSubgradeReactionMeasure)numericResult;
                    case "IfcMoistureDiffusivityMeasure": return (IfcMoistureDiffusivityMeasure)numericResult;
                    case "IfcMolecularWeightMeasure": return (IfcMolecularWeightMeasure)numericResult;
                    case "IfcMomentOfInertiaMeasure": return (IfcMomentOfInertiaMeasure)numericResult;
                    case "IfcMonetaryMeasure": return (IfcMonetaryMeasure)numericResult;
                    case "IfcMonthInYearNumber": return (IfcMonthInYearNumber)numericResult;
                    case "IfcNonNegativeLengthMeasure": return (IfcNonNegativeLengthMeasure)numericResult;
                    case "IfcNormalisedRatioMeasure": return (IfcNormalisedRatioMeasure)numericResult;
                    case "IfcNumericMeasure": return (IfcNumericMeasure)numericResult;
                    case "IfcPHMeasure": return (IfcPHMeasure)numericResult;
                    case "IfcParameterValue": return (IfcParameterValue)numericResult;
                    case "IfcPlanarForceMeasure": return (IfcPlanarForceMeasure)numericResult;
                    case "IfcPlaneAngleMeasure": return (IfcPlaneAngleMeasure)numericResult;
                    case "IfcPositiveInteger": return (IfcPositiveInteger)numericResult;
                    case "IfcPositiveLengthMeasure": return (IfcPositiveLengthMeasure)numericResult;
                    case "IfcPositivePlaneAngleMeasure": return (IfcPositivePlaneAngleMeasure)numericResult;
                    case "IfcPositiveRatioMeasure": return (IfcPositiveRatioMeasure)numericResult;
                    case "IfcPowerMeasure": return (IfcPowerMeasure)numericResult;
                    case "IfcPressureMeasure": return (IfcPressureMeasure)numericResult;
                    case "IfcRadioActivityMeasure": return (IfcRadioActivityMeasure)numericResult;
                    case "IfcRatioMeasure": return (IfcRatioMeasure)numericResult;
                    case "IfcReal": return (IfcReal)numericResult;
                    case "IfcRotationalFrequencyMeasure": return (IfcRotationalFrequencyMeasure)numericResult;
                    case "IfcRotationalMassMeasure": return (IfcRotationalMassMeasure)numericResult;
                    case "IfcRotationalStiffnessMeasure": return (IfcRotationalStiffnessMeasure)numericResult;
                    case "IfcSectionModulusMeasure": return (IfcSectionModulusMeasure)numericResult;
                    case "IfcSectionalAreaIntegralMeasure": return (IfcSectionalAreaIntegralMeasure)numericResult;
                    case "IfcShearModulusMeasure": return (IfcShearModulusMeasure)numericResult;
                    case "IfcSolidAngleMeasure": return (IfcSolidAngleMeasure)numericResult;
                    case "IfcSoundPowerLevelMeasure": return (IfcSoundPowerLevelMeasure)numericResult;
                    case "IfcSoundPowerMeasure": return (IfcSoundPowerMeasure)numericResult;
                    case "IfcSoundPressureLevelMeasure": return (IfcSoundPressureLevelMeasure)numericResult;
                    case "IfcSoundPressureMeasure": return (IfcSoundPressureMeasure)numericResult;
                    case "IfcSpecificHeatCapacityMeasure": return (IfcSpecificHeatCapacityMeasure)numericResult;
                    case "IfcSpecularExponent": return (IfcSpecularExponent)numericResult;
                    case "IfcSpecularRoughness": return (IfcSpecularRoughness)numericResult;
                    case "IfcTemperatureGradientMeasure": return (IfcTemperatureGradientMeasure)numericResult;
                    case "IfcTemperatureRateOfChangeMeasure": return (IfcTemperatureRateOfChangeMeasure)numericResult;
                    case "IfcThermalAdmittanceMeasure": return (IfcThermalAdmittanceMeasure)numericResult;
                    case "IfcThermalConductivityMeasure": return (IfcThermalConductivityMeasure)numericResult;
                    case "IfcThermalExpansionCoefficientMeasure": return (IfcThermalExpansionCoefficientMeasure)numericResult;
                    case "IfcThermalResistanceMeasure": return (IfcThermalResistanceMeasure)numericResult;
                    case "IfcThermalTransmittanceMeasure": return (IfcThermalTransmittanceMeasure)numericResult;
                    case "IfcThermodynamicTemperatureMeasure": return (IfcThermodynamicTemperatureMeasure)numericResult;
                    case "IfcTimeMeasure": return (IfcTimeMeasure)numericResult;
                    case "IfcTimeStamp": return (IfcTimeStamp)numericResult;
                    case "IfcTorqueMeasure": return (IfcTorqueMeasure)numericResult;
                    case "IfcVaporPermeabilityMeasure": return (IfcVaporPermeabilityMeasure)numericResult;
                    case "IfcVolumeMeasure": return (IfcVolumeMeasure)numericResult;
                    case "IfcVolumetricFlowRateMeasure": return (IfcVolumetricFlowRateMeasure)numericResult;
                    case "IfcWarpingConstantMeasure": return (IfcWarpingConstantMeasure)numericResult;
                    case "IfcWarpingMomentMeasure": return (IfcWarpingMomentMeasure)numericResult;
                }
            }

            //logical 
            if (input == ".T.")
            {
                switch (type.Name)
                {
                    case "IfcBoolean": return (IfcBoolean)true;
                    case "IfcLogical": return (IfcLogical)true;
                }
            }
            if (input == ".F.")
            {
                switch (type.Name)
                {
                    case "IfcBoolean": return (IfcBoolean)false;
                    case "IfcLogical": return (IfcLogical)false;
                }
            }
            if (input == ".U." && type.Name == "IfcLogical")
            {
                return null;
            }
            //enum
            if (input.Substring(0, 1) == ".")
            {
                switch (type.Name)
                {
                    case "IfcActionRequestTypeEnum": return (IfcActionRequestTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcActionSourceTypeEnum": return (IfcActionSourceTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcActionTypeEnum": return (IfcActionTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcActuatorTypeEnum": return (IfcActuatorTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcAddressTypeEnum": return (IfcAddressTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcAirTerminalBoxTypeEnum": return (IfcAirTerminalBoxTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcAirTerminalTypeEnum": return (IfcAirTerminalTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcAirToAirHeatRecoveryTypeEnum": return (IfcAirToAirHeatRecoveryTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcAlarmTypeEnum": return (IfcAlarmTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcAnalysisModelTypeEnum": return (IfcAnalysisModelTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcAnalysisTheoryTypeEnum": return (IfcAnalysisTheoryTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcArithmeticOperatorEnum": return (IfcArithmeticOperatorEnum)input.Substring(1, input.Length - 2);
                    case "IfcAssemblyPlaceEnum": return (IfcAssemblyPlaceEnum)input.Substring(1, input.Length - 2);
                    case "IfcAudioVisualApplianceTypeEnum": return (IfcAudioVisualApplianceTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcBSplineCurveForm": return (IfcBSplineCurveForm)input.Substring(1, input.Length - 2);
                    case "IfcBSplineSurfaceForm": return (IfcBSplineSurfaceForm)input.Substring(1, input.Length - 2);
                    case "IfcBeamTypeEnum": return (IfcBeamTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcBenchmarkEnum": return (IfcBenchmarkEnum)input.Substring(1, input.Length - 2);
                    case "IfcBoilerTypeEnum": return (IfcBoilerTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcBooleanOperator": return (IfcBooleanOperator)input.Substring(1, input.Length - 2);
                    case "IfcBuildingElementPartTypeEnum": return (IfcBuildingElementPartTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcBuildingElementProxyTypeEnum": return (IfcBuildingElementProxyTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcBuildingSystemTypeEnum": return (IfcBuildingSystemTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcBurnerTypeEnum": return (IfcBurnerTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcCableCarrierFittingTypeEnum": return (IfcCableCarrierFittingTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcCableCarrierSegmentTypeEnum": return (IfcCableCarrierSegmentTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcCableFittingTypeEnum": return (IfcCableFittingTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcCableSegmentTypeEnum": return (IfcCableSegmentTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcChangeActionEnum": return (IfcChangeActionEnum)input.Substring(1, input.Length - 2);
                    case "IfcChillerTypeEnum": return (IfcChillerTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcChimneyTypeEnum": return (IfcChimneyTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcCoilTypeEnum": return (IfcCoilTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcColumnTypeEnum": return (IfcColumnTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcCommunicationsApplianceTypeEnum": return (IfcCommunicationsApplianceTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcComplexPropertyTemplateTypeEnum": return (IfcComplexPropertyTemplateTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcCompressorTypeEnum": return (IfcCompressorTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcCondenserTypeEnum": return (IfcCondenserTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcConnectionTypeEnum": return (IfcConnectionTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcConstraintEnum": return (IfcConstraintEnum)input.Substring(1, input.Length - 2);
                    case "IfcConstructionEquipmentResourceTypeEnum": return (IfcConstructionEquipmentResourceTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcConstructionMaterialResourceTypeEnum": return (IfcConstructionMaterialResourceTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcConstructionProductResourceTypeEnum": return (IfcConstructionProductResourceTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcControllerTypeEnum": return (IfcControllerTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcCooledBeamTypeEnum": return (IfcCooledBeamTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcCoolingTowerTypeEnum": return (IfcCoolingTowerTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcCostItemTypeEnum": return (IfcCostItemTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcCostScheduleTypeEnum": return (IfcCostScheduleTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcCoveringTypeEnum": return (IfcCoveringTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcCrewResourceTypeEnum": return (IfcCrewResourceTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcCurtainWallTypeEnum": return (IfcCurtainWallTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcCurveInterpolationEnum": return (IfcCurveInterpolationEnum)input.Substring(1, input.Length - 2);
                    case "IfcDamperTypeEnum": return (IfcDamperTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcDataOriginEnum": return (IfcDataOriginEnum)input.Substring(1, input.Length - 2);
                    case "IfcDerivedUnitEnum": return (IfcDerivedUnitEnum)input.Substring(1, input.Length - 2);
                    case "IfcDirectionSenseEnum": return (IfcDirectionSenseEnum)input.Substring(1, input.Length - 2);
                    case "IfcDiscreteAccessoryTypeEnum": return (IfcDiscreteAccessoryTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcDistributionChamberElementTypeEnum": return (IfcDistributionChamberElementTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcDistributionPortTypeEnum": return (IfcDistributionPortTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcDistributionSystemEnum": return (IfcDistributionSystemEnum)input.Substring(1, input.Length - 2);
                    case "IfcDocumentConfidentialityEnum": return (IfcDocumentConfidentialityEnum)input.Substring(1, input.Length - 2);
                    case "IfcDocumentStatusEnum": return (IfcDocumentStatusEnum)input.Substring(1, input.Length - 2);
                    case "IfcDoorPanelOperationEnum": return (IfcDoorPanelOperationEnum)input.Substring(1, input.Length - 2);
                    case "IfcDoorPanelPositionEnum": return (IfcDoorPanelPositionEnum)input.Substring(1, input.Length - 2);
                    case "IfcDoorStyleConstructionEnum": return (IfcDoorStyleConstructionEnum)input.Substring(1, input.Length - 2);
                    case "IfcDoorStyleOperationEnum": return (IfcDoorStyleOperationEnum)input.Substring(1, input.Length - 2);
                    case "IfcDoorTypeEnum": return (IfcDoorTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcDoorTypeOperationEnum": return (IfcDoorTypeOperationEnum)input.Substring(1, input.Length - 2);
                    case "IfcDuctFittingTypeEnum": return (IfcDuctFittingTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcDuctSegmentTypeEnum": return (IfcDuctSegmentTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcDuctSilencerTypeEnum": return (IfcDuctSilencerTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcElectricApplianceTypeEnum": return (IfcElectricApplianceTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcElectricDistributionBoardTypeEnum": return (IfcElectricDistributionBoardTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcElectricFlowStorageDeviceTypeEnum": return (IfcElectricFlowStorageDeviceTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcElectricGeneratorTypeEnum": return (IfcElectricGeneratorTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcElectricMotorTypeEnum": return (IfcElectricMotorTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcElectricTimeControlTypeEnum": return (IfcElectricTimeControlTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcElementAssemblyTypeEnum": return (IfcElementAssemblyTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcElementCompositionEnum": return (IfcElementCompositionEnum)input.Substring(1, input.Length - 2);
                    case "IfcEngineTypeEnum": return (IfcEngineTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcEvaporativeCoolerTypeEnum": return (IfcEvaporativeCoolerTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcEvaporatorTypeEnum": return (IfcEvaporatorTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcEventTriggerTypeEnum": return (IfcEventTriggerTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcEventTypeEnum": return (IfcEventTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcExternalSpatialElementTypeEnum": return (IfcExternalSpatialElementTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcFanTypeEnum": return (IfcFanTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcFastenerTypeEnum": return (IfcFastenerTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcFilterTypeEnum": return (IfcFilterTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcFireSuppressionTerminalTypeEnum": return (IfcFireSuppressionTerminalTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcFlowDirectionEnum": return (IfcFlowDirectionEnum)input.Substring(1, input.Length - 2);
                    case "IfcFlowInstrumentTypeEnum": return (IfcFlowInstrumentTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcFlowMeterTypeEnum": return (IfcFlowMeterTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcFootingTypeEnum": return (IfcFootingTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcFurnitureTypeEnum": return (IfcFurnitureTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcGeographicElementTypeEnum": return (IfcGeographicElementTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcGeometricProjectionEnum": return (IfcGeometricProjectionEnum)input.Substring(1, input.Length - 2);
                    case "IfcGlobalOrLocalEnum": return (IfcGlobalOrLocalEnum)input.Substring(1, input.Length - 2);
                    case "IfcGridTypeEnum": return (IfcGridTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcHeatExchangerTypeEnum": return (IfcHeatExchangerTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcHumidifierTypeEnum": return (IfcHumidifierTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcInterceptorTypeEnum": return (IfcInterceptorTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcInternalOrExternalEnum": return (IfcInternalOrExternalEnum)input.Substring(1, input.Length - 2);
                    case "IfcInventoryTypeEnum": return (IfcInventoryTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcJunctionBoxTypeEnum": return (IfcJunctionBoxTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcKnotType": return (IfcKnotType)input.Substring(1, input.Length - 2);
                    case "IfcLaborResourceTypeEnum": return (IfcLaborResourceTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcLampTypeEnum": return (IfcLampTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcLayerSetDirectionEnum": return (IfcLayerSetDirectionEnum)input.Substring(1, input.Length - 2);
                    case "IfcLightDistributionCurveEnum": return (IfcLightDistributionCurveEnum)input.Substring(1, input.Length - 2);
                    case "IfcLightEmissionSourceEnum": return (IfcLightEmissionSourceEnum)input.Substring(1, input.Length - 2);
                    case "IfcLightFixtureTypeEnum": return (IfcLightFixtureTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcLoadGroupTypeEnum": return (IfcLoadGroupTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcLogicalOperatorEnum": return (IfcLogicalOperatorEnum)input.Substring(1, input.Length - 2);
                    case "IfcMechanicalFastenerTypeEnum": return (IfcMechanicalFastenerTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcMedicalDeviceTypeEnum": return (IfcMedicalDeviceTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcMemberTypeEnum": return (IfcMemberTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcMotorConnectionTypeEnum": return (IfcMotorConnectionTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcNullStyle": return (IfcNullStyle)input.Substring(1, input.Length - 2);
                    case "IfcObjectTypeEnum": return (IfcObjectTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcObjectiveEnum": return (IfcObjectiveEnum)input.Substring(1, input.Length - 2);
                    case "IfcOccupantTypeEnum": return (IfcOccupantTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcOpeningElementTypeEnum": return (IfcOpeningElementTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcOutletTypeEnum": return (IfcOutletTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcPerformanceHistoryTypeEnum": return (IfcPerformanceHistoryTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcPermeableCoveringOperationEnum": return (IfcPermeableCoveringOperationEnum)input.Substring(1, input.Length - 2);
                    case "IfcPermitTypeEnum": return (IfcPermitTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcPhysicalOrVirtualEnum": return (IfcPhysicalOrVirtualEnum)input.Substring(1, input.Length - 2);
                    case "IfcPileConstructionEnum": return (IfcPileConstructionEnum)input.Substring(1, input.Length - 2);
                    case "IfcPileTypeEnum": return (IfcPileTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcPipeFittingTypeEnum": return (IfcPipeFittingTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcPipeSegmentTypeEnum": return (IfcPipeSegmentTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcPlateTypeEnum": return (IfcPlateTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcPreferredSurfaceCurveRepresentation": return (IfcPreferredSurfaceCurveRepresentation)input.Substring(1, input.Length - 2);
                    case "IfcProcedureTypeEnum": return (IfcProcedureTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcProfileTypeEnum": return (IfcProfileTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcProjectOrderTypeEnum": return (IfcProjectOrderTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcProjectedOrTrueLengthEnum": return (IfcProjectedOrTrueLengthEnum)input.Substring(1, input.Length - 2);
                    case "IfcProjectionElementTypeEnum": return (IfcProjectionElementTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcPropertySetTemplateTypeEnum": return (IfcPropertySetTemplateTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcProtectiveDeviceTrippingUnitTypeEnum": return (IfcProtectiveDeviceTrippingUnitTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcProtectiveDeviceTypeEnum": return (IfcProtectiveDeviceTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcPumpTypeEnum": return (IfcPumpTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcRailingTypeEnum": return (IfcRailingTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcRampFlightTypeEnum": return (IfcRampFlightTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcRampTypeEnum": return (IfcRampTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcRecurrenceTypeEnum": return (IfcRecurrenceTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcReflectanceMethodEnum": return (IfcReflectanceMethodEnum)input.Substring(1, input.Length - 2);
                    case "IfcReinforcingBarRoleEnum": return (IfcReinforcingBarRoleEnum)input.Substring(1, input.Length - 2);
                    case "IfcReinforcingBarSurfaceEnum": return (IfcReinforcingBarSurfaceEnum)input.Substring(1, input.Length - 2);
                    case "IfcReinforcingBarTypeEnum": return (IfcReinforcingBarTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcReinforcingMeshTypeEnum": return (IfcReinforcingMeshTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcRoleEnum": return (IfcRoleEnum)input.Substring(1, input.Length - 2);
                    case "IfcRoofTypeEnum": return (IfcRoofTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcSIPrefix": return (IfcSIPrefix)input.Substring(1, input.Length - 2);
                    case "IfcSIUnitName": return (IfcSIUnitName)input.Substring(1, input.Length - 2);
                    case "IfcSanitaryTerminalTypeEnum": return (IfcSanitaryTerminalTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcSectionTypeEnum": return (IfcSectionTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcSensorTypeEnum": return (IfcSensorTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcSequenceEnum": return (IfcSequenceEnum)input.Substring(1, input.Length - 2);
                    case "IfcShadingDeviceTypeEnum": return (IfcShadingDeviceTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcSimplePropertyTemplateTypeEnum": return (IfcSimplePropertyTemplateTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcSlabTypeEnum": return (IfcSlabTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcSolarDeviceTypeEnum": return (IfcSolarDeviceTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcSpaceHeaterTypeEnum": return (IfcSpaceHeaterTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcSpaceTypeEnum": return (IfcSpaceTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcSpatialZoneTypeEnum": return (IfcSpatialZoneTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcStackTerminalTypeEnum": return (IfcStackTerminalTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcStairFlightTypeEnum": return (IfcStairFlightTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcStairTypeEnum": return (IfcStairTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcStateEnum": return (IfcStateEnum)input.Substring(1, input.Length - 2);
                    case "IfcStructuralCurveActivityTypeEnum": return (IfcStructuralCurveActivityTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcStructuralCurveMemberTypeEnum": return (IfcStructuralCurveMemberTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcStructuralSurfaceActivityTypeEnum": return (IfcStructuralSurfaceActivityTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcStructuralSurfaceMemberTypeEnum": return (IfcStructuralSurfaceMemberTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcSubContractResourceTypeEnum": return (IfcSubContractResourceTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcSurfaceFeatureTypeEnum": return (IfcSurfaceFeatureTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcSurfaceSide": return (IfcSurfaceSide)input.Substring(1, input.Length - 2);
                    case "IfcSwitchingDeviceTypeEnum": return (IfcSwitchingDeviceTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcSystemFurnitureElementTypeEnum": return (IfcSystemFurnitureElementTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcTankTypeEnum": return (IfcTankTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcTaskDurationEnum": return (IfcTaskDurationEnum)input.Substring(1, input.Length - 2);
                    case "IfcTaskTypeEnum": return (IfcTaskTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcTendonAnchorTypeEnum": return (IfcTendonAnchorTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcTendonTypeEnum": return (IfcTendonTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcTextPath": return (IfcTextPath)input.Substring(1, input.Length - 2);
                    case "IfcTimeSeriesDataTypeEnum": return (IfcTimeSeriesDataTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcTransformerTypeEnum": return (IfcTransformerTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcTransitionCode": return (IfcTransitionCode)input.Substring(1, input.Length - 2);
                    case "IfcTransportElementTypeEnum": return (IfcTransportElementTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcTrimmingPreference": return (IfcTrimmingPreference)input.Substring(1, input.Length - 2);
                    case "IfcTubeBundleTypeEnum": return (IfcTubeBundleTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcUnitEnum": return (IfcUnitEnum)input.Substring(1, input.Length - 2);
                    case "IfcUnitaryControlElementTypeEnum": return (IfcUnitaryControlElementTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcUnitaryEquipmentTypeEnum": return (IfcUnitaryEquipmentTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcValveTypeEnum": return (IfcValveTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcVibrationIsolatorTypeEnum": return (IfcVibrationIsolatorTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcVoidingFeatureTypeEnum": return (IfcVoidingFeatureTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcWallTypeEnum": return (IfcWallTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcWasteTerminalTypeEnum": return (IfcWasteTerminalTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcWindowPanelOperationEnum": return (IfcWindowPanelOperationEnum)input.Substring(1, input.Length - 2);
                    case "IfcWindowPanelPositionEnum": return (IfcWindowPanelPositionEnum)input.Substring(1, input.Length - 2);
                    case "IfcWindowStyleConstructionEnum": return (IfcWindowStyleConstructionEnum)input.Substring(1, input.Length - 2);
                    case "IfcWindowStyleOperationEnum": return (IfcWindowStyleOperationEnum)input.Substring(1, input.Length - 2);
                    case "IfcWindowTypeEnum": return (IfcWindowTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcWindowTypePartitioningEnum": return (IfcWindowTypePartitioningEnum)input.Substring(1, input.Length - 2);
                    case "IfcWorkCalendarTypeEnum": return (IfcWorkCalendarTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcWorkPlanTypeEnum": return (IfcWorkPlanTypeEnum)input.Substring(1, input.Length - 2);
                    case "IfcWorkScheduleTypeEnum": return (IfcWorkScheduleTypeEnum)input.Substring(1, input.Length - 2);
                }
            }

            //Lit
            if (input.Substring(0, 1) == "(")
            {
                dynamic elements;
                var elementInput = SplitParamText(input.Substring(1, input.Length - 2));
                Type elementType;
                if (type.Name == "List`1")
                {
                    string fullName = type.FullName;
                    var index1 = fullName.IndexOf("[");
                    var index2 = fullName.IndexOf(",");
                    string elementTypeName = fullName.Substring(index1 + 2, index2 - index1  - 2);
                    elementType = Type.GetType(elementTypeName);
                    elements = CreateList(elementTypeName);                   
                }
                else
                {
                    elements = CreateNew(type.Name.ToUpper());
                    switch (type.Name)
                    {
                        case "IfcArcIndex":
                            elementType = Type.GetType("IFC4.IfcPositiveInteger");
                            break;
                        case "IfcComplexNumber":
                            elementType = Type.GetType("IFC4.REAL");
                            break;
                        case "IfcCompoundPlaneAngleMeasure":
                            elementType = Type.GetType("IFC4.INTEGER");
                            break;
                        case "IfcLineIndex":
                            elementType = Type.GetType("IFC4.INTEGER");
                            break;
                        case "IfcPropertySetDefinitionSet":
                            elementType = Type.GetType("IFC4.IfcPropertySetDefinition");
                            break;
                        default:
                            elementType = null;
                            break;
                    }
                  
                }
                foreach (var word in elementInput)
                {
                    var elemment = GetInstance(word, elementType);
                    elements.Add(elemment);
                }
                return elements;
            }

            if (input.Contains("("))
            {
                int index1 = input.IndexOf("(");
                int index2= input.IndexOf(")");
                string inputTypeName = input.Substring(0, index1);
                string parameter = input.Substring(index1 + 1, index2 - index1 - 1);
                Type inputType = CreateNew(inputTypeName).GetType();
                if(inputType != null)
                {
                    return GetInstance(parameter, inputType);
                }
               
            }
            Console.WriteLine("ERROR :" + input + " : " + type.FullName);
            return null;
        }

        private dynamic CreateNew(string name)
        {
           
            switch (name)
            {
                case "IFCABSORBEDDOSEMEASURE":
                    return new IfcAbsorbedDoseMeasure();
                case "IFCACCELERATIONMEASURE":
                    return new IfcAccelerationMeasure();
                case "IFCAMOUNTOFSUBSTANCEMEASURE":
                    return new IfcAmountOfSubstanceMeasure();
                case "IFCANGULARVELOCITYMEASURE":
                    return new IfcAngularVelocityMeasure();
                case "IFCARCINDEX":
                    return new IfcArcIndex();
                case "IFCAREADENSITYMEASURE":
                    return new IfcAreaDensityMeasure();
                case "IFCAREAMEASURE":
                    return new IfcAreaMeasure();
                case "IFCBINARY":
                    return new IfcBinary();
                case "IFCBOOLEAN":
                    return new IfcBoolean();
                case "IFCBOXALIGNMENT":
                    return new IfcBoxAlignment();
                case "IFCCARDINALPOINTREFERENCE":
                    return new IfcCardinalPointReference();
                case "IFCCOMPLEXNUMBER":
                    return new IfcComplexNumber();
                case "IFCCOMPOUNDPLANEANGLEMEASURE":
                    return new IfcCompoundPlaneAngleMeasure();
                case "IFCCONTEXTDEPENDENTMEASURE":
                    return new IfcContextDependentMeasure();
                case "IFCCOUNTMEASURE":
                    return new IfcCountMeasure();
                case "IFCCURVATUREMEASURE":
                    return new IfcCurvatureMeasure();
                case "IFCDATE":
                    return new IfcDate();
                case "IFCDATETIME":
                    return new IfcDateTime();
                case "IFCDAYINMONTHNUMBER":
                    return new IfcDayInMonthNumber();
                case "IFCDAYINWEEKNUMBER":
                    return new IfcDayInWeekNumber();
                case "IFCDESCRIPTIVEMEASURE":
                    return new IfcDescriptiveMeasure();
                case "IFCDIMENSIONCOUNT":
                    return new IfcDimensionCount();
                case "IFCDOSEEQUIVALENTMEASURE":
                    return new IfcDoseEquivalentMeasure();
                case "IFCDURATION":
                    return new IfcDuration();
                case "IFCDYNAMICVISCOSITYMEASURE":
                    return new IfcDynamicViscosityMeasure();
                case "IFCELECTRICCAPACITANCEMEASURE":
                    return new IfcElectricCapacitanceMeasure();
                case "IFCELECTRICCHARGEMEASURE":
                    return new IfcElectricChargeMeasure();
                case "IFCELECTRICCONDUCTANCEMEASURE":
                    return new IfcElectricConductanceMeasure();
                case "IFCELECTRICCURRENTMEASURE":
                    return new IfcElectricCurrentMeasure();
                case "IFCELECTRICRESISTANCEMEASURE":
                    return new IfcElectricResistanceMeasure();
                case "IFCELECTRICVOLTAGEMEASURE":
                    return new IfcElectricVoltageMeasure();
                case "IFCENERGYMEASURE":
                    return new IfcEnergyMeasure();
                case "IFCFONTSTYLE":
                    return new IfcFontStyle();
                case "IFCFONTVARIANT":
                    return new IfcFontVariant();
                case "IFCFONTWEIGHT":
                    return new IfcFontWeight();
                case "IFCFORCEMEASURE":
                    return new IfcForceMeasure();
                case "IFCFREQUENCYMEASURE":
                    return new IfcFrequencyMeasure();
                case "IFCGLOBALLYUNIQUEID":
                    return new IfcGloballyUniqueId();
                case "IFCHEATFLUXDENSITYMEASURE":
                    return new IfcHeatFluxDensityMeasure();
                case "IFCHEATINGVALUEMEASURE":
                    return new IfcHeatingValueMeasure();
                case "IFCIDENTIFIER":
                    return new IfcIdentifier();
                case "IFCILLUMINANCEMEASURE":
                    return new IfcIlluminanceMeasure();
                case "IFCINDUCTANCEMEASURE":
                    return new IfcInductanceMeasure();
                case "IFCINTEGER":
                    return new IfcInteger();
                case "IFCINTEGERCOUNTRATEMEASURE":
                    return new IfcIntegerCountRateMeasure();
                case "IFCIONCONCENTRATIONMEASURE":
                    return new IfcIonConcentrationMeasure();
                case "IFCISOTHERMALMOISTURECAPACITYMEASURE":
                    return new IfcIsothermalMoistureCapacityMeasure();
                case "IFCKINEMATICVISCOSITYMEASURE":
                    return new IfcKinematicViscosityMeasure();
                case "IFCLABEL":
                    return new IfcLabel();
                case "IFCLANGUAGEID":
                    return new IfcLanguageId();
                case "IFCLENGTHMEASURE":
                    return new IfcLengthMeasure();
                case "IFCLINEINDEX":
                    return new IfcLineIndex();
                case "IFCLINEARFORCEMEASURE":
                    return new IfcLinearForceMeasure();
                case "IFCLINEARMOMENTMEASURE":
                    return new IfcLinearMomentMeasure();
                case "IFCLINEARSTIFFNESSMEASURE":
                    return new IfcLinearStiffnessMeasure();
                case "IFCLINEARVELOCITYMEASURE":
                    return new IfcLinearVelocityMeasure();
                case "IFCLOGICAL":
                    return new IfcLogical();
                case "IFCLUMINOUSFLUXMEASURE":
                    return new IfcLuminousFluxMeasure();
                case "IFCLUMINOUSINTENSITYDISTRIBUTIONMEASURE":
                    return new IfcLuminousIntensityDistributionMeasure();
                case "IFCLUMINOUSINTENSITYMEASURE":
                    return new IfcLuminousIntensityMeasure();
                case "IFCMAGNETICFLUXDENSITYMEASURE":
                    return new IfcMagneticFluxDensityMeasure();
                case "IFCMAGNETICFLUXMEASURE":
                    return new IfcMagneticFluxMeasure();
                case "IFCMASSDENSITYMEASURE":
                    return new IfcMassDensityMeasure();
                case "IFCMASSFLOWRATEMEASURE":
                    return new IfcMassFlowRateMeasure();
                case "IFCMASSMEASURE":
                    return new IfcMassMeasure();
                case "IFCMASSPERLENGTHMEASURE":
                    return new IfcMassPerLengthMeasure();
                case "IFCMODULUSOFELASTICITYMEASURE":
                    return new IfcModulusOfElasticityMeasure();
                case "IFCMODULUSOFLINEARSUBGRADEREACTIONMEASURE":
                    return new IfcModulusOfLinearSubgradeReactionMeasure();
                case "IFCMODULUSOFROTATIONALSUBGRADEREACTIONMEASURE":
                    return new IfcModulusOfRotationalSubgradeReactionMeasure();
                case "IFCMODULUSOFSUBGRADEREACTIONMEASURE":
                    return new IfcModulusOfSubgradeReactionMeasure();
                case "IFCMOISTUREDIFFUSIVITYMEASURE":
                    return new IfcMoistureDiffusivityMeasure();
                case "IFCMOLECULARWEIGHTMEASURE":
                    return new IfcMolecularWeightMeasure();
                case "IFCMOMENTOFINERTIAMEASURE":
                    return new IfcMomentOfInertiaMeasure();
                case "IFCMONETARYMEASURE":
                    return new IfcMonetaryMeasure();
                case "IFCMONTHINYEARNUMBER":
                    return new IfcMonthInYearNumber();
                case "IFCNONNEGATIVELENGTHMEASURE":
                    return new IfcNonNegativeLengthMeasure();
                case "IFCNORMALISEDRATIOMEASURE":
                    return new IfcNormalisedRatioMeasure();
                case "IFCNUMERICMEASURE":
                    return new IfcNumericMeasure();
                case "IFCPHMEASURE":
                    return new IfcPHMeasure();
                case "IFCPARAMETERVALUE":
                    return new IfcParameterValue();
                case "IFCPLANARFORCEMEASURE":
                    return new IfcPlanarForceMeasure();
                case "IFCPLANEANGLEMEASURE":
                    return new IfcPlaneAngleMeasure();
                case "IFCPOSITIVEINTEGER":
                    return new IfcPositiveInteger();
                case "IFCPOSITIVELENGTHMEASURE":
                    return new IfcPositiveLengthMeasure();
                case "IFCPOSITIVEPLANEANGLEMEASURE":
                    return new IfcPositivePlaneAngleMeasure();
                case "IFCPOSITIVERATIOMEASURE":
                    return new IfcPositiveRatioMeasure();
                case "IFCPOWERMEASURE":
                    return new IfcPowerMeasure();
                case "IFCPRESENTABLETEXT":
                    return new IfcPresentableText();
                case "IFCPRESSUREMEASURE":
                    return new IfcPressureMeasure();
                case "IFCPROPERTYSETDEFINITIONSET":
                    return new IfcPropertySetDefinitionSet();
                case "IFCRADIOACTIVITYMEASURE":
                    return new IfcRadioActivityMeasure();
                case "IFCRATIOMEASURE":
                    return new IfcRatioMeasure();
                case "IFCREAL":
                    return new IfcReal();
                case "IFCROTATIONALFREQUENCYMEASURE":
                    return new IfcRotationalFrequencyMeasure();
                case "IFCROTATIONALMASSMEASURE":
                    return new IfcRotationalMassMeasure();
                case "IFCROTATIONALSTIFFNESSMEASURE":
                    return new IfcRotationalStiffnessMeasure();
                case "IFCSECTIONMODULUSMEASURE":
                    return new IfcSectionModulusMeasure();
                case "IFCSECTIONALAREAINTEGRALMEASURE":
                    return new IfcSectionalAreaIntegralMeasure();
                case "IFCSHEARMODULUSMEASURE":
                    return new IfcShearModulusMeasure();
                case "IFCSOLIDANGLEMEASURE":
                    return new IfcSolidAngleMeasure();
                case "IFCSOUNDPOWERLEVELMEASURE":
                    return new IfcSoundPowerLevelMeasure();
                case "IFCSOUNDPOWERMEASURE":
                    return new IfcSoundPowerMeasure();
                case "IFCSOUNDPRESSURELEVELMEASURE":
                    return new IfcSoundPressureLevelMeasure();
                case "IFCSOUNDPRESSUREMEASURE":
                    return new IfcSoundPressureMeasure();
                case "IFCSPECIFICHEATCAPACITYMEASURE":
                    return new IfcSpecificHeatCapacityMeasure();
                case "IFCSPECULAREXPONENT":
                    return new IfcSpecularExponent();
                case "IFCSPECULARROUGHNESS":
                    return new IfcSpecularRoughness();
                case "IFCTEMPERATUREGRADIENTMEASURE":
                    return new IfcTemperatureGradientMeasure();
                case "IFCTEMPERATURERATEOFCHANGEMEASURE":
                    return new IfcTemperatureRateOfChangeMeasure();
                case "IFCTEXT":
                    return new IfcText();
                case "IFCTEXTALIGNMENT":
                    return new IfcTextAlignment();
                case "IFCTEXTDECORATION":
                    return new IfcTextDecoration();
                case "IFCTEXTFONTNAME":
                    return new IfcTextFontName();
                case "IFCTEXTTRANSFORMATION":
                    return new IfcTextTransformation();
                case "IFCTHERMALADMITTANCEMEASURE":
                    return new IfcThermalAdmittanceMeasure();
                case "IFCTHERMALCONDUCTIVITYMEASURE":
                    return new IfcThermalConductivityMeasure();
                case "IFCTHERMALEXPANSIONCOEFFICIENTMEASURE":
                    return new IfcThermalExpansionCoefficientMeasure();
                case "IFCTHERMALRESISTANCEMEASURE":
                    return new IfcThermalResistanceMeasure();
                case "IFCTHERMALTRANSMITTANCEMEASURE":
                    return new IfcThermalTransmittanceMeasure();
                case "IFCTHERMODYNAMICTEMPERATUREMEASURE":
                    return new IfcThermodynamicTemperatureMeasure();
                case "IFCTIME":
                    return new IfcTime();
                case "IFCTIMEMEASURE":
                    return new IfcTimeMeasure();
                case "IFCTIMESTAMP":
                    return new IfcTimeStamp();
                case "IFCTORQUEMEASURE":
                    return new IfcTorqueMeasure();
                case "IFCURIREFERENCE":
                    return new IfcURIReference();
                case "IFCVAPORPERMEABILITYMEASURE":
                    return new IfcVaporPermeabilityMeasure();
                case "IFCVOLUMEMEASURE":
                    return new IfcVolumeMeasure();
                case "IFCVOLUMETRICFLOWRATEMEASURE":
                    return new IfcVolumetricFlowRateMeasure();
                case "IFCWARPINGCONSTANTMEASURE":
                    return new IfcWarpingConstantMeasure();
                case "IFCWARPINGMOMENTMEASURE":
                    return new IfcWarpingMomentMeasure();
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




        private dynamic CreateList(string name)
        {
            switch (name.Replace("IFC4.",""))
            {
                case "IfcAbsorbedDoseMeasure":
                    return new List<IfcAbsorbedDoseMeasure>();
                case "IfcAccelerationMeasure":
                    return new List<IfcAccelerationMeasure>();
                case "IfcAmountOfSubstanceMeasure":
                    return new List<IfcAmountOfSubstanceMeasure>();
                case "IfcAngularVelocityMeasure":
                    return new List<IfcAngularVelocityMeasure>();
                case "IfcArcIndex":
                    return new List<IfcArcIndex>();
                case "IfcAreaDensityMeasure":
                    return new List<IfcAreaDensityMeasure>();
                case "IfcAreaMeasure":
                    return new List<IfcAreaMeasure>();
                case "IfcBinary":
                    return new List<IfcBinary>();
                case "IfcBoolean":
                    return new List<IfcBoolean>();
                case "IfcBoxAlignment":
                    return new List<IfcBoxAlignment>();
                case "IfcCardinalPointReference":
                    return new List<IfcCardinalPointReference>();
                case "IfcComplexNumber":
                    return new List<IfcComplexNumber>();
                case "IfcCompoundPlaneAngleMeasure":
                    return new List<IfcCompoundPlaneAngleMeasure>();
                case "IfcContextDependentMeasure":
                    return new List<IfcContextDependentMeasure>();
                case "IfcCountMeasure":
                    return new List<IfcCountMeasure>();
                case "IfcCurvatureMeasure":
                    return new List<IfcCurvatureMeasure>();
                case "IfcDate":
                    return new List<IfcDate>();
                case "IfcDateTime":
                    return new List<IfcDateTime>();
                case "IfcDayInMonthNumber":
                    return new List<IfcDayInMonthNumber>();
                case "IfcDayInWeekNumber":
                    return new List<IfcDayInWeekNumber>();
                case "IfcDescriptiveMeasure":
                    return new List<IfcDescriptiveMeasure>();
                case "IfcDimensionCount":
                    return new List<IfcDimensionCount>();
                case "IfcDoseEquivalentMeasure":
                    return new List<IfcDoseEquivalentMeasure>();
                case "IfcDuration":
                    return new List<IfcDuration>();
                case "IfcDynamicViscosityMeasure":
                    return new List<IfcDynamicViscosityMeasure>();
                case "IfcElectricCapacitanceMeasure":
                    return new List<IfcElectricCapacitanceMeasure>();
                case "IfcElectricChargeMeasure":
                    return new List<IfcElectricChargeMeasure>();
                case "IfcElectricConductanceMeasure":
                    return new List<IfcElectricConductanceMeasure>();
                case "IfcElectricCurrentMeasure":
                    return new List<IfcElectricCurrentMeasure>();
                case "IfcElectricResistanceMeasure":
                    return new List<IfcElectricResistanceMeasure>();
                case "IfcElectricVoltageMeasure":
                    return new List<IfcElectricVoltageMeasure>();
                case "IfcEnergyMeasure":
                    return new List<IfcEnergyMeasure>();
                case "IfcFontStyle":
                    return new List<IfcFontStyle>();
                case "IfcFontVariant":
                    return new List<IfcFontVariant>();
                case "IfcFontWeight":
                    return new List<IfcFontWeight>();
                case "IfcForceMeasure":
                    return new List<IfcForceMeasure>();
                case "IfcFrequencyMeasure":
                    return new List<IfcFrequencyMeasure>();
                case "IfcGloballyUniqueId":
                    return new List<IfcGloballyUniqueId>();
                case "IfcHeatFluxDensityMeasure":
                    return new List<IfcHeatFluxDensityMeasure>();
                case "IfcHeatingValueMeasure":
                    return new List<IfcHeatingValueMeasure>();
                case "IfcIdentifier":
                    return new List<IfcIdentifier>();
                case "IfcIlluminanceMeasure":
                    return new List<IfcIlluminanceMeasure>();
                case "IfcInductanceMeasure":
                    return new List<IfcInductanceMeasure>();
                case "IfcInteger":
                    return new List<IfcInteger>();
                case "IfcIntegerCountRateMeasure":
                    return new List<IfcIntegerCountRateMeasure>();
                case "IfcIonConcentrationMeasure":
                    return new List<IfcIonConcentrationMeasure>();
                case "IfcIsothermalMoistureCapacityMeasure":
                    return new List<IfcIsothermalMoistureCapacityMeasure>();
                case "IfcKinematicViscosityMeasure":
                    return new List<IfcKinematicViscosityMeasure>();
                case "IfcLabel":
                    return new List<IfcLabel>();
                case "IfcLanguageId":
                    return new List<IfcLanguageId>();
                case "IfcLengthMeasure":
                    return new List<IfcLengthMeasure>();
                case "IfcLineIndex":
                    return new List<IfcLineIndex>();
                case "IfcLinearForceMeasure":
                    return new List<IfcLinearForceMeasure>();
                case "IfcLinearMomentMeasure":
                    return new List<IfcLinearMomentMeasure>();
                case "IfcLinearStiffnessMeasure":
                    return new List<IfcLinearStiffnessMeasure>();
                case "IfcLinearVelocityMeasure":
                    return new List<IfcLinearVelocityMeasure>();
                case "IfcLogical":
                    return new List<IfcLogical>();
                case "IfcLuminousFluxMeasure":
                    return new List<IfcLuminousFluxMeasure>();
                case "IfcLuminousIntensityDistributionMeasure":
                    return new List<IfcLuminousIntensityDistributionMeasure>();
                case "IfcLuminousIntensityMeasure":
                    return new List<IfcLuminousIntensityMeasure>();
                case "IfcMagneticFluxDensityMeasure":
                    return new List<IfcMagneticFluxDensityMeasure>();
                case "IfcMagneticFluxMeasure":
                    return new List<IfcMagneticFluxMeasure>();
                case "IfcMassDensityMeasure":
                    return new List<IfcMassDensityMeasure>();
                case "IfcMassFlowRateMeasure":
                    return new List<IfcMassFlowRateMeasure>();
                case "IfcMassMeasure":
                    return new List<IfcMassMeasure>();
                case "IfcMassPerLengthMeasure":
                    return new List<IfcMassPerLengthMeasure>();
                case "IfcModulusOfElasticityMeasure":
                    return new List<IfcModulusOfElasticityMeasure>();
                case "IfcModulusOfLinearSubgradeReactionMeasure":
                    return new List<IfcModulusOfLinearSubgradeReactionMeasure>();
                case "IfcModulusOfRotationalSubgradeReactionMeasure":
                    return new List<IfcModulusOfRotationalSubgradeReactionMeasure>();
                case "IfcModulusOfSubgradeReactionMeasure":
                    return new List<IfcModulusOfSubgradeReactionMeasure>();
                case "IfcMoistureDiffusivityMeasure":
                    return new List<IfcMoistureDiffusivityMeasure>();
                case "IfcMolecularWeightMeasure":
                    return new List<IfcMolecularWeightMeasure>();
                case "IfcMomentOfInertiaMeasure":
                    return new List<IfcMomentOfInertiaMeasure>();
                case "IfcMonetaryMeasure":
                    return new List<IfcMonetaryMeasure>();
                case "IfcMonthInYearNumber":
                    return new List<IfcMonthInYearNumber>();
                case "IfcNonNegativeLengthMeasure":
                    return new List<IfcNonNegativeLengthMeasure>();
                case "IfcNormalisedRatioMeasure":
                    return new List<IfcNormalisedRatioMeasure>();
                case "IfcNumericMeasure":
                    return new List<IfcNumericMeasure>();
                case "IfcPHMeasure":
                    return new List<IfcPHMeasure>();
                case "IfcParameterValue":
                    return new List<IfcParameterValue>();
                case "IfcPlanarForceMeasure":
                    return new List<IfcPlanarForceMeasure>();
                case "IfcPlaneAngleMeasure":
                    return new List<IfcPlaneAngleMeasure>();
                case "IfcPositiveInteger":
                    return new List<IfcPositiveInteger>();
                case "IfcPositiveLengthMeasure":
                    return new List<IfcPositiveLengthMeasure>();
                case "IfcPositivePlaneAngleMeasure":
                    return new List<IfcPositivePlaneAngleMeasure>();
                case "IfcPositiveRatioMeasure":
                    return new List<IfcPositiveRatioMeasure>();
                case "IfcPowerMeasure":
                    return new List<IfcPowerMeasure>();
                case "IfcPresentableText":
                    return new List<IfcPresentableText>();
                case "IfcPressureMeasure":
                    return new List<IfcPressureMeasure>();
                case "IfcPropertySetDefinitionSet":
                    return new List<IfcPropertySetDefinitionSet>();
                case "IfcRadioActivityMeasure":
                    return new List<IfcRadioActivityMeasure>();
                case "IfcRatioMeasure":
                    return new List<IfcRatioMeasure>();
                case "IfcReal":
                    return new List<IfcReal>();
                case "IfcRotationalFrequencyMeasure":
                    return new List<IfcRotationalFrequencyMeasure>();
                case "IfcRotationalMassMeasure":
                    return new List<IfcRotationalMassMeasure>();
                case "IfcRotationalStiffnessMeasure":
                    return new List<IfcRotationalStiffnessMeasure>();
                case "IfcSectionModulusMeasure":
                    return new List<IfcSectionModulusMeasure>();
                case "IfcSectionalAreaIntegralMeasure":
                    return new List<IfcSectionalAreaIntegralMeasure>();
                case "IfcShearModulusMeasure":
                    return new List<IfcShearModulusMeasure>();
                case "IfcSolidAngleMeasure":
                    return new List<IfcSolidAngleMeasure>();
                case "IfcSoundPowerLevelMeasure":
                    return new List<IfcSoundPowerLevelMeasure>();
                case "IfcSoundPowerMeasure":
                    return new List<IfcSoundPowerMeasure>();
                case "IfcSoundPressureLevelMeasure":
                    return new List<IfcSoundPressureLevelMeasure>();
                case "IfcSoundPressureMeasure":
                    return new List<IfcSoundPressureMeasure>();
                case "IfcSpecificHeatCapacityMeasure":
                    return new List<IfcSpecificHeatCapacityMeasure>();
                case "IfcSpecularExponent":
                    return new List<IfcSpecularExponent>();
                case "IfcSpecularRoughness":
                    return new List<IfcSpecularRoughness>();
                case "IfcTemperatureGradientMeasure":
                    return new List<IfcTemperatureGradientMeasure>();
                case "IfcTemperatureRateOfChangeMeasure":
                    return new List<IfcTemperatureRateOfChangeMeasure>();
                case "IfcText":
                    return new List<IfcText>();
                case "IfcTextAlignment":
                    return new List<IfcTextAlignment>();
                case "IfcTextDecoration":
                    return new List<IfcTextDecoration>();
                case "IfcTextFontName":
                    return new List<IfcTextFontName>();
                case "IfcTextTransformation":
                    return new List<IfcTextTransformation>();
                case "IfcThermalAdmittanceMeasure":
                    return new List<IfcThermalAdmittanceMeasure>();
                case "IfcThermalConductivityMeasure":
                    return new List<IfcThermalConductivityMeasure>();
                case "IfcThermalExpansionCoefficientMeasure":
                    return new List<IfcThermalExpansionCoefficientMeasure>();
                case "IfcThermalResistanceMeasure":
                    return new List<IfcThermalResistanceMeasure>();
                case "IfcThermalTransmittanceMeasure":
                    return new List<IfcThermalTransmittanceMeasure>();
                case "IfcThermodynamicTemperatureMeasure":
                    return new List<IfcThermodynamicTemperatureMeasure>();
                case "IfcTime":
                    return new List<IfcTime>();
                case "IfcTimeMeasure":
                    return new List<IfcTimeMeasure>();
                case "IfcTimeStamp":
                    return new List<IfcTimeStamp>();
                case "IfcTorqueMeasure":
                    return new List<IfcTorqueMeasure>();
                case "IfcURIReference":
                    return new List<IfcURIReference>();
                case "IfcVaporPermeabilityMeasure":
                    return new List<IfcVaporPermeabilityMeasure>();
                case "IfcVolumeMeasure":
                    return new List<IfcVolumeMeasure>();
                case "IfcVolumetricFlowRateMeasure":
                    return new List<IfcVolumetricFlowRateMeasure>();
                case "IfcWarpingConstantMeasure":
                    return new List<IfcWarpingConstantMeasure>();
                case "IfcWarpingMomentMeasure":
                    return new List<IfcWarpingMomentMeasure>();
                case "IfcActionRequestTypeEnum":
                    return new List<IfcActionRequestTypeEnum>();
                case "IfcActionSourceTypeEnum":
                    return new List<IfcActionSourceTypeEnum>();
                case "IfcActionTypeEnum":
                    return new List<IfcActionTypeEnum>();
                case "IfcActuatorTypeEnum":
                    return new List<IfcActuatorTypeEnum>();
                case "IfcAddressTypeEnum":
                    return new List<IfcAddressTypeEnum>();
                case "IfcAirTerminalBoxTypeEnum":
                    return new List<IfcAirTerminalBoxTypeEnum>();
                case "IfcAirTerminalTypeEnum":
                    return new List<IfcAirTerminalTypeEnum>();
                case "IfcAirToAirHeatRecoveryTypeEnum":
                    return new List<IfcAirToAirHeatRecoveryTypeEnum>();
                case "IfcAlarmTypeEnum":
                    return new List<IfcAlarmTypeEnum>();
                case "IfcAnalysisModelTypeEnum":
                    return new List<IfcAnalysisModelTypeEnum>();
                case "IfcAnalysisTheoryTypeEnum":
                    return new List<IfcAnalysisTheoryTypeEnum>();
                case "IfcArithmeticOperatorEnum":
                    return new List<IfcArithmeticOperatorEnum>();
                case "IfcAssemblyPlaceEnum":
                    return new List<IfcAssemblyPlaceEnum>();
                case "IfcAudioVisualApplianceTypeEnum":
                    return new List<IfcAudioVisualApplianceTypeEnum>();
                case "IfcBSplineCurveForm":
                    return new List<IfcBSplineCurveForm>();
                case "IfcBSplineSurfaceForm":
                    return new List<IfcBSplineSurfaceForm>();
                case "IfcBeamTypeEnum":
                    return new List<IfcBeamTypeEnum>();
                case "IfcBenchmarkEnum":
                    return new List<IfcBenchmarkEnum>();
                case "IfcBoilerTypeEnum":
                    return new List<IfcBoilerTypeEnum>();
                case "IfcBooleanOperator":
                    return new List<IfcBooleanOperator>();
                case "IfcBuildingElementPartTypeEnum":
                    return new List<IfcBuildingElementPartTypeEnum>();
                case "IfcBuildingElementProxyTypeEnum":
                    return new List<IfcBuildingElementProxyTypeEnum>();
                case "IfcBuildingSystemTypeEnum":
                    return new List<IfcBuildingSystemTypeEnum>();
                case "IfcBurnerTypeEnum":
                    return new List<IfcBurnerTypeEnum>();
                case "IfcCableCarrierFittingTypeEnum":
                    return new List<IfcCableCarrierFittingTypeEnum>();
                case "IfcCableCarrierSegmentTypeEnum":
                    return new List<IfcCableCarrierSegmentTypeEnum>();
                case "IfcCableFittingTypeEnum":
                    return new List<IfcCableFittingTypeEnum>();
                case "IfcCableSegmentTypeEnum":
                    return new List<IfcCableSegmentTypeEnum>();
                case "IfcChangeActionEnum":
                    return new List<IfcChangeActionEnum>();
                case "IfcChillerTypeEnum":
                    return new List<IfcChillerTypeEnum>();
                case "IfcChimneyTypeEnum":
                    return new List<IfcChimneyTypeEnum>();
                case "IfcCoilTypeEnum":
                    return new List<IfcCoilTypeEnum>();
                case "IfcColumnTypeEnum":
                    return new List<IfcColumnTypeEnum>();
                case "IfcCommunicationsApplianceTypeEnum":
                    return new List<IfcCommunicationsApplianceTypeEnum>();
                case "IfcComplexPropertyTemplateTypeEnum":
                    return new List<IfcComplexPropertyTemplateTypeEnum>();
                case "IfcCompressorTypeEnum":
                    return new List<IfcCompressorTypeEnum>();
                case "IfcCondenserTypeEnum":
                    return new List<IfcCondenserTypeEnum>();
                case "IfcConnectionTypeEnum":
                    return new List<IfcConnectionTypeEnum>();
                case "IfcConstraintEnum":
                    return new List<IfcConstraintEnum>();
                case "IfcConstructionEquipmentResourceTypeEnum":
                    return new List<IfcConstructionEquipmentResourceTypeEnum>();
                case "IfcConstructionMaterialResourceTypeEnum":
                    return new List<IfcConstructionMaterialResourceTypeEnum>();
                case "IfcConstructionProductResourceTypeEnum":
                    return new List<IfcConstructionProductResourceTypeEnum>();
                case "IfcControllerTypeEnum":
                    return new List<IfcControllerTypeEnum>();
                case "IfcCooledBeamTypeEnum":
                    return new List<IfcCooledBeamTypeEnum>();
                case "IfcCoolingTowerTypeEnum":
                    return new List<IfcCoolingTowerTypeEnum>();
                case "IfcCostItemTypeEnum":
                    return new List<IfcCostItemTypeEnum>();
                case "IfcCostScheduleTypeEnum":
                    return new List<IfcCostScheduleTypeEnum>();
                case "IfcCoveringTypeEnum":
                    return new List<IfcCoveringTypeEnum>();
                case "IfcCrewResourceTypeEnum":
                    return new List<IfcCrewResourceTypeEnum>();
                case "IfcCurtainWallTypeEnum":
                    return new List<IfcCurtainWallTypeEnum>();
                case "IfcCurveInterpolationEnum":
                    return new List<IfcCurveInterpolationEnum>();
                case "IfcDamperTypeEnum":
                    return new List<IfcDamperTypeEnum>();
                case "IfcDataOriginEnum":
                    return new List<IfcDataOriginEnum>();
                case "IfcDerivedUnitEnum":
                    return new List<IfcDerivedUnitEnum>();
                case "IfcDirectionSenseEnum":
                    return new List<IfcDirectionSenseEnum>();
                case "IfcDiscreteAccessoryTypeEnum":
                    return new List<IfcDiscreteAccessoryTypeEnum>();
                case "IfcDistributionChamberElementTypeEnum":
                    return new List<IfcDistributionChamberElementTypeEnum>();
                case "IfcDistributionPortTypeEnum":
                    return new List<IfcDistributionPortTypeEnum>();
                case "IfcDistributionSystemEnum":
                    return new List<IfcDistributionSystemEnum>();
                case "IfcDocumentConfidentialityEnum":
                    return new List<IfcDocumentConfidentialityEnum>();
                case "IfcDocumentStatusEnum":
                    return new List<IfcDocumentStatusEnum>();
                case "IfcDoorPanelOperationEnum":
                    return new List<IfcDoorPanelOperationEnum>();
                case "IfcDoorPanelPositionEnum":
                    return new List<IfcDoorPanelPositionEnum>();
                case "IfcDoorStyleConstructionEnum":
                    return new List<IfcDoorStyleConstructionEnum>();
                case "IfcDoorStyleOperationEnum":
                    return new List<IfcDoorStyleOperationEnum>();
                case "IfcDoorTypeEnum":
                    return new List<IfcDoorTypeEnum>();
                case "IfcDoorTypeOperationEnum":
                    return new List<IfcDoorTypeOperationEnum>();
                case "IfcDuctFittingTypeEnum":
                    return new List<IfcDuctFittingTypeEnum>();
                case "IfcDuctSegmentTypeEnum":
                    return new List<IfcDuctSegmentTypeEnum>();
                case "IfcDuctSilencerTypeEnum":
                    return new List<IfcDuctSilencerTypeEnum>();
                case "IfcElectricApplianceTypeEnum":
                    return new List<IfcElectricApplianceTypeEnum>();
                case "IfcElectricDistributionBoardTypeEnum":
                    return new List<IfcElectricDistributionBoardTypeEnum>();
                case "IfcElectricFlowStorageDeviceTypeEnum":
                    return new List<IfcElectricFlowStorageDeviceTypeEnum>();
                case "IfcElectricGeneratorTypeEnum":
                    return new List<IfcElectricGeneratorTypeEnum>();
                case "IfcElectricMotorTypeEnum":
                    return new List<IfcElectricMotorTypeEnum>();
                case "IfcElectricTimeControlTypeEnum":
                    return new List<IfcElectricTimeControlTypeEnum>();
                case "IfcElementAssemblyTypeEnum":
                    return new List<IfcElementAssemblyTypeEnum>();
                case "IfcElementCompositionEnum":
                    return new List<IfcElementCompositionEnum>();
                case "IfcEngineTypeEnum":
                    return new List<IfcEngineTypeEnum>();
                case "IfcEvaporativeCoolerTypeEnum":
                    return new List<IfcEvaporativeCoolerTypeEnum>();
                case "IfcEvaporatorTypeEnum":
                    return new List<IfcEvaporatorTypeEnum>();
                case "IfcEventTriggerTypeEnum":
                    return new List<IfcEventTriggerTypeEnum>();
                case "IfcEventTypeEnum":
                    return new List<IfcEventTypeEnum>();
                case "IfcExternalSpatialElementTypeEnum":
                    return new List<IfcExternalSpatialElementTypeEnum>();
                case "IfcFanTypeEnum":
                    return new List<IfcFanTypeEnum>();
                case "IfcFastenerTypeEnum":
                    return new List<IfcFastenerTypeEnum>();
                case "IfcFilterTypeEnum":
                    return new List<IfcFilterTypeEnum>();
                case "IfcFireSuppressionTerminalTypeEnum":
                    return new List<IfcFireSuppressionTerminalTypeEnum>();
                case "IfcFlowDirectionEnum":
                    return new List<IfcFlowDirectionEnum>();
                case "IfcFlowInstrumentTypeEnum":
                    return new List<IfcFlowInstrumentTypeEnum>();
                case "IfcFlowMeterTypeEnum":
                    return new List<IfcFlowMeterTypeEnum>();
                case "IfcFootingTypeEnum":
                    return new List<IfcFootingTypeEnum>();
                case "IfcFurnitureTypeEnum":
                    return new List<IfcFurnitureTypeEnum>();
                case "IfcGeographicElementTypeEnum":
                    return new List<IfcGeographicElementTypeEnum>();
                case "IfcGeometricProjectionEnum":
                    return new List<IfcGeometricProjectionEnum>();
                case "IfcGlobalOrLocalEnum":
                    return new List<IfcGlobalOrLocalEnum>();
                case "IfcGridTypeEnum":
                    return new List<IfcGridTypeEnum>();
                case "IfcHeatExchangerTypeEnum":
                    return new List<IfcHeatExchangerTypeEnum>();
                case "IfcHumidifierTypeEnum":
                    return new List<IfcHumidifierTypeEnum>();
                case "IfcInterceptorTypeEnum":
                    return new List<IfcInterceptorTypeEnum>();
                case "IfcInternalOrExternalEnum":
                    return new List<IfcInternalOrExternalEnum>();
                case "IfcInventoryTypeEnum":
                    return new List<IfcInventoryTypeEnum>();
                case "IfcJunctionBoxTypeEnum":
                    return new List<IfcJunctionBoxTypeEnum>();
                case "IfcKnotType":
                    return new List<IfcKnotType>();
                case "IfcLaborResourceTypeEnum":
                    return new List<IfcLaborResourceTypeEnum>();
                case "IfcLampTypeEnum":
                    return new List<IfcLampTypeEnum>();
                case "IfcLayerSetDirectionEnum":
                    return new List<IfcLayerSetDirectionEnum>();
                case "IfcLightDistributionCurveEnum":
                    return new List<IfcLightDistributionCurveEnum>();
                case "IfcLightEmissionSourceEnum":
                    return new List<IfcLightEmissionSourceEnum>();
                case "IfcLightFixtureTypeEnum":
                    return new List<IfcLightFixtureTypeEnum>();
                case "IfcLoadGroupTypeEnum":
                    return new List<IfcLoadGroupTypeEnum>();
                case "IfcLogicalOperatorEnum":
                    return new List<IfcLogicalOperatorEnum>();
                case "IfcMechanicalFastenerTypeEnum":
                    return new List<IfcMechanicalFastenerTypeEnum>();
                case "IfcMedicalDeviceTypeEnum":
                    return new List<IfcMedicalDeviceTypeEnum>();
                case "IfcMemberTypeEnum":
                    return new List<IfcMemberTypeEnum>();
                case "IfcMotorConnectionTypeEnum":
                    return new List<IfcMotorConnectionTypeEnum>();
                case "IfcNullStyle":
                    return new List<IfcNullStyle>();
                case "IfcObjectTypeEnum":
                    return new List<IfcObjectTypeEnum>();
                case "IfcObjectiveEnum":
                    return new List<IfcObjectiveEnum>();
                case "IfcOccupantTypeEnum":
                    return new List<IfcOccupantTypeEnum>();
                case "IfcOpeningElementTypeEnum":
                    return new List<IfcOpeningElementTypeEnum>();
                case "IfcOutletTypeEnum":
                    return new List<IfcOutletTypeEnum>();
                case "IfcPerformanceHistoryTypeEnum":
                    return new List<IfcPerformanceHistoryTypeEnum>();
                case "IfcPermeableCoveringOperationEnum":
                    return new List<IfcPermeableCoveringOperationEnum>();
                case "IfcPermitTypeEnum":
                    return new List<IfcPermitTypeEnum>();
                case "IfcPhysicalOrVirtualEnum":
                    return new List<IfcPhysicalOrVirtualEnum>();
                case "IfcPileConstructionEnum":
                    return new List<IfcPileConstructionEnum>();
                case "IfcPileTypeEnum":
                    return new List<IfcPileTypeEnum>();
                case "IfcPipeFittingTypeEnum":
                    return new List<IfcPipeFittingTypeEnum>();
                case "IfcPipeSegmentTypeEnum":
                    return new List<IfcPipeSegmentTypeEnum>();
                case "IfcPlateTypeEnum":
                    return new List<IfcPlateTypeEnum>();
                case "IfcPreferredSurfaceCurveRepresentation":
                    return new List<IfcPreferredSurfaceCurveRepresentation>();
                case "IfcProcedureTypeEnum":
                    return new List<IfcProcedureTypeEnum>();
                case "IfcProfileTypeEnum":
                    return new List<IfcProfileTypeEnum>();
                case "IfcProjectOrderTypeEnum":
                    return new List<IfcProjectOrderTypeEnum>();
                case "IfcProjectedOrTrueLengthEnum":
                    return new List<IfcProjectedOrTrueLengthEnum>();
                case "IfcProjectionElementTypeEnum":
                    return new List<IfcProjectionElementTypeEnum>();
                case "IfcPropertySetTemplateTypeEnum":
                    return new List<IfcPropertySetTemplateTypeEnum>();
                case "IfcProtectiveDeviceTrippingUnitTypeEnum":
                    return new List<IfcProtectiveDeviceTrippingUnitTypeEnum>();
                case "IfcProtectiveDeviceTypeEnum":
                    return new List<IfcProtectiveDeviceTypeEnum>();
                case "IfcPumpTypeEnum":
                    return new List<IfcPumpTypeEnum>();
                case "IfcRailingTypeEnum":
                    return new List<IfcRailingTypeEnum>();
                case "IfcRampFlightTypeEnum":
                    return new List<IfcRampFlightTypeEnum>();
                case "IfcRampTypeEnum":
                    return new List<IfcRampTypeEnum>();
                case "IfcRecurrenceTypeEnum":
                    return new List<IfcRecurrenceTypeEnum>();
                case "IfcReflectanceMethodEnum":
                    return new List<IfcReflectanceMethodEnum>();
                case "IfcReinforcingBarRoleEnum":
                    return new List<IfcReinforcingBarRoleEnum>();
                case "IfcReinforcingBarSurfaceEnum":
                    return new List<IfcReinforcingBarSurfaceEnum>();
                case "IfcReinforcingBarTypeEnum":
                    return new List<IfcReinforcingBarTypeEnum>();
                case "IfcReinforcingMeshTypeEnum":
                    return new List<IfcReinforcingMeshTypeEnum>();
                case "IfcRoleEnum":
                    return new List<IfcRoleEnum>();
                case "IfcRoofTypeEnum":
                    return new List<IfcRoofTypeEnum>();
                case "IfcSIPrefix":
                    return new List<IfcSIPrefix>();
                case "IfcSIUnitName":
                    return new List<IfcSIUnitName>();
                case "IfcSanitaryTerminalTypeEnum":
                    return new List<IfcSanitaryTerminalTypeEnum>();
                case "IfcSectionTypeEnum":
                    return new List<IfcSectionTypeEnum>();
                case "IfcSensorTypeEnum":
                    return new List<IfcSensorTypeEnum>();
                case "IfcSequenceEnum":
                    return new List<IfcSequenceEnum>();
                case "IfcShadingDeviceTypeEnum":
                    return new List<IfcShadingDeviceTypeEnum>();
                case "IfcSimplePropertyTemplateTypeEnum":
                    return new List<IfcSimplePropertyTemplateTypeEnum>();
                case "IfcSlabTypeEnum":
                    return new List<IfcSlabTypeEnum>();
                case "IfcSolarDeviceTypeEnum":
                    return new List<IfcSolarDeviceTypeEnum>();
                case "IfcSpaceHeaterTypeEnum":
                    return new List<IfcSpaceHeaterTypeEnum>();
                case "IfcSpaceTypeEnum":
                    return new List<IfcSpaceTypeEnum>();
                case "IfcSpatialZoneTypeEnum":
                    return new List<IfcSpatialZoneTypeEnum>();
                case "IfcStackTerminalTypeEnum":
                    return new List<IfcStackTerminalTypeEnum>();
                case "IfcStairFlightTypeEnum":
                    return new List<IfcStairFlightTypeEnum>();
                case "IfcStairTypeEnum":
                    return new List<IfcStairTypeEnum>();
                case "IfcStateEnum":
                    return new List<IfcStateEnum>();
                case "IfcStructuralCurveActivityTypeEnum":
                    return new List<IfcStructuralCurveActivityTypeEnum>();
                case "IfcStructuralCurveMemberTypeEnum":
                    return new List<IfcStructuralCurveMemberTypeEnum>();
                case "IfcStructuralSurfaceActivityTypeEnum":
                    return new List<IfcStructuralSurfaceActivityTypeEnum>();
                case "IfcStructuralSurfaceMemberTypeEnum":
                    return new List<IfcStructuralSurfaceMemberTypeEnum>();
                case "IfcSubContractResourceTypeEnum":
                    return new List<IfcSubContractResourceTypeEnum>();
                case "IfcSurfaceFeatureTypeEnum":
                    return new List<IfcSurfaceFeatureTypeEnum>();
                case "IfcSurfaceSide":
                    return new List<IfcSurfaceSide>();
                case "IfcSwitchingDeviceTypeEnum":
                    return new List<IfcSwitchingDeviceTypeEnum>();
                case "IfcSystemFurnitureElementTypeEnum":
                    return new List<IfcSystemFurnitureElementTypeEnum>();
                case "IfcTankTypeEnum":
                    return new List<IfcTankTypeEnum>();
                case "IfcTaskDurationEnum":
                    return new List<IfcTaskDurationEnum>();
                case "IfcTaskTypeEnum":
                    return new List<IfcTaskTypeEnum>();
                case "IfcTendonAnchorTypeEnum":
                    return new List<IfcTendonAnchorTypeEnum>();
                case "IfcTendonTypeEnum":
                    return new List<IfcTendonTypeEnum>();
                case "IfcTextPath":
                    return new List<IfcTextPath>();
                case "IfcTimeSeriesDataTypeEnum":
                    return new List<IfcTimeSeriesDataTypeEnum>();
                case "IfcTransformerTypeEnum":
                    return new List<IfcTransformerTypeEnum>();
                case "IfcTransitionCode":
                    return new List<IfcTransitionCode>();
                case "IfcTransportElementTypeEnum":
                    return new List<IfcTransportElementTypeEnum>();
                case "IfcTrimmingPreference":
                    return new List<IfcTrimmingPreference>();
                case "IfcTubeBundleTypeEnum":
                    return new List<IfcTubeBundleTypeEnum>();
                case "IfcUnitEnum":
                    return new List<IfcUnitEnum>();
                case "IfcUnitaryControlElementTypeEnum":
                    return new List<IfcUnitaryControlElementTypeEnum>();
                case "IfcUnitaryEquipmentTypeEnum":
                    return new List<IfcUnitaryEquipmentTypeEnum>();
                case "IfcValveTypeEnum":
                    return new List<IfcValveTypeEnum>();
                case "IfcVibrationIsolatorTypeEnum":
                    return new List<IfcVibrationIsolatorTypeEnum>();
                case "IfcVoidingFeatureTypeEnum":
                    return new List<IfcVoidingFeatureTypeEnum>();
                case "IfcWallTypeEnum":
                    return new List<IfcWallTypeEnum>();
                case "IfcWasteTerminalTypeEnum":
                    return new List<IfcWasteTerminalTypeEnum>();
                case "IfcWindowPanelOperationEnum":
                    return new List<IfcWindowPanelOperationEnum>();
                case "IfcWindowPanelPositionEnum":
                    return new List<IfcWindowPanelPositionEnum>();
                case "IfcWindowStyleConstructionEnum":
                    return new List<IfcWindowStyleConstructionEnum>();
                case "IfcWindowStyleOperationEnum":
                    return new List<IfcWindowStyleOperationEnum>();
                case "IfcWindowTypeEnum":
                    return new List<IfcWindowTypeEnum>();
                case "IfcWindowTypePartitioningEnum":
                    return new List<IfcWindowTypePartitioningEnum>();
                case "IfcWorkCalendarTypeEnum":
                    return new List<IfcWorkCalendarTypeEnum>();
                case "IfcWorkPlanTypeEnum":
                    return new List<IfcWorkPlanTypeEnum>();
                case "IfcWorkScheduleTypeEnum":
                    return new List<IfcWorkScheduleTypeEnum>();
                case "IfcActorSelect":
                    return new List<IfcActorSelect>();
                case "IfcAppliedValueSelect":
                    return new List<IfcAppliedValueSelect>();
                case "IfcAxis2Placement":
                    return new List<IfcAxis2Placement>();
                case "IfcBendingParameterSelect":
                    return new List<IfcBendingParameterSelect>();
                case "IfcBooleanOperand":
                    return new List<IfcBooleanOperand>();
                case "IfcClassificationReferenceSelect":
                    return new List<IfcClassificationReferenceSelect>();
                case "IfcClassificationSelect":
                    return new List<IfcClassificationSelect>();
                case "IfcColour":
                    return new List<IfcColour>();
                case "IfcColourOrFactor":
                    return new List<IfcColourOrFactor>();
                case "IfcCoordinateReferenceSystemSelect":
                    return new List<IfcCoordinateReferenceSystemSelect>();
                case "IfcCsgSelect":
                    return new List<IfcCsgSelect>();
                case "IfcCurveFontOrScaledCurveFontSelect":
                    return new List<IfcCurveFontOrScaledCurveFontSelect>();
                case "IfcCurveOnSurface":
                    return new List<IfcCurveOnSurface>();
                case "IfcCurveOrEdgeCurve":
                    return new List<IfcCurveOrEdgeCurve>();
                case "IfcCurveStyleFontSelect":
                    return new List<IfcCurveStyleFontSelect>();
                case "IfcDefinitionSelect":
                    return new List<IfcDefinitionSelect>();
                case "IfcDerivedMeasureValue":
                    return new List<IfcDerivedMeasureValue>();
                case "IfcDocumentSelect":
                    return new List<IfcDocumentSelect>();
                case "IfcFillStyleSelect":
                    return new List<IfcFillStyleSelect>();
                case "IfcGeometricSetSelect":
                    return new List<IfcGeometricSetSelect>();
                case "IfcGridPlacementDirectionSelect":
                    return new List<IfcGridPlacementDirectionSelect>();
                case "IfcHatchLineDistanceSelect":
                    return new List<IfcHatchLineDistanceSelect>();
                case "IfcLayeredItem":
                    return new List<IfcLayeredItem>();
                case "IfcLibrarySelect":
                    return new List<IfcLibrarySelect>();
                case "IfcLightDistributionDataSourceSelect":
                    return new List<IfcLightDistributionDataSourceSelect>();
                case "IfcMaterialSelect":
                    return new List<IfcMaterialSelect>();
                case "IfcMeasureValue":
                    return new List<IfcMeasureValue>();
                case "IfcMetricValueSelect":
                    return new List<IfcMetricValueSelect>();
                case "IfcModulusOfRotationalSubgradeReactionSelect":
                    return new List<IfcModulusOfRotationalSubgradeReactionSelect>();
                case "IfcModulusOfSubgradeReactionSelect":
                    return new List<IfcModulusOfSubgradeReactionSelect>();
                case "IfcModulusOfTranslationalSubgradeReactionSelect":
                    return new List<IfcModulusOfTranslationalSubgradeReactionSelect>();
                case "IfcObjectReferenceSelect":
                    return new List<IfcObjectReferenceSelect>();
                case "IfcPointOrVertexPoint":
                    return new List<IfcPointOrVertexPoint>();
                case "IfcPresentationStyleSelect":
                    return new List<IfcPresentationStyleSelect>();
                case "IfcProcessSelect":
                    return new List<IfcProcessSelect>();
                case "IfcProductRepresentationSelect":
                    return new List<IfcProductRepresentationSelect>();
                case "IfcProductSelect":
                    return new List<IfcProductSelect>();
                case "IfcPropertySetDefinitionSelect":
                    return new List<IfcPropertySetDefinitionSelect>();
                case "IfcResourceObjectSelect":
                    return new List<IfcResourceObjectSelect>();
                case "IfcResourceSelect":
                    return new List<IfcResourceSelect>();
                case "IfcRotationalStiffnessSelect":
                    return new List<IfcRotationalStiffnessSelect>();
                case "IfcSegmentIndexSelect":
                    return new List<IfcSegmentIndexSelect>();
                case "IfcShell":
                    return new List<IfcShell>();
                case "IfcSimpleValue":
                    return new List<IfcSimpleValue>();
                case "IfcSizeSelect":
                    return new List<IfcSizeSelect>();
                case "IfcSolidOrShell":
                    return new List<IfcSolidOrShell>();
                case "IfcSpaceBoundarySelect":
                    return new List<IfcSpaceBoundarySelect>();
                case "IfcSpecularHighlightSelect":
                    return new List<IfcSpecularHighlightSelect>();
                case "IfcStructuralActivityAssignmentSelect":
                    return new List<IfcStructuralActivityAssignmentSelect>();
                case "IfcStyleAssignmentSelect":
                    return new List<IfcStyleAssignmentSelect>();
                case "IfcSurfaceOrFaceSurface":
                    return new List<IfcSurfaceOrFaceSurface>();
                case "IfcSurfaceStyleElementSelect":
                    return new List<IfcSurfaceStyleElementSelect>();
                case "IfcTextFontSelect":
                    return new List<IfcTextFontSelect>();
                case "IfcTimeOrRatioSelect":
                    return new List<IfcTimeOrRatioSelect>();
                case "IfcTranslationalStiffnessSelect":
                    return new List<IfcTranslationalStiffnessSelect>();
                case "IfcTrimmingSelect":
                    return new List<IfcTrimmingSelect>();
                case "IfcUnit":
                    return new List<IfcUnit>();
                case "IfcValue":
                    return new List<IfcValue>();
                case "IfcVectorOrDirection":
                    return new List<IfcVectorOrDirection>();
                case "IfcWarpingStiffnessSelect":
                    return new List<IfcWarpingStiffnessSelect>();
                case "IfcActionRequest":
                    return new List<IfcActionRequest>();
                case "IfcActor":
                    return new List<IfcActor>();
                case "IfcActorRole":
                    return new List<IfcActorRole>();
                case "IfcActuator":
                    return new List<IfcActuator>();
                case "IfcActuatorType":
                    return new List<IfcActuatorType>();
                case "IfcAddress":
                    return new List<IfcAddress>();
                case "IfcAdvancedBrep":
                    return new List<IfcAdvancedBrep>();
                case "IfcAdvancedBrepWithVoids":
                    return new List<IfcAdvancedBrepWithVoids>();
                case "IfcAdvancedFace":
                    return new List<IfcAdvancedFace>();
                case "IfcAirTerminal":
                    return new List<IfcAirTerminal>();
                case "IfcAirTerminalBox":
                    return new List<IfcAirTerminalBox>();
                case "IfcAirTerminalBoxType":
                    return new List<IfcAirTerminalBoxType>();
                case "IfcAirTerminalType":
                    return new List<IfcAirTerminalType>();
                case "IfcAirToAirHeatRecovery":
                    return new List<IfcAirToAirHeatRecovery>();
                case "IfcAirToAirHeatRecoveryType":
                    return new List<IfcAirToAirHeatRecoveryType>();
                case "IfcAlarm":
                    return new List<IfcAlarm>();
                case "IfcAlarmType":
                    return new List<IfcAlarmType>();
                case "IfcAnnotation":
                    return new List<IfcAnnotation>();
                case "IfcAnnotationFillArea":
                    return new List<IfcAnnotationFillArea>();
                case "IfcApplication":
                    return new List<IfcApplication>();
                case "IfcAppliedValue":
                    return new List<IfcAppliedValue>();
                case "IfcApproval":
                    return new List<IfcApproval>();
                case "IfcApprovalRelationship":
                    return new List<IfcApprovalRelationship>();
                case "IfcArbitraryClosedProfileDef":
                    return new List<IfcArbitraryClosedProfileDef>();
                case "IfcArbitraryOpenProfileDef":
                    return new List<IfcArbitraryOpenProfileDef>();
                case "IfcArbitraryProfileDefWithVoids":
                    return new List<IfcArbitraryProfileDefWithVoids>();
                case "IfcAsset":
                    return new List<IfcAsset>();
                case "IfcAsymmetricIShapeProfileDef":
                    return new List<IfcAsymmetricIShapeProfileDef>();
                case "IfcAudioVisualAppliance":
                    return new List<IfcAudioVisualAppliance>();
                case "IfcAudioVisualApplianceType":
                    return new List<IfcAudioVisualApplianceType>();
                case "IfcAxis1Placement":
                    return new List<IfcAxis1Placement>();
                case "IfcAxis2Placement2D":
                    return new List<IfcAxis2Placement2D>();
                case "IfcAxis2Placement3D":
                    return new List<IfcAxis2Placement3D>();
                case "IfcBSplineCurve":
                    return new List<IfcBSplineCurve>();
                case "IfcBSplineCurveWithKnots":
                    return new List<IfcBSplineCurveWithKnots>();
                case "IfcBSplineSurface":
                    return new List<IfcBSplineSurface>();
                case "IfcBSplineSurfaceWithKnots":
                    return new List<IfcBSplineSurfaceWithKnots>();
                case "IfcBeam":
                    return new List<IfcBeam>();
                case "IfcBeamStandardCase":
                    return new List<IfcBeamStandardCase>();
                case "IfcBeamType":
                    return new List<IfcBeamType>();
                case "IfcBlobTexture":
                    return new List<IfcBlobTexture>();
                case "IfcBlock":
                    return new List<IfcBlock>();
                case "IfcBoiler":
                    return new List<IfcBoiler>();
                case "IfcBoilerType":
                    return new List<IfcBoilerType>();
                case "IfcBooleanClippingResult":
                    return new List<IfcBooleanClippingResult>();
                case "IfcBooleanResult":
                    return new List<IfcBooleanResult>();
                case "IfcBoundaryCondition":
                    return new List<IfcBoundaryCondition>();
                case "IfcBoundaryCurve":
                    return new List<IfcBoundaryCurve>();
                case "IfcBoundaryEdgeCondition":
                    return new List<IfcBoundaryEdgeCondition>();
                case "IfcBoundaryFaceCondition":
                    return new List<IfcBoundaryFaceCondition>();
                case "IfcBoundaryNodeCondition":
                    return new List<IfcBoundaryNodeCondition>();
                case "IfcBoundaryNodeConditionWarping":
                    return new List<IfcBoundaryNodeConditionWarping>();
                case "IfcBoundedCurve":
                    return new List<IfcBoundedCurve>();
                case "IfcBoundedSurface":
                    return new List<IfcBoundedSurface>();
                case "IfcBoundingBox":
                    return new List<IfcBoundingBox>();
                case "IfcBoxedHalfSpace":
                    return new List<IfcBoxedHalfSpace>();
                case "IfcBuilding":
                    return new List<IfcBuilding>();
                case "IfcBuildingElement":
                    return new List<IfcBuildingElement>();
                case "IfcBuildingElementPart":
                    return new List<IfcBuildingElementPart>();
                case "IfcBuildingElementPartType":
                    return new List<IfcBuildingElementPartType>();
                case "IfcBuildingElementProxy":
                    return new List<IfcBuildingElementProxy>();
                case "IfcBuildingElementProxyType":
                    return new List<IfcBuildingElementProxyType>();
                case "IfcBuildingElementType":
                    return new List<IfcBuildingElementType>();
                case "IfcBuildingStorey":
                    return new List<IfcBuildingStorey>();
                case "IfcBuildingSystem":
                    return new List<IfcBuildingSystem>();
                case "IfcBurner":
                    return new List<IfcBurner>();
                case "IfcBurnerType":
                    return new List<IfcBurnerType>();
                case "IfcCShapeProfileDef":
                    return new List<IfcCShapeProfileDef>();
                case "IfcCableCarrierFitting":
                    return new List<IfcCableCarrierFitting>();
                case "IfcCableCarrierFittingType":
                    return new List<IfcCableCarrierFittingType>();
                case "IfcCableCarrierSegment":
                    return new List<IfcCableCarrierSegment>();
                case "IfcCableCarrierSegmentType":
                    return new List<IfcCableCarrierSegmentType>();
                case "IfcCableFitting":
                    return new List<IfcCableFitting>();
                case "IfcCableFittingType":
                    return new List<IfcCableFittingType>();
                case "IfcCableSegment":
                    return new List<IfcCableSegment>();
                case "IfcCableSegmentType":
                    return new List<IfcCableSegmentType>();
                case "IfcCartesianPoint":
                    return new List<IfcCartesianPoint>();
                case "IfcCartesianPointList":
                    return new List<IfcCartesianPointList>();
                case "IfcCartesianPointList2D":
                    return new List<IfcCartesianPointList2D>();
                case "IfcCartesianPointList3D":
                    return new List<IfcCartesianPointList3D>();
                case "IfcCartesianTransformationOperator":
                    return new List<IfcCartesianTransformationOperator>();
                case "IfcCartesianTransformationOperator2D":
                    return new List<IfcCartesianTransformationOperator2D>();
                case "IfcCartesianTransformationOperator2DnonUniform":
                    return new List<IfcCartesianTransformationOperator2DnonUniform>();
                case "IfcCartesianTransformationOperator3D":
                    return new List<IfcCartesianTransformationOperator3D>();
                case "IfcCartesianTransformationOperator3DnonUniform":
                    return new List<IfcCartesianTransformationOperator3DnonUniform>();
                case "IfcCenterLineProfileDef":
                    return new List<IfcCenterLineProfileDef>();
                case "IfcChiller":
                    return new List<IfcChiller>();
                case "IfcChillerType":
                    return new List<IfcChillerType>();
                case "IfcChimney":
                    return new List<IfcChimney>();
                case "IfcChimneyType":
                    return new List<IfcChimneyType>();
                case "IfcCircle":
                    return new List<IfcCircle>();
                case "IfcCircleHollowProfileDef":
                    return new List<IfcCircleHollowProfileDef>();
                case "IfcCircleProfileDef":
                    return new List<IfcCircleProfileDef>();
                case "IfcCivilElement":
                    return new List<IfcCivilElement>();
                case "IfcCivilElementType":
                    return new List<IfcCivilElementType>();
                case "IfcClassification":
                    return new List<IfcClassification>();
                case "IfcClassificationReference":
                    return new List<IfcClassificationReference>();
                case "IfcClosedShell":
                    return new List<IfcClosedShell>();
                case "IfcCoil":
                    return new List<IfcCoil>();
                case "IfcCoilType":
                    return new List<IfcCoilType>();
                case "IfcColourRgb":
                    return new List<IfcColourRgb>();
                case "IfcColourRgbList":
                    return new List<IfcColourRgbList>();
                case "IfcColourSpecification":
                    return new List<IfcColourSpecification>();
                case "IfcColumn":
                    return new List<IfcColumn>();
                case "IfcColumnStandardCase":
                    return new List<IfcColumnStandardCase>();
                case "IfcColumnType":
                    return new List<IfcColumnType>();
                case "IfcCommunicationsAppliance":
                    return new List<IfcCommunicationsAppliance>();
                case "IfcCommunicationsApplianceType":
                    return new List<IfcCommunicationsApplianceType>();
                case "IfcComplexProperty":
                    return new List<IfcComplexProperty>();
                case "IfcComplexPropertyTemplate":
                    return new List<IfcComplexPropertyTemplate>();
                case "IfcCompositeCurve":
                    return new List<IfcCompositeCurve>();
                case "IfcCompositeCurveOnSurface":
                    return new List<IfcCompositeCurveOnSurface>();
                case "IfcCompositeCurveSegment":
                    return new List<IfcCompositeCurveSegment>();
                case "IfcCompositeProfileDef":
                    return new List<IfcCompositeProfileDef>();
                case "IfcCompressor":
                    return new List<IfcCompressor>();
                case "IfcCompressorType":
                    return new List<IfcCompressorType>();
                case "IfcCondenser":
                    return new List<IfcCondenser>();
                case "IfcCondenserType":
                    return new List<IfcCondenserType>();
                case "IfcConic":
                    return new List<IfcConic>();
                case "IfcConnectedFaceSet":
                    return new List<IfcConnectedFaceSet>();
                case "IfcConnectionCurveGeometry":
                    return new List<IfcConnectionCurveGeometry>();
                case "IfcConnectionGeometry":
                    return new List<IfcConnectionGeometry>();
                case "IfcConnectionPointEccentricity":
                    return new List<IfcConnectionPointEccentricity>();
                case "IfcConnectionPointGeometry":
                    return new List<IfcConnectionPointGeometry>();
                case "IfcConnectionSurfaceGeometry":
                    return new List<IfcConnectionSurfaceGeometry>();
                case "IfcConnectionVolumeGeometry":
                    return new List<IfcConnectionVolumeGeometry>();
                case "IfcConstraint":
                    return new List<IfcConstraint>();
                case "IfcConstructionEquipmentResource":
                    return new List<IfcConstructionEquipmentResource>();
                case "IfcConstructionEquipmentResourceType":
                    return new List<IfcConstructionEquipmentResourceType>();
                case "IfcConstructionMaterialResource":
                    return new List<IfcConstructionMaterialResource>();
                case "IfcConstructionMaterialResourceType":
                    return new List<IfcConstructionMaterialResourceType>();
                case "IfcConstructionProductResource":
                    return new List<IfcConstructionProductResource>();
                case "IfcConstructionProductResourceType":
                    return new List<IfcConstructionProductResourceType>();
                case "IfcConstructionResource":
                    return new List<IfcConstructionResource>();
                case "IfcConstructionResourceType":
                    return new List<IfcConstructionResourceType>();
                case "IfcContext":
                    return new List<IfcContext>();
                case "IfcContextDependentUnit":
                    return new List<IfcContextDependentUnit>();
                case "IfcControl":
                    return new List<IfcControl>();
                case "IfcController":
                    return new List<IfcController>();
                case "IfcControllerType":
                    return new List<IfcControllerType>();
                case "IfcConversionBasedUnit":
                    return new List<IfcConversionBasedUnit>();
                case "IfcConversionBasedUnitWithOffset":
                    return new List<IfcConversionBasedUnitWithOffset>();
                case "IfcCooledBeam":
                    return new List<IfcCooledBeam>();
                case "IfcCooledBeamType":
                    return new List<IfcCooledBeamType>();
                case "IfcCoolingTower":
                    return new List<IfcCoolingTower>();
                case "IfcCoolingTowerType":
                    return new List<IfcCoolingTowerType>();
                case "IfcCoordinateOperation":
                    return new List<IfcCoordinateOperation>();
                case "IfcCoordinateReferenceSystem":
                    return new List<IfcCoordinateReferenceSystem>();
                case "IfcCostItem":
                    return new List<IfcCostItem>();
                case "IfcCostSchedule":
                    return new List<IfcCostSchedule>();
                case "IfcCostValue":
                    return new List<IfcCostValue>();
                case "IfcCovering":
                    return new List<IfcCovering>();
                case "IfcCoveringType":
                    return new List<IfcCoveringType>();
                case "IfcCrewResource":
                    return new List<IfcCrewResource>();
                case "IfcCrewResourceType":
                    return new List<IfcCrewResourceType>();
                case "IfcCsgPrimitive3D":
                    return new List<IfcCsgPrimitive3D>();
                case "IfcCsgSolid":
                    return new List<IfcCsgSolid>();
                case "IfcCurrencyRelationship":
                    return new List<IfcCurrencyRelationship>();
                case "IfcCurtainWall":
                    return new List<IfcCurtainWall>();
                case "IfcCurtainWallType":
                    return new List<IfcCurtainWallType>();
                case "IfcCurve":
                    return new List<IfcCurve>();
                case "IfcCurveBoundedPlane":
                    return new List<IfcCurveBoundedPlane>();
                case "IfcCurveBoundedSurface":
                    return new List<IfcCurveBoundedSurface>();
                case "IfcCurveStyle":
                    return new List<IfcCurveStyle>();
                case "IfcCurveStyleFont":
                    return new List<IfcCurveStyleFont>();
                case "IfcCurveStyleFontAndScaling":
                    return new List<IfcCurveStyleFontAndScaling>();
                case "IfcCurveStyleFontPattern":
                    return new List<IfcCurveStyleFontPattern>();
                case "IfcCylindricalSurface":
                    return new List<IfcCylindricalSurface>();
                case "IfcDamper":
                    return new List<IfcDamper>();
                case "IfcDamperType":
                    return new List<IfcDamperType>();
                case "IfcDerivedProfileDef":
                    return new List<IfcDerivedProfileDef>();
                case "IfcDerivedUnit":
                    return new List<IfcDerivedUnit>();
                case "IfcDerivedUnitElement":
                    return new List<IfcDerivedUnitElement>();
                case "IfcDimensionalExponents":
                    return new List<IfcDimensionalExponents>();
                case "IfcDirection":
                    return new List<IfcDirection>();
                case "IfcDiscreteAccessory":
                    return new List<IfcDiscreteAccessory>();
                case "IfcDiscreteAccessoryType":
                    return new List<IfcDiscreteAccessoryType>();
                case "IfcDistributionChamberElement":
                    return new List<IfcDistributionChamberElement>();
                case "IfcDistributionChamberElementType":
                    return new List<IfcDistributionChamberElementType>();
                case "IfcDistributionCircuit":
                    return new List<IfcDistributionCircuit>();
                case "IfcDistributionControlElement":
                    return new List<IfcDistributionControlElement>();
                case "IfcDistributionControlElementType":
                    return new List<IfcDistributionControlElementType>();
                case "IfcDistributionElement":
                    return new List<IfcDistributionElement>();
                case "IfcDistributionElementType":
                    return new List<IfcDistributionElementType>();
                case "IfcDistributionFlowElement":
                    return new List<IfcDistributionFlowElement>();
                case "IfcDistributionFlowElementType":
                    return new List<IfcDistributionFlowElementType>();
                case "IfcDistributionPort":
                    return new List<IfcDistributionPort>();
                case "IfcDistributionSystem":
                    return new List<IfcDistributionSystem>();
                case "IfcDocumentInformation":
                    return new List<IfcDocumentInformation>();
                case "IfcDocumentInformationRelationship":
                    return new List<IfcDocumentInformationRelationship>();
                case "IfcDocumentReference":
                    return new List<IfcDocumentReference>();
                case "IfcDoor":
                    return new List<IfcDoor>();
                case "IfcDoorLiningProperties":
                    return new List<IfcDoorLiningProperties>();
                case "IfcDoorPanelProperties":
                    return new List<IfcDoorPanelProperties>();
                case "IfcDoorStandardCase":
                    return new List<IfcDoorStandardCase>();
                case "IfcDoorStyle":
                    return new List<IfcDoorStyle>();
                case "IfcDoorType":
                    return new List<IfcDoorType>();
                case "IfcDraughtingPreDefinedColour":
                    return new List<IfcDraughtingPreDefinedColour>();
                case "IfcDraughtingPreDefinedCurveFont":
                    return new List<IfcDraughtingPreDefinedCurveFont>();
                case "IfcDuctFitting":
                    return new List<IfcDuctFitting>();
                case "IfcDuctFittingType":
                    return new List<IfcDuctFittingType>();
                case "IfcDuctSegment":
                    return new List<IfcDuctSegment>();
                case "IfcDuctSegmentType":
                    return new List<IfcDuctSegmentType>();
                case "IfcDuctSilencer":
                    return new List<IfcDuctSilencer>();
                case "IfcDuctSilencerType":
                    return new List<IfcDuctSilencerType>();
                case "IfcEdge":
                    return new List<IfcEdge>();
                case "IfcEdgeCurve":
                    return new List<IfcEdgeCurve>();
                case "IfcEdgeLoop":
                    return new List<IfcEdgeLoop>();
                case "IfcElectricAppliance":
                    return new List<IfcElectricAppliance>();
                case "IfcElectricApplianceType":
                    return new List<IfcElectricApplianceType>();
                case "IfcElectricDistributionBoard":
                    return new List<IfcElectricDistributionBoard>();
                case "IfcElectricDistributionBoardType":
                    return new List<IfcElectricDistributionBoardType>();
                case "IfcElectricFlowStorageDevice":
                    return new List<IfcElectricFlowStorageDevice>();
                case "IfcElectricFlowStorageDeviceType":
                    return new List<IfcElectricFlowStorageDeviceType>();
                case "IfcElectricGenerator":
                    return new List<IfcElectricGenerator>();
                case "IfcElectricGeneratorType":
                    return new List<IfcElectricGeneratorType>();
                case "IfcElectricMotor":
                    return new List<IfcElectricMotor>();
                case "IfcElectricMotorType":
                    return new List<IfcElectricMotorType>();
                case "IfcElectricTimeControl":
                    return new List<IfcElectricTimeControl>();
                case "IfcElectricTimeControlType":
                    return new List<IfcElectricTimeControlType>();
                case "IfcElement":
                    return new List<IfcElement>();
                case "IfcElementAssembly":
                    return new List<IfcElementAssembly>();
                case "IfcElementAssemblyType":
                    return new List<IfcElementAssemblyType>();
                case "IfcElementComponent":
                    return new List<IfcElementComponent>();
                case "IfcElementComponentType":
                    return new List<IfcElementComponentType>();
                case "IfcElementQuantity":
                    return new List<IfcElementQuantity>();
                case "IfcElementType":
                    return new List<IfcElementType>();
                case "IfcElementarySurface":
                    return new List<IfcElementarySurface>();
                case "IfcEllipse":
                    return new List<IfcEllipse>();
                case "IfcEllipseProfileDef":
                    return new List<IfcEllipseProfileDef>();
                case "IfcEnergyConversionDevice":
                    return new List<IfcEnergyConversionDevice>();
                case "IfcEnergyConversionDeviceType":
                    return new List<IfcEnergyConversionDeviceType>();
                case "IfcEngine":
                    return new List<IfcEngine>();
                case "IfcEngineType":
                    return new List<IfcEngineType>();
                case "IfcEvaporativeCooler":
                    return new List<IfcEvaporativeCooler>();
                case "IfcEvaporativeCoolerType":
                    return new List<IfcEvaporativeCoolerType>();
                case "IfcEvaporator":
                    return new List<IfcEvaporator>();
                case "IfcEvaporatorType":
                    return new List<IfcEvaporatorType>();
                case "IfcEvent":
                    return new List<IfcEvent>();
                case "IfcEventTime":
                    return new List<IfcEventTime>();
                case "IfcEventType":
                    return new List<IfcEventType>();
                case "IfcExtendedProperties":
                    return new List<IfcExtendedProperties>();
                case "IfcExternalInformation":
                    return new List<IfcExternalInformation>();
                case "IfcExternalReference":
                    return new List<IfcExternalReference>();
                case "IfcExternalReferenceRelationship":
                    return new List<IfcExternalReferenceRelationship>();
                case "IfcExternalSpatialElement":
                    return new List<IfcExternalSpatialElement>();
                case "IfcExternalSpatialStructureElement":
                    return new List<IfcExternalSpatialStructureElement>();
                case "IfcExternallyDefinedHatchStyle":
                    return new List<IfcExternallyDefinedHatchStyle>();
                case "IfcExternallyDefinedSurfaceStyle":
                    return new List<IfcExternallyDefinedSurfaceStyle>();
                case "IfcExternallyDefinedTextFont":
                    return new List<IfcExternallyDefinedTextFont>();
                case "IfcExtrudedAreaSolid":
                    return new List<IfcExtrudedAreaSolid>();
                case "IfcExtrudedAreaSolidTapered":
                    return new List<IfcExtrudedAreaSolidTapered>();
                case "IfcFace":
                    return new List<IfcFace>();
                case "IfcFaceBasedSurfaceModel":
                    return new List<IfcFaceBasedSurfaceModel>();
                case "IfcFaceBound":
                    return new List<IfcFaceBound>();
                case "IfcFaceOuterBound":
                    return new List<IfcFaceOuterBound>();
                case "IfcFaceSurface":
                    return new List<IfcFaceSurface>();
                case "IfcFacetedBrep":
                    return new List<IfcFacetedBrep>();
                case "IfcFacetedBrepWithVoids":
                    return new List<IfcFacetedBrepWithVoids>();
                case "IfcFailureConnectionCondition":
                    return new List<IfcFailureConnectionCondition>();
                case "IfcFan":
                    return new List<IfcFan>();
                case "IfcFanType":
                    return new List<IfcFanType>();
                case "IfcFastener":
                    return new List<IfcFastener>();
                case "IfcFastenerType":
                    return new List<IfcFastenerType>();
                case "IfcFeatureElement":
                    return new List<IfcFeatureElement>();
                case "IfcFeatureElementAddition":
                    return new List<IfcFeatureElementAddition>();
                case "IfcFeatureElementSubtraction":
                    return new List<IfcFeatureElementSubtraction>();
                case "IfcFillAreaStyle":
                    return new List<IfcFillAreaStyle>();
                case "IfcFillAreaStyleHatching":
                    return new List<IfcFillAreaStyleHatching>();
                case "IfcFillAreaStyleTiles":
                    return new List<IfcFillAreaStyleTiles>();
                case "IfcFilter":
                    return new List<IfcFilter>();
                case "IfcFilterType":
                    return new List<IfcFilterType>();
                case "IfcFireSuppressionTerminal":
                    return new List<IfcFireSuppressionTerminal>();
                case "IfcFireSuppressionTerminalType":
                    return new List<IfcFireSuppressionTerminalType>();
                case "IfcFixedReferenceSweptAreaSolid":
                    return new List<IfcFixedReferenceSweptAreaSolid>();
                case "IfcFlowController":
                    return new List<IfcFlowController>();
                case "IfcFlowControllerType":
                    return new List<IfcFlowControllerType>();
                case "IfcFlowFitting":
                    return new List<IfcFlowFitting>();
                case "IfcFlowFittingType":
                    return new List<IfcFlowFittingType>();
                case "IfcFlowInstrument":
                    return new List<IfcFlowInstrument>();
                case "IfcFlowInstrumentType":
                    return new List<IfcFlowInstrumentType>();
                case "IfcFlowMeter":
                    return new List<IfcFlowMeter>();
                case "IfcFlowMeterType":
                    return new List<IfcFlowMeterType>();
                case "IfcFlowMovingDevice":
                    return new List<IfcFlowMovingDevice>();
                case "IfcFlowMovingDeviceType":
                    return new List<IfcFlowMovingDeviceType>();
                case "IfcFlowSegment":
                    return new List<IfcFlowSegment>();
                case "IfcFlowSegmentType":
                    return new List<IfcFlowSegmentType>();
                case "IfcFlowStorageDevice":
                    return new List<IfcFlowStorageDevice>();
                case "IfcFlowStorageDeviceType":
                    return new List<IfcFlowStorageDeviceType>();
                case "IfcFlowTerminal":
                    return new List<IfcFlowTerminal>();
                case "IfcFlowTerminalType":
                    return new List<IfcFlowTerminalType>();
                case "IfcFlowTreatmentDevice":
                    return new List<IfcFlowTreatmentDevice>();
                case "IfcFlowTreatmentDeviceType":
                    return new List<IfcFlowTreatmentDeviceType>();
                case "IfcFooting":
                    return new List<IfcFooting>();
                case "IfcFootingType":
                    return new List<IfcFootingType>();
                case "IfcFurnishingElement":
                    return new List<IfcFurnishingElement>();
                case "IfcFurnishingElementType":
                    return new List<IfcFurnishingElementType>();
                case "IfcFurniture":
                    return new List<IfcFurniture>();
                case "IfcFurnitureType":
                    return new List<IfcFurnitureType>();
                case "IfcGeographicElement":
                    return new List<IfcGeographicElement>();
                case "IfcGeographicElementType":
                    return new List<IfcGeographicElementType>();
                case "IfcGeometricCurveSet":
                    return new List<IfcGeometricCurveSet>();
                case "IfcGeometricRepresentationContext":
                    return new List<IfcGeometricRepresentationContext>();
                case "IfcGeometricRepresentationItem":
                    return new List<IfcGeometricRepresentationItem>();
                case "IfcGeometricRepresentationSubContext":
                    return new List<IfcGeometricRepresentationSubContext>();
                case "IfcGeometricSet":
                    return new List<IfcGeometricSet>();
                case "IfcGrid":
                    return new List<IfcGrid>();
                case "IfcGridAxis":
                    return new List<IfcGridAxis>();
                case "IfcGridPlacement":
                    return new List<IfcGridPlacement>();
                case "IfcGroup":
                    return new List<IfcGroup>();
                case "IfcHalfSpaceSolid":
                    return new List<IfcHalfSpaceSolid>();
                case "IfcHeatExchanger":
                    return new List<IfcHeatExchanger>();
                case "IfcHeatExchangerType":
                    return new List<IfcHeatExchangerType>();
                case "IfcHumidifier":
                    return new List<IfcHumidifier>();
                case "IfcHumidifierType":
                    return new List<IfcHumidifierType>();
                case "IfcIShapeProfileDef":
                    return new List<IfcIShapeProfileDef>();
                case "IfcImageTexture":
                    return new List<IfcImageTexture>();
                case "IfcIndexedColourMap":
                    return new List<IfcIndexedColourMap>();
                case "IfcIndexedPolyCurve":
                    return new List<IfcIndexedPolyCurve>();
                case "IfcIndexedPolygonalFace":
                    return new List<IfcIndexedPolygonalFace>();
                case "IfcIndexedPolygonalFaceWithVoids":
                    return new List<IfcIndexedPolygonalFaceWithVoids>();
                case "IfcIndexedTextureMap":
                    return new List<IfcIndexedTextureMap>();
                case "IfcIndexedTriangleTextureMap":
                    return new List<IfcIndexedTriangleTextureMap>();
                case "IfcInterceptor":
                    return new List<IfcInterceptor>();
                case "IfcInterceptorType":
                    return new List<IfcInterceptorType>();
                case "IfcIntersectionCurve":
                    return new List<IfcIntersectionCurve>();
                case "IfcInventory":
                    return new List<IfcInventory>();
                case "IfcIrregularTimeSeries":
                    return new List<IfcIrregularTimeSeries>();
                case "IfcIrregularTimeSeriesValue":
                    return new List<IfcIrregularTimeSeriesValue>();
                case "IfcJunctionBox":
                    return new List<IfcJunctionBox>();
                case "IfcJunctionBoxType":
                    return new List<IfcJunctionBoxType>();
                case "IfcLShapeProfileDef":
                    return new List<IfcLShapeProfileDef>();
                case "IfcLaborResource":
                    return new List<IfcLaborResource>();
                case "IfcLaborResourceType":
                    return new List<IfcLaborResourceType>();
                case "IfcLagTime":
                    return new List<IfcLagTime>();
                case "IfcLamp":
                    return new List<IfcLamp>();
                case "IfcLampType":
                    return new List<IfcLampType>();
                case "IfcLibraryInformation":
                    return new List<IfcLibraryInformation>();
                case "IfcLibraryReference":
                    return new List<IfcLibraryReference>();
                case "IfcLightDistributionData":
                    return new List<IfcLightDistributionData>();
                case "IfcLightFixture":
                    return new List<IfcLightFixture>();
                case "IfcLightFixtureType":
                    return new List<IfcLightFixtureType>();
                case "IfcLightIntensityDistribution":
                    return new List<IfcLightIntensityDistribution>();
                case "IfcLightSource":
                    return new List<IfcLightSource>();
                case "IfcLightSourceAmbient":
                    return new List<IfcLightSourceAmbient>();
                case "IfcLightSourceDirectional":
                    return new List<IfcLightSourceDirectional>();
                case "IfcLightSourceGoniometric":
                    return new List<IfcLightSourceGoniometric>();
                case "IfcLightSourcePositional":
                    return new List<IfcLightSourcePositional>();
                case "IfcLightSourceSpot":
                    return new List<IfcLightSourceSpot>();
                case "IfcLine":
                    return new List<IfcLine>();
                case "IfcLocalPlacement":
                    return new List<IfcLocalPlacement>();
                case "IfcLoop":
                    return new List<IfcLoop>();
                case "IfcManifoldSolidBrep":
                    return new List<IfcManifoldSolidBrep>();
                case "IfcMapConversion":
                    return new List<IfcMapConversion>();
                case "IfcMappedItem":
                    return new List<IfcMappedItem>();
                case "IfcMaterial":
                    return new List<IfcMaterial>();
                case "IfcMaterialClassificationRelationship":
                    return new List<IfcMaterialClassificationRelationship>();
                case "IfcMaterialConstituent":
                    return new List<IfcMaterialConstituent>();
                case "IfcMaterialConstituentSet":
                    return new List<IfcMaterialConstituentSet>();
                case "IfcMaterialDefinition":
                    return new List<IfcMaterialDefinition>();
                case "IfcMaterialDefinitionRepresentation":
                    return new List<IfcMaterialDefinitionRepresentation>();
                case "IfcMaterialLayer":
                    return new List<IfcMaterialLayer>();
                case "IfcMaterialLayerSet":
                    return new List<IfcMaterialLayerSet>();
                case "IfcMaterialLayerSetUsage":
                    return new List<IfcMaterialLayerSetUsage>();
                case "IfcMaterialLayerWithOffsets":
                    return new List<IfcMaterialLayerWithOffsets>();
                case "IfcMaterialList":
                    return new List<IfcMaterialList>();
                case "IfcMaterialProfile":
                    return new List<IfcMaterialProfile>();
                case "IfcMaterialProfileSet":
                    return new List<IfcMaterialProfileSet>();
                case "IfcMaterialProfileSetUsage":
                    return new List<IfcMaterialProfileSetUsage>();
                case "IfcMaterialProfileSetUsageTapering":
                    return new List<IfcMaterialProfileSetUsageTapering>();
                case "IfcMaterialProfileWithOffsets":
                    return new List<IfcMaterialProfileWithOffsets>();
                case "IfcMaterialProperties":
                    return new List<IfcMaterialProperties>();
                case "IfcMaterialRelationship":
                    return new List<IfcMaterialRelationship>();
                case "IfcMaterialUsageDefinition":
                    return new List<IfcMaterialUsageDefinition>();
                case "IfcMeasureWithUnit":
                    return new List<IfcMeasureWithUnit>();
                case "IfcMechanicalFastener":
                    return new List<IfcMechanicalFastener>();
                case "IfcMechanicalFastenerType":
                    return new List<IfcMechanicalFastenerType>();
                case "IfcMedicalDevice":
                    return new List<IfcMedicalDevice>();
                case "IfcMedicalDeviceType":
                    return new List<IfcMedicalDeviceType>();
                case "IfcMember":
                    return new List<IfcMember>();
                case "IfcMemberStandardCase":
                    return new List<IfcMemberStandardCase>();
                case "IfcMemberType":
                    return new List<IfcMemberType>();
                case "IfcMetric":
                    return new List<IfcMetric>();
                case "IfcMirroredProfileDef":
                    return new List<IfcMirroredProfileDef>();
                case "IfcMonetaryUnit":
                    return new List<IfcMonetaryUnit>();
                case "IfcMotorConnection":
                    return new List<IfcMotorConnection>();
                case "IfcMotorConnectionType":
                    return new List<IfcMotorConnectionType>();
                case "IfcNamedUnit":
                    return new List<IfcNamedUnit>();
                case "IfcObject":
                    return new List<IfcObject>();
                case "IfcObjectDefinition":
                    return new List<IfcObjectDefinition>();
                case "IfcObjectPlacement":
                    return new List<IfcObjectPlacement>();
                case "IfcObjective":
                    return new List<IfcObjective>();
                case "IfcOccupant":
                    return new List<IfcOccupant>();
                case "IfcOffsetCurve2D":
                    return new List<IfcOffsetCurve2D>();
                case "IfcOffsetCurve3D":
                    return new List<IfcOffsetCurve3D>();
                case "IfcOpenShell":
                    return new List<IfcOpenShell>();
                case "IfcOpeningElement":
                    return new List<IfcOpeningElement>();
                case "IfcOpeningStandardCase":
                    return new List<IfcOpeningStandardCase>();
                case "IfcOrganization":
                    return new List<IfcOrganization>();
                case "IfcOrganizationRelationship":
                    return new List<IfcOrganizationRelationship>();
                case "IfcOrientedEdge":
                    return new List<IfcOrientedEdge>();
                case "IfcOuterBoundaryCurve":
                    return new List<IfcOuterBoundaryCurve>();
                case "IfcOutlet":
                    return new List<IfcOutlet>();
                case "IfcOutletType":
                    return new List<IfcOutletType>();
                case "IfcOwnerHistory":
                    return new List<IfcOwnerHistory>();
                case "IfcParameterizedProfileDef":
                    return new List<IfcParameterizedProfileDef>();
                case "IfcPath":
                    return new List<IfcPath>();
                case "IfcPcurve":
                    return new List<IfcPcurve>();
                case "IfcPerformanceHistory":
                    return new List<IfcPerformanceHistory>();
                case "IfcPermeableCoveringProperties":
                    return new List<IfcPermeableCoveringProperties>();
                case "IfcPermit":
                    return new List<IfcPermit>();
                case "IfcPerson":
                    return new List<IfcPerson>();
                case "IfcPersonAndOrganization":
                    return new List<IfcPersonAndOrganization>();
                case "IfcPhysicalComplexQuantity":
                    return new List<IfcPhysicalComplexQuantity>();
                case "IfcPhysicalQuantity":
                    return new List<IfcPhysicalQuantity>();
                case "IfcPhysicalSimpleQuantity":
                    return new List<IfcPhysicalSimpleQuantity>();
                case "IfcPile":
                    return new List<IfcPile>();
                case "IfcPileType":
                    return new List<IfcPileType>();
                case "IfcPipeFitting":
                    return new List<IfcPipeFitting>();
                case "IfcPipeFittingType":
                    return new List<IfcPipeFittingType>();
                case "IfcPipeSegment":
                    return new List<IfcPipeSegment>();
                case "IfcPipeSegmentType":
                    return new List<IfcPipeSegmentType>();
                case "IfcPixelTexture":
                    return new List<IfcPixelTexture>();
                case "IfcPlacement":
                    return new List<IfcPlacement>();
                case "IfcPlanarBox":
                    return new List<IfcPlanarBox>();
                case "IfcPlanarExtent":
                    return new List<IfcPlanarExtent>();
                case "IfcPlane":
                    return new List<IfcPlane>();
                case "IfcPlate":
                    return new List<IfcPlate>();
                case "IfcPlateStandardCase":
                    return new List<IfcPlateStandardCase>();
                case "IfcPlateType":
                    return new List<IfcPlateType>();
                case "IfcPoint":
                    return new List<IfcPoint>();
                case "IfcPointOnCurve":
                    return new List<IfcPointOnCurve>();
                case "IfcPointOnSurface":
                    return new List<IfcPointOnSurface>();
                case "IfcPolyLoop":
                    return new List<IfcPolyLoop>();
                case "IfcPolygonalBoundedHalfSpace":
                    return new List<IfcPolygonalBoundedHalfSpace>();
                case "IfcPolygonalFaceSet":
                    return new List<IfcPolygonalFaceSet>();
                case "IfcPolyline":
                    return new List<IfcPolyline>();
                case "IfcPort":
                    return new List<IfcPort>();
                case "IfcPostalAddress":
                    return new List<IfcPostalAddress>();
                case "IfcPreDefinedColour":
                    return new List<IfcPreDefinedColour>();
                case "IfcPreDefinedCurveFont":
                    return new List<IfcPreDefinedCurveFont>();
                case "IfcPreDefinedItem":
                    return new List<IfcPreDefinedItem>();
                case "IfcPreDefinedProperties":
                    return new List<IfcPreDefinedProperties>();
                case "IfcPreDefinedPropertySet":
                    return new List<IfcPreDefinedPropertySet>();
                case "IfcPreDefinedTextFont":
                    return new List<IfcPreDefinedTextFont>();
                case "IfcPresentationItem":
                    return new List<IfcPresentationItem>();
                case "IfcPresentationLayerAssignment":
                    return new List<IfcPresentationLayerAssignment>();
                case "IfcPresentationLayerWithStyle":
                    return new List<IfcPresentationLayerWithStyle>();
                case "IfcPresentationStyle":
                    return new List<IfcPresentationStyle>();
                case "IfcPresentationStyleAssignment":
                    return new List<IfcPresentationStyleAssignment>();
                case "IfcProcedure":
                    return new List<IfcProcedure>();
                case "IfcProcedureType":
                    return new List<IfcProcedureType>();
                case "IfcProcess":
                    return new List<IfcProcess>();
                case "IfcProduct":
                    return new List<IfcProduct>();
                case "IfcProductDefinitionShape":
                    return new List<IfcProductDefinitionShape>();
                case "IfcProductRepresentation":
                    return new List<IfcProductRepresentation>();
                case "IfcProfileDef":
                    return new List<IfcProfileDef>();
                case "IfcProfileProperties":
                    return new List<IfcProfileProperties>();
                case "IfcProject":
                    return new List<IfcProject>();
                case "IfcProjectLibrary":
                    return new List<IfcProjectLibrary>();
                case "IfcProjectOrder":
                    return new List<IfcProjectOrder>();
                case "IfcProjectedCRS":
                    return new List<IfcProjectedCRS>();
                case "IfcProjectionElement":
                    return new List<IfcProjectionElement>();
                case "IfcProperty":
                    return new List<IfcProperty>();
                case "IfcPropertyAbstraction":
                    return new List<IfcPropertyAbstraction>();
                case "IfcPropertyBoundedValue":
                    return new List<IfcPropertyBoundedValue>();
                case "IfcPropertyDefinition":
                    return new List<IfcPropertyDefinition>();
                case "IfcPropertyDependencyRelationship":
                    return new List<IfcPropertyDependencyRelationship>();
                case "IfcPropertyEnumeratedValue":
                    return new List<IfcPropertyEnumeratedValue>();
                case "IfcPropertyEnumeration":
                    return new List<IfcPropertyEnumeration>();
                case "IfcPropertyListValue":
                    return new List<IfcPropertyListValue>();
                case "IfcPropertyReferenceValue":
                    return new List<IfcPropertyReferenceValue>();
                case "IfcPropertySet":
                    return new List<IfcPropertySet>();
                case "IfcPropertySetDefinition":
                    return new List<IfcPropertySetDefinition>();
                case "IfcPropertySetTemplate":
                    return new List<IfcPropertySetTemplate>();
                case "IfcPropertySingleValue":
                    return new List<IfcPropertySingleValue>();
                case "IfcPropertyTableValue":
                    return new List<IfcPropertyTableValue>();
                case "IfcPropertyTemplate":
                    return new List<IfcPropertyTemplate>();
                case "IfcPropertyTemplateDefinition":
                    return new List<IfcPropertyTemplateDefinition>();
                case "IfcProtectiveDevice":
                    return new List<IfcProtectiveDevice>();
                case "IfcProtectiveDeviceTrippingUnit":
                    return new List<IfcProtectiveDeviceTrippingUnit>();
                case "IfcProtectiveDeviceTrippingUnitType":
                    return new List<IfcProtectiveDeviceTrippingUnitType>();
                case "IfcProtectiveDeviceType":
                    return new List<IfcProtectiveDeviceType>();
                case "IfcProxy":
                    return new List<IfcProxy>();
                case "IfcPump":
                    return new List<IfcPump>();
                case "IfcPumpType":
                    return new List<IfcPumpType>();
                case "IfcQuantityArea":
                    return new List<IfcQuantityArea>();
                case "IfcQuantityCount":
                    return new List<IfcQuantityCount>();
                case "IfcQuantityLength":
                    return new List<IfcQuantityLength>();
                case "IfcQuantitySet":
                    return new List<IfcQuantitySet>();
                case "IfcQuantityTime":
                    return new List<IfcQuantityTime>();
                case "IfcQuantityVolume":
                    return new List<IfcQuantityVolume>();
                case "IfcQuantityWeight":
                    return new List<IfcQuantityWeight>();
                case "IfcRailing":
                    return new List<IfcRailing>();
                case "IfcRailingType":
                    return new List<IfcRailingType>();
                case "IfcRamp":
                    return new List<IfcRamp>();
                case "IfcRampFlight":
                    return new List<IfcRampFlight>();
                case "IfcRampFlightType":
                    return new List<IfcRampFlightType>();
                case "IfcRampType":
                    return new List<IfcRampType>();
                case "IfcRationalBSplineCurveWithKnots":
                    return new List<IfcRationalBSplineCurveWithKnots>();
                case "IfcRationalBSplineSurfaceWithKnots":
                    return new List<IfcRationalBSplineSurfaceWithKnots>();
                case "IfcRectangleHollowProfileDef":
                    return new List<IfcRectangleHollowProfileDef>();
                case "IfcRectangleProfileDef":
                    return new List<IfcRectangleProfileDef>();
                case "IfcRectangularPyramid":
                    return new List<IfcRectangularPyramid>();
                case "IfcRectangularTrimmedSurface":
                    return new List<IfcRectangularTrimmedSurface>();
                case "IfcRecurrencePattern":
                    return new List<IfcRecurrencePattern>();
                case "IfcReference":
                    return new List<IfcReference>();
                case "IfcRegularTimeSeries":
                    return new List<IfcRegularTimeSeries>();
                case "IfcReinforcementBarProperties":
                    return new List<IfcReinforcementBarProperties>();
                case "IfcReinforcementDefinitionProperties":
                    return new List<IfcReinforcementDefinitionProperties>();
                case "IfcReinforcingBar":
                    return new List<IfcReinforcingBar>();
                case "IfcReinforcingBarType":
                    return new List<IfcReinforcingBarType>();
                case "IfcReinforcingElement":
                    return new List<IfcReinforcingElement>();
                case "IfcReinforcingElementType":
                    return new List<IfcReinforcingElementType>();
                case "IfcReinforcingMesh":
                    return new List<IfcReinforcingMesh>();
                case "IfcReinforcingMeshType":
                    return new List<IfcReinforcingMeshType>();
                case "IfcRelAggregates":
                    return new List<IfcRelAggregates>();
                case "IfcRelAssigns":
                    return new List<IfcRelAssigns>();
                case "IfcRelAssignsToActor":
                    return new List<IfcRelAssignsToActor>();
                case "IfcRelAssignsToControl":
                    return new List<IfcRelAssignsToControl>();
                case "IfcRelAssignsToGroup":
                    return new List<IfcRelAssignsToGroup>();
                case "IfcRelAssignsToGroupByFactor":
                    return new List<IfcRelAssignsToGroupByFactor>();
                case "IfcRelAssignsToProcess":
                    return new List<IfcRelAssignsToProcess>();
                case "IfcRelAssignsToProduct":
                    return new List<IfcRelAssignsToProduct>();
                case "IfcRelAssignsToResource":
                    return new List<IfcRelAssignsToResource>();
                case "IfcRelAssociates":
                    return new List<IfcRelAssociates>();
                case "IfcRelAssociatesApproval":
                    return new List<IfcRelAssociatesApproval>();
                case "IfcRelAssociatesClassification":
                    return new List<IfcRelAssociatesClassification>();
                case "IfcRelAssociatesConstraint":
                    return new List<IfcRelAssociatesConstraint>();
                case "IfcRelAssociatesDocument":
                    return new List<IfcRelAssociatesDocument>();
                case "IfcRelAssociatesLibrary":
                    return new List<IfcRelAssociatesLibrary>();
                case "IfcRelAssociatesMaterial":
                    return new List<IfcRelAssociatesMaterial>();
                case "IfcRelConnects":
                    return new List<IfcRelConnects>();
                case "IfcRelConnectsElements":
                    return new List<IfcRelConnectsElements>();
                case "IfcRelConnectsPathElements":
                    return new List<IfcRelConnectsPathElements>();
                case "IfcRelConnectsPortToElement":
                    return new List<IfcRelConnectsPortToElement>();
                case "IfcRelConnectsPorts":
                    return new List<IfcRelConnectsPorts>();
                case "IfcRelConnectsStructuralActivity":
                    return new List<IfcRelConnectsStructuralActivity>();
                case "IfcRelConnectsStructuralMember":
                    return new List<IfcRelConnectsStructuralMember>();
                case "IfcRelConnectsWithEccentricity":
                    return new List<IfcRelConnectsWithEccentricity>();
                case "IfcRelConnectsWithRealizingElements":
                    return new List<IfcRelConnectsWithRealizingElements>();
                case "IfcRelContainedInSpatialStructure":
                    return new List<IfcRelContainedInSpatialStructure>();
                case "IfcRelCoversBldgElements":
                    return new List<IfcRelCoversBldgElements>();
                case "IfcRelCoversSpaces":
                    return new List<IfcRelCoversSpaces>();
                case "IfcRelDeclares":
                    return new List<IfcRelDeclares>();
                case "IfcRelDecomposes":
                    return new List<IfcRelDecomposes>();
                case "IfcRelDefines":
                    return new List<IfcRelDefines>();
                case "IfcRelDefinesByObject":
                    return new List<IfcRelDefinesByObject>();
                case "IfcRelDefinesByProperties":
                    return new List<IfcRelDefinesByProperties>();
                case "IfcRelDefinesByTemplate":
                    return new List<IfcRelDefinesByTemplate>();
                case "IfcRelDefinesByType":
                    return new List<IfcRelDefinesByType>();
                case "IfcRelFillsElement":
                    return new List<IfcRelFillsElement>();
                case "IfcRelFlowControlElements":
                    return new List<IfcRelFlowControlElements>();
                case "IfcRelInterferesElements":
                    return new List<IfcRelInterferesElements>();
                case "IfcRelNests":
                    return new List<IfcRelNests>();
                case "IfcRelProjectsElement":
                    return new List<IfcRelProjectsElement>();
                case "IfcRelReferencedInSpatialStructure":
                    return new List<IfcRelReferencedInSpatialStructure>();
                case "IfcRelSequence":
                    return new List<IfcRelSequence>();
                case "IfcRelServicesBuildings":
                    return new List<IfcRelServicesBuildings>();
                case "IfcRelSpaceBoundary":
                    return new List<IfcRelSpaceBoundary>();
                case "IfcRelSpaceBoundary1stLevel":
                    return new List<IfcRelSpaceBoundary1stLevel>();
                case "IfcRelSpaceBoundary2ndLevel":
                    return new List<IfcRelSpaceBoundary2ndLevel>();
                case "IfcRelVoidsElement":
                    return new List<IfcRelVoidsElement>();
                case "IfcRelationship":
                    return new List<IfcRelationship>();
                case "IfcReparametrisedCompositeCurveSegment":
                    return new List<IfcReparametrisedCompositeCurveSegment>();
                case "IfcRepresentation":
                    return new List<IfcRepresentation>();
                case "IfcRepresentationContext":
                    return new List<IfcRepresentationContext>();
                case "IfcRepresentationItem":
                    return new List<IfcRepresentationItem>();
                case "IfcRepresentationMap":
                    return new List<IfcRepresentationMap>();
                case "IfcResource":
                    return new List<IfcResource>();
                case "IfcResourceApprovalRelationship":
                    return new List<IfcResourceApprovalRelationship>();
                case "IfcResourceConstraintRelationship":
                    return new List<IfcResourceConstraintRelationship>();
                case "IfcResourceLevelRelationship":
                    return new List<IfcResourceLevelRelationship>();
                case "IfcResourceTime":
                    return new List<IfcResourceTime>();
                case "IfcRevolvedAreaSolid":
                    return new List<IfcRevolvedAreaSolid>();
                case "IfcRevolvedAreaSolidTapered":
                    return new List<IfcRevolvedAreaSolidTapered>();
                case "IfcRightCircularCone":
                    return new List<IfcRightCircularCone>();
                case "IfcRightCircularCylinder":
                    return new List<IfcRightCircularCylinder>();
                case "IfcRoof":
                    return new List<IfcRoof>();
                case "IfcRoofType":
                    return new List<IfcRoofType>();
                case "IfcRoot":
                    return new List<IfcRoot>();
                case "IfcRoundedRectangleProfileDef":
                    return new List<IfcRoundedRectangleProfileDef>();
                case "IfcSIUnit":
                    return new List<IfcSIUnit>();
                case "IfcSanitaryTerminal":
                    return new List<IfcSanitaryTerminal>();
                case "IfcSanitaryTerminalType":
                    return new List<IfcSanitaryTerminalType>();
                case "IfcSchedulingTime":
                    return new List<IfcSchedulingTime>();
                case "IfcSeamCurve":
                    return new List<IfcSeamCurve>();
                case "IfcSectionProperties":
                    return new List<IfcSectionProperties>();
                case "IfcSectionReinforcementProperties":
                    return new List<IfcSectionReinforcementProperties>();
                case "IfcSectionedSpine":
                    return new List<IfcSectionedSpine>();
                case "IfcSensor":
                    return new List<IfcSensor>();
                case "IfcSensorType":
                    return new List<IfcSensorType>();
                case "IfcShadingDevice":
                    return new List<IfcShadingDevice>();
                case "IfcShadingDeviceType":
                    return new List<IfcShadingDeviceType>();
                case "IfcShapeAspect":
                    return new List<IfcShapeAspect>();
                case "IfcShapeModel":
                    return new List<IfcShapeModel>();
                case "IfcShapeRepresentation":
                    return new List<IfcShapeRepresentation>();
                case "IfcShellBasedSurfaceModel":
                    return new List<IfcShellBasedSurfaceModel>();
                case "IfcSimpleProperty":
                    return new List<IfcSimpleProperty>();
                case "IfcSimplePropertyTemplate":
                    return new List<IfcSimplePropertyTemplate>();
                case "IfcSite":
                    return new List<IfcSite>();
                case "IfcSlab":
                    return new List<IfcSlab>();
                case "IfcSlabElementedCase":
                    return new List<IfcSlabElementedCase>();
                case "IfcSlabStandardCase":
                    return new List<IfcSlabStandardCase>();
                case "IfcSlabType":
                    return new List<IfcSlabType>();
                case "IfcSlippageConnectionCondition":
                    return new List<IfcSlippageConnectionCondition>();
                case "IfcSolarDevice":
                    return new List<IfcSolarDevice>();
                case "IfcSolarDeviceType":
                    return new List<IfcSolarDeviceType>();
                case "IfcSolidModel":
                    return new List<IfcSolidModel>();
                case "IfcSpace":
                    return new List<IfcSpace>();
                case "IfcSpaceHeater":
                    return new List<IfcSpaceHeater>();
                case "IfcSpaceHeaterType":
                    return new List<IfcSpaceHeaterType>();
                case "IfcSpaceType":
                    return new List<IfcSpaceType>();
                case "IfcSpatialElement":
                    return new List<IfcSpatialElement>();
                case "IfcSpatialElementType":
                    return new List<IfcSpatialElementType>();
                case "IfcSpatialStructureElement":
                    return new List<IfcSpatialStructureElement>();
                case "IfcSpatialStructureElementType":
                    return new List<IfcSpatialStructureElementType>();
                case "IfcSpatialZone":
                    return new List<IfcSpatialZone>();
                case "IfcSpatialZoneType":
                    return new List<IfcSpatialZoneType>();
                case "IfcSphere":
                    return new List<IfcSphere>();
                case "IfcSphericalSurface":
                    return new List<IfcSphericalSurface>();
                case "IfcStackTerminal":
                    return new List<IfcStackTerminal>();
                case "IfcStackTerminalType":
                    return new List<IfcStackTerminalType>();
                case "IfcStair":
                    return new List<IfcStair>();
                case "IfcStairFlight":
                    return new List<IfcStairFlight>();
                case "IfcStairFlightType":
                    return new List<IfcStairFlightType>();
                case "IfcStairType":
                    return new List<IfcStairType>();
                case "IfcStructuralAction":
                    return new List<IfcStructuralAction>();
                case "IfcStructuralActivity":
                    return new List<IfcStructuralActivity>();
                case "IfcStructuralAnalysisModel":
                    return new List<IfcStructuralAnalysisModel>();
                case "IfcStructuralConnection":
                    return new List<IfcStructuralConnection>();
                case "IfcStructuralConnectionCondition":
                    return new List<IfcStructuralConnectionCondition>();
                case "IfcStructuralCurveAction":
                    return new List<IfcStructuralCurveAction>();
                case "IfcStructuralCurveConnection":
                    return new List<IfcStructuralCurveConnection>();
                case "IfcStructuralCurveMember":
                    return new List<IfcStructuralCurveMember>();
                case "IfcStructuralCurveMemberVarying":
                    return new List<IfcStructuralCurveMemberVarying>();
                case "IfcStructuralCurveReaction":
                    return new List<IfcStructuralCurveReaction>();
                case "IfcStructuralItem":
                    return new List<IfcStructuralItem>();
                case "IfcStructuralLinearAction":
                    return new List<IfcStructuralLinearAction>();
                case "IfcStructuralLoad":
                    return new List<IfcStructuralLoad>();
                case "IfcStructuralLoadCase":
                    return new List<IfcStructuralLoadCase>();
                case "IfcStructuralLoadConfiguration":
                    return new List<IfcStructuralLoadConfiguration>();
                case "IfcStructuralLoadGroup":
                    return new List<IfcStructuralLoadGroup>();
                case "IfcStructuralLoadLinearForce":
                    return new List<IfcStructuralLoadLinearForce>();
                case "IfcStructuralLoadOrResult":
                    return new List<IfcStructuralLoadOrResult>();
                case "IfcStructuralLoadPlanarForce":
                    return new List<IfcStructuralLoadPlanarForce>();
                case "IfcStructuralLoadSingleDisplacement":
                    return new List<IfcStructuralLoadSingleDisplacement>();
                case "IfcStructuralLoadSingleDisplacementDistortion":
                    return new List<IfcStructuralLoadSingleDisplacementDistortion>();
                case "IfcStructuralLoadSingleForce":
                    return new List<IfcStructuralLoadSingleForce>();
                case "IfcStructuralLoadSingleForceWarping":
                    return new List<IfcStructuralLoadSingleForceWarping>();
                case "IfcStructuralLoadStatic":
                    return new List<IfcStructuralLoadStatic>();
                case "IfcStructuralLoadTemperature":
                    return new List<IfcStructuralLoadTemperature>();
                case "IfcStructuralMember":
                    return new List<IfcStructuralMember>();
                case "IfcStructuralPlanarAction":
                    return new List<IfcStructuralPlanarAction>();
                case "IfcStructuralPointAction":
                    return new List<IfcStructuralPointAction>();
                case "IfcStructuralPointConnection":
                    return new List<IfcStructuralPointConnection>();
                case "IfcStructuralPointReaction":
                    return new List<IfcStructuralPointReaction>();
                case "IfcStructuralReaction":
                    return new List<IfcStructuralReaction>();
                case "IfcStructuralResultGroup":
                    return new List<IfcStructuralResultGroup>();
                case "IfcStructuralSurfaceAction":
                    return new List<IfcStructuralSurfaceAction>();
                case "IfcStructuralSurfaceConnection":
                    return new List<IfcStructuralSurfaceConnection>();
                case "IfcStructuralSurfaceMember":
                    return new List<IfcStructuralSurfaceMember>();
                case "IfcStructuralSurfaceMemberVarying":
                    return new List<IfcStructuralSurfaceMemberVarying>();
                case "IfcStructuralSurfaceReaction":
                    return new List<IfcStructuralSurfaceReaction>();
                case "IfcStyleModel":
                    return new List<IfcStyleModel>();
                case "IfcStyledItem":
                    return new List<IfcStyledItem>();
                case "IfcStyledRepresentation":
                    return new List<IfcStyledRepresentation>();
                case "IfcSubContractResource":
                    return new List<IfcSubContractResource>();
                case "IfcSubContractResourceType":
                    return new List<IfcSubContractResourceType>();
                case "IfcSubedge":
                    return new List<IfcSubedge>();
                case "IfcSurface":
                    return new List<IfcSurface>();
                case "IfcSurfaceCurve":
                    return new List<IfcSurfaceCurve>();
                case "IfcSurfaceCurveSweptAreaSolid":
                    return new List<IfcSurfaceCurveSweptAreaSolid>();
                case "IfcSurfaceFeature":
                    return new List<IfcSurfaceFeature>();
                case "IfcSurfaceOfLinearExtrusion":
                    return new List<IfcSurfaceOfLinearExtrusion>();
                case "IfcSurfaceOfRevolution":
                    return new List<IfcSurfaceOfRevolution>();
                case "IfcSurfaceReinforcementArea":
                    return new List<IfcSurfaceReinforcementArea>();
                case "IfcSurfaceStyle":
                    return new List<IfcSurfaceStyle>();
                case "IfcSurfaceStyleLighting":
                    return new List<IfcSurfaceStyleLighting>();
                case "IfcSurfaceStyleRefraction":
                    return new List<IfcSurfaceStyleRefraction>();
                case "IfcSurfaceStyleRendering":
                    return new List<IfcSurfaceStyleRendering>();
                case "IfcSurfaceStyleShading":
                    return new List<IfcSurfaceStyleShading>();
                case "IfcSurfaceStyleWithTextures":
                    return new List<IfcSurfaceStyleWithTextures>();
                case "IfcSurfaceTexture":
                    return new List<IfcSurfaceTexture>();
                case "IfcSweptAreaSolid":
                    return new List<IfcSweptAreaSolid>();
                case "IfcSweptDiskSolid":
                    return new List<IfcSweptDiskSolid>();
                case "IfcSweptDiskSolidPolygonal":
                    return new List<IfcSweptDiskSolidPolygonal>();
                case "IfcSweptSurface":
                    return new List<IfcSweptSurface>();
                case "IfcSwitchingDevice":
                    return new List<IfcSwitchingDevice>();
                case "IfcSwitchingDeviceType":
                    return new List<IfcSwitchingDeviceType>();
                case "IfcSystem":
                    return new List<IfcSystem>();
                case "IfcSystemFurnitureElement":
                    return new List<IfcSystemFurnitureElement>();
                case "IfcSystemFurnitureElementType":
                    return new List<IfcSystemFurnitureElementType>();
                case "IfcTShapeProfileDef":
                    return new List<IfcTShapeProfileDef>();
                case "IfcTable":
                    return new List<IfcTable>();
                case "IfcTableColumn":
                    return new List<IfcTableColumn>();
                case "IfcTableRow":
                    return new List<IfcTableRow>();
                case "IfcTank":
                    return new List<IfcTank>();
                case "IfcTankType":
                    return new List<IfcTankType>();
                case "IfcTask":
                    return new List<IfcTask>();
                case "IfcTaskTime":
                    return new List<IfcTaskTime>();
                case "IfcTaskTimeRecurring":
                    return new List<IfcTaskTimeRecurring>();
                case "IfcTaskType":
                    return new List<IfcTaskType>();
                case "IfcTelecomAddress":
                    return new List<IfcTelecomAddress>();
                case "IfcTendon":
                    return new List<IfcTendon>();
                case "IfcTendonAnchor":
                    return new List<IfcTendonAnchor>();
                case "IfcTendonAnchorType":
                    return new List<IfcTendonAnchorType>();
                case "IfcTendonType":
                    return new List<IfcTendonType>();
                case "IfcTessellatedFaceSet":
                    return new List<IfcTessellatedFaceSet>();
                case "IfcTessellatedItem":
                    return new List<IfcTessellatedItem>();
                case "IfcTextLiteral":
                    return new List<IfcTextLiteral>();
                case "IfcTextLiteralWithExtent":
                    return new List<IfcTextLiteralWithExtent>();
                case "IfcTextStyle":
                    return new List<IfcTextStyle>();
                case "IfcTextStyleFontModel":
                    return new List<IfcTextStyleFontModel>();
                case "IfcTextStyleForDefinedFont":
                    return new List<IfcTextStyleForDefinedFont>();
                case "IfcTextStyleTextModel":
                    return new List<IfcTextStyleTextModel>();
                case "IfcTextureCoordinate":
                    return new List<IfcTextureCoordinate>();
                case "IfcTextureCoordinateGenerator":
                    return new List<IfcTextureCoordinateGenerator>();
                case "IfcTextureMap":
                    return new List<IfcTextureMap>();
                case "IfcTextureVertex":
                    return new List<IfcTextureVertex>();
                case "IfcTextureVertexList":
                    return new List<IfcTextureVertexList>();
                case "IfcTimePeriod":
                    return new List<IfcTimePeriod>();
                case "IfcTimeSeries":
                    return new List<IfcTimeSeries>();
                case "IfcTimeSeriesValue":
                    return new List<IfcTimeSeriesValue>();
                case "IfcTopologicalRepresentationItem":
                    return new List<IfcTopologicalRepresentationItem>();
                case "IfcTopologyRepresentation":
                    return new List<IfcTopologyRepresentation>();
                case "IfcToroidalSurface":
                    return new List<IfcToroidalSurface>();
                case "IfcTransformer":
                    return new List<IfcTransformer>();
                case "IfcTransformerType":
                    return new List<IfcTransformerType>();
                case "IfcTransportElement":
                    return new List<IfcTransportElement>();
                case "IfcTransportElementType":
                    return new List<IfcTransportElementType>();
                case "IfcTrapeziumProfileDef":
                    return new List<IfcTrapeziumProfileDef>();
                case "IfcTriangulatedFaceSet":
                    return new List<IfcTriangulatedFaceSet>();
                case "IfcTrimmedCurve":
                    return new List<IfcTrimmedCurve>();
                case "IfcTubeBundle":
                    return new List<IfcTubeBundle>();
                case "IfcTubeBundleType":
                    return new List<IfcTubeBundleType>();
                case "IfcTypeObject":
                    return new List<IfcTypeObject>();
                case "IfcTypeProcess":
                    return new List<IfcTypeProcess>();
                case "IfcTypeProduct":
                    return new List<IfcTypeProduct>();
                case "IfcTypeResource":
                    return new List<IfcTypeResource>();
                case "IfcUShapeProfileDef":
                    return new List<IfcUShapeProfileDef>();
                case "IfcUnitAssignment":
                    return new List<IfcUnitAssignment>();
                case "IfcUnitaryControlElement":
                    return new List<IfcUnitaryControlElement>();
                case "IfcUnitaryControlElementType":
                    return new List<IfcUnitaryControlElementType>();
                case "IfcUnitaryEquipment":
                    return new List<IfcUnitaryEquipment>();
                case "IfcUnitaryEquipmentType":
                    return new List<IfcUnitaryEquipmentType>();
                case "IfcValve":
                    return new List<IfcValve>();
                case "IfcValveType":
                    return new List<IfcValveType>();
                case "IfcVector":
                    return new List<IfcVector>();
                case "IfcVertex":
                    return new List<IfcVertex>();
                case "IfcVertexLoop":
                    return new List<IfcVertexLoop>();
                case "IfcVertexPoint":
                    return new List<IfcVertexPoint>();
                case "IfcVibrationIsolator":
                    return new List<IfcVibrationIsolator>();
                case "IfcVibrationIsolatorType":
                    return new List<IfcVibrationIsolatorType>();
                case "IfcVirtualElement":
                    return new List<IfcVirtualElement>();
                case "IfcVirtualGridIntersection":
                    return new List<IfcVirtualGridIntersection>();
                case "IfcVoidingFeature":
                    return new List<IfcVoidingFeature>();
                case "IfcWall":
                    return new List<IfcWall>();
                case "IfcWallElementedCase":
                    return new List<IfcWallElementedCase>();
                case "IfcWallStandardCase":
                    return new List<IfcWallStandardCase>();
                case "IfcWallType":
                    return new List<IfcWallType>();
                case "IfcWasteTerminal":
                    return new List<IfcWasteTerminal>();
                case "IfcWasteTerminalType":
                    return new List<IfcWasteTerminalType>();
                case "IfcWindow":
                    return new List<IfcWindow>();
                case "IfcWindowLiningProperties":
                    return new List<IfcWindowLiningProperties>();
                case "IfcWindowPanelProperties":
                    return new List<IfcWindowPanelProperties>();
                case "IfcWindowStandardCase":
                    return new List<IfcWindowStandardCase>();
                case "IfcWindowStyle":
                    return new List<IfcWindowStyle>();
                case "IfcWindowType":
                    return new List<IfcWindowType>();
                case "IfcWorkCalendar":
                    return new List<IfcWorkCalendar>();
                case "IfcWorkControl":
                    return new List<IfcWorkControl>();
                case "IfcWorkPlan":
                    return new List<IfcWorkPlan>();
                case "IfcWorkSchedule":
                    return new List<IfcWorkSchedule>();
                case "IfcWorkTime":
                    return new List<IfcWorkTime>();
                case "IfcZShapeProfileDef":
                    return new List<IfcZShapeProfileDef>();
                case "IfcZone":
                    return new List<IfcZone>();
                default:
                    return null;
            }

        }
    }
}
