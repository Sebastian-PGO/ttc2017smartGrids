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

namespace TTC2017.SmartGrids.SubstationStandard.LNNodes.LNGroupC
{
    
    
    /// <summary>
    /// The public interface for CPOW
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(CPOW))]
    [XmlDefaultImplementationTypeAttribute(typeof(CPOW))]
    public interface ICPOW : IModelElement, IGroupC
    {
        
        /// <summary>
        /// The TmExc property
        /// </summary>
        ISPS TmExc
        {
            get;
            set;
        }
        
        /// <summary>
        /// The StrPOW property
        /// </summary>
        ISPS StrPOW
        {
            get;
            set;
        }
        
        /// <summary>
        /// The OpOpn property
        /// </summary>
        IACT OpOpn
        {
            get;
            set;
        }
        
        /// <summary>
        /// The OpCls property
        /// </summary>
        IACT OpCls
        {
            get;
            set;
        }
        
        /// <summary>
        /// The MaxDlTmms property
        /// </summary>
        IING MaxDlTmms
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the TmExc property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TmExcChanging;
        
        /// <summary>
        /// Gets fired when the TmExc property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TmExcChanged;
        
        /// <summary>
        /// Gets fired before the StrPOW property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> StrPOWChanging;
        
        /// <summary>
        /// Gets fired when the StrPOW property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> StrPOWChanged;
        
        /// <summary>
        /// Gets fired before the OpOpn property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> OpOpnChanging;
        
        /// <summary>
        /// Gets fired when the OpOpn property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> OpOpnChanged;
        
        /// <summary>
        /// Gets fired before the OpCls property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> OpClsChanging;
        
        /// <summary>
        /// Gets fired when the OpCls property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> OpClsChanged;
        
        /// <summary>
        /// Gets fired before the MaxDlTmms property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> MaxDlTmmsChanging;
        
        /// <summary>
        /// Gets fired when the MaxDlTmms property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> MaxDlTmmsChanged;
    }
}

