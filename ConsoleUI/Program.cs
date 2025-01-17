﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var vehicle = new List<Vehicle>();

            Car car1 = new Car()
            {   HasTrunk = true,
                Make = "Hyundai",
                Model = "Kona",
                Year = 2022
            };
            Motorcycle motorcycle1 = new Motorcycle()
            {   HasSideCar = true,
                Model = "EL Knucklehead",
                Make = "Harley",
                Year = 1936
            };
            Vehicle vehicle1 = new Car()
            {
                HasTrunk = false,
                Make = "Chevy",
                Model = "Nova",
                Year = 1974
            };
            Vehicle vehicle2 = new Motorcycle()
            {
                HasSideCar = false,
                Make = "Honda",
                Model = "Super Cub",
                Year = 1958
            };

            vehicle.Add(car1);
            vehicle.Add(motorcycle1);
            vehicle.Add(vehicle1);
            vehicle.Add(vehicle2);

            foreach(var automobile in vehicle)
            {
                Console.WriteLine($"Make: {automobile.Make} Model: {automobile.Model} Year: {automobile.Year}");
                automobile.DriveAbstract();
                automobile.DriveVirtual();
                Console.WriteLine("");
            }

            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle DONE
             * The vehicle class shall have three string properties Year, Make, and Model DONE
             * Set the defaults to something generic in the Vehicle class DONE
             * Vehicle shall have an abstract method called DriveAbstract with no implementation DONE
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation. DONE
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle DONE
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle DONE
             * Provide the implementations for the abstract methods DONE
             * Only in the Motorcycle class will you override the virtual drive method DONE
            */

            // Create a list of Vehicle called vehicles DONE

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) 
             * but use constuctors from derived classes DONE
             * 
             * Set the properties with object initializer syntax DONE
             */

            /*
             * Add the 4 vehicles to the list DONE
             * Using a foreach loop iterate over each of the properties DONE
             */

            // Call each of the drive methods for one car and one motorcycle DONE

            #endregion            
            Console.ReadLine();
        }
    }
}
