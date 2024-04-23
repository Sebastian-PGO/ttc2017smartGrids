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
    /// The public interface for WindingTest
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(WindingTest))]
    [XmlDefaultImplementationTypeAttribute(typeof(WindingTest))]
    public interface IWindingTest : IModelElement, IIdentifiedObject
    {
        
        /// <summary>
        /// The fromTapStep property
        /// </summary>
        int FromTapStep
        {
            get;
            set;
        }
        
        /// <summary>
        /// The leakageImpedance property
        /// </summary>
        float LeakageImpedance
        {
            get;
            set;
        }
        
        /// <summary>
        /// The noLoadLoss property
        /// </summary>
        float NoLoadLoss
        {
            get;
            set;
        }
        
        /// <summary>
        /// The phaseShift property
        /// </summary>
        float PhaseShift
        {
            get;
            set;
        }
        
        /// <summary>
        /// The loadLoss property
        /// </summary>
        float LoadLoss
        {
            get;
            set;
        }
        
        /// <summary>
        /// The toTapStep property
        /// </summary>
        int ToTapStep
        {
            get;
            set;
        }
        
        /// <summary>
        /// The voltage property
        /// </summary>
        float Voltage
        {
            get;
            set;
        }
        
        /// <summary>
        /// The excitingCurrent property
        /// </summary>
        float ExcitingCurrent
        {
            get;
            set;
        }
        
        /// <summary>
        /// The From_TransformerWinding property
        /// </summary>
        ITransformerWinding From_TransformerWinding
        {
            get;
            set;
        }
        
        /// <summary>
        /// The To_TransformerWinding property
        /// </summary>
        ITransformerWinding To_TransformerWinding
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the FromTapStep property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FromTapStepChanging;
        
        /// <summary>
        /// Gets fired when the FromTapStep property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FromTapStepChanged;
        
        /// <summary>
        /// Gets fired before the LeakageImpedance property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LeakageImpedanceChanging;
        
        /// <summary>
        /// Gets fired when the LeakageImpedance property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LeakageImpedanceChanged;
        
        /// <summary>
        /// Gets fired before the NoLoadLoss property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> NoLoadLossChanging;
        
        /// <summary>
        /// Gets fired when the NoLoadLoss property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> NoLoadLossChanged;
        
        /// <summary>
        /// Gets fired before the PhaseShift property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PhaseShiftChanging;
        
        /// <summary>
        /// Gets fired when the PhaseShift property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PhaseShiftChanged;
        
        /// <summary>
        /// Gets fired before the LoadLoss property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LoadLossChanging;
        
        /// <summary>
        /// Gets fired when the LoadLoss property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LoadLossChanged;
        
        /// <summary>
        /// Gets fired before the ToTapStep property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ToTapStepChanging;
        
        /// <summary>
        /// Gets fired when the ToTapStep property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ToTapStepChanged;
        
        /// <summary>
        /// Gets fired before the Voltage property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> VoltageChanging;
        
        /// <summary>
        /// Gets fired when the Voltage property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> VoltageChanged;
        
        /// <summary>
        /// Gets fired before the ExcitingCurrent property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ExcitingCurrentChanging;
        
        /// <summary>
        /// Gets fired when the ExcitingCurrent property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ExcitingCurrentChanged;
        
        /// <summary>
        /// Gets fired before the From_TransformerWinding property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> From_TransformerWindingChanging;
        
        /// <summary>
        /// Gets fired when the From_TransformerWinding property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> From_TransformerWindingChanged;
        
        /// <summary>
        /// Gets fired before the To_TransformerWinding property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> To_TransformerWindingChanging;
        
        /// <summary>
        /// Gets fired when the To_TransformerWinding property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> To_TransformerWindingChanged;
    }
}

