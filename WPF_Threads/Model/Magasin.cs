using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Threads.Model
{
    internal class Magasin
    {
        private string name;
        private Road road;

        public Magasin(string name, Road road)
        {
            Name= name;
            if(road!= null)
            {
                this.road=road;
            }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Road Road
        {
            get { return road; }
        }
    }
}
