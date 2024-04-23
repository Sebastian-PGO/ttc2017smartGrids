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
using TTC2017.SmartGrids.CIM.IEC61968.AssetModels;
using TTC2017.SmartGrids.CIM.IEC61968.Assets;
using TTC2017.SmartGrids.CIM.IEC61968.Common;
using TTC2017.SmartGrids.CIM.IEC61968.Customers;
using TTC2017.SmartGrids.CIM.IEC61968.Work;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.Financial;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssetModels;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssets;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfCommon;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfCustomers;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfLocations;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfOperations;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfTypeAsset;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfWork;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.MarketOperations;
using TTC2017.SmartGrids.CIM.IEC61970.Meas;

namespace TTC2017.SmartGrids.CIM.IEC61970.Informative.InfERPSupport
{
    
    
    /// <summary>
    /// The public interface for ErpOrganisation
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(ErpOrganisation))]
    [XmlDefaultImplementationTypeAttribute(typeof(ErpOrganisation))]
    public interface IErpOrganisation : IModelElement, IOrganisation
    {
        
        /// <summary>
        /// The mode property
        /// </summary>
        string Mode
        {
            get;
            set;
        }
        
        /// <summary>
        /// The optOut property
        /// </summary>
        bool OptOut
        {
            get;
            set;
        }
        
        /// <summary>
        /// The isProfitCenter property
        /// </summary>
        bool IsProfitCenter
        {
            get;
            set;
        }
        
        /// <summary>
        /// The isCostCenter property
        /// </summary>
        bool IsCostCenter
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
        /// The industryID property
        /// </summary>
        string IndustryID
        {
            get;
            set;
        }
        
        /// <summary>
        /// The category property
        /// </summary>
        string Category
        {
            get;
            set;
        }
        
        /// <summary>
        /// The governmentID property
        /// </summary>
        string GovernmentID
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Crews property
        /// </summary>
        IOrderedSetExpression<ICrew> Crews
        {
            get;
        }
        
        /// <summary>
        /// The Requests property
        /// </summary>
        IOrderedSetExpression<IRequest> Requests
        {
            get;
        }
        
        /// <summary>
        /// The RegisteredResources property
        /// </summary>
        IOrderedSetExpression<IRegisteredResource> RegisteredResources
        {
            get;
        }
        
        /// <summary>
        /// The PowerSystemResourceRoles property
        /// </summary>
        IOrderedSetExpression<IOrgPsrRole> PowerSystemResourceRoles
        {
            get;
        }
        
        /// <summary>
        /// The DocumentRoles property
        /// </summary>
        IOrderedSetExpression<IDocOrgRole> DocumentRoles
        {
            get;
        }
        
        /// <summary>
        /// The AssetRoles property
        /// </summary>
        IOrderedSetExpression<IOrgAssetRole> AssetRoles
        {
            get;
        }
        
        /// <summary>
        /// The ViolationLimits property
        /// </summary>
        IOrderedSetExpression<IViolationLimit> ViolationLimits
        {
            get;
        }
        
        /// <summary>
        /// The ParentOrganisationRoles property
        /// </summary>
        IOrderedSetExpression<IOrgOrgRole> ParentOrganisationRoles
        {
            get;
        }
        
        /// <summary>
        /// The LandPropertyRoles property
        /// </summary>
        IOrderedSetExpression<IOrgPropertyRole> LandPropertyRoles
        {
            get;
        }
        
        /// <summary>
        /// The ErpPersonRoles property
        /// </summary>
        IOrderedSetExpression<IOrgErpPersonRole> ErpPersonRoles
        {
            get;
        }
        
        /// <summary>
        /// The ChildOrganisationRoles property
        /// </summary>
        IOrderedSetExpression<IOrgOrgRole> ChildOrganisationRoles
        {
            get;
        }
        
        /// <summary>
        /// The ChangeItems property
        /// </summary>
        IOrderedSetExpression<IChangeItem> ChangeItems
        {
            get;
        }
        
        /// <summary>
        /// The Locations property
        /// </summary>
        IOrderedSetExpression<ILocation> Locations
        {
            get;
        }
        
        /// <summary>
        /// The IntSchedAgreement property
        /// </summary>
        IOrderedSetExpression<IIntSchedAgreement> IntSchedAgreement
        {
            get;
        }
        
        /// <summary>
        /// The ActivityRecords property
        /// </summary>
        IOrderedSetExpression<IActivityRecord> ActivityRecords
        {
            get;
        }
        
        /// <summary>
        /// Gets fired before the Mode property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ModeChanging;
        
        /// <summary>
        /// Gets fired when the Mode property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ModeChanged;
        
        /// <summary>
        /// Gets fired before the OptOut property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> OptOutChanging;
        
        /// <summary>
        /// Gets fired when the OptOut property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> OptOutChanged;
        
        /// <summary>
        /// Gets fired before the IsProfitCenter property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> IsProfitCenterChanging;
        
        /// <summary>
        /// Gets fired when the IsProfitCenter property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> IsProfitCenterChanged;
        
        /// <summary>
        /// Gets fired before the IsCostCenter property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> IsCostCenterChanging;
        
        /// <summary>
        /// Gets fired when the IsCostCenter property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> IsCostCenterChanged;
        
        /// <summary>
        /// Gets fired before the Code property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CodeChanging;
        
        /// <summary>
        /// Gets fired when the Code property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CodeChanged;
        
        /// <summary>
        /// Gets fired before the IndustryID property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> IndustryIDChanging;
        
        /// <summary>
        /// Gets fired when the IndustryID property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> IndustryIDChanged;
        
        /// <summary>
        /// Gets fired before the Category property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CategoryChanging;
        
        /// <summary>
        /// Gets fired when the Category property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CategoryChanged;
        
        /// <summary>
        /// Gets fired before the GovernmentID property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> GovernmentIDChanging;
        
        /// <summary>
        /// Gets fired when the GovernmentID property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> GovernmentIDChanged;
    }
}

