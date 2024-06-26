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
    /// The public interface for PositionPoint
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(PositionPoint))]
    [XmlDefaultImplementationTypeAttribute(typeof(PositionPoint))]
    public interface IPositionPoint : IModelElement
    {
        
        /// <summary>
        /// The xPosition property
        /// </summary>
        string XPosition
        {
            get;
            set;
        }
        
        /// <summary>
        /// The yPosition property
        /// </summary>
        string YPosition
        {
            get;
            set;
        }
        
        /// <summary>
        /// The zPosition property
        /// </summary>
        string ZPosition
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the XPosition property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> XPositionChanging;
        
        /// <summary>
        /// Gets fired when the XPosition property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> XPositionChanged;
        
        /// <summary>
        /// Gets fired before the YPosition property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> YPositionChanging;
        
        /// <summary>
        /// Gets fired when the YPosition property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> YPositionChanged;
        
        /// <summary>
        /// Gets fired before the ZPosition property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ZPositionChanging;
        
        /// <summary>
        /// Gets fired when the ZPosition property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ZPositionChanged;
    }
}

