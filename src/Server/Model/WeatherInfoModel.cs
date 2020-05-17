using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Model
{
    public class WeatherInfoModel
    {
        public int ID { get; set; }
        public string City { get; set; }
        public double MaxTemp { get; set; }
        public double MinTemp { get; set; }
        [NotMapped]
        public double AverageTemp => (MinTemp + MaxTemp) / 2;     
        public double DewPoint { get; set; }
        public double Humidity { get; set; }
        public string WindSpeed { get; set; }
        public DateTime date { get; set; }
        [NotMapped]
        public string Month => date.ToString("MMM");
        [NotMapped]
        public int day => date.Day;
        [NotMapped]
        public int year => date.Year;
    }
}
