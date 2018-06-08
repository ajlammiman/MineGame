namespace Core
{
    public interface ISquare
    {
        bool IsMine { get; set; }
        ILocation Location { get; set; }
        
        void HasBeenMovedTo();
        void CheckForMine();        
    }
}