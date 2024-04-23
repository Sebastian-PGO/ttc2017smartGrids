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
using TTC2017.SmartGrids.SubstationStandard.Dataclasses;
using TTC2017.SmartGrids.SubstationStandard.LNNodes.DomainLNs;

namespace TTC2017.SmartGrids.SubstationStandard.LNNodes.LNGroupP
{
    
    
    /// <summary>
    /// The public interface for PDIS
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(PDIS))]
    [XmlDefaultImplementationTypeAttribute(typeof(PDIS))]
    public interface IPDIS : IModelElement, IGroupP
    {
        
        /// <summary>
        /// The Str property
        /// </summary>
        IACD Str
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Op property
        /// </summary>
        IACT Op
        {
            get;
            set;
        }
        
        /// <summary>
        /// The PoRch property
        /// </summary>
        IASG PoRch
        {
            get;
            set;
        }
        
        /// <summary>
        /// The PhStr property
        /// </summary>
        IASG PhStr
        {
            get;
            set;
        }
        
        /// <summary>
        /// The GndStr property
        /// </summary>
        IASG GndStr
        {
            get;
            set;
        }
        
        /// <summary>
        /// The DirMod property
        /// </summary>
        IING DirMod
        {
            get;
            set;
        }
        
        /// <summary>
        /// The PctRch property
        /// </summary>
        IASG PctRch
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Ofs property
        /// </summary>
        IASG Ofs
        {
            get;
            set;
        }
        
        /// <summary>
        /// The PctOfs property
        /// </summary>
        IASG PctOfs
        {
            get;
            set;
        }
        
        /// <summary>
        /// The RisLod property
        /// </summary>
        IASG RisLod
        {
            get;
            set;
        }
        
        /// <summary>
        /// The AngLod property
        /// </summary>
        IASG AngLod
        {
            get;
            set;
        }
        
        /// <summary>
        /// The TmDlMod property
        /// </summary>
        ISPG TmDlMod
        {
            get;
            set;
        }
        
        /// <summary>
        /// The OpDlTmms property
        /// </summary>
        IING OpDlTmms
        {
            get;
            set;
        }
        
        /// <summary>
        /// The PhDlMod property
        /// </summary>
        ISPG PhDlMod
        {
            get;
            set;
        }
        
        /// <summary>
        /// The PhDlTmms property
        /// </summary>
        IING PhDlTmms
        {
            get;
            set;
        }
        
        /// <summary>
        /// The GndDlMod property
        /// </summary>
        ISPG GndDlMod
        {
            get;
            set;
        }
        
        /// <summary>
        /// The GndDlTmms property
        /// </summary>
        IING GndDlTmms
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
        /// The LinAng property
        /// </summary>
        IASG LinAng
        {
            get;
            set;
        }
        
        /// <summary>
        /// The RisGndRch property
        /// </summary>
        IASG RisGndRch
        {
            get;
            set;
        }
        
        /// <summary>
        /// The RisPhRch property
        /// </summary>
        IASG RisPhRch
        {
            get;
            set;
        }
        
        /// <summary>
        /// The K0Fact property
        /// </summary>
        IASG K0Fact
        {
            get;
            set;
        }
        
        /// <summary>
        /// The K0FactAng property
        /// </summary>
        IASG K0FactAng
        {
            get;
            set;
        }
        
        /// <summary>
        /// The RsDlTmms property
        /// </summary>
        IING RsDlTmms
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the Str property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> StrChanging;
        
        /// <summary>
        /// Gets fired when the Str property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> StrChanged;
        
        /// <summary>
        /// Gets fired before the Op property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> OpChanging;
        
        /// <summary>
        /// Gets fired when the Op property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> OpChanged;
        
        /// <summary>
        /// Gets fired before the PoRch property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PoRchChanging;
        
        /// <summary>
        /// Gets fired when the PoRch property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PoRchChanged;
        
        /// <summary>
        /// Gets fired before the PhStr property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PhStrChanging;
        
        /// <summary>
        /// Gets fired when the PhStr property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PhStrChanged;
        
        /// <summary>
        /// Gets fired before the GndStr property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> GndStrChanging;
        
        /// <summary>
        /// Gets fired when the GndStr property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> GndStrChanged;
        
        /// <summary>
        /// Gets fired before the DirMod property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DirModChanging;
        
        /// <summary>
        /// Gets fired when the DirMod property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DirModChanged;
        
        /// <summary>
        /// Gets fired before the PctRch property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PctRchChanging;
        
        /// <summary>
        /// Gets fired when the PctRch property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PctRchChanged;
        
        /// <summary>
        /// Gets fired before the Ofs property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> OfsChanging;
        
        /// <summary>
        /// Gets fired when the Ofs property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> OfsChanged;
        
        /// <summary>
        /// Gets fired before the PctOfs property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PctOfsChanging;
        
        /// <summary>
        /// Gets fired when the PctOfs property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PctOfsChanged;
        
        /// <summary>
        /// Gets fired before the RisLod property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> RisLodChanging;
        
        /// <summary>
        /// Gets fired when the RisLod property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> RisLodChanged;
        
        /// <summary>
        /// Gets fired before the AngLod property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AngLodChanging;
        
        /// <summary>
        /// Gets fired when the AngLod property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AngLodChanged;
        
        /// <summary>
        /// Gets fired before the TmDlMod property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TmDlModChanging;
        
        /// <summary>
        /// Gets fired when the TmDlMod property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TmDlModChanged;
        
        /// <summary>
        /// Gets fired before the OpDlTmms property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> OpDlTmmsChanging;
        
        /// <summary>
        /// Gets fired when the OpDlTmms property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> OpDlTmmsChanged;
        
        /// <summary>
        /// Gets fired before the PhDlMod property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PhDlModChanging;
        
        /// <summary>
        /// Gets fired when the PhDlMod property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PhDlModChanged;
        
        /// <summary>
        /// Gets fired before the PhDlTmms property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PhDlTmmsChanging;
        
        /// <summary>
        /// Gets fired when the PhDlTmms property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PhDlTmmsChanged;
        
        /// <summary>
        /// Gets fired before the GndDlMod property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> GndDlModChanging;
        
        /// <summary>
        /// Gets fired when the GndDlMod property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> GndDlModChanged;
        
        /// <summary>
        /// Gets fired before the GndDlTmms property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> GndDlTmmsChanging;
        
        /// <summary>
        /// Gets fired when the GndDlTmms property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> GndDlTmmsChanged;
        
        /// <summary>
        /// Gets fired before the X1 property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> X1Changing;
        
        /// <summary>
        /// Gets fired when the X1 property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> X1Changed;
        
        /// <summary>
        /// Gets fired before the LinAng property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LinAngChanging;
        
        /// <summary>
        /// Gets fired when the LinAng property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LinAngChanged;
        
        /// <summary>
        /// Gets fired before the RisGndRch property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> RisGndRchChanging;
        
        /// <summary>
        /// Gets fired when the RisGndRch property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> RisGndRchChanged;
        
        /// <summary>
        /// Gets fired before the RisPhRch property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> RisPhRchChanging;
        
        /// <summary>
        /// Gets fired when the RisPhRch property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> RisPhRchChanged;
        
        /// <summary>
        /// Gets fired before the K0Fact property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> K0FactChanging;
        
        /// <summary>
        /// Gets fired when the K0Fact property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> K0FactChanged;
        
        /// <summary>
        /// Gets fired before the K0FactAng property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> K0FactAngChanging;
        
        /// <summary>
        /// Gets fired when the K0FactAng property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> K0FactAngChanged;
        
        /// <summary>
        /// Gets fired before the RsDlTmms property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> RsDlTmmsChanging;
        
        /// <summary>
        /// Gets fired when the RsDlTmms property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> RsDlTmmsChanged;
    }
}

