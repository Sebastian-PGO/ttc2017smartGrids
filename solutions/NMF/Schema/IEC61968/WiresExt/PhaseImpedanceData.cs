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
using TTC2017.SmartGrids.CIM.IEC61968.AssetModels;
using TTC2017.SmartGrids.CIM.IEC61968.Metering;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssets;
using TTC2017.SmartGrids.CIM.IEC61970.Wires;

namespace TTC2017.SmartGrids.CIM.IEC61968.WiresExt
{
    
    
    /// <summary>
    /// The default implementation of the PhaseImpedanceData class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#WiresExt")]
    [XmlNamespacePrefixAttribute("cimWiresExt")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61968/WiresExt/PhaseImpedanceData")]
    [DebuggerDisplayAttribute("PhaseImpedanceData {UUID}")]
    public partial class PhaseImpedanceData : Element, IPhaseImpedanceData, IModelElement
    {
        
        /// <summary>
        /// The backing field for the SequenceNumber property
        /// </summary>
        private int _sequenceNumber;
        
        private static Lazy<ITypedElement> _sequenceNumberAttribute = new Lazy<ITypedElement>(RetrieveSequenceNumberAttribute);
        
        /// <summary>
        /// The backing field for the B property
        /// </summary>
        private float _b;
        
        private static Lazy<ITypedElement> _bAttribute = new Lazy<ITypedElement>(RetrieveBAttribute);
        
        /// <summary>
        /// The backing field for the X property
        /// </summary>
        private float _x;
        
        private static Lazy<ITypedElement> _xAttribute = new Lazy<ITypedElement>(RetrieveXAttribute);
        
        /// <summary>
        /// The backing field for the R property
        /// </summary>
        private float _r;
        
        private static Lazy<ITypedElement> _rAttribute = new Lazy<ITypedElement>(RetrieveRAttribute);
        
        private static Lazy<ITypedElement> _phaseImpedanceReference = new Lazy<ITypedElement>(RetrievePhaseImpedanceReference);
        
        /// <summary>
        /// The backing field for the PhaseImpedance property
        /// </summary>
        private IPerLengthPhaseImpedance _phaseImpedance;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The sequenceNumber property
        /// </summary>
        [XmlElementNameAttribute("sequenceNumber")]
        [XmlAttributeAttribute(true)]
        public virtual int SequenceNumber
        {
            get
            {
                return this._sequenceNumber;
            }
            set
            {
                if ((this._sequenceNumber != value))
                {
                    int old = this._sequenceNumber;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnSequenceNumberChanging(e);
                    this.OnPropertyChanging("SequenceNumber", e, _sequenceNumberAttribute);
                    this._sequenceNumber = value;
                    this.OnSequenceNumberChanged(e);
                    this.OnPropertyChanged("SequenceNumber", e, _sequenceNumberAttribute);
                }
            }
        }
        
        /// <summary>
        /// The b property
        /// </summary>
        [XmlElementNameAttribute("b")]
        [XmlAttributeAttribute(true)]
        public virtual float B
        {
            get
            {
                return this._b;
            }
            set
            {
                if ((this._b != value))
                {
                    float old = this._b;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnBChanging(e);
                    this.OnPropertyChanging("B", e, _bAttribute);
                    this._b = value;
                    this.OnBChanged(e);
                    this.OnPropertyChanged("B", e, _bAttribute);
                }
            }
        }
        
        /// <summary>
        /// The x property
        /// </summary>
        [XmlElementNameAttribute("x")]
        [XmlAttributeAttribute(true)]
        public virtual float X
        {
            get
            {
                return this._x;
            }
            set
            {
                if ((this._x != value))
                {
                    float old = this._x;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnXChanging(e);
                    this.OnPropertyChanging("X", e, _xAttribute);
                    this._x = value;
                    this.OnXChanged(e);
                    this.OnPropertyChanged("X", e, _xAttribute);
                }
            }
        }
        
        /// <summary>
        /// The r property
        /// </summary>
        [XmlElementNameAttribute("r")]
        [XmlAttributeAttribute(true)]
        public virtual float R
        {
            get
            {
                return this._r;
            }
            set
            {
                if ((this._r != value))
                {
                    float old = this._r;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnRChanging(e);
                    this.OnPropertyChanging("R", e, _rAttribute);
                    this._r = value;
                    this.OnRChanged(e);
                    this.OnPropertyChanged("R", e, _rAttribute);
                }
            }
        }
        
        /// <summary>
        /// The PhaseImpedance property
        /// </summary>
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("PhaseImpedanceData")]
        public virtual IPerLengthPhaseImpedance PhaseImpedance
        {
            get
            {
                return this._phaseImpedance;
            }
            set
            {
                if ((this._phaseImpedance != value))
                {
                    IPerLengthPhaseImpedance old = this._phaseImpedance;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnPhaseImpedanceChanging(e);
                    this.OnPropertyChanging("PhaseImpedance", e, _phaseImpedanceReference);
                    this._phaseImpedance = value;
                    if ((old != null))
                    {
                        old.PhaseImpedanceData.Remove(this);
                        old.Deleted -= this.OnResetPhaseImpedance;
                    }
                    if ((value != null))
                    {
                        value.PhaseImpedanceData.Add(this);
                        value.Deleted += this.OnResetPhaseImpedance;
                    }
                    this.OnPhaseImpedanceChanged(e);
                    this.OnPropertyChanged("PhaseImpedance", e, _phaseImpedanceReference);
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
                return base.ReferencedElements.Concat(new PhaseImpedanceDataReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61968/WiresExt/PhaseImpedanceData")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the SequenceNumber property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> SequenceNumberChanging;
        
        /// <summary>
        /// Gets fired when the SequenceNumber property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> SequenceNumberChanged;
        
        /// <summary>
        /// Gets fired before the B property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> BChanging;
        
        /// <summary>
        /// Gets fired when the B property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> BChanged;
        
        /// <summary>
        /// Gets fired before the X property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> XChanging;
        
        /// <summary>
        /// Gets fired when the X property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> XChanged;
        
        /// <summary>
        /// Gets fired before the R property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> RChanging;
        
        /// <summary>
        /// Gets fired when the R property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> RChanged;
        
        /// <summary>
        /// Gets fired before the PhaseImpedance property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> PhaseImpedanceChanging;
        
        /// <summary>
        /// Gets fired when the PhaseImpedance property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> PhaseImpedanceChanged;
        
        private static ITypedElement RetrieveSequenceNumberAttribute()
        {
            return ((ITypedElement)(((ModelElement)(PhaseImpedanceData.ClassInstance)).Resolve("sequenceNumber")));
        }
        
        /// <summary>
        /// Raises the SequenceNumberChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnSequenceNumberChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.SequenceNumberChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the SequenceNumberChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnSequenceNumberChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.SequenceNumberChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveBAttribute()
        {
            return ((ITypedElement)(((ModelElement)(PhaseImpedanceData.ClassInstance)).Resolve("b")));
        }
        
        /// <summary>
        /// Raises the BChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnBChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.BChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the BChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnBChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.BChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveXAttribute()
        {
            return ((ITypedElement)(((ModelElement)(PhaseImpedanceData.ClassInstance)).Resolve("x")));
        }
        
        /// <summary>
        /// Raises the XChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnXChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.XChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the XChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnXChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.XChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveRAttribute()
        {
            return ((ITypedElement)(((ModelElement)(PhaseImpedanceData.ClassInstance)).Resolve("r")));
        }
        
        /// <summary>
        /// Raises the RChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnRChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.RChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the RChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnRChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.RChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrievePhaseImpedanceReference()
        {
            return ((ITypedElement)(((ModelElement)(PhaseImpedanceData.ClassInstance)).Resolve("PhaseImpedance")));
        }
        
        /// <summary>
        /// Raises the PhaseImpedanceChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnPhaseImpedanceChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.PhaseImpedanceChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the PhaseImpedanceChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnPhaseImpedanceChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.PhaseImpedanceChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the PhaseImpedance property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetPhaseImpedance(object sender, System.EventArgs eventArgs)
        {
            this.PhaseImpedance = null;
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "SEQUENCENUMBER"))
            {
                return this.SequenceNumber;
            }
            if ((attribute == "B"))
            {
                return this.B;
            }
            if ((attribute == "X"))
            {
                return this.X;
            }
            if ((attribute == "R"))
            {
                return this.R;
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
            if ((feature == "PHASEIMPEDANCE"))
            {
                this.PhaseImpedance = ((IPerLengthPhaseImpedance)(value));
                return;
            }
            if ((feature == "SEQUENCENUMBER"))
            {
                this.SequenceNumber = ((int)(value));
                return;
            }
            if ((feature == "B"))
            {
                this.B = ((float)(value));
                return;
            }
            if ((feature == "X"))
            {
                this.X = ((float)(value));
                return;
            }
            if ((feature == "R"))
            {
                this.R = ((float)(value));
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
            if ((attribute == "PhaseImpedance"))
            {
                return new PhaseImpedanceProxy(this);
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
            if ((reference == "PhaseImpedance"))
            {
                return new PhaseImpedanceProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61968/WiresExt/PhaseImpedanceData")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the PhaseImpedanceData class
        /// </summary>
        public class PhaseImpedanceDataReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private PhaseImpedanceData _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public PhaseImpedanceDataReferencedElementsCollection(PhaseImpedanceData parent)
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
                    if ((this._parent.PhaseImpedance != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.PhaseImpedanceChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.PhaseImpedanceChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.PhaseImpedance == null))
                {
                    IPerLengthPhaseImpedance phaseImpedanceCasted = item.As<IPerLengthPhaseImpedance>();
                    if ((phaseImpedanceCasted != null))
                    {
                        this._parent.PhaseImpedance = phaseImpedanceCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.PhaseImpedance = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.PhaseImpedance))
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
                if ((this._parent.PhaseImpedance != null))
                {
                    array[arrayIndex] = this._parent.PhaseImpedance;
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
                if ((this._parent.PhaseImpedance == item))
                {
                    this._parent.PhaseImpedance = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.PhaseImpedance).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the sequenceNumber property
        /// </summary>
        private sealed class SequenceNumberProxy : ModelPropertyChange<IPhaseImpedanceData, int>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public SequenceNumberProxy(IPhaseImpedanceData modelElement) : 
                    base(modelElement, "sequenceNumber")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override int Value
            {
                get
                {
                    return this.ModelElement.SequenceNumber;
                }
                set
                {
                    this.ModelElement.SequenceNumber = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the b property
        /// </summary>
        private sealed class BProxy : ModelPropertyChange<IPhaseImpedanceData, float>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public BProxy(IPhaseImpedanceData modelElement) : 
                    base(modelElement, "b")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override float Value
            {
                get
                {
                    return this.ModelElement.B;
                }
                set
                {
                    this.ModelElement.B = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the x property
        /// </summary>
        private sealed class XProxy : ModelPropertyChange<IPhaseImpedanceData, float>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public XProxy(IPhaseImpedanceData modelElement) : 
                    base(modelElement, "x")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override float Value
            {
                get
                {
                    return this.ModelElement.X;
                }
                set
                {
                    this.ModelElement.X = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the r property
        /// </summary>
        private sealed class RProxy : ModelPropertyChange<IPhaseImpedanceData, float>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public RProxy(IPhaseImpedanceData modelElement) : 
                    base(modelElement, "r")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override float Value
            {
                get
                {
                    return this.ModelElement.R;
                }
                set
                {
                    this.ModelElement.R = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the PhaseImpedance property
        /// </summary>
        private sealed class PhaseImpedanceProxy : ModelPropertyChange<IPhaseImpedanceData, IPerLengthPhaseImpedance>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public PhaseImpedanceProxy(IPhaseImpedanceData modelElement) : 
                    base(modelElement, "PhaseImpedance")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IPerLengthPhaseImpedance Value
            {
                get
                {
                    return this.ModelElement.PhaseImpedance;
                }
                set
                {
                    this.ModelElement.PhaseImpedance = value;
                }
            }
        }
    }
}

