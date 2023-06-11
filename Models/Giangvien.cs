using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EFCore_Demo.Models;

[Table("GIANGVIEN")]
public partial class Giangvien
{
    [Key]
    [Column("MaGV")]
    public int MaGv { get; set; }

    [Column("HoTenGV")]
    [StringLength(100)]
    public string? HoTenGv { get; set; }

    [Column(TypeName = "decimal(5, 2)")]
    public decimal? Luong { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? MaKhoa { get; set; }

    [InverseProperty("MaGvNavigation")]
    public virtual ICollection<Huongdan> Huongdans { get; set; } = new List<Huongdan>();

    [ForeignKey("MaKhoa")]
    [InverseProperty("Giangviens")]
    public virtual Khoa? MaKhoaNavigation { get; set; }
}
