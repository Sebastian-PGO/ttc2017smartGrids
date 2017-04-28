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
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfOperations;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfWork;
using TTC2017.SmartGrids.CIM.IEC61970.Meas;

namespace TTC2017.SmartGrids.CIM.IEC61970.Informative.InfGMLSupport
{
    
    
    /// <summary>
    /// The public interface for GmlValue
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(GmlValue))]
    [XmlDefaultImplementationTypeAttribute(typeof(GmlValue))]
    public interface IGmlValue : IModelElement, IIdentifiedObject
    {
        
        /// <summary>
        /// The dateTime property
        /// </summary>
        DateTime DateTime
        {
            get;
            set;
        }
        
        /// <summary>
        /// The value property
        /// </summary>
        float Value
        {
            get;
            set;
        }
        
        /// <summary>
        /// The timePeriod property
        /// </summary>
        string TimePeriod
        {
            get;
            set;
        }
        
        /// <summary>
        /// The GmlObservation property
        /// </summary>
        IGmlObservation GmlObservation
        {
            get;
            set;
        }
        
        /// <summary>
        /// The MeasurementValue property
        /// </summary>
        IMeasurementValue MeasurementValue
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the DateTime property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DateTimeChanging;
        
        /// <summary>
        /// Gets fired when the DateTime property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DateTimeChanged;
        
        /// <summary>
        /// Gets fired before the Value property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ValueChanging;
        
        /// <summary>
        /// Gets fired when the Value property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ValueChanged;
        
        /// <summary>
        /// Gets fired before the TimePeriod property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TimePeriodChanging;
        
        /// <summary>
        /// Gets fired when the TimePeriod property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TimePeriodChanged;
        
        /// <summary>
        /// Gets fired before the GmlObservation property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> GmlObservationChanging;
        
        /// <summary>
        /// Gets fired when the GmlObservation property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> GmlObservationChanged;
        
        /// <summary>
        /// Gets fired before the MeasurementValue property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> MeasurementValueChanging;
        
        /// <summary>
        /// Gets fired when the MeasurementValue property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> MeasurementValueChanged;
    }
}

