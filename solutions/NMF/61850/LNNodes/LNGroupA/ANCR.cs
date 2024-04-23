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

namespace TTC2017.SmartGrids.SubstationStandard.LNNodes.LNGroupA
{
    
    
    /// <summary>
    /// The default implementation of the ANCR class
    /// </summary>
    [XmlNamespaceAttribute("http://www.transformation-tool-contest.eu/2017/smartGrids/substationStandard/grou" +
        "pA")]
    [XmlNamespacePrefixAttribute("groupa")]
    [ModelRepresentationClassAttribute("http://www.transformation-tool-contest.eu/2017/smartGrids/substationStandard#//LN" +
        "Nodes/LNGroupA/ANCR")]
    public partial class ANCR : TTC2017.SmartGrids.SubstationStandard.LNNodes.LNGroupA.GroupA, IANCR, IModelElement
    {
        
        private static Lazy<ITypedElement> _tapChgReference = new Lazy<ITypedElement>(RetrieveTapChgReference);
        
        /// <summary>
        /// The backing field for the TapChg property
        /// </summary>
        private IBSC _tapChg;
        
        private static Lazy<ITypedElement> _rColReference = new Lazy<ITypedElement>(RetrieveRColReference);
        
        /// <summary>
        /// The backing field for the RCol property
        /// </summary>
        private ISPC _rCol;
        
        private static Lazy<ITypedElement> _lColReference = new Lazy<ITypedElement>(RetrieveLColReference);
        
        /// <summary>
        /// The backing field for the LCol property
        /// </summary>
        private ISPC _lCol;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The TapChg property
        /// </summary>
        [XmlAttributeAttribute(true)]
        public virtual IBSC TapChg
        {
            get
            {
                return this._tapChg;
            }
            set
            {
                if ((this._tapChg != value))
                {
                    IBSC old = this._tapChg;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnTapChgChanging(e);
                    this.OnPropertyChanging("TapChg", e, _tapChgReference);
                    this._tapChg = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetTapChg;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetTapChg;
                    }
                    this.OnTapChgChanged(e);
                    this.OnPropertyChanged("TapChg", e, _tapChgReference);
                }
            }
        }
        
        /// <summary>
        /// The RCol property
        /// </summary>
        [XmlAttributeAttribute(true)]
        public virtual ISPC RCol
        {
            get
            {
                return this._rCol;
            }
            set
            {
                if ((this._rCol != value))
                {
                    ISPC old = this._rCol;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnRColChanging(e);
                    this.OnPropertyChanging("RCol", e, _rColReference);
                    this._rCol = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetRCol;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetRCol;
                    }
                    this.OnRColChanged(e);
                    this.OnPropertyChanged("RCol", e, _rColReference);
                }
            }
        }
        
        /// <summary>
        /// The LCol property
        /// </summary>
        [XmlAttributeAttribute(true)]
        public virtual ISPC LCol
        {
            get
            {
                return this._lCol;
            }
            set
            {
                if ((this._lCol != value))
                {
                    ISPC old = this._lCol;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnLColChanging(e);
                    this.OnPropertyChanging("LCol", e, _lColReference);
                    this._lCol = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetLCol;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetLCol;
                    }
                    this.OnLColChanged(e);
                    this.OnPropertyChanged("LCol", e, _lColReference);
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
                return base.ReferencedElements.Concat(new ANCRReferencedElementsCollection(this));
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
                            "Nodes/LNGroupA/ANCR")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the TapChg property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> TapChgChanging;
        
        /// <summary>
        /// Gets fired when the TapChg property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> TapChgChanged;
        
        /// <summary>
        /// Gets fired before the RCol property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> RColChanging;
        
        /// <summary>
        /// Gets fired when the RCol property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> RColChanged;
        
        /// <summary>
        /// Gets fired before the LCol property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> LColChanging;
        
        /// <summary>
        /// Gets fired when the LCol property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> LColChanged;
        
        private static ITypedElement RetrieveTapChgReference()
        {
            return ((ITypedElement)(((ModelElement)(ANCR.ClassInstance)).Resolve("TapChg")));
        }
        
        /// <summary>
        /// Raises the TapChgChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnTapChgChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.TapChgChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the TapChgChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnTapChgChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.TapChgChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the TapChg property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetTapChg(object sender, System.EventArgs eventArgs)
        {
            this.TapChg = null;
        }
        
        private static ITypedElement RetrieveRColReference()
        {
            return ((ITypedElement)(((ModelElement)(ANCR.ClassInstance)).Resolve("RCol")));
        }
        
        /// <summary>
        /// Raises the RColChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnRColChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.RColChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the RColChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnRColChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.RColChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the RCol property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetRCol(object sender, System.EventArgs eventArgs)
        {
            this.RCol = null;
        }
        
        private static ITypedElement RetrieveLColReference()
        {
            return ((ITypedElement)(((ModelElement)(ANCR.ClassInstance)).Resolve("LCol")));
        }
        
        /// <summary>
        /// Raises the LColChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnLColChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.LColChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the LColChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnLColChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.LColChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the LCol property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetLCol(object sender, System.EventArgs eventArgs)
        {
            this.LCol = null;
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "TAPCHG"))
            {
                this.TapChg = ((IBSC)(value));
                return;
            }
            if ((feature == "RCOL"))
            {
                this.RCol = ((ISPC)(value));
                return;
            }
            if ((feature == "LCOL"))
            {
                this.LCol = ((ISPC)(value));
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
            if ((attribute == "TapChg"))
            {
                return new TapChgProxy(this);
            }
            if ((attribute == "RCol"))
            {
                return new RColProxy(this);
            }
            if ((attribute == "LCol"))
            {
                return new LColProxy(this);
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
            if ((reference == "TapChg"))
            {
                return new TapChgProxy(this);
            }
            if ((reference == "RCol"))
            {
                return new RColProxy(this);
            }
            if ((reference == "LCol"))
            {
                return new LColProxy(this);
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
                        "Nodes/LNGroupA/ANCR")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the ANCR class
        /// </summary>
        public class ANCRReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private ANCR _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public ANCRReferencedElementsCollection(ANCR parent)
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
                    if ((this._parent.TapChg != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.RCol != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.LCol != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.TapChgChanged += this.PropagateValueChanges;
                this._parent.RColChanged += this.PropagateValueChanges;
                this._parent.LColChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.TapChgChanged -= this.PropagateValueChanges;
                this._parent.RColChanged -= this.PropagateValueChanges;
                this._parent.LColChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.TapChg == null))
                {
                    IBSC tapChgCasted = item.As<IBSC>();
                    if ((tapChgCasted != null))
                    {
                        this._parent.TapChg = tapChgCasted;
                        return;
                    }
                }
                if ((this._parent.RCol == null))
                {
                    ISPC rColCasted = item.As<ISPC>();
                    if ((rColCasted != null))
                    {
                        this._parent.RCol = rColCasted;
                        return;
                    }
                }
                if ((this._parent.LCol == null))
                {
                    ISPC lColCasted = item.As<ISPC>();
                    if ((lColCasted != null))
                    {
                        this._parent.LCol = lColCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.TapChg = null;
                this._parent.RCol = null;
                this._parent.LCol = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.TapChg))
                {
                    return true;
                }
                if ((item == this._parent.RCol))
                {
                    return true;
                }
                if ((item == this._parent.LCol))
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
                if ((this._parent.TapChg != null))
                {
                    array[arrayIndex] = this._parent.TapChg;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.RCol != null))
                {
                    array[arrayIndex] = this._parent.RCol;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.LCol != null))
                {
                    array[arrayIndex] = this._parent.LCol;
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
                if ((this._parent.TapChg == item))
                {
                    this._parent.TapChg = null;
                    return true;
                }
                if ((this._parent.RCol == item))
                {
                    this._parent.RCol = null;
                    return true;
                }
                if ((this._parent.LCol == item))
                {
                    this._parent.LCol = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.TapChg).Concat(this._parent.RCol).Concat(this._parent.LCol).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the TapChg property
        /// </summary>
        private sealed class TapChgProxy : ModelPropertyChange<IANCR, IBSC>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public TapChgProxy(IANCR modelElement) : 
                    base(modelElement, "TapChg")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IBSC Value
            {
                get
                {
                    return this.ModelElement.TapChg;
                }
                set
                {
                    this.ModelElement.TapChg = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the RCol property
        /// </summary>
        private sealed class RColProxy : ModelPropertyChange<IANCR, ISPC>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public RColProxy(IANCR modelElement) : 
                    base(modelElement, "RCol")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override ISPC Value
            {
                get
                {
                    return this.ModelElement.RCol;
                }
                set
                {
                    this.ModelElement.RCol = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the LCol property
        /// </summary>
        private sealed class LColProxy : ModelPropertyChange<IANCR, ISPC>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public LColProxy(IANCR modelElement) : 
                    base(modelElement, "LCol")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override ISPC Value
            {
                get
                {
                    return this.ModelElement.LCol;
                }
                set
                {
                    this.ModelElement.LCol = value;
                }
            }
        }
    }
}

