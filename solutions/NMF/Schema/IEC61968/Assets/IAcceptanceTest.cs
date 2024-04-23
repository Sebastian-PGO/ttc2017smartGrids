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
    /// The public interface for AcceptanceTest
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(AcceptanceTest))]
    [XmlDefaultImplementationTypeAttribute(typeof(AcceptanceTest))]
    public interface IAcceptanceTest : IModelElement, IElement
    {
        
        /// <summary>
        /// The dateTime property
        /// </summary>
        DateTime DateTime
        {
            get;
            set;
        }
        
        /// <summary>
        /// The success property
        /// </summary>
        bool Success
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
        /// Gets fired before the DateTime property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DateTimeChanging;
        
        /// <summary>
        /// Gets fired when the DateTime property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DateTimeChanged;
        
        /// <summary>
        /// Gets fired before the Success property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> SuccessChanging;
        
        /// <summary>
        /// Gets fired when the Success property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> SuccessChanged;
        
        /// <summary>
        /// Gets fired before the Type property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TypeChanging;
        
        /// <summary>
        /// Gets fired when the Type property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TypeChanged;
    }
}

