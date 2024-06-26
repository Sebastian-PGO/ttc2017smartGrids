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
using TTC2017.SmartGrids.CIM.IEC61968.AssetModels;
using TTC2017.SmartGrids.CIM.IEC61968.Assets;
using TTC2017.SmartGrids.CIM.IEC61968.Common;
using TTC2017.SmartGrids.CIM.IEC61968.Customers;
using TTC2017.SmartGrids.CIM.IEC61968.PaymentMetering;
using TTC2017.SmartGrids.CIM.IEC61968.WiresExt;
using TTC2017.SmartGrids.CIM.IEC61968.Work;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Domain;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssetModels;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssets;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfCustomers;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfMetering;
using TTC2017.SmartGrids.CIM.IEC61970.Meas;
using TTC2017.SmartGrids.CIM.IEC61970.Wires;

namespace TTC2017.SmartGrids.CIM.IEC61968.Metering
{
    
    
    /// <summary>
    /// The default implementation of the SDPLocation class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#Metering")]
    [XmlNamespacePrefixAttribute("cimMetering")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61968/Metering/SDPLocation")]
    [DebuggerDisplayAttribute("SDPLocation {UUID}")]
    public partial class SDPLocation : Location, ISDPLocation, IModelElement
    {
        
        /// <summary>
        /// The backing field for the AccessMethod property
        /// </summary>
        private string _accessMethod;
        
        private static Lazy<ITypedElement> _accessMethodAttribute = new Lazy<ITypedElement>(RetrieveAccessMethodAttribute);
        
        /// <summary>
        /// The backing field for the Remark property
        /// </summary>
        private string _remark;
        
        private static Lazy<ITypedElement> _remarkAttribute = new Lazy<ITypedElement>(RetrieveRemarkAttribute);
        
        /// <summary>
        /// The backing field for the SiteAccessProblem property
        /// </summary>
        private string _siteAccessProblem;
        
        private static Lazy<ITypedElement> _siteAccessProblemAttribute = new Lazy<ITypedElement>(RetrieveSiteAccessProblemAttribute);
        
        /// <summary>
        /// The backing field for the OccupancyDate property
        /// </summary>
        private string _occupancyDate;
        
        private static Lazy<ITypedElement> _occupancyDateAttribute = new Lazy<ITypedElement>(RetrieveOccupancyDateAttribute);
        
        private static Lazy<ITypedElement> _serviceDeliveryPointsReference = new Lazy<ITypedElement>(RetrieveServiceDeliveryPointsReference);
        
        /// <summary>
        /// The backing field for the ServiceDeliveryPoints property
        /// </summary>
        private SDPLocationServiceDeliveryPointsCollection _serviceDeliveryPoints;
        
        private static IClass _classInstance;
        
        public SDPLocation()
        {
            this._serviceDeliveryPoints = new SDPLocationServiceDeliveryPointsCollection(this);
            this._serviceDeliveryPoints.CollectionChanging += this.ServiceDeliveryPointsCollectionChanging;
            this._serviceDeliveryPoints.CollectionChanged += this.ServiceDeliveryPointsCollectionChanged;
        }
        
        /// <summary>
        /// The accessMethod property
        /// </summary>
        [XmlElementNameAttribute("accessMethod")]
        [XmlAttributeAttribute(true)]
        public virtual string AccessMethod
        {
            get
            {
                return this._accessMethod;
            }
            set
            {
                if ((this._accessMethod != value))
                {
                    string old = this._accessMethod;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnAccessMethodChanging(e);
                    this.OnPropertyChanging("AccessMethod", e, _accessMethodAttribute);
                    this._accessMethod = value;
                    this.OnAccessMethodChanged(e);
                    this.OnPropertyChanged("AccessMethod", e, _accessMethodAttribute);
                }
            }
        }
        
        /// <summary>
        /// The remark property
        /// </summary>
        [XmlElementNameAttribute("remark")]
        [XmlAttributeAttribute(true)]
        public virtual string Remark
        {
            get
            {
                return this._remark;
            }
            set
            {
                if ((this._remark != value))
                {
                    string old = this._remark;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnRemarkChanging(e);
                    this.OnPropertyChanging("Remark", e, _remarkAttribute);
                    this._remark = value;
                    this.OnRemarkChanged(e);
                    this.OnPropertyChanged("Remark", e, _remarkAttribute);
                }
            }
        }
        
        /// <summary>
        /// The siteAccessProblem property
        /// </summary>
        [XmlElementNameAttribute("siteAccessProblem")]
        [XmlAttributeAttribute(true)]
        public virtual string SiteAccessProblem
        {
            get
            {
                return this._siteAccessProblem;
            }
            set
            {
                if ((this._siteAccessProblem != value))
                {
                    string old = this._siteAccessProblem;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnSiteAccessProblemChanging(e);
                    this.OnPropertyChanging("SiteAccessProblem", e, _siteAccessProblemAttribute);
                    this._siteAccessProblem = value;
                    this.OnSiteAccessProblemChanged(e);
                    this.OnPropertyChanged("SiteAccessProblem", e, _siteAccessProblemAttribute);
                }
            }
        }
        
        /// <summary>
        /// The occupancyDate property
        /// </summary>
        [XmlElementNameAttribute("occupancyDate")]
        [XmlAttributeAttribute(true)]
        public virtual string OccupancyDate
        {
            get
            {
                return this._occupancyDate;
            }
            set
            {
                if ((this._occupancyDate != value))
                {
                    string old = this._occupancyDate;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnOccupancyDateChanging(e);
                    this.OnPropertyChanging("OccupancyDate", e, _occupancyDateAttribute);
                    this._occupancyDate = value;
                    this.OnOccupancyDateChanged(e);
                    this.OnPropertyChanged("OccupancyDate", e, _occupancyDateAttribute);
                }
            }
        }
        
        /// <summary>
        /// The ServiceDeliveryPoints property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("SDPLocations")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<IServiceDeliveryPoint> ServiceDeliveryPoints
        {
            get
            {
                return this._serviceDeliveryPoints;
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new SDPLocationReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61968/Metering/SDPLocation")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the AccessMethod property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> AccessMethodChanging;
        
        /// <summary>
        /// Gets fired when the AccessMethod property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> AccessMethodChanged;
        
        /// <summary>
        /// Gets fired before the Remark property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> RemarkChanging;
        
        /// <summary>
        /// Gets fired when the Remark property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> RemarkChanged;
        
        /// <summary>
        /// Gets fired before the SiteAccessProblem property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> SiteAccessProblemChanging;
        
        /// <summary>
        /// Gets fired when the SiteAccessProblem property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> SiteAccessProblemChanged;
        
        /// <summary>
        /// Gets fired before the OccupancyDate property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> OccupancyDateChanging;
        
        /// <summary>
        /// Gets fired when the OccupancyDate property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> OccupancyDateChanged;
        
        private static ITypedElement RetrieveAccessMethodAttribute()
        {
            return ((ITypedElement)(((ModelElement)(SDPLocation.ClassInstance)).Resolve("accessMethod")));
        }
        
        /// <summary>
        /// Raises the AccessMethodChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnAccessMethodChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.AccessMethodChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the AccessMethodChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnAccessMethodChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.AccessMethodChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveRemarkAttribute()
        {
            return ((ITypedElement)(((ModelElement)(SDPLocation.ClassInstance)).Resolve("remark")));
        }
        
        /// <summary>
        /// Raises the RemarkChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnRemarkChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.RemarkChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the RemarkChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnRemarkChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.RemarkChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveSiteAccessProblemAttribute()
        {
            return ((ITypedElement)(((ModelElement)(SDPLocation.ClassInstance)).Resolve("siteAccessProblem")));
        }
        
        /// <summary>
        /// Raises the SiteAccessProblemChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnSiteAccessProblemChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.SiteAccessProblemChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the SiteAccessProblemChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnSiteAccessProblemChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.SiteAccessProblemChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveOccupancyDateAttribute()
        {
            return ((ITypedElement)(((ModelElement)(SDPLocation.ClassInstance)).Resolve("occupancyDate")));
        }
        
        /// <summary>
        /// Raises the OccupancyDateChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnOccupancyDateChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.OccupancyDateChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the OccupancyDateChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnOccupancyDateChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.OccupancyDateChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveServiceDeliveryPointsReference()
        {
            return ((ITypedElement)(((ModelElement)(SDPLocation.ClassInstance)).Resolve("ServiceDeliveryPoints")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the ServiceDeliveryPoints property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void ServiceDeliveryPointsCollectionChanging(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanging("ServiceDeliveryPoints", e, _serviceDeliveryPointsReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the ServiceDeliveryPoints property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void ServiceDeliveryPointsCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("ServiceDeliveryPoints", e, _serviceDeliveryPointsReference);
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "ACCESSMETHOD"))
            {
                return this.AccessMethod;
            }
            if ((attribute == "REMARK"))
            {
                return this.Remark;
            }
            if ((attribute == "SITEACCESSPROBLEM"))
            {
                return this.SiteAccessProblem;
            }
            if ((attribute == "OCCUPANCYDATE"))
            {
                return this.OccupancyDate;
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
            if ((feature == "SERVICEDELIVERYPOINTS"))
            {
                return this._serviceDeliveryPoints;
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
            if ((feature == "ACCESSMETHOD"))
            {
                this.AccessMethod = ((string)(value));
                return;
            }
            if ((feature == "REMARK"))
            {
                this.Remark = ((string)(value));
                return;
            }
            if ((feature == "SITEACCESSPROBLEM"))
            {
                this.SiteAccessProblem = ((string)(value));
                return;
            }
            if ((feature == "OCCUPANCYDATE"))
            {
                this.OccupancyDate = ((string)(value));
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61968/Metering/SDPLocation")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the SDPLocation class
        /// </summary>
        public class SDPLocationReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private SDPLocation _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public SDPLocationReferencedElementsCollection(SDPLocation parent)
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
                    count = (count + this._parent.ServiceDeliveryPoints.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.ServiceDeliveryPoints.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.ServiceDeliveryPoints.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IServiceDeliveryPoint serviceDeliveryPointsCasted = item.As<IServiceDeliveryPoint>();
                if ((serviceDeliveryPointsCasted != null))
                {
                    this._parent.ServiceDeliveryPoints.Add(serviceDeliveryPointsCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.ServiceDeliveryPoints.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.ServiceDeliveryPoints.Contains(item))
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
                IEnumerator<IModelElement> serviceDeliveryPointsEnumerator = this._parent.ServiceDeliveryPoints.GetEnumerator();
                try
                {
                    for (
                    ; serviceDeliveryPointsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = serviceDeliveryPointsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    serviceDeliveryPointsEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IServiceDeliveryPoint serviceDeliveryPointItem = item.As<IServiceDeliveryPoint>();
                if (((serviceDeliveryPointItem != null) 
                            && this._parent.ServiceDeliveryPoints.Remove(serviceDeliveryPointItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.ServiceDeliveryPoints).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the accessMethod property
        /// </summary>
        private sealed class AccessMethodProxy : ModelPropertyChange<ISDPLocation, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public AccessMethodProxy(ISDPLocation modelElement) : 
                    base(modelElement, "accessMethod")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override string Value
            {
                get
                {
                    return this.ModelElement.AccessMethod;
                }
                set
                {
                    this.ModelElement.AccessMethod = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the remark property
        /// </summary>
        private sealed class RemarkProxy : ModelPropertyChange<ISDPLocation, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public RemarkProxy(ISDPLocation modelElement) : 
                    base(modelElement, "remark")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override string Value
            {
                get
                {
                    return this.ModelElement.Remark;
                }
                set
                {
                    this.ModelElement.Remark = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the siteAccessProblem property
        /// </summary>
        private sealed class SiteAccessProblemProxy : ModelPropertyChange<ISDPLocation, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public SiteAccessProblemProxy(ISDPLocation modelElement) : 
                    base(modelElement, "siteAccessProblem")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override string Value
            {
                get
                {
                    return this.ModelElement.SiteAccessProblem;
                }
                set
                {
                    this.ModelElement.SiteAccessProblem = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the occupancyDate property
        /// </summary>
        private sealed class OccupancyDateProxy : ModelPropertyChange<ISDPLocation, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public OccupancyDateProxy(ISDPLocation modelElement) : 
                    base(modelElement, "occupancyDate")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override string Value
            {
                get
                {
                    return this.ModelElement.OccupancyDate;
                }
                set
                {
                    this.ModelElement.OccupancyDate = value;
                }
            }
        }
    }
}

