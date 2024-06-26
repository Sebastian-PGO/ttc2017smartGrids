using System.Collections.Specialized;
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
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace TTC2017.SmartGrids.OutagePreventionJointarget
{
    
    
    /// <summary>
    /// The default implementation of the ServiceDeliveryPoint class
    /// </summary>
    [XmlNamespaceAttribute("http://www.transformation-tool-contest.eu/2017/smartGrids/VoltagePhaseMeasurement" +
        "s")]
    [XmlNamespacePrefixAttribute("outagePreventionJt")]
    [ModelRepresentationClassAttribute("http://www.transformation-tool-contest.eu/2017/smartGrids/VoltagePhaseMeasurement" +
        "s#//ServiceDeliveryPoint")]
    public partial class ServiceDeliveryPoint : ModelElement, IServiceDeliveryPoint, IModelElement
    {
        
        private static Lazy<ITypedElement> _energyConsumerReference = new Lazy<ITypedElement>(RetrieveEnergyConsumerReference);
        
        /// <summary>
        /// The backing field for the EnergyConsumer property
        /// </summary>
        private IEnergyConsumer _energyConsumer;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The EnergyConsumer property
        /// </summary>
        [XmlAttributeAttribute(true)]
        public IEnergyConsumer EnergyConsumer
        {
            get
            {
                return this._energyConsumer;
            }
            set
            {
                if ((this._energyConsumer != value))
                {
                    IEnergyConsumer old = this._energyConsumer;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnEnergyConsumerChanging(e);
                    this.OnPropertyChanging("EnergyConsumer", e, _energyConsumerReference);
                    this._energyConsumer = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetEnergyConsumer;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetEnergyConsumer;
                    }
                    this.OnEnergyConsumerChanged(e);
                    this.OnPropertyChanged("EnergyConsumer", e, _energyConsumerReference);
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
                return base.ReferencedElements.Concat(new ServiceDeliveryPointReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://www.transformation-tool-contest.eu/2017/smartGrids/VoltagePhaseMeasurement" +
                            "s#//ServiceDeliveryPoint")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the EnergyConsumer property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> EnergyConsumerChanging;
        
        /// <summary>
        /// Gets fired when the EnergyConsumer property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> EnergyConsumerChanged;
        
        private static ITypedElement RetrieveEnergyConsumerReference()
        {
            return ((ITypedElement)(((ModelElement)(TTC2017.SmartGrids.OutagePreventionJointarget.ServiceDeliveryPoint.ClassInstance)).Resolve("EnergyConsumer")));
        }
        
        /// <summary>
        /// Raises the EnergyConsumerChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnEnergyConsumerChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.EnergyConsumerChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the EnergyConsumerChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnEnergyConsumerChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.EnergyConsumerChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the EnergyConsumer property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetEnergyConsumer(object sender, System.EventArgs eventArgs)
        {
            this.EnergyConsumer = null;
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "ENERGYCONSUMER"))
            {
                this.EnergyConsumer = ((IEnergyConsumer)(value));
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
            if ((attribute == "EnergyConsumer"))
            {
                return new EnergyConsumerProxy(this);
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
            if ((reference == "EnergyConsumer"))
            {
                return new EnergyConsumerProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://www.transformation-tool-contest.eu/2017/smartGrids/VoltagePhaseMeasurement" +
                        "s#//ServiceDeliveryPoint")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the ServiceDeliveryPoint class
        /// </summary>
        public class ServiceDeliveryPointReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private ServiceDeliveryPoint _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public ServiceDeliveryPointReferencedElementsCollection(ServiceDeliveryPoint parent)
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
                    if ((this._parent.EnergyConsumer != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.EnergyConsumerChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.EnergyConsumerChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.EnergyConsumer == null))
                {
                    IEnergyConsumer energyConsumerCasted = item.As<IEnergyConsumer>();
                    if ((energyConsumerCasted != null))
                    {
                        this._parent.EnergyConsumer = energyConsumerCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.EnergyConsumer = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.EnergyConsumer))
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
                if ((this._parent.EnergyConsumer != null))
                {
                    array[arrayIndex] = this._parent.EnergyConsumer;
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
                if ((this._parent.EnergyConsumer == item))
                {
                    this._parent.EnergyConsumer = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.EnergyConsumer).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the EnergyConsumer property
        /// </summary>
        private sealed class EnergyConsumerProxy : ModelPropertyChange<IServiceDeliveryPoint, IEnergyConsumer>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public EnergyConsumerProxy(IServiceDeliveryPoint modelElement) : 
                    base(modelElement, "EnergyConsumer")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IEnergyConsumer Value
            {
                get
                {
                    return this.ModelElement.EnergyConsumer;
                }
                set
                {
                    this.ModelElement.EnergyConsumer = value;
                }
            }
        }
    }
}

