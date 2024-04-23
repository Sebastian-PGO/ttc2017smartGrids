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
using TTC2017.SmartGrids.CIM.IEC61968.AssetModels;
using TTC2017.SmartGrids.CIM.IEC61968.Assets;
using TTC2017.SmartGrids.CIM.IEC61968.Common;
using TTC2017.SmartGrids.CIM.IEC61968.Customers;
using TTC2017.SmartGrids.CIM.IEC61968.Work;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.Financial;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssetModels;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssets;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfCommon;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfCustomers;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfLocations;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfOperations;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfTypeAsset;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfWork;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.MarketOperations;
using TTC2017.SmartGrids.CIM.IEC61970.Meas;

namespace TTC2017.SmartGrids.CIM.IEC61970.Informative.InfERPSupport
{
    
    
    /// <summary>
    /// The public interface for ErpPayableLineItem
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(ErpPayableLineItem))]
    [XmlDefaultImplementationTypeAttribute(typeof(ErpPayableLineItem))]
    public interface IErpPayableLineItem : IModelElement, IIdentifiedObject
    {
        
        /// <summary>
        /// The ErpInvoiceLineItem property
        /// </summary>
        IErpInvoiceLineItem ErpInvoiceLineItem
        {
            get;
            set;
        }
        
        /// <summary>
        /// The ErpPayments property
        /// </summary>
        IOrderedSetExpression<IErpPayment> ErpPayments
        {
            get;
        }
        
        /// <summary>
        /// The ErpPayable property
        /// </summary>
        IErpPayable ErpPayable
        {
            get;
            set;
        }
        
        /// <summary>
        /// The ErpJournalEntries property
        /// </summary>
        IOrderedSetExpression<IErpJournalEntry> ErpJournalEntries
        {
            get;
        }
        
        /// <summary>
        /// The status property
        /// </summary>
        IStatus Status
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the ErpInvoiceLineItem property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ErpInvoiceLineItemChanging;
        
        /// <summary>
        /// Gets fired when the ErpInvoiceLineItem property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ErpInvoiceLineItemChanged;
        
        /// <summary>
        /// Gets fired before the ErpPayable property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ErpPayableChanging;
        
        /// <summary>
        /// Gets fired when the ErpPayable property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ErpPayableChanged;
        
        /// <summary>
        /// Gets fired before the Status property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> StatusChanging;
        
        /// <summary>
        /// Gets fired when the Status property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> StatusChanged;
    }
}

