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
    /// The public interface for ChargeProfileData
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(ChargeProfileData))]
    [XmlDefaultImplementationTypeAttribute(typeof(ChargeProfileData))]
    public interface IChargeProfileData : IModelElement, IElement
    {
        
        /// <summary>
        /// The sequence property
        /// </summary>
        int Sequence
        {
            get;
            set;
        }
        
        /// <summary>
        /// The timeStamp property
        /// </summary>
        DateTime TimeStamp
        {
            get;
            set;
        }
        
        /// <summary>
        /// The value property
        /// </summary>
        float Value
        {
            get;
            set;
        }
        
        /// <summary>
        /// The ChargeProfile property
        /// </summary>
        IChargeProfile ChargeProfile
        {
            get;
            set;
        }
        
        /// <summary>
        /// The BillDeterminant property
        /// </summary>
        IBillDeterminant BillDeterminant
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the Sequence property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> SequenceChanging;
        
        /// <summary>
        /// Gets fired when the Sequence property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> SequenceChanged;
        
        /// <summary>
        /// Gets fired before the TimeStamp property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TimeStampChanging;
        
        /// <summary>
        /// Gets fired when the TimeStamp property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TimeStampChanged;
        
        /// <summary>
        /// Gets fired before the Value property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ValueChanging;
        
        /// <summary>
        /// Gets fired when the Value property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ValueChanged;
        
        /// <summary>
        /// Gets fired before the ChargeProfile property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ChargeProfileChanging;
        
        /// <summary>
        /// Gets fired when the ChargeProfile property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ChargeProfileChanged;
        
        /// <summary>
        /// Gets fired before the BillDeterminant property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> BillDeterminantChanging;
        
        /// <summary>
        /// Gets fired when the BillDeterminant property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> BillDeterminantChanged;
    }
}

