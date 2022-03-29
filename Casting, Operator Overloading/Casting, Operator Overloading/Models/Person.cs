using System;
using System.Collections.Generic;
using System.Text;

namespace Casting__Operator_Overloading.Models
{
    public abstract class Person
    {
        private  static int  _id = 0;
        public   int Id { get;}
       abstract public string Name { get; set; }
        abstract public string SurName { get; set; }
       abstract public int Age { get; set; }
        public  Person()
        {
            _id++;
            Id = _id;
        }
        public Person(string name, string surname, int age):this()
        {
            this.Name = name;
            this.SurName = surname;
            this.Age = age;
        }

        public virtual void ShowInfo(string Name, string SurName, int Age)
        {
            Console.WriteLine($"Id:{Id} Ad:{Name} Soyad:{SurName} Yas:{Age}");
        }
     

        
    }
    
}
