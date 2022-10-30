using EntityFrameworkProject.Data;
using EntityFrameworkProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkProject.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    public class BlogHeaderController : Controller
    {
        private readonly AppDbContext _context;

        public BlogHeaderController(AppDbContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> Index()
        {
            BlogHeader blogHeader = await _context.BlogHeaders.FirstOrDefaultAsync();
            return View(blogHeader);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            try
            {
                if (id is null) return BadRequest();

                BlogHeader blogHeader = await _context.BlogHeaders.FirstOrDefaultAsync(m => m.Id == id);

                if (blogHeader is null) return NotFound();

                return View(blogHeader);

            }
            catch (Exception ex)
            {

                ViewBag.Message = ex.Message;
                return View();
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, BlogHeader blogHeader)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(blogHeader);
                }

                BlogHeader dbBlogHeader = await _context.BlogHeaders.FirstOrDefaultAsync(m => m.Id == id);

                if (dbBlogHeader is null) return NotFound();

                dbBlogHeader.Header = blogHeader.Header;
                dbBlogHeader.Description = blogHeader.Description;

                
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));

            }
            catch (Exception ex)
            {

                ViewBag.Message = ex.Message;
                return View();
            }
        }

    }
}
