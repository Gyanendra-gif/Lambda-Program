﻿using System;
using System.Collections.Generic;

namespace Lambda_Programs
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Data Management Program Using Lambda");
            Operation operation = new Operation();
            List<Persons> listPersonsInCity = new List<Persons>();
            operation.AddRecords(listPersonsInCity);
        }
    }
}