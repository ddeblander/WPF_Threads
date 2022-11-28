using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPF_Threads.Model
{
    internal class Road
    {
        string name;
        uint km;
        short x, y;
        public Road(string name,uint km, short x, short y) 
        {
            this.name = name;
            if (km > 0)
            {
                this.km = km;
            }
            else
                Console.WriteLine($"mauvaise saisie des km car négatif : {km}");
            this.x = x;
            this.y = y;

        }
        
    }
}
