﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace CarLotSimulator
//Create a CarLot class
//It should have at least one property: a List of cars
//Instanciate the a Carlot at the beginning of the program
//and as you create a car add the car to the list.
//At the end iterate through the list printing each of car's Year, Make, and Model to the console

{
    public class Carlot
    {
        public Carlot()
        {
        }
        //property name is a list of car, is a list a member or property? 
        public List<Car> Cars = new List<Car>();


        //public CarList = new List<string>

    }
}
