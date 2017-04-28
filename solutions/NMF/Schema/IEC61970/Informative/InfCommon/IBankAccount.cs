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
    
    
    /// <summary>
    /// The public interface for BankAccount
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(BankAccount))]
    [XmlDefaultImplementationTypeAttribute(typeof(BankAccount))]
    public interface IBankAccount : IModelElement, IDocument
    {
        
        /// <summary>
        /// The accountNumber property
        /// </summary>
        string AccountNumber
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Bank property
        /// </summary>
        IBank Bank
        {
            get;
            set;
        }
        
        /// <summary>
        /// The ServiceSupplier property
        /// </summary>
        IServiceSupplier ServiceSupplier
        {
            get;
            set;
        }
        
        /// <summary>
        /// The BankStatements property
        /// </summary>
        IOrderedSetExpression<IBankStatement> BankStatements
        {
            get;
        }
        
        /// <summary>
        /// Gets fired before the AccountNumber property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AccountNumberChanging;
        
        /// <summary>
        /// Gets fired when the AccountNumber property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AccountNumberChanged;
        
        /// <summary>
        /// Gets fired before the Bank property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> BankChanging;
        
        /// <summary>
        /// Gets fired when the Bank property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> BankChanged;
        
        /// <summary>
        /// Gets fired before the ServiceSupplier property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ServiceSupplierChanging;
        
        /// <summary>
        /// Gets fired when the ServiceSupplier property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ServiceSupplierChanged;
    }
}

