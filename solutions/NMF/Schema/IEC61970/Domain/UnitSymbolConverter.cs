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

namespace TTC2017.SmartGrids.CIM.IEC61970.Domain
{
    
    
    public class UnitSymbolConverter : System.ComponentModel.TypeConverter
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
                return default(UnitSymbol);
            }
            string valueString = value.ToString();
            if ((valueString == "A"))
            {
                return UnitSymbol.A;
            }
            if ((valueString == "rad"))
            {
                return UnitSymbol.Rad;
            }
            if ((valueString == "none"))
            {
                return UnitSymbol.None;
            }
            if ((valueString == "V"))
            {
                return UnitSymbol.V;
            }
            if ((valueString == "g"))
            {
                return UnitSymbol.G;
            }
            if ((valueString == "WHz"))
            {
                return UnitSymbol.WHz;
            }
            if ((valueString == "m2"))
            {
                return UnitSymbol.M2;
            }
            if ((valueString == "VA"))
            {
                return UnitSymbol.VA;
            }
            if ((valueString == "VArh"))
            {
                return UnitSymbol.VArh;
            }
            if ((valueString == "N"))
            {
                return UnitSymbol.N;
            }
            if ((valueString == "Pa"))
            {
                return UnitSymbol.Pa;
            }
            if ((valueString == "VAh"))
            {
                return UnitSymbol.VAh;
            }
            if ((valueString == "F"))
            {
                return UnitSymbol.F;
            }
            if ((valueString == "H"))
            {
                return UnitSymbol.H;
            }
            if ((valueString == "Hzminus1"))
            {
                return UnitSymbol.Hzminus1;
            }
            if ((valueString == "J"))
            {
                return UnitSymbol.J;
            }
            if ((valueString == "Ws"))
            {
                return UnitSymbol.Ws;
            }
            if ((valueString == "m"))
            {
                return UnitSymbol.M;
            }
            if ((valueString == "S"))
            {
                return UnitSymbol.S;
            }
            if ((valueString == "min"))
            {
                return UnitSymbol.Min;
            }
            if ((valueString == "deg"))
            {
                return UnitSymbol.Deg;
            }
            if ((valueString == "Js"))
            {
                return UnitSymbol.Js;
            }
            if ((valueString == "s"))
            {
                return UnitSymbol.S1;
            }
            if ((valueString == "Wh"))
            {
                return UnitSymbol.Wh;
            }
            if ((valueString == "m3"))
            {
                return UnitSymbol.M3;
            }
            if ((valueString == "ºC"))
            {
                return UnitSymbol.ºC;
            }
            if ((valueString == "VVAr"))
            {
                return UnitSymbol.VVAr;
            }
            if ((valueString == "sminus1"))
            {
                return UnitSymbol.Sminus1;
            }
            if ((valueString == "h_"))
            {
                return UnitSymbol.H_;
            }
            if ((valueString == "W"))
            {
                return UnitSymbol.W;
            }
            if ((valueString == "ohm"))
            {
                return UnitSymbol.Ohm;
            }
            if ((valueString == "Hz"))
            {
                return UnitSymbol.Hz;
            }
            if ((valueString == "VAr"))
            {
                return UnitSymbol.VAr;
            }
            if ((valueString == "kgJ"))
            {
                return UnitSymbol.KgJ;
            }
            return default(UnitSymbol);
        }
        
        public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType)
        {
            if ((value == null))
            {
                return null;
            }
            UnitSymbol valueCasted = ((UnitSymbol)(value));
            if ((valueCasted == UnitSymbol.A))
            {
                return "A";
            }
            if ((valueCasted == UnitSymbol.Rad))
            {
                return "rad";
            }
            if ((valueCasted == UnitSymbol.None))
            {
                return "none";
            }
            if ((valueCasted == UnitSymbol.V))
            {
                return "V";
            }
            if ((valueCasted == UnitSymbol.G))
            {
                return "g";
            }
            if ((valueCasted == UnitSymbol.WHz))
            {
                return "WHz";
            }
            if ((valueCasted == UnitSymbol.M2))
            {
                return "m2";
            }
            if ((valueCasted == UnitSymbol.VA))
            {
                return "VA";
            }
            if ((valueCasted == UnitSymbol.VArh))
            {
                return "VArh";
            }
            if ((valueCasted == UnitSymbol.N))
            {
                return "N";
            }
            if ((valueCasted == UnitSymbol.Pa))
            {
                return "Pa";
            }
            if ((valueCasted == UnitSymbol.VAh))
            {
                return "VAh";
            }
            if ((valueCasted == UnitSymbol.F))
            {
                return "F";
            }
            if ((valueCasted == UnitSymbol.H))
            {
                return "H";
            }
            if ((valueCasted == UnitSymbol.Hzminus1))
            {
                return "Hzminus1";
            }
            if ((valueCasted == UnitSymbol.J))
            {
                return "J";
            }
            if ((valueCasted == UnitSymbol.Ws))
            {
                return "Ws";
            }
            if ((valueCasted == UnitSymbol.M))
            {
                return "m";
            }
            if ((valueCasted == UnitSymbol.S))
            {
                return "S";
            }
            if ((valueCasted == UnitSymbol.Min))
            {
                return "min";
            }
            if ((valueCasted == UnitSymbol.Deg))
            {
                return "deg";
            }
            if ((valueCasted == UnitSymbol.Js))
            {
                return "Js";
            }
            if ((valueCasted == UnitSymbol.S1))
            {
                return "s";
            }
            if ((valueCasted == UnitSymbol.Wh))
            {
                return "Wh";
            }
            if ((valueCasted == UnitSymbol.M3))
            {
                return "m3";
            }
            if ((valueCasted == UnitSymbol.ºC))
            {
                return "ºC";
            }
            if ((valueCasted == UnitSymbol.VVAr))
            {
                return "VVAr";
            }
            if ((valueCasted == UnitSymbol.Sminus1))
            {
                return "sminus1";
            }
            if ((valueCasted == UnitSymbol.H_))
            {
                return "h_";
            }
            if ((valueCasted == UnitSymbol.W))
            {
                return "W";
            }
            if ((valueCasted == UnitSymbol.Ohm))
            {
                return "ohm";
            }
            if ((valueCasted == UnitSymbol.Hz))
            {
                return "Hz";
            }
            if ((valueCasted == UnitSymbol.VAr))
            {
                return "VAr";
            }
            if ((valueCasted == UnitSymbol.KgJ))
            {
                return "kgJ";
            }
            throw new ArgumentOutOfRangeException("value");
        }
    }
}

