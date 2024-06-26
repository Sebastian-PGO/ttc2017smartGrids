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
    /// The public interface for RegisteredResource
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(RegisteredResource))]
    [XmlDefaultImplementationTypeAttribute(typeof(RegisteredResource))]
    public interface IRegisteredResource : IModelElement, IIdentifiedObject
    {
        
        /// <summary>
        /// The rtoID property
        /// </summary>
        string RtoID
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Markets property
        /// </summary>
        IOrderedSetExpression<IMarket> Markets
        {
            get;
        }
        
        /// <summary>
        /// The MarketProducts property
        /// </summary>
        IOrderedSetExpression<IMarketProduct> MarketProducts
        {
            get;
        }
        
        /// <summary>
        /// The Meters property
        /// </summary>
        IOrderedSetExpression<IMeter> Meters
        {
            get;
        }
        
        /// <summary>
        /// The Pnode property
        /// </summary>
        IPnode Pnode
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
        /// The ResourceGroups property
        /// </summary>
        IOrderedSetExpression<IResourceGroup> ResourceGroups
        {
            get;
        }
        
        /// <summary>
        /// Gets fired before the RtoID property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> RtoIDChanging;
        
        /// <summary>
        /// Gets fired when the RtoID property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> RtoIDChanged;
        
        /// <summary>
        /// Gets fired before the Pnode property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PnodeChanging;
        
        /// <summary>
        /// Gets fired when the Pnode property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PnodeChanged;
        
        /// <summary>
        /// Gets fired before the Organisation property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> OrganisationChanging;
        
        /// <summary>
        /// Gets fired when the Organisation property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> OrganisationChanged;
    }
}

