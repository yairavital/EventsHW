using EventsHW;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

Console.ForegroundColor = ConsoleColor.Green;
SpaceQuestGameManager spaceManager = new SpaceQuestGameManager(150, 200, 200, 3);
GameViewer gameViewer = new GameViewer();
spaceManager.GoodSpaceShipLocationChanged += gameViewer.GoodSpaceShipLocationChangedEventHandler;
spaceManager.GoodSpaceShipHPChanged += gameViewer.GoodSpaceShipHpChangedEventHandler;
spaceManager.GoodSpaceShipDestroyed +=gameViewer.GoodSpaceShipDestroyedEventHandler;
spaceManager.LevelUpReached += gameViewer.LevelUpReachedEventHandler;
spaceManager.BadShipsExploded += gameViewer.BadShipsExplodedEventHandler;
spaceManager.EnemyShipsDestroyed(1);
spaceManager.EnemyShipsDestroyed(2);
while (true)
{
    Random r = new Random();
    int randomNumber = r.Next(1, 5);
    switch (randomNumber)
    {
        case 1:
            spaceManager.MoveSpaceShip(250, 350);
            Thread.Sleep(1000);
            break;

        case 2:
            Thread.Sleep(1000);
            spaceManager.EnemyShipsDestroyed(3);
            break;
        case 3:
            Thread.Sleep(1000);
            spaceManager.GoodSpaceShipGodDamged(50);
            break;
        case 4:
            Thread.Sleep(1000);
            spaceManager.GoodSpaceShipGotExtreHP(100);
            break;


    }
}
