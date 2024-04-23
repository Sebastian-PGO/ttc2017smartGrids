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
    /// The default implementation of the DistributionLineSegment class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#WiresExt")]
    [XmlNamespacePrefixAttribute("cimWiresExt")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61968/WiresExt/DistributionLineSegm" +
        "ent")]
    [DebuggerDisplayAttribute("DistributionLineSegment {UUID}")]
    public partial class DistributionLineSegment : ACLineSegment, IDistributionLineSegment, IModelElement
    {
        
        private static Lazy<ITypedElement> _phaseImpedanceReference = new Lazy<ITypedElement>(RetrievePhaseImpedanceReference);
        
        /// <summary>
        /// The backing field for the PhaseImpedance property
        /// </summary>
        private IPerLengthPhaseImpedance _phaseImpedance;
        
        private static Lazy<ITypedElement> _conductorAssetsReference = new Lazy<ITypedElement>(RetrieveConductorAssetsReference);
        
        /// <summary>
        /// The backing field for the ConductorAssets property
        /// </summary>
        private DistributionLineSegmentConductorAssetsCollection _conductorAssets;
        
        private static Lazy<ITypedElement> _sequenceImpedanceReference = new Lazy<ITypedElement>(RetrieveSequenceImpedanceReference);
        
        /// <summary>
        /// The backing field for the SequenceImpedance property
        /// </summary>
        private IPerLengthSequenceImpedance _sequenceImpedance;
        
        private static Lazy<ITypedElement> _conductorInfoReference = new Lazy<ITypedElement>(RetrieveConductorInfoReference);
        
        /// <summary>
        /// The backing field for the ConductorInfo property
        /// </summary>
        private IConductorInfo _conductorInfo;
        
        private static IClass _classInstance;
        
        public DistributionLineSegment()
        {
            this._conductorAssets = new DistributionLineSegmentConductorAssetsCollection(this);
            this._conductorAssets.CollectionChanging += this.ConductorAssetsCollectionChanging;
            this._conductorAssets.CollectionChanged += this.ConductorAssetsCollectionChanged;
        }
        
        /// <summary>
        /// The PhaseImpedance property
        /// </summary>
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("ConductorSegments")]
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
                        old.ConductorSegments.Remove(this);
                        old.Deleted -= this.OnResetPhaseImpedance;
                    }
                    if ((value != null))
                    {
                        value.ConductorSegments.Add(this);
                        value.Deleted += this.OnResetPhaseImpedance;
                    }
                    this.OnPhaseImpedanceChanged(e);
                    this.OnPropertyChanged("PhaseImpedance", e, _phaseImpedanceReference);
                }
            }
        }
        
        /// <summary>
        /// The ConductorAssets property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("ConductorSegment")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<IConductorAsset> ConductorAssets
        {
            get
            {
                return this._conductorAssets;
            }
        }
        
        /// <summary>
        /// The SequenceImpedance property
        /// </summary>
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("ConductorSegments")]
        public virtual IPerLengthSequenceImpedance SequenceImpedance
        {
            get
            {
                return this._sequenceImpedance;
            }
            set
            {
                if ((this._sequenceImpedance != value))
                {
                    IPerLengthSequenceImpedance old = this._sequenceImpedance;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnSequenceImpedanceChanging(e);
                    this.OnPropertyChanging("SequenceImpedance", e, _sequenceImpedanceReference);
                    this._sequenceImpedance = value;
                    if ((old != null))
                    {
                        old.ConductorSegments.Remove(this);
                        old.Deleted -= this.OnResetSequenceImpedance;
                    }
                    if ((value != null))
                    {
                        value.ConductorSegments.Add(this);
                        value.Deleted += this.OnResetSequenceImpedance;
                    }
                    this.OnSequenceImpedanceChanged(e);
                    this.OnPropertyChanged("SequenceImpedance", e, _sequenceImpedanceReference);
                }
            }
        }
        
        /// <summary>
        /// The ConductorInfo property
        /// </summary>
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("ConductorSegments")]
        public virtual IConductorInfo ConductorInfo
        {
            get
            {
                return this._conductorInfo;
            }
            set
            {
                if ((this._conductorInfo != value))
                {
                    IConductorInfo old = this._conductorInfo;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnConductorInfoChanging(e);
                    this.OnPropertyChanging("ConductorInfo", e, _conductorInfoReference);
                    this._conductorInfo = value;
                    if ((old != null))
                    {
                        old.ConductorSegments.Remove(this);
                        old.Deleted -= this.OnResetConductorInfo;
                    }
                    if ((value != null))
                    {
                        value.ConductorSegments.Add(this);
                        value.Deleted += this.OnResetConductorInfo;
                    }
                    this.OnConductorInfoChanged(e);
                    this.OnPropertyChanged("ConductorInfo", e, _conductorInfoReference);
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
                return base.ReferencedElements.Concat(new DistributionLineSegmentReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61968/WiresExt/DistributionLineSegm" +
                            "ent")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the PhaseImpedance property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> PhaseImpedanceChanging;
        
        /// <summary>
        /// Gets fired when the PhaseImpedance property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> PhaseImpedanceChanged;
        
        /// <summary>
        /// Gets fired before the SequenceImpedance property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> SequenceImpedanceChanging;
        
        /// <summary>
        /// Gets fired when the SequenceImpedance property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> SequenceImpedanceChanged;
        
        /// <summary>
        /// Gets fired before the ConductorInfo property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ConductorInfoChanging;
        
        /// <summary>
        /// Gets fired when the ConductorInfo property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ConductorInfoChanged;
        
        private static ITypedElement RetrievePhaseImpedanceReference()
        {
            return ((ITypedElement)(((ModelElement)(DistributionLineSegment.ClassInstance)).Resolve("PhaseImpedance")));
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
        
        private static ITypedElement RetrieveConductorAssetsReference()
        {
            return ((ITypedElement)(((ModelElement)(DistributionLineSegment.ClassInstance)).Resolve("ConductorAssets")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the ConductorAssets property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void ConductorAssetsCollectionChanging(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanging("ConductorAssets", e, _conductorAssetsReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the ConductorAssets property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void ConductorAssetsCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("ConductorAssets", e, _conductorAssetsReference);
        }
        
        private static ITypedElement RetrieveSequenceImpedanceReference()
        {
            return ((ITypedElement)(((ModelElement)(DistributionLineSegment.ClassInstance)).Resolve("SequenceImpedance")));
        }
        
        /// <summary>
        /// Raises the SequenceImpedanceChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnSequenceImpedanceChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.SequenceImpedanceChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the SequenceImpedanceChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnSequenceImpedanceChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.SequenceImpedanceChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the SequenceImpedance property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetSequenceImpedance(object sender, System.EventArgs eventArgs)
        {
            this.SequenceImpedance = null;
        }
        
        private static ITypedElement RetrieveConductorInfoReference()
        {
            return ((ITypedElement)(((ModelElement)(DistributionLineSegment.ClassInstance)).Resolve("ConductorInfo")));
        }
        
        /// <summary>
        /// Raises the ConductorInfoChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnConductorInfoChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ConductorInfoChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the ConductorInfoChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnConductorInfoChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ConductorInfoChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the ConductorInfo property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetConductorInfo(object sender, System.EventArgs eventArgs)
        {
            this.ConductorInfo = null;
        }
        
        /// <summary>
        /// Gets the Model element collection for the given feature
        /// </summary>
        /// <returns>A non-generic list of elements</returns>
        /// <param name="feature">The requested feature</param>
        protected override System.Collections.IList GetCollectionForFeature(string feature)
        {
            if ((feature == "CONDUCTORASSETS"))
            {
                return this._conductorAssets;
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
            if ((feature == "PHASEIMPEDANCE"))
            {
                this.PhaseImpedance = ((IPerLengthPhaseImpedance)(value));
                return;
            }
            if ((feature == "SEQUENCEIMPEDANCE"))
            {
                this.SequenceImpedance = ((IPerLengthSequenceImpedance)(value));
                return;
            }
            if ((feature == "CONDUCTORINFO"))
            {
                this.ConductorInfo = ((IConductorInfo)(value));
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
            if ((attribute == "SequenceImpedance"))
            {
                return new SequenceImpedanceProxy(this);
            }
            if ((attribute == "ConductorInfo"))
            {
                return new ConductorInfoProxy(this);
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
            if ((reference == "SequenceImpedance"))
            {
                return new SequenceImpedanceProxy(this);
            }
            if ((reference == "ConductorInfo"))
            {
                return new ConductorInfoProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61968/WiresExt/DistributionLineSegm" +
                        "ent")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the DistributionLineSegment class
        /// </summary>
        public class DistributionLineSegmentReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private DistributionLineSegment _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public DistributionLineSegmentReferencedElementsCollection(DistributionLineSegment parent)
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
                    count = (count + this._parent.ConductorAssets.Count);
                    if ((this._parent.SequenceImpedance != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.ConductorInfo != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.PhaseImpedanceChanged += this.PropagateValueChanges;
                this._parent.ConductorAssets.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.SequenceImpedanceChanged += this.PropagateValueChanges;
                this._parent.ConductorInfoChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.PhaseImpedanceChanged -= this.PropagateValueChanges;
                this._parent.ConductorAssets.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.SequenceImpedanceChanged -= this.PropagateValueChanges;
                this._parent.ConductorInfoChanged -= this.PropagateValueChanges;
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
                IConductorAsset conductorAssetsCasted = item.As<IConductorAsset>();
                if ((conductorAssetsCasted != null))
                {
                    this._parent.ConductorAssets.Add(conductorAssetsCasted);
                }
                if ((this._parent.SequenceImpedance == null))
                {
                    IPerLengthSequenceImpedance sequenceImpedanceCasted = item.As<IPerLengthSequenceImpedance>();
                    if ((sequenceImpedanceCasted != null))
                    {
                        this._parent.SequenceImpedance = sequenceImpedanceCasted;
                        return;
                    }
                }
                if ((this._parent.ConductorInfo == null))
                {
                    IConductorInfo conductorInfoCasted = item.As<IConductorInfo>();
                    if ((conductorInfoCasted != null))
                    {
                        this._parent.ConductorInfo = conductorInfoCasted;
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
                this._parent.ConductorAssets.Clear();
                this._parent.SequenceImpedance = null;
                this._parent.ConductorInfo = null;
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
                if (this._parent.ConductorAssets.Contains(item))
                {
                    return true;
                }
                if ((item == this._parent.SequenceImpedance))
                {
                    return true;
                }
                if ((item == this._parent.ConductorInfo))
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
                IEnumerator<IModelElement> conductorAssetsEnumerator = this._parent.ConductorAssets.GetEnumerator();
                try
                {
                    for (
                    ; conductorAssetsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = conductorAssetsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    conductorAssetsEnumerator.Dispose();
                }
                if ((this._parent.SequenceImpedance != null))
                {
                    array[arrayIndex] = this._parent.SequenceImpedance;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.ConductorInfo != null))
                {
                    array[arrayIndex] = this._parent.ConductorInfo;
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
                IConductorAsset conductorAssetItem = item.As<IConductorAsset>();
                if (((conductorAssetItem != null) 
                            && this._parent.ConductorAssets.Remove(conductorAssetItem)))
                {
                    return true;
                }
                if ((this._parent.SequenceImpedance == item))
                {
                    this._parent.SequenceImpedance = null;
                    return true;
                }
                if ((this._parent.ConductorInfo == item))
                {
                    this._parent.ConductorInfo = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.PhaseImpedance).Concat(this._parent.ConductorAssets).Concat(this._parent.SequenceImpedance).Concat(this._parent.ConductorInfo).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the PhaseImpedance property
        /// </summary>
        private sealed class PhaseImpedanceProxy : ModelPropertyChange<IDistributionLineSegment, IPerLengthPhaseImpedance>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public PhaseImpedanceProxy(IDistributionLineSegment modelElement) : 
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
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the SequenceImpedance property
        /// </summary>
        private sealed class SequenceImpedanceProxy : ModelPropertyChange<IDistributionLineSegment, IPerLengthSequenceImpedance>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public SequenceImpedanceProxy(IDistributionLineSegment modelElement) : 
                    base(modelElement, "SequenceImpedance")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IPerLengthSequenceImpedance Value
            {
                get
                {
                    return this.ModelElement.SequenceImpedance;
                }
                set
                {
                    this.ModelElement.SequenceImpedance = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the ConductorInfo property
        /// </summary>
        private sealed class ConductorInfoProxy : ModelPropertyChange<IDistributionLineSegment, IConductorInfo>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public ConductorInfoProxy(IDistributionLineSegment modelElement) : 
                    base(modelElement, "ConductorInfo")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IConductorInfo Value
            {
                get
                {
                    return this.ModelElement.ConductorInfo;
                }
                set
                {
                    this.ModelElement.ConductorInfo = value;
                }
            }
        }
    }
}

