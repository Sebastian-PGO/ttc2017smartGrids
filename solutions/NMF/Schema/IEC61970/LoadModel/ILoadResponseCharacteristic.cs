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
using TTC2017.SmartGrids.CIM.IEC61970.ControlArea;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.MarketOperations;
using TTC2017.SmartGrids.CIM.IEC61970.Wires;

namespace TTC2017.SmartGrids.CIM.IEC61970.LoadModel
{
    
    
    /// <summary>
    /// The public interface for LoadResponseCharacteristic
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(LoadResponseCharacteristic))]
    [XmlDefaultImplementationTypeAttribute(typeof(LoadResponseCharacteristic))]
    public interface ILoadResponseCharacteristic : IModelElement, IIdentifiedObject
    {
        
        /// <summary>
        /// The exponentModel property
        /// </summary>
        bool ExponentModel
        {
            get;
            set;
        }
        
        /// <summary>
        /// The pConstantCurrent property
        /// </summary>
        float PConstantCurrent
        {
            get;
            set;
        }
        
        /// <summary>
        /// The qConstantImpedance property
        /// </summary>
        float QConstantImpedance
        {
            get;
            set;
        }
        
        /// <summary>
        /// The qFrequencyExponent property
        /// </summary>
        float QFrequencyExponent
        {
            get;
            set;
        }
        
        /// <summary>
        /// The pFrequencyExponent property
        /// </summary>
        float PFrequencyExponent
        {
            get;
            set;
        }
        
        /// <summary>
        /// The pConstantImpedance property
        /// </summary>
        float PConstantImpedance
        {
            get;
            set;
        }
        
        /// <summary>
        /// The qVoltageExponent property
        /// </summary>
        float QVoltageExponent
        {
            get;
            set;
        }
        
        /// <summary>
        /// The pVoltageExponent property
        /// </summary>
        float PVoltageExponent
        {
            get;
            set;
        }
        
        /// <summary>
        /// The qConstantCurrent property
        /// </summary>
        float QConstantCurrent
        {
            get;
            set;
        }
        
        /// <summary>
        /// The pConstantPower property
        /// </summary>
        float PConstantPower
        {
            get;
            set;
        }
        
        /// <summary>
        /// The qConstantPower property
        /// </summary>
        float QConstantPower
        {
            get;
            set;
        }
        
        /// <summary>
        /// The EnergyConsumer property
        /// </summary>
        IOrderedSetExpression<IEnergyConsumer> EnergyConsumer
        {
            get;
        }
        
        /// <summary>
        /// Gets fired before the ExponentModel property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ExponentModelChanging;
        
        /// <summary>
        /// Gets fired when the ExponentModel property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ExponentModelChanged;
        
        /// <summary>
        /// Gets fired before the PConstantCurrent property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PConstantCurrentChanging;
        
        /// <summary>
        /// Gets fired when the PConstantCurrent property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PConstantCurrentChanged;
        
        /// <summary>
        /// Gets fired before the QConstantImpedance property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> QConstantImpedanceChanging;
        
        /// <summary>
        /// Gets fired when the QConstantImpedance property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> QConstantImpedanceChanged;
        
        /// <summary>
        /// Gets fired before the QFrequencyExponent property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> QFrequencyExponentChanging;
        
        /// <summary>
        /// Gets fired when the QFrequencyExponent property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> QFrequencyExponentChanged;
        
        /// <summary>
        /// Gets fired before the PFrequencyExponent property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PFrequencyExponentChanging;
        
        /// <summary>
        /// Gets fired when the PFrequencyExponent property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PFrequencyExponentChanged;
        
        /// <summary>
        /// Gets fired before the PConstantImpedance property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PConstantImpedanceChanging;
        
        /// <summary>
        /// Gets fired when the PConstantImpedance property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PConstantImpedanceChanged;
        
        /// <summary>
        /// Gets fired before the QVoltageExponent property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> QVoltageExponentChanging;
        
        /// <summary>
        /// Gets fired when the QVoltageExponent property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> QVoltageExponentChanged;
        
        /// <summary>
        /// Gets fired before the PVoltageExponent property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PVoltageExponentChanging;
        
        /// <summary>
        /// Gets fired when the PVoltageExponent property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PVoltageExponentChanged;
        
        /// <summary>
        /// Gets fired before the QConstantCurrent property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> QConstantCurrentChanging;
        
        /// <summary>
        /// Gets fired when the QConstantCurrent property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> QConstantCurrentChanged;
        
        /// <summary>
        /// Gets fired before the PConstantPower property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PConstantPowerChanging;
        
        /// <summary>
        /// Gets fired when the PConstantPower property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PConstantPowerChanged;
        
        /// <summary>
        /// Gets fired before the QConstantPower property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> QConstantPowerChanging;
        
        /// <summary>
        /// Gets fired when the QConstantPower property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> QConstantPowerChanged;
    }
}

