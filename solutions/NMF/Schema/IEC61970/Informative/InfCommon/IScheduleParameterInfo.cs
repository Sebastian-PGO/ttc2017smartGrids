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
    
    
    /// <summary>
    /// The public interface for ScheduleParameterInfo
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(ScheduleParameterInfo))]
    [XmlDefaultImplementationTypeAttribute(typeof(ScheduleParameterInfo))]
    public interface IScheduleParameterInfo : IModelElement, IIdentifiedObject
    {
        
        /// <summary>
        /// The ScheduledEvents property
        /// </summary>
        IOrderedSetExpression<IScheduledEvent> ScheduledEvents
        {
            get;
        }
        
        /// <summary>
        /// The requestedWindow property
        /// </summary>
        IDateTimeInterval RequestedWindow
        {
            get;
            set;
        }
        
        /// <summary>
        /// The ForInspectionDataSet property
        /// </summary>
        IInspectionDataSet ForInspectionDataSet
        {
            get;
            set;
        }
        
        /// <summary>
        /// The estimatedWindow property
        /// </summary>
        IDateTimeInterval EstimatedWindow
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Documents property
        /// </summary>
        IOrderedSetExpression<IDocument> Documents
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
        /// Gets fired before the RequestedWindow property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> RequestedWindowChanging;
        
        /// <summary>
        /// Gets fired when the RequestedWindow property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> RequestedWindowChanged;
        
        /// <summary>
        /// Gets fired before the ForInspectionDataSet property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ForInspectionDataSetChanging;
        
        /// <summary>
        /// Gets fired when the ForInspectionDataSet property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ForInspectionDataSetChanged;
        
        /// <summary>
        /// Gets fired before the EstimatedWindow property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> EstimatedWindowChanging;
        
        /// <summary>
        /// Gets fired when the EstimatedWindow property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> EstimatedWindowChanged;
        
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

