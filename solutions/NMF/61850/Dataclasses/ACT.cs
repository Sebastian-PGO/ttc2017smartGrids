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
    /// The default implementation of the ACT class
    /// </summary>
    [XmlNamespaceAttribute("http://www.transformation-tool-contest.eu/2017/smartGrids/dataclasses")]
    [XmlNamespacePrefixAttribute("data")]
    [ModelRepresentationClassAttribute("http://www.transformation-tool-contest.eu/2017/smartGrids/substationStandard#//Da" +
        "taclasses/ACT")]
    public partial class ACT : ModelElement, IACT, IModelElement
    {
        
        /// <summary>
        /// The backing field for the General property
        /// </summary>
        private Nullable<bool> _general;
        
        private static Lazy<ITypedElement> _generalAttribute = new Lazy<ITypedElement>(RetrieveGeneralAttribute);
        
        /// <summary>
        /// The backing field for the PhsA property
        /// </summary>
        private Nullable<bool> _phsA;
        
        private static Lazy<ITypedElement> _phsAAttribute = new Lazy<ITypedElement>(RetrievePhsAAttribute);
        
        /// <summary>
        /// The backing field for the PhsB property
        /// </summary>
        private Nullable<bool> _phsB;
        
        private static Lazy<ITypedElement> _phsBAttribute = new Lazy<ITypedElement>(RetrievePhsBAttribute);
        
        /// <summary>
        /// The backing field for the PhsC property
        /// </summary>
        private Nullable<bool> _phsC;
        
        private static Lazy<ITypedElement> _phsCAttribute = new Lazy<ITypedElement>(RetrievePhsCAttribute);
        
        /// <summary>
        /// The backing field for the Neut property
        /// </summary>
        private Nullable<bool> _neut;
        
        private static Lazy<ITypedElement> _neutAttribute = new Lazy<ITypedElement>(RetrieveNeutAttribute);
        
        private static Lazy<ITypedElement> _qReference = new Lazy<ITypedElement>(RetrieveQReference);
        
        /// <summary>
        /// The backing field for the Q property
        /// </summary>
        private IQuality _q;
        
        private static Lazy<ITypedElement> _operTmReference = new Lazy<ITypedElement>(RetrieveOperTmReference);
        
        /// <summary>
        /// The backing field for the OperTm property
        /// </summary>
        private ITimeStamp _operTm;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The general property
        /// </summary>
        [XmlElementNameAttribute("general")]
        [XmlAttributeAttribute(true)]
        public virtual Nullable<bool> General
        {
            get
            {
                return this._general;
            }
            set
            {
                if ((this._general != value))
                {
                    Nullable<bool> old = this._general;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnGeneralChanging(e);
                    this.OnPropertyChanging("General", e, _generalAttribute);
                    this._general = value;
                    this.OnGeneralChanged(e);
                    this.OnPropertyChanged("General", e, _generalAttribute);
                }
            }
        }
        
        /// <summary>
        /// The phsA property
        /// </summary>
        [XmlElementNameAttribute("phsA")]
        [XmlAttributeAttribute(true)]
        public virtual Nullable<bool> PhsA
        {
            get
            {
                return this._phsA;
            }
            set
            {
                if ((this._phsA != value))
                {
                    Nullable<bool> old = this._phsA;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnPhsAChanging(e);
                    this.OnPropertyChanging("PhsA", e, _phsAAttribute);
                    this._phsA = value;
                    this.OnPhsAChanged(e);
                    this.OnPropertyChanged("PhsA", e, _phsAAttribute);
                }
            }
        }
        
        /// <summary>
        /// The phsB property
        /// </summary>
        [XmlElementNameAttribute("phsB")]
        [XmlAttributeAttribute(true)]
        public virtual Nullable<bool> PhsB
        {
            get
            {
                return this._phsB;
            }
            set
            {
                if ((this._phsB != value))
                {
                    Nullable<bool> old = this._phsB;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnPhsBChanging(e);
                    this.OnPropertyChanging("PhsB", e, _phsBAttribute);
                    this._phsB = value;
                    this.OnPhsBChanged(e);
                    this.OnPropertyChanged("PhsB", e, _phsBAttribute);
                }
            }
        }
        
        /// <summary>
        /// The phsC property
        /// </summary>
        [XmlElementNameAttribute("phsC")]
        [XmlAttributeAttribute(true)]
        public virtual Nullable<bool> PhsC
        {
            get
            {
                return this._phsC;
            }
            set
            {
                if ((this._phsC != value))
                {
                    Nullable<bool> old = this._phsC;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnPhsCChanging(e);
                    this.OnPropertyChanging("PhsC", e, _phsCAttribute);
                    this._phsC = value;
                    this.OnPhsCChanged(e);
                    this.OnPropertyChanged("PhsC", e, _phsCAttribute);
                }
            }
        }
        
        /// <summary>
        /// The neut property
        /// </summary>
        [XmlElementNameAttribute("neut")]
        [XmlAttributeAttribute(true)]
        public virtual Nullable<bool> Neut
        {
            get
            {
                return this._neut;
            }
            set
            {
                if ((this._neut != value))
                {
                    Nullable<bool> old = this._neut;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnNeutChanging(e);
                    this.OnPropertyChanging("Neut", e, _neutAttribute);
                    this._neut = value;
                    this.OnNeutChanged(e);
                    this.OnPropertyChanged("Neut", e, _neutAttribute);
                }
            }
        }
        
        /// <summary>
        /// The q property
        /// </summary>
        [XmlElementNameAttribute("q")]
        [XmlAttributeAttribute(true)]
        public virtual IQuality Q
        {
            get
            {
                return this._q;
            }
            set
            {
                if ((this._q != value))
                {
                    IQuality old = this._q;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnQChanging(e);
                    this.OnPropertyChanging("Q", e, _qReference);
                    this._q = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetQ;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetQ;
                    }
                    this.OnQChanged(e);
                    this.OnPropertyChanged("Q", e, _qReference);
                }
            }
        }
        
        /// <summary>
        /// The operTm property
        /// </summary>
        [XmlElementNameAttribute("operTm")]
        [XmlAttributeAttribute(true)]
        public virtual ITimeStamp OperTm
        {
            get
            {
                return this._operTm;
            }
            set
            {
                if ((this._operTm != value))
                {
                    ITimeStamp old = this._operTm;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnOperTmChanging(e);
                    this.OnPropertyChanging("OperTm", e, _operTmReference);
                    this._operTm = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetOperTm;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetOperTm;
                    }
                    this.OnOperTmChanged(e);
                    this.OnPropertyChanged("OperTm", e, _operTmReference);
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
                return base.ReferencedElements.Concat(new ACTReferencedElementsCollection(this));
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
                            "taclasses/ACT")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the General property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> GeneralChanging;
        
        /// <summary>
        /// Gets fired when the General property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> GeneralChanged;
        
        /// <summary>
        /// Gets fired before the PhsA property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> PhsAChanging;
        
        /// <summary>
        /// Gets fired when the PhsA property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> PhsAChanged;
        
        /// <summary>
        /// Gets fired before the PhsB property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> PhsBChanging;
        
        /// <summary>
        /// Gets fired when the PhsB property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> PhsBChanged;
        
        /// <summary>
        /// Gets fired before the PhsC property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> PhsCChanging;
        
        /// <summary>
        /// Gets fired when the PhsC property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> PhsCChanged;
        
        /// <summary>
        /// Gets fired before the Neut property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> NeutChanging;
        
        /// <summary>
        /// Gets fired when the Neut property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> NeutChanged;
        
        /// <summary>
        /// Gets fired before the Q property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> QChanging;
        
        /// <summary>
        /// Gets fired when the Q property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> QChanged;
        
        /// <summary>
        /// Gets fired before the OperTm property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> OperTmChanging;
        
        /// <summary>
        /// Gets fired when the OperTm property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> OperTmChanged;
        
        private static ITypedElement RetrieveGeneralAttribute()
        {
            return ((ITypedElement)(((ModelElement)(ACT.ClassInstance)).Resolve("general")));
        }
        
        /// <summary>
        /// Raises the GeneralChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnGeneralChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.GeneralChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the GeneralChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnGeneralChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.GeneralChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrievePhsAAttribute()
        {
            return ((ITypedElement)(((ModelElement)(ACT.ClassInstance)).Resolve("phsA")));
        }
        
        /// <summary>
        /// Raises the PhsAChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnPhsAChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.PhsAChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the PhsAChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnPhsAChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.PhsAChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrievePhsBAttribute()
        {
            return ((ITypedElement)(((ModelElement)(ACT.ClassInstance)).Resolve("phsB")));
        }
        
        /// <summary>
        /// Raises the PhsBChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnPhsBChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.PhsBChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the PhsBChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnPhsBChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.PhsBChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrievePhsCAttribute()
        {
            return ((ITypedElement)(((ModelElement)(ACT.ClassInstance)).Resolve("phsC")));
        }
        
        /// <summary>
        /// Raises the PhsCChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnPhsCChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.PhsCChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the PhsCChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnPhsCChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.PhsCChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveNeutAttribute()
        {
            return ((ITypedElement)(((ModelElement)(ACT.ClassInstance)).Resolve("neut")));
        }
        
        /// <summary>
        /// Raises the NeutChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnNeutChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.NeutChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the NeutChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnNeutChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.NeutChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveQReference()
        {
            return ((ITypedElement)(((ModelElement)(ACT.ClassInstance)).Resolve("q")));
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
        
        /// <summary>
        /// Handles the event that the Q property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetQ(object sender, System.EventArgs eventArgs)
        {
            this.Q = null;
        }
        
        private static ITypedElement RetrieveOperTmReference()
        {
            return ((ITypedElement)(((ModelElement)(ACT.ClassInstance)).Resolve("operTm")));
        }
        
        /// <summary>
        /// Raises the OperTmChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnOperTmChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.OperTmChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the OperTmChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnOperTmChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.OperTmChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the OperTm property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetOperTm(object sender, System.EventArgs eventArgs)
        {
            this.OperTm = null;
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "GENERAL"))
            {
                return this.General;
            }
            if ((attribute == "PHSA"))
            {
                return this.PhsA;
            }
            if ((attribute == "PHSB"))
            {
                return this.PhsB;
            }
            if ((attribute == "PHSC"))
            {
                return this.PhsC;
            }
            if ((attribute == "NEUT"))
            {
                return this.Neut;
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
            if ((feature == "Q"))
            {
                this.Q = ((IQuality)(value));
                return;
            }
            if ((feature == "OPERTM"))
            {
                this.OperTm = ((ITimeStamp)(value));
                return;
            }
            if ((feature == "GENERAL"))
            {
                this.General = ((bool)(value));
                return;
            }
            if ((feature == "PHSA"))
            {
                this.PhsA = ((bool)(value));
                return;
            }
            if ((feature == "PHSB"))
            {
                this.PhsB = ((bool)(value));
                return;
            }
            if ((feature == "PHSC"))
            {
                this.PhsC = ((bool)(value));
                return;
            }
            if ((feature == "NEUT"))
            {
                this.Neut = ((bool)(value));
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
            if ((attribute == "Q"))
            {
                return new QProxy(this);
            }
            if ((attribute == "OperTm"))
            {
                return new OperTmProxy(this);
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
            if ((reference == "Q"))
            {
                return new QProxy(this);
            }
            if ((reference == "OperTm"))
            {
                return new OperTmProxy(this);
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
                        "taclasses/ACT")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the ACT class
        /// </summary>
        public class ACTReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private ACT _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public ACTReferencedElementsCollection(ACT parent)
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
                    if ((this._parent.Q != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.OperTm != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.QChanged += this.PropagateValueChanges;
                this._parent.OperTmChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.QChanged -= this.PropagateValueChanges;
                this._parent.OperTmChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.Q == null))
                {
                    IQuality qCasted = item.As<IQuality>();
                    if ((qCasted != null))
                    {
                        this._parent.Q = qCasted;
                        return;
                    }
                }
                if ((this._parent.OperTm == null))
                {
                    ITimeStamp operTmCasted = item.As<ITimeStamp>();
                    if ((operTmCasted != null))
                    {
                        this._parent.OperTm = operTmCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.Q = null;
                this._parent.OperTm = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.Q))
                {
                    return true;
                }
                if ((item == this._parent.OperTm))
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
                if ((this._parent.Q != null))
                {
                    array[arrayIndex] = this._parent.Q;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.OperTm != null))
                {
                    array[arrayIndex] = this._parent.OperTm;
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
                if ((this._parent.Q == item))
                {
                    this._parent.Q = null;
                    return true;
                }
                if ((this._parent.OperTm == item))
                {
                    this._parent.OperTm = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.Q).Concat(this._parent.OperTm).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the general property
        /// </summary>
        private sealed class GeneralProxy : ModelPropertyChange<IACT, Nullable<bool>>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public GeneralProxy(IACT modelElement) : 
                    base(modelElement, "general")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override Nullable<bool> Value
            {
                get
                {
                    return this.ModelElement.General;
                }
                set
                {
                    this.ModelElement.General = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the phsA property
        /// </summary>
        private sealed class PhsAProxy : ModelPropertyChange<IACT, Nullable<bool>>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public PhsAProxy(IACT modelElement) : 
                    base(modelElement, "phsA")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override Nullable<bool> Value
            {
                get
                {
                    return this.ModelElement.PhsA;
                }
                set
                {
                    this.ModelElement.PhsA = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the phsB property
        /// </summary>
        private sealed class PhsBProxy : ModelPropertyChange<IACT, Nullable<bool>>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public PhsBProxy(IACT modelElement) : 
                    base(modelElement, "phsB")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override Nullable<bool> Value
            {
                get
                {
                    return this.ModelElement.PhsB;
                }
                set
                {
                    this.ModelElement.PhsB = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the phsC property
        /// </summary>
        private sealed class PhsCProxy : ModelPropertyChange<IACT, Nullable<bool>>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public PhsCProxy(IACT modelElement) : 
                    base(modelElement, "phsC")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override Nullable<bool> Value
            {
                get
                {
                    return this.ModelElement.PhsC;
                }
                set
                {
                    this.ModelElement.PhsC = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the neut property
        /// </summary>
        private sealed class NeutProxy : ModelPropertyChange<IACT, Nullable<bool>>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public NeutProxy(IACT modelElement) : 
                    base(modelElement, "neut")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override Nullable<bool> Value
            {
                get
                {
                    return this.ModelElement.Neut;
                }
                set
                {
                    this.ModelElement.Neut = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the q property
        /// </summary>
        private sealed class QProxy : ModelPropertyChange<IACT, IQuality>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public QProxy(IACT modelElement) : 
                    base(modelElement, "q")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IQuality Value
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
        /// Represents a proxy to represent an incremental access to the operTm property
        /// </summary>
        private sealed class OperTmProxy : ModelPropertyChange<IACT, ITimeStamp>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public OperTmProxy(IACT modelElement) : 
                    base(modelElement, "operTm")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override ITimeStamp Value
            {
                get
                {
                    return this.ModelElement.OperTm;
                }
                set
                {
                    this.ModelElement.OperTm = value;
                }
            }
        }
    }
}

