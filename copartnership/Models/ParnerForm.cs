using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace copartnership.Models
{
    public class ParnerForm
    {
        public int Id { get; set; }


        [Required]
        [DisplayName("السجل المدني")]
        [MaxLength(10), MinLength(10)]
        public int NationalId { get; set; }

        [Required]
        [DisplayName("نوع الشراكة")]
        public string PartnerType { get; set; }

        [Required]
        [DisplayName("القسم")]
        public string Dept { get; set; }

        [Required]
        [DisplayName("تاريخ طلب الشراكة")]
        public DateTime PartnerDate { get; set; }

        [Required]
        [DisplayName("مدة الشراكة")]
        public string ParnerDuration { get; set; }

        public string userid { get; set; } 

        public int StatusId { get; set; }
        [ForeignKey("StatusId")]
        public OrderStatus? OrderStatus { get; set; }


    }
}
