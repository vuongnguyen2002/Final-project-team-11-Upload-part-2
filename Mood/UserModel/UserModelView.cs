using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mood.UserModel
{
    public class UserModelView
    {
        public long IDUser { get; set; }


        [StringLength(50)]

        [Display(Name = "Account")]
        public string UserName { get; set; }

        [StringLength(50)]
        [Display(Name = "Password")]
        public string PassWord { get; set; }

        [StringLength(50)]
        [Display(Name = "Full name")]
        public string Name { get; set; }

        [StringLength(250)]
        [Required(ErrorMessage = "No more than 250 characters")]
        [Display(Name = "Address")]
        public string Adress { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        [Display(Name = "Phone number")]
        public string Phone { get; set; }
        [Display(Name = "Status")]
        public bool Status { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayTao { get; set; }

        [StringLength(50)]
        public string NguoiTao { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ModifiedDate { get; set; }

        [StringLength(50)]
        public string ModifiedBy { get; set; }
        public long? IDQuyen { get; set; }
        [Display(Name = "Permission")]
        public string TenQuyen { get; set; }
    }
}
