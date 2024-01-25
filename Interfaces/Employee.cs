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
			private set { if (value < 0) 
				{
					throw new Exception("Invalid age");
				}
				this.age = value;			
			}
		}
		
		public string Name
		{
			get { return this.name; }
            private set
            {
                if (String.IsNullOrEmpty(value))
                {
					throw new Exception("Invalid name");
				} 
			}
		}

        public Employee(string name, int age)
        {
            this.name = Name;
			this.age = Age;
        }

		public bool IsAdult() => Age >= 18;

		public override string ToString() 
		{
			return base.ToString() + $"Name: {Name}, Age: {Age}, IsAdult{IsAdult}";
        }
        
    }
}
