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
    /// The default implementation of the SvPowerFlow class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#StateVariables")]
    [XmlNamespacePrefixAttribute("cimStateVariables")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/StateVariables/SvPowerFlow")]
    [DebuggerDisplayAttribute("SvPowerFlow {UUID}")]
    public partial class SvPowerFlow : StateVariable, ISvPowerFlow, IModelElement
    {
        
        /// <summary>
        /// The backing field for the P property
        /// </summary>
        private float _p;
        
        private static Lazy<ITypedElement> _pAttribute = new Lazy<ITypedElement>(RetrievePAttribute);
        
        /// <summary>
        /// The backing field for the Q property
        /// </summary>
        private float _q;
        
        private static Lazy<ITypedElement> _qAttribute = new Lazy<ITypedElement>(RetrieveQAttribute);
        
        private static Lazy<ITypedElement> _terminalReference = new Lazy<ITypedElement>(RetrieveTerminalReference);
        
        /// <summary>
        /// The backing field for the Terminal property
        /// </summary>
        private ITerminal _terminal;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The p property
        /// </summary>
        [XmlElementNameAttribute("p")]
        [XmlAttributeAttribute(true)]
        public virtual float P
        {
            get
            {
                return this._p;
            }
            set
            {
                if ((this._p != value))
                {
                    float old = this._p;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnPChanging(e);
                    this.OnPropertyChanging("P", e, _pAttribute);
                    this._p = value;
                    this.OnPChanged(e);
                    this.OnPropertyChanged("P", e, _pAttribute);
                }
            }
        }
        
        /// <summary>
        /// The q property
        /// </summary>
        [XmlElementNameAttribute("q")]
        [XmlAttributeAttribute(true)]
        public virtual float Q
        {
            get
            {
                return this._q;
            }
            set
            {
                if ((this._q != value))
                {
                    float old = this._q;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnQChanging(e);
                    this.OnPropertyChanging("Q", e, _qAttribute);
                    this._q = value;
                    this.OnQChanged(e);
                    this.OnPropertyChanged("Q", e, _qAttribute);
                }
            }
        }
        
        /// <summary>
        /// The Terminal property
        /// </summary>
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("SvPowerFlow")]
        public virtual ITerminal Terminal
        {
            get
            {
                return this._terminal;
            }
            set
            {
                if ((this._terminal != value))
                {
                    ITerminal old = this._terminal;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnTerminalChanging(e);
                    this.OnPropertyChanging("Terminal", e, _terminalReference);
                    this._terminal = value;
                    if ((old != null))
                    {
                        old.SvPowerFlow = null;
                        old.Deleted -= this.OnResetTerminal;
                    }
                    if ((value != null))
                    {
                        value.SvPowerFlow = this;
                        value.Deleted += this.OnResetTerminal;
                    }
                    this.OnTerminalChanged(e);
                    this.OnPropertyChanged("Terminal", e, _terminalReference);
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
                return base.ReferencedElements.Concat(new SvPowerFlowReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/StateVariables/SvPowerFlow")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the P property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> PChanging;
        
        /// <summary>
        /// Gets fired when the P property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> PChanged;
        
        /// <summary>
        /// Gets fired before the Q property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> QChanging;
        
        /// <summary>
        /// Gets fired when the Q property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> QChanged;
        
        /// <summary>
        /// Gets fired before the Terminal property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> TerminalChanging;
        
        /// <summary>
        /// Gets fired when the Terminal property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> TerminalChanged;
        
        private static ITypedElement RetrievePAttribute()
        {
            return ((ITypedElement)(((ModelElement)(SvPowerFlow.ClassInstance)).Resolve("p")));
        }
        
        /// <summary>
        /// Raises the PChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnPChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.PChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the PChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnPChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.PChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveQAttribute()
        {
            return ((ITypedElement)(((ModelElement)(SvPowerFlow.ClassInstance)).Resolve("q")));
        }
        
        /// <summary>
        /// Raises the QChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnQChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.QChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the QChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnQChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.QChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveTerminalReference()
        {
            return ((ITypedElement)(((ModelElement)(SvPowerFlow.ClassInstance)).Resolve("Terminal")));
        }
        
        /// <summary>
        /// Raises the TerminalChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnTerminalChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.TerminalChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the TerminalChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnTerminalChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.TerminalChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the Terminal property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetTerminal(object sender, System.EventArgs eventArgs)
        {
            this.Terminal = null;
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "P"))
            {
                return this.P;
            }
            if ((attribute == "Q"))
            {
                return this.Q;
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
            if ((feature == "TERMINAL"))
            {
                this.Terminal = ((ITerminal)(value));
                return;
            }
            if ((feature == "P"))
            {
                this.P = ((float)(value));
                return;
            }
            if ((feature == "Q"))
            {
                this.Q = ((float)(value));
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
            if ((attribute == "Terminal"))
            {
                return new TerminalProxy(this);
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
            if ((reference == "Terminal"))
            {
                return new TerminalProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/StateVariables/SvPowerFlow")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the SvPowerFlow class
        /// </summary>
        public class SvPowerFlowReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private SvPowerFlow _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public SvPowerFlowReferencedElementsCollection(SvPowerFlow parent)
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
                    if ((this._parent.Terminal != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.TerminalChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.TerminalChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.Terminal == null))
                {
                    ITerminal terminalCasted = item.As<ITerminal>();
                    if ((terminalCasted != null))
                    {
                        this._parent.Terminal = terminalCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.Terminal = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.Terminal))
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
                if ((this._parent.Terminal != null))
                {
                    array[arrayIndex] = this._parent.Terminal;
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
                if ((this._parent.Terminal == item))
                {
                    this._parent.Terminal = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.Terminal).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the p property
        /// </summary>
        private sealed class PProxy : ModelPropertyChange<ISvPowerFlow, float>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public PProxy(ISvPowerFlow modelElement) : 
                    base(modelElement, "p")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override float Value
            {
                get
                {
                    return this.ModelElement.P;
                }
                set
                {
                    this.ModelElement.P = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the q property
        /// </summary>
        private sealed class QProxy : ModelPropertyChange<ISvPowerFlow, float>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public QProxy(ISvPowerFlow modelElement) : 
                    base(modelElement, "q")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override float Value
            {
                get
                {
                    return this.ModelElement.Q;
                }
                set
                {
                    this.ModelElement.Q = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the Terminal property
        /// </summary>
        private sealed class TerminalProxy : ModelPropertyChange<ISvPowerFlow, ITerminal>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public TerminalProxy(ISvPowerFlow modelElement) : 
                    base(modelElement, "Terminal")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override ITerminal Value
            {
                get
                {
                    return this.ModelElement.Terminal;
                }
                set
                {
                    this.ModelElement.Terminal = value;
                }
            }
        }
    }
}

