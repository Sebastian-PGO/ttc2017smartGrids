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
using TTC2017.SmartGrids.CIM.IEC61968.Assets;
using TTC2017.SmartGrids.CIM.IEC61968.Common;
using TTC2017.SmartGrids.CIM.IEC61970.ControlArea;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.EnergyScheduling;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssets;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfERPSupport;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfGMLSupport;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.MarketOperations;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.Reservation;
using TTC2017.SmartGrids.CIM.IEC61970.SCADA;
using TTC2017.SmartGrids.CIM.IEC61970.Wires;

namespace TTC2017.SmartGrids.CIM.IEC61970.Meas
{
    
    
    /// <summary>
    /// The public interface for Measurement
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(Measurement))]
    [XmlDefaultImplementationTypeAttribute(typeof(Measurement))]
    public interface IMeasurement : IModelElement, IIdentifiedObject
    {
        
        /// <summary>
        /// The measurementType property
        /// </summary>
        string MeasurementType
        {
            get;
            set;
        }
        
        /// <summary>
        /// The By_TiePoint property
        /// </summary>
        ITiePoint By_TiePoint
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Terminal property
        /// </summary>
        ITerminal Terminal
        {
            get;
            set;
        }
        
        /// <summary>
        /// The DynamicSchedules property
        /// </summary>
        IOrderedSetExpression<IDynamicSchedule> DynamicSchedules
        {
            get;
        }
        
        /// <summary>
        /// The Locations property
        /// </summary>
        IOrderedSetExpression<ILocation> Locations
        {
            get;
        }
        
        /// <summary>
        /// The Asset property
        /// </summary>
        IAsset Asset
        {
            get;
            set;
        }
        
        /// <summary>
        /// The ViolationLimits property
        /// </summary>
        IOrderedSetExpression<IViolationLimit> ViolationLimits
        {
            get;
        }
        
        /// <summary>
        /// The Documents property
        /// </summary>
        IOrderedSetExpression<IDocument> Documents
        {
            get;
        }
        
        /// <summary>
        /// The Pnode property
        /// </summary>
        IPnode Pnode
        {
            get;
            set;
        }
        
        /// <summary>
        /// The PowerSystemResource property
        /// </summary>
        IPowerSystemResource PowerSystemResource
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Unit property
        /// </summary>
        IUnit Unit
        {
            get;
            set;
        }
        
        /// <summary>
        /// The For_TiePoint property
        /// </summary>
        ITiePoint For_TiePoint
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the MeasurementType property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> MeasurementTypeChanging;
        
        /// <summary>
        /// Gets fired when the MeasurementType property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> MeasurementTypeChanged;
        
        /// <summary>
        /// Gets fired before the By_TiePoint property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> By_TiePointChanging;
        
        /// <summary>
        /// Gets fired when the By_TiePoint property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> By_TiePointChanged;
        
        /// <summary>
        /// Gets fired before the Terminal property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TerminalChanging;
        
        /// <summary>
        /// Gets fired when the Terminal property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TerminalChanged;
        
        /// <summary>
        /// Gets fired before the Asset property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AssetChanging;
        
        /// <summary>
        /// Gets fired when the Asset property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AssetChanged;
        
        /// <summary>
        /// Gets fired before the Pnode property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PnodeChanging;
        
        /// <summary>
        /// Gets fired when the Pnode property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PnodeChanged;
        
        /// <summary>
        /// Gets fired before the PowerSystemResource property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PowerSystemResourceChanging;
        
        /// <summary>
        /// Gets fired when the PowerSystemResource property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PowerSystemResourceChanged;
        
        /// <summary>
        /// Gets fired before the Unit property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> UnitChanging;
        
        /// <summary>
        /// Gets fired when the Unit property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> UnitChanged;
        
        /// <summary>
        /// Gets fired before the For_TiePoint property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> For_TiePointChanging;
        
        /// <summary>
        /// Gets fired when the For_TiePoint property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> For_TiePointChanged;
    }
}

