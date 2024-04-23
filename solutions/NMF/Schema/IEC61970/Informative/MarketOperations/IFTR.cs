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
using TTC2017.SmartGrids.CIM;
using TTC2017.SmartGrids.CIM.IEC61968.Common;
using TTC2017.SmartGrids.CIM.IEC61970.Contingency;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Generation.Production;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.EnergyScheduling;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.Financial;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfERPSupport;
using TTC2017.SmartGrids.CIM.IEC61970.LoadModel;
using TTC2017.SmartGrids.CIM.IEC61970.Meas;
using TTC2017.SmartGrids.CIM.IEC61970.Wires;

namespace TTC2017.SmartGrids.CIM.IEC61970.Informative.MarketOperations
{
    
    
    /// <summary>
    /// The public interface for FTR
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(FTR))]
    [XmlDefaultImplementationTypeAttribute(typeof(FTR))]
    public interface IFTR : IModelElement, IAgreement
    {
        
        /// <summary>
        /// The baseEnergy property
        /// </summary>
        float BaseEnergy
        {
            get;
            set;
        }
        
        /// <summary>
        /// The action property
        /// </summary>
        string Action
        {
            get;
            set;
        }
        
        /// <summary>
        /// The optimized property
        /// </summary>
        string Optimized
        {
            get;
            set;
        }
        
        /// <summary>
        /// The class property
        /// </summary>
        string Class
        {
            get;
            set;
        }
        
        /// <summary>
        /// The ftrType property
        /// </summary>
        string FtrType
        {
            get;
            set;
        }
        
        /// <summary>
        /// The EnergyPriceCurve property
        /// </summary>
        IEnergyPriceCurve EnergyPriceCurve
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Pnodes property
        /// </summary>
        IOrderedSetExpression<IPnode> Pnodes
        {
            get;
        }
        
        /// <summary>
        /// The Flowgate property
        /// </summary>
        IFlowgate Flowgate
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the BaseEnergy property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> BaseEnergyChanging;
        
        /// <summary>
        /// Gets fired when the BaseEnergy property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> BaseEnergyChanged;
        
        /// <summary>
        /// Gets fired before the Action property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ActionChanging;
        
        /// <summary>
        /// Gets fired when the Action property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ActionChanged;
        
        /// <summary>
        /// Gets fired before the Optimized property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> OptimizedChanging;
        
        /// <summary>
        /// Gets fired when the Optimized property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> OptimizedChanged;
        
        /// <summary>
        /// Gets fired before the Class property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ClassChanging;
        
        /// <summary>
        /// Gets fired when the Class property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ClassChanged;
        
        /// <summary>
        /// Gets fired before the FtrType property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FtrTypeChanging;
        
        /// <summary>
        /// Gets fired when the FtrType property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FtrTypeChanged;
        
        /// <summary>
        /// Gets fired before the EnergyPriceCurve property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> EnergyPriceCurveChanging;
        
        /// <summary>
        /// Gets fired when the EnergyPriceCurve property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> EnergyPriceCurveChanged;
        
        /// <summary>
        /// Gets fired before the Flowgate property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FlowgateChanging;
        
        /// <summary>
        /// Gets fired when the Flowgate property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FlowgateChanged;
    }
}

