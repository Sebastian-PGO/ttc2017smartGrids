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
    /// The public interface for OutageRecord
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(OutageRecord))]
    [XmlDefaultImplementationTypeAttribute(typeof(OutageRecord))]
    public interface IOutageRecord : IModelElement, IDocument
    {
        
        /// <summary>
        /// The mode property
        /// </summary>
        string Mode
        {
            get;
            set;
        }
        
        /// <summary>
        /// The actionTaken property
        /// </summary>
        string ActionTaken
        {
            get;
            set;
        }
        
        /// <summary>
        /// The endDateTime property
        /// </summary>
        DateTime EndDateTime
        {
            get;
            set;
        }
        
        /// <summary>
        /// The damageCode property
        /// </summary>
        string DamageCode
        {
            get;
            set;
        }
        
        /// <summary>
        /// The isPlanned property
        /// </summary>
        bool IsPlanned
        {
            get;
            set;
        }
        
        /// <summary>
        /// The OutageReport property
        /// </summary>
        IOutageReport OutageReport
        {
            get;
            set;
        }
        
        /// <summary>
        /// The OutageSteps property
        /// </summary>
        IOrderedSetExpression<IOutageStep> OutageSteps
        {
            get;
        }
        
        /// <summary>
        /// The OutageCodes property
        /// </summary>
        IOrderedSetExpression<IOutageCode> OutageCodes
        {
            get;
        }
        
        /// <summary>
        /// Gets fired before the Mode property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ModeChanging;
        
        /// <summary>
        /// Gets fired when the Mode property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ModeChanged;
        
        /// <summary>
        /// Gets fired before the ActionTaken property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ActionTakenChanging;
        
        /// <summary>
        /// Gets fired when the ActionTaken property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ActionTakenChanged;
        
        /// <summary>
        /// Gets fired before the EndDateTime property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> EndDateTimeChanging;
        
        /// <summary>
        /// Gets fired when the EndDateTime property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> EndDateTimeChanged;
        
        /// <summary>
        /// Gets fired before the DamageCode property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DamageCodeChanging;
        
        /// <summary>
        /// Gets fired when the DamageCode property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DamageCodeChanged;
        
        /// <summary>
        /// Gets fired before the IsPlanned property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> IsPlannedChanging;
        
        /// <summary>
        /// Gets fired when the IsPlanned property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> IsPlannedChanged;
        
        /// <summary>
        /// Gets fired before the OutageReport property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> OutageReportChanging;
        
        /// <summary>
        /// Gets fired when the OutageReport property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> OutageReportChanged;
    }
}

