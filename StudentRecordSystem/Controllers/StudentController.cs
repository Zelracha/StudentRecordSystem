using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentRecordSystem.Data;
using StudentRecordSystem.Models;

namespace StudentRecordSystem.Controllers
{
    public class StudentController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StudentController(ApplicationDbContext dbContext) 
        {
           _context = dbContext;
        }


        public IActionResult Index()
        {
            var students = _context.Students.ToList(); // Retrieve students from database
            return View(students);
        }


        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(Student studentViewModel)
        {
            var student = new Student
            {
                FirstName = studentViewModel.FirstName,
                LastName = studentViewModel.LastName,
                DateOfBirth = studentViewModel.DateOfBirth,
                Email = studentViewModel.Email,
                Phone = studentViewModel.Phone
            };

            if (ModelState.IsValid)
            {
                await _context.Students.AddAsync(student);
                await _context.SaveChangesAsync();

                return RedirectToAction("Index"); // Redirect to Index view
            }
            else
            {
                return View();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Save(Student student) 
        {
            var UpdateStudent = new Student
            {
                FirstName = student.FirstName,
                LastName = student.LastName,
                DateOfBirth = student.DateOfBirth,
                Email = student.Email,
                Phone = student.Phone
            };

            if (ModelState.IsValid)
            {
                _context.Students.Update(UpdateStudent);
                await _context.SaveChangesAsync();

                return RedirectToAction("Index"); // Redirect to Index view
            }
            else
            {
                return View();
            }
        }

    }
}
