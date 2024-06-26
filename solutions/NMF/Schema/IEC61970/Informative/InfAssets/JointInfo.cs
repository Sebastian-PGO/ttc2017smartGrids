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
    /// The default implementation of the JointInfo class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#InfAssets")]
    [XmlNamespacePrefixAttribute("cimInfAssets")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfAssets/JointIn" +
        "fo")]
    [DebuggerDisplayAttribute("JointInfo {UUID}")]
    public partial class JointInfo : ElectricalInfo, IJointInfo, IModelElement
    {
        
        /// <summary>
        /// The backing field for the FillKind property
        /// </summary>
        private Nullable<JointFillKind> _fillKind;
        
        private static Lazy<ITypedElement> _fillKindAttribute = new Lazy<ITypedElement>(RetrieveFillKindAttribute);
        
        /// <summary>
        /// The backing field for the ConfigurationKind property
        /// </summary>
        private Nullable<JointConfigurationKind> _configurationKind;
        
        private static Lazy<ITypedElement> _configurationKindAttribute = new Lazy<ITypedElement>(RetrieveConfigurationKindAttribute);
        
        /// <summary>
        /// The backing field for the Insulation property
        /// </summary>
        private string _insulation;
        
        private static Lazy<ITypedElement> _insulationAttribute = new Lazy<ITypedElement>(RetrieveInsulationAttribute);
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The fillKind property
        /// </summary>
        [XmlElementNameAttribute("fillKind")]
        [XmlAttributeAttribute(true)]
        public virtual Nullable<JointFillKind> FillKind
        {
            get
            {
                return this._fillKind;
            }
            set
            {
                if ((this._fillKind != value))
                {
                    Nullable<JointFillKind> old = this._fillKind;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnFillKindChanging(e);
                    this.OnPropertyChanging("FillKind", e, _fillKindAttribute);
                    this._fillKind = value;
                    this.OnFillKindChanged(e);
                    this.OnPropertyChanged("FillKind", e, _fillKindAttribute);
                }
            }
        }
        
        /// <summary>
        /// The configurationKind property
        /// </summary>
        [XmlElementNameAttribute("configurationKind")]
        [XmlAttributeAttribute(true)]
        public virtual Nullable<JointConfigurationKind> ConfigurationKind
        {
            get
            {
                return this._configurationKind;
            }
            set
            {
                if ((this._configurationKind != value))
                {
                    Nullable<JointConfigurationKind> old = this._configurationKind;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnConfigurationKindChanging(e);
                    this.OnPropertyChanging("ConfigurationKind", e, _configurationKindAttribute);
                    this._configurationKind = value;
                    this.OnConfigurationKindChanged(e);
                    this.OnPropertyChanged("ConfigurationKind", e, _configurationKindAttribute);
                }
            }
        }
        
        /// <summary>
        /// The insulation property
        /// </summary>
        [XmlElementNameAttribute("insulation")]
        [XmlAttributeAttribute(true)]
        public virtual string Insulation
        {
            get
            {
                return this._insulation;
            }
            set
            {
                if ((this._insulation != value))
                {
                    string old = this._insulation;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnInsulationChanging(e);
                    this.OnPropertyChanging("Insulation", e, _insulationAttribute);
                    this._insulation = value;
                    this.OnInsulationChanged(e);
                    this.OnPropertyChanged("Insulation", e, _insulationAttribute);
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfAssets/JointIn" +
                            "fo")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the FillKind property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> FillKindChanging;
        
        /// <summary>
        /// Gets fired when the FillKind property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> FillKindChanged;
        
        /// <summary>
        /// Gets fired before the ConfigurationKind property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ConfigurationKindChanging;
        
        /// <summary>
        /// Gets fired when the ConfigurationKind property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ConfigurationKindChanged;
        
        /// <summary>
        /// Gets fired before the Insulation property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> InsulationChanging;
        
        /// <summary>
        /// Gets fired when the Insulation property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> InsulationChanged;
        
        private static ITypedElement RetrieveFillKindAttribute()
        {
            return ((ITypedElement)(((ModelElement)(JointInfo.ClassInstance)).Resolve("fillKind")));
        }
        
        /// <summary>
        /// Raises the FillKindChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnFillKindChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.FillKindChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the FillKindChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnFillKindChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.FillKindChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveConfigurationKindAttribute()
        {
            return ((ITypedElement)(((ModelElement)(JointInfo.ClassInstance)).Resolve("configurationKind")));
        }
        
        /// <summary>
        /// Raises the ConfigurationKindChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnConfigurationKindChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ConfigurationKindChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the ConfigurationKindChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnConfigurationKindChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ConfigurationKindChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveInsulationAttribute()
        {
            return ((ITypedElement)(((ModelElement)(JointInfo.ClassInstance)).Resolve("insulation")));
        }
        
        /// <summary>
        /// Raises the InsulationChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnInsulationChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.InsulationChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the InsulationChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnInsulationChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.InsulationChanged;
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
            if ((attribute == "FILLKIND"))
            {
                return this.FillKind;
            }
            if ((attribute == "CONFIGURATIONKIND"))
            {
                return this.ConfigurationKind;
            }
            if ((attribute == "INSULATION"))
            {
                return this.Insulation;
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
            if ((feature == "FILLKIND"))
            {
                this.FillKind = ((JointFillKind)(value));
                return;
            }
            if ((feature == "CONFIGURATIONKIND"))
            {
                this.ConfigurationKind = ((JointConfigurationKind)(value));
                return;
            }
            if ((feature == "INSULATION"))
            {
                this.Insulation = ((string)(value));
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfAssets/JointIn" +
                        "fo")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the fillKind property
        /// </summary>
        private sealed class FillKindProxy : ModelPropertyChange<IJointInfo, Nullable<JointFillKind>>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public FillKindProxy(IJointInfo modelElement) : 
                    base(modelElement, "fillKind")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override Nullable<JointFillKind> Value
            {
                get
                {
                    return this.ModelElement.FillKind;
                }
                set
                {
                    this.ModelElement.FillKind = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the configurationKind property
        /// </summary>
        private sealed class ConfigurationKindProxy : ModelPropertyChange<IJointInfo, Nullable<JointConfigurationKind>>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public ConfigurationKindProxy(IJointInfo modelElement) : 
                    base(modelElement, "configurationKind")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override Nullable<JointConfigurationKind> Value
            {
                get
                {
                    return this.ModelElement.ConfigurationKind;
                }
                set
                {
                    this.ModelElement.ConfigurationKind = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the insulation property
        /// </summary>
        private sealed class InsulationProxy : ModelPropertyChange<IJointInfo, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public InsulationProxy(IJointInfo modelElement) : 
                    base(modelElement, "insulation")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override string Value
            {
                get
                {
                    return this.ModelElement.Insulation;
                }
                set
                {
                    this.ModelElement.Insulation = value;
                }
            }
        }
    }
}

