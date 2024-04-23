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
using TTC2017.SmartGrids.CIM.IEC61968.LoadControl;
using TTC2017.SmartGrids.CIM.IEC61968.Metering;
using TTC2017.SmartGrids.CIM.IEC61968.WiresExt;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Generation.GenerationDynamics;
using TTC2017.SmartGrids.CIM.IEC61970.Generation.Production;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.EnergyScheduling;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssets;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfLoadControl;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.MarketOperations;
using TTC2017.SmartGrids.CIM.IEC61970.LoadModel;
using TTC2017.SmartGrids.CIM.IEC61970.Meas;
using TTC2017.SmartGrids.CIM.IEC61970.Outage;
using TTC2017.SmartGrids.CIM.IEC61970.Protection;
using TTC2017.SmartGrids.CIM.IEC61970.StateVariables;

namespace TTC2017.SmartGrids.CIM.IEC61970.Wires
{
    
    
    /// <summary>
    /// The default implementation of the RegulationSchedule class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#Wires")]
    [XmlNamespacePrefixAttribute("cimWires")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Wires/RegulationSchedule")]
    [DebuggerDisplayAttribute("RegulationSchedule {UUID}")]
    public partial class RegulationSchedule : SeasonDayTypeSchedule, IRegulationSchedule, IModelElement
    {
        
        /// <summary>
        /// The backing field for the LineDropR property
        /// </summary>
        private float _lineDropR;
        
        private static Lazy<ITypedElement> _lineDropRAttribute = new Lazy<ITypedElement>(RetrieveLineDropRAttribute);
        
        /// <summary>
        /// The backing field for the LineDropX property
        /// </summary>
        private float _lineDropX;
        
        private static Lazy<ITypedElement> _lineDropXAttribute = new Lazy<ITypedElement>(RetrieveLineDropXAttribute);
        
        /// <summary>
        /// The backing field for the LineDropCompensation property
        /// </summary>
        private bool _lineDropCompensation;
        
        private static Lazy<ITypedElement> _lineDropCompensationAttribute = new Lazy<ITypedElement>(RetrieveLineDropCompensationAttribute);
        
        private static Lazy<ITypedElement> _regulatingControlReference = new Lazy<ITypedElement>(RetrieveRegulatingControlReference);
        
        /// <summary>
        /// The backing field for the RegulatingControl property
        /// </summary>
        private IRegulatingControl _regulatingControl;
        
        private static Lazy<ITypedElement> _voltageControlZonesReference = new Lazy<ITypedElement>(RetrieveVoltageControlZonesReference);
        
        /// <summary>
        /// The backing field for the VoltageControlZones property
        /// </summary>
        private RegulationScheduleVoltageControlZonesCollection _voltageControlZones;
        
        private static IClass _classInstance;
        
        public RegulationSchedule()
        {
            this._voltageControlZones = new RegulationScheduleVoltageControlZonesCollection(this);
            this._voltageControlZones.CollectionChanging += this.VoltageControlZonesCollectionChanging;
            this._voltageControlZones.CollectionChanged += this.VoltageControlZonesCollectionChanged;
        }
        
        /// <summary>
        /// The lineDropR property
        /// </summary>
        [XmlElementNameAttribute("lineDropR")]
        [XmlAttributeAttribute(true)]
        public virtual float LineDropR
        {
            get
            {
                return this._lineDropR;
            }
            set
            {
                if ((this._lineDropR != value))
                {
                    float old = this._lineDropR;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnLineDropRChanging(e);
                    this.OnPropertyChanging("LineDropR", e, _lineDropRAttribute);
                    this._lineDropR = value;
                    this.OnLineDropRChanged(e);
                    this.OnPropertyChanged("LineDropR", e, _lineDropRAttribute);
                }
            }
        }
        
        /// <summary>
        /// The lineDropX property
        /// </summary>
        [XmlElementNameAttribute("lineDropX")]
        [XmlAttributeAttribute(true)]
        public virtual float LineDropX
        {
            get
            {
                return this._lineDropX;
            }
            set
            {
                if ((this._lineDropX != value))
                {
                    float old = this._lineDropX;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnLineDropXChanging(e);
                    this.OnPropertyChanging("LineDropX", e, _lineDropXAttribute);
                    this._lineDropX = value;
                    this.OnLineDropXChanged(e);
                    this.OnPropertyChanged("LineDropX", e, _lineDropXAttribute);
                }
            }
        }
        
        /// <summary>
        /// The lineDropCompensation property
        /// </summary>
        [XmlElementNameAttribute("lineDropCompensation")]
        [XmlAttributeAttribute(true)]
        public virtual bool LineDropCompensation
        {
            get
            {
                return this._lineDropCompensation;
            }
            set
            {
                if ((this._lineDropCompensation != value))
                {
                    bool old = this._lineDropCompensation;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnLineDropCompensationChanging(e);
                    this.OnPropertyChanging("LineDropCompensation", e, _lineDropCompensationAttribute);
                    this._lineDropCompensation = value;
                    this.OnLineDropCompensationChanged(e);
                    this.OnPropertyChanged("LineDropCompensation", e, _lineDropCompensationAttribute);
                }
            }
        }
        
        /// <summary>
        /// The RegulatingControl property
        /// </summary>
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("RegulationSchedule")]
        public virtual IRegulatingControl RegulatingControl
        {
            get
            {
                return this._regulatingControl;
            }
            set
            {
                if ((this._regulatingControl != value))
                {
                    IRegulatingControl old = this._regulatingControl;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnRegulatingControlChanging(e);
                    this.OnPropertyChanging("RegulatingControl", e, _regulatingControlReference);
                    this._regulatingControl = value;
                    if ((old != null))
                    {
                        old.RegulationSchedule.Remove(this);
                        old.Deleted -= this.OnResetRegulatingControl;
                    }
                    if ((value != null))
                    {
                        value.RegulationSchedule.Add(this);
                        value.Deleted += this.OnResetRegulatingControl;
                    }
                    this.OnRegulatingControlChanged(e);
                    this.OnPropertyChanged("RegulatingControl", e, _regulatingControlReference);
                }
            }
        }
        
        /// <summary>
        /// The VoltageControlZones property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("RegulationSchedule")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<IVoltageControlZone> VoltageControlZones
        {
            get
            {
                return this._voltageControlZones;
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new RegulationScheduleReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Wires/RegulationSchedule")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the LineDropR property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> LineDropRChanging;
        
        /// <summary>
        /// Gets fired when the LineDropR property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> LineDropRChanged;
        
        /// <summary>
        /// Gets fired before the LineDropX property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> LineDropXChanging;
        
        /// <summary>
        /// Gets fired when the LineDropX property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> LineDropXChanged;
        
        /// <summary>
        /// Gets fired before the LineDropCompensation property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> LineDropCompensationChanging;
        
        /// <summary>
        /// Gets fired when the LineDropCompensation property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> LineDropCompensationChanged;
        
        /// <summary>
        /// Gets fired before the RegulatingControl property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> RegulatingControlChanging;
        
        /// <summary>
        /// Gets fired when the RegulatingControl property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> RegulatingControlChanged;
        
        private static ITypedElement RetrieveLineDropRAttribute()
        {
            return ((ITypedElement)(((ModelElement)(RegulationSchedule.ClassInstance)).Resolve("lineDropR")));
        }
        
        /// <summary>
        /// Raises the LineDropRChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnLineDropRChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.LineDropRChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the LineDropRChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnLineDropRChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.LineDropRChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveLineDropXAttribute()
        {
            return ((ITypedElement)(((ModelElement)(RegulationSchedule.ClassInstance)).Resolve("lineDropX")));
        }
        
        /// <summary>
        /// Raises the LineDropXChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnLineDropXChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.LineDropXChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the LineDropXChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnLineDropXChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.LineDropXChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveLineDropCompensationAttribute()
        {
            return ((ITypedElement)(((ModelElement)(RegulationSchedule.ClassInstance)).Resolve("lineDropCompensation")));
        }
        
        /// <summary>
        /// Raises the LineDropCompensationChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnLineDropCompensationChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.LineDropCompensationChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the LineDropCompensationChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnLineDropCompensationChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.LineDropCompensationChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveRegulatingControlReference()
        {
            return ((ITypedElement)(((ModelElement)(RegulationSchedule.ClassInstance)).Resolve("RegulatingControl")));
        }
        
        /// <summary>
        /// Raises the RegulatingControlChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnRegulatingControlChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.RegulatingControlChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the RegulatingControlChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnRegulatingControlChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.RegulatingControlChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the RegulatingControl property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetRegulatingControl(object sender, System.EventArgs eventArgs)
        {
            this.RegulatingControl = null;
        }
        
        private static ITypedElement RetrieveVoltageControlZonesReference()
        {
            return ((ITypedElement)(((ModelElement)(RegulationSchedule.ClassInstance)).Resolve("VoltageControlZones")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the VoltageControlZones property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void VoltageControlZonesCollectionChanging(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanging("VoltageControlZones", e, _voltageControlZonesReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the VoltageControlZones property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void VoltageControlZonesCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("VoltageControlZones", e, _voltageControlZonesReference);
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "LINEDROPR"))
            {
                return this.LineDropR;
            }
            if ((attribute == "LINEDROPX"))
            {
                return this.LineDropX;
            }
            if ((attribute == "LINEDROPCOMPENSATION"))
            {
                return this.LineDropCompensation;
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
            if ((feature == "VOLTAGECONTROLZONES"))
            {
                return this._voltageControlZones;
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
            if ((feature == "REGULATINGCONTROL"))
            {
                this.RegulatingControl = ((IRegulatingControl)(value));
                return;
            }
            if ((feature == "LINEDROPR"))
            {
                this.LineDropR = ((float)(value));
                return;
            }
            if ((feature == "LINEDROPX"))
            {
                this.LineDropX = ((float)(value));
                return;
            }
            if ((feature == "LINEDROPCOMPENSATION"))
            {
                this.LineDropCompensation = ((bool)(value));
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
            if ((attribute == "RegulatingControl"))
            {
                return new RegulatingControlProxy(this);
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
            if ((reference == "RegulatingControl"))
            {
                return new RegulatingControlProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Wires/RegulationSchedule")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the RegulationSchedule class
        /// </summary>
        public class RegulationScheduleReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private RegulationSchedule _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public RegulationScheduleReferencedElementsCollection(RegulationSchedule parent)
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
                    if ((this._parent.RegulatingControl != null))
                    {
                        count = (count + 1);
                    }
                    count = (count + this._parent.VoltageControlZones.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.RegulatingControlChanged += this.PropagateValueChanges;
                this._parent.VoltageControlZones.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.RegulatingControlChanged -= this.PropagateValueChanges;
                this._parent.VoltageControlZones.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.RegulatingControl == null))
                {
                    IRegulatingControl regulatingControlCasted = item.As<IRegulatingControl>();
                    if ((regulatingControlCasted != null))
                    {
                        this._parent.RegulatingControl = regulatingControlCasted;
                        return;
                    }
                }
                IVoltageControlZone voltageControlZonesCasted = item.As<IVoltageControlZone>();
                if ((voltageControlZonesCasted != null))
                {
                    this._parent.VoltageControlZones.Add(voltageControlZonesCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.RegulatingControl = null;
                this._parent.VoltageControlZones.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.RegulatingControl))
                {
                    return true;
                }
                if (this._parent.VoltageControlZones.Contains(item))
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
                if ((this._parent.RegulatingControl != null))
                {
                    array[arrayIndex] = this._parent.RegulatingControl;
                    arrayIndex = (arrayIndex + 1);
                }
                IEnumerator<IModelElement> voltageControlZonesEnumerator = this._parent.VoltageControlZones.GetEnumerator();
                try
                {
                    for (
                    ; voltageControlZonesEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = voltageControlZonesEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    voltageControlZonesEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                if ((this._parent.RegulatingControl == item))
                {
                    this._parent.RegulatingControl = null;
                    return true;
                }
                IVoltageControlZone voltageControlZoneItem = item.As<IVoltageControlZone>();
                if (((voltageControlZoneItem != null) 
                            && this._parent.VoltageControlZones.Remove(voltageControlZoneItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.RegulatingControl).Concat(this._parent.VoltageControlZones).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the lineDropR property
        /// </summary>
        private sealed class LineDropRProxy : ModelPropertyChange<IRegulationSchedule, float>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public LineDropRProxy(IRegulationSchedule modelElement) : 
                    base(modelElement, "lineDropR")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override float Value
            {
                get
                {
                    return this.ModelElement.LineDropR;
                }
                set
                {
                    this.ModelElement.LineDropR = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the lineDropX property
        /// </summary>
        private sealed class LineDropXProxy : ModelPropertyChange<IRegulationSchedule, float>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public LineDropXProxy(IRegulationSchedule modelElement) : 
                    base(modelElement, "lineDropX")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override float Value
            {
                get
                {
                    return this.ModelElement.LineDropX;
                }
                set
                {
                    this.ModelElement.LineDropX = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the lineDropCompensation property
        /// </summary>
        private sealed class LineDropCompensationProxy : ModelPropertyChange<IRegulationSchedule, bool>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public LineDropCompensationProxy(IRegulationSchedule modelElement) : 
                    base(modelElement, "lineDropCompensation")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override bool Value
            {
                get
                {
                    return this.ModelElement.LineDropCompensation;
                }
                set
                {
                    this.ModelElement.LineDropCompensation = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the RegulatingControl property
        /// </summary>
        private sealed class RegulatingControlProxy : ModelPropertyChange<IRegulationSchedule, IRegulatingControl>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public RegulatingControlProxy(IRegulationSchedule modelElement) : 
                    base(modelElement, "RegulatingControl")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IRegulatingControl Value
            {
                get
                {
                    return this.ModelElement.RegulatingControl;
                }
                set
                {
                    this.ModelElement.RegulatingControl = value;
                }
            }
        }
    }
}

