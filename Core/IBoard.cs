using System.Collections.Generic;

namespace Core
{
    public interface IBoard
    {
        List<ISquare> CreateBoard<T, L>(int BoardWidth, int Boardheight) 
            where T : ISquare, new()
            where L : ILocation, new();
            
        List<ISquare> SetUpMines(List<ISquare> squares, int mines);
        
        
    }
}