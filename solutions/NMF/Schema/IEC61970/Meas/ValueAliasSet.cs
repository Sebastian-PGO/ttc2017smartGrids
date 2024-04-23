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
using TTC2017.SmartGrids.CIM.IEC61970.ControlArea;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.EnergyScheduling;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssets;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfERPSupport;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfGMLSupport;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.MarketOperations;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.Reservation;
using TTC2017.SmartGrids.CIM.IEC61970.SCADA;
using TTC2017.SmartGrids.CIM.IEC61970.Wires;

namespace TTC2017.SmartGrids.CIM.IEC61970.Meas
{
    
    
    /// <summary>
    /// The default implementation of the ValueAliasSet class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#Meas")]
    [XmlNamespacePrefixAttribute("cimMeas")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Meas/ValueAliasSet")]
    [DebuggerDisplayAttribute("ValueAliasSet {UUID}")]
    public partial class ValueAliasSet : IdentifiedObject, IValueAliasSet, IModelElement
    {
        
        private static Lazy<ITypedElement> _valuesReference = new Lazy<ITypedElement>(RetrieveValuesReference);
        
        /// <summary>
        /// The backing field for the Values property
        /// </summary>
        private ValueAliasSetValuesCollection _values;
        
        private static Lazy<ITypedElement> _commandsReference = new Lazy<ITypedElement>(RetrieveCommandsReference);
        
        /// <summary>
        /// The backing field for the Commands property
        /// </summary>
        private ValueAliasSetCommandsCollection _commands;
        
        private static Lazy<ITypedElement> _discretesReference = new Lazy<ITypedElement>(RetrieveDiscretesReference);
        
        /// <summary>
        /// The backing field for the Discretes property
        /// </summary>
        private ValueAliasSetDiscretesCollection _discretes;
        
        private static IClass _classInstance;
        
        public ValueAliasSet()
        {
            this._values = new ValueAliasSetValuesCollection(this);
            this._values.CollectionChanging += this.ValuesCollectionChanging;
            this._values.CollectionChanged += this.ValuesCollectionChanged;
            this._commands = new ValueAliasSetCommandsCollection(this);
            this._commands.CollectionChanging += this.CommandsCollectionChanging;
            this._commands.CollectionChanged += this.CommandsCollectionChanged;
            this._discretes = new ValueAliasSetDiscretesCollection(this);
            this._discretes.CollectionChanging += this.DiscretesCollectionChanging;
            this._discretes.CollectionChanged += this.DiscretesCollectionChanged;
        }
        
        /// <summary>
        /// The Values property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("ValueAliasSet")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<IValueToAlias> Values
        {
            get
            {
                return this._values;
            }
        }
        
        /// <summary>
        /// The Commands property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("ValueAliasSet")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<ICommand> Commands
        {
            get
            {
                return this._commands;
            }
        }
        
        /// <summary>
        /// The Discretes property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("ValueAliasSet")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<IDiscrete> Discretes
        {
            get
            {
                return this._discretes;
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new ValueAliasSetReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Meas/ValueAliasSet")));
                }
                return _classInstance;
            }
        }
        
        private static ITypedElement RetrieveValuesReference()
        {
            return ((ITypedElement)(((ModelElement)(ValueAliasSet.ClassInstance)).Resolve("Values")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the Values property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void ValuesCollectionChanging(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanging("Values", e, _valuesReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the Values property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void ValuesCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("Values", e, _valuesReference);
        }
        
        private static ITypedElement RetrieveCommandsReference()
        {
            return ((ITypedElement)(((ModelElement)(ValueAliasSet.ClassInstance)).Resolve("Commands")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the Commands property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void CommandsCollectionChanging(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanging("Commands", e, _commandsReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the Commands property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void CommandsCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("Commands", e, _commandsReference);
        }
        
        private static ITypedElement RetrieveDiscretesReference()
        {
            return ((ITypedElement)(((ModelElement)(ValueAliasSet.ClassInstance)).Resolve("Discretes")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the Discretes property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void DiscretesCollectionChanging(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanging("Discretes", e, _discretesReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the Discretes property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void DiscretesCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("Discretes", e, _discretesReference);
        }
        
        /// <summary>
        /// Gets the Model element collection for the given feature
        /// </summary>
        /// <returns>A non-generic list of elements</returns>
        /// <param name="feature">The requested feature</param>
        protected override System.Collections.IList GetCollectionForFeature(string feature)
        {
            if ((feature == "VALUES"))
            {
                return this._values;
            }
            if ((feature == "COMMANDS"))
            {
                return this._commands;
            }
            if ((feature == "DISCRETES"))
            {
                return this._discretes;
            }
            return base.GetCollectionForFeature(feature);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override IClass GetClass()
        {
            if ((_classInstance == null))
            {
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Meas/ValueAliasSet")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the ValueAliasSet class
        /// </summary>
        public class ValueAliasSetReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private ValueAliasSet _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public ValueAliasSetReferencedElementsCollection(ValueAliasSet parent)
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
                    count = (count + this._parent.Values.Count);
                    count = (count + this._parent.Commands.Count);
                    count = (count + this._parent.Discretes.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.Values.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.Commands.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.Discretes.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.Values.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.Commands.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.Discretes.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IValueToAlias valuesCasted = item.As<IValueToAlias>();
                if ((valuesCasted != null))
                {
                    this._parent.Values.Add(valuesCasted);
                }
                ICommand commandsCasted = item.As<ICommand>();
                if ((commandsCasted != null))
                {
                    this._parent.Commands.Add(commandsCasted);
                }
                IDiscrete discretesCasted = item.As<IDiscrete>();
                if ((discretesCasted != null))
                {
                    this._parent.Discretes.Add(discretesCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.Values.Clear();
                this._parent.Commands.Clear();
                this._parent.Discretes.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.Values.Contains(item))
                {
                    return true;
                }
                if (this._parent.Commands.Contains(item))
                {
                    return true;
                }
                if (this._parent.Discretes.Contains(item))
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
                IEnumerator<IModelElement> valuesEnumerator = this._parent.Values.GetEnumerator();
                try
                {
                    for (
                    ; valuesEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = valuesEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    valuesEnumerator.Dispose();
                }
                IEnumerator<IModelElement> commandsEnumerator = this._parent.Commands.GetEnumerator();
                try
                {
                    for (
                    ; commandsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = commandsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    commandsEnumerator.Dispose();
                }
                IEnumerator<IModelElement> discretesEnumerator = this._parent.Discretes.GetEnumerator();
                try
                {
                    for (
                    ; discretesEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = discretesEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    discretesEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IValueToAlias valueToAliasItem = item.As<IValueToAlias>();
                if (((valueToAliasItem != null) 
                            && this._parent.Values.Remove(valueToAliasItem)))
                {
                    return true;
                }
                ICommand commandItem = item.As<ICommand>();
                if (((commandItem != null) 
                            && this._parent.Commands.Remove(commandItem)))
                {
                    return true;
                }
                IDiscrete discreteItem = item.As<IDiscrete>();
                if (((discreteItem != null) 
                            && this._parent.Discretes.Remove(discreteItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.Values).Concat(this._parent.Commands).Concat(this._parent.Discretes).GetEnumerator();
            }
        }
    }
}

