using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mood.NhapHangModel
{
    public class NhapHangModelView
    {
        public long IDNhapHang { get; set; }
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

        [Display(Name = "The number of import)]
        public int? SoluongMoi { get; set; }

        [StringLength(250)]
        [Display(Name = "Address")]
        public string DiaChi { get; set; }

        [StringLength(50)]
        [Display(Name = "Phone")]
        public string SoDienThoai { get; set; }

        [StringLength(50)]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [StringLength(250)]
        [Display(Name = "Image")]
        public string Images { get; set; }

        public long? CategoryID { get; set; }

        [StringLength(50)]
        [Display(Name = "Quality")]
        public string Quanlity { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayTao { get; set; }

        [StringLength(50)]
        [Display(Name = "Creator")]
        public string NguoiTao { get; set; }
        [Display(Name = "Status")]
        public int? Status { get; set; }

        [StringLength(50)]
        [Display(Name = "Supplier")]
        public string NhaCungCap { set; get; }

        [Display(Name = "Price")]
        public int GiaTien { set; get; }
        [Display(Name = "Describe")]

        public int GiaNhap { set; get; }
        public string ThanhTien { set; get; }
        public bool? StatusPayment { set; get; }
        public bool? StatusInput { set; get; }
        public string Mota { get; set; }

        [Display(Name = "Detail")]
        public string ChiTiet { get; set; }
    }
}

