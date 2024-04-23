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
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfCommon;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfERPSupport;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfWork;

namespace TTC2017.SmartGrids.CIM.IEC61970.Informative.InfLocations
{
    
    
    /// <summary>
    /// The default implementation of the Direction class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#InfLocations")]
    [XmlNamespacePrefixAttribute("cimInfLocations")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfLocations/Dire" +
        "ction")]
    [DebuggerDisplayAttribute("Direction {UUID}")]
    public partial class Direction : Element, IDirection, IModelElement
    {
        
        /// <summary>
        /// The backing field for the DirectionInfo property
        /// </summary>
        private string _directionInfo;
        
        private static Lazy<ITypedElement> _directionInfoAttribute = new Lazy<ITypedElement>(RetrieveDirectionInfoAttribute);
        
        private static Lazy<ITypedElement> _locationReference = new Lazy<ITypedElement>(RetrieveLocationReference);
        
        /// <summary>
        /// The backing field for the Location property
        /// </summary>
        private ILocation _location;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The directionInfo property
        /// </summary>
        [XmlElementNameAttribute("directionInfo")]
        [XmlAttributeAttribute(true)]
        public virtual string DirectionInfo
        {
            get
            {
                return this._directionInfo;
            }
            set
            {
                if ((this._directionInfo != value))
                {
                    string old = this._directionInfo;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnDirectionInfoChanging(e);
                    this.OnPropertyChanging("DirectionInfo", e, _directionInfoAttribute);
                    this._directionInfo = value;
                    this.OnDirectionInfoChanged(e);
                    this.OnPropertyChanged("DirectionInfo", e, _directionInfoAttribute);
                }
            }
        }
        
        /// <summary>
        /// The Location property
        /// </summary>
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("Directions")]
        public virtual ILocation Location
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
                        old.Directions.Remove(this);
                        old.Deleted -= this.OnResetLocation;
                    }
                    if ((value != null))
                    {
                        value.Directions.Add(this);
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
                return base.ReferencedElements.Concat(new DirectionReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfLocations/Dire" +
                            "ction")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the DirectionInfo property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> DirectionInfoChanging;
        
        /// <summary>
        /// Gets fired when the DirectionInfo property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> DirectionInfoChanged;
        
        /// <summary>
        /// Gets fired before the Location property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> LocationChanging;
        
        /// <summary>
        /// Gets fired when the Location property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> LocationChanged;
        
        private static ITypedElement RetrieveDirectionInfoAttribute()
        {
            return ((ITypedElement)(((ModelElement)(Direction.ClassInstance)).Resolve("directionInfo")));
        }
        
        /// <summary>
        /// Raises the DirectionInfoChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnDirectionInfoChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.DirectionInfoChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the DirectionInfoChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnDirectionInfoChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.DirectionInfoChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveLocationReference()
        {
            return ((ITypedElement)(((ModelElement)(Direction.ClassInstance)).Resolve("Location")));
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
            if ((attribute == "DIRECTIONINFO"))
            {
                return this.DirectionInfo;
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
            if ((feature == "DIRECTIONINFO"))
            {
                this.DirectionInfo = ((string)(value));
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfLocations/Dire" +
                        "ction")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the Direction class
        /// </summary>
        public class DirectionReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private Direction _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public DirectionReferencedElementsCollection(Direction parent)
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
        /// Represents a proxy to represent an incremental access to the directionInfo property
        /// </summary>
        private sealed class DirectionInfoProxy : ModelPropertyChange<IDirection, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public DirectionInfoProxy(IDirection modelElement) : 
                    base(modelElement, "directionInfo")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override string Value
            {
                get
                {
                    return this.ModelElement.DirectionInfo;
                }
                set
                {
                    this.ModelElement.DirectionInfo = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the Location property
        /// </summary>
        private sealed class LocationProxy : ModelPropertyChange<IDirection, ILocation>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public LocationProxy(IDirection modelElement) : 
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

