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
using TTC2017.SmartGrids.COSEM.InterfaceClasses;

namespace TTC2017.SmartGrids.COSEM.COSEMObjects
{
    
    
    /// <summary>
    /// The public interface for MeterTemperEventRelatedObject
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(MeterTemperEventRelatedObject))]
    [XmlDefaultImplementationTypeAttribute(typeof(MeterTemperEventRelatedObject))]
    public interface IMeterTemperEventRelatedObject : IModelElement, IData
    {
        
        /// <summary>
        /// The Meter_open_event_counter property
        /// </summary>
        Nullable<int> Meter_open_event_counter
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Meter_open_event_timestamp property
        /// </summary>
        string Meter_open_event_timestamp
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Meter_open_event_duration property
        /// </summary>
        Nullable<int> Meter_open_event_duration
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Meter_open_event_cumulative_duration property
        /// </summary>
        Nullable<int> Meter_open_event_cumulative_duration
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Terminal_cover_open_event_counter property
        /// </summary>
        Nullable<int> Terminal_cover_open_event_counter
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Terminal_cover_open_event_time property
        /// </summary>
        string Terminal_cover_open_event_time
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Terminal_cover_open_event_duration property
        /// </summary>
        Nullable<int> Terminal_cover_open_event_duration
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Terminal_cover_open_event_cumulative_duration property
        /// </summary>
        Nullable<int> Terminal_cover_open_event_cumulative_duration
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Tilt_event_counter property
        /// </summary>
        Nullable<int> Tilt_event_counter
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Tilt_event_time property
        /// </summary>
        string Tilt_event_time
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Tilt_event_duration property
        /// </summary>
        Nullable<int> Tilt_event_duration
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Tilt_event_cumulative_duration property
        /// </summary>
        Nullable<int> Tilt_event_cumulative_duration
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Strong_DC_magnetic_field_event_counter property
        /// </summary>
        Nullable<int> Strong_DC_magnetic_field_event_counter
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Strong_DC_magnetic_field_event_time property
        /// </summary>
        string Strong_DC_magnetic_field_event_time
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Strong_DC_magnetic_field_event_duration property
        /// </summary>
        Nullable<int> Strong_DC_magnetic_field_event_duration
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Strong_DC_magnetic_field_event_cumulative_duration property
        /// </summary>
        Nullable<int> Strong_DC_magnetic_field_event_cumulative_duration
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Supply_control_switch_event_counter property
        /// </summary>
        Nullable<int> Supply_control_switch_event_counter
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Supply_control_switch_event_time property
        /// </summary>
        string Supply_control_switch_event_time
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Supply_control_switch_event_duration property
        /// </summary>
        Nullable<int> Supply_control_switch_event_duration
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Supply_control_switch_event_cumulative_duration property
        /// </summary>
        Nullable<int> Supply_control_switch_event_cumulative_duration
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Metrology_tamper_event_counter property
        /// </summary>
        Nullable<int> Metrology_tamper_event_counter
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Metrology_tamper_event_time property
        /// </summary>
        string Metrology_tamper_event_time
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Metrology_tamper_event_duration property
        /// </summary>
        Nullable<int> Metrology_tamper_event_duration
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Metrology_tamper_event_cumulative_duration property
        /// </summary>
        Nullable<int> Metrology_tamper_event_cumulative_duration
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Communication_tamper_event_counter property
        /// </summary>
        Nullable<int> Communication_tamper_event_counter
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Communication_tamper_event_time property
        /// </summary>
        string Communication_tamper_event_time
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Communication_tamper_event_duration property
        /// </summary>
        Nullable<int> Communication_tamper_event_duration
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Communication_tamper_event_cumulative_duration property
        /// </summary>
        Nullable<int> Communication_tamper_event_cumulative_duration
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Manufacturer_specific property
        /// </summary>
        string Manufacturer_specific
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the Meter_open_event_counter property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Meter_open_event_counterChanging;
        
        /// <summary>
        /// Gets fired when the Meter_open_event_counter property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Meter_open_event_counterChanged;
        
        /// <summary>
        /// Gets fired before the Meter_open_event_timestamp property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Meter_open_event_timestampChanging;
        
        /// <summary>
        /// Gets fired when the Meter_open_event_timestamp property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Meter_open_event_timestampChanged;
        
        /// <summary>
        /// Gets fired before the Meter_open_event_duration property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Meter_open_event_durationChanging;
        
        /// <summary>
        /// Gets fired when the Meter_open_event_duration property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Meter_open_event_durationChanged;
        
        /// <summary>
        /// Gets fired before the Meter_open_event_cumulative_duration property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Meter_open_event_cumulative_durationChanging;
        
        /// <summary>
        /// Gets fired when the Meter_open_event_cumulative_duration property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Meter_open_event_cumulative_durationChanged;
        
        /// <summary>
        /// Gets fired before the Terminal_cover_open_event_counter property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Terminal_cover_open_event_counterChanging;
        
        /// <summary>
        /// Gets fired when the Terminal_cover_open_event_counter property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Terminal_cover_open_event_counterChanged;
        
        /// <summary>
        /// Gets fired before the Terminal_cover_open_event_time property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Terminal_cover_open_event_timeChanging;
        
        /// <summary>
        /// Gets fired when the Terminal_cover_open_event_time property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Terminal_cover_open_event_timeChanged;
        
        /// <summary>
        /// Gets fired before the Terminal_cover_open_event_duration property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Terminal_cover_open_event_durationChanging;
        
        /// <summary>
        /// Gets fired when the Terminal_cover_open_event_duration property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Terminal_cover_open_event_durationChanged;
        
        /// <summary>
        /// Gets fired before the Terminal_cover_open_event_cumulative_duration property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Terminal_cover_open_event_cumulative_durationChanging;
        
        /// <summary>
        /// Gets fired when the Terminal_cover_open_event_cumulative_duration property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Terminal_cover_open_event_cumulative_durationChanged;
        
        /// <summary>
        /// Gets fired before the Tilt_event_counter property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Tilt_event_counterChanging;
        
        /// <summary>
        /// Gets fired when the Tilt_event_counter property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Tilt_event_counterChanged;
        
        /// <summary>
        /// Gets fired before the Tilt_event_time property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Tilt_event_timeChanging;
        
        /// <summary>
        /// Gets fired when the Tilt_event_time property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Tilt_event_timeChanged;
        
        /// <summary>
        /// Gets fired before the Tilt_event_duration property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Tilt_event_durationChanging;
        
        /// <summary>
        /// Gets fired when the Tilt_event_duration property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Tilt_event_durationChanged;
        
        /// <summary>
        /// Gets fired before the Tilt_event_cumulative_duration property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Tilt_event_cumulative_durationChanging;
        
        /// <summary>
        /// Gets fired when the Tilt_event_cumulative_duration property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Tilt_event_cumulative_durationChanged;
        
        /// <summary>
        /// Gets fired before the Strong_DC_magnetic_field_event_counter property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Strong_DC_magnetic_field_event_counterChanging;
        
        /// <summary>
        /// Gets fired when the Strong_DC_magnetic_field_event_counter property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Strong_DC_magnetic_field_event_counterChanged;
        
        /// <summary>
        /// Gets fired before the Strong_DC_magnetic_field_event_time property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Strong_DC_magnetic_field_event_timeChanging;
        
        /// <summary>
        /// Gets fired when the Strong_DC_magnetic_field_event_time property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Strong_DC_magnetic_field_event_timeChanged;
        
        /// <summary>
        /// Gets fired before the Strong_DC_magnetic_field_event_duration property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Strong_DC_magnetic_field_event_durationChanging;
        
        /// <summary>
        /// Gets fired when the Strong_DC_magnetic_field_event_duration property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Strong_DC_magnetic_field_event_durationChanged;
        
        /// <summary>
        /// Gets fired before the Strong_DC_magnetic_field_event_cumulative_duration property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Strong_DC_magnetic_field_event_cumulative_durationChanging;
        
        /// <summary>
        /// Gets fired when the Strong_DC_magnetic_field_event_cumulative_duration property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Strong_DC_magnetic_field_event_cumulative_durationChanged;
        
        /// <summary>
        /// Gets fired before the Supply_control_switch_event_counter property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Supply_control_switch_event_counterChanging;
        
        /// <summary>
        /// Gets fired when the Supply_control_switch_event_counter property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Supply_control_switch_event_counterChanged;
        
        /// <summary>
        /// Gets fired before the Supply_control_switch_event_time property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Supply_control_switch_event_timeChanging;
        
        /// <summary>
        /// Gets fired when the Supply_control_switch_event_time property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Supply_control_switch_event_timeChanged;
        
        /// <summary>
        /// Gets fired before the Supply_control_switch_event_duration property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Supply_control_switch_event_durationChanging;
        
        /// <summary>
        /// Gets fired when the Supply_control_switch_event_duration property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Supply_control_switch_event_durationChanged;
        
        /// <summary>
        /// Gets fired before the Supply_control_switch_event_cumulative_duration property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Supply_control_switch_event_cumulative_durationChanging;
        
        /// <summary>
        /// Gets fired when the Supply_control_switch_event_cumulative_duration property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Supply_control_switch_event_cumulative_durationChanged;
        
        /// <summary>
        /// Gets fired before the Metrology_tamper_event_counter property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Metrology_tamper_event_counterChanging;
        
        /// <summary>
        /// Gets fired when the Metrology_tamper_event_counter property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Metrology_tamper_event_counterChanged;
        
        /// <summary>
        /// Gets fired before the Metrology_tamper_event_time property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Metrology_tamper_event_timeChanging;
        
        /// <summary>
        /// Gets fired when the Metrology_tamper_event_time property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Metrology_tamper_event_timeChanged;
        
        /// <summary>
        /// Gets fired before the Metrology_tamper_event_duration property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Metrology_tamper_event_durationChanging;
        
        /// <summary>
        /// Gets fired when the Metrology_tamper_event_duration property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Metrology_tamper_event_durationChanged;
        
        /// <summary>
        /// Gets fired before the Metrology_tamper_event_cumulative_duration property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Metrology_tamper_event_cumulative_durationChanging;
        
        /// <summary>
        /// Gets fired when the Metrology_tamper_event_cumulative_duration property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Metrology_tamper_event_cumulative_durationChanged;
        
        /// <summary>
        /// Gets fired before the Communication_tamper_event_counter property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Communication_tamper_event_counterChanging;
        
        /// <summary>
        /// Gets fired when the Communication_tamper_event_counter property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Communication_tamper_event_counterChanged;
        
        /// <summary>
        /// Gets fired before the Communication_tamper_event_time property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Communication_tamper_event_timeChanging;
        
        /// <summary>
        /// Gets fired when the Communication_tamper_event_time property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Communication_tamper_event_timeChanged;
        
        /// <summary>
        /// Gets fired before the Communication_tamper_event_duration property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Communication_tamper_event_durationChanging;
        
        /// <summary>
        /// Gets fired when the Communication_tamper_event_duration property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Communication_tamper_event_durationChanged;
        
        /// <summary>
        /// Gets fired before the Communication_tamper_event_cumulative_duration property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Communication_tamper_event_cumulative_durationChanging;
        
        /// <summary>
        /// Gets fired when the Communication_tamper_event_cumulative_duration property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Communication_tamper_event_cumulative_durationChanged;
        
        /// <summary>
        /// Gets fired before the Manufacturer_specific property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Manufacturer_specificChanging;
        
        /// <summary>
        /// Gets fired when the Manufacturer_specific property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Manufacturer_specificChanged;
    }
}

