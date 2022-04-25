using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsHW
{
    internal class LevelEventArgs : EventArgs
    {
        public int Level { get; set; }
       public LevelEventArgs(int level)
        {
            Level = level;
        }
    }
}
