using System.Collections.Specialized;
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
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace TTC2017.SmartGrids.OutagePreventionJointarget
{
    
    
    /// <summary>
    /// The default implementation of the PrivateMeterVoltage class
    /// </summary>
    [XmlNamespaceAttribute("http://www.transformation-tool-contest.eu/2017/smartGrids/VoltagePhaseMeasurement" +
        "s")]
    [XmlNamespacePrefixAttribute("outagePreventionJt")]
    [ModelRepresentationClassAttribute("http://www.transformation-tool-contest.eu/2017/smartGrids/VoltagePhaseMeasurement" +
        "s#//PrivateMeterVoltage")]
    public partial class PrivateMeterVoltage : Asset, IPrivateMeterVoltage, IModelElement
    {
        
        /// <summary>
        /// The backing field for the ID property
        /// </summary>
        private string _iD;
        
        private static Lazy<ITypedElement> _iDAttribute = new Lazy<ITypedElement>(RetrieveIDAttribute);
        
        /// <summary>
        /// The backing field for the VoltageA property
        /// </summary>
        private Nullable<double> _voltageA;
        
        private static Lazy<ITypedElement> _voltageAAttribute = new Lazy<ITypedElement>(RetrieveVoltageAAttribute);
        
        /// <summary>
        /// The backing field for the VoltageB property
        /// </summary>
        private Nullable<double> _voltageB;
        
        private static Lazy<ITypedElement> _voltageBAttribute = new Lazy<ITypedElement>(RetrieveVoltageBAttribute);
        
        /// <summary>
        /// The backing field for the VoltageC property
        /// </summary>
        private Nullable<double> _voltageC;
        
        private static Lazy<ITypedElement> _voltageCAttribute = new Lazy<ITypedElement>(RetrieveVoltageCAttribute);
        
        private static Lazy<ITypedElement> _serviceDeliveryPointReference = new Lazy<ITypedElement>(RetrieveServiceDeliveryPointReference);
        
        /// <summary>
        /// The backing field for the ServiceDeliveryPoint property
        /// </summary>
        private IServiceDeliveryPoint _serviceDeliveryPoint;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The ID property
        /// </summary>
        [XmlAttributeAttribute(true)]
        public string ID
        {
            get
            {
                return this._iD;
            }
            set
            {
                if ((this._iD != value))
                {
                    string old = this._iD;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnIDChanging(e);
                    this.OnPropertyChanging("ID", e, _iDAttribute);
                    this._iD = value;
                    this.OnIDChanged(e);
                    this.OnPropertyChanged("ID", e, _iDAttribute);
                }
            }
        }
        
        /// <summary>
        /// The VoltageA property
        /// </summary>
        [XmlAttributeAttribute(true)]
        public Nullable<double> VoltageA
        {
            get
            {
                return this._voltageA;
            }
            set
            {
                if ((this._voltageA != value))
                {
                    Nullable<double> old = this._voltageA;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnVoltageAChanging(e);
                    this.OnPropertyChanging("VoltageA", e, _voltageAAttribute);
                    this._voltageA = value;
                    this.OnVoltageAChanged(e);
                    this.OnPropertyChanged("VoltageA", e, _voltageAAttribute);
                }
            }
        }
        
        /// <summary>
        /// The VoltageB property
        /// </summary>
        [XmlAttributeAttribute(true)]
        public Nullable<double> VoltageB
        {
            get
            {
                return this._voltageB;
            }
            set
            {
                if ((this._voltageB != value))
                {
                    Nullable<double> old = this._voltageB;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnVoltageBChanging(e);
                    this.OnPropertyChanging("VoltageB", e, _voltageBAttribute);
                    this._voltageB = value;
                    this.OnVoltageBChanged(e);
                    this.OnPropertyChanged("VoltageB", e, _voltageBAttribute);
                }
            }
        }
        
        /// <summary>
        /// The VoltageC property
        /// </summary>
        [XmlAttributeAttribute(true)]
        public Nullable<double> VoltageC
        {
            get
            {
                return this._voltageC;
            }
            set
            {
                if ((this._voltageC != value))
                {
                    Nullable<double> old = this._voltageC;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnVoltageCChanging(e);
                    this.OnPropertyChanging("VoltageC", e, _voltageCAttribute);
                    this._voltageC = value;
                    this.OnVoltageCChanged(e);
                    this.OnPropertyChanged("VoltageC", e, _voltageCAttribute);
                }
            }
        }
        
        /// <summary>
        /// The ServiceDeliveryPoint property
        /// </summary>
        [XmlAttributeAttribute(true)]
        public IServiceDeliveryPoint ServiceDeliveryPoint
        {
            get
            {
                return this._serviceDeliveryPoint;
            }
            set
            {
                if ((this._serviceDeliveryPoint != value))
                {
                    IServiceDeliveryPoint old = this._serviceDeliveryPoint;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnServiceDeliveryPointChanging(e);
                    this.OnPropertyChanging("ServiceDeliveryPoint", e, _serviceDeliveryPointReference);
                    this._serviceDeliveryPoint = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetServiceDeliveryPoint;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetServiceDeliveryPoint;
                    }
                    this.OnServiceDeliveryPointChanged(e);
                    this.OnPropertyChanged("ServiceDeliveryPoint", e, _serviceDeliveryPointReference);
                }
            }
        }
        
        /// <summary>
        /// Gets the child model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> Children
        {
            get
            {
                return base.Children.Concat(new PrivateMeterVoltageChildrenCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://www.transformation-tool-contest.eu/2017/smartGrids/VoltagePhaseMeasurement" +
                            "s#//PrivateMeterVoltage")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the ID property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> IDChanging;
        
        /// <summary>
        /// Gets fired when the ID property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> IDChanged;
        
        /// <summary>
        /// Gets fired before the VoltageA property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> VoltageAChanging;
        
        /// <summary>
        /// Gets fired when the VoltageA property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> VoltageAChanged;
        
        /// <summary>
        /// Gets fired before the VoltageB property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> VoltageBChanging;
        
        /// <summary>
        /// Gets fired when the VoltageB property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> VoltageBChanged;
        
        /// <summary>
        /// Gets fired before the VoltageC property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> VoltageCChanging;
        
        /// <summary>
        /// Gets fired when the VoltageC property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> VoltageCChanged;
        
        /// <summary>
        /// Gets fired before the ServiceDeliveryPoint property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ServiceDeliveryPointChanging;
        
        /// <summary>
        /// Gets fired when the ServiceDeliveryPoint property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ServiceDeliveryPointChanged;
        
        private static ITypedElement RetrieveIDAttribute()
        {
            return ((ITypedElement)(((ModelElement)(TTC2017.SmartGrids.OutagePreventionJointarget.PrivateMeterVoltage.ClassInstance)).Resolve("ID")));
        }
        
        /// <summary>
        /// Raises the IDChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnIDChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.IDChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the IDChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnIDChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.IDChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveVoltageAAttribute()
        {
            return ((ITypedElement)(((ModelElement)(TTC2017.SmartGrids.OutagePreventionJointarget.PrivateMeterVoltage.ClassInstance)).Resolve("VoltageA")));
        }
        
        /// <summary>
        /// Raises the VoltageAChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnVoltageAChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.VoltageAChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the VoltageAChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnVoltageAChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.VoltageAChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveVoltageBAttribute()
        {
            return ((ITypedElement)(((ModelElement)(TTC2017.SmartGrids.OutagePreventionJointarget.PrivateMeterVoltage.ClassInstance)).Resolve("VoltageB")));
        }
        
        /// <summary>
        /// Raises the VoltageBChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnVoltageBChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.VoltageBChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the VoltageBChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnVoltageBChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.VoltageBChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveVoltageCAttribute()
        {
            return ((ITypedElement)(((ModelElement)(TTC2017.SmartGrids.OutagePreventionJointarget.PrivateMeterVoltage.ClassInstance)).Resolve("VoltageC")));
        }
        
        /// <summary>
        /// Raises the VoltageCChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnVoltageCChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.VoltageCChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the VoltageCChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnVoltageCChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.VoltageCChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveServiceDeliveryPointReference()
        {
            return ((ITypedElement)(((ModelElement)(TTC2017.SmartGrids.OutagePreventionJointarget.EndDeviceAsset.ClassInstance)).Resolve("ServiceDeliveryPoint")));
        }
        
        /// <summary>
        /// Raises the ServiceDeliveryPointChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnServiceDeliveryPointChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ServiceDeliveryPointChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the ServiceDeliveryPointChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnServiceDeliveryPointChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ServiceDeliveryPointChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the ServiceDeliveryPoint property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetServiceDeliveryPoint(object sender, System.EventArgs eventArgs)
        {
            this.ServiceDeliveryPoint = null;
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "ID"))
            {
                return this.ID;
            }
            if ((attribute == "VOLTAGEA"))
            {
                return this.VoltageA;
            }
            if ((attribute == "VOLTAGEB"))
            {
                return this.VoltageB;
            }
            if ((attribute == "VOLTAGEC"))
            {
                return this.VoltageC;
            }
            return base.GetAttributeValue(attribute, index);
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "SERVICEDELIVERYPOINT"))
            {
                this.ServiceDeliveryPoint = ((IServiceDeliveryPoint)(value));
                return;
            }
            if ((feature == "ID"))
            {
                this.ID = ((string)(value));
                return;
            }
            if ((feature == "VOLTAGEA"))
            {
                this.VoltageA = ((double)(value));
                return;
            }
            if ((feature == "VOLTAGEB"))
            {
                this.VoltageB = ((double)(value));
                return;
            }
            if ((feature == "VOLTAGEC"))
            {
                this.VoltageC = ((double)(value));
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
            if ((attribute == "ServiceDeliveryPoint"))
            {
                return new ServiceDeliveryPointProxy(this);
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
            if ((reference == "ServiceDeliveryPoint"))
            {
                return new ServiceDeliveryPointProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://www.transformation-tool-contest.eu/2017/smartGrids/VoltagePhaseMeasurement" +
                        "s#//PrivateMeterVoltage")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the PrivateMeterVoltage class
        /// </summary>
        public class PrivateMeterVoltageChildrenCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private PrivateMeterVoltage _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public PrivateMeterVoltageChildrenCollection(PrivateMeterVoltage parent)
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
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
            }
            
            protected override void DetachCore()
            {
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                return false;
            }
            
            /// <summary>
            /// Copies the contents of the collection to the given array starting from the given array index
            /// </summary>
            /// <param name="array">The array in which the elements should be copied</param>
            /// <param name="arrayIndex">The starting index</param>
            public override void CopyTo(IModelElement[] array, int arrayIndex)
            {
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                return false;
            }
            
            /// <summary>
            /// Gets an enumerator that enumerates the collection
            /// </summary>
            /// <returns>A generic enumerator</returns>
            public override IEnumerator<IModelElement> GetEnumerator()
            {
                return Enumerable.Empty<IModelElement>().GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the ID property
        /// </summary>
        private sealed class IDProxy : ModelPropertyChange<IPrivateMeterVoltage, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public IDProxy(IPrivateMeterVoltage modelElement) : 
                    base(modelElement, "ID")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override string Value
            {
                get
                {
                    return this.ModelElement.ID;
                }
                set
                {
                    this.ModelElement.ID = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the VoltageA property
        /// </summary>
        private sealed class VoltageAProxy : ModelPropertyChange<IPrivateMeterVoltage, Nullable<double>>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public VoltageAProxy(IPrivateMeterVoltage modelElement) : 
                    base(modelElement, "VoltageA")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override Nullable<double> Value
            {
                get
                {
                    return this.ModelElement.VoltageA;
                }
                set
                {
                    this.ModelElement.VoltageA = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the VoltageB property
        /// </summary>
        private sealed class VoltageBProxy : ModelPropertyChange<IPrivateMeterVoltage, Nullable<double>>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public VoltageBProxy(IPrivateMeterVoltage modelElement) : 
                    base(modelElement, "VoltageB")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override Nullable<double> Value
            {
                get
                {
                    return this.ModelElement.VoltageB;
                }
                set
                {
                    this.ModelElement.VoltageB = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the VoltageC property
        /// </summary>
        private sealed class VoltageCProxy : ModelPropertyChange<IPrivateMeterVoltage, Nullable<double>>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public VoltageCProxy(IPrivateMeterVoltage modelElement) : 
                    base(modelElement, "VoltageC")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override Nullable<double> Value
            {
                get
                {
                    return this.ModelElement.VoltageC;
                }
                set
                {
                    this.ModelElement.VoltageC = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the ServiceDeliveryPoint property
        /// </summary>
        private sealed class ServiceDeliveryPointProxy : ModelPropertyChange<IEndDeviceAsset, IServiceDeliveryPoint>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public ServiceDeliveryPointProxy(IEndDeviceAsset modelElement) : 
                    base(modelElement, "ServiceDeliveryPoint")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IServiceDeliveryPoint Value
            {
                get
                {
                    return this.ModelElement.ServiceDeliveryPoint;
                }
                set
                {
                    this.ModelElement.ServiceDeliveryPoint = value;
                }
            }
        }
    }
}

