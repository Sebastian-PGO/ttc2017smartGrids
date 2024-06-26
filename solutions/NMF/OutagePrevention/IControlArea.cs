using System.Collections.Specialized;
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
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace TTC2017.SmartGrids.OutagePreventionJointarget
{
    
    
    /// <summary>
    /// The public interface for ControlArea
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(ControlArea))]
    [XmlDefaultImplementationTypeAttribute(typeof(ControlArea))]
    public interface IControlArea : IModelElement
    {
        
        /// <summary>
        /// The mRID property
        /// </summary>
        string MRID
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the MRID property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> MRIDChanging;
        
        /// <summary>
        /// Gets fired when the MRID property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> MRIDChanged;
    }
}

