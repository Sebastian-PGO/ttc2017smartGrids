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
using TTC2017.SmartGrids.CIM.IEC61970.Core;

namespace TTC2017.SmartGrids.CIM.IEC61970.OperationalLimits
{
    
    
    /// <summary>
    /// The default implementation of the ActivePowerLimit class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#OperationalLimits")]
    [XmlNamespacePrefixAttribute("cimOperationalLimits")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/OperationalLimits/ActivePower" +
        "Limit")]
    [DebuggerDisplayAttribute("ActivePowerLimit {UUID}")]
    public partial class ActivePowerLimit : OperationalLimit, IActivePowerLimit, IModelElement
    {
        
        /// <summary>
        /// The backing field for the Value property
        /// </summary>
        private float _value;
        
        private static Lazy<ITypedElement> _valueAttribute = new Lazy<ITypedElement>(RetrieveValueAttribute);
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The value property
        /// </summary>
        [XmlElementNameAttribute("value")]
        [XmlAttributeAttribute(true)]
        public virtual float Value
        {
            get
            {
                return this._value;
            }
            set
            {
                if ((this._value != value))
                {
                    float old = this._value;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnValueChanging(e);
                    this.OnPropertyChanging("Value", e, _valueAttribute);
                    this._value = value;
                    this.OnValueChanged(e);
                    this.OnPropertyChanged("Value", e, _valueAttribute);
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/OperationalLimits/ActivePower" +
                            "Limit")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the Value property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ValueChanging;
        
        /// <summary>
        /// Gets fired when the Value property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ValueChanged;
        
        private static ITypedElement RetrieveValueAttribute()
        {
            return ((ITypedElement)(((ModelElement)(ActivePowerLimit.ClassInstance)).Resolve("value")));
        }
        
        /// <summary>
        /// Raises the ValueChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnValueChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ValueChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the ValueChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnValueChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ValueChanged;
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
            if ((attribute == "VALUE"))
            {
                return this.Value;
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
            if ((feature == "VALUE"))
            {
                this.Value = ((float)(value));
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/OperationalLimits/ActivePower" +
                        "Limit")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the value property
        /// </summary>
        private sealed class ValueProxy : ModelPropertyChange<IActivePowerLimit, float>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public ValueProxy(IActivePowerLimit modelElement) : 
                    base(modelElement, "value")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override float Value
            {
                get
                {
                    return this.ModelElement.Value;
                }
                set
                {
                    this.ModelElement.Value = value;
                }
            }
        }
    }
}

