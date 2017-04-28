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
using TTC2017.SmartGrids.CIM.IEC61968.AssetModels;
using TTC2017.SmartGrids.CIM.IEC61968.Assets;
using TTC2017.SmartGrids.CIM.IEC61968.Common;
using TTC2017.SmartGrids.CIM.IEC61968.Metering;
using TTC2017.SmartGrids.CIM.IEC61968.WiresExt;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssetModels;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfCommon;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfERPSupport;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfOperations;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfTypeAsset;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfWork;
using TTC2017.SmartGrids.CIM.IEC61970.Meas;
using TTC2017.SmartGrids.CIM.IEC61970.Wires;

namespace TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssets
{
    
    
    /// <summary>
    /// The default implementation of the FailureEvent class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#InfAssets")]
    [XmlNamespacePrefixAttribute("cimInfAssets")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfAssets/Failure" +
        "Event")]
    [DebuggerDisplayAttribute("FailureEvent {UUID}")]
    public partial class FailureEvent : ActivityRecord, IFailureEvent, IModelElement
    {
        
        /// <summary>
        /// The backing field for the FailureIsolationMethod property
        /// </summary>
        private Nullable<FailureIsolationMethodKind> _failureIsolationMethod;
        
        private static Lazy<ITypedElement> _failureIsolationMethodAttribute = new Lazy<ITypedElement>(RetrieveFailureIsolationMethodAttribute);
        
        /// <summary>
        /// The backing field for the CorporateCode property
        /// </summary>
        private string _corporateCode;
        
        private static Lazy<ITypedElement> _corporateCodeAttribute = new Lazy<ITypedElement>(RetrieveCorporateCodeAttribute);
        
        /// <summary>
        /// The backing field for the FaultLocatingMethod property
        /// </summary>
        private string _faultLocatingMethod;
        
        private static Lazy<ITypedElement> _faultLocatingMethodAttribute = new Lazy<ITypedElement>(RetrieveFaultLocatingMethodAttribute);
        
        /// <summary>
        /// The backing field for the Location property
        /// </summary>
        private string _location;
        
        private static Lazy<ITypedElement> _locationAttribute = new Lazy<ITypedElement>(RetrieveLocationAttribute);
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The failureIsolationMethod property
        /// </summary>
        [XmlElementNameAttribute("failureIsolationMethod")]
        [XmlAttributeAttribute(true)]
        public virtual Nullable<FailureIsolationMethodKind> FailureIsolationMethod
        {
            get
            {
                return this._failureIsolationMethod;
            }
            set
            {
                if ((this._failureIsolationMethod != value))
                {
                    Nullable<FailureIsolationMethodKind> old = this._failureIsolationMethod;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnFailureIsolationMethodChanging(e);
                    this.OnPropertyChanging("FailureIsolationMethod", e, _failureIsolationMethodAttribute);
                    this._failureIsolationMethod = value;
                    this.OnFailureIsolationMethodChanged(e);
                    this.OnPropertyChanged("FailureIsolationMethod", e, _failureIsolationMethodAttribute);
                }
            }
        }
        
        /// <summary>
        /// The corporateCode property
        /// </summary>
        [XmlElementNameAttribute("corporateCode")]
        [XmlAttributeAttribute(true)]
        public virtual string CorporateCode
        {
            get
            {
                return this._corporateCode;
            }
            set
            {
                if ((this._corporateCode != value))
                {
                    string old = this._corporateCode;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnCorporateCodeChanging(e);
                    this.OnPropertyChanging("CorporateCode", e, _corporateCodeAttribute);
                    this._corporateCode = value;
                    this.OnCorporateCodeChanged(e);
                    this.OnPropertyChanged("CorporateCode", e, _corporateCodeAttribute);
                }
            }
        }
        
        /// <summary>
        /// The faultLocatingMethod property
        /// </summary>
        [XmlElementNameAttribute("faultLocatingMethod")]
        [XmlAttributeAttribute(true)]
        public virtual string FaultLocatingMethod
        {
            get
            {
                return this._faultLocatingMethod;
            }
            set
            {
                if ((this._faultLocatingMethod != value))
                {
                    string old = this._faultLocatingMethod;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnFaultLocatingMethodChanging(e);
                    this.OnPropertyChanging("FaultLocatingMethod", e, _faultLocatingMethodAttribute);
                    this._faultLocatingMethod = value;
                    this.OnFaultLocatingMethodChanged(e);
                    this.OnPropertyChanged("FaultLocatingMethod", e, _faultLocatingMethodAttribute);
                }
            }
        }
        
        /// <summary>
        /// The location property
        /// </summary>
        [XmlElementNameAttribute("location")]
        [XmlAttributeAttribute(true)]
        public virtual string Location
        {
            get
            {
                return this._location;
            }
            set
            {
                if ((this._location != value))
                {
                    string old = this._location;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnLocationChanging(e);
                    this.OnPropertyChanging("Location", e, _locationAttribute);
                    this._location = value;
                    this.OnLocationChanged(e);
                    this.OnPropertyChanged("Location", e, _locationAttribute);
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfAssets/Failure" +
                            "Event")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the FailureIsolationMethod property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> FailureIsolationMethodChanging;
        
        /// <summary>
        /// Gets fired when the FailureIsolationMethod property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> FailureIsolationMethodChanged;
        
        /// <summary>
        /// Gets fired before the CorporateCode property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> CorporateCodeChanging;
        
        /// <summary>
        /// Gets fired when the CorporateCode property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> CorporateCodeChanged;
        
        /// <summary>
        /// Gets fired before the FaultLocatingMethod property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> FaultLocatingMethodChanging;
        
        /// <summary>
        /// Gets fired when the FaultLocatingMethod property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> FaultLocatingMethodChanged;
        
        /// <summary>
        /// Gets fired before the Location property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> LocationChanging;
        
        /// <summary>
        /// Gets fired when the Location property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> LocationChanged;
        
        private static ITypedElement RetrieveFailureIsolationMethodAttribute()
        {
            return ((ITypedElement)(((ModelElement)(FailureEvent.ClassInstance)).Resolve("failureIsolationMethod")));
        }
        
        /// <summary>
        /// Raises the FailureIsolationMethodChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnFailureIsolationMethodChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.FailureIsolationMethodChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the FailureIsolationMethodChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnFailureIsolationMethodChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.FailureIsolationMethodChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveCorporateCodeAttribute()
        {
            return ((ITypedElement)(((ModelElement)(FailureEvent.ClassInstance)).Resolve("corporateCode")));
        }
        
        /// <summary>
        /// Raises the CorporateCodeChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnCorporateCodeChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.CorporateCodeChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the CorporateCodeChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnCorporateCodeChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.CorporateCodeChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveFaultLocatingMethodAttribute()
        {
            return ((ITypedElement)(((ModelElement)(FailureEvent.ClassInstance)).Resolve("faultLocatingMethod")));
        }
        
        /// <summary>
        /// Raises the FaultLocatingMethodChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnFaultLocatingMethodChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.FaultLocatingMethodChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the FaultLocatingMethodChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnFaultLocatingMethodChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.FaultLocatingMethodChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveLocationAttribute()
        {
            return ((ITypedElement)(((ModelElement)(FailureEvent.ClassInstance)).Resolve("location")));
        }
        
        /// <summary>
        /// Raises the LocationChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnLocationChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.LocationChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the LocationChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnLocationChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.LocationChanged;
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
            if ((attribute == "FAILUREISOLATIONMETHOD"))
            {
                return this.FailureIsolationMethod;
            }
            if ((attribute == "CORPORATECODE"))
            {
                return this.CorporateCode;
            }
            if ((attribute == "FAULTLOCATINGMETHOD"))
            {
                return this.FaultLocatingMethod;
            }
            if ((attribute == "LOCATION"))
            {
                return this.Location;
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
            if ((feature == "FAILUREISOLATIONMETHOD"))
            {
                this.FailureIsolationMethod = ((FailureIsolationMethodKind)(value));
                return;
            }
            if ((feature == "CORPORATECODE"))
            {
                this.CorporateCode = ((string)(value));
                return;
            }
            if ((feature == "FAULTLOCATINGMETHOD"))
            {
                this.FaultLocatingMethod = ((string)(value));
                return;
            }
            if ((feature == "LOCATION"))
            {
                this.Location = ((string)(value));
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfAssets/Failure" +
                        "Event")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the failureIsolationMethod property
        /// </summary>
        private sealed class FailureIsolationMethodProxy : ModelPropertyChange<IFailureEvent, Nullable<FailureIsolationMethodKind>>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public FailureIsolationMethodProxy(IFailureEvent modelElement) : 
                    base(modelElement, "failureIsolationMethod")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override Nullable<FailureIsolationMethodKind> Value
            {
                get
                {
                    return this.ModelElement.FailureIsolationMethod;
                }
                set
                {
                    this.ModelElement.FailureIsolationMethod = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the corporateCode property
        /// </summary>
        private sealed class CorporateCodeProxy : ModelPropertyChange<IFailureEvent, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public CorporateCodeProxy(IFailureEvent modelElement) : 
                    base(modelElement, "corporateCode")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override string Value
            {
                get
                {
                    return this.ModelElement.CorporateCode;
                }
                set
                {
                    this.ModelElement.CorporateCode = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the faultLocatingMethod property
        /// </summary>
        private sealed class FaultLocatingMethodProxy : ModelPropertyChange<IFailureEvent, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public FaultLocatingMethodProxy(IFailureEvent modelElement) : 
                    base(modelElement, "faultLocatingMethod")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override string Value
            {
                get
                {
                    return this.ModelElement.FaultLocatingMethod;
                }
                set
                {
                    this.ModelElement.FaultLocatingMethod = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the location property
        /// </summary>
        private sealed class LocationProxy : ModelPropertyChange<IFailureEvent, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public LocationProxy(IFailureEvent modelElement) : 
                    base(modelElement, "location")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override string Value
            {
                get
                {
                    return this.ModelElement.Location;
                }
                set
                {
                    this.ModelElement.Location = value;
                }
            }
        }
    }
}

