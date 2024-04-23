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
using TTC2017.SmartGrids.CIM.IEC61970.Contingency;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Generation.Production;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.EnergyScheduling;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.Financial;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfERPSupport;
using TTC2017.SmartGrids.CIM.IEC61970.LoadModel;
using TTC2017.SmartGrids.CIM.IEC61970.Meas;
using TTC2017.SmartGrids.CIM.IEC61970.Wires;

namespace TTC2017.SmartGrids.CIM.IEC61970.Informative.MarketOperations
{
    
    
    /// <summary>
    /// The public interface for AncillaryServiceClearing
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(AncillaryServiceClearing))]
    [XmlDefaultImplementationTypeAttribute(typeof(AncillaryServiceClearing))]
    public interface IAncillaryServiceClearing : IModelElement, IMarketFactors
    {
        
        /// <summary>
        /// The mcp property
        /// </summary>
        float Mcp
        {
            get;
            set;
        }
        
        /// <summary>
        /// The clearedMW property
        /// </summary>
        float ClearedMW
        {
            get;
            set;
        }
        
        /// <summary>
        /// The commodityType property
        /// </summary>
        string CommodityType
        {
            get;
            set;
        }
        
        /// <summary>
        /// The MarketCaseClearing property
        /// </summary>
        IMarketCaseClearing MarketCaseClearing
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the Mcp property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> McpChanging;
        
        /// <summary>
        /// Gets fired when the Mcp property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> McpChanged;
        
        /// <summary>
        /// Gets fired before the ClearedMW property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ClearedMWChanging;
        
        /// <summary>
        /// Gets fired when the ClearedMW property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ClearedMWChanged;
        
        /// <summary>
        /// Gets fired before the CommodityType property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CommodityTypeChanging;
        
        /// <summary>
        /// Gets fired when the CommodityType property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CommodityTypeChanged;
        
        /// <summary>
        /// Gets fired before the MarketCaseClearing property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> MarketCaseClearingChanging;
        
        /// <summary>
        /// Gets fired when the MarketCaseClearing property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> MarketCaseClearingChanged;
    }
}

