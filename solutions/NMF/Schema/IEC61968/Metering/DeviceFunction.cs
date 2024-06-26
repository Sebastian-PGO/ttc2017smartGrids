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
using TTC2017.SmartGrids.CIM.IEC61968.AssetModels;
using TTC2017.SmartGrids.CIM.IEC61968.Assets;
using TTC2017.SmartGrids.CIM.IEC61968.Common;
using TTC2017.SmartGrids.CIM.IEC61968.Customers;
using TTC2017.SmartGrids.CIM.IEC61968.PaymentMetering;
using TTC2017.SmartGrids.CIM.IEC61968.WiresExt;
using TTC2017.SmartGrids.CIM.IEC61968.Work;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Domain;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssetModels;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssets;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfCustomers;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfMetering;
using TTC2017.SmartGrids.CIM.IEC61970.Meas;
using TTC2017.SmartGrids.CIM.IEC61970.Wires;

namespace TTC2017.SmartGrids.CIM.IEC61968.Metering
{
    
    
    /// <summary>
    /// The default implementation of the DeviceFunction class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#Metering")]
    [XmlNamespacePrefixAttribute("cimMetering")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61968/Metering/DeviceFunction")]
    [DebuggerDisplayAttribute("DeviceFunction {UUID}")]
    public partial class DeviceFunction : AssetFunction, IDeviceFunction, IModelElement
    {
        
        /// <summary>
        /// The backing field for the Disabled property
        /// </summary>
        private bool _disabled;
        
        private static Lazy<ITypedElement> _disabledAttribute = new Lazy<ITypedElement>(RetrieveDisabledAttribute);
        
        private static Lazy<ITypedElement> _comEquipmentAssetReference = new Lazy<ITypedElement>(RetrieveComEquipmentAssetReference);
        
        /// <summary>
        /// The backing field for the ComEquipmentAsset property
        /// </summary>
        private IComEquipmentInfo _comEquipmentAsset;
        
        private static Lazy<ITypedElement> _endDeviceAssetReference = new Lazy<ITypedElement>(RetrieveEndDeviceAssetReference);
        
        /// <summary>
        /// The backing field for the EndDeviceAsset property
        /// </summary>
        private IEndDeviceAsset _endDeviceAsset;
        
        private static Lazy<ITypedElement> _endDeviceEventsReference = new Lazy<ITypedElement>(RetrieveEndDeviceEventsReference);
        
        /// <summary>
        /// The backing field for the EndDeviceEvents property
        /// </summary>
        private DeviceFunctionEndDeviceEventsCollection _endDeviceEvents;
        
        private static Lazy<ITypedElement> _registersReference = new Lazy<ITypedElement>(RetrieveRegistersReference);
        
        /// <summary>
        /// The backing field for the Registers property
        /// </summary>
        private DeviceFunctionRegistersCollection _registers;
        
        private static IClass _classInstance;
        
        public DeviceFunction()
        {
            this._endDeviceEvents = new DeviceFunctionEndDeviceEventsCollection(this);
            this._endDeviceEvents.CollectionChanging += this.EndDeviceEventsCollectionChanging;
            this._endDeviceEvents.CollectionChanged += this.EndDeviceEventsCollectionChanged;
            this._registers = new DeviceFunctionRegistersCollection(this);
            this._registers.CollectionChanging += this.RegistersCollectionChanging;
            this._registers.CollectionChanged += this.RegistersCollectionChanged;
        }
        
        /// <summary>
        /// The disabled property
        /// </summary>
        [XmlElementNameAttribute("disabled")]
        [XmlAttributeAttribute(true)]
        public virtual bool Disabled
        {
            get
            {
                return this._disabled;
            }
            set
            {
                if ((this._disabled != value))
                {
                    bool old = this._disabled;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnDisabledChanging(e);
                    this.OnPropertyChanging("Disabled", e, _disabledAttribute);
                    this._disabled = value;
                    this.OnDisabledChanged(e);
                    this.OnPropertyChanged("Disabled", e, _disabledAttribute);
                }
            }
        }
        
        /// <summary>
        /// The ComEquipmentAsset property
        /// </summary>
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("DeviceFunctions")]
        public virtual IComEquipmentInfo ComEquipmentAsset
        {
            get
            {
                return this._comEquipmentAsset;
            }
            set
            {
                if ((this._comEquipmentAsset != value))
                {
                    IComEquipmentInfo old = this._comEquipmentAsset;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnComEquipmentAssetChanging(e);
                    this.OnPropertyChanging("ComEquipmentAsset", e, _comEquipmentAssetReference);
                    this._comEquipmentAsset = value;
                    if ((old != null))
                    {
                        old.DeviceFunctions.Remove(this);
                        old.Deleted -= this.OnResetComEquipmentAsset;
                    }
                    if ((value != null))
                    {
                        value.DeviceFunctions.Add(this);
                        value.Deleted += this.OnResetComEquipmentAsset;
                    }
                    this.OnComEquipmentAssetChanged(e);
                    this.OnPropertyChanged("ComEquipmentAsset", e, _comEquipmentAssetReference);
                }
            }
        }
        
        /// <summary>
        /// The EndDeviceAsset property
        /// </summary>
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("DeviceFunctions")]
        public virtual IEndDeviceAsset EndDeviceAsset
        {
            get
            {
                return this._endDeviceAsset;
            }
            set
            {
                if ((this._endDeviceAsset != value))
                {
                    IEndDeviceAsset old = this._endDeviceAsset;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnEndDeviceAssetChanging(e);
                    this.OnPropertyChanging("EndDeviceAsset", e, _endDeviceAssetReference);
                    this._endDeviceAsset = value;
                    if ((old != null))
                    {
                        old.DeviceFunctions.Remove(this);
                        old.Deleted -= this.OnResetEndDeviceAsset;
                    }
                    if ((value != null))
                    {
                        value.DeviceFunctions.Add(this);
                        value.Deleted += this.OnResetEndDeviceAsset;
                    }
                    this.OnEndDeviceAssetChanged(e);
                    this.OnPropertyChanged("EndDeviceAsset", e, _endDeviceAssetReference);
                }
            }
        }
        
        /// <summary>
        /// The EndDeviceEvents property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("DeviceFunction")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<IEndDeviceEvent> EndDeviceEvents
        {
            get
            {
                return this._endDeviceEvents;
            }
        }
        
        /// <summary>
        /// The Registers property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("DeviceFunction")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<IRegister> Registers
        {
            get
            {
                return this._registers;
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new DeviceFunctionReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61968/Metering/DeviceFunction")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the Disabled property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> DisabledChanging;
        
        /// <summary>
        /// Gets fired when the Disabled property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> DisabledChanged;
        
        /// <summary>
        /// Gets fired before the ComEquipmentAsset property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ComEquipmentAssetChanging;
        
        /// <summary>
        /// Gets fired when the ComEquipmentAsset property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ComEquipmentAssetChanged;
        
        /// <summary>
        /// Gets fired before the EndDeviceAsset property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> EndDeviceAssetChanging;
        
        /// <summary>
        /// Gets fired when the EndDeviceAsset property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> EndDeviceAssetChanged;
        
        private static ITypedElement RetrieveDisabledAttribute()
        {
            return ((ITypedElement)(((ModelElement)(DeviceFunction.ClassInstance)).Resolve("disabled")));
        }
        
        /// <summary>
        /// Raises the DisabledChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnDisabledChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.DisabledChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the DisabledChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnDisabledChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.DisabledChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveComEquipmentAssetReference()
        {
            return ((ITypedElement)(((ModelElement)(DeviceFunction.ClassInstance)).Resolve("ComEquipmentAsset")));
        }
        
        /// <summary>
        /// Raises the ComEquipmentAssetChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnComEquipmentAssetChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ComEquipmentAssetChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the ComEquipmentAssetChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnComEquipmentAssetChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ComEquipmentAssetChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the ComEquipmentAsset property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetComEquipmentAsset(object sender, System.EventArgs eventArgs)
        {
            this.ComEquipmentAsset = null;
        }
        
        private static ITypedElement RetrieveEndDeviceAssetReference()
        {
            return ((ITypedElement)(((ModelElement)(DeviceFunction.ClassInstance)).Resolve("EndDeviceAsset")));
        }
        
        /// <summary>
        /// Raises the EndDeviceAssetChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnEndDeviceAssetChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.EndDeviceAssetChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the EndDeviceAssetChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnEndDeviceAssetChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.EndDeviceAssetChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the EndDeviceAsset property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetEndDeviceAsset(object sender, System.EventArgs eventArgs)
        {
            this.EndDeviceAsset = null;
        }
        
        private static ITypedElement RetrieveEndDeviceEventsReference()
        {
            return ((ITypedElement)(((ModelElement)(DeviceFunction.ClassInstance)).Resolve("EndDeviceEvents")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the EndDeviceEvents property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void EndDeviceEventsCollectionChanging(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanging("EndDeviceEvents", e, _endDeviceEventsReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the EndDeviceEvents property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void EndDeviceEventsCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("EndDeviceEvents", e, _endDeviceEventsReference);
        }
        
        private static ITypedElement RetrieveRegistersReference()
        {
            return ((ITypedElement)(((ModelElement)(DeviceFunction.ClassInstance)).Resolve("Registers")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the Registers property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void RegistersCollectionChanging(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanging("Registers", e, _registersReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the Registers property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void RegistersCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("Registers", e, _registersReference);
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "DISABLED"))
            {
                return this.Disabled;
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
            if ((feature == "ENDDEVICEEVENTS"))
            {
                return this._endDeviceEvents;
            }
            if ((feature == "REGISTERS"))
            {
                return this._registers;
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
            if ((feature == "COMEQUIPMENTASSET"))
            {
                this.ComEquipmentAsset = ((IComEquipmentInfo)(value));
                return;
            }
            if ((feature == "ENDDEVICEASSET"))
            {
                this.EndDeviceAsset = ((IEndDeviceAsset)(value));
                return;
            }
            if ((feature == "DISABLED"))
            {
                this.Disabled = ((bool)(value));
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
            if ((attribute == "ComEquipmentAsset"))
            {
                return new ComEquipmentAssetProxy(this);
            }
            if ((attribute == "EndDeviceAsset"))
            {
                return new EndDeviceAssetProxy(this);
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
            if ((reference == "ComEquipmentAsset"))
            {
                return new ComEquipmentAssetProxy(this);
            }
            if ((reference == "EndDeviceAsset"))
            {
                return new EndDeviceAssetProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61968/Metering/DeviceFunction")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the DeviceFunction class
        /// </summary>
        public class DeviceFunctionReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private DeviceFunction _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public DeviceFunctionReferencedElementsCollection(DeviceFunction parent)
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
                    if ((this._parent.ComEquipmentAsset != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.EndDeviceAsset != null))
                    {
                        count = (count + 1);
                    }
                    count = (count + this._parent.EndDeviceEvents.Count);
                    count = (count + this._parent.Registers.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.ComEquipmentAssetChanged += this.PropagateValueChanges;
                this._parent.EndDeviceAssetChanged += this.PropagateValueChanges;
                this._parent.EndDeviceEvents.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.Registers.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.ComEquipmentAssetChanged -= this.PropagateValueChanges;
                this._parent.EndDeviceAssetChanged -= this.PropagateValueChanges;
                this._parent.EndDeviceEvents.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.Registers.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.ComEquipmentAsset == null))
                {
                    IComEquipmentInfo comEquipmentAssetCasted = item.As<IComEquipmentInfo>();
                    if ((comEquipmentAssetCasted != null))
                    {
                        this._parent.ComEquipmentAsset = comEquipmentAssetCasted;
                        return;
                    }
                }
                if ((this._parent.EndDeviceAsset == null))
                {
                    IEndDeviceAsset endDeviceAssetCasted = item.As<IEndDeviceAsset>();
                    if ((endDeviceAssetCasted != null))
                    {
                        this._parent.EndDeviceAsset = endDeviceAssetCasted;
                        return;
                    }
                }
                IEndDeviceEvent endDeviceEventsCasted = item.As<IEndDeviceEvent>();
                if ((endDeviceEventsCasted != null))
                {
                    this._parent.EndDeviceEvents.Add(endDeviceEventsCasted);
                }
                IRegister registersCasted = item.As<IRegister>();
                if ((registersCasted != null))
                {
                    this._parent.Registers.Add(registersCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.ComEquipmentAsset = null;
                this._parent.EndDeviceAsset = null;
                this._parent.EndDeviceEvents.Clear();
                this._parent.Registers.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.ComEquipmentAsset))
                {
                    return true;
                }
                if ((item == this._parent.EndDeviceAsset))
                {
                    return true;
                }
                if (this._parent.EndDeviceEvents.Contains(item))
                {
                    return true;
                }
                if (this._parent.Registers.Contains(item))
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
                if ((this._parent.ComEquipmentAsset != null))
                {
                    array[arrayIndex] = this._parent.ComEquipmentAsset;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.EndDeviceAsset != null))
                {
                    array[arrayIndex] = this._parent.EndDeviceAsset;
                    arrayIndex = (arrayIndex + 1);
                }
                IEnumerator<IModelElement> endDeviceEventsEnumerator = this._parent.EndDeviceEvents.GetEnumerator();
                try
                {
                    for (
                    ; endDeviceEventsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = endDeviceEventsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    endDeviceEventsEnumerator.Dispose();
                }
                IEnumerator<IModelElement> registersEnumerator = this._parent.Registers.GetEnumerator();
                try
                {
                    for (
                    ; registersEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = registersEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    registersEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                if ((this._parent.ComEquipmentAsset == item))
                {
                    this._parent.ComEquipmentAsset = null;
                    return true;
                }
                if ((this._parent.EndDeviceAsset == item))
                {
                    this._parent.EndDeviceAsset = null;
                    return true;
                }
                IEndDeviceEvent endDeviceEventItem = item.As<IEndDeviceEvent>();
                if (((endDeviceEventItem != null) 
                            && this._parent.EndDeviceEvents.Remove(endDeviceEventItem)))
                {
                    return true;
                }
                IRegister registerItem = item.As<IRegister>();
                if (((registerItem != null) 
                            && this._parent.Registers.Remove(registerItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.ComEquipmentAsset).Concat(this._parent.EndDeviceAsset).Concat(this._parent.EndDeviceEvents).Concat(this._parent.Registers).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the disabled property
        /// </summary>
        private sealed class DisabledProxy : ModelPropertyChange<IDeviceFunction, bool>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public DisabledProxy(IDeviceFunction modelElement) : 
                    base(modelElement, "disabled")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override bool Value
            {
                get
                {
                    return this.ModelElement.Disabled;
                }
                set
                {
                    this.ModelElement.Disabled = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the ComEquipmentAsset property
        /// </summary>
        private sealed class ComEquipmentAssetProxy : ModelPropertyChange<IDeviceFunction, IComEquipmentInfo>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public ComEquipmentAssetProxy(IDeviceFunction modelElement) : 
                    base(modelElement, "ComEquipmentAsset")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IComEquipmentInfo Value
            {
                get
                {
                    return this.ModelElement.ComEquipmentAsset;
                }
                set
                {
                    this.ModelElement.ComEquipmentAsset = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the EndDeviceAsset property
        /// </summary>
        private sealed class EndDeviceAssetProxy : ModelPropertyChange<IDeviceFunction, IEndDeviceAsset>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public EndDeviceAssetProxy(IDeviceFunction modelElement) : 
                    base(modelElement, "EndDeviceAsset")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IEndDeviceAsset Value
            {
                get
                {
                    return this.ModelElement.EndDeviceAsset;
                }
                set
                {
                    this.ModelElement.EndDeviceAsset = value;
                }
            }
        }
    }
}

