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
using TTC2017.SmartGrids.SubstationStandard.Enumerations;
using TTC2017.SmartGrids.SubstationStandard.LNNodes.DomainLNs;
using TTC2017.SmartGrids.SubstationStandard.LNNodes.LNGroupA;

namespace TTC2017.SmartGrids.SubstationStandard.LNNodes.LNGroupZ
{
    
    
    /// <summary>
    /// The public interface for ZGEN
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(ZGEN))]
    [XmlDefaultImplementationTypeAttribute(typeof(ZGEN))]
    public interface IZGEN : IModelElement, IGroupZ
    {
        
        /// <summary>
        /// The GnSt property
        /// </summary>
        Nullable<GeneratorStateKind> GnSt
        {
            get;
            set;
        }
        
        /// <summary>
        /// The OpTmh property
        /// </summary>
        IINS OpTmh
        {
            get;
            set;
        }
        
        /// <summary>
        /// The GnCtl property
        /// </summary>
        IDPC GnCtl
        {
            get;
            set;
        }
        
        /// <summary>
        /// The DExt property
        /// </summary>
        ISPC DExt
        {
            get;
            set;
        }
        
        /// <summary>
        /// The AuxSCO property
        /// </summary>
        ISPC AuxSCO
        {
            get;
            set;
        }
        
        /// <summary>
        /// The StopVlv property
        /// </summary>
        ISPC StopVlv
        {
            get;
            set;
        }
        
        /// <summary>
        /// The ReactPwrR property
        /// </summary>
        ISPC ReactPwrR
        {
            get;
            set;
        }
        
        /// <summary>
        /// The ReactPwrL property
        /// </summary>
        ISPC ReactPwrL
        {
            get;
            set;
        }
        
        /// <summary>
        /// The GnSpd property
        /// </summary>
        IMV GnSpd
        {
            get;
            set;
        }
        
        /// <summary>
        /// The OANL property
        /// </summary>
        ISPS OANL
        {
            get;
            set;
        }
        
        /// <summary>
        /// The ClkRot property
        /// </summary>
        ISPS ClkRot
        {
            get;
            set;
        }
        
        /// <summary>
        /// The CntClkRot property
        /// </summary>
        ISPS CntClkRot
        {
            get;
            set;
        }
        
        /// <summary>
        /// The OpUnExt property
        /// </summary>
        ISPS OpUnExt
        {
            get;
            set;
        }
        
        /// <summary>
        /// The OpOvExt property
        /// </summary>
        ISPS OpOvExt
        {
            get;
            set;
        }
        
        /// <summary>
        /// The LosOil property
        /// </summary>
        ISPS LosOil
        {
            get;
            set;
        }
        
        /// <summary>
        /// The LosVac property
        /// </summary>
        ISPS LosVac
        {
            get;
            set;
        }
        
        /// <summary>
        /// The PresAlm property
        /// </summary>
        ISPS PresAlm
        {
            get;
            set;
        }
        
        /// <summary>
        /// The DmdPwr property
        /// </summary>
        IASG DmdPwr
        {
            get;
            set;
        }
        
        /// <summary>
        /// The PwrRtg property
        /// </summary>
        IASG PwrRtg
        {
            get;
            set;
        }
        
        /// <summary>
        /// The VRtg property
        /// </summary>
        IASG VRtg
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the GnSt property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> GnStChanging;
        
        /// <summary>
        /// Gets fired when the GnSt property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> GnStChanged;
        
        /// <summary>
        /// Gets fired before the OpTmh property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> OpTmhChanging;
        
        /// <summary>
        /// Gets fired when the OpTmh property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> OpTmhChanged;
        
        /// <summary>
        /// Gets fired before the GnCtl property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> GnCtlChanging;
        
        /// <summary>
        /// Gets fired when the GnCtl property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> GnCtlChanged;
        
        /// <summary>
        /// Gets fired before the DExt property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DExtChanging;
        
        /// <summary>
        /// Gets fired when the DExt property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DExtChanged;
        
        /// <summary>
        /// Gets fired before the AuxSCO property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AuxSCOChanging;
        
        /// <summary>
        /// Gets fired when the AuxSCO property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AuxSCOChanged;
        
        /// <summary>
        /// Gets fired before the StopVlv property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> StopVlvChanging;
        
        /// <summary>
        /// Gets fired when the StopVlv property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> StopVlvChanged;
        
        /// <summary>
        /// Gets fired before the ReactPwrR property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ReactPwrRChanging;
        
        /// <summary>
        /// Gets fired when the ReactPwrR property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ReactPwrRChanged;
        
        /// <summary>
        /// Gets fired before the ReactPwrL property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ReactPwrLChanging;
        
        /// <summary>
        /// Gets fired when the ReactPwrL property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ReactPwrLChanged;
        
        /// <summary>
        /// Gets fired before the GnSpd property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> GnSpdChanging;
        
        /// <summary>
        /// Gets fired when the GnSpd property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> GnSpdChanged;
        
        /// <summary>
        /// Gets fired before the OANL property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> OANLChanging;
        
        /// <summary>
        /// Gets fired when the OANL property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> OANLChanged;
        
        /// <summary>
        /// Gets fired before the ClkRot property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ClkRotChanging;
        
        /// <summary>
        /// Gets fired when the ClkRot property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ClkRotChanged;
        
        /// <summary>
        /// Gets fired before the CntClkRot property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CntClkRotChanging;
        
        /// <summary>
        /// Gets fired when the CntClkRot property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CntClkRotChanged;
        
        /// <summary>
        /// Gets fired before the OpUnExt property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> OpUnExtChanging;
        
        /// <summary>
        /// Gets fired when the OpUnExt property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> OpUnExtChanged;
        
        /// <summary>
        /// Gets fired before the OpOvExt property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> OpOvExtChanging;
        
        /// <summary>
        /// Gets fired when the OpOvExt property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> OpOvExtChanged;
        
        /// <summary>
        /// Gets fired before the LosOil property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LosOilChanging;
        
        /// <summary>
        /// Gets fired when the LosOil property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LosOilChanged;
        
        /// <summary>
        /// Gets fired before the LosVac property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LosVacChanging;
        
        /// <summary>
        /// Gets fired when the LosVac property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LosVacChanged;
        
        /// <summary>
        /// Gets fired before the PresAlm property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PresAlmChanging;
        
        /// <summary>
        /// Gets fired when the PresAlm property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PresAlmChanged;
        
        /// <summary>
        /// Gets fired before the DmdPwr property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DmdPwrChanging;
        
        /// <summary>
        /// Gets fired when the DmdPwr property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DmdPwrChanged;
        
        /// <summary>
        /// Gets fired before the PwrRtg property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PwrRtgChanging;
        
        /// <summary>
        /// Gets fired when the PwrRtg property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PwrRtgChanged;
        
        /// <summary>
        /// Gets fired before the VRtg property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> VRtgChanging;
        
        /// <summary>
        /// Gets fired when the VRtg property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> VRtgChanged;
    }
}
