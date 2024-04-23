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

namespace TTC2017.SmartGrids.SubstationStandard.LNNodes.LNGroupR
{
    
    
    /// <summary>
    /// The public interface for RADR
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(RADR))]
    [XmlDefaultImplementationTypeAttribute(typeof(RADR))]
    public interface IRADR : IModelElement, IGroupR
    {
        
        /// <summary>
        /// The OpCntRs property
        /// </summary>
        IINC OpCntRs
        {
            get;
            set;
        }
        
        /// <summary>
        /// The ChTrg property
        /// </summary>
        ISPS ChTrg
        {
            get;
            set;
        }
        
        /// <summary>
        /// The ChNum property
        /// </summary>
        IING ChNum
        {
            get;
            set;
        }
        
        /// <summary>
        /// The TrGMod property
        /// </summary>
        IING TrGMod
        {
            get;
            set;
        }
        
        /// <summary>
        /// The LevMod property
        /// </summary>
        IING LevMod
        {
            get;
            set;
        }
        
        /// <summary>
        /// The HiTrgLev property
        /// </summary>
        IASG HiTrgLev
        {
            get;
            set;
        }
        
        /// <summary>
        /// The LoTrgLev property
        /// </summary>
        IASG LoTrgLev
        {
            get;
            set;
        }
        
        /// <summary>
        /// The PreTmms property
        /// </summary>
        IING PreTmms
        {
            get;
            set;
        }
        
        /// <summary>
        /// The PstTmms property
        /// </summary>
        IING PstTmms
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the OpCntRs property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> OpCntRsChanging;
        
        /// <summary>
        /// Gets fired when the OpCntRs property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> OpCntRsChanged;
        
        /// <summary>
        /// Gets fired before the ChTrg property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ChTrgChanging;
        
        /// <summary>
        /// Gets fired when the ChTrg property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ChTrgChanged;
        
        /// <summary>
        /// Gets fired before the ChNum property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ChNumChanging;
        
        /// <summary>
        /// Gets fired when the ChNum property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ChNumChanged;
        
        /// <summary>
        /// Gets fired before the TrGMod property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TrGModChanging;
        
        /// <summary>
        /// Gets fired when the TrGMod property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TrGModChanged;
        
        /// <summary>
        /// Gets fired before the LevMod property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LevModChanging;
        
        /// <summary>
        /// Gets fired when the LevMod property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LevModChanged;
        
        /// <summary>
        /// Gets fired before the HiTrgLev property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> HiTrgLevChanging;
        
        /// <summary>
        /// Gets fired when the HiTrgLev property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> HiTrgLevChanged;
        
        /// <summary>
        /// Gets fired before the LoTrgLev property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LoTrgLevChanging;
        
        /// <summary>
        /// Gets fired when the LoTrgLev property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LoTrgLevChanged;
        
        /// <summary>
        /// Gets fired before the PreTmms property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PreTmmsChanging;
        
        /// <summary>
        /// Gets fired when the PreTmms property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PreTmmsChanged;
        
        /// <summary>
        /// Gets fired before the PstTmms property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PstTmmsChanging;
        
        /// <summary>
        /// Gets fired when the PstTmms property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PstTmmsChanged;
    }
}

