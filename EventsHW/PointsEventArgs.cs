namespace EventsHW
{
    public class PointsEventArgs : EventArgs
    {
        public int HitsPoints { get; set; }

        public PointsEventArgs(int points)
            {
            HitsPoints = points;
            }
    }
}