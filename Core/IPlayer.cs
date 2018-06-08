namespace Core
{
    public interface IPlayer
    {
        int Lives { get; set; }
        ILocation MoveLocation(ILocation location);
        int RemoveLives(int livesToremove);
        ILocation GetCurrentLocation();
    }
}