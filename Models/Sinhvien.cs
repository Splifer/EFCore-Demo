using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EFCore_Demo.Models;

[Table("SINHVIEN")]
public partial class Sinhvien
{
    [Key]
    [Column("MaSV")]
    public int MaSv { get; set; }

    [Column("HoTenSV")]
    [StringLength(100)]
    public string? HoTenSv { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? MaKhoa { get; set; }

    public int? NamSinh { get; set; }

    [StringLength(50)]
    public string? QueQuan { get; set; }

    [ForeignKey("MaKhoa")]
    [InverseProperty("Sinhviens")]
    public virtual Khoa? MaKhoaNavigation { get; set; }
}
