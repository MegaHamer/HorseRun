using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HorseRun
{
    class Horse
    {
        public int position = 0;
        public int[] state;
        public Horse()
        {
            Thread.Sleep(500);
            Random random = new Random();
            this.state = new int[5];
            for (int i = 0; i<5; i++)
            {
                this.state[i]=random.Next(-3, 10);
            }
            
        }
        public Horse(int[] states)
        {
            this.state = states;
        }
        public void step()
        {
            Random rand = new Random();
            int step = this.state[rand.Next(this.state.Length)];
            if (this.position+step > 0)
            {
                this.position += step;
            }
        }
        public void step(int hod)
        {
            int step = this.state[hod%state.Length];
            if (this.position + step > 0)
            {
                this.position += step;
            }
        }
        public string stateStr()
        {
            string result="";
            foreach (int i in this.state)
            {
                result += ' ' + i.ToString();
            }
            return result;
        }
    }
}
