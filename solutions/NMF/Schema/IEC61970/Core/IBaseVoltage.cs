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
using TTC2017.SmartGrids.CIM.IEC61968.Assets;
using TTC2017.SmartGrids.CIM.IEC61968.Common;
using TTC2017.SmartGrids.CIM.IEC61968.Customers;
using TTC2017.SmartGrids.CIM.IEC61970.Contingency;
using TTC2017.SmartGrids.CIM.IEC61970.ControlArea;
using TTC2017.SmartGrids.CIM.IEC61970.Domain;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssets;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfCommon;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfCore;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfOperations;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.MarketOperations;
using TTC2017.SmartGrids.CIM.IEC61970.Meas;
using TTC2017.SmartGrids.CIM.IEC61970.OperationalLimits;
using TTC2017.SmartGrids.CIM.IEC61970.Outage;
using TTC2017.SmartGrids.CIM.IEC61970.Protection;
using TTC2017.SmartGrids.CIM.IEC61970.StateVariables;
using TTC2017.SmartGrids.CIM.IEC61970.Topology;
using TTC2017.SmartGrids.CIM.IEC61970.Wires;

namespace TTC2017.SmartGrids.CIM.IEC61970.Core
{
    
    
    /// <summary>
    /// The public interface for BaseVoltage
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(BaseVoltage))]
    [XmlDefaultImplementationTypeAttribute(typeof(BaseVoltage))]
    public interface IBaseVoltage : IModelElement, IIdentifiedObject
    {
        
        /// <summary>
        /// The nominalVoltage property
        /// </summary>
        float NominalVoltage
        {
            get;
            set;
        }
        
        /// <summary>
        /// The isDC property
        /// </summary>
        bool IsDC
        {
            get;
            set;
        }
        
        /// <summary>
        /// The TopologicalNode property
        /// </summary>
        IOrderedSetExpression<ITopologicalNode> TopologicalNode
        {
            get;
        }
        
        /// <summary>
        /// The VoltageLevel property
        /// </summary>
        IOrderedSetExpression<IVoltageLevel> VoltageLevel
        {
            get;
        }
        
        /// <summary>
        /// The ConductingEquipment property
        /// </summary>
        IOrderedSetExpression<IConductingEquipment> ConductingEquipment
        {
            get;
        }
        
        /// <summary>
        /// Gets fired before the NominalVoltage property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> NominalVoltageChanging;
        
        /// <summary>
        /// Gets fired when the NominalVoltage property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> NominalVoltageChanged;
        
        /// <summary>
        /// Gets fired before the IsDC property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> IsDCChanging;
        
        /// <summary>
        /// Gets fired when the IsDC property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> IsDCChanged;
    }
}

