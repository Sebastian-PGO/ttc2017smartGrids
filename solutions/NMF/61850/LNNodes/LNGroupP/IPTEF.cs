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
using TTC2017.SmartGrids.SubstationStandard.LNNodes.DomainLNs;

namespace TTC2017.SmartGrids.SubstationStandard.LNNodes.LNGroupP
{
    
    
    /// <summary>
    /// The public interface for PTEF
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(PTEF))]
    [XmlDefaultImplementationTypeAttribute(typeof(PTEF))]
    public interface IPTEF : IModelElement, IGroupP
    {
        
        /// <summary>
        /// The Str property
        /// </summary>
        IACD Str
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Op property
        /// </summary>
        IACT Op
        {
            get;
            set;
        }
        
        /// <summary>
        /// The GndStr property
        /// </summary>
        IASG GndStr
        {
            get;
            set;
        }
        
        /// <summary>
        /// The DirMod property
        /// </summary>
        IING DirMod
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the Str property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> StrChanging;
        
        /// <summary>
        /// Gets fired when the Str property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> StrChanged;
        
        /// <summary>
        /// Gets fired before the Op property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> OpChanging;
        
        /// <summary>
        /// Gets fired when the Op property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> OpChanged;
        
        /// <summary>
        /// Gets fired before the GndStr property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> GndStrChanging;
        
        /// <summary>
        /// Gets fired when the GndStr property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> GndStrChanged;
        
        /// <summary>
        /// Gets fired before the DirMod property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DirModChanging;
        
        /// <summary>
        /// Gets fired when the DirMod property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DirModChanged;
    }
}

