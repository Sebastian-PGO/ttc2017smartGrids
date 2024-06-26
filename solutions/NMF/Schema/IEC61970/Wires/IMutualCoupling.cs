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
using TTC2017.SmartGrids.CIM.IEC61968.LoadControl;
using TTC2017.SmartGrids.CIM.IEC61968.Metering;
using TTC2017.SmartGrids.CIM.IEC61968.WiresExt;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Generation.GenerationDynamics;
using TTC2017.SmartGrids.CIM.IEC61970.Generation.Production;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.EnergyScheduling;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssets;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfLoadControl;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.MarketOperations;
using TTC2017.SmartGrids.CIM.IEC61970.LoadModel;
using TTC2017.SmartGrids.CIM.IEC61970.Meas;
using TTC2017.SmartGrids.CIM.IEC61970.Outage;
using TTC2017.SmartGrids.CIM.IEC61970.Protection;
using TTC2017.SmartGrids.CIM.IEC61970.StateVariables;

namespace TTC2017.SmartGrids.CIM.IEC61970.Wires
{
    
    
    /// <summary>
    /// The public interface for MutualCoupling
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(MutualCoupling))]
    [XmlDefaultImplementationTypeAttribute(typeof(MutualCoupling))]
    public interface IMutualCoupling : IModelElement, IIdentifiedObject
    {
        
        /// <summary>
        /// The distance11 property
        /// </summary>
        float Distance11
        {
            get;
            set;
        }
        
        /// <summary>
        /// The distance12 property
        /// </summary>
        float Distance12
        {
            get;
            set;
        }
        
        /// <summary>
        /// The b0ch property
        /// </summary>
        float B0ch
        {
            get;
            set;
        }
        
        /// <summary>
        /// The g0ch property
        /// </summary>
        float G0ch
        {
            get;
            set;
        }
        
        /// <summary>
        /// The x0 property
        /// </summary>
        float X0
        {
            get;
            set;
        }
        
        /// <summary>
        /// The r0 property
        /// </summary>
        float R0
        {
            get;
            set;
        }
        
        /// <summary>
        /// The distance22 property
        /// </summary>
        float Distance22
        {
            get;
            set;
        }
        
        /// <summary>
        /// The distance21 property
        /// </summary>
        float Distance21
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Second_Terminal property
        /// </summary>
        ITerminal Second_Terminal
        {
            get;
            set;
        }
        
        /// <summary>
        /// The First_Terminal property
        /// </summary>
        ITerminal First_Terminal
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the Distance11 property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Distance11Changing;
        
        /// <summary>
        /// Gets fired when the Distance11 property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Distance11Changed;
        
        /// <summary>
        /// Gets fired before the Distance12 property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Distance12Changing;
        
        /// <summary>
        /// Gets fired when the Distance12 property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Distance12Changed;
        
        /// <summary>
        /// Gets fired before the B0ch property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> B0chChanging;
        
        /// <summary>
        /// Gets fired when the B0ch property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> B0chChanged;
        
        /// <summary>
        /// Gets fired before the G0ch property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> G0chChanging;
        
        /// <summary>
        /// Gets fired when the G0ch property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> G0chChanged;
        
        /// <summary>
        /// Gets fired before the X0 property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> X0Changing;
        
        /// <summary>
        /// Gets fired when the X0 property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> X0Changed;
        
        /// <summary>
        /// Gets fired before the R0 property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> R0Changing;
        
        /// <summary>
        /// Gets fired when the R0 property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> R0Changed;
        
        /// <summary>
        /// Gets fired before the Distance22 property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Distance22Changing;
        
        /// <summary>
        /// Gets fired when the Distance22 property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Distance22Changed;
        
        /// <summary>
        /// Gets fired before the Distance21 property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Distance21Changing;
        
        /// <summary>
        /// Gets fired when the Distance21 property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Distance21Changed;
        
        /// <summary>
        /// Gets fired before the Second_Terminal property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Second_TerminalChanging;
        
        /// <summary>
        /// Gets fired when the Second_Terminal property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Second_TerminalChanged;
        
        /// <summary>
        /// Gets fired before the First_Terminal property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> First_TerminalChanging;
        
        /// <summary>
        /// Gets fired when the First_Terminal property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> First_TerminalChanged;
    }
}

