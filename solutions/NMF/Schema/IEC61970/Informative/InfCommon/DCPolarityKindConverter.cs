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
using TTC2017.SmartGrids.CIM;
using TTC2017.SmartGrids.CIM.IEC61968.Assets;
using TTC2017.SmartGrids.CIM.IEC61968.Common;
using TTC2017.SmartGrids.CIM.IEC61968.PaymentMetering;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfERPSupport;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfPaymentMetering;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfWork;

namespace TTC2017.SmartGrids.CIM.IEC61970.Informative.InfCommon
{
    
    
    public class DCPolarityKindConverter : System.ComponentModel.TypeConverter
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
                return default(DCPolarityKind);
            }
            string valueString = value.ToString();
            if ((valueString == "plusN"))
            {
                return DCPolarityKind.PlusN;
            }
            if ((valueString == "minus"))
            {
                return DCPolarityKind.Minus;
            }
            if ((valueString == "plus"))
            {
                return DCPolarityKind.Plus;
            }
            if ((valueString == "minusN"))
            {
                return DCPolarityKind.MinusN;
            }
            if ((valueString == "plusMinus"))
            {
                return DCPolarityKind.PlusMinus;
            }
            return default(DCPolarityKind);
        }
        
        public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType)
        {
            if ((value == null))
            {
                return null;
            }
            DCPolarityKind valueCasted = ((DCPolarityKind)(value));
            if ((valueCasted == DCPolarityKind.PlusN))
            {
                return "plusN";
            }
            if ((valueCasted == DCPolarityKind.Minus))
            {
                return "minus";
            }
            if ((valueCasted == DCPolarityKind.Plus))
            {
                return "plus";
            }
            if ((valueCasted == DCPolarityKind.MinusN))
            {
                return "minusN";
            }
            if ((valueCasted == DCPolarityKind.PlusMinus))
            {
                return "plusMinus";
            }
            throw new ArgumentOutOfRangeException("value");
        }
    }
}

