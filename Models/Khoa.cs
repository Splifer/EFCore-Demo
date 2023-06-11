using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EFCore_Demo.Models;

[Table("KHOA")]
public partial class Khoa
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string MaKhoa { get; set; } = null!;

    [StringLength(50)]
    public string? TenKhoa { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? DienThoai { get; set; }

    public string? Filter { get; set; }

    public bool? IsActive { get; set; }

    [InverseProperty("MaKhoaNavigation")]
    public virtual ICollection<Giangvien> Giangviens { get; set; } = new List<Giangvien>();

    [InverseProperty("MaKhoaNavigation")]
    public virtual ICollection<Sinhvien> Sinhviens { get; set; } = new List<Sinhvien>();
}
