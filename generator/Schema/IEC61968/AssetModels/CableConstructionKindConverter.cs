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
    
    
    public class CableConstructionKindConverter : System.ComponentModel.TypeConverter
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
                return default(CableConstructionKind);
            }
            string valueString = value.ToString();
            if ((valueString == "solid"))
            {
                return CableConstructionKind.Solid;
            }
            if ((valueString == "stranded"))
            {
                return CableConstructionKind.Stranded;
            }
            if ((valueString == "other"))
            {
                return CableConstructionKind.Other;
            }
            if ((valueString == "segmental"))
            {
                return CableConstructionKind.Segmental;
            }
            if ((valueString == "compacted"))
            {
                return CableConstructionKind.Compacted;
            }
            if ((valueString == "sector"))
            {
                return CableConstructionKind.Sector;
            }
            if ((valueString == "compressed"))
            {
                return CableConstructionKind.Compressed;
            }
            return default(CableConstructionKind);
        }
        
        public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType)
        {
            if ((value == null))
            {
                return null;
            }
            CableConstructionKind valueCasted = ((CableConstructionKind)(value));
            if ((valueCasted == CableConstructionKind.Solid))
            {
                return "solid";
            }
            if ((valueCasted == CableConstructionKind.Stranded))
            {
                return "stranded";
            }
            if ((valueCasted == CableConstructionKind.Other))
            {
                return "other";
            }
            if ((valueCasted == CableConstructionKind.Segmental))
            {
                return "segmental";
            }
            if ((valueCasted == CableConstructionKind.Compacted))
            {
                return "compacted";
            }
            if ((valueCasted == CableConstructionKind.Sector))
            {
                return "sector";
            }
            if ((valueCasted == CableConstructionKind.Compressed))
            {
                return "compressed";
            }
            throw new ArgumentOutOfRangeException("value");
        }
    }
}

