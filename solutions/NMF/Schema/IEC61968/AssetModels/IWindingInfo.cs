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
using TTC2017.SmartGrids.CIM.IEC61968.Metering;
using TTC2017.SmartGrids.CIM.IEC61968.WiresExt;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssetModels;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssets;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfERPSupport;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfTypeAsset;
using TTC2017.SmartGrids.CIM.IEC61970.Wires;

namespace TTC2017.SmartGrids.CIM.IEC61968.AssetModels
{
    
    
    /// <summary>
    /// The public interface for WindingInfo
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(WindingInfo))]
    [XmlDefaultImplementationTypeAttribute(typeof(WindingInfo))]
    public interface IWindingInfo : IModelElement, IIdentifiedObject
    {
        
        /// <summary>
        /// The emergencyS property
        /// </summary>
        float EmergencyS
        {
            get;
            set;
        }
        
        /// <summary>
        /// The phaseAngle property
        /// </summary>
        int PhaseAngle
        {
            get;
            set;
        }
        
        /// <summary>
        /// The ratedS property
        /// </summary>
        float RatedS
        {
            get;
            set;
        }
        
        /// <summary>
        /// The ratedU property
        /// </summary>
        float RatedU
        {
            get;
            set;
        }
        
        /// <summary>
        /// The r property
        /// </summary>
        float R
        {
            get;
            set;
        }
        
        /// <summary>
        /// The sequenceNumber property
        /// </summary>
        int SequenceNumber
        {
            get;
            set;
        }
        
        /// <summary>
        /// The shortTermS property
        /// </summary>
        float ShortTermS
        {
            get;
            set;
        }
        
        /// <summary>
        /// The connectionKind property
        /// </summary>
        Nullable<WindingConnection> ConnectionKind
        {
            get;
            set;
        }
        
        /// <summary>
        /// The insulationU property
        /// </summary>
        float InsulationU
        {
            get;
            set;
        }
        
        /// <summary>
        /// The WindingTests property
        /// </summary>
        IOrderedSetExpression<IDistributionWindingTest> WindingTests
        {
            get;
        }
        
        /// <summary>
        /// The Windings property
        /// </summary>
        IOrderedSetExpression<IDistributionTransformerWinding> Windings
        {
            get;
        }
        
        /// <summary>
        /// The ToWindingSpecs property
        /// </summary>
        IOrderedSetExpression<IToWindingSpec> ToWindingSpecs
        {
            get;
        }
        
        /// <summary>
        /// The TransformerInfo property
        /// </summary>
        ITransformerInfo TransformerInfo
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the EmergencyS property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> EmergencySChanging;
        
        /// <summary>
        /// Gets fired when the EmergencyS property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> EmergencySChanged;
        
        /// <summary>
        /// Gets fired before the PhaseAngle property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PhaseAngleChanging;
        
        /// <summary>
        /// Gets fired when the PhaseAngle property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PhaseAngleChanged;
        
        /// <summary>
        /// Gets fired before the RatedS property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> RatedSChanging;
        
        /// <summary>
        /// Gets fired when the RatedS property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> RatedSChanged;
        
        /// <summary>
        /// Gets fired before the RatedU property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> RatedUChanging;
        
        /// <summary>
        /// Gets fired when the RatedU property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> RatedUChanged;
        
        /// <summary>
        /// Gets fired before the R property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> RChanging;
        
        /// <summary>
        /// Gets fired when the R property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> RChanged;
        
        /// <summary>
        /// Gets fired before the SequenceNumber property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> SequenceNumberChanging;
        
        /// <summary>
        /// Gets fired when the SequenceNumber property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> SequenceNumberChanged;
        
        /// <summary>
        /// Gets fired before the ShortTermS property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ShortTermSChanging;
        
        /// <summary>
        /// Gets fired when the ShortTermS property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ShortTermSChanged;
        
        /// <summary>
        /// Gets fired before the ConnectionKind property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ConnectionKindChanging;
        
        /// <summary>
        /// Gets fired when the ConnectionKind property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ConnectionKindChanged;
        
        /// <summary>
        /// Gets fired before the InsulationU property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> InsulationUChanging;
        
        /// <summary>
        /// Gets fired when the InsulationU property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> InsulationUChanged;
        
        /// <summary>
        /// Gets fired before the TransformerInfo property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TransformerInfoChanging;
        
        /// <summary>
        /// Gets fired when the TransformerInfo property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TransformerInfoChanged;
    }
}

