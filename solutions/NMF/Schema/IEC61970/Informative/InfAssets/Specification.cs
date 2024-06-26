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
    /// The default implementation of the Specification class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#InfAssets")]
    [XmlNamespacePrefixAttribute("cimInfAssets")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfAssets/Specifi" +
        "cation")]
    [DebuggerDisplayAttribute("Specification {UUID}")]
    public partial class Specification : Document, ISpecification, IModelElement
    {
        
        private static Lazy<ITypedElement> _assetProperitesReference = new Lazy<ITypedElement>(RetrieveAssetProperitesReference);
        
        /// <summary>
        /// The backing field for the AssetProperites property
        /// </summary>
        private SpecificationAssetProperitesCollection _assetProperites;
        
        private static Lazy<ITypedElement> _reliabilityInfosReference = new Lazy<ITypedElement>(RetrieveReliabilityInfosReference);
        
        /// <summary>
        /// The backing field for the ReliabilityInfos property
        /// </summary>
        private SpecificationReliabilityInfosCollection _reliabilityInfos;
        
        private static Lazy<ITypedElement> _ratingsReference = new Lazy<ITypedElement>(RetrieveRatingsReference);
        
        /// <summary>
        /// The backing field for the Ratings property
        /// </summary>
        private SpecificationRatingsCollection _ratings;
        
        private static Lazy<ITypedElement> _qualificationRequirementsReference = new Lazy<ITypedElement>(RetrieveQualificationRequirementsReference);
        
        /// <summary>
        /// The backing field for the QualificationRequirements property
        /// </summary>
        private SpecificationQualificationRequirementsCollection _qualificationRequirements;
        
        private static Lazy<ITypedElement> _assetPropertyCurvesReference = new Lazy<ITypedElement>(RetrieveAssetPropertyCurvesReference);
        
        /// <summary>
        /// The backing field for the AssetPropertyCurves property
        /// </summary>
        private SpecificationAssetPropertyCurvesCollection _assetPropertyCurves;
        
        private static Lazy<ITypedElement> _dimensionsInfosReference = new Lazy<ITypedElement>(RetrieveDimensionsInfosReference);
        
        /// <summary>
        /// The backing field for the DimensionsInfos property
        /// </summary>
        private SpecificationDimensionsInfosCollection _dimensionsInfos;
        
        private static Lazy<ITypedElement> _mediumsReference = new Lazy<ITypedElement>(RetrieveMediumsReference);
        
        /// <summary>
        /// The backing field for the Mediums property
        /// </summary>
        private SpecificationMediumsCollection _mediums;
        
        private static IClass _classInstance;
        
        public Specification()
        {
            this._assetProperites = new SpecificationAssetProperitesCollection(this);
            this._assetProperites.CollectionChanging += this.AssetProperitesCollectionChanging;
            this._assetProperites.CollectionChanged += this.AssetProperitesCollectionChanged;
            this._reliabilityInfos = new SpecificationReliabilityInfosCollection(this);
            this._reliabilityInfos.CollectionChanging += this.ReliabilityInfosCollectionChanging;
            this._reliabilityInfos.CollectionChanged += this.ReliabilityInfosCollectionChanged;
            this._ratings = new SpecificationRatingsCollection(this);
            this._ratings.CollectionChanging += this.RatingsCollectionChanging;
            this._ratings.CollectionChanged += this.RatingsCollectionChanged;
            this._qualificationRequirements = new SpecificationQualificationRequirementsCollection(this);
            this._qualificationRequirements.CollectionChanging += this.QualificationRequirementsCollectionChanging;
            this._qualificationRequirements.CollectionChanged += this.QualificationRequirementsCollectionChanged;
            this._assetPropertyCurves = new SpecificationAssetPropertyCurvesCollection(this);
            this._assetPropertyCurves.CollectionChanging += this.AssetPropertyCurvesCollectionChanging;
            this._assetPropertyCurves.CollectionChanged += this.AssetPropertyCurvesCollectionChanged;
            this._dimensionsInfos = new SpecificationDimensionsInfosCollection(this);
            this._dimensionsInfos.CollectionChanging += this.DimensionsInfosCollectionChanging;
            this._dimensionsInfos.CollectionChanged += this.DimensionsInfosCollectionChanged;
            this._mediums = new SpecificationMediumsCollection(this);
            this._mediums.CollectionChanging += this.MediumsCollectionChanging;
            this._mediums.CollectionChanged += this.MediumsCollectionChanged;
        }
        
        /// <summary>
        /// The AssetProperites property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("PropertySpecification")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<IUserAttribute> AssetProperites
        {
            get
            {
                return this._assetProperites;
            }
        }
        
        /// <summary>
        /// The ReliabilityInfos property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("Specification")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<IReliabilityInfo> ReliabilityInfos
        {
            get
            {
                return this._reliabilityInfos;
            }
        }
        
        /// <summary>
        /// The Ratings property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("RatingSpecification")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<IUserAttribute> Ratings
        {
            get
            {
                return this._ratings;
            }
        }
        
        /// <summary>
        /// The QualificationRequirements property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("Specifications")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<IQualificationRequirement> QualificationRequirements
        {
            get
            {
                return this._qualificationRequirements;
            }
        }
        
        /// <summary>
        /// The AssetPropertyCurves property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("Specification")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<IAssetPropertyCurve> AssetPropertyCurves
        {
            get
            {
                return this._assetPropertyCurves;
            }
        }
        
        /// <summary>
        /// The DimensionsInfos property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("Specifications")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<IDimensionsInfo> DimensionsInfos
        {
            get
            {
                return this._dimensionsInfos;
            }
        }
        
        /// <summary>
        /// The Mediums property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("Specification")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<IMedium> Mediums
        {
            get
            {
                return this._mediums;
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new SpecificationReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfAssets/Specifi" +
                            "cation")));
                }
                return _classInstance;
            }
        }
        
        private static ITypedElement RetrieveAssetProperitesReference()
        {
            return ((ITypedElement)(((ModelElement)(Specification.ClassInstance)).Resolve("AssetProperites")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the AssetProperites property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void AssetProperitesCollectionChanging(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanging("AssetProperites", e, _assetProperitesReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the AssetProperites property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void AssetProperitesCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("AssetProperites", e, _assetProperitesReference);
        }
        
        private static ITypedElement RetrieveReliabilityInfosReference()
        {
            return ((ITypedElement)(((ModelElement)(Specification.ClassInstance)).Resolve("ReliabilityInfos")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the ReliabilityInfos property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void ReliabilityInfosCollectionChanging(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanging("ReliabilityInfos", e, _reliabilityInfosReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the ReliabilityInfos property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void ReliabilityInfosCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("ReliabilityInfos", e, _reliabilityInfosReference);
        }
        
        private static ITypedElement RetrieveRatingsReference()
        {
            return ((ITypedElement)(((ModelElement)(Specification.ClassInstance)).Resolve("Ratings")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the Ratings property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void RatingsCollectionChanging(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanging("Ratings", e, _ratingsReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the Ratings property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void RatingsCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("Ratings", e, _ratingsReference);
        }
        
        private static ITypedElement RetrieveQualificationRequirementsReference()
        {
            return ((ITypedElement)(((ModelElement)(Specification.ClassInstance)).Resolve("QualificationRequirements")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the QualificationRequirements property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void QualificationRequirementsCollectionChanging(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanging("QualificationRequirements", e, _qualificationRequirementsReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the QualificationRequirements property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void QualificationRequirementsCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("QualificationRequirements", e, _qualificationRequirementsReference);
        }
        
        private static ITypedElement RetrieveAssetPropertyCurvesReference()
        {
            return ((ITypedElement)(((ModelElement)(Specification.ClassInstance)).Resolve("AssetPropertyCurves")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the AssetPropertyCurves property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void AssetPropertyCurvesCollectionChanging(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanging("AssetPropertyCurves", e, _assetPropertyCurvesReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the AssetPropertyCurves property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void AssetPropertyCurvesCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("AssetPropertyCurves", e, _assetPropertyCurvesReference);
        }
        
        private static ITypedElement RetrieveDimensionsInfosReference()
        {
            return ((ITypedElement)(((ModelElement)(Specification.ClassInstance)).Resolve("DimensionsInfos")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the DimensionsInfos property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void DimensionsInfosCollectionChanging(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanging("DimensionsInfos", e, _dimensionsInfosReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the DimensionsInfos property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void DimensionsInfosCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("DimensionsInfos", e, _dimensionsInfosReference);
        }
        
        private static ITypedElement RetrieveMediumsReference()
        {
            return ((ITypedElement)(((ModelElement)(Specification.ClassInstance)).Resolve("Mediums")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the Mediums property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void MediumsCollectionChanging(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanging("Mediums", e, _mediumsReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the Mediums property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void MediumsCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("Mediums", e, _mediumsReference);
        }
        
        /// <summary>
        /// Gets the Model element collection for the given feature
        /// </summary>
        /// <returns>A non-generic list of elements</returns>
        /// <param name="feature">The requested feature</param>
        protected override System.Collections.IList GetCollectionForFeature(string feature)
        {
            if ((feature == "ASSETPROPERITES"))
            {
                return this._assetProperites;
            }
            if ((feature == "RELIABILITYINFOS"))
            {
                return this._reliabilityInfos;
            }
            if ((feature == "RATINGS"))
            {
                return this._ratings;
            }
            if ((feature == "QUALIFICATIONREQUIREMENTS"))
            {
                return this._qualificationRequirements;
            }
            if ((feature == "ASSETPROPERTYCURVES"))
            {
                return this._assetPropertyCurves;
            }
            if ((feature == "DIMENSIONSINFOS"))
            {
                return this._dimensionsInfos;
            }
            if ((feature == "MEDIUMS"))
            {
                return this._mediums;
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfAssets/Specifi" +
                        "cation")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the Specification class
        /// </summary>
        public class SpecificationReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private Specification _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public SpecificationReferencedElementsCollection(Specification parent)
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
                    count = (count + this._parent.AssetProperites.Count);
                    count = (count + this._parent.ReliabilityInfos.Count);
                    count = (count + this._parent.Ratings.Count);
                    count = (count + this._parent.QualificationRequirements.Count);
                    count = (count + this._parent.AssetPropertyCurves.Count);
                    count = (count + this._parent.DimensionsInfos.Count);
                    count = (count + this._parent.Mediums.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.AssetProperites.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.ReliabilityInfos.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.Ratings.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.QualificationRequirements.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.AssetPropertyCurves.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.DimensionsInfos.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.Mediums.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.AssetProperites.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.ReliabilityInfos.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.Ratings.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.QualificationRequirements.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.AssetPropertyCurves.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.DimensionsInfos.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.Mediums.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IUserAttribute assetProperitesCasted = item.As<IUserAttribute>();
                if ((assetProperitesCasted != null))
                {
                    this._parent.AssetProperites.Add(assetProperitesCasted);
                }
                IReliabilityInfo reliabilityInfosCasted = item.As<IReliabilityInfo>();
                if ((reliabilityInfosCasted != null))
                {
                    this._parent.ReliabilityInfos.Add(reliabilityInfosCasted);
                }
                IUserAttribute ratingsCasted = item.As<IUserAttribute>();
                if ((ratingsCasted != null))
                {
                    this._parent.Ratings.Add(ratingsCasted);
                }
                IQualificationRequirement qualificationRequirementsCasted = item.As<IQualificationRequirement>();
                if ((qualificationRequirementsCasted != null))
                {
                    this._parent.QualificationRequirements.Add(qualificationRequirementsCasted);
                }
                IAssetPropertyCurve assetPropertyCurvesCasted = item.As<IAssetPropertyCurve>();
                if ((assetPropertyCurvesCasted != null))
                {
                    this._parent.AssetPropertyCurves.Add(assetPropertyCurvesCasted);
                }
                IDimensionsInfo dimensionsInfosCasted = item.As<IDimensionsInfo>();
                if ((dimensionsInfosCasted != null))
                {
                    this._parent.DimensionsInfos.Add(dimensionsInfosCasted);
                }
                IMedium mediumsCasted = item.As<IMedium>();
                if ((mediumsCasted != null))
                {
                    this._parent.Mediums.Add(mediumsCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.AssetProperites.Clear();
                this._parent.ReliabilityInfos.Clear();
                this._parent.Ratings.Clear();
                this._parent.QualificationRequirements.Clear();
                this._parent.AssetPropertyCurves.Clear();
                this._parent.DimensionsInfos.Clear();
                this._parent.Mediums.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.AssetProperites.Contains(item))
                {
                    return true;
                }
                if (this._parent.ReliabilityInfos.Contains(item))
                {
                    return true;
                }
                if (this._parent.Ratings.Contains(item))
                {
                    return true;
                }
                if (this._parent.QualificationRequirements.Contains(item))
                {
                    return true;
                }
                if (this._parent.AssetPropertyCurves.Contains(item))
                {
                    return true;
                }
                if (this._parent.DimensionsInfos.Contains(item))
                {
                    return true;
                }
                if (this._parent.Mediums.Contains(item))
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
                IEnumerator<IModelElement> assetProperitesEnumerator = this._parent.AssetProperites.GetEnumerator();
                try
                {
                    for (
                    ; assetProperitesEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = assetProperitesEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    assetProperitesEnumerator.Dispose();
                }
                IEnumerator<IModelElement> reliabilityInfosEnumerator = this._parent.ReliabilityInfos.GetEnumerator();
                try
                {
                    for (
                    ; reliabilityInfosEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = reliabilityInfosEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    reliabilityInfosEnumerator.Dispose();
                }
                IEnumerator<IModelElement> ratingsEnumerator = this._parent.Ratings.GetEnumerator();
                try
                {
                    for (
                    ; ratingsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = ratingsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    ratingsEnumerator.Dispose();
                }
                IEnumerator<IModelElement> qualificationRequirementsEnumerator = this._parent.QualificationRequirements.GetEnumerator();
                try
                {
                    for (
                    ; qualificationRequirementsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = qualificationRequirementsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    qualificationRequirementsEnumerator.Dispose();
                }
                IEnumerator<IModelElement> assetPropertyCurvesEnumerator = this._parent.AssetPropertyCurves.GetEnumerator();
                try
                {
                    for (
                    ; assetPropertyCurvesEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = assetPropertyCurvesEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    assetPropertyCurvesEnumerator.Dispose();
                }
                IEnumerator<IModelElement> dimensionsInfosEnumerator = this._parent.DimensionsInfos.GetEnumerator();
                try
                {
                    for (
                    ; dimensionsInfosEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = dimensionsInfosEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    dimensionsInfosEnumerator.Dispose();
                }
                IEnumerator<IModelElement> mediumsEnumerator = this._parent.Mediums.GetEnumerator();
                try
                {
                    for (
                    ; mediumsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = mediumsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    mediumsEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IUserAttribute userAttributeItem = item.As<IUserAttribute>();
                if (((userAttributeItem != null) 
                            && this._parent.AssetProperites.Remove(userAttributeItem)))
                {
                    return true;
                }
                IReliabilityInfo reliabilityInfoItem = item.As<IReliabilityInfo>();
                if (((reliabilityInfoItem != null) 
                            && this._parent.ReliabilityInfos.Remove(reliabilityInfoItem)))
                {
                    return true;
                }
                if (((userAttributeItem != null) 
                            && this._parent.Ratings.Remove(userAttributeItem)))
                {
                    return true;
                }
                IQualificationRequirement qualificationRequirementItem = item.As<IQualificationRequirement>();
                if (((qualificationRequirementItem != null) 
                            && this._parent.QualificationRequirements.Remove(qualificationRequirementItem)))
                {
                    return true;
                }
                IAssetPropertyCurve assetPropertyCurveItem = item.As<IAssetPropertyCurve>();
                if (((assetPropertyCurveItem != null) 
                            && this._parent.AssetPropertyCurves.Remove(assetPropertyCurveItem)))
                {
                    return true;
                }
                IDimensionsInfo dimensionsInfoItem = item.As<IDimensionsInfo>();
                if (((dimensionsInfoItem != null) 
                            && this._parent.DimensionsInfos.Remove(dimensionsInfoItem)))
                {
                    return true;
                }
                IMedium mediumItem = item.As<IMedium>();
                if (((mediumItem != null) 
                            && this._parent.Mediums.Remove(mediumItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.AssetProperites).Concat(this._parent.ReliabilityInfos).Concat(this._parent.Ratings).Concat(this._parent.QualificationRequirements).Concat(this._parent.AssetPropertyCurves).Concat(this._parent.DimensionsInfos).Concat(this._parent.Mediums).GetEnumerator();
            }
        }
    }
}

