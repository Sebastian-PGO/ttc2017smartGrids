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
using TTC2017.SmartGrids.CIM.IEC61970.Generation.Production;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.EnergyScheduling;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfERPSupport;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.MarketOperations;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.Reservation;

namespace TTC2017.SmartGrids.CIM.IEC61970.Informative.Financial
{
    
    
    /// <summary>
    /// The default implementation of the GenerationProvider class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#Financial")]
    [XmlNamespacePrefixAttribute("cimFinancial")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/Financial/Generat" +
        "ionProvider")]
    [DebuggerDisplayAttribute("GenerationProvider {UUID}")]
    public partial class GenerationProvider : ErpOrganisation, IGenerationProvider, IModelElement
    {
        
        private static Lazy<ITypedElement> _servicePointReference = new Lazy<ITypedElement>(RetrieveServicePointReference);
        
        /// <summary>
        /// The backing field for the ServicePoint property
        /// </summary>
        private GenerationProviderServicePointCollection _servicePoint;
        
        private static Lazy<ITypedElement> _generatingUnitsReference = new Lazy<ITypedElement>(RetrieveGeneratingUnitsReference);
        
        /// <summary>
        /// The backing field for the GeneratingUnits property
        /// </summary>
        private GenerationProviderGeneratingUnitsCollection _generatingUnits;
        
        private static Lazy<ITypedElement> _energyProductsReference = new Lazy<ITypedElement>(RetrieveEnergyProductsReference);
        
        /// <summary>
        /// The backing field for the EnergyProducts property
        /// </summary>
        private GenerationProviderEnergyProductsCollection _energyProducts;
        
        private static IClass _classInstance;
        
        public GenerationProvider()
        {
            this._servicePoint = new GenerationProviderServicePointCollection(this);
            this._servicePoint.CollectionChanging += this.ServicePointCollectionChanging;
            this._servicePoint.CollectionChanged += this.ServicePointCollectionChanged;
            this._generatingUnits = new GenerationProviderGeneratingUnitsCollection(this);
            this._generatingUnits.CollectionChanging += this.GeneratingUnitsCollectionChanging;
            this._generatingUnits.CollectionChanged += this.GeneratingUnitsCollectionChanged;
            this._energyProducts = new GenerationProviderEnergyProductsCollection(this);
            this._energyProducts.CollectionChanging += this.EnergyProductsCollectionChanging;
            this._energyProducts.CollectionChanged += this.EnergyProductsCollectionChanged;
        }
        
        /// <summary>
        /// The ServicePoint property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("GenerationProvider")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<IServicePoint> ServicePoint
        {
            get
            {
                return this._servicePoint;
            }
        }
        
        /// <summary>
        /// The GeneratingUnits property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("OperatedBy_GenerationProvider")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<IGeneratingUnit> GeneratingUnits
        {
            get
            {
                return this._generatingUnits;
            }
        }
        
        /// <summary>
        /// The EnergyProducts property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("GenerationProvider")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<IEnergyProduct> EnergyProducts
        {
            get
            {
                return this._energyProducts;
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new GenerationProviderReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/Financial/Generat" +
                            "ionProvider")));
                }
                return _classInstance;
            }
        }
        
        private static ITypedElement RetrieveServicePointReference()
        {
            return ((ITypedElement)(((ModelElement)(GenerationProvider.ClassInstance)).Resolve("ServicePoint")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the ServicePoint property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void ServicePointCollectionChanging(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanging("ServicePoint", e, _servicePointReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the ServicePoint property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void ServicePointCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("ServicePoint", e, _servicePointReference);
        }
        
        private static ITypedElement RetrieveGeneratingUnitsReference()
        {
            return ((ITypedElement)(((ModelElement)(GenerationProvider.ClassInstance)).Resolve("GeneratingUnits")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the GeneratingUnits property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void GeneratingUnitsCollectionChanging(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanging("GeneratingUnits", e, _generatingUnitsReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the GeneratingUnits property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void GeneratingUnitsCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("GeneratingUnits", e, _generatingUnitsReference);
        }
        
        private static ITypedElement RetrieveEnergyProductsReference()
        {
            return ((ITypedElement)(((ModelElement)(GenerationProvider.ClassInstance)).Resolve("EnergyProducts")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the EnergyProducts property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void EnergyProductsCollectionChanging(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanging("EnergyProducts", e, _energyProductsReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the EnergyProducts property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void EnergyProductsCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("EnergyProducts", e, _energyProductsReference);
        }
        
        /// <summary>
        /// Gets the Model element collection for the given feature
        /// </summary>
        /// <returns>A non-generic list of elements</returns>
        /// <param name="feature">The requested feature</param>
        protected override System.Collections.IList GetCollectionForFeature(string feature)
        {
            if ((feature == "SERVICEPOINT"))
            {
                return this._servicePoint;
            }
            if ((feature == "GENERATINGUNITS"))
            {
                return this._generatingUnits;
            }
            if ((feature == "ENERGYPRODUCTS"))
            {
                return this._energyProducts;
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/Financial/Generat" +
                        "ionProvider")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the GenerationProvider class
        /// </summary>
        public class GenerationProviderReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private GenerationProvider _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public GenerationProviderReferencedElementsCollection(GenerationProvider parent)
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
                    count = (count + this._parent.ServicePoint.Count);
                    count = (count + this._parent.GeneratingUnits.Count);
                    count = (count + this._parent.EnergyProducts.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.ServicePoint.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.GeneratingUnits.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.EnergyProducts.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.ServicePoint.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.GeneratingUnits.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.EnergyProducts.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IServicePoint servicePointCasted = item.As<IServicePoint>();
                if ((servicePointCasted != null))
                {
                    this._parent.ServicePoint.Add(servicePointCasted);
                }
                IGeneratingUnit generatingUnitsCasted = item.As<IGeneratingUnit>();
                if ((generatingUnitsCasted != null))
                {
                    this._parent.GeneratingUnits.Add(generatingUnitsCasted);
                }
                IEnergyProduct energyProductsCasted = item.As<IEnergyProduct>();
                if ((energyProductsCasted != null))
                {
                    this._parent.EnergyProducts.Add(energyProductsCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.ServicePoint.Clear();
                this._parent.GeneratingUnits.Clear();
                this._parent.EnergyProducts.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.ServicePoint.Contains(item))
                {
                    return true;
                }
                if (this._parent.GeneratingUnits.Contains(item))
                {
                    return true;
                }
                if (this._parent.EnergyProducts.Contains(item))
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
                IEnumerator<IModelElement> servicePointEnumerator = this._parent.ServicePoint.GetEnumerator();
                try
                {
                    for (
                    ; servicePointEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = servicePointEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    servicePointEnumerator.Dispose();
                }
                IEnumerator<IModelElement> generatingUnitsEnumerator = this._parent.GeneratingUnits.GetEnumerator();
                try
                {
                    for (
                    ; generatingUnitsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = generatingUnitsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    generatingUnitsEnumerator.Dispose();
                }
                IEnumerator<IModelElement> energyProductsEnumerator = this._parent.EnergyProducts.GetEnumerator();
                try
                {
                    for (
                    ; energyProductsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = energyProductsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    energyProductsEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IServicePoint servicePointItem = item.As<IServicePoint>();
                if (((servicePointItem != null) 
                            && this._parent.ServicePoint.Remove(servicePointItem)))
                {
                    return true;
                }
                IGeneratingUnit generatingUnitItem = item.As<IGeneratingUnit>();
                if (((generatingUnitItem != null) 
                            && this._parent.GeneratingUnits.Remove(generatingUnitItem)))
                {
                    return true;
                }
                IEnergyProduct energyProductItem = item.As<IEnergyProduct>();
                if (((energyProductItem != null) 
                            && this._parent.EnergyProducts.Remove(energyProductItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.ServicePoint).Concat(this._parent.GeneratingUnits).Concat(this._parent.EnergyProducts).GetEnumerator();
            }
        }
    }
}

