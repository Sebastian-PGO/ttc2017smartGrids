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
using TTC2017.SmartGrids.CIM.IEC61970.Core;

namespace TTC2017.SmartGrids.CIM.IEC61970.OperationalLimits
{
    
    
    public class OperationalLimitTypeOperationalLimitCollection : ObservableOppositeOrderedSet<IOperationalLimitType, IOperationalLimit>
    {
        
        public OperationalLimitTypeOperationalLimitCollection(IOperationalLimitType parent) : 
                base(parent)
        {
        }
        
        private void OnItemDeleted(object sender, System.EventArgs e)
        {
            this.Remove(((IOperationalLimit)(sender)));
        }
        
        protected override void SetOpposite(IOperationalLimit item, IOperationalLimitType parent)
        {
            if ((parent != null))
            {
                item.Deleted += this.OnItemDeleted;
                item.OperationalLimitType = parent;
            }
            else
            {
                item.Deleted -= this.OnItemDeleted;
                if ((item.OperationalLimitType == this.Parent))
                {
                    item.OperationalLimitType = parent;
                }
            }
        }
    }
}

