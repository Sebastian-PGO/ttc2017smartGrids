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
    /// The public interface for SwitchingSchedule
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(SwitchingSchedule))]
    [XmlDefaultImplementationTypeAttribute(typeof(SwitchingSchedule))]
    public interface ISwitchingSchedule : IModelElement, IDocument
    {
        
        /// <summary>
        /// The reason property
        /// </summary>
        string Reason
        {
            get;
            set;
        }
        
        /// <summary>
        /// The WorkTask property
        /// </summary>
        IWorkTask WorkTask
        {
            get;
            set;
        }
        
        /// <summary>
        /// The ScheduleSteps property
        /// </summary>
        IOrderedSetExpression<ISwitchingStep> ScheduleSteps
        {
            get;
        }
        
        /// <summary>
        /// The interval property
        /// </summary>
        IDateTimeInterval Interval
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Crews property
        /// </summary>
        IOrderedSetExpression<ICrew> Crews
        {
            get;
        }
        
        /// <summary>
        /// Gets fired before the Reason property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ReasonChanging;
        
        /// <summary>
        /// Gets fired when the Reason property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ReasonChanged;
        
        /// <summary>
        /// Gets fired before the WorkTask property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> WorkTaskChanging;
        
        /// <summary>
        /// Gets fired when the WorkTask property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> WorkTaskChanged;
        
        /// <summary>
        /// Gets fired before the Interval property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> IntervalChanging;
        
        /// <summary>
        /// Gets fired when the Interval property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> IntervalChanged;
    }
}

