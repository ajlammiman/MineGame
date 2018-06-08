using System;
using System.Collections.Generic;
using System.Linq;
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

        public List<ISquare> SeedMines<T>(List<ISquare> squares, int mines) where T : ILocation
        {
            int boardWidth = 0;
            int boardHeight = 0;

            for (int i = 0; i < mines; i++)
            {
                var mineLocation = CreateMine<T>(boardWidth, boardHeight);

                var square = squares.FirstOrDefault(s => s.Location.Equals(mineLocation));
                if (square != null) square.IsMine = true;
            }

            return squares;
        }

        private ILocation CreateMine<T>(int boardWidth, int boardHeight) where T : ILocation, new()
        {
            Random rnd = new Random();
            int randomX = rnd.Next(0, boardWidth);
            int randomY = rnd.Next(0, boardHeight);

            var mineLocation = new T { XLocation = randomX, YLocation = randomY };

            return mineLocation;
        }


        public bool IsValidLocation(ILocation newLocation, List<ISquare> squares)
        {
            return squares.Any(s => s.Location.Equals(newLocation));
        }
    }
}
