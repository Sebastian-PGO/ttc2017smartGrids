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
using TTC2017.SmartGrids.CIM.IEC61968.Common;
using TTC2017.SmartGrids.CIM.IEC61968.Customers;
using TTC2017.SmartGrids.CIM.IEC61968.Metering;
using TTC2017.SmartGrids.CIM.IEC61968.Work;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfERPSupport;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfOperations;

namespace TTC2017.SmartGrids.CIM.IEC61970.Informative.InfCustomers
{
    
    
    /// <summary>
    /// The public interface for WorkBillingInfo
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(WorkBillingInfo))]
    [XmlDefaultImplementationTypeAttribute(typeof(WorkBillingInfo))]
    public interface IWorkBillingInfo : IModelElement, IDocument
    {
        
        /// <summary>
        /// The receivedDateTime property
        /// </summary>
        DateTime ReceivedDateTime
        {
            get;
            set;
        }
        
        /// <summary>
        /// The discount property
        /// </summary>
        float Discount
        {
            get;
            set;
        }
        
        /// <summary>
        /// The issueDateTime property
        /// </summary>
        DateTime IssueDateTime
        {
            get;
            set;
        }
        
        /// <summary>
        /// The dueDateTime property
        /// </summary>
        DateTime DueDateTime
        {
            get;
            set;
        }
        
        /// <summary>
        /// The deposit property
        /// </summary>
        float Deposit
        {
            get;
            set;
        }
        
        /// <summary>
        /// The workPrice property
        /// </summary>
        float WorkPrice
        {
            get;
            set;
        }
        
        /// <summary>
        /// The costEstimate property
        /// </summary>
        float CostEstimate
        {
            get;
            set;
        }
        
        /// <summary>
        /// The CustomerAccount property
        /// </summary>
        ICustomerAccount CustomerAccount
        {
            get;
            set;
        }
        
        /// <summary>
        /// The ErpLineItems property
        /// </summary>
        IOrderedSetExpression<IErpInvoiceLineItem> ErpLineItems
        {
            get;
        }
        
        /// <summary>
        /// The Works property
        /// </summary>
        IOrderedSetExpression<IWork> Works
        {
            get;
        }
        
        /// <summary>
        /// Gets fired before the ReceivedDateTime property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ReceivedDateTimeChanging;
        
        /// <summary>
        /// Gets fired when the ReceivedDateTime property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ReceivedDateTimeChanged;
        
        /// <summary>
        /// Gets fired before the Discount property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DiscountChanging;
        
        /// <summary>
        /// Gets fired when the Discount property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DiscountChanged;
        
        /// <summary>
        /// Gets fired before the IssueDateTime property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> IssueDateTimeChanging;
        
        /// <summary>
        /// Gets fired when the IssueDateTime property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> IssueDateTimeChanged;
        
        /// <summary>
        /// Gets fired before the DueDateTime property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DueDateTimeChanging;
        
        /// <summary>
        /// Gets fired when the DueDateTime property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DueDateTimeChanged;
        
        /// <summary>
        /// Gets fired before the Deposit property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DepositChanging;
        
        /// <summary>
        /// Gets fired when the Deposit property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DepositChanged;
        
        /// <summary>
        /// Gets fired before the WorkPrice property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> WorkPriceChanging;
        
        /// <summary>
        /// Gets fired when the WorkPrice property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> WorkPriceChanged;
        
        /// <summary>
        /// Gets fired before the CostEstimate property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CostEstimateChanging;
        
        /// <summary>
        /// Gets fired when the CostEstimate property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CostEstimateChanged;
        
        /// <summary>
        /// Gets fired before the CustomerAccount property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CustomerAccountChanging;
        
        /// <summary>
        /// Gets fired when the CustomerAccount property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CustomerAccountChanged;
    }
}

