using EFCore_Demo.Models;
using Microsoft.AspNetCore.Mvc;

namespace EFCore_Demo.Controllers
{
    public class KhoaController : Controller
    {
        private readonly QuanLySinhVienContext _context;

        public KhoaController(QuanLySinhVienContext context)
        { 
            _context = context; 
        }

        public IActionResult demo()
        {
            var items = _context.Khoas.ToList();
            return View(items);
        }

        [HttpPost]
        public IActionResult Them(string? makhoa, string? tenkhoa, int? sdt)
        {
            if (!String.IsNullOrEmpty(makhoa))
            {
                Khoa khoa = new Khoa();
                khoa.MaKhoa = makhoa;
                khoa.TenKhoa = tenkhoa;
                khoa.DienThoai = sdt.ToString();

                _context.Add(khoa);//them
                //_context.Update(khoa);//cap nhat
                //_context.Remove(khoa);//xoa
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                Khoa khoa = new Khoa();
                return View(khoa);
            }
        }



        public IActionResult CapNhat(string? makhoa, string? tenkhoa, string? sodienthoai, bool? isUpdate = true)
        {
            var rows = _context.Khoas.FirstOrDefault(k => k.MaKhoa == makhoa);
            if (!(bool)isUpdate)
            {
                return View(rows);
            }
            else
            {
                rows.TenKhoa = tenkhoa;
                rows.DienThoai = sodienthoai;
                //rows.IsActive = kichhoat == "on" ? true : false;
                //rows.Keyword = makhoa.ToLower() + " " + tenkhoa.ToLower();
                _context.Khoas.Update(rows);
                _context.SaveChanges();
                return RedirectToAction("demo");
            }
        }

        public IActionResult Xoa()
        {
            return RedirectToAction("Index");
        }
    }
}