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
using TTC2017.SmartGrids.CIM.IEC61968.Assets;
using TTC2017.SmartGrids.CIM.IEC61968.Common;
using TTC2017.SmartGrids.CIM.IEC61970.ControlArea;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.EnergyScheduling;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssets;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfERPSupport;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfGMLSupport;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.MarketOperations;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.Reservation;
using TTC2017.SmartGrids.CIM.IEC61970.SCADA;
using TTC2017.SmartGrids.CIM.IEC61970.Wires;

namespace TTC2017.SmartGrids.CIM.IEC61970.Meas
{
    
    
    /// <summary>
    /// The default implementation of the MeasurementValueSource class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#Meas")]
    [XmlNamespacePrefixAttribute("cimMeas")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Meas/MeasurementValueSource")]
    [DebuggerDisplayAttribute("MeasurementValueSource {UUID}")]
    public partial class MeasurementValueSource : IdentifiedObject, IMeasurementValueSource, IModelElement
    {
        
        private static Lazy<ITypedElement> _measurementValuesReference = new Lazy<ITypedElement>(RetrieveMeasurementValuesReference);
        
        /// <summary>
        /// The backing field for the MeasurementValues property
        /// </summary>
        private MeasurementValueSourceMeasurementValuesCollection _measurementValues;
        
        private static IClass _classInstance;
        
        public MeasurementValueSource()
        {
            this._measurementValues = new MeasurementValueSourceMeasurementValuesCollection(this);
            this._measurementValues.CollectionChanging += this.MeasurementValuesCollectionChanging;
            this._measurementValues.CollectionChanged += this.MeasurementValuesCollectionChanged;
        }
        
        /// <summary>
        /// The MeasurementValues property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("MeasurementValueSource")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<IMeasurementValue> MeasurementValues
        {
            get
            {
                return this._measurementValues;
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new MeasurementValueSourceReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Meas/MeasurementValueSource")));
                }
                return _classInstance;
            }
        }
        
        private static ITypedElement RetrieveMeasurementValuesReference()
        {
            return ((ITypedElement)(((ModelElement)(MeasurementValueSource.ClassInstance)).Resolve("MeasurementValues")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the MeasurementValues property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void MeasurementValuesCollectionChanging(object sender, NMF.Collections.ObjectModel.NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("MeasurementValues", e, _measurementValuesReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the MeasurementValues property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void MeasurementValuesCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("MeasurementValues", e, _measurementValuesReference);
        }
        
        /// <summary>
        /// Gets the Model element collection for the given feature
        /// </summary>
        /// <returns>A non-generic list of elements</returns>
        /// <param name="feature">The requested feature</param>
        protected override System.Collections.IList GetCollectionForFeature(string feature)
        {
            if ((feature == "MEASUREMENTVALUES"))
            {
                return this._measurementValues;
            }
            return base.GetCollectionForFeature(feature);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override IClass GetClass()
        {
            if ((_classInstance == null))
            {
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Meas/MeasurementValueSource")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the MeasurementValueSource class
        /// </summary>
        public class MeasurementValueSourceReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private MeasurementValueSource _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public MeasurementValueSourceReferencedElementsCollection(MeasurementValueSource parent)
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
                    count = (count + this._parent.MeasurementValues.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.MeasurementValues.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.MeasurementValues.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IMeasurementValue measurementValuesCasted = item.As<IMeasurementValue>();
                if ((measurementValuesCasted != null))
                {
                    this._parent.MeasurementValues.Add(measurementValuesCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.MeasurementValues.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.MeasurementValues.Contains(item))
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
                IEnumerator<IModelElement> measurementValuesEnumerator = this._parent.MeasurementValues.GetEnumerator();
                try
                {
                    for (
                    ; measurementValuesEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = measurementValuesEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    measurementValuesEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IMeasurementValue measurementValueItem = item.As<IMeasurementValue>();
                if (((measurementValueItem != null) 
                            && this._parent.MeasurementValues.Remove(measurementValueItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.MeasurementValues).GetEnumerator();
            }
        }
    }
}

