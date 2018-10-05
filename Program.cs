﻿using System;
using System.Collections.Generic;

namespace Classes {
    public class Employee {
        public string firstName { get; set; }

        public string lastName { get; set; }

        public string title { get; set; }

        public DateTime startDate { get; set; }
    }

    public class Company {

        // Some readonly properties (let's talk about gets, baby)
        public string Name { get; }
        public DateTime CreatedOn { get; }

        // Create a public property for holding a list of current employees

        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

            The constructor will set the value of the public properties
        */
    }

    class Program {
        static void Main (string[] args) {
            // Create an instance of a company. Name it whatever you like.

            // Create three employees

            // Assign the employees to the company

            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
        }
    }
}