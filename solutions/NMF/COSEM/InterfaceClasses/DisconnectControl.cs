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
using TTC2017.SmartGrids.COSEM;
using TTC2017.SmartGrids.COSEM.Datatypes;

namespace TTC2017.SmartGrids.COSEM.InterfaceClasses
{
    
    
    /// <summary>
    /// The default implementation of the DisconnectControl class
    /// </summary>
    [XmlNamespaceAttribute("interface")]
    [XmlNamespacePrefixAttribute("inter")]
    [ModelRepresentationClassAttribute("http://www.transformation-tool-contest.eu/2017/smartGrids/cosem#//InterfaceClasse" +
        "s/DisconnectControl")]
    public partial class DisconnectControl : Base, TTC2017.SmartGrids.COSEM.InterfaceClasses.IDisconnectControl, IModelElement
    {
        
        /// <summary>
        /// The backing field for the State property
        /// </summary>
        private Nullable<DisconnectControlState> _state;
        
        private static Lazy<ITypedElement> _stateAttribute = new Lazy<ITypedElement>(RetrieveStateAttribute);
        
        /// <summary>
        /// The backing field for the Transition property
        /// </summary>
        private Nullable<DisconnectControlTransition> _transition;
        
        private static Lazy<ITypedElement> _transitionAttribute = new Lazy<ITypedElement>(RetrieveTransitionAttribute);
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The state property
        /// </summary>
        [XmlElementNameAttribute("state")]
        [XmlAttributeAttribute(true)]
        public virtual Nullable<DisconnectControlState> State
        {
            get
            {
                return this._state;
            }
            set
            {
                if ((this._state != value))
                {
                    Nullable<DisconnectControlState> old = this._state;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnStateChanging(e);
                    this.OnPropertyChanging("State", e, _stateAttribute);
                    this._state = value;
                    this.OnStateChanged(e);
                    this.OnPropertyChanged("State", e, _stateAttribute);
                }
            }
        }
        
        /// <summary>
        /// The transition property
        /// </summary>
        [XmlElementNameAttribute("transition")]
        [XmlAttributeAttribute(true)]
        public virtual Nullable<DisconnectControlTransition> Transition
        {
            get
            {
                return this._transition;
            }
            set
            {
                if ((this._transition != value))
                {
                    Nullable<DisconnectControlTransition> old = this._transition;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnTransitionChanging(e);
                    this.OnPropertyChanging("Transition", e, _transitionAttribute);
                    this._transition = value;
                    this.OnTransitionChanged(e);
                    this.OnPropertyChanged("Transition", e, _transitionAttribute);
                }
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://www.transformation-tool-contest.eu/2017/smartGrids/cosem#//InterfaceClasse" +
                            "s/DisconnectControl")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the State property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> StateChanging;
        
        /// <summary>
        /// Gets fired when the State property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> StateChanged;
        
        /// <summary>
        /// Gets fired before the Transition property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> TransitionChanging;
        
        /// <summary>
        /// Gets fired when the Transition property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> TransitionChanged;
        
        private static ITypedElement RetrieveStateAttribute()
        {
            return ((ITypedElement)(((ModelElement)(DisconnectControl.ClassInstance)).Resolve("state")));
        }
        
        /// <summary>
        /// Raises the StateChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnStateChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.StateChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the StateChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnStateChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.StateChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveTransitionAttribute()
        {
            return ((ITypedElement)(((ModelElement)(DisconnectControl.ClassInstance)).Resolve("transition")));
        }
        
        /// <summary>
        /// Raises the TransitionChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnTransitionChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.TransitionChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the TransitionChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnTransitionChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.TransitionChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "STATE"))
            {
                return this.State;
            }
            if ((attribute == "TRANSITION"))
            {
                return this.Transition;
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
            if ((feature == "STATE"))
            {
                this.State = ((DisconnectControlState)(value));
                return;
            }
            if ((feature == "TRANSITION"))
            {
                this.Transition = ((DisconnectControlTransition)(value));
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://www.transformation-tool-contest.eu/2017/smartGrids/cosem#//InterfaceClasse" +
                        "s/DisconnectControl")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the state property
        /// </summary>
        private sealed class StateProxy : ModelPropertyChange<TTC2017.SmartGrids.COSEM.InterfaceClasses.IDisconnectControl, Nullable<DisconnectControlState>>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public StateProxy(TTC2017.SmartGrids.COSEM.InterfaceClasses.IDisconnectControl modelElement) : 
                    base(modelElement, "state")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override Nullable<DisconnectControlState> Value
            {
                get
                {
                    return this.ModelElement.State;
                }
                set
                {
                    this.ModelElement.State = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the transition property
        /// </summary>
        private sealed class TransitionProxy : ModelPropertyChange<TTC2017.SmartGrids.COSEM.InterfaceClasses.IDisconnectControl, Nullable<DisconnectControlTransition>>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public TransitionProxy(TTC2017.SmartGrids.COSEM.InterfaceClasses.IDisconnectControl modelElement) : 
                    base(modelElement, "transition")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override Nullable<DisconnectControlTransition> Value
            {
                get
                {
                    return this.ModelElement.Transition;
                }
                set
                {
                    this.ModelElement.Transition = value;
                }
            }
        }
    }
}

