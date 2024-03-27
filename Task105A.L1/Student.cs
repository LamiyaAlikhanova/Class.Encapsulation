using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task105A.L1
{
    internal class Student:Person
    {
        public string StudentId { get; set; }
        private int point;
        public int Point 
        { 
            get 
            {
                return point;
            }
            set 
            {
                if (value < 0 || value > 100)
                {
                    point = value;

                }

            }
        }

        public Student ( string name , string surname, byte age, string studentId, int point): base (name,surname, age)
        {
            StudentId = studentId;
            Point = point;
           
        }

        public void ShowInfo()
        {
            Console.WriteLine($"name:{Name},surname:{Surname},age:{Age}, studentId:{StudentId},point:{Point}");
        }
    }
}
