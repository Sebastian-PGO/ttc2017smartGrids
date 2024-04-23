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
    /// The default implementation of the CULaborCode class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#InfWork")]
    [XmlNamespacePrefixAttribute("cimInfWork")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfWork/CULaborCo" +
        "de")]
    [DebuggerDisplayAttribute("CULaborCode {UUID}")]
    public partial class CULaborCode : IdentifiedObject, ICULaborCode, IModelElement
    {
        
        /// <summary>
        /// The backing field for the Code property
        /// </summary>
        private string _code;
        
        private static Lazy<ITypedElement> _codeAttribute = new Lazy<ITypedElement>(RetrieveCodeAttribute);
        
        private static Lazy<ITypedElement> _statusReference = new Lazy<ITypedElement>(RetrieveStatusReference);
        
        /// <summary>
        /// The backing field for the Status property
        /// </summary>
        private IStatus _status;
        
        private static Lazy<ITypedElement> _cULaborItemsReference = new Lazy<ITypedElement>(RetrieveCULaborItemsReference);
        
        /// <summary>
        /// The backing field for the CULaborItems property
        /// </summary>
        private CULaborCodeCULaborItemsCollection _cULaborItems;
        
        private static IClass _classInstance;
        
        public CULaborCode()
        {
            this._cULaborItems = new CULaborCodeCULaborItemsCollection(this);
            this._cULaborItems.CollectionChanging += this.CULaborItemsCollectionChanging;
            this._cULaborItems.CollectionChanged += this.CULaborItemsCollectionChanged;
        }
        
        /// <summary>
        /// The code property
        /// </summary>
        [XmlElementNameAttribute("code")]
        [XmlAttributeAttribute(true)]
        public virtual string Code
        {
            get
            {
                return this._code;
            }
            set
            {
                if ((this._code != value))
                {
                    string old = this._code;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnCodeChanging(e);
                    this.OnPropertyChanging("Code", e, _codeAttribute);
                    this._code = value;
                    this.OnCodeChanged(e);
                    this.OnPropertyChanged("Code", e, _codeAttribute);
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
        /// The CULaborItems property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("CULaborCode")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<ICULaborItem> CULaborItems
        {
            get
            {
                return this._cULaborItems;
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new CULaborCodeReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfWork/CULaborCo" +
                            "de")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the Code property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> CodeChanging;
        
        /// <summary>
        /// Gets fired when the Code property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> CodeChanged;
        
        /// <summary>
        /// Gets fired before the Status property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> StatusChanging;
        
        /// <summary>
        /// Gets fired when the Status property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> StatusChanged;
        
        private static ITypedElement RetrieveCodeAttribute()
        {
            return ((ITypedElement)(((ModelElement)(CULaborCode.ClassInstance)).Resolve("code")));
        }
        
        /// <summary>
        /// Raises the CodeChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnCodeChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.CodeChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the CodeChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnCodeChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.CodeChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveStatusReference()
        {
            return ((ITypedElement)(((ModelElement)(CULaborCode.ClassInstance)).Resolve("status")));
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
        
        private static ITypedElement RetrieveCULaborItemsReference()
        {
            return ((ITypedElement)(((ModelElement)(CULaborCode.ClassInstance)).Resolve("CULaborItems")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the CULaborItems property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void CULaborItemsCollectionChanging(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanging("CULaborItems", e, _cULaborItemsReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the CULaborItems property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void CULaborItemsCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("CULaborItems", e, _cULaborItemsReference);
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "CODE"))
            {
                return this.Code;
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
            if ((feature == "CULABORITEMS"))
            {
                return this._cULaborItems;
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
            if ((feature == "CODE"))
            {
                this.Code = ((string)(value));
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
            return base.GetExpressionForReference(reference);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override IClass GetClass()
        {
            if ((_classInstance == null))
            {
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfWork/CULaborCo" +
                        "de")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the CULaborCode class
        /// </summary>
        public class CULaborCodeReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private CULaborCode _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public CULaborCodeReferencedElementsCollection(CULaborCode parent)
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
                    if ((this._parent.Status != null))
                    {
                        count = (count + 1);
                    }
                    count = (count + this._parent.CULaborItems.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.StatusChanged += this.PropagateValueChanges;
                this._parent.CULaborItems.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.StatusChanged -= this.PropagateValueChanges;
                this._parent.CULaborItems.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.Status == null))
                {
                    IStatus statusCasted = item.As<IStatus>();
                    if ((statusCasted != null))
                    {
                        this._parent.Status = statusCasted;
                        return;
                    }
                }
                ICULaborItem cULaborItemsCasted = item.As<ICULaborItem>();
                if ((cULaborItemsCasted != null))
                {
                    this._parent.CULaborItems.Add(cULaborItemsCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.Status = null;
                this._parent.CULaborItems.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.Status))
                {
                    return true;
                }
                if (this._parent.CULaborItems.Contains(item))
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
                if ((this._parent.Status != null))
                {
                    array[arrayIndex] = this._parent.Status;
                    arrayIndex = (arrayIndex + 1);
                }
                IEnumerator<IModelElement> cULaborItemsEnumerator = this._parent.CULaborItems.GetEnumerator();
                try
                {
                    for (
                    ; cULaborItemsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = cULaborItemsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    cULaborItemsEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                if ((this._parent.Status == item))
                {
                    this._parent.Status = null;
                    return true;
                }
                ICULaborItem cULaborItemItem = item.As<ICULaborItem>();
                if (((cULaborItemItem != null) 
                            && this._parent.CULaborItems.Remove(cULaborItemItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.Status).Concat(this._parent.CULaborItems).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the code property
        /// </summary>
        private sealed class CodeProxy : ModelPropertyChange<ICULaborCode, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public CodeProxy(ICULaborCode modelElement) : 
                    base(modelElement, "code")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override string Value
            {
                get
                {
                    return this.ModelElement.Code;
                }
                set
                {
                    this.ModelElement.Code = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the status property
        /// </summary>
        private sealed class StatusProxy : ModelPropertyChange<ICULaborCode, IStatus>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public StatusProxy(ICULaborCode modelElement) : 
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

