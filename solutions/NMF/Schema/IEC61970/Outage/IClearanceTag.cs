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
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfOperations;
using TTC2017.SmartGrids.CIM.IEC61970.Wires;

namespace TTC2017.SmartGrids.CIM.IEC61970.Outage
{
    
    
    /// <summary>
    /// The public interface for ClearanceTag
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(ClearanceTag))]
    [XmlDefaultImplementationTypeAttribute(typeof(ClearanceTag))]
    public interface IClearanceTag : IModelElement, IIdentifiedObject
    {
        
        /// <summary>
        /// The groundReqFlag property
        /// </summary>
        bool GroundReqFlag
        {
            get;
            set;
        }
        
        /// <summary>
        /// The tagIssueTime property
        /// </summary>
        DateTime TagIssueTime
        {
            get;
            set;
        }
        
        /// <summary>
        /// The workEndTime property
        /// </summary>
        DateTime WorkEndTime
        {
            get;
            set;
        }
        
        /// <summary>
        /// The authorityName property
        /// </summary>
        string AuthorityName
        {
            get;
            set;
        }
        
        /// <summary>
        /// The phaseCheckReqFlag property
        /// </summary>
        bool PhaseCheckReqFlag
        {
            get;
            set;
        }
        
        /// <summary>
        /// The deenergizeReqFlag property
        /// </summary>
        bool DeenergizeReqFlag
        {
            get;
            set;
        }
        
        /// <summary>
        /// The workStartTime property
        /// </summary>
        DateTime WorkStartTime
        {
            get;
            set;
        }
        
        /// <summary>
        /// The workDescription property
        /// </summary>
        string WorkDescription
        {
            get;
            set;
        }
        
        /// <summary>
        /// The SafetyDocument property
        /// </summary>
        ISafetyDocument SafetyDocument
        {
            get;
            set;
        }
        
        /// <summary>
        /// The ClearanceTagType property
        /// </summary>
        IClearanceTagType ClearanceTagType
        {
            get;
            set;
        }
        
        /// <summary>
        /// The ConductingEquipment property
        /// </summary>
        IConductingEquipment ConductingEquipment
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the GroundReqFlag property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> GroundReqFlagChanging;
        
        /// <summary>
        /// Gets fired when the GroundReqFlag property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> GroundReqFlagChanged;
        
        /// <summary>
        /// Gets fired before the TagIssueTime property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TagIssueTimeChanging;
        
        /// <summary>
        /// Gets fired when the TagIssueTime property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TagIssueTimeChanged;
        
        /// <summary>
        /// Gets fired before the WorkEndTime property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> WorkEndTimeChanging;
        
        /// <summary>
        /// Gets fired when the WorkEndTime property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> WorkEndTimeChanged;
        
        /// <summary>
        /// Gets fired before the AuthorityName property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AuthorityNameChanging;
        
        /// <summary>
        /// Gets fired when the AuthorityName property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AuthorityNameChanged;
        
        /// <summary>
        /// Gets fired before the PhaseCheckReqFlag property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PhaseCheckReqFlagChanging;
        
        /// <summary>
        /// Gets fired when the PhaseCheckReqFlag property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PhaseCheckReqFlagChanged;
        
        /// <summary>
        /// Gets fired before the DeenergizeReqFlag property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DeenergizeReqFlagChanging;
        
        /// <summary>
        /// Gets fired when the DeenergizeReqFlag property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DeenergizeReqFlagChanged;
        
        /// <summary>
        /// Gets fired before the WorkStartTime property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> WorkStartTimeChanging;
        
        /// <summary>
        /// Gets fired when the WorkStartTime property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> WorkStartTimeChanged;
        
        /// <summary>
        /// Gets fired before the WorkDescription property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> WorkDescriptionChanging;
        
        /// <summary>
        /// Gets fired when the WorkDescription property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> WorkDescriptionChanged;
        
        /// <summary>
        /// Gets fired before the SafetyDocument property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> SafetyDocumentChanging;
        
        /// <summary>
        /// Gets fired when the SafetyDocument property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> SafetyDocumentChanged;
        
        /// <summary>
        /// Gets fired before the ClearanceTagType property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ClearanceTagTypeChanging;
        
        /// <summary>
        /// Gets fired when the ClearanceTagType property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ClearanceTagTypeChanged;
        
        /// <summary>
        /// Gets fired before the ConductingEquipment property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ConductingEquipmentChanging;
        
        /// <summary>
        /// Gets fired when the ConductingEquipment property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ConductingEquipmentChanged;
    }
}

