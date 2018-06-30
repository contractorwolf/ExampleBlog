using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExampleBlog.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExampleBlog.Controllers
{
    [Route("api/[controller]")]
    public class BlogsController : Controller
    {
        List<Blog> blogList = PopulateBlogs();

        [HttpGet]
        public IActionResult ListBlogs()
        {
            ViewData["Header"] = "Select a blog";
            ViewData["Blogs"] = blogList;
            return View(blogList);
        }

        // GET api/blogs/5
        [HttpGet("{id}")]
        public Blog Get(int id)
        {
            foreach (Blog b in blogList)
            {
                if (b.id == id)
                {
                    return b;
                }
                else
                {
                    continue;
                }
            }
            return null;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        public static List<Blog> PopulateBlogs()
        {
            List<Blog> blogList = new List<Blog>();
            Blog logansBlog = new Blog();
            Blog eileensBlog = new Blog();
            Blog marksBlog = new Blog();
            logansBlog.id = 1;
            logansBlog.author = "Logan";
            logansBlog.title = "Mazdas";
            logansBlog.body = "Mazdas are super cool and you should buy one";
            eileensBlog.id = 2;
            eileensBlog.author = "Eileen";
            eileensBlog.title = "Dogs";
            eileensBlog.body = "We don't have enough dogs and we should get more";
            marksBlog.id = 3;
            marksBlog.author = "Mark";
            marksBlog.title = "Shoes are awesome";
            marksBlog.body = "I spent too much on shoes today";
            blogList.Add(logansBlog);
            blogList.Add(eileensBlog);
            blogList.Add(marksBlog);
            return blogList;
        }
    }
}
