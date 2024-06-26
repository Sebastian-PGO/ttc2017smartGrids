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
using TTC2017.SmartGrids.CIM.IEC61970.Contingency;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Generation.Production;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.EnergyScheduling;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.Financial;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfERPSupport;
using TTC2017.SmartGrids.CIM.IEC61970.LoadModel;
using TTC2017.SmartGrids.CIM.IEC61970.Meas;
using TTC2017.SmartGrids.CIM.IEC61970.Wires;

namespace TTC2017.SmartGrids.CIM.IEC61970.Informative.MarketOperations
{
    
    
    /// <summary>
    /// The public interface for TransmissionReliabilityMargin
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(TransmissionReliabilityMargin))]
    [XmlDefaultImplementationTypeAttribute(typeof(TransmissionReliabilityMargin))]
    public interface ITransmissionReliabilityMargin : IModelElement, IIdentifiedObject
    {
        
        /// <summary>
        /// The TrmType property
        /// </summary>
        string TrmType
        {
            get;
            set;
        }
        
        /// <summary>
        /// The valueUnit property
        /// </summary>
        string ValueUnit
        {
            get;
            set;
        }
        
        /// <summary>
        /// The trmValue property
        /// </summary>
        float TrmValue
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Flowgate property
        /// </summary>
        IOrderedSetExpression<IFlowgate> Flowgate
        {
            get;
        }
        
        /// <summary>
        /// Gets fired before the TrmType property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TrmTypeChanging;
        
        /// <summary>
        /// Gets fired when the TrmType property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TrmTypeChanged;
        
        /// <summary>
        /// Gets fired before the ValueUnit property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ValueUnitChanging;
        
        /// <summary>
        /// Gets fired when the ValueUnit property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ValueUnitChanged;
        
        /// <summary>
        /// Gets fired before the TrmValue property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TrmValueChanging;
        
        /// <summary>
        /// Gets fired when the TrmValue property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TrmValueChanged;
    }
}

