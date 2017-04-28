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
    /// The public interface for MeasurementPeriod_recordingInterval_billingPeriodDuration
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(MeasurementPeriod_recordingInterval_billingPeriodDuration))]
    [XmlDefaultImplementationTypeAttribute(typeof(MeasurementPeriod_recordingInterval_billingPeriodDuration))]
    public interface IMeasurementPeriod_recordingInterval_billingPeriodDuration : IModelElement, IData
    {
        
        /// <summary>
        /// The Measurement_period_1_for_averaging_scheme_1 property
        /// </summary>
        string Measurement_period_1_for_averaging_scheme_1
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Measurement_period_2_for_averagingscheme_2 property
        /// </summary>
        string Measurement_period_2_for_averagingscheme_2
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Measurement_period_3_for_instantaneous_value property
        /// </summary>
        string Measurement_period_3_for_instantaneous_value
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Measurement_period_4_for_test_value property
        /// </summary>
        string Measurement_period_4_for_test_value
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Recording_interval_1_for_loadprofile property
        /// </summary>
        string Recording_interval_1_for_loadprofile
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Recording_interval_2_for_loadprofile property
        /// </summary>
        string Recording_interval_2_for_loadprofile
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Billingperiod property
        /// </summary>
        string Billingperiod
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the Measurement_period_1_for_averaging_scheme_1 property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Measurement_period_1_for_averaging_scheme_1Changing;
        
        /// <summary>
        /// Gets fired when the Measurement_period_1_for_averaging_scheme_1 property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Measurement_period_1_for_averaging_scheme_1Changed;
        
        /// <summary>
        /// Gets fired before the Measurement_period_2_for_averagingscheme_2 property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Measurement_period_2_for_averagingscheme_2Changing;
        
        /// <summary>
        /// Gets fired when the Measurement_period_2_for_averagingscheme_2 property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Measurement_period_2_for_averagingscheme_2Changed;
        
        /// <summary>
        /// Gets fired before the Measurement_period_3_for_instantaneous_value property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Measurement_period_3_for_instantaneous_valueChanging;
        
        /// <summary>
        /// Gets fired when the Measurement_period_3_for_instantaneous_value property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Measurement_period_3_for_instantaneous_valueChanged;
        
        /// <summary>
        /// Gets fired before the Measurement_period_4_for_test_value property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Measurement_period_4_for_test_valueChanging;
        
        /// <summary>
        /// Gets fired when the Measurement_period_4_for_test_value property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Measurement_period_4_for_test_valueChanged;
        
        /// <summary>
        /// Gets fired before the Recording_interval_1_for_loadprofile property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Recording_interval_1_for_loadprofileChanging;
        
        /// <summary>
        /// Gets fired when the Recording_interval_1_for_loadprofile property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Recording_interval_1_for_loadprofileChanged;
        
        /// <summary>
        /// Gets fired before the Recording_interval_2_for_loadprofile property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Recording_interval_2_for_loadprofileChanging;
        
        /// <summary>
        /// Gets fired when the Recording_interval_2_for_loadprofile property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Recording_interval_2_for_loadprofileChanged;
        
        /// <summary>
        /// Gets fired before the Billingperiod property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> BillingperiodChanging;
        
        /// <summary>
        /// Gets fired when the Billingperiod property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> BillingperiodChanged;
    }
}

