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
using TTC2017.SmartGrids.SubstationStandard.Dataclasses;
using TTC2017.SmartGrids.SubstationStandard.Enumerations;
using TTC2017.SmartGrids.SubstationStandard.LNNodes.DomainLNs;
using TTC2017.SmartGrids.SubstationStandard.LNNodes.LNGroupA;

namespace TTC2017.SmartGrids.SubstationStandard.LNNodes.LNGroupY
{
    
    
    /// <summary>
    /// The default implementation of the GroupY class
    /// </summary>
    [XmlNamespaceAttribute("http://www.transformation-tool-contest.eu/2017/smartGrids/substationStandard/grou" +
        "pY")]
    [XmlNamespacePrefixAttribute("groupy")]
    [ModelRepresentationClassAttribute("http://www.transformation-tool-contest.eu/2017/smartGrids/substationStandard#//LN" +
        "Nodes/LNGroupY/GroupY")]
    public partial class GroupY : DomainLN, IGroupY, IModelElement
    {
        
        /// <summary>
        /// The backing field for the EEHealth property
        /// </summary>
        private Nullable<HealthStateKind> _eEHealth;
        
        private static Lazy<ITypedElement> _eEHealthAttribute = new Lazy<ITypedElement>(RetrieveEEHealthAttribute);
        
        private static Lazy<ITypedElement> _eENameReference = new Lazy<ITypedElement>(RetrieveEENameReference);
        
        /// <summary>
        /// The backing field for the EEName property
        /// </summary>
        private IDPL _eEName;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The EEHealth property
        /// </summary>
        [XmlAttributeAttribute(true)]
        public virtual Nullable<HealthStateKind> EEHealth
        {
            get
            {
                return this._eEHealth;
            }
            set
            {
                if ((this._eEHealth != value))
                {
                    Nullable<HealthStateKind> old = this._eEHealth;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnEEHealthChanging(e);
                    this.OnPropertyChanging("EEHealth", e, _eEHealthAttribute);
                    this._eEHealth = value;
                    this.OnEEHealthChanged(e);
                    this.OnPropertyChanged("EEHealth", e, _eEHealthAttribute);
                }
            }
        }
        
        /// <summary>
        /// The EEName property
        /// </summary>
        [XmlAttributeAttribute(true)]
        public virtual IDPL EEName
        {
            get
            {
                return this._eEName;
            }
            set
            {
                if ((this._eEName != value))
                {
                    IDPL old = this._eEName;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnEENameChanging(e);
                    this.OnPropertyChanging("EEName", e, _eENameReference);
                    this._eEName = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetEEName;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetEEName;
                    }
                    this.OnEENameChanged(e);
                    this.OnPropertyChanged("EEName", e, _eENameReference);
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
                return base.ReferencedElements.Concat(new GroupYReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://www.transformation-tool-contest.eu/2017/smartGrids/substationStandard#//LN" +
                            "Nodes/LNGroupY/GroupY")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the EEHealth property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> EEHealthChanging;
        
        /// <summary>
        /// Gets fired when the EEHealth property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> EEHealthChanged;
        
        /// <summary>
        /// Gets fired before the EEName property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> EENameChanging;
        
        /// <summary>
        /// Gets fired when the EEName property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> EENameChanged;
        
        private static ITypedElement RetrieveEEHealthAttribute()
        {
            return ((ITypedElement)(((ModelElement)(GroupY.ClassInstance)).Resolve("EEHealth")));
        }
        
        /// <summary>
        /// Raises the EEHealthChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnEEHealthChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.EEHealthChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the EEHealthChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnEEHealthChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.EEHealthChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveEENameReference()
        {
            return ((ITypedElement)(((ModelElement)(GroupY.ClassInstance)).Resolve("EEName")));
        }
        
        /// <summary>
        /// Raises the EENameChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnEENameChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.EENameChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the EENameChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnEENameChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.EENameChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the EEName property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetEEName(object sender, System.EventArgs eventArgs)
        {
            this.EEName = null;
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "EEHEALTH"))
            {
                return this.EEHealth;
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
            if ((feature == "EENAME"))
            {
                this.EEName = ((IDPL)(value));
                return;
            }
            if ((feature == "EEHEALTH"))
            {
                this.EEHealth = ((HealthStateKind)(value));
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
            if ((attribute == "EEName"))
            {
                return new EENameProxy(this);
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
            if ((reference == "EEName"))
            {
                return new EENameProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://www.transformation-tool-contest.eu/2017/smartGrids/substationStandard#//LN" +
                        "Nodes/LNGroupY/GroupY")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the GroupY class
        /// </summary>
        public class GroupYReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private GroupY _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public GroupYReferencedElementsCollection(GroupY parent)
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
                    if ((this._parent.EEName != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.EENameChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.EENameChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.EEName == null))
                {
                    IDPL eENameCasted = item.As<IDPL>();
                    if ((eENameCasted != null))
                    {
                        this._parent.EEName = eENameCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.EEName = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.EEName))
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
                if ((this._parent.EEName != null))
                {
                    array[arrayIndex] = this._parent.EEName;
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
                if ((this._parent.EEName == item))
                {
                    this._parent.EEName = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.EEName).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the EEHealth property
        /// </summary>
        private sealed class EEHealthProxy : ModelPropertyChange<IGroupY, Nullable<HealthStateKind>>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public EEHealthProxy(IGroupY modelElement) : 
                    base(modelElement, "EEHealth")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override Nullable<HealthStateKind> Value
            {
                get
                {
                    return this.ModelElement.EEHealth;
                }
                set
                {
                    this.ModelElement.EEHealth = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the EEName property
        /// </summary>
        private sealed class EENameProxy : ModelPropertyChange<IGroupY, IDPL>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public EENameProxy(IGroupY modelElement) : 
                    base(modelElement, "EEName")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IDPL Value
            {
                get
                {
                    return this.ModelElement.EEName;
                }
                set
                {
                    this.ModelElement.EEName = value;
                }
            }
        }
    }
}

