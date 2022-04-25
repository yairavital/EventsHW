using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsHW
{
    internal class GameViewer
    {

        public void GoodSpaceShipLocationChangedEventHandler(object sender, LocationEventArgs locationEventArgs)
        {
            Console.WriteLine($"The location of the space ship has changed to: ({locationEventArgs.X},{locationEventArgs.Y})");
        }
        public void GoodSpaceShipHpChangedEventHandler(object sender, PointsEventArgs pointsEventArgs)
        {
            Console.WriteLine($"The Hits of the good space has changed to {pointsEventArgs.HitsPoints}");
        }
        public void GoodSpaceShipDestroyedEventHandler(object sender,LocationEventArgs locationEventArgs)
        {
            
                Console.WriteLine($"The good space ship was destroyed");
        }
        public void BadShipsExplodedEventHandler(object sender, BadShipsExplodedEventArgs badShipsExplodedEventArgs)
        {
            Console.WriteLine($"Bad ships has destroyed now you have {badShipsExplodedEventArgs.BadShipsExploded} to exploed");
        }
        public void LevelUpReachedEventHandler(object sender, LevelEventArgs levelEventArgs)
        {
            Console.WriteLine($"Congratulations you have progressed to the stage of {levelEventArgs.Level} level");
        }

    }
}
