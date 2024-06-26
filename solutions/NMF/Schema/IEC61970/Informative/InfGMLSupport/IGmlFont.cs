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
    /// The public interface for GmlFont
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(GmlFont))]
    [XmlDefaultImplementationTypeAttribute(typeof(GmlFont))]
    public interface IGmlFont : IModelElement, IIdentifiedObject
    {
        
        /// <summary>
        /// The weight property
        /// </summary>
        string Weight
        {
            get;
            set;
        }
        
        /// <summary>
        /// The family property
        /// </summary>
        string Family
        {
            get;
            set;
        }
        
        /// <summary>
        /// The style property
        /// </summary>
        string Style
        {
            get;
            set;
        }
        
        /// <summary>
        /// The absoluteSize property
        /// </summary>
        bool AbsoluteSize
        {
            get;
            set;
        }
        
        /// <summary>
        /// The size property
        /// </summary>
        string Size
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
        /// The GmlColour property
        /// </summary>
        IGmlColour GmlColour
        {
            get;
            set;
        }
        
        /// <summary>
        /// The GmlSvgParameters property
        /// </summary>
        IOrderedSetExpression<IGmlSvgParameter> GmlSvgParameters
        {
            get;
        }
        
        /// <summary>
        /// Gets fired before the Weight property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> WeightChanging;
        
        /// <summary>
        /// Gets fired when the Weight property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> WeightChanged;
        
        /// <summary>
        /// Gets fired before the Family property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FamilyChanging;
        
        /// <summary>
        /// Gets fired when the Family property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> FamilyChanged;
        
        /// <summary>
        /// Gets fired before the Style property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> StyleChanging;
        
        /// <summary>
        /// Gets fired when the Style property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> StyleChanged;
        
        /// <summary>
        /// Gets fired before the AbsoluteSize property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AbsoluteSizeChanging;
        
        /// <summary>
        /// Gets fired when the AbsoluteSize property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AbsoluteSizeChanged;
        
        /// <summary>
        /// Gets fired before the Size property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> SizeChanging;
        
        /// <summary>
        /// Gets fired when the Size property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> SizeChanged;
        
        /// <summary>
        /// Gets fired before the GmlColour property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> GmlColourChanging;
        
        /// <summary>
        /// Gets fired when the GmlColour property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> GmlColourChanged;
    }
}

