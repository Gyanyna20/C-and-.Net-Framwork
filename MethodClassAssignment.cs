using System;

// Create a class that represents a bouquet of flowers.
class BouquetOfFlowers
{
    // Create a void method that takes two integers as parameters.
    public void CalculateFlowers(int flowersPerBouquet, int numberOfBouquets)
    {
        // Multiply the number of flowers in each bouquet by the number of bouquets.
        int totalFlowers = flowersPerBouquet * numberOfBouquets;

        // Display the total number of flowers on the screen.
        Console.WriteLine("Total number of flowers: " + totalFlowers);

        // Display the second integer, which represents the number of bouquets.
        Console.WriteLine("Number of bouquets: " + numberOfBouquets);
    }
}

// Create the main class for the console application.
class Program
{
    // The Main method is where the console application starts.
    static void Main(string[] args)
    {
        // Instantiate an object of the BouquetOfFlowers class.
        BouquetOfFlowers bouquet = new BouquetOfFlowers();

        // Call the method and pass in two numbers.
        // Each bouquet contains 6 flowers, and there are 3 bouquets.
        bouquet.CalculateFlowers(6, 3);

        // Call the method again using named parameters.
        // Each bouquet contains 8 flowers, and there are 4 bouquets.
        bouquet.CalculateFlowers(flowersPerBouquet: 8, numberOfBouquets: 4);

        // Keep the console window open so the results can be viewed.
        Console.ReadLine();
    }
}