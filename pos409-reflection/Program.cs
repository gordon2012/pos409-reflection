// Reflection
// Gordon Doskas
// POS/409
// June 20, 2016
// Carole Mckinney

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace pos409_reflection
{
    // Employee class
    //
    class Employee
    {
        // Getter and Setter properties
        //
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }

        // Constructor takes in first name, last name, and department
        //
        public Employee(string firstName, string lastName, string department)
        {
            FirstName = firstName;
            LastName = lastName;
            Department = department;
        }

        public void PrintProps()
        {
            // Uses Reflection to iterate through and print the properties of the employee
            //
            foreach (PropertyInfo prop in typeof(Employee).GetProperties())
	        {
                Console.WriteLine(prop.Name + ": " + prop.GetValue(this));
	        }
        }

        public void PrintMethods()
        {
            // Uses Reflection to iterate through and print the methods of the employee
            //
            foreach (MethodInfo method in typeof(Employee).GetMethods())
	        {
                Console.WriteLine(method.Name + ": " + method.GetBaseDefinition().ToString());
	        }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Reflection Demonstration Program");
            Console.WriteLine("===========================================");
            Console.WriteLine("This program uses Reflection to iterate through and print the properties");
            Console.WriteLine("and methods of an employee." + Environment.NewLine);

            Console.WriteLine("Press the Enter key to begin.");
            Console.ReadLine();


            // Creates a new employee
            //
            Employee employee = new Employee("John", "Smith", "Accounting");

            Console.WriteLine("Properties");
            Console.WriteLine("==========");
            employee.PrintProps();

            Console.WriteLine(Environment.NewLine + "Methods");
            Console.WriteLine("=======");
            employee.PrintMethods();

            // Hold console window open
            //
            Console.ReadLine();
        }


        

    }
}
