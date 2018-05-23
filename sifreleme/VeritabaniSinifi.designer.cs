﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace sifreleme
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="isletimdb")]
	public partial class VeritabaniSinifiDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertmesajlar(mesajlar instance);
    partial void Updatemesajlar(mesajlar instance);
    partial void Deletemesajlar(mesajlar instance);
    partial void Insertsilinenmesajlar(silinenmesajlar instance);
    partial void Updatesilinenmesajlar(silinenmesajlar instance);
    partial void Deletesilinenmesajlar(silinenmesajlar instance);
    partial void Insertkullanicilar(kullanicilar instance);
    partial void Updatekullanicilar(kullanicilar instance);
    partial void Deletekullanicilar(kullanicilar instance);
    #endregion
		
		public VeritabaniSinifiDataContext() : 
				base(global::sifreleme.Properties.Settings.Default.isletimdbConnectionString4, mappingSource)
		{
			OnCreated();
		}
		
		public VeritabaniSinifiDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public VeritabaniSinifiDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public VeritabaniSinifiDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public VeritabaniSinifiDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<mesajlar> mesajlars
		{
			get
			{
				return this.GetTable<mesajlar>();
			}
		}
		
		public System.Data.Linq.Table<silinenmesajlar> silinenmesajlars
		{
			get
			{
				return this.GetTable<silinenmesajlar>();
			}
		}
		
		public System.Data.Linq.Table<kullanicilar> kullanicilars
		{
			get
			{
				return this.GetTable<kullanicilar>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.mesajlar")]
	public partial class mesajlar : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private int _gonderen_id;
		
		private int _alan_id;
		
		private string _mesaj;
		
		private System.Nullable<System.DateTime> _tarih;
		
		private int _okundu;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void Ongonderen_idChanging(int value);
    partial void Ongonderen_idChanged();
    partial void Onalan_idChanging(int value);
    partial void Onalan_idChanged();
    partial void OnmesajChanging(string value);
    partial void OnmesajChanged();
    partial void OntarihChanging(System.Nullable<System.DateTime> value);
    partial void OntarihChanged();
    partial void OnokunduChanging(int value);
    partial void OnokunduChanged();
    #endregion
		
		public mesajlar()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_gonderen_id", DbType="Int NOT NULL")]
		public int gonderen_id
		{
			get
			{
				return this._gonderen_id;
			}
			set
			{
				if ((this._gonderen_id != value))
				{
					this.Ongonderen_idChanging(value);
					this.SendPropertyChanging();
					this._gonderen_id = value;
					this.SendPropertyChanged("gonderen_id");
					this.Ongonderen_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_alan_id", DbType="Int NOT NULL")]
		public int alan_id
		{
			get
			{
				return this._alan_id;
			}
			set
			{
				if ((this._alan_id != value))
				{
					this.Onalan_idChanging(value);
					this.SendPropertyChanging();
					this._alan_id = value;
					this.SendPropertyChanged("alan_id");
					this.Onalan_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_mesaj", DbType="Text NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string mesaj
		{
			get
			{
				return this._mesaj;
			}
			set
			{
				if ((this._mesaj != value))
				{
					this.OnmesajChanging(value);
					this.SendPropertyChanging();
					this._mesaj = value;
					this.SendPropertyChanged("mesaj");
					this.OnmesajChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tarih", DbType="DateTime")]
		public System.Nullable<System.DateTime> tarih
		{
			get
			{
				return this._tarih;
			}
			set
			{
				if ((this._tarih != value))
				{
					this.OntarihChanging(value);
					this.SendPropertyChanging();
					this._tarih = value;
					this.SendPropertyChanged("tarih");
					this.OntarihChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_okundu", DbType="Int NOT NULL")]
		public int okundu
		{
			get
			{
				return this._okundu;
			}
			set
			{
				if ((this._okundu != value))
				{
					this.OnokunduChanging(value);
					this.SendPropertyChanging();
					this._okundu = value;
					this.SendPropertyChanged("okundu");
					this.OnokunduChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.silinenmesajlar")]
	public partial class silinenmesajlar : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private System.Nullable<int> _silen_kullanici_id;
		
		private System.Nullable<int> _silinen_kullanici_id;
		
		private System.Nullable<System.DateTime> _tarih;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void Onsilen_kullanici_idChanging(System.Nullable<int> value);
    partial void Onsilen_kullanici_idChanged();
    partial void Onsilinen_kullanici_idChanging(System.Nullable<int> value);
    partial void Onsilinen_kullanici_idChanged();
    partial void OntarihChanging(System.Nullable<System.DateTime> value);
    partial void OntarihChanged();
    #endregion
		
		public silinenmesajlar()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_silen_kullanici_id", DbType="Int")]
		public System.Nullable<int> silen_kullanici_id
		{
			get
			{
				return this._silen_kullanici_id;
			}
			set
			{
				if ((this._silen_kullanici_id != value))
				{
					this.Onsilen_kullanici_idChanging(value);
					this.SendPropertyChanging();
					this._silen_kullanici_id = value;
					this.SendPropertyChanged("silen_kullanici_id");
					this.Onsilen_kullanici_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_silinen_kullanici_id", DbType="Int")]
		public System.Nullable<int> silinen_kullanici_id
		{
			get
			{
				return this._silinen_kullanici_id;
			}
			set
			{
				if ((this._silinen_kullanici_id != value))
				{
					this.Onsilinen_kullanici_idChanging(value);
					this.SendPropertyChanging();
					this._silinen_kullanici_id = value;
					this.SendPropertyChanged("silinen_kullanici_id");
					this.Onsilinen_kullanici_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tarih", DbType="DateTime")]
		public System.Nullable<System.DateTime> tarih
		{
			get
			{
				return this._tarih;
			}
			set
			{
				if ((this._tarih != value))
				{
					this.OntarihChanging(value);
					this.SendPropertyChanging();
					this._tarih = value;
					this.SendPropertyChanged("tarih");
					this.OntarihChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.kullanicilar")]
	public partial class kullanicilar : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _ad;
		
		private string _soyad;
		
		private string _kullanici_ad;
		
		private string _sifre;
		
		private string _mail;
		
		private System.DateTime _dogum_tarih;
		
		private string _aktif_durum;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnadChanging(string value);
    partial void OnadChanged();
    partial void OnsoyadChanging(string value);
    partial void OnsoyadChanged();
    partial void Onkullanici_adChanging(string value);
    partial void Onkullanici_adChanged();
    partial void OnsifreChanging(string value);
    partial void OnsifreChanged();
    partial void OnmailChanging(string value);
    partial void OnmailChanged();
    partial void Ondogum_tarihChanging(System.DateTime value);
    partial void Ondogum_tarihChanged();
    partial void Onaktif_durumChanging(string value);
    partial void Onaktif_durumChanged();
    #endregion
		
		public kullanicilar()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ad", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string ad
		{
			get
			{
				return this._ad;
			}
			set
			{
				if ((this._ad != value))
				{
					this.OnadChanging(value);
					this.SendPropertyChanging();
					this._ad = value;
					this.SendPropertyChanged("ad");
					this.OnadChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_soyad", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string soyad
		{
			get
			{
				return this._soyad;
			}
			set
			{
				if ((this._soyad != value))
				{
					this.OnsoyadChanging(value);
					this.SendPropertyChanging();
					this._soyad = value;
					this.SendPropertyChanged("soyad");
					this.OnsoyadChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_kullanici_ad", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string kullanici_ad
		{
			get
			{
				return this._kullanici_ad;
			}
			set
			{
				if ((this._kullanici_ad != value))
				{
					this.Onkullanici_adChanging(value);
					this.SendPropertyChanging();
					this._kullanici_ad = value;
					this.SendPropertyChanged("kullanici_ad");
					this.Onkullanici_adChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sifre", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string sifre
		{
			get
			{
				return this._sifre;
			}
			set
			{
				if ((this._sifre != value))
				{
					this.OnsifreChanging(value);
					this.SendPropertyChanging();
					this._sifre = value;
					this.SendPropertyChanged("sifre");
					this.OnsifreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_mail", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string mail
		{
			get
			{
				return this._mail;
			}
			set
			{
				if ((this._mail != value))
				{
					this.OnmailChanging(value);
					this.SendPropertyChanging();
					this._mail = value;
					this.SendPropertyChanged("mail");
					this.OnmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dogum_tarih", DbType="Date NOT NULL")]
		public System.DateTime dogum_tarih
		{
			get
			{
				return this._dogum_tarih;
			}
			set
			{
				if ((this._dogum_tarih != value))
				{
					this.Ondogum_tarihChanging(value);
					this.SendPropertyChanging();
					this._dogum_tarih = value;
					this.SendPropertyChanged("dogum_tarih");
					this.Ondogum_tarihChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_aktif_durum", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string aktif_durum
		{
			get
			{
				return this._aktif_durum;
			}
			set
			{
				if ((this._aktif_durum != value))
				{
					this.Onaktif_durumChanging(value);
					this.SendPropertyChanging();
					this._aktif_durum = value;
					this.SendPropertyChanged("aktif_durum");
					this.Onaktif_durumChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
