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
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.EnergyScheduling;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.Financial;
using TTC2017.SmartGrids.CIM.IEC61970.Meas;

namespace TTC2017.SmartGrids.CIM.IEC61970.Informative.Reservation
{
    
    
    /// <summary>
    /// The public interface for ServiceReservation
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(ServiceReservation))]
    [XmlDefaultImplementationTypeAttribute(typeof(ServiceReservation))]
    public interface IServiceReservation : IModelElement, IElement
    {
        
        /// <summary>
        /// The Holds property
        /// </summary>
        IMarketer Holds
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Reserves_TransmissionService property
        /// </summary>
        IOrderedSetExpression<ITransmissionService> Reserves_TransmissionService
        {
            get;
        }
        
        /// <summary>
        /// The Reserves_AncillaryServices property
        /// </summary>
        IOrderedSetExpression<IAncillaryService> Reserves_AncillaryServices
        {
            get;
        }
        
        /// <summary>
        /// The Resells property
        /// </summary>
        IMarketer Resells
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Sells property
        /// </summary>
        ITransmissionProvider Sells
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the Holds property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> HoldsChanging;
        
        /// <summary>
        /// Gets fired when the Holds property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> HoldsChanged;
        
        /// <summary>
        /// Gets fired before the Resells property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ResellsChanging;
        
        /// <summary>
        /// Gets fired when the Resells property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ResellsChanged;
        
        /// <summary>
        /// Gets fired before the Sells property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> SellsChanging;
        
        /// <summary>
        /// Gets fired when the Sells property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> SellsChanged;
    }
}

