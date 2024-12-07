using LibraryManagementApplication.Model.Class;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Windows;

namespace LibraryManagementApplication.ViewModel
{
    public class LibraryDbContext : DbContext
    {
        public DbSet<DauSach> DauSachs { get; set; }
        public DbSet<Sach> Sachs { get; set; }
        public DbSet<NhaXuatBan> NhaXuatBans { get; set; }
        public DbSet<TheLoai> TheLoais { get; set; }
        public DbSet<TacGia> TacGias { get; set; }
        public DbSet<DocGia> DocGias { get; set; }
        public DbSet<DonMuon> DonMuons { get; set; }
        public DbSet<CTDM> CTDMs { get; set; }
        public DbSet<TaiKhoan> TaiKhoans { get; set; }

        // Các bảng trung gian
        //public DbSet<SachTacGia> SachTacGias { get; set; }
        //public DbSet<SachTheLoai> SachTheLoais { get; set; }
        //public DbSet<SachNhaXuatBan> SachNhaXuatBans { get; set; }

        // Cấu hình chuỗi kết nối đến cơ sở dữ liệu
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=C:\Users\PC\Documents\GitHub\LibraryManagement\WpfApp1\LibraryManagementApplication\ResourceXAML\MainResource.xaml;Integrated Security=True;MultipleActiveResultSets=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<DauSach>()
                .ToTable("DauSach")
                .HasKey("MaDauSach");

            modelBuilder.Entity<Sach>()
                .ToTable("Sach")
                .HasOne(s => s.DauSach)  // Sach has one DauSach
                .WithMany(d => d.Sachs)   // DauSach has many Sachs
                .HasForeignKey(s => s.MaDauSach);  // Foreign key in Sach is MaDauSach

            modelBuilder.Entity<NhaXuatBan>()
                .ToTable("NhaXuatBan");

            modelBuilder.Entity<TheLoai>()
                .ToTable("TheLoai");

            modelBuilder.Entity<TacGia>()
                .ToTable("TacGia");

            modelBuilder.Entity<DocGia>()
                .ToTable("DocGia");

            modelBuilder.Entity<DonMuon>()
                .ToTable("DonMuon");

            modelBuilder.Entity<CTDM>()
                .ToTable("CTDM").HasNoKey();

            modelBuilder.Entity<TaiKhoan>()
                .ToTable("TaiKhoan");

            // Cấu hình các bảng trung gian, nếu cần
            //modelBuilder.Entity<SachTacGia>()
            //    .ToTable("SachTacGia");

            //modelBuilder.Entity<SachTheLoai>()
            //    .ToTable("SachTheLoai");

            //modelBuilder.Entity<SachNhaXuatBan>()
            //    .ToTable("SachNhaXuatBan");
        }
    }
}
