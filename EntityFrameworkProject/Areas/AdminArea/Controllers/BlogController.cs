using EntityFrameworkProject.Data;
using EntityFrameworkProject.Helpers;
using EntityFrameworkProject.Models;
using EntityFrameworkProject.ViewModels.BlogViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkProject.Areas.AdminArea.Controllers
{

    [Area("AdminArea")]
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;


        public BlogController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public async Task<IActionResult> Index()
        {
            List<Blog> blogs = await _context.Blogs.Where(m=>!m.IsDeleted).ToListAsync();

            return View(blogs);
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(BlogCreateVM blogCreateVM)
        {

            if (!ModelState.IsValid)
            {
                return View(blogCreateVM);
            }

            if (!blogCreateVM.Photo.CheckFileType("image/"))
            {
                ModelState.AddModelError("Photo", "Please choose correct image type");
                return View(blogCreateVM);
            }


            if (!blogCreateVM.Photo.CheckFileSize(500))
            {
                ModelState.AddModelError("Photo", "Please choose correct image size");
                return View(blogCreateVM);
            }



            string fileName = Guid.NewGuid().ToString() + "_" + blogCreateVM.Photo.FileName;

            string path = Helper.GetFilePath(_env.WebRootPath, "img", fileName);

            await Helper.SaveFile(path, blogCreateVM.Photo);       

            Blog blog = new Blog
            {
                Title = blogCreateVM.Title,
                Desc = blogCreateVM.Desc,                
                Date = DateTime.Now,
                Image = fileName
            };

           
            await _context.Blogs.AddAsync(blog);

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            Blog blog = await _context.Blogs
                .Where(m => !m.IsDeleted && m.Id == id)
                .FirstOrDefaultAsync();

            if (blog == null) return NotFound();

           
                string path = Helper.GetFilePath(_env.WebRootPath, "img", blog.Image);
                Helper.DeleteFile(path);
                
  

            blog.IsDeleted = true;

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));

        }



        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id is null) return BadRequest();

            Blog dbBlog = await GetByIdAsync((int)id);

            return View(new BlogUpdateVM
            {              
                Title = dbBlog.Title,
                Desc = dbBlog.Desc,           
                Image = dbBlog.Image
            });
        }

        private async Task<Blog> GetByIdAsync(int id)
        {
            return await _context.Blogs
           .Where(m => !m.IsDeleted && m.Id == id)
           .FirstOrDefaultAsync();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, BlogUpdateVM updatedBlog)
        {
      

            if (!ModelState.IsValid) return View(updatedBlog);

            Blog dbBlog = await GetByIdAsync(id);

            if (updatedBlog.Photo != null)
            {

               
                    if (!updatedBlog.Photo.CheckFileType("image/"))
                    {
                        ModelState.AddModelError("Photo", "Please choose correct image type");
                        return View(updatedBlog);
                    }


                    if (!updatedBlog.Photo.CheckFileSize(500))
                    {
                        ModelState.AddModelError("Photo", "Please choose correct image size");
                        return View(updatedBlog);
                    }

                
                    string exPath = Helper.GetFilePath(_env.WebRootPath, "img", dbBlog.Image);
                    Helper.DeleteFile(exPath);
               

                    string fileName = Guid.NewGuid().ToString() + "_" + updatedBlog.Photo.FileName;

                    string newPath = Helper.GetFilePath(_env.WebRootPath, "img", fileName);

                    await Helper.SaveFile(newPath, updatedBlog.Photo);

                dbBlog.Image = fileName;


            }

    

            dbBlog.Title = updatedBlog.Title;
            dbBlog.Desc = updatedBlog.Desc;
           
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }



    }
}
