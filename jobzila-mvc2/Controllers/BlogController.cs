using jobzila_mvc2.Controllers;
using System;

using Microsoft.AspNetCore.Mvc;
using jobzila_mvc2.Models;

namespace jobzila_mvc2.Controllers
{
    [Route("Blog")]
    public class BlogController : Controller
    {

        private readonly BlogDataContext _db;

        public BlogController(BlogDataContext db)
        {
            _db = db;
        }




        [Route("")]
        public IActionResult Index()
        {
            /*
            var posts = new[] {

                new Post{
                Title = "My First Blog",
                Body = "This is my first blog",
                Author = "Sadeed",
                Posted = DateTime.Now
                },
                new Post{ Title = "My Second Blog",
                Body = "This is my second blog",
                Author = "Sadeed",
                Posted = DateTime.Now} ,
                new Post{ Title = "My Third Blog",
                Body = "This is my thrid blog",
                Author = "Sadeed",
                Posted = DateTime.Now}



            };

           */

            //var posts = _db.Posts.ToArray();
            var posts = _db.Posts.OrderByDescending(x=>x.Posted).Take(5).ToArray();


            return View(posts);
        }


        [Route("{year:min(2015)}/{month:range(1,12)}/{key}")]
        public IActionResult Post(int year, int month, string key)
        {

            /*
            var post = new Post
            {
                Title = "My First Blog",
                Body = "This is my first blog",
                Author = "Sadeed",
                Posted = DateTime.Now
            };

            */

            var post = _db.Posts.FirstOrDefault(x => x.key == key);




            /*
             
            ViewBag.Title = "My First Blog";
            ViewBag.Body = "This is a sample data";
            ViewBag.Author = "Sadeed";
            ViewBag.Posted = DateTime.Now;
 */

            return View(post);
        }

        [HttpGet,  Route("create")]
        public IActionResult Create()
        { 

        return View();
        }

      

        [HttpPost,  Route("create")]


        //New Model 
        //public IActionResult Create( CreatePostRequest post)
        //Bind attribute 
        //public IActionResult Create([Bind("Title", "Body")] Post post)
        public IActionResult Create(Post post)
        {
            if (!ModelState.IsValid)
            { 
                //var errors = ModelState.Values.SelectMany(v=>v.Errors).Select(e=>e.ErrorMessage).ToList();
                
                
            
                return View();
            }
                 

            

            post.Author = "Bajinder";
            post.Posted = DateTime.Now;

            _db.Posts.Add(post);
            _db.SaveChanges();

            //return View();
            return RedirectToAction("Post","Blog",new {

                year = post.Posted.Year,
                month = post.Posted.Month,
                key = post.key

            } );
        }
    }
}


