using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EFCore_Demo.Models;

[Table("DETAI")]
public partial class Detai
{
    [Key]
    [Column("MaDT")]
    [StringLength(10)]
    [Unicode(false)]
    public string MaDt { get; set; } = null!;

    [Column("TenDT")]
    [StringLength(100)]
    public string? TenDt { get; set; }

    public int? KinhPhi { get; set; }

    [StringLength(100)]
    public string? NoiThucTap { get; set; }

    [InverseProperty("MaDtNavigation")]
    public virtual ICollection<Huongdan> Huongdans { get; set; } = new List<Huongdan>();
}
