using StudentResultManagement.Models;

namespace StudentResultManagement.ViewModels
{
    public class ResultViewModel
    {
        public Student Student { get; set; }
        public Exam Exam { get; set; }
        public List<Mark> Marks { get; set; }

        public int TotalMarks { get; set; }
        public int MaxTotalMarks { get; set; }
        public double Percentage { get; set; }
        public string Grade { get; set; }
    }
}
