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
    /// The default implementation of the AssetAssetRole class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#InfAssets")]
    [XmlNamespacePrefixAttribute("cimInfAssets")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfAssets/AssetAs" +
        "setRole")]
    [DebuggerDisplayAttribute("AssetAssetRole {UUID}")]
    public partial class AssetAssetRole : Role, IAssetAssetRole, IModelElement
    {
        
        private static Lazy<ITypedElement> _toAssetReference = new Lazy<ITypedElement>(RetrieveToAssetReference);
        
        /// <summary>
        /// The backing field for the ToAsset property
        /// </summary>
        private IAsset _toAsset;
        
        private static Lazy<ITypedElement> _fromAssetReference = new Lazy<ITypedElement>(RetrieveFromAssetReference);
        
        /// <summary>
        /// The backing field for the FromAsset property
        /// </summary>
        private IAsset _fromAsset;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The ToAsset property
        /// </summary>
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("FromAssetRoles")]
        public virtual IAsset ToAsset
        {
            get
            {
                return this._toAsset;
            }
            set
            {
                if ((this._toAsset != value))
                {
                    IAsset old = this._toAsset;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnToAssetChanging(e);
                    this.OnPropertyChanging("ToAsset", e, _toAssetReference);
                    this._toAsset = value;
                    if ((old != null))
                    {
                        old.FromAssetRoles.Remove(this);
                        old.Deleted -= this.OnResetToAsset;
                    }
                    if ((value != null))
                    {
                        value.FromAssetRoles.Add(this);
                        value.Deleted += this.OnResetToAsset;
                    }
                    this.OnToAssetChanged(e);
                    this.OnPropertyChanged("ToAsset", e, _toAssetReference);
                }
            }
        }
        
        /// <summary>
        /// The FromAsset property
        /// </summary>
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("ToAssetRoles")]
        public virtual IAsset FromAsset
        {
            get
            {
                return this._fromAsset;
            }
            set
            {
                if ((this._fromAsset != value))
                {
                    IAsset old = this._fromAsset;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnFromAssetChanging(e);
                    this.OnPropertyChanging("FromAsset", e, _fromAssetReference);
                    this._fromAsset = value;
                    if ((old != null))
                    {
                        old.ToAssetRoles.Remove(this);
                        old.Deleted -= this.OnResetFromAsset;
                    }
                    if ((value != null))
                    {
                        value.ToAssetRoles.Add(this);
                        value.Deleted += this.OnResetFromAsset;
                    }
                    this.OnFromAssetChanged(e);
                    this.OnPropertyChanged("FromAsset", e, _fromAssetReference);
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
                return base.ReferencedElements.Concat(new AssetAssetRoleReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfAssets/AssetAs" +
                            "setRole")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the ToAsset property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ToAssetChanging;
        
        /// <summary>
        /// Gets fired when the ToAsset property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ToAssetChanged;
        
        /// <summary>
        /// Gets fired before the FromAsset property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> FromAssetChanging;
        
        /// <summary>
        /// Gets fired when the FromAsset property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> FromAssetChanged;
        
        private static ITypedElement RetrieveToAssetReference()
        {
            return ((ITypedElement)(((ModelElement)(AssetAssetRole.ClassInstance)).Resolve("ToAsset")));
        }
        
        /// <summary>
        /// Raises the ToAssetChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnToAssetChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ToAssetChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the ToAssetChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnToAssetChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ToAssetChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the ToAsset property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetToAsset(object sender, System.EventArgs eventArgs)
        {
            this.ToAsset = null;
        }
        
        private static ITypedElement RetrieveFromAssetReference()
        {
            return ((ITypedElement)(((ModelElement)(AssetAssetRole.ClassInstance)).Resolve("FromAsset")));
        }
        
        /// <summary>
        /// Raises the FromAssetChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnFromAssetChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.FromAssetChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the FromAssetChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnFromAssetChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.FromAssetChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the FromAsset property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetFromAsset(object sender, System.EventArgs eventArgs)
        {
            this.FromAsset = null;
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "TOASSET"))
            {
                this.ToAsset = ((IAsset)(value));
                return;
            }
            if ((feature == "FROMASSET"))
            {
                this.FromAsset = ((IAsset)(value));
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
            if ((attribute == "ToAsset"))
            {
                return new ToAssetProxy(this);
            }
            if ((attribute == "FromAsset"))
            {
                return new FromAssetProxy(this);
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
            if ((reference == "ToAsset"))
            {
                return new ToAssetProxy(this);
            }
            if ((reference == "FromAsset"))
            {
                return new FromAssetProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfAssets/AssetAs" +
                        "setRole")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the AssetAssetRole class
        /// </summary>
        public class AssetAssetRoleReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private AssetAssetRole _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public AssetAssetRoleReferencedElementsCollection(AssetAssetRole parent)
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
                    if ((this._parent.ToAsset != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.FromAsset != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.ToAssetChanged += this.PropagateValueChanges;
                this._parent.FromAssetChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.ToAssetChanged -= this.PropagateValueChanges;
                this._parent.FromAssetChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.ToAsset == null))
                {
                    IAsset toAssetCasted = item.As<IAsset>();
                    if ((toAssetCasted != null))
                    {
                        this._parent.ToAsset = toAssetCasted;
                        return;
                    }
                }
                if ((this._parent.FromAsset == null))
                {
                    IAsset fromAssetCasted = item.As<IAsset>();
                    if ((fromAssetCasted != null))
                    {
                        this._parent.FromAsset = fromAssetCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.ToAsset = null;
                this._parent.FromAsset = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.ToAsset))
                {
                    return true;
                }
                if ((item == this._parent.FromAsset))
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
                if ((this._parent.ToAsset != null))
                {
                    array[arrayIndex] = this._parent.ToAsset;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.FromAsset != null))
                {
                    array[arrayIndex] = this._parent.FromAsset;
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
                if ((this._parent.ToAsset == item))
                {
                    this._parent.ToAsset = null;
                    return true;
                }
                if ((this._parent.FromAsset == item))
                {
                    this._parent.FromAsset = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.ToAsset).Concat(this._parent.FromAsset).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the ToAsset property
        /// </summary>
        private sealed class ToAssetProxy : ModelPropertyChange<IAssetAssetRole, IAsset>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public ToAssetProxy(IAssetAssetRole modelElement) : 
                    base(modelElement, "ToAsset")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IAsset Value
            {
                get
                {
                    return this.ModelElement.ToAsset;
                }
                set
                {
                    this.ModelElement.ToAsset = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the FromAsset property
        /// </summary>
        private sealed class FromAssetProxy : ModelPropertyChange<IAssetAssetRole, IAsset>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public FromAssetProxy(IAssetAssetRole modelElement) : 
                    base(modelElement, "FromAsset")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IAsset Value
            {
                get
                {
                    return this.ModelElement.FromAsset;
                }
                set
                {
                    this.ModelElement.FromAsset = value;
                }
            }
        }
    }
}

