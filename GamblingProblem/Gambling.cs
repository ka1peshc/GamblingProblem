using System;
using System.Collections.Generic;
using System.Text;

namespace GamblingProblem
{
    class Gambling
    {
        public const int STAKE = 100;
        public const int EVERYGAMEBET = 1;
        public const int STOPWINSTAKE = 150;
        public const int STOPLOOSESTAKE = 50;

        public void StartGambling()
        {
            int wallet = STAKE;
            int result;
            int BetCount = 0;
            Random random = new Random();
            while (true)
            {
                result = random.Next(0, 2);
                if (result == 0)
                {
                    wallet--;
                }
                else
                {
                    wallet++;
                }
                if(wallet >= STOPWINSTAKE || wallet <= STOPLOOSESTAKE)
                {                    
                    break;
                }
                BetCount++;
            }
            Console.WriteLine("Stake is {0} Number of times bet placed {1}", wallet,BetCount);
       }
    }
}
