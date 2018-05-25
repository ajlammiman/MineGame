using Core;

namespace Game
{
    class Game : IGame
    {
        public IPlayer _player { get; set; }
        public IBoard _board { get; set; }

        Game(IPlayer player, IBoard board)
        {
            _player = player;
            _board = board;
            
        }
    }
}
