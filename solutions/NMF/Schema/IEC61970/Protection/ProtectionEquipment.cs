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
using TTC2017.SmartGrids.CIM.IEC61970.Wires;

namespace TTC2017.SmartGrids.CIM.IEC61970.Protection
{
    
    
    /// <summary>
    /// The default implementation of the ProtectionEquipment class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#Protection")]
    [XmlNamespacePrefixAttribute("cimProtection")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Protection/ProtectionEquipmen" +
        "t")]
    [DebuggerDisplayAttribute("ProtectionEquipment {UUID}")]
    public partial class ProtectionEquipment : Equipment, IProtectionEquipment, IModelElement
    {
        
        /// <summary>
        /// The backing field for the HighLimit property
        /// </summary>
        private float _highLimit;
        
        private static Lazy<ITypedElement> _highLimitAttribute = new Lazy<ITypedElement>(RetrieveHighLimitAttribute);
        
        /// <summary>
        /// The backing field for the RelayDelayTime property
        /// </summary>
        private float _relayDelayTime;
        
        private static Lazy<ITypedElement> _relayDelayTimeAttribute = new Lazy<ITypedElement>(RetrieveRelayDelayTimeAttribute);
        
        /// <summary>
        /// The backing field for the PowerDirectionFlag property
        /// </summary>
        private bool _powerDirectionFlag;
        
        private static Lazy<ITypedElement> _powerDirectionFlagAttribute = new Lazy<ITypedElement>(RetrievePowerDirectionFlagAttribute);
        
        /// <summary>
        /// The backing field for the LowLimit property
        /// </summary>
        private float _lowLimit;
        
        private static Lazy<ITypedElement> _lowLimitAttribute = new Lazy<ITypedElement>(RetrieveLowLimitAttribute);
        
        private static Lazy<ITypedElement> _conductingEquipmentsReference = new Lazy<ITypedElement>(RetrieveConductingEquipmentsReference);
        
        /// <summary>
        /// The backing field for the ConductingEquipments property
        /// </summary>
        private ProtectionEquipmentConductingEquipmentsCollection _conductingEquipments;
        
        private static Lazy<ITypedElement> _unitReference = new Lazy<ITypedElement>(RetrieveUnitReference);
        
        /// <summary>
        /// The backing field for the Unit property
        /// </summary>
        private IUnit _unit;
        
        private static Lazy<ITypedElement> _protectedSwitchesReference = new Lazy<ITypedElement>(RetrieveProtectedSwitchesReference);
        
        /// <summary>
        /// The backing field for the ProtectedSwitches property
        /// </summary>
        private ObservableAssociationOrderedSet<IProtectedSwitch> _protectedSwitches;
        
        private static IClass _classInstance;
        
        public ProtectionEquipment()
        {
            this._conductingEquipments = new ProtectionEquipmentConductingEquipmentsCollection(this);
            this._conductingEquipments.CollectionChanging += this.ConductingEquipmentsCollectionChanging;
            this._conductingEquipments.CollectionChanged += this.ConductingEquipmentsCollectionChanged;
            this._protectedSwitches = new ObservableAssociationOrderedSet<IProtectedSwitch>();
            this._protectedSwitches.CollectionChanging += this.ProtectedSwitchesCollectionChanging;
            this._protectedSwitches.CollectionChanged += this.ProtectedSwitchesCollectionChanged;
        }
        
        /// <summary>
        /// The highLimit property
        /// </summary>
        [XmlElementNameAttribute("highLimit")]
        [XmlAttributeAttribute(true)]
        public virtual float HighLimit
        {
            get
            {
                return this._highLimit;
            }
            set
            {
                if ((this._highLimit != value))
                {
                    float old = this._highLimit;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnHighLimitChanging(e);
                    this.OnPropertyChanging("HighLimit", e, _highLimitAttribute);
                    this._highLimit = value;
                    this.OnHighLimitChanged(e);
                    this.OnPropertyChanged("HighLimit", e, _highLimitAttribute);
                }
            }
        }
        
        /// <summary>
        /// The relayDelayTime property
        /// </summary>
        [XmlElementNameAttribute("relayDelayTime")]
        [XmlAttributeAttribute(true)]
        public virtual float RelayDelayTime
        {
            get
            {
                return this._relayDelayTime;
            }
            set
            {
                if ((this._relayDelayTime != value))
                {
                    float old = this._relayDelayTime;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnRelayDelayTimeChanging(e);
                    this.OnPropertyChanging("RelayDelayTime", e, _relayDelayTimeAttribute);
                    this._relayDelayTime = value;
                    this.OnRelayDelayTimeChanged(e);
                    this.OnPropertyChanged("RelayDelayTime", e, _relayDelayTimeAttribute);
                }
            }
        }
        
        /// <summary>
        /// The powerDirectionFlag property
        /// </summary>
        [XmlElementNameAttribute("powerDirectionFlag")]
        [XmlAttributeAttribute(true)]
        public virtual bool PowerDirectionFlag
        {
            get
            {
                return this._powerDirectionFlag;
            }
            set
            {
                if ((this._powerDirectionFlag != value))
                {
                    bool old = this._powerDirectionFlag;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnPowerDirectionFlagChanging(e);
                    this.OnPropertyChanging("PowerDirectionFlag", e, _powerDirectionFlagAttribute);
                    this._powerDirectionFlag = value;
                    this.OnPowerDirectionFlagChanged(e);
                    this.OnPropertyChanged("PowerDirectionFlag", e, _powerDirectionFlagAttribute);
                }
            }
        }
        
        /// <summary>
        /// The lowLimit property
        /// </summary>
        [XmlElementNameAttribute("lowLimit")]
        [XmlAttributeAttribute(true)]
        public virtual float LowLimit
        {
            get
            {
                return this._lowLimit;
            }
            set
            {
                if ((this._lowLimit != value))
                {
                    float old = this._lowLimit;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnLowLimitChanging(e);
                    this.OnPropertyChanging("LowLimit", e, _lowLimitAttribute);
                    this._lowLimit = value;
                    this.OnLowLimitChanged(e);
                    this.OnPropertyChanged("LowLimit", e, _lowLimitAttribute);
                }
            }
        }
        
        /// <summary>
        /// The ConductingEquipments property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("ProtectionEquipments")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<IConductingEquipment> ConductingEquipments
        {
            get
            {
                return this._conductingEquipments;
            }
        }
        
        /// <summary>
        /// The Unit property
        /// </summary>
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("ProtectionEquipments")]
        public virtual IUnit Unit
        {
            get
            {
                return this._unit;
            }
            set
            {
                if ((this._unit != value))
                {
                    IUnit old = this._unit;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnUnitChanging(e);
                    this.OnPropertyChanging("Unit", e, _unitReference);
                    this._unit = value;
                    if ((old != null))
                    {
                        old.ProtectionEquipments.Remove(this);
                        old.Deleted -= this.OnResetUnit;
                    }
                    if ((value != null))
                    {
                        value.ProtectionEquipments.Add(this);
                        value.Deleted += this.OnResetUnit;
                    }
                    this.OnUnitChanged(e);
                    this.OnPropertyChanged("Unit", e, _unitReference);
                }
            }
        }
        
        /// <summary>
        /// The ProtectedSwitches property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<IProtectedSwitch> ProtectedSwitches
        {
            get
            {
                return this._protectedSwitches;
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new ProtectionEquipmentReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Protection/ProtectionEquipmen" +
                            "t")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the HighLimit property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> HighLimitChanging;
        
        /// <summary>
        /// Gets fired when the HighLimit property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> HighLimitChanged;
        
        /// <summary>
        /// Gets fired before the RelayDelayTime property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> RelayDelayTimeChanging;
        
        /// <summary>
        /// Gets fired when the RelayDelayTime property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> RelayDelayTimeChanged;
        
        /// <summary>
        /// Gets fired before the PowerDirectionFlag property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> PowerDirectionFlagChanging;
        
        /// <summary>
        /// Gets fired when the PowerDirectionFlag property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> PowerDirectionFlagChanged;
        
        /// <summary>
        /// Gets fired before the LowLimit property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> LowLimitChanging;
        
        /// <summary>
        /// Gets fired when the LowLimit property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> LowLimitChanged;
        
        /// <summary>
        /// Gets fired before the Unit property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> UnitChanging;
        
        /// <summary>
        /// Gets fired when the Unit property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> UnitChanged;
        
        private static ITypedElement RetrieveHighLimitAttribute()
        {
            return ((ITypedElement)(((ModelElement)(ProtectionEquipment.ClassInstance)).Resolve("highLimit")));
        }
        
        /// <summary>
        /// Raises the HighLimitChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnHighLimitChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.HighLimitChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the HighLimitChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnHighLimitChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.HighLimitChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveRelayDelayTimeAttribute()
        {
            return ((ITypedElement)(((ModelElement)(ProtectionEquipment.ClassInstance)).Resolve("relayDelayTime")));
        }
        
        /// <summary>
        /// Raises the RelayDelayTimeChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnRelayDelayTimeChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.RelayDelayTimeChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the RelayDelayTimeChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnRelayDelayTimeChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.RelayDelayTimeChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrievePowerDirectionFlagAttribute()
        {
            return ((ITypedElement)(((ModelElement)(ProtectionEquipment.ClassInstance)).Resolve("powerDirectionFlag")));
        }
        
        /// <summary>
        /// Raises the PowerDirectionFlagChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnPowerDirectionFlagChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.PowerDirectionFlagChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the PowerDirectionFlagChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnPowerDirectionFlagChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.PowerDirectionFlagChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveLowLimitAttribute()
        {
            return ((ITypedElement)(((ModelElement)(ProtectionEquipment.ClassInstance)).Resolve("lowLimit")));
        }
        
        /// <summary>
        /// Raises the LowLimitChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnLowLimitChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.LowLimitChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the LowLimitChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnLowLimitChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.LowLimitChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveConductingEquipmentsReference()
        {
            return ((ITypedElement)(((ModelElement)(ProtectionEquipment.ClassInstance)).Resolve("ConductingEquipments")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the ConductingEquipments property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void ConductingEquipmentsCollectionChanging(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanging("ConductingEquipments", e, _conductingEquipmentsReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the ConductingEquipments property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void ConductingEquipmentsCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("ConductingEquipments", e, _conductingEquipmentsReference);
        }
        
        private static ITypedElement RetrieveUnitReference()
        {
            return ((ITypedElement)(((ModelElement)(ProtectionEquipment.ClassInstance)).Resolve("Unit")));
        }
        
        /// <summary>
        /// Raises the UnitChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnUnitChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.UnitChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the UnitChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnUnitChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.UnitChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the Unit property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetUnit(object sender, System.EventArgs eventArgs)
        {
            this.Unit = null;
        }
        
        private static ITypedElement RetrieveProtectedSwitchesReference()
        {
            return ((ITypedElement)(((ModelElement)(ProtectionEquipment.ClassInstance)).Resolve("ProtectedSwitches")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the ProtectedSwitches property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void ProtectedSwitchesCollectionChanging(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanging("ProtectedSwitches", e, _protectedSwitchesReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the ProtectedSwitches property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void ProtectedSwitchesCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("ProtectedSwitches", e, _protectedSwitchesReference);
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "HIGHLIMIT"))
            {
                return this.HighLimit;
            }
            if ((attribute == "RELAYDELAYTIME"))
            {
                return this.RelayDelayTime;
            }
            if ((attribute == "POWERDIRECTIONFLAG"))
            {
                return this.PowerDirectionFlag;
            }
            if ((attribute == "LOWLIMIT"))
            {
                return this.LowLimit;
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
            if ((feature == "CONDUCTINGEQUIPMENTS"))
            {
                return this._conductingEquipments;
            }
            if ((feature == "PROTECTEDSWITCHES"))
            {
                return this._protectedSwitches;
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
            if ((feature == "UNIT"))
            {
                this.Unit = ((IUnit)(value));
                return;
            }
            if ((feature == "HIGHLIMIT"))
            {
                this.HighLimit = ((float)(value));
                return;
            }
            if ((feature == "RELAYDELAYTIME"))
            {
                this.RelayDelayTime = ((float)(value));
                return;
            }
            if ((feature == "POWERDIRECTIONFLAG"))
            {
                this.PowerDirectionFlag = ((bool)(value));
                return;
            }
            if ((feature == "LOWLIMIT"))
            {
                this.LowLimit = ((float)(value));
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
            if ((attribute == "Unit"))
            {
                return new UnitProxy(this);
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
            if ((reference == "Unit"))
            {
                return new UnitProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Protection/ProtectionEquipmen" +
                        "t")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the ProtectionEquipment class
        /// </summary>
        public class ProtectionEquipmentReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private ProtectionEquipment _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public ProtectionEquipmentReferencedElementsCollection(ProtectionEquipment parent)
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
                    count = (count + this._parent.ConductingEquipments.Count);
                    if ((this._parent.Unit != null))
                    {
                        count = (count + 1);
                    }
                    count = (count + this._parent.ProtectedSwitches.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.ConductingEquipments.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.UnitChanged += this.PropagateValueChanges;
                this._parent.ProtectedSwitches.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.ConductingEquipments.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.UnitChanged -= this.PropagateValueChanges;
                this._parent.ProtectedSwitches.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IConductingEquipment conductingEquipmentsCasted = item.As<IConductingEquipment>();
                if ((conductingEquipmentsCasted != null))
                {
                    this._parent.ConductingEquipments.Add(conductingEquipmentsCasted);
                }
                if ((this._parent.Unit == null))
                {
                    IUnit unitCasted = item.As<IUnit>();
                    if ((unitCasted != null))
                    {
                        this._parent.Unit = unitCasted;
                        return;
                    }
                }
                IProtectedSwitch protectedSwitchesCasted = item.As<IProtectedSwitch>();
                if ((protectedSwitchesCasted != null))
                {
                    this._parent.ProtectedSwitches.Add(protectedSwitchesCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.ConductingEquipments.Clear();
                this._parent.Unit = null;
                this._parent.ProtectedSwitches.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.ConductingEquipments.Contains(item))
                {
                    return true;
                }
                if ((item == this._parent.Unit))
                {
                    return true;
                }
                if (this._parent.ProtectedSwitches.Contains(item))
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
                IEnumerator<IModelElement> conductingEquipmentsEnumerator = this._parent.ConductingEquipments.GetEnumerator();
                try
                {
                    for (
                    ; conductingEquipmentsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = conductingEquipmentsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    conductingEquipmentsEnumerator.Dispose();
                }
                if ((this._parent.Unit != null))
                {
                    array[arrayIndex] = this._parent.Unit;
                    arrayIndex = (arrayIndex + 1);
                }
                IEnumerator<IModelElement> protectedSwitchesEnumerator = this._parent.ProtectedSwitches.GetEnumerator();
                try
                {
                    for (
                    ; protectedSwitchesEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = protectedSwitchesEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    protectedSwitchesEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IConductingEquipment conductingEquipmentItem = item.As<IConductingEquipment>();
                if (((conductingEquipmentItem != null) 
                            && this._parent.ConductingEquipments.Remove(conductingEquipmentItem)))
                {
                    return true;
                }
                if ((this._parent.Unit == item))
                {
                    this._parent.Unit = null;
                    return true;
                }
                IProtectedSwitch protectedSwitchItem = item.As<IProtectedSwitch>();
                if (((protectedSwitchItem != null) 
                            && this._parent.ProtectedSwitches.Remove(protectedSwitchItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.ConductingEquipments).Concat(this._parent.Unit).Concat(this._parent.ProtectedSwitches).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the highLimit property
        /// </summary>
        private sealed class HighLimitProxy : ModelPropertyChange<IProtectionEquipment, float>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public HighLimitProxy(IProtectionEquipment modelElement) : 
                    base(modelElement, "highLimit")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override float Value
            {
                get
                {
                    return this.ModelElement.HighLimit;
                }
                set
                {
                    this.ModelElement.HighLimit = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the relayDelayTime property
        /// </summary>
        private sealed class RelayDelayTimeProxy : ModelPropertyChange<IProtectionEquipment, float>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public RelayDelayTimeProxy(IProtectionEquipment modelElement) : 
                    base(modelElement, "relayDelayTime")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override float Value
            {
                get
                {
                    return this.ModelElement.RelayDelayTime;
                }
                set
                {
                    this.ModelElement.RelayDelayTime = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the powerDirectionFlag property
        /// </summary>
        private sealed class PowerDirectionFlagProxy : ModelPropertyChange<IProtectionEquipment, bool>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public PowerDirectionFlagProxy(IProtectionEquipment modelElement) : 
                    base(modelElement, "powerDirectionFlag")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override bool Value
            {
                get
                {
                    return this.ModelElement.PowerDirectionFlag;
                }
                set
                {
                    this.ModelElement.PowerDirectionFlag = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the lowLimit property
        /// </summary>
        private sealed class LowLimitProxy : ModelPropertyChange<IProtectionEquipment, float>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public LowLimitProxy(IProtectionEquipment modelElement) : 
                    base(modelElement, "lowLimit")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override float Value
            {
                get
                {
                    return this.ModelElement.LowLimit;
                }
                set
                {
                    this.ModelElement.LowLimit = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the Unit property
        /// </summary>
        private sealed class UnitProxy : ModelPropertyChange<IProtectionEquipment, IUnit>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public UnitProxy(IProtectionEquipment modelElement) : 
                    base(modelElement, "Unit")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IUnit Value
            {
                get
                {
                    return this.ModelElement.Unit;
                }
                set
                {
                    this.ModelElement.Unit = value;
                }
            }
        }
    }
}

