using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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
            
            Console.WriteLine("{0}, {1}", x, y);
            change(ref x,ref y);
            Console.WriteLine("{0}, {1}", x, y);
            /* ref usage
             *  when i write this line like this; change(x,y)
             * i will see this result: 3, 6 \n 6, 3 \n 3,6
             *  because x and y not change in our stack, we just declare another
             * variables and we change them,
             *  But i write change(ref x,ref y); ,
             * Its(ref) means that the argument referance our x and y
             * and directly change their values on our stack.
             * To use ref, make the methot argument like "ref int a", "ref int b" ,
             *  alsa make the paramethers like "ref a, ref b" .
             */

            //double sum = sumOfArray(15.6, 20,23.6,100);
            //Console.WriteLine("{0,5:0.##}",sum);
            //// :0.##} means coming 2 digits after comma.

            Console.WriteLine("{0,5:0.##}",sell(15.5));
            Console.WriteLine("{0,5:0.##}",sell(15.6,.1));


            /* Short cuts
             * 
             * cw = Console.WriteLine()
             * forr = for (int i = length - 1; i >= 0; i--)
             *\/// make summary 
             */

            Console.ReadKey();
            //just see the terminal
        }

        //----------- Method Examples ----------------------

        static void change(ref int a, ref int b)
        {
            int temp = a;
            a = b; 
            b = temp;
            Console.WriteLine("{0}, {1}",a,b);
        }


        /// <summary>
        /// Sell methot
        /// </summary>
        /// <param name="price">Total price</param>
        /// <returns>Total prince with KDV</returns>
        static double sell(double price)
        {
            return price * 1.20;
        }

        /// <summary>
        /// Sell methot
        /// </summary>
        /// <param name="price">Total price</param>
        /// <param name="discount">Discount rate</param>
        /// <returns>Total price with KDV and discount</returns>
        static double sell(double price, double discount)
        {
            return price * (1.0 - discount) * 1.18;
        }

        public static double sumOfArray(params double[] array)
        {//params makes the parametres changable.
            double sum = 0;

            foreach (double x in array)
                sum += x;
            return sum;
        }

        public static void compare(int number1, int number2)
        {
            if (number1 < number2)
                Console.WriteLine($"{number2} is bigger than {number1}.");
            else if (number1 > number2)
                Console.WriteLine($"{number1} is bigger than {number2}.");
            else Console.WriteLine($"They are equal.");
        }
        public static int compare2(int A, int B)
        {
            return A > B ? A : B;
        }

        static double square(double number)
        {
            return number*number;
        }


        //--------------------------------------------------------------

        private static void lists()
        {
            List<int> myList = new List<int>();
            //var myList = new List<int>();
            int[] array = new int[] { 10, 20, 30 };

            myList.Add(16);
            myList.Add(136);
            myList.Add(36);
            myList.AddRange(array);
            myList.AddRange(new int[] { 30, 40, 50 });

            //add an item on the spesific index
            myList.Insert(3, 0);
            myList.InsertRange(4, new int[] { 50, 60 });

            //remove 3rd index item
            myList.RemoveAt(3);
            myList.RemoveAt(myList.IndexOf(136));

            foreach (int i in myList)
            {
                Console.WriteLine($"{i,5} ");
            }
        }

        private static void arrayLists()
        {
            ArrayList myarraylist = new ArrayList();

            //ArrayList myarraylist = new ArrayList() {10, "Tuncay", 'T', true}

            myarraylist.Add(10);
            myarraylist.Add("Tuncay");
            myarraylist.Add('T');
            myarraylist.Add(true);

            foreach (var i in myarraylist)
            {
                Console.Write($"{i} ");
            }

            int[] numbers3 = new int[] { 22, 12, 25, 56 };
            myarraylist.AddRange(numbers3);
            Console.WriteLine();
            myarraylist.RemoveRange(3, 3);
            //star with 3rd index and delete the 3 items on the right side

            foreach (var i in myarraylist)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine($"\n{myarraylist[4]}");
        }

        private static void moreDimentionalArrays()
        {
            double[,] matris = new double[,] {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 } };

            double sum = 0;

            for (int i = 0; i < matris.GetLength(0); i++)
            {

                for (int j = 0; j < matris.GetLength(1); j++)
                {

                    if (i == j)
                        matris[i, j] = -1;

                    if (matris[i, j] % 2 == 0)
                        matris[i, j] = 0;

                    Console.Write($"{matris[i, j],5}");

                    sum += matris[i, j];
                }
                Console.WriteLine();
            }

            Console.WriteLine($"\nSum: {sum}");
        }

        private static void arraysAndforeach()
        {
            //lists
            int[] numbers = new int[3];

            numbers[0] = 3;
            numbers[1] = 5;
            numbers[2] = 7;

            /*
             * int[] numbers = new int[] {3, 5, 7};
             * int[] numbers = {3, 5, 7};
             */

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Numbers[{i}] =" +
                    $" {numbers[i]}");
            }

            Console.Write("Write a number to assign elements of array: ");
            var value = Convert.ToInt32(Console.ReadLine());

            int[] numbers2 = new int[value];
            var r = new Random();

            for (int i = 0; i < numbers2.Length; i++)
                numbers2[i] = r.Next(1, 100);


            foreach (int n in numbers2)
            {
                Console.WriteLine($"Numbers: {n,5}\t" +
                    $" Square of them: {n * n,5}");
            }
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
