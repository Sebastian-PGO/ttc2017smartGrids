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
    
    
    /// <summary>
    /// The public interface for AuxiliaryAgreement
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(AuxiliaryAgreement))]
    [XmlDefaultImplementationTypeAttribute(typeof(AuxiliaryAgreement))]
    public interface IAuxiliaryAgreement : IModelElement, IAgreement
    {
        
        /// <summary>
        /// The auxCycle property
        /// </summary>
        string AuxCycle
        {
            get;
            set;
        }
        
        /// <summary>
        /// The auxRef property
        /// </summary>
        string AuxRef
        {
            get;
            set;
        }
        
        /// <summary>
        /// The subCategory property
        /// </summary>
        string SubCategory
        {
            get;
            set;
        }
        
        /// <summary>
        /// The minAmount property
        /// </summary>
        float MinAmount
        {
            get;
            set;
        }
        
        /// <summary>
        /// The vendPortion property
        /// </summary>
        float VendPortion
        {
            get;
            set;
        }
        
        /// <summary>
        /// The auxPriorityCode property
        /// </summary>
        string AuxPriorityCode
        {
            get;
            set;
        }
        
        /// <summary>
        /// The arrearsInterest property
        /// </summary>
        float ArrearsInterest
        {
            get;
            set;
        }
        
        /// <summary>
        /// The fixedAmount property
        /// </summary>
        float FixedAmount
        {
            get;
            set;
        }
        
        /// <summary>
        /// The payCycle property
        /// </summary>
        string PayCycle
        {
            get;
            set;
        }
        
        /// <summary>
        /// The vendPortionArrear property
        /// </summary>
        float VendPortionArrear
        {
            get;
            set;
        }
        
        /// <summary>
        /// The CustomerAgreement property
        /// </summary>
        ICustomerAgreement CustomerAgreement
        {
            get;
            set;
        }
        
        /// <summary>
        /// The AuxiliaryAccounts property
        /// </summary>
        IOrderedSetExpression<IAuxiliaryAccount> AuxiliaryAccounts
        {
            get;
        }
        
        /// <summary>
        /// Gets fired before the AuxCycle property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AuxCycleChanging;
        
        /// <summary>
        /// Gets fired when the AuxCycle property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AuxCycleChanged;
        
        /// <summary>
        /// Gets fired before the AuxRef property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AuxRefChanging;
        
        /// <summary>
        /// Gets fired when the AuxRef property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AuxRefChanged;
        
        /// <summary>
        /// Gets fired before the SubCategory property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> SubCategoryChanging;
        
        /// <summary>
        /// Gets fired when the SubCategory property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> SubCategoryChanged;
        
        /// <summary>
        /// Gets fired before the MinAmount property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> MinAmountChanging;
        
        /// <summary>
        /// Gets fired when the MinAmount property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> MinAmountChanged;
        
        /// <summary>
        /// Gets fired before the VendPortion property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> VendPortionChanging;
        
        /// <summary>
        /// Gets fired when the VendPortion property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> VendPortionChanged;
        
        /// <summary>
        /// Gets fired before the AuxPriorityCode property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AuxPriorityCodeChanging;
        
        /// <summary>
        /// Gets fired when the AuxPriorityCode property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AuxPriorityCodeChanged;
        
        /// <summary>
        /// Gets fired before the ArrearsInterest property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ArrearsInterestChanging;
        
        /// <summary>
        /// Gets fired when the ArrearsInterest property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ArrearsInterestChanged;
        
        /// <summary>
        /// Gets fired before the FixedAmount property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FixedAmountChanging;
        
        /// <summary>
        /// Gets fired when the FixedAmount property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FixedAmountChanged;
        
        /// <summary>
        /// Gets fired before the PayCycle property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PayCycleChanging;
        
        /// <summary>
        /// Gets fired when the PayCycle property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PayCycleChanged;
        
        /// <summary>
        /// Gets fired before the VendPortionArrear property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> VendPortionArrearChanging;
        
        /// <summary>
        /// Gets fired when the VendPortionArrear property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> VendPortionArrearChanged;
        
        /// <summary>
        /// Gets fired before the CustomerAgreement property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CustomerAgreementChanging;
        
        /// <summary>
        /// Gets fired when the CustomerAgreement property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CustomerAgreementChanged;
    }
}

