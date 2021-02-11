using System;
// Defining a child class of Vehicle
class Car : Vehicle
{
    // We can add members that are unique to Cars, things that won't describe ALL vehicles
    public string Make;
    public string Model;
    // but when we define a constructor for Car, we need to satisfy any constructor requirements
    // for at least ONE constructor on the parent Vehicle class
    public Car(string color, string make, string model) : base(3, color)
    {
        Make = make;
        Model = model;
        // NumPassengers = numPass;
    }
    public override void GetInfo()
    {
        // Vehicle.Getinfo();
        Console.WriteLine($"Num Passengers: {NumPassengers}");
        Console.WriteLine($"Color: {Color}");
        Console.WriteLine($"Miles: {Odometer}");
        Console.WriteLine($"Make: {Make}");
        Console.WriteLine($"Model: {Model}");
    }
}