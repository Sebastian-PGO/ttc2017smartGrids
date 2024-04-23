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
using TTC2017.SmartGrids.CIM.IEC61968.Assets;
using TTC2017.SmartGrids.CIM.IEC61968.Common;
using TTC2017.SmartGrids.CIM.IEC61968.Work;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssets;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfCommon;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfERPSupport;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfGMLSupport;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfLocations;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfOperations;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfTypeAsset;

namespace TTC2017.SmartGrids.CIM.IEC61970.Informative.InfWork
{
    
    
    /// <summary>
    /// The public interface for AccessPermit
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(AccessPermit))]
    [XmlDefaultImplementationTypeAttribute(typeof(AccessPermit))]
    public interface IAccessPermit : IModelElement, IDocument
    {
        
        /// <summary>
        /// The expirationDate property
        /// </summary>
        string ExpirationDate
        {
            get;
            set;
        }
        
        /// <summary>
        /// The applicationNumber property
        /// </summary>
        string ApplicationNumber
        {
            get;
            set;
        }
        
        /// <summary>
        /// The effectiveDate property
        /// </summary>
        string EffectiveDate
        {
            get;
            set;
        }
        
        /// <summary>
        /// The permitID property
        /// </summary>
        string PermitID
        {
            get;
            set;
        }
        
        /// <summary>
        /// The payment property
        /// </summary>
        float Payment
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the ExpirationDate property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ExpirationDateChanging;
        
        /// <summary>
        /// Gets fired when the ExpirationDate property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ExpirationDateChanged;
        
        /// <summary>
        /// Gets fired before the ApplicationNumber property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ApplicationNumberChanging;
        
        /// <summary>
        /// Gets fired when the ApplicationNumber property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ApplicationNumberChanged;
        
        /// <summary>
        /// Gets fired before the EffectiveDate property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> EffectiveDateChanging;
        
        /// <summary>
        /// Gets fired when the EffectiveDate property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> EffectiveDateChanged;
        
        /// <summary>
        /// Gets fired before the PermitID property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PermitIDChanging;
        
        /// <summary>
        /// Gets fired when the PermitID property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PermitIDChanged;
        
        /// <summary>
        /// Gets fired before the Payment property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PaymentChanging;
        
        /// <summary>
        /// Gets fired when the Payment property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PaymentChanged;
    }
}

