public enum Move
{
    Left,
    Right,
    Up,
    Down
}

namespace Core
{
    public interface IGame
    {
        void MakeMove(Move move);
    }
}
