using Core;

namespace MineGame
{
    public class Game : IGame
    {
        private IPlayer player { get; set; }
        private IBoard board { get; set; }

        public Game(IPlayer player, IBoard board, ILocation startLocation)
        {
            this.player = player;
            this.board = board;
        }

        public void MakeMove(Move move)
        {
            var newLocation = this.CreateNewLocation(move, player.currentLocation);
            bool isValid = this.board.IsValidLocation(newLocation);

            if (isValid)
                this.player.MoveLocation(newLocation);
        }

        private ILocation CreateNewLocation(Move move, ILocation currentLocation)
        {
            switch (move)
            {
                case Move.Left:
                    return new Location {XLocation = currentLocation.XLocation -1, YLocation = currentLocation.YLocation};
                case Move.Right:
                    return new Location { XLocation = currentLocation.XLocation + 1, YLocation = currentLocation.YLocation };
                case Move.Up:
                    return new Location { XLocation = currentLocation.XLocation, YLocation = currentLocation.YLocation + 1 };
                case Move.Down:
                    return new Location { XLocation = currentLocation.XLocation, YLocation = currentLocation.YLocation - 1 };
                default:
                    return currentLocation;
            }
        }
        
    }
}
