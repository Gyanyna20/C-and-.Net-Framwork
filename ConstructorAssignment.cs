//Chain.cs
using System;
namespace ConstructorAssignment
{
    public class Chain
    {
        //Constructor if one parameter, a float, is provided
        public Chain(float num1) : this(num1, "Bob")
        {
            Console.WriteLine(num1 + " and your default name is " + Name);
        }
        //Constructor if one parameter, a string, is provided
        public Chain(string name1) : this(42, name1)
        {
            Console.WriteLine(name1 + " and your default favorite number is " + Num);
        }
        //Constructor if both parameters, a string and a float, are provided
        public Chain(float num, string name)
        {
            Name = name;
            Num = num;
        }
        string Name { get; set; }
        float Num { get; set; }
    }
}

//Program.cs
using Systom;
namespace ConstructorAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a const variable
            const string const1 = "Your name is: ";
            const string const2 = "Your favorite mumber is: ";
            Console.WriteLine("Enter your name or favorite number: ");
            //Create a variable using the var keyword
            var answer = Console,ReadLine();
            if (float. TryParse(answer, out float x))
            {
                Console.WriteLine(const2);
                Chain newChain = new Chain(x);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(const1);
                Chain newChain = new Chain(answer);
                Console.ReadLine();
            }
        }
    }
}
