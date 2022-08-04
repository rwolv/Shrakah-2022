using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace copartnership.Models
{
    public class OrderStatus
    {
        [Key]
        public int StatusId { get; set; }


        [DisplayName("حالة الطلب")]
        public string StatusName { get; set; }
    }
}
