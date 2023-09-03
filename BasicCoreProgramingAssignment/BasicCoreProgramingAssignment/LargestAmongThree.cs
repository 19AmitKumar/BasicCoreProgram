using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramingAssignment
{
    internal class LargestAmongThree
    {
        public void Largest() 
        {
            Console.WriteLine("Enter first Number: ");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number: ");
            int b=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third Number: ");
            int c=Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine("The largest Number is: "+a);
                }
                else
                {
                    Console.WriteLine("The largest Number is:" + c);
                }
            }
            else
            {
                if (b > c)
                {
                    Console.WriteLine("The largest Number is: "+b);
                }
                else
                {
                    Console.WriteLine("The largest Number is: "+c);
                }
            }
            
        }
    }
}
