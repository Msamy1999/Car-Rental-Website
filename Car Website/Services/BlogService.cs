using CarApplication.CLS;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace CarApplication.Services
{
    public class BlogService
    {
        public static IEnumerable<Blog> GetAllBlogs()
        {
            StreamReader reader = new StreamReader("Data/Blogs.json");
            string jsondata = reader.ReadToEnd();
            Blogs allBlogs = JsonSerializer.Deserialize<Blogs>(jsondata);
            return allBlogs.Blog; 


        }
    }
}
