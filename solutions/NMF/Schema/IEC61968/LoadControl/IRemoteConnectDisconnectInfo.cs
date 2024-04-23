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
using TTC2017.SmartGrids.CIM.IEC61968.Metering;
using TTC2017.SmartGrids.CIM.IEC61970.Wires;

namespace TTC2017.SmartGrids.CIM.IEC61968.LoadControl
{
    
    
    /// <summary>
    /// The public interface for RemoteConnectDisconnectInfo
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(RemoteConnectDisconnectInfo))]
    [XmlDefaultImplementationTypeAttribute(typeof(RemoteConnectDisconnectInfo))]
    public interface IRemoteConnectDisconnectInfo : IModelElement, IElement
    {
        
        /// <summary>
        /// The powerLimit property
        /// </summary>
        float PowerLimit
        {
            get;
            set;
        }
        
        /// <summary>
        /// The customerVoltageLimit property
        /// </summary>
        float CustomerVoltageLimit
        {
            get;
            set;
        }
        
        /// <summary>
        /// The energyLimit property
        /// </summary>
        float EnergyLimit
        {
            get;
            set;
        }
        
        /// <summary>
        /// The isEnergyLimiting property
        /// </summary>
        bool IsEnergyLimiting
        {
            get;
            set;
        }
        
        /// <summary>
        /// The energyUsageWarning property
        /// </summary>
        float EnergyUsageWarning
        {
            get;
            set;
        }
        
        /// <summary>
        /// The needsVoltageLimitCheck property
        /// </summary>
        bool NeedsVoltageLimitCheck
        {
            get;
            set;
        }
        
        /// <summary>
        /// The energyUsageStartDateTime property
        /// </summary>
        DateTime EnergyUsageStartDateTime
        {
            get;
            set;
        }
        
        /// <summary>
        /// The usePushbutton property
        /// </summary>
        bool UsePushbutton
        {
            get;
            set;
        }
        
        /// <summary>
        /// The isArmDisconnect property
        /// </summary>
        bool IsArmDisconnect
        {
            get;
            set;
        }
        
        /// <summary>
        /// The isArmConnect property
        /// </summary>
        bool IsArmConnect
        {
            get;
            set;
        }
        
        /// <summary>
        /// The needsPowerLimitCheck property
        /// </summary>
        bool NeedsPowerLimitCheck
        {
            get;
            set;
        }
        
        /// <summary>
        /// The armedTimeout property
        /// </summary>
        float ArmedTimeout
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the PowerLimit property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PowerLimitChanging;
        
        /// <summary>
        /// Gets fired when the PowerLimit property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PowerLimitChanged;
        
        /// <summary>
        /// Gets fired before the CustomerVoltageLimit property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CustomerVoltageLimitChanging;
        
        /// <summary>
        /// Gets fired when the CustomerVoltageLimit property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CustomerVoltageLimitChanged;
        
        /// <summary>
        /// Gets fired before the EnergyLimit property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> EnergyLimitChanging;
        
        /// <summary>
        /// Gets fired when the EnergyLimit property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> EnergyLimitChanged;
        
        /// <summary>
        /// Gets fired before the IsEnergyLimiting property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> IsEnergyLimitingChanging;
        
        /// <summary>
        /// Gets fired when the IsEnergyLimiting property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> IsEnergyLimitingChanged;
        
        /// <summary>
        /// Gets fired before the EnergyUsageWarning property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> EnergyUsageWarningChanging;
        
        /// <summary>
        /// Gets fired when the EnergyUsageWarning property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> EnergyUsageWarningChanged;
        
        /// <summary>
        /// Gets fired before the NeedsVoltageLimitCheck property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> NeedsVoltageLimitCheckChanging;
        
        /// <summary>
        /// Gets fired when the NeedsVoltageLimitCheck property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> NeedsVoltageLimitCheckChanged;
        
        /// <summary>
        /// Gets fired before the EnergyUsageStartDateTime property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> EnergyUsageStartDateTimeChanging;
        
        /// <summary>
        /// Gets fired when the EnergyUsageStartDateTime property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> EnergyUsageStartDateTimeChanged;
        
        /// <summary>
        /// Gets fired before the UsePushbutton property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> UsePushbuttonChanging;
        
        /// <summary>
        /// Gets fired when the UsePushbutton property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> UsePushbuttonChanged;
        
        /// <summary>
        /// Gets fired before the IsArmDisconnect property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> IsArmDisconnectChanging;
        
        /// <summary>
        /// Gets fired when the IsArmDisconnect property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> IsArmDisconnectChanged;
        
        /// <summary>
        /// Gets fired before the IsArmConnect property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> IsArmConnectChanging;
        
        /// <summary>
        /// Gets fired when the IsArmConnect property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> IsArmConnectChanged;
        
        /// <summary>
        /// Gets fired before the NeedsPowerLimitCheck property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> NeedsPowerLimitCheckChanging;
        
        /// <summary>
        /// Gets fired when the NeedsPowerLimitCheck property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> NeedsPowerLimitCheckChanged;
        
        /// <summary>
        /// Gets fired before the ArmedTimeout property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ArmedTimeoutChanging;
        
        /// <summary>
        /// Gets fired when the ArmedTimeout property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ArmedTimeoutChanged;
    }
}

