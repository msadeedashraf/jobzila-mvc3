using jobzila_mvc2.Models;
using Microsoft.AspNetCore.Mvc;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace jobzila_mvc2.Controllers
{
    [Route("Job")]
    public class JobController : Controller
    {
        [Route("")]
        public IActionResult Index()
        {

            var jobs = new[] {

                new Jobs {

                 Title = "Software Developer",
            Company = "ABC Inc.",
            Description = "We are looking for a skilled and experienced Software Developer to\r\n join our team. The ideal candidate should have strong programming\r\n skills in Java and experience with web development technologies\r\n                    such as HTML, CSS, and JavaScript. Familiarity with databases and\r\n                    version control systems is a plus.",
            City = "New York, NY"
                },
                   new Jobs {

                 Title = "Developer",
            Company = "TecZila Inc.",
            Description = "We are looking for a skilled and experienced Software Developer to\r\n join our team. The ideal candidate should have strong programming\r\n skills in Java and experience with web development technologies\r\n                    such as HTML, CSS, and JavaScript. Familiarity with databases and\r\n                    version control systems is a plus.",
            City = "New York, NY"
                },
                   new Jobs {

                 Title = "Full Stack Developer",
            Company = "JobZila Inc.",
            Description = "We are looking for a skilled and experienced Software Developer to\r\n join our team. The ideal candidate should have strong programming\r\n skills in Java and experience with web development technologies\r\n                    such as HTML, CSS, and JavaScript. Familiarity with databases and\r\n                    version control systems is a plus.",
            City = "New York, NY"
                }

            };


            return View(jobs);
        }


        [Route("Createjob")]
        public IActionResult Createjob() { 
        
        return View();
        }
        
    }
}
