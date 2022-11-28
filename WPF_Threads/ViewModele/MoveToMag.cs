using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using WPF_Threads.Model;

namespace WPF_Threads.ViewModele
{
    internal static class MoveToMag
    {
       
        public static int Moving(Person p, Magasin m) 
        {
            float time = p.Walking(m.Road) / (float)p.Kph;
            Trace.WriteLine(time);
            Trace.WriteLine(p.Walking(m.Road));
            Trace.WriteLine((float)p.Kph);
            if (time > 1) 
            {
                
                return (int)time*1000;
            }
            return 1000;
        }
    }
}
