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
using TTC2017.SmartGrids.SubstationStandard.Enumerations;

namespace TTC2017.SmartGrids.SubstationStandard.Dataclasses
{
    
    
    /// <summary>
    /// The public interface for DPC
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(DPC))]
    [XmlDefaultImplementationTypeAttribute(typeof(DPC))]
    public interface IDPC : IModelElement
    {
        
        /// <summary>
        /// The ctlVal property
        /// </summary>
        Nullable<bool> CtlVal
        {
            get;
            set;
        }
        
        /// <summary>
        /// The stVal property
        /// </summary>
        IDPStatus StVal
        {
            get;
            set;
        }
        
        /// <summary>
        /// The q property
        /// </summary>
        IQuality Q
        {
            get;
            set;
        }
        
        /// <summary>
        /// The t property
        /// </summary>
        ITimeStamp T
        {
            get;
            set;
        }
        
        /// <summary>
        /// The subVal property
        /// </summary>
        IDPStatus SubVal
        {
            get;
            set;
        }
        
        /// <summary>
        /// The pulseConfig property
        /// </summary>
        IPulseConfig PulseConfig
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the CtlVal property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CtlValChanging;
        
        /// <summary>
        /// Gets fired when the CtlVal property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CtlValChanged;
        
        /// <summary>
        /// Gets fired before the StVal property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> StValChanging;
        
        /// <summary>
        /// Gets fired when the StVal property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> StValChanged;
        
        /// <summary>
        /// Gets fired before the Q property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> QChanging;
        
        /// <summary>
        /// Gets fired when the Q property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> QChanged;
        
        /// <summary>
        /// Gets fired before the T property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TChanging;
        
        /// <summary>
        /// Gets fired when the T property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TChanged;
        
        /// <summary>
        /// Gets fired before the SubVal property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> SubValChanging;
        
        /// <summary>
        /// Gets fired when the SubVal property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> SubValChanged;
        
        /// <summary>
        /// Gets fired before the PulseConfig property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PulseConfigChanging;
        
        /// <summary>
        /// Gets fired when the PulseConfig property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PulseConfigChanged;
    }
}

