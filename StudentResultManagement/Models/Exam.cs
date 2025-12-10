using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace StudentResultManagement.Models
{
    public class Exam
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Exam Name")]
        public string Name { get; set; }
        [Display(Name = "Term / Semester")]
        public string Term { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Exam Date")]
        public DateTime ExamDate { get; set; }
        [ValidateNever]
        public ICollection<Mark> Marks { get; set; } = new List<Mark>();
    }
}
