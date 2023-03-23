﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trestlebridge.Models.Interfaces;

namespace Trestlebridge.Models.Animals
{
    public class Cow : IGrazing
    {
        // Fields
        private Guid _id;

        // Properties
        public double FeedPerDay { get; set; }
        public string Location { get; set; }
        public Dictionary<string, double> Product { get; set; }

        // Constructor
        public Cow()
        {
            _id = Guid.NewGuid();
            FeedPerDay = 5.4;
            Location = "Grazing Fields";
            Product = new()
            {
                {"Meat", 18.25}
            };
        }

        // Methods

    }
}
