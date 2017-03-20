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
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Meas;

namespace TTC2017.SmartGrids.CIM.IEC61970.SCADA
{
    
    
    /// <summary>
    /// The default implementation of the RemoteUnit class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#SCADA")]
    [XmlNamespacePrefixAttribute("cimSCADA")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/SCADA/RemoteUnit")]
    [DebuggerDisplayAttribute("RemoteUnit {UUID}")]
    public partial class RemoteUnit : PowerSystemResource, IRemoteUnit, IModelElement
    {
        
        /// <summary>
        /// The backing field for the RemoteUnitType property
        /// </summary>
        private Nullable<RemoteUnitType> _remoteUnitType;
        
        private static Lazy<ITypedElement> _remoteUnitTypeAttribute = new Lazy<ITypedElement>(RetrieveRemoteUnitTypeAttribute);
        
        private static Lazy<ITypedElement> _remotePointsReference = new Lazy<ITypedElement>(RetrieveRemotePointsReference);
        
        /// <summary>
        /// The backing field for the RemotePoints property
        /// </summary>
        private RemoteUnitRemotePointsCollection _remotePoints;
        
        private static Lazy<ITypedElement> _communicationLinksReference = new Lazy<ITypedElement>(RetrieveCommunicationLinksReference);
        
        /// <summary>
        /// The backing field for the CommunicationLinks property
        /// </summary>
        private RemoteUnitCommunicationLinksCollection _communicationLinks;
        
        private static IClass _classInstance;
        
        public RemoteUnit()
        {
            this._remotePoints = new RemoteUnitRemotePointsCollection(this);
            this._remotePoints.CollectionChanging += this.RemotePointsCollectionChanging;
            this._remotePoints.CollectionChanged += this.RemotePointsCollectionChanged;
            this._communicationLinks = new RemoteUnitCommunicationLinksCollection(this);
            this._communicationLinks.CollectionChanging += this.CommunicationLinksCollectionChanging;
            this._communicationLinks.CollectionChanged += this.CommunicationLinksCollectionChanged;
        }
        
        /// <summary>
        /// The remoteUnitType property
        /// </summary>
        [XmlElementNameAttribute("remoteUnitType")]
        [XmlAttributeAttribute(true)]
        public virtual Nullable<RemoteUnitType> RemoteUnitType
        {
            get
            {
                return this._remoteUnitType;
            }
            set
            {
                if ((this._remoteUnitType != value))
                {
                    Nullable<RemoteUnitType> old = this._remoteUnitType;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnRemoteUnitTypeChanging(e);
                    this.OnPropertyChanging("RemoteUnitType", e, _remoteUnitTypeAttribute);
                    this._remoteUnitType = value;
                    this.OnRemoteUnitTypeChanged(e);
                    this.OnPropertyChanged("RemoteUnitType", e, _remoteUnitTypeAttribute);
                }
            }
        }
        
        /// <summary>
        /// The RemotePoints property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("RemoteUnit")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<IRemotePoint> RemotePoints
        {
            get
            {
                return this._remotePoints;
            }
        }
        
        /// <summary>
        /// The CommunicationLinks property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("RemoteUnits")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<ICommunicationLink> CommunicationLinks
        {
            get
            {
                return this._communicationLinks;
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new RemoteUnitReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/SCADA/RemoteUnit")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the RemoteUnitType property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> RemoteUnitTypeChanging;
        
        /// <summary>
        /// Gets fired when the RemoteUnitType property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> RemoteUnitTypeChanged;
        
        private static ITypedElement RetrieveRemoteUnitTypeAttribute()
        {
            return ((ITypedElement)(((ModelElement)(RemoteUnit.ClassInstance)).Resolve("remoteUnitType")));
        }
        
        /// <summary>
        /// Raises the RemoteUnitTypeChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnRemoteUnitTypeChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.RemoteUnitTypeChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the RemoteUnitTypeChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnRemoteUnitTypeChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.RemoteUnitTypeChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveRemotePointsReference()
        {
            return ((ITypedElement)(((ModelElement)(RemoteUnit.ClassInstance)).Resolve("RemotePoints")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the RemotePoints property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void RemotePointsCollectionChanging(object sender, NMF.Collections.ObjectModel.NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("RemotePoints", e, _remotePointsReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the RemotePoints property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void RemotePointsCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("RemotePoints", e, _remotePointsReference);
        }
        
        private static ITypedElement RetrieveCommunicationLinksReference()
        {
            return ((ITypedElement)(((ModelElement)(RemoteUnit.ClassInstance)).Resolve("CommunicationLinks")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the CommunicationLinks property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void CommunicationLinksCollectionChanging(object sender, NMF.Collections.ObjectModel.NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("CommunicationLinks", e, _communicationLinksReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the CommunicationLinks property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void CommunicationLinksCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("CommunicationLinks", e, _communicationLinksReference);
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "REMOTEUNITTYPE"))
            {
                return this.RemoteUnitType;
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
            if ((feature == "REMOTEPOINTS"))
            {
                return this._remotePoints;
            }
            if ((feature == "COMMUNICATIONLINKS"))
            {
                return this._communicationLinks;
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
            if ((feature == "REMOTEUNITTYPE"))
            {
                this.RemoteUnitType = ((RemoteUnitType)(value));
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/SCADA/RemoteUnit")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the RemoteUnit class
        /// </summary>
        public class RemoteUnitReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private RemoteUnit _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public RemoteUnitReferencedElementsCollection(RemoteUnit parent)
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
                    count = (count + this._parent.RemotePoints.Count);
                    count = (count + this._parent.CommunicationLinks.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.RemotePoints.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.CommunicationLinks.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.RemotePoints.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.CommunicationLinks.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IRemotePoint remotePointsCasted = item.As<IRemotePoint>();
                if ((remotePointsCasted != null))
                {
                    this._parent.RemotePoints.Add(remotePointsCasted);
                }
                ICommunicationLink communicationLinksCasted = item.As<ICommunicationLink>();
                if ((communicationLinksCasted != null))
                {
                    this._parent.CommunicationLinks.Add(communicationLinksCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.RemotePoints.Clear();
                this._parent.CommunicationLinks.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.RemotePoints.Contains(item))
                {
                    return true;
                }
                if (this._parent.CommunicationLinks.Contains(item))
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
                IEnumerator<IModelElement> remotePointsEnumerator = this._parent.RemotePoints.GetEnumerator();
                try
                {
                    for (
                    ; remotePointsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = remotePointsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    remotePointsEnumerator.Dispose();
                }
                IEnumerator<IModelElement> communicationLinksEnumerator = this._parent.CommunicationLinks.GetEnumerator();
                try
                {
                    for (
                    ; communicationLinksEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = communicationLinksEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    communicationLinksEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IRemotePoint remotePointItem = item.As<IRemotePoint>();
                if (((remotePointItem != null) 
                            && this._parent.RemotePoints.Remove(remotePointItem)))
                {
                    return true;
                }
                ICommunicationLink communicationLinkItem = item.As<ICommunicationLink>();
                if (((communicationLinkItem != null) 
                            && this._parent.CommunicationLinks.Remove(communicationLinkItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.RemotePoints).Concat(this._parent.CommunicationLinks).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the remoteUnitType property
        /// </summary>
        private sealed class RemoteUnitTypeProxy : ModelPropertyChange<IRemoteUnit, Nullable<RemoteUnitType>>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public RemoteUnitTypeProxy(IRemoteUnit modelElement) : 
                    base(modelElement, "remoteUnitType")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override Nullable<RemoteUnitType> Value
            {
                get
                {
                    return this.ModelElement.RemoteUnitType;
                }
                set
                {
                    this.ModelElement.RemoteUnitType = value;
                }
            }
        }
    }
}
