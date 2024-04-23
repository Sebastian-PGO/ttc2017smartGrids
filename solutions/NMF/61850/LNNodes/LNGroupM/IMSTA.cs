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

namespace TTC2017.SmartGrids.SubstationStandard.LNNodes.LNGroupM
{
    
    
    /// <summary>
    /// The public interface for MSTA
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(MSTA))]
    [XmlDefaultImplementationTypeAttribute(typeof(MSTA))]
    public interface IMSTA : IModelElement, IGroupM
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
        /// The AvAmps property
        /// </summary>
        IMV AvAmps
        {
            get;
            set;
        }
        
        /// <summary>
        /// The MaxAmps property
        /// </summary>
        IMV MaxAmps
        {
            get;
            set;
        }
        
        /// <summary>
        /// The MinAmps property
        /// </summary>
        IMV MinAmps
        {
            get;
            set;
        }
        
        /// <summary>
        /// The AvVolts property
        /// </summary>
        IMV AvVolts
        {
            get;
            set;
        }
        
        /// <summary>
        /// The MaxVolts property
        /// </summary>
        IMV MaxVolts
        {
            get;
            set;
        }
        
        /// <summary>
        /// The MinVolts property
        /// </summary>
        IMV MinVolts
        {
            get;
            set;
        }
        
        /// <summary>
        /// The AvVA property
        /// </summary>
        IMV AvVA
        {
            get;
            set;
        }
        
        /// <summary>
        /// The MaxVA property
        /// </summary>
        IMV MaxVA
        {
            get;
            set;
        }
        
        /// <summary>
        /// The MinVA property
        /// </summary>
        IMV MinVA
        {
            get;
            set;
        }
        
        /// <summary>
        /// The AvW property
        /// </summary>
        IMV AvW
        {
            get;
            set;
        }
        
        /// <summary>
        /// The MaxW property
        /// </summary>
        IMV MaxW
        {
            get;
            set;
        }
        
        /// <summary>
        /// The MinW property
        /// </summary>
        IMV MinW
        {
            get;
            set;
        }
        
        /// <summary>
        /// The AvVAr property
        /// </summary>
        IMV AvVAr
        {
            get;
            set;
        }
        
        /// <summary>
        /// The MaxVAr property
        /// </summary>
        IMV MaxVAr
        {
            get;
            set;
        }
        
        /// <summary>
        /// The MinVAr property
        /// </summary>
        IMV MinVAr
        {
            get;
            set;
        }
        
        /// <summary>
        /// The EvStr property
        /// </summary>
        ISPC EvStr
        {
            get;
            set;
        }
        
        /// <summary>
        /// The EvTmms property
        /// </summary>
        IASG EvTmms
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
        /// Gets fired before the AvAmps property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AvAmpsChanging;
        
        /// <summary>
        /// Gets fired when the AvAmps property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AvAmpsChanged;
        
        /// <summary>
        /// Gets fired before the MaxAmps property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> MaxAmpsChanging;
        
        /// <summary>
        /// Gets fired when the MaxAmps property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> MaxAmpsChanged;
        
        /// <summary>
        /// Gets fired before the MinAmps property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> MinAmpsChanging;
        
        /// <summary>
        /// Gets fired when the MinAmps property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> MinAmpsChanged;
        
        /// <summary>
        /// Gets fired before the AvVolts property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AvVoltsChanging;
        
        /// <summary>
        /// Gets fired when the AvVolts property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AvVoltsChanged;
        
        /// <summary>
        /// Gets fired before the MaxVolts property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> MaxVoltsChanging;
        
        /// <summary>
        /// Gets fired when the MaxVolts property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> MaxVoltsChanged;
        
        /// <summary>
        /// Gets fired before the MinVolts property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> MinVoltsChanging;
        
        /// <summary>
        /// Gets fired when the MinVolts property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> MinVoltsChanged;
        
        /// <summary>
        /// Gets fired before the AvVA property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AvVAChanging;
        
        /// <summary>
        /// Gets fired when the AvVA property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AvVAChanged;
        
        /// <summary>
        /// Gets fired before the MaxVA property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> MaxVAChanging;
        
        /// <summary>
        /// Gets fired when the MaxVA property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> MaxVAChanged;
        
        /// <summary>
        /// Gets fired before the MinVA property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> MinVAChanging;
        
        /// <summary>
        /// Gets fired when the MinVA property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> MinVAChanged;
        
        /// <summary>
        /// Gets fired before the AvW property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AvWChanging;
        
        /// <summary>
        /// Gets fired when the AvW property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AvWChanged;
        
        /// <summary>
        /// Gets fired before the MaxW property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> MaxWChanging;
        
        /// <summary>
        /// Gets fired when the MaxW property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> MaxWChanged;
        
        /// <summary>
        /// Gets fired before the MinW property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> MinWChanging;
        
        /// <summary>
        /// Gets fired when the MinW property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> MinWChanged;
        
        /// <summary>
        /// Gets fired before the AvVAr property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AvVArChanging;
        
        /// <summary>
        /// Gets fired when the AvVAr property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AvVArChanged;
        
        /// <summary>
        /// Gets fired before the MaxVAr property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> MaxVArChanging;
        
        /// <summary>
        /// Gets fired when the MaxVAr property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> MaxVArChanged;
        
        /// <summary>
        /// Gets fired before the MinVAr property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> MinVArChanging;
        
        /// <summary>
        /// Gets fired when the MinVAr property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> MinVArChanged;
        
        /// <summary>
        /// Gets fired before the EvStr property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> EvStrChanging;
        
        /// <summary>
        /// Gets fired when the EvStr property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> EvStrChanged;
        
        /// <summary>
        /// Gets fired before the EvTmms property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> EvTmmsChanging;
        
        /// <summary>
        /// Gets fired when the EvTmms property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> EvTmmsChanged;
    }
}

