using System.Linq;
using Core;

namespace MineGame
{
    public class Player : IPlayer
    {
        public int lives { get; set; }
        private IBoard board { get; set; }
        public ILocation currentLocation { get; set;}
        public bool isAlive { get; set; }

        public Player(IBoard board, int lives)
        {
            this.board = board;
            this.lives = lives;
        }

        public bool MoveLocation(ILocation location)
        {
            var newLocation = this.board.Squares.FirstOrDefault(s => s.Location.Equals(location));

            if (newLocation == null)
                return false;

            if (!newLocation.IsMine)
            {
                currentLocation = newLocation.Location;
            }
            else
            {
                this.lives--;
                isAlive = (this.lives == 0) ? false : true;
            }

            return true;
        }

       
    }
}
