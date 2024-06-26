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
using TTC2017.SmartGrids.SubstationStandard.Dataclasses;
using TTC2017.SmartGrids.SubstationStandard.Enumerations;
using TTC2017.SmartGrids.SubstationStandard.LNNodes.DomainLNs;
using TTC2017.SmartGrids.SubstationStandard.LNNodes.LNGroupA;

namespace TTC2017.SmartGrids.SubstationStandard.LNNodes.LNGroupZ
{
    
    
    /// <summary>
    /// The default implementation of the ZMOT class
    /// </summary>
    [XmlNamespaceAttribute("http://www.transformation-tool-contest.eu/2017/smartGrids/substationStandard/grou" +
        "pZ")]
    [XmlNamespacePrefixAttribute("groupz")]
    [ModelRepresentationClassAttribute("http://www.transformation-tool-contest.eu/2017/smartGrids/substationStandard#//LN" +
        "Nodes/LNGroupZ/ZMOT")]
    public partial class ZMOT : TTC2017.SmartGrids.SubstationStandard.LNNodes.LNGroupZ.GroupZ, IZMOT, IModelElement
    {
        
        private static Lazy<ITypedElement> _opTmhReference = new Lazy<ITypedElement>(RetrieveOpTmhReference);
        
        /// <summary>
        /// The backing field for the OpTmh property
        /// </summary>
        private IINS _opTmh;
        
        private static Lazy<ITypedElement> _dExtReference = new Lazy<ITypedElement>(RetrieveDExtReference);
        
        /// <summary>
        /// The backing field for the DExt property
        /// </summary>
        private ISPC _dExt;
        
        private static Lazy<ITypedElement> _losOilReference = new Lazy<ITypedElement>(RetrieveLosOilReference);
        
        /// <summary>
        /// The backing field for the LosOil property
        /// </summary>
        private ISPS _losOil;
        
        private static Lazy<ITypedElement> _losVacReference = new Lazy<ITypedElement>(RetrieveLosVacReference);
        
        /// <summary>
        /// The backing field for the LosVac property
        /// </summary>
        private ISPS _losVac;
        
        private static Lazy<ITypedElement> _presAlmReference = new Lazy<ITypedElement>(RetrievePresAlmReference);
        
        /// <summary>
        /// The backing field for the PresAlm property
        /// </summary>
        private ISPS _presAlm;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The OpTmh property
        /// </summary>
        [XmlAttributeAttribute(true)]
        public virtual IINS OpTmh
        {
            get
            {
                return this._opTmh;
            }
            set
            {
                if ((this._opTmh != value))
                {
                    IINS old = this._opTmh;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnOpTmhChanging(e);
                    this.OnPropertyChanging("OpTmh", e, _opTmhReference);
                    this._opTmh = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetOpTmh;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetOpTmh;
                    }
                    this.OnOpTmhChanged(e);
                    this.OnPropertyChanged("OpTmh", e, _opTmhReference);
                }
            }
        }
        
        /// <summary>
        /// The DExt property
        /// </summary>
        [XmlAttributeAttribute(true)]
        public virtual ISPC DExt
        {
            get
            {
                return this._dExt;
            }
            set
            {
                if ((this._dExt != value))
                {
                    ISPC old = this._dExt;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnDExtChanging(e);
                    this.OnPropertyChanging("DExt", e, _dExtReference);
                    this._dExt = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetDExt;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetDExt;
                    }
                    this.OnDExtChanged(e);
                    this.OnPropertyChanged("DExt", e, _dExtReference);
                }
            }
        }
        
        /// <summary>
        /// The LosOil property
        /// </summary>
        [XmlAttributeAttribute(true)]
        public virtual ISPS LosOil
        {
            get
            {
                return this._losOil;
            }
            set
            {
                if ((this._losOil != value))
                {
                    ISPS old = this._losOil;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnLosOilChanging(e);
                    this.OnPropertyChanging("LosOil", e, _losOilReference);
                    this._losOil = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetLosOil;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetLosOil;
                    }
                    this.OnLosOilChanged(e);
                    this.OnPropertyChanged("LosOil", e, _losOilReference);
                }
            }
        }
        
        /// <summary>
        /// The LosVac property
        /// </summary>
        [XmlAttributeAttribute(true)]
        public virtual ISPS LosVac
        {
            get
            {
                return this._losVac;
            }
            set
            {
                if ((this._losVac != value))
                {
                    ISPS old = this._losVac;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnLosVacChanging(e);
                    this.OnPropertyChanging("LosVac", e, _losVacReference);
                    this._losVac = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetLosVac;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetLosVac;
                    }
                    this.OnLosVacChanged(e);
                    this.OnPropertyChanged("LosVac", e, _losVacReference);
                }
            }
        }
        
        /// <summary>
        /// The PresAlm property
        /// </summary>
        [XmlAttributeAttribute(true)]
        public virtual ISPS PresAlm
        {
            get
            {
                return this._presAlm;
            }
            set
            {
                if ((this._presAlm != value))
                {
                    ISPS old = this._presAlm;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnPresAlmChanging(e);
                    this.OnPropertyChanging("PresAlm", e, _presAlmReference);
                    this._presAlm = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetPresAlm;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetPresAlm;
                    }
                    this.OnPresAlmChanged(e);
                    this.OnPropertyChanged("PresAlm", e, _presAlmReference);
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
                return base.ReferencedElements.Concat(new ZMOTReferencedElementsCollection(this));
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
                            "Nodes/LNGroupZ/ZMOT")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the OpTmh property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> OpTmhChanging;
        
        /// <summary>
        /// Gets fired when the OpTmh property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> OpTmhChanged;
        
        /// <summary>
        /// Gets fired before the DExt property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> DExtChanging;
        
        /// <summary>
        /// Gets fired when the DExt property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> DExtChanged;
        
        /// <summary>
        /// Gets fired before the LosOil property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> LosOilChanging;
        
        /// <summary>
        /// Gets fired when the LosOil property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> LosOilChanged;
        
        /// <summary>
        /// Gets fired before the LosVac property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> LosVacChanging;
        
        /// <summary>
        /// Gets fired when the LosVac property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> LosVacChanged;
        
        /// <summary>
        /// Gets fired before the PresAlm property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> PresAlmChanging;
        
        /// <summary>
        /// Gets fired when the PresAlm property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> PresAlmChanged;
        
        private static ITypedElement RetrieveOpTmhReference()
        {
            return ((ITypedElement)(((ModelElement)(ZMOT.ClassInstance)).Resolve("OpTmh")));
        }
        
        /// <summary>
        /// Raises the OpTmhChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnOpTmhChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.OpTmhChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the OpTmhChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnOpTmhChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.OpTmhChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the OpTmh property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetOpTmh(object sender, System.EventArgs eventArgs)
        {
            this.OpTmh = null;
        }
        
        private static ITypedElement RetrieveDExtReference()
        {
            return ((ITypedElement)(((ModelElement)(ZMOT.ClassInstance)).Resolve("DExt")));
        }
        
        /// <summary>
        /// Raises the DExtChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnDExtChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.DExtChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the DExtChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnDExtChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.DExtChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the DExt property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetDExt(object sender, System.EventArgs eventArgs)
        {
            this.DExt = null;
        }
        
        private static ITypedElement RetrieveLosOilReference()
        {
            return ((ITypedElement)(((ModelElement)(ZMOT.ClassInstance)).Resolve("LosOil")));
        }
        
        /// <summary>
        /// Raises the LosOilChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnLosOilChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.LosOilChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the LosOilChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnLosOilChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.LosOilChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the LosOil property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetLosOil(object sender, System.EventArgs eventArgs)
        {
            this.LosOil = null;
        }
        
        private static ITypedElement RetrieveLosVacReference()
        {
            return ((ITypedElement)(((ModelElement)(ZMOT.ClassInstance)).Resolve("LosVac")));
        }
        
        /// <summary>
        /// Raises the LosVacChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnLosVacChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.LosVacChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the LosVacChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnLosVacChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.LosVacChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the LosVac property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetLosVac(object sender, System.EventArgs eventArgs)
        {
            this.LosVac = null;
        }
        
        private static ITypedElement RetrievePresAlmReference()
        {
            return ((ITypedElement)(((ModelElement)(ZMOT.ClassInstance)).Resolve("PresAlm")));
        }
        
        /// <summary>
        /// Raises the PresAlmChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnPresAlmChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.PresAlmChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the PresAlmChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnPresAlmChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.PresAlmChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the PresAlm property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetPresAlm(object sender, System.EventArgs eventArgs)
        {
            this.PresAlm = null;
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "OPTMH"))
            {
                this.OpTmh = ((IINS)(value));
                return;
            }
            if ((feature == "DEXT"))
            {
                this.DExt = ((ISPC)(value));
                return;
            }
            if ((feature == "LOSOIL"))
            {
                this.LosOil = ((ISPS)(value));
                return;
            }
            if ((feature == "LOSVAC"))
            {
                this.LosVac = ((ISPS)(value));
                return;
            }
            if ((feature == "PRESALM"))
            {
                this.PresAlm = ((ISPS)(value));
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
            if ((attribute == "OpTmh"))
            {
                return new OpTmhProxy(this);
            }
            if ((attribute == "DExt"))
            {
                return new DExtProxy(this);
            }
            if ((attribute == "LosOil"))
            {
                return new LosOilProxy(this);
            }
            if ((attribute == "LosVac"))
            {
                return new LosVacProxy(this);
            }
            if ((attribute == "PresAlm"))
            {
                return new PresAlmProxy(this);
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
            if ((reference == "OpTmh"))
            {
                return new OpTmhProxy(this);
            }
            if ((reference == "DExt"))
            {
                return new DExtProxy(this);
            }
            if ((reference == "LosOil"))
            {
                return new LosOilProxy(this);
            }
            if ((reference == "LosVac"))
            {
                return new LosVacProxy(this);
            }
            if ((reference == "PresAlm"))
            {
                return new PresAlmProxy(this);
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
                        "Nodes/LNGroupZ/ZMOT")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the ZMOT class
        /// </summary>
        public class ZMOTReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private ZMOT _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public ZMOTReferencedElementsCollection(ZMOT parent)
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
                    if ((this._parent.OpTmh != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.DExt != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.LosOil != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.LosVac != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.PresAlm != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.OpTmhChanged += this.PropagateValueChanges;
                this._parent.DExtChanged += this.PropagateValueChanges;
                this._parent.LosOilChanged += this.PropagateValueChanges;
                this._parent.LosVacChanged += this.PropagateValueChanges;
                this._parent.PresAlmChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.OpTmhChanged -= this.PropagateValueChanges;
                this._parent.DExtChanged -= this.PropagateValueChanges;
                this._parent.LosOilChanged -= this.PropagateValueChanges;
                this._parent.LosVacChanged -= this.PropagateValueChanges;
                this._parent.PresAlmChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.OpTmh == null))
                {
                    IINS opTmhCasted = item.As<IINS>();
                    if ((opTmhCasted != null))
                    {
                        this._parent.OpTmh = opTmhCasted;
                        return;
                    }
                }
                if ((this._parent.DExt == null))
                {
                    ISPC dExtCasted = item.As<ISPC>();
                    if ((dExtCasted != null))
                    {
                        this._parent.DExt = dExtCasted;
                        return;
                    }
                }
                if ((this._parent.LosOil == null))
                {
                    ISPS losOilCasted = item.As<ISPS>();
                    if ((losOilCasted != null))
                    {
                        this._parent.LosOil = losOilCasted;
                        return;
                    }
                }
                if ((this._parent.LosVac == null))
                {
                    ISPS losVacCasted = item.As<ISPS>();
                    if ((losVacCasted != null))
                    {
                        this._parent.LosVac = losVacCasted;
                        return;
                    }
                }
                if ((this._parent.PresAlm == null))
                {
                    ISPS presAlmCasted = item.As<ISPS>();
                    if ((presAlmCasted != null))
                    {
                        this._parent.PresAlm = presAlmCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.OpTmh = null;
                this._parent.DExt = null;
                this._parent.LosOil = null;
                this._parent.LosVac = null;
                this._parent.PresAlm = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.OpTmh))
                {
                    return true;
                }
                if ((item == this._parent.DExt))
                {
                    return true;
                }
                if ((item == this._parent.LosOil))
                {
                    return true;
                }
                if ((item == this._parent.LosVac))
                {
                    return true;
                }
                if ((item == this._parent.PresAlm))
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
                if ((this._parent.OpTmh != null))
                {
                    array[arrayIndex] = this._parent.OpTmh;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.DExt != null))
                {
                    array[arrayIndex] = this._parent.DExt;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.LosOil != null))
                {
                    array[arrayIndex] = this._parent.LosOil;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.LosVac != null))
                {
                    array[arrayIndex] = this._parent.LosVac;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.PresAlm != null))
                {
                    array[arrayIndex] = this._parent.PresAlm;
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
                if ((this._parent.OpTmh == item))
                {
                    this._parent.OpTmh = null;
                    return true;
                }
                if ((this._parent.DExt == item))
                {
                    this._parent.DExt = null;
                    return true;
                }
                if ((this._parent.LosOil == item))
                {
                    this._parent.LosOil = null;
                    return true;
                }
                if ((this._parent.LosVac == item))
                {
                    this._parent.LosVac = null;
                    return true;
                }
                if ((this._parent.PresAlm == item))
                {
                    this._parent.PresAlm = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.OpTmh).Concat(this._parent.DExt).Concat(this._parent.LosOil).Concat(this._parent.LosVac).Concat(this._parent.PresAlm).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the OpTmh property
        /// </summary>
        private sealed class OpTmhProxy : ModelPropertyChange<IZMOT, IINS>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public OpTmhProxy(IZMOT modelElement) : 
                    base(modelElement, "OpTmh")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IINS Value
            {
                get
                {
                    return this.ModelElement.OpTmh;
                }
                set
                {
                    this.ModelElement.OpTmh = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the DExt property
        /// </summary>
        private sealed class DExtProxy : ModelPropertyChange<IZMOT, ISPC>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public DExtProxy(IZMOT modelElement) : 
                    base(modelElement, "DExt")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override ISPC Value
            {
                get
                {
                    return this.ModelElement.DExt;
                }
                set
                {
                    this.ModelElement.DExt = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the LosOil property
        /// </summary>
        private sealed class LosOilProxy : ModelPropertyChange<IZMOT, ISPS>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public LosOilProxy(IZMOT modelElement) : 
                    base(modelElement, "LosOil")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override ISPS Value
            {
                get
                {
                    return this.ModelElement.LosOil;
                }
                set
                {
                    this.ModelElement.LosOil = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the LosVac property
        /// </summary>
        private sealed class LosVacProxy : ModelPropertyChange<IZMOT, ISPS>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public LosVacProxy(IZMOT modelElement) : 
                    base(modelElement, "LosVac")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override ISPS Value
            {
                get
                {
                    return this.ModelElement.LosVac;
                }
                set
                {
                    this.ModelElement.LosVac = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the PresAlm property
        /// </summary>
        private sealed class PresAlmProxy : ModelPropertyChange<IZMOT, ISPS>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public PresAlmProxy(IZMOT modelElement) : 
                    base(modelElement, "PresAlm")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override ISPS Value
            {
                get
                {
                    return this.ModelElement.PresAlm;
                }
                set
                {
                    this.ModelElement.PresAlm = value;
                }
            }
        }
    }
}

