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
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Generation.Production;
using TTC2017.SmartGrids.CIM.IEC61970.LoadModel;
using TTC2017.SmartGrids.CIM.IEC61970.Meas;

namespace TTC2017.SmartGrids.CIM.IEC61970.ControlArea
{
    
    
    /// <summary>
    /// The default implementation of the ControlAreaGeneratingUnit class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#ControlArea")]
    [XmlNamespacePrefixAttribute("cimControlArea")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/ControlArea/ControlAreaGenera" +
        "tingUnit")]
    [DebuggerDisplayAttribute("ControlAreaGeneratingUnit {UUID}")]
    public partial class ControlAreaGeneratingUnit : Element, IControlAreaGeneratingUnit, IModelElement
    {
        
        private static Lazy<ITypedElement> _controlAreaReference = new Lazy<ITypedElement>(RetrieveControlAreaReference);
        
        /// <summary>
        /// The backing field for the ControlArea property
        /// </summary>
        private IControlArea _controlArea;
        
        private static Lazy<ITypedElement> _altGeneratingUnitMeasReference = new Lazy<ITypedElement>(RetrieveAltGeneratingUnitMeasReference);
        
        /// <summary>
        /// The backing field for the AltGeneratingUnitMeas property
        /// </summary>
        private ControlAreaGeneratingUnitAltGeneratingUnitMeasCollection _altGeneratingUnitMeas;
        
        private static Lazy<ITypedElement> _generatingUnitReference = new Lazy<ITypedElement>(RetrieveGeneratingUnitReference);
        
        /// <summary>
        /// The backing field for the GeneratingUnit property
        /// </summary>
        private IGeneratingUnit _generatingUnit;
        
        private static IClass _classInstance;
        
        public ControlAreaGeneratingUnit()
        {
            this._altGeneratingUnitMeas = new ControlAreaGeneratingUnitAltGeneratingUnitMeasCollection(this);
            this._altGeneratingUnitMeas.CollectionChanging += this.AltGeneratingUnitMeasCollectionChanging;
            this._altGeneratingUnitMeas.CollectionChanged += this.AltGeneratingUnitMeasCollectionChanged;
        }
        
        /// <summary>
        /// The ControlArea property
        /// </summary>
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("ControlAreaGeneratingUnit")]
        public virtual IControlArea ControlArea
        {
            get
            {
                return this._controlArea;
            }
            set
            {
                if ((this._controlArea != value))
                {
                    IControlArea old = this._controlArea;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnControlAreaChanging(e);
                    this.OnPropertyChanging("ControlArea", e, _controlAreaReference);
                    this._controlArea = value;
                    if ((old != null))
                    {
                        old.ControlAreaGeneratingUnit.Remove(this);
                        old.Deleted -= this.OnResetControlArea;
                    }
                    if ((value != null))
                    {
                        value.ControlAreaGeneratingUnit.Add(this);
                        value.Deleted += this.OnResetControlArea;
                    }
                    this.OnControlAreaChanged(e);
                    this.OnPropertyChanged("ControlArea", e, _controlAreaReference);
                }
            }
        }
        
        /// <summary>
        /// The AltGeneratingUnitMeas property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("ControlAreaGeneratingUnit")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<IAltGeneratingUnitMeas> AltGeneratingUnitMeas
        {
            get
            {
                return this._altGeneratingUnitMeas;
            }
        }
        
        /// <summary>
        /// The GeneratingUnit property
        /// </summary>
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("ControlAreaGeneratingUnit")]
        public virtual IGeneratingUnit GeneratingUnit
        {
            get
            {
                return this._generatingUnit;
            }
            set
            {
                if ((this._generatingUnit != value))
                {
                    IGeneratingUnit old = this._generatingUnit;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnGeneratingUnitChanging(e);
                    this.OnPropertyChanging("GeneratingUnit", e, _generatingUnitReference);
                    this._generatingUnit = value;
                    if ((old != null))
                    {
                        old.ControlAreaGeneratingUnit.Remove(this);
                        old.Deleted -= this.OnResetGeneratingUnit;
                    }
                    if ((value != null))
                    {
                        value.ControlAreaGeneratingUnit.Add(this);
                        value.Deleted += this.OnResetGeneratingUnit;
                    }
                    this.OnGeneratingUnitChanged(e);
                    this.OnPropertyChanged("GeneratingUnit", e, _generatingUnitReference);
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
                return base.ReferencedElements.Concat(new ControlAreaGeneratingUnitReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/ControlArea/ControlAreaGenera" +
                            "tingUnit")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the ControlArea property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ControlAreaChanging;
        
        /// <summary>
        /// Gets fired when the ControlArea property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ControlAreaChanged;
        
        /// <summary>
        /// Gets fired before the GeneratingUnit property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> GeneratingUnitChanging;
        
        /// <summary>
        /// Gets fired when the GeneratingUnit property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> GeneratingUnitChanged;
        
        private static ITypedElement RetrieveControlAreaReference()
        {
            return ((ITypedElement)(((ModelElement)(ControlAreaGeneratingUnit.ClassInstance)).Resolve("ControlArea")));
        }
        
        /// <summary>
        /// Raises the ControlAreaChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnControlAreaChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ControlAreaChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the ControlAreaChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnControlAreaChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ControlAreaChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the ControlArea property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetControlArea(object sender, System.EventArgs eventArgs)
        {
            this.ControlArea = null;
        }
        
        private static ITypedElement RetrieveAltGeneratingUnitMeasReference()
        {
            return ((ITypedElement)(((ModelElement)(ControlAreaGeneratingUnit.ClassInstance)).Resolve("AltGeneratingUnitMeas")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the AltGeneratingUnitMeas property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void AltGeneratingUnitMeasCollectionChanging(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanging("AltGeneratingUnitMeas", e, _altGeneratingUnitMeasReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the AltGeneratingUnitMeas property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void AltGeneratingUnitMeasCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("AltGeneratingUnitMeas", e, _altGeneratingUnitMeasReference);
        }
        
        private static ITypedElement RetrieveGeneratingUnitReference()
        {
            return ((ITypedElement)(((ModelElement)(ControlAreaGeneratingUnit.ClassInstance)).Resolve("GeneratingUnit")));
        }
        
        /// <summary>
        /// Raises the GeneratingUnitChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnGeneratingUnitChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.GeneratingUnitChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the GeneratingUnitChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnGeneratingUnitChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.GeneratingUnitChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the GeneratingUnit property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetGeneratingUnit(object sender, System.EventArgs eventArgs)
        {
            this.GeneratingUnit = null;
        }
        
        /// <summary>
        /// Gets the Model element collection for the given feature
        /// </summary>
        /// <returns>A non-generic list of elements</returns>
        /// <param name="feature">The requested feature</param>
        protected override System.Collections.IList GetCollectionForFeature(string feature)
        {
            if ((feature == "ALTGENERATINGUNITMEAS"))
            {
                return this._altGeneratingUnitMeas;
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
            if ((feature == "CONTROLAREA"))
            {
                this.ControlArea = ((IControlArea)(value));
                return;
            }
            if ((feature == "GENERATINGUNIT"))
            {
                this.GeneratingUnit = ((IGeneratingUnit)(value));
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
            if ((attribute == "ControlArea"))
            {
                return new ControlAreaProxy(this);
            }
            if ((attribute == "GeneratingUnit"))
            {
                return new GeneratingUnitProxy(this);
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
            if ((reference == "ControlArea"))
            {
                return new ControlAreaProxy(this);
            }
            if ((reference == "GeneratingUnit"))
            {
                return new GeneratingUnitProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/ControlArea/ControlAreaGenera" +
                        "tingUnit")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the ControlAreaGeneratingUnit class
        /// </summary>
        public class ControlAreaGeneratingUnitReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private ControlAreaGeneratingUnit _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public ControlAreaGeneratingUnitReferencedElementsCollection(ControlAreaGeneratingUnit parent)
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
                    if ((this._parent.ControlArea != null))
                    {
                        count = (count + 1);
                    }
                    count = (count + this._parent.AltGeneratingUnitMeas.Count);
                    if ((this._parent.GeneratingUnit != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.ControlAreaChanged += this.PropagateValueChanges;
                this._parent.AltGeneratingUnitMeas.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.GeneratingUnitChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.ControlAreaChanged -= this.PropagateValueChanges;
                this._parent.AltGeneratingUnitMeas.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.GeneratingUnitChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.ControlArea == null))
                {
                    IControlArea controlAreaCasted = item.As<IControlArea>();
                    if ((controlAreaCasted != null))
                    {
                        this._parent.ControlArea = controlAreaCasted;
                        return;
                    }
                }
                IAltGeneratingUnitMeas altGeneratingUnitMeasCasted = item.As<IAltGeneratingUnitMeas>();
                if ((altGeneratingUnitMeasCasted != null))
                {
                    this._parent.AltGeneratingUnitMeas.Add(altGeneratingUnitMeasCasted);
                }
                if ((this._parent.GeneratingUnit == null))
                {
                    IGeneratingUnit generatingUnitCasted = item.As<IGeneratingUnit>();
                    if ((generatingUnitCasted != null))
                    {
                        this._parent.GeneratingUnit = generatingUnitCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.ControlArea = null;
                this._parent.AltGeneratingUnitMeas.Clear();
                this._parent.GeneratingUnit = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.ControlArea))
                {
                    return true;
                }
                if (this._parent.AltGeneratingUnitMeas.Contains(item))
                {
                    return true;
                }
                if ((item == this._parent.GeneratingUnit))
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
                if ((this._parent.ControlArea != null))
                {
                    array[arrayIndex] = this._parent.ControlArea;
                    arrayIndex = (arrayIndex + 1);
                }
                IEnumerator<IModelElement> altGeneratingUnitMeasEnumerator = this._parent.AltGeneratingUnitMeas.GetEnumerator();
                try
                {
                    for (
                    ; altGeneratingUnitMeasEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = altGeneratingUnitMeasEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    altGeneratingUnitMeasEnumerator.Dispose();
                }
                if ((this._parent.GeneratingUnit != null))
                {
                    array[arrayIndex] = this._parent.GeneratingUnit;
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
                if ((this._parent.ControlArea == item))
                {
                    this._parent.ControlArea = null;
                    return true;
                }
                IAltGeneratingUnitMeas altGeneratingUnitMeasItem = item.As<IAltGeneratingUnitMeas>();
                if (((altGeneratingUnitMeasItem != null) 
                            && this._parent.AltGeneratingUnitMeas.Remove(altGeneratingUnitMeasItem)))
                {
                    return true;
                }
                if ((this._parent.GeneratingUnit == item))
                {
                    this._parent.GeneratingUnit = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.ControlArea).Concat(this._parent.AltGeneratingUnitMeas).Concat(this._parent.GeneratingUnit).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the ControlArea property
        /// </summary>
        private sealed class ControlAreaProxy : ModelPropertyChange<IControlAreaGeneratingUnit, IControlArea>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public ControlAreaProxy(IControlAreaGeneratingUnit modelElement) : 
                    base(modelElement, "ControlArea")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IControlArea Value
            {
                get
                {
                    return this.ModelElement.ControlArea;
                }
                set
                {
                    this.ModelElement.ControlArea = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the GeneratingUnit property
        /// </summary>
        private sealed class GeneratingUnitProxy : ModelPropertyChange<IControlAreaGeneratingUnit, IGeneratingUnit>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public GeneratingUnitProxy(IControlAreaGeneratingUnit modelElement) : 
                    base(modelElement, "GeneratingUnit")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IGeneratingUnit Value
            {
                get
                {
                    return this.ModelElement.GeneratingUnit;
                }
                set
                {
                    this.ModelElement.GeneratingUnit = value;
                }
            }
        }
    }
}

