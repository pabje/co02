/*
'===============================================================================
'  Generated From - CSharp_dOOdads_View.vbgen
'
'  The supporting base class SqlClientEntity is in the 
'  Architecture directory in "dOOdads".
'===============================================================================
*/

// Generated by MyGeneration Version # (1.3.0.3)

using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using System.Collections.Specialized;

using MyGeneration.dOOdads;

namespace cfd.FacturaElectronica
{
	public class vwCfdInformeMensualVentas : SqlClientEntity
	{
		public vwCfdInformeMensualVentas()
		{
			this.QuerySource = "vwCfdInformeMensualVentas";
			this.MappingName = "vwCfdInformeMensualVentas";
		}	
		//3/11/10 jcf Crea constructor con cadena de conexi�n
        public vwCfdInformeMensualVentas(string connstr)
		{
		    this.ConnectionString = connstr;
			this.QuerySource = "vwCfdInformeMensualVentas";
			this.MappingName = "vwCfdInformeMensualVentas";
		}	
	
		//=================================================================
		//  	public Function LoadAll() As Boolean
		//=================================================================
		//  Loads all of the records in the database, and sets the currentRow to the first row
		//=================================================================
		public bool LoadAll() 
		{
			return base.Query.Load();
		}
		
		public override void FlushData()
		{
			this._whereClause = null;
			this._aggregateClause = null;
			base.FlushData();
		}
	
		#region Parameters
		protected class Parameters
		{
			
			public static SqlParameter ComprobanteEmitido
			{
				get
				{
					return new SqlParameter("@ComprobanteEmitido", SqlDbType.NVarChar, 1073741823);
				}
			}
			
			public static SqlParameter Soptype
			{
				get
				{
					return new SqlParameter("@Soptype", SqlDbType.SmallInt, 0);
				}
			}
			
			public static SqlParameter Docid
			{
				get
				{
					return new SqlParameter("@Docid", SqlDbType.VarChar, 15);
				}
			}
			
			public static SqlParameter Sopnumbe
			{
				get
				{
					return new SqlParameter("@Sopnumbe", SqlDbType.VarChar, 21);
				}
			}
			
			public static SqlParameter Fechahora
			{
				get
				{
					return new SqlParameter("@Fechahora", SqlDbType.DateTime, 0);
				}
			}
			
		}
		#endregion	
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string ComprobanteEmitido = "comprobanteEmitido";
            public const string Soptype = "soptype";
            public const string Docid = "docid";
            public const string Sopnumbe = "sopnumbe";
            public const string Fechahora = "fechahora";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[ComprobanteEmitido] = vwCfdInformeMensualVentas.PropertyNames.ComprobanteEmitido;
					ht[Soptype] = vwCfdInformeMensualVentas.PropertyNames.Soptype;
					ht[Docid] = vwCfdInformeMensualVentas.PropertyNames.Docid;
					ht[Sopnumbe] = vwCfdInformeMensualVentas.PropertyNames.Sopnumbe;
					ht[Fechahora] = vwCfdInformeMensualVentas.PropertyNames.Fechahora;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string ComprobanteEmitido = "ComprobanteEmitido";
            public const string Soptype = "Soptype";
            public const string Docid = "Docid";
            public const string Sopnumbe = "Sopnumbe";
            public const string Fechahora = "Fechahora";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[ComprobanteEmitido] = vwCfdInformeMensualVentas.ColumnNames.ComprobanteEmitido;
					ht[Soptype] = vwCfdInformeMensualVentas.ColumnNames.Soptype;
					ht[Docid] = vwCfdInformeMensualVentas.ColumnNames.Docid;
					ht[Sopnumbe] = vwCfdInformeMensualVentas.ColumnNames.Sopnumbe;
					ht[Fechahora] = vwCfdInformeMensualVentas.ColumnNames.Fechahora;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string ComprobanteEmitido = "s_ComprobanteEmitido";
            public const string Soptype = "s_Soptype";
            public const string Docid = "s_Docid";
            public const string Sopnumbe = "s_Sopnumbe";
            public const string Fechahora = "s_Fechahora";

		}
		#endregion	
		
		#region Properties
			public virtual string ComprobanteEmitido
	    {
			get
	        {
				return base.Getstring(ColumnNames.ComprobanteEmitido);
			}
			set
	        {
				base.Setstring(ColumnNames.ComprobanteEmitido, value);
			}
		}

		public virtual short Soptype
	    {
			get
	        {
				return base.Getshort(ColumnNames.Soptype);
			}
			set
	        {
				base.Setshort(ColumnNames.Soptype, value);
			}
		}

		public virtual string Docid
	    {
			get
	        {
				return base.Getstring(ColumnNames.Docid);
			}
			set
	        {
				base.Setstring(ColumnNames.Docid, value);
			}
		}

		public virtual string Sopnumbe
	    {
			get
	        {
				return base.Getstring(ColumnNames.Sopnumbe);
			}
			set
	        {
				base.Setstring(ColumnNames.Sopnumbe, value);
			}
		}

		public virtual DateTime Fechahora
	    {
			get
	        {
				return base.GetDateTime(ColumnNames.Fechahora);
			}
			set
	        {
				base.SetDateTime(ColumnNames.Fechahora, value);
			}
		}


		#endregion
		
		#region String Properties
	
		public virtual string s_ComprobanteEmitido
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.ComprobanteEmitido) ? string.Empty : base.GetstringAsString(ColumnNames.ComprobanteEmitido);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.ComprobanteEmitido);
				else
					this.ComprobanteEmitido = base.SetstringAsString(ColumnNames.ComprobanteEmitido, value);
			}
		}

		public virtual string s_Soptype
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Soptype) ? string.Empty : base.GetshortAsString(ColumnNames.Soptype);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Soptype);
				else
					this.Soptype = base.SetshortAsString(ColumnNames.Soptype, value);
			}
		}

		public virtual string s_Docid
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Docid) ? string.Empty : base.GetstringAsString(ColumnNames.Docid);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Docid);
				else
					this.Docid = base.SetstringAsString(ColumnNames.Docid, value);
			}
		}

		public virtual string s_Sopnumbe
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Sopnumbe) ? string.Empty : base.GetstringAsString(ColumnNames.Sopnumbe);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Sopnumbe);
				else
					this.Sopnumbe = base.SetstringAsString(ColumnNames.Sopnumbe, value);
			}
		}

		public virtual string s_Fechahora
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Fechahora) ? string.Empty : base.GetDateTimeAsString(ColumnNames.Fechahora);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Fechahora);
				else
					this.Fechahora = base.SetDateTimeAsString(ColumnNames.Fechahora, value);
			}
		}


		#endregion			
	
		#region Where Clause
		public class WhereClause
		{
			public WhereClause(BusinessEntity entity)
			{
				this._entity = entity;
			}
			
			public TearOffWhereParameter TearOff
			{
				get
				{
					if(_tearOff == null)
					{
						_tearOff = new TearOffWhereParameter(this);
					}

					return _tearOff;
				}
			}

			#region WhereParameter TearOff's
			public class TearOffWhereParameter
			{
				public TearOffWhereParameter(WhereClause clause)
				{
					this._clause = clause;
				}
				
				
				public WhereParameter ComprobanteEmitido
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.ComprobanteEmitido, Parameters.ComprobanteEmitido);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Soptype
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Soptype, Parameters.Soptype);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Docid
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Docid, Parameters.Docid);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Sopnumbe
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Sopnumbe, Parameters.Sopnumbe);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Fechahora
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Fechahora, Parameters.Fechahora);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}


				private WhereClause _clause;
			}
			#endregion
		
			public WhereParameter ComprobanteEmitido
		    {
				get
		        {
					if(_ComprobanteEmitido_W == null)
	        	    {
						_ComprobanteEmitido_W = TearOff.ComprobanteEmitido;
					}
					return _ComprobanteEmitido_W;
				}
			}

			public WhereParameter Soptype
		    {
				get
		        {
					if(_Soptype_W == null)
	        	    {
						_Soptype_W = TearOff.Soptype;
					}
					return _Soptype_W;
				}
			}

			public WhereParameter Docid
		    {
				get
		        {
					if(_Docid_W == null)
	        	    {
						_Docid_W = TearOff.Docid;
					}
					return _Docid_W;
				}
			}

			public WhereParameter Sopnumbe
		    {
				get
		        {
					if(_Sopnumbe_W == null)
	        	    {
						_Sopnumbe_W = TearOff.Sopnumbe;
					}
					return _Sopnumbe_W;
				}
			}

			public WhereParameter Fechahora
		    {
				get
		        {
					if(_Fechahora_W == null)
	        	    {
						_Fechahora_W = TearOff.Fechahora;
					}
					return _Fechahora_W;
				}
			}

			private WhereParameter _ComprobanteEmitido_W = null;
			private WhereParameter _Soptype_W = null;
			private WhereParameter _Docid_W = null;
			private WhereParameter _Sopnumbe_W = null;
			private WhereParameter _Fechahora_W = null;

			public void WhereClauseReset()
			{
				_ComprobanteEmitido_W = null;
				_Soptype_W = null;
				_Docid_W = null;
				_Sopnumbe_W = null;
				_Fechahora_W = null;

				this._entity.Query.FlushWhereParameters();

			}
	
			private BusinessEntity _entity;
			private TearOffWhereParameter _tearOff;
			
		}
	
		public WhereClause Where
		{
			get
			{
				if(_whereClause == null)
				{
					_whereClause = new WhereClause(this);
				}
		
				return _whereClause;
			}
		}
		
		private WhereClause _whereClause = null;	
		#endregion
	
		#region Aggregate Clause
		public class AggregateClause
		{
			public AggregateClause(BusinessEntity entity)
			{
				this._entity = entity;
			}
			
			public TearOffAggregateParameter TearOff
			{
				get
				{
					if(_tearOff == null)
					{
						_tearOff = new TearOffAggregateParameter(this);
					}

					return _tearOff;
				}
			}

			#region AggregateParameter TearOff's
			public class TearOffAggregateParameter
			{
				public TearOffAggregateParameter(AggregateClause clause)
				{
					this._clause = clause;
				}
				
				
				public AggregateParameter ComprobanteEmitido
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.ComprobanteEmitido, Parameters.ComprobanteEmitido);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Soptype
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Soptype, Parameters.Soptype);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Docid
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Docid, Parameters.Docid);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Sopnumbe
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Sopnumbe, Parameters.Sopnumbe);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Fechahora
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Fechahora, Parameters.Fechahora);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}


				private AggregateClause _clause;
			}
			#endregion
		
			public AggregateParameter ComprobanteEmitido
		    {
				get
		        {
					if(_ComprobanteEmitido_W == null)
	        	    {
						_ComprobanteEmitido_W = TearOff.ComprobanteEmitido;
					}
					return _ComprobanteEmitido_W;
				}
			}

			public AggregateParameter Soptype
		    {
				get
		        {
					if(_Soptype_W == null)
	        	    {
						_Soptype_W = TearOff.Soptype;
					}
					return _Soptype_W;
				}
			}

			public AggregateParameter Docid
		    {
				get
		        {
					if(_Docid_W == null)
	        	    {
						_Docid_W = TearOff.Docid;
					}
					return _Docid_W;
				}
			}

			public AggregateParameter Sopnumbe
		    {
				get
		        {
					if(_Sopnumbe_W == null)
	        	    {
						_Sopnumbe_W = TearOff.Sopnumbe;
					}
					return _Sopnumbe_W;
				}
			}

			public AggregateParameter Fechahora
		    {
				get
		        {
					if(_Fechahora_W == null)
	        	    {
						_Fechahora_W = TearOff.Fechahora;
					}
					return _Fechahora_W;
				}
			}

			private AggregateParameter _ComprobanteEmitido_W = null;
			private AggregateParameter _Soptype_W = null;
			private AggregateParameter _Docid_W = null;
			private AggregateParameter _Sopnumbe_W = null;
			private AggregateParameter _Fechahora_W = null;

			public void AggregateClauseReset()
			{
				_ComprobanteEmitido_W = null;
				_Soptype_W = null;
				_Docid_W = null;
				_Sopnumbe_W = null;
				_Fechahora_W = null;

				this._entity.Query.FlushAggregateParameters();

			}
	
			private BusinessEntity _entity;
			private TearOffAggregateParameter _tearOff;
			
		}
	
		public AggregateClause Aggregate
		{
			get
			{
				if(_aggregateClause == null)
				{
					_aggregateClause = new AggregateClause(this);
				}
		
				return _aggregateClause;
			}
		}
		
		private AggregateClause _aggregateClause = null;	
		#endregion
	
		protected override IDbCommand GetInsertCommand() 
		{
			return null;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
			return null;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
			return null;
		}
	}
}
