using Enrollment.Web.Models;

namespace Enrollment.Web.ViewModel.Student
{
    public class SubjectViewModel
    {
        public string SubjectID { get; set; }
        public string SubjectName { get; set; }

        public ICollection<TeacherViewModel> Teachers { get; set; }
    }
}
