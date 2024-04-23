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
using TTC2017.SmartGrids.CIM.IEC61968.AssetModels;
using TTC2017.SmartGrids.CIM.IEC61968.Assets;
using TTC2017.SmartGrids.CIM.IEC61968.Common;
using TTC2017.SmartGrids.CIM.IEC61968.Metering;
using TTC2017.SmartGrids.CIM.IEC61968.WiresExt;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssetModels;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfCommon;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfERPSupport;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfOperations;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfTypeAsset;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfWork;
using TTC2017.SmartGrids.CIM.IEC61970.Meas;
using TTC2017.SmartGrids.CIM.IEC61970.Wires;

namespace TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssets
{
    
    
    /// <summary>
    /// The public interface for TransformerAsset
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(TransformerAsset))]
    [XmlDefaultImplementationTypeAttribute(typeof(TransformerAsset))]
    public interface ITransformerAsset : IModelElement, IAsset
    {
        
        /// <summary>
        /// The reconditionedDateTime property
        /// </summary>
        DateTime ReconditionedDateTime
        {
            get;
            set;
        }
        
        /// <summary>
        /// The PowerRatings property
        /// </summary>
        IOrderedSetExpression<IPowerRating> PowerRatings
        {
            get;
        }
        
        /// <summary>
        /// The TransformerObservations property
        /// </summary>
        IOrderedSetExpression<ITransformerObservation> TransformerObservations
        {
            get;
        }
        
        /// <summary>
        /// The TransformerAssetModel property
        /// </summary>
        ITransformerAssetModel TransformerAssetModel
        {
            get;
            set;
        }
        
        /// <summary>
        /// The TransformerInfo property
        /// </summary>
        ITransformerInfo TransformerInfo
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the ReconditionedDateTime property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ReconditionedDateTimeChanging;
        
        /// <summary>
        /// Gets fired when the ReconditionedDateTime property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ReconditionedDateTimeChanged;
        
        /// <summary>
        /// Gets fired before the TransformerAssetModel property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TransformerAssetModelChanging;
        
        /// <summary>
        /// Gets fired when the TransformerAssetModel property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TransformerAssetModelChanged;
        
        /// <summary>
        /// Gets fired before the TransformerInfo property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TransformerInfoChanging;
        
        /// <summary>
        /// Gets fired when the TransformerInfo property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TransformerInfoChanged;
    }
}

