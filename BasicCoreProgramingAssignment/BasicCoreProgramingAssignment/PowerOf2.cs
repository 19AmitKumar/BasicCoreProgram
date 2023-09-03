using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramingAssignment
{
    internal class PowerOf2
    {
        public void Power()
        {
            for (int i = 1; i <= 10; i++) 
            {
                int power = 2*i;
                Console.WriteLine(power);
                
            }
        }
    }
}
