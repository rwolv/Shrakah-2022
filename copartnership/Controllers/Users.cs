using copartnership.Models;
using copartnership.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace copartnership.Controllers
{
    [Authorize(Roles ="Admin")]
    public class Users : Controller
    {
        private readonly UserManager<AppUsers> _userManager;
        private readonly RoleManager<AppRoles> _roleManager;

        public Users(UserManager<AppUsers> userManager, RoleManager<AppRoles> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }




        public async Task<IActionResult> Index()
        {
            var users = await _userManager.Users.Select(user => new UserViewModel

            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                Roles = _userManager.GetRolesAsync(user).Result
            }).ToListAsync();
            return View(users);
        }
    }
}
