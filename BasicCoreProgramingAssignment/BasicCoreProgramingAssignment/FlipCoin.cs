using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramingAssignment
{
    internal class FlipCoin
    {
        public void Toss()
        {
            Console.WriteLine("Please Enter the numer of flip: ");
            int flip = Convert.ToInt32(Console.ReadLine());

            int head = 0;
            int tail = 0;
            int headCount = 0;
            int tailCount = 0;
            double headPercentage;
            double tailPercentage;

            if (flip > 0)
            {
                for (int i = 0; i < flip; i++)
                {
                    Random random = new Random();
                    int coin = random.Next(2);
                    if (coin == 0)
                    {
                        Console.WriteLine("Its Head!!");
                        head = 1;
                        headCount += 1;
                    }
                    else if (coin == 1)
                    {
                        Console.WriteLine("Its Tail!!");
                        tail = 1;
                        tailCount += 1;
                    }
                }
                headPercentage = (headCount * 100) / flip;
                tailPercentage = (tailCount * 100) / flip;
                Console.WriteLine("Total Head percentage is: "+headPercentage);
                Console.WriteLine("Total Tail Percentage is: "+tailPercentage);
            }

        }

    }
}
