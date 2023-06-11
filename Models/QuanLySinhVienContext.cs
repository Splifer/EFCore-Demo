using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EFCore_Demo.Models;

public partial class QuanLySinhVienContext : DbContext
{
    public QuanLySinhVienContext()
    {
    }

    public QuanLySinhVienContext(DbContextOptions<QuanLySinhVienContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Detai> Detais { get; set; }

    public virtual DbSet<Giangvien> Giangviens { get; set; }

    public virtual DbSet<Huongdan> Huongdans { get; set; }

    public virtual DbSet<Khoa> Khoas { get; set; }

    public virtual DbSet<Sinhvien> Sinhviens { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("name=huy");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Detai>(entity =>
        {
            entity.HasKey(e => e.MaDt).HasName("PK__DETAI__272586553906A5E0");

            entity.Property(e => e.MaDt).IsFixedLength();
        });

        modelBuilder.Entity<Giangvien>(entity =>
        {
            entity.HasKey(e => e.MaGv).HasName("PK__GIANGVIE__2725AEF394CC8AE7");

            entity.Property(e => e.MaGv).ValueGeneratedNever();
            entity.Property(e => e.MaKhoa).IsFixedLength();

            entity.HasOne(d => d.MaKhoaNavigation).WithMany(p => p.Giangviens).HasConstraintName("FK__GIANGVIEN__MaKho__5EBF139D");
        });

        modelBuilder.Entity<Huongdan>(entity =>
        {
            entity.HasKey(e => e.MaSv).HasName("PK__HUONGDAN__2725081AEA214B19");

            entity.Property(e => e.MaSv).ValueGeneratedNever();
            entity.Property(e => e.MaDt).IsFixedLength();

            entity.HasOne(d => d.MaDtNavigation).WithMany(p => p.Huongdans).HasConstraintName("FK__HUONGDAN__MaDT__66603565");

            entity.HasOne(d => d.MaGvNavigation).WithMany(p => p.Huongdans).HasConstraintName("FK__HUONGDAN__MaGV__6754599E");
        });

        modelBuilder.Entity<Khoa>(entity =>
        {
            entity.HasKey(e => e.MaKhoa).HasName("PK__KHOA__65390405DC3D9379");

            entity.Property(e => e.MaKhoa).IsFixedLength();
            entity.Property(e => e.DienThoai).IsFixedLength();
        });

        modelBuilder.Entity<Sinhvien>(entity =>
        {
            entity.HasKey(e => e.MaSv).HasName("PK__SINHVIEN__2725081A0CEFD05B");

            entity.Property(e => e.MaSv).ValueGeneratedNever();
            entity.Property(e => e.MaKhoa).IsFixedLength();

            entity.HasOne(d => d.MaKhoaNavigation).WithMany(p => p.Sinhviens).HasConstraintName("FK__SINHVIEN__MaKhoa__619B8048");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
