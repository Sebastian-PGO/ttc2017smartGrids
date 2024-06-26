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
    
    
    public class MarketRoleKindConverter : System.ComponentModel.TypeConverter
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
                return default(MarketRoleKind);
            }
            string valueString = value.ToString();
            if ((valueString == "competitiveRetailer"))
            {
                return MarketRoleKind.CompetitiveRetailer;
            }
            if ((valueString == "standardsDeveloper"))
            {
                return MarketRoleKind.StandardsDeveloper;
            }
            if ((valueString == "other"))
            {
                return MarketRoleKind.Other;
            }
            if ((valueString == "resourcePlanner"))
            {
                return MarketRoleKind.ResourcePlanner;
            }
            if ((valueString == "interchangeAuthority"))
            {
                return MarketRoleKind.InterchangeAuthority;
            }
            if ((valueString == "transmissionServiceProvider"))
            {
                return MarketRoleKind.TransmissionServiceProvider;
            }
            if ((valueString == "purchasingSellingEntity"))
            {
                return MarketRoleKind.PurchasingSellingEntity;
            }
            if ((valueString == "balancingAuthority"))
            {
                return MarketRoleKind.BalancingAuthority;
            }
            if ((valueString == "energyServiceConsumer"))
            {
                return MarketRoleKind.EnergyServiceConsumer;
            }
            if ((valueString == "loadServingEntity"))
            {
                return MarketRoleKind.LoadServingEntity;
            }
            if ((valueString == "distributionProvider"))
            {
                return MarketRoleKind.DistributionProvider;
            }
            if ((valueString == "transmissionPlanner"))
            {
                return MarketRoleKind.TransmissionPlanner;
            }
            if ((valueString == "reliabilityAuthority"))
            {
                return MarketRoleKind.ReliabilityAuthority;
            }
            if ((valueString == "transmissionOwner"))
            {
                return MarketRoleKind.TransmissionOwner;
            }
            if ((valueString == "generatorOwner"))
            {
                return MarketRoleKind.GeneratorOwner;
            }
            if ((valueString == "planningAuthority"))
            {
                return MarketRoleKind.PlanningAuthority;
            }
            if ((valueString == "generatorOperator"))
            {
                return MarketRoleKind.GeneratorOperator;
            }
            if ((valueString == "complianceMonitor"))
            {
                return MarketRoleKind.ComplianceMonitor;
            }
            if ((valueString == "transmissionOperator"))
            {
                return MarketRoleKind.TransmissionOperator;
            }
            return default(MarketRoleKind);
        }
        
        public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType)
        {
            if ((value == null))
            {
                return null;
            }
            MarketRoleKind valueCasted = ((MarketRoleKind)(value));
            if ((valueCasted == MarketRoleKind.CompetitiveRetailer))
            {
                return "competitiveRetailer";
            }
            if ((valueCasted == MarketRoleKind.StandardsDeveloper))
            {
                return "standardsDeveloper";
            }
            if ((valueCasted == MarketRoleKind.Other))
            {
                return "other";
            }
            if ((valueCasted == MarketRoleKind.ResourcePlanner))
            {
                return "resourcePlanner";
            }
            if ((valueCasted == MarketRoleKind.InterchangeAuthority))
            {
                return "interchangeAuthority";
            }
            if ((valueCasted == MarketRoleKind.TransmissionServiceProvider))
            {
                return "transmissionServiceProvider";
            }
            if ((valueCasted == MarketRoleKind.PurchasingSellingEntity))
            {
                return "purchasingSellingEntity";
            }
            if ((valueCasted == MarketRoleKind.BalancingAuthority))
            {
                return "balancingAuthority";
            }
            if ((valueCasted == MarketRoleKind.EnergyServiceConsumer))
            {
                return "energyServiceConsumer";
            }
            if ((valueCasted == MarketRoleKind.LoadServingEntity))
            {
                return "loadServingEntity";
            }
            if ((valueCasted == MarketRoleKind.DistributionProvider))
            {
                return "distributionProvider";
            }
            if ((valueCasted == MarketRoleKind.TransmissionPlanner))
            {
                return "transmissionPlanner";
            }
            if ((valueCasted == MarketRoleKind.ReliabilityAuthority))
            {
                return "reliabilityAuthority";
            }
            if ((valueCasted == MarketRoleKind.TransmissionOwner))
            {
                return "transmissionOwner";
            }
            if ((valueCasted == MarketRoleKind.GeneratorOwner))
            {
                return "generatorOwner";
            }
            if ((valueCasted == MarketRoleKind.PlanningAuthority))
            {
                return "planningAuthority";
            }
            if ((valueCasted == MarketRoleKind.GeneratorOperator))
            {
                return "generatorOperator";
            }
            if ((valueCasted == MarketRoleKind.ComplianceMonitor))
            {
                return "complianceMonitor";
            }
            if ((valueCasted == MarketRoleKind.TransmissionOperator))
            {
                return "transmissionOperator";
            }
            throw new ArgumentOutOfRangeException("value");
        }
    }
}

