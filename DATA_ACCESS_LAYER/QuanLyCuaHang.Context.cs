﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DATA_ACCESS_LAYER
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QUANLYCUAHANGEntities : DbContext
    {
        public QUANLYCUAHANGEntities()
            : base("name=QUANLYCUAHANGEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BANG_BLOCK> BANG_BLOCK { get; set; }
        public virtual DbSet<BANG_CATEGORY> BANG_CATEGORY { get; set; }
        public virtual DbSet<BANG_CHITIETHOADON> BANG_CHITIETHOADON { get; set; }
        public virtual DbSet<BANG_DETAIL> BANG_DETAIL { get; set; }
        public virtual DbSet<BANG_HISTORY> BANG_HISTORY { get; set; }
        public virtual DbSet<BANG_HOADON> BANG_HOADON { get; set; }
        public virtual DbSet<BANG_KHACHHANG> BANG_KHACHHANG { get; set; }
        public virtual DbSet<BANG_KHUYENMAI> BANG_KHUYENMAI { get; set; }
        public virtual DbSet<BANG_NHANVIEN> BANG_NHANVIEN { get; set; }
        public virtual DbSet<BANG_SANPHAM> BANG_SANPHAM { get; set; }
        public virtual DbSet<BANG_THONGBAO> BANG_THONGBAO { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}
