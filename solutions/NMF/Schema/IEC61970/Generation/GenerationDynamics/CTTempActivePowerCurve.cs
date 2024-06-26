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
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Generation.Production;
using TTC2017.SmartGrids.CIM.IEC61970.Wires;

namespace TTC2017.SmartGrids.CIM.IEC61970.Generation.GenerationDynamics
{
    
    
    /// <summary>
    /// The default implementation of the CTTempActivePowerCurve class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#GenerationDynamics")]
    [XmlNamespacePrefixAttribute("cimGenerationDynamics")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Generation/GenerationDynamics" +
        "/CTTempActivePowerCurve")]
    [DebuggerDisplayAttribute("CTTempActivePowerCurve {UUID}")]
    public partial class CTTempActivePowerCurve : Curve, ICTTempActivePowerCurve, IModelElement
    {
        
        private static Lazy<ITypedElement> _combustionTurbineReference = new Lazy<ITypedElement>(RetrieveCombustionTurbineReference);
        
        /// <summary>
        /// The backing field for the CombustionTurbine property
        /// </summary>
        private ICombustionTurbine _combustionTurbine;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The CombustionTurbine property
        /// </summary>
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("CTTempActivePowerCurve")]
        public virtual ICombustionTurbine CombustionTurbine
        {
            get
            {
                return this._combustionTurbine;
            }
            set
            {
                if ((this._combustionTurbine != value))
                {
                    ICombustionTurbine old = this._combustionTurbine;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnCombustionTurbineChanging(e);
                    this.OnPropertyChanging("CombustionTurbine", e, _combustionTurbineReference);
                    this._combustionTurbine = value;
                    if ((old != null))
                    {
                        old.CTTempActivePowerCurve = null;
                        old.Deleted -= this.OnResetCombustionTurbine;
                    }
                    if ((value != null))
                    {
                        value.CTTempActivePowerCurve = this;
                        value.Deleted += this.OnResetCombustionTurbine;
                    }
                    this.OnCombustionTurbineChanged(e);
                    this.OnPropertyChanged("CombustionTurbine", e, _combustionTurbineReference);
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
                return base.ReferencedElements.Concat(new CTTempActivePowerCurveReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Generation/GenerationDynamics" +
                            "/CTTempActivePowerCurve")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the CombustionTurbine property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> CombustionTurbineChanging;
        
        /// <summary>
        /// Gets fired when the CombustionTurbine property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> CombustionTurbineChanged;
        
        private static ITypedElement RetrieveCombustionTurbineReference()
        {
            return ((ITypedElement)(((ModelElement)(CTTempActivePowerCurve.ClassInstance)).Resolve("CombustionTurbine")));
        }
        
        /// <summary>
        /// Raises the CombustionTurbineChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnCombustionTurbineChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.CombustionTurbineChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the CombustionTurbineChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnCombustionTurbineChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.CombustionTurbineChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the CombustionTurbine property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetCombustionTurbine(object sender, System.EventArgs eventArgs)
        {
            this.CombustionTurbine = null;
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "COMBUSTIONTURBINE"))
            {
                this.CombustionTurbine = ((ICombustionTurbine)(value));
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
            if ((attribute == "CombustionTurbine"))
            {
                return new CombustionTurbineProxy(this);
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
            if ((reference == "CombustionTurbine"))
            {
                return new CombustionTurbineProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Generation/GenerationDynamics" +
                        "/CTTempActivePowerCurve")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the CTTempActivePowerCurve class
        /// </summary>
        public class CTTempActivePowerCurveReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private CTTempActivePowerCurve _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public CTTempActivePowerCurveReferencedElementsCollection(CTTempActivePowerCurve parent)
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
                    if ((this._parent.CombustionTurbine != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.CombustionTurbineChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.CombustionTurbineChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.CombustionTurbine == null))
                {
                    ICombustionTurbine combustionTurbineCasted = item.As<ICombustionTurbine>();
                    if ((combustionTurbineCasted != null))
                    {
                        this._parent.CombustionTurbine = combustionTurbineCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.CombustionTurbine = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.CombustionTurbine))
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
                if ((this._parent.CombustionTurbine != null))
                {
                    array[arrayIndex] = this._parent.CombustionTurbine;
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
                if ((this._parent.CombustionTurbine == item))
                {
                    this._parent.CombustionTurbine = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.CombustionTurbine).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the CombustionTurbine property
        /// </summary>
        private sealed class CombustionTurbineProxy : ModelPropertyChange<ICTTempActivePowerCurve, ICombustionTurbine>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public CombustionTurbineProxy(ICTTempActivePowerCurve modelElement) : 
                    base(modelElement, "CombustionTurbine")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override ICombustionTurbine Value
            {
                get
                {
                    return this.ModelElement.CombustionTurbine;
                }
                set
                {
                    this.ModelElement.CombustionTurbine = value;
                }
            }
        }
    }
}

