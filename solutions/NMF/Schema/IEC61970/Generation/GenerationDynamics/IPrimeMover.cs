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
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Generation.Production;
using TTC2017.SmartGrids.CIM.IEC61970.Wires;

namespace TTC2017.SmartGrids.CIM.IEC61970.Generation.GenerationDynamics
{
    
    
    /// <summary>
    /// The public interface for PrimeMover
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(PrimeMover))]
    [XmlDefaultImplementationTypeAttribute(typeof(PrimeMover))]
    public interface IPrimeMover : IModelElement, IPowerSystemResource
    {
        
        /// <summary>
        /// The primeMoverRating property
        /// </summary>
        float PrimeMoverRating
        {
            get;
            set;
        }
        
        /// <summary>
        /// The SynchronousMachines property
        /// </summary>
        IOrderedSetExpression<ISynchronousMachine> SynchronousMachines
        {
            get;
        }
        
        /// <summary>
        /// Gets fired before the PrimeMoverRating property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PrimeMoverRatingChanging;
        
        /// <summary>
        /// Gets fired when the PrimeMoverRating property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PrimeMoverRatingChanged;
    }
}

