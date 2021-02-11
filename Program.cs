using System;
using System.Collections.Generic;

namespace inheritPraci
{
    class Program
    {
        public static void Main(string[] args)
        {
            Vehicle someVehicle = new Vehicle(4,"Green");
            // Constructing a Car "as a" Vehicle
            Vehicle carAsVehicle = new Car("Brown", "Dodge", "Dart");
            Vehicle truckAsVehicle= new Car("White", "Chevrolet", "Silverado");
            Vehicle tankAsVehicle= new Car("CamoGreen", "Abrams", "TK6.0M1A2");
            Vehicle vanAsVehicle= new Car("White", "Honda", "Oddessy");

            // Constructing a List of Vehicle, storing both Vehicle and Car objects
            Car someCar = new Car("Red", "Toyota", "Corolla");
            Car someOtherCar = new Car("Purple", "Ford", "Fiesta");
            List<Vehicle> vehicles = new List<Vehicle>();

            someVehicle.GetInfo();
            truckAsVehicle.GetInfo();
            vanAsVehicle.GetInfo();
            tankAsVehicle.GetInfo();
            someOtherCar.GetInfo();

        


        }
    };
}