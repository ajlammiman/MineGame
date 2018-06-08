using System.Collections.Generic;

namespace Core
{
    public interface IBoard
    {
        List<ISquare> CreateBoard<T, L>(int BoardWidth, int Boardheight) 
            where T : ISquare, new()
            where L : ILocation, new();
            
        List<ISquare> SeedMines(List<ISquare> squares, int mines);

        bool IsValidLocation(ILocation newLocation, List<ISquare> squares);
    }
}