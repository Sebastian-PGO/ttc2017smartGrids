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
using TTC2017.SmartGrids.CIM.IEC61970.Contingency;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Generation.Production;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.EnergyScheduling;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.Financial;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfERPSupport;
using TTC2017.SmartGrids.CIM.IEC61970.LoadModel;
using TTC2017.SmartGrids.CIM.IEC61970.Meas;
using TTC2017.SmartGrids.CIM.IEC61970.Wires;

namespace TTC2017.SmartGrids.CIM.IEC61970.Informative.MarketOperations
{
    
    
    /// <summary>
    /// The public interface for MarketFactors
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(MarketFactors))]
    [XmlDefaultImplementationTypeAttribute(typeof(MarketFactors))]
    public interface IMarketFactors : IModelElement, IDocument
    {
        
        /// <summary>
        /// The intervalStartTime property
        /// </summary>
        DateTime IntervalStartTime
        {
            get;
            set;
        }
        
        /// <summary>
        /// The ErpInvoices property
        /// </summary>
        IOrderedSetExpression<IErpInvoiceLineItem> ErpInvoices
        {
            get;
        }
        
        /// <summary>
        /// The Market property
        /// </summary>
        IMarket Market
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the IntervalStartTime property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> IntervalStartTimeChanging;
        
        /// <summary>
        /// Gets fired when the IntervalStartTime property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> IntervalStartTimeChanged;
        
        /// <summary>
        /// Gets fired before the Market property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> MarketChanging;
        
        /// <summary>
        /// Gets fired when the Market property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> MarketChanged;
    }
}

