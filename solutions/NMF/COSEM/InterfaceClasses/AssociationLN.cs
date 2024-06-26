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
using TTC2017.SmartGrids.COSEM;
using TTC2017.SmartGrids.COSEM.Datatypes;

namespace TTC2017.SmartGrids.COSEM.InterfaceClasses
{
    
    
    /// <summary>
    /// The default implementation of the AssociationLN class
    /// </summary>
    [XmlNamespaceAttribute("interface")]
    [XmlNamespacePrefixAttribute("inter")]
    [ModelRepresentationClassAttribute("http://www.transformation-tool-contest.eu/2017/smartGrids/cosem#//InterfaceClasse" +
        "s/AssociationLN")]
    public partial class AssociationLN : Base, IAssociationLN, IModelElement
    {
        
        private static Lazy<ITypedElement> _aAReference = new Lazy<ITypedElement>(RetrieveAAReference);
        
        /// <summary>
        /// The backing field for the AA property
        /// </summary>
        private IApplicationAssociation _aA;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The AA property
        /// </summary>
        [XmlAttributeAttribute(true)]
        public virtual IApplicationAssociation AA
        {
            get
            {
                return this._aA;
            }
            set
            {
                if ((this._aA != value))
                {
                    IApplicationAssociation old = this._aA;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnAAChanging(e);
                    this.OnPropertyChanging("AA", e, _aAReference);
                    this._aA = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetAA;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetAA;
                    }
                    this.OnAAChanged(e);
                    this.OnPropertyChanged("AA", e, _aAReference);
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
                return base.ReferencedElements.Concat(new AssociationLNReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://www.transformation-tool-contest.eu/2017/smartGrids/cosem#//InterfaceClasse" +
                            "s/AssociationLN")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the AA property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> AAChanging;
        
        /// <summary>
        /// Gets fired when the AA property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> AAChanged;
        
        private static ITypedElement RetrieveAAReference()
        {
            return ((ITypedElement)(((ModelElement)(AssociationLN.ClassInstance)).Resolve("AA")));
        }
        
        /// <summary>
        /// Raises the AAChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnAAChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.AAChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the AAChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnAAChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.AAChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the AA property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetAA(object sender, System.EventArgs eventArgs)
        {
            this.AA = null;
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "AA"))
            {
                this.AA = ((IApplicationAssociation)(value));
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
            if ((attribute == "AA"))
            {
                return new AAProxy(this);
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
            if ((reference == "AA"))
            {
                return new AAProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://www.transformation-tool-contest.eu/2017/smartGrids/cosem#//InterfaceClasse" +
                        "s/AssociationLN")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the AssociationLN class
        /// </summary>
        public class AssociationLNReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private AssociationLN _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public AssociationLNReferencedElementsCollection(AssociationLN parent)
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
                    if ((this._parent.AA != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.AAChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.AAChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.AA == null))
                {
                    IApplicationAssociation aACasted = item.As<IApplicationAssociation>();
                    if ((aACasted != null))
                    {
                        this._parent.AA = aACasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.AA = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.AA))
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
                if ((this._parent.AA != null))
                {
                    array[arrayIndex] = this._parent.AA;
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
                if ((this._parent.AA == item))
                {
                    this._parent.AA = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.AA).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the AA property
        /// </summary>
        private sealed class AAProxy : ModelPropertyChange<IAssociationLN, IApplicationAssociation>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public AAProxy(IAssociationLN modelElement) : 
                    base(modelElement, "AA")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IApplicationAssociation Value
            {
                get
                {
                    return this.ModelElement.AA;
                }
                set
                {
                    this.ModelElement.AA = value;
                }
            }
        }
    }
}

