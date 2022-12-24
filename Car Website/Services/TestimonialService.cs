using CarApplication.CLS;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Web_Car.Class;

namespace Web_Car.Servies
{
    public class TestimonialService
    {
        public static IEnumerable<Testimonial> GetAllTestimonials()
        {
          

            var reader = new StreamReader("Data/Testimonials.json");
            var alldata = reader.ReadToEnd();
            var zzz = JsonSerializer.Deserialize<Testimonialszz>(alldata);
            return zzz.Testimonials;


        }


    }
}
