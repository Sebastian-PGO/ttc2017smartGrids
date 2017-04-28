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
    /// The public interface for PoleInfo
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(PoleInfo))]
    [XmlDefaultImplementationTypeAttribute(typeof(PoleInfo))]
    public interface IPoleInfo : IModelElement, IStructureInfo
    {
        
        /// <summary>
        /// The treatedDateTime property
        /// </summary>
        DateTime TreatedDateTime
        {
            get;
            set;
        }
        
        /// <summary>
        /// The breastBlock property
        /// </summary>
        bool BreastBlock
        {
            get;
            set;
        }
        
        /// <summary>
        /// The classification property
        /// </summary>
        string Classification
        {
            get;
            set;
        }
        
        /// <summary>
        /// The preservativeKind property
        /// </summary>
        Nullable<PolePreservativeKind> PreservativeKind
        {
            get;
            set;
        }
        
        /// <summary>
        /// The jpaReference property
        /// </summary>
        string JpaReference
        {
            get;
            set;
        }
        
        /// <summary>
        /// The baseKind property
        /// </summary>
        Nullable<PoleBaseKind> BaseKind
        {
            get;
            set;
        }
        
        /// <summary>
        /// The diameter property
        /// </summary>
        float Diameter
        {
            get;
            set;
        }
        
        /// <summary>
        /// The treatmentKind property
        /// </summary>
        Nullable<PoleTreatmentKind> TreatmentKind
        {
            get;
            set;
        }
        
        /// <summary>
        /// The construction property
        /// </summary>
        string Construction
        {
            get;
            set;
        }
        
        /// <summary>
        /// The length property
        /// </summary>
        float Length
        {
            get;
            set;
        }
        
        /// <summary>
        /// The speciesType property
        /// </summary>
        string SpeciesType
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Streetlights property
        /// </summary>
        IOrderedSetExpression<IStreetlightInfo> Streetlights
        {
            get;
        }
        
        /// <summary>
        /// Gets fired before the TreatedDateTime property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TreatedDateTimeChanging;
        
        /// <summary>
        /// Gets fired when the TreatedDateTime property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TreatedDateTimeChanged;
        
        /// <summary>
        /// Gets fired before the BreastBlock property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> BreastBlockChanging;
        
        /// <summary>
        /// Gets fired when the BreastBlock property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> BreastBlockChanged;
        
        /// <summary>
        /// Gets fired before the Classification property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ClassificationChanging;
        
        /// <summary>
        /// Gets fired when the Classification property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ClassificationChanged;
        
        /// <summary>
        /// Gets fired before the PreservativeKind property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PreservativeKindChanging;
        
        /// <summary>
        /// Gets fired when the PreservativeKind property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PreservativeKindChanged;
        
        /// <summary>
        /// Gets fired before the JpaReference property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> JpaReferenceChanging;
        
        /// <summary>
        /// Gets fired when the JpaReference property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> JpaReferenceChanged;
        
        /// <summary>
        /// Gets fired before the BaseKind property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> BaseKindChanging;
        
        /// <summary>
        /// Gets fired when the BaseKind property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> BaseKindChanged;
        
        /// <summary>
        /// Gets fired before the Diameter property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DiameterChanging;
        
        /// <summary>
        /// Gets fired when the Diameter property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DiameterChanged;
        
        /// <summary>
        /// Gets fired before the TreatmentKind property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TreatmentKindChanging;
        
        /// <summary>
        /// Gets fired when the TreatmentKind property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TreatmentKindChanged;
        
        /// <summary>
        /// Gets fired before the Construction property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ConstructionChanging;
        
        /// <summary>
        /// Gets fired when the Construction property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ConstructionChanged;
        
        /// <summary>
        /// Gets fired before the Length property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LengthChanging;
        
        /// <summary>
        /// Gets fired when the Length property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LengthChanged;
        
        /// <summary>
        /// Gets fired before the SpeciesType property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> SpeciesTypeChanging;
        
        /// <summary>
        /// Gets fired when the SpeciesType property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> SpeciesTypeChanged;
    }
}

