using System;
using System.Collections.Generic;
using System.Xml.Schema;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values


            Car car = new Car()
            {
                Year = "2014",
                Make = "Dodge",
                Model = "Charger",
                Owner = "John",
                SpeedLimiter = true,
                Logo = "John, Inc",
                HasTrunk = true,
                TopSpeed = "188 mph"
            };
           //Console.WriteLine ($"Governed: {car.SpeedLimiter}   Logo: {car.Logo}   Has a trunk: {car.HasTrunk}   Top Speed: {car.TopSpeed}");

            Truck truck = new Truck()
            {
                Year = "1998",
                Make = "Toyota",
                Model = "Tundra",
                Owner = "Derrick",
                SpeedLimiter = false,
                Logo = "Los Vatos,LLC",
                BedSize = "short",
                TypeTires = "Offroad"
            };
            //Console.WriteLine($"Governed: {truck.SpeedLimiter}    Logo: {truck.Logo}    Bed Size: {truck.BedSize}    Tires: {truck.TypeTires}");
            SUV sUV = new SUV()
            {
                Year = "2018",
                Make = "Chevrolet",
                Model = "Tahoe",
                Owner = "Patrick",
                SpeedLimiter = false,
                Logo = "Black Cap, Inc",
                Package = "LT",
                CargoSize = "small"
            };
            List<IVehicle> vehicles = new List<IVehicle>();

            vehicles.Add(car);
            vehicles.Add(truck);
            vehicles.Add(sUV);

            foreach (IVehicle vehicle in vehicles)
            {
                vehicle.PrintToConsole();

            }
            



        }
    }
}
