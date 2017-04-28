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
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Topology;
using TTC2017.SmartGrids.CIM.IEC61970.Wires;

namespace TTC2017.SmartGrids.CIM.IEC61970.StateVariables
{
    
    
    /// <summary>
    /// The public interface for SvShortCircuit
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(SvShortCircuit))]
    [XmlDefaultImplementationTypeAttribute(typeof(SvShortCircuit))]
    public interface ISvShortCircuit : IModelElement, IStateVariable
    {
        
        /// <summary>
        /// The r0PerR property
        /// </summary>
        float R0PerR
        {
            get;
            set;
        }
        
        /// <summary>
        /// The sShortCircuit property
        /// </summary>
        float SShortCircuit
        {
            get;
            set;
        }
        
        /// <summary>
        /// The xPerR property
        /// </summary>
        float XPerR
        {
            get;
            set;
        }
        
        /// <summary>
        /// The x0PerX property
        /// </summary>
        float X0PerX
        {
            get;
            set;
        }
        
        /// <summary>
        /// The TopologicalNode property
        /// </summary>
        ITopologicalNode TopologicalNode
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the R0PerR property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> R0PerRChanging;
        
        /// <summary>
        /// Gets fired when the R0PerR property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> R0PerRChanged;
        
        /// <summary>
        /// Gets fired before the SShortCircuit property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> SShortCircuitChanging;
        
        /// <summary>
        /// Gets fired when the SShortCircuit property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> SShortCircuitChanged;
        
        /// <summary>
        /// Gets fired before the XPerR property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> XPerRChanging;
        
        /// <summary>
        /// Gets fired when the XPerR property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> XPerRChanged;
        
        /// <summary>
        /// Gets fired before the X0PerX property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> X0PerXChanging;
        
        /// <summary>
        /// Gets fired when the X0PerX property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> X0PerXChanged;
        
        /// <summary>
        /// Gets fired before the TopologicalNode property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TopologicalNodeChanging;
        
        /// <summary>
        /// Gets fired when the TopologicalNode property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TopologicalNodeChanged;
    }
}

