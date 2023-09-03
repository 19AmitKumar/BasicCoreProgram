using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramingAssignment
{
    internal class Quotient_reminder
    {
        public void Divide()
        {
            Console.WriteLine("Enter Dividend:");
            int dividend = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Dividor");
            int divisor= Convert.ToInt32(Console.ReadLine());
            float quotient=dividend/divisor;
            float reminder=dividend%divisor;
            Console.WriteLine("Quotient: " +quotient);
            Console.WriteLine("Reminder: " + reminder);
        }
    }
}
