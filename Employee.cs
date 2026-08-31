
using System;

namespace AbstractClassesAssignment
{
    // Create the IQuittable interface.
    public interface IQuittable
    {
        // Define a void method called Quit().
        void Quit();
    }

    // Create the Employee class and inherit from the Person class.
    // The Employee class also implements the IQuittable interface.
    public class Employee : Person, IQuittable
    {
        // Create an integer property to store the employee's ID.
        public int Id { get; set; }

        // Implement the SayName() method inherited from the Person class.
        public override void SayName()
        {
            // Display the employee's first and last name.
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }

        // Implement the Quit() method required by the IQuittable interface.
        public void Quit()
        {
            // Display a message when the employee quits.
            Console.WriteLine(firstName + " " + lastName + " has quit the company.");
        }
    }
}