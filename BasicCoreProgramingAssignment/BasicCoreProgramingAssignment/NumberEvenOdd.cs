using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramingAssignment
{
    internal class NumberEvenOdd
    {
        public void EvenOdd()
        {
            Console.WriteLine("Enter one Number: ");
            int num=Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("Number is Even number");
            }
            else
            {
                Console.WriteLine("Number is odd Number");
            }


        }
    }
}
