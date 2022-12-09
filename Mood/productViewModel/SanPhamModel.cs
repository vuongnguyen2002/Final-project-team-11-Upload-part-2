using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mood.SanPhamViewModel
{
    public class SanPhamModel
    {
        public long IDContent { get; set; }

        [StringLength(250)]
        [Display(Name = "Product's name")]
        public string Name { get; set; }

        [StringLength(50)]
        public string Metatile { get; set; }

        [StringLength(50)]
        [Display(Name = "Brands")]
        public string ThuongHieu { get; set; }

        [StringLength(500)]
        [Display(Name = "Producer")]
        public string NhaSanXuat { get; set; }
        [StringLength(250)]
        [Display(Name = "Product Type Name")]
        public string TenTheloai { get; set; }

        [Display(Name = "Amount")]
        public int Soluong { get; set; }

        [StringLength(250)]
        [Display(Name = "Image")]
        public string Images { get; set; }

        public long? CategoryID { get; set; }

        [StringLength(50)]
        [Display(Name = "Quality")]
        public string Quanlity { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayTao { get; set; }

        [StringLength(50)]
        [Display(Name = "Creator")]
        public string NguoiTao { get; set; }
        [Display(Name = "Status")]
        public bool Status { get; set; }

        [StringLength(50)]
        [Display(Name = "Supplier")]
        public string NhaCungCap;

        [Display(Name = "Price")]
        public int GiaTien { set; get; }

        [Display(Name = "Entry Price")]
        public int? GiaNhap { get; set; }

        [Display(Name = "Promotion Price")]
        public int? PriceSale { get; set; }

        [Display(Name = "Describe")]
        public string Mota { get; set; }

        [Display(Name = "Detail")]
        public string ChiTiet { get; set; }

        public int? TonKho { set; get; }

    }
}
