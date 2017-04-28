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
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.MarketOperations;

namespace TTC2017.SmartGrids.CIM.IEC61970.Contingency
{
    
    
    /// <summary>
    /// The default implementation of the ContingencyElement class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#Contingency")]
    [XmlNamespacePrefixAttribute("cimContingency")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Contingency/ContingencyElemen" +
        "t")]
    [DebuggerDisplayAttribute("ContingencyElement {UUID}")]
    public partial class ContingencyElement : IdentifiedObject, IContingencyElement, IModelElement
    {
        
        private static Lazy<ITypedElement> _contingencyReference = new Lazy<ITypedElement>(RetrieveContingencyReference);
        
        /// <summary>
        /// The backing field for the Contingency property
        /// </summary>
        private IContingency _contingency;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The Contingency property
        /// </summary>
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("ContingencyElement")]
        public virtual IContingency Contingency
        {
            get
            {
                return this._contingency;
            }
            set
            {
                if ((this._contingency != value))
                {
                    IContingency old = this._contingency;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnContingencyChanging(e);
                    this.OnPropertyChanging("Contingency", e, _contingencyReference);
                    this._contingency = value;
                    if ((old != null))
                    {
                        old.ContingencyElement.Remove(this);
                        old.Deleted -= this.OnResetContingency;
                    }
                    if ((value != null))
                    {
                        value.ContingencyElement.Add(this);
                        value.Deleted += this.OnResetContingency;
                    }
                    this.OnContingencyChanged(e);
                    this.OnPropertyChanged("Contingency", e, _contingencyReference);
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
                return base.ReferencedElements.Concat(new ContingencyElementReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Contingency/ContingencyElemen" +
                            "t")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the Contingency property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ContingencyChanging;
        
        /// <summary>
        /// Gets fired when the Contingency property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ContingencyChanged;
        
        private static ITypedElement RetrieveContingencyReference()
        {
            return ((ITypedElement)(((ModelElement)(ContingencyElement.ClassInstance)).Resolve("Contingency")));
        }
        
        /// <summary>
        /// Raises the ContingencyChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnContingencyChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ContingencyChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the ContingencyChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnContingencyChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ContingencyChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the Contingency property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetContingency(object sender, System.EventArgs eventArgs)
        {
            this.Contingency = null;
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "CONTINGENCY"))
            {
                this.Contingency = ((IContingency)(value));
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
            if ((attribute == "Contingency"))
            {
                return new ContingencyProxy(this);
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
            if ((reference == "Contingency"))
            {
                return new ContingencyProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Contingency/ContingencyElemen" +
                        "t")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the ContingencyElement class
        /// </summary>
        public class ContingencyElementReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private ContingencyElement _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public ContingencyElementReferencedElementsCollection(ContingencyElement parent)
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
                    if ((this._parent.Contingency != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.ContingencyChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.ContingencyChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.Contingency == null))
                {
                    IContingency contingencyCasted = item.As<IContingency>();
                    if ((contingencyCasted != null))
                    {
                        this._parent.Contingency = contingencyCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.Contingency = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.Contingency))
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
                if ((this._parent.Contingency != null))
                {
                    array[arrayIndex] = this._parent.Contingency;
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
                if ((this._parent.Contingency == item))
                {
                    this._parent.Contingency = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.Contingency).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the Contingency property
        /// </summary>
        private sealed class ContingencyProxy : ModelPropertyChange<IContingencyElement, IContingency>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public ContingencyProxy(IContingencyElement modelElement) : 
                    base(modelElement, "Contingency")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IContingency Value
            {
                get
                {
                    return this.ModelElement.Contingency;
                }
                set
                {
                    this.ModelElement.Contingency = value;
                }
            }
        }
    }
}

