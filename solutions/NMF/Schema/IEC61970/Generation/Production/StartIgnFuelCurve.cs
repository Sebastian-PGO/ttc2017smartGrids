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
using TTC2017.SmartGrids.CIM.IEC61970.ControlArea;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Generation.GenerationDynamics;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.EnergyScheduling;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.Financial;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.MarketOperations;
using TTC2017.SmartGrids.CIM.IEC61970.Wires;

namespace TTC2017.SmartGrids.CIM.IEC61970.Generation.Production
{
    
    
    /// <summary>
    /// The default implementation of the StartIgnFuelCurve class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#Production")]
    [XmlNamespacePrefixAttribute("cimProduction")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Generation/Production/StartIg" +
        "nFuelCurve")]
    [DebuggerDisplayAttribute("StartIgnFuelCurve {UUID}")]
    public partial class StartIgnFuelCurve : Curve, IStartIgnFuelCurve, IModelElement
    {
        
        /// <summary>
        /// The backing field for the IgnitionFuelType property
        /// </summary>
        private Nullable<FuelType> _ignitionFuelType;
        
        private static Lazy<ITypedElement> _ignitionFuelTypeAttribute = new Lazy<ITypedElement>(RetrieveIgnitionFuelTypeAttribute);
        
        private static Lazy<ITypedElement> _startupModelReference = new Lazy<ITypedElement>(RetrieveStartupModelReference);
        
        /// <summary>
        /// The backing field for the StartupModel property
        /// </summary>
        private IStartupModel _startupModel;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The ignitionFuelType property
        /// </summary>
        [XmlElementNameAttribute("ignitionFuelType")]
        [XmlAttributeAttribute(true)]
        public virtual Nullable<FuelType> IgnitionFuelType
        {
            get
            {
                return this._ignitionFuelType;
            }
            set
            {
                if ((this._ignitionFuelType != value))
                {
                    Nullable<FuelType> old = this._ignitionFuelType;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnIgnitionFuelTypeChanging(e);
                    this.OnPropertyChanging("IgnitionFuelType", e, _ignitionFuelTypeAttribute);
                    this._ignitionFuelType = value;
                    this.OnIgnitionFuelTypeChanged(e);
                    this.OnPropertyChanged("IgnitionFuelType", e, _ignitionFuelTypeAttribute);
                }
            }
        }
        
        /// <summary>
        /// The StartupModel property
        /// </summary>
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("StartIgnFuelCurve")]
        public virtual IStartupModel StartupModel
        {
            get
            {
                return this._startupModel;
            }
            set
            {
                if ((this._startupModel != value))
                {
                    IStartupModel old = this._startupModel;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnStartupModelChanging(e);
                    this.OnPropertyChanging("StartupModel", e, _startupModelReference);
                    this._startupModel = value;
                    if ((old != null))
                    {
                        old.StartIgnFuelCurve = null;
                        old.Deleted -= this.OnResetStartupModel;
                    }
                    if ((value != null))
                    {
                        value.StartIgnFuelCurve = this;
                        value.Deleted += this.OnResetStartupModel;
                    }
                    this.OnStartupModelChanged(e);
                    this.OnPropertyChanged("StartupModel", e, _startupModelReference);
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
                return base.ReferencedElements.Concat(new StartIgnFuelCurveReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Generation/Production/StartIg" +
                            "nFuelCurve")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the IgnitionFuelType property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> IgnitionFuelTypeChanging;
        
        /// <summary>
        /// Gets fired when the IgnitionFuelType property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> IgnitionFuelTypeChanged;
        
        /// <summary>
        /// Gets fired before the StartupModel property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> StartupModelChanging;
        
        /// <summary>
        /// Gets fired when the StartupModel property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> StartupModelChanged;
        
        private static ITypedElement RetrieveIgnitionFuelTypeAttribute()
        {
            return ((ITypedElement)(((ModelElement)(StartIgnFuelCurve.ClassInstance)).Resolve("ignitionFuelType")));
        }
        
        /// <summary>
        /// Raises the IgnitionFuelTypeChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnIgnitionFuelTypeChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.IgnitionFuelTypeChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the IgnitionFuelTypeChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnIgnitionFuelTypeChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.IgnitionFuelTypeChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveStartupModelReference()
        {
            return ((ITypedElement)(((ModelElement)(StartIgnFuelCurve.ClassInstance)).Resolve("StartupModel")));
        }
        
        /// <summary>
        /// Raises the StartupModelChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnStartupModelChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.StartupModelChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the StartupModelChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnStartupModelChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.StartupModelChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the StartupModel property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetStartupModel(object sender, System.EventArgs eventArgs)
        {
            this.StartupModel = null;
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "IGNITIONFUELTYPE"))
            {
                return this.IgnitionFuelType;
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
            if ((feature == "STARTUPMODEL"))
            {
                this.StartupModel = ((IStartupModel)(value));
                return;
            }
            if ((feature == "IGNITIONFUELTYPE"))
            {
                this.IgnitionFuelType = ((FuelType)(value));
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
            if ((attribute == "StartupModel"))
            {
                return new StartupModelProxy(this);
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
            if ((reference == "StartupModel"))
            {
                return new StartupModelProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Generation/Production/StartIg" +
                        "nFuelCurve")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the StartIgnFuelCurve class
        /// </summary>
        public class StartIgnFuelCurveReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private StartIgnFuelCurve _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public StartIgnFuelCurveReferencedElementsCollection(StartIgnFuelCurve parent)
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
                    if ((this._parent.StartupModel != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.StartupModelChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.StartupModelChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.StartupModel == null))
                {
                    IStartupModel startupModelCasted = item.As<IStartupModel>();
                    if ((startupModelCasted != null))
                    {
                        this._parent.StartupModel = startupModelCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.StartupModel = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.StartupModel))
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
                if ((this._parent.StartupModel != null))
                {
                    array[arrayIndex] = this._parent.StartupModel;
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
                if ((this._parent.StartupModel == item))
                {
                    this._parent.StartupModel = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.StartupModel).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the ignitionFuelType property
        /// </summary>
        private sealed class IgnitionFuelTypeProxy : ModelPropertyChange<IStartIgnFuelCurve, Nullable<FuelType>>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public IgnitionFuelTypeProxy(IStartIgnFuelCurve modelElement) : 
                    base(modelElement, "ignitionFuelType")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override Nullable<FuelType> Value
            {
                get
                {
                    return this.ModelElement.IgnitionFuelType;
                }
                set
                {
                    this.ModelElement.IgnitionFuelType = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the StartupModel property
        /// </summary>
        private sealed class StartupModelProxy : ModelPropertyChange<IStartIgnFuelCurve, IStartupModel>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public StartupModelProxy(IStartIgnFuelCurve modelElement) : 
                    base(modelElement, "StartupModel")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IStartupModel Value
            {
                get
                {
                    return this.ModelElement.StartupModel;
                }
                set
                {
                    this.ModelElement.StartupModel = value;
                }
            }
        }
    }
}

