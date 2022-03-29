using System;
using System.Collections.Generic;
using System.Text;

namespace Casting__Operator_Overloading.Models
{
    class Teacher : Person
    {
        public override string Name { get; set; }
        public override string SurName { get; set; }
        public override int Age { get; set; }
        public double Salary { get; set; }

        private Teacher():base()
        {

        }
        public Teacher(string name,string surname,int age,double salary)
        {
            this.Name = name;
            this.SurName = surname;
            this.Age = age;
            this.Salary = salary;
        }
        public void ShowInfo(string Name, string SurName, int Age, double Salary)
        {
            Console.WriteLine($"Id:{Id} Ad:{Name} Soyad:{SurName} Yas:{Age} Maas:{Salary}");
        }
        public static bool operator >(Teacher teacher1, Teacher teacher2)
        {
            return teacher1.Salary > teacher2.Salary;
        }
        public static bool operator <(Teacher teacher1, Teacher teacher2)
        {
            return teacher1.Salary < teacher2.Salary;
        }
    }
}
