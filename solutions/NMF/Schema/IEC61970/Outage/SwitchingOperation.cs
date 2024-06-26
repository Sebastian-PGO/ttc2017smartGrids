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
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfOperations;
using TTC2017.SmartGrids.CIM.IEC61970.Wires;

namespace TTC2017.SmartGrids.CIM.IEC61970.Outage
{
    
    
    /// <summary>
    /// The default implementation of the SwitchingOperation class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#Outage")]
    [XmlNamespacePrefixAttribute("cimOutage")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Outage/SwitchingOperation")]
    [DebuggerDisplayAttribute("SwitchingOperation {UUID}")]
    public partial class SwitchingOperation : IdentifiedObject, ISwitchingOperation, IModelElement
    {
        
        /// <summary>
        /// The backing field for the OperationTime property
        /// </summary>
        private DateTime _operationTime;
        
        private static Lazy<ITypedElement> _operationTimeAttribute = new Lazy<ITypedElement>(RetrieveOperationTimeAttribute);
        
        /// <summary>
        /// The backing field for the NewState property
        /// </summary>
        private Nullable<SwitchState> _newState;
        
        private static Lazy<ITypedElement> _newStateAttribute = new Lazy<ITypedElement>(RetrieveNewStateAttribute);
        
        private static Lazy<ITypedElement> _switchesReference = new Lazy<ITypedElement>(RetrieveSwitchesReference);
        
        /// <summary>
        /// The backing field for the Switches property
        /// </summary>
        private SwitchingOperationSwitchesCollection _switches;
        
        private static Lazy<ITypedElement> _outageScheduleReference = new Lazy<ITypedElement>(RetrieveOutageScheduleReference);
        
        /// <summary>
        /// The backing field for the OutageSchedule property
        /// </summary>
        private IOutageSchedule _outageSchedule;
        
        private static IClass _classInstance;
        
        public SwitchingOperation()
        {
            this._switches = new SwitchingOperationSwitchesCollection(this);
            this._switches.CollectionChanging += this.SwitchesCollectionChanging;
            this._switches.CollectionChanged += this.SwitchesCollectionChanged;
        }
        
        /// <summary>
        /// The operationTime property
        /// </summary>
        [XmlElementNameAttribute("operationTime")]
        [XmlAttributeAttribute(true)]
        public virtual DateTime OperationTime
        {
            get
            {
                return this._operationTime;
            }
            set
            {
                if ((this._operationTime != value))
                {
                    DateTime old = this._operationTime;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnOperationTimeChanging(e);
                    this.OnPropertyChanging("OperationTime", e, _operationTimeAttribute);
                    this._operationTime = value;
                    this.OnOperationTimeChanged(e);
                    this.OnPropertyChanged("OperationTime", e, _operationTimeAttribute);
                }
            }
        }
        
        /// <summary>
        /// The newState property
        /// </summary>
        [XmlElementNameAttribute("newState")]
        [XmlAttributeAttribute(true)]
        public virtual Nullable<SwitchState> NewState
        {
            get
            {
                return this._newState;
            }
            set
            {
                if ((this._newState != value))
                {
                    Nullable<SwitchState> old = this._newState;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnNewStateChanging(e);
                    this.OnPropertyChanging("NewState", e, _newStateAttribute);
                    this._newState = value;
                    this.OnNewStateChanged(e);
                    this.OnPropertyChanged("NewState", e, _newStateAttribute);
                }
            }
        }
        
        /// <summary>
        /// The Switches property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("SwitchingOperations")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<ISwitch> Switches
        {
            get
            {
                return this._switches;
            }
        }
        
        /// <summary>
        /// The OutageSchedule property
        /// </summary>
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("SwitchingOperations")]
        public virtual IOutageSchedule OutageSchedule
        {
            get
            {
                return this._outageSchedule;
            }
            set
            {
                if ((this._outageSchedule != value))
                {
                    IOutageSchedule old = this._outageSchedule;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnOutageScheduleChanging(e);
                    this.OnPropertyChanging("OutageSchedule", e, _outageScheduleReference);
                    this._outageSchedule = value;
                    if ((old != null))
                    {
                        old.SwitchingOperations.Remove(this);
                        old.Deleted -= this.OnResetOutageSchedule;
                    }
                    if ((value != null))
                    {
                        value.SwitchingOperations.Add(this);
                        value.Deleted += this.OnResetOutageSchedule;
                    }
                    this.OnOutageScheduleChanged(e);
                    this.OnPropertyChanged("OutageSchedule", e, _outageScheduleReference);
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
                return base.ReferencedElements.Concat(new SwitchingOperationReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Outage/SwitchingOperation")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the OperationTime property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> OperationTimeChanging;
        
        /// <summary>
        /// Gets fired when the OperationTime property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> OperationTimeChanged;
        
        /// <summary>
        /// Gets fired before the NewState property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> NewStateChanging;
        
        /// <summary>
        /// Gets fired when the NewState property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> NewStateChanged;
        
        /// <summary>
        /// Gets fired before the OutageSchedule property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> OutageScheduleChanging;
        
        /// <summary>
        /// Gets fired when the OutageSchedule property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> OutageScheduleChanged;
        
        private static ITypedElement RetrieveOperationTimeAttribute()
        {
            return ((ITypedElement)(((ModelElement)(SwitchingOperation.ClassInstance)).Resolve("operationTime")));
        }
        
        /// <summary>
        /// Raises the OperationTimeChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnOperationTimeChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.OperationTimeChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the OperationTimeChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnOperationTimeChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.OperationTimeChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveNewStateAttribute()
        {
            return ((ITypedElement)(((ModelElement)(SwitchingOperation.ClassInstance)).Resolve("newState")));
        }
        
        /// <summary>
        /// Raises the NewStateChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnNewStateChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.NewStateChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the NewStateChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnNewStateChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.NewStateChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveSwitchesReference()
        {
            return ((ITypedElement)(((ModelElement)(SwitchingOperation.ClassInstance)).Resolve("Switches")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the Switches property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void SwitchesCollectionChanging(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanging("Switches", e, _switchesReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the Switches property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void SwitchesCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("Switches", e, _switchesReference);
        }
        
        private static ITypedElement RetrieveOutageScheduleReference()
        {
            return ((ITypedElement)(((ModelElement)(SwitchingOperation.ClassInstance)).Resolve("OutageSchedule")));
        }
        
        /// <summary>
        /// Raises the OutageScheduleChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnOutageScheduleChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.OutageScheduleChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the OutageScheduleChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnOutageScheduleChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.OutageScheduleChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the OutageSchedule property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetOutageSchedule(object sender, System.EventArgs eventArgs)
        {
            this.OutageSchedule = null;
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "OPERATIONTIME"))
            {
                return this.OperationTime;
            }
            if ((attribute == "NEWSTATE"))
            {
                return this.NewState;
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
            if ((feature == "SWITCHES"))
            {
                return this._switches;
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
            if ((feature == "OUTAGESCHEDULE"))
            {
                this.OutageSchedule = ((IOutageSchedule)(value));
                return;
            }
            if ((feature == "OPERATIONTIME"))
            {
                this.OperationTime = ((DateTime)(value));
                return;
            }
            if ((feature == "NEWSTATE"))
            {
                this.NewState = ((SwitchState)(value));
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
            if ((attribute == "OutageSchedule"))
            {
                return new OutageScheduleProxy(this);
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
            if ((reference == "OutageSchedule"))
            {
                return new OutageScheduleProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Outage/SwitchingOperation")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the SwitchingOperation class
        /// </summary>
        public class SwitchingOperationReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private SwitchingOperation _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public SwitchingOperationReferencedElementsCollection(SwitchingOperation parent)
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
                    count = (count + this._parent.Switches.Count);
                    if ((this._parent.OutageSchedule != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.Switches.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.OutageScheduleChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.Switches.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.OutageScheduleChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                ISwitch switchesCasted = item.As<ISwitch>();
                if ((switchesCasted != null))
                {
                    this._parent.Switches.Add(switchesCasted);
                }
                if ((this._parent.OutageSchedule == null))
                {
                    IOutageSchedule outageScheduleCasted = item.As<IOutageSchedule>();
                    if ((outageScheduleCasted != null))
                    {
                        this._parent.OutageSchedule = outageScheduleCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.Switches.Clear();
                this._parent.OutageSchedule = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.Switches.Contains(item))
                {
                    return true;
                }
                if ((item == this._parent.OutageSchedule))
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
                IEnumerator<IModelElement> switchesEnumerator = this._parent.Switches.GetEnumerator();
                try
                {
                    for (
                    ; switchesEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = switchesEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    switchesEnumerator.Dispose();
                }
                if ((this._parent.OutageSchedule != null))
                {
                    array[arrayIndex] = this._parent.OutageSchedule;
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
                ISwitch switchItem = item.As<ISwitch>();
                if (((switchItem != null) 
                            && this._parent.Switches.Remove(switchItem)))
                {
                    return true;
                }
                if ((this._parent.OutageSchedule == item))
                {
                    this._parent.OutageSchedule = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.Switches).Concat(this._parent.OutageSchedule).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the operationTime property
        /// </summary>
        private sealed class OperationTimeProxy : ModelPropertyChange<ISwitchingOperation, DateTime>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public OperationTimeProxy(ISwitchingOperation modelElement) : 
                    base(modelElement, "operationTime")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override DateTime Value
            {
                get
                {
                    return this.ModelElement.OperationTime;
                }
                set
                {
                    this.ModelElement.OperationTime = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the newState property
        /// </summary>
        private sealed class NewStateProxy : ModelPropertyChange<ISwitchingOperation, Nullable<SwitchState>>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public NewStateProxy(ISwitchingOperation modelElement) : 
                    base(modelElement, "newState")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override Nullable<SwitchState> Value
            {
                get
                {
                    return this.ModelElement.NewState;
                }
                set
                {
                    this.ModelElement.NewState = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the OutageSchedule property
        /// </summary>
        private sealed class OutageScheduleProxy : ModelPropertyChange<ISwitchingOperation, IOutageSchedule>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public OutageScheduleProxy(ISwitchingOperation modelElement) : 
                    base(modelElement, "OutageSchedule")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IOutageSchedule Value
            {
                get
                {
                    return this.ModelElement.OutageSchedule;
                }
                set
                {
                    this.ModelElement.OutageSchedule = value;
                }
            }
        }
    }
}

