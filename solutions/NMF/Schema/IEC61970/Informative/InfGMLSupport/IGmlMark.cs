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
using TTC2017.SmartGrids.CIM;
using TTC2017.SmartGrids.CIM.IEC61968.Common;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfOperations;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfWork;
using TTC2017.SmartGrids.CIM.IEC61970.Meas;

namespace TTC2017.SmartGrids.CIM.IEC61970.Informative.InfGMLSupport
{
    
    
    /// <summary>
    /// The public interface for GmlMark
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(GmlMark))]
    [XmlDefaultImplementationTypeAttribute(typeof(GmlMark))]
    public interface IGmlMark : IModelElement, IIdentifiedObject
    {
        
        /// <summary>
        /// The wellKnownName property
        /// </summary>
        string WellKnownName
        {
            get;
            set;
        }
        
        /// <summary>
        /// The GmlGraphics property
        /// </summary>
        IOrderedSetExpression<IGmlGraphic> GmlGraphics
        {
            get;
        }
        
        /// <summary>
        /// The GmlFIlls property
        /// </summary>
        IOrderedSetExpression<IGmlFill> GmlFIlls
        {
            get;
        }
        
        /// <summary>
        /// The GmlStrokes property
        /// </summary>
        IOrderedSetExpression<IGmlStroke> GmlStrokes
        {
            get;
        }
        
        /// <summary>
        /// Gets fired before the WellKnownName property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> WellKnownNameChanging;
        
        /// <summary>
        /// Gets fired when the WellKnownName property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> WellKnownNameChanged;
    }
}

