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
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssets;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfCommon;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfERPSupport;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfLocations;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfOperations;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfWork;
using TTC2017.SmartGrids.CIM.IEC61970.Meas;

namespace TTC2017.SmartGrids.CIM.IEC61968.Assets
{
    
    
    /// <summary>
    /// The public interface for Seal
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(Seal))]
    [XmlDefaultImplementationTypeAttribute(typeof(Seal))]
    public interface ISeal : IModelElement, IIdentifiedObject
    {
        
        /// <summary>
        /// The condition property
        /// </summary>
        Nullable<SealConditionKind> Condition
        {
            get;
            set;
        }
        
        /// <summary>
        /// The sealNumber property
        /// </summary>
        string SealNumber
        {
            get;
            set;
        }
        
        /// <summary>
        /// The appliedDateTime property
        /// </summary>
        DateTime AppliedDateTime
        {
            get;
            set;
        }
        
        /// <summary>
        /// The kind property
        /// </summary>
        Nullable<SealKind> Kind
        {
            get;
            set;
        }
        
        /// <summary>
        /// The AssetContainer property
        /// </summary>
        IAssetContainer AssetContainer
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the Condition property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ConditionChanging;
        
        /// <summary>
        /// Gets fired when the Condition property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ConditionChanged;
        
        /// <summary>
        /// Gets fired before the SealNumber property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> SealNumberChanging;
        
        /// <summary>
        /// Gets fired when the SealNumber property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> SealNumberChanged;
        
        /// <summary>
        /// Gets fired before the AppliedDateTime property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AppliedDateTimeChanging;
        
        /// <summary>
        /// Gets fired when the AppliedDateTime property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AppliedDateTimeChanged;
        
        /// <summary>
        /// Gets fired before the Kind property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> KindChanging;
        
        /// <summary>
        /// Gets fired when the Kind property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> KindChanged;
        
        /// <summary>
        /// Gets fired before the AssetContainer property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AssetContainerChanging;
        
        /// <summary>
        /// Gets fired when the AssetContainer property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AssetContainerChanged;
    }
}

