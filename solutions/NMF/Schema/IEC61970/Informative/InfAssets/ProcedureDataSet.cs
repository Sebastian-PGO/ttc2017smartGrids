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
using TTC2017.SmartGrids.CIM.IEC61968.AssetModels;
using TTC2017.SmartGrids.CIM.IEC61968.Assets;
using TTC2017.SmartGrids.CIM.IEC61968.Common;
using TTC2017.SmartGrids.CIM.IEC61968.Metering;
using TTC2017.SmartGrids.CIM.IEC61968.WiresExt;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssetModels;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfCommon;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfERPSupport;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfOperations;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfTypeAsset;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfWork;
using TTC2017.SmartGrids.CIM.IEC61970.Meas;
using TTC2017.SmartGrids.CIM.IEC61970.Wires;

namespace TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssets
{
    
    
    /// <summary>
    /// The default implementation of the ProcedureDataSet class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#InfAssets")]
    [XmlNamespacePrefixAttribute("cimInfAssets")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfAssets/Procedu" +
        "reDataSet")]
    [DebuggerDisplayAttribute("ProcedureDataSet {UUID}")]
    public partial class ProcedureDataSet : Document, IProcedureDataSet, IModelElement
    {
        
        /// <summary>
        /// The backing field for the CompletedDateTime property
        /// </summary>
        private DateTime _completedDateTime;
        
        private static Lazy<ITypedElement> _completedDateTimeAttribute = new Lazy<ITypedElement>(RetrieveCompletedDateTimeAttribute);
        
        private static Lazy<ITypedElement> _measurementValuesReference = new Lazy<ITypedElement>(RetrieveMeasurementValuesReference);
        
        /// <summary>
        /// The backing field for the MeasurementValues property
        /// </summary>
        private ProcedureDataSetMeasurementValuesCollection _measurementValues;
        
        private static Lazy<ITypedElement> _transformerObservationsReference = new Lazy<ITypedElement>(RetrieveTransformerObservationsReference);
        
        /// <summary>
        /// The backing field for the TransformerObservations property
        /// </summary>
        private ProcedureDataSetTransformerObservationsCollection _transformerObservations;
        
        private static Lazy<ITypedElement> _propertiesReference = new Lazy<ITypedElement>(RetrievePropertiesReference);
        
        /// <summary>
        /// The backing field for the Properties property
        /// </summary>
        private ProcedureDataSetPropertiesCollection _properties;
        
        private static Lazy<ITypedElement> _procedureReference = new Lazy<ITypedElement>(RetrieveProcedureReference);
        
        /// <summary>
        /// The backing field for the Procedure property
        /// </summary>
        private IProcedure _procedure;
        
        private static IClass _classInstance;
        
        public ProcedureDataSet()
        {
            this._measurementValues = new ProcedureDataSetMeasurementValuesCollection(this);
            this._measurementValues.CollectionChanging += this.MeasurementValuesCollectionChanging;
            this._measurementValues.CollectionChanged += this.MeasurementValuesCollectionChanged;
            this._transformerObservations = new ProcedureDataSetTransformerObservationsCollection(this);
            this._transformerObservations.CollectionChanging += this.TransformerObservationsCollectionChanging;
            this._transformerObservations.CollectionChanged += this.TransformerObservationsCollectionChanged;
            this._properties = new ProcedureDataSetPropertiesCollection(this);
            this._properties.CollectionChanging += this.PropertiesCollectionChanging;
            this._properties.CollectionChanged += this.PropertiesCollectionChanged;
        }
        
        /// <summary>
        /// The completedDateTime property
        /// </summary>
        [XmlElementNameAttribute("completedDateTime")]
        [XmlAttributeAttribute(true)]
        public virtual DateTime CompletedDateTime
        {
            get
            {
                return this._completedDateTime;
            }
            set
            {
                if ((this._completedDateTime != value))
                {
                    DateTime old = this._completedDateTime;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnCompletedDateTimeChanging(e);
                    this.OnPropertyChanging("CompletedDateTime", e, _completedDateTimeAttribute);
                    this._completedDateTime = value;
                    this.OnCompletedDateTimeChanged(e);
                    this.OnPropertyChanged("CompletedDateTime", e, _completedDateTimeAttribute);
                }
            }
        }
        
        /// <summary>
        /// The MeasurementValues property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("ProcedureDataSets")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<IMeasurementValue> MeasurementValues
        {
            get
            {
                return this._measurementValues;
            }
        }
        
        /// <summary>
        /// The TransformerObservations property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("ProcedureDataSets")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<ITransformerObservation> TransformerObservations
        {
            get
            {
                return this._transformerObservations;
            }
        }
        
        /// <summary>
        /// The Properties property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("ProcedureDataSets")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<IUserAttribute> Properties
        {
            get
            {
                return this._properties;
            }
        }
        
        /// <summary>
        /// The Procedure property
        /// </summary>
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("ProcedureDataSets")]
        public virtual IProcedure Procedure
        {
            get
            {
                return this._procedure;
            }
            set
            {
                if ((this._procedure != value))
                {
                    IProcedure old = this._procedure;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnProcedureChanging(e);
                    this.OnPropertyChanging("Procedure", e, _procedureReference);
                    this._procedure = value;
                    if ((old != null))
                    {
                        old.ProcedureDataSets.Remove(this);
                        old.Deleted -= this.OnResetProcedure;
                    }
                    if ((value != null))
                    {
                        value.ProcedureDataSets.Add(this);
                        value.Deleted += this.OnResetProcedure;
                    }
                    this.OnProcedureChanged(e);
                    this.OnPropertyChanged("Procedure", e, _procedureReference);
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
                return base.ReferencedElements.Concat(new ProcedureDataSetReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfAssets/Procedu" +
                            "reDataSet")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the CompletedDateTime property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> CompletedDateTimeChanging;
        
        /// <summary>
        /// Gets fired when the CompletedDateTime property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> CompletedDateTimeChanged;
        
        /// <summary>
        /// Gets fired before the Procedure property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ProcedureChanging;
        
        /// <summary>
        /// Gets fired when the Procedure property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ProcedureChanged;
        
        private static ITypedElement RetrieveCompletedDateTimeAttribute()
        {
            return ((ITypedElement)(((ModelElement)(ProcedureDataSet.ClassInstance)).Resolve("completedDateTime")));
        }
        
        /// <summary>
        /// Raises the CompletedDateTimeChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnCompletedDateTimeChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.CompletedDateTimeChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the CompletedDateTimeChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnCompletedDateTimeChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.CompletedDateTimeChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveMeasurementValuesReference()
        {
            return ((ITypedElement)(((ModelElement)(ProcedureDataSet.ClassInstance)).Resolve("MeasurementValues")));
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
        
        private static ITypedElement RetrieveTransformerObservationsReference()
        {
            return ((ITypedElement)(((ModelElement)(ProcedureDataSet.ClassInstance)).Resolve("TransformerObservations")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the TransformerObservations property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void TransformerObservationsCollectionChanging(object sender, NMF.Collections.ObjectModel.NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("TransformerObservations", e, _transformerObservationsReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the TransformerObservations property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void TransformerObservationsCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("TransformerObservations", e, _transformerObservationsReference);
        }
        
        private static ITypedElement RetrievePropertiesReference()
        {
            return ((ITypedElement)(((ModelElement)(ProcedureDataSet.ClassInstance)).Resolve("Properties")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the Properties property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void PropertiesCollectionChanging(object sender, NMF.Collections.ObjectModel.NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("Properties", e, _propertiesReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the Properties property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void PropertiesCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("Properties", e, _propertiesReference);
        }
        
        private static ITypedElement RetrieveProcedureReference()
        {
            return ((ITypedElement)(((ModelElement)(ProcedureDataSet.ClassInstance)).Resolve("Procedure")));
        }
        
        /// <summary>
        /// Raises the ProcedureChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnProcedureChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ProcedureChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the ProcedureChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnProcedureChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ProcedureChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the Procedure property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetProcedure(object sender, System.EventArgs eventArgs)
        {
            this.Procedure = null;
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "COMPLETEDDATETIME"))
            {
                return this.CompletedDateTime;
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
            if ((feature == "MEASUREMENTVALUES"))
            {
                return this._measurementValues;
            }
            if ((feature == "TRANSFORMEROBSERVATIONS"))
            {
                return this._transformerObservations;
            }
            if ((feature == "PROPERTIES"))
            {
                return this._properties;
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
            if ((feature == "PROCEDURE"))
            {
                this.Procedure = ((IProcedure)(value));
                return;
            }
            if ((feature == "COMPLETEDDATETIME"))
            {
                this.CompletedDateTime = ((DateTime)(value));
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
            if ((attribute == "Procedure"))
            {
                return new ProcedureProxy(this);
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
            if ((reference == "Procedure"))
            {
                return new ProcedureProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfAssets/Procedu" +
                        "reDataSet")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the ProcedureDataSet class
        /// </summary>
        public class ProcedureDataSetReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private ProcedureDataSet _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public ProcedureDataSetReferencedElementsCollection(ProcedureDataSet parent)
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
                    count = (count + this._parent.TransformerObservations.Count);
                    count = (count + this._parent.Properties.Count);
                    if ((this._parent.Procedure != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.MeasurementValues.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.TransformerObservations.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.Properties.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.ProcedureChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.MeasurementValues.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.TransformerObservations.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.Properties.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.ProcedureChanged -= this.PropagateValueChanges;
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
                ITransformerObservation transformerObservationsCasted = item.As<ITransformerObservation>();
                if ((transformerObservationsCasted != null))
                {
                    this._parent.TransformerObservations.Add(transformerObservationsCasted);
                }
                IUserAttribute propertiesCasted = item.As<IUserAttribute>();
                if ((propertiesCasted != null))
                {
                    this._parent.Properties.Add(propertiesCasted);
                }
                if ((this._parent.Procedure == null))
                {
                    IProcedure procedureCasted = item.As<IProcedure>();
                    if ((procedureCasted != null))
                    {
                        this._parent.Procedure = procedureCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.MeasurementValues.Clear();
                this._parent.TransformerObservations.Clear();
                this._parent.Properties.Clear();
                this._parent.Procedure = null;
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
                if (this._parent.TransformerObservations.Contains(item))
                {
                    return true;
                }
                if (this._parent.Properties.Contains(item))
                {
                    return true;
                }
                if ((item == this._parent.Procedure))
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
                IEnumerator<IModelElement> transformerObservationsEnumerator = this._parent.TransformerObservations.GetEnumerator();
                try
                {
                    for (
                    ; transformerObservationsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = transformerObservationsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    transformerObservationsEnumerator.Dispose();
                }
                IEnumerator<IModelElement> propertiesEnumerator = this._parent.Properties.GetEnumerator();
                try
                {
                    for (
                    ; propertiesEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = propertiesEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    propertiesEnumerator.Dispose();
                }
                if ((this._parent.Procedure != null))
                {
                    array[arrayIndex] = this._parent.Procedure;
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
                IMeasurementValue measurementValueItem = item.As<IMeasurementValue>();
                if (((measurementValueItem != null) 
                            && this._parent.MeasurementValues.Remove(measurementValueItem)))
                {
                    return true;
                }
                ITransformerObservation transformerObservationItem = item.As<ITransformerObservation>();
                if (((transformerObservationItem != null) 
                            && this._parent.TransformerObservations.Remove(transformerObservationItem)))
                {
                    return true;
                }
                IUserAttribute userAttributeItem = item.As<IUserAttribute>();
                if (((userAttributeItem != null) 
                            && this._parent.Properties.Remove(userAttributeItem)))
                {
                    return true;
                }
                if ((this._parent.Procedure == item))
                {
                    this._parent.Procedure = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.MeasurementValues).Concat(this._parent.TransformerObservations).Concat(this._parent.Properties).Concat(this._parent.Procedure).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the completedDateTime property
        /// </summary>
        private sealed class CompletedDateTimeProxy : ModelPropertyChange<IProcedureDataSet, DateTime>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public CompletedDateTimeProxy(IProcedureDataSet modelElement) : 
                    base(modelElement, "completedDateTime")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override DateTime Value
            {
                get
                {
                    return this.ModelElement.CompletedDateTime;
                }
                set
                {
                    this.ModelElement.CompletedDateTime = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the Procedure property
        /// </summary>
        private sealed class ProcedureProxy : ModelPropertyChange<IProcedureDataSet, IProcedure>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public ProcedureProxy(IProcedureDataSet modelElement) : 
                    base(modelElement, "Procedure")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IProcedure Value
            {
                get
                {
                    return this.ModelElement.Procedure;
                }
                set
                {
                    this.ModelElement.Procedure = value;
                }
            }
        }
    }
}

