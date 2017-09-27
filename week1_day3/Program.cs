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

            /*
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
            */
            /*
            Console.WriteLine("How old are you? ");
            int userAge = int.Parse(Console.ReadLine());

            if (userAge >= 0 && userAge <= 1)
            {
                Console.WriteLine("You're just a baby!");
            }
            else if (userAge > 1 && userAge < 4)
            {
                Console.WriteLine("Yat toddlers!");
            }
            else if (userAge >= 4 && userAge < 13)
            {
                Console.WriteLine("Enjoy your chilehood.");
            }
            else if (userAge >= 13 && userAge < 65)
            {
                Console.WriteLine("Life is awkward");
            }
            else if (userAge >= 65 && userAge < 100)
            {
                Console.WriteLine("Enjoy your retirement.");
            }
            else
            {
                Console.WriteLine("That's not really your age.");
            }
            */

            /*
            Console.WriteLine("How many points did you earn?");
            int pointsEarned = int.Parse(Console.ReadLine());


            switch (pointsEarned)
            {
                case 0:
                    Console.WriteLine("You lose.");
                    break;

                case 1:
                    Console.WriteLine("Neds practice.");
                    break;

                case 2:
                    Console.WriteLine("On target.");
                    break;

                case 3:
                    Console.WriteLine("Superstar.");
                    break;

                case 4:
                    Console.WriteLine("Overachiever.");
                    break;

                case 5:
                    Console.WriteLine("You cheated.");
                    break;

                default:
                    Console.WriteLine("Invalid score entered.");
                    break;
            }
            */

            int numDiners = 4;
            Double amountPaid = 13;
            Double totalAmount = numDiners * amountPaid;

            //Console.WriteLine(totalAmount);

            Console.WriteLine("How many people went to dinner?");
            numDiners = int.Parse(Console.ReadLine());

            Console.WriteLine("How much did each person pay?");
            amountPaid = Double.Parse(Console.ReadLine());
            totalAmount = amountPaid * numDiners;
            double finalBill;
            if (totalAmount >= 50)
            {
                finalBill = totalAmount * 0.9;
            }
            else
            {
                finalBill = totalAmount * 0.95; 
            }

            // Console.WriteLine("The total amount spent was $" + totalBill);
            Console.WriteLine("Your discounted bill is $" + finalBill);


        }
    }
}
