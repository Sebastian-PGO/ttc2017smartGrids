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
    /// The public interface for CurrentTransformerInfo
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(CurrentTransformerInfo))]
    [XmlDefaultImplementationTypeAttribute(typeof(CurrentTransformerInfo))]
    public interface ICurrentTransformerInfo : IModelElement, IElectricalInfo
    {
        
        /// <summary>
        /// The accuracyClass property
        /// </summary>
        string AccuracyClass
        {
            get;
            set;
        }
        
        /// <summary>
        /// The ctClass property
        /// </summary>
        string CtClass
        {
            get;
            set;
        }
        
        /// <summary>
        /// The coreBurden property
        /// </summary>
        float CoreBurden
        {
            get;
            set;
        }
        
        /// <summary>
        /// The primaryFlsRating property
        /// </summary>
        float PrimaryFlsRating
        {
            get;
            set;
        }
        
        /// <summary>
        /// The accuracyLimit property
        /// </summary>
        float AccuracyLimit
        {
            get;
            set;
        }
        
        /// <summary>
        /// The kneePointCurrent property
        /// </summary>
        float KneePointCurrent
        {
            get;
            set;
        }
        
        /// <summary>
        /// The usage property
        /// </summary>
        string Usage
        {
            get;
            set;
        }
        
        /// <summary>
        /// The secondaryFlsRating property
        /// </summary>
        float SecondaryFlsRating
        {
            get;
            set;
        }
        
        /// <summary>
        /// The tertiaryFlsRating property
        /// </summary>
        float TertiaryFlsRating
        {
            get;
            set;
        }
        
        /// <summary>
        /// The coreCount property
        /// </summary>
        int CoreCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// The kneePointVoltage property
        /// </summary>
        float KneePointVoltage
        {
            get;
            set;
        }
        
        /// <summary>
        /// The maxRatio property
        /// </summary>
        IRatio MaxRatio
        {
            get;
            set;
        }
        
        /// <summary>
        /// The primaryRatio property
        /// </summary>
        IRatio PrimaryRatio
        {
            get;
            set;
        }
        
        /// <summary>
        /// The tertiaryRatio property
        /// </summary>
        IRatio TertiaryRatio
        {
            get;
            set;
        }
        
        /// <summary>
        /// The nominalRatio property
        /// </summary>
        IRatio NominalRatio
        {
            get;
            set;
        }
        
        /// <summary>
        /// The secondaryRatio property
        /// </summary>
        IRatio SecondaryRatio
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the AccuracyClass property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AccuracyClassChanging;
        
        /// <summary>
        /// Gets fired when the AccuracyClass property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AccuracyClassChanged;
        
        /// <summary>
        /// Gets fired before the CtClass property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CtClassChanging;
        
        /// <summary>
        /// Gets fired when the CtClass property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CtClassChanged;
        
        /// <summary>
        /// Gets fired before the CoreBurden property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CoreBurdenChanging;
        
        /// <summary>
        /// Gets fired when the CoreBurden property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CoreBurdenChanged;
        
        /// <summary>
        /// Gets fired before the PrimaryFlsRating property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PrimaryFlsRatingChanging;
        
        /// <summary>
        /// Gets fired when the PrimaryFlsRating property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PrimaryFlsRatingChanged;
        
        /// <summary>
        /// Gets fired before the AccuracyLimit property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AccuracyLimitChanging;
        
        /// <summary>
        /// Gets fired when the AccuracyLimit property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AccuracyLimitChanged;
        
        /// <summary>
        /// Gets fired before the KneePointCurrent property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> KneePointCurrentChanging;
        
        /// <summary>
        /// Gets fired when the KneePointCurrent property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> KneePointCurrentChanged;
        
        /// <summary>
        /// Gets fired before the Usage property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> UsageChanging;
        
        /// <summary>
        /// Gets fired when the Usage property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> UsageChanged;
        
        /// <summary>
        /// Gets fired before the SecondaryFlsRating property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> SecondaryFlsRatingChanging;
        
        /// <summary>
        /// Gets fired when the SecondaryFlsRating property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> SecondaryFlsRatingChanged;
        
        /// <summary>
        /// Gets fired before the TertiaryFlsRating property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TertiaryFlsRatingChanging;
        
        /// <summary>
        /// Gets fired when the TertiaryFlsRating property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TertiaryFlsRatingChanged;
        
        /// <summary>
        /// Gets fired before the CoreCount property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CoreCountChanging;
        
        /// <summary>
        /// Gets fired when the CoreCount property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CoreCountChanged;
        
        /// <summary>
        /// Gets fired before the KneePointVoltage property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> KneePointVoltageChanging;
        
        /// <summary>
        /// Gets fired when the KneePointVoltage property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> KneePointVoltageChanged;
        
        /// <summary>
        /// Gets fired before the MaxRatio property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> MaxRatioChanging;
        
        /// <summary>
        /// Gets fired when the MaxRatio property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> MaxRatioChanged;
        
        /// <summary>
        /// Gets fired before the PrimaryRatio property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PrimaryRatioChanging;
        
        /// <summary>
        /// Gets fired when the PrimaryRatio property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PrimaryRatioChanged;
        
        /// <summary>
        /// Gets fired before the TertiaryRatio property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TertiaryRatioChanging;
        
        /// <summary>
        /// Gets fired when the TertiaryRatio property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TertiaryRatioChanged;
        
        /// <summary>
        /// Gets fired before the NominalRatio property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> NominalRatioChanging;
        
        /// <summary>
        /// Gets fired when the NominalRatio property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> NominalRatioChanged;
        
        /// <summary>
        /// Gets fired before the SecondaryRatio property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> SecondaryRatioChanging;
        
        /// <summary>
        /// Gets fired when the SecondaryRatio property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> SecondaryRatioChanged;
    }
}

