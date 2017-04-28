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

namespace TTC2017.SmartGrids.OutageDetectionJointarget
{
    
    
    /// <summary>
    /// The default implementation of the EnergyConsumer class
    /// </summary>
    [XmlNamespaceAttribute("http://www.transformation-tool-contest.eu/2017/smartGrids/ConsumerReachabilityVie" +
        "w")]
    [XmlNamespacePrefixAttribute("outageDtJt")]
    [ModelRepresentationClassAttribute("http://www.transformation-tool-contest.eu/2017/smartGrids/ConsumerReachabilityVie" +
        "w#//EnergyConsumer")]
    public partial class EnergyConsumer : ModelElement, IEnergyConsumer, IModelElement
    {
        
        /// <summary>
        /// The backing field for the Reachability property
        /// </summary>
        private Nullable<int> _reachability;
        
        private static Lazy<ITypedElement> _reachabilityAttribute = new Lazy<ITypedElement>(RetrieveReachabilityAttribute);
        
        /// <summary>
        /// The backing field for the PowerA property
        /// </summary>
        private Nullable<double> _powerA;
        
        private static Lazy<ITypedElement> _powerAAttribute = new Lazy<ITypedElement>(RetrievePowerAAttribute);
        
        /// <summary>
        /// The backing field for the ID property
        /// </summary>
        private string _iD;
        
        private static Lazy<ITypedElement> _iDAttribute = new Lazy<ITypedElement>(RetrieveIDAttribute);
        
        private static Lazy<ITypedElement> _locationReference = new Lazy<ITypedElement>(RetrieveLocationReference);
        
        /// <summary>
        /// The backing field for the Location property
        /// </summary>
        private ILocation _location;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The Reachability property
        /// </summary>
        [XmlAttributeAttribute(true)]
        public Nullable<int> Reachability
        {
            get
            {
                return this._reachability;
            }
            set
            {
                if ((this._reachability != value))
                {
                    Nullable<int> old = this._reachability;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnReachabilityChanging(e);
                    this.OnPropertyChanging("Reachability", e, _reachabilityAttribute);
                    this._reachability = value;
                    this.OnReachabilityChanged(e);
                    this.OnPropertyChanged("Reachability", e, _reachabilityAttribute);
                }
            }
        }
        
        /// <summary>
        /// The PowerA property
        /// </summary>
        [XmlAttributeAttribute(true)]
        public Nullable<double> PowerA
        {
            get
            {
                return this._powerA;
            }
            set
            {
                if ((this._powerA != value))
                {
                    Nullable<double> old = this._powerA;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnPowerAChanging(e);
                    this.OnPropertyChanging("PowerA", e, _powerAAttribute);
                    this._powerA = value;
                    this.OnPowerAChanged(e);
                    this.OnPropertyChanged("PowerA", e, _powerAAttribute);
                }
            }
        }
        
        /// <summary>
        /// The ID property
        /// </summary>
        [XmlAttributeAttribute(true)]
        public string ID
        {
            get
            {
                return this._iD;
            }
            set
            {
                if ((this._iD != value))
                {
                    string old = this._iD;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnIDChanging(e);
                    this.OnPropertyChanging("ID", e, _iDAttribute);
                    this._iD = value;
                    this.OnIDChanged(e);
                    this.OnPropertyChanged("ID", e, _iDAttribute);
                }
            }
        }
        
        /// <summary>
        /// The Location property
        /// </summary>
        [XmlAttributeAttribute(true)]
        public ILocation Location
        {
            get
            {
                return this._location;
            }
            set
            {
                if ((this._location != value))
                {
                    ILocation old = this._location;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnLocationChanging(e);
                    this.OnPropertyChanging("Location", e, _locationReference);
                    this._location = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetLocation;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetLocation;
                    }
                    this.OnLocationChanged(e);
                    this.OnPropertyChanged("Location", e, _locationReference);
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
                return base.ReferencedElements.Concat(new EnergyConsumerReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://www.transformation-tool-contest.eu/2017/smartGrids/ConsumerReachabilityVie" +
                            "w#//EnergyConsumer")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the Reachability property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ReachabilityChanging;
        
        /// <summary>
        /// Gets fired when the Reachability property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ReachabilityChanged;
        
        /// <summary>
        /// Gets fired before the PowerA property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> PowerAChanging;
        
        /// <summary>
        /// Gets fired when the PowerA property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> PowerAChanged;
        
        /// <summary>
        /// Gets fired before the ID property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> IDChanging;
        
        /// <summary>
        /// Gets fired when the ID property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> IDChanged;
        
        /// <summary>
        /// Gets fired before the Location property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> LocationChanging;
        
        /// <summary>
        /// Gets fired when the Location property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> LocationChanged;
        
        private static ITypedElement RetrieveReachabilityAttribute()
        {
            return ((ITypedElement)(((ModelElement)(TTC2017.SmartGrids.OutageDetectionJointarget.EnergyConsumer.ClassInstance)).Resolve("Reachability")));
        }
        
        /// <summary>
        /// Raises the ReachabilityChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnReachabilityChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ReachabilityChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the ReachabilityChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnReachabilityChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ReachabilityChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrievePowerAAttribute()
        {
            return ((ITypedElement)(((ModelElement)(TTC2017.SmartGrids.OutageDetectionJointarget.EnergyConsumer.ClassInstance)).Resolve("PowerA")));
        }
        
        /// <summary>
        /// Raises the PowerAChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnPowerAChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.PowerAChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the PowerAChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnPowerAChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.PowerAChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveIDAttribute()
        {
            return ((ITypedElement)(((ModelElement)(TTC2017.SmartGrids.OutageDetectionJointarget.EnergyConsumer.ClassInstance)).Resolve("ID")));
        }
        
        /// <summary>
        /// Raises the IDChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnIDChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.IDChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the IDChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnIDChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.IDChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveLocationReference()
        {
            return ((ITypedElement)(((ModelElement)(TTC2017.SmartGrids.OutageDetectionJointarget.EnergyConsumer.ClassInstance)).Resolve("Location")));
        }
        
        /// <summary>
        /// Raises the LocationChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnLocationChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.LocationChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the LocationChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnLocationChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.LocationChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the Location property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetLocation(object sender, System.EventArgs eventArgs)
        {
            this.Location = null;
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "REACHABILITY"))
            {
                return this.Reachability;
            }
            if ((attribute == "POWERA"))
            {
                return this.PowerA;
            }
            if ((attribute == "ID"))
            {
                return this.ID;
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
            if ((feature == "LOCATION"))
            {
                this.Location = ((ILocation)(value));
                return;
            }
            if ((feature == "REACHABILITY"))
            {
                this.Reachability = ((int)(value));
                return;
            }
            if ((feature == "POWERA"))
            {
                this.PowerA = ((double)(value));
                return;
            }
            if ((feature == "ID"))
            {
                this.ID = ((string)(value));
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
            if ((attribute == "Location"))
            {
                return new LocationProxy(this);
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
            if ((reference == "Location"))
            {
                return new LocationProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://www.transformation-tool-contest.eu/2017/smartGrids/ConsumerReachabilityVie" +
                        "w#//EnergyConsumer")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the EnergyConsumer class
        /// </summary>
        public class EnergyConsumerReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private EnergyConsumer _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public EnergyConsumerReferencedElementsCollection(EnergyConsumer parent)
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
                    if ((this._parent.Location != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.LocationChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.LocationChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.Location == null))
                {
                    ILocation locationCasted = item.As<ILocation>();
                    if ((locationCasted != null))
                    {
                        this._parent.Location = locationCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.Location = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.Location))
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
                if ((this._parent.Location != null))
                {
                    array[arrayIndex] = this._parent.Location;
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
                if ((this._parent.Location == item))
                {
                    this._parent.Location = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.Location).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the Reachability property
        /// </summary>
        private sealed class ReachabilityProxy : ModelPropertyChange<IEnergyConsumer, Nullable<int>>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public ReachabilityProxy(IEnergyConsumer modelElement) : 
                    base(modelElement, "Reachability")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override Nullable<int> Value
            {
                get
                {
                    return this.ModelElement.Reachability;
                }
                set
                {
                    this.ModelElement.Reachability = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the PowerA property
        /// </summary>
        private sealed class PowerAProxy : ModelPropertyChange<IEnergyConsumer, Nullable<double>>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public PowerAProxy(IEnergyConsumer modelElement) : 
                    base(modelElement, "PowerA")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override Nullable<double> Value
            {
                get
                {
                    return this.ModelElement.PowerA;
                }
                set
                {
                    this.ModelElement.PowerA = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the ID property
        /// </summary>
        private sealed class IDProxy : ModelPropertyChange<IEnergyConsumer, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public IDProxy(IEnergyConsumer modelElement) : 
                    base(modelElement, "ID")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override string Value
            {
                get
                {
                    return this.ModelElement.ID;
                }
                set
                {
                    this.ModelElement.ID = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the Location property
        /// </summary>
        private sealed class LocationProxy : ModelPropertyChange<IEnergyConsumer, ILocation>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public LocationProxy(IEnergyConsumer modelElement) : 
                    base(modelElement, "Location")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override ILocation Value
            {
                get
                {
                    return this.ModelElement.Location;
                }
                set
                {
                    this.ModelElement.Location = value;
                }
            }
        }
    }
}

