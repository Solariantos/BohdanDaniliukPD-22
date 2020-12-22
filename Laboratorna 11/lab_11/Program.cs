using System;
using System.Collections.Generic;

namespace lab_11
{
    delegate void myDelegate(Car car);
    delegate bool stDeleg(Student student);

    class Program
    {
        public static void showStudent(in List<Student> ls)
        {
            foreach(var student in ls)
            {
                Console.WriteLine($"\tFirstName - {student.FirstName}");
                Console.WriteLine($"\tLastName - {student.LastName}");
                Console.WriteLine($"\tAge - {student.Age}");
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
       
            Console.WriteLine("\t\t\tЗавдання 1\n");
            Car car = new Car();
            STO sto = new STO();

            myDelegate my_Delegate = new myDelegate(sto.collapseClimbDone);
            my_Delegate += sto.painted;
            my_Delegate += sto.bodyRepairPerformed;
            my_Delegate(car);
            car.showInfo();
     
            Console.WriteLine(new string('-', 80));
            Console.WriteLine("\t\t\tЗавдання 2");
        

            List<Student> group = new List<Student>();
            group.Add(new Student("Bohdan", "Daniliuk", 19));
            group.Add(new Student("Bohdan", "Student", 18));
            group.Add(new Student("Vitaliy", "Voloshyn", 20));
            group.Add(new Student("Eduard", "Petrenko", 17));
            group.Add(new Student("Valera", "Dmytryshyn", 19));
            group.Add(new Student("Valera", "Bilous", 18));
            group.Add(new Student("Artem", "Iluchenko", 17));
            group.Add(new Student("Anton", "Atamas", 21));
            group.Add(new Student("Dana", "Prokopets", 40));
            group.Add(new Student("Dmytro", "Vdovin", 23));


            List<Student> results = new List<Student>();
            stDeleg del;

            //Завдання 2.8
            
            Console.WriteLine();
            del = Student.isAge18;
            results =  group.FindStudent(del);
            showStudent(in results);

            Console.WriteLine(new string('-', 80));
            Console.WriteLine("\t\t\tЗавдання 2.8");
            results.Clear();
            del = Student.isFirstNameBeginFromA;
            results = group.FindStudent(del);
            showStudent(in results);

            Console.WriteLine(new string('-', 40));
            results.Clear();
            del = Student.isLastNameLengthMoreThan3;
            results = group.FindStudent(del);
            showStudent(in results);

            
            Console.WriteLine(new string('-', 80));
            Console.WriteLine("\t\t\tЗавдання 2.9");
            results.Clear();
            del = student => student.Age >= 18;
            results = group.FindStudent(del);
            showStudent(in results);

            Console.WriteLine(new string('-', 40));
            results.Clear();
            del = student => student.FirstName.ToCharArray()[0] == 'A';
            results = group.FindStudent(del);
            showStudent(in results);

            Console.WriteLine(new string('-', 40));
            results.Clear();
            del = student => student.FirstName.Length > 3;
            results = group.FindStudent(del);
            showStudent(in results);

         
            Console.WriteLine(new string('-', 80));
            Console.WriteLine("\t\t\tЗавдання 2.10");
            results.Clear();
            del = student => student.Age >= 20 && student.Age <= 25;
            results = group.FindStudent(del);
            showStudent(in results);

         
            
            Console.WriteLine(new string('-', 80));
            Console.WriteLine("\t\t\tЗавдання 2.11");
            results.Clear();
            del = student => student.FirstName == "Anton";
            results = group.FindStudent(del);
            showStudent(in results);

    
           
            Console.WriteLine(new string('-', 80));
            Console.WriteLine("\t\t\tЗавдання 2.12");
            results.Clear();
            del = student => student.LastName == "Petrenko";
            results = group.FindStudent(del);
            showStudent(in results);

            Console.ReadKey();
        }
    }
    static class Extension
    {
        public static List<Student> FindStudent(this List<Student> ls, stDeleg del)
        {
            List<Student> tempList = new List<Student>();
            foreach (var student in ls)
            {
                if (del.Invoke(student))
                    tempList.Add(student);
            }
            return tempList;
        }
    }
}
