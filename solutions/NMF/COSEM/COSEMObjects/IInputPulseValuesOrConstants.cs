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
    /// The public interface for InputPulseValuesOrConstants
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(InputPulseValuesOrConstants))]
    [XmlDefaultImplementationTypeAttribute(typeof(InputPulseValuesOrConstants))]
    public interface IInputPulseValuesOrConstants : IModelElement, IData
    {
        
        /// <summary>
        /// The ActiveEnergy property
        /// </summary>
        Nullable<double> ActiveEnergy
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Reactive_energy property
        /// </summary>
        Nullable<double> Reactive_energy
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Apparent_energy property
        /// </summary>
        Nullable<double> Apparent_energy
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Volt_squared_hours property
        /// </summary>
        Nullable<double> Volt_squared_hours
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Ampere_squared_hours property
        /// </summary>
        Nullable<double> Ampere_squared_hours
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Unitless_quantities property
        /// </summary>
        Nullable<double> Unitless_quantities
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Active_energy_export property
        /// </summary>
        Nullable<double> Active_energy_export
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Reactive_energy_export property
        /// </summary>
        Nullable<double> Reactive_energy_export
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Apparent_energy_export property
        /// </summary>
        Nullable<double> Apparent_energy_export
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the ActiveEnergy property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ActiveEnergyChanging;
        
        /// <summary>
        /// Gets fired when the ActiveEnergy property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ActiveEnergyChanged;
        
        /// <summary>
        /// Gets fired before the Reactive_energy property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Reactive_energyChanging;
        
        /// <summary>
        /// Gets fired when the Reactive_energy property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Reactive_energyChanged;
        
        /// <summary>
        /// Gets fired before the Apparent_energy property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Apparent_energyChanging;
        
        /// <summary>
        /// Gets fired when the Apparent_energy property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Apparent_energyChanged;
        
        /// <summary>
        /// Gets fired before the Volt_squared_hours property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Volt_squared_hoursChanging;
        
        /// <summary>
        /// Gets fired when the Volt_squared_hours property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Volt_squared_hoursChanged;
        
        /// <summary>
        /// Gets fired before the Ampere_squared_hours property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Ampere_squared_hoursChanging;
        
        /// <summary>
        /// Gets fired when the Ampere_squared_hours property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Ampere_squared_hoursChanged;
        
        /// <summary>
        /// Gets fired before the Unitless_quantities property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Unitless_quantitiesChanging;
        
        /// <summary>
        /// Gets fired when the Unitless_quantities property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Unitless_quantitiesChanged;
        
        /// <summary>
        /// Gets fired before the Active_energy_export property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Active_energy_exportChanging;
        
        /// <summary>
        /// Gets fired when the Active_energy_export property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Active_energy_exportChanged;
        
        /// <summary>
        /// Gets fired before the Reactive_energy_export property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Reactive_energy_exportChanging;
        
        /// <summary>
        /// Gets fired when the Reactive_energy_export property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Reactive_energy_exportChanged;
        
        /// <summary>
        /// Gets fired before the Apparent_energy_export property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Apparent_energy_exportChanging;
        
        /// <summary>
        /// Gets fired when the Apparent_energy_export property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Apparent_energy_exportChanged;
    }
}

