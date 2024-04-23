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
using TTC2017.SmartGrids.CIM.IEC61968.Common;
using TTC2017.SmartGrids.CIM.IEC61968.Customers;
using TTC2017.SmartGrids.CIM.IEC61968.Metering;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Domain;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfCommon;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfPaymentMetering;

namespace TTC2017.SmartGrids.CIM.IEC61968.PaymentMetering
{
    
    
    public class TenderKindConverter : System.ComponentModel.TypeConverter
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
                return default(TenderKind);
            }
            string valueString = value.ToString();
            if ((valueString == "cash"))
            {
                return TenderKind.Cash;
            }
            if ((valueString == "unspecified"))
            {
                return TenderKind.Unspecified;
            }
            if ((valueString == "other"))
            {
                return TenderKind.Other;
            }
            if ((valueString == "card"))
            {
                return TenderKind.Card;
            }
            if ((valueString == "cheque"))
            {
                return TenderKind.Cheque;
            }
            return default(TenderKind);
        }
        
        public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType)
        {
            if ((value == null))
            {
                return null;
            }
            TenderKind valueCasted = ((TenderKind)(value));
            if ((valueCasted == TenderKind.Cash))
            {
                return "cash";
            }
            if ((valueCasted == TenderKind.Unspecified))
            {
                return "unspecified";
            }
            if ((valueCasted == TenderKind.Other))
            {
                return "other";
            }
            if ((valueCasted == TenderKind.Card))
            {
                return "card";
            }
            if ((valueCasted == TenderKind.Cheque))
            {
                return "cheque";
            }
            throw new ArgumentOutOfRangeException("value");
        }
    }
}

