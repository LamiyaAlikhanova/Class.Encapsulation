using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task105A.L2
{
    internal class Human
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
        public byte Age;
        private byte age
        {
            get 
            {
                return age;
            }
            set 
            {
                if (age >= 18)
                {
                    age = value;
                }
            }
        
        }

        public Human(string name, string surname, string gender, byte age)
        {
            Name = name;
            Surname = surname;
            Gender = gender;
            Age = age;
        }

        public string Getinfo()
        {
            return $"Name:{Name},Surname:{Surname},Gender:{Gender},Age:{Age}";

        }
        public void ShowInfo()
        {
            Console.WriteLine(Getinfo());
        }
            
    }
}
