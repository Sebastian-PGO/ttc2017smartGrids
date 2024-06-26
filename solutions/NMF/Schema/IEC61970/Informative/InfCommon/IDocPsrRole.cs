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
using TTC2017.SmartGrids.CIM.IEC61968.Assets;
using TTC2017.SmartGrids.CIM.IEC61968.Common;
using TTC2017.SmartGrids.CIM.IEC61968.PaymentMetering;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfERPSupport;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfPaymentMetering;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfWork;

namespace TTC2017.SmartGrids.CIM.IEC61970.Informative.InfCommon
{
    
    
    /// <summary>
    /// The public interface for DocPsrRole
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(DocPsrRole))]
    [XmlDefaultImplementationTypeAttribute(typeof(DocPsrRole))]
    public interface IDocPsrRole : IModelElement, IRole
    {
        
        /// <summary>
        /// The Document property
        /// </summary>
        IDocument Document
        {
            get;
            set;
        }
        
        /// <summary>
        /// The PowerSystemResource property
        /// </summary>
        IPowerSystemResource PowerSystemResource
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the Document property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DocumentChanging;
        
        /// <summary>
        /// Gets fired when the Document property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DocumentChanged;
        
        /// <summary>
        /// Gets fired before the PowerSystemResource property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PowerSystemResourceChanging;
        
        /// <summary>
        /// Gets fired when the PowerSystemResource property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PowerSystemResourceChanged;
    }
}

