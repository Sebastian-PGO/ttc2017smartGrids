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
    /// The public interface for PhaseImpedanceData
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(PhaseImpedanceData))]
    [XmlDefaultImplementationTypeAttribute(typeof(PhaseImpedanceData))]
    public interface IPhaseImpedanceData : IModelElement, IElement
    {
        
        /// <summary>
        /// The sequenceNumber property
        /// </summary>
        int SequenceNumber
        {
            get;
            set;
        }
        
        /// <summary>
        /// The b property
        /// </summary>
        float B
        {
            get;
            set;
        }
        
        /// <summary>
        /// The x property
        /// </summary>
        float X
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
        /// The PhaseImpedance property
        /// </summary>
        IPerLengthPhaseImpedance PhaseImpedance
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the SequenceNumber property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> SequenceNumberChanging;
        
        /// <summary>
        /// Gets fired when the SequenceNumber property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> SequenceNumberChanged;
        
        /// <summary>
        /// Gets fired before the B property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> BChanging;
        
        /// <summary>
        /// Gets fired when the B property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> BChanged;
        
        /// <summary>
        /// Gets fired before the X property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> XChanging;
        
        /// <summary>
        /// Gets fired when the X property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> XChanged;
        
        /// <summary>
        /// Gets fired before the R property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> RChanging;
        
        /// <summary>
        /// Gets fired when the R property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> RChanged;
        
        /// <summary>
        /// Gets fired before the PhaseImpedance property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PhaseImpedanceChanging;
        
        /// <summary>
        /// Gets fired when the PhaseImpedance property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PhaseImpedanceChanged;
    }
}

