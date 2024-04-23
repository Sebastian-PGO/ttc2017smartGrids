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
    /// The default implementation of the MountingPoint class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#InfAssets")]
    [XmlNamespacePrefixAttribute("cimInfAssets")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfAssets/Mountin" +
        "gPoint")]
    [DebuggerDisplayAttribute("MountingPoint {UUID}")]
    public partial class MountingPoint : IdentifiedObject, IMountingPoint, IModelElement
    {
        
        /// <summary>
        /// The backing field for the XCoord property
        /// </summary>
        private int _xCoord;
        
        private static Lazy<ITypedElement> _xCoordAttribute = new Lazy<ITypedElement>(RetrieveXCoordAttribute);
        
        /// <summary>
        /// The backing field for the PhaseCode property
        /// </summary>
        private Nullable<PhaseCode> _phaseCode;
        
        private static Lazy<ITypedElement> _phaseCodeAttribute = new Lazy<ITypedElement>(RetrievePhaseCodeAttribute);
        
        /// <summary>
        /// The backing field for the YCoord property
        /// </summary>
        private int _yCoord;
        
        private static Lazy<ITypedElement> _yCoordAttribute = new Lazy<ITypedElement>(RetrieveYCoordAttribute);
        
        private static Lazy<ITypedElement> _overheadConductorsReference = new Lazy<ITypedElement>(RetrieveOverheadConductorsReference);
        
        /// <summary>
        /// The backing field for the OverheadConductors property
        /// </summary>
        private MountingPointOverheadConductorsCollection _overheadConductors;
        
        private static Lazy<ITypedElement> _connectionsReference = new Lazy<ITypedElement>(RetrieveConnectionsReference);
        
        /// <summary>
        /// The backing field for the Connections property
        /// </summary>
        private MountingPointConnectionsCollection _connections;
        
        private static IClass _classInstance;
        
        public MountingPoint()
        {
            this._overheadConductors = new MountingPointOverheadConductorsCollection(this);
            this._overheadConductors.CollectionChanging += this.OverheadConductorsCollectionChanging;
            this._overheadConductors.CollectionChanged += this.OverheadConductorsCollectionChanged;
            this._connections = new MountingPointConnectionsCollection(this);
            this._connections.CollectionChanging += this.ConnectionsCollectionChanging;
            this._connections.CollectionChanged += this.ConnectionsCollectionChanged;
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
        /// The phaseCode property
        /// </summary>
        [XmlElementNameAttribute("phaseCode")]
        [XmlAttributeAttribute(true)]
        public virtual Nullable<PhaseCode> PhaseCode
        {
            get
            {
                return this._phaseCode;
            }
            set
            {
                if ((this._phaseCode != value))
                {
                    Nullable<PhaseCode> old = this._phaseCode;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnPhaseCodeChanging(e);
                    this.OnPropertyChanging("PhaseCode", e, _phaseCodeAttribute);
                    this._phaseCode = value;
                    this.OnPhaseCodeChanged(e);
                    this.OnPropertyChanged("PhaseCode", e, _phaseCodeAttribute);
                }
            }
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
        /// The OverheadConductors property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("MountingPoint")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<IOverheadConductorInfo> OverheadConductors
        {
            get
            {
                return this._overheadConductors;
            }
        }
        
        /// <summary>
        /// The Connections property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("MountingPoints")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<IMountingConnection> Connections
        {
            get
            {
                return this._connections;
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new MountingPointReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfAssets/Mountin" +
                            "gPoint")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the XCoord property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> XCoordChanging;
        
        /// <summary>
        /// Gets fired when the XCoord property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> XCoordChanged;
        
        /// <summary>
        /// Gets fired before the PhaseCode property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> PhaseCodeChanging;
        
        /// <summary>
        /// Gets fired when the PhaseCode property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> PhaseCodeChanged;
        
        /// <summary>
        /// Gets fired before the YCoord property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> YCoordChanging;
        
        /// <summary>
        /// Gets fired when the YCoord property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> YCoordChanged;
        
        private static ITypedElement RetrieveXCoordAttribute()
        {
            return ((ITypedElement)(((ModelElement)(MountingPoint.ClassInstance)).Resolve("xCoord")));
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
        
        private static ITypedElement RetrievePhaseCodeAttribute()
        {
            return ((ITypedElement)(((ModelElement)(MountingPoint.ClassInstance)).Resolve("phaseCode")));
        }
        
        /// <summary>
        /// Raises the PhaseCodeChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnPhaseCodeChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.PhaseCodeChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the PhaseCodeChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnPhaseCodeChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.PhaseCodeChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveYCoordAttribute()
        {
            return ((ITypedElement)(((ModelElement)(MountingPoint.ClassInstance)).Resolve("yCoord")));
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
        
        private static ITypedElement RetrieveOverheadConductorsReference()
        {
            return ((ITypedElement)(((ModelElement)(MountingPoint.ClassInstance)).Resolve("OverheadConductors")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the OverheadConductors property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void OverheadConductorsCollectionChanging(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanging("OverheadConductors", e, _overheadConductorsReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the OverheadConductors property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void OverheadConductorsCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("OverheadConductors", e, _overheadConductorsReference);
        }
        
        private static ITypedElement RetrieveConnectionsReference()
        {
            return ((ITypedElement)(((ModelElement)(MountingPoint.ClassInstance)).Resolve("Connections")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the Connections property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void ConnectionsCollectionChanging(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanging("Connections", e, _connectionsReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the Connections property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void ConnectionsCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("Connections", e, _connectionsReference);
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "XCOORD"))
            {
                return this.XCoord;
            }
            if ((attribute == "PHASECODE"))
            {
                return this.PhaseCode;
            }
            if ((attribute == "YCOORD"))
            {
                return this.YCoord;
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
            if ((feature == "OVERHEADCONDUCTORS"))
            {
                return this._overheadConductors;
            }
            if ((feature == "CONNECTIONS"))
            {
                return this._connections;
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
            if ((feature == "XCOORD"))
            {
                this.XCoord = ((int)(value));
                return;
            }
            if ((feature == "PHASECODE"))
            {
                this.PhaseCode = ((PhaseCode)(value));
                return;
            }
            if ((feature == "YCOORD"))
            {
                this.YCoord = ((int)(value));
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfAssets/Mountin" +
                        "gPoint")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the MountingPoint class
        /// </summary>
        public class MountingPointReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private MountingPoint _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public MountingPointReferencedElementsCollection(MountingPoint parent)
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
                    count = (count + this._parent.OverheadConductors.Count);
                    count = (count + this._parent.Connections.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.OverheadConductors.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.Connections.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.OverheadConductors.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.Connections.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IOverheadConductorInfo overheadConductorsCasted = item.As<IOverheadConductorInfo>();
                if ((overheadConductorsCasted != null))
                {
                    this._parent.OverheadConductors.Add(overheadConductorsCasted);
                }
                IMountingConnection connectionsCasted = item.As<IMountingConnection>();
                if ((connectionsCasted != null))
                {
                    this._parent.Connections.Add(connectionsCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.OverheadConductors.Clear();
                this._parent.Connections.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.OverheadConductors.Contains(item))
                {
                    return true;
                }
                if (this._parent.Connections.Contains(item))
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
                IEnumerator<IModelElement> overheadConductorsEnumerator = this._parent.OverheadConductors.GetEnumerator();
                try
                {
                    for (
                    ; overheadConductorsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = overheadConductorsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    overheadConductorsEnumerator.Dispose();
                }
                IEnumerator<IModelElement> connectionsEnumerator = this._parent.Connections.GetEnumerator();
                try
                {
                    for (
                    ; connectionsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = connectionsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    connectionsEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IOverheadConductorInfo overheadConductorInfoItem = item.As<IOverheadConductorInfo>();
                if (((overheadConductorInfoItem != null) 
                            && this._parent.OverheadConductors.Remove(overheadConductorInfoItem)))
                {
                    return true;
                }
                IMountingConnection mountingConnectionItem = item.As<IMountingConnection>();
                if (((mountingConnectionItem != null) 
                            && this._parent.Connections.Remove(mountingConnectionItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.OverheadConductors).Concat(this._parent.Connections).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the xCoord property
        /// </summary>
        private sealed class XCoordProxy : ModelPropertyChange<IMountingPoint, int>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public XCoordProxy(IMountingPoint modelElement) : 
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
        /// Represents a proxy to represent an incremental access to the phaseCode property
        /// </summary>
        private sealed class PhaseCodeProxy : ModelPropertyChange<IMountingPoint, Nullable<PhaseCode>>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public PhaseCodeProxy(IMountingPoint modelElement) : 
                    base(modelElement, "phaseCode")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override Nullable<PhaseCode> Value
            {
                get
                {
                    return this.ModelElement.PhaseCode;
                }
                set
                {
                    this.ModelElement.PhaseCode = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the yCoord property
        /// </summary>
        private sealed class YCoordProxy : ModelPropertyChange<IMountingPoint, int>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public YCoordProxy(IMountingPoint modelElement) : 
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
    }
}

