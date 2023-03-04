using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            CarLot myCarLot = new CarLot();

            Car car1 = new Car();
            car1.Year = 1950; //Dot Notation
            car1.Make = "Ford";
            car1.Model = "Model-T";
            car1.EngineNoise = "Vroom Vroom";
            car1.HonkNoise = "Beep Beep";
            car1.IsDriveable = true;

            Car.MakeEngineNoise(car1.EngineNoise);
            Car.MakeHonkNoise(car1.HonkNoise);

            Console.WriteLine($"\nNumber of cars created: {CarLot.numberOfCars}\n");

            myCarLot.ListOfCars.Add(car1);

            //OR

            //myListOfCars.Add(new Car
            //{
            //    Year = car1.Year,
            //    Make = car1.Make,
            //    Model = car1.Model,
            //    EngineNoise = car1.EngineNoise,
            //    HonkNoise = car1.HonkNoise,
            //    IsDriveable = car1.IsDriveable
            //});

            Car car2 = new Car() { Year = 1999, Make = "Honda", Model = "Civic", EngineNoise = "Vroom Vroom Vroom",  HonkNoise = "Beep Beep Beep", IsDriveable = false }; //Object Initializer Syntax

            Car.MakeEngineNoise(car2.EngineNoise);
            Car.MakeHonkNoise(car2.HonkNoise);

            Console.WriteLine($"\nNumber of cars created: {CarLot.numberOfCars}\n");

            myCarLot.ListOfCars.Add(car2);

            //OR

            //myListOfCars.Add(new Car
            //{
            //    Year = car2.Year,
            //    Make = car2.Make,
            //    Model = car2.Model,
            //    EngineNoise = car2.EngineNoise,
            //    HonkNoise = car2.HonkNoise,
            //    IsDriveable = car2.IsDriveable
            //});

            Car car3 = new Car(2020, "Tesla", "Model 3", "Vroom", "Beep", true); //Custom Constructor

            Car.MakeEngineNoise(car3.EngineNoise);
            Car.MakeHonkNoise(car3.HonkNoise);

            Console.WriteLine($"\nNumber of cars created: {CarLot.numberOfCars}\n");

            myCarLot.ListOfCars.Add(car3);

            //OR

            //myListOfCars.Add(new Car
            //{
            //    Year = car3.Year,
            //    Make = car3.Make,
            //    Model = car3.Model,
            //    EngineNoise = car3.EngineNoise,
            //    HonkNoise = car3.HonkNoise,
            //    IsDriveable = car3.IsDriveable
            //});

            int counter = 1;

            //foreach (var i in myListOfCars)
            //{
            //    Console.WriteLine($"Car {counter}: CarYear: {i.Year}, Make: {i.Make}, Model: {i.Model}");
            //    counter++;
            //}


            for (int i = 0; i < myCarLot.ListOfCars.Count; i++)
            {
                Console.WriteLine( $"Car {counter}: CarYear: {myCarLot.ListOfCars[i].Year}, Make: {myCarLot.ListOfCars[i].Make}, Model: {myCarLot.ListOfCars[i].Model}");
                counter++;
            }

            Console.WriteLine();
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
