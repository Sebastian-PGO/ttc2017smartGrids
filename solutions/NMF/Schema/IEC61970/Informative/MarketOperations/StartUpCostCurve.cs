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
    /// The default implementation of the StartUpCostCurve class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#MarketOperations")]
    [XmlNamespacePrefixAttribute("cimMarketOperations")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/MarketOperations/" +
        "StartUpCostCurve")]
    [DebuggerDisplayAttribute("StartUpCostCurve {UUID}")]
    public partial class StartUpCostCurve : Curve, IStartUpCostCurve, IModelElement
    {
        
        private static Lazy<ITypedElement> _generatingBidsReference = new Lazy<ITypedElement>(RetrieveGeneratingBidsReference);
        
        /// <summary>
        /// The backing field for the GeneratingBids property
        /// </summary>
        private StartUpCostCurveGeneratingBidsCollection _generatingBids;
        
        private static Lazy<ITypedElement> _registeredGeneratorsReference = new Lazy<ITypedElement>(RetrieveRegisteredGeneratorsReference);
        
        /// <summary>
        /// The backing field for the RegisteredGenerators property
        /// </summary>
        private StartUpCostCurveRegisteredGeneratorsCollection _registeredGenerators;
        
        private static IClass _classInstance;
        
        public StartUpCostCurve()
        {
            this._generatingBids = new StartUpCostCurveGeneratingBidsCollection(this);
            this._generatingBids.CollectionChanging += this.GeneratingBidsCollectionChanging;
            this._generatingBids.CollectionChanged += this.GeneratingBidsCollectionChanged;
            this._registeredGenerators = new StartUpCostCurveRegisteredGeneratorsCollection(this);
            this._registeredGenerators.CollectionChanging += this.RegisteredGeneratorsCollectionChanging;
            this._registeredGenerators.CollectionChanged += this.RegisteredGeneratorsCollectionChanged;
        }
        
        /// <summary>
        /// The GeneratingBids property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("StartUpCostCurve")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<IGeneratingBid> GeneratingBids
        {
            get
            {
                return this._generatingBids;
            }
        }
        
        /// <summary>
        /// The RegisteredGenerators property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("StartUpCostCurves")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<IRegisteredGenerator> RegisteredGenerators
        {
            get
            {
                return this._registeredGenerators;
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new StartUpCostCurveReferencedElementsCollection(this));
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
                            "StartUpCostCurve")));
                }
                return _classInstance;
            }
        }
        
        private static ITypedElement RetrieveGeneratingBidsReference()
        {
            return ((ITypedElement)(((ModelElement)(StartUpCostCurve.ClassInstance)).Resolve("GeneratingBids")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the GeneratingBids property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void GeneratingBidsCollectionChanging(object sender, NMF.Collections.ObjectModel.NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("GeneratingBids", e, _generatingBidsReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the GeneratingBids property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void GeneratingBidsCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("GeneratingBids", e, _generatingBidsReference);
        }
        
        private static ITypedElement RetrieveRegisteredGeneratorsReference()
        {
            return ((ITypedElement)(((ModelElement)(StartUpCostCurve.ClassInstance)).Resolve("RegisteredGenerators")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the RegisteredGenerators property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void RegisteredGeneratorsCollectionChanging(object sender, NMF.Collections.ObjectModel.NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("RegisteredGenerators", e, _registeredGeneratorsReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the RegisteredGenerators property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void RegisteredGeneratorsCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("RegisteredGenerators", e, _registeredGeneratorsReference);
        }
        
        /// <summary>
        /// Gets the Model element collection for the given feature
        /// </summary>
        /// <returns>A non-generic list of elements</returns>
        /// <param name="feature">The requested feature</param>
        protected override System.Collections.IList GetCollectionForFeature(string feature)
        {
            if ((feature == "GENERATINGBIDS"))
            {
                return this._generatingBids;
            }
            if ((feature == "REGISTEREDGENERATORS"))
            {
                return this._registeredGenerators;
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/MarketOperations/" +
                        "StartUpCostCurve")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the StartUpCostCurve class
        /// </summary>
        public class StartUpCostCurveReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private StartUpCostCurve _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public StartUpCostCurveReferencedElementsCollection(StartUpCostCurve parent)
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
                    count = (count + this._parent.GeneratingBids.Count);
                    count = (count + this._parent.RegisteredGenerators.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.GeneratingBids.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.RegisteredGenerators.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.GeneratingBids.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.RegisteredGenerators.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IGeneratingBid generatingBidsCasted = item.As<IGeneratingBid>();
                if ((generatingBidsCasted != null))
                {
                    this._parent.GeneratingBids.Add(generatingBidsCasted);
                }
                IRegisteredGenerator registeredGeneratorsCasted = item.As<IRegisteredGenerator>();
                if ((registeredGeneratorsCasted != null))
                {
                    this._parent.RegisteredGenerators.Add(registeredGeneratorsCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.GeneratingBids.Clear();
                this._parent.RegisteredGenerators.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.GeneratingBids.Contains(item))
                {
                    return true;
                }
                if (this._parent.RegisteredGenerators.Contains(item))
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
                IEnumerator<IModelElement> generatingBidsEnumerator = this._parent.GeneratingBids.GetEnumerator();
                try
                {
                    for (
                    ; generatingBidsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = generatingBidsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    generatingBidsEnumerator.Dispose();
                }
                IEnumerator<IModelElement> registeredGeneratorsEnumerator = this._parent.RegisteredGenerators.GetEnumerator();
                try
                {
                    for (
                    ; registeredGeneratorsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = registeredGeneratorsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    registeredGeneratorsEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IGeneratingBid generatingBidItem = item.As<IGeneratingBid>();
                if (((generatingBidItem != null) 
                            && this._parent.GeneratingBids.Remove(generatingBidItem)))
                {
                    return true;
                }
                IRegisteredGenerator registeredGeneratorItem = item.As<IRegisteredGenerator>();
                if (((registeredGeneratorItem != null) 
                            && this._parent.RegisteredGenerators.Remove(registeredGeneratorItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.GeneratingBids).Concat(this._parent.RegisteredGenerators).GetEnumerator();
            }
        }
    }
}

