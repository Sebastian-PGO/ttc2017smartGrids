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
    /// The default implementation of the GmlMark class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#InfGMLSupport")]
    [XmlNamespacePrefixAttribute("cimInfGMLSupport")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfGMLSupport/Gml" +
        "Mark")]
    [DebuggerDisplayAttribute("GmlMark {UUID}")]
    public partial class GmlMark : IdentifiedObject, IGmlMark, IModelElement
    {
        
        /// <summary>
        /// The backing field for the WellKnownName property
        /// </summary>
        private string _wellKnownName;
        
        private static Lazy<ITypedElement> _wellKnownNameAttribute = new Lazy<ITypedElement>(RetrieveWellKnownNameAttribute);
        
        private static Lazy<ITypedElement> _gmlGraphicsReference = new Lazy<ITypedElement>(RetrieveGmlGraphicsReference);
        
        /// <summary>
        /// The backing field for the GmlGraphics property
        /// </summary>
        private GmlMarkGmlGraphicsCollection _gmlGraphics;
        
        private static Lazy<ITypedElement> _gmlFIllsReference = new Lazy<ITypedElement>(RetrieveGmlFIllsReference);
        
        /// <summary>
        /// The backing field for the GmlFIlls property
        /// </summary>
        private GmlMarkGmlFIllsCollection _gmlFIlls;
        
        private static Lazy<ITypedElement> _gmlStrokesReference = new Lazy<ITypedElement>(RetrieveGmlStrokesReference);
        
        /// <summary>
        /// The backing field for the GmlStrokes property
        /// </summary>
        private GmlMarkGmlStrokesCollection _gmlStrokes;
        
        private static IClass _classInstance;
        
        public GmlMark()
        {
            this._gmlGraphics = new GmlMarkGmlGraphicsCollection(this);
            this._gmlGraphics.CollectionChanging += this.GmlGraphicsCollectionChanging;
            this._gmlGraphics.CollectionChanged += this.GmlGraphicsCollectionChanged;
            this._gmlFIlls = new GmlMarkGmlFIllsCollection(this);
            this._gmlFIlls.CollectionChanging += this.GmlFIllsCollectionChanging;
            this._gmlFIlls.CollectionChanged += this.GmlFIllsCollectionChanged;
            this._gmlStrokes = new GmlMarkGmlStrokesCollection(this);
            this._gmlStrokes.CollectionChanging += this.GmlStrokesCollectionChanging;
            this._gmlStrokes.CollectionChanged += this.GmlStrokesCollectionChanged;
        }
        
        /// <summary>
        /// The wellKnownName property
        /// </summary>
        [XmlElementNameAttribute("wellKnownName")]
        [XmlAttributeAttribute(true)]
        public virtual string WellKnownName
        {
            get
            {
                return this._wellKnownName;
            }
            set
            {
                if ((this._wellKnownName != value))
                {
                    string old = this._wellKnownName;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnWellKnownNameChanging(e);
                    this.OnPropertyChanging("WellKnownName", e, _wellKnownNameAttribute);
                    this._wellKnownName = value;
                    this.OnWellKnownNameChanged(e);
                    this.OnPropertyChanged("WellKnownName", e, _wellKnownNameAttribute);
                }
            }
        }
        
        /// <summary>
        /// The GmlGraphics property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("GmlMarks")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<IGmlGraphic> GmlGraphics
        {
            get
            {
                return this._gmlGraphics;
            }
        }
        
        /// <summary>
        /// The GmlFIlls property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("GmlMarks")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<IGmlFill> GmlFIlls
        {
            get
            {
                return this._gmlFIlls;
            }
        }
        
        /// <summary>
        /// The GmlStrokes property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("GmlMarks")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<IGmlStroke> GmlStrokes
        {
            get
            {
                return this._gmlStrokes;
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new GmlMarkReferencedElementsCollection(this));
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
                            "Mark")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the WellKnownName property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> WellKnownNameChanging;
        
        /// <summary>
        /// Gets fired when the WellKnownName property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> WellKnownNameChanged;
        
        private static ITypedElement RetrieveWellKnownNameAttribute()
        {
            return ((ITypedElement)(((ModelElement)(GmlMark.ClassInstance)).Resolve("wellKnownName")));
        }
        
        /// <summary>
        /// Raises the WellKnownNameChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnWellKnownNameChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.WellKnownNameChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the WellKnownNameChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnWellKnownNameChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.WellKnownNameChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveGmlGraphicsReference()
        {
            return ((ITypedElement)(((ModelElement)(GmlMark.ClassInstance)).Resolve("GmlGraphics")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the GmlGraphics property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void GmlGraphicsCollectionChanging(object sender, NMF.Collections.ObjectModel.NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("GmlGraphics", e, _gmlGraphicsReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the GmlGraphics property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void GmlGraphicsCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("GmlGraphics", e, _gmlGraphicsReference);
        }
        
        private static ITypedElement RetrieveGmlFIllsReference()
        {
            return ((ITypedElement)(((ModelElement)(GmlMark.ClassInstance)).Resolve("GmlFIlls")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the GmlFIlls property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void GmlFIllsCollectionChanging(object sender, NMF.Collections.ObjectModel.NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("GmlFIlls", e, _gmlFIllsReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the GmlFIlls property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void GmlFIllsCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("GmlFIlls", e, _gmlFIllsReference);
        }
        
        private static ITypedElement RetrieveGmlStrokesReference()
        {
            return ((ITypedElement)(((ModelElement)(GmlMark.ClassInstance)).Resolve("GmlStrokes")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the GmlStrokes property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void GmlStrokesCollectionChanging(object sender, NMF.Collections.ObjectModel.NotifyCollectionChangingEventArgs e)
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
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "WELLKNOWNNAME"))
            {
                return this.WellKnownName;
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
            if ((feature == "GMLGRAPHICS"))
            {
                return this._gmlGraphics;
            }
            if ((feature == "GMLFILLS"))
            {
                return this._gmlFIlls;
            }
            if ((feature == "GMLSTROKES"))
            {
                return this._gmlStrokes;
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
            if ((feature == "WELLKNOWNNAME"))
            {
                this.WellKnownName = ((string)(value));
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
                        "Mark")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the GmlMark class
        /// </summary>
        public class GmlMarkReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private GmlMark _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public GmlMarkReferencedElementsCollection(GmlMark parent)
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
                    count = (count + this._parent.GmlGraphics.Count);
                    count = (count + this._parent.GmlFIlls.Count);
                    count = (count + this._parent.GmlStrokes.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.GmlGraphics.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.GmlFIlls.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.GmlStrokes.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.GmlGraphics.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.GmlFIlls.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.GmlStrokes.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IGmlGraphic gmlGraphicsCasted = item.As<IGmlGraphic>();
                if ((gmlGraphicsCasted != null))
                {
                    this._parent.GmlGraphics.Add(gmlGraphicsCasted);
                }
                IGmlFill gmlFIllsCasted = item.As<IGmlFill>();
                if ((gmlFIllsCasted != null))
                {
                    this._parent.GmlFIlls.Add(gmlFIllsCasted);
                }
                IGmlStroke gmlStrokesCasted = item.As<IGmlStroke>();
                if ((gmlStrokesCasted != null))
                {
                    this._parent.GmlStrokes.Add(gmlStrokesCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.GmlGraphics.Clear();
                this._parent.GmlFIlls.Clear();
                this._parent.GmlStrokes.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.GmlGraphics.Contains(item))
                {
                    return true;
                }
                if (this._parent.GmlFIlls.Contains(item))
                {
                    return true;
                }
                if (this._parent.GmlStrokes.Contains(item))
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
                IEnumerator<IModelElement> gmlGraphicsEnumerator = this._parent.GmlGraphics.GetEnumerator();
                try
                {
                    for (
                    ; gmlGraphicsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = gmlGraphicsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    gmlGraphicsEnumerator.Dispose();
                }
                IEnumerator<IModelElement> gmlFIllsEnumerator = this._parent.GmlFIlls.GetEnumerator();
                try
                {
                    for (
                    ; gmlFIllsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = gmlFIllsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    gmlFIllsEnumerator.Dispose();
                }
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
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IGmlGraphic gmlGraphicItem = item.As<IGmlGraphic>();
                if (((gmlGraphicItem != null) 
                            && this._parent.GmlGraphics.Remove(gmlGraphicItem)))
                {
                    return true;
                }
                IGmlFill gmlFillItem = item.As<IGmlFill>();
                if (((gmlFillItem != null) 
                            && this._parent.GmlFIlls.Remove(gmlFillItem)))
                {
                    return true;
                }
                IGmlStroke gmlStrokeItem = item.As<IGmlStroke>();
                if (((gmlStrokeItem != null) 
                            && this._parent.GmlStrokes.Remove(gmlStrokeItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.GmlGraphics).Concat(this._parent.GmlFIlls).Concat(this._parent.GmlStrokes).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the wellKnownName property
        /// </summary>
        private sealed class WellKnownNameProxy : ModelPropertyChange<IGmlMark, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public WellKnownNameProxy(IGmlMark modelElement) : 
                    base(modelElement, "wellKnownName")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override string Value
            {
                get
                {
                    return this.ModelElement.WellKnownName;
                }
                set
                {
                    this.ModelElement.WellKnownName = value;
                }
            }
        }
    }
}

