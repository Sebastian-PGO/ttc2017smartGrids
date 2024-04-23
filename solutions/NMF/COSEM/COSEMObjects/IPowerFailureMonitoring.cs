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
    /// The public interface for PowerFailureMonitoring
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(PowerFailureMonitoring))]
    [XmlDefaultImplementationTypeAttribute(typeof(PowerFailureMonitoring))]
    public interface IPowerFailureMonitoring : IModelElement, IData
    {
        
        /// <summary>
        /// The FailuresAllPhases property
        /// </summary>
        Nullable<int> FailuresAllPhases
        {
            get;
            set;
        }
        
        /// <summary>
        /// The FailuresL1 property
        /// </summary>
        Nullable<int> FailuresL1
        {
            get;
            set;
        }
        
        /// <summary>
        /// The FailuresL2 property
        /// </summary>
        Nullable<int> FailuresL2
        {
            get;
            set;
        }
        
        /// <summary>
        /// The FailuresL3 property
        /// </summary>
        Nullable<int> FailuresL3
        {
            get;
            set;
        }
        
        /// <summary>
        /// The FailuresAny property
        /// </summary>
        Nullable<int> FailuresAny
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Auxiliarysupply property
        /// </summary>
        string Auxiliarysupply
        {
            get;
            set;
        }
        
        /// <summary>
        /// The LongFailsAll property
        /// </summary>
        Nullable<int> LongFailsAll
        {
            get;
            set;
        }
        
        /// <summary>
        /// The LongFailsL1 property
        /// </summary>
        Nullable<int> LongFailsL1
        {
            get;
            set;
        }
        
        /// <summary>
        /// The LongFailsL2 property
        /// </summary>
        Nullable<int> LongFailsL2
        {
            get;
            set;
        }
        
        /// <summary>
        /// The LongFailsL3 property
        /// </summary>
        Nullable<int> LongFailsL3
        {
            get;
            set;
        }
        
        /// <summary>
        /// The LongFailsAny property
        /// </summary>
        Nullable<int> LongFailsAny
        {
            get;
            set;
        }
        
        /// <summary>
        /// The TimeAll property
        /// </summary>
        string TimeAll
        {
            get;
            set;
        }
        
        /// <summary>
        /// The TimeL1 property
        /// </summary>
        string TimeL1
        {
            get;
            set;
        }
        
        /// <summary>
        /// The TimeL2 property
        /// </summary>
        string TimeL2
        {
            get;
            set;
        }
        
        /// <summary>
        /// The TimeL3 property
        /// </summary>
        string TimeL3
        {
            get;
            set;
        }
        
        /// <summary>
        /// The TimeAny property
        /// </summary>
        string TimeAny
        {
            get;
            set;
        }
        
        /// <summary>
        /// The DurationAll property
        /// </summary>
        Nullable<int> DurationAll
        {
            get;
            set;
        }
        
        /// <summary>
        /// The DurationL1 property
        /// </summary>
        Nullable<int> DurationL1
        {
            get;
            set;
        }
        
        /// <summary>
        /// The DurationL2 property
        /// </summary>
        Nullable<int> DurationL2
        {
            get;
            set;
        }
        
        /// <summary>
        /// The DurationL3 property
        /// </summary>
        Nullable<int> DurationL3
        {
            get;
            set;
        }
        
        /// <summary>
        /// The DurationAny property
        /// </summary>
        Nullable<int> DurationAny
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Time_threshold_long_powerfailure property
        /// </summary>
        Nullable<int> Time_threshold_long_powerfailure
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the FailuresAllPhases property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FailuresAllPhasesChanging;
        
        /// <summary>
        /// Gets fired when the FailuresAllPhases property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FailuresAllPhasesChanged;
        
        /// <summary>
        /// Gets fired before the FailuresL1 property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FailuresL1Changing;
        
        /// <summary>
        /// Gets fired when the FailuresL1 property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FailuresL1Changed;
        
        /// <summary>
        /// Gets fired before the FailuresL2 property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FailuresL2Changing;
        
        /// <summary>
        /// Gets fired when the FailuresL2 property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FailuresL2Changed;
        
        /// <summary>
        /// Gets fired before the FailuresL3 property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FailuresL3Changing;
        
        /// <summary>
        /// Gets fired when the FailuresL3 property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FailuresL3Changed;
        
        /// <summary>
        /// Gets fired before the FailuresAny property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FailuresAnyChanging;
        
        /// <summary>
        /// Gets fired when the FailuresAny property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FailuresAnyChanged;
        
        /// <summary>
        /// Gets fired before the Auxiliarysupply property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AuxiliarysupplyChanging;
        
        /// <summary>
        /// Gets fired when the Auxiliarysupply property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AuxiliarysupplyChanged;
        
        /// <summary>
        /// Gets fired before the LongFailsAll property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LongFailsAllChanging;
        
        /// <summary>
        /// Gets fired when the LongFailsAll property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LongFailsAllChanged;
        
        /// <summary>
        /// Gets fired before the LongFailsL1 property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LongFailsL1Changing;
        
        /// <summary>
        /// Gets fired when the LongFailsL1 property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LongFailsL1Changed;
        
        /// <summary>
        /// Gets fired before the LongFailsL2 property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LongFailsL2Changing;
        
        /// <summary>
        /// Gets fired when the LongFailsL2 property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LongFailsL2Changed;
        
        /// <summary>
        /// Gets fired before the LongFailsL3 property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LongFailsL3Changing;
        
        /// <summary>
        /// Gets fired when the LongFailsL3 property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LongFailsL3Changed;
        
        /// <summary>
        /// Gets fired before the LongFailsAny property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LongFailsAnyChanging;
        
        /// <summary>
        /// Gets fired when the LongFailsAny property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LongFailsAnyChanged;
        
        /// <summary>
        /// Gets fired before the TimeAll property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TimeAllChanging;
        
        /// <summary>
        /// Gets fired when the TimeAll property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TimeAllChanged;
        
        /// <summary>
        /// Gets fired before the TimeL1 property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TimeL1Changing;
        
        /// <summary>
        /// Gets fired when the TimeL1 property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TimeL1Changed;
        
        /// <summary>
        /// Gets fired before the TimeL2 property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TimeL2Changing;
        
        /// <summary>
        /// Gets fired when the TimeL2 property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TimeL2Changed;
        
        /// <summary>
        /// Gets fired before the TimeL3 property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TimeL3Changing;
        
        /// <summary>
        /// Gets fired when the TimeL3 property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TimeL3Changed;
        
        /// <summary>
        /// Gets fired before the TimeAny property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TimeAnyChanging;
        
        /// <summary>
        /// Gets fired when the TimeAny property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TimeAnyChanged;
        
        /// <summary>
        /// Gets fired before the DurationAll property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DurationAllChanging;
        
        /// <summary>
        /// Gets fired when the DurationAll property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DurationAllChanged;
        
        /// <summary>
        /// Gets fired before the DurationL1 property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DurationL1Changing;
        
        /// <summary>
        /// Gets fired when the DurationL1 property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DurationL1Changed;
        
        /// <summary>
        /// Gets fired before the DurationL2 property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DurationL2Changing;
        
        /// <summary>
        /// Gets fired when the DurationL2 property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DurationL2Changed;
        
        /// <summary>
        /// Gets fired before the DurationL3 property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DurationL3Changing;
        
        /// <summary>
        /// Gets fired when the DurationL3 property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DurationL3Changed;
        
        /// <summary>
        /// Gets fired before the DurationAny property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DurationAnyChanging;
        
        /// <summary>
        /// Gets fired when the DurationAny property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DurationAnyChanged;
        
        /// <summary>
        /// Gets fired before the Time_threshold_long_powerfailure property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Time_threshold_long_powerfailureChanging;
        
        /// <summary>
        /// Gets fired when the Time_threshold_long_powerfailure property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Time_threshold_long_powerfailureChanged;
    }
}

