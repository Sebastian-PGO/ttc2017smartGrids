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
    /// The public interface for PointOfSale
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(PointOfSale))]
    [XmlDefaultImplementationTypeAttribute(typeof(PointOfSale))]
    public interface IPointOfSale : IModelElement, IIdentifiedObject
    {
        
        /// <summary>
        /// The location property
        /// </summary>
        string Location
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Tokens property
        /// </summary>
        IOrderedSetExpression<IToken> Tokens
        {
            get;
        }
        
        /// <summary>
        /// The CashierShifts property
        /// </summary>
        IOrderedSetExpression<ICashierShift> CashierShifts
        {
            get;
        }
        
        /// <summary>
        /// The Vendor property
        /// </summary>
        IVendor Vendor
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the Location property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LocationChanging;
        
        /// <summary>
        /// Gets fired when the Location property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LocationChanged;
        
        /// <summary>
        /// Gets fired before the Vendor property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> VendorChanging;
        
        /// <summary>
        /// Gets fired when the Vendor property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> VendorChanged;
    }
}
