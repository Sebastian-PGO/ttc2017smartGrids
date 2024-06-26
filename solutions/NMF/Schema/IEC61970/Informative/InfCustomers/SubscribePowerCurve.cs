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
using TTC2017.SmartGrids.CIM.IEC61968.Common;
using TTC2017.SmartGrids.CIM.IEC61968.Customers;
using TTC2017.SmartGrids.CIM.IEC61968.Metering;
using TTC2017.SmartGrids.CIM.IEC61968.Work;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfERPSupport;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfOperations;

namespace TTC2017.SmartGrids.CIM.IEC61970.Informative.InfCustomers
{
    
    
    /// <summary>
    /// The default implementation of the SubscribePowerCurve class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#InfCustomers")]
    [XmlNamespacePrefixAttribute("cimInfCustomers")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfCustomers/Subs" +
        "cribePowerCurve")]
    [DebuggerDisplayAttribute("SubscribePowerCurve {UUID}")]
    public partial class SubscribePowerCurve : Curve, ISubscribePowerCurve, IModelElement
    {
        
        private static Lazy<ITypedElement> _pricingStructureReference = new Lazy<ITypedElement>(RetrievePricingStructureReference);
        
        /// <summary>
        /// The backing field for the PricingStructure property
        /// </summary>
        private IPricingStructure _pricingStructure;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The PricingStructure property
        /// </summary>
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("SubscribePowerCurve")]
        public virtual IPricingStructure PricingStructure
        {
            get
            {
                return this._pricingStructure;
            }
            set
            {
                if ((this._pricingStructure != value))
                {
                    IPricingStructure old = this._pricingStructure;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnPricingStructureChanging(e);
                    this.OnPropertyChanging("PricingStructure", e, _pricingStructureReference);
                    this._pricingStructure = value;
                    if ((old != null))
                    {
                        old.SubscribePowerCurve = null;
                        old.Deleted -= this.OnResetPricingStructure;
                    }
                    if ((value != null))
                    {
                        value.SubscribePowerCurve = this;
                        value.Deleted += this.OnResetPricingStructure;
                    }
                    this.OnPricingStructureChanged(e);
                    this.OnPropertyChanged("PricingStructure", e, _pricingStructureReference);
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
                return base.ReferencedElements.Concat(new SubscribePowerCurveReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfCustomers/Subs" +
                            "cribePowerCurve")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the PricingStructure property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> PricingStructureChanging;
        
        /// <summary>
        /// Gets fired when the PricingStructure property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> PricingStructureChanged;
        
        private static ITypedElement RetrievePricingStructureReference()
        {
            return ((ITypedElement)(((ModelElement)(SubscribePowerCurve.ClassInstance)).Resolve("PricingStructure")));
        }
        
        /// <summary>
        /// Raises the PricingStructureChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnPricingStructureChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.PricingStructureChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the PricingStructureChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnPricingStructureChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.PricingStructureChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the PricingStructure property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetPricingStructure(object sender, System.EventArgs eventArgs)
        {
            this.PricingStructure = null;
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "PRICINGSTRUCTURE"))
            {
                this.PricingStructure = ((IPricingStructure)(value));
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
            if ((attribute == "PricingStructure"))
            {
                return new PricingStructureProxy(this);
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
            if ((reference == "PricingStructure"))
            {
                return new PricingStructureProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfCustomers/Subs" +
                        "cribePowerCurve")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the SubscribePowerCurve class
        /// </summary>
        public class SubscribePowerCurveReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private SubscribePowerCurve _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public SubscribePowerCurveReferencedElementsCollection(SubscribePowerCurve parent)
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
                    if ((this._parent.PricingStructure != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.PricingStructureChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.PricingStructureChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.PricingStructure == null))
                {
                    IPricingStructure pricingStructureCasted = item.As<IPricingStructure>();
                    if ((pricingStructureCasted != null))
                    {
                        this._parent.PricingStructure = pricingStructureCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.PricingStructure = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.PricingStructure))
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
                if ((this._parent.PricingStructure != null))
                {
                    array[arrayIndex] = this._parent.PricingStructure;
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
                if ((this._parent.PricingStructure == item))
                {
                    this._parent.PricingStructure = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.PricingStructure).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the PricingStructure property
        /// </summary>
        private sealed class PricingStructureProxy : ModelPropertyChange<ISubscribePowerCurve, IPricingStructure>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public PricingStructureProxy(ISubscribePowerCurve modelElement) : 
                    base(modelElement, "PricingStructure")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IPricingStructure Value
            {
                get
                {
                    return this.ModelElement.PricingStructure;
                }
                set
                {
                    this.ModelElement.PricingStructure = value;
                }
            }
        }
    }
}

