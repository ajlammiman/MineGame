namespace Core
{
    public interface IPlayer
    {
        ILocation currentLocation { get; set; }
        int lives { get; set; }
        bool MoveLocation(ILocation location);
        bool isAlive { get; set; }
    }
}