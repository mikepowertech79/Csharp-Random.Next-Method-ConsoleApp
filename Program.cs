using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Random.Next___Method_ConsoleApp
{
    class Program
    {
        //https://www.geeksforgeeks.org/c-sharp-random-next-method/#:~:text=(Int32%2C%20Int32)-,Next()%20Method,0%20and%20less%20than%20MaxValue.

        //https://docs.microsoft.com/en-us/dotnet/api/system.random.next?view=net-5.0
        public static void Main()
        {
            // Instantiate random number generator 
            Random rand = new Random();

            // Print 10 random numbers between 50 and 100 
            Console.WriteLine("Printing 10 random numbers" +
                              " between 50 and 100");
            for (int i = 1; i <= 10; i++)
                Console.WriteLine("{0} -> {1}", i, rand.Next(50, 100));
        }
    }
}
