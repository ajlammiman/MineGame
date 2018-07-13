using System.Collections.Generic;

namespace Core
{
    public interface IBoard
    {
        ISquare[] Squares { get; set; }

        void CreateBoard<S, L>() where S : ISquare, new()
            where L : ILocation, new();

        void AddMines<L>() where L : ILocation, new();

        bool IsValidLocation(ILocation location);
    }
}