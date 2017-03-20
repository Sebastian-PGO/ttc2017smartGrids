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
using TTC2017.SmartGrids.COSEM.InterfaceClasses;

namespace TTC2017.SmartGrids.COSEM.COSEMObjects
{
    
    
    /// <summary>
    /// The public interface for ExtendedPhaseAngleMeasurement
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(ExtendedPhaseAngleMeasurement))]
    [XmlDefaultImplementationTypeAttribute(typeof(ExtendedPhaseAngleMeasurement))]
    public interface IExtendedPhaseAngleMeasurement : IModelElement, IData
    {
        
        /// <summary>
        /// The FromUL1toUL2 property
        /// </summary>
        Nullable<double> FromUL1toUL2
        {
            get;
            set;
        }
        
        /// <summary>
        /// The FromUL1toUL3 property
        /// </summary>
        Nullable<double> FromUL1toUL3
        {
            get;
            set;
        }
        
        /// <summary>
        /// The FromUL1toIL1 property
        /// </summary>
        Nullable<double> FromUL1toIL1
        {
            get;
            set;
        }
        
        /// <summary>
        /// The FromUL1toIL2 property
        /// </summary>
        Nullable<double> FromUL1toIL2
        {
            get;
            set;
        }
        
        /// <summary>
        /// The FromUL1toIL3 property
        /// </summary>
        Nullable<double> FromUL1toIL3
        {
            get;
            set;
        }
        
        /// <summary>
        /// The FromUL1toIL0 property
        /// </summary>
        Nullable<double> FromUL1toIL0
        {
            get;
            set;
        }
        
        /// <summary>
        /// The FromUL2toUL1 property
        /// </summary>
        Nullable<double> FromUL2toUL1
        {
            get;
            set;
        }
        
        /// <summary>
        /// The FromUL2toUL3 property
        /// </summary>
        Nullable<double> FromUL2toUL3
        {
            get;
            set;
        }
        
        /// <summary>
        /// The FromUL2toIL1 property
        /// </summary>
        Nullable<double> FromUL2toIL1
        {
            get;
            set;
        }
        
        /// <summary>
        /// The FromUL2toIL2 property
        /// </summary>
        Nullable<double> FromUL2toIL2
        {
            get;
            set;
        }
        
        /// <summary>
        /// The FromUL2toIL3 property
        /// </summary>
        Nullable<double> FromUL2toIL3
        {
            get;
            set;
        }
        
        /// <summary>
        /// The FromUL2toIL0 property
        /// </summary>
        Nullable<double> FromUL2toIL0
        {
            get;
            set;
        }
        
        /// <summary>
        /// The FromUL3toUL1 property
        /// </summary>
        Nullable<double> FromUL3toUL1
        {
            get;
            set;
        }
        
        /// <summary>
        /// The FromUL3toUL2 property
        /// </summary>
        Nullable<double> FromUL3toUL2
        {
            get;
            set;
        }
        
        /// <summary>
        /// The FromUL3toIL1 property
        /// </summary>
        Nullable<double> FromUL3toIL1
        {
            get;
            set;
        }
        
        /// <summary>
        /// The FromUL3toIL2 property
        /// </summary>
        Nullable<double> FromUL3toIL2
        {
            get;
            set;
        }
        
        /// <summary>
        /// The FromUL3toIL3 property
        /// </summary>
        Nullable<double> FromUL3toIL3
        {
            get;
            set;
        }
        
        /// <summary>
        /// The FromUL3toIL0 property
        /// </summary>
        Nullable<double> FromUL3toIL0
        {
            get;
            set;
        }
        
        /// <summary>
        /// The FromIL1toUL1 property
        /// </summary>
        Nullable<double> FromIL1toUL1
        {
            get;
            set;
        }
        
        /// <summary>
        /// The FromIL1toUL2 property
        /// </summary>
        Nullable<double> FromIL1toUL2
        {
            get;
            set;
        }
        
        /// <summary>
        /// The FromIL1toUL3 property
        /// </summary>
        Nullable<double> FromIL1toUL3
        {
            get;
            set;
        }
        
        /// <summary>
        /// The FromIL1toIL2 property
        /// </summary>
        Nullable<double> FromIL1toIL2
        {
            get;
            set;
        }
        
        /// <summary>
        /// The FromIL1toIL3 property
        /// </summary>
        Nullable<double> FromIL1toIL3
        {
            get;
            set;
        }
        
        /// <summary>
        /// The FromIL1toIL0 property
        /// </summary>
        Nullable<double> FromIL1toIL0
        {
            get;
            set;
        }
        
        /// <summary>
        /// The FromIL2toUL1 property
        /// </summary>
        Nullable<double> FromIL2toUL1
        {
            get;
            set;
        }
        
        /// <summary>
        /// The FromIL2toUL2 property
        /// </summary>
        Nullable<double> FromIL2toUL2
        {
            get;
            set;
        }
        
        /// <summary>
        /// The FromIL2toUL3 property
        /// </summary>
        Nullable<double> FromIL2toUL3
        {
            get;
            set;
        }
        
        /// <summary>
        /// The FromIL2toIL1 property
        /// </summary>
        Nullable<double> FromIL2toIL1
        {
            get;
            set;
        }
        
        /// <summary>
        /// The FromIL2toIL3 property
        /// </summary>
        Nullable<double> FromIL2toIL3
        {
            get;
            set;
        }
        
        /// <summary>
        /// The FromIL2toIL0 property
        /// </summary>
        Nullable<double> FromIL2toIL0
        {
            get;
            set;
        }
        
        /// <summary>
        /// The FromIL3toUL1 property
        /// </summary>
        Nullable<double> FromIL3toUL1
        {
            get;
            set;
        }
        
        /// <summary>
        /// The FromIL3toUL2 property
        /// </summary>
        Nullable<double> FromIL3toUL2
        {
            get;
            set;
        }
        
        /// <summary>
        /// The FromIL3toUL3 property
        /// </summary>
        Nullable<double> FromIL3toUL3
        {
            get;
            set;
        }
        
        /// <summary>
        /// The FromIL3toIL1 property
        /// </summary>
        Nullable<double> FromIL3toIL1
        {
            get;
            set;
        }
        
        /// <summary>
        /// The FromIL3toIL2 property
        /// </summary>
        Nullable<double> FromIL3toIL2
        {
            get;
            set;
        }
        
        /// <summary>
        /// The FromIL3toIL0 property
        /// </summary>
        Nullable<double> FromIL3toIL0
        {
            get;
            set;
        }
        
        /// <summary>
        /// The FromIL0toUL1 property
        /// </summary>
        Nullable<double> FromIL0toUL1
        {
            get;
            set;
        }
        
        /// <summary>
        /// The FromIL0toUL2 property
        /// </summary>
        Nullable<double> FromIL0toUL2
        {
            get;
            set;
        }
        
        /// <summary>
        /// The FromIL0toUL3 property
        /// </summary>
        Nullable<double> FromIL0toUL3
        {
            get;
            set;
        }
        
        /// <summary>
        /// The FromIL0toIL1 property
        /// </summary>
        Nullable<double> FromIL0toIL1
        {
            get;
            set;
        }
        
        /// <summary>
        /// The FromIL0toIL2 property
        /// </summary>
        Nullable<double> FromIL0toIL2
        {
            get;
            set;
        }
        
        /// <summary>
        /// The FromIL0toIL3 property
        /// </summary>
        Nullable<double> FromIL0toIL3
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the FromUL1toUL2 property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FromUL1toUL2Changing;
        
        /// <summary>
        /// Gets fired when the FromUL1toUL2 property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FromUL1toUL2Changed;
        
        /// <summary>
        /// Gets fired before the FromUL1toUL3 property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FromUL1toUL3Changing;
        
        /// <summary>
        /// Gets fired when the FromUL1toUL3 property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FromUL1toUL3Changed;
        
        /// <summary>
        /// Gets fired before the FromUL1toIL1 property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FromUL1toIL1Changing;
        
        /// <summary>
        /// Gets fired when the FromUL1toIL1 property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FromUL1toIL1Changed;
        
        /// <summary>
        /// Gets fired before the FromUL1toIL2 property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FromUL1toIL2Changing;
        
        /// <summary>
        /// Gets fired when the FromUL1toIL2 property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FromUL1toIL2Changed;
        
        /// <summary>
        /// Gets fired before the FromUL1toIL3 property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FromUL1toIL3Changing;
        
        /// <summary>
        /// Gets fired when the FromUL1toIL3 property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FromUL1toIL3Changed;
        
        /// <summary>
        /// Gets fired before the FromUL1toIL0 property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FromUL1toIL0Changing;
        
        /// <summary>
        /// Gets fired when the FromUL1toIL0 property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FromUL1toIL0Changed;
        
        /// <summary>
        /// Gets fired before the FromUL2toUL1 property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FromUL2toUL1Changing;
        
        /// <summary>
        /// Gets fired when the FromUL2toUL1 property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FromUL2toUL1Changed;
        
        /// <summary>
        /// Gets fired before the FromUL2toUL3 property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FromUL2toUL3Changing;
        
        /// <summary>
        /// Gets fired when the FromUL2toUL3 property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FromUL2toUL3Changed;
        
        /// <summary>
        /// Gets fired before the FromUL2toIL1 property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FromUL2toIL1Changing;
        
        /// <summary>
        /// Gets fired when the FromUL2toIL1 property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FromUL2toIL1Changed;
        
        /// <summary>
        /// Gets fired before the FromUL2toIL2 property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FromUL2toIL2Changing;
        
        /// <summary>
        /// Gets fired when the FromUL2toIL2 property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FromUL2toIL2Changed;
        
        /// <summary>
        /// Gets fired before the FromUL2toIL3 property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FromUL2toIL3Changing;
        
        /// <summary>
        /// Gets fired when the FromUL2toIL3 property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FromUL2toIL3Changed;
        
        /// <summary>
        /// Gets fired before the FromUL2toIL0 property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FromUL2toIL0Changing;
        
        /// <summary>
        /// Gets fired when the FromUL2toIL0 property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FromUL2toIL0Changed;
        
        /// <summary>
        /// Gets fired before the FromUL3toUL1 property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FromUL3toUL1Changing;
        
        /// <summary>
        /// Gets fired when the FromUL3toUL1 property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FromUL3toUL1Changed;
        
        /// <summary>
        /// Gets fired before the FromUL3toUL2 property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FromUL3toUL2Changing;
        
        /// <summary>
        /// Gets fired when the FromUL3toUL2 property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FromUL3toUL2Changed;
        
        /// <summary>
        /// Gets fired before the FromUL3toIL1 property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FromUL3toIL1Changing;
        
        /// <summary>
        /// Gets fired when the FromUL3toIL1 property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FromUL3toIL1Changed;
        
        /// <summary>
        /// Gets fired before the FromUL3toIL2 property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FromUL3toIL2Changing;
        
        /// <summary>
        /// Gets fired when the FromUL3toIL2 property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FromUL3toIL2Changed;
        
        /// <summary>
        /// Gets fired before the FromUL3toIL3 property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FromUL3toIL3Changing;
        
        /// <summary>
        /// Gets fired when the FromUL3toIL3 property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FromUL3toIL3Changed;
        
        /// <summary>
        /// Gets fired before the FromUL3toIL0 property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FromUL3toIL0Changing;
        
        /// <summary>
        /// Gets fired when the FromUL3toIL0 property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FromUL3toIL0Changed;
        
        /// <summary>
        /// Gets fired before the FromIL1toUL1 property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FromIL1toUL1Changing;
        
        /// <summary>
        /// Gets fired when the FromIL1toUL1 property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FromIL1toUL1Changed;
        
        /// <summary>
        /// Gets fired before the FromIL1toUL2 property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FromIL1toUL2Changing;
        
        /// <summary>
        /// Gets fired when the FromIL1toUL2 property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FromIL1toUL2Changed;
        
        /// <summary>
        /// Gets fired before the FromIL1toUL3 property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FromIL1toUL3Changing;
        
        /// <summary>
        /// Gets fired when the FromIL1toUL3 property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FromIL1toUL3Changed;
        
        /// <summary>
        /// Gets fired before the FromIL1toIL2 property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FromIL1toIL2Changing;
        
        /// <summary>
        /// Gets fired when the FromIL1toIL2 property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FromIL1toIL2Changed;
        
        /// <summary>
        /// Gets fired before the FromIL1toIL3 property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FromIL1toIL3Changing;
        
        /// <summary>
        /// Gets fired when the FromIL1toIL3 property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FromIL1toIL3Changed;
        
        /// <summary>
        /// Gets fired before the FromIL1toIL0 property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FromIL1toIL0Changing;
        
        /// <summary>
        /// Gets fired when the FromIL1toIL0 property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FromIL1toIL0Changed;
        
        /// <summary>
        /// Gets fired before the FromIL2toUL1 property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FromIL2toUL1Changing;
        
        /// <summary>
        /// Gets fired when the FromIL2toUL1 property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FromIL2toUL1Changed;
        
        /// <summary>
        /// Gets fired before the FromIL2toUL2 property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FromIL2toUL2Changing;
        
        /// <summary>
        /// Gets fired when the FromIL2toUL2 property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FromIL2toUL2Changed;
        
        /// <summary>
        /// Gets fired before the FromIL2toUL3 property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FromIL2toUL3Changing;
        
        /// <summary>
        /// Gets fired when the FromIL2toUL3 property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FromIL2toUL3Changed;
        
        /// <summary>
        /// Gets fired before the FromIL2toIL1 property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FromIL2toIL1Changing;
        
        /// <summary>
        /// Gets fired when the FromIL2toIL1 property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FromIL2toIL1Changed;
        
        /// <summary>
        /// Gets fired before the FromIL2toIL3 property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FromIL2toIL3Changing;
        
        /// <summary>
        /// Gets fired when the FromIL2toIL3 property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FromIL2toIL3Changed;
        
        /// <summary>
        /// Gets fired before the FromIL2toIL0 property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FromIL2toIL0Changing;
        
        /// <summary>
        /// Gets fired when the FromIL2toIL0 property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FromIL2toIL0Changed;
        
        /// <summary>
        /// Gets fired before the FromIL3toUL1 property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FromIL3toUL1Changing;
        
        /// <summary>
        /// Gets fired when the FromIL3toUL1 property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FromIL3toUL1Changed;
        
        /// <summary>
        /// Gets fired before the FromIL3toUL2 property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FromIL3toUL2Changing;
        
        /// <summary>
        /// Gets fired when the FromIL3toUL2 property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FromIL3toUL2Changed;
        
        /// <summary>
        /// Gets fired before the FromIL3toUL3 property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FromIL3toUL3Changing;
        
        /// <summary>
        /// Gets fired when the FromIL3toUL3 property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FromIL3toUL3Changed;
        
        /// <summary>
        /// Gets fired before the FromIL3toIL1 property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FromIL3toIL1Changing;
        
        /// <summary>
        /// Gets fired when the FromIL3toIL1 property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FromIL3toIL1Changed;
        
        /// <summary>
        /// Gets fired before the FromIL3toIL2 property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FromIL3toIL2Changing;
        
        /// <summary>
        /// Gets fired when the FromIL3toIL2 property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FromIL3toIL2Changed;
        
        /// <summary>
        /// Gets fired before the FromIL3toIL0 property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FromIL3toIL0Changing;
        
        /// <summary>
        /// Gets fired when the FromIL3toIL0 property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FromIL3toIL0Changed;
        
        /// <summary>
        /// Gets fired before the FromIL0toUL1 property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FromIL0toUL1Changing;
        
        /// <summary>
        /// Gets fired when the FromIL0toUL1 property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FromIL0toUL1Changed;
        
        /// <summary>
        /// Gets fired before the FromIL0toUL2 property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FromIL0toUL2Changing;
        
        /// <summary>
        /// Gets fired when the FromIL0toUL2 property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FromIL0toUL2Changed;
        
        /// <summary>
        /// Gets fired before the FromIL0toUL3 property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FromIL0toUL3Changing;
        
        /// <summary>
        /// Gets fired when the FromIL0toUL3 property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FromIL0toUL3Changed;
        
        /// <summary>
        /// Gets fired before the FromIL0toIL1 property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FromIL0toIL1Changing;
        
        /// <summary>
        /// Gets fired when the FromIL0toIL1 property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FromIL0toIL1Changed;
        
        /// <summary>
        /// Gets fired before the FromIL0toIL2 property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FromIL0toIL2Changing;
        
        /// <summary>
        /// Gets fired when the FromIL0toIL2 property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FromIL0toIL2Changed;
        
        /// <summary>
        /// Gets fired before the FromIL0toIL3 property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FromIL0toIL3Changing;
        
        /// <summary>
        /// Gets fired when the FromIL0toIL3 property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FromIL0toIL3Changed;
    }
}
