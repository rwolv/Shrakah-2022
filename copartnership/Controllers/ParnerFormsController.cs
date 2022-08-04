using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using copartnership.Data;
using copartnership.Models;
using Microsoft.AspNetCore.Authorization;

namespace copartnership.Controllers
{
    [Authorize]
    public class ParnerFormsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ParnerFormsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ParnerForms
        public async Task<IActionResult> Index()
        {
            return _context.parnerForms != null ?
                        View(await _context.parnerForms.ToListAsync()) :
                        Problem("Entity set 'ApplicationDbContext.partnerOrders'  is null.");
        }

        // GET: ParnerForms/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.parnerForms == null)
            {
                return NotFound();
            }

            var partnerOrder = await _context.parnerForms
                .FirstOrDefaultAsync(m => m.Id == id);
            if (partnerOrder == null)
            {
                return NotFound();
            }

            return View(partnerOrder);
        }

        // GET: ParnerForms/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ParnerForms/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NationalId,PartnerType,Dept,PartnerDate,ParnerDuration,userid,StatusId")] ParnerForm parnerForm)
        {
            ModelState.Remove("userid");
            ModelState.Remove("StatusId");
            if (ModelState.IsValid)
            {
                _context.Add(parnerForm);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(parnerForm);
        }

        // GET: ParnerForms/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.parnerForms == null)
            {
                return NotFound();
            }

            var parnerForm = await _context.parnerForms.FindAsync(id);
            if (parnerForm == null)
            {
                return NotFound();
            }
            return View(parnerForm);
        }

        // POST: ParnerForms/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NationalId,PartnerType,Dept,PartnerDate,ParnerDuration,userid,StatusId")] ParnerForm parnerForm)
        {
            if (id != parnerForm.Id)
            {
                return NotFound();
            }
            ModelState.Remove("userid");

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(parnerForm);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ParnerFormExists(parnerForm.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(parnerForm);
        }

        // GET: ParnerForms/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.parnerForms == null)
            {
                return NotFound();
            }

            var parnerForm = await _context.parnerForms
                .FirstOrDefaultAsync(m => m.Id == id);
            if (parnerForm == null)
            {
                return NotFound();
            }

            return View(parnerForm);
        }

        // POST: ParnerForms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.parnerForms == null)
            {
                return Problem("Entity set 'ApplicationDbContext.parnerForms'  is null.");
            }
            var parnerForm = await _context.parnerForms.FindAsync(id);
            if (parnerForm != null)
            {
                _context.parnerForms.Remove(parnerForm);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ParnerFormExists(int id)
        {
          return (_context.parnerForms?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
