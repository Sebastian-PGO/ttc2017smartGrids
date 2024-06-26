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
using TTC2017.SmartGrids.CIM.IEC61970.ControlArea;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Generation.GenerationDynamics;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.EnergyScheduling;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.Financial;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.MarketOperations;
using TTC2017.SmartGrids.CIM.IEC61970.Wires;

namespace TTC2017.SmartGrids.CIM.IEC61970.Generation.Production
{
    
    
    /// <summary>
    /// The public interface for CogenerationPlant
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(CogenerationPlant))]
    [XmlDefaultImplementationTypeAttribute(typeof(CogenerationPlant))]
    public interface ICogenerationPlant : IModelElement, IPowerSystemResource
    {
        
        /// <summary>
        /// The cogenLPSteamRating property
        /// </summary>
        float CogenLPSteamRating
        {
            get;
            set;
        }
        
        /// <summary>
        /// The cogenHPSteamRating property
        /// </summary>
        float CogenHPSteamRating
        {
            get;
            set;
        }
        
        /// <summary>
        /// The cogenHPSendoutRating property
        /// </summary>
        float CogenHPSendoutRating
        {
            get;
            set;
        }
        
        /// <summary>
        /// The cogenLPSendoutRating property
        /// </summary>
        float CogenLPSendoutRating
        {
            get;
            set;
        }
        
        /// <summary>
        /// The ratedP property
        /// </summary>
        float RatedP
        {
            get;
            set;
        }
        
        /// <summary>
        /// The SteamSendoutSchedule property
        /// </summary>
        ISteamSendoutSchedule SteamSendoutSchedule
        {
            get;
            set;
        }
        
        /// <summary>
        /// The ThermalGeneratingUnits property
        /// </summary>
        IOrderedSetExpression<IThermalGeneratingUnit> ThermalGeneratingUnits
        {
            get;
        }
        
        /// <summary>
        /// Gets fired before the CogenLPSteamRating property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CogenLPSteamRatingChanging;
        
        /// <summary>
        /// Gets fired when the CogenLPSteamRating property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CogenLPSteamRatingChanged;
        
        /// <summary>
        /// Gets fired before the CogenHPSteamRating property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CogenHPSteamRatingChanging;
        
        /// <summary>
        /// Gets fired when the CogenHPSteamRating property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CogenHPSteamRatingChanged;
        
        /// <summary>
        /// Gets fired before the CogenHPSendoutRating property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CogenHPSendoutRatingChanging;
        
        /// <summary>
        /// Gets fired when the CogenHPSendoutRating property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CogenHPSendoutRatingChanged;
        
        /// <summary>
        /// Gets fired before the CogenLPSendoutRating property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CogenLPSendoutRatingChanging;
        
        /// <summary>
        /// Gets fired when the CogenLPSendoutRating property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CogenLPSendoutRatingChanged;
        
        /// <summary>
        /// Gets fired before the RatedP property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> RatedPChanging;
        
        /// <summary>
        /// Gets fired when the RatedP property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> RatedPChanged;
        
        /// <summary>
        /// Gets fired before the SteamSendoutSchedule property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> SteamSendoutScheduleChanging;
        
        /// <summary>
        /// Gets fired when the SteamSendoutSchedule property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> SteamSendoutScheduleChanged;
    }
}

