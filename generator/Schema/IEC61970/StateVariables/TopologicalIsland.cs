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
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Topology;
using TTC2017.SmartGrids.CIM.IEC61970.Wires;

namespace TTC2017.SmartGrids.CIM.IEC61970.StateVariables
{
    
    
    /// <summary>
    /// The default implementation of the TopologicalIsland class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#StateVariables")]
    [XmlNamespacePrefixAttribute("cimStateVariables")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/StateVariables/TopologicalIsl" +
        "and")]
    [DebuggerDisplayAttribute("TopologicalIsland {UUID}")]
    public partial class TopologicalIsland : IdentifiedObject, ITopologicalIsland, IModelElement
    {
        
        private static Lazy<ITypedElement> _angleRef_TopologicalNodeReference = new Lazy<ITypedElement>(RetrieveAngleRef_TopologicalNodeReference);
        
        /// <summary>
        /// The backing field for the AngleRef_TopologicalNode property
        /// </summary>
        private ITopologicalNode _angleRef_TopologicalNode;
        
        private static Lazy<ITypedElement> _topologicalNodesReference = new Lazy<ITypedElement>(RetrieveTopologicalNodesReference);
        
        /// <summary>
        /// The backing field for the TopologicalNodes property
        /// </summary>
        private TopologicalIslandTopologicalNodesCollection _topologicalNodes;
        
        private static IClass _classInstance;
        
        public TopologicalIsland()
        {
            this._topologicalNodes = new TopologicalIslandTopologicalNodesCollection(this);
            this._topologicalNodes.CollectionChanging += this.TopologicalNodesCollectionChanging;
            this._topologicalNodes.CollectionChanged += this.TopologicalNodesCollectionChanged;
        }
        
        /// <summary>
        /// The AngleRef_TopologicalNode property
        /// </summary>
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("AngleRef_TopologicalIsland")]
        public virtual ITopologicalNode AngleRef_TopologicalNode
        {
            get
            {
                return this._angleRef_TopologicalNode;
            }
            set
            {
                if ((this._angleRef_TopologicalNode != value))
                {
                    ITopologicalNode old = this._angleRef_TopologicalNode;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnAngleRef_TopologicalNodeChanging(e);
                    this.OnPropertyChanging("AngleRef_TopologicalNode", e, _angleRef_TopologicalNodeReference);
                    this._angleRef_TopologicalNode = value;
                    if ((old != null))
                    {
                        old.AngleRef_TopologicalIsland = null;
                        old.Deleted -= this.OnResetAngleRef_TopologicalNode;
                    }
                    if ((value != null))
                    {
                        value.AngleRef_TopologicalIsland = this;
                        value.Deleted += this.OnResetAngleRef_TopologicalNode;
                    }
                    this.OnAngleRef_TopologicalNodeChanged(e);
                    this.OnPropertyChanged("AngleRef_TopologicalNode", e, _angleRef_TopologicalNodeReference);
                }
            }
        }
        
        /// <summary>
        /// The TopologicalNodes property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("TopologicalIsland")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<ITopologicalNode> TopologicalNodes
        {
            get
            {
                return this._topologicalNodes;
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new TopologicalIslandReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/StateVariables/TopologicalIsl" +
                            "and")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the AngleRef_TopologicalNode property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> AngleRef_TopologicalNodeChanging;
        
        /// <summary>
        /// Gets fired when the AngleRef_TopologicalNode property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> AngleRef_TopologicalNodeChanged;
        
        private static ITypedElement RetrieveAngleRef_TopologicalNodeReference()
        {
            return ((ITypedElement)(((ModelElement)(TopologicalIsland.ClassInstance)).Resolve("AngleRef_TopologicalNode")));
        }
        
        /// <summary>
        /// Raises the AngleRef_TopologicalNodeChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnAngleRef_TopologicalNodeChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.AngleRef_TopologicalNodeChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the AngleRef_TopologicalNodeChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnAngleRef_TopologicalNodeChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.AngleRef_TopologicalNodeChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the AngleRef_TopologicalNode property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetAngleRef_TopologicalNode(object sender, System.EventArgs eventArgs)
        {
            this.AngleRef_TopologicalNode = null;
        }
        
        private static ITypedElement RetrieveTopologicalNodesReference()
        {
            return ((ITypedElement)(((ModelElement)(TopologicalIsland.ClassInstance)).Resolve("TopologicalNodes")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the TopologicalNodes property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void TopologicalNodesCollectionChanging(object sender, NMF.Collections.ObjectModel.NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("TopologicalNodes", e, _topologicalNodesReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the TopologicalNodes property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void TopologicalNodesCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("TopologicalNodes", e, _topologicalNodesReference);
        }
        
        /// <summary>
        /// Gets the Model element collection for the given feature
        /// </summary>
        /// <returns>A non-generic list of elements</returns>
        /// <param name="feature">The requested feature</param>
        protected override System.Collections.IList GetCollectionForFeature(string feature)
        {
            if ((feature == "TOPOLOGICALNODES"))
            {
                return this._topologicalNodes;
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
            if ((feature == "ANGLEREF_TOPOLOGICALNODE"))
            {
                this.AngleRef_TopologicalNode = ((ITopologicalNode)(value));
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
            if ((attribute == "AngleRef_TopologicalNode"))
            {
                return new AngleRef_TopologicalNodeProxy(this);
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
            if ((reference == "AngleRef_TopologicalNode"))
            {
                return new AngleRef_TopologicalNodeProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/StateVariables/TopologicalIsl" +
                        "and")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the TopologicalIsland class
        /// </summary>
        public class TopologicalIslandReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private TopologicalIsland _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public TopologicalIslandReferencedElementsCollection(TopologicalIsland parent)
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
                    if ((this._parent.AngleRef_TopologicalNode != null))
                    {
                        count = (count + 1);
                    }
                    count = (count + this._parent.TopologicalNodes.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.AngleRef_TopologicalNodeChanged += this.PropagateValueChanges;
                this._parent.TopologicalNodes.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.AngleRef_TopologicalNodeChanged -= this.PropagateValueChanges;
                this._parent.TopologicalNodes.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.AngleRef_TopologicalNode == null))
                {
                    ITopologicalNode angleRef_TopologicalNodeCasted = item.As<ITopologicalNode>();
                    if ((angleRef_TopologicalNodeCasted != null))
                    {
                        this._parent.AngleRef_TopologicalNode = angleRef_TopologicalNodeCasted;
                        return;
                    }
                }
                ITopologicalNode topologicalNodesCasted = item.As<ITopologicalNode>();
                if ((topologicalNodesCasted != null))
                {
                    this._parent.TopologicalNodes.Add(topologicalNodesCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.AngleRef_TopologicalNode = null;
                this._parent.TopologicalNodes.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.AngleRef_TopologicalNode))
                {
                    return true;
                }
                if (this._parent.TopologicalNodes.Contains(item))
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
                if ((this._parent.AngleRef_TopologicalNode != null))
                {
                    array[arrayIndex] = this._parent.AngleRef_TopologicalNode;
                    arrayIndex = (arrayIndex + 1);
                }
                IEnumerator<IModelElement> topologicalNodesEnumerator = this._parent.TopologicalNodes.GetEnumerator();
                try
                {
                    for (
                    ; topologicalNodesEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = topologicalNodesEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    topologicalNodesEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                if ((this._parent.AngleRef_TopologicalNode == item))
                {
                    this._parent.AngleRef_TopologicalNode = null;
                    return true;
                }
                ITopologicalNode topologicalNodeItem = item.As<ITopologicalNode>();
                if (((topologicalNodeItem != null) 
                            && this._parent.TopologicalNodes.Remove(topologicalNodeItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.AngleRef_TopologicalNode).Concat(this._parent.TopologicalNodes).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the AngleRef_TopologicalNode property
        /// </summary>
        private sealed class AngleRef_TopologicalNodeProxy : ModelPropertyChange<ITopologicalIsland, ITopologicalNode>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public AngleRef_TopologicalNodeProxy(ITopologicalIsland modelElement) : 
                    base(modelElement, "AngleRef_TopologicalNode")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override ITopologicalNode Value
            {
                get
                {
                    return this.ModelElement.AngleRef_TopologicalNode;
                }
                set
                {
                    this.ModelElement.AngleRef_TopologicalNode = value;
                }
            }
        }
    }
}
