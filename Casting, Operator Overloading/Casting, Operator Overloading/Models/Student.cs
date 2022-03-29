using System;
using System.Collections.Generic;
using System.Text;

namespace Casting__Operator_Overloading.Models
{
    public class Student : Person
    {
        
        public double Point { get; set; }
        public override string Name { get; set; }
        public override string SurName { get; set; }
        public override int Age { get; set; }

        private Student():base()
        {
            
        }
        public Student(string name, string surname, int age,double point):this()
        {
            this.Name = name;
            this.SurName = surname;
            this.Age = age;
            this.Point = point;
        }
        public  void ShowInfo(string Name, string SurName, int Age, double Point)
        {
            Console.WriteLine($"Id:{Id} Ad:{Name} Soyad:{SurName} Yas:{Age} Bal:{Point}");
        }
        public static bool operator >(Student student1,Student student2)
        {
            return student1.Point > student2.Point;
        }
        public static bool operator <(Student student1, Student student2)
        {
            return student1.Point < student2.Point;
        }
    }
}
