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
using TTC2017.SmartGrids.COSEM.COSEMObjects;

namespace TTC2017.SmartGrids.COSEM
{
    
    
    /// <summary>
    /// The public interface for LogicalDeviceName
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(LogicalDeviceName))]
    [XmlDefaultImplementationTypeAttribute(typeof(LogicalDeviceName))]
    public interface ILogicalDeviceName : IModelElement
    {
        
        /// <summary>
        /// The name property
        /// </summary>
        ISAPAssignmentCurrent Name
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the Name property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> NameChanging;
        
        /// <summary>
        /// Gets fired when the Name property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> NameChanged;
    }
}

