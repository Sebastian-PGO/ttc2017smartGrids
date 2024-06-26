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
    /// The public interface for EmissionAccount
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(EmissionAccount))]
    [XmlDefaultImplementationTypeAttribute(typeof(EmissionAccount))]
    public interface IEmissionAccount : IModelElement, ICurve
    {
        
        /// <summary>
        /// The emissionValueSource property
        /// </summary>
        Nullable<EmissionValueSource> EmissionValueSource
        {
            get;
            set;
        }
        
        /// <summary>
        /// The emissionType property
        /// </summary>
        Nullable<EmissionType> EmissionType
        {
            get;
            set;
        }
        
        /// <summary>
        /// The ThermalGeneratingUnit property
        /// </summary>
        IThermalGeneratingUnit ThermalGeneratingUnit
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the EmissionValueSource property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> EmissionValueSourceChanging;
        
        /// <summary>
        /// Gets fired when the EmissionValueSource property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> EmissionValueSourceChanged;
        
        /// <summary>
        /// Gets fired before the EmissionType property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> EmissionTypeChanging;
        
        /// <summary>
        /// Gets fired when the EmissionType property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> EmissionTypeChanged;
        
        /// <summary>
        /// Gets fired before the ThermalGeneratingUnit property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ThermalGeneratingUnitChanging;
        
        /// <summary>
        /// Gets fired when the ThermalGeneratingUnit property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ThermalGeneratingUnitChanged;
    }
}

