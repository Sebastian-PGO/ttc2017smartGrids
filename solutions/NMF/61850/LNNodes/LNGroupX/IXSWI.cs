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
using TTC2017.SmartGrids.SubstationStandard.LNNodes.LNGroupC;

namespace TTC2017.SmartGrids.SubstationStandard.LNNodes.LNGroupX
{
    
    
    /// <summary>
    /// The public interface for XSWI
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(XSWI))]
    [XmlDefaultImplementationTypeAttribute(typeof(XSWI))]
    public interface IXSWI : IModelElement, IGroupX
    {
        
        /// <summary>
        /// The SwOpCap property
        /// </summary>
        Nullable<SwitchingCapabilityKind> SwOpCap
        {
            get;
            set;
        }
        
        /// <summary>
        /// The MaxOpCap property
        /// </summary>
        Nullable<SwitchingCapabilityKind> MaxOpCap
        {
            get;
            set;
        }
        
        /// <summary>
        /// The SwTyp property
        /// </summary>
        Nullable<SwitchTypeKind> SwTyp
        {
            get;
            set;
        }
        
        /// <summary>
        /// The SwitchControl property
        /// </summary>
        ICSWI SwitchControl
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the SwOpCap property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> SwOpCapChanging;
        
        /// <summary>
        /// Gets fired when the SwOpCap property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> SwOpCapChanged;
        
        /// <summary>
        /// Gets fired before the MaxOpCap property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> MaxOpCapChanging;
        
        /// <summary>
        /// Gets fired when the MaxOpCap property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> MaxOpCapChanged;
        
        /// <summary>
        /// Gets fired before the SwTyp property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> SwTypChanging;
        
        /// <summary>
        /// Gets fired when the SwTyp property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> SwTypChanged;
        
        /// <summary>
        /// Gets fired before the SwitchControl property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> SwitchControlChanging;
        
        /// <summary>
        /// Gets fired when the SwitchControl property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> SwitchControlChanged;
    }
}
