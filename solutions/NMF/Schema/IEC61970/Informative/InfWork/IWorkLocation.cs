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
using TTC2017.SmartGrids.CIM.IEC61968.Assets;
using TTC2017.SmartGrids.CIM.IEC61968.Common;
using TTC2017.SmartGrids.CIM.IEC61968.Work;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssets;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfCommon;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfERPSupport;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfGMLSupport;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfLocations;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfOperations;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfTypeAsset;

namespace TTC2017.SmartGrids.CIM.IEC61970.Informative.InfWork
{
    
    
    /// <summary>
    /// The public interface for WorkLocation
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(WorkLocation))]
    [XmlDefaultImplementationTypeAttribute(typeof(WorkLocation))]
    public interface IWorkLocation : IModelElement, ILocation
    {
        
        /// <summary>
        /// The subdivision property
        /// </summary>
        string Subdivision
        {
            get;
            set;
        }
        
        /// <summary>
        /// The block property
        /// </summary>
        string Block
        {
            get;
            set;
        }
        
        /// <summary>
        /// The lot property
        /// </summary>
        string Lot
        {
            get;
            set;
        }
        
        /// <summary>
        /// The nearestIntersection property
        /// </summary>
        string NearestIntersection
        {
            get;
            set;
        }
        
        /// <summary>
        /// The DesignLocations property
        /// </summary>
        IOrderedSetExpression<IDesignLocation> DesignLocations
        {
            get;
        }
        
        /// <summary>
        /// The OneCallRequest property
        /// </summary>
        IOneCallRequest OneCallRequest
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the Subdivision property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> SubdivisionChanging;
        
        /// <summary>
        /// Gets fired when the Subdivision property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> SubdivisionChanged;
        
        /// <summary>
        /// Gets fired before the Block property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> BlockChanging;
        
        /// <summary>
        /// Gets fired when the Block property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> BlockChanged;
        
        /// <summary>
        /// Gets fired before the Lot property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LotChanging;
        
        /// <summary>
        /// Gets fired when the Lot property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LotChanged;
        
        /// <summary>
        /// Gets fired before the NearestIntersection property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> NearestIntersectionChanging;
        
        /// <summary>
        /// Gets fired when the NearestIntersection property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> NearestIntersectionChanged;
        
        /// <summary>
        /// Gets fired before the OneCallRequest property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> OneCallRequestChanging;
        
        /// <summary>
        /// Gets fired when the OneCallRequest property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> OneCallRequestChanged;
    }
}

