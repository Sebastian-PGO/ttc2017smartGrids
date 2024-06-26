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
using TTC2017.SmartGrids.SubstationStandard.Enumerations;

namespace TTC2017.SmartGrids.SubstationStandard.Dataclasses
{
    
    
    /// <summary>
    /// The default implementation of the SEQ class
    /// </summary>
    [XmlNamespaceAttribute("http://www.transformation-tool-contest.eu/2017/smartGrids/dataclasses")]
    [XmlNamespacePrefixAttribute("data")]
    [ModelRepresentationClassAttribute("http://www.transformation-tool-contest.eu/2017/smartGrids/substationStandard#//Da" +
        "taclasses/SEQ")]
    public partial class SEQ : ModelElement, ISEQ, IModelElement
    {
        
        private static Lazy<ITypedElement> _c1Reference = new Lazy<ITypedElement>(RetrieveC1Reference);
        
        /// <summary>
        /// The backing field for the C1 property
        /// </summary>
        private ICMV _c1;
        
        private static Lazy<ITypedElement> _c2Reference = new Lazy<ITypedElement>(RetrieveC2Reference);
        
        /// <summary>
        /// The backing field for the C2 property
        /// </summary>
        private ICMV _c2;
        
        private static Lazy<ITypedElement> _c3Reference = new Lazy<ITypedElement>(RetrieveC3Reference);
        
        /// <summary>
        /// The backing field for the C3 property
        /// </summary>
        private ICMV _c3;
        
        private static Lazy<ITypedElement> _seqTReference = new Lazy<ITypedElement>(RetrieveSeqTReference);
        
        /// <summary>
        /// The backing field for the SeqT property
        /// </summary>
        private ISequence _seqT;
        
        private static Lazy<ITypedElement> _phsRefReference = new Lazy<ITypedElement>(RetrievePhsRefReference);
        
        /// <summary>
        /// The backing field for the PhsRef property
        /// </summary>
        private IPhaseReference _phsRef;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The c1 property
        /// </summary>
        [XmlElementNameAttribute("c1")]
        [XmlAttributeAttribute(true)]
        public virtual ICMV C1
        {
            get
            {
                return this._c1;
            }
            set
            {
                if ((this._c1 != value))
                {
                    ICMV old = this._c1;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnC1Changing(e);
                    this.OnPropertyChanging("C1", e, _c1Reference);
                    this._c1 = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetC1;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetC1;
                    }
                    this.OnC1Changed(e);
                    this.OnPropertyChanged("C1", e, _c1Reference);
                }
            }
        }
        
        /// <summary>
        /// The c2 property
        /// </summary>
        [XmlElementNameAttribute("c2")]
        [XmlAttributeAttribute(true)]
        public virtual ICMV C2
        {
            get
            {
                return this._c2;
            }
            set
            {
                if ((this._c2 != value))
                {
                    ICMV old = this._c2;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnC2Changing(e);
                    this.OnPropertyChanging("C2", e, _c2Reference);
                    this._c2 = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetC2;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetC2;
                    }
                    this.OnC2Changed(e);
                    this.OnPropertyChanged("C2", e, _c2Reference);
                }
            }
        }
        
        /// <summary>
        /// The c3 property
        /// </summary>
        [XmlElementNameAttribute("c3")]
        [XmlAttributeAttribute(true)]
        public virtual ICMV C3
        {
            get
            {
                return this._c3;
            }
            set
            {
                if ((this._c3 != value))
                {
                    ICMV old = this._c3;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnC3Changing(e);
                    this.OnPropertyChanging("C3", e, _c3Reference);
                    this._c3 = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetC3;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetC3;
                    }
                    this.OnC3Changed(e);
                    this.OnPropertyChanged("C3", e, _c3Reference);
                }
            }
        }
        
        /// <summary>
        /// The seqT property
        /// </summary>
        [XmlElementNameAttribute("seqT")]
        [XmlAttributeAttribute(true)]
        public virtual ISequence SeqT
        {
            get
            {
                return this._seqT;
            }
            set
            {
                if ((this._seqT != value))
                {
                    ISequence old = this._seqT;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnSeqTChanging(e);
                    this.OnPropertyChanging("SeqT", e, _seqTReference);
                    this._seqT = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetSeqT;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetSeqT;
                    }
                    this.OnSeqTChanged(e);
                    this.OnPropertyChanged("SeqT", e, _seqTReference);
                }
            }
        }
        
        /// <summary>
        /// The phsRef property
        /// </summary>
        [XmlElementNameAttribute("phsRef")]
        [XmlAttributeAttribute(true)]
        public virtual IPhaseReference PhsRef
        {
            get
            {
                return this._phsRef;
            }
            set
            {
                if ((this._phsRef != value))
                {
                    IPhaseReference old = this._phsRef;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnPhsRefChanging(e);
                    this.OnPropertyChanging("PhsRef", e, _phsRefReference);
                    this._phsRef = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetPhsRef;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetPhsRef;
                    }
                    this.OnPhsRefChanged(e);
                    this.OnPropertyChanged("PhsRef", e, _phsRefReference);
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
                return base.ReferencedElements.Concat(new SEQReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://www.transformation-tool-contest.eu/2017/smartGrids/substationStandard#//Da" +
                            "taclasses/SEQ")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the C1 property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> C1Changing;
        
        /// <summary>
        /// Gets fired when the C1 property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> C1Changed;
        
        /// <summary>
        /// Gets fired before the C2 property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> C2Changing;
        
        /// <summary>
        /// Gets fired when the C2 property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> C2Changed;
        
        /// <summary>
        /// Gets fired before the C3 property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> C3Changing;
        
        /// <summary>
        /// Gets fired when the C3 property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> C3Changed;
        
        /// <summary>
        /// Gets fired before the SeqT property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> SeqTChanging;
        
        /// <summary>
        /// Gets fired when the SeqT property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> SeqTChanged;
        
        /// <summary>
        /// Gets fired before the PhsRef property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> PhsRefChanging;
        
        /// <summary>
        /// Gets fired when the PhsRef property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> PhsRefChanged;
        
        private static ITypedElement RetrieveC1Reference()
        {
            return ((ITypedElement)(((ModelElement)(SEQ.ClassInstance)).Resolve("c1")));
        }
        
        /// <summary>
        /// Raises the C1Changing event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnC1Changing(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.C1Changing;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the C1Changed event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnC1Changed(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.C1Changed;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the C1 property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetC1(object sender, System.EventArgs eventArgs)
        {
            this.C1 = null;
        }
        
        private static ITypedElement RetrieveC2Reference()
        {
            return ((ITypedElement)(((ModelElement)(SEQ.ClassInstance)).Resolve("c2")));
        }
        
        /// <summary>
        /// Raises the C2Changing event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnC2Changing(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.C2Changing;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the C2Changed event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnC2Changed(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.C2Changed;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the C2 property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetC2(object sender, System.EventArgs eventArgs)
        {
            this.C2 = null;
        }
        
        private static ITypedElement RetrieveC3Reference()
        {
            return ((ITypedElement)(((ModelElement)(SEQ.ClassInstance)).Resolve("c3")));
        }
        
        /// <summary>
        /// Raises the C3Changing event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnC3Changing(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.C3Changing;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the C3Changed event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnC3Changed(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.C3Changed;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the C3 property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetC3(object sender, System.EventArgs eventArgs)
        {
            this.C3 = null;
        }
        
        private static ITypedElement RetrieveSeqTReference()
        {
            return ((ITypedElement)(((ModelElement)(SEQ.ClassInstance)).Resolve("seqT")));
        }
        
        /// <summary>
        /// Raises the SeqTChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnSeqTChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.SeqTChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the SeqTChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnSeqTChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.SeqTChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the SeqT property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetSeqT(object sender, System.EventArgs eventArgs)
        {
            this.SeqT = null;
        }
        
        private static ITypedElement RetrievePhsRefReference()
        {
            return ((ITypedElement)(((ModelElement)(SEQ.ClassInstance)).Resolve("phsRef")));
        }
        
        /// <summary>
        /// Raises the PhsRefChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnPhsRefChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.PhsRefChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the PhsRefChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnPhsRefChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.PhsRefChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the PhsRef property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetPhsRef(object sender, System.EventArgs eventArgs)
        {
            this.PhsRef = null;
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "C1"))
            {
                this.C1 = ((ICMV)(value));
                return;
            }
            if ((feature == "C2"))
            {
                this.C2 = ((ICMV)(value));
                return;
            }
            if ((feature == "C3"))
            {
                this.C3 = ((ICMV)(value));
                return;
            }
            if ((feature == "SEQT"))
            {
                this.SeqT = ((ISequence)(value));
                return;
            }
            if ((feature == "PHSREF"))
            {
                this.PhsRef = ((IPhaseReference)(value));
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
            if ((attribute == "C1"))
            {
                return new C1Proxy(this);
            }
            if ((attribute == "C2"))
            {
                return new C2Proxy(this);
            }
            if ((attribute == "C3"))
            {
                return new C3Proxy(this);
            }
            if ((attribute == "SeqT"))
            {
                return new SeqTProxy(this);
            }
            if ((attribute == "PhsRef"))
            {
                return new PhsRefProxy(this);
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
            if ((reference == "C1"))
            {
                return new C1Proxy(this);
            }
            if ((reference == "C2"))
            {
                return new C2Proxy(this);
            }
            if ((reference == "C3"))
            {
                return new C3Proxy(this);
            }
            if ((reference == "SeqT"))
            {
                return new SeqTProxy(this);
            }
            if ((reference == "PhsRef"))
            {
                return new PhsRefProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://www.transformation-tool-contest.eu/2017/smartGrids/substationStandard#//Da" +
                        "taclasses/SEQ")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the SEQ class
        /// </summary>
        public class SEQReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private SEQ _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public SEQReferencedElementsCollection(SEQ parent)
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
                    if ((this._parent.C1 != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.C2 != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.C3 != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.SeqT != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.PhsRef != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.C1Changed += this.PropagateValueChanges;
                this._parent.C2Changed += this.PropagateValueChanges;
                this._parent.C3Changed += this.PropagateValueChanges;
                this._parent.SeqTChanged += this.PropagateValueChanges;
                this._parent.PhsRefChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.C1Changed -= this.PropagateValueChanges;
                this._parent.C2Changed -= this.PropagateValueChanges;
                this._parent.C3Changed -= this.PropagateValueChanges;
                this._parent.SeqTChanged -= this.PropagateValueChanges;
                this._parent.PhsRefChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.C1 == null))
                {
                    ICMV c1Casted = item.As<ICMV>();
                    if ((c1Casted != null))
                    {
                        this._parent.C1 = c1Casted;
                        return;
                    }
                }
                if ((this._parent.C2 == null))
                {
                    ICMV c2Casted = item.As<ICMV>();
                    if ((c2Casted != null))
                    {
                        this._parent.C2 = c2Casted;
                        return;
                    }
                }
                if ((this._parent.C3 == null))
                {
                    ICMV c3Casted = item.As<ICMV>();
                    if ((c3Casted != null))
                    {
                        this._parent.C3 = c3Casted;
                        return;
                    }
                }
                if ((this._parent.SeqT == null))
                {
                    ISequence seqTCasted = item.As<ISequence>();
                    if ((seqTCasted != null))
                    {
                        this._parent.SeqT = seqTCasted;
                        return;
                    }
                }
                if ((this._parent.PhsRef == null))
                {
                    IPhaseReference phsRefCasted = item.As<IPhaseReference>();
                    if ((phsRefCasted != null))
                    {
                        this._parent.PhsRef = phsRefCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.C1 = null;
                this._parent.C2 = null;
                this._parent.C3 = null;
                this._parent.SeqT = null;
                this._parent.PhsRef = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.C1))
                {
                    return true;
                }
                if ((item == this._parent.C2))
                {
                    return true;
                }
                if ((item == this._parent.C3))
                {
                    return true;
                }
                if ((item == this._parent.SeqT))
                {
                    return true;
                }
                if ((item == this._parent.PhsRef))
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
                if ((this._parent.C1 != null))
                {
                    array[arrayIndex] = this._parent.C1;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.C2 != null))
                {
                    array[arrayIndex] = this._parent.C2;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.C3 != null))
                {
                    array[arrayIndex] = this._parent.C3;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.SeqT != null))
                {
                    array[arrayIndex] = this._parent.SeqT;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.PhsRef != null))
                {
                    array[arrayIndex] = this._parent.PhsRef;
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
                if ((this._parent.C1 == item))
                {
                    this._parent.C1 = null;
                    return true;
                }
                if ((this._parent.C2 == item))
                {
                    this._parent.C2 = null;
                    return true;
                }
                if ((this._parent.C3 == item))
                {
                    this._parent.C3 = null;
                    return true;
                }
                if ((this._parent.SeqT == item))
                {
                    this._parent.SeqT = null;
                    return true;
                }
                if ((this._parent.PhsRef == item))
                {
                    this._parent.PhsRef = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.C1).Concat(this._parent.C2).Concat(this._parent.C3).Concat(this._parent.SeqT).Concat(this._parent.PhsRef).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the c1 property
        /// </summary>
        private sealed class C1Proxy : ModelPropertyChange<ISEQ, ICMV>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public C1Proxy(ISEQ modelElement) : 
                    base(modelElement, "c1")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override ICMV Value
            {
                get
                {
                    return this.ModelElement.C1;
                }
                set
                {
                    this.ModelElement.C1 = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the c2 property
        /// </summary>
        private sealed class C2Proxy : ModelPropertyChange<ISEQ, ICMV>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public C2Proxy(ISEQ modelElement) : 
                    base(modelElement, "c2")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override ICMV Value
            {
                get
                {
                    return this.ModelElement.C2;
                }
                set
                {
                    this.ModelElement.C2 = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the c3 property
        /// </summary>
        private sealed class C3Proxy : ModelPropertyChange<ISEQ, ICMV>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public C3Proxy(ISEQ modelElement) : 
                    base(modelElement, "c3")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override ICMV Value
            {
                get
                {
                    return this.ModelElement.C3;
                }
                set
                {
                    this.ModelElement.C3 = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the seqT property
        /// </summary>
        private sealed class SeqTProxy : ModelPropertyChange<ISEQ, ISequence>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public SeqTProxy(ISEQ modelElement) : 
                    base(modelElement, "seqT")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override ISequence Value
            {
                get
                {
                    return this.ModelElement.SeqT;
                }
                set
                {
                    this.ModelElement.SeqT = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the phsRef property
        /// </summary>
        private sealed class PhsRefProxy : ModelPropertyChange<ISEQ, IPhaseReference>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public PhsRefProxy(ISEQ modelElement) : 
                    base(modelElement, "phsRef")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IPhaseReference Value
            {
                get
                {
                    return this.ModelElement.PhsRef;
                }
                set
                {
                    this.ModelElement.PhsRef = value;
                }
            }
        }
    }
}

