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
    /// The public interface for PTTR
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(PTTR))]
    [XmlDefaultImplementationTypeAttribute(typeof(PTTR))]
    public interface IPTTR : IModelElement, IGroupP
    {
        
        /// <summary>
        /// The Amp property
        /// </summary>
        IMV Amp
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Tmp property
        /// </summary>
        IMV Tmp
        {
            get;
            set;
        }
        
        /// <summary>
        /// The TmpRl property
        /// </summary>
        IMV TmpRl
        {
            get;
            set;
        }
        
        /// <summary>
        /// The LodRsvAlm property
        /// </summary>
        IMV LodRsvAlm
        {
            get;
            set;
        }
        
        /// <summary>
        /// The LodRsvTr property
        /// </summary>
        IMV LodRsvTr
        {
            get;
            set;
        }
        
        /// <summary>
        /// The AgeRat property
        /// </summary>
        IMV AgeRat
        {
            get;
            set;
        }
        
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
        /// The AlmThm property
        /// </summary>
        IACT AlmThm
        {
            get;
            set;
        }
        
        /// <summary>
        /// The TmTmpSt property
        /// </summary>
        ICSD TmTmpSt
        {
            get;
            set;
        }
        
        /// <summary>
        /// The TmASt property
        /// </summary>
        ICSD TmASt
        {
            get;
            set;
        }
        
        /// <summary>
        /// The TmTmpCrv property
        /// </summary>
        ICURVE TmTmpCrv
        {
            get;
            set;
        }
        
        /// <summary>
        /// The TmACrv property
        /// </summary>
        ICURVE TmACrv
        {
            get;
            set;
        }
        
        /// <summary>
        /// The TmpMax property
        /// </summary>
        IASG TmpMax
        {
            get;
            set;
        }
        
        /// <summary>
        /// The StrVal property
        /// </summary>
        IASG StrVal
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
        /// The MinOpTmms property
        /// </summary>
        IING MinOpTmms
        {
            get;
            set;
        }
        
        /// <summary>
        /// The MaxOpTmms property
        /// </summary>
        IING MaxOpTmms
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
        /// The ConsTms property
        /// </summary>
        IING ConsTms
        {
            get;
            set;
        }
        
        /// <summary>
        /// The AlmVal property
        /// </summary>
        IASG AlmVal
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the Amp property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AmpChanging;
        
        /// <summary>
        /// Gets fired when the Amp property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AmpChanged;
        
        /// <summary>
        /// Gets fired before the Tmp property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TmpChanging;
        
        /// <summary>
        /// Gets fired when the Tmp property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TmpChanged;
        
        /// <summary>
        /// Gets fired before the TmpRl property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TmpRlChanging;
        
        /// <summary>
        /// Gets fired when the TmpRl property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TmpRlChanged;
        
        /// <summary>
        /// Gets fired before the LodRsvAlm property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LodRsvAlmChanging;
        
        /// <summary>
        /// Gets fired when the LodRsvAlm property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LodRsvAlmChanged;
        
        /// <summary>
        /// Gets fired before the LodRsvTr property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LodRsvTrChanging;
        
        /// <summary>
        /// Gets fired when the LodRsvTr property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LodRsvTrChanged;
        
        /// <summary>
        /// Gets fired before the AgeRat property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AgeRatChanging;
        
        /// <summary>
        /// Gets fired when the AgeRat property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AgeRatChanged;
        
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
        /// Gets fired before the AlmThm property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AlmThmChanging;
        
        /// <summary>
        /// Gets fired when the AlmThm property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AlmThmChanged;
        
        /// <summary>
        /// Gets fired before the TmTmpSt property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TmTmpStChanging;
        
        /// <summary>
        /// Gets fired when the TmTmpSt property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TmTmpStChanged;
        
        /// <summary>
        /// Gets fired before the TmASt property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TmAStChanging;
        
        /// <summary>
        /// Gets fired when the TmASt property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TmAStChanged;
        
        /// <summary>
        /// Gets fired before the TmTmpCrv property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TmTmpCrvChanging;
        
        /// <summary>
        /// Gets fired when the TmTmpCrv property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TmTmpCrvChanged;
        
        /// <summary>
        /// Gets fired before the TmACrv property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TmACrvChanging;
        
        /// <summary>
        /// Gets fired when the TmACrv property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TmACrvChanged;
        
        /// <summary>
        /// Gets fired before the TmpMax property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TmpMaxChanging;
        
        /// <summary>
        /// Gets fired when the TmpMax property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TmpMaxChanged;
        
        /// <summary>
        /// Gets fired before the StrVal property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> StrValChanging;
        
        /// <summary>
        /// Gets fired when the StrVal property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> StrValChanged;
        
        /// <summary>
        /// Gets fired before the OpDlTmms property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> OpDlTmmsChanging;
        
        /// <summary>
        /// Gets fired when the OpDlTmms property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> OpDlTmmsChanged;
        
        /// <summary>
        /// Gets fired before the MinOpTmms property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> MinOpTmmsChanging;
        
        /// <summary>
        /// Gets fired when the MinOpTmms property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> MinOpTmmsChanged;
        
        /// <summary>
        /// Gets fired before the MaxOpTmms property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> MaxOpTmmsChanging;
        
        /// <summary>
        /// Gets fired when the MaxOpTmms property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> MaxOpTmmsChanged;
        
        /// <summary>
        /// Gets fired before the RsDlTmms property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> RsDlTmmsChanging;
        
        /// <summary>
        /// Gets fired when the RsDlTmms property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> RsDlTmmsChanged;
        
        /// <summary>
        /// Gets fired before the ConsTms property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ConsTmsChanging;
        
        /// <summary>
        /// Gets fired when the ConsTms property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ConsTmsChanged;
        
        /// <summary>
        /// Gets fired before the AlmVal property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AlmValChanging;
        
        /// <summary>
        /// Gets fired when the AlmVal property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AlmValChanged;
    }
}

