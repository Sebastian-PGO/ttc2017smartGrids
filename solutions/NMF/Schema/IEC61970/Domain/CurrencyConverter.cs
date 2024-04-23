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

namespace TTC2017.SmartGrids.CIM.IEC61970.Domain
{
    
    
    public class CurrencyConverter : System.ComponentModel.TypeConverter
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
                return default(TTC2017.SmartGrids.CIM.IEC61970.Domain.Currency);
            }
            string valueString = value.ToString();
            if ((valueString == "GBP"))
            {
                return TTC2017.SmartGrids.CIM.IEC61970.Domain.Currency.GBP;
            }
            if ((valueString == "CNY"))
            {
                return TTC2017.SmartGrids.CIM.IEC61970.Domain.Currency.CNY;
            }
            if ((valueString == "SEK"))
            {
                return TTC2017.SmartGrids.CIM.IEC61970.Domain.Currency.SEK;
            }
            if ((valueString == "NOK"))
            {
                return TTC2017.SmartGrids.CIM.IEC61970.Domain.Currency.NOK;
            }
            if ((valueString == "AUD"))
            {
                return TTC2017.SmartGrids.CIM.IEC61970.Domain.Currency.AUD;
            }
            if ((valueString == "JPY"))
            {
                return TTC2017.SmartGrids.CIM.IEC61970.Domain.Currency.JPY;
            }
            if ((valueString == "RUR"))
            {
                return TTC2017.SmartGrids.CIM.IEC61970.Domain.Currency.RUR;
            }
            if ((valueString == "EUR"))
            {
                return TTC2017.SmartGrids.CIM.IEC61970.Domain.Currency.EUR;
            }
            if ((valueString == "other"))
            {
                return TTC2017.SmartGrids.CIM.IEC61970.Domain.Currency.Other;
            }
            if ((valueString == "CAD"))
            {
                return TTC2017.SmartGrids.CIM.IEC61970.Domain.Currency.CAD;
            }
            if ((valueString == "INR"))
            {
                return TTC2017.SmartGrids.CIM.IEC61970.Domain.Currency.INR;
            }
            if ((valueString == "CHF"))
            {
                return TTC2017.SmartGrids.CIM.IEC61970.Domain.Currency.CHF;
            }
            if ((valueString == "USD"))
            {
                return TTC2017.SmartGrids.CIM.IEC61970.Domain.Currency.USD;
            }
            if ((valueString == "DKK"))
            {
                return TTC2017.SmartGrids.CIM.IEC61970.Domain.Currency.DKK;
            }
            return default(TTC2017.SmartGrids.CIM.IEC61970.Domain.Currency);
        }
        
        public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType)
        {
            if ((value == null))
            {
                return null;
            }
            TTC2017.SmartGrids.CIM.IEC61970.Domain.Currency valueCasted = ((TTC2017.SmartGrids.CIM.IEC61970.Domain.Currency)(value));
            if ((valueCasted == TTC2017.SmartGrids.CIM.IEC61970.Domain.Currency.GBP))
            {
                return "GBP";
            }
            if ((valueCasted == TTC2017.SmartGrids.CIM.IEC61970.Domain.Currency.CNY))
            {
                return "CNY";
            }
            if ((valueCasted == TTC2017.SmartGrids.CIM.IEC61970.Domain.Currency.SEK))
            {
                return "SEK";
            }
            if ((valueCasted == TTC2017.SmartGrids.CIM.IEC61970.Domain.Currency.NOK))
            {
                return "NOK";
            }
            if ((valueCasted == TTC2017.SmartGrids.CIM.IEC61970.Domain.Currency.AUD))
            {
                return "AUD";
            }
            if ((valueCasted == TTC2017.SmartGrids.CIM.IEC61970.Domain.Currency.JPY))
            {
                return "JPY";
            }
            if ((valueCasted == TTC2017.SmartGrids.CIM.IEC61970.Domain.Currency.RUR))
            {
                return "RUR";
            }
            if ((valueCasted == TTC2017.SmartGrids.CIM.IEC61970.Domain.Currency.EUR))
            {
                return "EUR";
            }
            if ((valueCasted == TTC2017.SmartGrids.CIM.IEC61970.Domain.Currency.Other))
            {
                return "other";
            }
            if ((valueCasted == TTC2017.SmartGrids.CIM.IEC61970.Domain.Currency.CAD))
            {
                return "CAD";
            }
            if ((valueCasted == TTC2017.SmartGrids.CIM.IEC61970.Domain.Currency.INR))
            {
                return "INR";
            }
            if ((valueCasted == TTC2017.SmartGrids.CIM.IEC61970.Domain.Currency.CHF))
            {
                return "CHF";
            }
            if ((valueCasted == TTC2017.SmartGrids.CIM.IEC61970.Domain.Currency.USD))
            {
                return "USD";
            }
            if ((valueCasted == TTC2017.SmartGrids.CIM.IEC61970.Domain.Currency.DKK))
            {
                return "DKK";
            }
            throw new ArgumentOutOfRangeException("value");
        }
    }
}

