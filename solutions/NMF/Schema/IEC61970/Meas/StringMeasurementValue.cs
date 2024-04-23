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
using TTC2017.SmartGrids.CIM.IEC61970.ControlArea;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.EnergyScheduling;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssets;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfERPSupport;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfGMLSupport;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.MarketOperations;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.Reservation;
using TTC2017.SmartGrids.CIM.IEC61970.SCADA;
using TTC2017.SmartGrids.CIM.IEC61970.Wires;

namespace TTC2017.SmartGrids.CIM.IEC61970.Meas
{
    
    
    /// <summary>
    /// The default implementation of the StringMeasurementValue class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#Meas")]
    [XmlNamespacePrefixAttribute("cimMeas")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Meas/StringMeasurementValue")]
    [DebuggerDisplayAttribute("StringMeasurementValue {UUID}")]
    public partial class StringMeasurementValue : MeasurementValue, IStringMeasurementValue, IModelElement
    {
        
        /// <summary>
        /// The backing field for the Value property
        /// </summary>
        private string _value;
        
        private static Lazy<ITypedElement> _valueAttribute = new Lazy<ITypedElement>(RetrieveValueAttribute);
        
        private static Lazy<ITypedElement> _stringMeasurementReference = new Lazy<ITypedElement>(RetrieveStringMeasurementReference);
        
        /// <summary>
        /// The backing field for the StringMeasurement property
        /// </summary>
        private IStringMeasurement _stringMeasurement;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The value property
        /// </summary>
        [XmlElementNameAttribute("value")]
        [XmlAttributeAttribute(true)]
        public virtual string Value
        {
            get
            {
                return this._value;
            }
            set
            {
                if ((this._value != value))
                {
                    string old = this._value;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnValueChanging(e);
                    this.OnPropertyChanging("Value", e, _valueAttribute);
                    this._value = value;
                    this.OnValueChanged(e);
                    this.OnPropertyChanged("Value", e, _valueAttribute);
                }
            }
        }
        
        /// <summary>
        /// The StringMeasurement property
        /// </summary>
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("StringMeasurementValues")]
        public virtual IStringMeasurement StringMeasurement
        {
            get
            {
                return this._stringMeasurement;
            }
            set
            {
                if ((this._stringMeasurement != value))
                {
                    IStringMeasurement old = this._stringMeasurement;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnStringMeasurementChanging(e);
                    this.OnPropertyChanging("StringMeasurement", e, _stringMeasurementReference);
                    this._stringMeasurement = value;
                    if ((old != null))
                    {
                        old.StringMeasurementValues.Remove(this);
                        old.Deleted -= this.OnResetStringMeasurement;
                    }
                    if ((value != null))
                    {
                        value.StringMeasurementValues.Add(this);
                        value.Deleted += this.OnResetStringMeasurement;
                    }
                    this.OnStringMeasurementChanged(e);
                    this.OnPropertyChanged("StringMeasurement", e, _stringMeasurementReference);
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
                return base.ReferencedElements.Concat(new StringMeasurementValueReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Meas/StringMeasurementValue")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the Value property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ValueChanging;
        
        /// <summary>
        /// Gets fired when the Value property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ValueChanged;
        
        /// <summary>
        /// Gets fired before the StringMeasurement property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> StringMeasurementChanging;
        
        /// <summary>
        /// Gets fired when the StringMeasurement property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> StringMeasurementChanged;
        
        private static ITypedElement RetrieveValueAttribute()
        {
            return ((ITypedElement)(((ModelElement)(StringMeasurementValue.ClassInstance)).Resolve("value")));
        }
        
        /// <summary>
        /// Raises the ValueChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnValueChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ValueChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the ValueChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnValueChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ValueChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveStringMeasurementReference()
        {
            return ((ITypedElement)(((ModelElement)(StringMeasurementValue.ClassInstance)).Resolve("StringMeasurement")));
        }
        
        /// <summary>
        /// Raises the StringMeasurementChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnStringMeasurementChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.StringMeasurementChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the StringMeasurementChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnStringMeasurementChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.StringMeasurementChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the StringMeasurement property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetStringMeasurement(object sender, System.EventArgs eventArgs)
        {
            this.StringMeasurement = null;
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "VALUE"))
            {
                return this.Value;
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
            if ((feature == "STRINGMEASUREMENT"))
            {
                this.StringMeasurement = ((IStringMeasurement)(value));
                return;
            }
            if ((feature == "VALUE"))
            {
                this.Value = ((string)(value));
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
            if ((attribute == "StringMeasurement"))
            {
                return new StringMeasurementProxy(this);
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
            if ((reference == "StringMeasurement"))
            {
                return new StringMeasurementProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Meas/StringMeasurementValue")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the StringMeasurementValue class
        /// </summary>
        public class StringMeasurementValueReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private StringMeasurementValue _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public StringMeasurementValueReferencedElementsCollection(StringMeasurementValue parent)
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
                    if ((this._parent.StringMeasurement != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.StringMeasurementChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.StringMeasurementChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.StringMeasurement == null))
                {
                    IStringMeasurement stringMeasurementCasted = item.As<IStringMeasurement>();
                    if ((stringMeasurementCasted != null))
                    {
                        this._parent.StringMeasurement = stringMeasurementCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.StringMeasurement = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.StringMeasurement))
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
                if ((this._parent.StringMeasurement != null))
                {
                    array[arrayIndex] = this._parent.StringMeasurement;
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
                if ((this._parent.StringMeasurement == item))
                {
                    this._parent.StringMeasurement = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.StringMeasurement).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the value property
        /// </summary>
        private sealed class ValueProxy : ModelPropertyChange<IStringMeasurementValue, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public ValueProxy(IStringMeasurementValue modelElement) : 
                    base(modelElement, "value")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override string Value
            {
                get
                {
                    return this.ModelElement.Value;
                }
                set
                {
                    this.ModelElement.Value = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the StringMeasurement property
        /// </summary>
        private sealed class StringMeasurementProxy : ModelPropertyChange<IStringMeasurementValue, IStringMeasurement>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public StringMeasurementProxy(IStringMeasurementValue modelElement) : 
                    base(modelElement, "StringMeasurement")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IStringMeasurement Value
            {
                get
                {
                    return this.ModelElement.StringMeasurement;
                }
                set
                {
                    this.ModelElement.StringMeasurement = value;
                }
            }
        }
    }
}

