using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2._1._1
{
    public static class Basic
    {
             
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int d= 0;
            int i = 2;

            while (i < number)
            {
                if (number % i == 0)
                {
                    d++;
                }
                else
                {
                    i++;
                }
                if (d == 0)
                {
                    Console.WriteLine("d-простое число");
                }
                else
                {
                    Console.WriteLine("d-непростое число");
                }
                break;
            }
            
        }
    }
}
