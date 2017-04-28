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
using TTC2017.SmartGrids.CIM.IEC61968.PaymentMetering;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssets;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfCommon;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfERPSupport;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfGMLSupport;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfLocations;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfOperations;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfWork;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.MarketOperations;
using TTC2017.SmartGrids.CIM.IEC61970.Meas;

namespace TTC2017.SmartGrids.CIM.IEC61968.Common
{
    
    
    /// <summary>
    /// The public interface for TimePoint
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(TimePoint))]
    [XmlDefaultImplementationTypeAttribute(typeof(TimePoint))]
    public interface ITimePoint : IModelElement, IIdentifiedObject
    {
        
        /// <summary>
        /// The sequenceNumber property
        /// </summary>
        int SequenceNumber
        {
            get;
            set;
        }
        
        /// <summary>
        /// The relativeTimeInterval property
        /// </summary>
        float RelativeTimeInterval
        {
            get;
            set;
        }
        
        /// <summary>
        /// The dateTime property
        /// </summary>
        DateTime DateTime
        {
            get;
            set;
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
        /// The ScheduledEvents property
        /// </summary>
        IOrderedSetExpression<IScheduledEvent> ScheduledEvents
        {
            get;
        }
        
        /// <summary>
        /// The window property
        /// </summary>
        IDateTimeInterval Window
        {
            get;
            set;
        }
        
        /// <summary>
        /// The TimeSchedule property
        /// </summary>
        ITimeSchedule TimeSchedule
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the SequenceNumber property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> SequenceNumberChanging;
        
        /// <summary>
        /// Gets fired when the SequenceNumber property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> SequenceNumberChanged;
        
        /// <summary>
        /// Gets fired before the RelativeTimeInterval property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> RelativeTimeIntervalChanging;
        
        /// <summary>
        /// Gets fired when the RelativeTimeInterval property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> RelativeTimeIntervalChanged;
        
        /// <summary>
        /// Gets fired before the DateTime property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DateTimeChanging;
        
        /// <summary>
        /// Gets fired when the DateTime property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DateTimeChanged;
        
        /// <summary>
        /// Gets fired before the Status property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> StatusChanging;
        
        /// <summary>
        /// Gets fired when the Status property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> StatusChanged;
        
        /// <summary>
        /// Gets fired before the Window property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> WindowChanging;
        
        /// <summary>
        /// Gets fired when the Window property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> WindowChanged;
        
        /// <summary>
        /// Gets fired before the TimeSchedule property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TimeScheduleChanging;
        
        /// <summary>
        /// Gets fired when the TimeSchedule property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TimeScheduleChanged;
    }
}

