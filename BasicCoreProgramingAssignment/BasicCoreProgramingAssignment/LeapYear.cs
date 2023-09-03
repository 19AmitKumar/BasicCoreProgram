using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramingAssignment
{
    internal class LeapYear
    {
        public void CheckYear() 
        {
            Console.WriteLine("Enter the Year:");
            int year = Convert.ToInt32(Console.ReadLine());
            if(year%4 == 0 && year%100 != 0 || year%400==0) 
            {
                Console.WriteLine("Year is Leap Year!!");
            }
            else {
                Console.WriteLine("Year is not Leap year!!");
            }
        }
    }
}
