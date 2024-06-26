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
    /// The default implementation of the CashierShift class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#PaymentMetering")]
    [XmlNamespacePrefixAttribute("cimPaymentMetering")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61968/PaymentMetering/CashierShift")]
    [DebuggerDisplayAttribute("CashierShift {UUID}")]
    public partial class CashierShift : Shift, ICashierShift, IModelElement
    {
        
        /// <summary>
        /// The backing field for the CashFloat property
        /// </summary>
        private float _cashFloat;
        
        private static Lazy<ITypedElement> _cashFloatAttribute = new Lazy<ITypedElement>(RetrieveCashFloatAttribute);
        
        private static Lazy<ITypedElement> _cashierReference = new Lazy<ITypedElement>(RetrieveCashierReference);
        
        /// <summary>
        /// The backing field for the Cashier property
        /// </summary>
        private ICashier _cashier;
        
        private static Lazy<ITypedElement> _pointOfSaleReference = new Lazy<ITypedElement>(RetrievePointOfSaleReference);
        
        /// <summary>
        /// The backing field for the PointOfSale property
        /// </summary>
        private IPointOfSale _pointOfSale;
        
        private static Lazy<ITypedElement> _receiptsReference = new Lazy<ITypedElement>(RetrieveReceiptsReference);
        
        /// <summary>
        /// The backing field for the Receipts property
        /// </summary>
        private CashierShiftReceiptsCollection _receipts;
        
        private static Lazy<ITypedElement> _transactionsReference = new Lazy<ITypedElement>(RetrieveTransactionsReference);
        
        /// <summary>
        /// The backing field for the Transactions property
        /// </summary>
        private CashierShiftTransactionsCollection _transactions;
        
        private static IClass _classInstance;
        
        public CashierShift()
        {
            this._receipts = new CashierShiftReceiptsCollection(this);
            this._receipts.CollectionChanging += this.ReceiptsCollectionChanging;
            this._receipts.CollectionChanged += this.ReceiptsCollectionChanged;
            this._transactions = new CashierShiftTransactionsCollection(this);
            this._transactions.CollectionChanging += this.TransactionsCollectionChanging;
            this._transactions.CollectionChanged += this.TransactionsCollectionChanged;
        }
        
        /// <summary>
        /// The cashFloat property
        /// </summary>
        [XmlElementNameAttribute("cashFloat")]
        [XmlAttributeAttribute(true)]
        public virtual float CashFloat
        {
            get
            {
                return this._cashFloat;
            }
            set
            {
                if ((this._cashFloat != value))
                {
                    float old = this._cashFloat;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnCashFloatChanging(e);
                    this.OnPropertyChanging("CashFloat", e, _cashFloatAttribute);
                    this._cashFloat = value;
                    this.OnCashFloatChanged(e);
                    this.OnPropertyChanged("CashFloat", e, _cashFloatAttribute);
                }
            }
        }
        
        /// <summary>
        /// The Cashier property
        /// </summary>
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("CashierShifts")]
        public virtual ICashier Cashier
        {
            get
            {
                return this._cashier;
            }
            set
            {
                if ((this._cashier != value))
                {
                    ICashier old = this._cashier;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnCashierChanging(e);
                    this.OnPropertyChanging("Cashier", e, _cashierReference);
                    this._cashier = value;
                    if ((old != null))
                    {
                        old.CashierShifts.Remove(this);
                        old.Deleted -= this.OnResetCashier;
                    }
                    if ((value != null))
                    {
                        value.CashierShifts.Add(this);
                        value.Deleted += this.OnResetCashier;
                    }
                    this.OnCashierChanged(e);
                    this.OnPropertyChanged("Cashier", e, _cashierReference);
                }
            }
        }
        
        /// <summary>
        /// The PointOfSale property
        /// </summary>
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("CashierShifts")]
        public virtual IPointOfSale PointOfSale
        {
            get
            {
                return this._pointOfSale;
            }
            set
            {
                if ((this._pointOfSale != value))
                {
                    IPointOfSale old = this._pointOfSale;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnPointOfSaleChanging(e);
                    this.OnPropertyChanging("PointOfSale", e, _pointOfSaleReference);
                    this._pointOfSale = value;
                    if ((old != null))
                    {
                        old.CashierShifts.Remove(this);
                        old.Deleted -= this.OnResetPointOfSale;
                    }
                    if ((value != null))
                    {
                        value.CashierShifts.Add(this);
                        value.Deleted += this.OnResetPointOfSale;
                    }
                    this.OnPointOfSaleChanged(e);
                    this.OnPropertyChanged("PointOfSale", e, _pointOfSaleReference);
                }
            }
        }
        
        /// <summary>
        /// The Receipts property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("CashierShift")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<IReceipt> Receipts
        {
            get
            {
                return this._receipts;
            }
        }
        
        /// <summary>
        /// The Transactions property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("CashierShift")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<ITransaction> Transactions
        {
            get
            {
                return this._transactions;
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new CashierShiftReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61968/PaymentMetering/CashierShift")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the CashFloat property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> CashFloatChanging;
        
        /// <summary>
        /// Gets fired when the CashFloat property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> CashFloatChanged;
        
        /// <summary>
        /// Gets fired before the Cashier property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> CashierChanging;
        
        /// <summary>
        /// Gets fired when the Cashier property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> CashierChanged;
        
        /// <summary>
        /// Gets fired before the PointOfSale property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> PointOfSaleChanging;
        
        /// <summary>
        /// Gets fired when the PointOfSale property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> PointOfSaleChanged;
        
        private static ITypedElement RetrieveCashFloatAttribute()
        {
            return ((ITypedElement)(((ModelElement)(CashierShift.ClassInstance)).Resolve("cashFloat")));
        }
        
        /// <summary>
        /// Raises the CashFloatChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnCashFloatChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.CashFloatChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the CashFloatChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnCashFloatChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.CashFloatChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveCashierReference()
        {
            return ((ITypedElement)(((ModelElement)(CashierShift.ClassInstance)).Resolve("Cashier")));
        }
        
        /// <summary>
        /// Raises the CashierChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnCashierChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.CashierChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the CashierChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnCashierChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.CashierChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the Cashier property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetCashier(object sender, System.EventArgs eventArgs)
        {
            this.Cashier = null;
        }
        
        private static ITypedElement RetrievePointOfSaleReference()
        {
            return ((ITypedElement)(((ModelElement)(CashierShift.ClassInstance)).Resolve("PointOfSale")));
        }
        
        /// <summary>
        /// Raises the PointOfSaleChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnPointOfSaleChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.PointOfSaleChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the PointOfSaleChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnPointOfSaleChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.PointOfSaleChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the PointOfSale property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetPointOfSale(object sender, System.EventArgs eventArgs)
        {
            this.PointOfSale = null;
        }
        
        private static ITypedElement RetrieveReceiptsReference()
        {
            return ((ITypedElement)(((ModelElement)(CashierShift.ClassInstance)).Resolve("Receipts")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the Receipts property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void ReceiptsCollectionChanging(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanging("Receipts", e, _receiptsReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the Receipts property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void ReceiptsCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("Receipts", e, _receiptsReference);
        }
        
        private static ITypedElement RetrieveTransactionsReference()
        {
            return ((ITypedElement)(((ModelElement)(CashierShift.ClassInstance)).Resolve("Transactions")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the Transactions property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void TransactionsCollectionChanging(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanging("Transactions", e, _transactionsReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the Transactions property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void TransactionsCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("Transactions", e, _transactionsReference);
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "CASHFLOAT"))
            {
                return this.CashFloat;
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
            if ((feature == "RECEIPTS"))
            {
                return this._receipts;
            }
            if ((feature == "TRANSACTIONS"))
            {
                return this._transactions;
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
            if ((feature == "CASHIER"))
            {
                this.Cashier = ((ICashier)(value));
                return;
            }
            if ((feature == "POINTOFSALE"))
            {
                this.PointOfSale = ((IPointOfSale)(value));
                return;
            }
            if ((feature == "CASHFLOAT"))
            {
                this.CashFloat = ((float)(value));
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
            if ((attribute == "Cashier"))
            {
                return new CashierProxy(this);
            }
            if ((attribute == "PointOfSale"))
            {
                return new PointOfSaleProxy(this);
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
            if ((reference == "Cashier"))
            {
                return new CashierProxy(this);
            }
            if ((reference == "PointOfSale"))
            {
                return new PointOfSaleProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61968/PaymentMetering/CashierShift")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the CashierShift class
        /// </summary>
        public class CashierShiftReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private CashierShift _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public CashierShiftReferencedElementsCollection(CashierShift parent)
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
                    if ((this._parent.Cashier != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.PointOfSale != null))
                    {
                        count = (count + 1);
                    }
                    count = (count + this._parent.Receipts.Count);
                    count = (count + this._parent.Transactions.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.CashierChanged += this.PropagateValueChanges;
                this._parent.PointOfSaleChanged += this.PropagateValueChanges;
                this._parent.Receipts.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.Transactions.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.CashierChanged -= this.PropagateValueChanges;
                this._parent.PointOfSaleChanged -= this.PropagateValueChanges;
                this._parent.Receipts.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.Transactions.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.Cashier == null))
                {
                    ICashier cashierCasted = item.As<ICashier>();
                    if ((cashierCasted != null))
                    {
                        this._parent.Cashier = cashierCasted;
                        return;
                    }
                }
                if ((this._parent.PointOfSale == null))
                {
                    IPointOfSale pointOfSaleCasted = item.As<IPointOfSale>();
                    if ((pointOfSaleCasted != null))
                    {
                        this._parent.PointOfSale = pointOfSaleCasted;
                        return;
                    }
                }
                IReceipt receiptsCasted = item.As<IReceipt>();
                if ((receiptsCasted != null))
                {
                    this._parent.Receipts.Add(receiptsCasted);
                }
                ITransaction transactionsCasted = item.As<ITransaction>();
                if ((transactionsCasted != null))
                {
                    this._parent.Transactions.Add(transactionsCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.Cashier = null;
                this._parent.PointOfSale = null;
                this._parent.Receipts.Clear();
                this._parent.Transactions.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.Cashier))
                {
                    return true;
                }
                if ((item == this._parent.PointOfSale))
                {
                    return true;
                }
                if (this._parent.Receipts.Contains(item))
                {
                    return true;
                }
                if (this._parent.Transactions.Contains(item))
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
                if ((this._parent.Cashier != null))
                {
                    array[arrayIndex] = this._parent.Cashier;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.PointOfSale != null))
                {
                    array[arrayIndex] = this._parent.PointOfSale;
                    arrayIndex = (arrayIndex + 1);
                }
                IEnumerator<IModelElement> receiptsEnumerator = this._parent.Receipts.GetEnumerator();
                try
                {
                    for (
                    ; receiptsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = receiptsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    receiptsEnumerator.Dispose();
                }
                IEnumerator<IModelElement> transactionsEnumerator = this._parent.Transactions.GetEnumerator();
                try
                {
                    for (
                    ; transactionsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = transactionsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    transactionsEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                if ((this._parent.Cashier == item))
                {
                    this._parent.Cashier = null;
                    return true;
                }
                if ((this._parent.PointOfSale == item))
                {
                    this._parent.PointOfSale = null;
                    return true;
                }
                IReceipt receiptItem = item.As<IReceipt>();
                if (((receiptItem != null) 
                            && this._parent.Receipts.Remove(receiptItem)))
                {
                    return true;
                }
                ITransaction transactionItem = item.As<ITransaction>();
                if (((transactionItem != null) 
                            && this._parent.Transactions.Remove(transactionItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.Cashier).Concat(this._parent.PointOfSale).Concat(this._parent.Receipts).Concat(this._parent.Transactions).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the cashFloat property
        /// </summary>
        private sealed class CashFloatProxy : ModelPropertyChange<ICashierShift, float>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public CashFloatProxy(ICashierShift modelElement) : 
                    base(modelElement, "cashFloat")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override float Value
            {
                get
                {
                    return this.ModelElement.CashFloat;
                }
                set
                {
                    this.ModelElement.CashFloat = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the Cashier property
        /// </summary>
        private sealed class CashierProxy : ModelPropertyChange<ICashierShift, ICashier>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public CashierProxy(ICashierShift modelElement) : 
                    base(modelElement, "Cashier")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override ICashier Value
            {
                get
                {
                    return this.ModelElement.Cashier;
                }
                set
                {
                    this.ModelElement.Cashier = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the PointOfSale property
        /// </summary>
        private sealed class PointOfSaleProxy : ModelPropertyChange<ICashierShift, IPointOfSale>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public PointOfSaleProxy(ICashierShift modelElement) : 
                    base(modelElement, "PointOfSale")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IPointOfSale Value
            {
                get
                {
                    return this.ModelElement.PointOfSale;
                }
                set
                {
                    this.ModelElement.PointOfSale = value;
                }
            }
        }
    }
}

