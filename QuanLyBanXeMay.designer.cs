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

namespace project_QLBanXeMay
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="QL_BanXeMay")]
	public partial class QuanLyBanXeMayDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertHOADON(HOADON instance);
    partial void UpdateHOADON(HOADON instance);
    partial void DeleteHOADON(HOADON instance);
    partial void InsertKHACHHANG(KHACHHANG instance);
    partial void UpdateKHACHHANG(KHACHHANG instance);
    partial void DeleteKHACHHANG(KHACHHANG instance);
    partial void InsertNHANVIEN(NHANVIEN instance);
    partial void UpdateNHANVIEN(NHANVIEN instance);
    partial void DeleteNHANVIEN(NHANVIEN instance);
    partial void InsertNHAPHANPHOI(NHAPHANPHOI instance);
    partial void UpdateNHAPHANPHOI(NHAPHANPHOI instance);
    partial void DeleteNHAPHANPHOI(NHAPHANPHOI instance);
    partial void InsertSANPHAM(SANPHAM instance);
    partial void UpdateSANPHAM(SANPHAM instance);
    partial void DeleteSANPHAM(SANPHAM instance);
    #endregion
		
		public QuanLyBanXeMayDataContext() : 
				base(global::project_QLBanXeMay.Properties.Settings.Default.QL_BanXeMayConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public QuanLyBanXeMayDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QuanLyBanXeMayDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QuanLyBanXeMayDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QuanLyBanXeMayDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<DANGNHAP> DANGNHAPs
		{
			get
			{
				return this.GetTable<DANGNHAP>();
			}
		}
		
		public System.Data.Linq.Table<HOADON> HOADONs
		{
			get
			{
				return this.GetTable<HOADON>();
			}
		}
		
		public System.Data.Linq.Table<KHACHHANG> KHACHHANGs
		{
			get
			{
				return this.GetTable<KHACHHANG>();
			}
		}
		
		public System.Data.Linq.Table<NHANVIEN> NHANVIENs
		{
			get
			{
				return this.GetTable<NHANVIEN>();
			}
		}
		
		public System.Data.Linq.Table<NHAPHANPHOI> NHAPHANPHOIs
		{
			get
			{
				return this.GetTable<NHAPHANPHOI>();
			}
		}
		
		public System.Data.Linq.Table<SANPHAM> SANPHAMs
		{
			get
			{
				return this.GetTable<SANPHAM>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DANGNHAP")]
	public partial class DANGNHAP
	{
		
		private string _TK;
		
		private string _MK;
		
		public DANGNHAP()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TK", DbType="NVarChar(50)")]
		public string TK
		{
			get
			{
				return this._TK;
			}
			set
			{
				if ((this._TK != value))
				{
					this._TK = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MK", DbType="NVarChar(50)")]
		public string MK
		{
			get
			{
				return this._MK;
			}
			set
			{
				if ((this._MK != value))
				{
					this._MK = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.HOADON")]
	public partial class HOADON : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaHD;
		
		private System.Nullable<int> _MaKH;
		
		private System.Nullable<int> _MaNV;
		
		private System.Nullable<int> _MaSP;
		
		private System.Nullable<int> _MaNPP;
		
		private System.Nullable<int> _SoLuongSP;
		
		private string _MauSP;
		
		private string _NgayXuatHD;
		
		private System.Nullable<int> _Tong;
		
		private EntityRef<KHACHHANG> _KHACHHANG;
		
		private EntityRef<NHANVIEN> _NHANVIEN;
		
		private EntityRef<NHAPHANPHOI> _NHAPHANPHOI;
		
		private EntityRef<SANPHAM> _SANPHAM;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaHDChanging(int value);
    partial void OnMaHDChanged();
    partial void OnMaKHChanging(System.Nullable<int> value);
    partial void OnMaKHChanged();
    partial void OnMaNVChanging(System.Nullable<int> value);
    partial void OnMaNVChanged();
    partial void OnMaSPChanging(System.Nullable<int> value);
    partial void OnMaSPChanged();
    partial void OnMaNPPChanging(System.Nullable<int> value);
    partial void OnMaNPPChanged();
    partial void OnSoLuongSPChanging(System.Nullable<int> value);
    partial void OnSoLuongSPChanged();
    partial void OnMauSPChanging(string value);
    partial void OnMauSPChanged();
    partial void OnNgayXuatHDChanging(string value);
    partial void OnNgayXuatHDChanged();
    partial void OnTongChanging(System.Nullable<int> value);
    partial void OnTongChanged();
    #endregion
		
		public HOADON()
		{
			this._KHACHHANG = default(EntityRef<KHACHHANG>);
			this._NHANVIEN = default(EntityRef<NHANVIEN>);
			this._NHAPHANPHOI = default(EntityRef<NHAPHANPHOI>);
			this._SANPHAM = default(EntityRef<SANPHAM>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaHD", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int MaHD
		{
			get
			{
				return this._MaHD;
			}
			set
			{
				if ((this._MaHD != value))
				{
					this.OnMaHDChanging(value);
					this.SendPropertyChanging();
					this._MaHD = value;
					this.SendPropertyChanged("MaHD");
					this.OnMaHDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaKH", DbType="Int")]
		public System.Nullable<int> MaKH
		{
			get
			{
				return this._MaKH;
			}
			set
			{
				if ((this._MaKH != value))
				{
					if (this._KHACHHANG.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaKHChanging(value);
					this.SendPropertyChanging();
					this._MaKH = value;
					this.SendPropertyChanged("MaKH");
					this.OnMaKHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaNV", DbType="Int")]
		public System.Nullable<int> MaNV
		{
			get
			{
				return this._MaNV;
			}
			set
			{
				if ((this._MaNV != value))
				{
					if (this._NHANVIEN.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaNVChanging(value);
					this.SendPropertyChanging();
					this._MaNV = value;
					this.SendPropertyChanged("MaNV");
					this.OnMaNVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaSP", DbType="Int")]
		public System.Nullable<int> MaSP
		{
			get
			{
				return this._MaSP;
			}
			set
			{
				if ((this._MaSP != value))
				{
					if (this._SANPHAM.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaSPChanging(value);
					this.SendPropertyChanging();
					this._MaSP = value;
					this.SendPropertyChanged("MaSP");
					this.OnMaSPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaNPP", DbType="Int")]
		public System.Nullable<int> MaNPP
		{
			get
			{
				return this._MaNPP;
			}
			set
			{
				if ((this._MaNPP != value))
				{
					if (this._NHAPHANPHOI.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaNPPChanging(value);
					this.SendPropertyChanging();
					this._MaNPP = value;
					this.SendPropertyChanged("MaNPP");
					this.OnMaNPPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoLuongSP", DbType="Int")]
		public System.Nullable<int> SoLuongSP
		{
			get
			{
				return this._SoLuongSP;
			}
			set
			{
				if ((this._SoLuongSP != value))
				{
					this.OnSoLuongSPChanging(value);
					this.SendPropertyChanging();
					this._SoLuongSP = value;
					this.SendPropertyChanged("SoLuongSP");
					this.OnSoLuongSPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MauSP", DbType="NVarChar(50)")]
		public string MauSP
		{
			get
			{
				return this._MauSP;
			}
			set
			{
				if ((this._MauSP != value))
				{
					this.OnMauSPChanging(value);
					this.SendPropertyChanging();
					this._MauSP = value;
					this.SendPropertyChanged("MauSP");
					this.OnMauSPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayXuatHD", DbType="NVarChar(50)")]
		public string NgayXuatHD
		{
			get
			{
				return this._NgayXuatHD;
			}
			set
			{
				if ((this._NgayXuatHD != value))
				{
					this.OnNgayXuatHDChanging(value);
					this.SendPropertyChanging();
					this._NgayXuatHD = value;
					this.SendPropertyChanged("NgayXuatHD");
					this.OnNgayXuatHDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tong", DbType="Int")]
		public System.Nullable<int> Tong
		{
			get
			{
				return this._Tong;
			}
			set
			{
				if ((this._Tong != value))
				{
					this.OnTongChanging(value);
					this.SendPropertyChanging();
					this._Tong = value;
					this.SendPropertyChanged("Tong");
					this.OnTongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="KHACHHANG_HOADON", Storage="_KHACHHANG", ThisKey="MaKH", OtherKey="MaKH", IsForeignKey=true)]
		public KHACHHANG KHACHHANG
		{
			get
			{
				return this._KHACHHANG.Entity;
			}
			set
			{
				KHACHHANG previousValue = this._KHACHHANG.Entity;
				if (((previousValue != value) 
							|| (this._KHACHHANG.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._KHACHHANG.Entity = null;
						previousValue.HOADONs.Remove(this);
					}
					this._KHACHHANG.Entity = value;
					if ((value != null))
					{
						value.HOADONs.Add(this);
						this._MaKH = value.MaKH;
					}
					else
					{
						this._MaKH = default(Nullable<int>);
					}
					this.SendPropertyChanged("KHACHHANG");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NHANVIEN_HOADON", Storage="_NHANVIEN", ThisKey="MaNV", OtherKey="MaNV", IsForeignKey=true)]
		public NHANVIEN NHANVIEN
		{
			get
			{
				return this._NHANVIEN.Entity;
			}
			set
			{
				NHANVIEN previousValue = this._NHANVIEN.Entity;
				if (((previousValue != value) 
							|| (this._NHANVIEN.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._NHANVIEN.Entity = null;
						previousValue.HOADONs.Remove(this);
					}
					this._NHANVIEN.Entity = value;
					if ((value != null))
					{
						value.HOADONs.Add(this);
						this._MaNV = value.MaNV;
					}
					else
					{
						this._MaNV = default(Nullable<int>);
					}
					this.SendPropertyChanged("NHANVIEN");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NHAPHANPHOI_HOADON", Storage="_NHAPHANPHOI", ThisKey="MaNPP", OtherKey="MaNPP", IsForeignKey=true)]
		public NHAPHANPHOI NHAPHANPHOI
		{
			get
			{
				return this._NHAPHANPHOI.Entity;
			}
			set
			{
				NHAPHANPHOI previousValue = this._NHAPHANPHOI.Entity;
				if (((previousValue != value) 
							|| (this._NHAPHANPHOI.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._NHAPHANPHOI.Entity = null;
						previousValue.HOADONs.Remove(this);
					}
					this._NHAPHANPHOI.Entity = value;
					if ((value != null))
					{
						value.HOADONs.Add(this);
						this._MaNPP = value.MaNPP;
					}
					else
					{
						this._MaNPP = default(Nullable<int>);
					}
					this.SendPropertyChanged("NHAPHANPHOI");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="SANPHAM_HOADON", Storage="_SANPHAM", ThisKey="MaSP", OtherKey="MaSP", IsForeignKey=true)]
		public SANPHAM SANPHAM
		{
			get
			{
				return this._SANPHAM.Entity;
			}
			set
			{
				SANPHAM previousValue = this._SANPHAM.Entity;
				if (((previousValue != value) 
							|| (this._SANPHAM.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._SANPHAM.Entity = null;
						previousValue.HOADONs.Remove(this);
					}
					this._SANPHAM.Entity = value;
					if ((value != null))
					{
						value.HOADONs.Add(this);
						this._MaSP = value.MaSP;
					}
					else
					{
						this._MaSP = default(Nullable<int>);
					}
					this.SendPropertyChanged("SANPHAM");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.KHACHHANG")]
	public partial class KHACHHANG : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaKH;
		
		private string _TenKH;
		
		private string _SDTKH;
		
		private string _DiaChiKH;
		
		private EntitySet<HOADON> _HOADONs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaKHChanging(int value);
    partial void OnMaKHChanged();
    partial void OnTenKHChanging(string value);
    partial void OnTenKHChanged();
    partial void OnSDTKHChanging(string value);
    partial void OnSDTKHChanged();
    partial void OnDiaChiKHChanging(string value);
    partial void OnDiaChiKHChanged();
    #endregion
		
		public KHACHHANG()
		{
			this._HOADONs = new EntitySet<HOADON>(new Action<HOADON>(this.attach_HOADONs), new Action<HOADON>(this.detach_HOADONs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaKH", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int MaKH
		{
			get
			{
				return this._MaKH;
			}
			set
			{
				if ((this._MaKH != value))
				{
					this.OnMaKHChanging(value);
					this.SendPropertyChanging();
					this._MaKH = value;
					this.SendPropertyChanged("MaKH");
					this.OnMaKHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenKH", DbType="NVarChar(50)")]
		public string TenKH
		{
			get
			{
				return this._TenKH;
			}
			set
			{
				if ((this._TenKH != value))
				{
					this.OnTenKHChanging(value);
					this.SendPropertyChanging();
					this._TenKH = value;
					this.SendPropertyChanged("TenKH");
					this.OnTenKHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SDTKH", DbType="NVarChar(50)")]
		public string SDTKH
		{
			get
			{
				return this._SDTKH;
			}
			set
			{
				if ((this._SDTKH != value))
				{
					this.OnSDTKHChanging(value);
					this.SendPropertyChanging();
					this._SDTKH = value;
					this.SendPropertyChanged("SDTKH");
					this.OnSDTKHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiaChiKH", DbType="NVarChar(50)")]
		public string DiaChiKH
		{
			get
			{
				return this._DiaChiKH;
			}
			set
			{
				if ((this._DiaChiKH != value))
				{
					this.OnDiaChiKHChanging(value);
					this.SendPropertyChanging();
					this._DiaChiKH = value;
					this.SendPropertyChanged("DiaChiKH");
					this.OnDiaChiKHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="KHACHHANG_HOADON", Storage="_HOADONs", ThisKey="MaKH", OtherKey="MaKH")]
		public EntitySet<HOADON> HOADONs
		{
			get
			{
				return this._HOADONs;
			}
			set
			{
				this._HOADONs.Assign(value);
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
		
		private void attach_HOADONs(HOADON entity)
		{
			this.SendPropertyChanging();
			entity.KHACHHANG = this;
		}
		
		private void detach_HOADONs(HOADON entity)
		{
			this.SendPropertyChanging();
			entity.KHACHHANG = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.NHANVIEN")]
	public partial class NHANVIEN : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaNV;
		
		private string _TenNV;
		
		private string _GioiTinhNV;
		
		private string _SDTNV;
		
		private string _DiaChiNV;
		
		private string _XepLoaiNV;
		
		private string _MatKhau;
		
		private string _Quyen;
		
		private EntitySet<HOADON> _HOADONs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaNVChanging(int value);
    partial void OnMaNVChanged();
    partial void OnTenNVChanging(string value);
    partial void OnTenNVChanged();
    partial void OnGioiTinhNVChanging(string value);
    partial void OnGioiTinhNVChanged();
    partial void OnSDTNVChanging(string value);
    partial void OnSDTNVChanged();
    partial void OnDiaChiNVChanging(string value);
    partial void OnDiaChiNVChanged();
    partial void OnXepLoaiNVChanging(string value);
    partial void OnXepLoaiNVChanged();
    partial void OnMatKhauChanging(string value);
    partial void OnMatKhauChanged();
    partial void OnQuyenChanging(string value);
    partial void OnQuyenChanged();
    #endregion
		
		public NHANVIEN()
		{
			this._HOADONs = new EntitySet<HOADON>(new Action<HOADON>(this.attach_HOADONs), new Action<HOADON>(this.detach_HOADONs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaNV", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int MaNV
		{
			get
			{
				return this._MaNV;
			}
			set
			{
				if ((this._MaNV != value))
				{
					this.OnMaNVChanging(value);
					this.SendPropertyChanging();
					this._MaNV = value;
					this.SendPropertyChanged("MaNV");
					this.OnMaNVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenNV", DbType="NVarChar(50)")]
		public string TenNV
		{
			get
			{
				return this._TenNV;
			}
			set
			{
				if ((this._TenNV != value))
				{
					this.OnTenNVChanging(value);
					this.SendPropertyChanging();
					this._TenNV = value;
					this.SendPropertyChanged("TenNV");
					this.OnTenNVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GioiTinhNV", DbType="NVarChar(50)")]
		public string GioiTinhNV
		{
			get
			{
				return this._GioiTinhNV;
			}
			set
			{
				if ((this._GioiTinhNV != value))
				{
					this.OnGioiTinhNVChanging(value);
					this.SendPropertyChanging();
					this._GioiTinhNV = value;
					this.SendPropertyChanged("GioiTinhNV");
					this.OnGioiTinhNVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SDTNV", DbType="NVarChar(50)")]
		public string SDTNV
		{
			get
			{
				return this._SDTNV;
			}
			set
			{
				if ((this._SDTNV != value))
				{
					this.OnSDTNVChanging(value);
					this.SendPropertyChanging();
					this._SDTNV = value;
					this.SendPropertyChanged("SDTNV");
					this.OnSDTNVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiaChiNV", DbType="NVarChar(50)")]
		public string DiaChiNV
		{
			get
			{
				return this._DiaChiNV;
			}
			set
			{
				if ((this._DiaChiNV != value))
				{
					this.OnDiaChiNVChanging(value);
					this.SendPropertyChanging();
					this._DiaChiNV = value;
					this.SendPropertyChanged("DiaChiNV");
					this.OnDiaChiNVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_XepLoaiNV", DbType="NVarChar(50)")]
		public string XepLoaiNV
		{
			get
			{
				return this._XepLoaiNV;
			}
			set
			{
				if ((this._XepLoaiNV != value))
				{
					this.OnXepLoaiNVChanging(value);
					this.SendPropertyChanging();
					this._XepLoaiNV = value;
					this.SendPropertyChanged("XepLoaiNV");
					this.OnXepLoaiNVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MatKhau", DbType="NVarChar(50)")]
		public string MatKhau
		{
			get
			{
				return this._MatKhau;
			}
			set
			{
				if ((this._MatKhau != value))
				{
					this.OnMatKhauChanging(value);
					this.SendPropertyChanging();
					this._MatKhau = value;
					this.SendPropertyChanged("MatKhau");
					this.OnMatKhauChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Quyen", DbType="NVarChar(50)")]
		public string Quyen
		{
			get
			{
				return this._Quyen;
			}
			set
			{
				if ((this._Quyen != value))
				{
					this.OnQuyenChanging(value);
					this.SendPropertyChanging();
					this._Quyen = value;
					this.SendPropertyChanged("Quyen");
					this.OnQuyenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NHANVIEN_HOADON", Storage="_HOADONs", ThisKey="MaNV", OtherKey="MaNV")]
		public EntitySet<HOADON> HOADONs
		{
			get
			{
				return this._HOADONs;
			}
			set
			{
				this._HOADONs.Assign(value);
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
		
		private void attach_HOADONs(HOADON entity)
		{
			this.SendPropertyChanging();
			entity.NHANVIEN = this;
		}
		
		private void detach_HOADONs(HOADON entity)
		{
			this.SendPropertyChanging();
			entity.NHANVIEN = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.NHAPHANPHOI")]
	public partial class NHAPHANPHOI : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaNPP;
		
		private string _TenNPP;
		
		private string _SDTNPP;
		
		private string _DiaChiNPP;
		
		private EntitySet<HOADON> _HOADONs;
		
		private EntitySet<SANPHAM> _SANPHAMs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaNPPChanging(int value);
    partial void OnMaNPPChanged();
    partial void OnTenNPPChanging(string value);
    partial void OnTenNPPChanged();
    partial void OnSDTNPPChanging(string value);
    partial void OnSDTNPPChanged();
    partial void OnDiaChiNPPChanging(string value);
    partial void OnDiaChiNPPChanged();
    #endregion
		
		public NHAPHANPHOI()
		{
			this._HOADONs = new EntitySet<HOADON>(new Action<HOADON>(this.attach_HOADONs), new Action<HOADON>(this.detach_HOADONs));
			this._SANPHAMs = new EntitySet<SANPHAM>(new Action<SANPHAM>(this.attach_SANPHAMs), new Action<SANPHAM>(this.detach_SANPHAMs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaNPP", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int MaNPP
		{
			get
			{
				return this._MaNPP;
			}
			set
			{
				if ((this._MaNPP != value))
				{
					this.OnMaNPPChanging(value);
					this.SendPropertyChanging();
					this._MaNPP = value;
					this.SendPropertyChanged("MaNPP");
					this.OnMaNPPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenNPP", DbType="NVarChar(50)")]
		public string TenNPP
		{
			get
			{
				return this._TenNPP;
			}
			set
			{
				if ((this._TenNPP != value))
				{
					this.OnTenNPPChanging(value);
					this.SendPropertyChanging();
					this._TenNPP = value;
					this.SendPropertyChanged("TenNPP");
					this.OnTenNPPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SDTNPP", DbType="NVarChar(50)")]
		public string SDTNPP
		{
			get
			{
				return this._SDTNPP;
			}
			set
			{
				if ((this._SDTNPP != value))
				{
					this.OnSDTNPPChanging(value);
					this.SendPropertyChanging();
					this._SDTNPP = value;
					this.SendPropertyChanged("SDTNPP");
					this.OnSDTNPPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiaChiNPP", DbType="NVarChar(50)")]
		public string DiaChiNPP
		{
			get
			{
				return this._DiaChiNPP;
			}
			set
			{
				if ((this._DiaChiNPP != value))
				{
					this.OnDiaChiNPPChanging(value);
					this.SendPropertyChanging();
					this._DiaChiNPP = value;
					this.SendPropertyChanged("DiaChiNPP");
					this.OnDiaChiNPPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NHAPHANPHOI_HOADON", Storage="_HOADONs", ThisKey="MaNPP", OtherKey="MaNPP")]
		public EntitySet<HOADON> HOADONs
		{
			get
			{
				return this._HOADONs;
			}
			set
			{
				this._HOADONs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NHAPHANPHOI_SANPHAM", Storage="_SANPHAMs", ThisKey="MaNPP", OtherKey="MaNPP")]
		public EntitySet<SANPHAM> SANPHAMs
		{
			get
			{
				return this._SANPHAMs;
			}
			set
			{
				this._SANPHAMs.Assign(value);
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
		
		private void attach_HOADONs(HOADON entity)
		{
			this.SendPropertyChanging();
			entity.NHAPHANPHOI = this;
		}
		
		private void detach_HOADONs(HOADON entity)
		{
			this.SendPropertyChanging();
			entity.NHAPHANPHOI = null;
		}
		
		private void attach_SANPHAMs(SANPHAM entity)
		{
			this.SendPropertyChanging();
			entity.NHAPHANPHOI = this;
		}
		
		private void detach_SANPHAMs(SANPHAM entity)
		{
			this.SendPropertyChanging();
			entity.NHAPHANPHOI = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SANPHAM")]
	public partial class SANPHAM : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaSP;
		
		private System.Nullable<int> _MaNPP;
		
		private string _TenSP;
		
		private string _MauSP;
		
		private System.Nullable<int> _GiaSP;
		
		private EntitySet<HOADON> _HOADONs;
		
		private EntityRef<NHAPHANPHOI> _NHAPHANPHOI;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaSPChanging(int value);
    partial void OnMaSPChanged();
    partial void OnMaNPPChanging(System.Nullable<int> value);
    partial void OnMaNPPChanged();
    partial void OnTenSPChanging(string value);
    partial void OnTenSPChanged();
    partial void OnMauSPChanging(string value);
    partial void OnMauSPChanged();
    partial void OnGiaSPChanging(System.Nullable<int> value);
    partial void OnGiaSPChanged();
    #endregion
		
		public SANPHAM()
		{
			this._HOADONs = new EntitySet<HOADON>(new Action<HOADON>(this.attach_HOADONs), new Action<HOADON>(this.detach_HOADONs));
			this._NHAPHANPHOI = default(EntityRef<NHAPHANPHOI>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaSP", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int MaSP
		{
			get
			{
				return this._MaSP;
			}
			set
			{
				if ((this._MaSP != value))
				{
					this.OnMaSPChanging(value);
					this.SendPropertyChanging();
					this._MaSP = value;
					this.SendPropertyChanged("MaSP");
					this.OnMaSPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaNPP", DbType="Int")]
		public System.Nullable<int> MaNPP
		{
			get
			{
				return this._MaNPP;
			}
			set
			{
				if ((this._MaNPP != value))
				{
					if (this._NHAPHANPHOI.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaNPPChanging(value);
					this.SendPropertyChanging();
					this._MaNPP = value;
					this.SendPropertyChanged("MaNPP");
					this.OnMaNPPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenSP", DbType="NVarChar(50)")]
		public string TenSP
		{
			get
			{
				return this._TenSP;
			}
			set
			{
				if ((this._TenSP != value))
				{
					this.OnTenSPChanging(value);
					this.SendPropertyChanging();
					this._TenSP = value;
					this.SendPropertyChanged("TenSP");
					this.OnTenSPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MauSP", DbType="NVarChar(50)")]
		public string MauSP
		{
			get
			{
				return this._MauSP;
			}
			set
			{
				if ((this._MauSP != value))
				{
					this.OnMauSPChanging(value);
					this.SendPropertyChanging();
					this._MauSP = value;
					this.SendPropertyChanged("MauSP");
					this.OnMauSPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GiaSP", DbType="Int")]
		public System.Nullable<int> GiaSP
		{
			get
			{
				return this._GiaSP;
			}
			set
			{
				if ((this._GiaSP != value))
				{
					this.OnGiaSPChanging(value);
					this.SendPropertyChanging();
					this._GiaSP = value;
					this.SendPropertyChanged("GiaSP");
					this.OnGiaSPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="SANPHAM_HOADON", Storage="_HOADONs", ThisKey="MaSP", OtherKey="MaSP")]
		public EntitySet<HOADON> HOADONs
		{
			get
			{
				return this._HOADONs;
			}
			set
			{
				this._HOADONs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NHAPHANPHOI_SANPHAM", Storage="_NHAPHANPHOI", ThisKey="MaNPP", OtherKey="MaNPP", IsForeignKey=true)]
		public NHAPHANPHOI NHAPHANPHOI
		{
			get
			{
				return this._NHAPHANPHOI.Entity;
			}
			set
			{
				NHAPHANPHOI previousValue = this._NHAPHANPHOI.Entity;
				if (((previousValue != value) 
							|| (this._NHAPHANPHOI.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._NHAPHANPHOI.Entity = null;
						previousValue.SANPHAMs.Remove(this);
					}
					this._NHAPHANPHOI.Entity = value;
					if ((value != null))
					{
						value.SANPHAMs.Add(this);
						this._MaNPP = value.MaNPP;
					}
					else
					{
						this._MaNPP = default(Nullable<int>);
					}
					this.SendPropertyChanged("NHAPHANPHOI");
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
		
		private void attach_HOADONs(HOADON entity)
		{
			this.SendPropertyChanging();
			entity.SANPHAM = this;
		}
		
		private void detach_HOADONs(HOADON entity)
		{
			this.SendPropertyChanging();
			entity.SANPHAM = null;
		}
	}
}
#pragma warning restore 1591
