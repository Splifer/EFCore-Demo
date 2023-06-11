﻿// <auto-generated />
using System;
using EFCore_Demo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFCore_Demo.Migrations
{
    [DbContext(typeof(QuanLySinhVienContext))]
    partial class QuanLySinhVienContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EFCore_Demo.Models.Detai", b =>
                {
                    b.Property<string>("MaDt")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("char(10)")
                        .HasColumnName("MaDT")
                        .IsFixedLength();

                    b.Property<int?>("KinhPhi")
                        .HasColumnType("int");

                    b.Property<string>("NoiThucTap")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("TenDt")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("TenDT");

                    b.HasKey("MaDt")
                        .HasName("PK__DETAI__272586553906A5E0");

                    b.ToTable("DETAI");
                });

            modelBuilder.Entity("EFCore_Demo.Models.Giangvien", b =>
                {
                    b.Property<int>("MaGv")
                        .HasColumnType("int")
                        .HasColumnName("MaGV");

                    b.Property<string>("HoTenGv")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("HoTenGV");

                    b.Property<decimal?>("Luong")
                        .HasColumnType("decimal(5, 2)");

                    b.Property<string>("MaKhoa")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("char(10)")
                        .IsFixedLength();

                    b.HasKey("MaGv")
                        .HasName("PK__GIANGVIE__2725AEF394CC8AE7");

                    b.HasIndex("MaKhoa");

                    b.ToTable("GIANGVIEN");
                });

            modelBuilder.Entity("EFCore_Demo.Models.Huongdan", b =>
                {
                    b.Property<int>("MaSv")
                        .HasColumnType("int")
                        .HasColumnName("MaSV");

                    b.Property<decimal?>("KetQua")
                        .HasColumnType("decimal(5, 2)");

                    b.Property<string>("MaDt")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("char(10)")
                        .HasColumnName("MaDT")
                        .IsFixedLength();

                    b.Property<int?>("MaGv")
                        .HasColumnType("int")
                        .HasColumnName("MaGV");

                    b.HasKey("MaSv")
                        .HasName("PK__HUONGDAN__2725081AEA214B19");

                    b.HasIndex("MaDt");

                    b.HasIndex("MaGv");

                    b.ToTable("HUONGDAN");
                });

            modelBuilder.Entity("EFCore_Demo.Models.Khoa", b =>
                {
                    b.Property<string>("MaKhoa")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("char(10)")
                        .IsFixedLength();

                    b.Property<string>("DienThoai")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("char(10)")
                        .IsFixedLength();

                    b.Property<string>("Filter")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("TenKhoa")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("MaKhoa")
                        .HasName("PK__KHOA__65390405DC3D9379");

                    b.ToTable("KHOA");
                });

            modelBuilder.Entity("EFCore_Demo.Models.Sinhvien", b =>
                {
                    b.Property<int>("MaSv")
                        .HasColumnType("int")
                        .HasColumnName("MaSV");

                    b.Property<string>("HoTenSv")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("HoTenSV");

                    b.Property<string>("MaKhoa")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("char(10)")
                        .IsFixedLength();

                    b.Property<int?>("NamSinh")
                        .HasColumnType("int");

                    b.Property<string>("QueQuan")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("MaSv")
                        .HasName("PK__SINHVIEN__2725081A0CEFD05B");

                    b.HasIndex("MaKhoa");

                    b.ToTable("SINHVIEN");
                });

            modelBuilder.Entity("EFCore_Demo.Models.Giangvien", b =>
                {
                    b.HasOne("EFCore_Demo.Models.Khoa", "MaKhoaNavigation")
                        .WithMany("Giangviens")
                        .HasForeignKey("MaKhoa")
                        .HasConstraintName("FK__GIANGVIEN__MaKho__5EBF139D");

                    b.Navigation("MaKhoaNavigation");
                });

            modelBuilder.Entity("EFCore_Demo.Models.Huongdan", b =>
                {
                    b.HasOne("EFCore_Demo.Models.Detai", "MaDtNavigation")
                        .WithMany("Huongdans")
                        .HasForeignKey("MaDt")
                        .HasConstraintName("FK__HUONGDAN__MaDT__66603565");

                    b.HasOne("EFCore_Demo.Models.Giangvien", "MaGvNavigation")
                        .WithMany("Huongdans")
                        .HasForeignKey("MaGv")
                        .HasConstraintName("FK__HUONGDAN__MaGV__6754599E");

                    b.Navigation("MaDtNavigation");

                    b.Navigation("MaGvNavigation");
                });

            modelBuilder.Entity("EFCore_Demo.Models.Sinhvien", b =>
                {
                    b.HasOne("EFCore_Demo.Models.Khoa", "MaKhoaNavigation")
                        .WithMany("Sinhviens")
                        .HasForeignKey("MaKhoa")
                        .HasConstraintName("FK__SINHVIEN__MaKhoa__619B8048");

                    b.Navigation("MaKhoaNavigation");
                });

            modelBuilder.Entity("EFCore_Demo.Models.Detai", b =>
                {
                    b.Navigation("Huongdans");
                });

            modelBuilder.Entity("EFCore_Demo.Models.Giangvien", b =>
                {
                    b.Navigation("Huongdans");
                });

            modelBuilder.Entity("EFCore_Demo.Models.Khoa", b =>
                {
                    b.Navigation("Giangviens");

                    b.Navigation("Sinhviens");
                });
#pragma warning restore 612, 618
        }
    }
}
