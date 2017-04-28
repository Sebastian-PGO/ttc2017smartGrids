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
    /// The default implementation of the TransformerAsset class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#InfAssets")]
    [XmlNamespacePrefixAttribute("cimInfAssets")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfAssets/Transfo" +
        "rmerAsset")]
    [DebuggerDisplayAttribute("TransformerAsset {UUID}")]
    public partial class TransformerAsset : Asset, ITransformerAsset, IModelElement
    {
        
        /// <summary>
        /// The backing field for the ReconditionedDateTime property
        /// </summary>
        private DateTime _reconditionedDateTime;
        
        private static Lazy<ITypedElement> _reconditionedDateTimeAttribute = new Lazy<ITypedElement>(RetrieveReconditionedDateTimeAttribute);
        
        private static Lazy<ITypedElement> _powerRatingsReference = new Lazy<ITypedElement>(RetrievePowerRatingsReference);
        
        /// <summary>
        /// The backing field for the PowerRatings property
        /// </summary>
        private TransformerAssetPowerRatingsCollection _powerRatings;
        
        private static Lazy<ITypedElement> _transformerObservationsReference = new Lazy<ITypedElement>(RetrieveTransformerObservationsReference);
        
        /// <summary>
        /// The backing field for the TransformerObservations property
        /// </summary>
        private TransformerAssetTransformerObservationsCollection _transformerObservations;
        
        private static Lazy<ITypedElement> _transformerAssetModelReference = new Lazy<ITypedElement>(RetrieveTransformerAssetModelReference);
        
        /// <summary>
        /// The backing field for the TransformerAssetModel property
        /// </summary>
        private ITransformerAssetModel _transformerAssetModel;
        
        private static Lazy<ITypedElement> _transformerInfoReference = new Lazy<ITypedElement>(RetrieveTransformerInfoReference);
        
        /// <summary>
        /// The backing field for the TransformerInfo property
        /// </summary>
        private ITransformerInfo _transformerInfo;
        
        private static IClass _classInstance;
        
        public TransformerAsset()
        {
            this._powerRatings = new TransformerAssetPowerRatingsCollection(this);
            this._powerRatings.CollectionChanging += this.PowerRatingsCollectionChanging;
            this._powerRatings.CollectionChanged += this.PowerRatingsCollectionChanged;
            this._transformerObservations = new TransformerAssetTransformerObservationsCollection(this);
            this._transformerObservations.CollectionChanging += this.TransformerObservationsCollectionChanging;
            this._transformerObservations.CollectionChanged += this.TransformerObservationsCollectionChanged;
        }
        
        /// <summary>
        /// The reconditionedDateTime property
        /// </summary>
        [XmlElementNameAttribute("reconditionedDateTime")]
        [XmlAttributeAttribute(true)]
        public virtual DateTime ReconditionedDateTime
        {
            get
            {
                return this._reconditionedDateTime;
            }
            set
            {
                if ((this._reconditionedDateTime != value))
                {
                    DateTime old = this._reconditionedDateTime;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnReconditionedDateTimeChanging(e);
                    this.OnPropertyChanging("ReconditionedDateTime", e, _reconditionedDateTimeAttribute);
                    this._reconditionedDateTime = value;
                    this.OnReconditionedDateTimeChanged(e);
                    this.OnPropertyChanged("ReconditionedDateTime", e, _reconditionedDateTimeAttribute);
                }
            }
        }
        
        /// <summary>
        /// The PowerRatings property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("TransformerAssets")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<IPowerRating> PowerRatings
        {
            get
            {
                return this._powerRatings;
            }
        }
        
        /// <summary>
        /// The TransformerObservations property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("TransformerAsset")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<ITransformerObservation> TransformerObservations
        {
            get
            {
                return this._transformerObservations;
            }
        }
        
        /// <summary>
        /// The TransformerAssetModel property
        /// </summary>
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("TransformerAssets")]
        public virtual ITransformerAssetModel TransformerAssetModel
        {
            get
            {
                return this._transformerAssetModel;
            }
            set
            {
                if ((this._transformerAssetModel != value))
                {
                    ITransformerAssetModel old = this._transformerAssetModel;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnTransformerAssetModelChanging(e);
                    this.OnPropertyChanging("TransformerAssetModel", e, _transformerAssetModelReference);
                    this._transformerAssetModel = value;
                    if ((old != null))
                    {
                        old.TransformerAssets.Remove(this);
                        old.Deleted -= this.OnResetTransformerAssetModel;
                    }
                    if ((value != null))
                    {
                        value.TransformerAssets.Add(this);
                        value.Deleted += this.OnResetTransformerAssetModel;
                    }
                    this.OnTransformerAssetModelChanged(e);
                    this.OnPropertyChanged("TransformerAssetModel", e, _transformerAssetModelReference);
                }
            }
        }
        
        /// <summary>
        /// The TransformerInfo property
        /// </summary>
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("TransformerAssets")]
        public virtual ITransformerInfo TransformerInfo
        {
            get
            {
                return this._transformerInfo;
            }
            set
            {
                if ((this._transformerInfo != value))
                {
                    ITransformerInfo old = this._transformerInfo;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnTransformerInfoChanging(e);
                    this.OnPropertyChanging("TransformerInfo", e, _transformerInfoReference);
                    this._transformerInfo = value;
                    if ((old != null))
                    {
                        old.TransformerAssets.Remove(this);
                        old.Deleted -= this.OnResetTransformerInfo;
                    }
                    if ((value != null))
                    {
                        value.TransformerAssets.Add(this);
                        value.Deleted += this.OnResetTransformerInfo;
                    }
                    this.OnTransformerInfoChanged(e);
                    this.OnPropertyChanged("TransformerInfo", e, _transformerInfoReference);
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
                return base.ReferencedElements.Concat(new TransformerAssetReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfAssets/Transfo" +
                            "rmerAsset")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the ReconditionedDateTime property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ReconditionedDateTimeChanging;
        
        /// <summary>
        /// Gets fired when the ReconditionedDateTime property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ReconditionedDateTimeChanged;
        
        /// <summary>
        /// Gets fired before the TransformerAssetModel property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> TransformerAssetModelChanging;
        
        /// <summary>
        /// Gets fired when the TransformerAssetModel property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> TransformerAssetModelChanged;
        
        /// <summary>
        /// Gets fired before the TransformerInfo property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> TransformerInfoChanging;
        
        /// <summary>
        /// Gets fired when the TransformerInfo property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> TransformerInfoChanged;
        
        private static ITypedElement RetrieveReconditionedDateTimeAttribute()
        {
            return ((ITypedElement)(((ModelElement)(TransformerAsset.ClassInstance)).Resolve("reconditionedDateTime")));
        }
        
        /// <summary>
        /// Raises the ReconditionedDateTimeChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnReconditionedDateTimeChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ReconditionedDateTimeChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the ReconditionedDateTimeChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnReconditionedDateTimeChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ReconditionedDateTimeChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrievePowerRatingsReference()
        {
            return ((ITypedElement)(((ModelElement)(TransformerAsset.ClassInstance)).Resolve("PowerRatings")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the PowerRatings property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void PowerRatingsCollectionChanging(object sender, NMF.Collections.ObjectModel.NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("PowerRatings", e, _powerRatingsReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the PowerRatings property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void PowerRatingsCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("PowerRatings", e, _powerRatingsReference);
        }
        
        private static ITypedElement RetrieveTransformerObservationsReference()
        {
            return ((ITypedElement)(((ModelElement)(TransformerAsset.ClassInstance)).Resolve("TransformerObservations")));
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
        
        private static ITypedElement RetrieveTransformerAssetModelReference()
        {
            return ((ITypedElement)(((ModelElement)(TransformerAsset.ClassInstance)).Resolve("TransformerAssetModel")));
        }
        
        /// <summary>
        /// Raises the TransformerAssetModelChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnTransformerAssetModelChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.TransformerAssetModelChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the TransformerAssetModelChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnTransformerAssetModelChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.TransformerAssetModelChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the TransformerAssetModel property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetTransformerAssetModel(object sender, System.EventArgs eventArgs)
        {
            this.TransformerAssetModel = null;
        }
        
        private static ITypedElement RetrieveTransformerInfoReference()
        {
            return ((ITypedElement)(((ModelElement)(TransformerAsset.ClassInstance)).Resolve("TransformerInfo")));
        }
        
        /// <summary>
        /// Raises the TransformerInfoChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnTransformerInfoChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.TransformerInfoChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the TransformerInfoChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnTransformerInfoChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.TransformerInfoChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the TransformerInfo property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetTransformerInfo(object sender, System.EventArgs eventArgs)
        {
            this.TransformerInfo = null;
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "RECONDITIONEDDATETIME"))
            {
                return this.ReconditionedDateTime;
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
            if ((feature == "POWERRATINGS"))
            {
                return this._powerRatings;
            }
            if ((feature == "TRANSFORMEROBSERVATIONS"))
            {
                return this._transformerObservations;
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
            if ((feature == "TRANSFORMERASSETMODEL"))
            {
                this.TransformerAssetModel = ((ITransformerAssetModel)(value));
                return;
            }
            if ((feature == "TRANSFORMERINFO"))
            {
                this.TransformerInfo = ((ITransformerInfo)(value));
                return;
            }
            if ((feature == "RECONDITIONEDDATETIME"))
            {
                this.ReconditionedDateTime = ((DateTime)(value));
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
            if ((attribute == "TransformerAssetModel"))
            {
                return new TransformerAssetModelProxy(this);
            }
            if ((attribute == "TransformerInfo"))
            {
                return new TransformerInfoProxy(this);
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
            if ((reference == "TransformerAssetModel"))
            {
                return new TransformerAssetModelProxy(this);
            }
            if ((reference == "TransformerInfo"))
            {
                return new TransformerInfoProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfAssets/Transfo" +
                        "rmerAsset")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the TransformerAsset class
        /// </summary>
        public class TransformerAssetReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private TransformerAsset _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public TransformerAssetReferencedElementsCollection(TransformerAsset parent)
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
                    count = (count + this._parent.PowerRatings.Count);
                    count = (count + this._parent.TransformerObservations.Count);
                    if ((this._parent.TransformerAssetModel != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.TransformerInfo != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.PowerRatings.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.TransformerObservations.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.TransformerAssetModelChanged += this.PropagateValueChanges;
                this._parent.TransformerInfoChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.PowerRatings.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.TransformerObservations.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.TransformerAssetModelChanged -= this.PropagateValueChanges;
                this._parent.TransformerInfoChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IPowerRating powerRatingsCasted = item.As<IPowerRating>();
                if ((powerRatingsCasted != null))
                {
                    this._parent.PowerRatings.Add(powerRatingsCasted);
                }
                ITransformerObservation transformerObservationsCasted = item.As<ITransformerObservation>();
                if ((transformerObservationsCasted != null))
                {
                    this._parent.TransformerObservations.Add(transformerObservationsCasted);
                }
                if ((this._parent.TransformerAssetModel == null))
                {
                    ITransformerAssetModel transformerAssetModelCasted = item.As<ITransformerAssetModel>();
                    if ((transformerAssetModelCasted != null))
                    {
                        this._parent.TransformerAssetModel = transformerAssetModelCasted;
                        return;
                    }
                }
                if ((this._parent.TransformerInfo == null))
                {
                    ITransformerInfo transformerInfoCasted = item.As<ITransformerInfo>();
                    if ((transformerInfoCasted != null))
                    {
                        this._parent.TransformerInfo = transformerInfoCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.PowerRatings.Clear();
                this._parent.TransformerObservations.Clear();
                this._parent.TransformerAssetModel = null;
                this._parent.TransformerInfo = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.PowerRatings.Contains(item))
                {
                    return true;
                }
                if (this._parent.TransformerObservations.Contains(item))
                {
                    return true;
                }
                if ((item == this._parent.TransformerAssetModel))
                {
                    return true;
                }
                if ((item == this._parent.TransformerInfo))
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
                IEnumerator<IModelElement> powerRatingsEnumerator = this._parent.PowerRatings.GetEnumerator();
                try
                {
                    for (
                    ; powerRatingsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = powerRatingsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    powerRatingsEnumerator.Dispose();
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
                if ((this._parent.TransformerAssetModel != null))
                {
                    array[arrayIndex] = this._parent.TransformerAssetModel;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.TransformerInfo != null))
                {
                    array[arrayIndex] = this._parent.TransformerInfo;
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
                IPowerRating powerRatingItem = item.As<IPowerRating>();
                if (((powerRatingItem != null) 
                            && this._parent.PowerRatings.Remove(powerRatingItem)))
                {
                    return true;
                }
                ITransformerObservation transformerObservationItem = item.As<ITransformerObservation>();
                if (((transformerObservationItem != null) 
                            && this._parent.TransformerObservations.Remove(transformerObservationItem)))
                {
                    return true;
                }
                if ((this._parent.TransformerAssetModel == item))
                {
                    this._parent.TransformerAssetModel = null;
                    return true;
                }
                if ((this._parent.TransformerInfo == item))
                {
                    this._parent.TransformerInfo = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.PowerRatings).Concat(this._parent.TransformerObservations).Concat(this._parent.TransformerAssetModel).Concat(this._parent.TransformerInfo).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the reconditionedDateTime property
        /// </summary>
        private sealed class ReconditionedDateTimeProxy : ModelPropertyChange<ITransformerAsset, DateTime>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public ReconditionedDateTimeProxy(ITransformerAsset modelElement) : 
                    base(modelElement, "reconditionedDateTime")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override DateTime Value
            {
                get
                {
                    return this.ModelElement.ReconditionedDateTime;
                }
                set
                {
                    this.ModelElement.ReconditionedDateTime = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the TransformerAssetModel property
        /// </summary>
        private sealed class TransformerAssetModelProxy : ModelPropertyChange<ITransformerAsset, ITransformerAssetModel>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public TransformerAssetModelProxy(ITransformerAsset modelElement) : 
                    base(modelElement, "TransformerAssetModel")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override ITransformerAssetModel Value
            {
                get
                {
                    return this.ModelElement.TransformerAssetModel;
                }
                set
                {
                    this.ModelElement.TransformerAssetModel = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the TransformerInfo property
        /// </summary>
        private sealed class TransformerInfoProxy : ModelPropertyChange<ITransformerAsset, ITransformerInfo>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public TransformerInfoProxy(ITransformerAsset modelElement) : 
                    base(modelElement, "TransformerInfo")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override ITransformerInfo Value
            {
                get
                {
                    return this.ModelElement.TransformerInfo;
                }
                set
                {
                    this.ModelElement.TransformerInfo = value;
                }
            }
        }
    }
}

