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
using TTC2017.SmartGrids.CIM.IEC61970.ControlArea;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Generation.GenerationDynamics;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.EnergyScheduling;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.Financial;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.MarketOperations;
using TTC2017.SmartGrids.CIM.IEC61970.Wires;

namespace TTC2017.SmartGrids.CIM.IEC61970.Generation.Production
{
    
    
    /// <summary>
    /// The default implementation of the ShutdownCurve class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#Production")]
    [XmlNamespacePrefixAttribute("cimProduction")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Generation/Production/Shutdow" +
        "nCurve")]
    [DebuggerDisplayAttribute("ShutdownCurve {UUID}")]
    public partial class ShutdownCurve : Curve, IShutdownCurve, IModelElement
    {
        
        /// <summary>
        /// The backing field for the ShutdownCost property
        /// </summary>
        private float _shutdownCost;
        
        private static Lazy<ITypedElement> _shutdownCostAttribute = new Lazy<ITypedElement>(RetrieveShutdownCostAttribute);
        
        /// <summary>
        /// The backing field for the ShutdownDate property
        /// </summary>
        private DateTime _shutdownDate;
        
        private static Lazy<ITypedElement> _shutdownDateAttribute = new Lazy<ITypedElement>(RetrieveShutdownDateAttribute);
        
        private static Lazy<ITypedElement> _thermalGeneratingUnitReference = new Lazy<ITypedElement>(RetrieveThermalGeneratingUnitReference);
        
        /// <summary>
        /// The backing field for the ThermalGeneratingUnit property
        /// </summary>
        private IThermalGeneratingUnit _thermalGeneratingUnit;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The shutdownCost property
        /// </summary>
        [XmlElementNameAttribute("shutdownCost")]
        [XmlAttributeAttribute(true)]
        public virtual float ShutdownCost
        {
            get
            {
                return this._shutdownCost;
            }
            set
            {
                if ((this._shutdownCost != value))
                {
                    float old = this._shutdownCost;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnShutdownCostChanging(e);
                    this.OnPropertyChanging("ShutdownCost", e, _shutdownCostAttribute);
                    this._shutdownCost = value;
                    this.OnShutdownCostChanged(e);
                    this.OnPropertyChanged("ShutdownCost", e, _shutdownCostAttribute);
                }
            }
        }
        
        /// <summary>
        /// The shutdownDate property
        /// </summary>
        [XmlElementNameAttribute("shutdownDate")]
        [XmlAttributeAttribute(true)]
        public virtual DateTime ShutdownDate
        {
            get
            {
                return this._shutdownDate;
            }
            set
            {
                if ((this._shutdownDate != value))
                {
                    DateTime old = this._shutdownDate;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnShutdownDateChanging(e);
                    this.OnPropertyChanging("ShutdownDate", e, _shutdownDateAttribute);
                    this._shutdownDate = value;
                    this.OnShutdownDateChanged(e);
                    this.OnPropertyChanged("ShutdownDate", e, _shutdownDateAttribute);
                }
            }
        }
        
        /// <summary>
        /// The ThermalGeneratingUnit property
        /// </summary>
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("ShutdownCurve")]
        public virtual IThermalGeneratingUnit ThermalGeneratingUnit
        {
            get
            {
                return this._thermalGeneratingUnit;
            }
            set
            {
                if ((this._thermalGeneratingUnit != value))
                {
                    IThermalGeneratingUnit old = this._thermalGeneratingUnit;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnThermalGeneratingUnitChanging(e);
                    this.OnPropertyChanging("ThermalGeneratingUnit", e, _thermalGeneratingUnitReference);
                    this._thermalGeneratingUnit = value;
                    if ((old != null))
                    {
                        old.ShutdownCurve = null;
                        old.Deleted -= this.OnResetThermalGeneratingUnit;
                    }
                    if ((value != null))
                    {
                        value.ShutdownCurve = this;
                        value.Deleted += this.OnResetThermalGeneratingUnit;
                    }
                    this.OnThermalGeneratingUnitChanged(e);
                    this.OnPropertyChanged("ThermalGeneratingUnit", e, _thermalGeneratingUnitReference);
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
                return base.ReferencedElements.Concat(new ShutdownCurveReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Generation/Production/Shutdow" +
                            "nCurve")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the ShutdownCost property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ShutdownCostChanging;
        
        /// <summary>
        /// Gets fired when the ShutdownCost property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ShutdownCostChanged;
        
        /// <summary>
        /// Gets fired before the ShutdownDate property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ShutdownDateChanging;
        
        /// <summary>
        /// Gets fired when the ShutdownDate property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ShutdownDateChanged;
        
        /// <summary>
        /// Gets fired before the ThermalGeneratingUnit property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ThermalGeneratingUnitChanging;
        
        /// <summary>
        /// Gets fired when the ThermalGeneratingUnit property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ThermalGeneratingUnitChanged;
        
        private static ITypedElement RetrieveShutdownCostAttribute()
        {
            return ((ITypedElement)(((ModelElement)(ShutdownCurve.ClassInstance)).Resolve("shutdownCost")));
        }
        
        /// <summary>
        /// Raises the ShutdownCostChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnShutdownCostChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ShutdownCostChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the ShutdownCostChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnShutdownCostChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ShutdownCostChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveShutdownDateAttribute()
        {
            return ((ITypedElement)(((ModelElement)(ShutdownCurve.ClassInstance)).Resolve("shutdownDate")));
        }
        
        /// <summary>
        /// Raises the ShutdownDateChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnShutdownDateChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ShutdownDateChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the ShutdownDateChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnShutdownDateChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ShutdownDateChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveThermalGeneratingUnitReference()
        {
            return ((ITypedElement)(((ModelElement)(ShutdownCurve.ClassInstance)).Resolve("ThermalGeneratingUnit")));
        }
        
        /// <summary>
        /// Raises the ThermalGeneratingUnitChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnThermalGeneratingUnitChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ThermalGeneratingUnitChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the ThermalGeneratingUnitChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnThermalGeneratingUnitChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ThermalGeneratingUnitChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the ThermalGeneratingUnit property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetThermalGeneratingUnit(object sender, System.EventArgs eventArgs)
        {
            this.ThermalGeneratingUnit = null;
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "SHUTDOWNCOST"))
            {
                return this.ShutdownCost;
            }
            if ((attribute == "SHUTDOWNDATE"))
            {
                return this.ShutdownDate;
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
            if ((feature == "THERMALGENERATINGUNIT"))
            {
                this.ThermalGeneratingUnit = ((IThermalGeneratingUnit)(value));
                return;
            }
            if ((feature == "SHUTDOWNCOST"))
            {
                this.ShutdownCost = ((float)(value));
                return;
            }
            if ((feature == "SHUTDOWNDATE"))
            {
                this.ShutdownDate = ((DateTime)(value));
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
            if ((attribute == "ThermalGeneratingUnit"))
            {
                return new ThermalGeneratingUnitProxy(this);
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
            if ((reference == "ThermalGeneratingUnit"))
            {
                return new ThermalGeneratingUnitProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Generation/Production/Shutdow" +
                        "nCurve")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the ShutdownCurve class
        /// </summary>
        public class ShutdownCurveReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private ShutdownCurve _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public ShutdownCurveReferencedElementsCollection(ShutdownCurve parent)
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
                    if ((this._parent.ThermalGeneratingUnit != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.ThermalGeneratingUnitChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.ThermalGeneratingUnitChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.ThermalGeneratingUnit == null))
                {
                    IThermalGeneratingUnit thermalGeneratingUnitCasted = item.As<IThermalGeneratingUnit>();
                    if ((thermalGeneratingUnitCasted != null))
                    {
                        this._parent.ThermalGeneratingUnit = thermalGeneratingUnitCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.ThermalGeneratingUnit = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.ThermalGeneratingUnit))
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
                if ((this._parent.ThermalGeneratingUnit != null))
                {
                    array[arrayIndex] = this._parent.ThermalGeneratingUnit;
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
                if ((this._parent.ThermalGeneratingUnit == item))
                {
                    this._parent.ThermalGeneratingUnit = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.ThermalGeneratingUnit).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the shutdownCost property
        /// </summary>
        private sealed class ShutdownCostProxy : ModelPropertyChange<IShutdownCurve, float>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public ShutdownCostProxy(IShutdownCurve modelElement) : 
                    base(modelElement, "shutdownCost")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override float Value
            {
                get
                {
                    return this.ModelElement.ShutdownCost;
                }
                set
                {
                    this.ModelElement.ShutdownCost = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the shutdownDate property
        /// </summary>
        private sealed class ShutdownDateProxy : ModelPropertyChange<IShutdownCurve, DateTime>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public ShutdownDateProxy(IShutdownCurve modelElement) : 
                    base(modelElement, "shutdownDate")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override DateTime Value
            {
                get
                {
                    return this.ModelElement.ShutdownDate;
                }
                set
                {
                    this.ModelElement.ShutdownDate = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the ThermalGeneratingUnit property
        /// </summary>
        private sealed class ThermalGeneratingUnitProxy : ModelPropertyChange<IShutdownCurve, IThermalGeneratingUnit>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public ThermalGeneratingUnitProxy(IShutdownCurve modelElement) : 
                    base(modelElement, "ThermalGeneratingUnit")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IThermalGeneratingUnit Value
            {
                get
                {
                    return this.ModelElement.ThermalGeneratingUnit;
                }
                set
                {
                    this.ModelElement.ThermalGeneratingUnit = value;
                }
            }
        }
    }
}

