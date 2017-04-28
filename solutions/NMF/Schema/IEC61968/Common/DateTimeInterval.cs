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
using TTC2017.SmartGrids.CIM.IEC61968.PaymentMetering;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssets;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfCommon;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfERPSupport;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfGMLSupport;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfLocations;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfOperations;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfWork;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.MarketOperations;
using TTC2017.SmartGrids.CIM.IEC61970.Meas;

namespace TTC2017.SmartGrids.CIM.IEC61968.Common
{
    
    
    /// <summary>
    /// The default implementation of the DateTimeInterval class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#Common")]
    [XmlNamespacePrefixAttribute("cimCommon")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61968/Common/DateTimeInterval")]
    [DebuggerDisplayAttribute("DateTimeInterval {UUID}")]
    public partial class DateTimeInterval : Element, IDateTimeInterval, IModelElement
    {
        
        /// <summary>
        /// The backing field for the Start property
        /// </summary>
        private DateTime _start;
        
        private static Lazy<ITypedElement> _startAttribute = new Lazy<ITypedElement>(RetrieveStartAttribute);
        
        /// <summary>
        /// The backing field for the End property
        /// </summary>
        private DateTime _end;
        
        private static Lazy<ITypedElement> _endAttribute = new Lazy<ITypedElement>(RetrieveEndAttribute);
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The start property
        /// </summary>
        [XmlElementNameAttribute("start")]
        [XmlAttributeAttribute(true)]
        public virtual DateTime Start
        {
            get
            {
                return this._start;
            }
            set
            {
                if ((this._start != value))
                {
                    DateTime old = this._start;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnStartChanging(e);
                    this.OnPropertyChanging("Start", e, _startAttribute);
                    this._start = value;
                    this.OnStartChanged(e);
                    this.OnPropertyChanged("Start", e, _startAttribute);
                }
            }
        }
        
        /// <summary>
        /// The end property
        /// </summary>
        [XmlElementNameAttribute("end")]
        [XmlAttributeAttribute(true)]
        public virtual DateTime End
        {
            get
            {
                return this._end;
            }
            set
            {
                if ((this._end != value))
                {
                    DateTime old = this._end;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnEndChanging(e);
                    this.OnPropertyChanging("End", e, _endAttribute);
                    this._end = value;
                    this.OnEndChanged(e);
                    this.OnPropertyChanged("End", e, _endAttribute);
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61968/Common/DateTimeInterval")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the Start property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> StartChanging;
        
        /// <summary>
        /// Gets fired when the Start property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> StartChanged;
        
        /// <summary>
        /// Gets fired before the End property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> EndChanging;
        
        /// <summary>
        /// Gets fired when the End property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> EndChanged;
        
        private static ITypedElement RetrieveStartAttribute()
        {
            return ((ITypedElement)(((ModelElement)(DateTimeInterval.ClassInstance)).Resolve("start")));
        }
        
        /// <summary>
        /// Raises the StartChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnStartChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.StartChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the StartChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnStartChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.StartChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveEndAttribute()
        {
            return ((ITypedElement)(((ModelElement)(DateTimeInterval.ClassInstance)).Resolve("end")));
        }
        
        /// <summary>
        /// Raises the EndChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnEndChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.EndChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the EndChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnEndChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.EndChanged;
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
            if ((attribute == "START"))
            {
                return this.Start;
            }
            if ((attribute == "END"))
            {
                return this.End;
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
            if ((feature == "START"))
            {
                this.Start = ((DateTime)(value));
                return;
            }
            if ((feature == "END"))
            {
                this.End = ((DateTime)(value));
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61968/Common/DateTimeInterval")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the start property
        /// </summary>
        private sealed class StartProxy : ModelPropertyChange<IDateTimeInterval, DateTime>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public StartProxy(IDateTimeInterval modelElement) : 
                    base(modelElement, "start")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override DateTime Value
            {
                get
                {
                    return this.ModelElement.Start;
                }
                set
                {
                    this.ModelElement.Start = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the end property
        /// </summary>
        private sealed class EndProxy : ModelPropertyChange<IDateTimeInterval, DateTime>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public EndProxy(IDateTimeInterval modelElement) : 
                    base(modelElement, "end")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override DateTime Value
            {
                get
                {
                    return this.ModelElement.End;
                }
                set
                {
                    this.ModelElement.End = value;
                }
            }
        }
    }
}

