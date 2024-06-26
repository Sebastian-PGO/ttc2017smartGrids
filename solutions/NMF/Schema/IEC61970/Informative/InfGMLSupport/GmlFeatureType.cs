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
using TTC2017.SmartGrids.CIM.IEC61968.Common;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfOperations;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfWork;
using TTC2017.SmartGrids.CIM.IEC61970.Meas;

namespace TTC2017.SmartGrids.CIM.IEC61970.Informative.InfGMLSupport
{
    
    
    /// <summary>
    /// The default implementation of the GmlFeatureType class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#InfGMLSupport")]
    [XmlNamespacePrefixAttribute("cimInfGMLSupport")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfGMLSupport/Gml" +
        "FeatureType")]
    [DebuggerDisplayAttribute("GmlFeatureType {UUID}")]
    public partial class GmlFeatureType : IdentifiedObject, IGmlFeatureType, IModelElement
    {
        
        private static Lazy<ITypedElement> _gmlFeatureStylesReference = new Lazy<ITypedElement>(RetrieveGmlFeatureStylesReference);
        
        /// <summary>
        /// The backing field for the GmlFeatureStyles property
        /// </summary>
        private GmlFeatureTypeGmlFeatureStylesCollection _gmlFeatureStyles;
        
        private static IClass _classInstance;
        
        public GmlFeatureType()
        {
            this._gmlFeatureStyles = new GmlFeatureTypeGmlFeatureStylesCollection(this);
            this._gmlFeatureStyles.CollectionChanging += this.GmlFeatureStylesCollectionChanging;
            this._gmlFeatureStyles.CollectionChanged += this.GmlFeatureStylesCollectionChanged;
        }
        
        /// <summary>
        /// The GmlFeatureStyles property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("GmlFeatureTypes")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<IGmlFeatureStyle> GmlFeatureStyles
        {
            get
            {
                return this._gmlFeatureStyles;
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new GmlFeatureTypeReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfGMLSupport/Gml" +
                            "FeatureType")));
                }
                return _classInstance;
            }
        }
        
        private static ITypedElement RetrieveGmlFeatureStylesReference()
        {
            return ((ITypedElement)(((ModelElement)(GmlFeatureType.ClassInstance)).Resolve("GmlFeatureStyles")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the GmlFeatureStyles property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void GmlFeatureStylesCollectionChanging(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanging("GmlFeatureStyles", e, _gmlFeatureStylesReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the GmlFeatureStyles property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void GmlFeatureStylesCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("GmlFeatureStyles", e, _gmlFeatureStylesReference);
        }
        
        /// <summary>
        /// Gets the Model element collection for the given feature
        /// </summary>
        /// <returns>A non-generic list of elements</returns>
        /// <param name="feature">The requested feature</param>
        protected override System.Collections.IList GetCollectionForFeature(string feature)
        {
            if ((feature == "GMLFEATURESTYLES"))
            {
                return this._gmlFeatureStyles;
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfGMLSupport/Gml" +
                        "FeatureType")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the GmlFeatureType class
        /// </summary>
        public class GmlFeatureTypeReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private GmlFeatureType _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public GmlFeatureTypeReferencedElementsCollection(GmlFeatureType parent)
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
                    count = (count + this._parent.GmlFeatureStyles.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.GmlFeatureStyles.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.GmlFeatureStyles.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IGmlFeatureStyle gmlFeatureStylesCasted = item.As<IGmlFeatureStyle>();
                if ((gmlFeatureStylesCasted != null))
                {
                    this._parent.GmlFeatureStyles.Add(gmlFeatureStylesCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.GmlFeatureStyles.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.GmlFeatureStyles.Contains(item))
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
                IEnumerator<IModelElement> gmlFeatureStylesEnumerator = this._parent.GmlFeatureStyles.GetEnumerator();
                try
                {
                    for (
                    ; gmlFeatureStylesEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = gmlFeatureStylesEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    gmlFeatureStylesEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IGmlFeatureStyle gmlFeatureStyleItem = item.As<IGmlFeatureStyle>();
                if (((gmlFeatureStyleItem != null) 
                            && this._parent.GmlFeatureStyles.Remove(gmlFeatureStyleItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.GmlFeatureStyles).GetEnumerator();
            }
        }
    }
}

