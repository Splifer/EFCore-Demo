using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EFCore_Demo.Models;

[Table("HUONGDAN")]
public partial class Huongdan
{
    [Key]
    [Column("MaSV")]
    public int MaSv { get; set; }

    [Column("MaDT")]
    [StringLength(10)]
    [Unicode(false)]
    public string? MaDt { get; set; }

    [Column("MaGV")]
    public int? MaGv { get; set; }

    [Column(TypeName = "decimal(5, 2)")]
    public decimal? KetQua { get; set; }

    [ForeignKey("MaDt")]
    [InverseProperty("Huongdans")]
    public virtual Detai? MaDtNavigation { get; set; }

    [ForeignKey("MaGv")]
    [InverseProperty("Huongdans")]
    public virtual Giangvien? MaGvNavigation { get; set; }
}
