using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NguyenThanhCong_03.Models
{
    public class PhongBan
    {
        [Key]
        public int MaPhongBan { get; set; }
        [StringLength(50)]
        public string TenPhongBan { get; set; }
        public virtual ICollection<NhanVien> NhanViens {get;set;}
    }
}