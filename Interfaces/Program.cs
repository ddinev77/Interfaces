﻿namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IPerson> people = new List<IPerson>();

            IPerson employee1 = new Employee("Стоян", 54);
            IPerson employee2 = new Employee("Петър", 35);

            IPerson manager1 = new Manager("Диан", 17, "RR");
            IPerson manager2 = new Manager("Моника", 17, "MG");

            people.Add(manager1);
            people.Add(manager2);
            people.Add(employee1);
            people.Add(employee2);

            foreach (IPerson person in people) 
            {
                Console.WriteLine(employee1.ToString());
                Console.WriteLine(employee2.ToString());
                Console.WriteLine(manager1.ToString());
                Console.WriteLine(manager2.ToString());
            }

        }
    }
}