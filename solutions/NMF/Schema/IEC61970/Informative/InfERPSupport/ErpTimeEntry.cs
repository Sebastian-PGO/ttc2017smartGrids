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
using TTC2017.SmartGrids.CIM.IEC61968.Customers;
using TTC2017.SmartGrids.CIM.IEC61968.Work;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.Financial;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssetModels;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssets;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfCommon;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfCustomers;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfLocations;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfOperations;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfTypeAsset;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfWork;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.MarketOperations;
using TTC2017.SmartGrids.CIM.IEC61970.Meas;

namespace TTC2017.SmartGrids.CIM.IEC61970.Informative.InfERPSupport
{
    
    
    /// <summary>
    /// The default implementation of the ErpTimeEntry class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#InfERPSupport")]
    [XmlNamespacePrefixAttribute("cimInfERPSupport")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfERPSupport/Erp" +
        "TimeEntry")]
    [DebuggerDisplayAttribute("ErpTimeEntry {UUID}")]
    public partial class ErpTimeEntry : IdentifiedObject, IErpTimeEntry, IModelElement
    {
        
        private static Lazy<ITypedElement> _erpProjectAccountingReference = new Lazy<ITypedElement>(RetrieveErpProjectAccountingReference);
        
        /// <summary>
        /// The backing field for the ErpProjectAccounting property
        /// </summary>
        private IErpProjectAccounting _erpProjectAccounting;
        
        private static Lazy<ITypedElement> _statusReference = new Lazy<ITypedElement>(RetrieveStatusReference);
        
        /// <summary>
        /// The backing field for the Status property
        /// </summary>
        private IStatus _status;
        
        private static Lazy<ITypedElement> _erpTimeSheetReference = new Lazy<ITypedElement>(RetrieveErpTimeSheetReference);
        
        /// <summary>
        /// The backing field for the ErpTimeSheet property
        /// </summary>
        private IErpTimeSheet _erpTimeSheet;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The ErpProjectAccounting property
        /// </summary>
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("ErpTimeEntries")]
        public virtual IErpProjectAccounting ErpProjectAccounting
        {
            get
            {
                return this._erpProjectAccounting;
            }
            set
            {
                if ((this._erpProjectAccounting != value))
                {
                    IErpProjectAccounting old = this._erpProjectAccounting;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnErpProjectAccountingChanging(e);
                    this.OnPropertyChanging("ErpProjectAccounting", e, _erpProjectAccountingReference);
                    this._erpProjectAccounting = value;
                    if ((old != null))
                    {
                        old.ErpTimeEntries.Remove(this);
                        old.Deleted -= this.OnResetErpProjectAccounting;
                    }
                    if ((value != null))
                    {
                        value.ErpTimeEntries.Add(this);
                        value.Deleted += this.OnResetErpProjectAccounting;
                    }
                    this.OnErpProjectAccountingChanged(e);
                    this.OnPropertyChanged("ErpProjectAccounting", e, _erpProjectAccountingReference);
                }
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
        /// The ErpTimeSheet property
        /// </summary>
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("ErpTimeEntries")]
        public virtual IErpTimeSheet ErpTimeSheet
        {
            get
            {
                return this._erpTimeSheet;
            }
            set
            {
                if ((this._erpTimeSheet != value))
                {
                    IErpTimeSheet old = this._erpTimeSheet;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnErpTimeSheetChanging(e);
                    this.OnPropertyChanging("ErpTimeSheet", e, _erpTimeSheetReference);
                    this._erpTimeSheet = value;
                    if ((old != null))
                    {
                        old.ErpTimeEntries.Remove(this);
                        old.Deleted -= this.OnResetErpTimeSheet;
                    }
                    if ((value != null))
                    {
                        value.ErpTimeEntries.Add(this);
                        value.Deleted += this.OnResetErpTimeSheet;
                    }
                    this.OnErpTimeSheetChanged(e);
                    this.OnPropertyChanged("ErpTimeSheet", e, _erpTimeSheetReference);
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
                return base.ReferencedElements.Concat(new ErpTimeEntryReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfERPSupport/Erp" +
                            "TimeEntry")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the ErpProjectAccounting property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ErpProjectAccountingChanging;
        
        /// <summary>
        /// Gets fired when the ErpProjectAccounting property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ErpProjectAccountingChanged;
        
        /// <summary>
        /// Gets fired before the Status property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> StatusChanging;
        
        /// <summary>
        /// Gets fired when the Status property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> StatusChanged;
        
        /// <summary>
        /// Gets fired before the ErpTimeSheet property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ErpTimeSheetChanging;
        
        /// <summary>
        /// Gets fired when the ErpTimeSheet property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ErpTimeSheetChanged;
        
        private static ITypedElement RetrieveErpProjectAccountingReference()
        {
            return ((ITypedElement)(((ModelElement)(ErpTimeEntry.ClassInstance)).Resolve("ErpProjectAccounting")));
        }
        
        /// <summary>
        /// Raises the ErpProjectAccountingChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnErpProjectAccountingChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ErpProjectAccountingChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the ErpProjectAccountingChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnErpProjectAccountingChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ErpProjectAccountingChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the ErpProjectAccounting property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetErpProjectAccounting(object sender, System.EventArgs eventArgs)
        {
            this.ErpProjectAccounting = null;
        }
        
        private static ITypedElement RetrieveStatusReference()
        {
            return ((ITypedElement)(((ModelElement)(ErpTimeEntry.ClassInstance)).Resolve("status")));
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
        
        private static ITypedElement RetrieveErpTimeSheetReference()
        {
            return ((ITypedElement)(((ModelElement)(ErpTimeEntry.ClassInstance)).Resolve("ErpTimeSheet")));
        }
        
        /// <summary>
        /// Raises the ErpTimeSheetChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnErpTimeSheetChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ErpTimeSheetChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the ErpTimeSheetChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnErpTimeSheetChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ErpTimeSheetChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the ErpTimeSheet property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetErpTimeSheet(object sender, System.EventArgs eventArgs)
        {
            this.ErpTimeSheet = null;
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "ERPPROJECTACCOUNTING"))
            {
                this.ErpProjectAccounting = ((IErpProjectAccounting)(value));
                return;
            }
            if ((feature == "STATUS"))
            {
                this.Status = ((IStatus)(value));
                return;
            }
            if ((feature == "ERPTIMESHEET"))
            {
                this.ErpTimeSheet = ((IErpTimeSheet)(value));
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
            if ((attribute == "ErpProjectAccounting"))
            {
                return new ErpProjectAccountingProxy(this);
            }
            if ((attribute == "Status"))
            {
                return new StatusProxy(this);
            }
            if ((attribute == "ErpTimeSheet"))
            {
                return new ErpTimeSheetProxy(this);
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
            if ((reference == "ErpProjectAccounting"))
            {
                return new ErpProjectAccountingProxy(this);
            }
            if ((reference == "Status"))
            {
                return new StatusProxy(this);
            }
            if ((reference == "ErpTimeSheet"))
            {
                return new ErpTimeSheetProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfERPSupport/Erp" +
                        "TimeEntry")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the ErpTimeEntry class
        /// </summary>
        public class ErpTimeEntryReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private ErpTimeEntry _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public ErpTimeEntryReferencedElementsCollection(ErpTimeEntry parent)
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
                    if ((this._parent.ErpProjectAccounting != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.Status != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.ErpTimeSheet != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.ErpProjectAccountingChanged += this.PropagateValueChanges;
                this._parent.StatusChanged += this.PropagateValueChanges;
                this._parent.ErpTimeSheetChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.ErpProjectAccountingChanged -= this.PropagateValueChanges;
                this._parent.StatusChanged -= this.PropagateValueChanges;
                this._parent.ErpTimeSheetChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.ErpProjectAccounting == null))
                {
                    IErpProjectAccounting erpProjectAccountingCasted = item.As<IErpProjectAccounting>();
                    if ((erpProjectAccountingCasted != null))
                    {
                        this._parent.ErpProjectAccounting = erpProjectAccountingCasted;
                        return;
                    }
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
                if ((this._parent.ErpTimeSheet == null))
                {
                    IErpTimeSheet erpTimeSheetCasted = item.As<IErpTimeSheet>();
                    if ((erpTimeSheetCasted != null))
                    {
                        this._parent.ErpTimeSheet = erpTimeSheetCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.ErpProjectAccounting = null;
                this._parent.Status = null;
                this._parent.ErpTimeSheet = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.ErpProjectAccounting))
                {
                    return true;
                }
                if ((item == this._parent.Status))
                {
                    return true;
                }
                if ((item == this._parent.ErpTimeSheet))
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
                if ((this._parent.ErpProjectAccounting != null))
                {
                    array[arrayIndex] = this._parent.ErpProjectAccounting;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.Status != null))
                {
                    array[arrayIndex] = this._parent.Status;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.ErpTimeSheet != null))
                {
                    array[arrayIndex] = this._parent.ErpTimeSheet;
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
                if ((this._parent.ErpProjectAccounting == item))
                {
                    this._parent.ErpProjectAccounting = null;
                    return true;
                }
                if ((this._parent.Status == item))
                {
                    this._parent.Status = null;
                    return true;
                }
                if ((this._parent.ErpTimeSheet == item))
                {
                    this._parent.ErpTimeSheet = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.ErpProjectAccounting).Concat(this._parent.Status).Concat(this._parent.ErpTimeSheet).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the ErpProjectAccounting property
        /// </summary>
        private sealed class ErpProjectAccountingProxy : ModelPropertyChange<IErpTimeEntry, IErpProjectAccounting>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public ErpProjectAccountingProxy(IErpTimeEntry modelElement) : 
                    base(modelElement, "ErpProjectAccounting")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IErpProjectAccounting Value
            {
                get
                {
                    return this.ModelElement.ErpProjectAccounting;
                }
                set
                {
                    this.ModelElement.ErpProjectAccounting = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the status property
        /// </summary>
        private sealed class StatusProxy : ModelPropertyChange<IErpTimeEntry, IStatus>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public StatusProxy(IErpTimeEntry modelElement) : 
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
        /// Represents a proxy to represent an incremental access to the ErpTimeSheet property
        /// </summary>
        private sealed class ErpTimeSheetProxy : ModelPropertyChange<IErpTimeEntry, IErpTimeSheet>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public ErpTimeSheetProxy(IErpTimeEntry modelElement) : 
                    base(modelElement, "ErpTimeSheet")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IErpTimeSheet Value
            {
                get
                {
                    return this.ModelElement.ErpTimeSheet;
                }
                set
                {
                    this.ModelElement.ErpTimeSheet = value;
                }
            }
        }
    }
}

