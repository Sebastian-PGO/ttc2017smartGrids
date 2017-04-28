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
    /// The default implementation of the DuctBankInfo class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#InfAssets")]
    [XmlNamespacePrefixAttribute("cimInfAssets")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfAssets/DuctBan" +
        "kInfo")]
    [DebuggerDisplayAttribute("DuctBankInfo {UUID}")]
    public partial class DuctBankInfo : AssetInfo, IDuctBankInfo, IModelElement
    {
        
        /// <summary>
        /// The backing field for the CircuitCount property
        /// </summary>
        private int _circuitCount;
        
        private static Lazy<ITypedElement> _circuitCountAttribute = new Lazy<ITypedElement>(RetrieveCircuitCountAttribute);
        
        private static Lazy<ITypedElement> _ductInfosReference = new Lazy<ITypedElement>(RetrieveDuctInfosReference);
        
        /// <summary>
        /// The backing field for the DuctInfos property
        /// </summary>
        private DuctBankInfoDuctInfosCollection _ductInfos;
        
        private static IClass _classInstance;
        
        public DuctBankInfo()
        {
            this._ductInfos = new DuctBankInfoDuctInfosCollection(this);
            this._ductInfos.CollectionChanging += this.DuctInfosCollectionChanging;
            this._ductInfos.CollectionChanged += this.DuctInfosCollectionChanged;
        }
        
        /// <summary>
        /// The circuitCount property
        /// </summary>
        [XmlElementNameAttribute("circuitCount")]
        [XmlAttributeAttribute(true)]
        public virtual int CircuitCount
        {
            get
            {
                return this._circuitCount;
            }
            set
            {
                if ((this._circuitCount != value))
                {
                    int old = this._circuitCount;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnCircuitCountChanging(e);
                    this.OnPropertyChanging("CircuitCount", e, _circuitCountAttribute);
                    this._circuitCount = value;
                    this.OnCircuitCountChanged(e);
                    this.OnPropertyChanged("CircuitCount", e, _circuitCountAttribute);
                }
            }
        }
        
        /// <summary>
        /// The DuctInfos property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("DuctBankInfo")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<IDuctInfo> DuctInfos
        {
            get
            {
                return this._ductInfos;
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new DuctBankInfoReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfAssets/DuctBan" +
                            "kInfo")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the CircuitCount property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> CircuitCountChanging;
        
        /// <summary>
        /// Gets fired when the CircuitCount property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> CircuitCountChanged;
        
        private static ITypedElement RetrieveCircuitCountAttribute()
        {
            return ((ITypedElement)(((ModelElement)(DuctBankInfo.ClassInstance)).Resolve("circuitCount")));
        }
        
        /// <summary>
        /// Raises the CircuitCountChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnCircuitCountChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.CircuitCountChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the CircuitCountChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnCircuitCountChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.CircuitCountChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveDuctInfosReference()
        {
            return ((ITypedElement)(((ModelElement)(DuctBankInfo.ClassInstance)).Resolve("DuctInfos")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the DuctInfos property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void DuctInfosCollectionChanging(object sender, NMF.Collections.ObjectModel.NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("DuctInfos", e, _ductInfosReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the DuctInfos property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void DuctInfosCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("DuctInfos", e, _ductInfosReference);
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "CIRCUITCOUNT"))
            {
                return this.CircuitCount;
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
            if ((feature == "DUCTINFOS"))
            {
                return this._ductInfos;
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
            if ((feature == "CIRCUITCOUNT"))
            {
                this.CircuitCount = ((int)(value));
                return;
            }
            base.SetFeature(feature, value);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override IClass GetClass()
        {
            if ((_classInstance == null))
            {
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfAssets/DuctBan" +
                        "kInfo")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the DuctBankInfo class
        /// </summary>
        public class DuctBankInfoReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private DuctBankInfo _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public DuctBankInfoReferencedElementsCollection(DuctBankInfo parent)
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
                    count = (count + this._parent.DuctInfos.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.DuctInfos.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.DuctInfos.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IDuctInfo ductInfosCasted = item.As<IDuctInfo>();
                if ((ductInfosCasted != null))
                {
                    this._parent.DuctInfos.Add(ductInfosCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.DuctInfos.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.DuctInfos.Contains(item))
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
                IEnumerator<IModelElement> ductInfosEnumerator = this._parent.DuctInfos.GetEnumerator();
                try
                {
                    for (
                    ; ductInfosEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = ductInfosEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    ductInfosEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IDuctInfo ductInfoItem = item.As<IDuctInfo>();
                if (((ductInfoItem != null) 
                            && this._parent.DuctInfos.Remove(ductInfoItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.DuctInfos).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the circuitCount property
        /// </summary>
        private sealed class CircuitCountProxy : ModelPropertyChange<IDuctBankInfo, int>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public CircuitCountProxy(IDuctBankInfo modelElement) : 
                    base(modelElement, "circuitCount")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override int Value
            {
                get
                {
                    return this.ModelElement.CircuitCount;
                }
                set
                {
                    this.ModelElement.CircuitCount = value;
                }
            }
        }
    }
}

