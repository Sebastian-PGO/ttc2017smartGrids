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
    /// The default implementation of the AutoAnswerObject class
    /// </summary>
    [XmlNamespaceAttribute("objects")]
    [XmlNamespacePrefixAttribute("objects")]
    [ModelRepresentationClassAttribute("http://www.transformation-tool-contest.eu/2017/smartGrids/cosem#//COSEMObjects/Au" +
        "toAnswerObject")]
    public partial class AutoAnswerObject : Auto_answer, IAutoAnswerObject, IModelElement
    {
        
        /// <summary>
        /// The backing field for the Answer property
        /// </summary>
        private Nullable<bool> _answer;
        
        private static Lazy<ITypedElement> _answerAttribute = new Lazy<ITypedElement>(RetrieveAnswerAttribute);
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The Answer property
        /// </summary>
        [XmlAttributeAttribute(true)]
        public virtual Nullable<bool> Answer
        {
            get
            {
                return this._answer;
            }
            set
            {
                if ((this._answer != value))
                {
                    Nullable<bool> old = this._answer;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnAnswerChanging(e);
                    this.OnPropertyChanging("Answer", e, _answerAttribute);
                    this._answer = value;
                    this.OnAnswerChanged(e);
                    this.OnPropertyChanged("Answer", e, _answerAttribute);
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://www.transformation-tool-contest.eu/2017/smartGrids/cosem#//COSEMObjects/Au" +
                            "toAnswerObject")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the Answer property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> AnswerChanging;
        
        /// <summary>
        /// Gets fired when the Answer property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> AnswerChanged;
        
        private static ITypedElement RetrieveAnswerAttribute()
        {
            return ((ITypedElement)(((ModelElement)(AutoAnswerObject.ClassInstance)).Resolve("Answer")));
        }
        
        /// <summary>
        /// Raises the AnswerChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnAnswerChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.AnswerChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the AnswerChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnAnswerChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.AnswerChanged;
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
            if ((attribute == "ANSWER"))
            {
                return this.Answer;
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
            if ((feature == "ANSWER"))
            {
                this.Answer = ((bool)(value));
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://www.transformation-tool-contest.eu/2017/smartGrids/cosem#//COSEMObjects/Au" +
                        "toAnswerObject")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the Answer property
        /// </summary>
        private sealed class AnswerProxy : ModelPropertyChange<IAutoAnswerObject, Nullable<bool>>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public AnswerProxy(IAutoAnswerObject modelElement) : 
                    base(modelElement, "Answer")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override Nullable<bool> Value
            {
                get
                {
                    return this.ModelElement.Answer;
                }
                set
                {
                    this.ModelElement.Answer = value;
                }
            }
        }
    }
}

