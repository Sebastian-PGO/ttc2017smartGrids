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
    /// The default implementation of the OutageReport class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#InfOperations")]
    [XmlNamespacePrefixAttribute("cimInfOperations")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfOperations/Out" +
        "ageReport")]
    [DebuggerDisplayAttribute("OutageReport {UUID}")]
    public partial class OutageReport : Document, IOutageReport, IModelElement
    {
        
        /// <summary>
        /// The backing field for the CustomerCount property
        /// </summary>
        private int _customerCount;
        
        private static Lazy<ITypedElement> _customerCountAttribute = new Lazy<ITypedElement>(RetrieveCustomerCountAttribute);
        
        /// <summary>
        /// The backing field for the OutageDuration property
        /// </summary>
        private float _outageDuration;
        
        private static Lazy<ITypedElement> _outageDurationAttribute = new Lazy<ITypedElement>(RetrieveOutageDurationAttribute);
        
        /// <summary>
        /// The backing field for the AverageCml property
        /// </summary>
        private float _averageCml;
        
        private static Lazy<ITypedElement> _averageCmlAttribute = new Lazy<ITypedElement>(RetrieveAverageCmlAttribute);
        
        /// <summary>
        /// The backing field for the TotalCml property
        /// </summary>
        private float _totalCml;
        
        private static Lazy<ITypedElement> _totalCmlAttribute = new Lazy<ITypedElement>(RetrieveTotalCmlAttribute);
        
        private static Lazy<ITypedElement> _outageRecordReference = new Lazy<ITypedElement>(RetrieveOutageRecordReference);
        
        /// <summary>
        /// The backing field for the OutageRecord property
        /// </summary>
        private IOutageRecord _outageRecord;
        
        private static Lazy<ITypedElement> _outageHistoryReference = new Lazy<ITypedElement>(RetrieveOutageHistoryReference);
        
        /// <summary>
        /// The backing field for the OutageHistory property
        /// </summary>
        private IOutageHistory _outageHistory;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The customerCount property
        /// </summary>
        [XmlElementNameAttribute("customerCount")]
        [XmlAttributeAttribute(true)]
        public virtual int CustomerCount
        {
            get
            {
                return this._customerCount;
            }
            set
            {
                if ((this._customerCount != value))
                {
                    int old = this._customerCount;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnCustomerCountChanging(e);
                    this.OnPropertyChanging("CustomerCount", e, _customerCountAttribute);
                    this._customerCount = value;
                    this.OnCustomerCountChanged(e);
                    this.OnPropertyChanged("CustomerCount", e, _customerCountAttribute);
                }
            }
        }
        
        /// <summary>
        /// The outageDuration property
        /// </summary>
        [XmlElementNameAttribute("outageDuration")]
        [XmlAttributeAttribute(true)]
        public virtual float OutageDuration
        {
            get
            {
                return this._outageDuration;
            }
            set
            {
                if ((this._outageDuration != value))
                {
                    float old = this._outageDuration;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnOutageDurationChanging(e);
                    this.OnPropertyChanging("OutageDuration", e, _outageDurationAttribute);
                    this._outageDuration = value;
                    this.OnOutageDurationChanged(e);
                    this.OnPropertyChanged("OutageDuration", e, _outageDurationAttribute);
                }
            }
        }
        
        /// <summary>
        /// The averageCml property
        /// </summary>
        [XmlElementNameAttribute("averageCml")]
        [XmlAttributeAttribute(true)]
        public virtual float AverageCml
        {
            get
            {
                return this._averageCml;
            }
            set
            {
                if ((this._averageCml != value))
                {
                    float old = this._averageCml;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnAverageCmlChanging(e);
                    this.OnPropertyChanging("AverageCml", e, _averageCmlAttribute);
                    this._averageCml = value;
                    this.OnAverageCmlChanged(e);
                    this.OnPropertyChanged("AverageCml", e, _averageCmlAttribute);
                }
            }
        }
        
        /// <summary>
        /// The totalCml property
        /// </summary>
        [XmlElementNameAttribute("totalCml")]
        [XmlAttributeAttribute(true)]
        public virtual float TotalCml
        {
            get
            {
                return this._totalCml;
            }
            set
            {
                if ((this._totalCml != value))
                {
                    float old = this._totalCml;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnTotalCmlChanging(e);
                    this.OnPropertyChanging("TotalCml", e, _totalCmlAttribute);
                    this._totalCml = value;
                    this.OnTotalCmlChanged(e);
                    this.OnPropertyChanged("TotalCml", e, _totalCmlAttribute);
                }
            }
        }
        
        /// <summary>
        /// The OutageRecord property
        /// </summary>
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("OutageReport")]
        public virtual IOutageRecord OutageRecord
        {
            get
            {
                return this._outageRecord;
            }
            set
            {
                if ((this._outageRecord != value))
                {
                    IOutageRecord old = this._outageRecord;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnOutageRecordChanging(e);
                    this.OnPropertyChanging("OutageRecord", e, _outageRecordReference);
                    this._outageRecord = value;
                    if ((old != null))
                    {
                        old.OutageReport = null;
                        old.Deleted -= this.OnResetOutageRecord;
                    }
                    if ((value != null))
                    {
                        value.OutageReport = this;
                        value.Deleted += this.OnResetOutageRecord;
                    }
                    this.OnOutageRecordChanged(e);
                    this.OnPropertyChanged("OutageRecord", e, _outageRecordReference);
                }
            }
        }
        
        /// <summary>
        /// The OutageHistory property
        /// </summary>
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("OutageReports")]
        public virtual IOutageHistory OutageHistory
        {
            get
            {
                return this._outageHistory;
            }
            set
            {
                if ((this._outageHistory != value))
                {
                    IOutageHistory old = this._outageHistory;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnOutageHistoryChanging(e);
                    this.OnPropertyChanging("OutageHistory", e, _outageHistoryReference);
                    this._outageHistory = value;
                    if ((old != null))
                    {
                        old.OutageReports.Remove(this);
                        old.Deleted -= this.OnResetOutageHistory;
                    }
                    if ((value != null))
                    {
                        value.OutageReports.Add(this);
                        value.Deleted += this.OnResetOutageHistory;
                    }
                    this.OnOutageHistoryChanged(e);
                    this.OnPropertyChanged("OutageHistory", e, _outageHistoryReference);
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
                return base.ReferencedElements.Concat(new OutageReportReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfOperations/Out" +
                            "ageReport")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the CustomerCount property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> CustomerCountChanging;
        
        /// <summary>
        /// Gets fired when the CustomerCount property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> CustomerCountChanged;
        
        /// <summary>
        /// Gets fired before the OutageDuration property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> OutageDurationChanging;
        
        /// <summary>
        /// Gets fired when the OutageDuration property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> OutageDurationChanged;
        
        /// <summary>
        /// Gets fired before the AverageCml property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> AverageCmlChanging;
        
        /// <summary>
        /// Gets fired when the AverageCml property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> AverageCmlChanged;
        
        /// <summary>
        /// Gets fired before the TotalCml property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> TotalCmlChanging;
        
        /// <summary>
        /// Gets fired when the TotalCml property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> TotalCmlChanged;
        
        /// <summary>
        /// Gets fired before the OutageRecord property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> OutageRecordChanging;
        
        /// <summary>
        /// Gets fired when the OutageRecord property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> OutageRecordChanged;
        
        /// <summary>
        /// Gets fired before the OutageHistory property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> OutageHistoryChanging;
        
        /// <summary>
        /// Gets fired when the OutageHistory property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> OutageHistoryChanged;
        
        private static ITypedElement RetrieveCustomerCountAttribute()
        {
            return ((ITypedElement)(((ModelElement)(OutageReport.ClassInstance)).Resolve("customerCount")));
        }
        
        /// <summary>
        /// Raises the CustomerCountChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnCustomerCountChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.CustomerCountChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the CustomerCountChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnCustomerCountChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.CustomerCountChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveOutageDurationAttribute()
        {
            return ((ITypedElement)(((ModelElement)(OutageReport.ClassInstance)).Resolve("outageDuration")));
        }
        
        /// <summary>
        /// Raises the OutageDurationChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnOutageDurationChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.OutageDurationChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the OutageDurationChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnOutageDurationChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.OutageDurationChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveAverageCmlAttribute()
        {
            return ((ITypedElement)(((ModelElement)(OutageReport.ClassInstance)).Resolve("averageCml")));
        }
        
        /// <summary>
        /// Raises the AverageCmlChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnAverageCmlChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.AverageCmlChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the AverageCmlChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnAverageCmlChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.AverageCmlChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveTotalCmlAttribute()
        {
            return ((ITypedElement)(((ModelElement)(OutageReport.ClassInstance)).Resolve("totalCml")));
        }
        
        /// <summary>
        /// Raises the TotalCmlChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnTotalCmlChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.TotalCmlChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the TotalCmlChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnTotalCmlChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.TotalCmlChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveOutageRecordReference()
        {
            return ((ITypedElement)(((ModelElement)(OutageReport.ClassInstance)).Resolve("OutageRecord")));
        }
        
        /// <summary>
        /// Raises the OutageRecordChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnOutageRecordChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.OutageRecordChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the OutageRecordChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnOutageRecordChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.OutageRecordChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the OutageRecord property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetOutageRecord(object sender, System.EventArgs eventArgs)
        {
            this.OutageRecord = null;
        }
        
        private static ITypedElement RetrieveOutageHistoryReference()
        {
            return ((ITypedElement)(((ModelElement)(OutageReport.ClassInstance)).Resolve("OutageHistory")));
        }
        
        /// <summary>
        /// Raises the OutageHistoryChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnOutageHistoryChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.OutageHistoryChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the OutageHistoryChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnOutageHistoryChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.OutageHistoryChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the OutageHistory property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetOutageHistory(object sender, System.EventArgs eventArgs)
        {
            this.OutageHistory = null;
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "CUSTOMERCOUNT"))
            {
                return this.CustomerCount;
            }
            if ((attribute == "OUTAGEDURATION"))
            {
                return this.OutageDuration;
            }
            if ((attribute == "AVERAGECML"))
            {
                return this.AverageCml;
            }
            if ((attribute == "TOTALCML"))
            {
                return this.TotalCml;
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
            if ((feature == "OUTAGERECORD"))
            {
                this.OutageRecord = ((IOutageRecord)(value));
                return;
            }
            if ((feature == "OUTAGEHISTORY"))
            {
                this.OutageHistory = ((IOutageHistory)(value));
                return;
            }
            if ((feature == "CUSTOMERCOUNT"))
            {
                this.CustomerCount = ((int)(value));
                return;
            }
            if ((feature == "OUTAGEDURATION"))
            {
                this.OutageDuration = ((float)(value));
                return;
            }
            if ((feature == "AVERAGECML"))
            {
                this.AverageCml = ((float)(value));
                return;
            }
            if ((feature == "TOTALCML"))
            {
                this.TotalCml = ((float)(value));
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
            if ((attribute == "OutageRecord"))
            {
                return new OutageRecordProxy(this);
            }
            if ((attribute == "OutageHistory"))
            {
                return new OutageHistoryProxy(this);
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
            if ((reference == "OutageRecord"))
            {
                return new OutageRecordProxy(this);
            }
            if ((reference == "OutageHistory"))
            {
                return new OutageHistoryProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfOperations/Out" +
                        "ageReport")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the OutageReport class
        /// </summary>
        public class OutageReportReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private OutageReport _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public OutageReportReferencedElementsCollection(OutageReport parent)
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
                    if ((this._parent.OutageRecord != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.OutageHistory != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.OutageRecordChanged += this.PropagateValueChanges;
                this._parent.OutageHistoryChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.OutageRecordChanged -= this.PropagateValueChanges;
                this._parent.OutageHistoryChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.OutageRecord == null))
                {
                    IOutageRecord outageRecordCasted = item.As<IOutageRecord>();
                    if ((outageRecordCasted != null))
                    {
                        this._parent.OutageRecord = outageRecordCasted;
                        return;
                    }
                }
                if ((this._parent.OutageHistory == null))
                {
                    IOutageHistory outageHistoryCasted = item.As<IOutageHistory>();
                    if ((outageHistoryCasted != null))
                    {
                        this._parent.OutageHistory = outageHistoryCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.OutageRecord = null;
                this._parent.OutageHistory = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.OutageRecord))
                {
                    return true;
                }
                if ((item == this._parent.OutageHistory))
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
                if ((this._parent.OutageRecord != null))
                {
                    array[arrayIndex] = this._parent.OutageRecord;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.OutageHistory != null))
                {
                    array[arrayIndex] = this._parent.OutageHistory;
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
                if ((this._parent.OutageRecord == item))
                {
                    this._parent.OutageRecord = null;
                    return true;
                }
                if ((this._parent.OutageHistory == item))
                {
                    this._parent.OutageHistory = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.OutageRecord).Concat(this._parent.OutageHistory).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the customerCount property
        /// </summary>
        private sealed class CustomerCountProxy : ModelPropertyChange<IOutageReport, int>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public CustomerCountProxy(IOutageReport modelElement) : 
                    base(modelElement, "customerCount")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override int Value
            {
                get
                {
                    return this.ModelElement.CustomerCount;
                }
                set
                {
                    this.ModelElement.CustomerCount = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the outageDuration property
        /// </summary>
        private sealed class OutageDurationProxy : ModelPropertyChange<IOutageReport, float>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public OutageDurationProxy(IOutageReport modelElement) : 
                    base(modelElement, "outageDuration")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override float Value
            {
                get
                {
                    return this.ModelElement.OutageDuration;
                }
                set
                {
                    this.ModelElement.OutageDuration = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the averageCml property
        /// </summary>
        private sealed class AverageCmlProxy : ModelPropertyChange<IOutageReport, float>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public AverageCmlProxy(IOutageReport modelElement) : 
                    base(modelElement, "averageCml")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override float Value
            {
                get
                {
                    return this.ModelElement.AverageCml;
                }
                set
                {
                    this.ModelElement.AverageCml = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the totalCml property
        /// </summary>
        private sealed class TotalCmlProxy : ModelPropertyChange<IOutageReport, float>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public TotalCmlProxy(IOutageReport modelElement) : 
                    base(modelElement, "totalCml")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override float Value
            {
                get
                {
                    return this.ModelElement.TotalCml;
                }
                set
                {
                    this.ModelElement.TotalCml = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the OutageRecord property
        /// </summary>
        private sealed class OutageRecordProxy : ModelPropertyChange<IOutageReport, IOutageRecord>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public OutageRecordProxy(IOutageReport modelElement) : 
                    base(modelElement, "OutageRecord")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IOutageRecord Value
            {
                get
                {
                    return this.ModelElement.OutageRecord;
                }
                set
                {
                    this.ModelElement.OutageRecord = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the OutageHistory property
        /// </summary>
        private sealed class OutageHistoryProxy : ModelPropertyChange<IOutageReport, IOutageHistory>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public OutageHistoryProxy(IOutageReport modelElement) : 
                    base(modelElement, "OutageHistory")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IOutageHistory Value
            {
                get
                {
                    return this.ModelElement.OutageHistory;
                }
                set
                {
                    this.ModelElement.OutageHistory = value;
                }
            }
        }
    }
}

