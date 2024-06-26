using System.Collections.Specialized;
//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using NMF.Collections.Generic;
using NMF.Collections.ObjectModel;
using NMF.Expressions;
using NMF.Expressions.Linq;
using NMF.Models;
using NMF.Models.Collections;
using NMF.Models.Expressions;
using NMF.Serialization;
using NMF.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace TTC2017.SmartGrids.SubstationStandard.Enumerations
{
    
    
    public class SIUnitsKindConverter : System.ComponentModel.TypeConverter
    {
        
        public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType)
        {
            return (sourceType == typeof(string));
        }
        
        public override bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType)
        {
            return (destinationType == typeof(string));
        }
        
        public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value)
        {
            if ((value == null))
            {
                return default(SIUnitsKind);
            }
            string valueString = value.ToString();
            if ((valueString == "dimensionless"))
            {
                return SIUnitsKind.Dimensionless;
            }
            if ((valueString == "meter"))
            {
                return SIUnitsKind.Meter;
            }
            if ((valueString == "kilogram"))
            {
                return SIUnitsKind.Kilogram;
            }
            if ((valueString == "second"))
            {
                return SIUnitsKind.Second;
            }
            if ((valueString == "ampere"))
            {
                return SIUnitsKind.Ampere;
            }
            if ((valueString == "Kelvin"))
            {
                return SIUnitsKind.Kelvin;
            }
            if ((valueString == "mole"))
            {
                return SIUnitsKind.Mole;
            }
            if ((valueString == "candela"))
            {
                return SIUnitsKind.Candela;
            }
            if ((valueString == "degree"))
            {
                return SIUnitsKind.Degree;
            }
            if ((valueString == "radian"))
            {
                return SIUnitsKind.Radian;
            }
            if ((valueString == "steradian"))
            {
                return SIUnitsKind.Steradian;
            }
            if ((valueString == "Gray"))
            {
                return SIUnitsKind.Gray;
            }
            if ((valueString == "becquerel"))
            {
                return SIUnitsKind.Becquerel;
            }
            if ((valueString == "degreeCelsius"))
            {
                return SIUnitsKind.DegreeCelsius;
            }
            if ((valueString == "sievert"))
            {
                return SIUnitsKind.Sievert;
            }
            if ((valueString == "farad"))
            {
                return SIUnitsKind.Farad;
            }
            if ((valueString == "coulomb"))
            {
                return SIUnitsKind.Coulomb;
            }
            if ((valueString == "siemens"))
            {
                return SIUnitsKind.Siemens;
            }
            if ((valueString == "henry"))
            {
                return SIUnitsKind.Henry;
            }
            if ((valueString == "volt"))
            {
                return SIUnitsKind.Volt;
            }
            if ((valueString == "ohm"))
            {
                return SIUnitsKind.Ohm;
            }
            if ((valueString == "joule"))
            {
                return SIUnitsKind.Joule;
            }
            if ((valueString == "newton"))
            {
                return SIUnitsKind.Newton;
            }
            if ((valueString == "hertz"))
            {
                return SIUnitsKind.Hertz;
            }
            if ((valueString == "lux"))
            {
                return SIUnitsKind.Lux;
            }
            if ((valueString == "lumen"))
            {
                return SIUnitsKind.Lumen;
            }
            if ((valueString == "weber"))
            {
                return SIUnitsKind.Weber;
            }
            if ((valueString == "tesla"))
            {
                return SIUnitsKind.Tesla;
            }
            if ((valueString == "wattGeneral"))
            {
                return SIUnitsKind.WattGeneral;
            }
            if ((valueString == "pascal"))
            {
                return SIUnitsKind.Pascal;
            }
            if ((valueString == "squareMeter"))
            {
                return SIUnitsKind.SquareMeter;
            }
            if ((valueString == "cubicMeter"))
            {
                return SIUnitsKind.CubicMeter;
            }
            if ((valueString == "meterPerSecond"))
            {
                return SIUnitsKind.MeterPerSecond;
            }
            if ((valueString == "meterPerSquareSecond"))
            {
                return SIUnitsKind.MeterPerSquareSecond;
            }
            if ((valueString == "cubicMeterPerSecond"))
            {
                return SIUnitsKind.CubicMeterPerSecond;
            }
            if ((valueString == "meterPerCubicMeter"))
            {
                return SIUnitsKind.MeterPerCubicMeter;
            }
            if ((valueString == "kilogramMeter"))
            {
                return SIUnitsKind.KilogramMeter;
            }
            if ((valueString == "kilogramPerCubicMeter"))
            {
                return SIUnitsKind.KilogramPerCubicMeter;
            }
            if ((valueString == "squareMeterPerSecond"))
            {
                return SIUnitsKind.SquareMeterPerSecond;
            }
            if ((valueString == "wattPerMeterKelvin"))
            {
                return SIUnitsKind.WattPerMeterKelvin;
            }
            if ((valueString == "joulePerKelvin"))
            {
                return SIUnitsKind.JoulePerKelvin;
            }
            if ((valueString == "partPerMillion"))
            {
                return SIUnitsKind.PartPerMillion;
            }
            if ((valueString == "rotationPerSecond"))
            {
                return SIUnitsKind.RotationPerSecond;
            }
            if ((valueString == "radianPerSecond"))
            {
                return SIUnitsKind.RadianPerSecond;
            }
            if ((valueString == "voltAmpere"))
            {
                return SIUnitsKind.VoltAmpere;
            }
            if ((valueString == "watt"))
            {
                return SIUnitsKind.Watt;
            }
            if ((valueString == "voltAmpereReactive"))
            {
                return SIUnitsKind.VoltAmpereReactive;
            }
            if ((valueString == "phaseAngleDegree"))
            {
                return SIUnitsKind.PhaseAngleDegree;
            }
            if ((valueString == "cosTheta"))
            {
                return SIUnitsKind.CosTheta;
            }
            if ((valueString == "voltSecond"))
            {
                return SIUnitsKind.VoltSecond;
            }
            if ((valueString == "voltSquare"))
            {
                return SIUnitsKind.VoltSquare;
            }
            if ((valueString == "ampSecond"))
            {
                return SIUnitsKind.AmpSecond;
            }
            if ((valueString == "ampSquare"))
            {
                return SIUnitsKind.AmpSquare;
            }
            if ((valueString == "ampSquareSecond"))
            {
                return SIUnitsKind.AmpSquareSecond;
            }
            if ((valueString == "voltAmpereHour"))
            {
                return SIUnitsKind.VoltAmpereHour;
            }
            if ((valueString == "wattHour"))
            {
                return SIUnitsKind.WattHour;
            }
            if ((valueString == "voltAmpereReactiveHour"))
            {
                return SIUnitsKind.VoltAmpereReactiveHour;
            }
            if ((valueString == "voltPerHertz"))
            {
                return SIUnitsKind.VoltPerHertz;
            }
            return default(SIUnitsKind);
        }
        
        public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType)
        {
            if ((value == null))
            {
                return null;
            }
            SIUnitsKind valueCasted = ((SIUnitsKind)(value));
            if ((valueCasted == SIUnitsKind.Dimensionless))
            {
                return "dimensionless";
            }
            if ((valueCasted == SIUnitsKind.Meter))
            {
                return "meter";
            }
            if ((valueCasted == SIUnitsKind.Kilogram))
            {
                return "kilogram";
            }
            if ((valueCasted == SIUnitsKind.Second))
            {
                return "second";
            }
            if ((valueCasted == SIUnitsKind.Ampere))
            {
                return "ampere";
            }
            if ((valueCasted == SIUnitsKind.Kelvin))
            {
                return "Kelvin";
            }
            if ((valueCasted == SIUnitsKind.Mole))
            {
                return "mole";
            }
            if ((valueCasted == SIUnitsKind.Candela))
            {
                return "candela";
            }
            if ((valueCasted == SIUnitsKind.Degree))
            {
                return "degree";
            }
            if ((valueCasted == SIUnitsKind.Radian))
            {
                return "radian";
            }
            if ((valueCasted == SIUnitsKind.Steradian))
            {
                return "steradian";
            }
            if ((valueCasted == SIUnitsKind.Gray))
            {
                return "Gray";
            }
            if ((valueCasted == SIUnitsKind.Becquerel))
            {
                return "becquerel";
            }
            if ((valueCasted == SIUnitsKind.DegreeCelsius))
            {
                return "degreeCelsius";
            }
            if ((valueCasted == SIUnitsKind.Sievert))
            {
                return "sievert";
            }
            if ((valueCasted == SIUnitsKind.Farad))
            {
                return "farad";
            }
            if ((valueCasted == SIUnitsKind.Coulomb))
            {
                return "coulomb";
            }
            if ((valueCasted == SIUnitsKind.Siemens))
            {
                return "siemens";
            }
            if ((valueCasted == SIUnitsKind.Henry))
            {
                return "henry";
            }
            if ((valueCasted == SIUnitsKind.Volt))
            {
                return "volt";
            }
            if ((valueCasted == SIUnitsKind.Ohm))
            {
                return "ohm";
            }
            if ((valueCasted == SIUnitsKind.Joule))
            {
                return "joule";
            }
            if ((valueCasted == SIUnitsKind.Newton))
            {
                return "newton";
            }
            if ((valueCasted == SIUnitsKind.Hertz))
            {
                return "hertz";
            }
            if ((valueCasted == SIUnitsKind.Lux))
            {
                return "lux";
            }
            if ((valueCasted == SIUnitsKind.Lumen))
            {
                return "lumen";
            }
            if ((valueCasted == SIUnitsKind.Weber))
            {
                return "weber";
            }
            if ((valueCasted == SIUnitsKind.Tesla))
            {
                return "tesla";
            }
            if ((valueCasted == SIUnitsKind.WattGeneral))
            {
                return "wattGeneral";
            }
            if ((valueCasted == SIUnitsKind.Pascal))
            {
                return "pascal";
            }
            if ((valueCasted == SIUnitsKind.SquareMeter))
            {
                return "squareMeter";
            }
            if ((valueCasted == SIUnitsKind.CubicMeter))
            {
                return "cubicMeter";
            }
            if ((valueCasted == SIUnitsKind.MeterPerSecond))
            {
                return "meterPerSecond";
            }
            if ((valueCasted == SIUnitsKind.MeterPerSquareSecond))
            {
                return "meterPerSquareSecond";
            }
            if ((valueCasted == SIUnitsKind.CubicMeterPerSecond))
            {
                return "cubicMeterPerSecond";
            }
            if ((valueCasted == SIUnitsKind.MeterPerCubicMeter))
            {
                return "meterPerCubicMeter";
            }
            if ((valueCasted == SIUnitsKind.KilogramMeter))
            {
                return "kilogramMeter";
            }
            if ((valueCasted == SIUnitsKind.KilogramPerCubicMeter))
            {
                return "kilogramPerCubicMeter";
            }
            if ((valueCasted == SIUnitsKind.SquareMeterPerSecond))
            {
                return "squareMeterPerSecond";
            }
            if ((valueCasted == SIUnitsKind.WattPerMeterKelvin))
            {
                return "wattPerMeterKelvin";
            }
            if ((valueCasted == SIUnitsKind.JoulePerKelvin))
            {
                return "joulePerKelvin";
            }
            if ((valueCasted == SIUnitsKind.PartPerMillion))
            {
                return "partPerMillion";
            }
            if ((valueCasted == SIUnitsKind.RotationPerSecond))
            {
                return "rotationPerSecond";
            }
            if ((valueCasted == SIUnitsKind.RadianPerSecond))
            {
                return "radianPerSecond";
            }
            if ((valueCasted == SIUnitsKind.VoltAmpere))
            {
                return "voltAmpere";
            }
            if ((valueCasted == SIUnitsKind.Watt))
            {
                return "watt";
            }
            if ((valueCasted == SIUnitsKind.VoltAmpereReactive))
            {
                return "voltAmpereReactive";
            }
            if ((valueCasted == SIUnitsKind.PhaseAngleDegree))
            {
                return "phaseAngleDegree";
            }
            if ((valueCasted == SIUnitsKind.CosTheta))
            {
                return "cosTheta";
            }
            if ((valueCasted == SIUnitsKind.VoltSecond))
            {
                return "voltSecond";
            }
            if ((valueCasted == SIUnitsKind.VoltSquare))
            {
                return "voltSquare";
            }
            if ((valueCasted == SIUnitsKind.AmpSecond))
            {
                return "ampSecond";
            }
            if ((valueCasted == SIUnitsKind.AmpSquare))
            {
                return "ampSquare";
            }
            if ((valueCasted == SIUnitsKind.AmpSquareSecond))
            {
                return "ampSquareSecond";
            }
            if ((valueCasted == SIUnitsKind.VoltAmpereHour))
            {
                return "voltAmpereHour";
            }
            if ((valueCasted == SIUnitsKind.WattHour))
            {
                return "wattHour";
            }
            if ((valueCasted == SIUnitsKind.VoltAmpereReactiveHour))
            {
                return "voltAmpereReactiveHour";
            }
            if ((valueCasted == SIUnitsKind.VoltPerHertz))
            {
                return "voltPerHertz";
            }
            throw new ArgumentOutOfRangeException("value");
        }
    }
}

