using copartnership.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace copartnership.Controllers
{
    [Authorize(Roles="Admin")]
    public class Roles : Controller
    {
        private readonly RoleManager<AppRoles> _roleManager;

        public Roles(RoleManager<AppRoles> roleManager)
        {
            _roleManager = roleManager;
        }

        public async Task<IActionResult> Index()
        {
            var roles = await _roleManager.Roles.ToListAsync();
            return View(roles);
        }
    }
}
