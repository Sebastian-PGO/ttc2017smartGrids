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
using TTC2017.SmartGrids.COSEM.COSEMObjects;

namespace TTC2017.SmartGrids.COSEM
{
    
    
    /// <summary>
    /// The public interface for PhysicalDevice
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(PhysicalDevice))]
    [XmlDefaultImplementationTypeAttribute(typeof(PhysicalDevice))]
    public interface IPhysicalDevice : IModelElement
    {
        
        /// <summary>
        /// The ID property
        /// </summary>
        string ID
        {
            get;
            set;
        }
        
        /// <summary>
        /// The managementLogicalDevice property
        /// </summary>
        IManagementLogicalDevice ManagementLogicalDevice
        {
            get;
            set;
        }
        
        /// <summary>
        /// The LogicalDevice property
        /// </summary>
        IOrderedSetExpression<ILogicalDevice> LogicalDevice
        {
            get;
        }
        
        /// <summary>
        /// The ElectricityRelatedStatus property
        /// </summary>
        IElectricityRelatedStatusData ElectricityRelatedStatus
        {
            get;
            set;
        }
        
        /// <summary>
        /// The AA property
        /// </summary>
        ICurrentAssociation AA
        {
            get;
            set;
        }
        
        /// <summary>
        /// The AutoConnect property
        /// </summary>
        IAutoConnectObject AutoConnect
        {
            get;
            set;
        }
        
        /// <summary>
        /// The BillingPeriodValues property
        /// </summary>
        IBillingPeriodValues BillingPeriodValues
        {
            get;
            set;
        }
        
        /// <summary>
        /// The ElectricityID property
        /// </summary>
        IElectricityID ElectricityID
        {
            get;
            set;
        }
        
        /// <summary>
        /// The ProgramEntries property
        /// </summary>
        IElectricityProgramEntries ProgramEntries
        {
            get;
            set;
        }
        
        /// <summary>
        /// The OutputPulse property
        /// </summary>
        IOutputPulseValues_constants OutputPulse
        {
            get;
            set;
        }
        
        /// <summary>
        /// The ReadingFactor property
        /// </summary>
        IReadingFactorAndCT_VTratio ReadingFactor
        {
            get;
            set;
        }
        
        /// <summary>
        /// The NominalValues property
        /// </summary>
        IElectricityNominalValues NominalValues
        {
            get;
            set;
        }
        
        /// <summary>
        /// The InputPulse property
        /// </summary>
        IInputPulseValuesOrConstants InputPulse
        {
            get;
            set;
        }
        
        /// <summary>
        /// The MeasurementPeriod property
        /// </summary>
        IMeasurementPeriod_recordingInterval_billingPeriodDuration MeasurementPeriod
        {
            get;
            set;
        }
        
        /// <summary>
        /// The TimeEntries property
        /// </summary>
        ITimeEntries TimeEntries
        {
            get;
            set;
        }
        
        /// <summary>
        /// The TransformerLineLosses property
        /// </summary>
        ITransformerAndLineLosses TransformerLineLosses
        {
            get;
            set;
        }
        
        /// <summary>
        /// The MeasurementAlgorithm property
        /// </summary>
        IMeasurementMethods MeasurementAlgorithm
        {
            get;
            set;
        }
        
        /// <summary>
        /// The MeteringPoint property
        /// </summary>
        IMeteringPointID MeteringPoint
        {
            get;
            set;
        }
        
        /// <summary>
        /// The RegisterMonitor property
        /// </summary>
        IRegisterMonitorObject RegisterMonitor
        {
            get;
            set;
        }
        
        /// <summary>
        /// The ElectricityValues property
        /// </summary>
        IElectricityValues ElectricityValues
        {
            get;
            set;
        }
        
        /// <summary>
        /// The MeasurementValueTypes property
        /// </summary>
        IMeasurementValues MeasurementValueTypes
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Harmonics property
        /// </summary>
        IElectricityHarmonics Harmonics
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Tariffs property
        /// </summary>
        ICurrentlyActiveTariff Tariffs
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Phaseangles property
        /// </summary>
        IExtendedPhaseAngleMeasurement Phaseangles
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the ID property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> IDChanging;
        
        /// <summary>
        /// Gets fired when the ID property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> IDChanged;
        
        /// <summary>
        /// Gets fired before the ManagementLogicalDevice property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ManagementLogicalDeviceChanging;
        
        /// <summary>
        /// Gets fired when the ManagementLogicalDevice property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ManagementLogicalDeviceChanged;
        
        /// <summary>
        /// Gets fired before the ElectricityRelatedStatus property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ElectricityRelatedStatusChanging;
        
        /// <summary>
        /// Gets fired when the ElectricityRelatedStatus property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ElectricityRelatedStatusChanged;
        
        /// <summary>
        /// Gets fired before the AA property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AAChanging;
        
        /// <summary>
        /// Gets fired when the AA property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AAChanged;
        
        /// <summary>
        /// Gets fired before the AutoConnect property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AutoConnectChanging;
        
        /// <summary>
        /// Gets fired when the AutoConnect property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AutoConnectChanged;
        
        /// <summary>
        /// Gets fired before the BillingPeriodValues property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> BillingPeriodValuesChanging;
        
        /// <summary>
        /// Gets fired when the BillingPeriodValues property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> BillingPeriodValuesChanged;
        
        /// <summary>
        /// Gets fired before the ElectricityID property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ElectricityIDChanging;
        
        /// <summary>
        /// Gets fired when the ElectricityID property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ElectricityIDChanged;
        
        /// <summary>
        /// Gets fired before the ProgramEntries property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ProgramEntriesChanging;
        
        /// <summary>
        /// Gets fired when the ProgramEntries property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ProgramEntriesChanged;
        
        /// <summary>
        /// Gets fired before the OutputPulse property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> OutputPulseChanging;
        
        /// <summary>
        /// Gets fired when the OutputPulse property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> OutputPulseChanged;
        
        /// <summary>
        /// Gets fired before the ReadingFactor property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ReadingFactorChanging;
        
        /// <summary>
        /// Gets fired when the ReadingFactor property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ReadingFactorChanged;
        
        /// <summary>
        /// Gets fired before the NominalValues property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> NominalValuesChanging;
        
        /// <summary>
        /// Gets fired when the NominalValues property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> NominalValuesChanged;
        
        /// <summary>
        /// Gets fired before the InputPulse property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> InputPulseChanging;
        
        /// <summary>
        /// Gets fired when the InputPulse property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> InputPulseChanged;
        
        /// <summary>
        /// Gets fired before the MeasurementPeriod property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> MeasurementPeriodChanging;
        
        /// <summary>
        /// Gets fired when the MeasurementPeriod property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> MeasurementPeriodChanged;
        
        /// <summary>
        /// Gets fired before the TimeEntries property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TimeEntriesChanging;
        
        /// <summary>
        /// Gets fired when the TimeEntries property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TimeEntriesChanged;
        
        /// <summary>
        /// Gets fired before the TransformerLineLosses property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TransformerLineLossesChanging;
        
        /// <summary>
        /// Gets fired when the TransformerLineLosses property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TransformerLineLossesChanged;
        
        /// <summary>
        /// Gets fired before the MeasurementAlgorithm property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> MeasurementAlgorithmChanging;
        
        /// <summary>
        /// Gets fired when the MeasurementAlgorithm property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> MeasurementAlgorithmChanged;
        
        /// <summary>
        /// Gets fired before the MeteringPoint property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> MeteringPointChanging;
        
        /// <summary>
        /// Gets fired when the MeteringPoint property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> MeteringPointChanged;
        
        /// <summary>
        /// Gets fired before the RegisterMonitor property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> RegisterMonitorChanging;
        
        /// <summary>
        /// Gets fired when the RegisterMonitor property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> RegisterMonitorChanged;
        
        /// <summary>
        /// Gets fired before the ElectricityValues property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ElectricityValuesChanging;
        
        /// <summary>
        /// Gets fired when the ElectricityValues property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ElectricityValuesChanged;
        
        /// <summary>
        /// Gets fired before the MeasurementValueTypes property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> MeasurementValueTypesChanging;
        
        /// <summary>
        /// Gets fired when the MeasurementValueTypes property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> MeasurementValueTypesChanged;
        
        /// <summary>
        /// Gets fired before the Harmonics property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> HarmonicsChanging;
        
        /// <summary>
        /// Gets fired when the Harmonics property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> HarmonicsChanged;
        
        /// <summary>
        /// Gets fired before the Tariffs property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TariffsChanging;
        
        /// <summary>
        /// Gets fired when the Tariffs property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TariffsChanged;
        
        /// <summary>
        /// Gets fired before the Phaseangles property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PhaseanglesChanging;
        
        /// <summary>
        /// Gets fired when the Phaseangles property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PhaseanglesChanged;
    }
}

