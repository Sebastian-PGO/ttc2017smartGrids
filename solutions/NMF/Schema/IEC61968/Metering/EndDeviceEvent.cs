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
    /// The default implementation of the EndDeviceEvent class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#Metering")]
    [XmlNamespacePrefixAttribute("cimMetering")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61968/Metering/EndDeviceEvent")]
    [DebuggerDisplayAttribute("EndDeviceEvent {UUID}")]
    public partial class EndDeviceEvent : ActivityRecord, IEndDeviceEvent, IModelElement
    {
        
        /// <summary>
        /// The backing field for the UserID property
        /// </summary>
        private string _userID;
        
        private static Lazy<ITypedElement> _userIDAttribute = new Lazy<ITypedElement>(RetrieveUserIDAttribute);
        
        private static Lazy<ITypedElement> _meterReadingReference = new Lazy<ITypedElement>(RetrieveMeterReadingReference);
        
        /// <summary>
        /// The backing field for the MeterReading property
        /// </summary>
        private IMeterReading _meterReading;
        
        private static Lazy<ITypedElement> _deviceFunctionReference = new Lazy<ITypedElement>(RetrieveDeviceFunctionReference);
        
        /// <summary>
        /// The backing field for the DeviceFunction property
        /// </summary>
        private IDeviceFunction _deviceFunction;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The userID property
        /// </summary>
        [XmlElementNameAttribute("userID")]
        [XmlAttributeAttribute(true)]
        public virtual string UserID
        {
            get
            {
                return this._userID;
            }
            set
            {
                if ((this._userID != value))
                {
                    string old = this._userID;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnUserIDChanging(e);
                    this.OnPropertyChanging("UserID", e, _userIDAttribute);
                    this._userID = value;
                    this.OnUserIDChanged(e);
                    this.OnPropertyChanged("UserID", e, _userIDAttribute);
                }
            }
        }
        
        /// <summary>
        /// The MeterReading property
        /// </summary>
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("EndDeviceEvents")]
        public virtual IMeterReading MeterReading
        {
            get
            {
                return this._meterReading;
            }
            set
            {
                if ((this._meterReading != value))
                {
                    IMeterReading old = this._meterReading;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnMeterReadingChanging(e);
                    this.OnPropertyChanging("MeterReading", e, _meterReadingReference);
                    this._meterReading = value;
                    if ((old != null))
                    {
                        old.EndDeviceEvents.Remove(this);
                        old.Deleted -= this.OnResetMeterReading;
                    }
                    if ((value != null))
                    {
                        value.EndDeviceEvents.Add(this);
                        value.Deleted += this.OnResetMeterReading;
                    }
                    this.OnMeterReadingChanged(e);
                    this.OnPropertyChanged("MeterReading", e, _meterReadingReference);
                }
            }
        }
        
        /// <summary>
        /// The DeviceFunction property
        /// </summary>
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("EndDeviceEvents")]
        public virtual IDeviceFunction DeviceFunction
        {
            get
            {
                return this._deviceFunction;
            }
            set
            {
                if ((this._deviceFunction != value))
                {
                    IDeviceFunction old = this._deviceFunction;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnDeviceFunctionChanging(e);
                    this.OnPropertyChanging("DeviceFunction", e, _deviceFunctionReference);
                    this._deviceFunction = value;
                    if ((old != null))
                    {
                        old.EndDeviceEvents.Remove(this);
                        old.Deleted -= this.OnResetDeviceFunction;
                    }
                    if ((value != null))
                    {
                        value.EndDeviceEvents.Add(this);
                        value.Deleted += this.OnResetDeviceFunction;
                    }
                    this.OnDeviceFunctionChanged(e);
                    this.OnPropertyChanged("DeviceFunction", e, _deviceFunctionReference);
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
                return base.ReferencedElements.Concat(new EndDeviceEventReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61968/Metering/EndDeviceEvent")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the UserID property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> UserIDChanging;
        
        /// <summary>
        /// Gets fired when the UserID property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> UserIDChanged;
        
        /// <summary>
        /// Gets fired before the MeterReading property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> MeterReadingChanging;
        
        /// <summary>
        /// Gets fired when the MeterReading property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> MeterReadingChanged;
        
        /// <summary>
        /// Gets fired before the DeviceFunction property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> DeviceFunctionChanging;
        
        /// <summary>
        /// Gets fired when the DeviceFunction property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> DeviceFunctionChanged;
        
        private static ITypedElement RetrieveUserIDAttribute()
        {
            return ((ITypedElement)(((ModelElement)(EndDeviceEvent.ClassInstance)).Resolve("userID")));
        }
        
        /// <summary>
        /// Raises the UserIDChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnUserIDChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.UserIDChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the UserIDChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnUserIDChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.UserIDChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveMeterReadingReference()
        {
            return ((ITypedElement)(((ModelElement)(EndDeviceEvent.ClassInstance)).Resolve("MeterReading")));
        }
        
        /// <summary>
        /// Raises the MeterReadingChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnMeterReadingChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.MeterReadingChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the MeterReadingChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnMeterReadingChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.MeterReadingChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the MeterReading property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetMeterReading(object sender, System.EventArgs eventArgs)
        {
            this.MeterReading = null;
        }
        
        private static ITypedElement RetrieveDeviceFunctionReference()
        {
            return ((ITypedElement)(((ModelElement)(EndDeviceEvent.ClassInstance)).Resolve("DeviceFunction")));
        }
        
        /// <summary>
        /// Raises the DeviceFunctionChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnDeviceFunctionChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.DeviceFunctionChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the DeviceFunctionChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnDeviceFunctionChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.DeviceFunctionChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the DeviceFunction property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetDeviceFunction(object sender, System.EventArgs eventArgs)
        {
            this.DeviceFunction = null;
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "USERID"))
            {
                return this.UserID;
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
            if ((feature == "METERREADING"))
            {
                this.MeterReading = ((IMeterReading)(value));
                return;
            }
            if ((feature == "DEVICEFUNCTION"))
            {
                this.DeviceFunction = ((IDeviceFunction)(value));
                return;
            }
            if ((feature == "USERID"))
            {
                this.UserID = ((string)(value));
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
            if ((attribute == "MeterReading"))
            {
                return new MeterReadingProxy(this);
            }
            if ((attribute == "DeviceFunction"))
            {
                return new DeviceFunctionProxy(this);
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
            if ((reference == "MeterReading"))
            {
                return new MeterReadingProxy(this);
            }
            if ((reference == "DeviceFunction"))
            {
                return new DeviceFunctionProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61968/Metering/EndDeviceEvent")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the EndDeviceEvent class
        /// </summary>
        public class EndDeviceEventReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private EndDeviceEvent _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public EndDeviceEventReferencedElementsCollection(EndDeviceEvent parent)
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
                    if ((this._parent.MeterReading != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.DeviceFunction != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.MeterReadingChanged += this.PropagateValueChanges;
                this._parent.DeviceFunctionChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.MeterReadingChanged -= this.PropagateValueChanges;
                this._parent.DeviceFunctionChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.MeterReading == null))
                {
                    IMeterReading meterReadingCasted = item.As<IMeterReading>();
                    if ((meterReadingCasted != null))
                    {
                        this._parent.MeterReading = meterReadingCasted;
                        return;
                    }
                }
                if ((this._parent.DeviceFunction == null))
                {
                    IDeviceFunction deviceFunctionCasted = item.As<IDeviceFunction>();
                    if ((deviceFunctionCasted != null))
                    {
                        this._parent.DeviceFunction = deviceFunctionCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.MeterReading = null;
                this._parent.DeviceFunction = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.MeterReading))
                {
                    return true;
                }
                if ((item == this._parent.DeviceFunction))
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
                if ((this._parent.MeterReading != null))
                {
                    array[arrayIndex] = this._parent.MeterReading;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.DeviceFunction != null))
                {
                    array[arrayIndex] = this._parent.DeviceFunction;
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
                if ((this._parent.MeterReading == item))
                {
                    this._parent.MeterReading = null;
                    return true;
                }
                if ((this._parent.DeviceFunction == item))
                {
                    this._parent.DeviceFunction = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.MeterReading).Concat(this._parent.DeviceFunction).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the userID property
        /// </summary>
        private sealed class UserIDProxy : ModelPropertyChange<IEndDeviceEvent, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public UserIDProxy(IEndDeviceEvent modelElement) : 
                    base(modelElement, "userID")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override string Value
            {
                get
                {
                    return this.ModelElement.UserID;
                }
                set
                {
                    this.ModelElement.UserID = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the MeterReading property
        /// </summary>
        private sealed class MeterReadingProxy : ModelPropertyChange<IEndDeviceEvent, IMeterReading>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public MeterReadingProxy(IEndDeviceEvent modelElement) : 
                    base(modelElement, "MeterReading")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IMeterReading Value
            {
                get
                {
                    return this.ModelElement.MeterReading;
                }
                set
                {
                    this.ModelElement.MeterReading = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the DeviceFunction property
        /// </summary>
        private sealed class DeviceFunctionProxy : ModelPropertyChange<IEndDeviceEvent, IDeviceFunction>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public DeviceFunctionProxy(IEndDeviceEvent modelElement) : 
                    base(modelElement, "DeviceFunction")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IDeviceFunction Value
            {
                get
                {
                    return this.ModelElement.DeviceFunction;
                }
                set
                {
                    this.ModelElement.DeviceFunction = value;
                }
            }
        }
    }
}

