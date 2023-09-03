using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramingAssignment
{
    internal class VowelConsonant
    {
        public void Alphabet()
        {
            Console.WriteLine("Enter any character: ");
            char ch=Convert.ToChar(Console.ReadLine());
            if(ch =='a' || ch=='e' ||  ch =='i' || ch=='o' || ch=='u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                Console.WriteLine("Vowel");
            
            }
            else
            {
                Console.WriteLine("Consonant");
            }
        }
    }
}
