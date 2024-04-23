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
    /// The default implementation of the WorkFlowStep class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#InfWork")]
    [XmlNamespacePrefixAttribute("cimInfWork")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfWork/WorkFlowS" +
        "tep")]
    [DebuggerDisplayAttribute("WorkFlowStep {UUID}")]
    public partial class WorkFlowStep : IdentifiedObject, IWorkFlowStep, IModelElement
    {
        
        /// <summary>
        /// The backing field for the SequenceNumber property
        /// </summary>
        private int _sequenceNumber;
        
        private static Lazy<ITypedElement> _sequenceNumberAttribute = new Lazy<ITypedElement>(RetrieveSequenceNumberAttribute);
        
        private static Lazy<ITypedElement> _workTasksReference = new Lazy<ITypedElement>(RetrieveWorkTasksReference);
        
        /// <summary>
        /// The backing field for the WorkTasks property
        /// </summary>
        private WorkFlowStepWorkTasksCollection _workTasks;
        
        private static Lazy<ITypedElement> _statusReference = new Lazy<ITypedElement>(RetrieveStatusReference);
        
        /// <summary>
        /// The backing field for the Status property
        /// </summary>
        private IStatus _status;
        
        private static Lazy<ITypedElement> _workReference = new Lazy<ITypedElement>(RetrieveWorkReference);
        
        /// <summary>
        /// The backing field for the Work property
        /// </summary>
        private IWork _work;
        
        private static IClass _classInstance;
        
        public WorkFlowStep()
        {
            this._workTasks = new WorkFlowStepWorkTasksCollection(this);
            this._workTasks.CollectionChanging += this.WorkTasksCollectionChanging;
            this._workTasks.CollectionChanged += this.WorkTasksCollectionChanged;
        }
        
        /// <summary>
        /// The sequenceNumber property
        /// </summary>
        [XmlElementNameAttribute("sequenceNumber")]
        [XmlAttributeAttribute(true)]
        public virtual int SequenceNumber
        {
            get
            {
                return this._sequenceNumber;
            }
            set
            {
                if ((this._sequenceNumber != value))
                {
                    int old = this._sequenceNumber;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnSequenceNumberChanging(e);
                    this.OnPropertyChanging("SequenceNumber", e, _sequenceNumberAttribute);
                    this._sequenceNumber = value;
                    this.OnSequenceNumberChanged(e);
                    this.OnPropertyChanged("SequenceNumber", e, _sequenceNumberAttribute);
                }
            }
        }
        
        /// <summary>
        /// The WorkTasks property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("WorkFlowStep")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<IWorkTask> WorkTasks
        {
            get
            {
                return this._workTasks;
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
        /// The Work property
        /// </summary>
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("WorkFlowSteps")]
        public virtual IWork Work
        {
            get
            {
                return this._work;
            }
            set
            {
                if ((this._work != value))
                {
                    IWork old = this._work;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnWorkChanging(e);
                    this.OnPropertyChanging("Work", e, _workReference);
                    this._work = value;
                    if ((old != null))
                    {
                        old.WorkFlowSteps.Remove(this);
                        old.Deleted -= this.OnResetWork;
                    }
                    if ((value != null))
                    {
                        value.WorkFlowSteps.Add(this);
                        value.Deleted += this.OnResetWork;
                    }
                    this.OnWorkChanged(e);
                    this.OnPropertyChanged("Work", e, _workReference);
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
                return base.ReferencedElements.Concat(new WorkFlowStepReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfWork/WorkFlowS" +
                            "tep")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the SequenceNumber property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> SequenceNumberChanging;
        
        /// <summary>
        /// Gets fired when the SequenceNumber property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> SequenceNumberChanged;
        
        /// <summary>
        /// Gets fired before the Status property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> StatusChanging;
        
        /// <summary>
        /// Gets fired when the Status property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> StatusChanged;
        
        /// <summary>
        /// Gets fired before the Work property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> WorkChanging;
        
        /// <summary>
        /// Gets fired when the Work property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> WorkChanged;
        
        private static ITypedElement RetrieveSequenceNumberAttribute()
        {
            return ((ITypedElement)(((ModelElement)(WorkFlowStep.ClassInstance)).Resolve("sequenceNumber")));
        }
        
        /// <summary>
        /// Raises the SequenceNumberChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnSequenceNumberChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.SequenceNumberChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the SequenceNumberChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnSequenceNumberChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.SequenceNumberChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveWorkTasksReference()
        {
            return ((ITypedElement)(((ModelElement)(WorkFlowStep.ClassInstance)).Resolve("WorkTasks")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the WorkTasks property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void WorkTasksCollectionChanging(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanging("WorkTasks", e, _workTasksReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the WorkTasks property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void WorkTasksCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("WorkTasks", e, _workTasksReference);
        }
        
        private static ITypedElement RetrieveStatusReference()
        {
            return ((ITypedElement)(((ModelElement)(WorkFlowStep.ClassInstance)).Resolve("status")));
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
        
        private static ITypedElement RetrieveWorkReference()
        {
            return ((ITypedElement)(((ModelElement)(WorkFlowStep.ClassInstance)).Resolve("Work")));
        }
        
        /// <summary>
        /// Raises the WorkChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnWorkChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.WorkChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the WorkChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnWorkChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.WorkChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the Work property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetWork(object sender, System.EventArgs eventArgs)
        {
            this.Work = null;
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "SEQUENCENUMBER"))
            {
                return this.SequenceNumber;
            }
            return base.GetAttributeValue(attribute, index);
        }
        
        /// <summary>
        /// Gets the Model element collection for the given feature
        /// </summary>
        /// <returns>A non-generic list of elements</returns>
        /// <param name="feature">The requested feature</param>
        protected override System.Collections.IList GetCollectionForFeature(string feature)
        {
            if ((feature == "WORKTASKS"))
            {
                return this._workTasks;
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
            if ((feature == "WORK"))
            {
                this.Work = ((IWork)(value));
                return;
            }
            if ((feature == "SEQUENCENUMBER"))
            {
                this.SequenceNumber = ((int)(value));
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
            if ((attribute == "Work"))
            {
                return new WorkProxy(this);
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
            if ((reference == "Work"))
            {
                return new WorkProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfWork/WorkFlowS" +
                        "tep")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the WorkFlowStep class
        /// </summary>
        public class WorkFlowStepReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private WorkFlowStep _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public WorkFlowStepReferencedElementsCollection(WorkFlowStep parent)
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
                    count = (count + this._parent.WorkTasks.Count);
                    if ((this._parent.Status != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.Work != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.WorkTasks.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.StatusChanged += this.PropagateValueChanges;
                this._parent.WorkChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.WorkTasks.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.StatusChanged -= this.PropagateValueChanges;
                this._parent.WorkChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IWorkTask workTasksCasted = item.As<IWorkTask>();
                if ((workTasksCasted != null))
                {
                    this._parent.WorkTasks.Add(workTasksCasted);
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
                if ((this._parent.Work == null))
                {
                    IWork workCasted = item.As<IWork>();
                    if ((workCasted != null))
                    {
                        this._parent.Work = workCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.WorkTasks.Clear();
                this._parent.Status = null;
                this._parent.Work = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.WorkTasks.Contains(item))
                {
                    return true;
                }
                if ((item == this._parent.Status))
                {
                    return true;
                }
                if ((item == this._parent.Work))
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
                IEnumerator<IModelElement> workTasksEnumerator = this._parent.WorkTasks.GetEnumerator();
                try
                {
                    for (
                    ; workTasksEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = workTasksEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    workTasksEnumerator.Dispose();
                }
                if ((this._parent.Status != null))
                {
                    array[arrayIndex] = this._parent.Status;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.Work != null))
                {
                    array[arrayIndex] = this._parent.Work;
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
                IWorkTask workTaskItem = item.As<IWorkTask>();
                if (((workTaskItem != null) 
                            && this._parent.WorkTasks.Remove(workTaskItem)))
                {
                    return true;
                }
                if ((this._parent.Status == item))
                {
                    this._parent.Status = null;
                    return true;
                }
                if ((this._parent.Work == item))
                {
                    this._parent.Work = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.WorkTasks).Concat(this._parent.Status).Concat(this._parent.Work).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the sequenceNumber property
        /// </summary>
        private sealed class SequenceNumberProxy : ModelPropertyChange<IWorkFlowStep, int>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public SequenceNumberProxy(IWorkFlowStep modelElement) : 
                    base(modelElement, "sequenceNumber")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override int Value
            {
                get
                {
                    return this.ModelElement.SequenceNumber;
                }
                set
                {
                    this.ModelElement.SequenceNumber = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the status property
        /// </summary>
        private sealed class StatusProxy : ModelPropertyChange<IWorkFlowStep, IStatus>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public StatusProxy(IWorkFlowStep modelElement) : 
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
        /// Represents a proxy to represent an incremental access to the Work property
        /// </summary>
        private sealed class WorkProxy : ModelPropertyChange<IWorkFlowStep, IWork>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public WorkProxy(IWorkFlowStep modelElement) : 
                    base(modelElement, "Work")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IWork Value
            {
                get
                {
                    return this.ModelElement.Work;
                }
                set
                {
                    this.ModelElement.Work = value;
                }
            }
        }
    }
}

