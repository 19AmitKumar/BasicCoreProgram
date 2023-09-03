using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramingAssignment
{
    internal class Factor
    {
        public void FindFactor()
        {
            Console.WriteLine("Enter the Number: ");
            int num=Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= num; i++) 
            {
                if(num%i == 0)
                {
                    Console.WriteLine(i);
                }
            
            }
        }
    }
}
