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
    /// The default implementation of the EquipmentItem class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#InfWork")]
    [XmlNamespacePrefixAttribute("cimInfWork")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfWork/Equipment" +
        "Item")]
    [DebuggerDisplayAttribute("EquipmentItem {UUID}")]
    public partial class EquipmentItem : IdentifiedObject, IEquipmentItem, IModelElement
    {
        
        /// <summary>
        /// The backing field for the Code property
        /// </summary>
        private string _code;
        
        private static Lazy<ITypedElement> _codeAttribute = new Lazy<ITypedElement>(RetrieveCodeAttribute);
        
        /// <summary>
        /// The backing field for the Cost property
        /// </summary>
        private float _cost;
        
        private static Lazy<ITypedElement> _costAttribute = new Lazy<ITypedElement>(RetrieveCostAttribute);
        
        private static Lazy<ITypedElement> _statusReference = new Lazy<ITypedElement>(RetrieveStatusReference);
        
        /// <summary>
        /// The backing field for the Status property
        /// </summary>
        private IStatus _status;
        
        private static Lazy<ITypedElement> _workCostDetailReference = new Lazy<ITypedElement>(RetrieveWorkCostDetailReference);
        
        /// <summary>
        /// The backing field for the WorkCostDetail property
        /// </summary>
        private IWorkCostDetail _workCostDetail;
        
        private static Lazy<ITypedElement> _workTaskReference = new Lazy<ITypedElement>(RetrieveWorkTaskReference);
        
        /// <summary>
        /// The backing field for the WorkTask property
        /// </summary>
        private IWorkTask _workTask;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The code property
        /// </summary>
        [XmlElementNameAttribute("code")]
        [XmlAttributeAttribute(true)]
        public virtual string Code
        {
            get
            {
                return this._code;
            }
            set
            {
                if ((this._code != value))
                {
                    string old = this._code;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnCodeChanging(e);
                    this.OnPropertyChanging("Code", e, _codeAttribute);
                    this._code = value;
                    this.OnCodeChanged(e);
                    this.OnPropertyChanged("Code", e, _codeAttribute);
                }
            }
        }
        
        /// <summary>
        /// The cost property
        /// </summary>
        [XmlElementNameAttribute("cost")]
        [XmlAttributeAttribute(true)]
        public virtual float Cost
        {
            get
            {
                return this._cost;
            }
            set
            {
                if ((this._cost != value))
                {
                    float old = this._cost;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnCostChanging(e);
                    this.OnPropertyChanging("Cost", e, _costAttribute);
                    this._cost = value;
                    this.OnCostChanged(e);
                    this.OnPropertyChanged("Cost", e, _costAttribute);
                }
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
        /// The WorkCostDetail property
        /// </summary>
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("EquipmentItems")]
        public virtual IWorkCostDetail WorkCostDetail
        {
            get
            {
                return this._workCostDetail;
            }
            set
            {
                if ((this._workCostDetail != value))
                {
                    IWorkCostDetail old = this._workCostDetail;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnWorkCostDetailChanging(e);
                    this.OnPropertyChanging("WorkCostDetail", e, _workCostDetailReference);
                    this._workCostDetail = value;
                    if ((old != null))
                    {
                        old.EquipmentItems.Remove(this);
                        old.Deleted -= this.OnResetWorkCostDetail;
                    }
                    if ((value != null))
                    {
                        value.EquipmentItems.Add(this);
                        value.Deleted += this.OnResetWorkCostDetail;
                    }
                    this.OnWorkCostDetailChanged(e);
                    this.OnPropertyChanged("WorkCostDetail", e, _workCostDetailReference);
                }
            }
        }
        
        /// <summary>
        /// The WorkTask property
        /// </summary>
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("EquipmentItems")]
        public virtual IWorkTask WorkTask
        {
            get
            {
                return this._workTask;
            }
            set
            {
                if ((this._workTask != value))
                {
                    IWorkTask old = this._workTask;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnWorkTaskChanging(e);
                    this.OnPropertyChanging("WorkTask", e, _workTaskReference);
                    this._workTask = value;
                    if ((old != null))
                    {
                        old.EquipmentItems.Remove(this);
                        old.Deleted -= this.OnResetWorkTask;
                    }
                    if ((value != null))
                    {
                        value.EquipmentItems.Add(this);
                        value.Deleted += this.OnResetWorkTask;
                    }
                    this.OnWorkTaskChanged(e);
                    this.OnPropertyChanged("WorkTask", e, _workTaskReference);
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
                return base.ReferencedElements.Concat(new EquipmentItemReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfWork/Equipment" +
                            "Item")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the Code property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> CodeChanging;
        
        /// <summary>
        /// Gets fired when the Code property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> CodeChanged;
        
        /// <summary>
        /// Gets fired before the Cost property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> CostChanging;
        
        /// <summary>
        /// Gets fired when the Cost property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> CostChanged;
        
        /// <summary>
        /// Gets fired before the Status property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> StatusChanging;
        
        /// <summary>
        /// Gets fired when the Status property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> StatusChanged;
        
        /// <summary>
        /// Gets fired before the WorkCostDetail property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> WorkCostDetailChanging;
        
        /// <summary>
        /// Gets fired when the WorkCostDetail property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> WorkCostDetailChanged;
        
        /// <summary>
        /// Gets fired before the WorkTask property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> WorkTaskChanging;
        
        /// <summary>
        /// Gets fired when the WorkTask property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> WorkTaskChanged;
        
        private static ITypedElement RetrieveCodeAttribute()
        {
            return ((ITypedElement)(((ModelElement)(EquipmentItem.ClassInstance)).Resolve("code")));
        }
        
        /// <summary>
        /// Raises the CodeChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnCodeChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.CodeChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the CodeChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnCodeChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.CodeChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveCostAttribute()
        {
            return ((ITypedElement)(((ModelElement)(EquipmentItem.ClassInstance)).Resolve("cost")));
        }
        
        /// <summary>
        /// Raises the CostChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnCostChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.CostChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the CostChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnCostChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.CostChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveStatusReference()
        {
            return ((ITypedElement)(((ModelElement)(EquipmentItem.ClassInstance)).Resolve("status")));
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
        
        private static ITypedElement RetrieveWorkCostDetailReference()
        {
            return ((ITypedElement)(((ModelElement)(EquipmentItem.ClassInstance)).Resolve("WorkCostDetail")));
        }
        
        /// <summary>
        /// Raises the WorkCostDetailChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnWorkCostDetailChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.WorkCostDetailChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the WorkCostDetailChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnWorkCostDetailChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.WorkCostDetailChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the WorkCostDetail property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetWorkCostDetail(object sender, System.EventArgs eventArgs)
        {
            this.WorkCostDetail = null;
        }
        
        private static ITypedElement RetrieveWorkTaskReference()
        {
            return ((ITypedElement)(((ModelElement)(EquipmentItem.ClassInstance)).Resolve("WorkTask")));
        }
        
        /// <summary>
        /// Raises the WorkTaskChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnWorkTaskChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.WorkTaskChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the WorkTaskChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnWorkTaskChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.WorkTaskChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the WorkTask property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetWorkTask(object sender, System.EventArgs eventArgs)
        {
            this.WorkTask = null;
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "CODE"))
            {
                return this.Code;
            }
            if ((attribute == "COST"))
            {
                return this.Cost;
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
            if ((feature == "STATUS"))
            {
                this.Status = ((IStatus)(value));
                return;
            }
            if ((feature == "WORKCOSTDETAIL"))
            {
                this.WorkCostDetail = ((IWorkCostDetail)(value));
                return;
            }
            if ((feature == "WORKTASK"))
            {
                this.WorkTask = ((IWorkTask)(value));
                return;
            }
            if ((feature == "CODE"))
            {
                this.Code = ((string)(value));
                return;
            }
            if ((feature == "COST"))
            {
                this.Cost = ((float)(value));
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
            if ((attribute == "WorkCostDetail"))
            {
                return new WorkCostDetailProxy(this);
            }
            if ((attribute == "WorkTask"))
            {
                return new WorkTaskProxy(this);
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
            if ((reference == "WorkCostDetail"))
            {
                return new WorkCostDetailProxy(this);
            }
            if ((reference == "WorkTask"))
            {
                return new WorkTaskProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfWork/Equipment" +
                        "Item")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the EquipmentItem class
        /// </summary>
        public class EquipmentItemReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private EquipmentItem _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public EquipmentItemReferencedElementsCollection(EquipmentItem parent)
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
                    if ((this._parent.Status != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.WorkCostDetail != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.WorkTask != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.StatusChanged += this.PropagateValueChanges;
                this._parent.WorkCostDetailChanged += this.PropagateValueChanges;
                this._parent.WorkTaskChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.StatusChanged -= this.PropagateValueChanges;
                this._parent.WorkCostDetailChanged -= this.PropagateValueChanges;
                this._parent.WorkTaskChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.Status == null))
                {
                    IStatus statusCasted = item.As<IStatus>();
                    if ((statusCasted != null))
                    {
                        this._parent.Status = statusCasted;
                        return;
                    }
                }
                if ((this._parent.WorkCostDetail == null))
                {
                    IWorkCostDetail workCostDetailCasted = item.As<IWorkCostDetail>();
                    if ((workCostDetailCasted != null))
                    {
                        this._parent.WorkCostDetail = workCostDetailCasted;
                        return;
                    }
                }
                if ((this._parent.WorkTask == null))
                {
                    IWorkTask workTaskCasted = item.As<IWorkTask>();
                    if ((workTaskCasted != null))
                    {
                        this._parent.WorkTask = workTaskCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.Status = null;
                this._parent.WorkCostDetail = null;
                this._parent.WorkTask = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.Status))
                {
                    return true;
                }
                if ((item == this._parent.WorkCostDetail))
                {
                    return true;
                }
                if ((item == this._parent.WorkTask))
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
                if ((this._parent.Status != null))
                {
                    array[arrayIndex] = this._parent.Status;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.WorkCostDetail != null))
                {
                    array[arrayIndex] = this._parent.WorkCostDetail;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.WorkTask != null))
                {
                    array[arrayIndex] = this._parent.WorkTask;
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
                if ((this._parent.Status == item))
                {
                    this._parent.Status = null;
                    return true;
                }
                if ((this._parent.WorkCostDetail == item))
                {
                    this._parent.WorkCostDetail = null;
                    return true;
                }
                if ((this._parent.WorkTask == item))
                {
                    this._parent.WorkTask = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.Status).Concat(this._parent.WorkCostDetail).Concat(this._parent.WorkTask).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the code property
        /// </summary>
        private sealed class CodeProxy : ModelPropertyChange<IEquipmentItem, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public CodeProxy(IEquipmentItem modelElement) : 
                    base(modelElement, "code")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override string Value
            {
                get
                {
                    return this.ModelElement.Code;
                }
                set
                {
                    this.ModelElement.Code = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the cost property
        /// </summary>
        private sealed class CostProxy : ModelPropertyChange<IEquipmentItem, float>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public CostProxy(IEquipmentItem modelElement) : 
                    base(modelElement, "cost")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override float Value
            {
                get
                {
                    return this.ModelElement.Cost;
                }
                set
                {
                    this.ModelElement.Cost = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the status property
        /// </summary>
        private sealed class StatusProxy : ModelPropertyChange<IEquipmentItem, IStatus>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public StatusProxy(IEquipmentItem modelElement) : 
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
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the WorkCostDetail property
        /// </summary>
        private sealed class WorkCostDetailProxy : ModelPropertyChange<IEquipmentItem, IWorkCostDetail>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public WorkCostDetailProxy(IEquipmentItem modelElement) : 
                    base(modelElement, "WorkCostDetail")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IWorkCostDetail Value
            {
                get
                {
                    return this.ModelElement.WorkCostDetail;
                }
                set
                {
                    this.ModelElement.WorkCostDetail = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the WorkTask property
        /// </summary>
        private sealed class WorkTaskProxy : ModelPropertyChange<IEquipmentItem, IWorkTask>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public WorkTaskProxy(IEquipmentItem modelElement) : 
                    base(modelElement, "WorkTask")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IWorkTask Value
            {
                get
                {
                    return this.ModelElement.WorkTask;
                }
                set
                {
                    this.ModelElement.WorkTask = value;
                }
            }
        }
    }
}

