using System;
using System.Collections.Generic;
using System.Text;

namespace GamblingProblem
{
    class Gambling
    {
        public const int STAKE = 100;
        public const int EVERYGAMEBET = 1;

        public void StartGambling()
        {
            int wallet = STAKE;
            Random random = new Random();
            int result = random.Next(0, 2);
            if(result == 0)
            {
                wallet--;
            }
            else
            {
                wallet++;
            }
            Console.WriteLine(wallet);
       }
    }
}
