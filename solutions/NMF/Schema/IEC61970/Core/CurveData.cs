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
using TTC2017.SmartGrids.CIM.IEC61968.Customers;
using TTC2017.SmartGrids.CIM.IEC61970.Contingency;
using TTC2017.SmartGrids.CIM.IEC61970.ControlArea;
using TTC2017.SmartGrids.CIM.IEC61970.Domain;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssets;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfCommon;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfCore;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfOperations;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.MarketOperations;
using TTC2017.SmartGrids.CIM.IEC61970.Meas;
using TTC2017.SmartGrids.CIM.IEC61970.OperationalLimits;
using TTC2017.SmartGrids.CIM.IEC61970.Outage;
using TTC2017.SmartGrids.CIM.IEC61970.Protection;
using TTC2017.SmartGrids.CIM.IEC61970.StateVariables;
using TTC2017.SmartGrids.CIM.IEC61970.Topology;
using TTC2017.SmartGrids.CIM.IEC61970.Wires;

namespace TTC2017.SmartGrids.CIM.IEC61970.Core
{
    
    
    /// <summary>
    /// The default implementation of the CurveData class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#Core")]
    [XmlNamespacePrefixAttribute("cimCore")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Core/CurveData")]
    [DebuggerDisplayAttribute("CurveData {UUID}")]
    public partial class CurveData : Element, ICurveData, IModelElement
    {
        
        /// <summary>
        /// The backing field for the Xvalue property
        /// </summary>
        private float _xvalue;
        
        private static Lazy<ITypedElement> _xvalueAttribute = new Lazy<ITypedElement>(RetrieveXvalueAttribute);
        
        /// <summary>
        /// The backing field for the Y2value property
        /// </summary>
        private float _y2value;
        
        private static Lazy<ITypedElement> _y2valueAttribute = new Lazy<ITypedElement>(RetrieveY2valueAttribute);
        
        /// <summary>
        /// The backing field for the Y3value property
        /// </summary>
        private float _y3value;
        
        private static Lazy<ITypedElement> _y3valueAttribute = new Lazy<ITypedElement>(RetrieveY3valueAttribute);
        
        /// <summary>
        /// The backing field for the Y1value property
        /// </summary>
        private float _y1value;
        
        private static Lazy<ITypedElement> _y1valueAttribute = new Lazy<ITypedElement>(RetrieveY1valueAttribute);
        
        private static Lazy<ITypedElement> _curveReference = new Lazy<ITypedElement>(RetrieveCurveReference);
        
        /// <summary>
        /// The backing field for the Curve property
        /// </summary>
        private ICurve _curve;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The xvalue property
        /// </summary>
        [XmlElementNameAttribute("xvalue")]
        [XmlAttributeAttribute(true)]
        public virtual float Xvalue
        {
            get
            {
                return this._xvalue;
            }
            set
            {
                if ((this._xvalue != value))
                {
                    float old = this._xvalue;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnXvalueChanging(e);
                    this.OnPropertyChanging("Xvalue", e, _xvalueAttribute);
                    this._xvalue = value;
                    this.OnXvalueChanged(e);
                    this.OnPropertyChanged("Xvalue", e, _xvalueAttribute);
                }
            }
        }
        
        /// <summary>
        /// The y2value property
        /// </summary>
        [XmlElementNameAttribute("y2value")]
        [XmlAttributeAttribute(true)]
        public virtual float Y2value
        {
            get
            {
                return this._y2value;
            }
            set
            {
                if ((this._y2value != value))
                {
                    float old = this._y2value;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnY2valueChanging(e);
                    this.OnPropertyChanging("Y2value", e, _y2valueAttribute);
                    this._y2value = value;
                    this.OnY2valueChanged(e);
                    this.OnPropertyChanged("Y2value", e, _y2valueAttribute);
                }
            }
        }
        
        /// <summary>
        /// The y3value property
        /// </summary>
        [XmlElementNameAttribute("y3value")]
        [XmlAttributeAttribute(true)]
        public virtual float Y3value
        {
            get
            {
                return this._y3value;
            }
            set
            {
                if ((this._y3value != value))
                {
                    float old = this._y3value;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnY3valueChanging(e);
                    this.OnPropertyChanging("Y3value", e, _y3valueAttribute);
                    this._y3value = value;
                    this.OnY3valueChanged(e);
                    this.OnPropertyChanged("Y3value", e, _y3valueAttribute);
                }
            }
        }
        
        /// <summary>
        /// The y1value property
        /// </summary>
        [XmlElementNameAttribute("y1value")]
        [XmlAttributeAttribute(true)]
        public virtual float Y1value
        {
            get
            {
                return this._y1value;
            }
            set
            {
                if ((this._y1value != value))
                {
                    float old = this._y1value;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnY1valueChanging(e);
                    this.OnPropertyChanging("Y1value", e, _y1valueAttribute);
                    this._y1value = value;
                    this.OnY1valueChanged(e);
                    this.OnPropertyChanged("Y1value", e, _y1valueAttribute);
                }
            }
        }
        
        /// <summary>
        /// The Curve property
        /// </summary>
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("CurveDatas")]
        public virtual ICurve Curve
        {
            get
            {
                return this._curve;
            }
            set
            {
                if ((this._curve != value))
                {
                    ICurve old = this._curve;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnCurveChanging(e);
                    this.OnPropertyChanging("Curve", e, _curveReference);
                    this._curve = value;
                    if ((old != null))
                    {
                        old.CurveDatas.Remove(this);
                        old.Deleted -= this.OnResetCurve;
                    }
                    if ((value != null))
                    {
                        value.CurveDatas.Add(this);
                        value.Deleted += this.OnResetCurve;
                    }
                    this.OnCurveChanged(e);
                    this.OnPropertyChanged("Curve", e, _curveReference);
                }
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new CurveDataReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Core/CurveData")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the Xvalue property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> XvalueChanging;
        
        /// <summary>
        /// Gets fired when the Xvalue property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> XvalueChanged;
        
        /// <summary>
        /// Gets fired before the Y2value property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> Y2valueChanging;
        
        /// <summary>
        /// Gets fired when the Y2value property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> Y2valueChanged;
        
        /// <summary>
        /// Gets fired before the Y3value property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> Y3valueChanging;
        
        /// <summary>
        /// Gets fired when the Y3value property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> Y3valueChanged;
        
        /// <summary>
        /// Gets fired before the Y1value property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> Y1valueChanging;
        
        /// <summary>
        /// Gets fired when the Y1value property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> Y1valueChanged;
        
        /// <summary>
        /// Gets fired before the Curve property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> CurveChanging;
        
        /// <summary>
        /// Gets fired when the Curve property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> CurveChanged;
        
        private static ITypedElement RetrieveXvalueAttribute()
        {
            return ((ITypedElement)(((ModelElement)(CurveData.ClassInstance)).Resolve("xvalue")));
        }
        
        /// <summary>
        /// Raises the XvalueChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnXvalueChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.XvalueChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the XvalueChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnXvalueChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.XvalueChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveY2valueAttribute()
        {
            return ((ITypedElement)(((ModelElement)(CurveData.ClassInstance)).Resolve("y2value")));
        }
        
        /// <summary>
        /// Raises the Y2valueChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnY2valueChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.Y2valueChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the Y2valueChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnY2valueChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.Y2valueChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveY3valueAttribute()
        {
            return ((ITypedElement)(((ModelElement)(CurveData.ClassInstance)).Resolve("y3value")));
        }
        
        /// <summary>
        /// Raises the Y3valueChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnY3valueChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.Y3valueChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the Y3valueChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnY3valueChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.Y3valueChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveY1valueAttribute()
        {
            return ((ITypedElement)(((ModelElement)(CurveData.ClassInstance)).Resolve("y1value")));
        }
        
        /// <summary>
        /// Raises the Y1valueChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnY1valueChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.Y1valueChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the Y1valueChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnY1valueChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.Y1valueChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveCurveReference()
        {
            return ((ITypedElement)(((ModelElement)(CurveData.ClassInstance)).Resolve("Curve")));
        }
        
        /// <summary>
        /// Raises the CurveChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnCurveChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.CurveChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the CurveChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnCurveChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.CurveChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the Curve property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetCurve(object sender, System.EventArgs eventArgs)
        {
            this.Curve = null;
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "XVALUE"))
            {
                return this.Xvalue;
            }
            if ((attribute == "Y2VALUE"))
            {
                return this.Y2value;
            }
            if ((attribute == "Y3VALUE"))
            {
                return this.Y3value;
            }
            if ((attribute == "Y1VALUE"))
            {
                return this.Y1value;
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
            if ((feature == "CURVE"))
            {
                this.Curve = ((ICurve)(value));
                return;
            }
            if ((feature == "XVALUE"))
            {
                this.Xvalue = ((float)(value));
                return;
            }
            if ((feature == "Y2VALUE"))
            {
                this.Y2value = ((float)(value));
                return;
            }
            if ((feature == "Y3VALUE"))
            {
                this.Y3value = ((float)(value));
                return;
            }
            if ((feature == "Y1VALUE"))
            {
                this.Y1value = ((float)(value));
                return;
            }
            base.SetFeature(feature, value);
        }
        
        /// <summary>
        /// Gets the property expression for the given attribute
        /// </summary>
        /// <returns>An incremental property expression</returns>
        /// <param name="attribute">The requested attribute in upper case</param>
        protected override NMF.Expressions.INotifyExpression<object> GetExpressionForAttribute(string attribute)
        {
            if ((attribute == "Curve"))
            {
                return new CurveProxy(this);
            }
            return base.GetExpressionForAttribute(attribute);
        }
        
        /// <summary>
        /// Gets the property expression for the given reference
        /// </summary>
        /// <returns>An incremental property expression</returns>
        /// <param name="reference">The requested reference in upper case</param>
        protected override NMF.Expressions.INotifyExpression<NMF.Models.IModelElement> GetExpressionForReference(string reference)
        {
            if ((reference == "Curve"))
            {
                return new CurveProxy(this);
            }
            return base.GetExpressionForReference(reference);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override IClass GetClass()
        {
            if ((_classInstance == null))
            {
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Core/CurveData")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the CurveData class
        /// </summary>
        public class CurveDataReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private CurveData _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public CurveDataReferencedElementsCollection(CurveData parent)
            {
                this._parent = parent;
            }
            
            /// <summary>
            /// Gets the amount of elements contained in this collection
            /// </summary>
            public override int Count
            {
                get
                {
                    int count = 0;
                    if ((this._parent.Curve != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.CurveChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.CurveChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.Curve == null))
                {
                    ICurve curveCasted = item.As<ICurve>();
                    if ((curveCasted != null))
                    {
                        this._parent.Curve = curveCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.Curve = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.Curve))
                {
                    return true;
                }
                return false;
            }
            
            /// <summary>
            /// Copies the contents of the collection to the given array starting from the given array index
            /// </summary>
            /// <param name="array">The array in which the elements should be copied</param>
            /// <param name="arrayIndex">The starting index</param>
            public override void CopyTo(IModelElement[] array, int arrayIndex)
            {
                if ((this._parent.Curve != null))
                {
                    array[arrayIndex] = this._parent.Curve;
                    arrayIndex = (arrayIndex + 1);
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                if ((this._parent.Curve == item))
                {
                    this._parent.Curve = null;
                    return true;
                }
                return false;
            }
            
            /// <summary>
            /// Gets an enumerator that enumerates the collection
            /// </summary>
            /// <returns>A generic enumerator</returns>
            public override IEnumerator<IModelElement> GetEnumerator()
            {
                return Enumerable.Empty<IModelElement>().Concat(this._parent.Curve).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the xvalue property
        /// </summary>
        private sealed class XvalueProxy : ModelPropertyChange<ICurveData, float>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public XvalueProxy(ICurveData modelElement) : 
                    base(modelElement, "xvalue")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override float Value
            {
                get
                {
                    return this.ModelElement.Xvalue;
                }
                set
                {
                    this.ModelElement.Xvalue = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the y2value property
        /// </summary>
        private sealed class Y2valueProxy : ModelPropertyChange<ICurveData, float>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public Y2valueProxy(ICurveData modelElement) : 
                    base(modelElement, "y2value")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override float Value
            {
                get
                {
                    return this.ModelElement.Y2value;
                }
                set
                {
                    this.ModelElement.Y2value = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the y3value property
        /// </summary>
        private sealed class Y3valueProxy : ModelPropertyChange<ICurveData, float>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public Y3valueProxy(ICurveData modelElement) : 
                    base(modelElement, "y3value")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override float Value
            {
                get
                {
                    return this.ModelElement.Y3value;
                }
                set
                {
                    this.ModelElement.Y3value = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the y1value property
        /// </summary>
        private sealed class Y1valueProxy : ModelPropertyChange<ICurveData, float>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public Y1valueProxy(ICurveData modelElement) : 
                    base(modelElement, "y1value")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override float Value
            {
                get
                {
                    return this.ModelElement.Y1value;
                }
                set
                {
                    this.ModelElement.Y1value = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the Curve property
        /// </summary>
        private sealed class CurveProxy : ModelPropertyChange<ICurveData, ICurve>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public CurveProxy(ICurveData modelElement) : 
                    base(modelElement, "Curve")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override ICurve Value
            {
                get
                {
                    return this.ModelElement.Curve;
                }
                set
                {
                    this.ModelElement.Curve = value;
                }
            }
        }
    }
}

