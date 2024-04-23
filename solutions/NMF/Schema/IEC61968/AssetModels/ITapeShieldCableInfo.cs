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
using TTC2017.SmartGrids.CIM.IEC61968.Metering;
using TTC2017.SmartGrids.CIM.IEC61968.WiresExt;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssetModels;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssets;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfERPSupport;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfTypeAsset;
using TTC2017.SmartGrids.CIM.IEC61970.Wires;

namespace TTC2017.SmartGrids.CIM.IEC61968.AssetModels
{
    
    
    /// <summary>
    /// The public interface for TapeShieldCableInfo
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(TapeShieldCableInfo))]
    [XmlDefaultImplementationTypeAttribute(typeof(TapeShieldCableInfo))]
    public interface ITapeShieldCableInfo : IModelElement, ICableInfo
    {
        
        /// <summary>
        /// The tapeLap property
        /// </summary>
        float TapeLap
        {
            get;
            set;
        }
        
        /// <summary>
        /// The tapeThickness property
        /// </summary>
        float TapeThickness
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the TapeLap property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TapeLapChanging;
        
        /// <summary>
        /// Gets fired when the TapeLap property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TapeLapChanged;
        
        /// <summary>
        /// Gets fired before the TapeThickness property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TapeThicknessChanging;
        
        /// <summary>
        /// Gets fired when the TapeThickness property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TapeThicknessChanged;
    }
}

