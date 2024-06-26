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
    /// The public interface for AuxiliaryAccount
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(AuxiliaryAccount))]
    [XmlDefaultImplementationTypeAttribute(typeof(AuxiliaryAccount))]
    public interface IAuxiliaryAccount : IModelElement, IDocument
    {
        
        /// <summary>
        /// The principleAmount property
        /// </summary>
        float PrincipleAmount
        {
            get;
            set;
        }
        
        /// <summary>
        /// The balance property
        /// </summary>
        float Balance
        {
            get;
            set;
        }
        
        /// <summary>
        /// The PaymentTransactions property
        /// </summary>
        IOrderedSetExpression<ITransaction> PaymentTransactions
        {
            get;
        }
        
        /// <summary>
        /// The due property
        /// </summary>
        IDue Due
        {
            get;
            set;
        }
        
        /// <summary>
        /// The lastCredit property
        /// </summary>
        IAccountMovement LastCredit
        {
            get;
            set;
        }
        
        /// <summary>
        /// The AuxiliaryAgreement property
        /// </summary>
        IAuxiliaryAgreement AuxiliaryAgreement
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Charges property
        /// </summary>
        IOrderedSetExpression<ICharge> Charges
        {
            get;
        }
        
        /// <summary>
        /// The lastDebit property
        /// </summary>
        IAccountMovement LastDebit
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the PrincipleAmount property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PrincipleAmountChanging;
        
        /// <summary>
        /// Gets fired when the PrincipleAmount property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PrincipleAmountChanged;
        
        /// <summary>
        /// Gets fired before the Balance property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> BalanceChanging;
        
        /// <summary>
        /// Gets fired when the Balance property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> BalanceChanged;
        
        /// <summary>
        /// Gets fired before the Due property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DueChanging;
        
        /// <summary>
        /// Gets fired when the Due property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DueChanged;
        
        /// <summary>
        /// Gets fired before the LastCredit property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LastCreditChanging;
        
        /// <summary>
        /// Gets fired when the LastCredit property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LastCreditChanged;
        
        /// <summary>
        /// Gets fired before the AuxiliaryAgreement property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AuxiliaryAgreementChanging;
        
        /// <summary>
        /// Gets fired when the AuxiliaryAgreement property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AuxiliaryAgreementChanged;
        
        /// <summary>
        /// Gets fired before the LastDebit property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LastDebitChanging;
        
        /// <summary>
        /// Gets fired when the LastDebit property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LastDebitChanged;
    }
}

