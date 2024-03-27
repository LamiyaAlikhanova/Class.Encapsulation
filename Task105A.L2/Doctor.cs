using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task105A.L2
{
    internal class Doctor:Human
    {
        public string Speciality { get; set; }
        public int Experience;
        private int experience
        {
            get 
            { 
                return experience;
            }
            set
            {
                if (experience >= 18)
                {
                experience = value;
                }

            }
        }

        public Doctor( string name,string surname ,string gender ,byte age,string speciality, int experience):base (name,surname,gender,age)
        {
            Experience = experience;
            Speciality = speciality;
        }
        public new string GetInfo()
        {
            return $"Name:{Name},Surname:{Surname},Gender:{Gender},Age:{Age},Speciality:{Speciality},Experience:{Experience}";
        }
        public new void ShowInfo()
        {
           Console.WriteLine(GetInfo());
        }
    }
}
