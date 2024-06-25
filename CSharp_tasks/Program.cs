
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            Console.WriteLine(name);
            Console.WriteLine("//////////////////////////////////////////////////////////////////");
            string String= Console.ReadLine();
            int integer_value = Convert.ToInt32(Console.ReadLine());
            double double_value = Convert.ToDouble(Console.ReadLine());
            char char_value = Convert.ToChar(Console.ReadLine());
            bool bool_value = Convert.ToBoolean(Console.ReadLine());
            const double ip = 3.14;
            Console.WriteLine(String);
            Console.WriteLine(integer_value);
            Console.WriteLine(double_value);
            Console.WriteLine(char_value);
            Console.WriteLine(bool_value);
            Console.WriteLine(ip);
            Console.WriteLine("//////////////////////////////////////////////////////////////////");
            string car1 = Console.ReadLine();
            string car2 = Console.ReadLine();
            string car3 = Console.ReadLine();
            string[] cars = { car1, car2, car3 };
            Array.Sort(cars);
            Console.WriteLine(cars.Length);
            Console.WriteLine(cars[0]);
            Console.WriteLine(cars[1]);
            Console.WriteLine(cars[2]);
            Console.WriteLine("//////////////////////////////////////////////////////////////////");
            Console.Write("input your firstname:");
            string firstname = Console.ReadLine();
            Console.Write("input your lastname:");
            string lastname = Console.ReadLine();
            Console.Write("input your year of birth:");
            int birth = Convert.ToInt32(Console.ReadLine());
            Console.Write(firstname, lastname, birth);
            Console.WriteLine("//////////////////////////////////////////////////////////////////");
            Console.WriteLine();
            int i = 1;
            Console.WriteLine(i);
            Console.WriteLine(i);
            for (i = 2; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("//////////////////////////////////////////////////////////////////");


            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());
            int sum = num1 + num2 + num3;
            Console.WriteLine("Sum of all elements = " + sum);

            int num1_arr = Convert.ToInt32(Console.ReadLine());
            int num2_arr = Convert.ToInt32(Console.ReadLine());
            int num3_arr = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[] { num1_arr, num2_arr, num3_arr };
            int sum_arr = 0;
            for (int j = 0; j < arr.Length; j++)
            {
                sum_arr += arr[j];
            }
            Console.WriteLine("Sum of all elements stored in the array is = " + sum_arr);

            Console.ReadLine();





        }
    }
}

