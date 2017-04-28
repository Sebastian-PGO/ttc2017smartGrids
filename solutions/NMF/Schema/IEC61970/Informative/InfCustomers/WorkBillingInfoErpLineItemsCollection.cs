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
using TTC2017.SmartGrids.CIM.IEC61968.Common;
using TTC2017.SmartGrids.CIM.IEC61968.Customers;
using TTC2017.SmartGrids.CIM.IEC61968.Metering;
using TTC2017.SmartGrids.CIM.IEC61968.Work;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfERPSupport;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.InfOperations;

namespace TTC2017.SmartGrids.CIM.IEC61970.Informative.InfCustomers
{
    
    
    public class WorkBillingInfoErpLineItemsCollection : ObservableOppositeOrderedSet<IWorkBillingInfo, IErpInvoiceLineItem>
    {
        
        public WorkBillingInfoErpLineItemsCollection(IWorkBillingInfo parent) : 
                base(parent)
        {
        }
        
        private void OnItemDeleted(object sender, System.EventArgs e)
        {
            this.Remove(((IErpInvoiceLineItem)(sender)));
        }
        
        protected override void SetOpposite(IErpInvoiceLineItem item, IWorkBillingInfo parent)
        {
            if ((parent != null))
            {
                item.Deleted += this.OnItemDeleted;
                item.WorkBillingInfos.Add(parent);
            }
            else
            {
                item.Deleted -= this.OnItemDeleted;
                item.WorkBillingInfos.Remove(this.Parent);
            }
        }
    }
}

