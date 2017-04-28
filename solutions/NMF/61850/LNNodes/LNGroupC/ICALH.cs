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
    /// The public interface for CALH
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(CALH))]
    [XmlDefaultImplementationTypeAttribute(typeof(CALH))]
    public interface ICALH : IModelElement, IGroupC
    {
        
        /// <summary>
        /// The GrAlm property
        /// </summary>
        ISPS GrAlm
        {
            get;
            set;
        }
        
        /// <summary>
        /// The GrWrn property
        /// </summary>
        ISPS GrWrn
        {
            get;
            set;
        }
        
        /// <summary>
        /// The AlmLstOv property
        /// </summary>
        ISPS AlmLstOv
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the GrAlm property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> GrAlmChanging;
        
        /// <summary>
        /// Gets fired when the GrAlm property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> GrAlmChanged;
        
        /// <summary>
        /// Gets fired before the GrWrn property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> GrWrnChanging;
        
        /// <summary>
        /// Gets fired when the GrWrn property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> GrWrnChanged;
        
        /// <summary>
        /// Gets fired before the AlmLstOv property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AlmLstOvChanging;
        
        /// <summary>
        /// Gets fired when the AlmLstOv property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AlmLstOvChanged;
    }
}

