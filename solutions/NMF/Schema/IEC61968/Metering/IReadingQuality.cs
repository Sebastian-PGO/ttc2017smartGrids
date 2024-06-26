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
using TTC2017.SmartGrids.CIM.IEC61968.AssetModels;
using TTC2017.SmartGrids.CIM.IEC61968.Assets;
using TTC2017.SmartGrids.CIM.IEC61968.Common;
using TTC2017.SmartGrids.CIM.IEC61968.Customers;
using TTC2017.SmartGrids.CIM.IEC61968.PaymentMetering;
using TTC2017.SmartGrids.CIM.IEC61968.WiresExt;
using TTC2017.SmartGrids.CIM.IEC61968.Work;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Domain;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssetModels;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssets;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfCustomers;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfMetering;
using TTC2017.SmartGrids.CIM.IEC61970.Meas;
using TTC2017.SmartGrids.CIM.IEC61970.Wires;

namespace TTC2017.SmartGrids.CIM.IEC61968.Metering
{
    
    
    /// <summary>
    /// The public interface for ReadingQuality
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(ReadingQuality))]
    [XmlDefaultImplementationTypeAttribute(typeof(ReadingQuality))]
    public interface IReadingQuality : IModelElement, IElement
    {
        
        /// <summary>
        /// The quality property
        /// </summary>
        string Quality
        {
            get;
            set;
        }
        
        /// <summary>
        /// The IntervalReading property
        /// </summary>
        IIntervalReading IntervalReading
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Reading property
        /// </summary>
        IReading Reading
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the Quality property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> QualityChanging;
        
        /// <summary>
        /// Gets fired when the Quality property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> QualityChanged;
        
        /// <summary>
        /// Gets fired before the IntervalReading property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> IntervalReadingChanging;
        
        /// <summary>
        /// Gets fired when the IntervalReading property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> IntervalReadingChanged;
        
        /// <summary>
        /// Gets fired before the Reading property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ReadingChanging;
        
        /// <summary>
        /// Gets fired when the Reading property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ReadingChanged;
    }
}

