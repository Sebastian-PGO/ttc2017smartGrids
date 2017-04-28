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
    /// The default implementation of the Dynamic class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#EnergyScheduling")]
    [XmlNamespacePrefixAttribute("cimEnergyScheduling")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/EnergyScheduling/" +
        "Dynamic")]
    [DebuggerDisplayAttribute("Dynamic {UUID}")]
    public partial class Dynamic : EnergyTransaction, IDynamic, IModelElement
    {
        
        private static Lazy<ITypedElement> _tieLinesReference = new Lazy<ITypedElement>(RetrieveTieLinesReference);
        
        /// <summary>
        /// The backing field for the TieLines property
        /// </summary>
        private DynamicTieLinesCollection _tieLines;
        
        private static IClass _classInstance;
        
        public Dynamic()
        {
            this._tieLines = new DynamicTieLinesCollection(this);
            this._tieLines.CollectionChanging += this.TieLinesCollectionChanging;
            this._tieLines.CollectionChanged += this.TieLinesCollectionChanged;
        }
        
        /// <summary>
        /// The TieLines property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("DynamicEnergyTransaction")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<ITieLine> TieLines
        {
            get
            {
                return this._tieLines;
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new DynamicReferencedElementsCollection(this));
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
                            "Dynamic")));
                }
                return _classInstance;
            }
        }
        
        private static ITypedElement RetrieveTieLinesReference()
        {
            return ((ITypedElement)(((ModelElement)(Dynamic.ClassInstance)).Resolve("TieLines")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the TieLines property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void TieLinesCollectionChanging(object sender, NMF.Collections.ObjectModel.NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("TieLines", e, _tieLinesReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the TieLines property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void TieLinesCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("TieLines", e, _tieLinesReference);
        }
        
        /// <summary>
        /// Gets the Model element collection for the given feature
        /// </summary>
        /// <returns>A non-generic list of elements</returns>
        /// <param name="feature">The requested feature</param>
        protected override System.Collections.IList GetCollectionForFeature(string feature)
        {
            if ((feature == "TIELINES"))
            {
                return this._tieLines;
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
                        "Dynamic")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the Dynamic class
        /// </summary>
        public class DynamicReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private Dynamic _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public DynamicReferencedElementsCollection(Dynamic parent)
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
                    count = (count + this._parent.TieLines.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.TieLines.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.TieLines.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                ITieLine tieLinesCasted = item.As<ITieLine>();
                if ((tieLinesCasted != null))
                {
                    this._parent.TieLines.Add(tieLinesCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.TieLines.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.TieLines.Contains(item))
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
                IEnumerator<IModelElement> tieLinesEnumerator = this._parent.TieLines.GetEnumerator();
                try
                {
                    for (
                    ; tieLinesEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = tieLinesEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    tieLinesEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                ITieLine tieLineItem = item.As<ITieLine>();
                if (((tieLineItem != null) 
                            && this._parent.TieLines.Remove(tieLineItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.TieLines).GetEnumerator();
            }
        }
    }
}

