namespace Core
{
    public interface ISquare
    {
        bool IsMine { get; set; }
        int Xlocatioon { get; set; }
        int Ylocatioon { get; set; }

        void HasBeenMovedTo();
        
    }
}