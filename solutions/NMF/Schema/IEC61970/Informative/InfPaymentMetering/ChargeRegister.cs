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
using TTC2017.SmartGrids.CIM.IEC61968.PaymentMetering;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfCommon;

namespace TTC2017.SmartGrids.CIM.IEC61970.Informative.InfPaymentMetering
{
    
    
    /// <summary>
    /// The default implementation of the ChargeRegister class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#InfPaymentMetering")]
    [XmlNamespacePrefixAttribute("cimInfPaymentMetering")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfPaymentMeterin" +
        "g/ChargeRegister")]
    [DebuggerDisplayAttribute("ChargeRegister {UUID}")]
    public partial class ChargeRegister : IdentifiedObject, IChargeRegister, IModelElement
    {
        
        /// <summary>
        /// The backing field for the ChargeKind property
        /// </summary>
        private Nullable<ChargeKind> _chargeKind;
        
        private static Lazy<ITypedElement> _chargeKindAttribute = new Lazy<ITypedElement>(RetrieveChargeKindAttribute);
        
        private static Lazy<ITypedElement> _sPAccountingFunctionReference = new Lazy<ITypedElement>(RetrieveSPAccountingFunctionReference);
        
        /// <summary>
        /// The backing field for the SPAccountingFunction property
        /// </summary>
        private ISDPAccountingFunction _sPAccountingFunction;
        
        private static Lazy<ITypedElement> _chargeAmountReference = new Lazy<ITypedElement>(RetrieveChargeAmountReference);
        
        /// <summary>
        /// The backing field for the ChargeAmount property
        /// </summary>
        private IAccountingUnit _chargeAmount;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The chargeKind property
        /// </summary>
        [XmlElementNameAttribute("chargeKind")]
        [XmlAttributeAttribute(true)]
        public virtual Nullable<ChargeKind> ChargeKind
        {
            get
            {
                return this._chargeKind;
            }
            set
            {
                if ((this._chargeKind != value))
                {
                    Nullable<ChargeKind> old = this._chargeKind;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnChargeKindChanging(e);
                    this.OnPropertyChanging("ChargeKind", e, _chargeKindAttribute);
                    this._chargeKind = value;
                    this.OnChargeKindChanged(e);
                    this.OnPropertyChanged("ChargeKind", e, _chargeKindAttribute);
                }
            }
        }
        
        /// <summary>
        /// The SPAccountingFunction property
        /// </summary>
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("ChargeRegisters")]
        public virtual ISDPAccountingFunction SPAccountingFunction
        {
            get
            {
                return this._sPAccountingFunction;
            }
            set
            {
                if ((this._sPAccountingFunction != value))
                {
                    ISDPAccountingFunction old = this._sPAccountingFunction;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnSPAccountingFunctionChanging(e);
                    this.OnPropertyChanging("SPAccountingFunction", e, _sPAccountingFunctionReference);
                    this._sPAccountingFunction = value;
                    if ((old != null))
                    {
                        old.ChargeRegisters.Remove(this);
                        old.Deleted -= this.OnResetSPAccountingFunction;
                    }
                    if ((value != null))
                    {
                        value.ChargeRegisters.Add(this);
                        value.Deleted += this.OnResetSPAccountingFunction;
                    }
                    this.OnSPAccountingFunctionChanged(e);
                    this.OnPropertyChanged("SPAccountingFunction", e, _sPAccountingFunctionReference);
                }
            }
        }
        
        /// <summary>
        /// The chargeAmount property
        /// </summary>
        [XmlElementNameAttribute("chargeAmount")]
        [XmlAttributeAttribute(true)]
        public virtual IAccountingUnit ChargeAmount
        {
            get
            {
                return this._chargeAmount;
            }
            set
            {
                if ((this._chargeAmount != value))
                {
                    IAccountingUnit old = this._chargeAmount;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnChargeAmountChanging(e);
                    this.OnPropertyChanging("ChargeAmount", e, _chargeAmountReference);
                    this._chargeAmount = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetChargeAmount;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetChargeAmount;
                    }
                    this.OnChargeAmountChanged(e);
                    this.OnPropertyChanged("ChargeAmount", e, _chargeAmountReference);
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
                return base.ReferencedElements.Concat(new ChargeRegisterReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfPaymentMeterin" +
                            "g/ChargeRegister")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the ChargeKind property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ChargeKindChanging;
        
        /// <summary>
        /// Gets fired when the ChargeKind property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ChargeKindChanged;
        
        /// <summary>
        /// Gets fired before the SPAccountingFunction property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> SPAccountingFunctionChanging;
        
        /// <summary>
        /// Gets fired when the SPAccountingFunction property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> SPAccountingFunctionChanged;
        
        /// <summary>
        /// Gets fired before the ChargeAmount property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ChargeAmountChanging;
        
        /// <summary>
        /// Gets fired when the ChargeAmount property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ChargeAmountChanged;
        
        private static ITypedElement RetrieveChargeKindAttribute()
        {
            return ((ITypedElement)(((ModelElement)(ChargeRegister.ClassInstance)).Resolve("chargeKind")));
        }
        
        /// <summary>
        /// Raises the ChargeKindChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnChargeKindChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ChargeKindChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the ChargeKindChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnChargeKindChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ChargeKindChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveSPAccountingFunctionReference()
        {
            return ((ITypedElement)(((ModelElement)(ChargeRegister.ClassInstance)).Resolve("SPAccountingFunction")));
        }
        
        /// <summary>
        /// Raises the SPAccountingFunctionChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnSPAccountingFunctionChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.SPAccountingFunctionChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the SPAccountingFunctionChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnSPAccountingFunctionChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.SPAccountingFunctionChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the SPAccountingFunction property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetSPAccountingFunction(object sender, System.EventArgs eventArgs)
        {
            this.SPAccountingFunction = null;
        }
        
        private static ITypedElement RetrieveChargeAmountReference()
        {
            return ((ITypedElement)(((ModelElement)(ChargeRegister.ClassInstance)).Resolve("chargeAmount")));
        }
        
        /// <summary>
        /// Raises the ChargeAmountChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnChargeAmountChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ChargeAmountChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the ChargeAmountChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnChargeAmountChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ChargeAmountChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the ChargeAmount property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetChargeAmount(object sender, System.EventArgs eventArgs)
        {
            this.ChargeAmount = null;
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "CHARGEKIND"))
            {
                return this.ChargeKind;
            }
            return base.GetAttributeValue(attribute, index);
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "SPACCOUNTINGFUNCTION"))
            {
                this.SPAccountingFunction = ((ISDPAccountingFunction)(value));
                return;
            }
            if ((feature == "CHARGEAMOUNT"))
            {
                this.ChargeAmount = ((IAccountingUnit)(value));
                return;
            }
            if ((feature == "CHARGEKIND"))
            {
                this.ChargeKind = ((ChargeKind)(value));
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
            if ((attribute == "SPAccountingFunction"))
            {
                return new SPAccountingFunctionProxy(this);
            }
            if ((attribute == "ChargeAmount"))
            {
                return new ChargeAmountProxy(this);
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
            if ((reference == "SPAccountingFunction"))
            {
                return new SPAccountingFunctionProxy(this);
            }
            if ((reference == "ChargeAmount"))
            {
                return new ChargeAmountProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfPaymentMeterin" +
                        "g/ChargeRegister")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the ChargeRegister class
        /// </summary>
        public class ChargeRegisterReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private ChargeRegister _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public ChargeRegisterReferencedElementsCollection(ChargeRegister parent)
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
                    if ((this._parent.SPAccountingFunction != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.ChargeAmount != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.SPAccountingFunctionChanged += this.PropagateValueChanges;
                this._parent.ChargeAmountChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.SPAccountingFunctionChanged -= this.PropagateValueChanges;
                this._parent.ChargeAmountChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.SPAccountingFunction == null))
                {
                    ISDPAccountingFunction sPAccountingFunctionCasted = item.As<ISDPAccountingFunction>();
                    if ((sPAccountingFunctionCasted != null))
                    {
                        this._parent.SPAccountingFunction = sPAccountingFunctionCasted;
                        return;
                    }
                }
                if ((this._parent.ChargeAmount == null))
                {
                    IAccountingUnit chargeAmountCasted = item.As<IAccountingUnit>();
                    if ((chargeAmountCasted != null))
                    {
                        this._parent.ChargeAmount = chargeAmountCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.SPAccountingFunction = null;
                this._parent.ChargeAmount = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.SPAccountingFunction))
                {
                    return true;
                }
                if ((item == this._parent.ChargeAmount))
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
                if ((this._parent.SPAccountingFunction != null))
                {
                    array[arrayIndex] = this._parent.SPAccountingFunction;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.ChargeAmount != null))
                {
                    array[arrayIndex] = this._parent.ChargeAmount;
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
                if ((this._parent.SPAccountingFunction == item))
                {
                    this._parent.SPAccountingFunction = null;
                    return true;
                }
                if ((this._parent.ChargeAmount == item))
                {
                    this._parent.ChargeAmount = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.SPAccountingFunction).Concat(this._parent.ChargeAmount).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the chargeKind property
        /// </summary>
        private sealed class ChargeKindProxy : ModelPropertyChange<IChargeRegister, Nullable<ChargeKind>>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public ChargeKindProxy(IChargeRegister modelElement) : 
                    base(modelElement, "chargeKind")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override Nullable<ChargeKind> Value
            {
                get
                {
                    return this.ModelElement.ChargeKind;
                }
                set
                {
                    this.ModelElement.ChargeKind = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the SPAccountingFunction property
        /// </summary>
        private sealed class SPAccountingFunctionProxy : ModelPropertyChange<IChargeRegister, ISDPAccountingFunction>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public SPAccountingFunctionProxy(IChargeRegister modelElement) : 
                    base(modelElement, "SPAccountingFunction")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override ISDPAccountingFunction Value
            {
                get
                {
                    return this.ModelElement.SPAccountingFunction;
                }
                set
                {
                    this.ModelElement.SPAccountingFunction = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the chargeAmount property
        /// </summary>
        private sealed class ChargeAmountProxy : ModelPropertyChange<IChargeRegister, IAccountingUnit>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public ChargeAmountProxy(IChargeRegister modelElement) : 
                    base(modelElement, "chargeAmount")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IAccountingUnit Value
            {
                get
                {
                    return this.ModelElement.ChargeAmount;
                }
                set
                {
                    this.ModelElement.ChargeAmount = value;
                }
            }
        }
    }
}

