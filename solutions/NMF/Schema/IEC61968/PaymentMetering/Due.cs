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
using TTC2017.SmartGrids.CIM.IEC61968.Common;
using TTC2017.SmartGrids.CIM.IEC61968.Customers;
using TTC2017.SmartGrids.CIM.IEC61968.Metering;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Domain;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfCommon;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfPaymentMetering;

namespace TTC2017.SmartGrids.CIM.IEC61968.PaymentMetering
{
    
    
    /// <summary>
    /// The default implementation of the Due class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#PaymentMetering")]
    [XmlNamespacePrefixAttribute("cimPaymentMetering")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61968/PaymentMetering/Due")]
    [DebuggerDisplayAttribute("Due {UUID}")]
    public partial class Due : Element, IDue, IModelElement
    {
        
        /// <summary>
        /// The backing field for the Interest property
        /// </summary>
        private float _interest;
        
        private static Lazy<ITypedElement> _interestAttribute = new Lazy<ITypedElement>(RetrieveInterestAttribute);
        
        /// <summary>
        /// The backing field for the Principle property
        /// </summary>
        private float _principle;
        
        private static Lazy<ITypedElement> _principleAttribute = new Lazy<ITypedElement>(RetrievePrincipleAttribute);
        
        /// <summary>
        /// The backing field for the Current property
        /// </summary>
        private float _current;
        
        private static Lazy<ITypedElement> _currentAttribute = new Lazy<ITypedElement>(RetrieveCurrentAttribute);
        
        /// <summary>
        /// The backing field for the Arrears property
        /// </summary>
        private float _arrears;
        
        private static Lazy<ITypedElement> _arrearsAttribute = new Lazy<ITypedElement>(RetrieveArrearsAttribute);
        
        /// <summary>
        /// The backing field for the Charges property
        /// </summary>
        private float _charges;
        
        private static Lazy<ITypedElement> _chargesAttribute = new Lazy<ITypedElement>(RetrieveChargesAttribute);
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The interest property
        /// </summary>
        [XmlElementNameAttribute("interest")]
        [XmlAttributeAttribute(true)]
        public virtual float Interest
        {
            get
            {
                return this._interest;
            }
            set
            {
                if ((this._interest != value))
                {
                    float old = this._interest;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnInterestChanging(e);
                    this.OnPropertyChanging("Interest", e, _interestAttribute);
                    this._interest = value;
                    this.OnInterestChanged(e);
                    this.OnPropertyChanged("Interest", e, _interestAttribute);
                }
            }
        }
        
        /// <summary>
        /// The principle property
        /// </summary>
        [XmlElementNameAttribute("principle")]
        [XmlAttributeAttribute(true)]
        public virtual float Principle
        {
            get
            {
                return this._principle;
            }
            set
            {
                if ((this._principle != value))
                {
                    float old = this._principle;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnPrincipleChanging(e);
                    this.OnPropertyChanging("Principle", e, _principleAttribute);
                    this._principle = value;
                    this.OnPrincipleChanged(e);
                    this.OnPropertyChanged("Principle", e, _principleAttribute);
                }
            }
        }
        
        /// <summary>
        /// The current property
        /// </summary>
        [XmlElementNameAttribute("current")]
        [XmlAttributeAttribute(true)]
        public virtual float Current
        {
            get
            {
                return this._current;
            }
            set
            {
                if ((this._current != value))
                {
                    float old = this._current;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnCurrentChanging(e);
                    this.OnPropertyChanging("Current", e, _currentAttribute);
                    this._current = value;
                    this.OnCurrentChanged(e);
                    this.OnPropertyChanged("Current", e, _currentAttribute);
                }
            }
        }
        
        /// <summary>
        /// The arrears property
        /// </summary>
        [XmlElementNameAttribute("arrears")]
        [XmlAttributeAttribute(true)]
        public virtual float Arrears
        {
            get
            {
                return this._arrears;
            }
            set
            {
                if ((this._arrears != value))
                {
                    float old = this._arrears;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnArrearsChanging(e);
                    this.OnPropertyChanging("Arrears", e, _arrearsAttribute);
                    this._arrears = value;
                    this.OnArrearsChanged(e);
                    this.OnPropertyChanged("Arrears", e, _arrearsAttribute);
                }
            }
        }
        
        /// <summary>
        /// The charges property
        /// </summary>
        [XmlElementNameAttribute("charges")]
        [XmlAttributeAttribute(true)]
        public virtual float Charges
        {
            get
            {
                return this._charges;
            }
            set
            {
                if ((this._charges != value))
                {
                    float old = this._charges;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnChargesChanging(e);
                    this.OnPropertyChanging("Charges", e, _chargesAttribute);
                    this._charges = value;
                    this.OnChargesChanged(e);
                    this.OnPropertyChanged("Charges", e, _chargesAttribute);
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61968/PaymentMetering/Due")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the Interest property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> InterestChanging;
        
        /// <summary>
        /// Gets fired when the Interest property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> InterestChanged;
        
        /// <summary>
        /// Gets fired before the Principle property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> PrincipleChanging;
        
        /// <summary>
        /// Gets fired when the Principle property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> PrincipleChanged;
        
        /// <summary>
        /// Gets fired before the Current property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> CurrentChanging;
        
        /// <summary>
        /// Gets fired when the Current property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> CurrentChanged;
        
        /// <summary>
        /// Gets fired before the Arrears property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ArrearsChanging;
        
        /// <summary>
        /// Gets fired when the Arrears property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ArrearsChanged;
        
        /// <summary>
        /// Gets fired before the Charges property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ChargesChanging;
        
        /// <summary>
        /// Gets fired when the Charges property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ChargesChanged;
        
        private static ITypedElement RetrieveInterestAttribute()
        {
            return ((ITypedElement)(((ModelElement)(Due.ClassInstance)).Resolve("interest")));
        }
        
        /// <summary>
        /// Raises the InterestChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnInterestChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.InterestChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the InterestChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnInterestChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.InterestChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrievePrincipleAttribute()
        {
            return ((ITypedElement)(((ModelElement)(Due.ClassInstance)).Resolve("principle")));
        }
        
        /// <summary>
        /// Raises the PrincipleChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnPrincipleChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.PrincipleChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the PrincipleChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnPrincipleChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.PrincipleChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveCurrentAttribute()
        {
            return ((ITypedElement)(((ModelElement)(Due.ClassInstance)).Resolve("current")));
        }
        
        /// <summary>
        /// Raises the CurrentChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnCurrentChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.CurrentChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the CurrentChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnCurrentChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.CurrentChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveArrearsAttribute()
        {
            return ((ITypedElement)(((ModelElement)(Due.ClassInstance)).Resolve("arrears")));
        }
        
        /// <summary>
        /// Raises the ArrearsChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnArrearsChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ArrearsChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the ArrearsChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnArrearsChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ArrearsChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveChargesAttribute()
        {
            return ((ITypedElement)(((ModelElement)(Due.ClassInstance)).Resolve("charges")));
        }
        
        /// <summary>
        /// Raises the ChargesChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnChargesChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ChargesChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the ChargesChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnChargesChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ChargesChanged;
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
            if ((attribute == "INTEREST"))
            {
                return this.Interest;
            }
            if ((attribute == "PRINCIPLE"))
            {
                return this.Principle;
            }
            if ((attribute == "CURRENT"))
            {
                return this.Current;
            }
            if ((attribute == "ARREARS"))
            {
                return this.Arrears;
            }
            if ((attribute == "CHARGES"))
            {
                return this.Charges;
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
            if ((feature == "INTEREST"))
            {
                this.Interest = ((float)(value));
                return;
            }
            if ((feature == "PRINCIPLE"))
            {
                this.Principle = ((float)(value));
                return;
            }
            if ((feature == "CURRENT"))
            {
                this.Current = ((float)(value));
                return;
            }
            if ((feature == "ARREARS"))
            {
                this.Arrears = ((float)(value));
                return;
            }
            if ((feature == "CHARGES"))
            {
                this.Charges = ((float)(value));
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61968/PaymentMetering/Due")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the interest property
        /// </summary>
        private sealed class InterestProxy : ModelPropertyChange<IDue, float>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public InterestProxy(IDue modelElement) : 
                    base(modelElement, "interest")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override float Value
            {
                get
                {
                    return this.ModelElement.Interest;
                }
                set
                {
                    this.ModelElement.Interest = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the principle property
        /// </summary>
        private sealed class PrincipleProxy : ModelPropertyChange<IDue, float>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public PrincipleProxy(IDue modelElement) : 
                    base(modelElement, "principle")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override float Value
            {
                get
                {
                    return this.ModelElement.Principle;
                }
                set
                {
                    this.ModelElement.Principle = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the current property
        /// </summary>
        private sealed class CurrentProxy : ModelPropertyChange<IDue, float>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public CurrentProxy(IDue modelElement) : 
                    base(modelElement, "current")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override float Value
            {
                get
                {
                    return this.ModelElement.Current;
                }
                set
                {
                    this.ModelElement.Current = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the arrears property
        /// </summary>
        private sealed class ArrearsProxy : ModelPropertyChange<IDue, float>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public ArrearsProxy(IDue modelElement) : 
                    base(modelElement, "arrears")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override float Value
            {
                get
                {
                    return this.ModelElement.Arrears;
                }
                set
                {
                    this.ModelElement.Arrears = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the charges property
        /// </summary>
        private sealed class ChargesProxy : ModelPropertyChange<IDue, float>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public ChargesProxy(IDue modelElement) : 
                    base(modelElement, "charges")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override float Value
            {
                get
                {
                    return this.ModelElement.Charges;
                }
                set
                {
                    this.ModelElement.Charges = value;
                }
            }
        }
    }
}

