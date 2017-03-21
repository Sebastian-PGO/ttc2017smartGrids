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
using TTC2017.SmartGrids.CIM.IEC61968.AssetModels;
using TTC2017.SmartGrids.CIM.IEC61968.Common;
using TTC2017.SmartGrids.CIM.IEC61968.Metering;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssets;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfERPSupport;

namespace TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssetModels
{
    
    
    public class CableShieldKindConverter : System.ComponentModel.TypeConverter
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
                return default(CableShieldKind);
            }
            string valueString = value.ToString();
            if ((valueString == "superclean"))
            {
                return CableShieldKind.Superclean;
            }
            if ((valueString == "supersmooth"))
            {
                return CableShieldKind.Supersmooth;
            }
            if ((valueString == "conventional"))
            {
                return CableShieldKind.Conventional;
            }
            if ((valueString == "other"))
            {
                return CableShieldKind.Other;
            }
            if ((valueString == "freeForm"))
            {
                return CableShieldKind.FreeForm;
            }
            return default(CableShieldKind);
        }
        
        public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType)
        {
            if ((value == null))
            {
                return null;
            }
            CableShieldKind valueCasted = ((CableShieldKind)(value));
            if ((valueCasted == CableShieldKind.Superclean))
            {
                return "superclean";
            }
            if ((valueCasted == CableShieldKind.Supersmooth))
            {
                return "supersmooth";
            }
            if ((valueCasted == CableShieldKind.Conventional))
            {
                return "conventional";
            }
            if ((valueCasted == CableShieldKind.Other))
            {
                return "other";
            }
            if ((valueCasted == CableShieldKind.FreeForm))
            {
                return "freeForm";
            }
            throw new ArgumentOutOfRangeException("value");
        }
    }
}

