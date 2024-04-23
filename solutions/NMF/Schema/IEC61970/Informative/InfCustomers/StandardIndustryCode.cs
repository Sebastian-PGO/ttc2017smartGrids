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
    /// The default implementation of the StandardIndustryCode class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#InfCustomers")]
    [XmlNamespacePrefixAttribute("cimInfCustomers")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfCustomers/Stan" +
        "dardIndustryCode")]
    [DebuggerDisplayAttribute("StandardIndustryCode {UUID}")]
    public partial class StandardIndustryCode : Document, IStandardIndustryCode, IModelElement
    {
        
        /// <summary>
        /// The backing field for the Code property
        /// </summary>
        private string _code;
        
        private static Lazy<ITypedElement> _codeAttribute = new Lazy<ITypedElement>(RetrieveCodeAttribute);
        
        private static Lazy<ITypedElement> _customerAgreementsReference = new Lazy<ITypedElement>(RetrieveCustomerAgreementsReference);
        
        /// <summary>
        /// The backing field for the CustomerAgreements property
        /// </summary>
        private StandardIndustryCodeCustomerAgreementsCollection _customerAgreements;
        
        private static IClass _classInstance;
        
        public StandardIndustryCode()
        {
            this._customerAgreements = new StandardIndustryCodeCustomerAgreementsCollection(this);
            this._customerAgreements.CollectionChanging += this.CustomerAgreementsCollectionChanging;
            this._customerAgreements.CollectionChanged += this.CustomerAgreementsCollectionChanged;
        }
        
        /// <summary>
        /// The code property
        /// </summary>
        [XmlElementNameAttribute("code")]
        [XmlAttributeAttribute(true)]
        public virtual string Code
        {
            get
            {
                return this._code;
            }
            set
            {
                if ((this._code != value))
                {
                    string old = this._code;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnCodeChanging(e);
                    this.OnPropertyChanging("Code", e, _codeAttribute);
                    this._code = value;
                    this.OnCodeChanged(e);
                    this.OnPropertyChanged("Code", e, _codeAttribute);
                }
            }
        }
        
        /// <summary>
        /// The CustomerAgreements property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("StandardIndustryCode")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<ICustomerAgreement> CustomerAgreements
        {
            get
            {
                return this._customerAgreements;
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new StandardIndustryCodeReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfCustomers/Stan" +
                            "dardIndustryCode")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the Code property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> CodeChanging;
        
        /// <summary>
        /// Gets fired when the Code property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> CodeChanged;
        
        private static ITypedElement RetrieveCodeAttribute()
        {
            return ((ITypedElement)(((ModelElement)(StandardIndustryCode.ClassInstance)).Resolve("code")));
        }
        
        /// <summary>
        /// Raises the CodeChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnCodeChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.CodeChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the CodeChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnCodeChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.CodeChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveCustomerAgreementsReference()
        {
            return ((ITypedElement)(((ModelElement)(StandardIndustryCode.ClassInstance)).Resolve("CustomerAgreements")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the CustomerAgreements property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void CustomerAgreementsCollectionChanging(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanging("CustomerAgreements", e, _customerAgreementsReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the CustomerAgreements property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void CustomerAgreementsCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("CustomerAgreements", e, _customerAgreementsReference);
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "CODE"))
            {
                return this.Code;
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
            if ((feature == "CUSTOMERAGREEMENTS"))
            {
                return this._customerAgreements;
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
            if ((feature == "CODE"))
            {
                this.Code = ((string)(value));
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfCustomers/Stan" +
                        "dardIndustryCode")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the StandardIndustryCode class
        /// </summary>
        public class StandardIndustryCodeReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private StandardIndustryCode _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public StandardIndustryCodeReferencedElementsCollection(StandardIndustryCode parent)
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
                    count = (count + this._parent.CustomerAgreements.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.CustomerAgreements.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.CustomerAgreements.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                ICustomerAgreement customerAgreementsCasted = item.As<ICustomerAgreement>();
                if ((customerAgreementsCasted != null))
                {
                    this._parent.CustomerAgreements.Add(customerAgreementsCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.CustomerAgreements.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.CustomerAgreements.Contains(item))
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
                IEnumerator<IModelElement> customerAgreementsEnumerator = this._parent.CustomerAgreements.GetEnumerator();
                try
                {
                    for (
                    ; customerAgreementsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = customerAgreementsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    customerAgreementsEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                ICustomerAgreement customerAgreementItem = item.As<ICustomerAgreement>();
                if (((customerAgreementItem != null) 
                            && this._parent.CustomerAgreements.Remove(customerAgreementItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.CustomerAgreements).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the code property
        /// </summary>
        private sealed class CodeProxy : ModelPropertyChange<IStandardIndustryCode, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public CodeProxy(IStandardIndustryCode modelElement) : 
                    base(modelElement, "code")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override string Value
            {
                get
                {
                    return this.ModelElement.Code;
                }
                set
                {
                    this.ModelElement.Code = value;
                }
            }
        }
    }
}

