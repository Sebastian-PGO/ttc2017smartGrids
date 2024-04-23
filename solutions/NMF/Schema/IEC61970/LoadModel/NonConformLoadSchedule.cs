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
using TTC2017.SmartGrids.CIM;
using TTC2017.SmartGrids.CIM.IEC61970.ControlArea;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.MarketOperations;
using TTC2017.SmartGrids.CIM.IEC61970.Wires;

namespace TTC2017.SmartGrids.CIM.IEC61970.LoadModel
{
    
    
    /// <summary>
    /// The default implementation of the NonConformLoadSchedule class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#LoadModel")]
    [XmlNamespacePrefixAttribute("cimLoadModel")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/LoadModel/NonConformLoadSched" +
        "ule")]
    [DebuggerDisplayAttribute("NonConformLoadSchedule {UUID}")]
    public partial class NonConformLoadSchedule : SeasonDayTypeSchedule, INonConformLoadSchedule, IModelElement
    {
        
        private static Lazy<ITypedElement> _nonConformLoadGroupReference = new Lazy<ITypedElement>(RetrieveNonConformLoadGroupReference);
        
        /// <summary>
        /// The backing field for the NonConformLoadGroup property
        /// </summary>
        private INonConformLoadGroup _nonConformLoadGroup;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The NonConformLoadGroup property
        /// </summary>
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("NonConformLoadSchedules")]
        public virtual INonConformLoadGroup NonConformLoadGroup
        {
            get
            {
                return this._nonConformLoadGroup;
            }
            set
            {
                if ((this._nonConformLoadGroup != value))
                {
                    INonConformLoadGroup old = this._nonConformLoadGroup;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnNonConformLoadGroupChanging(e);
                    this.OnPropertyChanging("NonConformLoadGroup", e, _nonConformLoadGroupReference);
                    this._nonConformLoadGroup = value;
                    if ((old != null))
                    {
                        old.NonConformLoadSchedules.Remove(this);
                        old.Deleted -= this.OnResetNonConformLoadGroup;
                    }
                    if ((value != null))
                    {
                        value.NonConformLoadSchedules.Add(this);
                        value.Deleted += this.OnResetNonConformLoadGroup;
                    }
                    this.OnNonConformLoadGroupChanged(e);
                    this.OnPropertyChanged("NonConformLoadGroup", e, _nonConformLoadGroupReference);
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
                return base.ReferencedElements.Concat(new NonConformLoadScheduleReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/LoadModel/NonConformLoadSched" +
                            "ule")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the NonConformLoadGroup property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> NonConformLoadGroupChanging;
        
        /// <summary>
        /// Gets fired when the NonConformLoadGroup property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> NonConformLoadGroupChanged;
        
        private static ITypedElement RetrieveNonConformLoadGroupReference()
        {
            return ((ITypedElement)(((ModelElement)(NonConformLoadSchedule.ClassInstance)).Resolve("NonConformLoadGroup")));
        }
        
        /// <summary>
        /// Raises the NonConformLoadGroupChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnNonConformLoadGroupChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.NonConformLoadGroupChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the NonConformLoadGroupChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnNonConformLoadGroupChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.NonConformLoadGroupChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the NonConformLoadGroup property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetNonConformLoadGroup(object sender, System.EventArgs eventArgs)
        {
            this.NonConformLoadGroup = null;
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "NONCONFORMLOADGROUP"))
            {
                this.NonConformLoadGroup = ((INonConformLoadGroup)(value));
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
            if ((attribute == "NonConformLoadGroup"))
            {
                return new NonConformLoadGroupProxy(this);
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
            if ((reference == "NonConformLoadGroup"))
            {
                return new NonConformLoadGroupProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/LoadModel/NonConformLoadSched" +
                        "ule")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the NonConformLoadSchedule class
        /// </summary>
        public class NonConformLoadScheduleReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private NonConformLoadSchedule _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public NonConformLoadScheduleReferencedElementsCollection(NonConformLoadSchedule parent)
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
                    if ((this._parent.NonConformLoadGroup != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.NonConformLoadGroupChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.NonConformLoadGroupChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.NonConformLoadGroup == null))
                {
                    INonConformLoadGroup nonConformLoadGroupCasted = item.As<INonConformLoadGroup>();
                    if ((nonConformLoadGroupCasted != null))
                    {
                        this._parent.NonConformLoadGroup = nonConformLoadGroupCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.NonConformLoadGroup = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.NonConformLoadGroup))
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
                if ((this._parent.NonConformLoadGroup != null))
                {
                    array[arrayIndex] = this._parent.NonConformLoadGroup;
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
                if ((this._parent.NonConformLoadGroup == item))
                {
                    this._parent.NonConformLoadGroup = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.NonConformLoadGroup).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the NonConformLoadGroup property
        /// </summary>
        private sealed class NonConformLoadGroupProxy : ModelPropertyChange<INonConformLoadSchedule, INonConformLoadGroup>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public NonConformLoadGroupProxy(INonConformLoadSchedule modelElement) : 
                    base(modelElement, "NonConformLoadGroup")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override INonConformLoadGroup Value
            {
                get
                {
                    return this.ModelElement.NonConformLoadGroup;
                }
                set
                {
                    this.ModelElement.NonConformLoadGroup = value;
                }
            }
        }
    }
}

