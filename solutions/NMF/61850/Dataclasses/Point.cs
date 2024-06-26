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
    /// The default implementation of the Point class
    /// </summary>
    [XmlNamespaceAttribute("http://www.transformation-tool-contest.eu/2017/smartGrids/dataclasses")]
    [XmlNamespacePrefixAttribute("data")]
    [ModelRepresentationClassAttribute("http://www.transformation-tool-contest.eu/2017/smartGrids/substationStandard#//Da" +
        "taclasses/Point")]
    public partial class Point : ModelElement, IPoint, IModelElement
    {
        
        /// <summary>
        /// The backing field for the XVal property
        /// </summary>
        private Nullable<float> _xVal;
        
        private static Lazy<ITypedElement> _xValAttribute = new Lazy<ITypedElement>(RetrieveXValAttribute);
        
        /// <summary>
        /// The backing field for the YVal property
        /// </summary>
        private Nullable<float> _yVal;
        
        private static Lazy<ITypedElement> _yValAttribute = new Lazy<ITypedElement>(RetrieveYValAttribute);
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The xVal property
        /// </summary>
        [XmlElementNameAttribute("xVal")]
        [XmlAttributeAttribute(true)]
        public virtual Nullable<float> XVal
        {
            get
            {
                return this._xVal;
            }
            set
            {
                if ((this._xVal != value))
                {
                    Nullable<float> old = this._xVal;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnXValChanging(e);
                    this.OnPropertyChanging("XVal", e, _xValAttribute);
                    this._xVal = value;
                    this.OnXValChanged(e);
                    this.OnPropertyChanged("XVal", e, _xValAttribute);
                }
            }
        }
        
        /// <summary>
        /// The yVal property
        /// </summary>
        [XmlElementNameAttribute("yVal")]
        [XmlAttributeAttribute(true)]
        public virtual Nullable<float> YVal
        {
            get
            {
                return this._yVal;
            }
            set
            {
                if ((this._yVal != value))
                {
                    Nullable<float> old = this._yVal;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnYValChanging(e);
                    this.OnPropertyChanging("YVal", e, _yValAttribute);
                    this._yVal = value;
                    this.OnYValChanged(e);
                    this.OnPropertyChanged("YVal", e, _yValAttribute);
                }
            }
        }
        
        /// <summary>
        /// Gets the Class model for this type
        /// </summary>
        public new static IClass ClassInstance
        {
            get
            {
                if ((_classInstance == null))
                {
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://www.transformation-tool-contest.eu/2017/smartGrids/substationStandard#//Da" +
                            "taclasses/Point")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the XVal property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> XValChanging;
        
        /// <summary>
        /// Gets fired when the XVal property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> XValChanged;
        
        /// <summary>
        /// Gets fired before the YVal property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> YValChanging;
        
        /// <summary>
        /// Gets fired when the YVal property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> YValChanged;
        
        private static ITypedElement RetrieveXValAttribute()
        {
            return ((ITypedElement)(((ModelElement)(Point.ClassInstance)).Resolve("xVal")));
        }
        
        /// <summary>
        /// Raises the XValChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnXValChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.XValChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the XValChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnXValChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.XValChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveYValAttribute()
        {
            return ((ITypedElement)(((ModelElement)(Point.ClassInstance)).Resolve("yVal")));
        }
        
        /// <summary>
        /// Raises the YValChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnYValChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.YValChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the YValChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnYValChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.YValChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "XVAL"))
            {
                return this.XVal;
            }
            if ((attribute == "YVAL"))
            {
                return this.YVal;
            }
            return base.GetAttributeValue(attribute, index);
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "XVAL"))
            {
                this.XVal = ((float)(value));
                return;
            }
            if ((feature == "YVAL"))
            {
                this.YVal = ((float)(value));
                return;
            }
            base.SetFeature(feature, value);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override IClass GetClass()
        {
            if ((_classInstance == null))
            {
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://www.transformation-tool-contest.eu/2017/smartGrids/substationStandard#//Da" +
                        "taclasses/Point")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the xVal property
        /// </summary>
        private sealed class XValProxy : ModelPropertyChange<IPoint, Nullable<float>>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public XValProxy(IPoint modelElement) : 
                    base(modelElement, "xVal")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override Nullable<float> Value
            {
                get
                {
                    return this.ModelElement.XVal;
                }
                set
                {
                    this.ModelElement.XVal = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the yVal property
        /// </summary>
        private sealed class YValProxy : ModelPropertyChange<IPoint, Nullable<float>>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public YValProxy(IPoint modelElement) : 
                    base(modelElement, "yVal")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override Nullable<float> Value
            {
                get
                {
                    return this.ModelElement.YVal;
                }
                set
                {
                    this.ModelElement.YVal = value;
                }
            }
        }
    }
}

