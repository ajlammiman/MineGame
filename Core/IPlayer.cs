namespace Core
{
    public interface IPlayer
    {
        ILocation currentLocation { get; set; }
        int lives { get; set; }
        bool MoveLocation(ILocation location);
        int RemoveLives(int livesToremove);
        ILocation GetCurrentLocation();
    }
}