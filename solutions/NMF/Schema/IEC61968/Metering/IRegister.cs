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
    /// The public interface for Register
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(Register))]
    [XmlDefaultImplementationTypeAttribute(typeof(Register))]
    public interface IRegister : IModelElement, IIdentifiedObject
    {
        
        /// <summary>
        /// The leftDigitCount property
        /// </summary>
        int LeftDigitCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// The rightDigitCount property
        /// </summary>
        int RightDigitCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// The ReadingType property
        /// </summary>
        IReadingType ReadingType
        {
            get;
            set;
        }
        
        /// <summary>
        /// The DeviceFunction property
        /// </summary>
        IDeviceFunction DeviceFunction
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the LeftDigitCount property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LeftDigitCountChanging;
        
        /// <summary>
        /// Gets fired when the LeftDigitCount property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LeftDigitCountChanged;
        
        /// <summary>
        /// Gets fired before the RightDigitCount property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> RightDigitCountChanging;
        
        /// <summary>
        /// Gets fired when the RightDigitCount property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> RightDigitCountChanged;
        
        /// <summary>
        /// Gets fired before the ReadingType property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ReadingTypeChanging;
        
        /// <summary>
        /// Gets fired when the ReadingType property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ReadingTypeChanged;
        
        /// <summary>
        /// Gets fired before the DeviceFunction property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DeviceFunctionChanging;
        
        /// <summary>
        /// Gets fired when the DeviceFunction property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DeviceFunctionChanged;
    }
}

