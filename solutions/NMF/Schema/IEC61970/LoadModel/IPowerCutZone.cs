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
using TTC2017.SmartGrids.CIM.IEC61970.ControlArea;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.MarketOperations;
using TTC2017.SmartGrids.CIM.IEC61970.Wires;

namespace TTC2017.SmartGrids.CIM.IEC61970.LoadModel
{
    
    
    /// <summary>
    /// The public interface for PowerCutZone
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(PowerCutZone))]
    [XmlDefaultImplementationTypeAttribute(typeof(PowerCutZone))]
    public interface IPowerCutZone : IModelElement, IPowerSystemResource
    {
        
        /// <summary>
        /// The cutLevel1 property
        /// </summary>
        float CutLevel1
        {
            get;
            set;
        }
        
        /// <summary>
        /// The cutLevel2 property
        /// </summary>
        float CutLevel2
        {
            get;
            set;
        }
        
        /// <summary>
        /// The EnergyConsumers property
        /// </summary>
        IOrderedSetExpression<IEnergyConsumer> EnergyConsumers
        {
            get;
        }
        
        /// <summary>
        /// Gets fired before the CutLevel1 property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CutLevel1Changing;
        
        /// <summary>
        /// Gets fired when the CutLevel1 property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CutLevel1Changed;
        
        /// <summary>
        /// Gets fired before the CutLevel2 property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CutLevel2Changing;
        
        /// <summary>
        /// Gets fired when the CutLevel2 property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CutLevel2Changed;
    }
}

