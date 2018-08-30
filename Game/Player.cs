using System.Linq;
using Core;

namespace Game
{
    public class Player : IPlayer
    {
        public int lives { get; set; }
        private IBoard board { get; set; }
        public ILocation currentLocation { get; set;
        }

        public Player(IBoard board, int lives)
        {
            this.board = board;
            this.lives = lives;
        }

        public ILocation GetCurrentLocation()
        {
            throw new System.NotImplementedException();
        }

        public void MoveLocation(ILocation location)
        {
            var newLocation = this.board.Squares.FirstOrDefault(s => s.Location.Equals(location));
            
            if (!newLocation.IsMine)
            {
                currentLocation = newLocation.Location;
            }
            else
            {
                this.lives--;
            }
        }

        public int RemoveLives(int livesToremove)
        {
            throw new System.NotImplementedException();
        }
    }
}
