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
            Console.WriteLine();
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
                    case 3:
                    int num = Convert.ToInt32(args[0]);
                    PowerOf2 powerOf2 = new PowerOf2();
                    powerOf2.Power();
                    break;
                    case 4:
                    HarmonicNumber harmonicNumber = new HarmonicNumber();
                    harmonicNumber.Number();
                    break;
                    case 5:
                    Factor factor = new Factor();
                    factor.FindFactor();
                    break;
            }
            Console.ReadLine();
        }
    }
}
