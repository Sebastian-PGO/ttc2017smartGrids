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
    
    
    public class PumpControlKindConverter : System.ComponentModel.TypeConverter
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
                return default(PumpControlKind);
            }
            string valueString = value.ToString();
            if ((valueString == "inactive"))
            {
                return PumpControlKind.Inactive;
            }
            if ((valueString == "stage1"))
            {
                return PumpControlKind.Stage1;
            }
            if ((valueString == "stage2"))
            {
                return PumpControlKind.Stage2;
            }
            if ((valueString == "stage3"))
            {
                return PumpControlKind.Stage3;
            }
            return default(PumpControlKind);
        }
        
        public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType)
        {
            if ((value == null))
            {
                return null;
            }
            PumpControlKind valueCasted = ((PumpControlKind)(value));
            if ((valueCasted == PumpControlKind.Inactive))
            {
                return "inactive";
            }
            if ((valueCasted == PumpControlKind.Stage1))
            {
                return "stage1";
            }
            if ((valueCasted == PumpControlKind.Stage2))
            {
                return "stage2";
            }
            if ((valueCasted == PumpControlKind.Stage3))
            {
                return "stage3";
            }
            throw new ArgumentOutOfRangeException("value");
        }
    }
}

