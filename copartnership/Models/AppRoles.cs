using Microsoft.AspNetCore.Identity;

namespace copartnership.Models
{
    public class AppRoles : IdentityRole
    {
        public AppRoles() : base() { }

        public AppRoles(string roleName) : base(roleName)
        {

        }
    }
}
