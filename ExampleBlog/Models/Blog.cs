using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleBlog.Models
{
    public class Blog
    {
        public int id { get; set; }
        public String author { get; set; }
        public String title { get; set; }
        public String body { get; set; }
    }
}
