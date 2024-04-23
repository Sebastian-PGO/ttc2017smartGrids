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
using TTC2017.SmartGrids.CIM.IEC61968.Work;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssets;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfCommon;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfERPSupport;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfGMLSupport;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfLocations;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfOperations;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfTypeAsset;

namespace TTC2017.SmartGrids.CIM.IEC61970.Informative.InfWork
{
    
    
    /// <summary>
    /// The default implementation of the Assignment class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#InfWork")]
    [XmlNamespacePrefixAttribute("cimInfWork")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfWork/Assignmen" +
        "t")]
    [DebuggerDisplayAttribute("Assignment {UUID}")]
    public partial class Assignment : Document, IAssignment, IModelElement
    {
        
        private static Lazy<ITypedElement> _crewsReference = new Lazy<ITypedElement>(RetrieveCrewsReference);
        
        /// <summary>
        /// The backing field for the Crews property
        /// </summary>
        private AssignmentCrewsCollection _crews;
        
        private static Lazy<ITypedElement> _effectivePeriodReference = new Lazy<ITypedElement>(RetrieveEffectivePeriodReference);
        
        /// <summary>
        /// The backing field for the EffectivePeriod property
        /// </summary>
        private IDateTimeInterval _effectivePeriod;
        
        private static IClass _classInstance;
        
        public Assignment()
        {
            this._crews = new AssignmentCrewsCollection(this);
            this._crews.CollectionChanging += this.CrewsCollectionChanging;
            this._crews.CollectionChanged += this.CrewsCollectionChanged;
        }
        
        /// <summary>
        /// The Crews property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("Assignments")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<ICrew> Crews
        {
            get
            {
                return this._crews;
            }
        }
        
        /// <summary>
        /// The effectivePeriod property
        /// </summary>
        [XmlElementNameAttribute("effectivePeriod")]
        [XmlAttributeAttribute(true)]
        public virtual IDateTimeInterval EffectivePeriod
        {
            get
            {
                return this._effectivePeriod;
            }
            set
            {
                if ((this._effectivePeriod != value))
                {
                    IDateTimeInterval old = this._effectivePeriod;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnEffectivePeriodChanging(e);
                    this.OnPropertyChanging("EffectivePeriod", e, _effectivePeriodReference);
                    this._effectivePeriod = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetEffectivePeriod;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetEffectivePeriod;
                    }
                    this.OnEffectivePeriodChanged(e);
                    this.OnPropertyChanged("EffectivePeriod", e, _effectivePeriodReference);
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
                return base.ReferencedElements.Concat(new AssignmentReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfWork/Assignmen" +
                            "t")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the EffectivePeriod property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> EffectivePeriodChanging;
        
        /// <summary>
        /// Gets fired when the EffectivePeriod property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> EffectivePeriodChanged;
        
        private static ITypedElement RetrieveCrewsReference()
        {
            return ((ITypedElement)(((ModelElement)(Assignment.ClassInstance)).Resolve("Crews")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the Crews property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void CrewsCollectionChanging(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanging("Crews", e, _crewsReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the Crews property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void CrewsCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("Crews", e, _crewsReference);
        }
        
        private static ITypedElement RetrieveEffectivePeriodReference()
        {
            return ((ITypedElement)(((ModelElement)(Assignment.ClassInstance)).Resolve("effectivePeriod")));
        }
        
        /// <summary>
        /// Raises the EffectivePeriodChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnEffectivePeriodChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.EffectivePeriodChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the EffectivePeriodChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnEffectivePeriodChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.EffectivePeriodChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the EffectivePeriod property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetEffectivePeriod(object sender, System.EventArgs eventArgs)
        {
            this.EffectivePeriod = null;
        }
        
        /// <summary>
        /// Gets the Model element collection for the given feature
        /// </summary>
        /// <returns>A non-generic list of elements</returns>
        /// <param name="feature">The requested feature</param>
        protected override System.Collections.IList GetCollectionForFeature(string feature)
        {
            if ((feature == "CREWS"))
            {
                return this._crews;
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
            if ((feature == "EFFECTIVEPERIOD"))
            {
                this.EffectivePeriod = ((IDateTimeInterval)(value));
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
            if ((attribute == "EffectivePeriod"))
            {
                return new EffectivePeriodProxy(this);
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
            if ((reference == "EffectivePeriod"))
            {
                return new EffectivePeriodProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfWork/Assignmen" +
                        "t")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the Assignment class
        /// </summary>
        public class AssignmentReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private Assignment _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public AssignmentReferencedElementsCollection(Assignment parent)
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
                    count = (count + this._parent.Crews.Count);
                    if ((this._parent.EffectivePeriod != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.Crews.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.EffectivePeriodChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.Crews.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.EffectivePeriodChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                ICrew crewsCasted = item.As<ICrew>();
                if ((crewsCasted != null))
                {
                    this._parent.Crews.Add(crewsCasted);
                }
                if ((this._parent.EffectivePeriod == null))
                {
                    IDateTimeInterval effectivePeriodCasted = item.As<IDateTimeInterval>();
                    if ((effectivePeriodCasted != null))
                    {
                        this._parent.EffectivePeriod = effectivePeriodCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.Crews.Clear();
                this._parent.EffectivePeriod = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.Crews.Contains(item))
                {
                    return true;
                }
                if ((item == this._parent.EffectivePeriod))
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
                IEnumerator<IModelElement> crewsEnumerator = this._parent.Crews.GetEnumerator();
                try
                {
                    for (
                    ; crewsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = crewsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    crewsEnumerator.Dispose();
                }
                if ((this._parent.EffectivePeriod != null))
                {
                    array[arrayIndex] = this._parent.EffectivePeriod;
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
                ICrew crewItem = item.As<ICrew>();
                if (((crewItem != null) 
                            && this._parent.Crews.Remove(crewItem)))
                {
                    return true;
                }
                if ((this._parent.EffectivePeriod == item))
                {
                    this._parent.EffectivePeriod = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.Crews).Concat(this._parent.EffectivePeriod).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the effectivePeriod property
        /// </summary>
        private sealed class EffectivePeriodProxy : ModelPropertyChange<IAssignment, IDateTimeInterval>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public EffectivePeriodProxy(IAssignment modelElement) : 
                    base(modelElement, "effectivePeriod")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IDateTimeInterval Value
            {
                get
                {
                    return this.ModelElement.EffectivePeriod;
                }
                set
                {
                    this.ModelElement.EffectivePeriod = value;
                }
            }
        }
    }
}

