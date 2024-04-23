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
    /// The default implementation of the AccessPermit class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#InfWork")]
    [XmlNamespacePrefixAttribute("cimInfWork")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfWork/AccessPer" +
        "mit")]
    [DebuggerDisplayAttribute("AccessPermit {UUID}")]
    public partial class AccessPermit : Document, IAccessPermit, IModelElement
    {
        
        /// <summary>
        /// The backing field for the ExpirationDate property
        /// </summary>
        private string _expirationDate;
        
        private static Lazy<ITypedElement> _expirationDateAttribute = new Lazy<ITypedElement>(RetrieveExpirationDateAttribute);
        
        /// <summary>
        /// The backing field for the ApplicationNumber property
        /// </summary>
        private string _applicationNumber;
        
        private static Lazy<ITypedElement> _applicationNumberAttribute = new Lazy<ITypedElement>(RetrieveApplicationNumberAttribute);
        
        /// <summary>
        /// The backing field for the EffectiveDate property
        /// </summary>
        private string _effectiveDate;
        
        private static Lazy<ITypedElement> _effectiveDateAttribute = new Lazy<ITypedElement>(RetrieveEffectiveDateAttribute);
        
        /// <summary>
        /// The backing field for the PermitID property
        /// </summary>
        private string _permitID;
        
        private static Lazy<ITypedElement> _permitIDAttribute = new Lazy<ITypedElement>(RetrievePermitIDAttribute);
        
        /// <summary>
        /// The backing field for the Payment property
        /// </summary>
        private float _payment;
        
        private static Lazy<ITypedElement> _paymentAttribute = new Lazy<ITypedElement>(RetrievePaymentAttribute);
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The expirationDate property
        /// </summary>
        [XmlElementNameAttribute("expirationDate")]
        [XmlAttributeAttribute(true)]
        public virtual string ExpirationDate
        {
            get
            {
                return this._expirationDate;
            }
            set
            {
                if ((this._expirationDate != value))
                {
                    string old = this._expirationDate;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnExpirationDateChanging(e);
                    this.OnPropertyChanging("ExpirationDate", e, _expirationDateAttribute);
                    this._expirationDate = value;
                    this.OnExpirationDateChanged(e);
                    this.OnPropertyChanged("ExpirationDate", e, _expirationDateAttribute);
                }
            }
        }
        
        /// <summary>
        /// The applicationNumber property
        /// </summary>
        [XmlElementNameAttribute("applicationNumber")]
        [XmlAttributeAttribute(true)]
        public virtual string ApplicationNumber
        {
            get
            {
                return this._applicationNumber;
            }
            set
            {
                if ((this._applicationNumber != value))
                {
                    string old = this._applicationNumber;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnApplicationNumberChanging(e);
                    this.OnPropertyChanging("ApplicationNumber", e, _applicationNumberAttribute);
                    this._applicationNumber = value;
                    this.OnApplicationNumberChanged(e);
                    this.OnPropertyChanged("ApplicationNumber", e, _applicationNumberAttribute);
                }
            }
        }
        
        /// <summary>
        /// The effectiveDate property
        /// </summary>
        [XmlElementNameAttribute("effectiveDate")]
        [XmlAttributeAttribute(true)]
        public virtual string EffectiveDate
        {
            get
            {
                return this._effectiveDate;
            }
            set
            {
                if ((this._effectiveDate != value))
                {
                    string old = this._effectiveDate;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnEffectiveDateChanging(e);
                    this.OnPropertyChanging("EffectiveDate", e, _effectiveDateAttribute);
                    this._effectiveDate = value;
                    this.OnEffectiveDateChanged(e);
                    this.OnPropertyChanged("EffectiveDate", e, _effectiveDateAttribute);
                }
            }
        }
        
        /// <summary>
        /// The permitID property
        /// </summary>
        [XmlElementNameAttribute("permitID")]
        [XmlAttributeAttribute(true)]
        public virtual string PermitID
        {
            get
            {
                return this._permitID;
            }
            set
            {
                if ((this._permitID != value))
                {
                    string old = this._permitID;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnPermitIDChanging(e);
                    this.OnPropertyChanging("PermitID", e, _permitIDAttribute);
                    this._permitID = value;
                    this.OnPermitIDChanged(e);
                    this.OnPropertyChanged("PermitID", e, _permitIDAttribute);
                }
            }
        }
        
        /// <summary>
        /// The payment property
        /// </summary>
        [XmlElementNameAttribute("payment")]
        [XmlAttributeAttribute(true)]
        public virtual float Payment
        {
            get
            {
                return this._payment;
            }
            set
            {
                if ((this._payment != value))
                {
                    float old = this._payment;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnPaymentChanging(e);
                    this.OnPropertyChanging("Payment", e, _paymentAttribute);
                    this._payment = value;
                    this.OnPaymentChanged(e);
                    this.OnPropertyChanged("Payment", e, _paymentAttribute);
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfWork/AccessPer" +
                            "mit")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the ExpirationDate property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ExpirationDateChanging;
        
        /// <summary>
        /// Gets fired when the ExpirationDate property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ExpirationDateChanged;
        
        /// <summary>
        /// Gets fired before the ApplicationNumber property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ApplicationNumberChanging;
        
        /// <summary>
        /// Gets fired when the ApplicationNumber property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ApplicationNumberChanged;
        
        /// <summary>
        /// Gets fired before the EffectiveDate property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> EffectiveDateChanging;
        
        /// <summary>
        /// Gets fired when the EffectiveDate property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> EffectiveDateChanged;
        
        /// <summary>
        /// Gets fired before the PermitID property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> PermitIDChanging;
        
        /// <summary>
        /// Gets fired when the PermitID property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> PermitIDChanged;
        
        /// <summary>
        /// Gets fired before the Payment property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> PaymentChanging;
        
        /// <summary>
        /// Gets fired when the Payment property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> PaymentChanged;
        
        private static ITypedElement RetrieveExpirationDateAttribute()
        {
            return ((ITypedElement)(((ModelElement)(AccessPermit.ClassInstance)).Resolve("expirationDate")));
        }
        
        /// <summary>
        /// Raises the ExpirationDateChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnExpirationDateChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ExpirationDateChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the ExpirationDateChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnExpirationDateChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ExpirationDateChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveApplicationNumberAttribute()
        {
            return ((ITypedElement)(((ModelElement)(AccessPermit.ClassInstance)).Resolve("applicationNumber")));
        }
        
        /// <summary>
        /// Raises the ApplicationNumberChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnApplicationNumberChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ApplicationNumberChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the ApplicationNumberChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnApplicationNumberChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ApplicationNumberChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveEffectiveDateAttribute()
        {
            return ((ITypedElement)(((ModelElement)(AccessPermit.ClassInstance)).Resolve("effectiveDate")));
        }
        
        /// <summary>
        /// Raises the EffectiveDateChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnEffectiveDateChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.EffectiveDateChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the EffectiveDateChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnEffectiveDateChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.EffectiveDateChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrievePermitIDAttribute()
        {
            return ((ITypedElement)(((ModelElement)(AccessPermit.ClassInstance)).Resolve("permitID")));
        }
        
        /// <summary>
        /// Raises the PermitIDChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnPermitIDChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.PermitIDChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the PermitIDChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnPermitIDChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.PermitIDChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrievePaymentAttribute()
        {
            return ((ITypedElement)(((ModelElement)(AccessPermit.ClassInstance)).Resolve("payment")));
        }
        
        /// <summary>
        /// Raises the PaymentChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnPaymentChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.PaymentChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the PaymentChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnPaymentChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.PaymentChanged;
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
            if ((attribute == "EXPIRATIONDATE"))
            {
                return this.ExpirationDate;
            }
            if ((attribute == "APPLICATIONNUMBER"))
            {
                return this.ApplicationNumber;
            }
            if ((attribute == "EFFECTIVEDATE"))
            {
                return this.EffectiveDate;
            }
            if ((attribute == "PERMITID"))
            {
                return this.PermitID;
            }
            if ((attribute == "PAYMENT"))
            {
                return this.Payment;
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
            if ((feature == "EXPIRATIONDATE"))
            {
                this.ExpirationDate = ((string)(value));
                return;
            }
            if ((feature == "APPLICATIONNUMBER"))
            {
                this.ApplicationNumber = ((string)(value));
                return;
            }
            if ((feature == "EFFECTIVEDATE"))
            {
                this.EffectiveDate = ((string)(value));
                return;
            }
            if ((feature == "PERMITID"))
            {
                this.PermitID = ((string)(value));
                return;
            }
            if ((feature == "PAYMENT"))
            {
                this.Payment = ((float)(value));
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfWork/AccessPer" +
                        "mit")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the expirationDate property
        /// </summary>
        private sealed class ExpirationDateProxy : ModelPropertyChange<IAccessPermit, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public ExpirationDateProxy(IAccessPermit modelElement) : 
                    base(modelElement, "expirationDate")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override string Value
            {
                get
                {
                    return this.ModelElement.ExpirationDate;
                }
                set
                {
                    this.ModelElement.ExpirationDate = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the applicationNumber property
        /// </summary>
        private sealed class ApplicationNumberProxy : ModelPropertyChange<IAccessPermit, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public ApplicationNumberProxy(IAccessPermit modelElement) : 
                    base(modelElement, "applicationNumber")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override string Value
            {
                get
                {
                    return this.ModelElement.ApplicationNumber;
                }
                set
                {
                    this.ModelElement.ApplicationNumber = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the effectiveDate property
        /// </summary>
        private sealed class EffectiveDateProxy : ModelPropertyChange<IAccessPermit, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public EffectiveDateProxy(IAccessPermit modelElement) : 
                    base(modelElement, "effectiveDate")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override string Value
            {
                get
                {
                    return this.ModelElement.EffectiveDate;
                }
                set
                {
                    this.ModelElement.EffectiveDate = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the permitID property
        /// </summary>
        private sealed class PermitIDProxy : ModelPropertyChange<IAccessPermit, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public PermitIDProxy(IAccessPermit modelElement) : 
                    base(modelElement, "permitID")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override string Value
            {
                get
                {
                    return this.ModelElement.PermitID;
                }
                set
                {
                    this.ModelElement.PermitID = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the payment property
        /// </summary>
        private sealed class PaymentProxy : ModelPropertyChange<IAccessPermit, float>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public PaymentProxy(IAccessPermit modelElement) : 
                    base(modelElement, "payment")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override float Value
            {
                get
                {
                    return this.ModelElement.Payment;
                }
                set
                {
                    this.ModelElement.Payment = value;
                }
            }
        }
    }
}

