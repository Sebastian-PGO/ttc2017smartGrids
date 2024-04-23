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
    /// The public interface for EquipmentItem
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(EquipmentItem))]
    [XmlDefaultImplementationTypeAttribute(typeof(EquipmentItem))]
    public interface IEquipmentItem : IModelElement, IIdentifiedObject
    {
        
        /// <summary>
        /// The code property
        /// </summary>
        string Code
        {
            get;
            set;
        }
        
        /// <summary>
        /// The cost property
        /// </summary>
        float Cost
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
        /// The WorkCostDetail property
        /// </summary>
        IWorkCostDetail WorkCostDetail
        {
            get;
            set;
        }
        
        /// <summary>
        /// The WorkTask property
        /// </summary>
        IWorkTask WorkTask
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the Code property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CodeChanging;
        
        /// <summary>
        /// Gets fired when the Code property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CodeChanged;
        
        /// <summary>
        /// Gets fired before the Cost property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CostChanging;
        
        /// <summary>
        /// Gets fired when the Cost property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CostChanged;
        
        /// <summary>
        /// Gets fired before the Status property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> StatusChanging;
        
        /// <summary>
        /// Gets fired when the Status property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> StatusChanged;
        
        /// <summary>
        /// Gets fired before the WorkCostDetail property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> WorkCostDetailChanging;
        
        /// <summary>
        /// Gets fired when the WorkCostDetail property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> WorkCostDetailChanged;
        
        /// <summary>
        /// Gets fired before the WorkTask property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> WorkTaskChanging;
        
        /// <summary>
        /// Gets fired when the WorkTask property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> WorkTaskChanged;
    }
}

