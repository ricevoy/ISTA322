﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Progex6
{
    class Vehicle
    {
        private string vehicleType;
        private string vehicleName;
        private string vehicleFunction;
        public void Drive()
        {
            Console.WriteLine($"The {vehicleName} drives across the battlefield");
        }

        public void Stop()
        {
            Console.WriteLine($"The {vehicleName} comes to a stop.");
        }

        public void Accelerate()
        {
            Console.WriteLine($"The {vehicleName} accelerates!");
        }

        public virtual void Refuel()
        {
            Console.WriteLine($"Time to refuel the {vehicleName}");
        }

        public virtual void BreakDown()
        {
            Console.WriteLine($"Oh no! The {vehicleName} broke down!");
        }

        public Vehicle()
        {
            vehicleType = "Default Vehicle Type";
            vehicleFunction = "Default Vehicle Function";
            vehicleName = "Default Vehicle Name";
        }

        public Vehicle(string vehicleType, string vehicleFunction, string vehicleName)
        {
            this.vehicleType = vehicleType;
            this.vehicleFunction = vehicleFunction;
            this.vehicleName = vehicleName;
        }

    }
}