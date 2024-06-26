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
using TTC2017.SmartGrids.CIM.IEC61968.Assets;
using TTC2017.SmartGrids.CIM.IEC61968.Common;
using TTC2017.SmartGrids.CIM.IEC61968.Work;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssets;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfCommon;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfERPSupport;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfGMLSupport;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfLocations;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfOperations;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfTypeAsset;

namespace TTC2017.SmartGrids.CIM.IEC61970.Informative.InfWork
{
    
    
    /// <summary>
    /// The default implementation of the CUWorkEquipmentItem class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#InfWork")]
    [XmlNamespacePrefixAttribute("cimInfWork")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfWork/CUWorkEqu" +
        "ipmentItem")]
    [DebuggerDisplayAttribute("CUWorkEquipmentItem {UUID}")]
    public partial class CUWorkEquipmentItem : IdentifiedObject, ICUWorkEquipmentItem, IModelElement
    {
        
        /// <summary>
        /// The backing field for the EquipCode property
        /// </summary>
        private string _equipCode;
        
        private static Lazy<ITypedElement> _equipCodeAttribute = new Lazy<ITypedElement>(RetrieveEquipCodeAttribute);
        
        /// <summary>
        /// The backing field for the Rate property
        /// </summary>
        private float _rate;
        
        private static Lazy<ITypedElement> _rateAttribute = new Lazy<ITypedElement>(RetrieveRateAttribute);
        
        private static Lazy<ITypedElement> _typeAssetReference = new Lazy<ITypedElement>(RetrieveTypeAssetReference);
        
        /// <summary>
        /// The backing field for the TypeAsset property
        /// </summary>
        private ITypeAsset _typeAsset;
        
        private static Lazy<ITypedElement> _compatibleUnitsReference = new Lazy<ITypedElement>(RetrieveCompatibleUnitsReference);
        
        /// <summary>
        /// The backing field for the CompatibleUnits property
        /// </summary>
        private CUWorkEquipmentItemCompatibleUnitsCollection _compatibleUnits;
        
        private static Lazy<ITypedElement> _statusReference = new Lazy<ITypedElement>(RetrieveStatusReference);
        
        /// <summary>
        /// The backing field for the Status property
        /// </summary>
        private IStatus _status;
        
        private static IClass _classInstance;
        
        public CUWorkEquipmentItem()
        {
            this._compatibleUnits = new CUWorkEquipmentItemCompatibleUnitsCollection(this);
            this._compatibleUnits.CollectionChanging += this.CompatibleUnitsCollectionChanging;
            this._compatibleUnits.CollectionChanged += this.CompatibleUnitsCollectionChanged;
        }
        
        /// <summary>
        /// The equipCode property
        /// </summary>
        [XmlElementNameAttribute("equipCode")]
        [XmlAttributeAttribute(true)]
        public virtual string EquipCode
        {
            get
            {
                return this._equipCode;
            }
            set
            {
                if ((this._equipCode != value))
                {
                    string old = this._equipCode;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnEquipCodeChanging(e);
                    this.OnPropertyChanging("EquipCode", e, _equipCodeAttribute);
                    this._equipCode = value;
                    this.OnEquipCodeChanged(e);
                    this.OnPropertyChanged("EquipCode", e, _equipCodeAttribute);
                }
            }
        }
        
        /// <summary>
        /// The rate property
        /// </summary>
        [XmlElementNameAttribute("rate")]
        [XmlAttributeAttribute(true)]
        public virtual float Rate
        {
            get
            {
                return this._rate;
            }
            set
            {
                if ((this._rate != value))
                {
                    float old = this._rate;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnRateChanging(e);
                    this.OnPropertyChanging("Rate", e, _rateAttribute);
                    this._rate = value;
                    this.OnRateChanged(e);
                    this.OnPropertyChanged("Rate", e, _rateAttribute);
                }
            }
        }
        
        /// <summary>
        /// The TypeAsset property
        /// </summary>
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("CUWorkEquipmentAsset")]
        public virtual ITypeAsset TypeAsset
        {
            get
            {
                return this._typeAsset;
            }
            set
            {
                if ((this._typeAsset != value))
                {
                    ITypeAsset old = this._typeAsset;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnTypeAssetChanging(e);
                    this.OnPropertyChanging("TypeAsset", e, _typeAssetReference);
                    this._typeAsset = value;
                    if ((old != null))
                    {
                        old.CUWorkEquipmentAsset = null;
                        old.Deleted -= this.OnResetTypeAsset;
                    }
                    if ((value != null))
                    {
                        value.CUWorkEquipmentAsset = this;
                        value.Deleted += this.OnResetTypeAsset;
                    }
                    this.OnTypeAssetChanged(e);
                    this.OnPropertyChanged("TypeAsset", e, _typeAssetReference);
                }
            }
        }
        
        /// <summary>
        /// The CompatibleUnits property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("CUWorkEquipmentItems")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<ICompatibleUnit> CompatibleUnits
        {
            get
            {
                return this._compatibleUnits;
            }
        }
        
        /// <summary>
        /// The status property
        /// </summary>
        [XmlElementNameAttribute("status")]
        [XmlAttributeAttribute(true)]
        public virtual IStatus Status
        {
            get
            {
                return this._status;
            }
            set
            {
                if ((this._status != value))
                {
                    IStatus old = this._status;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnStatusChanging(e);
                    this.OnPropertyChanging("Status", e, _statusReference);
                    this._status = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetStatus;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetStatus;
                    }
                    this.OnStatusChanged(e);
                    this.OnPropertyChanged("Status", e, _statusReference);
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
                return base.ReferencedElements.Concat(new CUWorkEquipmentItemReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfWork/CUWorkEqu" +
                            "ipmentItem")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the EquipCode property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> EquipCodeChanging;
        
        /// <summary>
        /// Gets fired when the EquipCode property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> EquipCodeChanged;
        
        /// <summary>
        /// Gets fired before the Rate property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> RateChanging;
        
        /// <summary>
        /// Gets fired when the Rate property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> RateChanged;
        
        /// <summary>
        /// Gets fired before the TypeAsset property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> TypeAssetChanging;
        
        /// <summary>
        /// Gets fired when the TypeAsset property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> TypeAssetChanged;
        
        /// <summary>
        /// Gets fired before the Status property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> StatusChanging;
        
        /// <summary>
        /// Gets fired when the Status property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> StatusChanged;
        
        private static ITypedElement RetrieveEquipCodeAttribute()
        {
            return ((ITypedElement)(((ModelElement)(CUWorkEquipmentItem.ClassInstance)).Resolve("equipCode")));
        }
        
        /// <summary>
        /// Raises the EquipCodeChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnEquipCodeChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.EquipCodeChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the EquipCodeChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnEquipCodeChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.EquipCodeChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveRateAttribute()
        {
            return ((ITypedElement)(((ModelElement)(CUWorkEquipmentItem.ClassInstance)).Resolve("rate")));
        }
        
        /// <summary>
        /// Raises the RateChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnRateChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.RateChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the RateChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnRateChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.RateChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveTypeAssetReference()
        {
            return ((ITypedElement)(((ModelElement)(CUWorkEquipmentItem.ClassInstance)).Resolve("TypeAsset")));
        }
        
        /// <summary>
        /// Raises the TypeAssetChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnTypeAssetChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.TypeAssetChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the TypeAssetChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnTypeAssetChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.TypeAssetChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the TypeAsset property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetTypeAsset(object sender, System.EventArgs eventArgs)
        {
            this.TypeAsset = null;
        }
        
        private static ITypedElement RetrieveCompatibleUnitsReference()
        {
            return ((ITypedElement)(((ModelElement)(CUWorkEquipmentItem.ClassInstance)).Resolve("CompatibleUnits")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the CompatibleUnits property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void CompatibleUnitsCollectionChanging(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanging("CompatibleUnits", e, _compatibleUnitsReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the CompatibleUnits property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void CompatibleUnitsCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("CompatibleUnits", e, _compatibleUnitsReference);
        }
        
        private static ITypedElement RetrieveStatusReference()
        {
            return ((ITypedElement)(((ModelElement)(CUWorkEquipmentItem.ClassInstance)).Resolve("status")));
        }
        
        /// <summary>
        /// Raises the StatusChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnStatusChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.StatusChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the StatusChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnStatusChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.StatusChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the Status property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetStatus(object sender, System.EventArgs eventArgs)
        {
            this.Status = null;
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "EQUIPCODE"))
            {
                return this.EquipCode;
            }
            if ((attribute == "RATE"))
            {
                return this.Rate;
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
            if ((feature == "COMPATIBLEUNITS"))
            {
                return this._compatibleUnits;
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
            if ((feature == "TYPEASSET"))
            {
                this.TypeAsset = ((ITypeAsset)(value));
                return;
            }
            if ((feature == "STATUS"))
            {
                this.Status = ((IStatus)(value));
                return;
            }
            if ((feature == "EQUIPCODE"))
            {
                this.EquipCode = ((string)(value));
                return;
            }
            if ((feature == "RATE"))
            {
                this.Rate = ((float)(value));
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
            if ((attribute == "TypeAsset"))
            {
                return new TypeAssetProxy(this);
            }
            if ((attribute == "Status"))
            {
                return new StatusProxy(this);
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
            if ((reference == "TypeAsset"))
            {
                return new TypeAssetProxy(this);
            }
            if ((reference == "Status"))
            {
                return new StatusProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfWork/CUWorkEqu" +
                        "ipmentItem")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the CUWorkEquipmentItem class
        /// </summary>
        public class CUWorkEquipmentItemReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private CUWorkEquipmentItem _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public CUWorkEquipmentItemReferencedElementsCollection(CUWorkEquipmentItem parent)
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
                    if ((this._parent.TypeAsset != null))
                    {
                        count = (count + 1);
                    }
                    count = (count + this._parent.CompatibleUnits.Count);
                    if ((this._parent.Status != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.TypeAssetChanged += this.PropagateValueChanges;
                this._parent.CompatibleUnits.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.StatusChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.TypeAssetChanged -= this.PropagateValueChanges;
                this._parent.CompatibleUnits.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.StatusChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.TypeAsset == null))
                {
                    ITypeAsset typeAssetCasted = item.As<ITypeAsset>();
                    if ((typeAssetCasted != null))
                    {
                        this._parent.TypeAsset = typeAssetCasted;
                        return;
                    }
                }
                ICompatibleUnit compatibleUnitsCasted = item.As<ICompatibleUnit>();
                if ((compatibleUnitsCasted != null))
                {
                    this._parent.CompatibleUnits.Add(compatibleUnitsCasted);
                }
                if ((this._parent.Status == null))
                {
                    IStatus statusCasted = item.As<IStatus>();
                    if ((statusCasted != null))
                    {
                        this._parent.Status = statusCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.TypeAsset = null;
                this._parent.CompatibleUnits.Clear();
                this._parent.Status = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.TypeAsset))
                {
                    return true;
                }
                if (this._parent.CompatibleUnits.Contains(item))
                {
                    return true;
                }
                if ((item == this._parent.Status))
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
                if ((this._parent.TypeAsset != null))
                {
                    array[arrayIndex] = this._parent.TypeAsset;
                    arrayIndex = (arrayIndex + 1);
                }
                IEnumerator<IModelElement> compatibleUnitsEnumerator = this._parent.CompatibleUnits.GetEnumerator();
                try
                {
                    for (
                    ; compatibleUnitsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = compatibleUnitsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    compatibleUnitsEnumerator.Dispose();
                }
                if ((this._parent.Status != null))
                {
                    array[arrayIndex] = this._parent.Status;
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
                if ((this._parent.TypeAsset == item))
                {
                    this._parent.TypeAsset = null;
                    return true;
                }
                ICompatibleUnit compatibleUnitItem = item.As<ICompatibleUnit>();
                if (((compatibleUnitItem != null) 
                            && this._parent.CompatibleUnits.Remove(compatibleUnitItem)))
                {
                    return true;
                }
                if ((this._parent.Status == item))
                {
                    this._parent.Status = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.TypeAsset).Concat(this._parent.CompatibleUnits).Concat(this._parent.Status).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the equipCode property
        /// </summary>
        private sealed class EquipCodeProxy : ModelPropertyChange<ICUWorkEquipmentItem, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public EquipCodeProxy(ICUWorkEquipmentItem modelElement) : 
                    base(modelElement, "equipCode")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override string Value
            {
                get
                {
                    return this.ModelElement.EquipCode;
                }
                set
                {
                    this.ModelElement.EquipCode = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the rate property
        /// </summary>
        private sealed class RateProxy : ModelPropertyChange<ICUWorkEquipmentItem, float>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public RateProxy(ICUWorkEquipmentItem modelElement) : 
                    base(modelElement, "rate")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override float Value
            {
                get
                {
                    return this.ModelElement.Rate;
                }
                set
                {
                    this.ModelElement.Rate = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the TypeAsset property
        /// </summary>
        private sealed class TypeAssetProxy : ModelPropertyChange<ICUWorkEquipmentItem, ITypeAsset>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public TypeAssetProxy(ICUWorkEquipmentItem modelElement) : 
                    base(modelElement, "TypeAsset")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override ITypeAsset Value
            {
                get
                {
                    return this.ModelElement.TypeAsset;
                }
                set
                {
                    this.ModelElement.TypeAsset = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the status property
        /// </summary>
        private sealed class StatusProxy : ModelPropertyChange<ICUWorkEquipmentItem, IStatus>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public StatusProxy(ICUWorkEquipmentItem modelElement) : 
                    base(modelElement, "status")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IStatus Value
            {
                get
                {
                    return this.ModelElement.Status;
                }
                set
                {
                    this.ModelElement.Status = value;
                }
            }
        }
    }
}

