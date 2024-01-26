using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HorseRun
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] posible = new int[5] { 2, 4, -1, 0, 1 };
            int[] stateOrig = new int[5] {2,4,-1,0,1};
            int[] state1 = new int[10] ;
            int[] state2 = new int[10] ;
            for (int j = 0; j < 10; j++)
            {
                state1[j] = stateOrig[random.Next(0,3)];
                state2[j] = stateOrig[random.Next(0,3)];
            }
            
            var h = new Horse(state1);
            var h2 = new Horse(state2);
            var map = new Map();
            map.AddHorse(h);
            map.AddHorse(h2);
            int i= 0;
            do
            {
                Thread.Sleep(500);
                map.Draw();
                map.HorsesStep();
            }
            while (!map.Finish());

            

            Console.ReadLine();


        }

    }
}
