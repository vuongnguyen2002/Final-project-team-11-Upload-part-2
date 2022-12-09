using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mood.HoaDonModel
{
    public class ChiTietHoaDon
    {
        [Key]
        [Display(Name = "Code product")]
        public long ProductID { get; set; }

        [Display(Name = "Name product")]
        public string Name { get; set; }

        [Display(Name = "Name")]
        public string TenKH { get; set; }

        [Display(Name = "Phone")]
        public string Phone { get; set; }

        [Display(Name = "Address")]
        public string Address { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }
        [Display(Name = "Brand")]
        public string ThuongHieu { get; set; }

        [Display(Name = "Code Bill")]
        public long OderID { get; set; }

        [Display(Name = "Amount")]
        public int? Quanlity { get; set; }

        [Display(Name = "Date created")]
        public DateTime? NgayTao { get; set; }

        [Display(Name = "Price")]
        public int? Price { get; set; }

        [Display(Name = "Status")]
        public int? Status { get; set; }
        [Display(Name = "Delivery")]
        public int? GiaoHang { get; set; }

        [Display(Name = "Nhận hàng")]
        public int? NhanHang { get; set; }

        [Display(Name = "Receive")]
        public string ghiChu { get; set; }

        [Display(Name = "Payment methods")]
        public string DeliveryPaymentMethod { get; set; }

        [Display(Name = "Pay")]
        public int StatusPayment { get; set; }
        [Display(Name = "Promotion Price")]
        public int? PriceSale { get; set; }

    }
}
