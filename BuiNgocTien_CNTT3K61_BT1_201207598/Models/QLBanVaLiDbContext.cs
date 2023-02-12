using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace BuiNgocTien_CNTT3K61_BT1_201207598.Models
{
    public partial class QLBanVaLiDbContext : DbContext
    {
        public QLBanVaLiDbContext()
            : base("name=QLBanVaLiDbContext")
        {
        }

        public virtual DbSet<tAnhSP> tAnhSPs { get; set; }
        public virtual DbSet<tChatLieu> tChatLieux { get; set; }
        public virtual DbSet<tDanhMucSP> tDanhMucSPs { get; set; }
        public virtual DbSet<tHangSX> tHangSXes { get; set; }
        public virtual DbSet<tKichThuoc> tKichThuocs { get; set; }
        public virtual DbSet<tLoaiDT> tLoaiDTs { get; set; }
        public virtual DbSet<tLoaiSP> tLoaiSPs { get; set; }
        public virtual DbSet<tQuocGia> tQuocGias { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tAnhSP>()
                .Property(e => e.MaSP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tAnhSP>()
                .Property(e => e.TenFileAnh)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tChatLieu>()
                .Property(e => e.MaChatLieu)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tDanhMucSP>()
                .Property(e => e.MaSP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tDanhMucSP>()
                .Property(e => e.MaChatLieu)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tDanhMucSP>()
                .Property(e => e.MaKichThuoc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tDanhMucSP>()
                .Property(e => e.MaHangSX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tDanhMucSP>()
                .Property(e => e.MaNuocSX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tDanhMucSP>()
                .Property(e => e.MaDacTinh)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tDanhMucSP>()
                .Property(e => e.Website)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tDanhMucSP>()
                .Property(e => e.MaLoai)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tDanhMucSP>()
                .Property(e => e.MaDT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tDanhMucSP>()
                .Property(e => e.Anh)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tHangSX>()
                .Property(e => e.MaHangSX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tHangSX>()
                .Property(e => e.MaNuocThuongHieu)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tKichThuoc>()
                .Property(e => e.MaKichThuoc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tKichThuoc>()
                .Property(e => e.KichThuoc)
                .IsFixedLength();

            modelBuilder.Entity<tLoaiDT>()
                .Property(e => e.MaDT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tLoaiSP>()
                .Property(e => e.MaLoai)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tQuocGia>()
                .Property(e => e.MaNuoc)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
