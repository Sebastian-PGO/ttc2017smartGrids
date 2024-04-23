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
    /// The public interface for FossilFuel
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(FossilFuel))]
    [XmlDefaultImplementationTypeAttribute(typeof(FossilFuel))]
    public interface IFossilFuel : IModelElement, IIdentifiedObject
    {
        
        /// <summary>
        /// The fuelEffFactor property
        /// </summary>
        float FuelEffFactor
        {
            get;
            set;
        }
        
        /// <summary>
        /// The fossilFuelType property
        /// </summary>
        Nullable<FuelType> FossilFuelType
        {
            get;
            set;
        }
        
        /// <summary>
        /// The fuelMixture property
        /// </summary>
        float FuelMixture
        {
            get;
            set;
        }
        
        /// <summary>
        /// The fuelCost property
        /// </summary>
        float FuelCost
        {
            get;
            set;
        }
        
        /// <summary>
        /// The lowBreakpointP property
        /// </summary>
        float LowBreakpointP
        {
            get;
            set;
        }
        
        /// <summary>
        /// The fuelHandlingCost property
        /// </summary>
        float FuelHandlingCost
        {
            get;
            set;
        }
        
        /// <summary>
        /// The fuelSulfur property
        /// </summary>
        float FuelSulfur
        {
            get;
            set;
        }
        
        /// <summary>
        /// The fuelHeatContent property
        /// </summary>
        float FuelHeatContent
        {
            get;
            set;
        }
        
        /// <summary>
        /// The highBreakpointP property
        /// </summary>
        float HighBreakpointP
        {
            get;
            set;
        }
        
        /// <summary>
        /// The fuelDispatchCost property
        /// </summary>
        float FuelDispatchCost
        {
            get;
            set;
        }
        
        /// <summary>
        /// The FuelAllocationSchedules property
        /// </summary>
        IOrderedSetExpression<IFuelAllocationSchedule> FuelAllocationSchedules
        {
            get;
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
        /// Gets fired before the FuelEffFactor property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FuelEffFactorChanging;
        
        /// <summary>
        /// Gets fired when the FuelEffFactor property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FuelEffFactorChanged;
        
        /// <summary>
        /// Gets fired before the FossilFuelType property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FossilFuelTypeChanging;
        
        /// <summary>
        /// Gets fired when the FossilFuelType property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FossilFuelTypeChanged;
        
        /// <summary>
        /// Gets fired before the FuelMixture property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FuelMixtureChanging;
        
        /// <summary>
        /// Gets fired when the FuelMixture property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FuelMixtureChanged;
        
        /// <summary>
        /// Gets fired before the FuelCost property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FuelCostChanging;
        
        /// <summary>
        /// Gets fired when the FuelCost property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FuelCostChanged;
        
        /// <summary>
        /// Gets fired before the LowBreakpointP property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LowBreakpointPChanging;
        
        /// <summary>
        /// Gets fired when the LowBreakpointP property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LowBreakpointPChanged;
        
        /// <summary>
        /// Gets fired before the FuelHandlingCost property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FuelHandlingCostChanging;
        
        /// <summary>
        /// Gets fired when the FuelHandlingCost property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FuelHandlingCostChanged;
        
        /// <summary>
        /// Gets fired before the FuelSulfur property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FuelSulfurChanging;
        
        /// <summary>
        /// Gets fired when the FuelSulfur property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FuelSulfurChanged;
        
        /// <summary>
        /// Gets fired before the FuelHeatContent property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FuelHeatContentChanging;
        
        /// <summary>
        /// Gets fired when the FuelHeatContent property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FuelHeatContentChanged;
        
        /// <summary>
        /// Gets fired before the HighBreakpointP property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> HighBreakpointPChanging;
        
        /// <summary>
        /// Gets fired when the HighBreakpointP property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> HighBreakpointPChanged;
        
        /// <summary>
        /// Gets fired before the FuelDispatchCost property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FuelDispatchCostChanging;
        
        /// <summary>
        /// Gets fired when the FuelDispatchCost property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FuelDispatchCostChanged;
        
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

