using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//pouzitim :base(x) muze konstruktor dedit z nadrazeneho konstruktoru

namespace InheritanceOfConstructor
{
    class Person
    {
        public int age;
        //public Person() { }         //implicitní konstruktor nyní nevyužíváme, ale měl by v každé třídě být
        public Person(int v)
        {
            age = v;
        }
    }
    class Employee : Person
    {
        public int salary;
        //public Employee() { }   //implicitní konstruktor nyní nevyužíváme, ale měl by v každé třídě být
        public Employee(int v, int p)
          : base(v)
        {                //
                         //age = v; 
            salary = p;
        }
    }

    class Student : Person
    {
        public int scholarship;
        public Student(int v, int s)
          : base(v)
        {                //
                         //age = v;
            scholarship = s;
        }
        public void writeInfo()
        {
            Console.WriteLine("věk studenta: " + age + ", scholarship: " + scholarship);
        }
    }

    class Accountant : Employee
    {
        public Accountant(int v, int p)
          : base(v, p)
        {             //
                      //age = v;
                      //salary = p;
        }
        public void writeInfo()
        {
            Console.WriteLine("věk ekonomky: " + age + ", salary: " + salary);
        }
    }

    class Teacher : Employee
    {
        public int teachingTime;
        public Teacher(int v, int p, int u)
          : base(v, p)
        {             //
                      //age = v;
                      //salary = p;
            teachingTime = u;
        }
        public void writeInfo()
        {
            Console.Write("věk učitele:  " + age + ", salary: " + salary);
            Console.WriteLine(", počet úvazkových hodin: " + teachingTime);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "InheritanceOfConstructor";
            Student s1 = new Student(20, 1000);
            s1.writeInfo();
            Accountant e1 = new Accountant(30, 12000);
            e1.writeInfo();
            Teacher u1 = new Teacher(40, 20000, 22);
            u1.writeInfo();

        }
    }
}
