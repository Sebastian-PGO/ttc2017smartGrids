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
using TTC2017.SmartGrids.COSEM;
using TTC2017.SmartGrids.COSEM.Datatypes;

namespace TTC2017.SmartGrids.COSEM.InterfaceClasses
{
    
    
    /// <summary>
    /// The public interface for DemandRegister
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(DemandRegister))]
    [XmlDefaultImplementationTypeAttribute(typeof(DemandRegister))]
    public interface IDemandRegister : IModelElement, IExtendedRegister
    {
        
        /// <summary>
        /// The number_of_periods property
        /// </summary>
        Nullable<int> Number_of_periods
        {
            get;
            set;
        }
        
        /// <summary>
        /// The period property
        /// </summary>
        Nullable<int> Period
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the Number_of_periods property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Number_of_periodsChanging;
        
        /// <summary>
        /// Gets fired when the Number_of_periods property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Number_of_periodsChanged;
        
        /// <summary>
        /// Gets fired before the Period property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PeriodChanging;
        
        /// <summary>
        /// Gets fired when the Period property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PeriodChanged;
    }
}

