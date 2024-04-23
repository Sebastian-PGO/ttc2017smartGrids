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
using TTC2017.SmartGrids.CIM.IEC61968.Customers;
using TTC2017.SmartGrids.CIM.IEC61968.Metering;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Domain;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfCommon;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfPaymentMetering;

namespace TTC2017.SmartGrids.CIM.IEC61968.PaymentMetering
{
    
    
    /// <summary>
    /// The default implementation of the TariffProfile class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#PaymentMetering")]
    [XmlNamespacePrefixAttribute("cimPaymentMetering")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61968/PaymentMetering/TariffProfile" +
        "")]
    [DebuggerDisplayAttribute("TariffProfile {UUID}")]
    public partial class TariffProfile : Document, ITariffProfile, IModelElement
    {
        
        /// <summary>
        /// The backing field for the TariffCycle property
        /// </summary>
        private string _tariffCycle;
        
        private static Lazy<ITypedElement> _tariffCycleAttribute = new Lazy<ITypedElement>(RetrieveTariffCycleAttribute);
        
        private static Lazy<ITypedElement> _timeTariffIntervalsReference = new Lazy<ITypedElement>(RetrieveTimeTariffIntervalsReference);
        
        /// <summary>
        /// The backing field for the TimeTariffIntervals property
        /// </summary>
        private TariffProfileTimeTariffIntervalsCollection _timeTariffIntervals;
        
        private static Lazy<ITypedElement> _tariffsReference = new Lazy<ITypedElement>(RetrieveTariffsReference);
        
        /// <summary>
        /// The backing field for the Tariffs property
        /// </summary>
        private TariffProfileTariffsCollection _tariffs;
        
        private static Lazy<ITypedElement> _consumptionTariffIntervalsReference = new Lazy<ITypedElement>(RetrieveConsumptionTariffIntervalsReference);
        
        /// <summary>
        /// The backing field for the ConsumptionTariffIntervals property
        /// </summary>
        private TariffProfileConsumptionTariffIntervalsCollection _consumptionTariffIntervals;
        
        private static IClass _classInstance;
        
        public TariffProfile()
        {
            this._timeTariffIntervals = new TariffProfileTimeTariffIntervalsCollection(this);
            this._timeTariffIntervals.CollectionChanging += this.TimeTariffIntervalsCollectionChanging;
            this._timeTariffIntervals.CollectionChanged += this.TimeTariffIntervalsCollectionChanged;
            this._tariffs = new TariffProfileTariffsCollection(this);
            this._tariffs.CollectionChanging += this.TariffsCollectionChanging;
            this._tariffs.CollectionChanged += this.TariffsCollectionChanged;
            this._consumptionTariffIntervals = new TariffProfileConsumptionTariffIntervalsCollection(this);
            this._consumptionTariffIntervals.CollectionChanging += this.ConsumptionTariffIntervalsCollectionChanging;
            this._consumptionTariffIntervals.CollectionChanged += this.ConsumptionTariffIntervalsCollectionChanged;
        }
        
        /// <summary>
        /// The tariffCycle property
        /// </summary>
        [XmlElementNameAttribute("tariffCycle")]
        [XmlAttributeAttribute(true)]
        public virtual string TariffCycle
        {
            get
            {
                return this._tariffCycle;
            }
            set
            {
                if ((this._tariffCycle != value))
                {
                    string old = this._tariffCycle;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnTariffCycleChanging(e);
                    this.OnPropertyChanging("TariffCycle", e, _tariffCycleAttribute);
                    this._tariffCycle = value;
                    this.OnTariffCycleChanged(e);
                    this.OnPropertyChanged("TariffCycle", e, _tariffCycleAttribute);
                }
            }
        }
        
        /// <summary>
        /// The TimeTariffIntervals property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("TariffProfiles")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<ITimeTariffInterval> TimeTariffIntervals
        {
            get
            {
                return this._timeTariffIntervals;
            }
        }
        
        /// <summary>
        /// The Tariffs property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("TariffProfiles")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<ITariff> Tariffs
        {
            get
            {
                return this._tariffs;
            }
        }
        
        /// <summary>
        /// The ConsumptionTariffIntervals property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("TariffProfiles")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<IConsumptionTariffInterval> ConsumptionTariffIntervals
        {
            get
            {
                return this._consumptionTariffIntervals;
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new TariffProfileReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61968/PaymentMetering/TariffProfile" +
                            "")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the TariffCycle property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> TariffCycleChanging;
        
        /// <summary>
        /// Gets fired when the TariffCycle property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> TariffCycleChanged;
        
        private static ITypedElement RetrieveTariffCycleAttribute()
        {
            return ((ITypedElement)(((ModelElement)(TariffProfile.ClassInstance)).Resolve("tariffCycle")));
        }
        
        /// <summary>
        /// Raises the TariffCycleChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnTariffCycleChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.TariffCycleChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the TariffCycleChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnTariffCycleChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.TariffCycleChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveTimeTariffIntervalsReference()
        {
            return ((ITypedElement)(((ModelElement)(TariffProfile.ClassInstance)).Resolve("TimeTariffIntervals")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the TimeTariffIntervals property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void TimeTariffIntervalsCollectionChanging(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanging("TimeTariffIntervals", e, _timeTariffIntervalsReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the TimeTariffIntervals property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void TimeTariffIntervalsCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("TimeTariffIntervals", e, _timeTariffIntervalsReference);
        }
        
        private static ITypedElement RetrieveTariffsReference()
        {
            return ((ITypedElement)(((ModelElement)(TariffProfile.ClassInstance)).Resolve("Tariffs")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the Tariffs property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void TariffsCollectionChanging(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanging("Tariffs", e, _tariffsReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the Tariffs property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void TariffsCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("Tariffs", e, _tariffsReference);
        }
        
        private static ITypedElement RetrieveConsumptionTariffIntervalsReference()
        {
            return ((ITypedElement)(((ModelElement)(TariffProfile.ClassInstance)).Resolve("ConsumptionTariffIntervals")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the ConsumptionTariffIntervals property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void ConsumptionTariffIntervalsCollectionChanging(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanging("ConsumptionTariffIntervals", e, _consumptionTariffIntervalsReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the ConsumptionTariffIntervals property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void ConsumptionTariffIntervalsCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("ConsumptionTariffIntervals", e, _consumptionTariffIntervalsReference);
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "TARIFFCYCLE"))
            {
                return this.TariffCycle;
            }
            return base.GetAttributeValue(attribute, index);
        }
        
        /// <summary>
        /// Gets the Model element collection for the given feature
        /// </summary>
        /// <returns>A non-generic list of elements</returns>
        /// <param name="feature">The requested feature</param>
        protected override System.Collections.IList GetCollectionForFeature(string feature)
        {
            if ((feature == "TIMETARIFFINTERVALS"))
            {
                return this._timeTariffIntervals;
            }
            if ((feature == "TARIFFS"))
            {
                return this._tariffs;
            }
            if ((feature == "CONSUMPTIONTARIFFINTERVALS"))
            {
                return this._consumptionTariffIntervals;
            }
            return base.GetCollectionForFeature(feature);
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "TARIFFCYCLE"))
            {
                this.TariffCycle = ((string)(value));
                return;
            }
            base.SetFeature(feature, value);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override IClass GetClass()
        {
            if ((_classInstance == null))
            {
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61968/PaymentMetering/TariffProfile" +
                        "")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the TariffProfile class
        /// </summary>
        public class TariffProfileReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private TariffProfile _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public TariffProfileReferencedElementsCollection(TariffProfile parent)
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
                    count = (count + this._parent.TimeTariffIntervals.Count);
                    count = (count + this._parent.Tariffs.Count);
                    count = (count + this._parent.ConsumptionTariffIntervals.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.TimeTariffIntervals.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.Tariffs.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.ConsumptionTariffIntervals.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.TimeTariffIntervals.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.Tariffs.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.ConsumptionTariffIntervals.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                ITimeTariffInterval timeTariffIntervalsCasted = item.As<ITimeTariffInterval>();
                if ((timeTariffIntervalsCasted != null))
                {
                    this._parent.TimeTariffIntervals.Add(timeTariffIntervalsCasted);
                }
                ITariff tariffsCasted = item.As<ITariff>();
                if ((tariffsCasted != null))
                {
                    this._parent.Tariffs.Add(tariffsCasted);
                }
                IConsumptionTariffInterval consumptionTariffIntervalsCasted = item.As<IConsumptionTariffInterval>();
                if ((consumptionTariffIntervalsCasted != null))
                {
                    this._parent.ConsumptionTariffIntervals.Add(consumptionTariffIntervalsCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.TimeTariffIntervals.Clear();
                this._parent.Tariffs.Clear();
                this._parent.ConsumptionTariffIntervals.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.TimeTariffIntervals.Contains(item))
                {
                    return true;
                }
                if (this._parent.Tariffs.Contains(item))
                {
                    return true;
                }
                if (this._parent.ConsumptionTariffIntervals.Contains(item))
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
                IEnumerator<IModelElement> timeTariffIntervalsEnumerator = this._parent.TimeTariffIntervals.GetEnumerator();
                try
                {
                    for (
                    ; timeTariffIntervalsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = timeTariffIntervalsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    timeTariffIntervalsEnumerator.Dispose();
                }
                IEnumerator<IModelElement> tariffsEnumerator = this._parent.Tariffs.GetEnumerator();
                try
                {
                    for (
                    ; tariffsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = tariffsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    tariffsEnumerator.Dispose();
                }
                IEnumerator<IModelElement> consumptionTariffIntervalsEnumerator = this._parent.ConsumptionTariffIntervals.GetEnumerator();
                try
                {
                    for (
                    ; consumptionTariffIntervalsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = consumptionTariffIntervalsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    consumptionTariffIntervalsEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                ITimeTariffInterval timeTariffIntervalItem = item.As<ITimeTariffInterval>();
                if (((timeTariffIntervalItem != null) 
                            && this._parent.TimeTariffIntervals.Remove(timeTariffIntervalItem)))
                {
                    return true;
                }
                ITariff tariffItem = item.As<ITariff>();
                if (((tariffItem != null) 
                            && this._parent.Tariffs.Remove(tariffItem)))
                {
                    return true;
                }
                IConsumptionTariffInterval consumptionTariffIntervalItem = item.As<IConsumptionTariffInterval>();
                if (((consumptionTariffIntervalItem != null) 
                            && this._parent.ConsumptionTariffIntervals.Remove(consumptionTariffIntervalItem)))
                {
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.TimeTariffIntervals).Concat(this._parent.Tariffs).Concat(this._parent.ConsumptionTariffIntervals).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the tariffCycle property
        /// </summary>
        private sealed class TariffCycleProxy : ModelPropertyChange<ITariffProfile, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public TariffCycleProxy(ITariffProfile modelElement) : 
                    base(modelElement, "tariffCycle")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override string Value
            {
                get
                {
                    return this.ModelElement.TariffCycle;
                }
                set
                {
                    this.ModelElement.TariffCycle = value;
                }
            }
        }
    }
}

