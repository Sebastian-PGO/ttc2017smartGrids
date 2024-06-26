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
using TTC2017.SmartGrids.COSEM.InterfaceClasses;

namespace TTC2017.SmartGrids.COSEM.COSEMObjects
{
    
    
    /// <summary>
    /// The default implementation of the ProgramEntries class
    /// </summary>
    [XmlNamespaceAttribute("objects")]
    [XmlNamespacePrefixAttribute("objects")]
    [ModelRepresentationClassAttribute("http://www.transformation-tool-contest.eu/2017/smartGrids/cosem#//COSEMObjects/Pr" +
        "ogramEntries")]
    public partial class ProgramEntries : Data, IProgramEntries, IModelElement
    {
        
        /// <summary>
        /// The backing field for the ActiveFirmwareIdentifier property
        /// </summary>
        private string _activeFirmwareIdentifier;
        
        private static Lazy<ITypedElement> _activeFirmwareIdentifierAttribute = new Lazy<ITypedElement>(RetrieveActiveFirmwareIdentifierAttribute);
        
        /// <summary>
        /// The backing field for the ActiveFirmwareVersion property
        /// </summary>
        private string _activeFirmwareVersion;
        
        private static Lazy<ITypedElement> _activeFirmwareVersionAttribute = new Lazy<ITypedElement>(RetrieveActiveFirmwareVersionAttribute);
        
        /// <summary>
        /// The backing field for the ActiveFirmwareSignature property
        /// </summary>
        private string _activeFirmwareSignature;
        
        private static Lazy<ITypedElement> _activeFirmwareSignatureAttribute = new Lazy<ITypedElement>(RetrieveActiveFirmwareSignatureAttribute);
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The ActiveFirmwareIdentifier property
        /// </summary>
        [XmlAttributeAttribute(true)]
        public virtual string ActiveFirmwareIdentifier
        {
            get
            {
                return this._activeFirmwareIdentifier;
            }
            set
            {
                if ((this._activeFirmwareIdentifier != value))
                {
                    string old = this._activeFirmwareIdentifier;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnActiveFirmwareIdentifierChanging(e);
                    this.OnPropertyChanging("ActiveFirmwareIdentifier", e, _activeFirmwareIdentifierAttribute);
                    this._activeFirmwareIdentifier = value;
                    this.OnActiveFirmwareIdentifierChanged(e);
                    this.OnPropertyChanged("ActiveFirmwareIdentifier", e, _activeFirmwareIdentifierAttribute);
                }
            }
        }
        
        /// <summary>
        /// The ActiveFirmwareVersion property
        /// </summary>
        [XmlAttributeAttribute(true)]
        public virtual string ActiveFirmwareVersion
        {
            get
            {
                return this._activeFirmwareVersion;
            }
            set
            {
                if ((this._activeFirmwareVersion != value))
                {
                    string old = this._activeFirmwareVersion;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnActiveFirmwareVersionChanging(e);
                    this.OnPropertyChanging("ActiveFirmwareVersion", e, _activeFirmwareVersionAttribute);
                    this._activeFirmwareVersion = value;
                    this.OnActiveFirmwareVersionChanged(e);
                    this.OnPropertyChanged("ActiveFirmwareVersion", e, _activeFirmwareVersionAttribute);
                }
            }
        }
        
        /// <summary>
        /// The ActiveFirmwareSignature property
        /// </summary>
        [XmlAttributeAttribute(true)]
        public virtual string ActiveFirmwareSignature
        {
            get
            {
                return this._activeFirmwareSignature;
            }
            set
            {
                if ((this._activeFirmwareSignature != value))
                {
                    string old = this._activeFirmwareSignature;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnActiveFirmwareSignatureChanging(e);
                    this.OnPropertyChanging("ActiveFirmwareSignature", e, _activeFirmwareSignatureAttribute);
                    this._activeFirmwareSignature = value;
                    this.OnActiveFirmwareSignatureChanged(e);
                    this.OnPropertyChanged("ActiveFirmwareSignature", e, _activeFirmwareSignatureAttribute);
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://www.transformation-tool-contest.eu/2017/smartGrids/cosem#//COSEMObjects/Pr" +
                            "ogramEntries")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the ActiveFirmwareIdentifier property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ActiveFirmwareIdentifierChanging;
        
        /// <summary>
        /// Gets fired when the ActiveFirmwareIdentifier property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ActiveFirmwareIdentifierChanged;
        
        /// <summary>
        /// Gets fired before the ActiveFirmwareVersion property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ActiveFirmwareVersionChanging;
        
        /// <summary>
        /// Gets fired when the ActiveFirmwareVersion property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ActiveFirmwareVersionChanged;
        
        /// <summary>
        /// Gets fired before the ActiveFirmwareSignature property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ActiveFirmwareSignatureChanging;
        
        /// <summary>
        /// Gets fired when the ActiveFirmwareSignature property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ActiveFirmwareSignatureChanged;
        
        private static ITypedElement RetrieveActiveFirmwareIdentifierAttribute()
        {
            return ((ITypedElement)(((ModelElement)(ProgramEntries.ClassInstance)).Resolve("ActiveFirmwareIdentifier")));
        }
        
        /// <summary>
        /// Raises the ActiveFirmwareIdentifierChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnActiveFirmwareIdentifierChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ActiveFirmwareIdentifierChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the ActiveFirmwareIdentifierChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnActiveFirmwareIdentifierChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ActiveFirmwareIdentifierChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveActiveFirmwareVersionAttribute()
        {
            return ((ITypedElement)(((ModelElement)(ProgramEntries.ClassInstance)).Resolve("ActiveFirmwareVersion")));
        }
        
        /// <summary>
        /// Raises the ActiveFirmwareVersionChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnActiveFirmwareVersionChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ActiveFirmwareVersionChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the ActiveFirmwareVersionChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnActiveFirmwareVersionChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ActiveFirmwareVersionChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveActiveFirmwareSignatureAttribute()
        {
            return ((ITypedElement)(((ModelElement)(ProgramEntries.ClassInstance)).Resolve("ActiveFirmwareSignature")));
        }
        
        /// <summary>
        /// Raises the ActiveFirmwareSignatureChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnActiveFirmwareSignatureChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ActiveFirmwareSignatureChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the ActiveFirmwareSignatureChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnActiveFirmwareSignatureChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ActiveFirmwareSignatureChanged;
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
            if ((attribute == "ACTIVEFIRMWAREIDENTIFIER"))
            {
                return this.ActiveFirmwareIdentifier;
            }
            if ((attribute == "ACTIVEFIRMWAREVERSION"))
            {
                return this.ActiveFirmwareVersion;
            }
            if ((attribute == "ACTIVEFIRMWARESIGNATURE"))
            {
                return this.ActiveFirmwareSignature;
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
            if ((feature == "ACTIVEFIRMWAREIDENTIFIER"))
            {
                this.ActiveFirmwareIdentifier = ((string)(value));
                return;
            }
            if ((feature == "ACTIVEFIRMWAREVERSION"))
            {
                this.ActiveFirmwareVersion = ((string)(value));
                return;
            }
            if ((feature == "ACTIVEFIRMWARESIGNATURE"))
            {
                this.ActiveFirmwareSignature = ((string)(value));
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://www.transformation-tool-contest.eu/2017/smartGrids/cosem#//COSEMObjects/Pr" +
                        "ogramEntries")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the ActiveFirmwareIdentifier property
        /// </summary>
        private sealed class ActiveFirmwareIdentifierProxy : ModelPropertyChange<IProgramEntries, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public ActiveFirmwareIdentifierProxy(IProgramEntries modelElement) : 
                    base(modelElement, "ActiveFirmwareIdentifier")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override string Value
            {
                get
                {
                    return this.ModelElement.ActiveFirmwareIdentifier;
                }
                set
                {
                    this.ModelElement.ActiveFirmwareIdentifier = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the ActiveFirmwareVersion property
        /// </summary>
        private sealed class ActiveFirmwareVersionProxy : ModelPropertyChange<IProgramEntries, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public ActiveFirmwareVersionProxy(IProgramEntries modelElement) : 
                    base(modelElement, "ActiveFirmwareVersion")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override string Value
            {
                get
                {
                    return this.ModelElement.ActiveFirmwareVersion;
                }
                set
                {
                    this.ModelElement.ActiveFirmwareVersion = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the ActiveFirmwareSignature property
        /// </summary>
        private sealed class ActiveFirmwareSignatureProxy : ModelPropertyChange<IProgramEntries, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public ActiveFirmwareSignatureProxy(IProgramEntries modelElement) : 
                    base(modelElement, "ActiveFirmwareSignature")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override string Value
            {
                get
                {
                    return this.ModelElement.ActiveFirmwareSignature;
                }
                set
                {
                    this.ModelElement.ActiveFirmwareSignature = value;
                }
            }
        }
    }
}

