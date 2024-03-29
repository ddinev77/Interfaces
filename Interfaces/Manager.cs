﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Manager : Employee, IPerson
    {
        private string department;

        public Manager(string name, int age, string department) : base (name, age) 
        {
            this.department = department;
        }

        string IPerson.ToString()
        {
            return $"Name: {Name}, Age: {Age}, Deparment: {this.department} IsAdult {this.IsAdult}";
        }

    }
}
