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
    /// The default implementation of the CUMaterialItem class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#InfWork")]
    [XmlNamespacePrefixAttribute("cimInfWork")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfWork/CUMateria" +
        "lItem")]
    [DebuggerDisplayAttribute("CUMaterialItem {UUID}")]
    public partial class CUMaterialItem : IdentifiedObject, ICUMaterialItem, IModelElement
    {
        
        /// <summary>
        /// The backing field for the Quantity property
        /// </summary>
        private object _quantity;
        
        private static Lazy<ITypedElement> _quantityAttribute = new Lazy<ITypedElement>(RetrieveQuantityAttribute);
        
        /// <summary>
        /// The backing field for the CorporateCode property
        /// </summary>
        private string _corporateCode;
        
        private static Lazy<ITypedElement> _corporateCodeAttribute = new Lazy<ITypedElement>(RetrieveCorporateCodeAttribute);
        
        private static Lazy<ITypedElement> _compatibleUnitsReference = new Lazy<ITypedElement>(RetrieveCompatibleUnitsReference);
        
        /// <summary>
        /// The backing field for the CompatibleUnits property
        /// </summary>
        private CUMaterialItemCompatibleUnitsCollection _compatibleUnits;
        
        private static Lazy<ITypedElement> _statusReference = new Lazy<ITypedElement>(RetrieveStatusReference);
        
        /// <summary>
        /// The backing field for the Status property
        /// </summary>
        private IStatus _status;
        
        private static Lazy<ITypedElement> _typeMaterialReference = new Lazy<ITypedElement>(RetrieveTypeMaterialReference);
        
        /// <summary>
        /// The backing field for the TypeMaterial property
        /// </summary>
        private ITypeMaterial _typeMaterial;
        
        private static Lazy<ITypedElement> _propertyUnitsReference = new Lazy<ITypedElement>(RetrievePropertyUnitsReference);
        
        /// <summary>
        /// The backing field for the PropertyUnits property
        /// </summary>
        private CUMaterialItemPropertyUnitsCollection _propertyUnits;
        
        private static IClass _classInstance;
        
        public CUMaterialItem()
        {
            this._compatibleUnits = new CUMaterialItemCompatibleUnitsCollection(this);
            this._compatibleUnits.CollectionChanging += this.CompatibleUnitsCollectionChanging;
            this._compatibleUnits.CollectionChanged += this.CompatibleUnitsCollectionChanged;
            this._propertyUnits = new CUMaterialItemPropertyUnitsCollection(this);
            this._propertyUnits.CollectionChanging += this.PropertyUnitsCollectionChanging;
            this._propertyUnits.CollectionChanged += this.PropertyUnitsCollectionChanged;
        }
        
        /// <summary>
        /// The quantity property
        /// </summary>
        [XmlElementNameAttribute("quantity")]
        [XmlAttributeAttribute(true)]
        public virtual object Quantity
        {
            get
            {
                return this._quantity;
            }
            set
            {
                if ((this._quantity != value))
                {
                    object old = this._quantity;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnQuantityChanging(e);
                    this.OnPropertyChanging("Quantity", e, _quantityAttribute);
                    this._quantity = value;
                    this.OnQuantityChanged(e);
                    this.OnPropertyChanged("Quantity", e, _quantityAttribute);
                }
            }
        }
        
        /// <summary>
        /// The corporateCode property
        /// </summary>
        [XmlElementNameAttribute("corporateCode")]
        [XmlAttributeAttribute(true)]
        public virtual string CorporateCode
        {
            get
            {
                return this._corporateCode;
            }
            set
            {
                if ((this._corporateCode != value))
                {
                    string old = this._corporateCode;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnCorporateCodeChanging(e);
                    this.OnPropertyChanging("CorporateCode", e, _corporateCodeAttribute);
                    this._corporateCode = value;
                    this.OnCorporateCodeChanged(e);
                    this.OnPropertyChanged("CorporateCode", e, _corporateCodeAttribute);
                }
            }
        }
        
        /// <summary>
        /// The CompatibleUnits property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("CUMaterialItems")]
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
        /// The TypeMaterial property
        /// </summary>
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("CUMaterialItems")]
        public virtual ITypeMaterial TypeMaterial
        {
            get
            {
                return this._typeMaterial;
            }
            set
            {
                if ((this._typeMaterial != value))
                {
                    ITypeMaterial old = this._typeMaterial;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnTypeMaterialChanging(e);
                    this.OnPropertyChanging("TypeMaterial", e, _typeMaterialReference);
                    this._typeMaterial = value;
                    if ((old != null))
                    {
                        old.CUMaterialItems.Remove(this);
                        old.Deleted -= this.OnResetTypeMaterial;
                    }
                    if ((value != null))
                    {
                        value.CUMaterialItems.Add(this);
                        value.Deleted += this.OnResetTypeMaterial;
                    }
                    this.OnTypeMaterialChanged(e);
                    this.OnPropertyChanged("TypeMaterial", e, _typeMaterialReference);
                }
            }
        }
        
        /// <summary>
        /// The PropertyUnits property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("CUMaterialItems")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<IPropertyUnit> PropertyUnits
        {
            get
            {
                return this._propertyUnits;
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new CUMaterialItemReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfWork/CUMateria" +
                            "lItem")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the Quantity property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> QuantityChanging;
        
        /// <summary>
        /// Gets fired when the Quantity property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> QuantityChanged;
        
        /// <summary>
        /// Gets fired before the CorporateCode property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> CorporateCodeChanging;
        
        /// <summary>
        /// Gets fired when the CorporateCode property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> CorporateCodeChanged;
        
        /// <summary>
        /// Gets fired before the Status property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> StatusChanging;
        
        /// <summary>
        /// Gets fired when the Status property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> StatusChanged;
        
        /// <summary>
        /// Gets fired before the TypeMaterial property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> TypeMaterialChanging;
        
        /// <summary>
        /// Gets fired when the TypeMaterial property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> TypeMaterialChanged;
        
        private static ITypedElement RetrieveQuantityAttribute()
        {
            return ((ITypedElement)(((ModelElement)(CUMaterialItem.ClassInstance)).Resolve("quantity")));
        }
        
        /// <summary>
        /// Raises the QuantityChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnQuantityChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.QuantityChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the QuantityChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnQuantityChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.QuantityChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveCorporateCodeAttribute()
        {
            return ((ITypedElement)(((ModelElement)(CUMaterialItem.ClassInstance)).Resolve("corporateCode")));
        }
        
        /// <summary>
        /// Raises the CorporateCodeChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnCorporateCodeChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.CorporateCodeChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the CorporateCodeChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnCorporateCodeChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.CorporateCodeChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveCompatibleUnitsReference()
        {
            return ((ITypedElement)(((ModelElement)(CUMaterialItem.ClassInstance)).Resolve("CompatibleUnits")));
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
            return ((ITypedElement)(((ModelElement)(CUMaterialItem.ClassInstance)).Resolve("status")));
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
        
        private static ITypedElement RetrieveTypeMaterialReference()
        {
            return ((ITypedElement)(((ModelElement)(CUMaterialItem.ClassInstance)).Resolve("TypeMaterial")));
        }
        
        /// <summary>
        /// Raises the TypeMaterialChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnTypeMaterialChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.TypeMaterialChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the TypeMaterialChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnTypeMaterialChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.TypeMaterialChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the TypeMaterial property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetTypeMaterial(object sender, System.EventArgs eventArgs)
        {
            this.TypeMaterial = null;
        }
        
        private static ITypedElement RetrievePropertyUnitsReference()
        {
            return ((ITypedElement)(((ModelElement)(CUMaterialItem.ClassInstance)).Resolve("PropertyUnits")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the PropertyUnits property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void PropertyUnitsCollectionChanging(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanging("PropertyUnits", e, _propertyUnitsReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the PropertyUnits property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void PropertyUnitsCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("PropertyUnits", e, _propertyUnitsReference);
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "QUANTITY"))
            {
                return this.Quantity;
            }
            if ((attribute == "CORPORATECODE"))
            {
                return this.CorporateCode;
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
            if ((feature == "PROPERTYUNITS"))
            {
                return this._propertyUnits;
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
            if ((feature == "STATUS"))
            {
                this.Status = ((IStatus)(value));
                return;
            }
            if ((feature == "TYPEMATERIAL"))
            {
                this.TypeMaterial = ((ITypeMaterial)(value));
                return;
            }
            if ((feature == "QUANTITY"))
            {
                this.Quantity = ((object)(value));
                return;
            }
            if ((feature == "CORPORATECODE"))
            {
                this.CorporateCode = ((string)(value));
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
            if ((attribute == "Status"))
            {
                return new StatusProxy(this);
            }
            if ((attribute == "TypeMaterial"))
            {
                return new TypeMaterialProxy(this);
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
            if ((reference == "Status"))
            {
                return new StatusProxy(this);
            }
            if ((reference == "TypeMaterial"))
            {
                return new TypeMaterialProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfWork/CUMateria" +
                        "lItem")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the CUMaterialItem class
        /// </summary>
        public class CUMaterialItemReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private CUMaterialItem _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public CUMaterialItemReferencedElementsCollection(CUMaterialItem parent)
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
                    count = (count + this._parent.CompatibleUnits.Count);
                    if ((this._parent.Status != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.TypeMaterial != null))
                    {
                        count = (count + 1);
                    }
                    count = (count + this._parent.PropertyUnits.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.CompatibleUnits.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.StatusChanged += this.PropagateValueChanges;
                this._parent.TypeMaterialChanged += this.PropagateValueChanges;
                this._parent.PropertyUnits.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.CompatibleUnits.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.StatusChanged -= this.PropagateValueChanges;
                this._parent.TypeMaterialChanged -= this.PropagateValueChanges;
                this._parent.PropertyUnits.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
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
                if ((this._parent.TypeMaterial == null))
                {
                    ITypeMaterial typeMaterialCasted = item.As<ITypeMaterial>();
                    if ((typeMaterialCasted != null))
                    {
                        this._parent.TypeMaterial = typeMaterialCasted;
                        return;
                    }
                }
                IPropertyUnit propertyUnitsCasted = item.As<IPropertyUnit>();
                if ((propertyUnitsCasted != null))
                {
                    this._parent.PropertyUnits.Add(propertyUnitsCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.CompatibleUnits.Clear();
                this._parent.Status = null;
                this._parent.TypeMaterial = null;
                this._parent.PropertyUnits.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.CompatibleUnits.Contains(item))
                {
                    return true;
                }
                if ((item == this._parent.Status))
                {
                    return true;
                }
                if ((item == this._parent.TypeMaterial))
                {
                    return true;
                }
                if (this._parent.PropertyUnits.Contains(item))
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
                if ((this._parent.TypeMaterial != null))
                {
                    array[arrayIndex] = this._parent.TypeMaterial;
                    arrayIndex = (arrayIndex + 1);
                }
                IEnumerator<IModelElement> propertyUnitsEnumerator = this._parent.PropertyUnits.GetEnumerator();
                try
                {
                    for (
                    ; propertyUnitsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = propertyUnitsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    propertyUnitsEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
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
                if ((this._parent.TypeMaterial == item))
                {
                    this._parent.TypeMaterial = null;
                    return true;
                }
                IPropertyUnit propertyUnitItem = item.As<IPropertyUnit>();
                if (((propertyUnitItem != null) 
                            && this._parent.PropertyUnits.Remove(propertyUnitItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.CompatibleUnits).Concat(this._parent.Status).Concat(this._parent.TypeMaterial).Concat(this._parent.PropertyUnits).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the quantity property
        /// </summary>
        private sealed class QuantityProxy : ModelPropertyChange<ICUMaterialItem, object>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public QuantityProxy(ICUMaterialItem modelElement) : 
                    base(modelElement, "quantity")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override object Value
            {
                get
                {
                    return this.ModelElement.Quantity;
                }
                set
                {
                    this.ModelElement.Quantity = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the corporateCode property
        /// </summary>
        private sealed class CorporateCodeProxy : ModelPropertyChange<ICUMaterialItem, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public CorporateCodeProxy(ICUMaterialItem modelElement) : 
                    base(modelElement, "corporateCode")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override string Value
            {
                get
                {
                    return this.ModelElement.CorporateCode;
                }
                set
                {
                    this.ModelElement.CorporateCode = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the status property
        /// </summary>
        private sealed class StatusProxy : ModelPropertyChange<ICUMaterialItem, IStatus>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public StatusProxy(ICUMaterialItem modelElement) : 
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
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the TypeMaterial property
        /// </summary>
        private sealed class TypeMaterialProxy : ModelPropertyChange<ICUMaterialItem, ITypeMaterial>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public TypeMaterialProxy(ICUMaterialItem modelElement) : 
                    base(modelElement, "TypeMaterial")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override ITypeMaterial Value
            {
                get
                {
                    return this.ModelElement.TypeMaterial;
                }
                set
                {
                    this.ModelElement.TypeMaterial = value;
                }
            }
        }
    }
}

