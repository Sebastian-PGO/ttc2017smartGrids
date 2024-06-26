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
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Topology;
using TTC2017.SmartGrids.CIM.IEC61970.Wires;

namespace TTC2017.SmartGrids.CIM.IEC61970.StateVariables
{
    
    
    /// <summary>
    /// The default implementation of the SvShortCircuit class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#StateVariables")]
    [XmlNamespacePrefixAttribute("cimStateVariables")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/StateVariables/SvShortCircuit" +
        "")]
    [DebuggerDisplayAttribute("SvShortCircuit {UUID}")]
    public partial class SvShortCircuit : StateVariable, ISvShortCircuit, IModelElement
    {
        
        /// <summary>
        /// The backing field for the R0PerR property
        /// </summary>
        private float _r0PerR;
        
        private static Lazy<ITypedElement> _r0PerRAttribute = new Lazy<ITypedElement>(RetrieveR0PerRAttribute);
        
        /// <summary>
        /// The backing field for the SShortCircuit property
        /// </summary>
        private float _sShortCircuit;
        
        private static Lazy<ITypedElement> _sShortCircuitAttribute = new Lazy<ITypedElement>(RetrieveSShortCircuitAttribute);
        
        /// <summary>
        /// The backing field for the XPerR property
        /// </summary>
        private float _xPerR;
        
        private static Lazy<ITypedElement> _xPerRAttribute = new Lazy<ITypedElement>(RetrieveXPerRAttribute);
        
        /// <summary>
        /// The backing field for the X0PerX property
        /// </summary>
        private float _x0PerX;
        
        private static Lazy<ITypedElement> _x0PerXAttribute = new Lazy<ITypedElement>(RetrieveX0PerXAttribute);
        
        private static Lazy<ITypedElement> _topologicalNodeReference = new Lazy<ITypedElement>(RetrieveTopologicalNodeReference);
        
        /// <summary>
        /// The backing field for the TopologicalNode property
        /// </summary>
        private ITopologicalNode _topologicalNode;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The r0PerR property
        /// </summary>
        [XmlElementNameAttribute("r0PerR")]
        [XmlAttributeAttribute(true)]
        public virtual float R0PerR
        {
            get
            {
                return this._r0PerR;
            }
            set
            {
                if ((this._r0PerR != value))
                {
                    float old = this._r0PerR;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnR0PerRChanging(e);
                    this.OnPropertyChanging("R0PerR", e, _r0PerRAttribute);
                    this._r0PerR = value;
                    this.OnR0PerRChanged(e);
                    this.OnPropertyChanged("R0PerR", e, _r0PerRAttribute);
                }
            }
        }
        
        /// <summary>
        /// The sShortCircuit property
        /// </summary>
        [XmlElementNameAttribute("sShortCircuit")]
        [XmlAttributeAttribute(true)]
        public virtual float SShortCircuit
        {
            get
            {
                return this._sShortCircuit;
            }
            set
            {
                if ((this._sShortCircuit != value))
                {
                    float old = this._sShortCircuit;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnSShortCircuitChanging(e);
                    this.OnPropertyChanging("SShortCircuit", e, _sShortCircuitAttribute);
                    this._sShortCircuit = value;
                    this.OnSShortCircuitChanged(e);
                    this.OnPropertyChanged("SShortCircuit", e, _sShortCircuitAttribute);
                }
            }
        }
        
        /// <summary>
        /// The xPerR property
        /// </summary>
        [XmlElementNameAttribute("xPerR")]
        [XmlAttributeAttribute(true)]
        public virtual float XPerR
        {
            get
            {
                return this._xPerR;
            }
            set
            {
                if ((this._xPerR != value))
                {
                    float old = this._xPerR;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnXPerRChanging(e);
                    this.OnPropertyChanging("XPerR", e, _xPerRAttribute);
                    this._xPerR = value;
                    this.OnXPerRChanged(e);
                    this.OnPropertyChanged("XPerR", e, _xPerRAttribute);
                }
            }
        }
        
        /// <summary>
        /// The x0PerX property
        /// </summary>
        [XmlElementNameAttribute("x0PerX")]
        [XmlAttributeAttribute(true)]
        public virtual float X0PerX
        {
            get
            {
                return this._x0PerX;
            }
            set
            {
                if ((this._x0PerX != value))
                {
                    float old = this._x0PerX;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnX0PerXChanging(e);
                    this.OnPropertyChanging("X0PerX", e, _x0PerXAttribute);
                    this._x0PerX = value;
                    this.OnX0PerXChanged(e);
                    this.OnPropertyChanged("X0PerX", e, _x0PerXAttribute);
                }
            }
        }
        
        /// <summary>
        /// The TopologicalNode property
        /// </summary>
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("SvShortCircuit")]
        public virtual ITopologicalNode TopologicalNode
        {
            get
            {
                return this._topologicalNode;
            }
            set
            {
                if ((this._topologicalNode != value))
                {
                    ITopologicalNode old = this._topologicalNode;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnTopologicalNodeChanging(e);
                    this.OnPropertyChanging("TopologicalNode", e, _topologicalNodeReference);
                    this._topologicalNode = value;
                    if ((old != null))
                    {
                        old.SvShortCircuit = null;
                        old.Deleted -= this.OnResetTopologicalNode;
                    }
                    if ((value != null))
                    {
                        value.SvShortCircuit = this;
                        value.Deleted += this.OnResetTopologicalNode;
                    }
                    this.OnTopologicalNodeChanged(e);
                    this.OnPropertyChanged("TopologicalNode", e, _topologicalNodeReference);
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
                return base.ReferencedElements.Concat(new SvShortCircuitReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/StateVariables/SvShortCircuit" +
                            "")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the R0PerR property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> R0PerRChanging;
        
        /// <summary>
        /// Gets fired when the R0PerR property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> R0PerRChanged;
        
        /// <summary>
        /// Gets fired before the SShortCircuit property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> SShortCircuitChanging;
        
        /// <summary>
        /// Gets fired when the SShortCircuit property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> SShortCircuitChanged;
        
        /// <summary>
        /// Gets fired before the XPerR property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> XPerRChanging;
        
        /// <summary>
        /// Gets fired when the XPerR property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> XPerRChanged;
        
        /// <summary>
        /// Gets fired before the X0PerX property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> X0PerXChanging;
        
        /// <summary>
        /// Gets fired when the X0PerX property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> X0PerXChanged;
        
        /// <summary>
        /// Gets fired before the TopologicalNode property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> TopologicalNodeChanging;
        
        /// <summary>
        /// Gets fired when the TopologicalNode property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> TopologicalNodeChanged;
        
        private static ITypedElement RetrieveR0PerRAttribute()
        {
            return ((ITypedElement)(((ModelElement)(SvShortCircuit.ClassInstance)).Resolve("r0PerR")));
        }
        
        /// <summary>
        /// Raises the R0PerRChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnR0PerRChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.R0PerRChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the R0PerRChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnR0PerRChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.R0PerRChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveSShortCircuitAttribute()
        {
            return ((ITypedElement)(((ModelElement)(SvShortCircuit.ClassInstance)).Resolve("sShortCircuit")));
        }
        
        /// <summary>
        /// Raises the SShortCircuitChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnSShortCircuitChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.SShortCircuitChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the SShortCircuitChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnSShortCircuitChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.SShortCircuitChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveXPerRAttribute()
        {
            return ((ITypedElement)(((ModelElement)(SvShortCircuit.ClassInstance)).Resolve("xPerR")));
        }
        
        /// <summary>
        /// Raises the XPerRChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnXPerRChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.XPerRChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the XPerRChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnXPerRChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.XPerRChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveX0PerXAttribute()
        {
            return ((ITypedElement)(((ModelElement)(SvShortCircuit.ClassInstance)).Resolve("x0PerX")));
        }
        
        /// <summary>
        /// Raises the X0PerXChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnX0PerXChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.X0PerXChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the X0PerXChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnX0PerXChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.X0PerXChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveTopologicalNodeReference()
        {
            return ((ITypedElement)(((ModelElement)(SvShortCircuit.ClassInstance)).Resolve("TopologicalNode")));
        }
        
        /// <summary>
        /// Raises the TopologicalNodeChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnTopologicalNodeChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.TopologicalNodeChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the TopologicalNodeChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnTopologicalNodeChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.TopologicalNodeChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the TopologicalNode property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetTopologicalNode(object sender, System.EventArgs eventArgs)
        {
            this.TopologicalNode = null;
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "R0PERR"))
            {
                return this.R0PerR;
            }
            if ((attribute == "SSHORTCIRCUIT"))
            {
                return this.SShortCircuit;
            }
            if ((attribute == "XPERR"))
            {
                return this.XPerR;
            }
            if ((attribute == "X0PERX"))
            {
                return this.X0PerX;
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
            if ((feature == "TOPOLOGICALNODE"))
            {
                this.TopologicalNode = ((ITopologicalNode)(value));
                return;
            }
            if ((feature == "R0PERR"))
            {
                this.R0PerR = ((float)(value));
                return;
            }
            if ((feature == "SSHORTCIRCUIT"))
            {
                this.SShortCircuit = ((float)(value));
                return;
            }
            if ((feature == "XPERR"))
            {
                this.XPerR = ((float)(value));
                return;
            }
            if ((feature == "X0PERX"))
            {
                this.X0PerX = ((float)(value));
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
            if ((attribute == "TopologicalNode"))
            {
                return new TopologicalNodeProxy(this);
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
            if ((reference == "TopologicalNode"))
            {
                return new TopologicalNodeProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/StateVariables/SvShortCircuit" +
                        "")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the SvShortCircuit class
        /// </summary>
        public class SvShortCircuitReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private SvShortCircuit _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public SvShortCircuitReferencedElementsCollection(SvShortCircuit parent)
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
                    if ((this._parent.TopologicalNode != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.TopologicalNodeChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.TopologicalNodeChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.TopologicalNode == null))
                {
                    ITopologicalNode topologicalNodeCasted = item.As<ITopologicalNode>();
                    if ((topologicalNodeCasted != null))
                    {
                        this._parent.TopologicalNode = topologicalNodeCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.TopologicalNode = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.TopologicalNode))
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
                if ((this._parent.TopologicalNode != null))
                {
                    array[arrayIndex] = this._parent.TopologicalNode;
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
                if ((this._parent.TopologicalNode == item))
                {
                    this._parent.TopologicalNode = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.TopologicalNode).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the r0PerR property
        /// </summary>
        private sealed class R0PerRProxy : ModelPropertyChange<ISvShortCircuit, float>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public R0PerRProxy(ISvShortCircuit modelElement) : 
                    base(modelElement, "r0PerR")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override float Value
            {
                get
                {
                    return this.ModelElement.R0PerR;
                }
                set
                {
                    this.ModelElement.R0PerR = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the sShortCircuit property
        /// </summary>
        private sealed class SShortCircuitProxy : ModelPropertyChange<ISvShortCircuit, float>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public SShortCircuitProxy(ISvShortCircuit modelElement) : 
                    base(modelElement, "sShortCircuit")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override float Value
            {
                get
                {
                    return this.ModelElement.SShortCircuit;
                }
                set
                {
                    this.ModelElement.SShortCircuit = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the xPerR property
        /// </summary>
        private sealed class XPerRProxy : ModelPropertyChange<ISvShortCircuit, float>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public XPerRProxy(ISvShortCircuit modelElement) : 
                    base(modelElement, "xPerR")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override float Value
            {
                get
                {
                    return this.ModelElement.XPerR;
                }
                set
                {
                    this.ModelElement.XPerR = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the x0PerX property
        /// </summary>
        private sealed class X0PerXProxy : ModelPropertyChange<ISvShortCircuit, float>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public X0PerXProxy(ISvShortCircuit modelElement) : 
                    base(modelElement, "x0PerX")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override float Value
            {
                get
                {
                    return this.ModelElement.X0PerX;
                }
                set
                {
                    this.ModelElement.X0PerX = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the TopologicalNode property
        /// </summary>
        private sealed class TopologicalNodeProxy : ModelPropertyChange<ISvShortCircuit, ITopologicalNode>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public TopologicalNodeProxy(ISvShortCircuit modelElement) : 
                    base(modelElement, "TopologicalNode")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override ITopologicalNode Value
            {
                get
                {
                    return this.ModelElement.TopologicalNode;
                }
                set
                {
                    this.ModelElement.TopologicalNode = value;
                }
            }
        }
    }
}

