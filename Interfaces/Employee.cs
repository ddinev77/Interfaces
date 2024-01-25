using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Employee : IPerson
    {
		private int age;
        private string name;

        public int Age
		{
			get { return this.age; }
			private set { if (value >= 0)
                    if (value >= 0)
                    {
                        this.age = value;
                    }
                    else
                    {
                        throw new Exception("Invalid age");
                    }		
			}
		}
		
		public string Name
        {
            get { return this.name; }
            private set
            {
                if (value != string.Empty)
                {
                    this.name = value;
                }
                else
                {
                    throw new Exception("Invalid name");
                }
            }
        }

        public Employee(string name, int age)
        {
            this.Name = name;
			this.Age = age;
        }

		public bool IsAdult() => Age >= 18;

		string IPerson.ToString() 
		{
			return $"Name: {this.Name}, Age: {this.Age}, IsAdult{this.IsAdult()}";
        }
        
    }
}
