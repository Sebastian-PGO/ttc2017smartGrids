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
    /// The public interface for HydroGeneratingEfficiencyCurve
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(HydroGeneratingEfficiencyCurve))]
    [XmlDefaultImplementationTypeAttribute(typeof(HydroGeneratingEfficiencyCurve))]
    public interface IHydroGeneratingEfficiencyCurve : IModelElement, ICurve
    {
        
        /// <summary>
        /// The HydroGeneratingUnit property
        /// </summary>
        IHydroGeneratingUnit HydroGeneratingUnit
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the HydroGeneratingUnit property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> HydroGeneratingUnitChanging;
        
        /// <summary>
        /// Gets fired when the HydroGeneratingUnit property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> HydroGeneratingUnitChanged;
    }
}

