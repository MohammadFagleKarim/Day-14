using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VechicleAppPractice2
{
     public class Vehicle
    {
        public string VehicleName { set; get; }
        public string RegNo { set; get; }
        
        public List<double> speed = new List<double>();

        public List<double> AddSpeed(double vehicleSpeed)
        {
            speed.Add(vehicleSpeed);
            return speed;
        }

        public double MinSpeed()
        {
            double minSpeed = speed.Min();
            return minSpeed;
        }

        public double MaxSpeed()
        {
            double maxSpeed = speed.Max();
            return maxSpeed;
        }

        public double AverageSpeed()
        {
            double averageSpeed = speed.Average();
            return averageSpeed;
        }
    }
}
