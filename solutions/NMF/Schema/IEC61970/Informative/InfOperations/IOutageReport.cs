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
using TTC2017.SmartGrids.CIM.IEC61968.Assets;
using TTC2017.SmartGrids.CIM.IEC61968.Common;
using TTC2017.SmartGrids.CIM.IEC61968.Customers;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssets;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfCommon;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfCustomers;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfERPSupport;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfGMLSupport;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfWork;
using TTC2017.SmartGrids.CIM.IEC61970.Outage;

namespace TTC2017.SmartGrids.CIM.IEC61970.Informative.InfOperations
{
    
    
    /// <summary>
    /// The public interface for OutageReport
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(OutageReport))]
    [XmlDefaultImplementationTypeAttribute(typeof(OutageReport))]
    public interface IOutageReport : IModelElement, IDocument
    {
        
        /// <summary>
        /// The customerCount property
        /// </summary>
        int CustomerCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// The outageDuration property
        /// </summary>
        float OutageDuration
        {
            get;
            set;
        }
        
        /// <summary>
        /// The averageCml property
        /// </summary>
        float AverageCml
        {
            get;
            set;
        }
        
        /// <summary>
        /// The totalCml property
        /// </summary>
        float TotalCml
        {
            get;
            set;
        }
        
        /// <summary>
        /// The OutageRecord property
        /// </summary>
        IOutageRecord OutageRecord
        {
            get;
            set;
        }
        
        /// <summary>
        /// The OutageHistory property
        /// </summary>
        IOutageHistory OutageHistory
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the CustomerCount property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CustomerCountChanging;
        
        /// <summary>
        /// Gets fired when the CustomerCount property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CustomerCountChanged;
        
        /// <summary>
        /// Gets fired before the OutageDuration property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> OutageDurationChanging;
        
        /// <summary>
        /// Gets fired when the OutageDuration property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> OutageDurationChanged;
        
        /// <summary>
        /// Gets fired before the AverageCml property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AverageCmlChanging;
        
        /// <summary>
        /// Gets fired when the AverageCml property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AverageCmlChanged;
        
        /// <summary>
        /// Gets fired before the TotalCml property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TotalCmlChanging;
        
        /// <summary>
        /// Gets fired when the TotalCml property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TotalCmlChanged;
        
        /// <summary>
        /// Gets fired before the OutageRecord property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> OutageRecordChanging;
        
        /// <summary>
        /// Gets fired when the OutageRecord property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> OutageRecordChanged;
        
        /// <summary>
        /// Gets fired before the OutageHistory property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> OutageHistoryChanging;
        
        /// <summary>
        /// Gets fired when the OutageHistory property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> OutageHistoryChanged;
    }
}
