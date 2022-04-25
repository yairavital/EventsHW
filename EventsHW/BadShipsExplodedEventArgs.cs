using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsHW
{
    internal class BadShipsExplodedEventArgs: EventArgs
    {
        public int BadShipsExploded { get; set; }
       public BadShipsExplodedEventArgs(int badShipsExploded)
        {
            BadShipsExploded=badShipsExploded;
        }
    }
}
