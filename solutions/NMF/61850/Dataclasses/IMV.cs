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
    /// The public interface for MV
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(MV))]
    [XmlDefaultImplementationTypeAttribute(typeof(MV))]
    public interface IMV : IModelElement
    {
        
        /// <summary>
        /// The subEna property
        /// </summary>
        Nullable<bool> SubEna
        {
            get;
            set;
        }
        
        /// <summary>
        /// The subID property
        /// </summary>
        string SubID
        {
            get;
            set;
        }
        
        /// <summary>
        /// The db property
        /// </summary>
        Nullable<int> Db
        {
            get;
            set;
        }
        
        /// <summary>
        /// The zeroDb property
        /// </summary>
        Nullable<int> ZeroDb
        {
            get;
            set;
        }
        
        /// <summary>
        /// The smpRate property
        /// </summary>
        Nullable<int> SmpRate
        {
            get;
            set;
        }
        
        /// <summary>
        /// The instMag property
        /// </summary>
        IAnalogueValue InstMag
        {
            get;
            set;
        }
        
        /// <summary>
        /// The mag property
        /// </summary>
        IAnalogueValue Mag
        {
            get;
            set;
        }
        
        /// <summary>
        /// The range property
        /// </summary>
        IRange Range
        {
            get;
            set;
        }
        
        /// <summary>
        /// The q property
        /// </summary>
        IQuality Q
        {
            get;
            set;
        }
        
        /// <summary>
        /// The t property
        /// </summary>
        ITimeStamp T
        {
            get;
            set;
        }
        
        /// <summary>
        /// The subMag property
        /// </summary>
        IAnalogueValue SubMag
        {
            get;
            set;
        }
        
        /// <summary>
        /// The subQ property
        /// </summary>
        IQuality SubQ
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
        /// The rangeC property
        /// </summary>
        IRangeConfig RangeC
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the SubEna property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> SubEnaChanging;
        
        /// <summary>
        /// Gets fired when the SubEna property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> SubEnaChanged;
        
        /// <summary>
        /// Gets fired before the SubID property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> SubIDChanging;
        
        /// <summary>
        /// Gets fired when the SubID property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> SubIDChanged;
        
        /// <summary>
        /// Gets fired before the Db property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DbChanging;
        
        /// <summary>
        /// Gets fired when the Db property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DbChanged;
        
        /// <summary>
        /// Gets fired before the ZeroDb property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ZeroDbChanging;
        
        /// <summary>
        /// Gets fired when the ZeroDb property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ZeroDbChanged;
        
        /// <summary>
        /// Gets fired before the SmpRate property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> SmpRateChanging;
        
        /// <summary>
        /// Gets fired when the SmpRate property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> SmpRateChanged;
        
        /// <summary>
        /// Gets fired before the InstMag property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> InstMagChanging;
        
        /// <summary>
        /// Gets fired when the InstMag property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> InstMagChanged;
        
        /// <summary>
        /// Gets fired before the Mag property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> MagChanging;
        
        /// <summary>
        /// Gets fired when the Mag property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> MagChanged;
        
        /// <summary>
        /// Gets fired before the Range property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> RangeChanging;
        
        /// <summary>
        /// Gets fired when the Range property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> RangeChanged;
        
        /// <summary>
        /// Gets fired before the Q property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> QChanging;
        
        /// <summary>
        /// Gets fired when the Q property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> QChanged;
        
        /// <summary>
        /// Gets fired before the T property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TChanging;
        
        /// <summary>
        /// Gets fired when the T property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TChanged;
        
        /// <summary>
        /// Gets fired before the SubMag property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> SubMagChanging;
        
        /// <summary>
        /// Gets fired when the SubMag property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> SubMagChanged;
        
        /// <summary>
        /// Gets fired before the SubQ property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> SubQChanging;
        
        /// <summary>
        /// Gets fired when the SubQ property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> SubQChanged;
        
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
        /// Gets fired before the RangeC property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> RangeCChanging;
        
        /// <summary>
        /// Gets fired when the RangeC property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> RangeCChanged;
    }
}

