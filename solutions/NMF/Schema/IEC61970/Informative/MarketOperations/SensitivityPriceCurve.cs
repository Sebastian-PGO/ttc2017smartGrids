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
using TTC2017.SmartGrids.CIM.IEC61970.Contingency;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Generation.Production;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.EnergyScheduling;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.Financial;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfERPSupport;
using TTC2017.SmartGrids.CIM.IEC61970.LoadModel;
using TTC2017.SmartGrids.CIM.IEC61970.Meas;
using TTC2017.SmartGrids.CIM.IEC61970.Wires;

namespace TTC2017.SmartGrids.CIM.IEC61970.Informative.MarketOperations
{
    
    
    /// <summary>
    /// The default implementation of the SensitivityPriceCurve class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#MarketOperations")]
    [XmlNamespacePrefixAttribute("cimMarketOperations")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/MarketOperations/" +
        "SensitivityPriceCurve")]
    [DebuggerDisplayAttribute("SensitivityPriceCurve {UUID}")]
    public partial class SensitivityPriceCurve : Curve, ISensitivityPriceCurve, IModelElement
    {
        
        private static Lazy<ITypedElement> _reserveReqReference = new Lazy<ITypedElement>(RetrieveReserveReqReference);
        
        /// <summary>
        /// The backing field for the ReserveReq property
        /// </summary>
        private IReserveReq _reserveReq;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The ReserveReq property
        /// </summary>
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("SensitivityPriceCurve")]
        public virtual IReserveReq ReserveReq
        {
            get
            {
                return this._reserveReq;
            }
            set
            {
                if ((this._reserveReq != value))
                {
                    IReserveReq old = this._reserveReq;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnReserveReqChanging(e);
                    this.OnPropertyChanging("ReserveReq", e, _reserveReqReference);
                    this._reserveReq = value;
                    if ((old != null))
                    {
                        old.SensitivityPriceCurve = null;
                        old.Deleted -= this.OnResetReserveReq;
                    }
                    if ((value != null))
                    {
                        value.SensitivityPriceCurve = this;
                        value.Deleted += this.OnResetReserveReq;
                    }
                    this.OnReserveReqChanged(e);
                    this.OnPropertyChanged("ReserveReq", e, _reserveReqReference);
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
                return base.ReferencedElements.Concat(new SensitivityPriceCurveReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/MarketOperations/" +
                            "SensitivityPriceCurve")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the ReserveReq property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ReserveReqChanging;
        
        /// <summary>
        /// Gets fired when the ReserveReq property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ReserveReqChanged;
        
        private static ITypedElement RetrieveReserveReqReference()
        {
            return ((ITypedElement)(((ModelElement)(SensitivityPriceCurve.ClassInstance)).Resolve("ReserveReq")));
        }
        
        /// <summary>
        /// Raises the ReserveReqChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnReserveReqChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ReserveReqChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the ReserveReqChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnReserveReqChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ReserveReqChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the ReserveReq property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetReserveReq(object sender, System.EventArgs eventArgs)
        {
            this.ReserveReq = null;
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "RESERVEREQ"))
            {
                this.ReserveReq = ((IReserveReq)(value));
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
            if ((attribute == "ReserveReq"))
            {
                return new ReserveReqProxy(this);
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
            if ((reference == "ReserveReq"))
            {
                return new ReserveReqProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/MarketOperations/" +
                        "SensitivityPriceCurve")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the SensitivityPriceCurve class
        /// </summary>
        public class SensitivityPriceCurveReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private SensitivityPriceCurve _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public SensitivityPriceCurveReferencedElementsCollection(SensitivityPriceCurve parent)
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
                    if ((this._parent.ReserveReq != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.ReserveReqChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.ReserveReqChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.ReserveReq == null))
                {
                    IReserveReq reserveReqCasted = item.As<IReserveReq>();
                    if ((reserveReqCasted != null))
                    {
                        this._parent.ReserveReq = reserveReqCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.ReserveReq = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.ReserveReq))
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
                if ((this._parent.ReserveReq != null))
                {
                    array[arrayIndex] = this._parent.ReserveReq;
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
                if ((this._parent.ReserveReq == item))
                {
                    this._parent.ReserveReq = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.ReserveReq).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the ReserveReq property
        /// </summary>
        private sealed class ReserveReqProxy : ModelPropertyChange<ISensitivityPriceCurve, IReserveReq>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public ReserveReqProxy(ISensitivityPriceCurve modelElement) : 
                    base(modelElement, "ReserveReq")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IReserveReq Value
            {
                get
                {
                    return this.ModelElement.ReserveReq;
                }
                set
                {
                    this.ModelElement.ReserveReq = value;
                }
            }
        }
    }
}

