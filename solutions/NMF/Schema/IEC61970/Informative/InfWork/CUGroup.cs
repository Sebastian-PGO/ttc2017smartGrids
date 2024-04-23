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
    /// The default implementation of the CUGroup class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#InfWork")]
    [XmlNamespacePrefixAttribute("cimInfWork")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfWork/CUGroup")]
    [DebuggerDisplayAttribute("CUGroup {UUID}")]
    public partial class CUGroup : IdentifiedObject, ICUGroup, IModelElement
    {
        
        private static Lazy<ITypedElement> _childCUGroupsReference = new Lazy<ITypedElement>(RetrieveChildCUGroupsReference);
        
        /// <summary>
        /// The backing field for the ChildCUGroups property
        /// </summary>
        private CUGroupChildCUGroupsCollection _childCUGroups;
        
        private static Lazy<ITypedElement> _parentCUGroupsReference = new Lazy<ITypedElement>(RetrieveParentCUGroupsReference);
        
        /// <summary>
        /// The backing field for the ParentCUGroups property
        /// </summary>
        private CUGroupParentCUGroupsCollection _parentCUGroups;
        
        private static Lazy<ITypedElement> _designLocationCUsReference = new Lazy<ITypedElement>(RetrieveDesignLocationCUsReference);
        
        /// <summary>
        /// The backing field for the DesignLocationCUs property
        /// </summary>
        private CUGroupDesignLocationCUsCollection _designLocationCUs;
        
        private static Lazy<ITypedElement> _compatibleUnitsReference = new Lazy<ITypedElement>(RetrieveCompatibleUnitsReference);
        
        /// <summary>
        /// The backing field for the CompatibleUnits property
        /// </summary>
        private CUGroupCompatibleUnitsCollection _compatibleUnits;
        
        private static Lazy<ITypedElement> _statusReference = new Lazy<ITypedElement>(RetrieveStatusReference);
        
        /// <summary>
        /// The backing field for the Status property
        /// </summary>
        private IStatus _status;
        
        private static IClass _classInstance;
        
        public CUGroup()
        {
            this._childCUGroups = new CUGroupChildCUGroupsCollection(this);
            this._childCUGroups.CollectionChanging += this.ChildCUGroupsCollectionChanging;
            this._childCUGroups.CollectionChanged += this.ChildCUGroupsCollectionChanged;
            this._parentCUGroups = new CUGroupParentCUGroupsCollection(this);
            this._parentCUGroups.CollectionChanging += this.ParentCUGroupsCollectionChanging;
            this._parentCUGroups.CollectionChanged += this.ParentCUGroupsCollectionChanged;
            this._designLocationCUs = new CUGroupDesignLocationCUsCollection(this);
            this._designLocationCUs.CollectionChanging += this.DesignLocationCUsCollectionChanging;
            this._designLocationCUs.CollectionChanged += this.DesignLocationCUsCollectionChanged;
            this._compatibleUnits = new CUGroupCompatibleUnitsCollection(this);
            this._compatibleUnits.CollectionChanging += this.CompatibleUnitsCollectionChanging;
            this._compatibleUnits.CollectionChanged += this.CompatibleUnitsCollectionChanged;
        }
        
        /// <summary>
        /// The ChildCUGroups property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("ParentCUGroups")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<ICUGroup> ChildCUGroups
        {
            get
            {
                return this._childCUGroups;
            }
        }
        
        /// <summary>
        /// The ParentCUGroups property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("ChildCUGroups")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<ICUGroup> ParentCUGroups
        {
            get
            {
                return this._parentCUGroups;
            }
        }
        
        /// <summary>
        /// The DesignLocationCUs property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("CUGroups")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<IDesignLocationCU> DesignLocationCUs
        {
            get
            {
                return this._designLocationCUs;
            }
        }
        
        /// <summary>
        /// The CompatibleUnits property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("CUGroup")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<ICompatibleUnit> CompatibleUnits
        {
            get
            {
                return this._compatibleUnits;
            }
        }
        
        /// <summary>
        /// The status property
        /// </summary>
        [XmlElementNameAttribute("status")]
        [XmlAttributeAttribute(true)]
        public virtual IStatus Status
        {
            get
            {
                return this._status;
            }
            set
            {
                if ((this._status != value))
                {
                    IStatus old = this._status;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnStatusChanging(e);
                    this.OnPropertyChanging("Status", e, _statusReference);
                    this._status = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetStatus;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetStatus;
                    }
                    this.OnStatusChanged(e);
                    this.OnPropertyChanged("Status", e, _statusReference);
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
                return base.ReferencedElements.Concat(new CUGroupReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfWork/CUGroup")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the Status property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> StatusChanging;
        
        /// <summary>
        /// Gets fired when the Status property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> StatusChanged;
        
        private static ITypedElement RetrieveChildCUGroupsReference()
        {
            return ((ITypedElement)(((ModelElement)(CUGroup.ClassInstance)).Resolve("ChildCUGroups")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the ChildCUGroups property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void ChildCUGroupsCollectionChanging(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanging("ChildCUGroups", e, _childCUGroupsReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the ChildCUGroups property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void ChildCUGroupsCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("ChildCUGroups", e, _childCUGroupsReference);
        }
        
        private static ITypedElement RetrieveParentCUGroupsReference()
        {
            return ((ITypedElement)(((ModelElement)(CUGroup.ClassInstance)).Resolve("ParentCUGroups")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the ParentCUGroups property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void ParentCUGroupsCollectionChanging(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanging("ParentCUGroups", e, _parentCUGroupsReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the ParentCUGroups property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void ParentCUGroupsCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("ParentCUGroups", e, _parentCUGroupsReference);
        }
        
        private static ITypedElement RetrieveDesignLocationCUsReference()
        {
            return ((ITypedElement)(((ModelElement)(CUGroup.ClassInstance)).Resolve("DesignLocationCUs")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the DesignLocationCUs property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void DesignLocationCUsCollectionChanging(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanging("DesignLocationCUs", e, _designLocationCUsReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the DesignLocationCUs property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void DesignLocationCUsCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("DesignLocationCUs", e, _designLocationCUsReference);
        }
        
        private static ITypedElement RetrieveCompatibleUnitsReference()
        {
            return ((ITypedElement)(((ModelElement)(CUGroup.ClassInstance)).Resolve("CompatibleUnits")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the CompatibleUnits property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void CompatibleUnitsCollectionChanging(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanging("CompatibleUnits", e, _compatibleUnitsReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the CompatibleUnits property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void CompatibleUnitsCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("CompatibleUnits", e, _compatibleUnitsReference);
        }
        
        private static ITypedElement RetrieveStatusReference()
        {
            return ((ITypedElement)(((ModelElement)(CUGroup.ClassInstance)).Resolve("status")));
        }
        
        /// <summary>
        /// Raises the StatusChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnStatusChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.StatusChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the StatusChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnStatusChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.StatusChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the Status property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetStatus(object sender, System.EventArgs eventArgs)
        {
            this.Status = null;
        }
        
        /// <summary>
        /// Gets the Model element collection for the given feature
        /// </summary>
        /// <returns>A non-generic list of elements</returns>
        /// <param name="feature">The requested feature</param>
        protected override System.Collections.IList GetCollectionForFeature(string feature)
        {
            if ((feature == "CHILDCUGROUPS"))
            {
                return this._childCUGroups;
            }
            if ((feature == "PARENTCUGROUPS"))
            {
                return this._parentCUGroups;
            }
            if ((feature == "DESIGNLOCATIONCUS"))
            {
                return this._designLocationCUs;
            }
            if ((feature == "COMPATIBLEUNITS"))
            {
                return this._compatibleUnits;
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
            if ((feature == "STATUS"))
            {
                this.Status = ((IStatus)(value));
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
            if ((attribute == "Status"))
            {
                return new StatusProxy(this);
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
            if ((reference == "Status"))
            {
                return new StatusProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfWork/CUGroup")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the CUGroup class
        /// </summary>
        public class CUGroupReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private CUGroup _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public CUGroupReferencedElementsCollection(CUGroup parent)
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
                    count = (count + this._parent.ChildCUGroups.Count);
                    count = (count + this._parent.ParentCUGroups.Count);
                    count = (count + this._parent.DesignLocationCUs.Count);
                    count = (count + this._parent.CompatibleUnits.Count);
                    if ((this._parent.Status != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.ChildCUGroups.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.ParentCUGroups.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.DesignLocationCUs.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.CompatibleUnits.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.StatusChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.ChildCUGroups.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.ParentCUGroups.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.DesignLocationCUs.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.CompatibleUnits.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.StatusChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                ICUGroup childCUGroupsCasted = item.As<ICUGroup>();
                if ((childCUGroupsCasted != null))
                {
                    this._parent.ChildCUGroups.Add(childCUGroupsCasted);
                }
                ICUGroup parentCUGroupsCasted = item.As<ICUGroup>();
                if ((parentCUGroupsCasted != null))
                {
                    this._parent.ParentCUGroups.Add(parentCUGroupsCasted);
                }
                IDesignLocationCU designLocationCUsCasted = item.As<IDesignLocationCU>();
                if ((designLocationCUsCasted != null))
                {
                    this._parent.DesignLocationCUs.Add(designLocationCUsCasted);
                }
                ICompatibleUnit compatibleUnitsCasted = item.As<ICompatibleUnit>();
                if ((compatibleUnitsCasted != null))
                {
                    this._parent.CompatibleUnits.Add(compatibleUnitsCasted);
                }
                if ((this._parent.Status == null))
                {
                    IStatus statusCasted = item.As<IStatus>();
                    if ((statusCasted != null))
                    {
                        this._parent.Status = statusCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.ChildCUGroups.Clear();
                this._parent.ParentCUGroups.Clear();
                this._parent.DesignLocationCUs.Clear();
                this._parent.CompatibleUnits.Clear();
                this._parent.Status = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.ChildCUGroups.Contains(item))
                {
                    return true;
                }
                if (this._parent.ParentCUGroups.Contains(item))
                {
                    return true;
                }
                if (this._parent.DesignLocationCUs.Contains(item))
                {
                    return true;
                }
                if (this._parent.CompatibleUnits.Contains(item))
                {
                    return true;
                }
                if ((item == this._parent.Status))
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
                IEnumerator<IModelElement> childCUGroupsEnumerator = this._parent.ChildCUGroups.GetEnumerator();
                try
                {
                    for (
                    ; childCUGroupsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = childCUGroupsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    childCUGroupsEnumerator.Dispose();
                }
                IEnumerator<IModelElement> parentCUGroupsEnumerator = this._parent.ParentCUGroups.GetEnumerator();
                try
                {
                    for (
                    ; parentCUGroupsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = parentCUGroupsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    parentCUGroupsEnumerator.Dispose();
                }
                IEnumerator<IModelElement> designLocationCUsEnumerator = this._parent.DesignLocationCUs.GetEnumerator();
                try
                {
                    for (
                    ; designLocationCUsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = designLocationCUsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    designLocationCUsEnumerator.Dispose();
                }
                IEnumerator<IModelElement> compatibleUnitsEnumerator = this._parent.CompatibleUnits.GetEnumerator();
                try
                {
                    for (
                    ; compatibleUnitsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = compatibleUnitsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    compatibleUnitsEnumerator.Dispose();
                }
                if ((this._parent.Status != null))
                {
                    array[arrayIndex] = this._parent.Status;
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
                ICUGroup cUGroupItem = item.As<ICUGroup>();
                if (((cUGroupItem != null) 
                            && this._parent.ChildCUGroups.Remove(cUGroupItem)))
                {
                    return true;
                }
                if (((cUGroupItem != null) 
                            && this._parent.ParentCUGroups.Remove(cUGroupItem)))
                {
                    return true;
                }
                IDesignLocationCU designLocationCUItem = item.As<IDesignLocationCU>();
                if (((designLocationCUItem != null) 
                            && this._parent.DesignLocationCUs.Remove(designLocationCUItem)))
                {
                    return true;
                }
                ICompatibleUnit compatibleUnitItem = item.As<ICompatibleUnit>();
                if (((compatibleUnitItem != null) 
                            && this._parent.CompatibleUnits.Remove(compatibleUnitItem)))
                {
                    return true;
                }
                if ((this._parent.Status == item))
                {
                    this._parent.Status = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.ChildCUGroups).Concat(this._parent.ParentCUGroups).Concat(this._parent.DesignLocationCUs).Concat(this._parent.CompatibleUnits).Concat(this._parent.Status).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the status property
        /// </summary>
        private sealed class StatusProxy : ModelPropertyChange<ICUGroup, IStatus>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public StatusProxy(ICUGroup modelElement) : 
                    base(modelElement, "status")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IStatus Value
            {
                get
                {
                    return this.ModelElement.Status;
                }
                set
                {
                    this.ModelElement.Status = value;
                }
            }
        }
    }
}

