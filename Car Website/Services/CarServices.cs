using CarApplication.CLS;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Car_Website.Services
{
    public class CarServices
    {
        public static IEnumerable<Blog> GetAllCars()
        {
            var reader = new StreamReader("Data/Blog.json");
            var alldata = reader.ReadToEnd();
            var allcars = JsonSerializer.Deserialize<Blogs>(alldata);

            return allcars.Blog;

        }
    }
}
