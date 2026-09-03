using System;

namespace AbstractClassesAssignment
{
    // Create the Program class.
    class Program
    {
        // The Main method is where the program starts.
        static void Main(string[] args)
        {
            // Create an Employee object and assign values to its properties.
            Employee gia = new Employee()
            {
                firstName = "Sample",
                lastName = "Student",
                Id = 1
            };

            // Call the SayName() method on the Employee object.
            gia.SayName();

            // Use polymorphism to create an object of type IQuittable.
            // The Employee object can be assigned to an IQuittable variable
            // because the Employee class implements the IQuittable interface.
            IQuittable quittableEmployee = gia;

            // Call the Quit() method using the IQuittable object.
            quittableEmployee.Quit();

            // Keep the console window open so the output can be viewed.
            Console.ReadLine();
        }
    }
}
