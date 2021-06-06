using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NguyenThanhCong_03.Models
{
    public class NhanVien
    {
        [Key]
        [StringLength(20)]
        public string MaNhanVien { get; set; }
        public string HoTen { get; set; }
        public int MaPhongBan { get; set; }
        public virtual PhongBan PhongBan { get; set; }
    }
}