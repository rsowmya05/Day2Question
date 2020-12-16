using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Question
{
    class Program
    {
        static void Main(string[] args)
        {
            int min, max, i, j, flag;      
            
            Console.WriteLine("Enter min value: ");
            min = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter max value: ");
            max = int.Parse(Console.ReadLine());

            Console.WriteLine("\nPrime numbers between {0} and {1} : ", min, max);
            for (i = min; i <= max; i++)
            {
                if (i == 1 || i == 0)
                    continue;
                flag = 1;

                for (j = 2; j <= i / 2; ++j)
                {
                    if (i % j == 0)
                    {
                        flag = 0;
                        break;
                    }
                }
                if (flag == 1)
                {
                    Console.WriteLine(i);
                }
                    
            }
            Console.ReadKey();
        }
        
    }
    
}
