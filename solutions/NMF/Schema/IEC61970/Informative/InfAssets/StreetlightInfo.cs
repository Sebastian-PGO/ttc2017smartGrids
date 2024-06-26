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
    /// The default implementation of the StreetlightInfo class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#InfAssets")]
    [XmlNamespacePrefixAttribute("cimInfAssets")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfAssets/Streetl" +
        "ightInfo")]
    [DebuggerDisplayAttribute("StreetlightInfo {UUID}")]
    public partial class StreetlightInfo : ElectricalInfo, IStreetlightInfo, IModelElement
    {
        
        /// <summary>
        /// The backing field for the LightRating property
        /// </summary>
        private float _lightRating;
        
        private static Lazy<ITypedElement> _lightRatingAttribute = new Lazy<ITypedElement>(RetrieveLightRatingAttribute);
        
        /// <summary>
        /// The backing field for the ArmLength property
        /// </summary>
        private float _armLength;
        
        private static Lazy<ITypedElement> _armLengthAttribute = new Lazy<ITypedElement>(RetrieveArmLengthAttribute);
        
        /// <summary>
        /// The backing field for the LampKind property
        /// </summary>
        private Nullable<StreetlightLampKind> _lampKind;
        
        private static Lazy<ITypedElement> _lampKindAttribute = new Lazy<ITypedElement>(RetrieveLampKindAttribute);
        
        private static Lazy<ITypedElement> _poleReference = new Lazy<ITypedElement>(RetrievePoleReference);
        
        /// <summary>
        /// The backing field for the Pole property
        /// </summary>
        private IPoleInfo _pole;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The lightRating property
        /// </summary>
        [XmlElementNameAttribute("lightRating")]
        [XmlAttributeAttribute(true)]
        public virtual float LightRating
        {
            get
            {
                return this._lightRating;
            }
            set
            {
                if ((this._lightRating != value))
                {
                    float old = this._lightRating;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnLightRatingChanging(e);
                    this.OnPropertyChanging("LightRating", e, _lightRatingAttribute);
                    this._lightRating = value;
                    this.OnLightRatingChanged(e);
                    this.OnPropertyChanged("LightRating", e, _lightRatingAttribute);
                }
            }
        }
        
        /// <summary>
        /// The armLength property
        /// </summary>
        [XmlElementNameAttribute("armLength")]
        [XmlAttributeAttribute(true)]
        public virtual float ArmLength
        {
            get
            {
                return this._armLength;
            }
            set
            {
                if ((this._armLength != value))
                {
                    float old = this._armLength;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnArmLengthChanging(e);
                    this.OnPropertyChanging("ArmLength", e, _armLengthAttribute);
                    this._armLength = value;
                    this.OnArmLengthChanged(e);
                    this.OnPropertyChanged("ArmLength", e, _armLengthAttribute);
                }
            }
        }
        
        /// <summary>
        /// The lampKind property
        /// </summary>
        [XmlElementNameAttribute("lampKind")]
        [XmlAttributeAttribute(true)]
        public virtual Nullable<StreetlightLampKind> LampKind
        {
            get
            {
                return this._lampKind;
            }
            set
            {
                if ((this._lampKind != value))
                {
                    Nullable<StreetlightLampKind> old = this._lampKind;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnLampKindChanging(e);
                    this.OnPropertyChanging("LampKind", e, _lampKindAttribute);
                    this._lampKind = value;
                    this.OnLampKindChanged(e);
                    this.OnPropertyChanged("LampKind", e, _lampKindAttribute);
                }
            }
        }
        
        /// <summary>
        /// The Pole property
        /// </summary>
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("Streetlights")]
        public virtual IPoleInfo Pole
        {
            get
            {
                return this._pole;
            }
            set
            {
                if ((this._pole != value))
                {
                    IPoleInfo old = this._pole;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnPoleChanging(e);
                    this.OnPropertyChanging("Pole", e, _poleReference);
                    this._pole = value;
                    if ((old != null))
                    {
                        old.Streetlights.Remove(this);
                        old.Deleted -= this.OnResetPole;
                    }
                    if ((value != null))
                    {
                        value.Streetlights.Add(this);
                        value.Deleted += this.OnResetPole;
                    }
                    this.OnPoleChanged(e);
                    this.OnPropertyChanged("Pole", e, _poleReference);
                }
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new StreetlightInfoReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfAssets/Streetl" +
                            "ightInfo")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the LightRating property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> LightRatingChanging;
        
        /// <summary>
        /// Gets fired when the LightRating property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> LightRatingChanged;
        
        /// <summary>
        /// Gets fired before the ArmLength property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ArmLengthChanging;
        
        /// <summary>
        /// Gets fired when the ArmLength property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ArmLengthChanged;
        
        /// <summary>
        /// Gets fired before the LampKind property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> LampKindChanging;
        
        /// <summary>
        /// Gets fired when the LampKind property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> LampKindChanged;
        
        /// <summary>
        /// Gets fired before the Pole property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> PoleChanging;
        
        /// <summary>
        /// Gets fired when the Pole property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> PoleChanged;
        
        private static ITypedElement RetrieveLightRatingAttribute()
        {
            return ((ITypedElement)(((ModelElement)(StreetlightInfo.ClassInstance)).Resolve("lightRating")));
        }
        
        /// <summary>
        /// Raises the LightRatingChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnLightRatingChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.LightRatingChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the LightRatingChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnLightRatingChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.LightRatingChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveArmLengthAttribute()
        {
            return ((ITypedElement)(((ModelElement)(StreetlightInfo.ClassInstance)).Resolve("armLength")));
        }
        
        /// <summary>
        /// Raises the ArmLengthChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnArmLengthChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ArmLengthChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the ArmLengthChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnArmLengthChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ArmLengthChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveLampKindAttribute()
        {
            return ((ITypedElement)(((ModelElement)(StreetlightInfo.ClassInstance)).Resolve("lampKind")));
        }
        
        /// <summary>
        /// Raises the LampKindChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnLampKindChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.LampKindChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the LampKindChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnLampKindChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.LampKindChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrievePoleReference()
        {
            return ((ITypedElement)(((ModelElement)(StreetlightInfo.ClassInstance)).Resolve("Pole")));
        }
        
        /// <summary>
        /// Raises the PoleChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnPoleChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.PoleChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the PoleChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnPoleChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.PoleChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the Pole property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetPole(object sender, System.EventArgs eventArgs)
        {
            this.Pole = null;
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "LIGHTRATING"))
            {
                return this.LightRating;
            }
            if ((attribute == "ARMLENGTH"))
            {
                return this.ArmLength;
            }
            if ((attribute == "LAMPKIND"))
            {
                return this.LampKind;
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
            if ((feature == "POLE"))
            {
                this.Pole = ((IPoleInfo)(value));
                return;
            }
            if ((feature == "LIGHTRATING"))
            {
                this.LightRating = ((float)(value));
                return;
            }
            if ((feature == "ARMLENGTH"))
            {
                this.ArmLength = ((float)(value));
                return;
            }
            if ((feature == "LAMPKIND"))
            {
                this.LampKind = ((StreetlightLampKind)(value));
                return;
            }
            base.SetFeature(feature, value);
        }
        
        /// <summary>
        /// Gets the property expression for the given attribute
        /// </summary>
        /// <returns>An incremental property expression</returns>
        /// <param name="attribute">The requested attribute in upper case</param>
        protected override NMF.Expressions.INotifyExpression<object> GetExpressionForAttribute(string attribute)
        {
            if ((attribute == "Pole"))
            {
                return new PoleProxy(this);
            }
            return base.GetExpressionForAttribute(attribute);
        }
        
        /// <summary>
        /// Gets the property expression for the given reference
        /// </summary>
        /// <returns>An incremental property expression</returns>
        /// <param name="reference">The requested reference in upper case</param>
        protected override NMF.Expressions.INotifyExpression<NMF.Models.IModelElement> GetExpressionForReference(string reference)
        {
            if ((reference == "Pole"))
            {
                return new PoleProxy(this);
            }
            return base.GetExpressionForReference(reference);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override IClass GetClass()
        {
            if ((_classInstance == null))
            {
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfAssets/Streetl" +
                        "ightInfo")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the StreetlightInfo class
        /// </summary>
        public class StreetlightInfoReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private StreetlightInfo _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public StreetlightInfoReferencedElementsCollection(StreetlightInfo parent)
            {
                this._parent = parent;
            }
            
            /// <summary>
            /// Gets the amount of elements contained in this collection
            /// </summary>
            public override int Count
            {
                get
                {
                    int count = 0;
                    if ((this._parent.Pole != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.PoleChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.PoleChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.Pole == null))
                {
                    IPoleInfo poleCasted = item.As<IPoleInfo>();
                    if ((poleCasted != null))
                    {
                        this._parent.Pole = poleCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.Pole = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.Pole))
                {
                    return true;
                }
                return false;
            }
            
            /// <summary>
            /// Copies the contents of the collection to the given array starting from the given array index
            /// </summary>
            /// <param name="array">The array in which the elements should be copied</param>
            /// <param name="arrayIndex">The starting index</param>
            public override void CopyTo(IModelElement[] array, int arrayIndex)
            {
                if ((this._parent.Pole != null))
                {
                    array[arrayIndex] = this._parent.Pole;
                    arrayIndex = (arrayIndex + 1);
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                if ((this._parent.Pole == item))
                {
                    this._parent.Pole = null;
                    return true;
                }
                return false;
            }
            
            /// <summary>
            /// Gets an enumerator that enumerates the collection
            /// </summary>
            /// <returns>A generic enumerator</returns>
            public override IEnumerator<IModelElement> GetEnumerator()
            {
                return Enumerable.Empty<IModelElement>().Concat(this._parent.Pole).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the lightRating property
        /// </summary>
        private sealed class LightRatingProxy : ModelPropertyChange<IStreetlightInfo, float>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public LightRatingProxy(IStreetlightInfo modelElement) : 
                    base(modelElement, "lightRating")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override float Value
            {
                get
                {
                    return this.ModelElement.LightRating;
                }
                set
                {
                    this.ModelElement.LightRating = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the armLength property
        /// </summary>
        private sealed class ArmLengthProxy : ModelPropertyChange<IStreetlightInfo, float>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public ArmLengthProxy(IStreetlightInfo modelElement) : 
                    base(modelElement, "armLength")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override float Value
            {
                get
                {
                    return this.ModelElement.ArmLength;
                }
                set
                {
                    this.ModelElement.ArmLength = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the lampKind property
        /// </summary>
        private sealed class LampKindProxy : ModelPropertyChange<IStreetlightInfo, Nullable<StreetlightLampKind>>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public LampKindProxy(IStreetlightInfo modelElement) : 
                    base(modelElement, "lampKind")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override Nullable<StreetlightLampKind> Value
            {
                get
                {
                    return this.ModelElement.LampKind;
                }
                set
                {
                    this.ModelElement.LampKind = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the Pole property
        /// </summary>
        private sealed class PoleProxy : ModelPropertyChange<IStreetlightInfo, IPoleInfo>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public PoleProxy(IStreetlightInfo modelElement) : 
                    base(modelElement, "Pole")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IPoleInfo Value
            {
                get
                {
                    return this.ModelElement.Pole;
                }
                set
                {
                    this.ModelElement.Pole = value;
                }
            }
        }
    }
}

