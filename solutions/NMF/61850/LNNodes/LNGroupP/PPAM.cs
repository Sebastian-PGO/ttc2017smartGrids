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
using TTC2017.SmartGrids.SubstationStandard.Dataclasses;
using TTC2017.SmartGrids.SubstationStandard.LNNodes.DomainLNs;

namespace TTC2017.SmartGrids.SubstationStandard.LNNodes.LNGroupP
{
    
    
    /// <summary>
    /// The default implementation of the PPAM class
    /// </summary>
    [XmlNamespaceAttribute("http://www.transformation-tool-contest.eu/2017/smartGrids/substationStandard/grou" +
        "pP")]
    [XmlNamespacePrefixAttribute("groupP")]
    [ModelRepresentationClassAttribute("http://www.transformation-tool-contest.eu/2017/smartGrids/substationStandard#//LN" +
        "Nodes/LNGroupP/PPAM")]
    public partial class PPAM : TTC2017.SmartGrids.SubstationStandard.LNNodes.LNGroupP.GroupP, IPPAM, IModelElement
    {
        
        private static Lazy<ITypedElement> _strReference = new Lazy<ITypedElement>(RetrieveStrReference);
        
        /// <summary>
        /// The backing field for the Str property
        /// </summary>
        private IACD _str;
        
        private static Lazy<ITypedElement> _opReference = new Lazy<ITypedElement>(RetrieveOpReference);
        
        /// <summary>
        /// The backing field for the Op property
        /// </summary>
        private IACT _op;
        
        private static Lazy<ITypedElement> _strValReference = new Lazy<ITypedElement>(RetrieveStrValReference);
        
        /// <summary>
        /// The backing field for the StrVal property
        /// </summary>
        private IASG _strVal;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The Str property
        /// </summary>
        [XmlAttributeAttribute(true)]
        public virtual IACD Str
        {
            get
            {
                return this._str;
            }
            set
            {
                if ((this._str != value))
                {
                    IACD old = this._str;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnStrChanging(e);
                    this.OnPropertyChanging("Str", e, _strReference);
                    this._str = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetStr;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetStr;
                    }
                    this.OnStrChanged(e);
                    this.OnPropertyChanged("Str", e, _strReference);
                }
            }
        }
        
        /// <summary>
        /// The Op property
        /// </summary>
        [XmlAttributeAttribute(true)]
        public virtual IACT Op
        {
            get
            {
                return this._op;
            }
            set
            {
                if ((this._op != value))
                {
                    IACT old = this._op;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnOpChanging(e);
                    this.OnPropertyChanging("Op", e, _opReference);
                    this._op = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetOp;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetOp;
                    }
                    this.OnOpChanged(e);
                    this.OnPropertyChanged("Op", e, _opReference);
                }
            }
        }
        
        /// <summary>
        /// The StrVal property
        /// </summary>
        [XmlAttributeAttribute(true)]
        public virtual IASG StrVal
        {
            get
            {
                return this._strVal;
            }
            set
            {
                if ((this._strVal != value))
                {
                    IASG old = this._strVal;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnStrValChanging(e);
                    this.OnPropertyChanging("StrVal", e, _strValReference);
                    this._strVal = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetStrVal;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetStrVal;
                    }
                    this.OnStrValChanged(e);
                    this.OnPropertyChanged("StrVal", e, _strValReference);
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
                return base.ReferencedElements.Concat(new PPAMReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://www.transformation-tool-contest.eu/2017/smartGrids/substationStandard#//LN" +
                            "Nodes/LNGroupP/PPAM")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the Str property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> StrChanging;
        
        /// <summary>
        /// Gets fired when the Str property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> StrChanged;
        
        /// <summary>
        /// Gets fired before the Op property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> OpChanging;
        
        /// <summary>
        /// Gets fired when the Op property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> OpChanged;
        
        /// <summary>
        /// Gets fired before the StrVal property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> StrValChanging;
        
        /// <summary>
        /// Gets fired when the StrVal property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> StrValChanged;
        
        private static ITypedElement RetrieveStrReference()
        {
            return ((ITypedElement)(((ModelElement)(PPAM.ClassInstance)).Resolve("Str")));
        }
        
        /// <summary>
        /// Raises the StrChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnStrChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.StrChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the StrChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnStrChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.StrChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the Str property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetStr(object sender, System.EventArgs eventArgs)
        {
            this.Str = null;
        }
        
        private static ITypedElement RetrieveOpReference()
        {
            return ((ITypedElement)(((ModelElement)(PPAM.ClassInstance)).Resolve("Op")));
        }
        
        /// <summary>
        /// Raises the OpChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnOpChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.OpChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the OpChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnOpChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.OpChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the Op property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetOp(object sender, System.EventArgs eventArgs)
        {
            this.Op = null;
        }
        
        private static ITypedElement RetrieveStrValReference()
        {
            return ((ITypedElement)(((ModelElement)(PPAM.ClassInstance)).Resolve("StrVal")));
        }
        
        /// <summary>
        /// Raises the StrValChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnStrValChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.StrValChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the StrValChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnStrValChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.StrValChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the StrVal property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetStrVal(object sender, System.EventArgs eventArgs)
        {
            this.StrVal = null;
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "STR"))
            {
                this.Str = ((IACD)(value));
                return;
            }
            if ((feature == "OP"))
            {
                this.Op = ((IACT)(value));
                return;
            }
            if ((feature == "STRVAL"))
            {
                this.StrVal = ((IASG)(value));
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
            if ((attribute == "Str"))
            {
                return new StrProxy(this);
            }
            if ((attribute == "Op"))
            {
                return new OpProxy(this);
            }
            if ((attribute == "StrVal"))
            {
                return new StrValProxy(this);
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
            if ((reference == "Str"))
            {
                return new StrProxy(this);
            }
            if ((reference == "Op"))
            {
                return new OpProxy(this);
            }
            if ((reference == "StrVal"))
            {
                return new StrValProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://www.transformation-tool-contest.eu/2017/smartGrids/substationStandard#//LN" +
                        "Nodes/LNGroupP/PPAM")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the PPAM class
        /// </summary>
        public class PPAMReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private PPAM _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public PPAMReferencedElementsCollection(PPAM parent)
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
                    if ((this._parent.Str != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.Op != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.StrVal != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.StrChanged += this.PropagateValueChanges;
                this._parent.OpChanged += this.PropagateValueChanges;
                this._parent.StrValChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.StrChanged -= this.PropagateValueChanges;
                this._parent.OpChanged -= this.PropagateValueChanges;
                this._parent.StrValChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.Str == null))
                {
                    IACD strCasted = item.As<IACD>();
                    if ((strCasted != null))
                    {
                        this._parent.Str = strCasted;
                        return;
                    }
                }
                if ((this._parent.Op == null))
                {
                    IACT opCasted = item.As<IACT>();
                    if ((opCasted != null))
                    {
                        this._parent.Op = opCasted;
                        return;
                    }
                }
                if ((this._parent.StrVal == null))
                {
                    IASG strValCasted = item.As<IASG>();
                    if ((strValCasted != null))
                    {
                        this._parent.StrVal = strValCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.Str = null;
                this._parent.Op = null;
                this._parent.StrVal = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.Str))
                {
                    return true;
                }
                if ((item == this._parent.Op))
                {
                    return true;
                }
                if ((item == this._parent.StrVal))
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
                if ((this._parent.Str != null))
                {
                    array[arrayIndex] = this._parent.Str;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.Op != null))
                {
                    array[arrayIndex] = this._parent.Op;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.StrVal != null))
                {
                    array[arrayIndex] = this._parent.StrVal;
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
                if ((this._parent.Str == item))
                {
                    this._parent.Str = null;
                    return true;
                }
                if ((this._parent.Op == item))
                {
                    this._parent.Op = null;
                    return true;
                }
                if ((this._parent.StrVal == item))
                {
                    this._parent.StrVal = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.Str).Concat(this._parent.Op).Concat(this._parent.StrVal).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the Str property
        /// </summary>
        private sealed class StrProxy : ModelPropertyChange<IPPAM, IACD>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public StrProxy(IPPAM modelElement) : 
                    base(modelElement, "Str")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IACD Value
            {
                get
                {
                    return this.ModelElement.Str;
                }
                set
                {
                    this.ModelElement.Str = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the Op property
        /// </summary>
        private sealed class OpProxy : ModelPropertyChange<IPPAM, IACT>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public OpProxy(IPPAM modelElement) : 
                    base(modelElement, "Op")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IACT Value
            {
                get
                {
                    return this.ModelElement.Op;
                }
                set
                {
                    this.ModelElement.Op = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the StrVal property
        /// </summary>
        private sealed class StrValProxy : ModelPropertyChange<IPPAM, IASG>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public StrValProxy(IPPAM modelElement) : 
                    base(modelElement, "StrVal")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IASG Value
            {
                get
                {
                    return this.ModelElement.StrVal;
                }
                set
                {
                    this.ModelElement.StrVal = value;
                }
            }
        }
    }
}

