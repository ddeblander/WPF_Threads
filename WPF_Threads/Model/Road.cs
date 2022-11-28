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
        private string name;
        private short x, y;
        public Road(string name, short x, short y) 
        {
            this.name = name;
           
            this.x = x;
            this.y = y;

        }


        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public short X
        {
            get { return x; }
            set { x = value; }
        }
        public short Y
        {
            get { return y; }
            set { y = value; } 
        }
    }
}
