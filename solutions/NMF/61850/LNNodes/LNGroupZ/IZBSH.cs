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

namespace TTC2017.SmartGrids.SubstationStandard.LNNodes.LNGroupZ
{
    
    
    /// <summary>
    /// The public interface for ZBSH
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(ZBSH))]
    [XmlDefaultImplementationTypeAttribute(typeof(ZBSH))]
    public interface IZBSH : IModelElement, IGroupZ
    {
        
        /// <summary>
        /// The OpTmh property
        /// </summary>
        IINS OpTmh
        {
            get;
            set;
        }
        
        /// <summary>
        /// The React property
        /// </summary>
        IMV React
        {
            get;
            set;
        }
        
        /// <summary>
        /// The LosFact property
        /// </summary>
        IMV LosFact
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Vol property
        /// </summary>
        IMV Vol
        {
            get;
            set;
        }
        
        /// <summary>
        /// The RefReact property
        /// </summary>
        IASG RefReact
        {
            get;
            set;
        }
        
        /// <summary>
        /// The RefPF property
        /// </summary>
        IASG RefPF
        {
            get;
            set;
        }
        
        /// <summary>
        /// The RefV property
        /// </summary>
        IASG RefV
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the OpTmh property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> OpTmhChanging;
        
        /// <summary>
        /// Gets fired when the OpTmh property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> OpTmhChanged;
        
        /// <summary>
        /// Gets fired before the React property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ReactChanging;
        
        /// <summary>
        /// Gets fired when the React property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ReactChanged;
        
        /// <summary>
        /// Gets fired before the LosFact property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LosFactChanging;
        
        /// <summary>
        /// Gets fired when the LosFact property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LosFactChanged;
        
        /// <summary>
        /// Gets fired before the Vol property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> VolChanging;
        
        /// <summary>
        /// Gets fired when the Vol property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> VolChanged;
        
        /// <summary>
        /// Gets fired before the RefReact property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> RefReactChanging;
        
        /// <summary>
        /// Gets fired when the RefReact property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> RefReactChanged;
        
        /// <summary>
        /// Gets fired before the RefPF property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> RefPFChanging;
        
        /// <summary>
        /// Gets fired when the RefPF property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> RefPFChanged;
        
        /// <summary>
        /// Gets fired before the RefV property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> RefVChanging;
        
        /// <summary>
        /// Gets fired when the RefV property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> RefVChanged;
    }
}

