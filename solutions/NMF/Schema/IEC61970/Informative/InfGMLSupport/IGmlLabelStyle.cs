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
    /// The public interface for GmlLabelStyle
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(GmlLabelStyle))]
    [XmlDefaultImplementationTypeAttribute(typeof(GmlLabelStyle))]
    public interface IGmlLabelStyle : IModelElement, IIdentifiedObject
    {
        
        /// <summary>
        /// The style property
        /// </summary>
        string Style
        {
            get;
            set;
        }
        
        /// <summary>
        /// The transform property
        /// </summary>
        string Transform
        {
            get;
            set;
        }
        
        /// <summary>
        /// The labelExpression property
        /// </summary>
        string LabelExpression
        {
            get;
            set;
        }
        
        /// <summary>
        /// The GmlFeatureStyle property
        /// </summary>
        IGmlFeatureStyle GmlFeatureStyle
        {
            get;
            set;
        }
        
        /// <summary>
        /// The GmlGeometryStyles property
        /// </summary>
        IOrderedSetExpression<IGmlGeometryStyle> GmlGeometryStyles
        {
            get;
        }
        
        /// <summary>
        /// The GmlTopologyStyles property
        /// </summary>
        IOrderedSetExpression<IGmlTopologyStyle> GmlTopologyStyles
        {
            get;
        }
        
        /// <summary>
        /// Gets fired before the Style property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> StyleChanging;
        
        /// <summary>
        /// Gets fired when the Style property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> StyleChanged;
        
        /// <summary>
        /// Gets fired before the Transform property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TransformChanging;
        
        /// <summary>
        /// Gets fired when the Transform property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TransformChanged;
        
        /// <summary>
        /// Gets fired before the LabelExpression property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LabelExpressionChanging;
        
        /// <summary>
        /// Gets fired when the LabelExpression property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LabelExpressionChanged;
        
        /// <summary>
        /// Gets fired before the GmlFeatureStyle property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> GmlFeatureStyleChanging;
        
        /// <summary>
        /// Gets fired when the GmlFeatureStyle property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> GmlFeatureStyleChanged;
    }
}

