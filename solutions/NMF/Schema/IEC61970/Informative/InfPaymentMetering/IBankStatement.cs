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
    /// The public interface for BankStatement
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(BankStatement))]
    [XmlDefaultImplementationTypeAttribute(typeof(BankStatement))]
    public interface IBankStatement : IModelElement, IDocument
    {
        
        /// <summary>
        /// The merchantCreditAmount property
        /// </summary>
        float MerchantCreditAmount
        {
            get;
            set;
        }
        
        /// <summary>
        /// The depositAmount property
        /// </summary>
        float DepositAmount
        {
            get;
            set;
        }
        
        /// <summary>
        /// The depositDateTime property
        /// </summary>
        DateTime DepositDateTime
        {
            get;
            set;
        }
        
        /// <summary>
        /// The posted property
        /// </summary>
        bool Posted
        {
            get;
            set;
        }
        
        /// <summary>
        /// The BankAccount property
        /// </summary>
        IBankAccount BankAccount
        {
            get;
            set;
        }
        
        /// <summary>
        /// The MerchantAccount property
        /// </summary>
        IMerchantAccount MerchantAccount
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Vendor property
        /// </summary>
        IVendor Vendor
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the MerchantCreditAmount property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> MerchantCreditAmountChanging;
        
        /// <summary>
        /// Gets fired when the MerchantCreditAmount property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> MerchantCreditAmountChanged;
        
        /// <summary>
        /// Gets fired before the DepositAmount property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DepositAmountChanging;
        
        /// <summary>
        /// Gets fired when the DepositAmount property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DepositAmountChanged;
        
        /// <summary>
        /// Gets fired before the DepositDateTime property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DepositDateTimeChanging;
        
        /// <summary>
        /// Gets fired when the DepositDateTime property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DepositDateTimeChanged;
        
        /// <summary>
        /// Gets fired before the Posted property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PostedChanging;
        
        /// <summary>
        /// Gets fired when the Posted property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PostedChanged;
        
        /// <summary>
        /// Gets fired before the BankAccount property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> BankAccountChanging;
        
        /// <summary>
        /// Gets fired when the BankAccount property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> BankAccountChanged;
        
        /// <summary>
        /// Gets fired before the MerchantAccount property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> MerchantAccountChanging;
        
        /// <summary>
        /// Gets fired when the MerchantAccount property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> MerchantAccountChanged;
        
        /// <summary>
        /// Gets fired before the Vendor property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> VendorChanging;
        
        /// <summary>
        /// Gets fired when the Vendor property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> VendorChanged;
    }
}

