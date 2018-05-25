namespace Core
{
    public interface IPlayer
    {
        void StartingLives(int lives);
        void StartingLocation(ILocation location);
        void RemoveLives(int livesToremove);
        void GetCurrentLocation();
    }
}