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
using TTC2017.SmartGrids.CIM.IEC61968.Common;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfOperations;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfWork;
using TTC2017.SmartGrids.CIM.IEC61970.Meas;

namespace TTC2017.SmartGrids.CIM.IEC61970.Informative.InfGMLSupport
{
    
    
    /// <summary>
    /// The public interface for GmlLabelPlacement
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(GmlLabelPlacement))]
    [XmlDefaultImplementationTypeAttribute(typeof(GmlLabelPlacement))]
    public interface IGmlLabelPlacement : IModelElement, IIdentifiedObject
    {
        
        /// <summary>
        /// The type property
        /// </summary>
        string Type
        {
            get;
            set;
        }
        
        /// <summary>
        /// The offset property
        /// </summary>
        string Offset
        {
            get;
            set;
        }
        
        /// <summary>
        /// The anchorY property
        /// </summary>
        string AnchorY
        {
            get;
            set;
        }
        
        /// <summary>
        /// The anchorX property
        /// </summary>
        string AnchorX
        {
            get;
            set;
        }
        
        /// <summary>
        /// The rotation property
        /// </summary>
        string Rotation
        {
            get;
            set;
        }
        
        /// <summary>
        /// The displacementY property
        /// </summary>
        string DisplacementY
        {
            get;
            set;
        }
        
        /// <summary>
        /// The displacementX property
        /// </summary>
        string DisplacementX
        {
            get;
            set;
        }
        
        /// <summary>
        /// The GmlTextSymbols property
        /// </summary>
        IOrderedSetExpression<IGmlTextSymbol> GmlTextSymbols
        {
            get;
        }
        
        /// <summary>
        /// Gets fired before the Type property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TypeChanging;
        
        /// <summary>
        /// Gets fired when the Type property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TypeChanged;
        
        /// <summary>
        /// Gets fired before the Offset property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> OffsetChanging;
        
        /// <summary>
        /// Gets fired when the Offset property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> OffsetChanged;
        
        /// <summary>
        /// Gets fired before the AnchorY property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AnchorYChanging;
        
        /// <summary>
        /// Gets fired when the AnchorY property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AnchorYChanged;
        
        /// <summary>
        /// Gets fired before the AnchorX property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AnchorXChanging;
        
        /// <summary>
        /// Gets fired when the AnchorX property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AnchorXChanged;
        
        /// <summary>
        /// Gets fired before the Rotation property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> RotationChanging;
        
        /// <summary>
        /// Gets fired when the Rotation property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> RotationChanged;
        
        /// <summary>
        /// Gets fired before the DisplacementY property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DisplacementYChanging;
        
        /// <summary>
        /// Gets fired when the DisplacementY property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DisplacementYChanged;
        
        /// <summary>
        /// Gets fired before the DisplacementX property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DisplacementXChanging;
        
        /// <summary>
        /// Gets fired when the DisplacementX property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DisplacementXChanged;
    }
}

