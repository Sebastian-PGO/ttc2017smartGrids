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
    /// The default implementation of the MarketCaseClearing class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#MarketOperations")]
    [XmlNamespacePrefixAttribute("cimMarketOperations")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/MarketOperations/" +
        "MarketCaseClearing")]
    [DebuggerDisplayAttribute("MarketCaseClearing {UUID}")]
    public partial class MarketCaseClearing : MarketFactors, IMarketCaseClearing, IModelElement
    {
        
        /// <summary>
        /// The backing field for the PostedDate property
        /// </summary>
        private DateTime _postedDate;
        
        private static Lazy<ITypedElement> _postedDateAttribute = new Lazy<ITypedElement>(RetrievePostedDateAttribute);
        
        /// <summary>
        /// The backing field for the CaseType property
        /// </summary>
        private string _caseType;
        
        private static Lazy<ITypedElement> _caseTypeAttribute = new Lazy<ITypedElement>(RetrieveCaseTypeAttribute);
        
        /// <summary>
        /// The backing field for the ModifiedDate property
        /// </summary>
        private DateTime _modifiedDate;
        
        private static Lazy<ITypedElement> _modifiedDateAttribute = new Lazy<ITypedElement>(RetrieveModifiedDateAttribute);
        
        private static Lazy<ITypedElement> _ancillaryServiceClearingReference = new Lazy<ITypedElement>(RetrieveAncillaryServiceClearingReference);
        
        /// <summary>
        /// The backing field for the AncillaryServiceClearing property
        /// </summary>
        private MarketCaseClearingAncillaryServiceClearingCollection _ancillaryServiceClearing;
        
        private static IClass _classInstance;
        
        public MarketCaseClearing()
        {
            this._ancillaryServiceClearing = new MarketCaseClearingAncillaryServiceClearingCollection(this);
            this._ancillaryServiceClearing.CollectionChanging += this.AncillaryServiceClearingCollectionChanging;
            this._ancillaryServiceClearing.CollectionChanged += this.AncillaryServiceClearingCollectionChanged;
        }
        
        /// <summary>
        /// The postedDate property
        /// </summary>
        [XmlElementNameAttribute("postedDate")]
        [XmlAttributeAttribute(true)]
        public virtual DateTime PostedDate
        {
            get
            {
                return this._postedDate;
            }
            set
            {
                if ((this._postedDate != value))
                {
                    DateTime old = this._postedDate;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnPostedDateChanging(e);
                    this.OnPropertyChanging("PostedDate", e, _postedDateAttribute);
                    this._postedDate = value;
                    this.OnPostedDateChanged(e);
                    this.OnPropertyChanged("PostedDate", e, _postedDateAttribute);
                }
            }
        }
        
        /// <summary>
        /// The caseType property
        /// </summary>
        [XmlElementNameAttribute("caseType")]
        [XmlAttributeAttribute(true)]
        public virtual string CaseType
        {
            get
            {
                return this._caseType;
            }
            set
            {
                if ((this._caseType != value))
                {
                    string old = this._caseType;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnCaseTypeChanging(e);
                    this.OnPropertyChanging("CaseType", e, _caseTypeAttribute);
                    this._caseType = value;
                    this.OnCaseTypeChanged(e);
                    this.OnPropertyChanged("CaseType", e, _caseTypeAttribute);
                }
            }
        }
        
        /// <summary>
        /// The modifiedDate property
        /// </summary>
        [XmlElementNameAttribute("modifiedDate")]
        [XmlAttributeAttribute(true)]
        public virtual DateTime ModifiedDate
        {
            get
            {
                return this._modifiedDate;
            }
            set
            {
                if ((this._modifiedDate != value))
                {
                    DateTime old = this._modifiedDate;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnModifiedDateChanging(e);
                    this.OnPropertyChanging("ModifiedDate", e, _modifiedDateAttribute);
                    this._modifiedDate = value;
                    this.OnModifiedDateChanged(e);
                    this.OnPropertyChanged("ModifiedDate", e, _modifiedDateAttribute);
                }
            }
        }
        
        /// <summary>
        /// The AncillaryServiceClearing property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("MarketCaseClearing")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<IAncillaryServiceClearing> AncillaryServiceClearing
        {
            get
            {
                return this._ancillaryServiceClearing;
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new MarketCaseClearingReferencedElementsCollection(this));
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
                            "MarketCaseClearing")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the PostedDate property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> PostedDateChanging;
        
        /// <summary>
        /// Gets fired when the PostedDate property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> PostedDateChanged;
        
        /// <summary>
        /// Gets fired before the CaseType property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> CaseTypeChanging;
        
        /// <summary>
        /// Gets fired when the CaseType property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> CaseTypeChanged;
        
        /// <summary>
        /// Gets fired before the ModifiedDate property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ModifiedDateChanging;
        
        /// <summary>
        /// Gets fired when the ModifiedDate property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ModifiedDateChanged;
        
        private static ITypedElement RetrievePostedDateAttribute()
        {
            return ((ITypedElement)(((ModelElement)(MarketCaseClearing.ClassInstance)).Resolve("postedDate")));
        }
        
        /// <summary>
        /// Raises the PostedDateChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnPostedDateChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.PostedDateChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the PostedDateChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnPostedDateChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.PostedDateChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveCaseTypeAttribute()
        {
            return ((ITypedElement)(((ModelElement)(MarketCaseClearing.ClassInstance)).Resolve("caseType")));
        }
        
        /// <summary>
        /// Raises the CaseTypeChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnCaseTypeChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.CaseTypeChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the CaseTypeChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnCaseTypeChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.CaseTypeChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveModifiedDateAttribute()
        {
            return ((ITypedElement)(((ModelElement)(MarketCaseClearing.ClassInstance)).Resolve("modifiedDate")));
        }
        
        /// <summary>
        /// Raises the ModifiedDateChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnModifiedDateChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ModifiedDateChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the ModifiedDateChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnModifiedDateChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ModifiedDateChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveAncillaryServiceClearingReference()
        {
            return ((ITypedElement)(((ModelElement)(MarketCaseClearing.ClassInstance)).Resolve("AncillaryServiceClearing")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the AncillaryServiceClearing property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void AncillaryServiceClearingCollectionChanging(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanging("AncillaryServiceClearing", e, _ancillaryServiceClearingReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the AncillaryServiceClearing property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void AncillaryServiceClearingCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("AncillaryServiceClearing", e, _ancillaryServiceClearingReference);
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "POSTEDDATE"))
            {
                return this.PostedDate;
            }
            if ((attribute == "CASETYPE"))
            {
                return this.CaseType;
            }
            if ((attribute == "MODIFIEDDATE"))
            {
                return this.ModifiedDate;
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
            if ((feature == "ANCILLARYSERVICECLEARING"))
            {
                return this._ancillaryServiceClearing;
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
            if ((feature == "POSTEDDATE"))
            {
                this.PostedDate = ((DateTime)(value));
                return;
            }
            if ((feature == "CASETYPE"))
            {
                this.CaseType = ((string)(value));
                return;
            }
            if ((feature == "MODIFIEDDATE"))
            {
                this.ModifiedDate = ((DateTime)(value));
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/MarketOperations/" +
                        "MarketCaseClearing")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the MarketCaseClearing class
        /// </summary>
        public class MarketCaseClearingReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private MarketCaseClearing _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public MarketCaseClearingReferencedElementsCollection(MarketCaseClearing parent)
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
                    count = (count + this._parent.AncillaryServiceClearing.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.AncillaryServiceClearing.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.AncillaryServiceClearing.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IAncillaryServiceClearing ancillaryServiceClearingCasted = item.As<IAncillaryServiceClearing>();
                if ((ancillaryServiceClearingCasted != null))
                {
                    this._parent.AncillaryServiceClearing.Add(ancillaryServiceClearingCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.AncillaryServiceClearing.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.AncillaryServiceClearing.Contains(item))
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
                IEnumerator<IModelElement> ancillaryServiceClearingEnumerator = this._parent.AncillaryServiceClearing.GetEnumerator();
                try
                {
                    for (
                    ; ancillaryServiceClearingEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = ancillaryServiceClearingEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    ancillaryServiceClearingEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IAncillaryServiceClearing ancillaryServiceClearingItem = item.As<IAncillaryServiceClearing>();
                if (((ancillaryServiceClearingItem != null) 
                            && this._parent.AncillaryServiceClearing.Remove(ancillaryServiceClearingItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.AncillaryServiceClearing).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the postedDate property
        /// </summary>
        private sealed class PostedDateProxy : ModelPropertyChange<IMarketCaseClearing, DateTime>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public PostedDateProxy(IMarketCaseClearing modelElement) : 
                    base(modelElement, "postedDate")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override DateTime Value
            {
                get
                {
                    return this.ModelElement.PostedDate;
                }
                set
                {
                    this.ModelElement.PostedDate = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the caseType property
        /// </summary>
        private sealed class CaseTypeProxy : ModelPropertyChange<IMarketCaseClearing, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public CaseTypeProxy(IMarketCaseClearing modelElement) : 
                    base(modelElement, "caseType")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override string Value
            {
                get
                {
                    return this.ModelElement.CaseType;
                }
                set
                {
                    this.ModelElement.CaseType = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the modifiedDate property
        /// </summary>
        private sealed class ModifiedDateProxy : ModelPropertyChange<IMarketCaseClearing, DateTime>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public ModifiedDateProxy(IMarketCaseClearing modelElement) : 
                    base(modelElement, "modifiedDate")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override DateTime Value
            {
                get
                {
                    return this.ModelElement.ModifiedDate;
                }
                set
                {
                    this.ModelElement.ModifiedDate = value;
                }
            }
        }
    }
}

