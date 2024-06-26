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
    /// The default implementation of the DuctInfo class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#InfAssets")]
    [XmlNamespacePrefixAttribute("cimInfAssets")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfAssets/DuctInf" +
        "o")]
    [DebuggerDisplayAttribute("DuctInfo {UUID}")]
    public partial class DuctInfo : AssetInfo, IDuctInfo, IModelElement
    {
        
        /// <summary>
        /// The backing field for the YCoord property
        /// </summary>
        private int _yCoord;
        
        private static Lazy<ITypedElement> _yCoordAttribute = new Lazy<ITypedElement>(RetrieveYCoordAttribute);
        
        /// <summary>
        /// The backing field for the XCoord property
        /// </summary>
        private int _xCoord;
        
        private static Lazy<ITypedElement> _xCoordAttribute = new Lazy<ITypedElement>(RetrieveXCoordAttribute);
        
        private static Lazy<ITypedElement> _cableInfosReference = new Lazy<ITypedElement>(RetrieveCableInfosReference);
        
        /// <summary>
        /// The backing field for the CableInfos property
        /// </summary>
        private DuctInfoCableInfosCollection _cableInfos;
        
        private static Lazy<ITypedElement> _ductBankInfoReference = new Lazy<ITypedElement>(RetrieveDuctBankInfoReference);
        
        /// <summary>
        /// The backing field for the DuctBankInfo property
        /// </summary>
        private IDuctBankInfo _ductBankInfo;
        
        private static IClass _classInstance;
        
        public DuctInfo()
        {
            this._cableInfos = new DuctInfoCableInfosCollection(this);
            this._cableInfos.CollectionChanging += this.CableInfosCollectionChanging;
            this._cableInfos.CollectionChanged += this.CableInfosCollectionChanged;
        }
        
        /// <summary>
        /// The yCoord property
        /// </summary>
        [XmlElementNameAttribute("yCoord")]
        [XmlAttributeAttribute(true)]
        public virtual int YCoord
        {
            get
            {
                return this._yCoord;
            }
            set
            {
                if ((this._yCoord != value))
                {
                    int old = this._yCoord;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnYCoordChanging(e);
                    this.OnPropertyChanging("YCoord", e, _yCoordAttribute);
                    this._yCoord = value;
                    this.OnYCoordChanged(e);
                    this.OnPropertyChanged("YCoord", e, _yCoordAttribute);
                }
            }
        }
        
        /// <summary>
        /// The xCoord property
        /// </summary>
        [XmlElementNameAttribute("xCoord")]
        [XmlAttributeAttribute(true)]
        public virtual int XCoord
        {
            get
            {
                return this._xCoord;
            }
            set
            {
                if ((this._xCoord != value))
                {
                    int old = this._xCoord;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnXCoordChanging(e);
                    this.OnPropertyChanging("XCoord", e, _xCoordAttribute);
                    this._xCoord = value;
                    this.OnXCoordChanged(e);
                    this.OnPropertyChanged("XCoord", e, _xCoordAttribute);
                }
            }
        }
        
        /// <summary>
        /// The CableInfos property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("DuctBankInfo")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<ICableInfo> CableInfos
        {
            get
            {
                return this._cableInfos;
            }
        }
        
        /// <summary>
        /// The DuctBankInfo property
        /// </summary>
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("DuctInfos")]
        public virtual IDuctBankInfo DuctBankInfo
        {
            get
            {
                return this._ductBankInfo;
            }
            set
            {
                if ((this._ductBankInfo != value))
                {
                    IDuctBankInfo old = this._ductBankInfo;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnDuctBankInfoChanging(e);
                    this.OnPropertyChanging("DuctBankInfo", e, _ductBankInfoReference);
                    this._ductBankInfo = value;
                    if ((old != null))
                    {
                        old.DuctInfos.Remove(this);
                        old.Deleted -= this.OnResetDuctBankInfo;
                    }
                    if ((value != null))
                    {
                        value.DuctInfos.Add(this);
                        value.Deleted += this.OnResetDuctBankInfo;
                    }
                    this.OnDuctBankInfoChanged(e);
                    this.OnPropertyChanged("DuctBankInfo", e, _ductBankInfoReference);
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
                return base.ReferencedElements.Concat(new DuctInfoReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfAssets/DuctInf" +
                            "o")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the YCoord property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> YCoordChanging;
        
        /// <summary>
        /// Gets fired when the YCoord property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> YCoordChanged;
        
        /// <summary>
        /// Gets fired before the XCoord property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> XCoordChanging;
        
        /// <summary>
        /// Gets fired when the XCoord property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> XCoordChanged;
        
        /// <summary>
        /// Gets fired before the DuctBankInfo property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> DuctBankInfoChanging;
        
        /// <summary>
        /// Gets fired when the DuctBankInfo property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> DuctBankInfoChanged;
        
        private static ITypedElement RetrieveYCoordAttribute()
        {
            return ((ITypedElement)(((ModelElement)(DuctInfo.ClassInstance)).Resolve("yCoord")));
        }
        
        /// <summary>
        /// Raises the YCoordChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnYCoordChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.YCoordChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the YCoordChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnYCoordChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.YCoordChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveXCoordAttribute()
        {
            return ((ITypedElement)(((ModelElement)(DuctInfo.ClassInstance)).Resolve("xCoord")));
        }
        
        /// <summary>
        /// Raises the XCoordChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnXCoordChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.XCoordChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the XCoordChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnXCoordChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.XCoordChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveCableInfosReference()
        {
            return ((ITypedElement)(((ModelElement)(DuctInfo.ClassInstance)).Resolve("CableInfos")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the CableInfos property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void CableInfosCollectionChanging(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanging("CableInfos", e, _cableInfosReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the CableInfos property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void CableInfosCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("CableInfos", e, _cableInfosReference);
        }
        
        private static ITypedElement RetrieveDuctBankInfoReference()
        {
            return ((ITypedElement)(((ModelElement)(DuctInfo.ClassInstance)).Resolve("DuctBankInfo")));
        }
        
        /// <summary>
        /// Raises the DuctBankInfoChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnDuctBankInfoChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.DuctBankInfoChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the DuctBankInfoChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnDuctBankInfoChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.DuctBankInfoChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the DuctBankInfo property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetDuctBankInfo(object sender, System.EventArgs eventArgs)
        {
            this.DuctBankInfo = null;
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "YCOORD"))
            {
                return this.YCoord;
            }
            if ((attribute == "XCOORD"))
            {
                return this.XCoord;
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
            if ((feature == "CABLEINFOS"))
            {
                return this._cableInfos;
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
            if ((feature == "DUCTBANKINFO"))
            {
                this.DuctBankInfo = ((IDuctBankInfo)(value));
                return;
            }
            if ((feature == "YCOORD"))
            {
                this.YCoord = ((int)(value));
                return;
            }
            if ((feature == "XCOORD"))
            {
                this.XCoord = ((int)(value));
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
            if ((attribute == "DuctBankInfo"))
            {
                return new DuctBankInfoProxy(this);
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
            if ((reference == "DuctBankInfo"))
            {
                return new DuctBankInfoProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfAssets/DuctInf" +
                        "o")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the DuctInfo class
        /// </summary>
        public class DuctInfoReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private DuctInfo _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public DuctInfoReferencedElementsCollection(DuctInfo parent)
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
                    count = (count + this._parent.CableInfos.Count);
                    if ((this._parent.DuctBankInfo != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.CableInfos.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.DuctBankInfoChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.CableInfos.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.DuctBankInfoChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                ICableInfo cableInfosCasted = item.As<ICableInfo>();
                if ((cableInfosCasted != null))
                {
                    this._parent.CableInfos.Add(cableInfosCasted);
                }
                if ((this._parent.DuctBankInfo == null))
                {
                    IDuctBankInfo ductBankInfoCasted = item.As<IDuctBankInfo>();
                    if ((ductBankInfoCasted != null))
                    {
                        this._parent.DuctBankInfo = ductBankInfoCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.CableInfos.Clear();
                this._parent.DuctBankInfo = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.CableInfos.Contains(item))
                {
                    return true;
                }
                if ((item == this._parent.DuctBankInfo))
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
                IEnumerator<IModelElement> cableInfosEnumerator = this._parent.CableInfos.GetEnumerator();
                try
                {
                    for (
                    ; cableInfosEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = cableInfosEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    cableInfosEnumerator.Dispose();
                }
                if ((this._parent.DuctBankInfo != null))
                {
                    array[arrayIndex] = this._parent.DuctBankInfo;
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
                ICableInfo cableInfoItem = item.As<ICableInfo>();
                if (((cableInfoItem != null) 
                            && this._parent.CableInfos.Remove(cableInfoItem)))
                {
                    return true;
                }
                if ((this._parent.DuctBankInfo == item))
                {
                    this._parent.DuctBankInfo = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.CableInfos).Concat(this._parent.DuctBankInfo).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the yCoord property
        /// </summary>
        private sealed class YCoordProxy : ModelPropertyChange<IDuctInfo, int>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public YCoordProxy(IDuctInfo modelElement) : 
                    base(modelElement, "yCoord")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override int Value
            {
                get
                {
                    return this.ModelElement.YCoord;
                }
                set
                {
                    this.ModelElement.YCoord = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the xCoord property
        /// </summary>
        private sealed class XCoordProxy : ModelPropertyChange<IDuctInfo, int>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public XCoordProxy(IDuctInfo modelElement) : 
                    base(modelElement, "xCoord")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override int Value
            {
                get
                {
                    return this.ModelElement.XCoord;
                }
                set
                {
                    this.ModelElement.XCoord = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the DuctBankInfo property
        /// </summary>
        private sealed class DuctBankInfoProxy : ModelPropertyChange<IDuctInfo, IDuctBankInfo>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public DuctBankInfoProxy(IDuctInfo modelElement) : 
                    base(modelElement, "DuctBankInfo")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IDuctBankInfo Value
            {
                get
                {
                    return this.ModelElement.DuctBankInfo;
                }
                set
                {
                    this.ModelElement.DuctBankInfo = value;
                }
            }
        }
    }
}

