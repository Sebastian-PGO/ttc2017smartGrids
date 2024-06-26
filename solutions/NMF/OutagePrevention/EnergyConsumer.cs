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
    /// The default implementation of the EnergyConsumer class
    /// </summary>
    [XmlNamespaceAttribute("http://www.transformation-tool-contest.eu/2017/smartGrids/VoltagePhaseMeasurement" +
        "s")]
    [XmlNamespacePrefixAttribute("outagePreventionJt")]
    [ModelRepresentationClassAttribute("http://www.transformation-tool-contest.eu/2017/smartGrids/VoltagePhaseMeasurement" +
        "s#//EnergyConsumer")]
    public partial class EnergyConsumer : ModelElement, IEnergyConsumer, IModelElement
    {
        
        /// <summary>
        /// The backing field for the MRID property
        /// </summary>
        private string _mRID;
        
        private static Lazy<ITypedElement> _mRIDAttribute = new Lazy<ITypedElement>(RetrieveMRIDAttribute);
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The mRID property
        /// </summary>
        [XmlElementNameAttribute("mRID")]
        [XmlAttributeAttribute(true)]
        public string MRID
        {
            get
            {
                return this._mRID;
            }
            set
            {
                if ((this._mRID != value))
                {
                    string old = this._mRID;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnMRIDChanging(e);
                    this.OnPropertyChanging("MRID", e, _mRIDAttribute);
                    this._mRID = value;
                    this.OnMRIDChanged(e);
                    this.OnPropertyChanged("MRID", e, _mRIDAttribute);
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://www.transformation-tool-contest.eu/2017/smartGrids/VoltagePhaseMeasurement" +
                            "s#//EnergyConsumer")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the MRID property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> MRIDChanging;
        
        /// <summary>
        /// Gets fired when the MRID property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> MRIDChanged;
        
        private static ITypedElement RetrieveMRIDAttribute()
        {
            return ((ITypedElement)(((ModelElement)(TTC2017.SmartGrids.OutagePreventionJointarget.EnergyConsumer.ClassInstance)).Resolve("mRID")));
        }
        
        /// <summary>
        /// Raises the MRIDChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnMRIDChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.MRIDChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the MRIDChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnMRIDChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.MRIDChanged;
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
            if ((attribute == "MRID"))
            {
                return this.MRID;
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
            if ((feature == "MRID"))
            {
                this.MRID = ((string)(value));
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://www.transformation-tool-contest.eu/2017/smartGrids/VoltagePhaseMeasurement" +
                        "s#//EnergyConsumer")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the mRID property
        /// </summary>
        private sealed class MRIDProxy : ModelPropertyChange<IEnergyConsumer, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public MRIDProxy(IEnergyConsumer modelElement) : 
                    base(modelElement, "mRID")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override string Value
            {
                get
                {
                    return this.ModelElement.MRID;
                }
                set
                {
                    this.ModelElement.MRID = value;
                }
            }
        }
    }
}

