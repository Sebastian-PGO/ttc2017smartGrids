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
    /// The public interface for ElectricalAsset
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(ElectricalAsset))]
    [XmlDefaultImplementationTypeAttribute(typeof(ElectricalAsset))]
    public interface IElectricalAsset : IModelElement, IAsset
    {
        
        /// <summary>
        /// The phaseCode property
        /// </summary>
        Nullable<PhaseCode> PhaseCode
        {
            get;
            set;
        }
        
        /// <summary>
        /// The isConnected property
        /// </summary>
        bool IsConnected
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
        /// The ElectricalInfos property
        /// </summary>
        IOrderedSetExpression<IElectricalInfo> ElectricalInfos
        {
            get;
        }
        
        /// <summary>
        /// Gets fired before the PhaseCode property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PhaseCodeChanging;
        
        /// <summary>
        /// Gets fired when the PhaseCode property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PhaseCodeChanged;
        
        /// <summary>
        /// Gets fired before the IsConnected property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> IsConnectedChanging;
        
        /// <summary>
        /// Gets fired when the IsConnected property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> IsConnectedChanged;
        
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

