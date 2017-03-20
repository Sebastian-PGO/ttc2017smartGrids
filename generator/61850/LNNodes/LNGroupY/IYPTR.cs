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

namespace TTC2017.SmartGrids.SubstationStandard.LNNodes.LNGroupY
{
    
    
    /// <summary>
    /// The public interface for YPTR
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(YPTR))]
    [XmlDefaultImplementationTypeAttribute(typeof(YPTR))]
    public interface IYPTR : IModelElement, IGroupY
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
        /// The HPTmp property
        /// </summary>
        IMV HPTmp
        {
            get;
            set;
        }
        
        /// <summary>
        /// The HPZmpAlm property
        /// </summary>
        ISPS HPZmpAlm
        {
            get;
            set;
        }
        
        /// <summary>
        /// The HPTmpTr property
        /// </summary>
        ISPS HPTmpTr
        {
            get;
            set;
        }
        
        /// <summary>
        /// The OANL property
        /// </summary>
        ISPS OANL
        {
            get;
            set;
        }
        
        /// <summary>
        /// The OpOvA property
        /// </summary>
        ISPS OpOvA
        {
            get;
            set;
        }
        
        /// <summary>
        /// The OpOvV property
        /// </summary>
        ISPS OpOvV
        {
            get;
            set;
        }
        
        /// <summary>
        /// The OpUnV property
        /// </summary>
        ISPS OpUnV
        {
            get;
            set;
        }
        
        /// <summary>
        /// The CGAlm property
        /// </summary>
        ISPS CGAlm
        {
            get;
            set;
        }
        
        /// <summary>
        /// The HiVRtg property
        /// </summary>
        IASG HiVRtg
        {
            get;
            set;
        }
        
        /// <summary>
        /// The LoVRtg property
        /// </summary>
        IASG LoVRtg
        {
            get;
            set;
        }
        
        /// <summary>
        /// The PwrRtg property
        /// </summary>
        IASG PwrRtg
        {
            get;
            set;
        }
        
        /// <summary>
        /// The TransformerControl property
        /// </summary>
        IATCC TransformerControl
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
        /// Gets fired before the HPTmp property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> HPTmpChanging;
        
        /// <summary>
        /// Gets fired when the HPTmp property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> HPTmpChanged;
        
        /// <summary>
        /// Gets fired before the HPZmpAlm property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> HPZmpAlmChanging;
        
        /// <summary>
        /// Gets fired when the HPZmpAlm property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> HPZmpAlmChanged;
        
        /// <summary>
        /// Gets fired before the HPTmpTr property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> HPTmpTrChanging;
        
        /// <summary>
        /// Gets fired when the HPTmpTr property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> HPTmpTrChanged;
        
        /// <summary>
        /// Gets fired before the OANL property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> OANLChanging;
        
        /// <summary>
        /// Gets fired when the OANL property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> OANLChanged;
        
        /// <summary>
        /// Gets fired before the OpOvA property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> OpOvAChanging;
        
        /// <summary>
        /// Gets fired when the OpOvA property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> OpOvAChanged;
        
        /// <summary>
        /// Gets fired before the OpOvV property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> OpOvVChanging;
        
        /// <summary>
        /// Gets fired when the OpOvV property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> OpOvVChanged;
        
        /// <summary>
        /// Gets fired before the OpUnV property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> OpUnVChanging;
        
        /// <summary>
        /// Gets fired when the OpUnV property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> OpUnVChanged;
        
        /// <summary>
        /// Gets fired before the CGAlm property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CGAlmChanging;
        
        /// <summary>
        /// Gets fired when the CGAlm property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CGAlmChanged;
        
        /// <summary>
        /// Gets fired before the HiVRtg property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> HiVRtgChanging;
        
        /// <summary>
        /// Gets fired when the HiVRtg property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> HiVRtgChanged;
        
        /// <summary>
        /// Gets fired before the LoVRtg property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LoVRtgChanging;
        
        /// <summary>
        /// Gets fired when the LoVRtg property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LoVRtgChanged;
        
        /// <summary>
        /// Gets fired before the PwrRtg property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PwrRtgChanging;
        
        /// <summary>
        /// Gets fired when the PwrRtg property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PwrRtgChanged;
        
        /// <summary>
        /// Gets fired before the TransformerControl property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TransformerControlChanging;
        
        /// <summary>
        /// Gets fired when the TransformerControl property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TransformerControlChanged;
    }
}
