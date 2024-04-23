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

namespace TTC2017.SmartGrids.CIM.IEC61970.Equivalents
{
    
    
    /// <summary>
    /// The default implementation of the EquivalentInjection class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#Equivalents")]
    [XmlNamespacePrefixAttribute("cimEquivalents")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Equivalents/EquivalentInjecti" +
        "on")]
    [DebuggerDisplayAttribute("EquivalentInjection {UUID}")]
    public partial class EquivalentInjection : EquivalentEquipment, IEquivalentInjection, IModelElement
    {
        
        /// <summary>
        /// The backing field for the RegulationStatus property
        /// </summary>
        private bool _regulationStatus;
        
        private static Lazy<ITypedElement> _regulationStatusAttribute = new Lazy<ITypedElement>(RetrieveRegulationStatusAttribute);
        
        /// <summary>
        /// The backing field for the RegulationCapability property
        /// </summary>
        private bool _regulationCapability;
        
        private static Lazy<ITypedElement> _regulationCapabilityAttribute = new Lazy<ITypedElement>(RetrieveRegulationCapabilityAttribute);
        
        /// <summary>
        /// The backing field for the MinP property
        /// </summary>
        private float _minP;
        
        private static Lazy<ITypedElement> _minPAttribute = new Lazy<ITypedElement>(RetrieveMinPAttribute);
        
        /// <summary>
        /// The backing field for the MaxP property
        /// </summary>
        private float _maxP;
        
        private static Lazy<ITypedElement> _maxPAttribute = new Lazy<ITypedElement>(RetrieveMaxPAttribute);
        
        /// <summary>
        /// The backing field for the RegulationTarget property
        /// </summary>
        private float _regulationTarget;
        
        private static Lazy<ITypedElement> _regulationTargetAttribute = new Lazy<ITypedElement>(RetrieveRegulationTargetAttribute);
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The regulationStatus property
        /// </summary>
        [XmlElementNameAttribute("regulationStatus")]
        [XmlAttributeAttribute(true)]
        public virtual bool RegulationStatus
        {
            get
            {
                return this._regulationStatus;
            }
            set
            {
                if ((this._regulationStatus != value))
                {
                    bool old = this._regulationStatus;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnRegulationStatusChanging(e);
                    this.OnPropertyChanging("RegulationStatus", e, _regulationStatusAttribute);
                    this._regulationStatus = value;
                    this.OnRegulationStatusChanged(e);
                    this.OnPropertyChanged("RegulationStatus", e, _regulationStatusAttribute);
                }
            }
        }
        
        /// <summary>
        /// The regulationCapability property
        /// </summary>
        [XmlElementNameAttribute("regulationCapability")]
        [XmlAttributeAttribute(true)]
        public virtual bool RegulationCapability
        {
            get
            {
                return this._regulationCapability;
            }
            set
            {
                if ((this._regulationCapability != value))
                {
                    bool old = this._regulationCapability;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnRegulationCapabilityChanging(e);
                    this.OnPropertyChanging("RegulationCapability", e, _regulationCapabilityAttribute);
                    this._regulationCapability = value;
                    this.OnRegulationCapabilityChanged(e);
                    this.OnPropertyChanged("RegulationCapability", e, _regulationCapabilityAttribute);
                }
            }
        }
        
        /// <summary>
        /// The minP property
        /// </summary>
        [XmlElementNameAttribute("minP")]
        [XmlAttributeAttribute(true)]
        public virtual float MinP
        {
            get
            {
                return this._minP;
            }
            set
            {
                if ((this._minP != value))
                {
                    float old = this._minP;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnMinPChanging(e);
                    this.OnPropertyChanging("MinP", e, _minPAttribute);
                    this._minP = value;
                    this.OnMinPChanged(e);
                    this.OnPropertyChanged("MinP", e, _minPAttribute);
                }
            }
        }
        
        /// <summary>
        /// The maxP property
        /// </summary>
        [XmlElementNameAttribute("maxP")]
        [XmlAttributeAttribute(true)]
        public virtual float MaxP
        {
            get
            {
                return this._maxP;
            }
            set
            {
                if ((this._maxP != value))
                {
                    float old = this._maxP;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnMaxPChanging(e);
                    this.OnPropertyChanging("MaxP", e, _maxPAttribute);
                    this._maxP = value;
                    this.OnMaxPChanged(e);
                    this.OnPropertyChanged("MaxP", e, _maxPAttribute);
                }
            }
        }
        
        /// <summary>
        /// The regulationTarget property
        /// </summary>
        [XmlElementNameAttribute("regulationTarget")]
        [XmlAttributeAttribute(true)]
        public virtual float RegulationTarget
        {
            get
            {
                return this._regulationTarget;
            }
            set
            {
                if ((this._regulationTarget != value))
                {
                    float old = this._regulationTarget;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnRegulationTargetChanging(e);
                    this.OnPropertyChanging("RegulationTarget", e, _regulationTargetAttribute);
                    this._regulationTarget = value;
                    this.OnRegulationTargetChanged(e);
                    this.OnPropertyChanged("RegulationTarget", e, _regulationTargetAttribute);
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Equivalents/EquivalentInjecti" +
                            "on")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the RegulationStatus property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> RegulationStatusChanging;
        
        /// <summary>
        /// Gets fired when the RegulationStatus property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> RegulationStatusChanged;
        
        /// <summary>
        /// Gets fired before the RegulationCapability property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> RegulationCapabilityChanging;
        
        /// <summary>
        /// Gets fired when the RegulationCapability property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> RegulationCapabilityChanged;
        
        /// <summary>
        /// Gets fired before the MinP property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> MinPChanging;
        
        /// <summary>
        /// Gets fired when the MinP property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> MinPChanged;
        
        /// <summary>
        /// Gets fired before the MaxP property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> MaxPChanging;
        
        /// <summary>
        /// Gets fired when the MaxP property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> MaxPChanged;
        
        /// <summary>
        /// Gets fired before the RegulationTarget property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> RegulationTargetChanging;
        
        /// <summary>
        /// Gets fired when the RegulationTarget property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> RegulationTargetChanged;
        
        private static ITypedElement RetrieveRegulationStatusAttribute()
        {
            return ((ITypedElement)(((ModelElement)(EquivalentInjection.ClassInstance)).Resolve("regulationStatus")));
        }
        
        /// <summary>
        /// Raises the RegulationStatusChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnRegulationStatusChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.RegulationStatusChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the RegulationStatusChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnRegulationStatusChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.RegulationStatusChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveRegulationCapabilityAttribute()
        {
            return ((ITypedElement)(((ModelElement)(EquivalentInjection.ClassInstance)).Resolve("regulationCapability")));
        }
        
        /// <summary>
        /// Raises the RegulationCapabilityChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnRegulationCapabilityChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.RegulationCapabilityChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the RegulationCapabilityChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnRegulationCapabilityChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.RegulationCapabilityChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveMinPAttribute()
        {
            return ((ITypedElement)(((ModelElement)(EquivalentInjection.ClassInstance)).Resolve("minP")));
        }
        
        /// <summary>
        /// Raises the MinPChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnMinPChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.MinPChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the MinPChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnMinPChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.MinPChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveMaxPAttribute()
        {
            return ((ITypedElement)(((ModelElement)(EquivalentInjection.ClassInstance)).Resolve("maxP")));
        }
        
        /// <summary>
        /// Raises the MaxPChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnMaxPChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.MaxPChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the MaxPChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnMaxPChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.MaxPChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveRegulationTargetAttribute()
        {
            return ((ITypedElement)(((ModelElement)(EquivalentInjection.ClassInstance)).Resolve("regulationTarget")));
        }
        
        /// <summary>
        /// Raises the RegulationTargetChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnRegulationTargetChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.RegulationTargetChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the RegulationTargetChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnRegulationTargetChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.RegulationTargetChanged;
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
            if ((attribute == "REGULATIONSTATUS"))
            {
                return this.RegulationStatus;
            }
            if ((attribute == "REGULATIONCAPABILITY"))
            {
                return this.RegulationCapability;
            }
            if ((attribute == "MINP"))
            {
                return this.MinP;
            }
            if ((attribute == "MAXP"))
            {
                return this.MaxP;
            }
            if ((attribute == "REGULATIONTARGET"))
            {
                return this.RegulationTarget;
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
            if ((feature == "REGULATIONSTATUS"))
            {
                this.RegulationStatus = ((bool)(value));
                return;
            }
            if ((feature == "REGULATIONCAPABILITY"))
            {
                this.RegulationCapability = ((bool)(value));
                return;
            }
            if ((feature == "MINP"))
            {
                this.MinP = ((float)(value));
                return;
            }
            if ((feature == "MAXP"))
            {
                this.MaxP = ((float)(value));
                return;
            }
            if ((feature == "REGULATIONTARGET"))
            {
                this.RegulationTarget = ((float)(value));
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Equivalents/EquivalentInjecti" +
                        "on")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the regulationStatus property
        /// </summary>
        private sealed class RegulationStatusProxy : ModelPropertyChange<IEquivalentInjection, bool>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public RegulationStatusProxy(IEquivalentInjection modelElement) : 
                    base(modelElement, "regulationStatus")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override bool Value
            {
                get
                {
                    return this.ModelElement.RegulationStatus;
                }
                set
                {
                    this.ModelElement.RegulationStatus = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the regulationCapability property
        /// </summary>
        private sealed class RegulationCapabilityProxy : ModelPropertyChange<IEquivalentInjection, bool>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public RegulationCapabilityProxy(IEquivalentInjection modelElement) : 
                    base(modelElement, "regulationCapability")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override bool Value
            {
                get
                {
                    return this.ModelElement.RegulationCapability;
                }
                set
                {
                    this.ModelElement.RegulationCapability = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the minP property
        /// </summary>
        private sealed class MinPProxy : ModelPropertyChange<IEquivalentInjection, float>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public MinPProxy(IEquivalentInjection modelElement) : 
                    base(modelElement, "minP")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override float Value
            {
                get
                {
                    return this.ModelElement.MinP;
                }
                set
                {
                    this.ModelElement.MinP = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the maxP property
        /// </summary>
        private sealed class MaxPProxy : ModelPropertyChange<IEquivalentInjection, float>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public MaxPProxy(IEquivalentInjection modelElement) : 
                    base(modelElement, "maxP")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override float Value
            {
                get
                {
                    return this.ModelElement.MaxP;
                }
                set
                {
                    this.ModelElement.MaxP = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the regulationTarget property
        /// </summary>
        private sealed class RegulationTargetProxy : ModelPropertyChange<IEquivalentInjection, float>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public RegulationTargetProxy(IEquivalentInjection modelElement) : 
                    base(modelElement, "regulationTarget")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override float Value
            {
                get
                {
                    return this.ModelElement.RegulationTarget;
                }
                set
                {
                    this.ModelElement.RegulationTarget = value;
                }
            }
        }
    }
}

