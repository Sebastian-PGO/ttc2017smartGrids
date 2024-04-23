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
using TTC2017.SmartGrids.CIM.IEC61968.AssetModels;
using TTC2017.SmartGrids.CIM.IEC61968.Assets;
using TTC2017.SmartGrids.CIM.IEC61968.Common;
using TTC2017.SmartGrids.CIM.IEC61968.Customers;
using TTC2017.SmartGrids.CIM.IEC61968.PaymentMetering;
using TTC2017.SmartGrids.CIM.IEC61968.WiresExt;
using TTC2017.SmartGrids.CIM.IEC61968.Work;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Domain;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssetModels;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssets;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfCustomers;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfMetering;
using TTC2017.SmartGrids.CIM.IEC61970.Meas;
using TTC2017.SmartGrids.CIM.IEC61970.Wires;

namespace TTC2017.SmartGrids.CIM.IEC61968.Metering
{
    
    
    /// <summary>
    /// The public interface for EndDeviceControl
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(EndDeviceControl))]
    [XmlDefaultImplementationTypeAttribute(typeof(EndDeviceControl))]
    public interface IEndDeviceControl : IModelElement, IIdentifiedObject
    {
        
        /// <summary>
        /// The drProgramMandatory property
        /// </summary>
        bool DrProgramMandatory
        {
            get;
            set;
        }
        
        /// <summary>
        /// The drProgramLevel property
        /// </summary>
        int DrProgramLevel
        {
            get;
            set;
        }
        
        /// <summary>
        /// The type property
        /// </summary>
        string Type
        {
            get;
            set;
        }
        
        /// <summary>
        /// The priceSignal property
        /// </summary>
        float PriceSignal
        {
            get;
            set;
        }
        
        /// <summary>
        /// The scheduledInterval property
        /// </summary>
        IDateTimeInterval ScheduledInterval
        {
            get;
            set;
        }
        
        /// <summary>
        /// The CustomerAgreement property
        /// </summary>
        ICustomerAgreement CustomerAgreement
        {
            get;
            set;
        }
        
        /// <summary>
        /// The EndDeviceAsset property
        /// </summary>
        IEndDeviceAsset EndDeviceAsset
        {
            get;
            set;
        }
        
        /// <summary>
        /// The EndDeviceGroup property
        /// </summary>
        IEndDeviceGroup EndDeviceGroup
        {
            get;
            set;
        }
        
        /// <summary>
        /// The DemandResponseProgram property
        /// </summary>
        IDemandResponseProgram DemandResponseProgram
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the DrProgramMandatory property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DrProgramMandatoryChanging;
        
        /// <summary>
        /// Gets fired when the DrProgramMandatory property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DrProgramMandatoryChanged;
        
        /// <summary>
        /// Gets fired before the DrProgramLevel property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DrProgramLevelChanging;
        
        /// <summary>
        /// Gets fired when the DrProgramLevel property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DrProgramLevelChanged;
        
        /// <summary>
        /// Gets fired before the Type property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TypeChanging;
        
        /// <summary>
        /// Gets fired when the Type property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TypeChanged;
        
        /// <summary>
        /// Gets fired before the PriceSignal property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PriceSignalChanging;
        
        /// <summary>
        /// Gets fired when the PriceSignal property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PriceSignalChanged;
        
        /// <summary>
        /// Gets fired before the ScheduledInterval property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ScheduledIntervalChanging;
        
        /// <summary>
        /// Gets fired when the ScheduledInterval property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ScheduledIntervalChanged;
        
        /// <summary>
        /// Gets fired before the CustomerAgreement property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CustomerAgreementChanging;
        
        /// <summary>
        /// Gets fired when the CustomerAgreement property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CustomerAgreementChanged;
        
        /// <summary>
        /// Gets fired before the EndDeviceAsset property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> EndDeviceAssetChanging;
        
        /// <summary>
        /// Gets fired when the EndDeviceAsset property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> EndDeviceAssetChanged;
        
        /// <summary>
        /// Gets fired before the EndDeviceGroup property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> EndDeviceGroupChanging;
        
        /// <summary>
        /// Gets fired when the EndDeviceGroup property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> EndDeviceGroupChanged;
        
        /// <summary>
        /// Gets fired before the DemandResponseProgram property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DemandResponseProgramChanging;
        
        /// <summary>
        /// Gets fired when the DemandResponseProgram property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DemandResponseProgramChanged;
    }
}

