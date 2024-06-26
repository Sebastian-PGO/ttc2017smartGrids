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
using TTC2017.SmartGrids.SubstationStandard.Dataclasses;
using TTC2017.SmartGrids.SubstationStandard.LNNodes.DomainLNs;

namespace TTC2017.SmartGrids.SubstationStandard.LNNodes.LNGroupC
{
    
    
    /// <summary>
    /// The default implementation of the CALH class
    /// </summary>
    [XmlNamespaceAttribute("http://www.transformation-tool-contest.eu/2017/smartGrids/substationStandard/grou" +
        "pC")]
    [XmlNamespacePrefixAttribute("groupc")]
    [ModelRepresentationClassAttribute("http://www.transformation-tool-contest.eu/2017/smartGrids/substationStandard#//LN" +
        "Nodes/LNGroupC/CALH")]
    public partial class CALH : TTC2017.SmartGrids.SubstationStandard.LNNodes.LNGroupC.GroupC, ICALH, IModelElement
    {
        
        private static Lazy<ITypedElement> _grAlmReference = new Lazy<ITypedElement>(RetrieveGrAlmReference);
        
        /// <summary>
        /// The backing field for the GrAlm property
        /// </summary>
        private ISPS _grAlm;
        
        private static Lazy<ITypedElement> _grWrnReference = new Lazy<ITypedElement>(RetrieveGrWrnReference);
        
        /// <summary>
        /// The backing field for the GrWrn property
        /// </summary>
        private ISPS _grWrn;
        
        private static Lazy<ITypedElement> _almLstOvReference = new Lazy<ITypedElement>(RetrieveAlmLstOvReference);
        
        /// <summary>
        /// The backing field for the AlmLstOv property
        /// </summary>
        private ISPS _almLstOv;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The GrAlm property
        /// </summary>
        [XmlAttributeAttribute(true)]
        public virtual ISPS GrAlm
        {
            get
            {
                return this._grAlm;
            }
            set
            {
                if ((this._grAlm != value))
                {
                    ISPS old = this._grAlm;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnGrAlmChanging(e);
                    this.OnPropertyChanging("GrAlm", e, _grAlmReference);
                    this._grAlm = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetGrAlm;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetGrAlm;
                    }
                    this.OnGrAlmChanged(e);
                    this.OnPropertyChanged("GrAlm", e, _grAlmReference);
                }
            }
        }
        
        /// <summary>
        /// The GrWrn property
        /// </summary>
        [XmlAttributeAttribute(true)]
        public virtual ISPS GrWrn
        {
            get
            {
                return this._grWrn;
            }
            set
            {
                if ((this._grWrn != value))
                {
                    ISPS old = this._grWrn;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnGrWrnChanging(e);
                    this.OnPropertyChanging("GrWrn", e, _grWrnReference);
                    this._grWrn = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetGrWrn;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetGrWrn;
                    }
                    this.OnGrWrnChanged(e);
                    this.OnPropertyChanged("GrWrn", e, _grWrnReference);
                }
            }
        }
        
        /// <summary>
        /// The AlmLstOv property
        /// </summary>
        [XmlAttributeAttribute(true)]
        public virtual ISPS AlmLstOv
        {
            get
            {
                return this._almLstOv;
            }
            set
            {
                if ((this._almLstOv != value))
                {
                    ISPS old = this._almLstOv;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnAlmLstOvChanging(e);
                    this.OnPropertyChanging("AlmLstOv", e, _almLstOvReference);
                    this._almLstOv = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetAlmLstOv;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetAlmLstOv;
                    }
                    this.OnAlmLstOvChanged(e);
                    this.OnPropertyChanged("AlmLstOv", e, _almLstOvReference);
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
                return base.ReferencedElements.Concat(new CALHReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://www.transformation-tool-contest.eu/2017/smartGrids/substationStandard#//LN" +
                            "Nodes/LNGroupC/CALH")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the GrAlm property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> GrAlmChanging;
        
        /// <summary>
        /// Gets fired when the GrAlm property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> GrAlmChanged;
        
        /// <summary>
        /// Gets fired before the GrWrn property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> GrWrnChanging;
        
        /// <summary>
        /// Gets fired when the GrWrn property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> GrWrnChanged;
        
        /// <summary>
        /// Gets fired before the AlmLstOv property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> AlmLstOvChanging;
        
        /// <summary>
        /// Gets fired when the AlmLstOv property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> AlmLstOvChanged;
        
        private static ITypedElement RetrieveGrAlmReference()
        {
            return ((ITypedElement)(((ModelElement)(CALH.ClassInstance)).Resolve("GrAlm")));
        }
        
        /// <summary>
        /// Raises the GrAlmChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnGrAlmChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.GrAlmChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the GrAlmChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnGrAlmChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.GrAlmChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the GrAlm property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetGrAlm(object sender, System.EventArgs eventArgs)
        {
            this.GrAlm = null;
        }
        
        private static ITypedElement RetrieveGrWrnReference()
        {
            return ((ITypedElement)(((ModelElement)(CALH.ClassInstance)).Resolve("GrWrn")));
        }
        
        /// <summary>
        /// Raises the GrWrnChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnGrWrnChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.GrWrnChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the GrWrnChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnGrWrnChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.GrWrnChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the GrWrn property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetGrWrn(object sender, System.EventArgs eventArgs)
        {
            this.GrWrn = null;
        }
        
        private static ITypedElement RetrieveAlmLstOvReference()
        {
            return ((ITypedElement)(((ModelElement)(CALH.ClassInstance)).Resolve("AlmLstOv")));
        }
        
        /// <summary>
        /// Raises the AlmLstOvChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnAlmLstOvChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.AlmLstOvChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the AlmLstOvChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnAlmLstOvChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.AlmLstOvChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the AlmLstOv property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetAlmLstOv(object sender, System.EventArgs eventArgs)
        {
            this.AlmLstOv = null;
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "GRALM"))
            {
                this.GrAlm = ((ISPS)(value));
                return;
            }
            if ((feature == "GRWRN"))
            {
                this.GrWrn = ((ISPS)(value));
                return;
            }
            if ((feature == "ALMLSTOV"))
            {
                this.AlmLstOv = ((ISPS)(value));
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
            if ((attribute == "GrAlm"))
            {
                return new GrAlmProxy(this);
            }
            if ((attribute == "GrWrn"))
            {
                return new GrWrnProxy(this);
            }
            if ((attribute == "AlmLstOv"))
            {
                return new AlmLstOvProxy(this);
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
            if ((reference == "GrAlm"))
            {
                return new GrAlmProxy(this);
            }
            if ((reference == "GrWrn"))
            {
                return new GrWrnProxy(this);
            }
            if ((reference == "AlmLstOv"))
            {
                return new AlmLstOvProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://www.transformation-tool-contest.eu/2017/smartGrids/substationStandard#//LN" +
                        "Nodes/LNGroupC/CALH")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the CALH class
        /// </summary>
        public class CALHReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private CALH _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public CALHReferencedElementsCollection(CALH parent)
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
                    if ((this._parent.GrAlm != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.GrWrn != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.AlmLstOv != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.GrAlmChanged += this.PropagateValueChanges;
                this._parent.GrWrnChanged += this.PropagateValueChanges;
                this._parent.AlmLstOvChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.GrAlmChanged -= this.PropagateValueChanges;
                this._parent.GrWrnChanged -= this.PropagateValueChanges;
                this._parent.AlmLstOvChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.GrAlm == null))
                {
                    ISPS grAlmCasted = item.As<ISPS>();
                    if ((grAlmCasted != null))
                    {
                        this._parent.GrAlm = grAlmCasted;
                        return;
                    }
                }
                if ((this._parent.GrWrn == null))
                {
                    ISPS grWrnCasted = item.As<ISPS>();
                    if ((grWrnCasted != null))
                    {
                        this._parent.GrWrn = grWrnCasted;
                        return;
                    }
                }
                if ((this._parent.AlmLstOv == null))
                {
                    ISPS almLstOvCasted = item.As<ISPS>();
                    if ((almLstOvCasted != null))
                    {
                        this._parent.AlmLstOv = almLstOvCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.GrAlm = null;
                this._parent.GrWrn = null;
                this._parent.AlmLstOv = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.GrAlm))
                {
                    return true;
                }
                if ((item == this._parent.GrWrn))
                {
                    return true;
                }
                if ((item == this._parent.AlmLstOv))
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
                if ((this._parent.GrAlm != null))
                {
                    array[arrayIndex] = this._parent.GrAlm;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.GrWrn != null))
                {
                    array[arrayIndex] = this._parent.GrWrn;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.AlmLstOv != null))
                {
                    array[arrayIndex] = this._parent.AlmLstOv;
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
                if ((this._parent.GrAlm == item))
                {
                    this._parent.GrAlm = null;
                    return true;
                }
                if ((this._parent.GrWrn == item))
                {
                    this._parent.GrWrn = null;
                    return true;
                }
                if ((this._parent.AlmLstOv == item))
                {
                    this._parent.AlmLstOv = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.GrAlm).Concat(this._parent.GrWrn).Concat(this._parent.AlmLstOv).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the GrAlm property
        /// </summary>
        private sealed class GrAlmProxy : ModelPropertyChange<ICALH, ISPS>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public GrAlmProxy(ICALH modelElement) : 
                    base(modelElement, "GrAlm")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override ISPS Value
            {
                get
                {
                    return this.ModelElement.GrAlm;
                }
                set
                {
                    this.ModelElement.GrAlm = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the GrWrn property
        /// </summary>
        private sealed class GrWrnProxy : ModelPropertyChange<ICALH, ISPS>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public GrWrnProxy(ICALH modelElement) : 
                    base(modelElement, "GrWrn")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override ISPS Value
            {
                get
                {
                    return this.ModelElement.GrWrn;
                }
                set
                {
                    this.ModelElement.GrWrn = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the AlmLstOv property
        /// </summary>
        private sealed class AlmLstOvProxy : ModelPropertyChange<ICALH, ISPS>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public AlmLstOvProxy(ICALH modelElement) : 
                    base(modelElement, "AlmLstOv")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override ISPS Value
            {
                get
                {
                    return this.ModelElement.AlmLstOv;
                }
                set
                {
                    this.ModelElement.AlmLstOv = value;
                }
            }
        }
    }
}

