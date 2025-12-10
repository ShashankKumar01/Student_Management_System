using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentResultManagement.Models
{
    public class Mark
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Student ID")]
        public int StudentId { get; set; }
        [ValidateNever]
        public Student Student { get; set; }

        [Required]
        [Display(Name = "Subject ID")]
        public int SubjectId { get; set; }
        [ValidateNever]
        public Subject Subject { get; set; }

        [Required]
        [Display(Name = "Exam ID")]
        public int ExamId { get; set; }
        [ValidateNever]
        public Exam Exam { get; set; }

        [Range(0, 100)]
        [Display(Name = "Marks Obtained")]
        public int MarksObtained { get; set; }
        [Display(Name = "Absent")]
        public bool IsAbsent { get; set; }
    }
}
