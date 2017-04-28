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
using TTC2017.SmartGrids.CIM.IEC61970.Core;

namespace TTC2017.SmartGrids.CIM.IEC61970.OperationalLimits
{
    
    
    /// <summary>
    /// The public interface for OperationalLimitSet
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(OperationalLimitSet))]
    [XmlDefaultImplementationTypeAttribute(typeof(OperationalLimitSet))]
    public interface IOperationalLimitSet : IModelElement, IIdentifiedObject
    {
        
        /// <summary>
        /// The OperationalLimitValue property
        /// </summary>
        IOrderedSetExpression<IOperationalLimit> OperationalLimitValue
        {
            get;
        }
        
        /// <summary>
        /// The Terminal property
        /// </summary>
        ITerminal Terminal
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Equipment property
        /// </summary>
        IEquipment Equipment
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the Terminal property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TerminalChanging;
        
        /// <summary>
        /// Gets fired when the Terminal property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TerminalChanged;
        
        /// <summary>
        /// Gets fired before the Equipment property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> EquipmentChanging;
        
        /// <summary>
        /// Gets fired when the Equipment property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> EquipmentChanged;
    }
}

