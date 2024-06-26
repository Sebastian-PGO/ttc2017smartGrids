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
    /// The default implementation of the ConformLoadSchedule class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#LoadModel")]
    [XmlNamespacePrefixAttribute("cimLoadModel")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/LoadModel/ConformLoadSchedule" +
        "")]
    [DebuggerDisplayAttribute("ConformLoadSchedule {UUID}")]
    public partial class ConformLoadSchedule : SeasonDayTypeSchedule, IConformLoadSchedule, IModelElement
    {
        
        private static Lazy<ITypedElement> _conformLoadGroupReference = new Lazy<ITypedElement>(RetrieveConformLoadGroupReference);
        
        /// <summary>
        /// The backing field for the ConformLoadGroup property
        /// </summary>
        private IConformLoadGroup _conformLoadGroup;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The ConformLoadGroup property
        /// </summary>
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("ConformLoadSchedules")]
        public virtual IConformLoadGroup ConformLoadGroup
        {
            get
            {
                return this._conformLoadGroup;
            }
            set
            {
                if ((this._conformLoadGroup != value))
                {
                    IConformLoadGroup old = this._conformLoadGroup;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnConformLoadGroupChanging(e);
                    this.OnPropertyChanging("ConformLoadGroup", e, _conformLoadGroupReference);
                    this._conformLoadGroup = value;
                    if ((old != null))
                    {
                        old.ConformLoadSchedules.Remove(this);
                        old.Deleted -= this.OnResetConformLoadGroup;
                    }
                    if ((value != null))
                    {
                        value.ConformLoadSchedules.Add(this);
                        value.Deleted += this.OnResetConformLoadGroup;
                    }
                    this.OnConformLoadGroupChanged(e);
                    this.OnPropertyChanged("ConformLoadGroup", e, _conformLoadGroupReference);
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
                return base.ReferencedElements.Concat(new ConformLoadScheduleReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/LoadModel/ConformLoadSchedule" +
                            "")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the ConformLoadGroup property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ConformLoadGroupChanging;
        
        /// <summary>
        /// Gets fired when the ConformLoadGroup property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ConformLoadGroupChanged;
        
        private static ITypedElement RetrieveConformLoadGroupReference()
        {
            return ((ITypedElement)(((ModelElement)(ConformLoadSchedule.ClassInstance)).Resolve("ConformLoadGroup")));
        }
        
        /// <summary>
        /// Raises the ConformLoadGroupChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnConformLoadGroupChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ConformLoadGroupChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the ConformLoadGroupChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnConformLoadGroupChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ConformLoadGroupChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the ConformLoadGroup property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetConformLoadGroup(object sender, System.EventArgs eventArgs)
        {
            this.ConformLoadGroup = null;
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "CONFORMLOADGROUP"))
            {
                this.ConformLoadGroup = ((IConformLoadGroup)(value));
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
            if ((attribute == "ConformLoadGroup"))
            {
                return new ConformLoadGroupProxy(this);
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
            if ((reference == "ConformLoadGroup"))
            {
                return new ConformLoadGroupProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/LoadModel/ConformLoadSchedule" +
                        "")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the ConformLoadSchedule class
        /// </summary>
        public class ConformLoadScheduleReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private ConformLoadSchedule _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public ConformLoadScheduleReferencedElementsCollection(ConformLoadSchedule parent)
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
                    if ((this._parent.ConformLoadGroup != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.ConformLoadGroupChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.ConformLoadGroupChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.ConformLoadGroup == null))
                {
                    IConformLoadGroup conformLoadGroupCasted = item.As<IConformLoadGroup>();
                    if ((conformLoadGroupCasted != null))
                    {
                        this._parent.ConformLoadGroup = conformLoadGroupCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.ConformLoadGroup = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.ConformLoadGroup))
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
                if ((this._parent.ConformLoadGroup != null))
                {
                    array[arrayIndex] = this._parent.ConformLoadGroup;
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
                if ((this._parent.ConformLoadGroup == item))
                {
                    this._parent.ConformLoadGroup = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.ConformLoadGroup).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the ConformLoadGroup property
        /// </summary>
        private sealed class ConformLoadGroupProxy : ModelPropertyChange<IConformLoadSchedule, IConformLoadGroup>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public ConformLoadGroupProxy(IConformLoadSchedule modelElement) : 
                    base(modelElement, "ConformLoadGroup")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IConformLoadGroup Value
            {
                get
                {
                    return this.ModelElement.ConformLoadGroup;
                }
                set
                {
                    this.ModelElement.ConformLoadGroup = value;
                }
            }
        }
    }
}

