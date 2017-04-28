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
    /// The public interface for CurrentTransformer
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(CurrentTransformer))]
    [XmlDefaultImplementationTypeAttribute(typeof(CurrentTransformer))]
    public interface ICurrentTransformer : IModelElement, IEquipment
    {
        
        /// <summary>
        /// The maxRatio property
        /// </summary>
        float MaxRatio
        {
            get;
            set;
        }
        
        /// <summary>
        /// The coreCount property
        /// </summary>
        int CoreCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// The ctClass property
        /// </summary>
        string CtClass
        {
            get;
            set;
        }
        
        /// <summary>
        /// The usage property
        /// </summary>
        string Usage
        {
            get;
            set;
        }
        
        /// <summary>
        /// The accuracyLimit property
        /// </summary>
        string AccuracyLimit
        {
            get;
            set;
        }
        
        /// <summary>
        /// The accuracyClass property
        /// </summary>
        string AccuracyClass
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the MaxRatio property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> MaxRatioChanging;
        
        /// <summary>
        /// Gets fired when the MaxRatio property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> MaxRatioChanged;
        
        /// <summary>
        /// Gets fired before the CoreCount property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CoreCountChanging;
        
        /// <summary>
        /// Gets fired when the CoreCount property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CoreCountChanged;
        
        /// <summary>
        /// Gets fired before the CtClass property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CtClassChanging;
        
        /// <summary>
        /// Gets fired when the CtClass property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CtClassChanged;
        
        /// <summary>
        /// Gets fired before the Usage property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> UsageChanging;
        
        /// <summary>
        /// Gets fired when the Usage property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> UsageChanged;
        
        /// <summary>
        /// Gets fired before the AccuracyLimit property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AccuracyLimitChanging;
        
        /// <summary>
        /// Gets fired when the AccuracyLimit property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AccuracyLimitChanged;
        
        /// <summary>
        /// Gets fired before the AccuracyClass property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AccuracyClassChanging;
        
        /// <summary>
        /// Gets fired when the AccuracyClass property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AccuracyClassChanged;
    }
}

