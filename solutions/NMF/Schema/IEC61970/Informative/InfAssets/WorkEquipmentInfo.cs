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
    /// The default implementation of the WorkEquipmentInfo class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#InfAssets")]
    [XmlNamespacePrefixAttribute("cimInfAssets")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfAssets/WorkEqu" +
        "ipmentInfo")]
    [DebuggerDisplayAttribute("WorkEquipmentInfo {UUID}")]
    public partial class WorkEquipmentInfo : AssetInfo, IWorkEquipmentInfo, IModelElement
    {
        
        private static Lazy<ITypedElement> _crewReference = new Lazy<ITypedElement>(RetrieveCrewReference);
        
        /// <summary>
        /// The backing field for the Crew property
        /// </summary>
        private ICrew _crew;
        
        private static Lazy<ITypedElement> _usagesReference = new Lazy<ITypedElement>(RetrieveUsagesReference);
        
        /// <summary>
        /// The backing field for the Usages property
        /// </summary>
        private WorkEquipmentInfoUsagesCollection _usages;
        
        private static IClass _classInstance;
        
        public WorkEquipmentInfo()
        {
            this._usages = new WorkEquipmentInfoUsagesCollection(this);
            this._usages.CollectionChanging += this.UsagesCollectionChanging;
            this._usages.CollectionChanged += this.UsagesCollectionChanged;
        }
        
        /// <summary>
        /// The Crew property
        /// </summary>
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("WorkEquipmentAssets")]
        public virtual ICrew Crew
        {
            get
            {
                return this._crew;
            }
            set
            {
                if ((this._crew != value))
                {
                    ICrew old = this._crew;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnCrewChanging(e);
                    this.OnPropertyChanging("Crew", e, _crewReference);
                    this._crew = value;
                    if ((old != null))
                    {
                        old.WorkEquipmentAssets.Remove(this);
                        old.Deleted -= this.OnResetCrew;
                    }
                    if ((value != null))
                    {
                        value.WorkEquipmentAssets.Add(this);
                        value.Deleted += this.OnResetCrew;
                    }
                    this.OnCrewChanged(e);
                    this.OnPropertyChanged("Crew", e, _crewReference);
                }
            }
        }
        
        /// <summary>
        /// The Usages property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("WorkEquipmentAsset")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<IUsage> Usages
        {
            get
            {
                return this._usages;
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new WorkEquipmentInfoReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfAssets/WorkEqu" +
                            "ipmentInfo")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the Crew property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> CrewChanging;
        
        /// <summary>
        /// Gets fired when the Crew property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> CrewChanged;
        
        private static ITypedElement RetrieveCrewReference()
        {
            return ((ITypedElement)(((ModelElement)(WorkEquipmentInfo.ClassInstance)).Resolve("Crew")));
        }
        
        /// <summary>
        /// Raises the CrewChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnCrewChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.CrewChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the CrewChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnCrewChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.CrewChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the Crew property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetCrew(object sender, System.EventArgs eventArgs)
        {
            this.Crew = null;
        }
        
        private static ITypedElement RetrieveUsagesReference()
        {
            return ((ITypedElement)(((ModelElement)(WorkEquipmentInfo.ClassInstance)).Resolve("Usages")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the Usages property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void UsagesCollectionChanging(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanging("Usages", e, _usagesReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the Usages property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void UsagesCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("Usages", e, _usagesReference);
        }
        
        /// <summary>
        /// Gets the Model element collection for the given feature
        /// </summary>
        /// <returns>A non-generic list of elements</returns>
        /// <param name="feature">The requested feature</param>
        protected override System.Collections.IList GetCollectionForFeature(string feature)
        {
            if ((feature == "USAGES"))
            {
                return this._usages;
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
            if ((feature == "CREW"))
            {
                this.Crew = ((ICrew)(value));
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
            if ((attribute == "Crew"))
            {
                return new CrewProxy(this);
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
            if ((reference == "Crew"))
            {
                return new CrewProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfAssets/WorkEqu" +
                        "ipmentInfo")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the WorkEquipmentInfo class
        /// </summary>
        public class WorkEquipmentInfoReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private WorkEquipmentInfo _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public WorkEquipmentInfoReferencedElementsCollection(WorkEquipmentInfo parent)
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
                    if ((this._parent.Crew != null))
                    {
                        count = (count + 1);
                    }
                    count = (count + this._parent.Usages.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.CrewChanged += this.PropagateValueChanges;
                this._parent.Usages.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.CrewChanged -= this.PropagateValueChanges;
                this._parent.Usages.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.Crew == null))
                {
                    ICrew crewCasted = item.As<ICrew>();
                    if ((crewCasted != null))
                    {
                        this._parent.Crew = crewCasted;
                        return;
                    }
                }
                IUsage usagesCasted = item.As<IUsage>();
                if ((usagesCasted != null))
                {
                    this._parent.Usages.Add(usagesCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.Crew = null;
                this._parent.Usages.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.Crew))
                {
                    return true;
                }
                if (this._parent.Usages.Contains(item))
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
                if ((this._parent.Crew != null))
                {
                    array[arrayIndex] = this._parent.Crew;
                    arrayIndex = (arrayIndex + 1);
                }
                IEnumerator<IModelElement> usagesEnumerator = this._parent.Usages.GetEnumerator();
                try
                {
                    for (
                    ; usagesEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = usagesEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    usagesEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                if ((this._parent.Crew == item))
                {
                    this._parent.Crew = null;
                    return true;
                }
                IUsage usageItem = item.As<IUsage>();
                if (((usageItem != null) 
                            && this._parent.Usages.Remove(usageItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.Crew).Concat(this._parent.Usages).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the Crew property
        /// </summary>
        private sealed class CrewProxy : ModelPropertyChange<IWorkEquipmentInfo, ICrew>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public CrewProxy(IWorkEquipmentInfo modelElement) : 
                    base(modelElement, "Crew")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override ICrew Value
            {
                get
                {
                    return this.ModelElement.Crew;
                }
                set
                {
                    this.ModelElement.Crew = value;
                }
            }
        }
    }
}

