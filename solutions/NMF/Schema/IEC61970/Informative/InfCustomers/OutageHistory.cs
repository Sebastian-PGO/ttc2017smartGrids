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
    /// The default implementation of the OutageHistory class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#InfCustomers")]
    [XmlNamespacePrefixAttribute("cimInfCustomers")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfCustomers/Outa" +
        "geHistory")]
    [DebuggerDisplayAttribute("OutageHistory {UUID}")]
    public partial class OutageHistory : Document, IOutageHistory, IModelElement
    {
        
        private static Lazy<ITypedElement> _outageReportsReference = new Lazy<ITypedElement>(RetrieveOutageReportsReference);
        
        /// <summary>
        /// The backing field for the OutageReports property
        /// </summary>
        private OutageHistoryOutageReportsCollection _outageReports;
        
        private static IClass _classInstance;
        
        public OutageHistory()
        {
            this._outageReports = new OutageHistoryOutageReportsCollection(this);
            this._outageReports.CollectionChanging += this.OutageReportsCollectionChanging;
            this._outageReports.CollectionChanged += this.OutageReportsCollectionChanged;
        }
        
        /// <summary>
        /// The OutageReports property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("OutageHistory")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<IOutageReport> OutageReports
        {
            get
            {
                return this._outageReports;
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new OutageHistoryReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfCustomers/Outa" +
                            "geHistory")));
                }
                return _classInstance;
            }
        }
        
        private static ITypedElement RetrieveOutageReportsReference()
        {
            return ((ITypedElement)(((ModelElement)(OutageHistory.ClassInstance)).Resolve("OutageReports")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the OutageReports property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void OutageReportsCollectionChanging(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanging("OutageReports", e, _outageReportsReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the OutageReports property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void OutageReportsCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("OutageReports", e, _outageReportsReference);
        }
        
        /// <summary>
        /// Gets the Model element collection for the given feature
        /// </summary>
        /// <returns>A non-generic list of elements</returns>
        /// <param name="feature">The requested feature</param>
        protected override System.Collections.IList GetCollectionForFeature(string feature)
        {
            if ((feature == "OUTAGEREPORTS"))
            {
                return this._outageReports;
            }
            return base.GetCollectionForFeature(feature);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override IClass GetClass()
        {
            if ((_classInstance == null))
            {
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfCustomers/Outa" +
                        "geHistory")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the OutageHistory class
        /// </summary>
        public class OutageHistoryReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private OutageHistory _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public OutageHistoryReferencedElementsCollection(OutageHistory parent)
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
                    count = (count + this._parent.OutageReports.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.OutageReports.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.OutageReports.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IOutageReport outageReportsCasted = item.As<IOutageReport>();
                if ((outageReportsCasted != null))
                {
                    this._parent.OutageReports.Add(outageReportsCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.OutageReports.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.OutageReports.Contains(item))
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
                IEnumerator<IModelElement> outageReportsEnumerator = this._parent.OutageReports.GetEnumerator();
                try
                {
                    for (
                    ; outageReportsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = outageReportsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    outageReportsEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IOutageReport outageReportItem = item.As<IOutageReport>();
                if (((outageReportItem != null) 
                            && this._parent.OutageReports.Remove(outageReportItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.OutageReports).GetEnumerator();
            }
        }
    }
}

