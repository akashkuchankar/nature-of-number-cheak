using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter any number");
                int a= Convert.ToInt32(Console.ReadLine());
            if(a==0)
            {
                Console.WriteLine("number is zero");
              }
            if(a>0)
                {
                Console.WriteLine("number is positive");
            }else 
            {
                Console.WriteLine("number is negative");
            }
            Console.ReadLine();  
        }
    }
}
