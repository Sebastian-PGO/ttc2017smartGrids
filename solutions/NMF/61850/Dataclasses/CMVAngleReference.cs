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
    /// The default implementation of the CMVAngleReference class
    /// </summary>
    [XmlNamespaceAttribute("http://www.transformation-tool-contest.eu/2017/smartGrids/dataclasses")]
    [XmlNamespacePrefixAttribute("data")]
    [ModelRepresentationClassAttribute("http://www.transformation-tool-contest.eu/2017/smartGrids/substationStandard#//Da" +
        "taclasses/CMVAngleReference")]
    public partial class CMVAngleReference : ModelElement, ICMVAngleReference, IModelElement
    {
        
        /// <summary>
        /// The backing field for the Val property
        /// </summary>
        private Nullable<CMVAngleReferenceKind> _val;
        
        private static Lazy<ITypedElement> _valAttribute = new Lazy<ITypedElement>(RetrieveValAttribute);
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The val property
        /// </summary>
        [XmlElementNameAttribute("val")]
        [XmlAttributeAttribute(true)]
        public virtual Nullable<CMVAngleReferenceKind> Val
        {
            get
            {
                return this._val;
            }
            set
            {
                if ((this._val != value))
                {
                    Nullable<CMVAngleReferenceKind> old = this._val;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnValChanging(e);
                    this.OnPropertyChanging("Val", e, _valAttribute);
                    this._val = value;
                    this.OnValChanged(e);
                    this.OnPropertyChanged("Val", e, _valAttribute);
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
                            "taclasses/CMVAngleReference")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the Val property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ValChanging;
        
        /// <summary>
        /// Gets fired when the Val property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ValChanged;
        
        private static ITypedElement RetrieveValAttribute()
        {
            return ((ITypedElement)(((ModelElement)(CMVAngleReference.ClassInstance)).Resolve("val")));
        }
        
        /// <summary>
        /// Raises the ValChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnValChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ValChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the ValChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnValChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ValChanged;
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
            if ((attribute == "VAL"))
            {
                return this.Val;
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
            if ((feature == "VAL"))
            {
                this.Val = ((CMVAngleReferenceKind)(value));
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
                        "taclasses/CMVAngleReference")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the val property
        /// </summary>
        private sealed class ValProxy : ModelPropertyChange<ICMVAngleReference, Nullable<CMVAngleReferenceKind>>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public ValProxy(ICMVAngleReference modelElement) : 
                    base(modelElement, "val")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override Nullable<CMVAngleReferenceKind> Value
            {
                get
                {
                    return this.ModelElement.Val;
                }
                set
                {
                    this.ModelElement.Val = value;
                }
            }
        }
    }
}

