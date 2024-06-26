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
using TTC2017.SmartGrids.CIM.IEC61968.AssetModels;
using TTC2017.SmartGrids.CIM.IEC61968.Assets;
using TTC2017.SmartGrids.CIM.IEC61968.Common;
using TTC2017.SmartGrids.CIM.IEC61968.Metering;
using TTC2017.SmartGrids.CIM.IEC61968.WiresExt;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssetModels;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfCommon;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfERPSupport;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfOperations;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfTypeAsset;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfWork;
using TTC2017.SmartGrids.CIM.IEC61970.Meas;
using TTC2017.SmartGrids.CIM.IEC61970.Wires;

namespace TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssets
{
    
    
    /// <summary>
    /// The public interface for ShuntImpedanceInfo
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(ShuntImpedanceInfo))]
    [XmlDefaultImplementationTypeAttribute(typeof(ShuntImpedanceInfo))]
    public interface IShuntImpedanceInfo : IModelElement, IElectricalInfo
    {
        
        /// <summary>
        /// The lowVoltageOverride property
        /// </summary>
        float LowVoltageOverride
        {
            get;
            set;
        }
        
        /// <summary>
        /// The cellSize property
        /// </summary>
        float CellSize
        {
            get;
            set;
        }
        
        /// <summary>
        /// The highVoltageOverride property
        /// </summary>
        float HighVoltageOverride
        {
            get;
            set;
        }
        
        /// <summary>
        /// The regBranchKind property
        /// </summary>
        Nullable<RegulationBranchKind> RegBranchKind
        {
            get;
            set;
        }
        
        /// <summary>
        /// The normalOpen property
        /// </summary>
        bool NormalOpen
        {
            get;
            set;
        }
        
        /// <summary>
        /// The regBranchEnd property
        /// </summary>
        int RegBranchEnd
        {
            get;
            set;
        }
        
        /// <summary>
        /// The vRegLineLine property
        /// </summary>
        bool VRegLineLine
        {
            get;
            set;
        }
        
        /// <summary>
        /// The switchOperationCycle property
        /// </summary>
        float SwitchOperationCycle
        {
            get;
            set;
        }
        
        /// <summary>
        /// The localOffLevel property
        /// </summary>
        string LocalOffLevel
        {
            get;
            set;
        }
        
        /// <summary>
        /// The sensingPhaseCode property
        /// </summary>
        Nullable<PhaseCode> SensingPhaseCode
        {
            get;
            set;
        }
        
        /// <summary>
        /// The localControlKind property
        /// </summary>
        Nullable<ShuntImpedanceLocalControlKind> LocalControlKind
        {
            get;
            set;
        }
        
        /// <summary>
        /// The branchDirect property
        /// </summary>
        int BranchDirect
        {
            get;
            set;
        }
        
        /// <summary>
        /// The maxSwitchOperationCount property
        /// </summary>
        int MaxSwitchOperationCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// The localOverride property
        /// </summary>
        bool LocalOverride
        {
            get;
            set;
        }
        
        /// <summary>
        /// The localOnLevel property
        /// </summary>
        string LocalOnLevel
        {
            get;
            set;
        }
        
        /// <summary>
        /// The regBranch property
        /// </summary>
        string RegBranch
        {
            get;
            set;
        }
        
        /// <summary>
        /// The controlKind property
        /// </summary>
        Nullable<ShuntImpedanceControlKind> ControlKind
        {
            get;
            set;
        }
        
        /// <summary>
        /// The ShuntCompensatorInfos property
        /// </summary>
        IOrderedSetExpression<IShuntCompensatorInfo> ShuntCompensatorInfos
        {
            get;
        }
        
        /// <summary>
        /// Gets fired before the LowVoltageOverride property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LowVoltageOverrideChanging;
        
        /// <summary>
        /// Gets fired when the LowVoltageOverride property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LowVoltageOverrideChanged;
        
        /// <summary>
        /// Gets fired before the CellSize property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CellSizeChanging;
        
        /// <summary>
        /// Gets fired when the CellSize property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CellSizeChanged;
        
        /// <summary>
        /// Gets fired before the HighVoltageOverride property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> HighVoltageOverrideChanging;
        
        /// <summary>
        /// Gets fired when the HighVoltageOverride property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> HighVoltageOverrideChanged;
        
        /// <summary>
        /// Gets fired before the RegBranchKind property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> RegBranchKindChanging;
        
        /// <summary>
        /// Gets fired when the RegBranchKind property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> RegBranchKindChanged;
        
        /// <summary>
        /// Gets fired before the NormalOpen property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> NormalOpenChanging;
        
        /// <summary>
        /// Gets fired when the NormalOpen property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> NormalOpenChanged;
        
        /// <summary>
        /// Gets fired before the RegBranchEnd property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> RegBranchEndChanging;
        
        /// <summary>
        /// Gets fired when the RegBranchEnd property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> RegBranchEndChanged;
        
        /// <summary>
        /// Gets fired before the VRegLineLine property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> VRegLineLineChanging;
        
        /// <summary>
        /// Gets fired when the VRegLineLine property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> VRegLineLineChanged;
        
        /// <summary>
        /// Gets fired before the SwitchOperationCycle property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> SwitchOperationCycleChanging;
        
        /// <summary>
        /// Gets fired when the SwitchOperationCycle property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> SwitchOperationCycleChanged;
        
        /// <summary>
        /// Gets fired before the LocalOffLevel property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LocalOffLevelChanging;
        
        /// <summary>
        /// Gets fired when the LocalOffLevel property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LocalOffLevelChanged;
        
        /// <summary>
        /// Gets fired before the SensingPhaseCode property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> SensingPhaseCodeChanging;
        
        /// <summary>
        /// Gets fired when the SensingPhaseCode property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> SensingPhaseCodeChanged;
        
        /// <summary>
        /// Gets fired before the LocalControlKind property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LocalControlKindChanging;
        
        /// <summary>
        /// Gets fired when the LocalControlKind property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LocalControlKindChanged;
        
        /// <summary>
        /// Gets fired before the BranchDirect property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> BranchDirectChanging;
        
        /// <summary>
        /// Gets fired when the BranchDirect property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> BranchDirectChanged;
        
        /// <summary>
        /// Gets fired before the MaxSwitchOperationCount property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> MaxSwitchOperationCountChanging;
        
        /// <summary>
        /// Gets fired when the MaxSwitchOperationCount property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> MaxSwitchOperationCountChanged;
        
        /// <summary>
        /// Gets fired before the LocalOverride property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LocalOverrideChanging;
        
        /// <summary>
        /// Gets fired when the LocalOverride property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LocalOverrideChanged;
        
        /// <summary>
        /// Gets fired before the LocalOnLevel property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LocalOnLevelChanging;
        
        /// <summary>
        /// Gets fired when the LocalOnLevel property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LocalOnLevelChanged;
        
        /// <summary>
        /// Gets fired before the RegBranch property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> RegBranchChanging;
        
        /// <summary>
        /// Gets fired when the RegBranch property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> RegBranchChanged;
        
        /// <summary>
        /// Gets fired before the ControlKind property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ControlKindChanging;
        
        /// <summary>
        /// Gets fired when the ControlKind property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ControlKindChanged;
    }
}

