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
    /// The default implementation of the GmlColour class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#InfGMLSupport")]
    [XmlNamespacePrefixAttribute("cimInfGMLSupport")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfGMLSupport/Gml" +
        "Colour")]
    [DebuggerDisplayAttribute("GmlColour {UUID}")]
    public partial class GmlColour : IdentifiedObject, IGmlColour, IModelElement
    {
        
        /// <summary>
        /// The backing field for the Green property
        /// </summary>
        private string _green;
        
        private static Lazy<ITypedElement> _greenAttribute = new Lazy<ITypedElement>(RetrieveGreenAttribute);
        
        /// <summary>
        /// The backing field for the Red property
        /// </summary>
        private string _red;
        
        private static Lazy<ITypedElement> _redAttribute = new Lazy<ITypedElement>(RetrieveRedAttribute);
        
        /// <summary>
        /// The backing field for the Blue property
        /// </summary>
        private string _blue;
        
        private static Lazy<ITypedElement> _blueAttribute = new Lazy<ITypedElement>(RetrieveBlueAttribute);
        
        private static Lazy<ITypedElement> _gmlStrokesReference = new Lazy<ITypedElement>(RetrieveGmlStrokesReference);
        
        /// <summary>
        /// The backing field for the GmlStrokes property
        /// </summary>
        private GmlColourGmlStrokesCollection _gmlStrokes;
        
        private static Lazy<ITypedElement> _gmlFontsReference = new Lazy<ITypedElement>(RetrieveGmlFontsReference);
        
        /// <summary>
        /// The backing field for the GmlFonts property
        /// </summary>
        private GmlColourGmlFontsCollection _gmlFonts;
        
        private static Lazy<ITypedElement> _gmlFillsReference = new Lazy<ITypedElement>(RetrieveGmlFillsReference);
        
        /// <summary>
        /// The backing field for the GmlFills property
        /// </summary>
        private GmlColourGmlFillsCollection _gmlFills;
        
        private static IClass _classInstance;
        
        public GmlColour()
        {
            this._gmlStrokes = new GmlColourGmlStrokesCollection(this);
            this._gmlStrokes.CollectionChanging += this.GmlStrokesCollectionChanging;
            this._gmlStrokes.CollectionChanged += this.GmlStrokesCollectionChanged;
            this._gmlFonts = new GmlColourGmlFontsCollection(this);
            this._gmlFonts.CollectionChanging += this.GmlFontsCollectionChanging;
            this._gmlFonts.CollectionChanged += this.GmlFontsCollectionChanged;
            this._gmlFills = new GmlColourGmlFillsCollection(this);
            this._gmlFills.CollectionChanging += this.GmlFillsCollectionChanging;
            this._gmlFills.CollectionChanged += this.GmlFillsCollectionChanged;
        }
        
        /// <summary>
        /// The green property
        /// </summary>
        [XmlElementNameAttribute("green")]
        [XmlAttributeAttribute(true)]
        public virtual string Green
        {
            get
            {
                return this._green;
            }
            set
            {
                if ((this._green != value))
                {
                    string old = this._green;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnGreenChanging(e);
                    this.OnPropertyChanging("Green", e, _greenAttribute);
                    this._green = value;
                    this.OnGreenChanged(e);
                    this.OnPropertyChanged("Green", e, _greenAttribute);
                }
            }
        }
        
        /// <summary>
        /// The red property
        /// </summary>
        [XmlElementNameAttribute("red")]
        [XmlAttributeAttribute(true)]
        public virtual string Red
        {
            get
            {
                return this._red;
            }
            set
            {
                if ((this._red != value))
                {
                    string old = this._red;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnRedChanging(e);
                    this.OnPropertyChanging("Red", e, _redAttribute);
                    this._red = value;
                    this.OnRedChanged(e);
                    this.OnPropertyChanged("Red", e, _redAttribute);
                }
            }
        }
        
        /// <summary>
        /// The blue property
        /// </summary>
        [XmlElementNameAttribute("blue")]
        [XmlAttributeAttribute(true)]
        public virtual string Blue
        {
            get
            {
                return this._blue;
            }
            set
            {
                if ((this._blue != value))
                {
                    string old = this._blue;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnBlueChanging(e);
                    this.OnPropertyChanging("Blue", e, _blueAttribute);
                    this._blue = value;
                    this.OnBlueChanged(e);
                    this.OnPropertyChanged("Blue", e, _blueAttribute);
                }
            }
        }
        
        /// <summary>
        /// The GmlStrokes property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("GmlColour")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<IGmlStroke> GmlStrokes
        {
            get
            {
                return this._gmlStrokes;
            }
        }
        
        /// <summary>
        /// The GmlFonts property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("GmlColour")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<IGmlFont> GmlFonts
        {
            get
            {
                return this._gmlFonts;
            }
        }
        
        /// <summary>
        /// The GmlFills property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("GmlColour")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<IGmlFill> GmlFills
        {
            get
            {
                return this._gmlFills;
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new GmlColourReferencedElementsCollection(this));
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
                            "Colour")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the Green property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> GreenChanging;
        
        /// <summary>
        /// Gets fired when the Green property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> GreenChanged;
        
        /// <summary>
        /// Gets fired before the Red property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> RedChanging;
        
        /// <summary>
        /// Gets fired when the Red property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> RedChanged;
        
        /// <summary>
        /// Gets fired before the Blue property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> BlueChanging;
        
        /// <summary>
        /// Gets fired when the Blue property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> BlueChanged;
        
        private static ITypedElement RetrieveGreenAttribute()
        {
            return ((ITypedElement)(((ModelElement)(GmlColour.ClassInstance)).Resolve("green")));
        }
        
        /// <summary>
        /// Raises the GreenChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnGreenChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.GreenChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the GreenChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnGreenChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.GreenChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveRedAttribute()
        {
            return ((ITypedElement)(((ModelElement)(GmlColour.ClassInstance)).Resolve("red")));
        }
        
        /// <summary>
        /// Raises the RedChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnRedChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.RedChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the RedChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnRedChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.RedChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveBlueAttribute()
        {
            return ((ITypedElement)(((ModelElement)(GmlColour.ClassInstance)).Resolve("blue")));
        }
        
        /// <summary>
        /// Raises the BlueChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnBlueChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.BlueChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the BlueChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnBlueChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.BlueChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveGmlStrokesReference()
        {
            return ((ITypedElement)(((ModelElement)(GmlColour.ClassInstance)).Resolve("GmlStrokes")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the GmlStrokes property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void GmlStrokesCollectionChanging(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanging("GmlStrokes", e, _gmlStrokesReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the GmlStrokes property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void GmlStrokesCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("GmlStrokes", e, _gmlStrokesReference);
        }
        
        private static ITypedElement RetrieveGmlFontsReference()
        {
            return ((ITypedElement)(((ModelElement)(GmlColour.ClassInstance)).Resolve("GmlFonts")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the GmlFonts property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void GmlFontsCollectionChanging(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanging("GmlFonts", e, _gmlFontsReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the GmlFonts property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void GmlFontsCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("GmlFonts", e, _gmlFontsReference);
        }
        
        private static ITypedElement RetrieveGmlFillsReference()
        {
            return ((ITypedElement)(((ModelElement)(GmlColour.ClassInstance)).Resolve("GmlFills")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the GmlFills property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void GmlFillsCollectionChanging(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanging("GmlFills", e, _gmlFillsReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the GmlFills property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void GmlFillsCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("GmlFills", e, _gmlFillsReference);
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "GREEN"))
            {
                return this.Green;
            }
            if ((attribute == "RED"))
            {
                return this.Red;
            }
            if ((attribute == "BLUE"))
            {
                return this.Blue;
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
            if ((feature == "GMLSTROKES"))
            {
                return this._gmlStrokes;
            }
            if ((feature == "GMLFONTS"))
            {
                return this._gmlFonts;
            }
            if ((feature == "GMLFILLS"))
            {
                return this._gmlFills;
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
            if ((feature == "GREEN"))
            {
                this.Green = ((string)(value));
                return;
            }
            if ((feature == "RED"))
            {
                this.Red = ((string)(value));
                return;
            }
            if ((feature == "BLUE"))
            {
                this.Blue = ((string)(value));
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
                        "Colour")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the GmlColour class
        /// </summary>
        public class GmlColourReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private GmlColour _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public GmlColourReferencedElementsCollection(GmlColour parent)
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
                    count = (count + this._parent.GmlStrokes.Count);
                    count = (count + this._parent.GmlFonts.Count);
                    count = (count + this._parent.GmlFills.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.GmlStrokes.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.GmlFonts.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.GmlFills.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.GmlStrokes.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.GmlFonts.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.GmlFills.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IGmlStroke gmlStrokesCasted = item.As<IGmlStroke>();
                if ((gmlStrokesCasted != null))
                {
                    this._parent.GmlStrokes.Add(gmlStrokesCasted);
                }
                IGmlFont gmlFontsCasted = item.As<IGmlFont>();
                if ((gmlFontsCasted != null))
                {
                    this._parent.GmlFonts.Add(gmlFontsCasted);
                }
                IGmlFill gmlFillsCasted = item.As<IGmlFill>();
                if ((gmlFillsCasted != null))
                {
                    this._parent.GmlFills.Add(gmlFillsCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.GmlStrokes.Clear();
                this._parent.GmlFonts.Clear();
                this._parent.GmlFills.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.GmlStrokes.Contains(item))
                {
                    return true;
                }
                if (this._parent.GmlFonts.Contains(item))
                {
                    return true;
                }
                if (this._parent.GmlFills.Contains(item))
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
                IEnumerator<IModelElement> gmlStrokesEnumerator = this._parent.GmlStrokes.GetEnumerator();
                try
                {
                    for (
                    ; gmlStrokesEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = gmlStrokesEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    gmlStrokesEnumerator.Dispose();
                }
                IEnumerator<IModelElement> gmlFontsEnumerator = this._parent.GmlFonts.GetEnumerator();
                try
                {
                    for (
                    ; gmlFontsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = gmlFontsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    gmlFontsEnumerator.Dispose();
                }
                IEnumerator<IModelElement> gmlFillsEnumerator = this._parent.GmlFills.GetEnumerator();
                try
                {
                    for (
                    ; gmlFillsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = gmlFillsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    gmlFillsEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IGmlStroke gmlStrokeItem = item.As<IGmlStroke>();
                if (((gmlStrokeItem != null) 
                            && this._parent.GmlStrokes.Remove(gmlStrokeItem)))
                {
                    return true;
                }
                IGmlFont gmlFontItem = item.As<IGmlFont>();
                if (((gmlFontItem != null) 
                            && this._parent.GmlFonts.Remove(gmlFontItem)))
                {
                    return true;
                }
                IGmlFill gmlFillItem = item.As<IGmlFill>();
                if (((gmlFillItem != null) 
                            && this._parent.GmlFills.Remove(gmlFillItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.GmlStrokes).Concat(this._parent.GmlFonts).Concat(this._parent.GmlFills).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the green property
        /// </summary>
        private sealed class GreenProxy : ModelPropertyChange<IGmlColour, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public GreenProxy(IGmlColour modelElement) : 
                    base(modelElement, "green")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override string Value
            {
                get
                {
                    return this.ModelElement.Green;
                }
                set
                {
                    this.ModelElement.Green = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the red property
        /// </summary>
        private sealed class RedProxy : ModelPropertyChange<IGmlColour, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public RedProxy(IGmlColour modelElement) : 
                    base(modelElement, "red")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override string Value
            {
                get
                {
                    return this.ModelElement.Red;
                }
                set
                {
                    this.ModelElement.Red = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the blue property
        /// </summary>
        private sealed class BlueProxy : ModelPropertyChange<IGmlColour, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public BlueProxy(IGmlColour modelElement) : 
                    base(modelElement, "blue")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override string Value
            {
                get
                {
                    return this.ModelElement.Blue;
                }
                set
                {
                    this.ModelElement.Blue = value;
                }
            }
        }
    }
}

