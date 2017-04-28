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
    /// The public interface for GmlColour
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(GmlColour))]
    [XmlDefaultImplementationTypeAttribute(typeof(GmlColour))]
    public interface IGmlColour : IModelElement, IIdentifiedObject
    {
        
        /// <summary>
        /// The green property
        /// </summary>
        string Green
        {
            get;
            set;
        }
        
        /// <summary>
        /// The red property
        /// </summary>
        string Red
        {
            get;
            set;
        }
        
        /// <summary>
        /// The blue property
        /// </summary>
        string Blue
        {
            get;
            set;
        }
        
        /// <summary>
        /// The GmlStrokes property
        /// </summary>
        IOrderedSetExpression<IGmlStroke> GmlStrokes
        {
            get;
        }
        
        /// <summary>
        /// The GmlFonts property
        /// </summary>
        IOrderedSetExpression<IGmlFont> GmlFonts
        {
            get;
        }
        
        /// <summary>
        /// The GmlFills property
        /// </summary>
        IOrderedSetExpression<IGmlFill> GmlFills
        {
            get;
        }
        
        /// <summary>
        /// Gets fired before the Green property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> GreenChanging;
        
        /// <summary>
        /// Gets fired when the Green property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> GreenChanged;
        
        /// <summary>
        /// Gets fired before the Red property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> RedChanging;
        
        /// <summary>
        /// Gets fired when the Red property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> RedChanged;
        
        /// <summary>
        /// Gets fired before the Blue property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> BlueChanging;
        
        /// <summary>
        /// Gets fired when the Blue property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> BlueChanged;
    }
}

