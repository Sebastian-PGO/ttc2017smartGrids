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
    /// The default implementation of the GmlValue class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#InfGMLSupport")]
    [XmlNamespacePrefixAttribute("cimInfGMLSupport")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfGMLSupport/Gml" +
        "Value")]
    [DebuggerDisplayAttribute("GmlValue {UUID}")]
    public partial class GmlValue : IdentifiedObject, IGmlValue, IModelElement
    {
        
        /// <summary>
        /// The backing field for the DateTime property
        /// </summary>
        private DateTime _dateTime;
        
        private static Lazy<ITypedElement> _dateTimeAttribute = new Lazy<ITypedElement>(RetrieveDateTimeAttribute);
        
        /// <summary>
        /// The backing field for the Value property
        /// </summary>
        private float _value;
        
        private static Lazy<ITypedElement> _valueAttribute = new Lazy<ITypedElement>(RetrieveValueAttribute);
        
        /// <summary>
        /// The backing field for the TimePeriod property
        /// </summary>
        private string _timePeriod;
        
        private static Lazy<ITypedElement> _timePeriodAttribute = new Lazy<ITypedElement>(RetrieveTimePeriodAttribute);
        
        private static Lazy<ITypedElement> _gmlObservationReference = new Lazy<ITypedElement>(RetrieveGmlObservationReference);
        
        /// <summary>
        /// The backing field for the GmlObservation property
        /// </summary>
        private IGmlObservation _gmlObservation;
        
        private static Lazy<ITypedElement> _measurementValueReference = new Lazy<ITypedElement>(RetrieveMeasurementValueReference);
        
        /// <summary>
        /// The backing field for the MeasurementValue property
        /// </summary>
        private IMeasurementValue _measurementValue;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The dateTime property
        /// </summary>
        [XmlElementNameAttribute("dateTime")]
        [XmlAttributeAttribute(true)]
        public virtual DateTime DateTime
        {
            get
            {
                return this._dateTime;
            }
            set
            {
                if ((this._dateTime != value))
                {
                    DateTime old = this._dateTime;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnDateTimeChanging(e);
                    this.OnPropertyChanging("DateTime", e, _dateTimeAttribute);
                    this._dateTime = value;
                    this.OnDateTimeChanged(e);
                    this.OnPropertyChanged("DateTime", e, _dateTimeAttribute);
                }
            }
        }
        
        /// <summary>
        /// The value property
        /// </summary>
        [XmlElementNameAttribute("value")]
        [XmlAttributeAttribute(true)]
        public virtual float Value
        {
            get
            {
                return this._value;
            }
            set
            {
                if ((this._value != value))
                {
                    float old = this._value;
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
        /// The timePeriod property
        /// </summary>
        [XmlElementNameAttribute("timePeriod")]
        [XmlAttributeAttribute(true)]
        public virtual string TimePeriod
        {
            get
            {
                return this._timePeriod;
            }
            set
            {
                if ((this._timePeriod != value))
                {
                    string old = this._timePeriod;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnTimePeriodChanging(e);
                    this.OnPropertyChanging("TimePeriod", e, _timePeriodAttribute);
                    this._timePeriod = value;
                    this.OnTimePeriodChanged(e);
                    this.OnPropertyChanged("TimePeriod", e, _timePeriodAttribute);
                }
            }
        }
        
        /// <summary>
        /// The GmlObservation property
        /// </summary>
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("GmlValues")]
        public virtual IGmlObservation GmlObservation
        {
            get
            {
                return this._gmlObservation;
            }
            set
            {
                if ((this._gmlObservation != value))
                {
                    IGmlObservation old = this._gmlObservation;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnGmlObservationChanging(e);
                    this.OnPropertyChanging("GmlObservation", e, _gmlObservationReference);
                    this._gmlObservation = value;
                    if ((old != null))
                    {
                        old.GmlValues.Remove(this);
                        old.Deleted -= this.OnResetGmlObservation;
                    }
                    if ((value != null))
                    {
                        value.GmlValues.Add(this);
                        value.Deleted += this.OnResetGmlObservation;
                    }
                    this.OnGmlObservationChanged(e);
                    this.OnPropertyChanged("GmlObservation", e, _gmlObservationReference);
                }
            }
        }
        
        /// <summary>
        /// The MeasurementValue property
        /// </summary>
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("GmlValues")]
        public virtual IMeasurementValue MeasurementValue
        {
            get
            {
                return this._measurementValue;
            }
            set
            {
                if ((this._measurementValue != value))
                {
                    IMeasurementValue old = this._measurementValue;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnMeasurementValueChanging(e);
                    this.OnPropertyChanging("MeasurementValue", e, _measurementValueReference);
                    this._measurementValue = value;
                    if ((old != null))
                    {
                        old.GmlValues.Remove(this);
                        old.Deleted -= this.OnResetMeasurementValue;
                    }
                    if ((value != null))
                    {
                        value.GmlValues.Add(this);
                        value.Deleted += this.OnResetMeasurementValue;
                    }
                    this.OnMeasurementValueChanged(e);
                    this.OnPropertyChanged("MeasurementValue", e, _measurementValueReference);
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
                return base.ReferencedElements.Concat(new GmlValueReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfGMLSupport/Gml" +
                            "Value")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the DateTime property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> DateTimeChanging;
        
        /// <summary>
        /// Gets fired when the DateTime property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> DateTimeChanged;
        
        /// <summary>
        /// Gets fired before the Value property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ValueChanging;
        
        /// <summary>
        /// Gets fired when the Value property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ValueChanged;
        
        /// <summary>
        /// Gets fired before the TimePeriod property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> TimePeriodChanging;
        
        /// <summary>
        /// Gets fired when the TimePeriod property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> TimePeriodChanged;
        
        /// <summary>
        /// Gets fired before the GmlObservation property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> GmlObservationChanging;
        
        /// <summary>
        /// Gets fired when the GmlObservation property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> GmlObservationChanged;
        
        /// <summary>
        /// Gets fired before the MeasurementValue property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> MeasurementValueChanging;
        
        /// <summary>
        /// Gets fired when the MeasurementValue property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> MeasurementValueChanged;
        
        private static ITypedElement RetrieveDateTimeAttribute()
        {
            return ((ITypedElement)(((ModelElement)(GmlValue.ClassInstance)).Resolve("dateTime")));
        }
        
        /// <summary>
        /// Raises the DateTimeChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnDateTimeChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.DateTimeChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the DateTimeChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnDateTimeChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.DateTimeChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveValueAttribute()
        {
            return ((ITypedElement)(((ModelElement)(GmlValue.ClassInstance)).Resolve("value")));
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
        
        private static ITypedElement RetrieveTimePeriodAttribute()
        {
            return ((ITypedElement)(((ModelElement)(GmlValue.ClassInstance)).Resolve("timePeriod")));
        }
        
        /// <summary>
        /// Raises the TimePeriodChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnTimePeriodChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.TimePeriodChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the TimePeriodChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnTimePeriodChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.TimePeriodChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveGmlObservationReference()
        {
            return ((ITypedElement)(((ModelElement)(GmlValue.ClassInstance)).Resolve("GmlObservation")));
        }
        
        /// <summary>
        /// Raises the GmlObservationChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnGmlObservationChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.GmlObservationChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the GmlObservationChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnGmlObservationChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.GmlObservationChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the GmlObservation property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetGmlObservation(object sender, System.EventArgs eventArgs)
        {
            this.GmlObservation = null;
        }
        
        private static ITypedElement RetrieveMeasurementValueReference()
        {
            return ((ITypedElement)(((ModelElement)(GmlValue.ClassInstance)).Resolve("MeasurementValue")));
        }
        
        /// <summary>
        /// Raises the MeasurementValueChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnMeasurementValueChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.MeasurementValueChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the MeasurementValueChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnMeasurementValueChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.MeasurementValueChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the MeasurementValue property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetMeasurementValue(object sender, System.EventArgs eventArgs)
        {
            this.MeasurementValue = null;
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "DATETIME"))
            {
                return this.DateTime;
            }
            if ((attribute == "VALUE"))
            {
                return this.Value;
            }
            if ((attribute == "TIMEPERIOD"))
            {
                return this.TimePeriod;
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
            if ((feature == "GMLOBSERVATION"))
            {
                this.GmlObservation = ((IGmlObservation)(value));
                return;
            }
            if ((feature == "MEASUREMENTVALUE"))
            {
                this.MeasurementValue = ((IMeasurementValue)(value));
                return;
            }
            if ((feature == "DATETIME"))
            {
                this.DateTime = ((DateTime)(value));
                return;
            }
            if ((feature == "VALUE"))
            {
                this.Value = ((float)(value));
                return;
            }
            if ((feature == "TIMEPERIOD"))
            {
                this.TimePeriod = ((string)(value));
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
            if ((attribute == "GmlObservation"))
            {
                return new GmlObservationProxy(this);
            }
            if ((attribute == "MeasurementValue"))
            {
                return new MeasurementValueProxy(this);
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
            if ((reference == "GmlObservation"))
            {
                return new GmlObservationProxy(this);
            }
            if ((reference == "MeasurementValue"))
            {
                return new MeasurementValueProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfGMLSupport/Gml" +
                        "Value")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the GmlValue class
        /// </summary>
        public class GmlValueReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private GmlValue _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public GmlValueReferencedElementsCollection(GmlValue parent)
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
                    if ((this._parent.GmlObservation != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.MeasurementValue != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.GmlObservationChanged += this.PropagateValueChanges;
                this._parent.MeasurementValueChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.GmlObservationChanged -= this.PropagateValueChanges;
                this._parent.MeasurementValueChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.GmlObservation == null))
                {
                    IGmlObservation gmlObservationCasted = item.As<IGmlObservation>();
                    if ((gmlObservationCasted != null))
                    {
                        this._parent.GmlObservation = gmlObservationCasted;
                        return;
                    }
                }
                if ((this._parent.MeasurementValue == null))
                {
                    IMeasurementValue measurementValueCasted = item.As<IMeasurementValue>();
                    if ((measurementValueCasted != null))
                    {
                        this._parent.MeasurementValue = measurementValueCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.GmlObservation = null;
                this._parent.MeasurementValue = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.GmlObservation))
                {
                    return true;
                }
                if ((item == this._parent.MeasurementValue))
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
                if ((this._parent.GmlObservation != null))
                {
                    array[arrayIndex] = this._parent.GmlObservation;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.MeasurementValue != null))
                {
                    array[arrayIndex] = this._parent.MeasurementValue;
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
                if ((this._parent.GmlObservation == item))
                {
                    this._parent.GmlObservation = null;
                    return true;
                }
                if ((this._parent.MeasurementValue == item))
                {
                    this._parent.MeasurementValue = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.GmlObservation).Concat(this._parent.MeasurementValue).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the dateTime property
        /// </summary>
        private sealed class DateTimeProxy : ModelPropertyChange<IGmlValue, DateTime>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public DateTimeProxy(IGmlValue modelElement) : 
                    base(modelElement, "dateTime")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override DateTime Value
            {
                get
                {
                    return this.ModelElement.DateTime;
                }
                set
                {
                    this.ModelElement.DateTime = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the value property
        /// </summary>
        private sealed class ValueProxy : ModelPropertyChange<IGmlValue, float>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public ValueProxy(IGmlValue modelElement) : 
                    base(modelElement, "value")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override float Value
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
        /// Represents a proxy to represent an incremental access to the timePeriod property
        /// </summary>
        private sealed class TimePeriodProxy : ModelPropertyChange<IGmlValue, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public TimePeriodProxy(IGmlValue modelElement) : 
                    base(modelElement, "timePeriod")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override string Value
            {
                get
                {
                    return this.ModelElement.TimePeriod;
                }
                set
                {
                    this.ModelElement.TimePeriod = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the GmlObservation property
        /// </summary>
        private sealed class GmlObservationProxy : ModelPropertyChange<IGmlValue, IGmlObservation>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public GmlObservationProxy(IGmlValue modelElement) : 
                    base(modelElement, "GmlObservation")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IGmlObservation Value
            {
                get
                {
                    return this.ModelElement.GmlObservation;
                }
                set
                {
                    this.ModelElement.GmlObservation = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the MeasurementValue property
        /// </summary>
        private sealed class MeasurementValueProxy : ModelPropertyChange<IGmlValue, IMeasurementValue>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public MeasurementValueProxy(IGmlValue modelElement) : 
                    base(modelElement, "MeasurementValue")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IMeasurementValue Value
            {
                get
                {
                    return this.ModelElement.MeasurementValue;
                }
                set
                {
                    this.ModelElement.MeasurementValue = value;
                }
            }
        }
    }
}

