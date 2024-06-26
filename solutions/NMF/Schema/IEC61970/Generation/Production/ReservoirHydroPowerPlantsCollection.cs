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
using TTC2017.SmartGrids.CIM.IEC61970.ControlArea;
using TTC2017.SmartGrids.CIM.IEC61970.Core;
using TTC2017.SmartGrids.CIM.IEC61970.Generation.GenerationDynamics;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.EnergyScheduling;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.Financial;
using TTC2017.SmartGrids.CIM.IEC61970.Informative.MarketOperations;
using TTC2017.SmartGrids.CIM.IEC61970.Wires;

namespace TTC2017.SmartGrids.CIM.IEC61970.Generation.Production
{
    
    
    public class ReservoirHydroPowerPlantsCollection : ObservableOppositeOrderedSet<IReservoir, IHydroPowerPlant>
    {
        
        public ReservoirHydroPowerPlantsCollection(IReservoir parent) : 
                base(parent)
        {
        }
        
        private void OnItemDeleted(object sender, System.EventArgs e)
        {
            this.Remove(((IHydroPowerPlant)(sender)));
        }
        
        protected override void SetOpposite(IHydroPowerPlant item, IReservoir parent)
        {
            if ((parent != null))
            {
                item.Deleted += this.OnItemDeleted;
                item.Reservoir = parent;
            }
            else
            {
                item.Deleted -= this.OnItemDeleted;
                if ((item.Reservoir == this.Parent))
                {
                    item.Reservoir = parent;
                }
            }
        }
    }
}

