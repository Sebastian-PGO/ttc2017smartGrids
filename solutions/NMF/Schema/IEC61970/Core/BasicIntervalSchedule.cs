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
using TTC2017.SmartGrids.CIM.IEC61968.Assets;
using TTC2017.SmartGrids.CIM.IEC61968.Common;
using TTC2017.SmartGrids.CIM.IEC61968.Customers;
using TTC2017.SmartGrids.CIM.IEC61970.Contingency;
using TTC2017.SmartGrids.CIM.IEC61970.ControlArea;
using TTC2017.SmartGrids.CIM.IEC61970.Domain;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssets;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfCommon;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfCore;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfOperations;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.MarketOperations;
using TTC2017.SmartGrids.CIM.IEC61970.Meas;
using TTC2017.SmartGrids.CIM.IEC61970.OperationalLimits;
using TTC2017.SmartGrids.CIM.IEC61970.Outage;
using TTC2017.SmartGrids.CIM.IEC61970.Protection;
using TTC2017.SmartGrids.CIM.IEC61970.StateVariables;
using TTC2017.SmartGrids.CIM.IEC61970.Topology;
using TTC2017.SmartGrids.CIM.IEC61970.Wires;

namespace TTC2017.SmartGrids.CIM.IEC61970.Core
{
    
    
    /// <summary>
    /// The default implementation of the BasicIntervalSchedule class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#Core")]
    [XmlNamespacePrefixAttribute("cimCore")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Core/BasicIntervalSchedule")]
    [DebuggerDisplayAttribute("BasicIntervalSchedule {UUID}")]
    public partial class BasicIntervalSchedule : IdentifiedObject, IBasicIntervalSchedule, IModelElement
    {
        
        /// <summary>
        /// The backing field for the Value2Multiplier property
        /// </summary>
        private Nullable<UnitMultiplier> _value2Multiplier;
        
        private static Lazy<ITypedElement> _value2MultiplierAttribute = new Lazy<ITypedElement>(RetrieveValue2MultiplierAttribute);
        
        /// <summary>
        /// The backing field for the Value1Multiplier property
        /// </summary>
        private Nullable<UnitMultiplier> _value1Multiplier;
        
        private static Lazy<ITypedElement> _value1MultiplierAttribute = new Lazy<ITypedElement>(RetrieveValue1MultiplierAttribute);
        
        /// <summary>
        /// The backing field for the StartTime property
        /// </summary>
        private string _startTime;
        
        private static Lazy<ITypedElement> _startTimeAttribute = new Lazy<ITypedElement>(RetrieveStartTimeAttribute);
        
        /// <summary>
        /// The backing field for the Value2Unit property
        /// </summary>
        private Nullable<UnitSymbol> _value2Unit;
        
        private static Lazy<ITypedElement> _value2UnitAttribute = new Lazy<ITypedElement>(RetrieveValue2UnitAttribute);
        
        /// <summary>
        /// The backing field for the Value1Unit property
        /// </summary>
        private Nullable<UnitSymbol> _value1Unit;
        
        private static Lazy<ITypedElement> _value1UnitAttribute = new Lazy<ITypedElement>(RetrieveValue1UnitAttribute);
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The value2Multiplier property
        /// </summary>
        [XmlElementNameAttribute("value2Multiplier")]
        [XmlAttributeAttribute(true)]
        public virtual Nullable<UnitMultiplier> Value2Multiplier
        {
            get
            {
                return this._value2Multiplier;
            }
            set
            {
                if ((this._value2Multiplier != value))
                {
                    Nullable<UnitMultiplier> old = this._value2Multiplier;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnValue2MultiplierChanging(e);
                    this.OnPropertyChanging("Value2Multiplier", e, _value2MultiplierAttribute);
                    this._value2Multiplier = value;
                    this.OnValue2MultiplierChanged(e);
                    this.OnPropertyChanged("Value2Multiplier", e, _value2MultiplierAttribute);
                }
            }
        }
        
        /// <summary>
        /// The value1Multiplier property
        /// </summary>
        [XmlElementNameAttribute("value1Multiplier")]
        [XmlAttributeAttribute(true)]
        public virtual Nullable<UnitMultiplier> Value1Multiplier
        {
            get
            {
                return this._value1Multiplier;
            }
            set
            {
                if ((this._value1Multiplier != value))
                {
                    Nullable<UnitMultiplier> old = this._value1Multiplier;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnValue1MultiplierChanging(e);
                    this.OnPropertyChanging("Value1Multiplier", e, _value1MultiplierAttribute);
                    this._value1Multiplier = value;
                    this.OnValue1MultiplierChanged(e);
                    this.OnPropertyChanged("Value1Multiplier", e, _value1MultiplierAttribute);
                }
            }
        }
        
        /// <summary>
        /// The startTime property
        /// </summary>
        [XmlElementNameAttribute("startTime")]
        [XmlAttributeAttribute(true)]
        public virtual string StartTime
        {
            get
            {
                return this._startTime;
            }
            set
            {
                if ((this._startTime != value))
                {
                    string old = this._startTime;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnStartTimeChanging(e);
                    this.OnPropertyChanging("StartTime", e, _startTimeAttribute);
                    this._startTime = value;
                    this.OnStartTimeChanged(e);
                    this.OnPropertyChanged("StartTime", e, _startTimeAttribute);
                }
            }
        }
        
        /// <summary>
        /// The value2Unit property
        /// </summary>
        [XmlElementNameAttribute("value2Unit")]
        [XmlAttributeAttribute(true)]
        public virtual Nullable<UnitSymbol> Value2Unit
        {
            get
            {
                return this._value2Unit;
            }
            set
            {
                if ((this._value2Unit != value))
                {
                    Nullable<UnitSymbol> old = this._value2Unit;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnValue2UnitChanging(e);
                    this.OnPropertyChanging("Value2Unit", e, _value2UnitAttribute);
                    this._value2Unit = value;
                    this.OnValue2UnitChanged(e);
                    this.OnPropertyChanged("Value2Unit", e, _value2UnitAttribute);
                }
            }
        }
        
        /// <summary>
        /// The value1Unit property
        /// </summary>
        [XmlElementNameAttribute("value1Unit")]
        [XmlAttributeAttribute(true)]
        public virtual Nullable<UnitSymbol> Value1Unit
        {
            get
            {
                return this._value1Unit;
            }
            set
            {
                if ((this._value1Unit != value))
                {
                    Nullable<UnitSymbol> old = this._value1Unit;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnValue1UnitChanging(e);
                    this.OnPropertyChanging("Value1Unit", e, _value1UnitAttribute);
                    this._value1Unit = value;
                    this.OnValue1UnitChanged(e);
                    this.OnPropertyChanged("Value1Unit", e, _value1UnitAttribute);
                }
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Core/BasicIntervalSchedule")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the Value2Multiplier property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> Value2MultiplierChanging;
        
        /// <summary>
        /// Gets fired when the Value2Multiplier property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> Value2MultiplierChanged;
        
        /// <summary>
        /// Gets fired before the Value1Multiplier property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> Value1MultiplierChanging;
        
        /// <summary>
        /// Gets fired when the Value1Multiplier property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> Value1MultiplierChanged;
        
        /// <summary>
        /// Gets fired before the StartTime property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> StartTimeChanging;
        
        /// <summary>
        /// Gets fired when the StartTime property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> StartTimeChanged;
        
        /// <summary>
        /// Gets fired before the Value2Unit property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> Value2UnitChanging;
        
        /// <summary>
        /// Gets fired when the Value2Unit property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> Value2UnitChanged;
        
        /// <summary>
        /// Gets fired before the Value1Unit property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> Value1UnitChanging;
        
        /// <summary>
        /// Gets fired when the Value1Unit property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> Value1UnitChanged;
        
        private static ITypedElement RetrieveValue2MultiplierAttribute()
        {
            return ((ITypedElement)(((ModelElement)(BasicIntervalSchedule.ClassInstance)).Resolve("value2Multiplier")));
        }
        
        /// <summary>
        /// Raises the Value2MultiplierChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnValue2MultiplierChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.Value2MultiplierChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the Value2MultiplierChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnValue2MultiplierChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.Value2MultiplierChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveValue1MultiplierAttribute()
        {
            return ((ITypedElement)(((ModelElement)(BasicIntervalSchedule.ClassInstance)).Resolve("value1Multiplier")));
        }
        
        /// <summary>
        /// Raises the Value1MultiplierChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnValue1MultiplierChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.Value1MultiplierChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the Value1MultiplierChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnValue1MultiplierChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.Value1MultiplierChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveStartTimeAttribute()
        {
            return ((ITypedElement)(((ModelElement)(BasicIntervalSchedule.ClassInstance)).Resolve("startTime")));
        }
        
        /// <summary>
        /// Raises the StartTimeChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnStartTimeChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.StartTimeChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the StartTimeChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnStartTimeChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.StartTimeChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveValue2UnitAttribute()
        {
            return ((ITypedElement)(((ModelElement)(BasicIntervalSchedule.ClassInstance)).Resolve("value2Unit")));
        }
        
        /// <summary>
        /// Raises the Value2UnitChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnValue2UnitChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.Value2UnitChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the Value2UnitChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnValue2UnitChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.Value2UnitChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveValue1UnitAttribute()
        {
            return ((ITypedElement)(((ModelElement)(BasicIntervalSchedule.ClassInstance)).Resolve("value1Unit")));
        }
        
        /// <summary>
        /// Raises the Value1UnitChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnValue1UnitChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.Value1UnitChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the Value1UnitChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnValue1UnitChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.Value1UnitChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "VALUE2MULTIPLIER"))
            {
                return this.Value2Multiplier;
            }
            if ((attribute == "VALUE1MULTIPLIER"))
            {
                return this.Value1Multiplier;
            }
            if ((attribute == "STARTTIME"))
            {
                return this.StartTime;
            }
            if ((attribute == "VALUE2UNIT"))
            {
                return this.Value2Unit;
            }
            if ((attribute == "VALUE1UNIT"))
            {
                return this.Value1Unit;
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
            if ((feature == "VALUE2MULTIPLIER"))
            {
                this.Value2Multiplier = ((UnitMultiplier)(value));
                return;
            }
            if ((feature == "VALUE1MULTIPLIER"))
            {
                this.Value1Multiplier = ((UnitMultiplier)(value));
                return;
            }
            if ((feature == "STARTTIME"))
            {
                this.StartTime = ((string)(value));
                return;
            }
            if ((feature == "VALUE2UNIT"))
            {
                this.Value2Unit = ((UnitSymbol)(value));
                return;
            }
            if ((feature == "VALUE1UNIT"))
            {
                this.Value1Unit = ((UnitSymbol)(value));
                return;
            }
            base.SetFeature(feature, value);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override IClass GetClass()
        {
            if ((_classInstance == null))
            {
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Core/BasicIntervalSchedule")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the value2Multiplier property
        /// </summary>
        private sealed class Value2MultiplierProxy : ModelPropertyChange<IBasicIntervalSchedule, Nullable<UnitMultiplier>>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public Value2MultiplierProxy(IBasicIntervalSchedule modelElement) : 
                    base(modelElement, "value2Multiplier")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override Nullable<UnitMultiplier> Value
            {
                get
                {
                    return this.ModelElement.Value2Multiplier;
                }
                set
                {
                    this.ModelElement.Value2Multiplier = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the value1Multiplier property
        /// </summary>
        private sealed class Value1MultiplierProxy : ModelPropertyChange<IBasicIntervalSchedule, Nullable<UnitMultiplier>>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public Value1MultiplierProxy(IBasicIntervalSchedule modelElement) : 
                    base(modelElement, "value1Multiplier")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override Nullable<UnitMultiplier> Value
            {
                get
                {
                    return this.ModelElement.Value1Multiplier;
                }
                set
                {
                    this.ModelElement.Value1Multiplier = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the startTime property
        /// </summary>
        private sealed class StartTimeProxy : ModelPropertyChange<IBasicIntervalSchedule, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public StartTimeProxy(IBasicIntervalSchedule modelElement) : 
                    base(modelElement, "startTime")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override string Value
            {
                get
                {
                    return this.ModelElement.StartTime;
                }
                set
                {
                    this.ModelElement.StartTime = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the value2Unit property
        /// </summary>
        private sealed class Value2UnitProxy : ModelPropertyChange<IBasicIntervalSchedule, Nullable<UnitSymbol>>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public Value2UnitProxy(IBasicIntervalSchedule modelElement) : 
                    base(modelElement, "value2Unit")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override Nullable<UnitSymbol> Value
            {
                get
                {
                    return this.ModelElement.Value2Unit;
                }
                set
                {
                    this.ModelElement.Value2Unit = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the value1Unit property
        /// </summary>
        private sealed class Value1UnitProxy : ModelPropertyChange<IBasicIntervalSchedule, Nullable<UnitSymbol>>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public Value1UnitProxy(IBasicIntervalSchedule modelElement) : 
                    base(modelElement, "value1Unit")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override Nullable<UnitSymbol> Value
            {
                get
                {
                    return this.ModelElement.Value1Unit;
                }
                set
                {
                    this.ModelElement.Value1Unit = value;
                }
            }
        }
    }
}

