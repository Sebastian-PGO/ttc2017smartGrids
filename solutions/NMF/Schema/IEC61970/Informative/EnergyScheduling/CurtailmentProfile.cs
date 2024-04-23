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
using TTC2017.SmartGrids.CIM.IEC61968.Common;
using TTC2017.SmartGrids.CIM.IEC61970.ControlArea;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Generation.Production;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.Financial;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.MarketOperations;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.Reservation;
using TTC2017.SmartGrids.CIM.IEC61970.Meas;
using TTC2017.SmartGrids.CIM.IEC61970.Wires;

namespace TTC2017.SmartGrids.CIM.IEC61970.Informative.EnergyScheduling
{
    
    
    /// <summary>
    /// The default implementation of the CurtailmentProfile class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#EnergyScheduling")]
    [XmlNamespacePrefixAttribute("cimEnergyScheduling")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/EnergyScheduling/" +
        "CurtailmentProfile")]
    [DebuggerDisplayAttribute("CurtailmentProfile {UUID}")]
    public partial class CurtailmentProfile : Profile, ICurtailmentProfile, IModelElement
    {
        
        private static Lazy<ITypedElement> _energyTransactionReference = new Lazy<ITypedElement>(RetrieveEnergyTransactionReference);
        
        /// <summary>
        /// The backing field for the EnergyTransaction property
        /// </summary>
        private IEnergyTransaction _energyTransaction;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The EnergyTransaction property
        /// </summary>
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("CurtailmentProfiles")]
        public virtual IEnergyTransaction EnergyTransaction
        {
            get
            {
                return this._energyTransaction;
            }
            set
            {
                if ((this._energyTransaction != value))
                {
                    IEnergyTransaction old = this._energyTransaction;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnEnergyTransactionChanging(e);
                    this.OnPropertyChanging("EnergyTransaction", e, _energyTransactionReference);
                    this._energyTransaction = value;
                    if ((old != null))
                    {
                        old.CurtailmentProfiles.Remove(this);
                        old.Deleted -= this.OnResetEnergyTransaction;
                    }
                    if ((value != null))
                    {
                        value.CurtailmentProfiles.Add(this);
                        value.Deleted += this.OnResetEnergyTransaction;
                    }
                    this.OnEnergyTransactionChanged(e);
                    this.OnPropertyChanged("EnergyTransaction", e, _energyTransactionReference);
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
                return base.ReferencedElements.Concat(new CurtailmentProfileReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/EnergyScheduling/" +
                            "CurtailmentProfile")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the EnergyTransaction property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> EnergyTransactionChanging;
        
        /// <summary>
        /// Gets fired when the EnergyTransaction property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> EnergyTransactionChanged;
        
        private static ITypedElement RetrieveEnergyTransactionReference()
        {
            return ((ITypedElement)(((ModelElement)(CurtailmentProfile.ClassInstance)).Resolve("EnergyTransaction")));
        }
        
        /// <summary>
        /// Raises the EnergyTransactionChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnEnergyTransactionChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.EnergyTransactionChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the EnergyTransactionChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnEnergyTransactionChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.EnergyTransactionChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the EnergyTransaction property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetEnergyTransaction(object sender, System.EventArgs eventArgs)
        {
            this.EnergyTransaction = null;
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "ENERGYTRANSACTION"))
            {
                this.EnergyTransaction = ((IEnergyTransaction)(value));
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
            if ((attribute == "EnergyTransaction"))
            {
                return new EnergyTransactionProxy(this);
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
            if ((reference == "EnergyTransaction"))
            {
                return new EnergyTransactionProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/EnergyScheduling/" +
                        "CurtailmentProfile")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the CurtailmentProfile class
        /// </summary>
        public class CurtailmentProfileReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private CurtailmentProfile _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public CurtailmentProfileReferencedElementsCollection(CurtailmentProfile parent)
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
                    if ((this._parent.EnergyTransaction != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.EnergyTransactionChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.EnergyTransactionChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.EnergyTransaction == null))
                {
                    IEnergyTransaction energyTransactionCasted = item.As<IEnergyTransaction>();
                    if ((energyTransactionCasted != null))
                    {
                        this._parent.EnergyTransaction = energyTransactionCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.EnergyTransaction = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.EnergyTransaction))
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
                if ((this._parent.EnergyTransaction != null))
                {
                    array[arrayIndex] = this._parent.EnergyTransaction;
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
                if ((this._parent.EnergyTransaction == item))
                {
                    this._parent.EnergyTransaction = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.EnergyTransaction).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the EnergyTransaction property
        /// </summary>
        private sealed class EnergyTransactionProxy : ModelPropertyChange<ICurtailmentProfile, IEnergyTransaction>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public EnergyTransactionProxy(ICurtailmentProfile modelElement) : 
                    base(modelElement, "EnergyTransaction")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IEnergyTransaction Value
            {
                get
                {
                    return this.ModelElement.EnergyTransaction;
                }
                set
                {
                    this.ModelElement.EnergyTransaction = value;
                }
            }
        }
    }
}

