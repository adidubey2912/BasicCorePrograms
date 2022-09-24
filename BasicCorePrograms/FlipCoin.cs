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
            int Head = 0, Tail = 0;
            int HPercent = 0, TPercent = 0;

            Random random = new Random();
            for (int i = 1; i <= Count; i++)
            {
                int Coin = random.Next(0, 2);
                if(Coin == 0)
                {
                    Head = Head + 1;
                    HPercent = (Head/Count)*100;
                }
                else
                {
                    Tail = Tail + 1;
                    TPercent = (Tail/Count)*100;
                }

            }
            Console.WriteLine("Head percent is : {0}.", HPercent);
            Console.WriteLine("Tail percent is : {0}.", TPercent);
        }
    }
}
