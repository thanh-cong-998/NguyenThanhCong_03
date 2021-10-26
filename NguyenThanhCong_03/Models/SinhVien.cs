using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NguyenThanhCong_03.Models
{
    public class SinhVien
    {
        [Key]
        public string MSV { get; set; }
        public string TenSV { get; set; }
        public DateTime NS { get; set; }
    }
}