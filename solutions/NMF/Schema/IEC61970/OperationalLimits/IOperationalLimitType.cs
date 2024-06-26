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
using TTC2017.SmartGrids.CIM.IEC61970.Core;

namespace TTC2017.SmartGrids.CIM.IEC61970.OperationalLimits
{
    
    
    /// <summary>
    /// The public interface for OperationalLimitType
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(OperationalLimitType))]
    [XmlDefaultImplementationTypeAttribute(typeof(OperationalLimitType))]
    public interface IOperationalLimitType : IModelElement, IIdentifiedObject
    {
        
        /// <summary>
        /// The acceptableDuration property
        /// </summary>
        float AcceptableDuration
        {
            get;
            set;
        }
        
        /// <summary>
        /// The direction property
        /// </summary>
        Nullable<OperationalLimitDirectionKind> Direction
        {
            get;
            set;
        }
        
        /// <summary>
        /// The OperationalLimit property
        /// </summary>
        IOrderedSetExpression<IOperationalLimit> OperationalLimit
        {
            get;
        }
        
        /// <summary>
        /// Gets fired before the AcceptableDuration property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AcceptableDurationChanging;
        
        /// <summary>
        /// Gets fired when the AcceptableDuration property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AcceptableDurationChanged;
        
        /// <summary>
        /// Gets fired before the Direction property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DirectionChanging;
        
        /// <summary>
        /// Gets fired when the Direction property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DirectionChanged;
    }
}

