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
using TTC2017.SmartGrids.CIM.IEC61968.Common;
using TTC2017.SmartGrids.CIM.IEC61968.Customers;
using TTC2017.SmartGrids.CIM.IEC61968.Metering;
using TTC2017.SmartGrids.CIM.IEC61968.PaymentMetering;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfCommon;

namespace TTC2017.SmartGrids.CIM.IEC61970.Informative.InfPaymentMetering
{
    
    
    /// <summary>
    /// The default implementation of the ReceiptSummary class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#InfPaymentMetering")]
    [XmlNamespacePrefixAttribute("cimInfPaymentMetering")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfPaymentMeterin" +
        "g/ReceiptSummary")]
    [DebuggerDisplayAttribute("ReceiptSummary {UUID}")]
    public partial class ReceiptSummary : Element, IReceiptSummary, IModelElement
    {
        
        /// <summary>
        /// The backing field for the TenderKind property
        /// </summary>
        private Nullable<TenderKind> _tenderKind;
        
        private static Lazy<ITypedElement> _tenderKindAttribute = new Lazy<ITypedElement>(RetrieveTenderKindAttribute);
        
        private static Lazy<ITypedElement> _lineReference = new Lazy<ITypedElement>(RetrieveLineReference);
        
        /// <summary>
        /// The backing field for the Line property
        /// </summary>
        private ILineDetail _line;
        
        private static Lazy<ITypedElement> _shiftReference = new Lazy<ITypedElement>(RetrieveShiftReference);
        
        /// <summary>
        /// The backing field for the Shift property
        /// </summary>
        private IShift _shift;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The tenderKind property
        /// </summary>
        [XmlElementNameAttribute("tenderKind")]
        [XmlAttributeAttribute(true)]
        public virtual Nullable<TenderKind> TenderKind
        {
            get
            {
                return this._tenderKind;
            }
            set
            {
                if ((this._tenderKind != value))
                {
                    Nullable<TenderKind> old = this._tenderKind;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnTenderKindChanging(e);
                    this.OnPropertyChanging("TenderKind", e, _tenderKindAttribute);
                    this._tenderKind = value;
                    this.OnTenderKindChanged(e);
                    this.OnPropertyChanged("TenderKind", e, _tenderKindAttribute);
                }
            }
        }
        
        /// <summary>
        /// The line property
        /// </summary>
        [XmlElementNameAttribute("line")]
        [XmlAttributeAttribute(true)]
        public virtual ILineDetail Line
        {
            get
            {
                return this._line;
            }
            set
            {
                if ((this._line != value))
                {
                    ILineDetail old = this._line;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnLineChanging(e);
                    this.OnPropertyChanging("Line", e, _lineReference);
                    this._line = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetLine;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetLine;
                    }
                    this.OnLineChanged(e);
                    this.OnPropertyChanged("Line", e, _lineReference);
                }
            }
        }
        
        /// <summary>
        /// The Shift property
        /// </summary>
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("ReceiptSummaries")]
        public virtual IShift Shift
        {
            get
            {
                return this._shift;
            }
            set
            {
                if ((this._shift != value))
                {
                    IShift old = this._shift;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnShiftChanging(e);
                    this.OnPropertyChanging("Shift", e, _shiftReference);
                    this._shift = value;
                    if ((old != null))
                    {
                        old.ReceiptSummaries.Remove(this);
                        old.Deleted -= this.OnResetShift;
                    }
                    if ((value != null))
                    {
                        value.ReceiptSummaries.Add(this);
                        value.Deleted += this.OnResetShift;
                    }
                    this.OnShiftChanged(e);
                    this.OnPropertyChanged("Shift", e, _shiftReference);
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
                return base.ReferencedElements.Concat(new ReceiptSummaryReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfPaymentMeterin" +
                            "g/ReceiptSummary")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the TenderKind property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> TenderKindChanging;
        
        /// <summary>
        /// Gets fired when the TenderKind property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> TenderKindChanged;
        
        /// <summary>
        /// Gets fired before the Line property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> LineChanging;
        
        /// <summary>
        /// Gets fired when the Line property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> LineChanged;
        
        /// <summary>
        /// Gets fired before the Shift property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ShiftChanging;
        
        /// <summary>
        /// Gets fired when the Shift property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ShiftChanged;
        
        private static ITypedElement RetrieveTenderKindAttribute()
        {
            return ((ITypedElement)(((ModelElement)(ReceiptSummary.ClassInstance)).Resolve("tenderKind")));
        }
        
        /// <summary>
        /// Raises the TenderKindChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnTenderKindChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.TenderKindChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the TenderKindChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnTenderKindChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.TenderKindChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveLineReference()
        {
            return ((ITypedElement)(((ModelElement)(ReceiptSummary.ClassInstance)).Resolve("line")));
        }
        
        /// <summary>
        /// Raises the LineChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnLineChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.LineChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the LineChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnLineChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.LineChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the Line property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetLine(object sender, System.EventArgs eventArgs)
        {
            this.Line = null;
        }
        
        private static ITypedElement RetrieveShiftReference()
        {
            return ((ITypedElement)(((ModelElement)(ReceiptSummary.ClassInstance)).Resolve("Shift")));
        }
        
        /// <summary>
        /// Raises the ShiftChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnShiftChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ShiftChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the ShiftChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnShiftChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ShiftChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the Shift property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetShift(object sender, System.EventArgs eventArgs)
        {
            this.Shift = null;
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "TENDERKIND"))
            {
                return this.TenderKind;
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
            if ((feature == "LINE"))
            {
                this.Line = ((ILineDetail)(value));
                return;
            }
            if ((feature == "SHIFT"))
            {
                this.Shift = ((IShift)(value));
                return;
            }
            if ((feature == "TENDERKIND"))
            {
                this.TenderKind = ((TenderKind)(value));
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
            if ((attribute == "Line"))
            {
                return new LineProxy(this);
            }
            if ((attribute == "Shift"))
            {
                return new ShiftProxy(this);
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
            if ((reference == "Line"))
            {
                return new LineProxy(this);
            }
            if ((reference == "Shift"))
            {
                return new ShiftProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfPaymentMeterin" +
                        "g/ReceiptSummary")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the ReceiptSummary class
        /// </summary>
        public class ReceiptSummaryReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private ReceiptSummary _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public ReceiptSummaryReferencedElementsCollection(ReceiptSummary parent)
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
                    if ((this._parent.Line != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.Shift != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.LineChanged += this.PropagateValueChanges;
                this._parent.ShiftChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.LineChanged -= this.PropagateValueChanges;
                this._parent.ShiftChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.Line == null))
                {
                    ILineDetail lineCasted = item.As<ILineDetail>();
                    if ((lineCasted != null))
                    {
                        this._parent.Line = lineCasted;
                        return;
                    }
                }
                if ((this._parent.Shift == null))
                {
                    IShift shiftCasted = item.As<IShift>();
                    if ((shiftCasted != null))
                    {
                        this._parent.Shift = shiftCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.Line = null;
                this._parent.Shift = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.Line))
                {
                    return true;
                }
                if ((item == this._parent.Shift))
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
                if ((this._parent.Line != null))
                {
                    array[arrayIndex] = this._parent.Line;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.Shift != null))
                {
                    array[arrayIndex] = this._parent.Shift;
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
                if ((this._parent.Line == item))
                {
                    this._parent.Line = null;
                    return true;
                }
                if ((this._parent.Shift == item))
                {
                    this._parent.Shift = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.Line).Concat(this._parent.Shift).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the tenderKind property
        /// </summary>
        private sealed class TenderKindProxy : ModelPropertyChange<IReceiptSummary, Nullable<TenderKind>>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public TenderKindProxy(IReceiptSummary modelElement) : 
                    base(modelElement, "tenderKind")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override Nullable<TenderKind> Value
            {
                get
                {
                    return this.ModelElement.TenderKind;
                }
                set
                {
                    this.ModelElement.TenderKind = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the line property
        /// </summary>
        private sealed class LineProxy : ModelPropertyChange<IReceiptSummary, ILineDetail>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public LineProxy(IReceiptSummary modelElement) : 
                    base(modelElement, "line")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override ILineDetail Value
            {
                get
                {
                    return this.ModelElement.Line;
                }
                set
                {
                    this.ModelElement.Line = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the Shift property
        /// </summary>
        private sealed class ShiftProxy : ModelPropertyChange<IReceiptSummary, IShift>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public ShiftProxy(IReceiptSummary modelElement) : 
                    base(modelElement, "Shift")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IShift Value
            {
                get
                {
                    return this.ModelElement.Shift;
                }
                set
                {
                    this.ModelElement.Shift = value;
                }
            }
        }
    }
}

