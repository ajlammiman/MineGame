using System.Collections.Generic;
using Core;

namespace Game
{
    public  class Board : IBoard
    {
        public int _numberOfMines { get; set; }

        public Board(int boardWidth, int boardHeight, int numberOfMines)
        {
            _numberOfMines = numberOfMines;
            var squares = CreateBoard<Square>(boardWidth, boardHeight);

            SetUpBoard(squares, _numberOfMines);
        }

        public List<ISquare> CreateBoard<T>(int boardWidth, int boardHeight) where T : ISquare, new()
        {
            List<ISquare> board = new List<ISquare>();

            for (int Xaxis = 0; Xaxis < boardHeight; Xaxis++)
            {
                for (int Yaxis = 0; Yaxis < boardWidth; Yaxis++)
                {
                    var square = new T { Xlocatioon = Xaxis, Ylocatioon = Yaxis };

                    board.Add(square);
                }
            }

            return board;
        }

        public void SetUpBoard(List<ISquare> squares, int mines)
        {
        }

        
    }
}
