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

namespace TTC2017.SmartGrids.SubstationStandard.LNNodes.LNGroupT
{
    
    
    /// <summary>
    /// The public interface for GroupT
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(GroupT))]
    [XmlDefaultImplementationTypeAttribute(typeof(GroupT))]
    public interface IGroupT : IModelElement, IDomainLN
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
        /// The OpTmh property
        /// </summary>
        IINS OpTmh
        {
            get;
            set;
        }
        
        /// <summary>
        /// The HzRtg property
        /// </summary>
        IASG HzRtg
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Rat property
        /// </summary>
        IASG Rat
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Cor property
        /// </summary>
        IASG Cor
        {
            get;
            set;
        }
        
        /// <summary>
        /// The AngCor property
        /// </summary>
        IASG AngCor
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
        
        /// <summary>
        /// Gets fired before the OpTmh property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> OpTmhChanging;
        
        /// <summary>
        /// Gets fired when the OpTmh property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> OpTmhChanged;
        
        /// <summary>
        /// Gets fired before the HzRtg property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> HzRtgChanging;
        
        /// <summary>
        /// Gets fired when the HzRtg property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> HzRtgChanged;
        
        /// <summary>
        /// Gets fired before the Rat property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> RatChanging;
        
        /// <summary>
        /// Gets fired when the Rat property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> RatChanged;
        
        /// <summary>
        /// Gets fired before the Cor property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CorChanging;
        
        /// <summary>
        /// Gets fired when the Cor property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CorChanged;
        
        /// <summary>
        /// Gets fired before the AngCor property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AngCorChanging;
        
        /// <summary>
        /// Gets fired when the AngCor property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AngCorChanged;
    }
}

