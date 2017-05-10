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
    /// The public interface for Request
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(Request))]
    [XmlDefaultImplementationTypeAttribute(typeof(Request))]
    public interface IRequest : IModelElement, IDocument
    {
        
        /// <summary>
        /// The priority property
        /// </summary>
        string Priority
        {
            get;
            set;
        }
        
        /// <summary>
        /// The corporateCode property
        /// </summary>
        string CorporateCode
        {
            get;
            set;
        }
        
        /// <summary>
        /// The actionNeeded property
        /// </summary>
        string ActionNeeded
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Organisation property
        /// </summary>
        IErpOrganisation Organisation
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Works property
        /// </summary>
        IOrderedSetExpression<IWork> Works
        {
            get;
        }
        
        /// <summary>
        /// The ErpQuoteLineItem property
        /// </summary>
        IErpQuoteLineItem ErpQuoteLineItem
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Projects property
        /// </summary>
        IOrderedSetExpression<IProject> Projects
        {
            get;
        }
        
        /// <summary>
        /// Gets fired before the Priority property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PriorityChanging;
        
        /// <summary>
        /// Gets fired when the Priority property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PriorityChanged;
        
        /// <summary>
        /// Gets fired before the CorporateCode property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CorporateCodeChanging;
        
        /// <summary>
        /// Gets fired when the CorporateCode property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CorporateCodeChanged;
        
        /// <summary>
        /// Gets fired before the ActionNeeded property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ActionNeededChanging;
        
        /// <summary>
        /// Gets fired when the ActionNeeded property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ActionNeededChanged;
        
        /// <summary>
        /// Gets fired before the Organisation property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> OrganisationChanging;
        
        /// <summary>
        /// Gets fired when the Organisation property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> OrganisationChanged;
        
        /// <summary>
        /// Gets fired before the ErpQuoteLineItem property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ErpQuoteLineItemChanging;
        
        /// <summary>
        /// Gets fired when the ErpQuoteLineItem property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ErpQuoteLineItemChanged;
    }
}
