using Car_Website.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Web_Car.Class;
using Web_Car.Servies;

namespace Car_Website.Controllers
{
    public class CarController : Controller
    {
        
        public IActionResult Index()
        {
 
            return View(CarServices.GetAllCars());
        }


  

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Blog()
        {
            return View();
        }
     
        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult listing()
        {
            var reader = new StreamReader("Data/cars.json");
            var alldata = reader.ReadToEnd();
            var allrecipes = JsonSerializer.Deserialize<Car>(alldata);



            return View(CarServices.GetAllCars());
        }

        public IActionResult testimonials()
        {
            //var reader = new StreamReader("Data/Testimonials.json");
            //var alldata = reader.ReadToEnd();
            //var allrecipes = JsonSerializer.Deserialize<Testimonialszz>(alldata);


            return View(TestimonialService.GetAllTestimonials());
        }

    }
}
