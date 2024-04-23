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
    /// The public interface for MMXU
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(MMXU))]
    [XmlDefaultImplementationTypeAttribute(typeof(MMXU))]
    public interface IMMXU : IModelElement, IGroupM
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
        /// The TotW property
        /// </summary>
        IMV TotW
        {
            get;
            set;
        }
        
        /// <summary>
        /// The TotVAr property
        /// </summary>
        IMV TotVAr
        {
            get;
            set;
        }
        
        /// <summary>
        /// The TotVA property
        /// </summary>
        IMV TotVA
        {
            get;
            set;
        }
        
        /// <summary>
        /// The TotPF property
        /// </summary>
        IMV TotPF
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Hz property
        /// </summary>
        IMV Hz
        {
            get;
            set;
        }
        
        /// <summary>
        /// The PPV property
        /// </summary>
        IDEL PPV
        {
            get;
            set;
        }
        
        /// <summary>
        /// The PhV property
        /// </summary>
        IWYE PhV
        {
            get;
            set;
        }
        
        /// <summary>
        /// The A property
        /// </summary>
        IWYE A
        {
            get;
            set;
        }
        
        /// <summary>
        /// The W property
        /// </summary>
        IWYE W
        {
            get;
            set;
        }
        
        /// <summary>
        /// The VAr property
        /// </summary>
        IWYE VAr
        {
            get;
            set;
        }
        
        /// <summary>
        /// The VA property
        /// </summary>
        IWYE VA
        {
            get;
            set;
        }
        
        /// <summary>
        /// The PF property
        /// </summary>
        IWYE PF
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Z property
        /// </summary>
        IWYE Z
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
        /// Gets fired before the TotW property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TotWChanging;
        
        /// <summary>
        /// Gets fired when the TotW property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TotWChanged;
        
        /// <summary>
        /// Gets fired before the TotVAr property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TotVArChanging;
        
        /// <summary>
        /// Gets fired when the TotVAr property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TotVArChanged;
        
        /// <summary>
        /// Gets fired before the TotVA property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TotVAChanging;
        
        /// <summary>
        /// Gets fired when the TotVA property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TotVAChanged;
        
        /// <summary>
        /// Gets fired before the TotPF property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TotPFChanging;
        
        /// <summary>
        /// Gets fired when the TotPF property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TotPFChanged;
        
        /// <summary>
        /// Gets fired before the Hz property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> HzChanging;
        
        /// <summary>
        /// Gets fired when the Hz property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> HzChanged;
        
        /// <summary>
        /// Gets fired before the PPV property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PPVChanging;
        
        /// <summary>
        /// Gets fired when the PPV property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PPVChanged;
        
        /// <summary>
        /// Gets fired before the PhV property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PhVChanging;
        
        /// <summary>
        /// Gets fired when the PhV property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PhVChanged;
        
        /// <summary>
        /// Gets fired before the A property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AChanging;
        
        /// <summary>
        /// Gets fired when the A property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AChanged;
        
        /// <summary>
        /// Gets fired before the W property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> WChanging;
        
        /// <summary>
        /// Gets fired when the W property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> WChanged;
        
        /// <summary>
        /// Gets fired before the VAr property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> VArChanging;
        
        /// <summary>
        /// Gets fired when the VAr property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> VArChanged;
        
        /// <summary>
        /// Gets fired before the VA property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> VAChanging;
        
        /// <summary>
        /// Gets fired when the VA property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> VAChanged;
        
        /// <summary>
        /// Gets fired before the PF property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PFChanging;
        
        /// <summary>
        /// Gets fired when the PF property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PFChanged;
        
        /// <summary>
        /// Gets fired before the Z property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ZChanging;
        
        /// <summary>
        /// Gets fired when the Z property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ZChanged;
    }
}

