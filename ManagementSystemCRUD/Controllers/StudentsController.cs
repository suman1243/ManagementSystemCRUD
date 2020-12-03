using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ManagementSystemCRUD.Models;

namespace ManagementSystemCRUD.Controllers
{
    public class StudentsController : Controller
    {
        private readonly ManagementContext _context;

        public StudentsController(ManagementContext context)
        {
            _context = context;
        }

        // GET: Students
        public async Task<IActionResult> Index()
        {
            return View(await _context.Students.ToListAsync());
        }

     
      
        // GET: Students/Create
        public IActionResult Manage(int id=0)
        {
           
            if (id==0)
            {
                return View(new Student());
            }
            else
            {
                return View(_context.Students.Find(id));
            }
        }

        [HttpPost]
        public async Task<IActionResult> Manage(Student student)
        {
            if (ModelState.IsValid)
            {
                if (student.StudentId <= 0)
                {
                    _context.Add(student);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Index");
                }
                else
                {
                    _context.Update(student);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Index");
                }
              
            }
            return View(student);
        }

     
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.Students
                .FirstOrDefaultAsync(m => m.StudentId == id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        // POST: Students/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var student = await _context.Students.FindAsync(id);
            _context.Students.Remove(student);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StudentExists(int id)
        {
            return _context.Students.Any(e => e.StudentId == id);
        }
    }
}
