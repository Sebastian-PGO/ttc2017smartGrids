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
using TTC2017.SmartGrids.CIM.IEC61968.Common;
using TTC2017.SmartGrids.CIM.IEC61968.Metering;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssets;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfERPSupport;

namespace TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssetModels
{
    
    
    /// <summary>
    /// The public interface for TransformerAssetModel
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(TransformerAssetModel))]
    [XmlDefaultImplementationTypeAttribute(typeof(TransformerAssetModel))]
    public interface ITransformerAssetModel : IModelElement, IAssetModel
    {
        
        /// <summary>
        /// The hourOverLoadRating property
        /// </summary>
        float HourOverLoadRating
        {
            get;
            set;
        }
        
        /// <summary>
        /// The oilPreservationKind property
        /// </summary>
        Nullable<OilPreservationKind> OilPreservationKind
        {
            get;
            set;
        }
        
        /// <summary>
        /// The coreCoilsWeight property
        /// </summary>
        float CoreCoilsWeight
        {
            get;
            set;
        }
        
        /// <summary>
        /// The windingInsulationKind property
        /// </summary>
        Nullable<WindingInsulationKind> WindingInsulationKind
        {
            get;
            set;
        }
        
        /// <summary>
        /// The altSecondaryNomVoltage property
        /// </summary>
        float AltSecondaryNomVoltage
        {
            get;
            set;
        }
        
        /// <summary>
        /// The solidInsulationWeight property
        /// </summary>
        float SolidInsulationWeight
        {
            get;
            set;
        }
        
        /// <summary>
        /// The neutralBIL property
        /// </summary>
        float NeutralBIL
        {
            get;
            set;
        }
        
        /// <summary>
        /// The coreKind property
        /// </summary>
        Nullable<TransformerCoreKind> CoreKind
        {
            get;
            set;
        }
        
        /// <summary>
        /// The dayOverLoadRating property
        /// </summary>
        float DayOverLoadRating
        {
            get;
            set;
        }
        
        /// <summary>
        /// The function property
        /// </summary>
        Nullable<TransformerFunctionKind> Function
        {
            get;
            set;
        }
        
        /// <summary>
        /// The constructionKind property
        /// </summary>
        Nullable<TransformerConstructionKind> ConstructionKind
        {
            get;
            set;
        }
        
        /// <summary>
        /// The autoTransformer property
        /// </summary>
        bool AutoTransformer
        {
            get;
            set;
        }
        
        /// <summary>
        /// The altPrimaryNomVoltage property
        /// </summary>
        float AltPrimaryNomVoltage
        {
            get;
            set;
        }
        
        /// <summary>
        /// The reconfigWinding property
        /// </summary>
        bool ReconfigWinding
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
        /// The TransformerAssets property
        /// </summary>
        IOrderedSetExpression<ITransformerAsset> TransformerAssets
        {
            get;
        }
        
        /// <summary>
        /// Gets fired before the HourOverLoadRating property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> HourOverLoadRatingChanging;
        
        /// <summary>
        /// Gets fired when the HourOverLoadRating property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> HourOverLoadRatingChanged;
        
        /// <summary>
        /// Gets fired before the OilPreservationKind property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> OilPreservationKindChanging;
        
        /// <summary>
        /// Gets fired when the OilPreservationKind property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> OilPreservationKindChanged;
        
        /// <summary>
        /// Gets fired before the CoreCoilsWeight property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CoreCoilsWeightChanging;
        
        /// <summary>
        /// Gets fired when the CoreCoilsWeight property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CoreCoilsWeightChanged;
        
        /// <summary>
        /// Gets fired before the WindingInsulationKind property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> WindingInsulationKindChanging;
        
        /// <summary>
        /// Gets fired when the WindingInsulationKind property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> WindingInsulationKindChanged;
        
        /// <summary>
        /// Gets fired before the AltSecondaryNomVoltage property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AltSecondaryNomVoltageChanging;
        
        /// <summary>
        /// Gets fired when the AltSecondaryNomVoltage property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AltSecondaryNomVoltageChanged;
        
        /// <summary>
        /// Gets fired before the SolidInsulationWeight property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> SolidInsulationWeightChanging;
        
        /// <summary>
        /// Gets fired when the SolidInsulationWeight property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> SolidInsulationWeightChanged;
        
        /// <summary>
        /// Gets fired before the NeutralBIL property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> NeutralBILChanging;
        
        /// <summary>
        /// Gets fired when the NeutralBIL property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> NeutralBILChanged;
        
        /// <summary>
        /// Gets fired before the CoreKind property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CoreKindChanging;
        
        /// <summary>
        /// Gets fired when the CoreKind property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CoreKindChanged;
        
        /// <summary>
        /// Gets fired before the DayOverLoadRating property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DayOverLoadRatingChanging;
        
        /// <summary>
        /// Gets fired when the DayOverLoadRating property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DayOverLoadRatingChanged;
        
        /// <summary>
        /// Gets fired before the Function property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FunctionChanging;
        
        /// <summary>
        /// Gets fired when the Function property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FunctionChanged;
        
        /// <summary>
        /// Gets fired before the ConstructionKind property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ConstructionKindChanging;
        
        /// <summary>
        /// Gets fired when the ConstructionKind property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ConstructionKindChanged;
        
        /// <summary>
        /// Gets fired before the AutoTransformer property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AutoTransformerChanging;
        
        /// <summary>
        /// Gets fired when the AutoTransformer property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AutoTransformerChanged;
        
        /// <summary>
        /// Gets fired before the AltPrimaryNomVoltage property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AltPrimaryNomVoltageChanging;
        
        /// <summary>
        /// Gets fired when the AltPrimaryNomVoltage property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AltPrimaryNomVoltageChanged;
        
        /// <summary>
        /// Gets fired before the ReconfigWinding property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ReconfigWindingChanging;
        
        /// <summary>
        /// Gets fired when the ReconfigWinding property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ReconfigWindingChanged;
        
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

