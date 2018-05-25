using Core;

namespace Game
{
    public class Square : ISquare
    {
        public bool IsMine { get; set; }
        public int Xlocatioon { get; set; }
        public int Ylocatioon { get; set; }

        public void HasBeenMovedTo()
        {
        }
    }
}
