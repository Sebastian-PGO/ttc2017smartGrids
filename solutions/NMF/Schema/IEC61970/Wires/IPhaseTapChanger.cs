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
    /// The public interface for PhaseTapChanger
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(PhaseTapChanger))]
    [XmlDefaultImplementationTypeAttribute(typeof(PhaseTapChanger))]
    public interface IPhaseTapChanger : IModelElement, ITapChanger
    {
        
        /// <summary>
        /// The windingConnectionAngle property
        /// </summary>
        float WindingConnectionAngle
        {
            get;
            set;
        }
        
        /// <summary>
        /// The phaseTapChangerType property
        /// </summary>
        Nullable<PhaseTapChangerKind> PhaseTapChangerType
        {
            get;
            set;
        }
        
        /// <summary>
        /// The stepPhaseShiftIncrement property
        /// </summary>
        float StepPhaseShiftIncrement
        {
            get;
            set;
        }
        
        /// <summary>
        /// The voltageStepIncrementOutOfPhase property
        /// </summary>
        float VoltageStepIncrementOutOfPhase
        {
            get;
            set;
        }
        
        /// <summary>
        /// The nominalVoltageOutOfPhase property
        /// </summary>
        float NominalVoltageOutOfPhase
        {
            get;
            set;
        }
        
        /// <summary>
        /// The xStepMax property
        /// </summary>
        float XStepMax
        {
            get;
            set;
        }
        
        /// <summary>
        /// The xStepMin property
        /// </summary>
        float XStepMin
        {
            get;
            set;
        }
        
        /// <summary>
        /// The TransformerWinding property
        /// </summary>
        ITransformerWinding TransformerWinding
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Winding property
        /// </summary>
        IDistributionTransformerWinding Winding
        {
            get;
            set;
        }
        
        /// <summary>
        /// The PhaseVariationCurve property
        /// </summary>
        IPhaseVariationCurve PhaseVariationCurve
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the WindingConnectionAngle property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> WindingConnectionAngleChanging;
        
        /// <summary>
        /// Gets fired when the WindingConnectionAngle property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> WindingConnectionAngleChanged;
        
        /// <summary>
        /// Gets fired before the PhaseTapChangerType property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PhaseTapChangerTypeChanging;
        
        /// <summary>
        /// Gets fired when the PhaseTapChangerType property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PhaseTapChangerTypeChanged;
        
        /// <summary>
        /// Gets fired before the StepPhaseShiftIncrement property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> StepPhaseShiftIncrementChanging;
        
        /// <summary>
        /// Gets fired when the StepPhaseShiftIncrement property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> StepPhaseShiftIncrementChanged;
        
        /// <summary>
        /// Gets fired before the VoltageStepIncrementOutOfPhase property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> VoltageStepIncrementOutOfPhaseChanging;
        
        /// <summary>
        /// Gets fired when the VoltageStepIncrementOutOfPhase property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> VoltageStepIncrementOutOfPhaseChanged;
        
        /// <summary>
        /// Gets fired before the NominalVoltageOutOfPhase property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> NominalVoltageOutOfPhaseChanging;
        
        /// <summary>
        /// Gets fired when the NominalVoltageOutOfPhase property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> NominalVoltageOutOfPhaseChanged;
        
        /// <summary>
        /// Gets fired before the XStepMax property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> XStepMaxChanging;
        
        /// <summary>
        /// Gets fired when the XStepMax property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> XStepMaxChanged;
        
        /// <summary>
        /// Gets fired before the XStepMin property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> XStepMinChanging;
        
        /// <summary>
        /// Gets fired when the XStepMin property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> XStepMinChanged;
        
        /// <summary>
        /// Gets fired before the TransformerWinding property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TransformerWindingChanging;
        
        /// <summary>
        /// Gets fired when the TransformerWinding property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TransformerWindingChanged;
        
        /// <summary>
        /// Gets fired before the Winding property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> WindingChanging;
        
        /// <summary>
        /// Gets fired when the Winding property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> WindingChanged;
        
        /// <summary>
        /// Gets fired before the PhaseVariationCurve property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PhaseVariationCurveChanging;
        
        /// <summary>
        /// Gets fired when the PhaseVariationCurve property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PhaseVariationCurveChanged;
    }
}

