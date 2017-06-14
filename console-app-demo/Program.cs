using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_app_demo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number1");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number2");
            int number2 = int.Parse(Console.ReadLine());
            int result = Addition(number1, number2);
            Console.WriteLine("The result is : " + result);
            Console.ReadLine();
        }

        public static int Addition(int number1, int number2)
        {
            return number1 + number2;
        }
    }
}
