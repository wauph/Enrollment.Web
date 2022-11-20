using Enrollment.Web.Models;
using Enrollment.Web.ViewModel.Student;
using Microsoft.AspNetCore.Mvc;

namespace Enrollment.Web.Controllers
{
    public class StudentsController : Controller
    {
        // GET: Students
        public async Task<IActionResult> Index()
        {

            return View(GetStudents());
        }

        private ICollection<StudentViewModel> GetStudents()
        {
            var students = new List<StudentViewModel>();
            var student = new StudentViewModel()
            {
                StudentID = "1",
                StudentName = "Jeff",
                Subjects = GetStudentSubjects()
            };
            students.Add(student);
            return students;
        }
        private ICollection<SubjectViewModel> GetStudentSubjects()
        {
            var subjects = new List<SubjectViewModel>();
            var subject = new SubjectViewModel() { SubjectID = "1", SubjectName = "Math" };
            subjects.Add(subject);
            return subjects;
        }

        // GET: Students/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = GetStudents().FirstOrDefault();
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        // GET: Students/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Students/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StudentID,StudentName")] StudentViewModel student)
        {
            if (ModelState.IsValid)
            {
                var studentSubjects = GetStudentSubjects(student.Subjects);
                var studentCreated = new Student()
                {
                    StudentID = student.StudentID,
                    StudentName = student.StudentName,
                    Subjects = studentSubjects,

                };
                // add service here
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }

        private ICollection<Subject> GetStudentSubjects(ICollection<SubjectViewModel> subjects)
        {

            var listofSubjects = new List<Subject>();
            var newSubject = new Subject();
            foreach (var subject in subjects)
            {
                newSubject.SubjectID = subject.SubjectID;
                newSubject.SubjectName = subject.SubjectName;
            }
            listofSubjects.Add(newSubject);

            return listofSubjects;
        }
    }
}
