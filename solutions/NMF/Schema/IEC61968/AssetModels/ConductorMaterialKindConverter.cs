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
using TTC2017.SmartGrids.CIM.IEC61968.Metering;
using TTC2017.SmartGrids.CIM.IEC61968.WiresExt;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssetModels;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssets;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfERPSupport;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfTypeAsset;
using TTC2017.SmartGrids.CIM.IEC61970.Wires;

namespace TTC2017.SmartGrids.CIM.IEC61968.AssetModels
{
    
    
    public class ConductorMaterialKindConverter : System.ComponentModel.TypeConverter
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
                return default(ConductorMaterialKind);
            }
            string valueString = value.ToString();
            if ((valueString == "steel"))
            {
                return ConductorMaterialKind.Steel;
            }
            if ((valueString == "other"))
            {
                return ConductorMaterialKind.Other;
            }
            if ((valueString == "aluminum"))
            {
                return ConductorMaterialKind.Aluminum;
            }
            if ((valueString == "copper"))
            {
                return ConductorMaterialKind.Copper;
            }
            if ((valueString == "acsr"))
            {
                return ConductorMaterialKind.Acsr;
            }
            return default(ConductorMaterialKind);
        }
        
        public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType)
        {
            if ((value == null))
            {
                return null;
            }
            ConductorMaterialKind valueCasted = ((ConductorMaterialKind)(value));
            if ((valueCasted == ConductorMaterialKind.Steel))
            {
                return "steel";
            }
            if ((valueCasted == ConductorMaterialKind.Other))
            {
                return "other";
            }
            if ((valueCasted == ConductorMaterialKind.Aluminum))
            {
                return "aluminum";
            }
            if ((valueCasted == ConductorMaterialKind.Copper))
            {
                return "copper";
            }
            if ((valueCasted == ConductorMaterialKind.Acsr))
            {
                return "acsr";
            }
            throw new ArgumentOutOfRangeException("value");
        }
    }
}

