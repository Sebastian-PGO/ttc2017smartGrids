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
    /// The public interface for DesignLocation
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(DesignLocation))]
    [XmlDefaultImplementationTypeAttribute(typeof(DesignLocation))]
    public interface IDesignLocation : IModelElement, IIdentifiedObject
    {
        
        /// <summary>
        /// The spanLength property
        /// </summary>
        float SpanLength
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
        /// The MaterialItems property
        /// </summary>
        IOrderedSetExpression<IMaterialItem> MaterialItems
        {
            get;
        }
        
        /// <summary>
        /// The status property
        /// </summary>
        IStatus Status
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Diagrams property
        /// </summary>
        IOrderedSetExpression<IDiagram> Diagrams
        {
            get;
        }
        
        /// <summary>
        /// The WorkLocations property
        /// </summary>
        IOrderedSetExpression<IWorkLocation> WorkLocations
        {
            get;
        }
        
        /// <summary>
        /// The DesignLocationCUs property
        /// </summary>
        IOrderedSetExpression<IDesignLocationCU> DesignLocationCUs
        {
            get;
        }
        
        /// <summary>
        /// The Designs property
        /// </summary>
        IOrderedSetExpression<IDesign> Designs
        {
            get;
        }
        
        /// <summary>
        /// The ErpBomItemDatas property
        /// </summary>
        IOrderedSetExpression<IErpBomItemData> ErpBomItemDatas
        {
            get;
        }
        
        /// <summary>
        /// The MiscCostItems property
        /// </summary>
        IOrderedSetExpression<IMiscCostItem> MiscCostItems
        {
            get;
        }
        
        /// <summary>
        /// Gets fired before the SpanLength property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> SpanLengthChanging;
        
        /// <summary>
        /// Gets fired when the SpanLength property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> SpanLengthChanged;
        
        /// <summary>
        /// Gets fired before the Status property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> StatusChanging;
        
        /// <summary>
        /// Gets fired when the Status property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> StatusChanged;
    }
}

