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
using TTC2017.SmartGrids.CIM.IEC61968.Customers;
using TTC2017.SmartGrids.CIM.IEC61968.Metering;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Domain;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfCommon;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfPaymentMetering;

namespace TTC2017.SmartGrids.CIM.IEC61968.PaymentMetering
{
    
    
    /// <summary>
    /// The public interface for Transaction
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(Transaction))]
    [XmlDefaultImplementationTypeAttribute(typeof(Transaction))]
    public interface ITransaction : IModelElement, IIdentifiedObject
    {
        
        /// <summary>
        /// The kind property
        /// </summary>
        Nullable<TransactionKind> Kind
        {
            get;
            set;
        }
        
        /// <summary>
        /// The serviceUnitsError property
        /// </summary>
        float ServiceUnitsError
        {
            get;
            set;
        }
        
        /// <summary>
        /// The reversedId property
        /// </summary>
        string ReversedId
        {
            get;
            set;
        }
        
        /// <summary>
        /// The receiverReference property
        /// </summary>
        string ReceiverReference
        {
            get;
            set;
        }
        
        /// <summary>
        /// The donorReference property
        /// </summary>
        string DonorReference
        {
            get;
            set;
        }
        
        /// <summary>
        /// The serviceUnitsEnergy property
        /// </summary>
        float ServiceUnitsEnergy
        {
            get;
            set;
        }
        
        /// <summary>
        /// The diverseReference property
        /// </summary>
        string DiverseReference
        {
            get;
            set;
        }
        
        /// <summary>
        /// The UserAttributes property
        /// </summary>
        IOrderedSetExpression<IUserAttribute> UserAttributes
        {
            get;
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
        /// The line property
        /// </summary>
        ILineDetail Line
        {
            get;
            set;
        }
        
        /// <summary>
        /// The VendorShift property
        /// </summary>
        IVendorShift VendorShift
        {
            get;
            set;
        }
        
        /// <summary>
        /// The CashierShift property
        /// </summary>
        ICashierShift CashierShift
        {
            get;
            set;
        }
        
        /// <summary>
        /// The AuxiliaryAccount property
        /// </summary>
        IAuxiliaryAccount AuxiliaryAccount
        {
            get;
            set;
        }
        
        /// <summary>
        /// The PricingStructure property
        /// </summary>
        IPricingStructure PricingStructure
        {
            get;
            set;
        }
        
        /// <summary>
        /// The CustomerAccount property
        /// </summary>
        ICustomerAccount CustomerAccount
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Receipt property
        /// </summary>
        IReceipt Receipt
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the Kind property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> KindChanging;
        
        /// <summary>
        /// Gets fired when the Kind property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> KindChanged;
        
        /// <summary>
        /// Gets fired before the ServiceUnitsError property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ServiceUnitsErrorChanging;
        
        /// <summary>
        /// Gets fired when the ServiceUnitsError property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ServiceUnitsErrorChanged;
        
        /// <summary>
        /// Gets fired before the ReversedId property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ReversedIdChanging;
        
        /// <summary>
        /// Gets fired when the ReversedId property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ReversedIdChanged;
        
        /// <summary>
        /// Gets fired before the ReceiverReference property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ReceiverReferenceChanging;
        
        /// <summary>
        /// Gets fired when the ReceiverReference property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ReceiverReferenceChanged;
        
        /// <summary>
        /// Gets fired before the DonorReference property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DonorReferenceChanging;
        
        /// <summary>
        /// Gets fired when the DonorReference property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DonorReferenceChanged;
        
        /// <summary>
        /// Gets fired before the ServiceUnitsEnergy property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ServiceUnitsEnergyChanging;
        
        /// <summary>
        /// Gets fired when the ServiceUnitsEnergy property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ServiceUnitsEnergyChanged;
        
        /// <summary>
        /// Gets fired before the DiverseReference property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DiverseReferenceChanging;
        
        /// <summary>
        /// Gets fired when the DiverseReference property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DiverseReferenceChanged;
        
        /// <summary>
        /// Gets fired before the MeterAsset property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> MeterAssetChanging;
        
        /// <summary>
        /// Gets fired when the MeterAsset property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> MeterAssetChanged;
        
        /// <summary>
        /// Gets fired before the Line property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LineChanging;
        
        /// <summary>
        /// Gets fired when the Line property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LineChanged;
        
        /// <summary>
        /// Gets fired before the VendorShift property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> VendorShiftChanging;
        
        /// <summary>
        /// Gets fired when the VendorShift property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> VendorShiftChanged;
        
        /// <summary>
        /// Gets fired before the CashierShift property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CashierShiftChanging;
        
        /// <summary>
        /// Gets fired when the CashierShift property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CashierShiftChanged;
        
        /// <summary>
        /// Gets fired before the AuxiliaryAccount property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AuxiliaryAccountChanging;
        
        /// <summary>
        /// Gets fired when the AuxiliaryAccount property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AuxiliaryAccountChanged;
        
        /// <summary>
        /// Gets fired before the PricingStructure property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PricingStructureChanging;
        
        /// <summary>
        /// Gets fired when the PricingStructure property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PricingStructureChanged;
        
        /// <summary>
        /// Gets fired before the CustomerAccount property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CustomerAccountChanging;
        
        /// <summary>
        /// Gets fired when the CustomerAccount property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CustomerAccountChanged;
        
        /// <summary>
        /// Gets fired before the Receipt property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ReceiptChanging;
        
        /// <summary>
        /// Gets fired when the Receipt property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ReceiptChanged;
    }
}

