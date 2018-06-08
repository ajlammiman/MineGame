using Core;

namespace Game
{
    public class Square : ISquare
    {
        public bool IsMine { get; set; }
        public ILocation Location { get; set; }

        public void CheckForMine()
        {
        }

        public void HasBeenMovedTo()
        {
        }
    }
}
