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
using TTC2017.SmartGrids.CIM.IEC61968.Assets;
using TTC2017.SmartGrids.CIM.IEC61968.Common;
using TTC2017.SmartGrids.CIM.IEC61968.Work;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfAssets;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfCommon;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfERPSupport;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfGMLSupport;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfLocations;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfOperations;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfTypeAsset;

namespace TTC2017.SmartGrids.CIM.IEC61970.Informative.InfWork
{
    
    
    /// <summary>
    /// The default implementation of the BusinessCase class
    /// </summary>
    [XmlNamespaceAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#InfWork")]
    [XmlNamespacePrefixAttribute("cimInfWork")]
    [ModelRepresentationClassAttribute("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfWork/BusinessC" +
        "ase")]
    [DebuggerDisplayAttribute("BusinessCase {UUID}")]
    public partial class BusinessCase : Document, IBusinessCase, IModelElement
    {
        
        /// <summary>
        /// The backing field for the CorporateCode property
        /// </summary>
        private string _corporateCode;
        
        private static Lazy<ITypedElement> _corporateCodeAttribute = new Lazy<ITypedElement>(RetrieveCorporateCodeAttribute);
        
        private static Lazy<ITypedElement> _worksReference = new Lazy<ITypedElement>(RetrieveWorksReference);
        
        /// <summary>
        /// The backing field for the Works property
        /// </summary>
        private BusinessCaseWorksCollection _works;
        
        private static Lazy<ITypedElement> _projectsReference = new Lazy<ITypedElement>(RetrieveProjectsReference);
        
        /// <summary>
        /// The backing field for the Projects property
        /// </summary>
        private BusinessCaseProjectsCollection _projects;
        
        private static IClass _classInstance;
        
        public BusinessCase()
        {
            this._works = new BusinessCaseWorksCollection(this);
            this._works.CollectionChanging += this.WorksCollectionChanging;
            this._works.CollectionChanged += this.WorksCollectionChanged;
            this._projects = new BusinessCaseProjectsCollection(this);
            this._projects.CollectionChanging += this.ProjectsCollectionChanging;
            this._projects.CollectionChanged += this.ProjectsCollectionChanged;
        }
        
        /// <summary>
        /// The corporateCode property
        /// </summary>
        [XmlElementNameAttribute("corporateCode")]
        [XmlAttributeAttribute(true)]
        public virtual string CorporateCode
        {
            get
            {
                return this._corporateCode;
            }
            set
            {
                if ((this._corporateCode != value))
                {
                    string old = this._corporateCode;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnCorporateCodeChanging(e);
                    this.OnPropertyChanging("CorporateCode", e, _corporateCodeAttribute);
                    this._corporateCode = value;
                    this.OnCorporateCodeChanged(e);
                    this.OnPropertyChanged("CorporateCode", e, _corporateCodeAttribute);
                }
            }
        }
        
        /// <summary>
        /// The Works property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("BusinessCase")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<IWork> Works
        {
            get
            {
                return this._works;
            }
        }
        
        /// <summary>
        /// The Projects property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("BusinessCase")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<IProject> Projects
        {
            get
            {
                return this._projects;
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new BusinessCaseReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfWork/BusinessC" +
                            "ase")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the CorporateCode property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> CorporateCodeChanging;
        
        /// <summary>
        /// Gets fired when the CorporateCode property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> CorporateCodeChanged;
        
        private static ITypedElement RetrieveCorporateCodeAttribute()
        {
            return ((ITypedElement)(((ModelElement)(BusinessCase.ClassInstance)).Resolve("corporateCode")));
        }
        
        /// <summary>
        /// Raises the CorporateCodeChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnCorporateCodeChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.CorporateCodeChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the CorporateCodeChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnCorporateCodeChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.CorporateCodeChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveWorksReference()
        {
            return ((ITypedElement)(((ModelElement)(BusinessCase.ClassInstance)).Resolve("Works")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the Works property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void WorksCollectionChanging(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanging("Works", e, _worksReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the Works property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void WorksCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("Works", e, _worksReference);
        }
        
        private static ITypedElement RetrieveProjectsReference()
        {
            return ((ITypedElement)(((ModelElement)(BusinessCase.ClassInstance)).Resolve("Projects")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the Projects property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void ProjectsCollectionChanging(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanging("Projects", e, _projectsReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the Projects property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void ProjectsCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("Projects", e, _projectsReference);
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "CORPORATECODE"))
            {
                return this.CorporateCode;
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
            if ((feature == "WORKS"))
            {
                return this._works;
            }
            if ((feature == "PROJECTS"))
            {
                return this._projects;
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
            if ((feature == "CORPORATECODE"))
            {
                this.CorporateCode = ((string)(value));
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://iec.ch/TC57/2009/CIM-schema-cim14#//IEC61970/Informative/InfWork/BusinessC" +
                        "ase")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the BusinessCase class
        /// </summary>
        public class BusinessCaseReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private BusinessCase _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public BusinessCaseReferencedElementsCollection(BusinessCase parent)
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
                    count = (count + this._parent.Works.Count);
                    count = (count + this._parent.Projects.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.Works.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.Projects.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.Works.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.Projects.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IWork worksCasted = item.As<IWork>();
                if ((worksCasted != null))
                {
                    this._parent.Works.Add(worksCasted);
                }
                IProject projectsCasted = item.As<IProject>();
                if ((projectsCasted != null))
                {
                    this._parent.Projects.Add(projectsCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.Works.Clear();
                this._parent.Projects.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.Works.Contains(item))
                {
                    return true;
                }
                if (this._parent.Projects.Contains(item))
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
                IEnumerator<IModelElement> worksEnumerator = this._parent.Works.GetEnumerator();
                try
                {
                    for (
                    ; worksEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = worksEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    worksEnumerator.Dispose();
                }
                IEnumerator<IModelElement> projectsEnumerator = this._parent.Projects.GetEnumerator();
                try
                {
                    for (
                    ; projectsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = projectsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    projectsEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IWork workItem = item.As<IWork>();
                if (((workItem != null) 
                            && this._parent.Works.Remove(workItem)))
                {
                    return true;
                }
                IProject projectItem = item.As<IProject>();
                if (((projectItem != null) 
                            && this._parent.Projects.Remove(projectItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.Works).Concat(this._parent.Projects).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the corporateCode property
        /// </summary>
        private sealed class CorporateCodeProxy : ModelPropertyChange<IBusinessCase, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public CorporateCodeProxy(IBusinessCase modelElement) : 
                    base(modelElement, "corporateCode")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override string Value
            {
                get
                {
                    return this.ModelElement.CorporateCode;
                }
                set
                {
                    this.ModelElement.CorporateCode = value;
                }
            }
        }
    }
}

