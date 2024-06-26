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
    /// The default implementation of the OutageCode class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#InfOperations")]
    [XmlNamespacePrefixAttribute("cimInfOperations")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfOperations/Out" +
        "ageCode")]
    [DebuggerDisplayAttribute("OutageCode {UUID}")]
    public partial class OutageCode : IdentifiedObject, IOutageCode, IModelElement
    {
        
        /// <summary>
        /// The backing field for the SubCode property
        /// </summary>
        private string _subCode;
        
        private static Lazy<ITypedElement> _subCodeAttribute = new Lazy<ITypedElement>(RetrieveSubCodeAttribute);
        
        private static Lazy<ITypedElement> _outageRecordsReference = new Lazy<ITypedElement>(RetrieveOutageRecordsReference);
        
        /// <summary>
        /// The backing field for the OutageRecords property
        /// </summary>
        private OutageCodeOutageRecordsCollection _outageRecords;
        
        private static Lazy<ITypedElement> _outageStepsReference = new Lazy<ITypedElement>(RetrieveOutageStepsReference);
        
        /// <summary>
        /// The backing field for the OutageSteps property
        /// </summary>
        private OutageCodeOutageStepsCollection _outageSteps;
        
        private static IClass _classInstance;
        
        public OutageCode()
        {
            this._outageRecords = new OutageCodeOutageRecordsCollection(this);
            this._outageRecords.CollectionChanging += this.OutageRecordsCollectionChanging;
            this._outageRecords.CollectionChanged += this.OutageRecordsCollectionChanged;
            this._outageSteps = new OutageCodeOutageStepsCollection(this);
            this._outageSteps.CollectionChanging += this.OutageStepsCollectionChanging;
            this._outageSteps.CollectionChanged += this.OutageStepsCollectionChanged;
        }
        
        /// <summary>
        /// The subCode property
        /// </summary>
        [XmlElementNameAttribute("subCode")]
        [XmlAttributeAttribute(true)]
        public virtual string SubCode
        {
            get
            {
                return this._subCode;
            }
            set
            {
                if ((this._subCode != value))
                {
                    string old = this._subCode;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnSubCodeChanging(e);
                    this.OnPropertyChanging("SubCode", e, _subCodeAttribute);
                    this._subCode = value;
                    this.OnSubCodeChanged(e);
                    this.OnPropertyChanged("SubCode", e, _subCodeAttribute);
                }
            }
        }
        
        /// <summary>
        /// The OutageRecords property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("OutageCodes")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<IOutageRecord> OutageRecords
        {
            get
            {
                return this._outageRecords;
            }
        }
        
        /// <summary>
        /// The OutageSteps property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("OutageCodes")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<IOutageStep> OutageSteps
        {
            get
            {
                return this._outageSteps;
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new OutageCodeReferencedElementsCollection(this));
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
                            "ageCode")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the SubCode property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> SubCodeChanging;
        
        /// <summary>
        /// Gets fired when the SubCode property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> SubCodeChanged;
        
        private static ITypedElement RetrieveSubCodeAttribute()
        {
            return ((ITypedElement)(((ModelElement)(OutageCode.ClassInstance)).Resolve("subCode")));
        }
        
        /// <summary>
        /// Raises the SubCodeChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnSubCodeChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.SubCodeChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the SubCodeChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnSubCodeChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.SubCodeChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveOutageRecordsReference()
        {
            return ((ITypedElement)(((ModelElement)(OutageCode.ClassInstance)).Resolve("OutageRecords")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the OutageRecords property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void OutageRecordsCollectionChanging(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanging("OutageRecords", e, _outageRecordsReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the OutageRecords property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void OutageRecordsCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("OutageRecords", e, _outageRecordsReference);
        }
        
        private static ITypedElement RetrieveOutageStepsReference()
        {
            return ((ITypedElement)(((ModelElement)(OutageCode.ClassInstance)).Resolve("OutageSteps")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the OutageSteps property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void OutageStepsCollectionChanging(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanging("OutageSteps", e, _outageStepsReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the OutageSteps property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void OutageStepsCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("OutageSteps", e, _outageStepsReference);
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "SUBCODE"))
            {
                return this.SubCode;
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
            if ((feature == "OUTAGERECORDS"))
            {
                return this._outageRecords;
            }
            if ((feature == "OUTAGESTEPS"))
            {
                return this._outageSteps;
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
            if ((feature == "SUBCODE"))
            {
                this.SubCode = ((string)(value));
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfOperations/Out" +
                        "ageCode")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the OutageCode class
        /// </summary>
        public class OutageCodeReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private OutageCode _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public OutageCodeReferencedElementsCollection(OutageCode parent)
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
                    count = (count + this._parent.OutageRecords.Count);
                    count = (count + this._parent.OutageSteps.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.OutageRecords.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.OutageSteps.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.OutageRecords.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.OutageSteps.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IOutageRecord outageRecordsCasted = item.As<IOutageRecord>();
                if ((outageRecordsCasted != null))
                {
                    this._parent.OutageRecords.Add(outageRecordsCasted);
                }
                IOutageStep outageStepsCasted = item.As<IOutageStep>();
                if ((outageStepsCasted != null))
                {
                    this._parent.OutageSteps.Add(outageStepsCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.OutageRecords.Clear();
                this._parent.OutageSteps.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.OutageRecords.Contains(item))
                {
                    return true;
                }
                if (this._parent.OutageSteps.Contains(item))
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
                IEnumerator<IModelElement> outageRecordsEnumerator = this._parent.OutageRecords.GetEnumerator();
                try
                {
                    for (
                    ; outageRecordsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = outageRecordsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    outageRecordsEnumerator.Dispose();
                }
                IEnumerator<IModelElement> outageStepsEnumerator = this._parent.OutageSteps.GetEnumerator();
                try
                {
                    for (
                    ; outageStepsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = outageStepsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    outageStepsEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IOutageRecord outageRecordItem = item.As<IOutageRecord>();
                if (((outageRecordItem != null) 
                            && this._parent.OutageRecords.Remove(outageRecordItem)))
                {
                    return true;
                }
                IOutageStep outageStepItem = item.As<IOutageStep>();
                if (((outageStepItem != null) 
                            && this._parent.OutageSteps.Remove(outageStepItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.OutageRecords).Concat(this._parent.OutageSteps).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the subCode property
        /// </summary>
        private sealed class SubCodeProxy : ModelPropertyChange<IOutageCode, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public SubCodeProxy(IOutageCode modelElement) : 
                    base(modelElement, "subCode")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override string Value
            {
                get
                {
                    return this.ModelElement.SubCode;
                }
                set
                {
                    this.ModelElement.SubCode = value;
                }
            }
        }
    }
}

