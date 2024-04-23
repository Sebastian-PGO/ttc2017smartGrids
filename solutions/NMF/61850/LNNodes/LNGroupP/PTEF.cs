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

namespace TTC2017.SmartGrids.SubstationStandard.LNNodes.LNGroupP
{
    
    
    /// <summary>
    /// The default implementation of the PTEF class
    /// </summary>
    [XmlNamespaceAttribute("http://www.transformation-tool-contest.eu/2017/smartGrids/substationStandard/grou" +
        "pP")]
    [XmlNamespacePrefixAttribute("groupP")]
    [ModelRepresentationClassAttribute("http://www.transformation-tool-contest.eu/2017/smartGrids/substationStandard#//LN" +
        "Nodes/LNGroupP/PTEF")]
    public partial class PTEF : TTC2017.SmartGrids.SubstationStandard.LNNodes.LNGroupP.GroupP, IPTEF, IModelElement
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
        
        private static Lazy<ITypedElement> _gndStrReference = new Lazy<ITypedElement>(RetrieveGndStrReference);
        
        /// <summary>
        /// The backing field for the GndStr property
        /// </summary>
        private IASG _gndStr;
        
        private static Lazy<ITypedElement> _dirModReference = new Lazy<ITypedElement>(RetrieveDirModReference);
        
        /// <summary>
        /// The backing field for the DirMod property
        /// </summary>
        private IING _dirMod;
        
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
        /// The GndStr property
        /// </summary>
        [XmlAttributeAttribute(true)]
        public virtual IASG GndStr
        {
            get
            {
                return this._gndStr;
            }
            set
            {
                if ((this._gndStr != value))
                {
                    IASG old = this._gndStr;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnGndStrChanging(e);
                    this.OnPropertyChanging("GndStr", e, _gndStrReference);
                    this._gndStr = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetGndStr;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetGndStr;
                    }
                    this.OnGndStrChanged(e);
                    this.OnPropertyChanged("GndStr", e, _gndStrReference);
                }
            }
        }
        
        /// <summary>
        /// The DirMod property
        /// </summary>
        [XmlAttributeAttribute(true)]
        public virtual IING DirMod
        {
            get
            {
                return this._dirMod;
            }
            set
            {
                if ((this._dirMod != value))
                {
                    IING old = this._dirMod;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnDirModChanging(e);
                    this.OnPropertyChanging("DirMod", e, _dirModReference);
                    this._dirMod = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetDirMod;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetDirMod;
                    }
                    this.OnDirModChanged(e);
                    this.OnPropertyChanged("DirMod", e, _dirModReference);
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
                return base.ReferencedElements.Concat(new PTEFReferencedElementsCollection(this));
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
                            "Nodes/LNGroupP/PTEF")));
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
        /// Gets fired before the GndStr property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> GndStrChanging;
        
        /// <summary>
        /// Gets fired when the GndStr property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> GndStrChanged;
        
        /// <summary>
        /// Gets fired before the DirMod property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> DirModChanging;
        
        /// <summary>
        /// Gets fired when the DirMod property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> DirModChanged;
        
        private static ITypedElement RetrieveStrReference()
        {
            return ((ITypedElement)(((ModelElement)(PTEF.ClassInstance)).Resolve("Str")));
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
            return ((ITypedElement)(((ModelElement)(PTEF.ClassInstance)).Resolve("Op")));
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
        
        private static ITypedElement RetrieveGndStrReference()
        {
            return ((ITypedElement)(((ModelElement)(PTEF.ClassInstance)).Resolve("GndStr")));
        }
        
        /// <summary>
        /// Raises the GndStrChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnGndStrChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.GndStrChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the GndStrChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnGndStrChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.GndStrChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the GndStr property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetGndStr(object sender, System.EventArgs eventArgs)
        {
            this.GndStr = null;
        }
        
        private static ITypedElement RetrieveDirModReference()
        {
            return ((ITypedElement)(((ModelElement)(PTEF.ClassInstance)).Resolve("DirMod")));
        }
        
        /// <summary>
        /// Raises the DirModChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnDirModChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.DirModChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the DirModChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnDirModChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.DirModChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the DirMod property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetDirMod(object sender, System.EventArgs eventArgs)
        {
            this.DirMod = null;
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
            if ((feature == "GNDSTR"))
            {
                this.GndStr = ((IASG)(value));
                return;
            }
            if ((feature == "DIRMOD"))
            {
                this.DirMod = ((IING)(value));
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
            if ((attribute == "GndStr"))
            {
                return new GndStrProxy(this);
            }
            if ((attribute == "DirMod"))
            {
                return new DirModProxy(this);
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
            if ((reference == "GndStr"))
            {
                return new GndStrProxy(this);
            }
            if ((reference == "DirMod"))
            {
                return new DirModProxy(this);
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
                        "Nodes/LNGroupP/PTEF")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the PTEF class
        /// </summary>
        public class PTEFReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private PTEF _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public PTEFReferencedElementsCollection(PTEF parent)
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
                    if ((this._parent.GndStr != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.DirMod != null))
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
                this._parent.GndStrChanged += this.PropagateValueChanges;
                this._parent.DirModChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.StrChanged -= this.PropagateValueChanges;
                this._parent.OpChanged -= this.PropagateValueChanges;
                this._parent.GndStrChanged -= this.PropagateValueChanges;
                this._parent.DirModChanged -= this.PropagateValueChanges;
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
                if ((this._parent.GndStr == null))
                {
                    IASG gndStrCasted = item.As<IASG>();
                    if ((gndStrCasted != null))
                    {
                        this._parent.GndStr = gndStrCasted;
                        return;
                    }
                }
                if ((this._parent.DirMod == null))
                {
                    IING dirModCasted = item.As<IING>();
                    if ((dirModCasted != null))
                    {
                        this._parent.DirMod = dirModCasted;
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
                this._parent.GndStr = null;
                this._parent.DirMod = null;
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
                if ((item == this._parent.GndStr))
                {
                    return true;
                }
                if ((item == this._parent.DirMod))
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
                if ((this._parent.GndStr != null))
                {
                    array[arrayIndex] = this._parent.GndStr;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.DirMod != null))
                {
                    array[arrayIndex] = this._parent.DirMod;
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
                if ((this._parent.GndStr == item))
                {
                    this._parent.GndStr = null;
                    return true;
                }
                if ((this._parent.DirMod == item))
                {
                    this._parent.DirMod = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.Str).Concat(this._parent.Op).Concat(this._parent.GndStr).Concat(this._parent.DirMod).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the Str property
        /// </summary>
        private sealed class StrProxy : ModelPropertyChange<IPTEF, IACD>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public StrProxy(IPTEF modelElement) : 
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
        private sealed class OpProxy : ModelPropertyChange<IPTEF, IACT>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public OpProxy(IPTEF modelElement) : 
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
        /// Represents a proxy to represent an incremental access to the GndStr property
        /// </summary>
        private sealed class GndStrProxy : ModelPropertyChange<IPTEF, IASG>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public GndStrProxy(IPTEF modelElement) : 
                    base(modelElement, "GndStr")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IASG Value
            {
                get
                {
                    return this.ModelElement.GndStr;
                }
                set
                {
                    this.ModelElement.GndStr = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the DirMod property
        /// </summary>
        private sealed class DirModProxy : ModelPropertyChange<IPTEF, IING>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public DirModProxy(IPTEF modelElement) : 
                    base(modelElement, "DirMod")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IING Value
            {
                get
                {
                    return this.ModelElement.DirMod;
                }
                set
                {
                    this.ModelElement.DirMod = value;
                }
            }
        }
    }
}

