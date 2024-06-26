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
using TTC2017.SmartGrids.SubstationStandard.Enumerations;

namespace TTC2017.SmartGrids.SubstationStandard.Dataclasses
{
    
    
    /// <summary>
    /// The default implementation of the DPL class
    /// </summary>
    [XmlNamespaceAttribute("http://www.transformation-tool-contest.eu/2017/smartGrids/dataclasses")]
    [XmlNamespacePrefixAttribute("data")]
    [ModelRepresentationClassAttribute("http://www.transformation-tool-contest.eu/2017/smartGrids/substationStandard#//Da" +
        "taclasses/DPL")]
    public partial class DPL : ModelElement, IDPL, IModelElement
    {
        
        /// <summary>
        /// The backing field for the Vendor property
        /// </summary>
        private string _vendor;
        
        private static Lazy<ITypedElement> _vendorAttribute = new Lazy<ITypedElement>(RetrieveVendorAttribute);
        
        /// <summary>
        /// The backing field for the HwRev property
        /// </summary>
        private string _hwRev;
        
        private static Lazy<ITypedElement> _hwRevAttribute = new Lazy<ITypedElement>(RetrieveHwRevAttribute);
        
        /// <summary>
        /// The backing field for the SwRev property
        /// </summary>
        private string _swRev;
        
        private static Lazy<ITypedElement> _swRevAttribute = new Lazy<ITypedElement>(RetrieveSwRevAttribute);
        
        /// <summary>
        /// The backing field for the SerNum property
        /// </summary>
        private string _serNum;
        
        private static Lazy<ITypedElement> _serNumAttribute = new Lazy<ITypedElement>(RetrieveSerNumAttribute);
        
        /// <summary>
        /// The backing field for the Model property
        /// </summary>
        private string _model;
        
        private static Lazy<ITypedElement> _modelAttribute = new Lazy<ITypedElement>(RetrieveModelAttribute);
        
        /// <summary>
        /// The backing field for the Location property
        /// </summary>
        private string _location;
        
        private static Lazy<ITypedElement> _locationAttribute = new Lazy<ITypedElement>(RetrieveLocationAttribute);
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The vendor property
        /// </summary>
        [XmlElementNameAttribute("vendor")]
        [XmlAttributeAttribute(true)]
        public virtual string Vendor
        {
            get
            {
                return this._vendor;
            }
            set
            {
                if ((this._vendor != value))
                {
                    string old = this._vendor;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnVendorChanging(e);
                    this.OnPropertyChanging("Vendor", e, _vendorAttribute);
                    this._vendor = value;
                    this.OnVendorChanged(e);
                    this.OnPropertyChanged("Vendor", e, _vendorAttribute);
                }
            }
        }
        
        /// <summary>
        /// The hwRev property
        /// </summary>
        [XmlElementNameAttribute("hwRev")]
        [XmlAttributeAttribute(true)]
        public virtual string HwRev
        {
            get
            {
                return this._hwRev;
            }
            set
            {
                if ((this._hwRev != value))
                {
                    string old = this._hwRev;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnHwRevChanging(e);
                    this.OnPropertyChanging("HwRev", e, _hwRevAttribute);
                    this._hwRev = value;
                    this.OnHwRevChanged(e);
                    this.OnPropertyChanged("HwRev", e, _hwRevAttribute);
                }
            }
        }
        
        /// <summary>
        /// The swRev property
        /// </summary>
        [XmlElementNameAttribute("swRev")]
        [XmlAttributeAttribute(true)]
        public virtual string SwRev
        {
            get
            {
                return this._swRev;
            }
            set
            {
                if ((this._swRev != value))
                {
                    string old = this._swRev;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnSwRevChanging(e);
                    this.OnPropertyChanging("SwRev", e, _swRevAttribute);
                    this._swRev = value;
                    this.OnSwRevChanged(e);
                    this.OnPropertyChanged("SwRev", e, _swRevAttribute);
                }
            }
        }
        
        /// <summary>
        /// The serNum property
        /// </summary>
        [XmlElementNameAttribute("serNum")]
        [XmlAttributeAttribute(true)]
        public virtual string SerNum
        {
            get
            {
                return this._serNum;
            }
            set
            {
                if ((this._serNum != value))
                {
                    string old = this._serNum;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnSerNumChanging(e);
                    this.OnPropertyChanging("SerNum", e, _serNumAttribute);
                    this._serNum = value;
                    this.OnSerNumChanged(e);
                    this.OnPropertyChanged("SerNum", e, _serNumAttribute);
                }
            }
        }
        
        /// <summary>
        /// The model property
        /// </summary>
        [XmlElementNameAttribute("model")]
        [XmlAttributeAttribute(true)]
        public virtual string Model
        {
            get
            {
                return this._model;
            }
            set
            {
                if ((this._model != value))
                {
                    string old = this._model;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnModelChanging(e);
                    this.OnPropertyChanging("Model", e, _modelAttribute);
                    this._model = value;
                    this.OnModelChanged(e);
                    this.OnPropertyChanged("Model", e, _modelAttribute);
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://www.transformation-tool-contest.eu/2017/smartGrids/substationStandard#//Da" +
                            "taclasses/DPL")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the Vendor property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> VendorChanging;
        
        /// <summary>
        /// Gets fired when the Vendor property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> VendorChanged;
        
        /// <summary>
        /// Gets fired before the HwRev property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> HwRevChanging;
        
        /// <summary>
        /// Gets fired when the HwRev property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> HwRevChanged;
        
        /// <summary>
        /// Gets fired before the SwRev property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> SwRevChanging;
        
        /// <summary>
        /// Gets fired when the SwRev property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> SwRevChanged;
        
        /// <summary>
        /// Gets fired before the SerNum property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> SerNumChanging;
        
        /// <summary>
        /// Gets fired when the SerNum property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> SerNumChanged;
        
        /// <summary>
        /// Gets fired before the Model property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ModelChanging;
        
        /// <summary>
        /// Gets fired when the Model property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ModelChanged;
        
        /// <summary>
        /// Gets fired before the Location property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> LocationChanging;
        
        /// <summary>
        /// Gets fired when the Location property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> LocationChanged;
        
        private static ITypedElement RetrieveVendorAttribute()
        {
            return ((ITypedElement)(((ModelElement)(DPL.ClassInstance)).Resolve("vendor")));
        }
        
        /// <summary>
        /// Raises the VendorChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnVendorChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.VendorChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the VendorChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnVendorChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.VendorChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveHwRevAttribute()
        {
            return ((ITypedElement)(((ModelElement)(DPL.ClassInstance)).Resolve("hwRev")));
        }
        
        /// <summary>
        /// Raises the HwRevChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnHwRevChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.HwRevChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the HwRevChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnHwRevChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.HwRevChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveSwRevAttribute()
        {
            return ((ITypedElement)(((ModelElement)(DPL.ClassInstance)).Resolve("swRev")));
        }
        
        /// <summary>
        /// Raises the SwRevChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnSwRevChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.SwRevChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the SwRevChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnSwRevChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.SwRevChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveSerNumAttribute()
        {
            return ((ITypedElement)(((ModelElement)(DPL.ClassInstance)).Resolve("serNum")));
        }
        
        /// <summary>
        /// Raises the SerNumChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnSerNumChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.SerNumChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the SerNumChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnSerNumChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.SerNumChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveModelAttribute()
        {
            return ((ITypedElement)(((ModelElement)(DPL.ClassInstance)).Resolve("model")));
        }
        
        /// <summary>
        /// Raises the ModelChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnModelChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ModelChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the ModelChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnModelChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ModelChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveLocationAttribute()
        {
            return ((ITypedElement)(((ModelElement)(DPL.ClassInstance)).Resolve("location")));
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
            if ((attribute == "VENDOR"))
            {
                return this.Vendor;
            }
            if ((attribute == "HWREV"))
            {
                return this.HwRev;
            }
            if ((attribute == "SWREV"))
            {
                return this.SwRev;
            }
            if ((attribute == "SERNUM"))
            {
                return this.SerNum;
            }
            if ((attribute == "MODEL"))
            {
                return this.Model;
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
            if ((feature == "VENDOR"))
            {
                this.Vendor = ((string)(value));
                return;
            }
            if ((feature == "HWREV"))
            {
                this.HwRev = ((string)(value));
                return;
            }
            if ((feature == "SWREV"))
            {
                this.SwRev = ((string)(value));
                return;
            }
            if ((feature == "SERNUM"))
            {
                this.SerNum = ((string)(value));
                return;
            }
            if ((feature == "MODEL"))
            {
                this.Model = ((string)(value));
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://www.transformation-tool-contest.eu/2017/smartGrids/substationStandard#//Da" +
                        "taclasses/DPL")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the vendor property
        /// </summary>
        private sealed class VendorProxy : ModelPropertyChange<IDPL, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public VendorProxy(IDPL modelElement) : 
                    base(modelElement, "vendor")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override string Value
            {
                get
                {
                    return this.ModelElement.Vendor;
                }
                set
                {
                    this.ModelElement.Vendor = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the hwRev property
        /// </summary>
        private sealed class HwRevProxy : ModelPropertyChange<IDPL, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public HwRevProxy(IDPL modelElement) : 
                    base(modelElement, "hwRev")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override string Value
            {
                get
                {
                    return this.ModelElement.HwRev;
                }
                set
                {
                    this.ModelElement.HwRev = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the swRev property
        /// </summary>
        private sealed class SwRevProxy : ModelPropertyChange<IDPL, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public SwRevProxy(IDPL modelElement) : 
                    base(modelElement, "swRev")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override string Value
            {
                get
                {
                    return this.ModelElement.SwRev;
                }
                set
                {
                    this.ModelElement.SwRev = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the serNum property
        /// </summary>
        private sealed class SerNumProxy : ModelPropertyChange<IDPL, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public SerNumProxy(IDPL modelElement) : 
                    base(modelElement, "serNum")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override string Value
            {
                get
                {
                    return this.ModelElement.SerNum;
                }
                set
                {
                    this.ModelElement.SerNum = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the model property
        /// </summary>
        private sealed class ModelProxy : ModelPropertyChange<IDPL, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public ModelProxy(IDPL modelElement) : 
                    base(modelElement, "model")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override string Value
            {
                get
                {
                    return this.ModelElement.Model;
                }
                set
                {
                    this.ModelElement.Model = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the location property
        /// </summary>
        private sealed class LocationProxy : ModelPropertyChange<IDPL, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public LocationProxy(IDPL modelElement) : 
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

