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
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Wires;

namespace TTC2017.SmartGrids.CIM.IEC61970.Protection
{
    
    
    /// <summary>
    /// The default implementation of the RecloseSequence class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#Protection")]
    [XmlNamespacePrefixAttribute("cimProtection")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Protection/RecloseSequence")]
    [DebuggerDisplayAttribute("RecloseSequence {UUID}")]
    public partial class RecloseSequence : IdentifiedObject, IRecloseSequence, IModelElement
    {
        
        /// <summary>
        /// The backing field for the RecloseDelay property
        /// </summary>
        private float _recloseDelay;
        
        private static Lazy<ITypedElement> _recloseDelayAttribute = new Lazy<ITypedElement>(RetrieveRecloseDelayAttribute);
        
        /// <summary>
        /// The backing field for the RecloseStep property
        /// </summary>
        private int _recloseStep;
        
        private static Lazy<ITypedElement> _recloseStepAttribute = new Lazy<ITypedElement>(RetrieveRecloseStepAttribute);
        
        private static Lazy<ITypedElement> _protectedSwitchReference = new Lazy<ITypedElement>(RetrieveProtectedSwitchReference);
        
        /// <summary>
        /// The backing field for the ProtectedSwitch property
        /// </summary>
        private IProtectedSwitch _protectedSwitch;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The recloseDelay property
        /// </summary>
        [XmlElementNameAttribute("recloseDelay")]
        [XmlAttributeAttribute(true)]
        public virtual float RecloseDelay
        {
            get
            {
                return this._recloseDelay;
            }
            set
            {
                if ((this._recloseDelay != value))
                {
                    float old = this._recloseDelay;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnRecloseDelayChanging(e);
                    this.OnPropertyChanging("RecloseDelay", e, _recloseDelayAttribute);
                    this._recloseDelay = value;
                    this.OnRecloseDelayChanged(e);
                    this.OnPropertyChanged("RecloseDelay", e, _recloseDelayAttribute);
                }
            }
        }
        
        /// <summary>
        /// The recloseStep property
        /// </summary>
        [XmlElementNameAttribute("recloseStep")]
        [XmlAttributeAttribute(true)]
        public virtual int RecloseStep
        {
            get
            {
                return this._recloseStep;
            }
            set
            {
                if ((this._recloseStep != value))
                {
                    int old = this._recloseStep;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnRecloseStepChanging(e);
                    this.OnPropertyChanging("RecloseStep", e, _recloseStepAttribute);
                    this._recloseStep = value;
                    this.OnRecloseStepChanged(e);
                    this.OnPropertyChanged("RecloseStep", e, _recloseStepAttribute);
                }
            }
        }
        
        /// <summary>
        /// The ProtectedSwitch property
        /// </summary>
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("RecloseSequences")]
        public virtual IProtectedSwitch ProtectedSwitch
        {
            get
            {
                return this._protectedSwitch;
            }
            set
            {
                if ((this._protectedSwitch != value))
                {
                    IProtectedSwitch old = this._protectedSwitch;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnProtectedSwitchChanging(e);
                    this.OnPropertyChanging("ProtectedSwitch", e, _protectedSwitchReference);
                    this._protectedSwitch = value;
                    if ((old != null))
                    {
                        old.RecloseSequences.Remove(this);
                        old.Deleted -= this.OnResetProtectedSwitch;
                    }
                    if ((value != null))
                    {
                        value.RecloseSequences.Add(this);
                        value.Deleted += this.OnResetProtectedSwitch;
                    }
                    this.OnProtectedSwitchChanged(e);
                    this.OnPropertyChanged("ProtectedSwitch", e, _protectedSwitchReference);
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
                return base.ReferencedElements.Concat(new RecloseSequenceReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Protection/RecloseSequence")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the RecloseDelay property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> RecloseDelayChanging;
        
        /// <summary>
        /// Gets fired when the RecloseDelay property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> RecloseDelayChanged;
        
        /// <summary>
        /// Gets fired before the RecloseStep property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> RecloseStepChanging;
        
        /// <summary>
        /// Gets fired when the RecloseStep property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> RecloseStepChanged;
        
        /// <summary>
        /// Gets fired before the ProtectedSwitch property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ProtectedSwitchChanging;
        
        /// <summary>
        /// Gets fired when the ProtectedSwitch property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ProtectedSwitchChanged;
        
        private static ITypedElement RetrieveRecloseDelayAttribute()
        {
            return ((ITypedElement)(((ModelElement)(RecloseSequence.ClassInstance)).Resolve("recloseDelay")));
        }
        
        /// <summary>
        /// Raises the RecloseDelayChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnRecloseDelayChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.RecloseDelayChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the RecloseDelayChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnRecloseDelayChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.RecloseDelayChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveRecloseStepAttribute()
        {
            return ((ITypedElement)(((ModelElement)(RecloseSequence.ClassInstance)).Resolve("recloseStep")));
        }
        
        /// <summary>
        /// Raises the RecloseStepChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnRecloseStepChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.RecloseStepChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the RecloseStepChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnRecloseStepChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.RecloseStepChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveProtectedSwitchReference()
        {
            return ((ITypedElement)(((ModelElement)(RecloseSequence.ClassInstance)).Resolve("ProtectedSwitch")));
        }
        
        /// <summary>
        /// Raises the ProtectedSwitchChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnProtectedSwitchChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ProtectedSwitchChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the ProtectedSwitchChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnProtectedSwitchChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ProtectedSwitchChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the ProtectedSwitch property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetProtectedSwitch(object sender, System.EventArgs eventArgs)
        {
            this.ProtectedSwitch = null;
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "RECLOSEDELAY"))
            {
                return this.RecloseDelay;
            }
            if ((attribute == "RECLOSESTEP"))
            {
                return this.RecloseStep;
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
            if ((feature == "PROTECTEDSWITCH"))
            {
                this.ProtectedSwitch = ((IProtectedSwitch)(value));
                return;
            }
            if ((feature == "RECLOSEDELAY"))
            {
                this.RecloseDelay = ((float)(value));
                return;
            }
            if ((feature == "RECLOSESTEP"))
            {
                this.RecloseStep = ((int)(value));
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
            if ((attribute == "ProtectedSwitch"))
            {
                return new ProtectedSwitchProxy(this);
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
            if ((reference == "ProtectedSwitch"))
            {
                return new ProtectedSwitchProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Protection/RecloseSequence")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the RecloseSequence class
        /// </summary>
        public class RecloseSequenceReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private RecloseSequence _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public RecloseSequenceReferencedElementsCollection(RecloseSequence parent)
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
                    if ((this._parent.ProtectedSwitch != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.ProtectedSwitchChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.ProtectedSwitchChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.ProtectedSwitch == null))
                {
                    IProtectedSwitch protectedSwitchCasted = item.As<IProtectedSwitch>();
                    if ((protectedSwitchCasted != null))
                    {
                        this._parent.ProtectedSwitch = protectedSwitchCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.ProtectedSwitch = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.ProtectedSwitch))
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
                if ((this._parent.ProtectedSwitch != null))
                {
                    array[arrayIndex] = this._parent.ProtectedSwitch;
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
                if ((this._parent.ProtectedSwitch == item))
                {
                    this._parent.ProtectedSwitch = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.ProtectedSwitch).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the recloseDelay property
        /// </summary>
        private sealed class RecloseDelayProxy : ModelPropertyChange<IRecloseSequence, float>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public RecloseDelayProxy(IRecloseSequence modelElement) : 
                    base(modelElement, "recloseDelay")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override float Value
            {
                get
                {
                    return this.ModelElement.RecloseDelay;
                }
                set
                {
                    this.ModelElement.RecloseDelay = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the recloseStep property
        /// </summary>
        private sealed class RecloseStepProxy : ModelPropertyChange<IRecloseSequence, int>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public RecloseStepProxy(IRecloseSequence modelElement) : 
                    base(modelElement, "recloseStep")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override int Value
            {
                get
                {
                    return this.ModelElement.RecloseStep;
                }
                set
                {
                    this.ModelElement.RecloseStep = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the ProtectedSwitch property
        /// </summary>
        private sealed class ProtectedSwitchProxy : ModelPropertyChange<IRecloseSequence, IProtectedSwitch>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public ProtectedSwitchProxy(IRecloseSequence modelElement) : 
                    base(modelElement, "ProtectedSwitch")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IProtectedSwitch Value
            {
                get
                {
                    return this.ModelElement.ProtectedSwitch;
                }
                set
                {
                    this.ModelElement.ProtectedSwitch = value;
                }
            }
        }
    }
}

