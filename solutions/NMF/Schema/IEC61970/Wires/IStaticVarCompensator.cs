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
using TTC2017.SmartGrids.CIM.IEC61968.LoadControl;
using TTC2017.SmartGrids.CIM.IEC61968.Metering;
using TTC2017.SmartGrids.CIM.IEC61968.WiresExt;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Generation.GenerationDynamics;
using TTC2017.SmartGrids.CIM.IEC61970.Generation.Production;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.EnergyScheduling;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssets;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfLoadControl;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.MarketOperations;
using TTC2017.SmartGrids.CIM.IEC61970.LoadModel;
using TTC2017.SmartGrids.CIM.IEC61970.Meas;
using TTC2017.SmartGrids.CIM.IEC61970.Outage;
using TTC2017.SmartGrids.CIM.IEC61970.Protection;
using TTC2017.SmartGrids.CIM.IEC61970.StateVariables;

namespace TTC2017.SmartGrids.CIM.IEC61970.Wires
{
    
    
    /// <summary>
    /// The public interface for StaticVarCompensator
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(StaticVarCompensator))]
    [XmlDefaultImplementationTypeAttribute(typeof(StaticVarCompensator))]
    public interface IStaticVarCompensator : IModelElement, IRegulatingCondEq
    {
        
        /// <summary>
        /// The sVCControlMode property
        /// </summary>
        Nullable<SVCControlMode> SVCControlMode
        {
            get;
            set;
        }
        
        /// <summary>
        /// The inductiveRating property
        /// </summary>
        float InductiveRating
        {
            get;
            set;
        }
        
        /// <summary>
        /// The capacitiveRating property
        /// </summary>
        float CapacitiveRating
        {
            get;
            set;
        }
        
        /// <summary>
        /// The voltageSetPoint property
        /// </summary>
        float VoltageSetPoint
        {
            get;
            set;
        }
        
        /// <summary>
        /// The slope property
        /// </summary>
        float Slope
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the SVCControlMode property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> SVCControlModeChanging;
        
        /// <summary>
        /// Gets fired when the SVCControlMode property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> SVCControlModeChanged;
        
        /// <summary>
        /// Gets fired before the InductiveRating property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> InductiveRatingChanging;
        
        /// <summary>
        /// Gets fired when the InductiveRating property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> InductiveRatingChanged;
        
        /// <summary>
        /// Gets fired before the CapacitiveRating property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CapacitiveRatingChanging;
        
        /// <summary>
        /// Gets fired when the CapacitiveRating property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CapacitiveRatingChanged;
        
        /// <summary>
        /// Gets fired before the VoltageSetPoint property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> VoltageSetPointChanging;
        
        /// <summary>
        /// Gets fired when the VoltageSetPoint property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> VoltageSetPointChanged;
        
        /// <summary>
        /// Gets fired before the Slope property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> SlopeChanging;
        
        /// <summary>
        /// Gets fired when the Slope property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> SlopeChanged;
    }
}

