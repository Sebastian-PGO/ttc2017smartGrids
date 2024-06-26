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
using TTC2017.SmartGrids.CIM.IEC61968.LoadControl;
using TTC2017.SmartGrids.CIM.IEC61968.Metering;
using TTC2017.SmartGrids.CIM.IEC61968.WiresExt;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Generation.GenerationDynamics;
using TTC2017.SmartGrids.CIM.IEC61970.Generation.Production;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.EnergyScheduling;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssets;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfLoadControl;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.MarketOperations;
using TTC2017.SmartGrids.CIM.IEC61970.LoadModel;
using TTC2017.SmartGrids.CIM.IEC61970.Meas;
using TTC2017.SmartGrids.CIM.IEC61970.Outage;
using TTC2017.SmartGrids.CIM.IEC61970.Protection;
using TTC2017.SmartGrids.CIM.IEC61970.StateVariables;

namespace TTC2017.SmartGrids.CIM.IEC61970.Wires
{
    
    
    /// <summary>
    /// The default implementation of the Breaker class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#Wires")]
    [XmlNamespacePrefixAttribute("cimWires")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Wires/Breaker")]
    [DebuggerDisplayAttribute("Breaker {UUID}")]
    public partial class Breaker : ProtectedSwitch, IBreaker, IModelElement
    {
        
        /// <summary>
        /// The backing field for the RatedCurrent property
        /// </summary>
        private float _ratedCurrent;
        
        private static Lazy<ITypedElement> _ratedCurrentAttribute = new Lazy<ITypedElement>(RetrieveRatedCurrentAttribute);
        
        /// <summary>
        /// The backing field for the InTransitTime property
        /// </summary>
        private float _inTransitTime;
        
        private static Lazy<ITypedElement> _inTransitTimeAttribute = new Lazy<ITypedElement>(RetrieveInTransitTimeAttribute);
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The ratedCurrent property
        /// </summary>
        [XmlElementNameAttribute("ratedCurrent")]
        [XmlAttributeAttribute(true)]
        public virtual float RatedCurrent
        {
            get
            {
                return this._ratedCurrent;
            }
            set
            {
                if ((this._ratedCurrent != value))
                {
                    float old = this._ratedCurrent;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnRatedCurrentChanging(e);
                    this.OnPropertyChanging("RatedCurrent", e, _ratedCurrentAttribute);
                    this._ratedCurrent = value;
                    this.OnRatedCurrentChanged(e);
                    this.OnPropertyChanged("RatedCurrent", e, _ratedCurrentAttribute);
                }
            }
        }
        
        /// <summary>
        /// The inTransitTime property
        /// </summary>
        [XmlElementNameAttribute("inTransitTime")]
        [XmlAttributeAttribute(true)]
        public virtual float InTransitTime
        {
            get
            {
                return this._inTransitTime;
            }
            set
            {
                if ((this._inTransitTime != value))
                {
                    float old = this._inTransitTime;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnInTransitTimeChanging(e);
                    this.OnPropertyChanging("InTransitTime", e, _inTransitTimeAttribute);
                    this._inTransitTime = value;
                    this.OnInTransitTimeChanged(e);
                    this.OnPropertyChanged("InTransitTime", e, _inTransitTimeAttribute);
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Wires/Breaker")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the RatedCurrent property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> RatedCurrentChanging;
        
        /// <summary>
        /// Gets fired when the RatedCurrent property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> RatedCurrentChanged;
        
        /// <summary>
        /// Gets fired before the InTransitTime property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> InTransitTimeChanging;
        
        /// <summary>
        /// Gets fired when the InTransitTime property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> InTransitTimeChanged;
        
        private static ITypedElement RetrieveRatedCurrentAttribute()
        {
            return ((ITypedElement)(((ModelElement)(Breaker.ClassInstance)).Resolve("ratedCurrent")));
        }
        
        /// <summary>
        /// Raises the RatedCurrentChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnRatedCurrentChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.RatedCurrentChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the RatedCurrentChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnRatedCurrentChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.RatedCurrentChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveInTransitTimeAttribute()
        {
            return ((ITypedElement)(((ModelElement)(Breaker.ClassInstance)).Resolve("inTransitTime")));
        }
        
        /// <summary>
        /// Raises the InTransitTimeChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnInTransitTimeChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.InTransitTimeChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the InTransitTimeChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnInTransitTimeChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.InTransitTimeChanged;
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
            if ((attribute == "RATEDCURRENT"))
            {
                return this.RatedCurrent;
            }
            if ((attribute == "INTRANSITTIME"))
            {
                return this.InTransitTime;
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
            if ((feature == "RATEDCURRENT"))
            {
                this.RatedCurrent = ((float)(value));
                return;
            }
            if ((feature == "INTRANSITTIME"))
            {
                this.InTransitTime = ((float)(value));
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Wires/Breaker")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the ratedCurrent property
        /// </summary>
        private sealed class RatedCurrentProxy : ModelPropertyChange<IBreaker, float>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public RatedCurrentProxy(IBreaker modelElement) : 
                    base(modelElement, "ratedCurrent")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override float Value
            {
                get
                {
                    return this.ModelElement.RatedCurrent;
                }
                set
                {
                    this.ModelElement.RatedCurrent = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the inTransitTime property
        /// </summary>
        private sealed class InTransitTimeProxy : ModelPropertyChange<IBreaker, float>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public InTransitTimeProxy(IBreaker modelElement) : 
                    base(modelElement, "inTransitTime")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override float Value
            {
                get
                {
                    return this.ModelElement.InTransitTime;
                }
                set
                {
                    this.ModelElement.InTransitTime = value;
                }
            }
        }
    }
}

