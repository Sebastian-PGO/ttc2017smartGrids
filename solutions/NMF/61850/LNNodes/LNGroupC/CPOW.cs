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
using TTC2017.SmartGrids.SubstationStandard.LNNodes.DomainLNs;

namespace TTC2017.SmartGrids.SubstationStandard.LNNodes.LNGroupC
{
    
    
    /// <summary>
    /// The default implementation of the CPOW class
    /// </summary>
    [XmlNamespaceAttribute("http://www.transformation-tool-contest.eu/2017/smartGrids/substationStandard/grou" +
        "pC")]
    [XmlNamespacePrefixAttribute("groupc")]
    [ModelRepresentationClassAttribute("http://www.transformation-tool-contest.eu/2017/smartGrids/substationStandard#//LN" +
        "Nodes/LNGroupC/CPOW")]
    public partial class CPOW : TTC2017.SmartGrids.SubstationStandard.LNNodes.LNGroupC.GroupC, ICPOW, IModelElement
    {
        
        private static Lazy<ITypedElement> _tmExcReference = new Lazy<ITypedElement>(RetrieveTmExcReference);
        
        /// <summary>
        /// The backing field for the TmExc property
        /// </summary>
        private ISPS _tmExc;
        
        private static Lazy<ITypedElement> _strPOWReference = new Lazy<ITypedElement>(RetrieveStrPOWReference);
        
        /// <summary>
        /// The backing field for the StrPOW property
        /// </summary>
        private ISPS _strPOW;
        
        private static Lazy<ITypedElement> _opOpnReference = new Lazy<ITypedElement>(RetrieveOpOpnReference);
        
        /// <summary>
        /// The backing field for the OpOpn property
        /// </summary>
        private IACT _opOpn;
        
        private static Lazy<ITypedElement> _opClsReference = new Lazy<ITypedElement>(RetrieveOpClsReference);
        
        /// <summary>
        /// The backing field for the OpCls property
        /// </summary>
        private IACT _opCls;
        
        private static Lazy<ITypedElement> _maxDlTmmsReference = new Lazy<ITypedElement>(RetrieveMaxDlTmmsReference);
        
        /// <summary>
        /// The backing field for the MaxDlTmms property
        /// </summary>
        private IING _maxDlTmms;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The TmExc property
        /// </summary>
        [XmlAttributeAttribute(true)]
        public virtual ISPS TmExc
        {
            get
            {
                return this._tmExc;
            }
            set
            {
                if ((this._tmExc != value))
                {
                    ISPS old = this._tmExc;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnTmExcChanging(e);
                    this.OnPropertyChanging("TmExc", e, _tmExcReference);
                    this._tmExc = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetTmExc;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetTmExc;
                    }
                    this.OnTmExcChanged(e);
                    this.OnPropertyChanged("TmExc", e, _tmExcReference);
                }
            }
        }
        
        /// <summary>
        /// The StrPOW property
        /// </summary>
        [XmlAttributeAttribute(true)]
        public virtual ISPS StrPOW
        {
            get
            {
                return this._strPOW;
            }
            set
            {
                if ((this._strPOW != value))
                {
                    ISPS old = this._strPOW;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnStrPOWChanging(e);
                    this.OnPropertyChanging("StrPOW", e, _strPOWReference);
                    this._strPOW = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetStrPOW;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetStrPOW;
                    }
                    this.OnStrPOWChanged(e);
                    this.OnPropertyChanged("StrPOW", e, _strPOWReference);
                }
            }
        }
        
        /// <summary>
        /// The OpOpn property
        /// </summary>
        [XmlAttributeAttribute(true)]
        public virtual IACT OpOpn
        {
            get
            {
                return this._opOpn;
            }
            set
            {
                if ((this._opOpn != value))
                {
                    IACT old = this._opOpn;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnOpOpnChanging(e);
                    this.OnPropertyChanging("OpOpn", e, _opOpnReference);
                    this._opOpn = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetOpOpn;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetOpOpn;
                    }
                    this.OnOpOpnChanged(e);
                    this.OnPropertyChanged("OpOpn", e, _opOpnReference);
                }
            }
        }
        
        /// <summary>
        /// The OpCls property
        /// </summary>
        [XmlAttributeAttribute(true)]
        public virtual IACT OpCls
        {
            get
            {
                return this._opCls;
            }
            set
            {
                if ((this._opCls != value))
                {
                    IACT old = this._opCls;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnOpClsChanging(e);
                    this.OnPropertyChanging("OpCls", e, _opClsReference);
                    this._opCls = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetOpCls;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetOpCls;
                    }
                    this.OnOpClsChanged(e);
                    this.OnPropertyChanged("OpCls", e, _opClsReference);
                }
            }
        }
        
        /// <summary>
        /// The MaxDlTmms property
        /// </summary>
        [XmlAttributeAttribute(true)]
        public virtual IING MaxDlTmms
        {
            get
            {
                return this._maxDlTmms;
            }
            set
            {
                if ((this._maxDlTmms != value))
                {
                    IING old = this._maxDlTmms;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnMaxDlTmmsChanging(e);
                    this.OnPropertyChanging("MaxDlTmms", e, _maxDlTmmsReference);
                    this._maxDlTmms = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetMaxDlTmms;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetMaxDlTmms;
                    }
                    this.OnMaxDlTmmsChanged(e);
                    this.OnPropertyChanged("MaxDlTmms", e, _maxDlTmmsReference);
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
                return base.ReferencedElements.Concat(new CPOWReferencedElementsCollection(this));
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
                            "Nodes/LNGroupC/CPOW")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the TmExc property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> TmExcChanging;
        
        /// <summary>
        /// Gets fired when the TmExc property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> TmExcChanged;
        
        /// <summary>
        /// Gets fired before the StrPOW property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> StrPOWChanging;
        
        /// <summary>
        /// Gets fired when the StrPOW property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> StrPOWChanged;
        
        /// <summary>
        /// Gets fired before the OpOpn property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> OpOpnChanging;
        
        /// <summary>
        /// Gets fired when the OpOpn property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> OpOpnChanged;
        
        /// <summary>
        /// Gets fired before the OpCls property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> OpClsChanging;
        
        /// <summary>
        /// Gets fired when the OpCls property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> OpClsChanged;
        
        /// <summary>
        /// Gets fired before the MaxDlTmms property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> MaxDlTmmsChanging;
        
        /// <summary>
        /// Gets fired when the MaxDlTmms property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> MaxDlTmmsChanged;
        
        private static ITypedElement RetrieveTmExcReference()
        {
            return ((ITypedElement)(((ModelElement)(CPOW.ClassInstance)).Resolve("TmExc")));
        }
        
        /// <summary>
        /// Raises the TmExcChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnTmExcChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.TmExcChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the TmExcChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnTmExcChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.TmExcChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the TmExc property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetTmExc(object sender, System.EventArgs eventArgs)
        {
            this.TmExc = null;
        }
        
        private static ITypedElement RetrieveStrPOWReference()
        {
            return ((ITypedElement)(((ModelElement)(CPOW.ClassInstance)).Resolve("StrPOW")));
        }
        
        /// <summary>
        /// Raises the StrPOWChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnStrPOWChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.StrPOWChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the StrPOWChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnStrPOWChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.StrPOWChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the StrPOW property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetStrPOW(object sender, System.EventArgs eventArgs)
        {
            this.StrPOW = null;
        }
        
        private static ITypedElement RetrieveOpOpnReference()
        {
            return ((ITypedElement)(((ModelElement)(CPOW.ClassInstance)).Resolve("OpOpn")));
        }
        
        /// <summary>
        /// Raises the OpOpnChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnOpOpnChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.OpOpnChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the OpOpnChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnOpOpnChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.OpOpnChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the OpOpn property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetOpOpn(object sender, System.EventArgs eventArgs)
        {
            this.OpOpn = null;
        }
        
        private static ITypedElement RetrieveOpClsReference()
        {
            return ((ITypedElement)(((ModelElement)(CPOW.ClassInstance)).Resolve("OpCls")));
        }
        
        /// <summary>
        /// Raises the OpClsChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnOpClsChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.OpClsChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the OpClsChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnOpClsChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.OpClsChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the OpCls property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetOpCls(object sender, System.EventArgs eventArgs)
        {
            this.OpCls = null;
        }
        
        private static ITypedElement RetrieveMaxDlTmmsReference()
        {
            return ((ITypedElement)(((ModelElement)(CPOW.ClassInstance)).Resolve("MaxDlTmms")));
        }
        
        /// <summary>
        /// Raises the MaxDlTmmsChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnMaxDlTmmsChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.MaxDlTmmsChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the MaxDlTmmsChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnMaxDlTmmsChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.MaxDlTmmsChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the MaxDlTmms property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetMaxDlTmms(object sender, System.EventArgs eventArgs)
        {
            this.MaxDlTmms = null;
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "TMEXC"))
            {
                this.TmExc = ((ISPS)(value));
                return;
            }
            if ((feature == "STRPOW"))
            {
                this.StrPOW = ((ISPS)(value));
                return;
            }
            if ((feature == "OPOPN"))
            {
                this.OpOpn = ((IACT)(value));
                return;
            }
            if ((feature == "OPCLS"))
            {
                this.OpCls = ((IACT)(value));
                return;
            }
            if ((feature == "MAXDLTMMS"))
            {
                this.MaxDlTmms = ((IING)(value));
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
            if ((attribute == "TmExc"))
            {
                return new TmExcProxy(this);
            }
            if ((attribute == "StrPOW"))
            {
                return new StrPOWProxy(this);
            }
            if ((attribute == "OpOpn"))
            {
                return new OpOpnProxy(this);
            }
            if ((attribute == "OpCls"))
            {
                return new OpClsProxy(this);
            }
            if ((attribute == "MaxDlTmms"))
            {
                return new MaxDlTmmsProxy(this);
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
            if ((reference == "TmExc"))
            {
                return new TmExcProxy(this);
            }
            if ((reference == "StrPOW"))
            {
                return new StrPOWProxy(this);
            }
            if ((reference == "OpOpn"))
            {
                return new OpOpnProxy(this);
            }
            if ((reference == "OpCls"))
            {
                return new OpClsProxy(this);
            }
            if ((reference == "MaxDlTmms"))
            {
                return new MaxDlTmmsProxy(this);
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
                        "Nodes/LNGroupC/CPOW")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the CPOW class
        /// </summary>
        public class CPOWReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private CPOW _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public CPOWReferencedElementsCollection(CPOW parent)
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
                    if ((this._parent.TmExc != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.StrPOW != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.OpOpn != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.OpCls != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.MaxDlTmms != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.TmExcChanged += this.PropagateValueChanges;
                this._parent.StrPOWChanged += this.PropagateValueChanges;
                this._parent.OpOpnChanged += this.PropagateValueChanges;
                this._parent.OpClsChanged += this.PropagateValueChanges;
                this._parent.MaxDlTmmsChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.TmExcChanged -= this.PropagateValueChanges;
                this._parent.StrPOWChanged -= this.PropagateValueChanges;
                this._parent.OpOpnChanged -= this.PropagateValueChanges;
                this._parent.OpClsChanged -= this.PropagateValueChanges;
                this._parent.MaxDlTmmsChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.TmExc == null))
                {
                    ISPS tmExcCasted = item.As<ISPS>();
                    if ((tmExcCasted != null))
                    {
                        this._parent.TmExc = tmExcCasted;
                        return;
                    }
                }
                if ((this._parent.StrPOW == null))
                {
                    ISPS strPOWCasted = item.As<ISPS>();
                    if ((strPOWCasted != null))
                    {
                        this._parent.StrPOW = strPOWCasted;
                        return;
                    }
                }
                if ((this._parent.OpOpn == null))
                {
                    IACT opOpnCasted = item.As<IACT>();
                    if ((opOpnCasted != null))
                    {
                        this._parent.OpOpn = opOpnCasted;
                        return;
                    }
                }
                if ((this._parent.OpCls == null))
                {
                    IACT opClsCasted = item.As<IACT>();
                    if ((opClsCasted != null))
                    {
                        this._parent.OpCls = opClsCasted;
                        return;
                    }
                }
                if ((this._parent.MaxDlTmms == null))
                {
                    IING maxDlTmmsCasted = item.As<IING>();
                    if ((maxDlTmmsCasted != null))
                    {
                        this._parent.MaxDlTmms = maxDlTmmsCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.TmExc = null;
                this._parent.StrPOW = null;
                this._parent.OpOpn = null;
                this._parent.OpCls = null;
                this._parent.MaxDlTmms = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.TmExc))
                {
                    return true;
                }
                if ((item == this._parent.StrPOW))
                {
                    return true;
                }
                if ((item == this._parent.OpOpn))
                {
                    return true;
                }
                if ((item == this._parent.OpCls))
                {
                    return true;
                }
                if ((item == this._parent.MaxDlTmms))
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
                if ((this._parent.TmExc != null))
                {
                    array[arrayIndex] = this._parent.TmExc;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.StrPOW != null))
                {
                    array[arrayIndex] = this._parent.StrPOW;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.OpOpn != null))
                {
                    array[arrayIndex] = this._parent.OpOpn;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.OpCls != null))
                {
                    array[arrayIndex] = this._parent.OpCls;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.MaxDlTmms != null))
                {
                    array[arrayIndex] = this._parent.MaxDlTmms;
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
                if ((this._parent.TmExc == item))
                {
                    this._parent.TmExc = null;
                    return true;
                }
                if ((this._parent.StrPOW == item))
                {
                    this._parent.StrPOW = null;
                    return true;
                }
                if ((this._parent.OpOpn == item))
                {
                    this._parent.OpOpn = null;
                    return true;
                }
                if ((this._parent.OpCls == item))
                {
                    this._parent.OpCls = null;
                    return true;
                }
                if ((this._parent.MaxDlTmms == item))
                {
                    this._parent.MaxDlTmms = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.TmExc).Concat(this._parent.StrPOW).Concat(this._parent.OpOpn).Concat(this._parent.OpCls).Concat(this._parent.MaxDlTmms).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the TmExc property
        /// </summary>
        private sealed class TmExcProxy : ModelPropertyChange<ICPOW, ISPS>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public TmExcProxy(ICPOW modelElement) : 
                    base(modelElement, "TmExc")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override ISPS Value
            {
                get
                {
                    return this.ModelElement.TmExc;
                }
                set
                {
                    this.ModelElement.TmExc = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the StrPOW property
        /// </summary>
        private sealed class StrPOWProxy : ModelPropertyChange<ICPOW, ISPS>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public StrPOWProxy(ICPOW modelElement) : 
                    base(modelElement, "StrPOW")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override ISPS Value
            {
                get
                {
                    return this.ModelElement.StrPOW;
                }
                set
                {
                    this.ModelElement.StrPOW = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the OpOpn property
        /// </summary>
        private sealed class OpOpnProxy : ModelPropertyChange<ICPOW, IACT>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public OpOpnProxy(ICPOW modelElement) : 
                    base(modelElement, "OpOpn")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IACT Value
            {
                get
                {
                    return this.ModelElement.OpOpn;
                }
                set
                {
                    this.ModelElement.OpOpn = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the OpCls property
        /// </summary>
        private sealed class OpClsProxy : ModelPropertyChange<ICPOW, IACT>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public OpClsProxy(ICPOW modelElement) : 
                    base(modelElement, "OpCls")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IACT Value
            {
                get
                {
                    return this.ModelElement.OpCls;
                }
                set
                {
                    this.ModelElement.OpCls = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the MaxDlTmms property
        /// </summary>
        private sealed class MaxDlTmmsProxy : ModelPropertyChange<ICPOW, IING>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public MaxDlTmmsProxy(ICPOW modelElement) : 
                    base(modelElement, "MaxDlTmms")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IING Value
            {
                get
                {
                    return this.ModelElement.MaxDlTmms;
                }
                set
                {
                    this.ModelElement.MaxDlTmms = value;
                }
            }
        }
    }
}

