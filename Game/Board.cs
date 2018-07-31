using System;
using System.Collections.Generic;
using System.Linq;
using Core;

namespace Game
{
    public  class Board : IBoard
    {
        public ISquare[] Squares { get; set; }

        private int _numberOfMines { get; set; }
        private int _boardHeight { get; set; }
        private int _boardWidth { get; set; }

        public Board(int numberOfMines, int boardHeight, int boardWidth)
        {
            _numberOfMines = numberOfMines;
            _boardHeight = boardHeight;
            _boardWidth = boardWidth;
        }

        public void CreateBoard<S, L>() where S : ISquare, new()
            where L : ILocation, new()
        {
            List<ISquare> squares = new List<ISquare>();

            for (int Xaxis = 0; Xaxis < _boardHeight; Xaxis++)
            {
                for (int Yaxis = 0; Yaxis < _boardWidth; Yaxis++)
                {
                    var square = new S { Location = new L { XLocation = Xaxis + 1, YLocation = Yaxis + 1 } };

                    squares.Add(square);
                }
            }

            Squares = squares.ToArray();
        }

        

        public void AddMines<L>() where L : ILocation, new()
        {
            Random rnd = new Random();
            
            for (int i = 0; i < _numberOfMines; i++)
            {
                int randomX = rnd.Next(0, _boardWidth);
                int randomY = rnd.Next(0, _boardHeight);

                var mineLocation = new L { XLocation = randomX, YLocation = randomY  };

                Squares.Where(s => s.Location.Equals(mineLocation)).FirstOrDefault(s => s.IsMine = true);
            }
        }


        public bool IsValidLocation(ILocation location)
        {
            return Squares.Any(s => s.Location.Equals(location));
        }

       
    }
}
