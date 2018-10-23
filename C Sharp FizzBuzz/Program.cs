using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            //Step 1: Print number from 1 - 100
            for (int j = 1; j <= 100; j++)
            {
                string results = "";

                //Step 2: Divisible by 3 print Fizz
                if (j % 3 == 0) results = "Fizz";

                //Step 3: Divisible by 5 print Buzz
                if (j % 5 == 0) results += "Buzz";

                //Step 4: Divisible by 3 and 3 print FizzBuzz


                //Step 5: Print number as it is if not divisible by 3 or 5
                if (results.Length == 0) results = j.ToString();

                Console.WriteLine(results);
            }
        }
    }
}
