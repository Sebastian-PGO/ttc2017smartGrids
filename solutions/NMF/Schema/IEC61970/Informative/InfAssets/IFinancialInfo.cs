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
    /// The public interface for FinancialInfo
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(FinancialInfo))]
    [XmlDefaultImplementationTypeAttribute(typeof(FinancialInfo))]
    public interface IFinancialInfo : IModelElement, IIdentifiedObject
    {
        
        /// <summary>
        /// The costType property
        /// </summary>
        string CostType
        {
            get;
            set;
        }
        
        /// <summary>
        /// The costDescription property
        /// </summary>
        string CostDescription
        {
            get;
            set;
        }
        
        /// <summary>
        /// The account property
        /// </summary>
        string Account
        {
            get;
            set;
        }
        
        /// <summary>
        /// The plantTransferDateTime property
        /// </summary>
        DateTime PlantTransferDateTime
        {
            get;
            set;
        }
        
        /// <summary>
        /// The warrantyEndDateTime property
        /// </summary>
        DateTime WarrantyEndDateTime
        {
            get;
            set;
        }
        
        /// <summary>
        /// The actualPurchaseCost property
        /// </summary>
        float ActualPurchaseCost
        {
            get;
            set;
        }
        
        /// <summary>
        /// The purchaseDateTime property
        /// </summary>
        DateTime PurchaseDateTime
        {
            get;
            set;
        }
        
        /// <summary>
        /// The purchaseOrderNumber property
        /// </summary>
        string PurchaseOrderNumber
        {
            get;
            set;
        }
        
        /// <summary>
        /// The financialValue property
        /// </summary>
        float FinancialValue
        {
            get;
            set;
        }
        
        /// <summary>
        /// The quantity property
        /// </summary>
        object Quantity
        {
            get;
            set;
        }
        
        /// <summary>
        /// The valueDateTime property
        /// </summary>
        DateTime ValueDateTime
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Asset property
        /// </summary>
        IAsset Asset
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the CostType property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CostTypeChanging;
        
        /// <summary>
        /// Gets fired when the CostType property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CostTypeChanged;
        
        /// <summary>
        /// Gets fired before the CostDescription property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CostDescriptionChanging;
        
        /// <summary>
        /// Gets fired when the CostDescription property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CostDescriptionChanged;
        
        /// <summary>
        /// Gets fired before the Account property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AccountChanging;
        
        /// <summary>
        /// Gets fired when the Account property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AccountChanged;
        
        /// <summary>
        /// Gets fired before the PlantTransferDateTime property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PlantTransferDateTimeChanging;
        
        /// <summary>
        /// Gets fired when the PlantTransferDateTime property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PlantTransferDateTimeChanged;
        
        /// <summary>
        /// Gets fired before the WarrantyEndDateTime property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> WarrantyEndDateTimeChanging;
        
        /// <summary>
        /// Gets fired when the WarrantyEndDateTime property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> WarrantyEndDateTimeChanged;
        
        /// <summary>
        /// Gets fired before the ActualPurchaseCost property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ActualPurchaseCostChanging;
        
        /// <summary>
        /// Gets fired when the ActualPurchaseCost property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ActualPurchaseCostChanged;
        
        /// <summary>
        /// Gets fired before the PurchaseDateTime property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PurchaseDateTimeChanging;
        
        /// <summary>
        /// Gets fired when the PurchaseDateTime property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PurchaseDateTimeChanged;
        
        /// <summary>
        /// Gets fired before the PurchaseOrderNumber property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PurchaseOrderNumberChanging;
        
        /// <summary>
        /// Gets fired when the PurchaseOrderNumber property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PurchaseOrderNumberChanged;
        
        /// <summary>
        /// Gets fired before the FinancialValue property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FinancialValueChanging;
        
        /// <summary>
        /// Gets fired when the FinancialValue property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FinancialValueChanged;
        
        /// <summary>
        /// Gets fired before the Quantity property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> QuantityChanging;
        
        /// <summary>
        /// Gets fired when the Quantity property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> QuantityChanged;
        
        /// <summary>
        /// Gets fired before the ValueDateTime property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ValueDateTimeChanging;
        
        /// <summary>
        /// Gets fired when the ValueDateTime property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ValueDateTimeChanged;
        
        /// <summary>
        /// Gets fired before the Asset property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AssetChanging;
        
        /// <summary>
        /// Gets fired when the Asset property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AssetChanged;
    }
}

