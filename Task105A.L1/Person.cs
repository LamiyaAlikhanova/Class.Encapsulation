using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task105A.L1
{
    internal class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        private byte age;
        public byte Age
        { 
            get 
            { 
                return age;
            }
            set 
            {
                if (value < 0)
                {
                    age = value;
                }
            }
        }

        public Person(string name, string surname, byte age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }
    }
}
