










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

        // Cấu hình chuỗi kết nối đến cơ sở dữ liệu
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Model\Database\DatabaseLibrary.mdf;Integrated Security=True;MultipleActiveResultSets=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure DauSach table
            modelBuilder.Entity<DauSach>(entity =>
            {
                entity.ToTable("DauSach");
                entity.HasKey(e => e.MaDauSach);
            });

            // Configure Sach table
            modelBuilder.Entity<Sach>(entity =>
            {
                entity.ToTable("Sach");
                entity.HasKey(e => new { e.MaDauSach, e.ISBN });
                entity.Property(e => e.TrangThai).IsRequired();
                entity.HasOne(e => e.DauSach)
                      .WithMany(d => d.Sachs)
                      .HasForeignKey(e => e.MaDauSach);
            });

            // Configure NhaXuatBan table
            modelBuilder.Entity<NhaXuatBan>(entity =>
            {
                entity.ToTable("NhaXuatBan");
                entity.HasKey(e => e.MaNXB);
            });

            // Configure TheLoai table
            modelBuilder.Entity<TheLoai>(entity =>
            {
                entity.ToTable("TheLoai");
                entity.HasKey(e => e.MaTL);
            });

            // Configure TacGia table
            modelBuilder.Entity<TacGia>(entity =>
            {
                entity.ToTable("TacGia");
                entity.HasKey(e => e.MaTG);
            });

            // Configure DocGia table
            modelBuilder.Entity<DocGia>(entity =>
            {
                entity.ToTable("DocGia");
                entity.HasKey(e => e.MaDG);
            });

            // Configure DonMuon table
            modelBuilder.Entity<DonMuon>(entity =>
            {
                entity.ToTable("DonMuon");
                entity.HasKey(e => e.MaMuon);
                entity.HasOne(e => e.DocGia)
                      .WithMany(d => d.DonMuons)
                      .HasForeignKey(e => e.MaDG);
                entity.HasOne(e => e.TaiKhoan)
                      .WithMany(t => t.DonMuons)
                      .HasForeignKey(e => e.MaNV);
            });

            // Configure CTDM table
            modelBuilder.Entity<CTDM>(entity =>
            {
                entity.ToTable("CTDM");
                entity.HasKey(e => new { e.MaMuon, e.MaDauSach, e.ISBN });
                entity.HasOne(e => e.DonMuon)
                      .WithMany(d => d.CTDMs)
                      .HasForeignKey(e => e.MaMuon);
                entity.HasOne(e => e.Sach)
                      .WithMany(s => s.CTDMs)
                      .HasForeignKey(e => new { e.MaDauSach, e.ISBN });
            });

            // Configure TaiKhoan table
            modelBuilder.Entity<TaiKhoan>(entity =>
            {
                entity.ToTable("TaiKhoan");
                entity.HasKey(e => e.UserID);
                entity.Property(e => e.Loai).IsRequired();
            });
        }
    }
}
