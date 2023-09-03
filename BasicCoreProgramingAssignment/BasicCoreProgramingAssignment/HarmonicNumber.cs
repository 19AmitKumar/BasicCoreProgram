using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramingAssignment
{
    internal class HarmonicNumber
    {
        public void Number() 
        {
            Console.WriteLine("Enter one Number:");
            int num=Convert.ToInt32(Console.ReadLine());
            double result = 0.0;
            for(int i=num;i>0;i--) 
            {
                result += (double)1 / i;
                Console.WriteLine(result);

            
            }

        }
    }
}
