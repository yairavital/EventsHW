using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsHW
{
    internal class SpaceQuestGameManager
    {
        private int _goodSpaceShipHitPoints;
        private readonly int hits;
        private int _shipXLocation;
        private int _shipYLocation;
        private int _numberOfBadShips;
        public event EventHandler<PointsEventArgs> GoodSpaceShipHPChanged;
        public event EventHandler<LocationEventArgs> GoodSpaceShipLocationChanged;
        public event EventHandler<LocationEventArgs> GoodSpaceShipDestroyed;
        public event EventHandler<BadShipsExplodedEventArgs> BadShipsExploded;
        public event EventHandler<LevelEventArgs> LevelUpReached;
        public int _currentLevel;

        public SpaceQuestGameManager(int goodSpaceShipHitPoints,int xLocation,int yLocation,int numberOfBadShips)
        {
            _goodSpaceShipHitPoints = goodSpaceShipHitPoints;   
            _shipXLocation = xLocation;
            _shipYLocation = yLocation;
            _numberOfBadShips = numberOfBadShips;
            _currentLevel = 1;
            hits = _goodSpaceShipHitPoints;
        }
        public void MoveSpaceShip(int newX, int newY)
        {
            _shipXLocation = newX;
            _shipYLocation = newY;
            OnGoodSpaceShipLocationChanged(_shipXLocation, _shipYLocation);
        }
        public void GoodSpaceShipGodDamged(int damge)
        {
            _goodSpaceShipHitPoints-= damge;
            OnSpaceShipHPChanged(_goodSpaceShipHitPoints);
            if(_goodSpaceShipHitPoints<=0)
                OnGoodSpaceShipDestroyed(0,0);

        }
        public void GoodSpaceShipGotExtreHP(int extra)
        {
            _goodSpaceShipHitPoints += extra;
            OnSpaceShipHPChanged(_goodSpaceShipHitPoints);
        }
        public void EnemyShipsDestroyed( int numberOfBadShipsDestroyed)
        {
            if (_numberOfBadShips > numberOfBadShipsDestroyed)
                _numberOfBadShips -= numberOfBadShipsDestroyed;
            else _numberOfBadShips = 0;
            OnSpaceShipsExploded(_numberOfBadShips);
            if (_numberOfBadShips == 0)
            {_currentLevel++;
                OnLevelUpReached(_currentLevel);
                _goodSpaceShipHitPoints = hits;

            }
                


        }
        private void OnSpaceShipHPChanged(int points)
        {
            GoodSpaceShipHPChanged.Invoke(this, new PointsEventArgs(points));
        }
        private void OnGoodSpaceShipLocationChanged(int x,int y)
        {
            GoodSpaceShipLocationChanged.Invoke(this, new LocationEventArgs(x,y));
        }
        private void OnGoodSpaceShipDestroyed(int x,int y)
        {
            GoodSpaceShipDestroyed.Invoke(this, new LocationEventArgs(x, y));
        }
        private void OnSpaceShipsExploded(int exploed)
        {
            BadShipsExploded.Invoke(this, new BadShipsExplodedEventArgs(exploed));
        }
        private void OnLevelUpReached(int level)
        {
            LevelUpReached.Invoke(this, new LevelEventArgs(level));
        }
    }
}
