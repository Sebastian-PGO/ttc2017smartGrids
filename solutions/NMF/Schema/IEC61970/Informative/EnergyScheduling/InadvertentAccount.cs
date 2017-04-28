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
    /// The default implementation of the InadvertentAccount class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#EnergyScheduling")]
    [XmlNamespacePrefixAttribute("cimEnergyScheduling")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/EnergyScheduling/" +
        "InadvertentAccount")]
    [DebuggerDisplayAttribute("InadvertentAccount {UUID}")]
    public partial class InadvertentAccount : Curve, IInadvertentAccount, IModelElement
    {
        
        private static Lazy<ITypedElement> _hostControlAreaReference = new Lazy<ITypedElement>(RetrieveHostControlAreaReference);
        
        /// <summary>
        /// The backing field for the HostControlArea property
        /// </summary>
        private IHostControlArea _hostControlArea;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The HostControlArea property
        /// </summary>
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("InadvertentAccounts")]
        public virtual IHostControlArea HostControlArea
        {
            get
            {
                return this._hostControlArea;
            }
            set
            {
                if ((this._hostControlArea != value))
                {
                    IHostControlArea old = this._hostControlArea;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnHostControlAreaChanging(e);
                    this.OnPropertyChanging("HostControlArea", e, _hostControlAreaReference);
                    this._hostControlArea = value;
                    if ((old != null))
                    {
                        old.InadvertentAccounts.Remove(this);
                        old.Deleted -= this.OnResetHostControlArea;
                    }
                    if ((value != null))
                    {
                        value.InadvertentAccounts.Add(this);
                        value.Deleted += this.OnResetHostControlArea;
                    }
                    this.OnHostControlAreaChanged(e);
                    this.OnPropertyChanged("HostControlArea", e, _hostControlAreaReference);
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
                return base.ReferencedElements.Concat(new InadvertentAccountReferencedElementsCollection(this));
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
                            "InadvertentAccount")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the HostControlArea property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> HostControlAreaChanging;
        
        /// <summary>
        /// Gets fired when the HostControlArea property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> HostControlAreaChanged;
        
        private static ITypedElement RetrieveHostControlAreaReference()
        {
            return ((ITypedElement)(((ModelElement)(InadvertentAccount.ClassInstance)).Resolve("HostControlArea")));
        }
        
        /// <summary>
        /// Raises the HostControlAreaChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnHostControlAreaChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.HostControlAreaChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the HostControlAreaChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnHostControlAreaChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.HostControlAreaChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the HostControlArea property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetHostControlArea(object sender, System.EventArgs eventArgs)
        {
            this.HostControlArea = null;
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "HOSTCONTROLAREA"))
            {
                this.HostControlArea = ((IHostControlArea)(value));
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
            if ((attribute == "HostControlArea"))
            {
                return new HostControlAreaProxy(this);
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
            if ((reference == "HostControlArea"))
            {
                return new HostControlAreaProxy(this);
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
                        "InadvertentAccount")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the InadvertentAccount class
        /// </summary>
        public class InadvertentAccountReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private InadvertentAccount _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public InadvertentAccountReferencedElementsCollection(InadvertentAccount parent)
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
                    if ((this._parent.HostControlArea != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.HostControlAreaChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.HostControlAreaChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.HostControlArea == null))
                {
                    IHostControlArea hostControlAreaCasted = item.As<IHostControlArea>();
                    if ((hostControlAreaCasted != null))
                    {
                        this._parent.HostControlArea = hostControlAreaCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.HostControlArea = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.HostControlArea))
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
                if ((this._parent.HostControlArea != null))
                {
                    array[arrayIndex] = this._parent.HostControlArea;
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
                if ((this._parent.HostControlArea == item))
                {
                    this._parent.HostControlArea = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.HostControlArea).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the HostControlArea property
        /// </summary>
        private sealed class HostControlAreaProxy : ModelPropertyChange<IInadvertentAccount, IHostControlArea>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public HostControlAreaProxy(IInadvertentAccount modelElement) : 
                    base(modelElement, "HostControlArea")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IHostControlArea Value
            {
                get
                {
                    return this.ModelElement.HostControlArea;
                }
                set
                {
                    this.ModelElement.HostControlArea = value;
                }
            }
        }
    }
}

