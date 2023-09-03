using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramingAssignment
{
    internal class SwapNumbers
    {
        public void swap() 
        {
            Console.WriteLine("Enter First Number: ");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number: ");
            int b=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Number Before Swaping: "+a+" "+b);
            int temp;
            temp = a;
            a= b; 
            b = temp;
            Console.WriteLine("Number After Swaping: " + a + " " + b);
        }
    }
}
