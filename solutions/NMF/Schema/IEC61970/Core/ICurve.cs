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
using TTC2017.SmartGrids.CIM.IEC61968.Assets;
using TTC2017.SmartGrids.CIM.IEC61968.Common;
using TTC2017.SmartGrids.CIM.IEC61968.Customers;
using TTC2017.SmartGrids.CIM.IEC61970.Contingency;
using TTC2017.SmartGrids.CIM.IEC61970.ControlArea;
using TTC2017.SmartGrids.CIM.IEC61970.Domain;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssets;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfCommon;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfCore;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfOperations;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.MarketOperations;
using TTC2017.SmartGrids.CIM.IEC61970.Meas;
using TTC2017.SmartGrids.CIM.IEC61970.OperationalLimits;
using TTC2017.SmartGrids.CIM.IEC61970.Outage;
using TTC2017.SmartGrids.CIM.IEC61970.Protection;
using TTC2017.SmartGrids.CIM.IEC61970.StateVariables;
using TTC2017.SmartGrids.CIM.IEC61970.Topology;
using TTC2017.SmartGrids.CIM.IEC61970.Wires;

namespace TTC2017.SmartGrids.CIM.IEC61970.Core
{
    
    
    /// <summary>
    /// The public interface for Curve
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(Curve))]
    [XmlDefaultImplementationTypeAttribute(typeof(Curve))]
    public interface ICurve : IModelElement, IIdentifiedObject
    {
        
        /// <summary>
        /// The y2Unit property
        /// </summary>
        Nullable<UnitSymbol> Y2Unit
        {
            get;
            set;
        }
        
        /// <summary>
        /// The xMultiplier property
        /// </summary>
        Nullable<UnitMultiplier> XMultiplier
        {
            get;
            set;
        }
        
        /// <summary>
        /// The y3Multiplier property
        /// </summary>
        Nullable<UnitMultiplier> Y3Multiplier
        {
            get;
            set;
        }
        
        /// <summary>
        /// The y1Unit property
        /// </summary>
        Nullable<UnitSymbol> Y1Unit
        {
            get;
            set;
        }
        
        /// <summary>
        /// The curveStyle property
        /// </summary>
        Nullable<CurveStyle> CurveStyle
        {
            get;
            set;
        }
        
        /// <summary>
        /// The y3Unit property
        /// </summary>
        Nullable<UnitSymbol> Y3Unit
        {
            get;
            set;
        }
        
        /// <summary>
        /// The xUnit property
        /// </summary>
        Nullable<UnitSymbol> XUnit
        {
            get;
            set;
        }
        
        /// <summary>
        /// The y2Multiplier property
        /// </summary>
        Nullable<UnitMultiplier> Y2Multiplier
        {
            get;
            set;
        }
        
        /// <summary>
        /// The y1Multiplier property
        /// </summary>
        Nullable<UnitMultiplier> Y1Multiplier
        {
            get;
            set;
        }
        
        /// <summary>
        /// The CurveDatas property
        /// </summary>
        IOrderedSetExpression<ICurveData> CurveDatas
        {
            get;
        }
        
        /// <summary>
        /// Gets fired before the Y2Unit property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Y2UnitChanging;
        
        /// <summary>
        /// Gets fired when the Y2Unit property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Y2UnitChanged;
        
        /// <summary>
        /// Gets fired before the XMultiplier property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> XMultiplierChanging;
        
        /// <summary>
        /// Gets fired when the XMultiplier property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> XMultiplierChanged;
        
        /// <summary>
        /// Gets fired before the Y3Multiplier property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Y3MultiplierChanging;
        
        /// <summary>
        /// Gets fired when the Y3Multiplier property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Y3MultiplierChanged;
        
        /// <summary>
        /// Gets fired before the Y1Unit property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Y1UnitChanging;
        
        /// <summary>
        /// Gets fired when the Y1Unit property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Y1UnitChanged;
        
        /// <summary>
        /// Gets fired before the CurveStyle property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CurveStyleChanging;
        
        /// <summary>
        /// Gets fired when the CurveStyle property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CurveStyleChanged;
        
        /// <summary>
        /// Gets fired before the Y3Unit property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Y3UnitChanging;
        
        /// <summary>
        /// Gets fired when the Y3Unit property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Y3UnitChanged;
        
        /// <summary>
        /// Gets fired before the XUnit property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> XUnitChanging;
        
        /// <summary>
        /// Gets fired when the XUnit property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> XUnitChanged;
        
        /// <summary>
        /// Gets fired before the Y2Multiplier property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Y2MultiplierChanging;
        
        /// <summary>
        /// Gets fired when the Y2Multiplier property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Y2MultiplierChanged;
        
        /// <summary>
        /// Gets fired before the Y1Multiplier property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Y1MultiplierChanging;
        
        /// <summary>
        /// Gets fired when the Y1Multiplier property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Y1MultiplierChanged;
    }
}

