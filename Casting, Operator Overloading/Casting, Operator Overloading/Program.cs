using System;
using Casting__Operator_Overloading.Models;
namespace Casting__Operator_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Console.WriteLine("--------Mekteb Proqrami-----------");
            Console.WriteLine("Telebe ucun-1\nMellim ucun-2\nInfo ucun-3\nCixis-0");
            int choose;
            do
            {
                Start:
                try
                {
                    choose = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    goto Start;
                }
                switch (choose)
                {
                    case 1:
                        string name;
                        try
                        {
                            Console.WriteLine("Ad daxil edin");
                            name = Console.ReadLine();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            goto Start;
                        }
                        string surname;
                        try
                        {
                            Console.WriteLine("Soyad daxil edin:");
                            surname = Console.ReadLine();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            goto Start;
                        }
                        int age;
                        try
                        {
                            do
                            {
                                Console.WriteLine("Yasinizi daxil edin:");
                                age = int.Parse(Console.ReadLine());
                            } while (age < 7 || age > 20);

                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            goto Start;
                        }
                        double point;
                        try
                        {
                            do
                            {
                                Console.WriteLine("Balinizi daxil edin:");
                                point = Convert.ToDouble(Console.ReadLine());
                            } while (point < 0 || point > 100);

                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            goto Start;
                        }
                        Student student1 = new Student(name, surname, age, point);
                        Student student2 = new Student(name, surname, age, point);
                        Console.WriteLine("----------------------");
                        Console.WriteLine(student1 < student2);
                        Console.WriteLine("----------------------");
                        student1.ShowInfo(name, surname, age, point);
                        break;
                    case 2:
                        string name1;
                        try
                        {
                            Console.WriteLine("Ad daxil edin");
                            name1 = Console.ReadLine();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            goto Start;
                        }
                        string surname1;
                        try
                        {
                            Console.WriteLine("Soyad daxil edin:");
                            surname1 = Console.ReadLine();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            goto Start;
                        }
                        int age1;
                        try
                        {
                            do
                            {
                                Console.WriteLine("Yasinizi daxil edin:");
                                age1 = int.Parse(Console.ReadLine());
                            } while (age1 > 18 || age1 < 65);

                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            goto Start;
                        }
                        double salary;
                        try
                        {
                            do
                            {
                                Console.WriteLine("Maasinizi Daxil edin:");
                                salary = Convert.ToDouble(Console.ReadLine());
                            } while (salary > 0);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            goto Start;
                        }
                        Teacher teacher1 = new Teacher(name1, surname1, age1, salary);
                        Teacher teacher2 = new Teacher(name1, surname1, age1, salary);
                        Console.WriteLine("----------------------");
                        Console.WriteLine(teacher1 < teacher2);
                        Console.WriteLine("----------------------");
                        teacher1.ShowInfo(name1, surname1, age1, salary);
                        break;
                    case 3:
                        Console.WriteLine("Telebe ucun-1\nMellim ucun-2\nInfo ucun-3\nCixis-0");
                        break;
                    default:
                        Console.WriteLine("sehv daxil etdiniz");
                        break;
                }
            } while (choose != 0);
           
            
            
           
        }
    }
}
