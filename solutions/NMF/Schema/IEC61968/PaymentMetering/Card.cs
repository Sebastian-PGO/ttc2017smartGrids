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
    /// The default implementation of the Card class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#PaymentMetering")]
    [XmlNamespacePrefixAttribute("cimPaymentMetering")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61968/PaymentMetering/Card")]
    [DebuggerDisplayAttribute("Card {UUID}")]
    public partial class Card : Element, ICard, IModelElement
    {
        
        /// <summary>
        /// The backing field for the CvNumber property
        /// </summary>
        private string _cvNumber;
        
        private static Lazy<ITypedElement> _cvNumberAttribute = new Lazy<ITypedElement>(RetrieveCvNumberAttribute);
        
        /// <summary>
        /// The backing field for the ExpiryDate property
        /// </summary>
        private string _expiryDate;
        
        private static Lazy<ITypedElement> _expiryDateAttribute = new Lazy<ITypedElement>(RetrieveExpiryDateAttribute);
        
        /// <summary>
        /// The backing field for the Pan property
        /// </summary>
        private string _pan;
        
        private static Lazy<ITypedElement> _panAttribute = new Lazy<ITypedElement>(RetrievePanAttribute);
        
        /// <summary>
        /// The backing field for the AccountHolderName property
        /// </summary>
        private string _accountHolderName;
        
        private static Lazy<ITypedElement> _accountHolderNameAttribute = new Lazy<ITypedElement>(RetrieveAccountHolderNameAttribute);
        
        private static Lazy<ITypedElement> _tenderReference = new Lazy<ITypedElement>(RetrieveTenderReference);
        
        /// <summary>
        /// The backing field for the Tender property
        /// </summary>
        private ITender _tender;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The cvNumber property
        /// </summary>
        [XmlElementNameAttribute("cvNumber")]
        [XmlAttributeAttribute(true)]
        public virtual string CvNumber
        {
            get
            {
                return this._cvNumber;
            }
            set
            {
                if ((this._cvNumber != value))
                {
                    string old = this._cvNumber;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnCvNumberChanging(e);
                    this.OnPropertyChanging("CvNumber", e, _cvNumberAttribute);
                    this._cvNumber = value;
                    this.OnCvNumberChanged(e);
                    this.OnPropertyChanged("CvNumber", e, _cvNumberAttribute);
                }
            }
        }
        
        /// <summary>
        /// The expiryDate property
        /// </summary>
        [XmlElementNameAttribute("expiryDate")]
        [XmlAttributeAttribute(true)]
        public virtual string ExpiryDate
        {
            get
            {
                return this._expiryDate;
            }
            set
            {
                if ((this._expiryDate != value))
                {
                    string old = this._expiryDate;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnExpiryDateChanging(e);
                    this.OnPropertyChanging("ExpiryDate", e, _expiryDateAttribute);
                    this._expiryDate = value;
                    this.OnExpiryDateChanged(e);
                    this.OnPropertyChanged("ExpiryDate", e, _expiryDateAttribute);
                }
            }
        }
        
        /// <summary>
        /// The pan property
        /// </summary>
        [XmlElementNameAttribute("pan")]
        [XmlAttributeAttribute(true)]
        public virtual string Pan
        {
            get
            {
                return this._pan;
            }
            set
            {
                if ((this._pan != value))
                {
                    string old = this._pan;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnPanChanging(e);
                    this.OnPropertyChanging("Pan", e, _panAttribute);
                    this._pan = value;
                    this.OnPanChanged(e);
                    this.OnPropertyChanged("Pan", e, _panAttribute);
                }
            }
        }
        
        /// <summary>
        /// The accountHolderName property
        /// </summary>
        [XmlElementNameAttribute("accountHolderName")]
        [XmlAttributeAttribute(true)]
        public virtual string AccountHolderName
        {
            get
            {
                return this._accountHolderName;
            }
            set
            {
                if ((this._accountHolderName != value))
                {
                    string old = this._accountHolderName;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnAccountHolderNameChanging(e);
                    this.OnPropertyChanging("AccountHolderName", e, _accountHolderNameAttribute);
                    this._accountHolderName = value;
                    this.OnAccountHolderNameChanged(e);
                    this.OnPropertyChanged("AccountHolderName", e, _accountHolderNameAttribute);
                }
            }
        }
        
        /// <summary>
        /// The Tender property
        /// </summary>
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("Card")]
        public virtual ITender Tender
        {
            get
            {
                return this._tender;
            }
            set
            {
                if ((this._tender != value))
                {
                    ITender old = this._tender;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnTenderChanging(e);
                    this.OnPropertyChanging("Tender", e, _tenderReference);
                    this._tender = value;
                    if ((old != null))
                    {
                        old.Card = null;
                        old.Deleted -= this.OnResetTender;
                    }
                    if ((value != null))
                    {
                        value.Card = this;
                        value.Deleted += this.OnResetTender;
                    }
                    this.OnTenderChanged(e);
                    this.OnPropertyChanged("Tender", e, _tenderReference);
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
                return base.ReferencedElements.Concat(new CardReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61968/PaymentMetering/Card")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the CvNumber property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> CvNumberChanging;
        
        /// <summary>
        /// Gets fired when the CvNumber property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> CvNumberChanged;
        
        /// <summary>
        /// Gets fired before the ExpiryDate property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ExpiryDateChanging;
        
        /// <summary>
        /// Gets fired when the ExpiryDate property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ExpiryDateChanged;
        
        /// <summary>
        /// Gets fired before the Pan property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> PanChanging;
        
        /// <summary>
        /// Gets fired when the Pan property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> PanChanged;
        
        /// <summary>
        /// Gets fired before the AccountHolderName property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> AccountHolderNameChanging;
        
        /// <summary>
        /// Gets fired when the AccountHolderName property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> AccountHolderNameChanged;
        
        /// <summary>
        /// Gets fired before the Tender property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> TenderChanging;
        
        /// <summary>
        /// Gets fired when the Tender property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> TenderChanged;
        
        private static ITypedElement RetrieveCvNumberAttribute()
        {
            return ((ITypedElement)(((ModelElement)(Card.ClassInstance)).Resolve("cvNumber")));
        }
        
        /// <summary>
        /// Raises the CvNumberChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnCvNumberChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.CvNumberChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the CvNumberChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnCvNumberChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.CvNumberChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveExpiryDateAttribute()
        {
            return ((ITypedElement)(((ModelElement)(Card.ClassInstance)).Resolve("expiryDate")));
        }
        
        /// <summary>
        /// Raises the ExpiryDateChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnExpiryDateChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ExpiryDateChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the ExpiryDateChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnExpiryDateChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ExpiryDateChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrievePanAttribute()
        {
            return ((ITypedElement)(((ModelElement)(Card.ClassInstance)).Resolve("pan")));
        }
        
        /// <summary>
        /// Raises the PanChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnPanChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.PanChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the PanChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnPanChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.PanChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveAccountHolderNameAttribute()
        {
            return ((ITypedElement)(((ModelElement)(Card.ClassInstance)).Resolve("accountHolderName")));
        }
        
        /// <summary>
        /// Raises the AccountHolderNameChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnAccountHolderNameChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.AccountHolderNameChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the AccountHolderNameChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnAccountHolderNameChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.AccountHolderNameChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveTenderReference()
        {
            return ((ITypedElement)(((ModelElement)(Card.ClassInstance)).Resolve("Tender")));
        }
        
        /// <summary>
        /// Raises the TenderChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnTenderChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.TenderChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the TenderChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnTenderChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.TenderChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the Tender property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetTender(object sender, System.EventArgs eventArgs)
        {
            this.Tender = null;
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "CVNUMBER"))
            {
                return this.CvNumber;
            }
            if ((attribute == "EXPIRYDATE"))
            {
                return this.ExpiryDate;
            }
            if ((attribute == "PAN"))
            {
                return this.Pan;
            }
            if ((attribute == "ACCOUNTHOLDERNAME"))
            {
                return this.AccountHolderName;
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
            if ((feature == "TENDER"))
            {
                this.Tender = ((ITender)(value));
                return;
            }
            if ((feature == "CVNUMBER"))
            {
                this.CvNumber = ((string)(value));
                return;
            }
            if ((feature == "EXPIRYDATE"))
            {
                this.ExpiryDate = ((string)(value));
                return;
            }
            if ((feature == "PAN"))
            {
                this.Pan = ((string)(value));
                return;
            }
            if ((feature == "ACCOUNTHOLDERNAME"))
            {
                this.AccountHolderName = ((string)(value));
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
            if ((attribute == "Tender"))
            {
                return new TenderProxy(this);
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
            if ((reference == "Tender"))
            {
                return new TenderProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61968/PaymentMetering/Card")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the Card class
        /// </summary>
        public class CardReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private Card _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public CardReferencedElementsCollection(Card parent)
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
                    if ((this._parent.Tender != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.TenderChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.TenderChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.Tender == null))
                {
                    ITender tenderCasted = item.As<ITender>();
                    if ((tenderCasted != null))
                    {
                        this._parent.Tender = tenderCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.Tender = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.Tender))
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
                if ((this._parent.Tender != null))
                {
                    array[arrayIndex] = this._parent.Tender;
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
                if ((this._parent.Tender == item))
                {
                    this._parent.Tender = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.Tender).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the cvNumber property
        /// </summary>
        private sealed class CvNumberProxy : ModelPropertyChange<ICard, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public CvNumberProxy(ICard modelElement) : 
                    base(modelElement, "cvNumber")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override string Value
            {
                get
                {
                    return this.ModelElement.CvNumber;
                }
                set
                {
                    this.ModelElement.CvNumber = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the expiryDate property
        /// </summary>
        private sealed class ExpiryDateProxy : ModelPropertyChange<ICard, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public ExpiryDateProxy(ICard modelElement) : 
                    base(modelElement, "expiryDate")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override string Value
            {
                get
                {
                    return this.ModelElement.ExpiryDate;
                }
                set
                {
                    this.ModelElement.ExpiryDate = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the pan property
        /// </summary>
        private sealed class PanProxy : ModelPropertyChange<ICard, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public PanProxy(ICard modelElement) : 
                    base(modelElement, "pan")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override string Value
            {
                get
                {
                    return this.ModelElement.Pan;
                }
                set
                {
                    this.ModelElement.Pan = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the accountHolderName property
        /// </summary>
        private sealed class AccountHolderNameProxy : ModelPropertyChange<ICard, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public AccountHolderNameProxy(ICard modelElement) : 
                    base(modelElement, "accountHolderName")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override string Value
            {
                get
                {
                    return this.ModelElement.AccountHolderName;
                }
                set
                {
                    this.ModelElement.AccountHolderName = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the Tender property
        /// </summary>
        private sealed class TenderProxy : ModelPropertyChange<ICard, ITender>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public TenderProxy(ICard modelElement) : 
                    base(modelElement, "Tender")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override ITender Value
            {
                get
                {
                    return this.ModelElement.Tender;
                }
                set
                {
                    this.ModelElement.Tender = value;
                }
            }
        }
    }
}

