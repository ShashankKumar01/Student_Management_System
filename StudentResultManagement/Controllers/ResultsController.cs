using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
//using StudentResultManagement.Data;
using StudentResultManagement.Models;
using StudentResultManagement.ViewModels;

namespace StudentResultManagement.Controllers
{
    public class ResultsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ResultsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.Students = new SelectList(_context.Students, "Id", "Name");
            ViewBag.Exams = new SelectList(_context.Exams, "Id", "Name");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ViewResult(int studentId, int examId)
        {
            var student = await _context.Students.FindAsync(studentId);
            var exam = await _context.Exams.FindAsync(examId);

            if (student == null || exam == null)
                return NotFound("Invalid selection.");

            var marks = await _context.Marks
                .Include(m => m.Subject)
                .Where(m => m.StudentId == studentId && m.ExamId == examId)
                .ToListAsync();

            if (!marks.Any())
            {
                return View("NoResult");
            }

            int total = marks.Sum(m => m.MarksObtained);
            int maxTotal = marks.Sum(m => m.Subject.MaxMarks);
            double percentage = (double)total / maxTotal * 100.0;

            var vm = new ResultViewModel
            {
                Student = student,
                Exam = exam,
                Marks = marks,
                TotalMarks = total,
                MaxTotalMarks = maxTotal,
                Percentage = Math.Round(percentage, 2),
                Grade = CalculateGrade(percentage)
            };

            return View(vm);
        }

        private string CalculateGrade(double percentage)
        {
            if (percentage >= 90) return "A+";
            if (percentage >= 80) return "A";
            if (percentage >= 70) return "B";
            if (percentage >= 60) return "C";
            if (percentage >= 50) return "D";
            return "F";
        }
    }
}
