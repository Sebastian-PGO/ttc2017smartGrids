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
    
    
    public class TimeAccuracyKindConverter : System.ComponentModel.TypeConverter
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
                return default(TimeAccuracyKind);
            }
            string valueString = value.ToString();
            if ((valueString == "T0"))
            {
                return TimeAccuracyKind.T0;
            }
            if ((valueString == "T1"))
            {
                return TimeAccuracyKind.T1;
            }
            if ((valueString == "T2"))
            {
                return TimeAccuracyKind.T2;
            }
            if ((valueString == "T3"))
            {
                return TimeAccuracyKind.T3;
            }
            if ((valueString == "T4"))
            {
                return TimeAccuracyKind.T4;
            }
            if ((valueString == "T5"))
            {
                return TimeAccuracyKind.T5;
            }
            if ((valueString == "unspecified"))
            {
                return TimeAccuracyKind.Unspecified;
            }
            return default(TimeAccuracyKind);
        }
        
        public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType)
        {
            if ((value == null))
            {
                return null;
            }
            TimeAccuracyKind valueCasted = ((TimeAccuracyKind)(value));
            if ((valueCasted == TimeAccuracyKind.T0))
            {
                return "T0";
            }
            if ((valueCasted == TimeAccuracyKind.T1))
            {
                return "T1";
            }
            if ((valueCasted == TimeAccuracyKind.T2))
            {
                return "T2";
            }
            if ((valueCasted == TimeAccuracyKind.T3))
            {
                return "T3";
            }
            if ((valueCasted == TimeAccuracyKind.T4))
            {
                return "T4";
            }
            if ((valueCasted == TimeAccuracyKind.T5))
            {
                return "T5";
            }
            if ((valueCasted == TimeAccuracyKind.Unspecified))
            {
                return "unspecified";
            }
            throw new ArgumentOutOfRangeException("value");
        }
    }
}

