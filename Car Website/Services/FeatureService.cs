using CarApplication.CLS;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace CarApplication.Services
{
    public class FeatureService
    {
        public static IEnumerable<Feature> GetAllFeatures()
        {
            StreamReader reader = new StreamReader("Data/Features.json");
            string jsondata = reader.ReadToEnd();
            Features  allFeatures = JsonSerializer.Deserialize<Features>(jsondata);
            return allFeatures.Feature;


        }
    }
}
