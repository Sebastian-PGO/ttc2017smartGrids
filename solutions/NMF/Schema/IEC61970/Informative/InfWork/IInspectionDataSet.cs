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
    /// The public interface for InspectionDataSet
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(InspectionDataSet))]
    [XmlDefaultImplementationTypeAttribute(typeof(InspectionDataSet))]
    public interface IInspectionDataSet : IModelElement, IProcedureDataSet
    {
        
        /// <summary>
        /// The locationCondition property
        /// </summary>
        string LocationCondition
        {
            get;
            set;
        }
        
        /// <summary>
        /// The AccordingToSchedules property
        /// </summary>
        IOrderedSetExpression<IScheduleParameterInfo> AccordingToSchedules
        {
            get;
        }
        
        /// <summary>
        /// Gets fired before the LocationCondition property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LocationConditionChanging;
        
        /// <summary>
        /// Gets fired when the LocationCondition property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LocationConditionChanged;
    }
}

