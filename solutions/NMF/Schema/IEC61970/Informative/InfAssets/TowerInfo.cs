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
    /// The default implementation of the TowerInfo class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#InfAssets")]
    [XmlNamespacePrefixAttribute("cimInfAssets")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfAssets/TowerIn" +
        "fo")]
    [DebuggerDisplayAttribute("TowerInfo {UUID}")]
    public partial class TowerInfo : StructureInfo, ITowerInfo, IModelElement
    {
        
        /// <summary>
        /// The backing field for the ConstructionKind property
        /// </summary>
        private Nullable<TowerConstructionKind> _constructionKind;
        
        private static Lazy<ITypedElement> _constructionKindAttribute = new Lazy<ITypedElement>(RetrieveConstructionKindAttribute);
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The constructionKind property
        /// </summary>
        [XmlElementNameAttribute("constructionKind")]
        [XmlAttributeAttribute(true)]
        public virtual Nullable<TowerConstructionKind> ConstructionKind
        {
            get
            {
                return this._constructionKind;
            }
            set
            {
                if ((this._constructionKind != value))
                {
                    Nullable<TowerConstructionKind> old = this._constructionKind;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnConstructionKindChanging(e);
                    this.OnPropertyChanging("ConstructionKind", e, _constructionKindAttribute);
                    this._constructionKind = value;
                    this.OnConstructionKindChanged(e);
                    this.OnPropertyChanged("ConstructionKind", e, _constructionKindAttribute);
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfAssets/TowerIn" +
                            "fo")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the ConstructionKind property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ConstructionKindChanging;
        
        /// <summary>
        /// Gets fired when the ConstructionKind property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ConstructionKindChanged;
        
        private static ITypedElement RetrieveConstructionKindAttribute()
        {
            return ((ITypedElement)(((ModelElement)(TowerInfo.ClassInstance)).Resolve("constructionKind")));
        }
        
        /// <summary>
        /// Raises the ConstructionKindChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnConstructionKindChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ConstructionKindChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the ConstructionKindChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnConstructionKindChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ConstructionKindChanged;
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
            if ((attribute == "CONSTRUCTIONKIND"))
            {
                return this.ConstructionKind;
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
            if ((feature == "CONSTRUCTIONKIND"))
            {
                this.ConstructionKind = ((TowerConstructionKind)(value));
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfAssets/TowerIn" +
                        "fo")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the constructionKind property
        /// </summary>
        private sealed class ConstructionKindProxy : ModelPropertyChange<ITowerInfo, Nullable<TowerConstructionKind>>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public ConstructionKindProxy(ITowerInfo modelElement) : 
                    base(modelElement, "constructionKind")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override Nullable<TowerConstructionKind> Value
            {
                get
                {
                    return this.ModelElement.ConstructionKind;
                }
                set
                {
                    this.ModelElement.ConstructionKind = value;
                }
            }
        }
    }
}

