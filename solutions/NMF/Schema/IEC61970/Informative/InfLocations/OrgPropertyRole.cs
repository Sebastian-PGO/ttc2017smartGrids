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
using TTC2017.SmartGrids.CIM.IEC61968.Assets;
using TTC2017.SmartGrids.CIM.IEC61968.Common;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfCommon;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfERPSupport;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfWork;

namespace TTC2017.SmartGrids.CIM.IEC61970.Informative.InfLocations
{
    
    
    /// <summary>
    /// The default implementation of the OrgPropertyRole class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#InfLocations")]
    [XmlNamespacePrefixAttribute("cimInfLocations")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfLocations/OrgP" +
        "ropertyRole")]
    [DebuggerDisplayAttribute("OrgPropertyRole {UUID}")]
    public partial class OrgPropertyRole : Role, IOrgPropertyRole, IModelElement
    {
        
        private static Lazy<ITypedElement> _erpOrganisationReference = new Lazy<ITypedElement>(RetrieveErpOrganisationReference);
        
        /// <summary>
        /// The backing field for the ErpOrganisation property
        /// </summary>
        private IErpOrganisation _erpOrganisation;
        
        private static Lazy<ITypedElement> _landPropertyReference = new Lazy<ITypedElement>(RetrieveLandPropertyReference);
        
        /// <summary>
        /// The backing field for the LandProperty property
        /// </summary>
        private OrgPropertyRoleLandPropertyCollection _landProperty;
        
        private static IClass _classInstance;
        
        public OrgPropertyRole()
        {
            this._landProperty = new OrgPropertyRoleLandPropertyCollection(this);
            this._landProperty.CollectionChanging += this.LandPropertyCollectionChanging;
            this._landProperty.CollectionChanged += this.LandPropertyCollectionChanged;
        }
        
        /// <summary>
        /// The ErpOrganisation property
        /// </summary>
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("LandPropertyRoles")]
        public virtual IErpOrganisation ErpOrganisation
        {
            get
            {
                return this._erpOrganisation;
            }
            set
            {
                if ((this._erpOrganisation != value))
                {
                    IErpOrganisation old = this._erpOrganisation;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnErpOrganisationChanging(e);
                    this.OnPropertyChanging("ErpOrganisation", e, _erpOrganisationReference);
                    this._erpOrganisation = value;
                    if ((old != null))
                    {
                        old.LandPropertyRoles.Remove(this);
                        old.Deleted -= this.OnResetErpOrganisation;
                    }
                    if ((value != null))
                    {
                        value.LandPropertyRoles.Add(this);
                        value.Deleted += this.OnResetErpOrganisation;
                    }
                    this.OnErpOrganisationChanged(e);
                    this.OnPropertyChanged("ErpOrganisation", e, _erpOrganisationReference);
                }
            }
        }
        
        /// <summary>
        /// The LandProperty property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("ErpOrganisationRoles")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<ILandProperty> LandProperty
        {
            get
            {
                return this._landProperty;
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new OrgPropertyRoleReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfLocations/OrgP" +
                            "ropertyRole")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the ErpOrganisation property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ErpOrganisationChanging;
        
        /// <summary>
        /// Gets fired when the ErpOrganisation property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ErpOrganisationChanged;
        
        private static ITypedElement RetrieveErpOrganisationReference()
        {
            return ((ITypedElement)(((ModelElement)(OrgPropertyRole.ClassInstance)).Resolve("ErpOrganisation")));
        }
        
        /// <summary>
        /// Raises the ErpOrganisationChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnErpOrganisationChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ErpOrganisationChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the ErpOrganisationChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnErpOrganisationChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ErpOrganisationChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the ErpOrganisation property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetErpOrganisation(object sender, System.EventArgs eventArgs)
        {
            this.ErpOrganisation = null;
        }
        
        private static ITypedElement RetrieveLandPropertyReference()
        {
            return ((ITypedElement)(((ModelElement)(OrgPropertyRole.ClassInstance)).Resolve("LandProperty")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the LandProperty property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void LandPropertyCollectionChanging(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanging("LandProperty", e, _landPropertyReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the LandProperty property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void LandPropertyCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("LandProperty", e, _landPropertyReference);
        }
        
        /// <summary>
        /// Gets the Model element collection for the given feature
        /// </summary>
        /// <returns>A non-generic list of elements</returns>
        /// <param name="feature">The requested feature</param>
        protected override System.Collections.IList GetCollectionForFeature(string feature)
        {
            if ((feature == "LANDPROPERTY"))
            {
                return this._landProperty;
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
            if ((feature == "ERPORGANISATION"))
            {
                this.ErpOrganisation = ((IErpOrganisation)(value));
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
            if ((attribute == "ErpOrganisation"))
            {
                return new ErpOrganisationProxy(this);
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
            if ((reference == "ErpOrganisation"))
            {
                return new ErpOrganisationProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfLocations/OrgP" +
                        "ropertyRole")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the OrgPropertyRole class
        /// </summary>
        public class OrgPropertyRoleReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private OrgPropertyRole _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public OrgPropertyRoleReferencedElementsCollection(OrgPropertyRole parent)
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
                    if ((this._parent.ErpOrganisation != null))
                    {
                        count = (count + 1);
                    }
                    count = (count + this._parent.LandProperty.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.ErpOrganisationChanged += this.PropagateValueChanges;
                this._parent.LandProperty.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.ErpOrganisationChanged -= this.PropagateValueChanges;
                this._parent.LandProperty.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.ErpOrganisation == null))
                {
                    IErpOrganisation erpOrganisationCasted = item.As<IErpOrganisation>();
                    if ((erpOrganisationCasted != null))
                    {
                        this._parent.ErpOrganisation = erpOrganisationCasted;
                        return;
                    }
                }
                ILandProperty landPropertyCasted = item.As<ILandProperty>();
                if ((landPropertyCasted != null))
                {
                    this._parent.LandProperty.Add(landPropertyCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.ErpOrganisation = null;
                this._parent.LandProperty.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.ErpOrganisation))
                {
                    return true;
                }
                if (this._parent.LandProperty.Contains(item))
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
                if ((this._parent.ErpOrganisation != null))
                {
                    array[arrayIndex] = this._parent.ErpOrganisation;
                    arrayIndex = (arrayIndex + 1);
                }
                IEnumerator<IModelElement> landPropertyEnumerator = this._parent.LandProperty.GetEnumerator();
                try
                {
                    for (
                    ; landPropertyEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = landPropertyEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    landPropertyEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                if ((this._parent.ErpOrganisation == item))
                {
                    this._parent.ErpOrganisation = null;
                    return true;
                }
                ILandProperty landPropertyItem = item.As<ILandProperty>();
                if (((landPropertyItem != null) 
                            && this._parent.LandProperty.Remove(landPropertyItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.ErpOrganisation).Concat(this._parent.LandProperty).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the ErpOrganisation property
        /// </summary>
        private sealed class ErpOrganisationProxy : ModelPropertyChange<IOrgPropertyRole, IErpOrganisation>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public ErpOrganisationProxy(IOrgPropertyRole modelElement) : 
                    base(modelElement, "ErpOrganisation")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IErpOrganisation Value
            {
                get
                {
                    return this.ModelElement.ErpOrganisation;
                }
                set
                {
                    this.ModelElement.ErpOrganisation = value;
                }
            }
        }
    }
}

