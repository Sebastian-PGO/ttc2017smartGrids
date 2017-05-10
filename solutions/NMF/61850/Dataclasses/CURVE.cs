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
    /// The default implementation of the CURVE class
    /// </summary>
    [XmlNamespaceAttribute("http://www.transformation-tool-contest.eu/2017/smartGrids/dataclasses")]
    [XmlNamespacePrefixAttribute("data")]
    [ModelRepresentationClassAttribute("http://www.transformation-tool-contest.eu/2017/smartGrids/substationStandard#//Da" +
        "taclasses/CURVE")]
    public partial class CURVE : ModelElement, ICURVE, IModelElement
    {
        
        /// <summary>
        /// The backing field for the SetParA property
        /// </summary>
        private Nullable<float> _setParA;
        
        private static Lazy<ITypedElement> _setParAAttribute = new Lazy<ITypedElement>(RetrieveSetParAAttribute);
        
        /// <summary>
        /// The backing field for the SetParB property
        /// </summary>
        private Nullable<float> _setParB;
        
        private static Lazy<ITypedElement> _setParBAttribute = new Lazy<ITypedElement>(RetrieveSetParBAttribute);
        
        /// <summary>
        /// The backing field for the SetParC property
        /// </summary>
        private Nullable<float> _setParC;
        
        private static Lazy<ITypedElement> _setParCAttribute = new Lazy<ITypedElement>(RetrieveSetParCAttribute);
        
        /// <summary>
        /// The backing field for the SetParD property
        /// </summary>
        private Nullable<float> _setParD;
        
        private static Lazy<ITypedElement> _setParDAttribute = new Lazy<ITypedElement>(RetrieveSetParDAttribute);
        
        /// <summary>
        /// The backing field for the SetParE property
        /// </summary>
        private Nullable<float> _setParE;
        
        private static Lazy<ITypedElement> _setParEAttribute = new Lazy<ITypedElement>(RetrieveSetParEAttribute);
        
        /// <summary>
        /// The backing field for the SetParF property
        /// </summary>
        private Nullable<float> _setParF;
        
        private static Lazy<ITypedElement> _setParFAttribute = new Lazy<ITypedElement>(RetrieveSetParFAttribute);
        
        private static Lazy<ITypedElement> _setCharactReference = new Lazy<ITypedElement>(RetrieveSetCharactReference);
        
        /// <summary>
        /// The backing field for the SetCharact property
        /// </summary>
        private ICurveChar _setCharact;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The setParA property
        /// </summary>
        [XmlElementNameAttribute("setParA")]
        [XmlAttributeAttribute(true)]
        public virtual Nullable<float> SetParA
        {
            get
            {
                return this._setParA;
            }
            set
            {
                if ((this._setParA != value))
                {
                    Nullable<float> old = this._setParA;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnSetParAChanging(e);
                    this.OnPropertyChanging("SetParA", e, _setParAAttribute);
                    this._setParA = value;
                    this.OnSetParAChanged(e);
                    this.OnPropertyChanged("SetParA", e, _setParAAttribute);
                }
            }
        }
        
        /// <summary>
        /// The setParB property
        /// </summary>
        [XmlElementNameAttribute("setParB")]
        [XmlAttributeAttribute(true)]
        public virtual Nullable<float> SetParB
        {
            get
            {
                return this._setParB;
            }
            set
            {
                if ((this._setParB != value))
                {
                    Nullable<float> old = this._setParB;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnSetParBChanging(e);
                    this.OnPropertyChanging("SetParB", e, _setParBAttribute);
                    this._setParB = value;
                    this.OnSetParBChanged(e);
                    this.OnPropertyChanged("SetParB", e, _setParBAttribute);
                }
            }
        }
        
        /// <summary>
        /// The setParC property
        /// </summary>
        [XmlElementNameAttribute("setParC")]
        [XmlAttributeAttribute(true)]
        public virtual Nullable<float> SetParC
        {
            get
            {
                return this._setParC;
            }
            set
            {
                if ((this._setParC != value))
                {
                    Nullable<float> old = this._setParC;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnSetParCChanging(e);
                    this.OnPropertyChanging("SetParC", e, _setParCAttribute);
                    this._setParC = value;
                    this.OnSetParCChanged(e);
                    this.OnPropertyChanged("SetParC", e, _setParCAttribute);
                }
            }
        }
        
        /// <summary>
        /// The setParD property
        /// </summary>
        [XmlElementNameAttribute("setParD")]
        [XmlAttributeAttribute(true)]
        public virtual Nullable<float> SetParD
        {
            get
            {
                return this._setParD;
            }
            set
            {
                if ((this._setParD != value))
                {
                    Nullable<float> old = this._setParD;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnSetParDChanging(e);
                    this.OnPropertyChanging("SetParD", e, _setParDAttribute);
                    this._setParD = value;
                    this.OnSetParDChanged(e);
                    this.OnPropertyChanged("SetParD", e, _setParDAttribute);
                }
            }
        }
        
        /// <summary>
        /// The setParE property
        /// </summary>
        [XmlElementNameAttribute("setParE")]
        [XmlAttributeAttribute(true)]
        public virtual Nullable<float> SetParE
        {
            get
            {
                return this._setParE;
            }
            set
            {
                if ((this._setParE != value))
                {
                    Nullable<float> old = this._setParE;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnSetParEChanging(e);
                    this.OnPropertyChanging("SetParE", e, _setParEAttribute);
                    this._setParE = value;
                    this.OnSetParEChanged(e);
                    this.OnPropertyChanged("SetParE", e, _setParEAttribute);
                }
            }
        }
        
        /// <summary>
        /// The setParF property
        /// </summary>
        [XmlElementNameAttribute("setParF")]
        [XmlAttributeAttribute(true)]
        public virtual Nullable<float> SetParF
        {
            get
            {
                return this._setParF;
            }
            set
            {
                if ((this._setParF != value))
                {
                    Nullable<float> old = this._setParF;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnSetParFChanging(e);
                    this.OnPropertyChanging("SetParF", e, _setParFAttribute);
                    this._setParF = value;
                    this.OnSetParFChanged(e);
                    this.OnPropertyChanged("SetParF", e, _setParFAttribute);
                }
            }
        }
        
        /// <summary>
        /// The setCharact property
        /// </summary>
        [XmlElementNameAttribute("setCharact")]
        [XmlAttributeAttribute(true)]
        public virtual ICurveChar SetCharact
        {
            get
            {
                return this._setCharact;
            }
            set
            {
                if ((this._setCharact != value))
                {
                    ICurveChar old = this._setCharact;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnSetCharactChanging(e);
                    this.OnPropertyChanging("SetCharact", e, _setCharactReference);
                    this._setCharact = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetSetCharact;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetSetCharact;
                    }
                    this.OnSetCharactChanged(e);
                    this.OnPropertyChanged("SetCharact", e, _setCharactReference);
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
                return base.ReferencedElements.Concat(new CURVEReferencedElementsCollection(this));
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
                            "taclasses/CURVE")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the SetParA property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> SetParAChanging;
        
        /// <summary>
        /// Gets fired when the SetParA property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> SetParAChanged;
        
        /// <summary>
        /// Gets fired before the SetParB property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> SetParBChanging;
        
        /// <summary>
        /// Gets fired when the SetParB property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> SetParBChanged;
        
        /// <summary>
        /// Gets fired before the SetParC property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> SetParCChanging;
        
        /// <summary>
        /// Gets fired when the SetParC property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> SetParCChanged;
        
        /// <summary>
        /// Gets fired before the SetParD property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> SetParDChanging;
        
        /// <summary>
        /// Gets fired when the SetParD property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> SetParDChanged;
        
        /// <summary>
        /// Gets fired before the SetParE property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> SetParEChanging;
        
        /// <summary>
        /// Gets fired when the SetParE property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> SetParEChanged;
        
        /// <summary>
        /// Gets fired before the SetParF property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> SetParFChanging;
        
        /// <summary>
        /// Gets fired when the SetParF property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> SetParFChanged;
        
        /// <summary>
        /// Gets fired before the SetCharact property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> SetCharactChanging;
        
        /// <summary>
        /// Gets fired when the SetCharact property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> SetCharactChanged;
        
        private static ITypedElement RetrieveSetParAAttribute()
        {
            return ((ITypedElement)(((ModelElement)(CURVE.ClassInstance)).Resolve("setParA")));
        }
        
        /// <summary>
        /// Raises the SetParAChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnSetParAChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.SetParAChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the SetParAChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnSetParAChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.SetParAChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveSetParBAttribute()
        {
            return ((ITypedElement)(((ModelElement)(CURVE.ClassInstance)).Resolve("setParB")));
        }
        
        /// <summary>
        /// Raises the SetParBChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnSetParBChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.SetParBChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the SetParBChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnSetParBChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.SetParBChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveSetParCAttribute()
        {
            return ((ITypedElement)(((ModelElement)(CURVE.ClassInstance)).Resolve("setParC")));
        }
        
        /// <summary>
        /// Raises the SetParCChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnSetParCChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.SetParCChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the SetParCChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnSetParCChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.SetParCChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveSetParDAttribute()
        {
            return ((ITypedElement)(((ModelElement)(CURVE.ClassInstance)).Resolve("setParD")));
        }
        
        /// <summary>
        /// Raises the SetParDChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnSetParDChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.SetParDChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the SetParDChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnSetParDChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.SetParDChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveSetParEAttribute()
        {
            return ((ITypedElement)(((ModelElement)(CURVE.ClassInstance)).Resolve("setParE")));
        }
        
        /// <summary>
        /// Raises the SetParEChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnSetParEChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.SetParEChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the SetParEChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnSetParEChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.SetParEChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveSetParFAttribute()
        {
            return ((ITypedElement)(((ModelElement)(CURVE.ClassInstance)).Resolve("setParF")));
        }
        
        /// <summary>
        /// Raises the SetParFChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnSetParFChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.SetParFChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the SetParFChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnSetParFChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.SetParFChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveSetCharactReference()
        {
            return ((ITypedElement)(((ModelElement)(CURVE.ClassInstance)).Resolve("setCharact")));
        }
        
        /// <summary>
        /// Raises the SetCharactChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnSetCharactChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.SetCharactChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the SetCharactChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnSetCharactChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.SetCharactChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the SetCharact property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetSetCharact(object sender, System.EventArgs eventArgs)
        {
            this.SetCharact = null;
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "SETPARA"))
            {
                return this.SetParA;
            }
            if ((attribute == "SETPARB"))
            {
                return this.SetParB;
            }
            if ((attribute == "SETPARC"))
            {
                return this.SetParC;
            }
            if ((attribute == "SETPARD"))
            {
                return this.SetParD;
            }
            if ((attribute == "SETPARE"))
            {
                return this.SetParE;
            }
            if ((attribute == "SETPARF"))
            {
                return this.SetParF;
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
            if ((feature == "SETCHARACT"))
            {
                this.SetCharact = ((ICurveChar)(value));
                return;
            }
            if ((feature == "SETPARA"))
            {
                this.SetParA = ((float)(value));
                return;
            }
            if ((feature == "SETPARB"))
            {
                this.SetParB = ((float)(value));
                return;
            }
            if ((feature == "SETPARC"))
            {
                this.SetParC = ((float)(value));
                return;
            }
            if ((feature == "SETPARD"))
            {
                this.SetParD = ((float)(value));
                return;
            }
            if ((feature == "SETPARE"))
            {
                this.SetParE = ((float)(value));
                return;
            }
            if ((feature == "SETPARF"))
            {
                this.SetParF = ((float)(value));
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
            if ((attribute == "SetCharact"))
            {
                return new SetCharactProxy(this);
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
            if ((reference == "SetCharact"))
            {
                return new SetCharactProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://www.transformation-tool-contest.eu/2017/smartGrids/substationStandard#//Da" +
                        "taclasses/CURVE")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the CURVE class
        /// </summary>
        public class CURVEReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private CURVE _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public CURVEReferencedElementsCollection(CURVE parent)
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
                    if ((this._parent.SetCharact != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.SetCharactChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.SetCharactChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.SetCharact == null))
                {
                    ICurveChar setCharactCasted = item.As<ICurveChar>();
                    if ((setCharactCasted != null))
                    {
                        this._parent.SetCharact = setCharactCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.SetCharact = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.SetCharact))
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
                if ((this._parent.SetCharact != null))
                {
                    array[arrayIndex] = this._parent.SetCharact;
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
                if ((this._parent.SetCharact == item))
                {
                    this._parent.SetCharact = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.SetCharact).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the setParA property
        /// </summary>
        private sealed class SetParAProxy : ModelPropertyChange<ICURVE, Nullable<float>>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public SetParAProxy(ICURVE modelElement) : 
                    base(modelElement, "setParA")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override Nullable<float> Value
            {
                get
                {
                    return this.ModelElement.SetParA;
                }
                set
                {
                    this.ModelElement.SetParA = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the setParB property
        /// </summary>
        private sealed class SetParBProxy : ModelPropertyChange<ICURVE, Nullable<float>>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public SetParBProxy(ICURVE modelElement) : 
                    base(modelElement, "setParB")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override Nullable<float> Value
            {
                get
                {
                    return this.ModelElement.SetParB;
                }
                set
                {
                    this.ModelElement.SetParB = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the setParC property
        /// </summary>
        private sealed class SetParCProxy : ModelPropertyChange<ICURVE, Nullable<float>>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public SetParCProxy(ICURVE modelElement) : 
                    base(modelElement, "setParC")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override Nullable<float> Value
            {
                get
                {
                    return this.ModelElement.SetParC;
                }
                set
                {
                    this.ModelElement.SetParC = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the setParD property
        /// </summary>
        private sealed class SetParDProxy : ModelPropertyChange<ICURVE, Nullable<float>>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public SetParDProxy(ICURVE modelElement) : 
                    base(modelElement, "setParD")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override Nullable<float> Value
            {
                get
                {
                    return this.ModelElement.SetParD;
                }
                set
                {
                    this.ModelElement.SetParD = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the setParE property
        /// </summary>
        private sealed class SetParEProxy : ModelPropertyChange<ICURVE, Nullable<float>>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public SetParEProxy(ICURVE modelElement) : 
                    base(modelElement, "setParE")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override Nullable<float> Value
            {
                get
                {
                    return this.ModelElement.SetParE;
                }
                set
                {
                    this.ModelElement.SetParE = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the setParF property
        /// </summary>
        private sealed class SetParFProxy : ModelPropertyChange<ICURVE, Nullable<float>>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public SetParFProxy(ICURVE modelElement) : 
                    base(modelElement, "setParF")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override Nullable<float> Value
            {
                get
                {
                    return this.ModelElement.SetParF;
                }
                set
                {
                    this.ModelElement.SetParF = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the setCharact property
        /// </summary>
        private sealed class SetCharactProxy : ModelPropertyChange<ICURVE, ICurveChar>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public SetCharactProxy(ICURVE modelElement) : 
                    base(modelElement, "setCharact")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override ICurveChar Value
            {
                get
                {
                    return this.ModelElement.SetCharact;
                }
                set
                {
                    this.ModelElement.SetCharact = value;
                }
            }
        }
    }
}
