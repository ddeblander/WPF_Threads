using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Threads.Model
{
    internal class Person
    {
        private string name;
        private float kph;
        private Road r;
        public Person(string name, float kph, Road r)
        {
            Name = name;
            Kph = kph;
            R = r;
            
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public float Kph
        {
            get { return kph;}
            set { kph = value; }
        }
        public Road R
        {
            get { return r; }
            set { if (value != null) { r = value; } else Trace.WriteLine("Road null dans Person"); }
        }

        public float Walking( Road rE)
        {
            if((rE != null)&&(r!= null))
            {
                short xB =r.X;
                short xE=rE.X;
                short yB =r.Y;
                short yE =rE.Y;

                return((xE-xB)+(yE-yB));
            }
            Trace.WriteLine("une Road est null dans Walking");
            return 0;
           
            

        }

    }
}
