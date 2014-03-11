using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {       
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            number.num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the power: ");
            number.powerValue = Convert.ToInt32(Console.ReadLine());
            number.result = number.num;
            for (int i = 1; i < number.powerValue; i++)
            {
                number.result = number.result * number.num;
            }
            number.power();            
        }
    }
    class number
    {
        public static int num;
        public static int powerValue;
        public static int result;
        public static void power()
        {
            
            Console.WriteLine("Power of {0} is {1}", num, result);
            Console.ReadLine();
        }
    }




}
