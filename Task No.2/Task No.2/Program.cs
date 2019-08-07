using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Task_No._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = ReadLine();
            int temp = 0;
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] == number[number.Length - 1 - i])
                {
                    temp++;
                }
                else
                {
                    temp = 0;
                }
            }
            if (temp == number.Length)
            {
                WriteLine("The number is polindrome...");
            }
            else
            {
                WriteLine("The number is not polindrome...");
            }


           
        }
    }
}
