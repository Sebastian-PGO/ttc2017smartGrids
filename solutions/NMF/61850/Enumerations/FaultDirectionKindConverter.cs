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
    
    
    public class FaultDirectionKindConverter : System.ComponentModel.TypeConverter
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
                return default(FaultDirectionKind);
            }
            string valueString = value.ToString();
            if ((valueString == "unknown"))
            {
                return FaultDirectionKind.Unknown;
            }
            if ((valueString == "forward"))
            {
                return FaultDirectionKind.Forward;
            }
            if ((valueString == "backward"))
            {
                return FaultDirectionKind.Backward;
            }
            if ((valueString == "both"))
            {
                return FaultDirectionKind.Both;
            }
            return default(FaultDirectionKind);
        }
        
        public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType)
        {
            if ((value == null))
            {
                return null;
            }
            FaultDirectionKind valueCasted = ((FaultDirectionKind)(value));
            if ((valueCasted == FaultDirectionKind.Unknown))
            {
                return "unknown";
            }
            if ((valueCasted == FaultDirectionKind.Forward))
            {
                return "forward";
            }
            if ((valueCasted == FaultDirectionKind.Backward))
            {
                return "backward";
            }
            if ((valueCasted == FaultDirectionKind.Both))
            {
                return "both";
            }
            throw new ArgumentOutOfRangeException("value");
        }
    }
}

