using System;
using System.Runtime.InteropServices.ComTypes;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            Bird penguin = new Bird("Penguin", 4, 5, true, false, "medium", true, "questionable");
            penguin.BirdStats();

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *
             * Creatively display the class member values
             */
            Reptile tortoise = new Reptile("Tortoise", 4, 40, true, "Will Drown", true, "undoubtedly", true);
            
        }
    }
}
