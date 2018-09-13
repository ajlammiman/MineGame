using Core;

namespace MineGame
{
    public class Square : ISquare
    {
        public bool IsMine { get; set; }
        public ILocation Location { get; set; }

        public Square()
        {
            IsMine = false;
        }

        public void CheckForMine()
        {
        }

        public void HasBeenMovedTo()
        {
        }
    }
}
