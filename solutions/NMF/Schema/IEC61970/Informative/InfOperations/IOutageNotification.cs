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
using TTC2017.SmartGrids.CIM.IEC61968.Assets;
using TTC2017.SmartGrids.CIM.IEC61968.Common;
using TTC2017.SmartGrids.CIM.IEC61968.Customers;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssets;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfCommon;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfCustomers;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfERPSupport;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfGMLSupport;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfWork;
using TTC2017.SmartGrids.CIM.IEC61970.Outage;

namespace TTC2017.SmartGrids.CIM.IEC61970.Informative.InfOperations
{
    
    
    /// <summary>
    /// The public interface for OutageNotification
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(OutageNotification))]
    [XmlDefaultImplementationTypeAttribute(typeof(OutageNotification))]
    public interface IOutageNotification : IModelElement, IDocument
    {
        
        /// <summary>
        /// The expectedInterruptionCount property
        /// </summary>
        int ExpectedInterruptionCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// The duration property
        /// </summary>
        float Duration
        {
            get;
            set;
        }
        
        /// <summary>
        /// The reason property
        /// </summary>
        string Reason
        {
            get;
            set;
        }
        
        /// <summary>
        /// The CustomerDatas property
        /// </summary>
        IOrderedSetExpression<ICustomer> CustomerDatas
        {
            get;
        }
        
        /// <summary>
        /// Gets fired before the ExpectedInterruptionCount property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ExpectedInterruptionCountChanging;
        
        /// <summary>
        /// Gets fired when the ExpectedInterruptionCount property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ExpectedInterruptionCountChanged;
        
        /// <summary>
        /// Gets fired before the Duration property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DurationChanging;
        
        /// <summary>
        /// Gets fired when the Duration property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DurationChanged;
        
        /// <summary>
        /// Gets fired before the Reason property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ReasonChanging;
        
        /// <summary>
        /// Gets fired when the Reason property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ReasonChanged;
    }
}

