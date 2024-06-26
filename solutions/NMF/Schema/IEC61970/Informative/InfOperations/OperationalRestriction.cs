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
using TTC2017.SmartGrids.CIM.IEC61968.Assets;
using TTC2017.SmartGrids.CIM.IEC61968.Common;
using TTC2017.SmartGrids.CIM.IEC61968.Customers;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssets;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfCommon;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfCustomers;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfERPSupport;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfGMLSupport;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfWork;
using TTC2017.SmartGrids.CIM.IEC61970.Outage;

namespace TTC2017.SmartGrids.CIM.IEC61970.Informative.InfOperations
{
    
    
    /// <summary>
    /// The default implementation of the OperationalRestriction class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#InfOperations")]
    [XmlNamespacePrefixAttribute("cimInfOperations")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfOperations/Ope" +
        "rationalRestriction")]
    [DebuggerDisplayAttribute("OperationalRestriction {UUID}")]
    public partial class OperationalRestriction : Document, IOperationalRestriction, IModelElement
    {
        
        private static Lazy<ITypedElement> _activePeriodReference = new Lazy<ITypedElement>(RetrieveActivePeriodReference);
        
        /// <summary>
        /// The backing field for the ActivePeriod property
        /// </summary>
        private IDateTimeInterval _activePeriod;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The activePeriod property
        /// </summary>
        [XmlElementNameAttribute("activePeriod")]
        [XmlAttributeAttribute(true)]
        public virtual IDateTimeInterval ActivePeriod
        {
            get
            {
                return this._activePeriod;
            }
            set
            {
                if ((this._activePeriod != value))
                {
                    IDateTimeInterval old = this._activePeriod;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnActivePeriodChanging(e);
                    this.OnPropertyChanging("ActivePeriod", e, _activePeriodReference);
                    this._activePeriod = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetActivePeriod;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetActivePeriod;
                    }
                    this.OnActivePeriodChanged(e);
                    this.OnPropertyChanged("ActivePeriod", e, _activePeriodReference);
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
                return base.ReferencedElements.Concat(new OperationalRestrictionReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfOperations/Ope" +
                            "rationalRestriction")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the ActivePeriod property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ActivePeriodChanging;
        
        /// <summary>
        /// Gets fired when the ActivePeriod property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ActivePeriodChanged;
        
        private static ITypedElement RetrieveActivePeriodReference()
        {
            return ((ITypedElement)(((ModelElement)(OperationalRestriction.ClassInstance)).Resolve("activePeriod")));
        }
        
        /// <summary>
        /// Raises the ActivePeriodChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnActivePeriodChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ActivePeriodChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the ActivePeriodChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnActivePeriodChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ActivePeriodChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the ActivePeriod property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetActivePeriod(object sender, System.EventArgs eventArgs)
        {
            this.ActivePeriod = null;
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "ACTIVEPERIOD"))
            {
                this.ActivePeriod = ((IDateTimeInterval)(value));
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
            if ((attribute == "ActivePeriod"))
            {
                return new ActivePeriodProxy(this);
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
            if ((reference == "ActivePeriod"))
            {
                return new ActivePeriodProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfOperations/Ope" +
                        "rationalRestriction")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the OperationalRestriction class
        /// </summary>
        public class OperationalRestrictionReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private OperationalRestriction _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public OperationalRestrictionReferencedElementsCollection(OperationalRestriction parent)
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
                    if ((this._parent.ActivePeriod != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.ActivePeriodChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.ActivePeriodChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.ActivePeriod == null))
                {
                    IDateTimeInterval activePeriodCasted = item.As<IDateTimeInterval>();
                    if ((activePeriodCasted != null))
                    {
                        this._parent.ActivePeriod = activePeriodCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.ActivePeriod = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.ActivePeriod))
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
                if ((this._parent.ActivePeriod != null))
                {
                    array[arrayIndex] = this._parent.ActivePeriod;
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
                if ((this._parent.ActivePeriod == item))
                {
                    this._parent.ActivePeriod = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.ActivePeriod).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the activePeriod property
        /// </summary>
        private sealed class ActivePeriodProxy : ModelPropertyChange<IOperationalRestriction, IDateTimeInterval>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public ActivePeriodProxy(IOperationalRestriction modelElement) : 
                    base(modelElement, "activePeriod")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IDateTimeInterval Value
            {
                get
                {
                    return this.ModelElement.ActivePeriod;
                }
                set
                {
                    this.ModelElement.ActivePeriod = value;
                }
            }
        }
    }
}

