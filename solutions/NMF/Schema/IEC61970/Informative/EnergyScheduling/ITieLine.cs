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
    /// The public interface for TieLine
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(TieLine))]
    [XmlDefaultImplementationTypeAttribute(typeof(TieLine))]
    public interface ITieLine : IModelElement, IElement
    {
        
        /// <summary>
        /// The DynamicEnergyTransaction property
        /// </summary>
        IDynamic DynamicEnergyTransaction
        {
            get;
            set;
        }
        
        /// <summary>
        /// The CustomerConsumer property
        /// </summary>
        ICustomerConsumer CustomerConsumer
        {
            get;
            set;
        }
        
        /// <summary>
        /// The SideA_SubControlArea property
        /// </summary>
        ISubControlArea SideA_SubControlArea
        {
            get;
            set;
        }
        
        /// <summary>
        /// The SideB_HostControlArea property
        /// </summary>
        IHostControlArea SideB_HostControlArea
        {
            get;
            set;
        }
        
        /// <summary>
        /// The SideB_SubControlArea property
        /// </summary>
        ISubControlArea SideB_SubControlArea
        {
            get;
            set;
        }
        
        /// <summary>
        /// The SideA_HostControlArea property
        /// </summary>
        IHostControlArea SideA_HostControlArea
        {
            get;
            set;
        }
        
        /// <summary>
        /// The ControlAreaOperators property
        /// </summary>
        IOrderedSetExpression<IControlAreaOperator> ControlAreaOperators
        {
            get;
        }
        
        /// <summary>
        /// Gets fired before the DynamicEnergyTransaction property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DynamicEnergyTransactionChanging;
        
        /// <summary>
        /// Gets fired when the DynamicEnergyTransaction property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DynamicEnergyTransactionChanged;
        
        /// <summary>
        /// Gets fired before the CustomerConsumer property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CustomerConsumerChanging;
        
        /// <summary>
        /// Gets fired when the CustomerConsumer property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CustomerConsumerChanged;
        
        /// <summary>
        /// Gets fired before the SideA_SubControlArea property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> SideA_SubControlAreaChanging;
        
        /// <summary>
        /// Gets fired when the SideA_SubControlArea property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> SideA_SubControlAreaChanged;
        
        /// <summary>
        /// Gets fired before the SideB_HostControlArea property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> SideB_HostControlAreaChanging;
        
        /// <summary>
        /// Gets fired when the SideB_HostControlArea property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> SideB_HostControlAreaChanged;
        
        /// <summary>
        /// Gets fired before the SideB_SubControlArea property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> SideB_SubControlAreaChanging;
        
        /// <summary>
        /// Gets fired when the SideB_SubControlArea property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> SideB_SubControlAreaChanged;
        
        /// <summary>
        /// Gets fired before the SideA_HostControlArea property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> SideA_HostControlAreaChanging;
        
        /// <summary>
        /// Gets fired when the SideA_HostControlArea property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> SideA_HostControlAreaChanged;
    }
}

