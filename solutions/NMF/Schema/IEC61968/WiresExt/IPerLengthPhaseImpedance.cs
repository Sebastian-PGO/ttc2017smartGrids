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
using TTC2017.SmartGrids.CIM.IEC61968.Metering;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssets;
using TTC2017.SmartGrids.CIM.IEC61970.Wires;

namespace TTC2017.SmartGrids.CIM.IEC61968.WiresExt
{
    
    
    /// <summary>
    /// The public interface for PerLengthPhaseImpedance
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(PerLengthPhaseImpedance))]
    [XmlDefaultImplementationTypeAttribute(typeof(PerLengthPhaseImpedance))]
    public interface IPerLengthPhaseImpedance : IModelElement, IIdentifiedObject
    {
        
        /// <summary>
        /// The conductorCount property
        /// </summary>
        int ConductorCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// The ConductorSegments property
        /// </summary>
        IOrderedSetExpression<IDistributionLineSegment> ConductorSegments
        {
            get;
        }
        
        /// <summary>
        /// The PhaseImpedanceData property
        /// </summary>
        IOrderedSetExpression<IPhaseImpedanceData> PhaseImpedanceData
        {
            get;
        }
        
        /// <summary>
        /// Gets fired before the ConductorCount property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ConductorCountChanging;
        
        /// <summary>
        /// Gets fired when the ConductorCount property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ConductorCountChanged;
    }
}

