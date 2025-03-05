using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp2___prime_or_not
{
    internal class Program
    {
        static void Main(string[] args)
        {// prime or not
          /*  int num, i, count = 0;
            Console.Write("Input a number: ");
            num = Convert.ToInt32(Console.ReadLine());
            for (i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    count++;
                    break;
                }
            }
            if (count == 0 && num != 1)
                Console.Write("{0} is a prime number.\n", num);
            else
                Console.Write("{0} is not a prime number\n", num);
            Console.ReadLine();*/

            // prime or not using while loop   //
            
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            int i = 2;
            bool isPrime = true;
            while (i <= num / 2)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                    break;
                }
                i++;
            }if (isPrime)
            {
                Console.WriteLine(num + " is a prime number");
            }
            else
            {
                Console.WriteLine(num + " is not a prime number");
            }
            Console.ReadLine();
        }
    }
}
