using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        enum Calculations
        {
            add,       //index = 0 for default
            subtract,  //index = 1 for default
            multiply,  //index = 2 for default
            divide     //index = 3 for default
            /*But we can change it like this;
             * add = 1,
             * subtract =2, ...
             */
        }


        static void Main(string[] args)
        {

            Console.Write("Tuncay");
            Console.WriteLine(" Çelikkanat");

            int x = 3;
            var y = x * 2;
            // var - örtülü değişken
            //var uses to make equal the type of 'y' with the other side of the equality.




            /* Short cuts
             * 
             * cw = Console.WriteLine()
             * forr = for (int i = length - 1; i >= 0; i--)
             */

            Console.ReadKey();
            //just see the terminal
        }

        private static void forExample()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 5 == 0)
                {
                    Console.WriteLine("Boom!");
                    continue;
                }
                Console.Write("{0,-5}", i);
            }

            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(" * ");
                }
                Console.WriteLine();
            }
        }

        private static void whileExample()
        {
            //do-while is classic so i do not write an example

            int counter = 0;
            int counter2 = 0;
            while (counter < 10)
            {
                Console.WriteLine(counter);
                counter++;
            }

            while (counter2 < 10)
            {
                counter2++;
                Console.WriteLine("\t{0,-5} {1,-5}", counter2, counter2 * counter2);
                /*0 is the variable, 5 is the space between them and its changable;
                 Pozitif values put space the left side, negatives right side
                 */
            }
        }

        private static void switchCase()
        {
            double A, B;

            Console.Write("Write first number: ");
            A = Convert.ToDouble(Console.ReadLine());

            Console.Write("Write second number: ");
            B = Convert.ToDouble(Console.ReadLine());

            Console.Write("And make your choice\n(0) for add\n(1) for subtract\n(2) for multiply\n(3) for divide: ");
            Calculations choice = (Calculations)Convert.ToInt32(Console.ReadLine());
            /* Or we can randomly make a choice;
            Calculations choice = (Calculations)(new Random().Next(0,4));
            */

            switch (choice)
            {
                case Calculations.add:
                    Console.WriteLine($"{A} + {B} = {A + B}");
                    break;
                case Calculations.subtract:
                    Console.WriteLine($"{A} - {B} = {A - B}");
                    break;
                case Calculations.multiply:
                    Console.WriteLine($"{A} x {B} = {A * B}");
                    break;
                case Calculations.divide:
                    Console.WriteLine($"{A} / {B} = {A / B}");
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
        }

        private static void ifElseifElse()
        {
            var k = (char)Console.Read();
            /*Console.Read() return an int value that asign the chars,
             and (char) converts the number to char*/

            if (char.IsDigit(k))
            {
                Console.WriteLine("Its a digit.");
            }
            else if (char.IsLower(k))
            {
                Console.WriteLine("Its lower.");
            }
            else if (char.IsUpper(k))
            {
                Console.WriteLine("Its upper.");
            }
            else
            {
                Console.WriteLine("Unknown char.");
            }
        }

        private static void tabAndSpace()
        {
            Console.WriteLine("\aHello \n\"World\"");
            /* \n, \t, \" same with java
             \a play an alert when run the program*/
        }

        private static void typesUsage()
        {
            int number1 = 1;
            double pi = 3.14;
            char firstLetter = 'T';
            string name = "Tuncay";
            bool isTrue = true;
            Console.WriteLine(number1 + pi);
            Console.WriteLine(name + isTrue + firstLetter);
            //usage of types
        }

        private static void likeScanner()
        {
            var text = Console.ReadLine();
            //like scanner, read and save the input from user
            Console.WriteLine(text);
        }

        private static void stringOperators()
        {
            var text3 = "Heellooooo minecraft";
            Console.WriteLine(text3.ToUpper());
            Console.WriteLine(text3.ToLower());
            Console.WriteLine(text3.Length);
            Console.WriteLine(text3.TrimStart());
            Console.WriteLine(text3.TrimEnd());
            Console.WriteLine(text3.Trim(text3[0]));
        }

        private static void readKey()
        {
            var text2 = Console.ReadKey();
            Console.WriteLine(text2.Key);
            Console.WriteLine(text2.KeyChar);
        }

        private static void operators()
        {
            int number2 = 20, number3 = 11;
            //Aritmetic Operators
            Console.WriteLine(number2 + number3);
            Console.WriteLine(number2 - number3);
            Console.WriteLine(number2 % number3);

            //Relational Operators
            Console.WriteLine(number3 < number2);
            Console.WriteLine(number3 >= number2);
            Console.WriteLine(number3 == number2);
            Console.WriteLine(number3 != number2);
            // || = or, && = and
        }

        private static void oddOrEven()
        {
            Console.WriteLine("Write a number: ");
            int number4 = Convert.ToInt32(Console.ReadLine());

            if (number4 % 2 == 0)
            {
                Console.WriteLine($"This is an even number ({number4})");
            }
            else
            {
                Console.WriteLine($"This is an odd number ({number4})");
            }
        }
    }
}
