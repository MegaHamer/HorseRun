using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace HorseRun
{
    class Map
    {
        public int lenght;
        public Horse[] horses;
        public int x=0;
        public int y=0;
        private int hod=0;

        public Map()
        {
            this.lenght = 100;
        }
        public void AddHorse(Horse horse)
        {
            if (this.horses == null)
            {
                this.horses = new Horse[] { horse };
            }
            else
            {
                horses= horses.Concat(new Horse[] { horse }).ToArray();
            }
            
        }

        public void Draw()
        {
            if (horses != null)
            {
                //field
                string line="";
                string spaceLine="█";
                for (int i =0; i < lenght + 2; i++)
                {
                    line += '█';
                }
                for (int i = 0; i < lenght; i++)
                {
                    spaceLine += ' ';
                }
                spaceLine += '█';
                Console.SetCursorPosition(x, y);
                Console.WriteLine(line);
                for (int i = 0; i < horses.Length; i++)
                {
                    Console.WriteLine(spaceLine);
                }
                Console.WriteLine(line);
                //horses
                for (int i = 0; i < horses.Length; i++)
                {
                    Console.SetCursorPosition(horses[i].position+x+1, y +1+ i);
                    Console.Write('╬');
                    Console.SetCursorPosition(x, y + horses.Length + i+2);
                    Console.Write(horses[i].stateStr());
                }
                //state

            }
        }
        public bool Finish()
        {
            foreach(var elem in horses)
            {
                if (elem.position > lenght) 
                {
                    Console.SetCursorPosition(x, y + horses.Length + 4);
                    Console.Write("Финиш");
                    return true;
                }
            }
            return false;
        }
        public void HorsesStep()
        {
            foreach (var elem in horses)
            {
                elem.step();
            }
        }
        public void HorsesStep(bool tru)
        {
            hod++;
            foreach (var elem in horses)
            {
                elem.step(hod);
            }
        }
    }
}
