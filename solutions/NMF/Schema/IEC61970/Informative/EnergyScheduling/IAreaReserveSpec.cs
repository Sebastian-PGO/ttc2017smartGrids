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
using TTC2017.SmartGrids.CIM.IEC61970.ControlArea;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Generation.Production;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.Financial;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.MarketOperations;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.Reservation;
using TTC2017.SmartGrids.CIM.IEC61970.Meas;
using TTC2017.SmartGrids.CIM.IEC61970.Wires;

namespace TTC2017.SmartGrids.CIM.IEC61970.Informative.EnergyScheduling
{
    
    
    /// <summary>
    /// The public interface for AreaReserveSpec
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(AreaReserveSpec))]
    [XmlDefaultImplementationTypeAttribute(typeof(AreaReserveSpec))]
    public interface IAreaReserveSpec : IModelElement, IElement
    {
        
        /// <summary>
        /// The raiseRegMarginReqt property
        /// </summary>
        float RaiseRegMarginReqt
        {
            get;
            set;
        }
        
        /// <summary>
        /// The areaReserveSpecName property
        /// </summary>
        string AreaReserveSpecName
        {
            get;
            set;
        }
        
        /// <summary>
        /// The opReserveReqt property
        /// </summary>
        float OpReserveReqt
        {
            get;
            set;
        }
        
        /// <summary>
        /// The lowerRegMarginReqt property
        /// </summary>
        float LowerRegMarginReqt
        {
            get;
            set;
        }
        
        /// <summary>
        /// The primaryReserveReqt property
        /// </summary>
        float PrimaryReserveReqt
        {
            get;
            set;
        }
        
        /// <summary>
        /// The spinningReserveReqt property
        /// </summary>
        float SpinningReserveReqt
        {
            get;
            set;
        }
        
        /// <summary>
        /// The ReserveEnergyTransaction property
        /// </summary>
        IReserve ReserveEnergyTransaction
        {
            get;
            set;
        }
        
        /// <summary>
        /// The HostControlAreas property
        /// </summary>
        IOrderedSetExpression<IHostControlArea> HostControlAreas
        {
            get;
        }
        
        /// <summary>
        /// Gets fired before the RaiseRegMarginReqt property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> RaiseRegMarginReqtChanging;
        
        /// <summary>
        /// Gets fired when the RaiseRegMarginReqt property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> RaiseRegMarginReqtChanged;
        
        /// <summary>
        /// Gets fired before the AreaReserveSpecName property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AreaReserveSpecNameChanging;
        
        /// <summary>
        /// Gets fired when the AreaReserveSpecName property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AreaReserveSpecNameChanged;
        
        /// <summary>
        /// Gets fired before the OpReserveReqt property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> OpReserveReqtChanging;
        
        /// <summary>
        /// Gets fired when the OpReserveReqt property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> OpReserveReqtChanged;
        
        /// <summary>
        /// Gets fired before the LowerRegMarginReqt property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LowerRegMarginReqtChanging;
        
        /// <summary>
        /// Gets fired when the LowerRegMarginReqt property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LowerRegMarginReqtChanged;
        
        /// <summary>
        /// Gets fired before the PrimaryReserveReqt property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PrimaryReserveReqtChanging;
        
        /// <summary>
        /// Gets fired when the PrimaryReserveReqt property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PrimaryReserveReqtChanged;
        
        /// <summary>
        /// Gets fired before the SpinningReserveReqt property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> SpinningReserveReqtChanging;
        
        /// <summary>
        /// Gets fired when the SpinningReserveReqt property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> SpinningReserveReqtChanged;
        
        /// <summary>
        /// Gets fired before the ReserveEnergyTransaction property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ReserveEnergyTransactionChanging;
        
        /// <summary>
        /// Gets fired when the ReserveEnergyTransaction property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ReserveEnergyTransactionChanged;
    }
}

