using System.Linq;
using System.Web.Mvc;
using InterviewApp.Database;

namespace InterviewApp.WebApp.Controllers
{
    public class StudentController : Controller
    {
        private SchoolContext _db = new SchoolContext();
        // GET: Student
        public ActionResult Index()
        {
            return View(_db.Students.ToList());
        }
    }
}