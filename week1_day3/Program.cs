using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1_day3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int firstNumber = 2;
            int secondNumber = 6;

            if(firstNumber > secondNumber)
            {
                //Do somethingr
                Console.WriteLine("Math no work, nice job.");
            }
            else
            {
                //do something else
                Console.WriteLine("Math works, good.");
            } */
        

            Console.WriteLine("What day is today? ");
            String userAnswer = Console.ReadLine();

            if (userAnswer == "Monday" || userAnswer == "monday")
            {
                Console.WriteLine("Back to work.");
            }
            else if (userAnswer == "Friday" || userAnswer == "friday")
            {
                Console.WriteLine("TGIF!");
            }
            else
            {
                Console.WriteLine("Bloop.");
            }


        } 
    }
}
