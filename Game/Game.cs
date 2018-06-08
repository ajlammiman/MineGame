using Core;
using System.Collections.Generic;

namespace Game
{
    class Game : IGame
    {
        private IPlayer _player { get; set; }
        private IBoard _board { get; set; }
        private List<ISquare> _squares { get; set; }

        Game(IPlayer player, IBoard board, ILocation startLocation, int boardWidth, int boardHeight, int numberOfMines)
        {
            _player = player;
            _board = board;

            _squares = _board.CreateBoard<Square, Location>(boardWidth, boardHeight);
            _board.SeedMines(_squares, numberOfMines);
        }
    }
}
