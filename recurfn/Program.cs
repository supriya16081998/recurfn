using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recurfn
{
    class demo
    {
       
        public int facto(int x)
        {
            if(x==1)
            {
                return 1;
            }
            else
            {
                return x* facto(x-1);
            }
             
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            demo d1 = new demo();
            Console.WriteLine("Enter a number:");
            int a = Convert.ToInt32(Console.ReadLine());
            int fact=d1.facto(a);
            Console.WriteLine("Factorial of {0} is {1}",a, fact);
            Console.ReadLine();
        }
    }
}
