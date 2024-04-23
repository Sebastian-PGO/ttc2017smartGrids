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
using TTC2017.SmartGrids.SubstationStandard.Dataclasses;
using TTC2017.SmartGrids.SubstationStandard.LNNodes.DomainLNs;

namespace TTC2017.SmartGrids.SubstationStandard
{
    
    
    /// <summary>
    /// The public interface for Substandard
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(Substandard))]
    [XmlDefaultImplementationTypeAttribute(typeof(Substandard))]
    public interface ISubstandard : IModelElement
    {
        
        /// <summary>
        /// The LN property
        /// </summary>
        IOrderedSetExpression<IDomainLN> LN
        {
            get;
        }
        
        /// <summary>
        /// The NamePlt property
        /// </summary>
        IOrderedSetExpression<ILPL> NamePlt
        {
            get;
        }
        
        /// <summary>
        /// The LPL property
        /// </summary>
        IOrderedSetExpression<ILPL> LPL
        {
            get;
        }
        
        /// <summary>
        /// The DPC property
        /// </summary>
        IOrderedSetExpression<IDPC> DPC
        {
            get;
        }
        
        /// <summary>
        /// The ACT property
        /// </summary>
        IOrderedSetExpression<IACT> ACT
        {
            get;
        }
        
        /// <summary>
        /// The SPS property
        /// </summary>
        IOrderedSetExpression<ISPS> SPS
        {
            get;
        }
        
        /// <summary>
        /// The BSC property
        /// </summary>
        IOrderedSetExpression<IBSC> BSC
        {
            get;
        }
        
        /// <summary>
        /// The ISC property
        /// </summary>
        IOrderedSetExpression<IISC> ISC
        {
            get;
        }
        
        /// <summary>
        /// The SPC property
        /// </summary>
        IOrderedSetExpression<ISPC> SPC
        {
            get;
        }
        
        /// <summary>
        /// The MV property
        /// </summary>
        IOrderedSetExpression<IMV> MV
        {
            get;
        }
        
        /// <summary>
        /// The INS property
        /// </summary>
        IOrderedSetExpression<IINS> INS
        {
            get;
        }
        
        /// <summary>
        /// The ASG property
        /// </summary>
        IOrderedSetExpression<IASG> ASG
        {
            get;
        }
        
        /// <summary>
        /// The WYE property
        /// </summary>
        IOrderedSetExpression<IWYE> WYE
        {
            get;
        }
        
        /// <summary>
        /// The DPStatus property
        /// </summary>
        IOrderedSetExpression<IDPStatus> DPStatus
        {
            get;
        }
        
        /// <summary>
        /// The AnalogueValue property
        /// </summary>
        IOrderedSetExpression<IAnalogueValue> AnalogueValue
        {
            get;
        }
        
        /// <summary>
        /// The CMV property
        /// </summary>
        IOrderedSetExpression<ICMV> CMV
        {
            get;
        }
        
        /// <summary>
        /// The ValWithTrans property
        /// </summary>
        IOrderedSetExpression<IValWithTrans> ValWithTrans
        {
            get;
        }
        
        /// <summary>
        /// The BSControl property
        /// </summary>
        IOrderedSetExpression<IBSControl> BSControl
        {
            get;
        }
        
        /// <summary>
        /// The Vector property
        /// </summary>
        IOrderedSetExpression<IVector> Vector
        {
            get;
        }
    }
}

