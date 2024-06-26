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
using TTC2017.SmartGrids.CIM.IEC61968.Assets;
using TTC2017.SmartGrids.CIM.IEC61968.PaymentMetering;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssets;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfCommon;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfERPSupport;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfGMLSupport;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfLocations;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfOperations;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfWork;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.MarketOperations;
using TTC2017.SmartGrids.CIM.IEC61970.Meas;

namespace TTC2017.SmartGrids.CIM.IEC61968.Common
{
    
    
    /// <summary>
    /// The public interface for StreetDetail
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(StreetDetail))]
    [XmlDefaultImplementationTypeAttribute(typeof(StreetDetail))]
    public interface IStreetDetail : IModelElement, IElement
    {
        
        /// <summary>
        /// The name property
        /// </summary>
        string Name
        {
            get;
            set;
        }
        
        /// <summary>
        /// The prefix property
        /// </summary>
        string Prefix
        {
            get;
            set;
        }
        
        /// <summary>
        /// The buildingName property
        /// </summary>
        string BuildingName
        {
            get;
            set;
        }
        
        /// <summary>
        /// The suiteNumber property
        /// </summary>
        string SuiteNumber
        {
            get;
            set;
        }
        
        /// <summary>
        /// The withinTownLimits property
        /// </summary>
        bool WithinTownLimits
        {
            get;
            set;
        }
        
        /// <summary>
        /// The addressGeneral property
        /// </summary>
        string AddressGeneral
        {
            get;
            set;
        }
        
        /// <summary>
        /// The number property
        /// </summary>
        string Number
        {
            get;
            set;
        }
        
        /// <summary>
        /// The suffix property
        /// </summary>
        string Suffix
        {
            get;
            set;
        }
        
        /// <summary>
        /// The type property
        /// </summary>
        string Type
        {
            get;
            set;
        }
        
        /// <summary>
        /// The code property
        /// </summary>
        string Code
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the Name property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> NameChanging;
        
        /// <summary>
        /// Gets fired when the Name property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> NameChanged;
        
        /// <summary>
        /// Gets fired before the Prefix property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PrefixChanging;
        
        /// <summary>
        /// Gets fired when the Prefix property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PrefixChanged;
        
        /// <summary>
        /// Gets fired before the BuildingName property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> BuildingNameChanging;
        
        /// <summary>
        /// Gets fired when the BuildingName property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> BuildingNameChanged;
        
        /// <summary>
        /// Gets fired before the SuiteNumber property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> SuiteNumberChanging;
        
        /// <summary>
        /// Gets fired when the SuiteNumber property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> SuiteNumberChanged;
        
        /// <summary>
        /// Gets fired before the WithinTownLimits property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> WithinTownLimitsChanging;
        
        /// <summary>
        /// Gets fired when the WithinTownLimits property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> WithinTownLimitsChanged;
        
        /// <summary>
        /// Gets fired before the AddressGeneral property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AddressGeneralChanging;
        
        /// <summary>
        /// Gets fired when the AddressGeneral property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AddressGeneralChanged;
        
        /// <summary>
        /// Gets fired before the Number property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> NumberChanging;
        
        /// <summary>
        /// Gets fired when the Number property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> NumberChanged;
        
        /// <summary>
        /// Gets fired before the Suffix property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> SuffixChanging;
        
        /// <summary>
        /// Gets fired when the Suffix property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> SuffixChanged;
        
        /// <summary>
        /// Gets fired before the Type property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TypeChanging;
        
        /// <summary>
        /// Gets fired when the Type property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TypeChanged;
        
        /// <summary>
        /// Gets fired before the Code property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CodeChanging;
        
        /// <summary>
        /// Gets fired when the Code property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CodeChanged;
    }
}

