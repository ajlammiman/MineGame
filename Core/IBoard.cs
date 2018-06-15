using System.Collections.Generic;

namespace Core
{
    public interface IBoard
    {
        IEnumerable<ISquare> CreateBoard<T, L>(int BoardWidth, int Boardheight) 
            where T : ISquare, new()
            where L : ILocation, new();

        IEnumerable<ISquare> SeedMines(IList<ISquare> squares, IEnumerable<ILocation> mines);

        IEnumerable<ILocation> CreateMine<T>(int boardWidth, int boardHeight, int numberOfMines, IList<ILocation> mineLocations) where T : ILocation, new();

        bool IsValidLocation(ILocation newLocation, List<ISquare> squares);
    }
}