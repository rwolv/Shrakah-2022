using Microsoft.AspNetCore.Identity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace copartnership.Models
{
    public class AppUsers :IdentityUser
    {
        [DisplayName("الاسم الأول")]
        [Required, MaxLength(100)]
        public string FirstName { get; set; }

        [DisplayName("الاسم الثاني")]
        [Required, MaxLength(100)]
        public string LastName { get; set; }
    }
}
