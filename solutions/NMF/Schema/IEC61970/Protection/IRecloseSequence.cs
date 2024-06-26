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
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Wires;

namespace TTC2017.SmartGrids.CIM.IEC61970.Protection
{
    
    
    /// <summary>
    /// The public interface for RecloseSequence
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(RecloseSequence))]
    [XmlDefaultImplementationTypeAttribute(typeof(RecloseSequence))]
    public interface IRecloseSequence : IModelElement, IIdentifiedObject
    {
        
        /// <summary>
        /// The recloseDelay property
        /// </summary>
        float RecloseDelay
        {
            get;
            set;
        }
        
        /// <summary>
        /// The recloseStep property
        /// </summary>
        int RecloseStep
        {
            get;
            set;
        }
        
        /// <summary>
        /// The ProtectedSwitch property
        /// </summary>
        IProtectedSwitch ProtectedSwitch
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the RecloseDelay property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> RecloseDelayChanging;
        
        /// <summary>
        /// Gets fired when the RecloseDelay property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> RecloseDelayChanged;
        
        /// <summary>
        /// Gets fired before the RecloseStep property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> RecloseStepChanging;
        
        /// <summary>
        /// Gets fired when the RecloseStep property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> RecloseStepChanged;
        
        /// <summary>
        /// Gets fired before the ProtectedSwitch property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ProtectedSwitchChanging;
        
        /// <summary>
        /// Gets fired when the ProtectedSwitch property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ProtectedSwitchChanged;
    }
}

