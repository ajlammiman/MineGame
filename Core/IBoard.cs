using System.Collections.Generic;

namespace Core
{
    public interface IBoard
    {
        List<ISquare> CreateBoard<T>(int BoardWidth, int Boardheight) where T : ISquare, new();
        void SetUpBoard(List<ISquare> squares, int mines);
        
    }
}