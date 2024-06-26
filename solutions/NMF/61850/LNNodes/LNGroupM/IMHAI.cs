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
    /// The public interface for MHAI
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(MHAI))]
    [XmlDefaultImplementationTypeAttribute(typeof(MHAI))]
    public interface IMHAI : IModelElement, IGroupM
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
        /// The Hz property
        /// </summary>
        IMV Hz
        {
            get;
            set;
        }
        
        /// <summary>
        /// The HA property
        /// </summary>
        IHYWE HA
        {
            get;
            set;
        }
        
        /// <summary>
        /// The HPhV property
        /// </summary>
        IHYWE HPhV
        {
            get;
            set;
        }
        
        /// <summary>
        /// The HPPV property
        /// </summary>
        IHDEL HPPV
        {
            get;
            set;
        }
        
        /// <summary>
        /// The HW property
        /// </summary>
        IHYWE HW
        {
            get;
            set;
        }
        
        /// <summary>
        /// The HVAr property
        /// </summary>
        IHYWE HVAr
        {
            get;
            set;
        }
        
        /// <summary>
        /// The HVA property
        /// </summary>
        IHYWE HVA
        {
            get;
            set;
        }
        
        /// <summary>
        /// The HRmsA property
        /// </summary>
        IWYE HRmsA
        {
            get;
            set;
        }
        
        /// <summary>
        /// The HRmsPhV property
        /// </summary>
        IWYE HRmsPhV
        {
            get;
            set;
        }
        
        /// <summary>
        /// The HRmsPPV property
        /// </summary>
        IDEL HRmsPPV
        {
            get;
            set;
        }
        
        /// <summary>
        /// The HTuW property
        /// </summary>
        IWYE HTuW
        {
            get;
            set;
        }
        
        /// <summary>
        /// The HTsW property
        /// </summary>
        IWYE HTsW
        {
            get;
            set;
        }
        
        /// <summary>
        /// The HATm property
        /// </summary>
        IWYE HATm
        {
            get;
            set;
        }
        
        /// <summary>
        /// The HKf property
        /// </summary>
        IWYE HKf
        {
            get;
            set;
        }
        
        /// <summary>
        /// The HTdf property
        /// </summary>
        IWYE HTdf
        {
            get;
            set;
        }
        
        /// <summary>
        /// The ThdA property
        /// </summary>
        IWYE ThdA
        {
            get;
            set;
        }
        
        /// <summary>
        /// The ThdOddA property
        /// </summary>
        IWYE ThdOddA
        {
            get;
            set;
        }
        
        /// <summary>
        /// The ThdEvnA property
        /// </summary>
        IWYE ThdEvnA
        {
            get;
            set;
        }
        
        /// <summary>
        /// The ThdPhV property
        /// </summary>
        IWYE ThdPhV
        {
            get;
            set;
        }
        
        /// <summary>
        /// The ThdOddPhV property
        /// </summary>
        IWYE ThdOddPhV
        {
            get;
            set;
        }
        
        /// <summary>
        /// The ThdEvnV property
        /// </summary>
        IWYE ThdEvnV
        {
            get;
            set;
        }
        
        /// <summary>
        /// The ThdPPV property
        /// </summary>
        IDEL ThdPPV
        {
            get;
            set;
        }
        
        /// <summary>
        /// The ThdOddPPV property
        /// </summary>
        IDEL ThdOddPPV
        {
            get;
            set;
        }
        
        /// <summary>
        /// The ThdEvnPPV property
        /// </summary>
        IDEL ThdEvnPPV
        {
            get;
            set;
        }
        
        /// <summary>
        /// The HCfPhV property
        /// </summary>
        IWYE HCfPhV
        {
            get;
            set;
        }
        
        /// <summary>
        /// The HCfPPV property
        /// </summary>
        IDEL HCfPPV
        {
            get;
            set;
        }
        
        /// <summary>
        /// The HCfA property
        /// </summary>
        IWYE HCfA
        {
            get;
            set;
        }
        
        /// <summary>
        /// The HTif property
        /// </summary>
        IWYE HTif
        {
            get;
            set;
        }
        
        /// <summary>
        /// The HzSet property
        /// </summary>
        IASG HzSet
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
        /// The NumCyc property
        /// </summary>
        IING NumCyc
        {
            get;
            set;
        }
        
        /// <summary>
        /// The ThdAVal property
        /// </summary>
        IASG ThdAVal
        {
            get;
            set;
        }
        
        /// <summary>
        /// The ThdVVal property
        /// </summary>
        IASG ThdVVal
        {
            get;
            set;
        }
        
        /// <summary>
        /// The ThdATmms property
        /// </summary>
        IING ThdATmms
        {
            get;
            set;
        }
        
        /// <summary>
        /// The ThdVTmms property
        /// </summary>
        IING ThdVTmms
        {
            get;
            set;
        }
        
        /// <summary>
        /// The NomA property
        /// </summary>
        IASG NomA
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
        /// Gets fired before the Hz property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> HzChanging;
        
        /// <summary>
        /// Gets fired when the Hz property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> HzChanged;
        
        /// <summary>
        /// Gets fired before the HA property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> HAChanging;
        
        /// <summary>
        /// Gets fired when the HA property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> HAChanged;
        
        /// <summary>
        /// Gets fired before the HPhV property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> HPhVChanging;
        
        /// <summary>
        /// Gets fired when the HPhV property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> HPhVChanged;
        
        /// <summary>
        /// Gets fired before the HPPV property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> HPPVChanging;
        
        /// <summary>
        /// Gets fired when the HPPV property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> HPPVChanged;
        
        /// <summary>
        /// Gets fired before the HW property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> HWChanging;
        
        /// <summary>
        /// Gets fired when the HW property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> HWChanged;
        
        /// <summary>
        /// Gets fired before the HVAr property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> HVArChanging;
        
        /// <summary>
        /// Gets fired when the HVAr property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> HVArChanged;
        
        /// <summary>
        /// Gets fired before the HVA property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> HVAChanging;
        
        /// <summary>
        /// Gets fired when the HVA property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> HVAChanged;
        
        /// <summary>
        /// Gets fired before the HRmsA property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> HRmsAChanging;
        
        /// <summary>
        /// Gets fired when the HRmsA property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> HRmsAChanged;
        
        /// <summary>
        /// Gets fired before the HRmsPhV property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> HRmsPhVChanging;
        
        /// <summary>
        /// Gets fired when the HRmsPhV property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> HRmsPhVChanged;
        
        /// <summary>
        /// Gets fired before the HRmsPPV property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> HRmsPPVChanging;
        
        /// <summary>
        /// Gets fired when the HRmsPPV property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> HRmsPPVChanged;
        
        /// <summary>
        /// Gets fired before the HTuW property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> HTuWChanging;
        
        /// <summary>
        /// Gets fired when the HTuW property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> HTuWChanged;
        
        /// <summary>
        /// Gets fired before the HTsW property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> HTsWChanging;
        
        /// <summary>
        /// Gets fired when the HTsW property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> HTsWChanged;
        
        /// <summary>
        /// Gets fired before the HATm property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> HATmChanging;
        
        /// <summary>
        /// Gets fired when the HATm property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> HATmChanged;
        
        /// <summary>
        /// Gets fired before the HKf property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> HKfChanging;
        
        /// <summary>
        /// Gets fired when the HKf property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> HKfChanged;
        
        /// <summary>
        /// Gets fired before the HTdf property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> HTdfChanging;
        
        /// <summary>
        /// Gets fired when the HTdf property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> HTdfChanged;
        
        /// <summary>
        /// Gets fired before the ThdA property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ThdAChanging;
        
        /// <summary>
        /// Gets fired when the ThdA property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ThdAChanged;
        
        /// <summary>
        /// Gets fired before the ThdOddA property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ThdOddAChanging;
        
        /// <summary>
        /// Gets fired when the ThdOddA property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ThdOddAChanged;
        
        /// <summary>
        /// Gets fired before the ThdEvnA property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ThdEvnAChanging;
        
        /// <summary>
        /// Gets fired when the ThdEvnA property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ThdEvnAChanged;
        
        /// <summary>
        /// Gets fired before the ThdPhV property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ThdPhVChanging;
        
        /// <summary>
        /// Gets fired when the ThdPhV property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ThdPhVChanged;
        
        /// <summary>
        /// Gets fired before the ThdOddPhV property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ThdOddPhVChanging;
        
        /// <summary>
        /// Gets fired when the ThdOddPhV property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ThdOddPhVChanged;
        
        /// <summary>
        /// Gets fired before the ThdEvnV property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ThdEvnVChanging;
        
        /// <summary>
        /// Gets fired when the ThdEvnV property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ThdEvnVChanged;
        
        /// <summary>
        /// Gets fired before the ThdPPV property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ThdPPVChanging;
        
        /// <summary>
        /// Gets fired when the ThdPPV property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ThdPPVChanged;
        
        /// <summary>
        /// Gets fired before the ThdOddPPV property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ThdOddPPVChanging;
        
        /// <summary>
        /// Gets fired when the ThdOddPPV property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ThdOddPPVChanged;
        
        /// <summary>
        /// Gets fired before the ThdEvnPPV property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ThdEvnPPVChanging;
        
        /// <summary>
        /// Gets fired when the ThdEvnPPV property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ThdEvnPPVChanged;
        
        /// <summary>
        /// Gets fired before the HCfPhV property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> HCfPhVChanging;
        
        /// <summary>
        /// Gets fired when the HCfPhV property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> HCfPhVChanged;
        
        /// <summary>
        /// Gets fired before the HCfPPV property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> HCfPPVChanging;
        
        /// <summary>
        /// Gets fired when the HCfPPV property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> HCfPPVChanged;
        
        /// <summary>
        /// Gets fired before the HCfA property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> HCfAChanging;
        
        /// <summary>
        /// Gets fired when the HCfA property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> HCfAChanged;
        
        /// <summary>
        /// Gets fired before the HTif property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> HTifChanging;
        
        /// <summary>
        /// Gets fired when the HTif property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> HTifChanged;
        
        /// <summary>
        /// Gets fired before the HzSet property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> HzSetChanging;
        
        /// <summary>
        /// Gets fired when the HzSet property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> HzSetChanged;
        
        /// <summary>
        /// Gets fired before the EvTmms property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> EvTmmsChanging;
        
        /// <summary>
        /// Gets fired when the EvTmms property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> EvTmmsChanged;
        
        /// <summary>
        /// Gets fired before the NumCyc property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> NumCycChanging;
        
        /// <summary>
        /// Gets fired when the NumCyc property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> NumCycChanged;
        
        /// <summary>
        /// Gets fired before the ThdAVal property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ThdAValChanging;
        
        /// <summary>
        /// Gets fired when the ThdAVal property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ThdAValChanged;
        
        /// <summary>
        /// Gets fired before the ThdVVal property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ThdVValChanging;
        
        /// <summary>
        /// Gets fired when the ThdVVal property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ThdVValChanged;
        
        /// <summary>
        /// Gets fired before the ThdATmms property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ThdATmmsChanging;
        
        /// <summary>
        /// Gets fired when the ThdATmms property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ThdATmmsChanged;
        
        /// <summary>
        /// Gets fired before the ThdVTmms property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ThdVTmmsChanging;
        
        /// <summary>
        /// Gets fired when the ThdVTmms property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ThdVTmmsChanged;
        
        /// <summary>
        /// Gets fired before the NomA property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> NomAChanging;
        
        /// <summary>
        /// Gets fired when the NomA property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> NomAChanged;
    }
}

