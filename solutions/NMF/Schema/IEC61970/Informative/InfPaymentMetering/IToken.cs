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
using TTC2017.SmartGrids.CIM.IEC61968.Customers;
using TTC2017.SmartGrids.CIM.IEC61968.Metering;
using TTC2017.SmartGrids.CIM.IEC61968.PaymentMetering;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfCommon;

namespace TTC2017.SmartGrids.CIM.IEC61970.Informative.InfPaymentMetering
{
    
    
    /// <summary>
    /// The public interface for Token
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(Token))]
    [XmlDefaultImplementationTypeAttribute(typeof(Token))]
    public interface IToken : IModelElement, IIdentifiedObject
    {
        
        /// <summary>
        /// The comment property
        /// </summary>
        string Comment
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
        /// The PointOfSale property
        /// </summary>
        IPointOfSale PointOfSale
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the Comment property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CommentChanging;
        
        /// <summary>
        /// Gets fired when the Comment property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CommentChanged;
        
        /// <summary>
        /// Gets fired before the Code property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CodeChanging;
        
        /// <summary>
        /// Gets fired when the Code property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CodeChanged;
        
        /// <summary>
        /// Gets fired before the PointOfSale property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PointOfSaleChanging;
        
        /// <summary>
        /// Gets fired when the PointOfSale property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PointOfSaleChanged;
    }
}

