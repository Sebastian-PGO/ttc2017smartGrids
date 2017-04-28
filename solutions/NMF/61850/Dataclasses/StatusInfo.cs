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
    /// The default implementation of the StatusInfo class
    /// </summary>
    [XmlNamespaceAttribute("http://www.transformation-tool-contest.eu/2017/smartGrids/dataclasses")]
    [XmlNamespacePrefixAttribute("data")]
    [ModelRepresentationClassAttribute("http://www.transformation-tool-contest.eu/2017/smartGrids/substationStandard#//Da" +
        "taclasses/StatusInfo")]
    public partial class StatusInfo : ModelElement, IStatusInfo, IModelElement
    {
        
        /// <summary>
        /// The backing field for the D property
        /// </summary>
        private string _d;
        
        private static Lazy<ITypedElement> _dAttribute = new Lazy<ITypedElement>(RetrieveDAttribute);
        
        /// <summary>
        /// The backing field for the DU property
        /// </summary>
        private string _dU;
        
        private static Lazy<ITypedElement> _dUAttribute = new Lazy<ITypedElement>(RetrieveDUAttribute);
        
        private static Lazy<ITypedElement> _tReference = new Lazy<ITypedElement>(RetrieveTReference);
        
        /// <summary>
        /// The backing field for the T property
        /// </summary>
        private ITimeStamp _t;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The d property
        /// </summary>
        [XmlElementNameAttribute("d")]
        [XmlAttributeAttribute(true)]
        public virtual string D
        {
            get
            {
                return this._d;
            }
            set
            {
                if ((this._d != value))
                {
                    string old = this._d;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnDChanging(e);
                    this.OnPropertyChanging("D", e, _dAttribute);
                    this._d = value;
                    this.OnDChanged(e);
                    this.OnPropertyChanged("D", e, _dAttribute);
                }
            }
        }
        
        /// <summary>
        /// The dU property
        /// </summary>
        [XmlElementNameAttribute("dU")]
        [XmlAttributeAttribute(true)]
        public virtual string DU
        {
            get
            {
                return this._dU;
            }
            set
            {
                if ((this._dU != value))
                {
                    string old = this._dU;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnDUChanging(e);
                    this.OnPropertyChanging("DU", e, _dUAttribute);
                    this._dU = value;
                    this.OnDUChanged(e);
                    this.OnPropertyChanged("DU", e, _dUAttribute);
                }
            }
        }
        
        /// <summary>
        /// The t property
        /// </summary>
        [XmlElementNameAttribute("t")]
        [XmlAttributeAttribute(true)]
        public virtual ITimeStamp T
        {
            get
            {
                return this._t;
            }
            set
            {
                if ((this._t != value))
                {
                    ITimeStamp old = this._t;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnTChanging(e);
                    this.OnPropertyChanging("T", e, _tReference);
                    this._t = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetT;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetT;
                    }
                    this.OnTChanged(e);
                    this.OnPropertyChanged("T", e, _tReference);
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
                return base.ReferencedElements.Concat(new StatusInfoReferencedElementsCollection(this));
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
                            "taclasses/StatusInfo")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the D property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> DChanging;
        
        /// <summary>
        /// Gets fired when the D property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> DChanged;
        
        /// <summary>
        /// Gets fired before the DU property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> DUChanging;
        
        /// <summary>
        /// Gets fired when the DU property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> DUChanged;
        
        /// <summary>
        /// Gets fired before the T property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> TChanging;
        
        /// <summary>
        /// Gets fired when the T property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> TChanged;
        
        private static ITypedElement RetrieveDAttribute()
        {
            return ((ITypedElement)(((ModelElement)(StatusInfo.ClassInstance)).Resolve("d")));
        }
        
        /// <summary>
        /// Raises the DChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnDChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.DChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the DChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnDChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.DChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveDUAttribute()
        {
            return ((ITypedElement)(((ModelElement)(StatusInfo.ClassInstance)).Resolve("dU")));
        }
        
        /// <summary>
        /// Raises the DUChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnDUChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.DUChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the DUChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnDUChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.DUChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveTReference()
        {
            return ((ITypedElement)(((ModelElement)(StatusInfo.ClassInstance)).Resolve("t")));
        }
        
        /// <summary>
        /// Raises the TChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnTChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.TChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the TChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnTChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.TChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the T property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetT(object sender, System.EventArgs eventArgs)
        {
            this.T = null;
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "D"))
            {
                return this.D;
            }
            if ((attribute == "DU"))
            {
                return this.DU;
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
            if ((feature == "T"))
            {
                this.T = ((ITimeStamp)(value));
                return;
            }
            if ((feature == "D"))
            {
                this.D = ((string)(value));
                return;
            }
            if ((feature == "DU"))
            {
                this.DU = ((string)(value));
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
            if ((attribute == "T"))
            {
                return new TProxy(this);
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
            if ((reference == "T"))
            {
                return new TProxy(this);
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
                        "taclasses/StatusInfo")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the StatusInfo class
        /// </summary>
        public class StatusInfoReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private StatusInfo _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public StatusInfoReferencedElementsCollection(StatusInfo parent)
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
                    if ((this._parent.T != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.TChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.TChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.T == null))
                {
                    ITimeStamp tCasted = item.As<ITimeStamp>();
                    if ((tCasted != null))
                    {
                        this._parent.T = tCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.T = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.T))
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
                if ((this._parent.T != null))
                {
                    array[arrayIndex] = this._parent.T;
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
                if ((this._parent.T == item))
                {
                    this._parent.T = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.T).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the d property
        /// </summary>
        private sealed class DProxy : ModelPropertyChange<IStatusInfo, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public DProxy(IStatusInfo modelElement) : 
                    base(modelElement, "d")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override string Value
            {
                get
                {
                    return this.ModelElement.D;
                }
                set
                {
                    this.ModelElement.D = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the dU property
        /// </summary>
        private sealed class DUProxy : ModelPropertyChange<IStatusInfo, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public DUProxy(IStatusInfo modelElement) : 
                    base(modelElement, "dU")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override string Value
            {
                get
                {
                    return this.ModelElement.DU;
                }
                set
                {
                    this.ModelElement.DU = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the t property
        /// </summary>
        private sealed class TProxy : ModelPropertyChange<IStatusInfo, ITimeStamp>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public TProxy(IStatusInfo modelElement) : 
                    base(modelElement, "t")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override ITimeStamp Value
            {
                get
                {
                    return this.ModelElement.T;
                }
                set
                {
                    this.ModelElement.T = value;
                }
            }
        }
    }
}

