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
using NMF.Models.Meta;
using NMF.Models.Repository;
using NMF.Serialization;
using NMF.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using TTC2017.SmartGrids.CIM.IEC61968.Common;
using TTC2017.SmartGrids.CIM.IEC61968.Metering;
using TTC2017.SmartGrids.CIM.IEC61970.Wires;

namespace TTC2017.SmartGrids.CIM.IEC61970.Informative.InfLoadControl
{
    
    
    public class LoadMgmtKindConverter : System.ComponentModel.TypeConverter
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
                return default(LoadMgmtKind);
            }
            string valueString = value.ToString();
            if ((valueString == "timeBased"))
            {
                return LoadMgmtKind.TimeBased;
            }
            if ((valueString == "remoteControl"))
            {
                return LoadMgmtKind.RemoteControl;
            }
            if ((valueString == "manualControl"))
            {
                return LoadMgmtKind.ManualControl;
            }
            if ((valueString == "tariffBased"))
            {
                return LoadMgmtKind.TariffBased;
            }
            return default(LoadMgmtKind);
        }
        
        public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType)
        {
            if ((value == null))
            {
                return null;
            }
            LoadMgmtKind valueCasted = ((LoadMgmtKind)(value));
            if ((valueCasted == LoadMgmtKind.TimeBased))
            {
                return "timeBased";
            }
            if ((valueCasted == LoadMgmtKind.RemoteControl))
            {
                return "remoteControl";
            }
            if ((valueCasted == LoadMgmtKind.ManualControl))
            {
                return "manualControl";
            }
            if ((valueCasted == LoadMgmtKind.TariffBased))
            {
                return "tariffBased";
            }
            throw new ArgumentOutOfRangeException("value");
        }
    }
}

