using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Threads.Model
{
    internal class Person
    {
        private string name;
        private uint kph;
        public Person(string name, uint kph)
        {
            this.name = name;
            this.kph = kph;
        }
        public string Name
        {
            get { return name; }
            set { this.name = name; }
        }
        public uint Kph
        {
            get { return kph;}
            set { this.kph = kph; }
        }

        public int Walking(Road rB, Road rE)
        {
            if((rB != null)&&(rE != null))
            {
                short xB =rB.X;
                short xE=rE.X;
                short yB =rB.Y;
                short yE =rB.Y;

                return((xE-xB)+(yE-yB));
            }
            Console.WriteLine("une ou plusieurs Road sont null");
            return 0;
           
            

        }

    }
}
