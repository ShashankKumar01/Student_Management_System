using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace StudentResultManagement.Models
{
    public class Subject
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Subject Code")]
        public string Code { get; set; }

        [Required]
        [Display(Name = "Subject Name")]
        public string Name { get; set; }
        [Range(1, 1000)]
        [Display(Name = "Maximum Marks")]
        public int MaxMarks { get; set; }
        [Range(0, 1000)]
        [Display(Name = "Minimum Passing Marks")]
        public int MinPassMarks { get; set; }
        [ValidateNever]
        public ICollection<Mark> Marks { get; set; } = new List<Mark>();
    }
}
