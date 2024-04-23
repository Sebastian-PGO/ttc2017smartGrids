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
    /// The default implementation of the GrossToNetActivePowerCurve class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#Production")]
    [XmlNamespacePrefixAttribute("cimProduction")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Generation/Production/GrossTo" +
        "NetActivePowerCurve")]
    [DebuggerDisplayAttribute("GrossToNetActivePowerCurve {UUID}")]
    public partial class GrossToNetActivePowerCurve : Curve, IGrossToNetActivePowerCurve, IModelElement
    {
        
        private static Lazy<ITypedElement> _generatingUnitReference = new Lazy<ITypedElement>(RetrieveGeneratingUnitReference);
        
        /// <summary>
        /// The backing field for the GeneratingUnit property
        /// </summary>
        private IGeneratingUnit _generatingUnit;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The GeneratingUnit property
        /// </summary>
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("GrossToNetActivePowerCurves")]
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
                        old.GrossToNetActivePowerCurves.Remove(this);
                        old.Deleted -= this.OnResetGeneratingUnit;
                    }
                    if ((value != null))
                    {
                        value.GrossToNetActivePowerCurves.Add(this);
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
                return base.ReferencedElements.Concat(new GrossToNetActivePowerCurveReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Generation/Production/GrossTo" +
                            "NetActivePowerCurve")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the GeneratingUnit property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> GeneratingUnitChanging;
        
        /// <summary>
        /// Gets fired when the GeneratingUnit property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> GeneratingUnitChanged;
        
        private static ITypedElement RetrieveGeneratingUnitReference()
        {
            return ((ITypedElement)(((ModelElement)(GrossToNetActivePowerCurve.ClassInstance)).Resolve("GeneratingUnit")));
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
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Generation/Production/GrossTo" +
                        "NetActivePowerCurve")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the GrossToNetActivePowerCurve class
        /// </summary>
        public class GrossToNetActivePowerCurveReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private GrossToNetActivePowerCurve _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public GrossToNetActivePowerCurveReferencedElementsCollection(GrossToNetActivePowerCurve parent)
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
                    if ((this._parent.GeneratingUnit != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.GeneratingUnitChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.GeneratingUnitChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
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
                this._parent.GeneratingUnit = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.GeneratingUnit).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the GeneratingUnit property
        /// </summary>
        private sealed class GeneratingUnitProxy : ModelPropertyChange<IGrossToNetActivePowerCurve, IGeneratingUnit>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public GeneratingUnitProxy(IGrossToNetActivePowerCurve modelElement) : 
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

