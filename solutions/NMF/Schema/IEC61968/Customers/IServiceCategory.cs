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
using TTC2017.SmartGrids.CIM.IEC61968.Common;
using TTC2017.SmartGrids.CIM.IEC61968.Metering;
using TTC2017.SmartGrids.CIM.IEC61968.PaymentMetering;
using TTC2017.SmartGrids.CIM.IEC61968.Work;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfCustomers;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfERPSupport;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfOperations;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfPaymentMetering;

namespace TTC2017.SmartGrids.CIM.IEC61968.Customers
{
    
    
    /// <summary>
    /// The public interface for ServiceCategory
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(ServiceCategory))]
    [XmlDefaultImplementationTypeAttribute(typeof(ServiceCategory))]
    public interface IServiceCategory : IModelElement, IIdentifiedObject
    {
        
        /// <summary>
        /// The kind property
        /// </summary>
        Nullable<ServiceKind> Kind
        {
            get;
            set;
        }
        
        /// <summary>
        /// The SPAccountingFunctions property
        /// </summary>
        IOrderedSetExpression<ISDPAccountingFunction> SPAccountingFunctions
        {
            get;
        }
        
        /// <summary>
        /// The ServiceDeliveryPoints property
        /// </summary>
        IOrderedSetExpression<IServiceDeliveryPoint> ServiceDeliveryPoints
        {
            get;
        }
        
        /// <summary>
        /// The CustomerAgreements property
        /// </summary>
        IOrderedSetExpression<ICustomerAgreement> CustomerAgreements
        {
            get;
        }
        
        /// <summary>
        /// The PricingStructures property
        /// </summary>
        IOrderedSetExpression<IPricingStructure> PricingStructures
        {
            get;
        }
        
        /// <summary>
        /// Gets fired before the Kind property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> KindChanging;
        
        /// <summary>
        /// Gets fired when the Kind property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> KindChanged;
    }
}

