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
using TTC2017.SmartGrids.SubstationStandard.Dataclasses;
using TTC2017.SmartGrids.SubstationStandard.LNNodes.DomainLNs;

namespace TTC2017.SmartGrids.SubstationStandard.LNNodes.LNGroupR
{
    
    
    /// <summary>
    /// The public interface for RFLO
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(RFLO))]
    [XmlDefaultImplementationTypeAttribute(typeof(RFLO))]
    public interface IRFLO : IModelElement, IGroupR
    {
        
        /// <summary>
        /// The OpCntRs property
        /// </summary>
        IINC OpCntRs
        {
            get;
            set;
        }
        
        /// <summary>
        /// The FltZ property
        /// </summary>
        ICMV FltZ
        {
            get;
            set;
        }
        
        /// <summary>
        /// The FltDiskm property
        /// </summary>
        IMV FltDiskm
        {
            get;
            set;
        }
        
        /// <summary>
        /// The FltLoop property
        /// </summary>
        IINS FltLoop
        {
            get;
            set;
        }
        
        /// <summary>
        /// The LinLenKm property
        /// </summary>
        IASG LinLenKm
        {
            get;
            set;
        }
        
        /// <summary>
        /// The R1 property
        /// </summary>
        IASG R1
        {
            get;
            set;
        }
        
        /// <summary>
        /// The X1 property
        /// </summary>
        IASG X1
        {
            get;
            set;
        }
        
        /// <summary>
        /// The R0 property
        /// </summary>
        IASG R0
        {
            get;
            set;
        }
        
        /// <summary>
        /// The X0 property
        /// </summary>
        IASG X0
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Z1Mod property
        /// </summary>
        IASG Z1Mod
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Z1Ang property
        /// </summary>
        IASG Z1Ang
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Z0Mod property
        /// </summary>
        IASG Z0Mod
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Z0Ang property
        /// </summary>
        IASG Z0Ang
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Rm0 property
        /// </summary>
        IASG Rm0
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Xm0 property
        /// </summary>
        IASG Xm0
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Zm0Mod property
        /// </summary>
        IASG Zm0Mod
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Zm0Ang property
        /// </summary>
        IASG Zm0Ang
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the OpCntRs property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> OpCntRsChanging;
        
        /// <summary>
        /// Gets fired when the OpCntRs property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> OpCntRsChanged;
        
        /// <summary>
        /// Gets fired before the FltZ property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FltZChanging;
        
        /// <summary>
        /// Gets fired when the FltZ property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FltZChanged;
        
        /// <summary>
        /// Gets fired before the FltDiskm property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FltDiskmChanging;
        
        /// <summary>
        /// Gets fired when the FltDiskm property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FltDiskmChanged;
        
        /// <summary>
        /// Gets fired before the FltLoop property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FltLoopChanging;
        
        /// <summary>
        /// Gets fired when the FltLoop property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FltLoopChanged;
        
        /// <summary>
        /// Gets fired before the LinLenKm property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LinLenKmChanging;
        
        /// <summary>
        /// Gets fired when the LinLenKm property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LinLenKmChanged;
        
        /// <summary>
        /// Gets fired before the R1 property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> R1Changing;
        
        /// <summary>
        /// Gets fired when the R1 property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> R1Changed;
        
        /// <summary>
        /// Gets fired before the X1 property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> X1Changing;
        
        /// <summary>
        /// Gets fired when the X1 property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> X1Changed;
        
        /// <summary>
        /// Gets fired before the R0 property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> R0Changing;
        
        /// <summary>
        /// Gets fired when the R0 property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> R0Changed;
        
        /// <summary>
        /// Gets fired before the X0 property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> X0Changing;
        
        /// <summary>
        /// Gets fired when the X0 property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> X0Changed;
        
        /// <summary>
        /// Gets fired before the Z1Mod property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Z1ModChanging;
        
        /// <summary>
        /// Gets fired when the Z1Mod property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Z1ModChanged;
        
        /// <summary>
        /// Gets fired before the Z1Ang property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Z1AngChanging;
        
        /// <summary>
        /// Gets fired when the Z1Ang property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Z1AngChanged;
        
        /// <summary>
        /// Gets fired before the Z0Mod property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Z0ModChanging;
        
        /// <summary>
        /// Gets fired when the Z0Mod property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Z0ModChanged;
        
        /// <summary>
        /// Gets fired before the Z0Ang property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Z0AngChanging;
        
        /// <summary>
        /// Gets fired when the Z0Ang property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Z0AngChanged;
        
        /// <summary>
        /// Gets fired before the Rm0 property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Rm0Changing;
        
        /// <summary>
        /// Gets fired when the Rm0 property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Rm0Changed;
        
        /// <summary>
        /// Gets fired before the Xm0 property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Xm0Changing;
        
        /// <summary>
        /// Gets fired when the Xm0 property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Xm0Changed;
        
        /// <summary>
        /// Gets fired before the Zm0Mod property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Zm0ModChanging;
        
        /// <summary>
        /// Gets fired when the Zm0Mod property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Zm0ModChanged;
        
        /// <summary>
        /// Gets fired before the Zm0Ang property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Zm0AngChanging;
        
        /// <summary>
        /// Gets fired when the Zm0Ang property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Zm0AngChanged;
    }
}

