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
using TTC2017.SmartGrids.SubstationStandard.Dataclasses;
using TTC2017.SmartGrids.SubstationStandard.Enumerations;
using TTC2017.SmartGrids.SubstationStandard.LNNodes.DomainLNs;
using TTC2017.SmartGrids.SubstationStandard.LNNodes.LNGroupA;

namespace TTC2017.SmartGrids.SubstationStandard.LNNodes.LNGroupY
{
    
    
    /// <summary>
    /// The public interface for GroupY
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(GroupY))]
    [XmlDefaultImplementationTypeAttribute(typeof(GroupY))]
    public interface IGroupY : IModelElement, IDomainLN
    {
        
        /// <summary>
        /// The EEHealth property
        /// </summary>
        Nullable<HealthStateKind> EEHealth
        {
            get;
            set;
        }
        
        /// <summary>
        /// The EEName property
        /// </summary>
        IDPL EEName
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the EEHealth property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> EEHealthChanging;
        
        /// <summary>
        /// Gets fired when the EEHealth property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> EEHealthChanged;
        
        /// <summary>
        /// Gets fired before the EEName property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> EENameChanging;
        
        /// <summary>
        /// Gets fired when the EEName property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> EENameChanged;
    }
}

