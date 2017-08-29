using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCCIweek3LoopsTextPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //while loops
            //simple counting

            int counter1 = 0;

            while (counter1 <= 9)
            {
                Console.WriteLine("Number: " + counter1);
                counter1++;
            }

            //summing a sequence of numbers

            Console.WriteLine("\nEnter a smallish number:");
            int input1 = int.Parse(Console.ReadLine());

            int num = 1; //starts us at 1
            int sum = 1; //starts the adding with first digit

            Console.Write($"The sum of 1");

            while (num < input1)
            {
                num++;
                sum += num;
                Console.Write(" + " + num);
            }
                //fyi, you had bad formatting in an earlier exercise
                //because you used writeline instead of write

            Console.WriteLine(" = " + sum);

            //program to check if a number is prime

            Console.WriteLine("\nEnter a positive integer.");
            int num2 = int.Parse(Console.ReadLine());

            int divider = 2;  //2 is smallest possible divider
            int maxDivider = (int)Math.Sqrt(num2);  //a number's square root is its larges possible divider
            bool prime = true;

            while (prime && (divider <= maxDivider))  //runs so long as prime is not false
            {
                if (num2 % divider == 0) //each time it divides by a new number. 
                                         //until it reaches the number's square root.
                                         //if no remainder... not prime.
                {
                    prime = false;
                }
                divider++;
            }

            Console.WriteLine($"Is the number {num2} prime? " + prime);

            //breaks
            //practice in a factorial exercise

            Console.ReadLine();

        }
    }
}
