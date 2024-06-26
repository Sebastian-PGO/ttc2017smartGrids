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
    /// The public interface for ConstraintTerm
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(ConstraintTerm))]
    [XmlDefaultImplementationTypeAttribute(typeof(ConstraintTerm))]
    public interface IConstraintTerm : IModelElement, IIdentifiedObject
    {
        
        /// <summary>
        /// The factor property
        /// </summary>
        string Factor
        {
            get;
            set;
        }
        
        /// <summary>
        /// The function property
        /// </summary>
        string Function
        {
            get;
            set;
        }
        
        /// <summary>
        /// The SecurityConstraintSum property
        /// </summary>
        ISecurityConstraintSum SecurityConstraintSum
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the Factor property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FactorChanging;
        
        /// <summary>
        /// Gets fired when the Factor property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FactorChanged;
        
        /// <summary>
        /// Gets fired before the Function property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FunctionChanging;
        
        /// <summary>
        /// Gets fired when the Function property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FunctionChanged;
        
        /// <summary>
        /// Gets fired before the SecurityConstraintSum property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> SecurityConstraintSumChanging;
        
        /// <summary>
        /// Gets fired when the SecurityConstraintSum property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> SecurityConstraintSumChanged;
    }
}

