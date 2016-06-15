﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]

namespace Pledger.Data
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class DTCEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new DTCEntities object using the connection string found in the 'DTCEntities' section of the application configuration file.
        /// </summary>
        public DTCEntities() : base("name=DTCEntities", "DTCEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new DTCEntities object.
        /// </summary>
        public DTCEntities(string connectionString) : base(connectionString, "DTCEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new DTCEntities object.
        /// </summary>
        public DTCEntities(EntityConnection connection) : base(connection, "DTCEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region Function Imports
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        /// <param name="participantNum">No Metadata Documentation available.</param>
        public ObjectResult<spAlanGetRealTimePositions_Result> spAlanGetRealTimePositions(global::System.String participantNum)
        {
            ObjectParameter participantNumParameter;
            if (participantNum != null)
            {
                participantNumParameter = new ObjectParameter("ParticipantNum", participantNum);
            }
            else
            {
                participantNumParameter = new ObjectParameter("ParticipantNum", typeof(global::System.String));
            }
    
            return base.ExecuteFunction<spAlanGetRealTimePositions_Result>("spAlanGetRealTimePositions", participantNumParameter);
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        /// <param name="participantNum">No Metadata Documentation available.</param>
        public ObjectResult<spAlanGetRealTimePositions_Pledger_Result> spAlanGetRealTimePositions_Pledger(global::System.String participantNum)
        {
            ObjectParameter participantNumParameter;
            if (participantNum != null)
            {
                participantNumParameter = new ObjectParameter("ParticipantNum", participantNum);
            }
            else
            {
                participantNumParameter = new ObjectParameter("ParticipantNum", typeof(global::System.String));
            }
    
            return base.ExecuteFunction<spAlanGetRealTimePositions_Pledger_Result>("spAlanGetRealTimePositions_Pledger", participantNumParameter);
        }

        #endregion
    }
    

    #endregion
    
    #region ComplexTypes
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmComplexTypeAttribute(NamespaceName="DTCModel", Name="spAlanGetRealTimePositions_Pledger_Result")]
    [DataContractAttribute(IsReference=true)]
    [Serializable()]
    public partial class spAlanGetRealTimePositions_Pledger_Result : ComplexObject
    {
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String cusip
        {
            get
            {
                return _cusip;
            }
            set
            {
                OncusipChanging(value);
                ReportPropertyChanging("cusip");
                _cusip = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("cusip");
                OncusipChanged();
            }
        }
        private global::System.String _cusip;
        partial void OncusipChanging(global::System.String value);
        partial void OncusipChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Ticker
        {
            get
            {
                return _Ticker;
            }
            set
            {
                OnTickerChanging(value);
                ReportPropertyChanging("Ticker");
                _Ticker = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Ticker");
                OnTickerChanged();
            }
        }
        private global::System.String _Ticker;
        partial void OnTickerChanging(global::System.String value);
        partial void OnTickerChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Decimal> unpledgedquantity
        {
            get
            {
                return _unpledgedquantity;
            }
            set
            {
                OnunpledgedquantityChanging(value);
                ReportPropertyChanging("unpledgedquantity");
                _unpledgedquantity = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("unpledgedquantity");
                OnunpledgedquantityChanged();
            }
        }
        private Nullable<global::System.Decimal> _unpledgedquantity;
        partial void OnunpledgedquantityChanging(Nullable<global::System.Decimal> value);
        partial void OnunpledgedquantityChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> pledgedquantity
        {
            get
            {
                return _pledgedquantity;
            }
            set
            {
                OnpledgedquantityChanging(value);
                ReportPropertyChanging("pledgedquantity");
                _pledgedquantity = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("pledgedquantity");
                OnpledgedquantityChanged();
            }
        }
        private Nullable<global::System.Int32> _pledgedquantity;
        partial void OnpledgedquantityChanging(Nullable<global::System.Int32> value);
        partial void OnpledgedquantityChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Decimal> Price
        {
            get
            {
                return _Price;
            }
            set
            {
                OnPriceChanging(value);
                ReportPropertyChanging("Price");
                _Price = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Price");
                OnPriceChanged();
            }
        }
        private Nullable<global::System.Decimal> _Price;
        partial void OnPriceChanging(Nullable<global::System.Decimal> value);
        partial void OnPriceChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> TodaysNet
        {
            get
            {
                return _TodaysNet;
            }
            set
            {
                OnTodaysNetChanging(value);
                ReportPropertyChanging("TodaysNet");
                _TodaysNet = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("TodaysNet");
                OnTodaysNetChanged();
            }
        }
        private Nullable<global::System.Int32> _TodaysNet;
        partial void OnTodaysNetChanging(Nullable<global::System.Int32> value);
        partial void OnTodaysNetChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> TomorrowsNet
        {
            get
            {
                return _TomorrowsNet;
            }
            set
            {
                OnTomorrowsNetChanging(value);
                ReportPropertyChanging("TomorrowsNet");
                _TomorrowsNet = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("TomorrowsNet");
                OnTomorrowsNetChanged();
            }
        }
        private Nullable<global::System.Int32> _TomorrowsNet;
        partial void OnTomorrowsNetChanging(Nullable<global::System.Int32> value);
        partial void OnTomorrowsNetChanged();

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmComplexTypeAttribute(NamespaceName="DTCModel", Name="spAlanGetRealTimePositions_Result")]
    [DataContractAttribute(IsReference=true)]
    [Serializable()]
    public partial class spAlanGetRealTimePositions_Result : ComplexObject
    {
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String cusip
        {
            get
            {
                return _cusip;
            }
            set
            {
                OncusipChanging(value);
                ReportPropertyChanging("cusip");
                _cusip = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("cusip");
                OncusipChanged();
            }
        }
        private global::System.String _cusip;
        partial void OncusipChanging(global::System.String value);
        partial void OncusipChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Ticker
        {
            get
            {
                return _Ticker;
            }
            set
            {
                OnTickerChanging(value);
                ReportPropertyChanging("Ticker");
                _Ticker = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Ticker");
                OnTickerChanged();
            }
        }
        private global::System.String _Ticker;
        partial void OnTickerChanging(global::System.String value);
        partial void OnTickerChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Decimal> unpledgedquantity
        {
            get
            {
                return _unpledgedquantity;
            }
            set
            {
                OnunpledgedquantityChanging(value);
                ReportPropertyChanging("unpledgedquantity");
                _unpledgedquantity = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("unpledgedquantity");
                OnunpledgedquantityChanged();
            }
        }
        private Nullable<global::System.Decimal> _unpledgedquantity;
        partial void OnunpledgedquantityChanging(Nullable<global::System.Decimal> value);
        partial void OnunpledgedquantityChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> pledgedquantity
        {
            get
            {
                return _pledgedquantity;
            }
            set
            {
                OnpledgedquantityChanging(value);
                ReportPropertyChanging("pledgedquantity");
                _pledgedquantity = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("pledgedquantity");
                OnpledgedquantityChanged();
            }
        }
        private Nullable<global::System.Int32> _pledgedquantity;
        partial void OnpledgedquantityChanging(Nullable<global::System.Int32> value);
        partial void OnpledgedquantityChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Decimal> Price
        {
            get
            {
                return _Price;
            }
            set
            {
                OnPriceChanging(value);
                ReportPropertyChanging("Price");
                _Price = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Price");
                OnPriceChanged();
            }
        }
        private Nullable<global::System.Decimal> _Price;
        partial void OnPriceChanging(Nullable<global::System.Decimal> value);
        partial void OnPriceChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> TodaysNet
        {
            get
            {
                return _TodaysNet;
            }
            set
            {
                OnTodaysNetChanging(value);
                ReportPropertyChanging("TodaysNet");
                _TodaysNet = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("TodaysNet");
                OnTodaysNetChanged();
            }
        }
        private Nullable<global::System.Int32> _TodaysNet;
        partial void OnTodaysNetChanging(Nullable<global::System.Int32> value);
        partial void OnTodaysNetChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> TomorrowsNet
        {
            get
            {
                return _TomorrowsNet;
            }
            set
            {
                OnTomorrowsNetChanging(value);
                ReportPropertyChanging("TomorrowsNet");
                _TomorrowsNet = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("TomorrowsNet");
                OnTomorrowsNetChanged();
            }
        }
        private Nullable<global::System.Int32> _TomorrowsNet;
        partial void OnTomorrowsNetChanging(Nullable<global::System.Int32> value);
        partial void OnTomorrowsNetChanged();

        #endregion
    }

    #endregion
    
}