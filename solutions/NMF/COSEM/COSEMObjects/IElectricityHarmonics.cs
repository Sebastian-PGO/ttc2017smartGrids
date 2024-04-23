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
    /// The public interface for ElectricityHarmonics
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(ElectricityHarmonics))]
    [XmlDefaultImplementationTypeAttribute(typeof(ElectricityHarmonics))]
    public interface IElectricityHarmonics : IModelElement, IData
    {
        
        /// <summary>
        /// The total property
        /// </summary>
        Nullable<double> Total
        {
            get;
            set;
        }
        
        /// <summary>
        /// The fundamental_harmonic property
        /// </summary>
        Nullable<double> Fundamental_harmonic
        {
            get;
            set;
        }
        
        /// <summary>
        /// The harmonic property
        /// </summary>
        Nullable<double> Harmonic
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Total_Harmoni_Distortion property
        /// </summary>
        Nullable<double> Total_Harmoni_Distortion
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Total_Demand_Distortion property
        /// </summary>
        Nullable<double> Total_Demand_Distortion
        {
            get;
            set;
        }
        
        /// <summary>
        /// The All_harmonics property
        /// </summary>
        Nullable<double> All_harmonics
        {
            get;
            set;
        }
        
        /// <summary>
        /// The All_harmonics_to_nominal_value_ratio property
        /// </summary>
        Nullable<double> All_harmonics_to_nominal_value_ratio
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the Total property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TotalChanging;
        
        /// <summary>
        /// Gets fired when the Total property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TotalChanged;
        
        /// <summary>
        /// Gets fired before the Fundamental_harmonic property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Fundamental_harmonicChanging;
        
        /// <summary>
        /// Gets fired when the Fundamental_harmonic property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Fundamental_harmonicChanged;
        
        /// <summary>
        /// Gets fired before the Harmonic property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> HarmonicChanging;
        
        /// <summary>
        /// Gets fired when the Harmonic property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> HarmonicChanged;
        
        /// <summary>
        /// Gets fired before the Total_Harmoni_Distortion property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Total_Harmoni_DistortionChanging;
        
        /// <summary>
        /// Gets fired when the Total_Harmoni_Distortion property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Total_Harmoni_DistortionChanged;
        
        /// <summary>
        /// Gets fired before the Total_Demand_Distortion property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Total_Demand_DistortionChanging;
        
        /// <summary>
        /// Gets fired when the Total_Demand_Distortion property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Total_Demand_DistortionChanged;
        
        /// <summary>
        /// Gets fired before the All_harmonics property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> All_harmonicsChanging;
        
        /// <summary>
        /// Gets fired when the All_harmonics property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> All_harmonicsChanged;
        
        /// <summary>
        /// Gets fired before the All_harmonics_to_nominal_value_ratio property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> All_harmonics_to_nominal_value_ratioChanging;
        
        /// <summary>
        /// Gets fired when the All_harmonics_to_nominal_value_ratio property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> All_harmonics_to_nominal_value_ratioChanged;
    }
}

