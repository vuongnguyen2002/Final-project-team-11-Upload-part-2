using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mood.HoaDonModel
{
    public class MessengerModel
    {
        [Key]
        public long IDMes { get; set; }

        public long? IDCustomer { get; set; }


        [Column(TypeName = "date")]
        public DateTime? NgayTao { get; set; }

        [Display(Name = "Content")]
        public string Content { set; get; }

        [Display(Name = "Name")]
        public bool Status { get; set; }

        public long? IDOrder { set; get; }
        [Display(Name = "Status")]
        public int? XacNhan { get; set; }

        [Display(Name = "Delivery")]
        public int? GiaoHang { get; set; }

        [Display(Name = "Receive")]
        public int? NhanHang { get; set; }

        [Display(Name = "Note")]
        public string ghiChu { get; set; }
    }
}

