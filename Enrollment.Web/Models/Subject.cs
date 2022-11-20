namespace Enrollment.Web.Models
{
    public class Subject
    {
        public string SubjectID { get; set; }
        public string SubjectName { get; set; }

        public ICollection<Teacher> Teachers { get; set; }
    }
}
