using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab_13
{
    class Program
    {        
        static void Main(string[] args)
        {
            // testing for both options. 
            param(4);

            param(2, 10);

            Console.ReadLine(); // to pause the program 
        }
        // Method containing optional parameter
        static public void param(int num, [Optional] int num2)
        {
            Console.WriteLine(num * num2);
        }


    }
}
