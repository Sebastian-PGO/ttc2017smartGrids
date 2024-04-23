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
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfOperations;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfWork;
using TTC2017.SmartGrids.CIM.IEC61970.Meas;

namespace TTC2017.SmartGrids.CIM.IEC61970.Informative.InfGMLSupport
{
    
    
    /// <summary>
    /// The default implementation of the GmlHalo class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#InfGMLSupport")]
    [XmlNamespacePrefixAttribute("cimInfGMLSupport")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfGMLSupport/Gml" +
        "Halo")]
    [DebuggerDisplayAttribute("GmlHalo {UUID}")]
    public partial class GmlHalo : IdentifiedObject, IGmlHalo, IModelElement
    {
        
        /// <summary>
        /// The backing field for the Opacity property
        /// </summary>
        private float _opacity;
        
        private static Lazy<ITypedElement> _opacityAttribute = new Lazy<ITypedElement>(RetrieveOpacityAttribute);
        
        /// <summary>
        /// The backing field for the Radius property
        /// </summary>
        private string _radius;
        
        private static Lazy<ITypedElement> _radiusAttribute = new Lazy<ITypedElement>(RetrieveRadiusAttribute);
        
        private static Lazy<ITypedElement> _gmlTextSymbolsReference = new Lazy<ITypedElement>(RetrieveGmlTextSymbolsReference);
        
        /// <summary>
        /// The backing field for the GmlTextSymbols property
        /// </summary>
        private GmlHaloGmlTextSymbolsCollection _gmlTextSymbols;
        
        private static IClass _classInstance;
        
        public GmlHalo()
        {
            this._gmlTextSymbols = new GmlHaloGmlTextSymbolsCollection(this);
            this._gmlTextSymbols.CollectionChanging += this.GmlTextSymbolsCollectionChanging;
            this._gmlTextSymbols.CollectionChanged += this.GmlTextSymbolsCollectionChanged;
        }
        
        /// <summary>
        /// The opacity property
        /// </summary>
        [XmlElementNameAttribute("opacity")]
        [XmlAttributeAttribute(true)]
        public virtual float Opacity
        {
            get
            {
                return this._opacity;
            }
            set
            {
                if ((this._opacity != value))
                {
                    float old = this._opacity;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnOpacityChanging(e);
                    this.OnPropertyChanging("Opacity", e, _opacityAttribute);
                    this._opacity = value;
                    this.OnOpacityChanged(e);
                    this.OnPropertyChanged("Opacity", e, _opacityAttribute);
                }
            }
        }
        
        /// <summary>
        /// The radius property
        /// </summary>
        [XmlElementNameAttribute("radius")]
        [XmlAttributeAttribute(true)]
        public virtual string Radius
        {
            get
            {
                return this._radius;
            }
            set
            {
                if ((this._radius != value))
                {
                    string old = this._radius;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnRadiusChanging(e);
                    this.OnPropertyChanging("Radius", e, _radiusAttribute);
                    this._radius = value;
                    this.OnRadiusChanged(e);
                    this.OnPropertyChanged("Radius", e, _radiusAttribute);
                }
            }
        }
        
        /// <summary>
        /// The GmlTextSymbols property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("GmlHalo")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<IGmlTextSymbol> GmlTextSymbols
        {
            get
            {
                return this._gmlTextSymbols;
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new GmlHaloReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfGMLSupport/Gml" +
                            "Halo")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the Opacity property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> OpacityChanging;
        
        /// <summary>
        /// Gets fired when the Opacity property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> OpacityChanged;
        
        /// <summary>
        /// Gets fired before the Radius property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> RadiusChanging;
        
        /// <summary>
        /// Gets fired when the Radius property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> RadiusChanged;
        
        private static ITypedElement RetrieveOpacityAttribute()
        {
            return ((ITypedElement)(((ModelElement)(GmlHalo.ClassInstance)).Resolve("opacity")));
        }
        
        /// <summary>
        /// Raises the OpacityChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnOpacityChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.OpacityChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the OpacityChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnOpacityChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.OpacityChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveRadiusAttribute()
        {
            return ((ITypedElement)(((ModelElement)(GmlHalo.ClassInstance)).Resolve("radius")));
        }
        
        /// <summary>
        /// Raises the RadiusChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnRadiusChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.RadiusChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the RadiusChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnRadiusChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.RadiusChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveGmlTextSymbolsReference()
        {
            return ((ITypedElement)(((ModelElement)(GmlHalo.ClassInstance)).Resolve("GmlTextSymbols")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the GmlTextSymbols property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void GmlTextSymbolsCollectionChanging(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanging("GmlTextSymbols", e, _gmlTextSymbolsReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the GmlTextSymbols property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void GmlTextSymbolsCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("GmlTextSymbols", e, _gmlTextSymbolsReference);
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "OPACITY"))
            {
                return this.Opacity;
            }
            if ((attribute == "RADIUS"))
            {
                return this.Radius;
            }
            return base.GetAttributeValue(attribute, index);
        }
        
        /// <summary>
        /// Gets the Model element collection for the given feature
        /// </summary>
        /// <returns>A non-generic list of elements</returns>
        /// <param name="feature">The requested feature</param>
        protected override System.Collections.IList GetCollectionForFeature(string feature)
        {
            if ((feature == "GMLTEXTSYMBOLS"))
            {
                return this._gmlTextSymbols;
            }
            return base.GetCollectionForFeature(feature);
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "OPACITY"))
            {
                this.Opacity = ((float)(value));
                return;
            }
            if ((feature == "RADIUS"))
            {
                this.Radius = ((string)(value));
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfGMLSupport/Gml" +
                        "Halo")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the GmlHalo class
        /// </summary>
        public class GmlHaloReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private GmlHalo _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public GmlHaloReferencedElementsCollection(GmlHalo parent)
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
                    count = (count + this._parent.GmlTextSymbols.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.GmlTextSymbols.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.GmlTextSymbols.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IGmlTextSymbol gmlTextSymbolsCasted = item.As<IGmlTextSymbol>();
                if ((gmlTextSymbolsCasted != null))
                {
                    this._parent.GmlTextSymbols.Add(gmlTextSymbolsCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.GmlTextSymbols.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.GmlTextSymbols.Contains(item))
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
                IEnumerator<IModelElement> gmlTextSymbolsEnumerator = this._parent.GmlTextSymbols.GetEnumerator();
                try
                {
                    for (
                    ; gmlTextSymbolsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = gmlTextSymbolsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    gmlTextSymbolsEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IGmlTextSymbol gmlTextSymbolItem = item.As<IGmlTextSymbol>();
                if (((gmlTextSymbolItem != null) 
                            && this._parent.GmlTextSymbols.Remove(gmlTextSymbolItem)))
                {
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.GmlTextSymbols).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the opacity property
        /// </summary>
        private sealed class OpacityProxy : ModelPropertyChange<IGmlHalo, float>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public OpacityProxy(IGmlHalo modelElement) : 
                    base(modelElement, "opacity")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override float Value
            {
                get
                {
                    return this.ModelElement.Opacity;
                }
                set
                {
                    this.ModelElement.Opacity = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the radius property
        /// </summary>
        private sealed class RadiusProxy : ModelPropertyChange<IGmlHalo, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public RadiusProxy(IGmlHalo modelElement) : 
                    base(modelElement, "radius")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override string Value
            {
                get
                {
                    return this.ModelElement.Radius;
                }
                set
                {
                    this.ModelElement.Radius = value;
                }
            }
        }
    }
}

