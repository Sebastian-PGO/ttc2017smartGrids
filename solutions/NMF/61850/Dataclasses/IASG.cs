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
using TTC2017.SmartGrids.SubstationStandard.Enumerations;

namespace TTC2017.SmartGrids.SubstationStandard.Dataclasses
{
    
    
    /// <summary>
    /// The public interface for ASG
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(ASG))]
    [XmlDefaultImplementationTypeAttribute(typeof(ASG))]
    public interface IASG : IModelElement
    {
        
        /// <summary>
        /// The setMag property
        /// </summary>
        IAnalogueValue SetMag
        {
            get;
            set;
        }
        
        /// <summary>
        /// The units property
        /// </summary>
        IUnits Units
        {
            get;
            set;
        }
        
        /// <summary>
        /// The sVC property
        /// </summary>
        IScaledValueConfig SVC
        {
            get;
            set;
        }
        
        /// <summary>
        /// The minVal property
        /// </summary>
        IAnalogueValue MinVal
        {
            get;
            set;
        }
        
        /// <summary>
        /// The maxVal property
        /// </summary>
        IAnalogueValue MaxVal
        {
            get;
            set;
        }
        
        /// <summary>
        /// The stepSize property
        /// </summary>
        IAnalogueValue StepSize
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the SetMag property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> SetMagChanging;
        
        /// <summary>
        /// Gets fired when the SetMag property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> SetMagChanged;
        
        /// <summary>
        /// Gets fired before the Units property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> UnitsChanging;
        
        /// <summary>
        /// Gets fired when the Units property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> UnitsChanged;
        
        /// <summary>
        /// Gets fired before the SVC property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> SVCChanging;
        
        /// <summary>
        /// Gets fired when the SVC property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> SVCChanged;
        
        /// <summary>
        /// Gets fired before the MinVal property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> MinValChanging;
        
        /// <summary>
        /// Gets fired when the MinVal property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> MinValChanged;
        
        /// <summary>
        /// Gets fired before the MaxVal property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> MaxValChanging;
        
        /// <summary>
        /// Gets fired when the MaxVal property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> MaxValChanged;
        
        /// <summary>
        /// Gets fired before the StepSize property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> StepSizeChanging;
        
        /// <summary>
        /// Gets fired when the StepSize property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> StepSizeChanged;
    }
}

