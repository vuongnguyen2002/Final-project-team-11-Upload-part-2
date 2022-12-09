using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mood.NhaCungCapModel
{
    public class NhaCungCapModelView
    {
        public long IDNCC { get; set; }

        [StringLength(250)]
        [Display(Name = "Supplier Name")]
        public string TenNCC { get; set; }

        [Column(TypeName = "date")]
        [Display(Name = "Date created")]
        public DateTime? NgayTao { get; set; }

        [Display(Name = "Creator")]
        public string NguoiTao { get; set; }
        [Display(Name = "Status")]
        public bool Status { get; set; }

        [StringLength(250)]
        [Display(Name = "Address")]
        public string DiaChi { get; set; }

        [StringLength(50)]
        [Display(Name = "Phone")]
        public string SoDienThoai { get; set; }

        [StringLength(50)]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
