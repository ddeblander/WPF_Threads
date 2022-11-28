using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Threads.Model
{
    internal class magasin
    {
        private string name;
        private Road road;

        public magasin(string name, Road road)
        {
            this.name = name;
            if(road!= null)
            {
                road.Name = name;
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
