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
    /// The public interface for PHIZ
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(PHIZ))]
    [XmlDefaultImplementationTypeAttribute(typeof(PHIZ))]
    public interface IPHIZ : IModelElement, IGroupP
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
        /// The AStr property
        /// </summary>
        IASG AStr
        {
            get;
            set;
        }
        
        /// <summary>
        /// The VStr property
        /// </summary>
        IASG VStr
        {
            get;
            set;
        }
        
        /// <summary>
        /// The HVStr property
        /// </summary>
        IASG HVStr
        {
            get;
            set;
        }
        
        /// <summary>
        /// The OpDlTmms property
        /// </summary>
        IING OpDlTmms
        {
            get;
            set;
        }
        
        /// <summary>
        /// The RsDlTmms property
        /// </summary>
        IING RsDlTmms
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
        /// Gets fired before the AStr property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AStrChanging;
        
        /// <summary>
        /// Gets fired when the AStr property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AStrChanged;
        
        /// <summary>
        /// Gets fired before the VStr property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> VStrChanging;
        
        /// <summary>
        /// Gets fired when the VStr property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> VStrChanged;
        
        /// <summary>
        /// Gets fired before the HVStr property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> HVStrChanging;
        
        /// <summary>
        /// Gets fired when the HVStr property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> HVStrChanged;
        
        /// <summary>
        /// Gets fired before the OpDlTmms property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> OpDlTmmsChanging;
        
        /// <summary>
        /// Gets fired when the OpDlTmms property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> OpDlTmmsChanged;
        
        /// <summary>
        /// Gets fired before the RsDlTmms property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> RsDlTmmsChanging;
        
        /// <summary>
        /// Gets fired when the RsDlTmms property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> RsDlTmmsChanged;
    }
}

