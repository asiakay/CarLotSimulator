using System;
using System.Linq;
using System.Collections.Generic;


namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Done

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property            

            //Done

            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars

            //Done

            //Call each of the methods for each car

            //
            //Instanciate the Carlot at the beginning of the program
            //and as you create a car add the car to the list.
            var myLot = new Carlot();

            //First way to created a new instance,
            //using . notation
            //now can access the properties of the
            //Car class to work with the new instance
            var carA = new Car();
            carA.Year = 1967;
            carA.Make = "Ford";
            carA.Model = "Mustang";
            carA.EngineNoise = "vroom";
            carA.HonkNoise = "beep";
            carA.IsDriveable = true;
            // Adding carA to local variable myLot we created for list of Cars
            // in the Carlot class
            // references travel from bigger container to smaller unit
            myLot.Cars.Add(carA);
            //object initializer syntax
            // - has scope,
            // properties are separated by a comma
            var carB = new Car()
            {
                Year=2017,
                Make="Honda",
                Model="Civic",
                EngineNoise="tut",
                HonkNoise="beep",
                IsDriveable=false,
            };
            //Adding carB
            myLot.Cars.Add(carB);
            //Construction Pass
            //will pass through the new constructor we made in Class.cs
            var carC = new Car(2020, "Tesla", "Whateveritscalled","wrrrr","beep", true);
            myLot.Cars.Add(carC);
            //Calling Methods
            //Instance Method
            //Parameters go through parenthesis, Methods go through methods,
            //Instances of a class go through instances of a class
            //The method has instructions to print to console 
            carC.MakeEngineNoise();
            carB.MakeEngineNoise();
            carA.MakeEngineNoise();
            //Using a foreach loop is for when you want to apply some factor to each
            //item in a list, array, etc??
            //using the local variable car, i can write to console 

            foreach (var car in myLot.Cars)
                Console.WriteLine($"{car.Year} {car.Make} {car.Model}");

            //Done
            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //Done
            //*************BONUS X 2*************//
            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console



        }
    }
}
