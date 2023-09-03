using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramingAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Choice:- ");
            int d = Convert.ToInt32(Console.ReadLine());
            switch (d)
            {
                case 1:
                    FlipCoin f = new FlipCoin();
                    f.Toss();
                    break;
                case 2:
                    LeapYear y = new LeapYear();
                    y.CheckYear();
                    break;
            }
            Console.ReadLine();
        }
    }
}
