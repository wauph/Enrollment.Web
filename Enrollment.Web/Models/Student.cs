namespace Enrollment.Web.Models
{
    public class Student
    {
        public string StudentID { get; set; }
        public string StudentName { get; set; }
        public ICollection<Subject> Subjects { get; set; }
    }
}
