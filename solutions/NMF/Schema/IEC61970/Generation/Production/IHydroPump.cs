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
using TTC2017.SmartGrids.CIM.IEC61970.ControlArea;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Generation.GenerationDynamics;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.EnergyScheduling;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.Financial;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.MarketOperations;
using TTC2017.SmartGrids.CIM.IEC61970.Wires;

namespace TTC2017.SmartGrids.CIM.IEC61970.Generation.Production
{
    
    
    /// <summary>
    /// The public interface for HydroPump
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(HydroPump))]
    [XmlDefaultImplementationTypeAttribute(typeof(HydroPump))]
    public interface IHydroPump : IModelElement, IPowerSystemResource
    {
        
        /// <summary>
        /// The pumpDischAtMinHead property
        /// </summary>
        float PumpDischAtMinHead
        {
            get;
            set;
        }
        
        /// <summary>
        /// The pumpPowerAtMinHead property
        /// </summary>
        float PumpPowerAtMinHead
        {
            get;
            set;
        }
        
        /// <summary>
        /// The pumpPowerAtMaxHead property
        /// </summary>
        float PumpPowerAtMaxHead
        {
            get;
            set;
        }
        
        /// <summary>
        /// The pumpDischAtMaxHead property
        /// </summary>
        float PumpDischAtMaxHead
        {
            get;
            set;
        }
        
        /// <summary>
        /// The HydroPowerPlant property
        /// </summary>
        IHydroPowerPlant HydroPowerPlant
        {
            get;
            set;
        }
        
        /// <summary>
        /// The SynchronousMachine property
        /// </summary>
        ISynchronousMachine SynchronousMachine
        {
            get;
            set;
        }
        
        /// <summary>
        /// The HydroPumpOpSchedule property
        /// </summary>
        IHydroPumpOpSchedule HydroPumpOpSchedule
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the PumpDischAtMinHead property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PumpDischAtMinHeadChanging;
        
        /// <summary>
        /// Gets fired when the PumpDischAtMinHead property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PumpDischAtMinHeadChanged;
        
        /// <summary>
        /// Gets fired before the PumpPowerAtMinHead property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PumpPowerAtMinHeadChanging;
        
        /// <summary>
        /// Gets fired when the PumpPowerAtMinHead property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PumpPowerAtMinHeadChanged;
        
        /// <summary>
        /// Gets fired before the PumpPowerAtMaxHead property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PumpPowerAtMaxHeadChanging;
        
        /// <summary>
        /// Gets fired when the PumpPowerAtMaxHead property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PumpPowerAtMaxHeadChanged;
        
        /// <summary>
        /// Gets fired before the PumpDischAtMaxHead property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PumpDischAtMaxHeadChanging;
        
        /// <summary>
        /// Gets fired when the PumpDischAtMaxHead property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PumpDischAtMaxHeadChanged;
        
        /// <summary>
        /// Gets fired before the HydroPowerPlant property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> HydroPowerPlantChanging;
        
        /// <summary>
        /// Gets fired when the HydroPowerPlant property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> HydroPowerPlantChanged;
        
        /// <summary>
        /// Gets fired before the SynchronousMachine property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> SynchronousMachineChanging;
        
        /// <summary>
        /// Gets fired when the SynchronousMachine property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> SynchronousMachineChanged;
        
        /// <summary>
        /// Gets fired before the HydroPumpOpSchedule property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> HydroPumpOpScheduleChanging;
        
        /// <summary>
        /// Gets fired when the HydroPumpOpSchedule property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> HydroPumpOpScheduleChanged;
    }
}

