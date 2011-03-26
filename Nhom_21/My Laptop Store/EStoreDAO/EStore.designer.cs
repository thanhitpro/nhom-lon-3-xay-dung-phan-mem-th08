﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4927
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EStoreDAO
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
	
	
	[System.Data.Linq.Mapping.DatabaseAttribute(Name="ESTORE")]
	public partial class EStoreDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertKHACHHANG(KHACHHANG instance);
    partial void UpdateKHACHHANG(KHACHHANG instance);
    partial void DeleteKHACHHANG(KHACHHANG instance);
    partial void InsertNHASANXUAT(NHASANXUAT instance);
    partial void UpdateNHASANXUAT(NHASANXUAT instance);
    partial void DeleteNHASANXUAT(NHASANXUAT instance);
    partial void InsertCHITIETDONGLAPTOP(CHITIETDONGLAPTOP instance);
    partial void UpdateCHITIETDONGLAPTOP(CHITIETDONGLAPTOP instance);
    partial void DeleteCHITIETDONGLAPTOP(CHITIETDONGLAPTOP instance);
    #endregion
		
		public EStoreDataContext() : 
				base(global::EStoreDAO.Properties.Settings.Default.ESTOREConnectionString4, mappingSource)
		{
			OnCreated();
		}
		
		public EStoreDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public EStoreDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public EStoreDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public EStoreDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<KHACHHANG> KHACHHANGs
		{
			get
			{
				return this.GetTable<KHACHHANG>();
			}
		}
		
		public System.Data.Linq.Table<NHASANXUAT> NHASANXUATs
		{
			get
			{
				return this.GetTable<NHASANXUAT>();
			}
		}
		
		public System.Data.Linq.Table<CHITIETDONGLAPTOP> CHITIETDONGLAPTOPs
		{
			get
			{
				return this.GetTable<CHITIETDONGLAPTOP>();
			}
		}
	}
	
	[Table(Name="dbo.KHACHHANG")]
	public partial class KHACHHANG : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaKhachHang;
		
		private string _TenKhachHang;
		
		private System.DateTime _NgaySinh;
		
		private string _CMND;
		
		private string _GioiTinh;
		
		private string _DiaChi;
		
		private string _Email;
		
		private string _SoDienThoai;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaKhachHangChanging(int value);
    partial void OnMaKhachHangChanged();
    partial void OnTenKhachHangChanging(string value);
    partial void OnTenKhachHangChanged();
    partial void OnNgaySinhChanging(System.DateTime value);
    partial void OnNgaySinhChanged();
    partial void OnCMNDChanging(string value);
    partial void OnCMNDChanged();
    partial void OnGioiTinhChanging(string value);
    partial void OnGioiTinhChanged();
    partial void OnDiaChiChanging(string value);
    partial void OnDiaChiChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnSoDienThoaiChanging(string value);
    partial void OnSoDienThoaiChanged();
    #endregion
		
		public KHACHHANG()
		{
			OnCreated();
		}
		
		[Column(Storage="_MaKhachHang", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaKhachHang
		{
			get
			{
				return this._MaKhachHang;
			}
			set
			{
				if ((this._MaKhachHang != value))
				{
					this.OnMaKhachHangChanging(value);
					this.SendPropertyChanging();
					this._MaKhachHang = value;
					this.SendPropertyChanged("MaKhachHang");
					this.OnMaKhachHangChanged();
				}
			}
		}
		
		[Column(Storage="_TenKhachHang", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string TenKhachHang
		{
			get
			{
				return this._TenKhachHang;
			}
			set
			{
				if ((this._TenKhachHang != value))
				{
					this.OnTenKhachHangChanging(value);
					this.SendPropertyChanging();
					this._TenKhachHang = value;
					this.SendPropertyChanged("TenKhachHang");
					this.OnTenKhachHangChanged();
				}
			}
		}
		
		[Column(Storage="_NgaySinh", DbType="DateTime NOT NULL")]
		public System.DateTime NgaySinh
		{
			get
			{
				return this._NgaySinh;
			}
			set
			{
				if ((this._NgaySinh != value))
				{
					this.OnNgaySinhChanging(value);
					this.SendPropertyChanging();
					this._NgaySinh = value;
					this.SendPropertyChanged("NgaySinh");
					this.OnNgaySinhChanged();
				}
			}
		}
		
		[Column(Storage="_CMND", DbType="NVarChar(9)")]
		public string CMND
		{
			get
			{
				return this._CMND;
			}
			set
			{
				if ((this._CMND != value))
				{
					this.OnCMNDChanging(value);
					this.SendPropertyChanging();
					this._CMND = value;
					this.SendPropertyChanged("CMND");
					this.OnCMNDChanged();
				}
			}
		}
		
		[Column(Storage="_GioiTinh", DbType="NVarChar(5) NOT NULL", CanBeNull=false)]
		public string GioiTinh
		{
			get
			{
				return this._GioiTinh;
			}
			set
			{
				if ((this._GioiTinh != value))
				{
					this.OnGioiTinhChanging(value);
					this.SendPropertyChanging();
					this._GioiTinh = value;
					this.SendPropertyChanged("GioiTinh");
					this.OnGioiTinhChanged();
				}
			}
		}
		
		[Column(Storage="_DiaChi", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string DiaChi
		{
			get
			{
				return this._DiaChi;
			}
			set
			{
				if ((this._DiaChi != value))
				{
					this.OnDiaChiChanging(value);
					this.SendPropertyChanging();
					this._DiaChi = value;
					this.SendPropertyChanged("DiaChi");
					this.OnDiaChiChanged();
				}
			}
		}
		
		[Column(Storage="_Email", DbType="NVarChar(30)")]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[Column(Storage="_SoDienThoai", DbType="NVarChar(11) NOT NULL", CanBeNull=false)]
		public string SoDienThoai
		{
			get
			{
				return this._SoDienThoai;
			}
			set
			{
				if ((this._SoDienThoai != value))
				{
					this.OnSoDienThoaiChanging(value);
					this.SendPropertyChanging();
					this._SoDienThoai = value;
					this.SendPropertyChanged("SoDienThoai");
					this.OnSoDienThoaiChanged();
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
	
	[Table(Name="dbo.NHASANXUAT")]
	public partial class NHASANXUAT : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaNhaSanXuat;
		
		private string _TenNhaSanXuat;
		
		private EntitySet<CHITIETDONGLAPTOP> _CHITIETDONGLAPTOPs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaNhaSanXuatChanging(int value);
    partial void OnMaNhaSanXuatChanged();
    partial void OnTenNhaSanXuatChanging(string value);
    partial void OnTenNhaSanXuatChanged();
    #endregion
		
		public NHASANXUAT()
		{
			this._CHITIETDONGLAPTOPs = new EntitySet<CHITIETDONGLAPTOP>(new Action<CHITIETDONGLAPTOP>(this.attach_CHITIETDONGLAPTOPs), new Action<CHITIETDONGLAPTOP>(this.detach_CHITIETDONGLAPTOPs));
			OnCreated();
		}
		
		[Column(Storage="_MaNhaSanXuat", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaNhaSanXuat
		{
			get
			{
				return this._MaNhaSanXuat;
			}
			set
			{
				if ((this._MaNhaSanXuat != value))
				{
					this.OnMaNhaSanXuatChanging(value);
					this.SendPropertyChanging();
					this._MaNhaSanXuat = value;
					this.SendPropertyChanged("MaNhaSanXuat");
					this.OnMaNhaSanXuatChanged();
				}
			}
		}
		
		[Column(Storage="_TenNhaSanXuat", DbType="NVarChar(30) NOT NULL", CanBeNull=false)]
		public string TenNhaSanXuat
		{
			get
			{
				return this._TenNhaSanXuat;
			}
			set
			{
				if ((this._TenNhaSanXuat != value))
				{
					this.OnTenNhaSanXuatChanging(value);
					this.SendPropertyChanging();
					this._TenNhaSanXuat = value;
					this.SendPropertyChanged("TenNhaSanXuat");
					this.OnTenNhaSanXuatChanged();
				}
			}
		}
		
		[Association(Name="NHASANXUAT_CHITIETDONGLAPTOP", Storage="_CHITIETDONGLAPTOPs", ThisKey="MaNhaSanXuat", OtherKey="MaNhaSanXuat")]
		public EntitySet<CHITIETDONGLAPTOP> CHITIETDONGLAPTOPs
		{
			get
			{
				return this._CHITIETDONGLAPTOPs;
			}
			set
			{
				this._CHITIETDONGLAPTOPs.Assign(value);
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
		
		private void attach_CHITIETDONGLAPTOPs(CHITIETDONGLAPTOP entity)
		{
			this.SendPropertyChanging();
			entity.NHASANXUAT = this;
		}
		
		private void detach_CHITIETDONGLAPTOPs(CHITIETDONGLAPTOP entity)
		{
			this.SendPropertyChanging();
			entity.NHASANXUAT = null;
		}
	}
	
	[Table(Name="dbo.CHITIETDONGLAPTOP")]
	public partial class CHITIETDONGLAPTOP : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaDongLapTop;
		
		private string _TenChiTietDongLapTop;
		
		private System.Nullable<int> _MaDongRAM;
		
		private System.Nullable<int> _MaDongCPU;
		
		private System.Nullable<int> _MaDongOCung;
		
		private System.Nullable<int> _MaDongManHinh;
		
		private System.Nullable<int> _MaDongCardDoHoa;
		
		private System.Nullable<int> _MaDongLoa;
		
		private System.Nullable<int> _MaDongODiaQuang;
		
		private System.Nullable<int> _MaDongCardMang;
		
		private System.Nullable<int> _MaDongCardReader;
		
		private System.Nullable<int> _MaDongWebCam;
		
		private System.Nullable<int> _MaDongPin;
		
		private System.Nullable<int> _MaHeDieuHanh;
		
		private System.Nullable<int> _MaChiTietTrongLuong;
		
		private System.Nullable<bool> _FingerprintReader;
		
		private System.Nullable<bool> _HDMI;
		
		private System.Nullable<int> _SoLuongCongUSB;
		
		private System.Nullable<int> _MaNhaSanXuat;
		
		private System.Nullable<int> _MaDanhGia;
		
		private System.Nullable<double> _GiaBanHienHanh;
		
		private string _MoTaThem;
		
		private System.Nullable<int> _SoLuongNhap;
		
		private System.Nullable<int> _SoLuongConLai;
		
		private System.Nullable<int> _ThoiGianBaoHanh;
		
		private string _HinhAnh;
		
		private string _MauSac;
		
		private EntityRef<NHASANXUAT> _NHASANXUAT;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaDongLapTopChanging(int value);
    partial void OnMaDongLapTopChanged();
    partial void OnTenChiTietDongLapTopChanging(string value);
    partial void OnTenChiTietDongLapTopChanged();
    partial void OnMaDongRAMChanging(System.Nullable<int> value);
    partial void OnMaDongRAMChanged();
    partial void OnMaDongCPUChanging(System.Nullable<int> value);
    partial void OnMaDongCPUChanged();
    partial void OnMaDongOCungChanging(System.Nullable<int> value);
    partial void OnMaDongOCungChanged();
    partial void OnMaDongManHinhChanging(System.Nullable<int> value);
    partial void OnMaDongManHinhChanged();
    partial void OnMaDongCardDoHoaChanging(System.Nullable<int> value);
    partial void OnMaDongCardDoHoaChanged();
    partial void OnMaDongLoaChanging(System.Nullable<int> value);
    partial void OnMaDongLoaChanged();
    partial void OnMaDongODiaQuangChanging(System.Nullable<int> value);
    partial void OnMaDongODiaQuangChanged();
    partial void OnMaDongCardMangChanging(System.Nullable<int> value);
    partial void OnMaDongCardMangChanged();
    partial void OnMaDongCardReaderChanging(System.Nullable<int> value);
    partial void OnMaDongCardReaderChanged();
    partial void OnMaDongWebCamChanging(System.Nullable<int> value);
    partial void OnMaDongWebCamChanged();
    partial void OnMaDongPinChanging(System.Nullable<int> value);
    partial void OnMaDongPinChanged();
    partial void OnMaHeDieuHanhChanging(System.Nullable<int> value);
    partial void OnMaHeDieuHanhChanged();
    partial void OnMaChiTietTrongLuongChanging(System.Nullable<int> value);
    partial void OnMaChiTietTrongLuongChanged();
    partial void OnFingerprintReaderChanging(System.Nullable<bool> value);
    partial void OnFingerprintReaderChanged();
    partial void OnHDMIChanging(System.Nullable<bool> value);
    partial void OnHDMIChanged();
    partial void OnSoLuongCongUSBChanging(System.Nullable<int> value);
    partial void OnSoLuongCongUSBChanged();
    partial void OnMaNhaSanXuatChanging(System.Nullable<int> value);
    partial void OnMaNhaSanXuatChanged();
    partial void OnMaDanhGiaChanging(System.Nullable<int> value);
    partial void OnMaDanhGiaChanged();
    partial void OnGiaBanHienHanhChanging(System.Nullable<double> value);
    partial void OnGiaBanHienHanhChanged();
    partial void OnMoTaThemChanging(string value);
    partial void OnMoTaThemChanged();
    partial void OnSoLuongNhapChanging(System.Nullable<int> value);
    partial void OnSoLuongNhapChanged();
    partial void OnSoLuongConLaiChanging(System.Nullable<int> value);
    partial void OnSoLuongConLaiChanged();
    partial void OnThoiGianBaoHanhChanging(System.Nullable<int> value);
    partial void OnThoiGianBaoHanhChanged();
    partial void OnHinhAnhChanging(string value);
    partial void OnHinhAnhChanged();
    partial void OnMauSacChanging(string value);
    partial void OnMauSacChanged();
    #endregion
		
		public CHITIETDONGLAPTOP()
		{
			this._NHASANXUAT = default(EntityRef<NHASANXUAT>);
			OnCreated();
		}
		
		[Column(Storage="_MaDongLapTop", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaDongLapTop
		{
			get
			{
				return this._MaDongLapTop;
			}
			set
			{
				if ((this._MaDongLapTop != value))
				{
					this.OnMaDongLapTopChanging(value);
					this.SendPropertyChanging();
					this._MaDongLapTop = value;
					this.SendPropertyChanged("MaDongLapTop");
					this.OnMaDongLapTopChanged();
				}
			}
		}
		
		[Column(Storage="_TenChiTietDongLapTop", DbType="NVarChar(30)")]
		public string TenChiTietDongLapTop
		{
			get
			{
				return this._TenChiTietDongLapTop;
			}
			set
			{
				if ((this._TenChiTietDongLapTop != value))
				{
					this.OnTenChiTietDongLapTopChanging(value);
					this.SendPropertyChanging();
					this._TenChiTietDongLapTop = value;
					this.SendPropertyChanged("TenChiTietDongLapTop");
					this.OnTenChiTietDongLapTopChanged();
				}
			}
		}
		
		[Column(Storage="_MaDongRAM", DbType="Int")]
		public System.Nullable<int> MaDongRAM
		{
			get
			{
				return this._MaDongRAM;
			}
			set
			{
				if ((this._MaDongRAM != value))
				{
					this.OnMaDongRAMChanging(value);
					this.SendPropertyChanging();
					this._MaDongRAM = value;
					this.SendPropertyChanged("MaDongRAM");
					this.OnMaDongRAMChanged();
				}
			}
		}
		
		[Column(Storage="_MaDongCPU", DbType="Int")]
		public System.Nullable<int> MaDongCPU
		{
			get
			{
				return this._MaDongCPU;
			}
			set
			{
				if ((this._MaDongCPU != value))
				{
					this.OnMaDongCPUChanging(value);
					this.SendPropertyChanging();
					this._MaDongCPU = value;
					this.SendPropertyChanged("MaDongCPU");
					this.OnMaDongCPUChanged();
				}
			}
		}
		
		[Column(Storage="_MaDongOCung", DbType="Int")]
		public System.Nullable<int> MaDongOCung
		{
			get
			{
				return this._MaDongOCung;
			}
			set
			{
				if ((this._MaDongOCung != value))
				{
					this.OnMaDongOCungChanging(value);
					this.SendPropertyChanging();
					this._MaDongOCung = value;
					this.SendPropertyChanged("MaDongOCung");
					this.OnMaDongOCungChanged();
				}
			}
		}
		
		[Column(Storage="_MaDongManHinh", DbType="Int")]
		public System.Nullable<int> MaDongManHinh
		{
			get
			{
				return this._MaDongManHinh;
			}
			set
			{
				if ((this._MaDongManHinh != value))
				{
					this.OnMaDongManHinhChanging(value);
					this.SendPropertyChanging();
					this._MaDongManHinh = value;
					this.SendPropertyChanged("MaDongManHinh");
					this.OnMaDongManHinhChanged();
				}
			}
		}
		
		[Column(Storage="_MaDongCardDoHoa", DbType="Int")]
		public System.Nullable<int> MaDongCardDoHoa
		{
			get
			{
				return this._MaDongCardDoHoa;
			}
			set
			{
				if ((this._MaDongCardDoHoa != value))
				{
					this.OnMaDongCardDoHoaChanging(value);
					this.SendPropertyChanging();
					this._MaDongCardDoHoa = value;
					this.SendPropertyChanged("MaDongCardDoHoa");
					this.OnMaDongCardDoHoaChanged();
				}
			}
		}
		
		[Column(Storage="_MaDongLoa", DbType="Int")]
		public System.Nullable<int> MaDongLoa
		{
			get
			{
				return this._MaDongLoa;
			}
			set
			{
				if ((this._MaDongLoa != value))
				{
					this.OnMaDongLoaChanging(value);
					this.SendPropertyChanging();
					this._MaDongLoa = value;
					this.SendPropertyChanged("MaDongLoa");
					this.OnMaDongLoaChanged();
				}
			}
		}
		
		[Column(Storage="_MaDongODiaQuang", DbType="Int")]
		public System.Nullable<int> MaDongODiaQuang
		{
			get
			{
				return this._MaDongODiaQuang;
			}
			set
			{
				if ((this._MaDongODiaQuang != value))
				{
					this.OnMaDongODiaQuangChanging(value);
					this.SendPropertyChanging();
					this._MaDongODiaQuang = value;
					this.SendPropertyChanged("MaDongODiaQuang");
					this.OnMaDongODiaQuangChanged();
				}
			}
		}
		
		[Column(Storage="_MaDongCardMang", DbType="Int")]
		public System.Nullable<int> MaDongCardMang
		{
			get
			{
				return this._MaDongCardMang;
			}
			set
			{
				if ((this._MaDongCardMang != value))
				{
					this.OnMaDongCardMangChanging(value);
					this.SendPropertyChanging();
					this._MaDongCardMang = value;
					this.SendPropertyChanged("MaDongCardMang");
					this.OnMaDongCardMangChanged();
				}
			}
		}
		
		[Column(Storage="_MaDongCardReader", DbType="Int")]
		public System.Nullable<int> MaDongCardReader
		{
			get
			{
				return this._MaDongCardReader;
			}
			set
			{
				if ((this._MaDongCardReader != value))
				{
					this.OnMaDongCardReaderChanging(value);
					this.SendPropertyChanging();
					this._MaDongCardReader = value;
					this.SendPropertyChanged("MaDongCardReader");
					this.OnMaDongCardReaderChanged();
				}
			}
		}
		
		[Column(Storage="_MaDongWebCam", DbType="Int")]
		public System.Nullable<int> MaDongWebCam
		{
			get
			{
				return this._MaDongWebCam;
			}
			set
			{
				if ((this._MaDongWebCam != value))
				{
					this.OnMaDongWebCamChanging(value);
					this.SendPropertyChanging();
					this._MaDongWebCam = value;
					this.SendPropertyChanged("MaDongWebCam");
					this.OnMaDongWebCamChanged();
				}
			}
		}
		
		[Column(Storage="_MaDongPin", DbType="Int")]
		public System.Nullable<int> MaDongPin
		{
			get
			{
				return this._MaDongPin;
			}
			set
			{
				if ((this._MaDongPin != value))
				{
					this.OnMaDongPinChanging(value);
					this.SendPropertyChanging();
					this._MaDongPin = value;
					this.SendPropertyChanged("MaDongPin");
					this.OnMaDongPinChanged();
				}
			}
		}
		
		[Column(Storage="_MaHeDieuHanh", DbType="Int")]
		public System.Nullable<int> MaHeDieuHanh
		{
			get
			{
				return this._MaHeDieuHanh;
			}
			set
			{
				if ((this._MaHeDieuHanh != value))
				{
					this.OnMaHeDieuHanhChanging(value);
					this.SendPropertyChanging();
					this._MaHeDieuHanh = value;
					this.SendPropertyChanged("MaHeDieuHanh");
					this.OnMaHeDieuHanhChanged();
				}
			}
		}
		
		[Column(Storage="_MaChiTietTrongLuong", DbType="Int")]
		public System.Nullable<int> MaChiTietTrongLuong
		{
			get
			{
				return this._MaChiTietTrongLuong;
			}
			set
			{
				if ((this._MaChiTietTrongLuong != value))
				{
					this.OnMaChiTietTrongLuongChanging(value);
					this.SendPropertyChanging();
					this._MaChiTietTrongLuong = value;
					this.SendPropertyChanged("MaChiTietTrongLuong");
					this.OnMaChiTietTrongLuongChanged();
				}
			}
		}
		
		[Column(Storage="_FingerprintReader", DbType="Bit")]
		public System.Nullable<bool> FingerprintReader
		{
			get
			{
				return this._FingerprintReader;
			}
			set
			{
				if ((this._FingerprintReader != value))
				{
					this.OnFingerprintReaderChanging(value);
					this.SendPropertyChanging();
					this._FingerprintReader = value;
					this.SendPropertyChanged("FingerprintReader");
					this.OnFingerprintReaderChanged();
				}
			}
		}
		
		[Column(Storage="_HDMI", DbType="Bit")]
		public System.Nullable<bool> HDMI
		{
			get
			{
				return this._HDMI;
			}
			set
			{
				if ((this._HDMI != value))
				{
					this.OnHDMIChanging(value);
					this.SendPropertyChanging();
					this._HDMI = value;
					this.SendPropertyChanged("HDMI");
					this.OnHDMIChanged();
				}
			}
		}
		
		[Column(Storage="_SoLuongCongUSB", DbType="Int")]
		public System.Nullable<int> SoLuongCongUSB
		{
			get
			{
				return this._SoLuongCongUSB;
			}
			set
			{
				if ((this._SoLuongCongUSB != value))
				{
					this.OnSoLuongCongUSBChanging(value);
					this.SendPropertyChanging();
					this._SoLuongCongUSB = value;
					this.SendPropertyChanged("SoLuongCongUSB");
					this.OnSoLuongCongUSBChanged();
				}
			}
		}
		
		[Column(Storage="_MaNhaSanXuat", DbType="Int")]
		public System.Nullable<int> MaNhaSanXuat
		{
			get
			{
				return this._MaNhaSanXuat;
			}
			set
			{
				if ((this._MaNhaSanXuat != value))
				{
					if (this._NHASANXUAT.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaNhaSanXuatChanging(value);
					this.SendPropertyChanging();
					this._MaNhaSanXuat = value;
					this.SendPropertyChanged("MaNhaSanXuat");
					this.OnMaNhaSanXuatChanged();
				}
			}
		}
		
		[Column(Storage="_MaDanhGia", DbType="Int")]
		public System.Nullable<int> MaDanhGia
		{
			get
			{
				return this._MaDanhGia;
			}
			set
			{
				if ((this._MaDanhGia != value))
				{
					this.OnMaDanhGiaChanging(value);
					this.SendPropertyChanging();
					this._MaDanhGia = value;
					this.SendPropertyChanged("MaDanhGia");
					this.OnMaDanhGiaChanged();
				}
			}
		}
		
		[Column(Storage="_GiaBanHienHanh", DbType="Float")]
		public System.Nullable<double> GiaBanHienHanh
		{
			get
			{
				return this._GiaBanHienHanh;
			}
			set
			{
				if ((this._GiaBanHienHanh != value))
				{
					this.OnGiaBanHienHanhChanging(value);
					this.SendPropertyChanging();
					this._GiaBanHienHanh = value;
					this.SendPropertyChanged("GiaBanHienHanh");
					this.OnGiaBanHienHanhChanged();
				}
			}
		}
		
		[Column(Storage="_MoTaThem", DbType="NVarChar(512)")]
		public string MoTaThem
		{
			get
			{
				return this._MoTaThem;
			}
			set
			{
				if ((this._MoTaThem != value))
				{
					this.OnMoTaThemChanging(value);
					this.SendPropertyChanging();
					this._MoTaThem = value;
					this.SendPropertyChanged("MoTaThem");
					this.OnMoTaThemChanged();
				}
			}
		}
		
		[Column(Storage="_SoLuongNhap", DbType="Int")]
		public System.Nullable<int> SoLuongNhap
		{
			get
			{
				return this._SoLuongNhap;
			}
			set
			{
				if ((this._SoLuongNhap != value))
				{
					this.OnSoLuongNhapChanging(value);
					this.SendPropertyChanging();
					this._SoLuongNhap = value;
					this.SendPropertyChanged("SoLuongNhap");
					this.OnSoLuongNhapChanged();
				}
			}
		}
		
		[Column(Storage="_SoLuongConLai", DbType="Int")]
		public System.Nullable<int> SoLuongConLai
		{
			get
			{
				return this._SoLuongConLai;
			}
			set
			{
				if ((this._SoLuongConLai != value))
				{
					this.OnSoLuongConLaiChanging(value);
					this.SendPropertyChanging();
					this._SoLuongConLai = value;
					this.SendPropertyChanged("SoLuongConLai");
					this.OnSoLuongConLaiChanged();
				}
			}
		}
		
		[Column(Storage="_ThoiGianBaoHanh", DbType="Int")]
		public System.Nullable<int> ThoiGianBaoHanh
		{
			get
			{
				return this._ThoiGianBaoHanh;
			}
			set
			{
				if ((this._ThoiGianBaoHanh != value))
				{
					this.OnThoiGianBaoHanhChanging(value);
					this.SendPropertyChanging();
					this._ThoiGianBaoHanh = value;
					this.SendPropertyChanged("ThoiGianBaoHanh");
					this.OnThoiGianBaoHanhChanged();
				}
			}
		}
		
		[Column(Storage="_HinhAnh", DbType="NVarChar(256)")]
		public string HinhAnh
		{
			get
			{
				return this._HinhAnh;
			}
			set
			{
				if ((this._HinhAnh != value))
				{
					this.OnHinhAnhChanging(value);
					this.SendPropertyChanging();
					this._HinhAnh = value;
					this.SendPropertyChanged("HinhAnh");
					this.OnHinhAnhChanged();
				}
			}
		}
		
		[Column(Storage="_MauSac", DbType="NVarChar(30)")]
		public string MauSac
		{
			get
			{
				return this._MauSac;
			}
			set
			{
				if ((this._MauSac != value))
				{
					this.OnMauSacChanging(value);
					this.SendPropertyChanging();
					this._MauSac = value;
					this.SendPropertyChanged("MauSac");
					this.OnMauSacChanged();
				}
			}
		}
		
		[Association(Name="NHASANXUAT_CHITIETDONGLAPTOP", Storage="_NHASANXUAT", ThisKey="MaNhaSanXuat", OtherKey="MaNhaSanXuat", IsForeignKey=true)]
		public NHASANXUAT NHASANXUAT
		{
			get
			{
				return this._NHASANXUAT.Entity;
			}
			set
			{
				NHASANXUAT previousValue = this._NHASANXUAT.Entity;
				if (((previousValue != value) 
							|| (this._NHASANXUAT.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._NHASANXUAT.Entity = null;
						previousValue.CHITIETDONGLAPTOPs.Remove(this);
					}
					this._NHASANXUAT.Entity = value;
					if ((value != null))
					{
						value.CHITIETDONGLAPTOPs.Add(this);
						this._MaNhaSanXuat = value.MaNhaSanXuat;
					}
					else
					{
						this._MaNhaSanXuat = default(Nullable<int>);
					}
					this.SendPropertyChanged("NHASANXUAT");
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
