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
using TTC2017.SmartGrids.CIM.IEC61968.PaymentMetering;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfCommon;

namespace TTC2017.SmartGrids.CIM.IEC61970.Informative.InfPaymentMetering
{
    
    
    /// <summary>
    /// The public interface for SDPAccountingFunction
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(SDPAccountingFunction))]
    [XmlDefaultImplementationTypeAttribute(typeof(SDPAccountingFunction))]
    public interface ISDPAccountingFunction : IModelElement, IDeviceFunction
    {
        
        /// <summary>
        /// The availableCredit property
        /// </summary>
        IAccountingUnit AvailableCredit
        {
            get;
            set;
        }
        
        /// <summary>
        /// The CreditRegisters property
        /// </summary>
        IOrderedSetExpression<ICreditRegister> CreditRegisters
        {
            get;
        }
        
        /// <summary>
        /// The ChargeRegisters property
        /// </summary>
        IOrderedSetExpression<IChargeRegister> ChargeRegisters
        {
            get;
        }
        
        /// <summary>
        /// The lowCreditWarningLevel property
        /// </summary>
        IAccountingUnit LowCreditWarningLevel
        {
            get;
            set;
        }
        
        /// <summary>
        /// The creditExpiryLevel property
        /// </summary>
        IAccountingUnit CreditExpiryLevel
        {
            get;
            set;
        }
        
        /// <summary>
        /// The ServiceKind property
        /// </summary>
        IServiceCategory ServiceKind
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the AvailableCredit property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AvailableCreditChanging;
        
        /// <summary>
        /// Gets fired when the AvailableCredit property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AvailableCreditChanged;
        
        /// <summary>
        /// Gets fired before the LowCreditWarningLevel property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LowCreditWarningLevelChanging;
        
        /// <summary>
        /// Gets fired when the LowCreditWarningLevel property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LowCreditWarningLevelChanged;
        
        /// <summary>
        /// Gets fired before the CreditExpiryLevel property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CreditExpiryLevelChanging;
        
        /// <summary>
        /// Gets fired when the CreditExpiryLevel property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CreditExpiryLevelChanged;
        
        /// <summary>
        /// Gets fired before the ServiceKind property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ServiceKindChanging;
        
        /// <summary>
        /// Gets fired when the ServiceKind property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ServiceKindChanged;
    }
}

