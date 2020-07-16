using System;
using System.Collections.Generic;
using System.Linq;

//This is the Car class. We will use this class to create object instances,
//in this case, New CarObject = Car will have the same members & properties of the car class.
//any new "Car objects" will have inherit the behavior of the class members.


////DONE Create a seperate class file called Car
////DONE Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
////DONE Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
////The methods should take one string parameter: the respective noise property



namespace CarLotSimulator
    //scope inside namespace
{
    public class Car
        //scope inside class Car
    {
        // default empty constructor(){}
        public Car()
        {
            //empty scope
        }
        //new constructor renames properties inside the method
        // public Class(datatype xname, datatype xname,){};
        // Are we turning a property into a parameter?
        public Car(int year,
            string make,
            string model,
            string enginenoise,
            string honknoise,
            bool isdriveable)
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = enginenoise;
            HonkNoise = honknoise;
            IsDriveable = isdriveable;
        }
        //setting the properties of the Car Class
        //? makes the Year property nullable
        public int? Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }
        // The two methods, returning string variables
        // return type was originally a string named _engineNoise
        // changed it in the MakeEngineNoise() method in the Car class
        // made the return type a property within the Method parameter

        public void MakeEngineNoise()
        {
            // prints to the console
            Console.WriteLine(EngineNoise);
        }
        public void MakeHonkNoise()
        {
            Console.WriteLine(HonkNoise);
        }
    }
}








//    public Car()
//    {
//    }
//    //This is the method car.
//    //is it a member of the car class?
//    //is it a property of the car class?
//    // A property is a member that provides a flexible
//    // mechanism to read, write, or compute the value of a private field.
//    // Properties can be used as if they are public data members,
//    // but they are actually special methods called accessors.
//    // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/properties




//}




////DONE Create a seperate class file called Car
////DONE Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
//// Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
////The methods should take one string parameter: the respective noise property


////public Car(string year,
////           string make,
////           string model,
////           string engineNoise,
////           string honkNoise,
////           bool isDriveable)
////{
////    Year = year;
////    Make = make;
////    Model = model;
////    EngineNoise = engineNoise;
////    HonkNoise = honkNoise;
////    IsDriveable = isDriveable;
////}

////public string Year { get; set; }
////public string Make { get; set; }
////public string Model { get; set; }
////public string EngineNoise { get; set; }
////public string HonkNoise { get; set; }
////public bool IsDriveable { get; set; }

//public void MakeEngineNoise(string EngineNose)
//{
//    Console.WriteLine(EngineNoise);

//}

//public void MakeHonkNoise(string honkNoise)
//{
//    Console.WriteLine(honkNoise);
//}


//    }
//}
