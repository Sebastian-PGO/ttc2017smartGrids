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

namespace TTC2017.SmartGrids.COSEM.Datatypes
{
    
    
    [ModelRepresentationClassAttribute("http://www.transformation-tool-contest.eu/2017/smartGrids/cosem#//Datatypes/Disco" +
        "nnectControlState")]
    public enum DisconnectControlState
    {
        
        Disconnected = 0,
        
        Connected = 1,
        
        Ready_for_reconnection = 2,
    }
}

