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
    /// The default implementation of the ZGIL class
    /// </summary>
    [XmlNamespaceAttribute("http://www.transformation-tool-contest.eu/2017/smartGrids/substationStandard/grou" +
        "pZ")]
    [XmlNamespacePrefixAttribute("groupz")]
    [ModelRepresentationClassAttribute("http://www.transformation-tool-contest.eu/2017/smartGrids/substationStandard#//LN" +
        "Nodes/LNGroupZ/ZGIL")]
    public partial class ZGIL : TTC2017.SmartGrids.SubstationStandard.LNNodes.LNGroupZ.GroupZ, IZGIL, IModelElement
    {
        
        private static Lazy<ITypedElement> _opTmhReference = new Lazy<ITypedElement>(RetrieveOpTmhReference);
        
        /// <summary>
        /// The backing field for the OpTmh property
        /// </summary>
        private IINS _opTmh;
        
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
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new ZGILReferencedElementsCollection(this));
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
                            "Nodes/LNGroupZ/ZGIL")));
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
        
        private static ITypedElement RetrieveOpTmhReference()
        {
            return ((ITypedElement)(((ModelElement)(ZGIL.ClassInstance)).Resolve("OpTmh")));
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
                        "Nodes/LNGroupZ/ZGIL")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the ZGIL class
        /// </summary>
        public class ZGILReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private ZGIL _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public ZGILReferencedElementsCollection(ZGIL parent)
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
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.OpTmhChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.OpTmhChanged -= this.PropagateValueChanges;
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
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.OpTmh = null;
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
                return false;
            }
            
            /// <summary>
            /// Gets an enumerator that enumerates the collection
            /// </summary>
            /// <returns>A generic enumerator</returns>
            public override IEnumerator<IModelElement> GetEnumerator()
            {
                return Enumerable.Empty<IModelElement>().Concat(this._parent.OpTmh).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the OpTmh property
        /// </summary>
        private sealed class OpTmhProxy : ModelPropertyChange<IZGIL, IINS>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public OpTmhProxy(IZGIL modelElement) : 
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
    }
}

