using LibraryManagementApplication.Model.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementApplication.ViewModel
{
    public class LibraryDbContext : DbContext
    {
        public DbSet<Sach> Sachs { get; set; }
        public DbSet<TheLoai> TheLoais { get; set; }
        public DbSet<TacGia> TacGias { get; set; }
        public DbSet<NhaXuatBan> NhaXuatBans { get; set; }
        public DbSet<DonMuon> DonMuons { get; set; }
        public DbSet<CTDM> CTDMs { get; set; }
        public DbSet<TaiKhoan> TaiKhoans { get; set; }
        public DbSet<DocGia> DocGias { get; set; }

        // Thêm DbSet cho các bảng trung gian
        public DbSet<SachTacGia> SachTacGias { get; set; }
        public DbSet<SachTheLoai> SachTheLoais { get; set; }
        public DbSet<SachNhaXuatBan> SachNhaXuatBans { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("YourConnectionStringHere");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuring many-to-many relationship between Sach and TacGia using intermediate entity
            modelBuilder.Entity<SachTacGia>()
                .HasKey(stg => new { stg.MaSach, stg.MaTG });

            modelBuilder.Entity<SachTacGia>()
                .HasOne(stg => stg.Sach)
                .WithMany(s => s.SachTacGias)
                .HasForeignKey(stg => stg.MaSach);

            modelBuilder.Entity<SachTacGia>()
                .HasOne(stg => stg.TacGia)
                .WithMany(tg => tg.SachTacGias)
                .HasForeignKey(stg => stg.MaTG);

            // Configuring many-to-many relationship between Sach and TheLoai using intermediate entity
            modelBuilder.Entity<SachTheLoai>()
                .HasKey(stl => new { stl.MaSach, stl.MaTL });

            modelBuilder.Entity<SachTheLoai>()
                .HasOne(stl => stl.Sach)
                .WithMany(s => s.SachTheLoais)
                .HasForeignKey(stl => stl.MaSach);

            modelBuilder.Entity<SachTheLoai>()
                .HasOne(stl => stl.TheLoai)
                .WithMany(tl => tl.SachTheLoais)
                .HasForeignKey(stl => stl.MaTL);

            // Configuring many-to-many relationship between Sach and NhaXuatBan using intermediate entity
            modelBuilder.Entity<SachNhaXuatBan>()
                .HasKey(snb => new { snb.MaSach, snb.MaNXB });

            modelBuilder.Entity<SachNhaXuatBan>()
                .HasOne(snb => snb.Sach)
                .WithMany(s => s.SachNhaXuatBans)
                .HasForeignKey(snb => snb.MaSach);

            modelBuilder.Entity<SachNhaXuatBan>()
                .HasOne(snb => snb.NhaXuatBan)
                .WithMany(nxb => nxb.SachNhaXuatBans)
                .HasForeignKey(snb => snb.MaNXB);

            // Configuring one-to-many relationship between DonMuon and DocGia
            modelBuilder.Entity<DonMuon>()
                .HasOne(dm => dm.DocGia)
                .WithMany(dg => dg.DonMuons)
                .HasForeignKey(dm => dm.MaDG);

            // Configuring one-to-many relationship between CTDM and DonMuon/Sach
            modelBuilder.Entity<CTDM>().HasKey(ct => new { ct.MaMuon, ct.MaSach });
            modelBuilder.Entity<CTDM>()
                .HasOne(ct => ct.DonMuon)
                .WithMany(dm => dm.CTDMs)
                .HasForeignKey(ct => ct.MaMuon);
            modelBuilder.Entity<CTDM>()
                .HasOne(ct => ct.Sach)
                .WithMany(s => s.CTDMs)
                .HasForeignKey(ct => ct.MaSach);
        }
    }
}
