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
    /// The public interface for GmlFeatureStyle
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(GmlFeatureStyle))]
    [XmlDefaultImplementationTypeAttribute(typeof(GmlFeatureStyle))]
    public interface IGmlFeatureStyle : IModelElement, IIdentifiedObject
    {
        
        /// <summary>
        /// The featureConstraint property
        /// </summary>
        string FeatureConstraint
        {
            get;
            set;
        }
        
        /// <summary>
        /// The semanticTypeIdentifier property
        /// </summary>
        string SemanticTypeIdentifier
        {
            get;
            set;
        }
        
        /// <summary>
        /// The version property
        /// </summary>
        string Version
        {
            get;
            set;
        }
        
        /// <summary>
        /// The featureTypeName property
        /// </summary>
        string FeatureTypeName
        {
            get;
            set;
        }
        
        /// <summary>
        /// The queryGrammar property
        /// </summary>
        Nullable<QueryGrammarKind> QueryGrammar
        {
            get;
            set;
        }
        
        /// <summary>
        /// The featureType property
        /// </summary>
        string FeatureType
        {
            get;
            set;
        }
        
        /// <summary>
        /// The baseType property
        /// </summary>
        string BaseType
        {
            get;
            set;
        }
        
        /// <summary>
        /// The GmlSymbols property
        /// </summary>
        IOrderedSetExpression<IGmlSymbol> GmlSymbols
        {
            get;
        }
        
        /// <summary>
        /// The GmlLabelStyles property
        /// </summary>
        IOrderedSetExpression<IGmlLabelStyle> GmlLabelStyles
        {
            get;
        }
        
        /// <summary>
        /// The GmlGeometryStyles property
        /// </summary>
        IOrderedSetExpression<IGmlGeometryStyle> GmlGeometryStyles
        {
            get;
        }
        
        /// <summary>
        /// The GmlFeatureTypes property
        /// </summary>
        IOrderedSetExpression<IGmlFeatureType> GmlFeatureTypes
        {
            get;
        }
        
        /// <summary>
        /// The GmlTobologyStyles property
        /// </summary>
        IOrderedSetExpression<IGmlTopologyStyle> GmlTobologyStyles
        {
            get;
        }
        
        /// <summary>
        /// Gets fired before the FeatureConstraint property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FeatureConstraintChanging;
        
        /// <summary>
        /// Gets fired when the FeatureConstraint property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FeatureConstraintChanged;
        
        /// <summary>
        /// Gets fired before the SemanticTypeIdentifier property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> SemanticTypeIdentifierChanging;
        
        /// <summary>
        /// Gets fired when the SemanticTypeIdentifier property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> SemanticTypeIdentifierChanged;
        
        /// <summary>
        /// Gets fired before the Version property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> VersionChanging;
        
        /// <summary>
        /// Gets fired when the Version property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> VersionChanged;
        
        /// <summary>
        /// Gets fired before the FeatureTypeName property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FeatureTypeNameChanging;
        
        /// <summary>
        /// Gets fired when the FeatureTypeName property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FeatureTypeNameChanged;
        
        /// <summary>
        /// Gets fired before the QueryGrammar property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> QueryGrammarChanging;
        
        /// <summary>
        /// Gets fired when the QueryGrammar property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> QueryGrammarChanged;
        
        /// <summary>
        /// Gets fired before the FeatureType property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FeatureTypeChanging;
        
        /// <summary>
        /// Gets fired when the FeatureType property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FeatureTypeChanged;
        
        /// <summary>
        /// Gets fired before the BaseType property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> BaseTypeChanging;
        
        /// <summary>
        /// Gets fired when the BaseType property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> BaseTypeChanged;
    }
}
