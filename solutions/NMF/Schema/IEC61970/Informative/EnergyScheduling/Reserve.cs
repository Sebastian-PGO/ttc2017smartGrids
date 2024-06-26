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
using TTC2017.SmartGrids.CIM.IEC61970.ControlArea;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Generation.Production;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.Financial;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.MarketOperations;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.Reservation;
using TTC2017.SmartGrids.CIM.IEC61970.Meas;
using TTC2017.SmartGrids.CIM.IEC61970.Wires;

namespace TTC2017.SmartGrids.CIM.IEC61970.Informative.EnergyScheduling
{
    
    
    /// <summary>
    /// The default implementation of the Reserve class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#EnergyScheduling")]
    [XmlNamespacePrefixAttribute("cimEnergyScheduling")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/EnergyScheduling/" +
        "Reserve")]
    [DebuggerDisplayAttribute("Reserve {UUID}")]
    public partial class Reserve : EnergyTransaction, IReserve, IModelElement
    {
        
        private static Lazy<ITypedElement> _areaReserveSpecReference = new Lazy<ITypedElement>(RetrieveAreaReserveSpecReference);
        
        /// <summary>
        /// The backing field for the AreaReserveSpec property
        /// </summary>
        private ReserveAreaReserveSpecCollection _areaReserveSpec;
        
        private static IClass _classInstance;
        
        public Reserve()
        {
            this._areaReserveSpec = new ReserveAreaReserveSpecCollection(this);
            this._areaReserveSpec.CollectionChanging += this.AreaReserveSpecCollectionChanging;
            this._areaReserveSpec.CollectionChanged += this.AreaReserveSpecCollectionChanged;
        }
        
        /// <summary>
        /// The AreaReserveSpec property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("ReserveEnergyTransaction")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<IAreaReserveSpec> AreaReserveSpec
        {
            get
            {
                return this._areaReserveSpec;
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new ReserveReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/EnergyScheduling/" +
                            "Reserve")));
                }
                return _classInstance;
            }
        }
        
        private static ITypedElement RetrieveAreaReserveSpecReference()
        {
            return ((ITypedElement)(((ModelElement)(Reserve.ClassInstance)).Resolve("AreaReserveSpec")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the AreaReserveSpec property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void AreaReserveSpecCollectionChanging(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanging("AreaReserveSpec", e, _areaReserveSpecReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the AreaReserveSpec property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void AreaReserveSpecCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("AreaReserveSpec", e, _areaReserveSpecReference);
        }
        
        /// <summary>
        /// Gets the Model element collection for the given feature
        /// </summary>
        /// <returns>A non-generic list of elements</returns>
        /// <param name="feature">The requested feature</param>
        protected override System.Collections.IList GetCollectionForFeature(string feature)
        {
            if ((feature == "AREARESERVESPEC"))
            {
                return this._areaReserveSpec;
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/EnergyScheduling/" +
                        "Reserve")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the Reserve class
        /// </summary>
        public class ReserveReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private Reserve _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public ReserveReferencedElementsCollection(Reserve parent)
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
                    count = (count + this._parent.AreaReserveSpec.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.AreaReserveSpec.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.AreaReserveSpec.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IAreaReserveSpec areaReserveSpecCasted = item.As<IAreaReserveSpec>();
                if ((areaReserveSpecCasted != null))
                {
                    this._parent.AreaReserveSpec.Add(areaReserveSpecCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.AreaReserveSpec.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.AreaReserveSpec.Contains(item))
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
                IEnumerator<IModelElement> areaReserveSpecEnumerator = this._parent.AreaReserveSpec.GetEnumerator();
                try
                {
                    for (
                    ; areaReserveSpecEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = areaReserveSpecEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    areaReserveSpecEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IAreaReserveSpec areaReserveSpecItem = item.As<IAreaReserveSpec>();
                if (((areaReserveSpecItem != null) 
                            && this._parent.AreaReserveSpec.Remove(areaReserveSpecItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.AreaReserveSpec).GetEnumerator();
            }
        }
    }
}

