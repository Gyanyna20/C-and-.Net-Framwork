using System;

namespace EmployeeAssignment
{
    // Create the Employee class.
    public class Employee
    {
        // Employee properties.
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Overload == to compare Employee Ids.
        public static bool operator ==(Employee employee1, Employee employee2)
        {
            return employee1.Id == employee2.Id;
        }

        // Overload != because operators must be overloaded in pairs.
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            return employee1.Id != employee2.Id;
        }
    }

    // Main program.
    class Program
    {
        static void Main(string[] args)
        {
            // Create the first employee.
            Employee employee1 = new Employee();
            employee1.Id = 1;
            employee1.FirstName = "Gia";
            employee1.LastName = "Student";

            // Create the second employee.
            Employee employee2 = new Employee();
            employee2.Id = 2;
            employee2.FirstName = "Nina";
            employee2.LastName = "Student";

            // Compare the two employees by their Id.
            Console.WriteLine(employee1 == employee2);

            // Keep the console window open.
            Console.ReadLine();
        }
    }
}