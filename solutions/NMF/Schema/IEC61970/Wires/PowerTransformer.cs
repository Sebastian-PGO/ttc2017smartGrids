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
using TTC2017.SmartGrids.CIM.IEC61968.LoadControl;
using TTC2017.SmartGrids.CIM.IEC61968.Metering;
using TTC2017.SmartGrids.CIM.IEC61968.WiresExt;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Generation.GenerationDynamics;
using TTC2017.SmartGrids.CIM.IEC61970.Generation.Production;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.EnergyScheduling;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssets;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfLoadControl;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.MarketOperations;
using TTC2017.SmartGrids.CIM.IEC61970.LoadModel;
using TTC2017.SmartGrids.CIM.IEC61970.Meas;
using TTC2017.SmartGrids.CIM.IEC61970.Outage;
using TTC2017.SmartGrids.CIM.IEC61970.Protection;
using TTC2017.SmartGrids.CIM.IEC61970.StateVariables;

namespace TTC2017.SmartGrids.CIM.IEC61970.Wires
{
    
    
    /// <summary>
    /// The default implementation of the PowerTransformer class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#Wires")]
    [XmlNamespacePrefixAttribute("cimWires")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Wires/PowerTransformer")]
    [DebuggerDisplayAttribute("PowerTransformer {UUID}")]
    public partial class PowerTransformer : Equipment, IPowerTransformer, IModelElement
    {
        
        /// <summary>
        /// The backing field for the MagBaseU property
        /// </summary>
        private float _magBaseU;
        
        private static Lazy<ITypedElement> _magBaseUAttribute = new Lazy<ITypedElement>(RetrieveMagBaseUAttribute);
        
        /// <summary>
        /// The backing field for the MagSatFlux property
        /// </summary>
        private float _magSatFlux;
        
        private static Lazy<ITypedElement> _magSatFluxAttribute = new Lazy<ITypedElement>(RetrieveMagSatFluxAttribute);
        
        /// <summary>
        /// The backing field for the BmagSat property
        /// </summary>
        private float _bmagSat;
        
        private static Lazy<ITypedElement> _bmagSatAttribute = new Lazy<ITypedElement>(RetrieveBmagSatAttribute);
        
        private static Lazy<ITypedElement> _flowgatesReference = new Lazy<ITypedElement>(RetrieveFlowgatesReference);
        
        /// <summary>
        /// The backing field for the Flowgates property
        /// </summary>
        private PowerTransformerFlowgatesCollection _flowgates;
        
        private static Lazy<ITypedElement> _heatExchangerReference = new Lazy<ITypedElement>(RetrieveHeatExchangerReference);
        
        /// <summary>
        /// The backing field for the HeatExchanger property
        /// </summary>
        private IHeatExchanger _heatExchanger;
        
        private static Lazy<ITypedElement> _transformerWindingsReference = new Lazy<ITypedElement>(RetrieveTransformerWindingsReference);
        
        /// <summary>
        /// The backing field for the TransformerWindings property
        /// </summary>
        private PowerTransformerTransformerWindingsCollection _transformerWindings;
        
        private static IClass _classInstance;
        
        public PowerTransformer()
        {
            this._flowgates = new PowerTransformerFlowgatesCollection(this);
            this._flowgates.CollectionChanging += this.FlowgatesCollectionChanging;
            this._flowgates.CollectionChanged += this.FlowgatesCollectionChanged;
            this._transformerWindings = new PowerTransformerTransformerWindingsCollection(this);
            this._transformerWindings.CollectionChanging += this.TransformerWindingsCollectionChanging;
            this._transformerWindings.CollectionChanged += this.TransformerWindingsCollectionChanged;
        }
        
        /// <summary>
        /// The magBaseU property
        /// </summary>
        [XmlElementNameAttribute("magBaseU")]
        [XmlAttributeAttribute(true)]
        public virtual float MagBaseU
        {
            get
            {
                return this._magBaseU;
            }
            set
            {
                if ((this._magBaseU != value))
                {
                    float old = this._magBaseU;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnMagBaseUChanging(e);
                    this.OnPropertyChanging("MagBaseU", e, _magBaseUAttribute);
                    this._magBaseU = value;
                    this.OnMagBaseUChanged(e);
                    this.OnPropertyChanged("MagBaseU", e, _magBaseUAttribute);
                }
            }
        }
        
        /// <summary>
        /// The magSatFlux property
        /// </summary>
        [XmlElementNameAttribute("magSatFlux")]
        [XmlAttributeAttribute(true)]
        public virtual float MagSatFlux
        {
            get
            {
                return this._magSatFlux;
            }
            set
            {
                if ((this._magSatFlux != value))
                {
                    float old = this._magSatFlux;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnMagSatFluxChanging(e);
                    this.OnPropertyChanging("MagSatFlux", e, _magSatFluxAttribute);
                    this._magSatFlux = value;
                    this.OnMagSatFluxChanged(e);
                    this.OnPropertyChanged("MagSatFlux", e, _magSatFluxAttribute);
                }
            }
        }
        
        /// <summary>
        /// The bmagSat property
        /// </summary>
        [XmlElementNameAttribute("bmagSat")]
        [XmlAttributeAttribute(true)]
        public virtual float BmagSat
        {
            get
            {
                return this._bmagSat;
            }
            set
            {
                if ((this._bmagSat != value))
                {
                    float old = this._bmagSat;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnBmagSatChanging(e);
                    this.OnPropertyChanging("BmagSat", e, _bmagSatAttribute);
                    this._bmagSat = value;
                    this.OnBmagSatChanged(e);
                    this.OnPropertyChanged("BmagSat", e, _bmagSatAttribute);
                }
            }
        }
        
        /// <summary>
        /// The Flowgates property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("PowerTransormers")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<IFlowgate> Flowgates
        {
            get
            {
                return this._flowgates;
            }
        }
        
        /// <summary>
        /// The HeatExchanger property
        /// </summary>
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("PowerTransformer")]
        public virtual IHeatExchanger HeatExchanger
        {
            get
            {
                return this._heatExchanger;
            }
            set
            {
                if ((this._heatExchanger != value))
                {
                    IHeatExchanger old = this._heatExchanger;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnHeatExchangerChanging(e);
                    this.OnPropertyChanging("HeatExchanger", e, _heatExchangerReference);
                    this._heatExchanger = value;
                    if ((old != null))
                    {
                        old.PowerTransformer = null;
                        old.Deleted -= this.OnResetHeatExchanger;
                    }
                    if ((value != null))
                    {
                        value.PowerTransformer = this;
                        value.Deleted += this.OnResetHeatExchanger;
                    }
                    this.OnHeatExchangerChanged(e);
                    this.OnPropertyChanged("HeatExchanger", e, _heatExchangerReference);
                }
            }
        }
        
        /// <summary>
        /// The TransformerWindings property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("PowerTransformer")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<ITransformerWinding> TransformerWindings
        {
            get
            {
                return this._transformerWindings;
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new PowerTransformerReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Wires/PowerTransformer")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the MagBaseU property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> MagBaseUChanging;
        
        /// <summary>
        /// Gets fired when the MagBaseU property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> MagBaseUChanged;
        
        /// <summary>
        /// Gets fired before the MagSatFlux property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> MagSatFluxChanging;
        
        /// <summary>
        /// Gets fired when the MagSatFlux property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> MagSatFluxChanged;
        
        /// <summary>
        /// Gets fired before the BmagSat property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> BmagSatChanging;
        
        /// <summary>
        /// Gets fired when the BmagSat property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> BmagSatChanged;
        
        /// <summary>
        /// Gets fired before the HeatExchanger property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> HeatExchangerChanging;
        
        /// <summary>
        /// Gets fired when the HeatExchanger property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> HeatExchangerChanged;
        
        private static ITypedElement RetrieveMagBaseUAttribute()
        {
            return ((ITypedElement)(((ModelElement)(PowerTransformer.ClassInstance)).Resolve("magBaseU")));
        }
        
        /// <summary>
        /// Raises the MagBaseUChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnMagBaseUChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.MagBaseUChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the MagBaseUChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnMagBaseUChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.MagBaseUChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveMagSatFluxAttribute()
        {
            return ((ITypedElement)(((ModelElement)(PowerTransformer.ClassInstance)).Resolve("magSatFlux")));
        }
        
        /// <summary>
        /// Raises the MagSatFluxChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnMagSatFluxChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.MagSatFluxChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the MagSatFluxChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnMagSatFluxChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.MagSatFluxChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveBmagSatAttribute()
        {
            return ((ITypedElement)(((ModelElement)(PowerTransformer.ClassInstance)).Resolve("bmagSat")));
        }
        
        /// <summary>
        /// Raises the BmagSatChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnBmagSatChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.BmagSatChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the BmagSatChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnBmagSatChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.BmagSatChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveFlowgatesReference()
        {
            return ((ITypedElement)(((ModelElement)(PowerTransformer.ClassInstance)).Resolve("Flowgates")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the Flowgates property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void FlowgatesCollectionChanging(object sender, NMF.Collections.ObjectModel.NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("Flowgates", e, _flowgatesReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the Flowgates property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void FlowgatesCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("Flowgates", e, _flowgatesReference);
        }
        
        private static ITypedElement RetrieveHeatExchangerReference()
        {
            return ((ITypedElement)(((ModelElement)(PowerTransformer.ClassInstance)).Resolve("HeatExchanger")));
        }
        
        /// <summary>
        /// Raises the HeatExchangerChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnHeatExchangerChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.HeatExchangerChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the HeatExchangerChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnHeatExchangerChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.HeatExchangerChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the HeatExchanger property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetHeatExchanger(object sender, System.EventArgs eventArgs)
        {
            this.HeatExchanger = null;
        }
        
        private static ITypedElement RetrieveTransformerWindingsReference()
        {
            return ((ITypedElement)(((ModelElement)(PowerTransformer.ClassInstance)).Resolve("TransformerWindings")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the TransformerWindings property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void TransformerWindingsCollectionChanging(object sender, NMF.Collections.ObjectModel.NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("TransformerWindings", e, _transformerWindingsReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the TransformerWindings property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void TransformerWindingsCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("TransformerWindings", e, _transformerWindingsReference);
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "MAGBASEU"))
            {
                return this.MagBaseU;
            }
            if ((attribute == "MAGSATFLUX"))
            {
                return this.MagSatFlux;
            }
            if ((attribute == "BMAGSAT"))
            {
                return this.BmagSat;
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
            if ((feature == "FLOWGATES"))
            {
                return this._flowgates;
            }
            if ((feature == "TRANSFORMERWINDINGS"))
            {
                return this._transformerWindings;
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
            if ((feature == "HEATEXCHANGER"))
            {
                this.HeatExchanger = ((IHeatExchanger)(value));
                return;
            }
            if ((feature == "MAGBASEU"))
            {
                this.MagBaseU = ((float)(value));
                return;
            }
            if ((feature == "MAGSATFLUX"))
            {
                this.MagSatFlux = ((float)(value));
                return;
            }
            if ((feature == "BMAGSAT"))
            {
                this.BmagSat = ((float)(value));
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
            if ((attribute == "HeatExchanger"))
            {
                return new HeatExchangerProxy(this);
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
            if ((reference == "HeatExchanger"))
            {
                return new HeatExchangerProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Wires/PowerTransformer")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the PowerTransformer class
        /// </summary>
        public class PowerTransformerReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private PowerTransformer _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public PowerTransformerReferencedElementsCollection(PowerTransformer parent)
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
                    count = (count + this._parent.Flowgates.Count);
                    if ((this._parent.HeatExchanger != null))
                    {
                        count = (count + 1);
                    }
                    count = (count + this._parent.TransformerWindings.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.Flowgates.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.HeatExchangerChanged += this.PropagateValueChanges;
                this._parent.TransformerWindings.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.Flowgates.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.HeatExchangerChanged -= this.PropagateValueChanges;
                this._parent.TransformerWindings.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IFlowgate flowgatesCasted = item.As<IFlowgate>();
                if ((flowgatesCasted != null))
                {
                    this._parent.Flowgates.Add(flowgatesCasted);
                }
                if ((this._parent.HeatExchanger == null))
                {
                    IHeatExchanger heatExchangerCasted = item.As<IHeatExchanger>();
                    if ((heatExchangerCasted != null))
                    {
                        this._parent.HeatExchanger = heatExchangerCasted;
                        return;
                    }
                }
                ITransformerWinding transformerWindingsCasted = item.As<ITransformerWinding>();
                if ((transformerWindingsCasted != null))
                {
                    this._parent.TransformerWindings.Add(transformerWindingsCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.Flowgates.Clear();
                this._parent.HeatExchanger = null;
                this._parent.TransformerWindings.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.Flowgates.Contains(item))
                {
                    return true;
                }
                if ((item == this._parent.HeatExchanger))
                {
                    return true;
                }
                if (this._parent.TransformerWindings.Contains(item))
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
                IEnumerator<IModelElement> flowgatesEnumerator = this._parent.Flowgates.GetEnumerator();
                try
                {
                    for (
                    ; flowgatesEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = flowgatesEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    flowgatesEnumerator.Dispose();
                }
                if ((this._parent.HeatExchanger != null))
                {
                    array[arrayIndex] = this._parent.HeatExchanger;
                    arrayIndex = (arrayIndex + 1);
                }
                IEnumerator<IModelElement> transformerWindingsEnumerator = this._parent.TransformerWindings.GetEnumerator();
                try
                {
                    for (
                    ; transformerWindingsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = transformerWindingsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    transformerWindingsEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IFlowgate flowgateItem = item.As<IFlowgate>();
                if (((flowgateItem != null) 
                            && this._parent.Flowgates.Remove(flowgateItem)))
                {
                    return true;
                }
                if ((this._parent.HeatExchanger == item))
                {
                    this._parent.HeatExchanger = null;
                    return true;
                }
                ITransformerWinding transformerWindingItem = item.As<ITransformerWinding>();
                if (((transformerWindingItem != null) 
                            && this._parent.TransformerWindings.Remove(transformerWindingItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.Flowgates).Concat(this._parent.HeatExchanger).Concat(this._parent.TransformerWindings).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the magBaseU property
        /// </summary>
        private sealed class MagBaseUProxy : ModelPropertyChange<IPowerTransformer, float>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public MagBaseUProxy(IPowerTransformer modelElement) : 
                    base(modelElement, "magBaseU")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override float Value
            {
                get
                {
                    return this.ModelElement.MagBaseU;
                }
                set
                {
                    this.ModelElement.MagBaseU = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the magSatFlux property
        /// </summary>
        private sealed class MagSatFluxProxy : ModelPropertyChange<IPowerTransformer, float>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public MagSatFluxProxy(IPowerTransformer modelElement) : 
                    base(modelElement, "magSatFlux")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override float Value
            {
                get
                {
                    return this.ModelElement.MagSatFlux;
                }
                set
                {
                    this.ModelElement.MagSatFlux = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the bmagSat property
        /// </summary>
        private sealed class BmagSatProxy : ModelPropertyChange<IPowerTransformer, float>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public BmagSatProxy(IPowerTransformer modelElement) : 
                    base(modelElement, "bmagSat")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override float Value
            {
                get
                {
                    return this.ModelElement.BmagSat;
                }
                set
                {
                    this.ModelElement.BmagSat = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the HeatExchanger property
        /// </summary>
        private sealed class HeatExchangerProxy : ModelPropertyChange<IPowerTransformer, IHeatExchanger>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public HeatExchangerProxy(IPowerTransformer modelElement) : 
                    base(modelElement, "HeatExchanger")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IHeatExchanger Value
            {
                get
                {
                    return this.ModelElement.HeatExchanger;
                }
                set
                {
                    this.ModelElement.HeatExchanger = value;
                }
            }
        }
    }
}

