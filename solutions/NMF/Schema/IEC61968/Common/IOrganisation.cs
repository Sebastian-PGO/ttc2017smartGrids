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
    /// The public interface for Organisation
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(Organisation))]
    [XmlDefaultImplementationTypeAttribute(typeof(Organisation))]
    public interface IOrganisation : IModelElement, IIdentifiedObject
    {
        
        /// <summary>
        /// The streetAddress property
        /// </summary>
        IStreetAddress StreetAddress
        {
            get;
            set;
        }
        
        /// <summary>
        /// The electronicAddress property
        /// </summary>
        IElectronicAddress ElectronicAddress
        {
            get;
            set;
        }
        
        /// <summary>
        /// The postalAddress property
        /// </summary>
        IPostalAddress PostalAddress
        {
            get;
            set;
        }
        
        /// <summary>
        /// The phone1 property
        /// </summary>
        ITelephoneNumber Phone1
        {
            get;
            set;
        }
        
        /// <summary>
        /// The phone2 property
        /// </summary>
        ITelephoneNumber Phone2
        {
            get;
            set;
        }
        
        /// <summary>
        /// The MarketRoles property
        /// </summary>
        IOrderedSetExpression<IMarketRole> MarketRoles
        {
            get;
        }
        
        /// <summary>
        /// The BusinessRoles property
        /// </summary>
        IOrderedSetExpression<IBusinessRole> BusinessRoles
        {
            get;
        }
        
        /// <summary>
        /// Gets fired before the StreetAddress property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> StreetAddressChanging;
        
        /// <summary>
        /// Gets fired when the StreetAddress property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> StreetAddressChanged;
        
        /// <summary>
        /// Gets fired before the ElectronicAddress property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ElectronicAddressChanging;
        
        /// <summary>
        /// Gets fired when the ElectronicAddress property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ElectronicAddressChanged;
        
        /// <summary>
        /// Gets fired before the PostalAddress property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PostalAddressChanging;
        
        /// <summary>
        /// Gets fired when the PostalAddress property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PostalAddressChanged;
        
        /// <summary>
        /// Gets fired before the Phone1 property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Phone1Changing;
        
        /// <summary>
        /// Gets fired when the Phone1 property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Phone1Changed;
        
        /// <summary>
        /// Gets fired before the Phone2 property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Phone2Changing;
        
        /// <summary>
        /// Gets fired when the Phone2 property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Phone2Changed;
    }
}

