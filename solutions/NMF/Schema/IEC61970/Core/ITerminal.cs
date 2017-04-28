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
    /// The public interface for Terminal
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(Terminal))]
    [XmlDefaultImplementationTypeAttribute(typeof(Terminal))]
    public interface ITerminal : IModelElement, IIdentifiedObject
    {
        
        /// <summary>
        /// The connected property
        /// </summary>
        bool Connected
        {
            get;
            set;
        }
        
        /// <summary>
        /// The sequenceNumber property
        /// </summary>
        int SequenceNumber
        {
            get;
            set;
        }
        
        /// <summary>
        /// The ConnectivityNode property
        /// </summary>
        IConnectivityNode ConnectivityNode
        {
            get;
            set;
        }
        
        /// <summary>
        /// The SvPowerFlow property
        /// </summary>
        ISvPowerFlow SvPowerFlow
        {
            get;
            set;
        }
        
        /// <summary>
        /// The HasFirst_MutualCoupling property
        /// </summary>
        IOrderedSetExpression<IMutualCoupling> HasFirst_MutualCoupling
        {
            get;
        }
        
        /// <summary>
        /// The TerminalConstraints property
        /// </summary>
        IOrderedSetExpression<ITerminalConstraintTerm> TerminalConstraints
        {
            get;
        }
        
        /// <summary>
        /// The RegulatingControl property
        /// </summary>
        IOrderedSetExpression<IRegulatingControl> RegulatingControl
        {
            get;
        }
        
        /// <summary>
        /// The Measurements property
        /// </summary>
        IOrderedSetExpression<IMeasurement> Measurements
        {
            get;
        }
        
        /// <summary>
        /// The TieFlow property
        /// </summary>
        IOrderedSetExpression<ITieFlow> TieFlow
        {
            get;
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
        /// The BranchGroupTerminal property
        /// </summary>
        IOrderedSetExpression<IBranchGroupTerminal> BranchGroupTerminal
        {
            get;
        }
        
        /// <summary>
        /// The BushingInfo property
        /// </summary>
        IBushingInfo BushingInfo
        {
            get;
            set;
        }
        
        /// <summary>
        /// The ConductingEquipment property
        /// </summary>
        IConductingEquipment ConductingEquipment
        {
            get;
            set;
        }
        
        /// <summary>
        /// The HasSecond_MutualCoupling property
        /// </summary>
        IOrderedSetExpression<IMutualCoupling> HasSecond_MutualCoupling
        {
            get;
        }
        
        /// <summary>
        /// The OperationalLimitSet property
        /// </summary>
        IOrderedSetExpression<IOperationalLimitSet> OperationalLimitSet
        {
            get;
        }
        
        /// <summary>
        /// Gets fired before the Connected property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ConnectedChanging;
        
        /// <summary>
        /// Gets fired when the Connected property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ConnectedChanged;
        
        /// <summary>
        /// Gets fired before the SequenceNumber property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> SequenceNumberChanging;
        
        /// <summary>
        /// Gets fired when the SequenceNumber property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> SequenceNumberChanged;
        
        /// <summary>
        /// Gets fired before the ConnectivityNode property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ConnectivityNodeChanging;
        
        /// <summary>
        /// Gets fired when the ConnectivityNode property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ConnectivityNodeChanged;
        
        /// <summary>
        /// Gets fired before the SvPowerFlow property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> SvPowerFlowChanging;
        
        /// <summary>
        /// Gets fired when the SvPowerFlow property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> SvPowerFlowChanged;
        
        /// <summary>
        /// Gets fired before the TopologicalNode property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TopologicalNodeChanging;
        
        /// <summary>
        /// Gets fired when the TopologicalNode property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TopologicalNodeChanged;
        
        /// <summary>
        /// Gets fired before the BushingInfo property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> BushingInfoChanging;
        
        /// <summary>
        /// Gets fired when the BushingInfo property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> BushingInfoChanged;
        
        /// <summary>
        /// Gets fired before the ConductingEquipment property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ConductingEquipmentChanging;
        
        /// <summary>
        /// Gets fired when the ConductingEquipment property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ConductingEquipmentChanged;
    }
}

