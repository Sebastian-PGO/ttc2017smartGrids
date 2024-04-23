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
    
    
    public class OriginatorCategoryKindConverter : System.ComponentModel.TypeConverter
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
                return default(OriginatorCategoryKind);
            }
            string valueString = value.ToString();
            if ((valueString == "notSupported"))
            {
                return OriginatorCategoryKind.NotSupported;
            }
            if ((valueString == "bayControl"))
            {
                return OriginatorCategoryKind.BayControl;
            }
            if ((valueString == "stationControl"))
            {
                return OriginatorCategoryKind.StationControl;
            }
            if ((valueString == "remoteControl"))
            {
                return OriginatorCategoryKind.RemoteControl;
            }
            if ((valueString == "automaticBay"))
            {
                return OriginatorCategoryKind.AutomaticBay;
            }
            if ((valueString == "automaticStation"))
            {
                return OriginatorCategoryKind.AutomaticStation;
            }
            if ((valueString == "automaticRemote"))
            {
                return OriginatorCategoryKind.AutomaticRemote;
            }
            if ((valueString == "maintenance"))
            {
                return OriginatorCategoryKind.Maintenance;
            }
            if ((valueString == "process"))
            {
                return OriginatorCategoryKind.Process;
            }
            return default(OriginatorCategoryKind);
        }
        
        public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType)
        {
            if ((value == null))
            {
                return null;
            }
            OriginatorCategoryKind valueCasted = ((OriginatorCategoryKind)(value));
            if ((valueCasted == OriginatorCategoryKind.NotSupported))
            {
                return "notSupported";
            }
            if ((valueCasted == OriginatorCategoryKind.BayControl))
            {
                return "bayControl";
            }
            if ((valueCasted == OriginatorCategoryKind.StationControl))
            {
                return "stationControl";
            }
            if ((valueCasted == OriginatorCategoryKind.RemoteControl))
            {
                return "remoteControl";
            }
            if ((valueCasted == OriginatorCategoryKind.AutomaticBay))
            {
                return "automaticBay";
            }
            if ((valueCasted == OriginatorCategoryKind.AutomaticStation))
            {
                return "automaticStation";
            }
            if ((valueCasted == OriginatorCategoryKind.AutomaticRemote))
            {
                return "automaticRemote";
            }
            if ((valueCasted == OriginatorCategoryKind.Maintenance))
            {
                return "maintenance";
            }
            if ((valueCasted == OriginatorCategoryKind.Process))
            {
                return "process";
            }
            throw new ArgumentOutOfRangeException("value");
        }
    }
}

