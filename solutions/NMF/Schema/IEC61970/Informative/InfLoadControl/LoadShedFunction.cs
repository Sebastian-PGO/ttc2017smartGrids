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
using TTC2017.SmartGrids.CIM.IEC61968.Common;
using TTC2017.SmartGrids.CIM.IEC61968.Metering;
using TTC2017.SmartGrids.CIM.IEC61970.Wires;

namespace TTC2017.SmartGrids.CIM.IEC61970.Informative.InfLoadControl
{
    
    
    /// <summary>
    /// The default implementation of the LoadShedFunction class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#InfLoadControl")]
    [XmlNamespacePrefixAttribute("cimInfLoadControl")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfLoadControl/Lo" +
        "adShedFunction")]
    [DebuggerDisplayAttribute("LoadShedFunction {UUID}")]
    public partial class LoadShedFunction : LoadMgmtFunction, ILoadShedFunction, IModelElement
    {
        
        /// <summary>
        /// The backing field for the SwitchedLoad property
        /// </summary>
        private float _switchedLoad;
        
        private static Lazy<ITypedElement> _switchedLoadAttribute = new Lazy<ITypedElement>(RetrieveSwitchedLoadAttribute);
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The switchedLoad property
        /// </summary>
        [XmlElementNameAttribute("switchedLoad")]
        [XmlAttributeAttribute(true)]
        public virtual float SwitchedLoad
        {
            get
            {
                return this._switchedLoad;
            }
            set
            {
                if ((this._switchedLoad != value))
                {
                    float old = this._switchedLoad;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnSwitchedLoadChanging(e);
                    this.OnPropertyChanging("SwitchedLoad", e, _switchedLoadAttribute);
                    this._switchedLoad = value;
                    this.OnSwitchedLoadChanged(e);
                    this.OnPropertyChanged("SwitchedLoad", e, _switchedLoadAttribute);
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfLoadControl/Lo" +
                            "adShedFunction")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the SwitchedLoad property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> SwitchedLoadChanging;
        
        /// <summary>
        /// Gets fired when the SwitchedLoad property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> SwitchedLoadChanged;
        
        private static ITypedElement RetrieveSwitchedLoadAttribute()
        {
            return ((ITypedElement)(((ModelElement)(LoadShedFunction.ClassInstance)).Resolve("switchedLoad")));
        }
        
        /// <summary>
        /// Raises the SwitchedLoadChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnSwitchedLoadChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.SwitchedLoadChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the SwitchedLoadChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnSwitchedLoadChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.SwitchedLoadChanged;
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
            if ((attribute == "SWITCHEDLOAD"))
            {
                return this.SwitchedLoad;
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
            if ((feature == "SWITCHEDLOAD"))
            {
                this.SwitchedLoad = ((float)(value));
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfLoadControl/Lo" +
                        "adShedFunction")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the switchedLoad property
        /// </summary>
        private sealed class SwitchedLoadProxy : ModelPropertyChange<ILoadShedFunction, float>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public SwitchedLoadProxy(ILoadShedFunction modelElement) : 
                    base(modelElement, "switchedLoad")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override float Value
            {
                get
                {
                    return this.ModelElement.SwitchedLoad;
                }
                set
                {
                    this.ModelElement.SwitchedLoad = value;
                }
            }
        }
    }
}

