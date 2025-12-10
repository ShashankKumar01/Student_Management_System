using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace StudentResultManagement.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        public string RollNumber { get; set; }

        [Required]
        public string Name { get; set; }

        public string Class { get; set; }
        public string Section { get; set; }
        public DateTime? DOB { get; set; }  
        [ValidateNever]
        public ICollection<Mark> Marks { get; set; } = new List<Mark>();
    }
}
