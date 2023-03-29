﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trestlebridge.Models.Facilities
{
    public class DuckHouse : IFacility
    {
        // Fields
        private Guid _id;

        // Properties
        public string Name { get; set; }
        public int Capacity { get; }
        public int CurrentAmount { get; set; }

        // Methods
        public void AddResource(IResource duck, int amount)
        {
            if (CurrentAmount + amount > Capacity)
            {
                Console.WriteLine(@"
This facility does not have the capacity to add that amount of ducks.
Please lower your amount or add another facility.");
            }
            else if (CurrentAmount + amount == Capacity)
            {
                CurrentAmount = CurrentAmount + amount;
                Console.WriteLine("Ducks added to facility. This facility is now at capacity!");
            }
            else
            {
                CurrentAmount = CurrentAmount + amount;
                Console.WriteLine($"Ducks added to facility. This facility is now at {CurrentAmount}/{Capacity} capacity!");
            }
        }

        // Constructor
        public DuckHouse(string name)
        {
            _id = Guid.NewGuid();
            Name = name;
            Capacity = 12;
            CurrentAmount = 0;
        }
    }
}
