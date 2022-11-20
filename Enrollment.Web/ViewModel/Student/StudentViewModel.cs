

using System.ComponentModel.DataAnnotations;

namespace Enrollment.Web.ViewModel.Student
{
    public class StudentViewModel
    {
        public string StudentID { get; set; }
        public string StudentName { get; set; }
        public ICollection<SubjectViewModel> Subjects { get; set; }
    }
}
