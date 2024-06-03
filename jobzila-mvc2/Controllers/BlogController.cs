using jobzila_mvc2.Controllers;
using System;

using Microsoft.AspNetCore.Mvc;
using jobzila_mvc2.Models;

namespace jobzila_mvc2.Controllers
{
    [Route("Blog")]
    public class BlogController : Controller
    {

        [Route("")]
        public IActionResult Index()
        {
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

           

            return View(posts);
        }


        [Route("{year:min(2015)}/{month:range(1,12)}/{key}")]
        public IActionResult Post()
        {

            var post = new Post
            {
                Title = "My First Blog",
                Body = "This is my first blog",
                Author = "Sadeed",
                Posted = DateTime.Now
            };







            /*
             
            ViewBag.Title = "My First Blog";
            ViewBag.Body = "This is a sample data";
            ViewBag.Author = "Sadeed";
            ViewBag.Posted = DateTime.Now;
 */

            return View(post);
        }

        [Route("create")]
        public IActionResult Create()
        { 

        return View();
        }
    }
}


