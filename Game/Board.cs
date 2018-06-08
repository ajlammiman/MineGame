using System.Collections.Generic;
using Core;

namespace Game
{
    public  class Board : IBoard
    {
        public int _numberOfMines { get; set; }

        public Board()
        {
           
        }

        public List<ISquare> CreateBoard<T, L>(int boardWidth, int boardHeight) 
            where T : ISquare, new()
            where L : ILocation, new()
        {
            List<ISquare> board = new List<ISquare>();

            for (int Xaxis = 0; Xaxis < boardHeight; Xaxis++)
            {
                for (int Yaxis = 0; Yaxis < boardWidth; Yaxis++)
                {
                    var square = new T { Location = new L { XLocation = Xaxis, YLocation = Yaxis } };

                    board.Add(square);
                }
            }

            return board;
        }

        public List<ISquare> SetUpMines(List<ISquare> squares, int mines)
        {
            return squares;
        }

       
    }
}
