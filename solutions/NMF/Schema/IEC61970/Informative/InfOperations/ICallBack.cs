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
using TTC2017.SmartGrids.CIM.IEC61968.Customers;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssets;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfCommon;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfCustomers;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfERPSupport;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfGMLSupport;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfWork;
using TTC2017.SmartGrids.CIM.IEC61970.Outage;

namespace TTC2017.SmartGrids.CIM.IEC61970.Informative.InfOperations
{
    
    
    /// <summary>
    /// The public interface for CallBack
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(CallBack))]
    [XmlDefaultImplementationTypeAttribute(typeof(CallBack))]
    public interface ICallBack : IModelElement, IIdentifiedObject
    {
        
        /// <summary>
        /// The advice property
        /// </summary>
        string Advice
        {
            get;
            set;
        }
        
        /// <summary>
        /// The problemInfo property
        /// </summary>
        string ProblemInfo
        {
            get;
            set;
        }
        
        /// <summary>
        /// The contactDetail property
        /// </summary>
        string ContactDetail
        {
            get;
            set;
        }
        
        /// <summary>
        /// The dateTime property
        /// </summary>
        DateTime DateTime
        {
            get;
            set;
        }
        
        /// <summary>
        /// The comment property
        /// </summary>
        string Comment
        {
            get;
            set;
        }
        
        /// <summary>
        /// The status property
        /// </summary>
        IStatus Status
        {
            get;
            set;
        }
        
        /// <summary>
        /// The ErpPersons property
        /// </summary>
        IOrderedSetExpression<IErpPerson> ErpPersons
        {
            get;
        }
        
        /// <summary>
        /// The Appointments property
        /// </summary>
        IOrderedSetExpression<IAppointment> Appointments
        {
            get;
        }
        
        /// <summary>
        /// The TroubleTickets property
        /// </summary>
        IOrderedSetExpression<ITroubleTicket> TroubleTickets
        {
            get;
        }
        
        /// <summary>
        /// Gets fired before the Advice property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AdviceChanging;
        
        /// <summary>
        /// Gets fired when the Advice property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AdviceChanged;
        
        /// <summary>
        /// Gets fired before the ProblemInfo property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ProblemInfoChanging;
        
        /// <summary>
        /// Gets fired when the ProblemInfo property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ProblemInfoChanged;
        
        /// <summary>
        /// Gets fired before the ContactDetail property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ContactDetailChanging;
        
        /// <summary>
        /// Gets fired when the ContactDetail property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ContactDetailChanged;
        
        /// <summary>
        /// Gets fired before the DateTime property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DateTimeChanging;
        
        /// <summary>
        /// Gets fired when the DateTime property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DateTimeChanged;
        
        /// <summary>
        /// Gets fired before the Comment property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CommentChanging;
        
        /// <summary>
        /// Gets fired when the Comment property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CommentChanged;
        
        /// <summary>
        /// Gets fired before the Status property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> StatusChanging;
        
        /// <summary>
        /// Gets fired when the Status property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> StatusChanged;
    }
}

