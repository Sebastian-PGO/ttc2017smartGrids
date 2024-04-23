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
    /// The default implementation of the PenstockLossCurve class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#Production")]
    [XmlNamespacePrefixAttribute("cimProduction")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Generation/Production/Penstoc" +
        "kLossCurve")]
    [DebuggerDisplayAttribute("PenstockLossCurve {UUID}")]
    public partial class PenstockLossCurve : Curve, IPenstockLossCurve, IModelElement
    {
        
        private static Lazy<ITypedElement> _hydroGeneratingUnitReference = new Lazy<ITypedElement>(RetrieveHydroGeneratingUnitReference);
        
        /// <summary>
        /// The backing field for the HydroGeneratingUnit property
        /// </summary>
        private IHydroGeneratingUnit _hydroGeneratingUnit;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The HydroGeneratingUnit property
        /// </summary>
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("PenstockLossCurve")]
        public virtual IHydroGeneratingUnit HydroGeneratingUnit
        {
            get
            {
                return this._hydroGeneratingUnit;
            }
            set
            {
                if ((this._hydroGeneratingUnit != value))
                {
                    IHydroGeneratingUnit old = this._hydroGeneratingUnit;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnHydroGeneratingUnitChanging(e);
                    this.OnPropertyChanging("HydroGeneratingUnit", e, _hydroGeneratingUnitReference);
                    this._hydroGeneratingUnit = value;
                    if ((old != null))
                    {
                        old.PenstockLossCurve = null;
                        old.Deleted -= this.OnResetHydroGeneratingUnit;
                    }
                    if ((value != null))
                    {
                        value.PenstockLossCurve = this;
                        value.Deleted += this.OnResetHydroGeneratingUnit;
                    }
                    this.OnHydroGeneratingUnitChanged(e);
                    this.OnPropertyChanged("HydroGeneratingUnit", e, _hydroGeneratingUnitReference);
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
                return base.ReferencedElements.Concat(new PenstockLossCurveReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Generation/Production/Penstoc" +
                            "kLossCurve")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the HydroGeneratingUnit property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> HydroGeneratingUnitChanging;
        
        /// <summary>
        /// Gets fired when the HydroGeneratingUnit property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> HydroGeneratingUnitChanged;
        
        private static ITypedElement RetrieveHydroGeneratingUnitReference()
        {
            return ((ITypedElement)(((ModelElement)(PenstockLossCurve.ClassInstance)).Resolve("HydroGeneratingUnit")));
        }
        
        /// <summary>
        /// Raises the HydroGeneratingUnitChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnHydroGeneratingUnitChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.HydroGeneratingUnitChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the HydroGeneratingUnitChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnHydroGeneratingUnitChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.HydroGeneratingUnitChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the HydroGeneratingUnit property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetHydroGeneratingUnit(object sender, System.EventArgs eventArgs)
        {
            this.HydroGeneratingUnit = null;
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "HYDROGENERATINGUNIT"))
            {
                this.HydroGeneratingUnit = ((IHydroGeneratingUnit)(value));
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
            if ((attribute == "HydroGeneratingUnit"))
            {
                return new HydroGeneratingUnitProxy(this);
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
            if ((reference == "HydroGeneratingUnit"))
            {
                return new HydroGeneratingUnitProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Generation/Production/Penstoc" +
                        "kLossCurve")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the PenstockLossCurve class
        /// </summary>
        public class PenstockLossCurveReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private PenstockLossCurve _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public PenstockLossCurveReferencedElementsCollection(PenstockLossCurve parent)
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
                    if ((this._parent.HydroGeneratingUnit != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.HydroGeneratingUnitChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.HydroGeneratingUnitChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.HydroGeneratingUnit == null))
                {
                    IHydroGeneratingUnit hydroGeneratingUnitCasted = item.As<IHydroGeneratingUnit>();
                    if ((hydroGeneratingUnitCasted != null))
                    {
                        this._parent.HydroGeneratingUnit = hydroGeneratingUnitCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.HydroGeneratingUnit = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.HydroGeneratingUnit))
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
                if ((this._parent.HydroGeneratingUnit != null))
                {
                    array[arrayIndex] = this._parent.HydroGeneratingUnit;
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
                if ((this._parent.HydroGeneratingUnit == item))
                {
                    this._parent.HydroGeneratingUnit = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.HydroGeneratingUnit).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the HydroGeneratingUnit property
        /// </summary>
        private sealed class HydroGeneratingUnitProxy : ModelPropertyChange<IPenstockLossCurve, IHydroGeneratingUnit>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public HydroGeneratingUnitProxy(IPenstockLossCurve modelElement) : 
                    base(modelElement, "HydroGeneratingUnit")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IHydroGeneratingUnit Value
            {
                get
                {
                    return this.ModelElement.HydroGeneratingUnit;
                }
                set
                {
                    this.ModelElement.HydroGeneratingUnit = value;
                }
            }
        }
    }
}

