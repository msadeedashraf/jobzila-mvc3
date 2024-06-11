using jobzila_mvc2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace jobzila_mvc2.Controllers
{
    [Route("Job")]
    public class JobController : Controller
    {

        

        private readonly JobsDataContext _db;

        public JobController(JobsDataContext db)
        {
            _db = db;
        }




        [Route("")]
        public IActionResult Index()
        {


            /*
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
            */
            var jobs= _db.Jobs.OrderByDescending(x => x.Posted).Take(5).ToArray();

            return View(jobs);
        }


        [HttpGet, Route("Createjob")]
        public IActionResult Createjob() { 
        
        return View();
        }

        [HttpPost, Route("Createjob")]
        public IActionResult Createjob(Jobs job)
        {
            if (!ModelState.IsValid)
            {


                //return RedirectToAction("Postjob", "job");

                return View();
            }


            job.Author = "Bajinder";
            job.Posted = DateTime.Now;

            //_db.Jobs.c
            
            
            _db.Jobs.Add(job);
            _db.SaveChanges();


            return View();

        }



        [Route("Postjob")]
        public IActionResult Postjob()
        {

            var job = new Jobs
            {

                Title = "Developer",
                Company = "TecZila Inc.",
                Description = "We are looking for a skilled and experienced Software Developer to\r\n join our team. The ideal candidate should have strong programming\r\n skills in Java and experience with web development technologies\r\n                    such as HTML, CSS, and JavaScript. Familiarity with databases and\r\n                    version control systems is a plus.",
                City = "New York, NY"
            };


            return View(job);
        }

    }
}
