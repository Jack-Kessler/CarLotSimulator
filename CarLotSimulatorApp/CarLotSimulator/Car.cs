using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class Car
    {
        public Car() //Default Constructor
        {
            CarLot.numberOfCars++;
        }

        public Car(int year, string make, string model, string engineNoise, string honkNoise, bool isDrivable) //Custom Constructor
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDriveable = isDrivable;
        }


        public int Year { get; set; } //Property
        public string Make { get; set; } //Property
        public string Model { get; set; } //Property
        public string EngineNoise { get; set; } //Property
        public string HonkNoise { get; set; } //Property
        public bool IsDriveable { get; set; } //Property
        public static void MakeEngineNoise(string engingeNoise)
        {
            Console.WriteLine(engingeNoise);
        }

        public static void MakeHonkNoise(string honkNoise)
        {
            Console.WriteLine(honkNoise);
        }
    }
}
