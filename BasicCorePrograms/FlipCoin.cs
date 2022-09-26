using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    class FlipCoin
    {
        public static void HeadTail(int Count)
        {
            int Head = 0;
            int Tail = 0;
            double HPercent = 0;
            double TPercent = 0;

            Random random = new Random();
            for (int i = 1; i <= Count; i++)
            {
                double Coin = random.NextDouble();
                if(Coin<0.5)
                {
                    Head += 1;
                }
                else
                {
                    Tail += 1;
                }

            }
            HPercent = (Head*100 / Count);
            TPercent = (Tail*100 / Count);
            Console.WriteLine("Head percent is : {0}.", HPercent);
            Console.WriteLine("Tail percent is : {0}.", TPercent);
        }
    }
}
