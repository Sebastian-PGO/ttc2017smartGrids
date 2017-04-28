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

namespace TTC2017.SmartGrids.SubstationStandard.LNNodes.LNGroupZ
{
    
    
    /// <summary>
    /// The public interface for ZREA
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(ZREA))]
    [XmlDefaultImplementationTypeAttribute(typeof(ZREA))]
    public interface IZREA : IModelElement, IGroupZ
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
        /// The ReactorControl property
        /// </summary>
        IARCO ReactorControl
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
        /// Gets fired before the ReactorControl property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ReactorControlChanging;
        
        /// <summary>
        /// Gets fired when the ReactorControl property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ReactorControlChanged;
    }
}

