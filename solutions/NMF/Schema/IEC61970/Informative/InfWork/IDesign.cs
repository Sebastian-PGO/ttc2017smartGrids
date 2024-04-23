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
using TTC2017.SmartGrids.CIM.IEC61968.Assets;
using TTC2017.SmartGrids.CIM.IEC61968.Common;
using TTC2017.SmartGrids.CIM.IEC61968.Work;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssets;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfCommon;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfERPSupport;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfGMLSupport;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfLocations;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfOperations;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfTypeAsset;

namespace TTC2017.SmartGrids.CIM.IEC61970.Informative.InfWork
{
    
    
    /// <summary>
    /// The public interface for Design
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(Design))]
    [XmlDefaultImplementationTypeAttribute(typeof(Design))]
    public interface IDesign : IModelElement, IDocument
    {
        
        /// <summary>
        /// The costEstimate property
        /// </summary>
        float CostEstimate
        {
            get;
            set;
        }
        
        /// <summary>
        /// The kind property
        /// </summary>
        Nullable<DesignKind> Kind
        {
            get;
            set;
        }
        
        /// <summary>
        /// The price property
        /// </summary>
        float Price
        {
            get;
            set;
        }
        
        /// <summary>
        /// The DesignLocations property
        /// </summary>
        IOrderedSetExpression<IDesignLocation> DesignLocations
        {
            get;
        }
        
        /// <summary>
        /// The DesignLocationsCUs property
        /// </summary>
        IOrderedSetExpression<IDesignLocationCU> DesignLocationsCUs
        {
            get;
        }
        
        /// <summary>
        /// The Work property
        /// </summary>
        IWork Work
        {
            get;
            set;
        }
        
        /// <summary>
        /// The WorkCostDetails property
        /// </summary>
        IOrderedSetExpression<IWorkCostDetail> WorkCostDetails
        {
            get;
        }
        
        /// <summary>
        /// The ErpBOMs property
        /// </summary>
        IOrderedSetExpression<IErpBOM> ErpBOMs
        {
            get;
        }
        
        /// <summary>
        /// The ErpQuoteLineItem property
        /// </summary>
        IErpQuoteLineItem ErpQuoteLineItem
        {
            get;
            set;
        }
        
        /// <summary>
        /// The ConditionFactors property
        /// </summary>
        IOrderedSetExpression<IConditionFactor> ConditionFactors
        {
            get;
        }
        
        /// <summary>
        /// The WorkTasks property
        /// </summary>
        IOrderedSetExpression<IWorkTask> WorkTasks
        {
            get;
        }
        
        /// <summary>
        /// Gets fired before the CostEstimate property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CostEstimateChanging;
        
        /// <summary>
        /// Gets fired when the CostEstimate property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CostEstimateChanged;
        
        /// <summary>
        /// Gets fired before the Kind property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> KindChanging;
        
        /// <summary>
        /// Gets fired when the Kind property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> KindChanged;
        
        /// <summary>
        /// Gets fired before the Price property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PriceChanging;
        
        /// <summary>
        /// Gets fired when the Price property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PriceChanged;
        
        /// <summary>
        /// Gets fired before the Work property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> WorkChanging;
        
        /// <summary>
        /// Gets fired when the Work property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> WorkChanged;
        
        /// <summary>
        /// Gets fired before the ErpQuoteLineItem property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ErpQuoteLineItemChanging;
        
        /// <summary>
        /// Gets fired when the ErpQuoteLineItem property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ErpQuoteLineItemChanged;
    }
}

