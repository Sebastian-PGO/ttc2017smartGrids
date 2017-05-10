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
    /// The public interface for RREC
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(RREC))]
    [XmlDefaultImplementationTypeAttribute(typeof(RREC))]
    public interface IRREC : IModelElement, IGroupR
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
        /// The BlkRec property
        /// </summary>
        ISPC BlkRec
        {
            get;
            set;
        }
        
        /// <summary>
        /// The ChkRec property
        /// </summary>
        ISPC ChkRec
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Auto property
        /// </summary>
        ISPS Auto
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
        /// The AutoRecSt property
        /// </summary>
        IINS AutoRecSt
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Rec1Tmms property
        /// </summary>
        IING Rec1Tmms
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Rec2Tmms property
        /// </summary>
        IING Rec2Tmms
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Rec3Tmms property
        /// </summary>
        IING Rec3Tmms
        {
            get;
            set;
        }
        
        /// <summary>
        /// The PlsTmms property
        /// </summary>
        IING PlsTmms
        {
            get;
            set;
        }
        
        /// <summary>
        /// The RclTmms property
        /// </summary>
        IING RclTmms
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
        /// Gets fired before the BlkRec property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> BlkRecChanging;
        
        /// <summary>
        /// Gets fired when the BlkRec property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> BlkRecChanged;
        
        /// <summary>
        /// Gets fired before the ChkRec property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ChkRecChanging;
        
        /// <summary>
        /// Gets fired when the ChkRec property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ChkRecChanged;
        
        /// <summary>
        /// Gets fired before the Auto property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AutoChanging;
        
        /// <summary>
        /// Gets fired when the Auto property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AutoChanged;
        
        /// <summary>
        /// Gets fired before the Op property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> OpChanging;
        
        /// <summary>
        /// Gets fired when the Op property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> OpChanged;
        
        /// <summary>
        /// Gets fired before the AutoRecSt property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AutoRecStChanging;
        
        /// <summary>
        /// Gets fired when the AutoRecSt property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AutoRecStChanged;
        
        /// <summary>
        /// Gets fired before the Rec1Tmms property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Rec1TmmsChanging;
        
        /// <summary>
        /// Gets fired when the Rec1Tmms property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Rec1TmmsChanged;
        
        /// <summary>
        /// Gets fired before the Rec2Tmms property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Rec2TmmsChanging;
        
        /// <summary>
        /// Gets fired when the Rec2Tmms property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Rec2TmmsChanged;
        
        /// <summary>
        /// Gets fired before the Rec3Tmms property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Rec3TmmsChanging;
        
        /// <summary>
        /// Gets fired when the Rec3Tmms property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Rec3TmmsChanged;
        
        /// <summary>
        /// Gets fired before the PlsTmms property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PlsTmmsChanging;
        
        /// <summary>
        /// Gets fired when the PlsTmms property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PlsTmmsChanged;
        
        /// <summary>
        /// Gets fired before the RclTmms property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> RclTmmsChanging;
        
        /// <summary>
        /// Gets fired when the RclTmms property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> RclTmmsChanged;
    }
}
