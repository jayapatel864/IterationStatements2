using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {

            var numbers = new List<int>();

            // Create a do-while loop
            int init = 0;
            do
            {

                init++;
                numbers.Add(init);

            } while (init < 100);
            // Increment your variable by 1
            // Then add your variable to "numbers"
            
            while(init < 200)
            {
                init++;
                numbers.Add(init);



            }

            // While your variable is less than 100
            Console.WriteLine("Increase");
            foreach (var num in numbers)
            {
                Console.WriteLine($"{num}");
                

            }

            Console.WriteLine("Decrease");

            // Create a for loop
            // DONE in your initializer set the value of i to 199
            // in your conditional, as long as i is less than or equal to the length of "numbers"
            // AND as long as i is greater than or equal to 0
            // Decrement i by 1
            for (int i = 199; i <= numbers.Count && i >= 0; i--)
            {

                Console.WriteLine($"{numbers[i]}");

            }
        }
    }
}







            // Create a while loop
            // While your variable is less than 200

//Console.WriteLine("Increase:"); Increment your variable by 1
// Then add your variable to "numbers"




// Create a foreach loop
// Write your variable to the console



// Create a for loop
// in your initializer set the value of i to 199
// in your conditional, as long as i is less than or equal to the length of "numbers"
// and as long as i is greater than or equal to 0
// Decrement i by 1

// Write to the console "numbers" at index i
