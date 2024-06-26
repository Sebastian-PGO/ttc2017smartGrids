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
using TTC2017.SmartGrids.CIM.IEC61968.AssetModels;
using TTC2017.SmartGrids.CIM.IEC61968.Assets;
using TTC2017.SmartGrids.CIM.IEC61968.Common;
using TTC2017.SmartGrids.CIM.IEC61968.Customers;
using TTC2017.SmartGrids.CIM.IEC61968.PaymentMetering;
using TTC2017.SmartGrids.CIM.IEC61968.WiresExt;
using TTC2017.SmartGrids.CIM.IEC61968.Work;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Domain;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssetModels;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssets;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfCustomers;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfMetering;
using TTC2017.SmartGrids.CIM.IEC61970.Meas;
using TTC2017.SmartGrids.CIM.IEC61970.Wires;

namespace TTC2017.SmartGrids.CIM.IEC61968.Metering
{
    
    
    /// <summary>
    /// The public interface for MeterServiceWork
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(MeterServiceWork))]
    [XmlDefaultImplementationTypeAttribute(typeof(MeterServiceWork))]
    public interface IMeterServiceWork : IModelElement, IWork
    {
        
        /// <summary>
        /// The OldMeterAsset property
        /// </summary>
        IMeterAsset OldMeterAsset
        {
            get;
            set;
        }
        
        /// <summary>
        /// The MeterAsset property
        /// </summary>
        IMeterAsset MeterAsset
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the OldMeterAsset property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> OldMeterAssetChanging;
        
        /// <summary>
        /// Gets fired when the OldMeterAsset property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> OldMeterAssetChanged;
        
        /// <summary>
        /// Gets fired before the MeterAsset property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> MeterAssetChanging;
        
        /// <summary>
        /// Gets fired when the MeterAsset property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> MeterAssetChanged;
    }
}

