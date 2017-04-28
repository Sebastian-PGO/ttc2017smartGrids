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
    /// The default implementation of the ControlArea class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#ControlArea")]
    [XmlNamespacePrefixAttribute("cimControlArea")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/ControlArea/ControlArea")]
    [DebuggerDisplayAttribute("ControlArea {UUID}")]
    public partial class ControlArea : PowerSystemResource, IControlArea, IModelElement
    {
        
        /// <summary>
        /// The backing field for the Type property
        /// </summary>
        private Nullable<ControlAreaTypeKind> _type;
        
        private static Lazy<ITypedElement> _typeAttribute = new Lazy<ITypedElement>(RetrieveTypeAttribute);
        
        /// <summary>
        /// The backing field for the PTolerance property
        /// </summary>
        private float _pTolerance;
        
        private static Lazy<ITypedElement> _pToleranceAttribute = new Lazy<ITypedElement>(RetrievePToleranceAttribute);
        
        /// <summary>
        /// The backing field for the NetInterchange property
        /// </summary>
        private float _netInterchange;
        
        private static Lazy<ITypedElement> _netInterchangeAttribute = new Lazy<ITypedElement>(RetrieveNetInterchangeAttribute);
        
        private static Lazy<ITypedElement> _controlAreaGeneratingUnitReference = new Lazy<ITypedElement>(RetrieveControlAreaGeneratingUnitReference);
        
        /// <summary>
        /// The backing field for the ControlAreaGeneratingUnit property
        /// </summary>
        private ControlAreaControlAreaGeneratingUnitCollection _controlAreaGeneratingUnit;
        
        private static Lazy<ITypedElement> _energyAreaReference = new Lazy<ITypedElement>(RetrieveEnergyAreaReference);
        
        /// <summary>
        /// The backing field for the EnergyArea property
        /// </summary>
        private IEnergyArea _energyArea;
        
        private static Lazy<ITypedElement> _tieFlowReference = new Lazy<ITypedElement>(RetrieveTieFlowReference);
        
        /// <summary>
        /// The backing field for the TieFlow property
        /// </summary>
        private ControlAreaTieFlowCollection _tieFlow;
        
        private static IClass _classInstance;
        
        public ControlArea()
        {
            this._controlAreaGeneratingUnit = new ControlAreaControlAreaGeneratingUnitCollection(this);
            this._controlAreaGeneratingUnit.CollectionChanging += this.ControlAreaGeneratingUnitCollectionChanging;
            this._controlAreaGeneratingUnit.CollectionChanged += this.ControlAreaGeneratingUnitCollectionChanged;
            this._tieFlow = new ControlAreaTieFlowCollection(this);
            this._tieFlow.CollectionChanging += this.TieFlowCollectionChanging;
            this._tieFlow.CollectionChanged += this.TieFlowCollectionChanged;
        }
        
        /// <summary>
        /// The type property
        /// </summary>
        [XmlElementNameAttribute("type")]
        [XmlAttributeAttribute(true)]
        public virtual Nullable<ControlAreaTypeKind> Type
        {
            get
            {
                return this._type;
            }
            set
            {
                if ((this._type != value))
                {
                    Nullable<ControlAreaTypeKind> old = this._type;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnTypeChanging(e);
                    this.OnPropertyChanging("Type", e, _typeAttribute);
                    this._type = value;
                    this.OnTypeChanged(e);
                    this.OnPropertyChanged("Type", e, _typeAttribute);
                }
            }
        }
        
        /// <summary>
        /// The pTolerance property
        /// </summary>
        [XmlElementNameAttribute("pTolerance")]
        [XmlAttributeAttribute(true)]
        public virtual float PTolerance
        {
            get
            {
                return this._pTolerance;
            }
            set
            {
                if ((this._pTolerance != value))
                {
                    float old = this._pTolerance;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnPToleranceChanging(e);
                    this.OnPropertyChanging("PTolerance", e, _pToleranceAttribute);
                    this._pTolerance = value;
                    this.OnPToleranceChanged(e);
                    this.OnPropertyChanged("PTolerance", e, _pToleranceAttribute);
                }
            }
        }
        
        /// <summary>
        /// The netInterchange property
        /// </summary>
        [XmlElementNameAttribute("netInterchange")]
        [XmlAttributeAttribute(true)]
        public virtual float NetInterchange
        {
            get
            {
                return this._netInterchange;
            }
            set
            {
                if ((this._netInterchange != value))
                {
                    float old = this._netInterchange;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnNetInterchangeChanging(e);
                    this.OnPropertyChanging("NetInterchange", e, _netInterchangeAttribute);
                    this._netInterchange = value;
                    this.OnNetInterchangeChanged(e);
                    this.OnPropertyChanged("NetInterchange", e, _netInterchangeAttribute);
                }
            }
        }
        
        /// <summary>
        /// The ControlAreaGeneratingUnit property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("ControlArea")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<IControlAreaGeneratingUnit> ControlAreaGeneratingUnit
        {
            get
            {
                return this._controlAreaGeneratingUnit;
            }
        }
        
        /// <summary>
        /// The EnergyArea property
        /// </summary>
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("ControlArea")]
        public virtual IEnergyArea EnergyArea
        {
            get
            {
                return this._energyArea;
            }
            set
            {
                if ((this._energyArea != value))
                {
                    IEnergyArea old = this._energyArea;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnEnergyAreaChanging(e);
                    this.OnPropertyChanging("EnergyArea", e, _energyAreaReference);
                    this._energyArea = value;
                    if ((old != null))
                    {
                        old.ControlArea = null;
                        old.Deleted -= this.OnResetEnergyArea;
                    }
                    if ((value != null))
                    {
                        value.ControlArea = this;
                        value.Deleted += this.OnResetEnergyArea;
                    }
                    this.OnEnergyAreaChanged(e);
                    this.OnPropertyChanged("EnergyArea", e, _energyAreaReference);
                }
            }
        }
        
        /// <summary>
        /// The TieFlow property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("ControlArea")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<ITieFlow> TieFlow
        {
            get
            {
                return this._tieFlow;
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new ControlAreaReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/ControlArea/ControlArea")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the Type property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> TypeChanging;
        
        /// <summary>
        /// Gets fired when the Type property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> TypeChanged;
        
        /// <summary>
        /// Gets fired before the PTolerance property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> PToleranceChanging;
        
        /// <summary>
        /// Gets fired when the PTolerance property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> PToleranceChanged;
        
        /// <summary>
        /// Gets fired before the NetInterchange property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> NetInterchangeChanging;
        
        /// <summary>
        /// Gets fired when the NetInterchange property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> NetInterchangeChanged;
        
        /// <summary>
        /// Gets fired before the EnergyArea property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> EnergyAreaChanging;
        
        /// <summary>
        /// Gets fired when the EnergyArea property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> EnergyAreaChanged;
        
        private static ITypedElement RetrieveTypeAttribute()
        {
            return ((ITypedElement)(((ModelElement)(ControlArea.ClassInstance)).Resolve("type")));
        }
        
        /// <summary>
        /// Raises the TypeChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnTypeChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.TypeChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the TypeChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnTypeChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.TypeChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrievePToleranceAttribute()
        {
            return ((ITypedElement)(((ModelElement)(ControlArea.ClassInstance)).Resolve("pTolerance")));
        }
        
        /// <summary>
        /// Raises the PToleranceChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnPToleranceChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.PToleranceChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the PToleranceChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnPToleranceChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.PToleranceChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveNetInterchangeAttribute()
        {
            return ((ITypedElement)(((ModelElement)(ControlArea.ClassInstance)).Resolve("netInterchange")));
        }
        
        /// <summary>
        /// Raises the NetInterchangeChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnNetInterchangeChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.NetInterchangeChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the NetInterchangeChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnNetInterchangeChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.NetInterchangeChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveControlAreaGeneratingUnitReference()
        {
            return ((ITypedElement)(((ModelElement)(ControlArea.ClassInstance)).Resolve("ControlAreaGeneratingUnit")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the ControlAreaGeneratingUnit property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void ControlAreaGeneratingUnitCollectionChanging(object sender, NMF.Collections.ObjectModel.NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("ControlAreaGeneratingUnit", e, _controlAreaGeneratingUnitReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the ControlAreaGeneratingUnit property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void ControlAreaGeneratingUnitCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("ControlAreaGeneratingUnit", e, _controlAreaGeneratingUnitReference);
        }
        
        private static ITypedElement RetrieveEnergyAreaReference()
        {
            return ((ITypedElement)(((ModelElement)(ControlArea.ClassInstance)).Resolve("EnergyArea")));
        }
        
        /// <summary>
        /// Raises the EnergyAreaChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnEnergyAreaChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.EnergyAreaChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the EnergyAreaChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnEnergyAreaChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.EnergyAreaChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the EnergyArea property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetEnergyArea(object sender, System.EventArgs eventArgs)
        {
            this.EnergyArea = null;
        }
        
        private static ITypedElement RetrieveTieFlowReference()
        {
            return ((ITypedElement)(((ModelElement)(ControlArea.ClassInstance)).Resolve("TieFlow")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the TieFlow property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void TieFlowCollectionChanging(object sender, NMF.Collections.ObjectModel.NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("TieFlow", e, _tieFlowReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the TieFlow property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void TieFlowCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("TieFlow", e, _tieFlowReference);
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "TYPE"))
            {
                return this.Type;
            }
            if ((attribute == "PTOLERANCE"))
            {
                return this.PTolerance;
            }
            if ((attribute == "NETINTERCHANGE"))
            {
                return this.NetInterchange;
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
            if ((feature == "CONTROLAREAGENERATINGUNIT"))
            {
                return this._controlAreaGeneratingUnit;
            }
            if ((feature == "TIEFLOW"))
            {
                return this._tieFlow;
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
            if ((feature == "ENERGYAREA"))
            {
                this.EnergyArea = ((IEnergyArea)(value));
                return;
            }
            if ((feature == "TYPE"))
            {
                this.Type = ((ControlAreaTypeKind)(value));
                return;
            }
            if ((feature == "PTOLERANCE"))
            {
                this.PTolerance = ((float)(value));
                return;
            }
            if ((feature == "NETINTERCHANGE"))
            {
                this.NetInterchange = ((float)(value));
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
            if ((attribute == "EnergyArea"))
            {
                return new EnergyAreaProxy(this);
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
            if ((reference == "EnergyArea"))
            {
                return new EnergyAreaProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/ControlArea/ControlArea")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the ControlArea class
        /// </summary>
        public class ControlAreaReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private ControlArea _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public ControlAreaReferencedElementsCollection(ControlArea parent)
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
                    count = (count + this._parent.ControlAreaGeneratingUnit.Count);
                    if ((this._parent.EnergyArea != null))
                    {
                        count = (count + 1);
                    }
                    count = (count + this._parent.TieFlow.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.ControlAreaGeneratingUnit.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.EnergyAreaChanged += this.PropagateValueChanges;
                this._parent.TieFlow.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.ControlAreaGeneratingUnit.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.EnergyAreaChanged -= this.PropagateValueChanges;
                this._parent.TieFlow.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IControlAreaGeneratingUnit controlAreaGeneratingUnitCasted = item.As<IControlAreaGeneratingUnit>();
                if ((controlAreaGeneratingUnitCasted != null))
                {
                    this._parent.ControlAreaGeneratingUnit.Add(controlAreaGeneratingUnitCasted);
                }
                if ((this._parent.EnergyArea == null))
                {
                    IEnergyArea energyAreaCasted = item.As<IEnergyArea>();
                    if ((energyAreaCasted != null))
                    {
                        this._parent.EnergyArea = energyAreaCasted;
                        return;
                    }
                }
                ITieFlow tieFlowCasted = item.As<ITieFlow>();
                if ((tieFlowCasted != null))
                {
                    this._parent.TieFlow.Add(tieFlowCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.ControlAreaGeneratingUnit.Clear();
                this._parent.EnergyArea = null;
                this._parent.TieFlow.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.ControlAreaGeneratingUnit.Contains(item))
                {
                    return true;
                }
                if ((item == this._parent.EnergyArea))
                {
                    return true;
                }
                if (this._parent.TieFlow.Contains(item))
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
                IEnumerator<IModelElement> controlAreaGeneratingUnitEnumerator = this._parent.ControlAreaGeneratingUnit.GetEnumerator();
                try
                {
                    for (
                    ; controlAreaGeneratingUnitEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = controlAreaGeneratingUnitEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    controlAreaGeneratingUnitEnumerator.Dispose();
                }
                if ((this._parent.EnergyArea != null))
                {
                    array[arrayIndex] = this._parent.EnergyArea;
                    arrayIndex = (arrayIndex + 1);
                }
                IEnumerator<IModelElement> tieFlowEnumerator = this._parent.TieFlow.GetEnumerator();
                try
                {
                    for (
                    ; tieFlowEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = tieFlowEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    tieFlowEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IControlAreaGeneratingUnit controlAreaGeneratingUnitItem = item.As<IControlAreaGeneratingUnit>();
                if (((controlAreaGeneratingUnitItem != null) 
                            && this._parent.ControlAreaGeneratingUnit.Remove(controlAreaGeneratingUnitItem)))
                {
                    return true;
                }
                if ((this._parent.EnergyArea == item))
                {
                    this._parent.EnergyArea = null;
                    return true;
                }
                ITieFlow tieFlowItem = item.As<ITieFlow>();
                if (((tieFlowItem != null) 
                            && this._parent.TieFlow.Remove(tieFlowItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.ControlAreaGeneratingUnit).Concat(this._parent.EnergyArea).Concat(this._parent.TieFlow).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the type property
        /// </summary>
        private sealed class TypeProxy : ModelPropertyChange<IControlArea, Nullable<ControlAreaTypeKind>>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public TypeProxy(IControlArea modelElement) : 
                    base(modelElement, "type")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override Nullable<ControlAreaTypeKind> Value
            {
                get
                {
                    return this.ModelElement.Type;
                }
                set
                {
                    this.ModelElement.Type = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the pTolerance property
        /// </summary>
        private sealed class PToleranceProxy : ModelPropertyChange<IControlArea, float>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public PToleranceProxy(IControlArea modelElement) : 
                    base(modelElement, "pTolerance")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override float Value
            {
                get
                {
                    return this.ModelElement.PTolerance;
                }
                set
                {
                    this.ModelElement.PTolerance = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the netInterchange property
        /// </summary>
        private sealed class NetInterchangeProxy : ModelPropertyChange<IControlArea, float>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public NetInterchangeProxy(IControlArea modelElement) : 
                    base(modelElement, "netInterchange")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override float Value
            {
                get
                {
                    return this.ModelElement.NetInterchange;
                }
                set
                {
                    this.ModelElement.NetInterchange = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the EnergyArea property
        /// </summary>
        private sealed class EnergyAreaProxy : ModelPropertyChange<IControlArea, IEnergyArea>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public EnergyAreaProxy(IControlArea modelElement) : 
                    base(modelElement, "EnergyArea")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IEnergyArea Value
            {
                get
                {
                    return this.ModelElement.EnergyArea;
                }
                set
                {
                    this.ModelElement.EnergyArea = value;
                }
            }
        }
    }
}

