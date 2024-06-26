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
    /// The default implementation of the DocAssetRole class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#InfAssets")]
    [XmlNamespacePrefixAttribute("cimInfAssets")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfAssets/DocAsse" +
        "tRole")]
    [DebuggerDisplayAttribute("DocAssetRole {UUID}")]
    public partial class DocAssetRole : Role, IDocAssetRole, IModelElement
    {
        
        private static Lazy<ITypedElement> _assetReference = new Lazy<ITypedElement>(RetrieveAssetReference);
        
        /// <summary>
        /// The backing field for the Asset property
        /// </summary>
        private IAsset _asset;
        
        private static Lazy<ITypedElement> _documentReference = new Lazy<ITypedElement>(RetrieveDocumentReference);
        
        /// <summary>
        /// The backing field for the Document property
        /// </summary>
        private IDocument _document;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The Asset property
        /// </summary>
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("DocumentRoles")]
        public virtual IAsset Asset
        {
            get
            {
                return this._asset;
            }
            set
            {
                if ((this._asset != value))
                {
                    IAsset old = this._asset;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnAssetChanging(e);
                    this.OnPropertyChanging("Asset", e, _assetReference);
                    this._asset = value;
                    if ((old != null))
                    {
                        old.DocumentRoles.Remove(this);
                        old.Deleted -= this.OnResetAsset;
                    }
                    if ((value != null))
                    {
                        value.DocumentRoles.Add(this);
                        value.Deleted += this.OnResetAsset;
                    }
                    this.OnAssetChanged(e);
                    this.OnPropertyChanged("Asset", e, _assetReference);
                }
            }
        }
        
        /// <summary>
        /// The Document property
        /// </summary>
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("AssetRoles")]
        public virtual IDocument Document
        {
            get
            {
                return this._document;
            }
            set
            {
                if ((this._document != value))
                {
                    IDocument old = this._document;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnDocumentChanging(e);
                    this.OnPropertyChanging("Document", e, _documentReference);
                    this._document = value;
                    if ((old != null))
                    {
                        old.AssetRoles.Remove(this);
                        old.Deleted -= this.OnResetDocument;
                    }
                    if ((value != null))
                    {
                        value.AssetRoles.Add(this);
                        value.Deleted += this.OnResetDocument;
                    }
                    this.OnDocumentChanged(e);
                    this.OnPropertyChanged("Document", e, _documentReference);
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
                return base.ReferencedElements.Concat(new DocAssetRoleReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfAssets/DocAsse" +
                            "tRole")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the Asset property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> AssetChanging;
        
        /// <summary>
        /// Gets fired when the Asset property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> AssetChanged;
        
        /// <summary>
        /// Gets fired before the Document property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> DocumentChanging;
        
        /// <summary>
        /// Gets fired when the Document property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> DocumentChanged;
        
        private static ITypedElement RetrieveAssetReference()
        {
            return ((ITypedElement)(((ModelElement)(DocAssetRole.ClassInstance)).Resolve("Asset")));
        }
        
        /// <summary>
        /// Raises the AssetChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnAssetChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.AssetChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the AssetChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnAssetChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.AssetChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the Asset property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetAsset(object sender, System.EventArgs eventArgs)
        {
            this.Asset = null;
        }
        
        private static ITypedElement RetrieveDocumentReference()
        {
            return ((ITypedElement)(((ModelElement)(DocAssetRole.ClassInstance)).Resolve("Document")));
        }
        
        /// <summary>
        /// Raises the DocumentChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnDocumentChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.DocumentChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the DocumentChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnDocumentChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.DocumentChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the Document property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetDocument(object sender, System.EventArgs eventArgs)
        {
            this.Document = null;
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "ASSET"))
            {
                this.Asset = ((IAsset)(value));
                return;
            }
            if ((feature == "DOCUMENT"))
            {
                this.Document = ((IDocument)(value));
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
            if ((attribute == "Asset"))
            {
                return new AssetProxy(this);
            }
            if ((attribute == "Document"))
            {
                return new DocumentProxy(this);
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
            if ((reference == "Asset"))
            {
                return new AssetProxy(this);
            }
            if ((reference == "Document"))
            {
                return new DocumentProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfAssets/DocAsse" +
                        "tRole")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the DocAssetRole class
        /// </summary>
        public class DocAssetRoleReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private DocAssetRole _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public DocAssetRoleReferencedElementsCollection(DocAssetRole parent)
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
                    if ((this._parent.Asset != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.Document != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.AssetChanged += this.PropagateValueChanges;
                this._parent.DocumentChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.AssetChanged -= this.PropagateValueChanges;
                this._parent.DocumentChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.Asset == null))
                {
                    IAsset assetCasted = item.As<IAsset>();
                    if ((assetCasted != null))
                    {
                        this._parent.Asset = assetCasted;
                        return;
                    }
                }
                if ((this._parent.Document == null))
                {
                    IDocument documentCasted = item.As<IDocument>();
                    if ((documentCasted != null))
                    {
                        this._parent.Document = documentCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.Asset = null;
                this._parent.Document = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.Asset))
                {
                    return true;
                }
                if ((item == this._parent.Document))
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
                if ((this._parent.Asset != null))
                {
                    array[arrayIndex] = this._parent.Asset;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.Document != null))
                {
                    array[arrayIndex] = this._parent.Document;
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
                if ((this._parent.Asset == item))
                {
                    this._parent.Asset = null;
                    return true;
                }
                if ((this._parent.Document == item))
                {
                    this._parent.Document = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.Asset).Concat(this._parent.Document).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the Asset property
        /// </summary>
        private sealed class AssetProxy : ModelPropertyChange<IDocAssetRole, IAsset>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public AssetProxy(IDocAssetRole modelElement) : 
                    base(modelElement, "Asset")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IAsset Value
            {
                get
                {
                    return this.ModelElement.Asset;
                }
                set
                {
                    this.ModelElement.Asset = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the Document property
        /// </summary>
        private sealed class DocumentProxy : ModelPropertyChange<IDocAssetRole, IDocument>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public DocumentProxy(IDocAssetRole modelElement) : 
                    base(modelElement, "Document")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IDocument Value
            {
                get
                {
                    return this.ModelElement.Document;
                }
                set
                {
                    this.ModelElement.Document = value;
                }
            }
        }
    }
}

