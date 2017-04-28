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
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace TTC2017.SmartGrids.OutagePreventionJointarget
{
    
    
    /// <summary>
    /// The default implementation of the Terminal class
    /// </summary>
    [XmlNamespaceAttribute("http://www.transformation-tool-contest.eu/2017/smartGrids/VoltagePhaseMeasurement" +
        "s")]
    [XmlNamespacePrefixAttribute("outagePreventionJt")]
    [ModelRepresentationClassAttribute("http://www.transformation-tool-contest.eu/2017/smartGrids/VoltagePhaseMeasurement" +
        "s#//Terminal")]
    public partial class Terminal : ModelElement, ITerminal, IModelElement
    {
        
        private static Lazy<ITypedElement> _tieFlowReference = new Lazy<ITypedElement>(RetrieveTieFlowReference);
        
        /// <summary>
        /// The backing field for the TieFlow property
        /// </summary>
        private ObservableAssociationOrderedSet<ITieFlow> _tieFlow;
        
        private static IClass _classInstance;
        
        public Terminal()
        {
            this._tieFlow = new ObservableAssociationOrderedSet<ITieFlow>();
            this._tieFlow.CollectionChanging += this.TieFlowCollectionChanging;
            this._tieFlow.CollectionChanged += this.TieFlowCollectionChanged;
        }
        
        /// <summary>
        /// The TieFlow property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [ConstantAttribute()]
        public IOrderedSetExpression<ITieFlow> TieFlow
        {
            get
            {
                return this._tieFlow;
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new TerminalReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://www.transformation-tool-contest.eu/2017/smartGrids/VoltagePhaseMeasurement" +
                            "s#//Terminal")));
                }
                return _classInstance;
            }
        }
        
        private static ITypedElement RetrieveTieFlowReference()
        {
            return ((ITypedElement)(((ModelElement)(TTC2017.SmartGrids.OutagePreventionJointarget.Terminal.ClassInstance)).Resolve("TieFlow")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the TieFlow property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void TieFlowCollectionChanging(object sender, NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("TieFlow", e, _tieFlowReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the TieFlow property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void TieFlowCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("TieFlow", e, _tieFlowReference);
        }
        
        /// <summary>
        /// Gets the Model element collection for the given feature
        /// </summary>
        /// <returns>A non-generic list of elements</returns>
        /// <param name="feature">The requested feature</param>
        protected override System.Collections.IList GetCollectionForFeature(string feature)
        {
            if ((feature == "TIEFLOW"))
            {
                return this._tieFlow;
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://www.transformation-tool-contest.eu/2017/smartGrids/VoltagePhaseMeasurement" +
                        "s#//Terminal")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the Terminal class
        /// </summary>
        public class TerminalReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private Terminal _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public TerminalReferencedElementsCollection(Terminal parent)
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
                    count = (count + this._parent.TieFlow.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.TieFlow.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.TieFlow.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                ITieFlow tieFlowCasted = item.As<ITieFlow>();
                if ((tieFlowCasted != null))
                {
                    this._parent.TieFlow.Add(tieFlowCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.TieFlow.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.TieFlow.Contains(item))
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
                IEnumerator<IModelElement> tieFlowEnumerator = this._parent.TieFlow.GetEnumerator();
                try
                {
                    for (
                    ; tieFlowEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = tieFlowEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    tieFlowEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                ITieFlow tieFlowItem = item.As<ITieFlow>();
                if (((tieFlowItem != null) 
                            && this._parent.TieFlow.Remove(tieFlowItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.TieFlow).GetEnumerator();
            }
        }
    }
}

