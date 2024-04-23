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
using TTC2017.SmartGrids.CIM.IEC61970.ControlArea;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Generation.GenerationDynamics;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.EnergyScheduling;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.Financial;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.MarketOperations;
using TTC2017.SmartGrids.CIM.IEC61970.Wires;

namespace TTC2017.SmartGrids.CIM.IEC61970.Generation.Production
{
    
    
    /// <summary>
    /// The default implementation of the HydroPumpOpSchedule class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#Production")]
    [XmlNamespacePrefixAttribute("cimProduction")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Generation/Production/HydroPu" +
        "mpOpSchedule")]
    [DebuggerDisplayAttribute("HydroPumpOpSchedule {UUID}")]
    public partial class HydroPumpOpSchedule : RegularIntervalSchedule, IHydroPumpOpSchedule, IModelElement
    {
        
        private static Lazy<ITypedElement> _hydroPumpReference = new Lazy<ITypedElement>(RetrieveHydroPumpReference);
        
        /// <summary>
        /// The backing field for the HydroPump property
        /// </summary>
        private IHydroPump _hydroPump;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The HydroPump property
        /// </summary>
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("HydroPumpOpSchedule")]
        public virtual IHydroPump HydroPump
        {
            get
            {
                return this._hydroPump;
            }
            set
            {
                if ((this._hydroPump != value))
                {
                    IHydroPump old = this._hydroPump;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnHydroPumpChanging(e);
                    this.OnPropertyChanging("HydroPump", e, _hydroPumpReference);
                    this._hydroPump = value;
                    if ((old != null))
                    {
                        old.HydroPumpOpSchedule = null;
                        old.Deleted -= this.OnResetHydroPump;
                    }
                    if ((value != null))
                    {
                        value.HydroPumpOpSchedule = this;
                        value.Deleted += this.OnResetHydroPump;
                    }
                    this.OnHydroPumpChanged(e);
                    this.OnPropertyChanged("HydroPump", e, _hydroPumpReference);
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
                return base.ReferencedElements.Concat(new HydroPumpOpScheduleReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Generation/Production/HydroPu" +
                            "mpOpSchedule")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the HydroPump property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> HydroPumpChanging;
        
        /// <summary>
        /// Gets fired when the HydroPump property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> HydroPumpChanged;
        
        private static ITypedElement RetrieveHydroPumpReference()
        {
            return ((ITypedElement)(((ModelElement)(HydroPumpOpSchedule.ClassInstance)).Resolve("HydroPump")));
        }
        
        /// <summary>
        /// Raises the HydroPumpChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnHydroPumpChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.HydroPumpChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the HydroPumpChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnHydroPumpChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.HydroPumpChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the HydroPump property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetHydroPump(object sender, System.EventArgs eventArgs)
        {
            this.HydroPump = null;
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "HYDROPUMP"))
            {
                this.HydroPump = ((IHydroPump)(value));
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
            if ((attribute == "HydroPump"))
            {
                return new HydroPumpProxy(this);
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
            if ((reference == "HydroPump"))
            {
                return new HydroPumpProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Generation/Production/HydroPu" +
                        "mpOpSchedule")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the HydroPumpOpSchedule class
        /// </summary>
        public class HydroPumpOpScheduleReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private HydroPumpOpSchedule _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public HydroPumpOpScheduleReferencedElementsCollection(HydroPumpOpSchedule parent)
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
                    if ((this._parent.HydroPump != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.HydroPumpChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.HydroPumpChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.HydroPump == null))
                {
                    IHydroPump hydroPumpCasted = item.As<IHydroPump>();
                    if ((hydroPumpCasted != null))
                    {
                        this._parent.HydroPump = hydroPumpCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.HydroPump = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.HydroPump))
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
                if ((this._parent.HydroPump != null))
                {
                    array[arrayIndex] = this._parent.HydroPump;
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
                if ((this._parent.HydroPump == item))
                {
                    this._parent.HydroPump = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.HydroPump).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the HydroPump property
        /// </summary>
        private sealed class HydroPumpProxy : ModelPropertyChange<IHydroPumpOpSchedule, IHydroPump>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public HydroPumpProxy(IHydroPumpOpSchedule modelElement) : 
                    base(modelElement, "HydroPump")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IHydroPump Value
            {
                get
                {
                    return this.ModelElement.HydroPump;
                }
                set
                {
                    this.ModelElement.HydroPump = value;
                }
            }
        }
    }
}

