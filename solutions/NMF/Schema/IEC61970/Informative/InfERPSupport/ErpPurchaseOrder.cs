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
using TTC2017.SmartGrids.CIM.IEC61968.AssetModels;
using TTC2017.SmartGrids.CIM.IEC61968.Assets;
using TTC2017.SmartGrids.CIM.IEC61968.Common;
using TTC2017.SmartGrids.CIM.IEC61968.Customers;
using TTC2017.SmartGrids.CIM.IEC61968.Work;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.Financial;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssetModels;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssets;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfCommon;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfCustomers;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfLocations;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfOperations;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfTypeAsset;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfWork;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.MarketOperations;
using TTC2017.SmartGrids.CIM.IEC61970.Meas;

namespace TTC2017.SmartGrids.CIM.IEC61970.Informative.InfERPSupport
{
    
    
    /// <summary>
    /// The default implementation of the ErpPurchaseOrder class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#InfERPSupport")]
    [XmlNamespacePrefixAttribute("cimInfERPSupport")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfERPSupport/Erp" +
        "PurchaseOrder")]
    [DebuggerDisplayAttribute("ErpPurchaseOrder {UUID}")]
    public partial class ErpPurchaseOrder : Document, IErpPurchaseOrder, IModelElement
    {
        
        private static Lazy<ITypedElement> _erpPOLineItemsReference = new Lazy<ITypedElement>(RetrieveErpPOLineItemsReference);
        
        /// <summary>
        /// The backing field for the ErpPOLineItems property
        /// </summary>
        private ErpPurchaseOrderErpPOLineItemsCollection _erpPOLineItems;
        
        private static IClass _classInstance;
        
        public ErpPurchaseOrder()
        {
            this._erpPOLineItems = new ErpPurchaseOrderErpPOLineItemsCollection(this);
            this._erpPOLineItems.CollectionChanging += this.ErpPOLineItemsCollectionChanging;
            this._erpPOLineItems.CollectionChanged += this.ErpPOLineItemsCollectionChanged;
        }
        
        /// <summary>
        /// The ErpPOLineItems property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("ErpPurchaseOrder")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<IErpPOLineItem> ErpPOLineItems
        {
            get
            {
                return this._erpPOLineItems;
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new ErpPurchaseOrderReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfERPSupport/Erp" +
                            "PurchaseOrder")));
                }
                return _classInstance;
            }
        }
        
        private static ITypedElement RetrieveErpPOLineItemsReference()
        {
            return ((ITypedElement)(((ModelElement)(ErpPurchaseOrder.ClassInstance)).Resolve("ErpPOLineItems")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the ErpPOLineItems property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void ErpPOLineItemsCollectionChanging(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanging("ErpPOLineItems", e, _erpPOLineItemsReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the ErpPOLineItems property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void ErpPOLineItemsCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("ErpPOLineItems", e, _erpPOLineItemsReference);
        }
        
        /// <summary>
        /// Gets the Model element collection for the given feature
        /// </summary>
        /// <returns>A non-generic list of elements</returns>
        /// <param name="feature">The requested feature</param>
        protected override System.Collections.IList GetCollectionForFeature(string feature)
        {
            if ((feature == "ERPPOLINEITEMS"))
            {
                return this._erpPOLineItems;
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfERPSupport/Erp" +
                        "PurchaseOrder")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the ErpPurchaseOrder class
        /// </summary>
        public class ErpPurchaseOrderReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private ErpPurchaseOrder _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public ErpPurchaseOrderReferencedElementsCollection(ErpPurchaseOrder parent)
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
                    count = (count + this._parent.ErpPOLineItems.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.ErpPOLineItems.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.ErpPOLineItems.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IErpPOLineItem erpPOLineItemsCasted = item.As<IErpPOLineItem>();
                if ((erpPOLineItemsCasted != null))
                {
                    this._parent.ErpPOLineItems.Add(erpPOLineItemsCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.ErpPOLineItems.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.ErpPOLineItems.Contains(item))
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
                IEnumerator<IModelElement> erpPOLineItemsEnumerator = this._parent.ErpPOLineItems.GetEnumerator();
                try
                {
                    for (
                    ; erpPOLineItemsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = erpPOLineItemsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    erpPOLineItemsEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IErpPOLineItem erpPOLineItemItem = item.As<IErpPOLineItem>();
                if (((erpPOLineItemItem != null) 
                            && this._parent.ErpPOLineItems.Remove(erpPOLineItemItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.ErpPOLineItems).GetEnumerator();
            }
        }
    }
}

