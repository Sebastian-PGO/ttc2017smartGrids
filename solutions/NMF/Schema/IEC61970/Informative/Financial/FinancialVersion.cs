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
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Generation.Production;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.EnergyScheduling;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfERPSupport;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.MarketOperations;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.Reservation;

namespace TTC2017.SmartGrids.CIM.IEC61970.Informative.Financial
{
    
    
    /// <summary>
    /// The default implementation of the FinancialVersion class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#Financial")]
    [XmlNamespacePrefixAttribute("cimFinancial")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/Financial/Financi" +
        "alVersion")]
    [DebuggerDisplayAttribute("FinancialVersion {UUID}")]
    public partial class FinancialVersion : Element, IFinancialVersion, IModelElement
    {
        
        /// <summary>
        /// The backing field for the Version property
        /// </summary>
        private string _version;
        
        private static Lazy<ITypedElement> _versionAttribute = new Lazy<ITypedElement>(RetrieveVersionAttribute);
        
        /// <summary>
        /// The backing field for the Date property
        /// </summary>
        private DateTime _date;
        
        private static Lazy<ITypedElement> _dateAttribute = new Lazy<ITypedElement>(RetrieveDateAttribute);
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The version property
        /// </summary>
        [XmlElementNameAttribute("version")]
        [XmlAttributeAttribute(true)]
        public virtual string Version
        {
            get
            {
                return this._version;
            }
            set
            {
                if ((this._version != value))
                {
                    string old = this._version;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnVersionChanging(e);
                    this.OnPropertyChanging("Version", e, _versionAttribute);
                    this._version = value;
                    this.OnVersionChanged(e);
                    this.OnPropertyChanged("Version", e, _versionAttribute);
                }
            }
        }
        
        /// <summary>
        /// The date property
        /// </summary>
        [XmlElementNameAttribute("date")]
        [XmlAttributeAttribute(true)]
        public virtual DateTime Date
        {
            get
            {
                return this._date;
            }
            set
            {
                if ((this._date != value))
                {
                    DateTime old = this._date;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnDateChanging(e);
                    this.OnPropertyChanging("Date", e, _dateAttribute);
                    this._date = value;
                    this.OnDateChanged(e);
                    this.OnPropertyChanged("Date", e, _dateAttribute);
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/Financial/Financi" +
                            "alVersion")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the Version property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> VersionChanging;
        
        /// <summary>
        /// Gets fired when the Version property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> VersionChanged;
        
        /// <summary>
        /// Gets fired before the Date property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> DateChanging;
        
        /// <summary>
        /// Gets fired when the Date property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> DateChanged;
        
        private static ITypedElement RetrieveVersionAttribute()
        {
            return ((ITypedElement)(((ModelElement)(FinancialVersion.ClassInstance)).Resolve("version")));
        }
        
        /// <summary>
        /// Raises the VersionChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnVersionChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.VersionChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the VersionChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnVersionChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.VersionChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveDateAttribute()
        {
            return ((ITypedElement)(((ModelElement)(FinancialVersion.ClassInstance)).Resolve("date")));
        }
        
        /// <summary>
        /// Raises the DateChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnDateChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.DateChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the DateChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnDateChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.DateChanged;
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
            if ((attribute == "VERSION"))
            {
                return this.Version;
            }
            if ((attribute == "DATE"))
            {
                return this.Date;
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
            if ((feature == "VERSION"))
            {
                this.Version = ((string)(value));
                return;
            }
            if ((feature == "DATE"))
            {
                this.Date = ((DateTime)(value));
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/Financial/Financi" +
                        "alVersion")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the version property
        /// </summary>
        private sealed class VersionProxy : ModelPropertyChange<IFinancialVersion, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public VersionProxy(IFinancialVersion modelElement) : 
                    base(modelElement, "version")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override string Value
            {
                get
                {
                    return this.ModelElement.Version;
                }
                set
                {
                    this.ModelElement.Version = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the date property
        /// </summary>
        private sealed class DateProxy : ModelPropertyChange<IFinancialVersion, DateTime>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public DateProxy(IFinancialVersion modelElement) : 
                    base(modelElement, "date")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override DateTime Value
            {
                get
                {
                    return this.ModelElement.Date;
                }
                set
                {
                    this.ModelElement.Date = value;
                }
            }
        }
    }
}

