using System;
using System.Collections.Generic;
using System.Linq;
using Core;

namespace Game
{
    public  class Board : IBoard
    {
        public int _numberOfMines { get; set; }
       

        public IEnumerable<ISquare> CreateBoard<T, L>(int boardWidth, int boardHeight) 
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

        public IEnumerable<ISquare> SeedMines(IEnumerable<ISquare> squares, IEnumerable<ILocation> mines)
        {
            foreach (ILocation mine in mines)
            {
                var square = squares.FirstOrDefault(s => s.Location.Equals(mine));
                if (square != null) square.IsMine = true;
            }

            return squares;
        }

        public IEnumerable<ILocation> CreateMine<T>(int boardWidth, int boardHeight, int numberOfMines, IList<ILocation> mineLocations) where T : ILocation, new()
        {
            Random rnd = new Random();
            
            for (int i = 0; i < numberOfMines; i++)
            {
                int randomX = rnd.Next(0, boardWidth);
                int randomY = rnd.Next(0, boardHeight);

                mineLocations.Add(new T { XLocation = randomX, YLocation = randomY });
            }

            return mineLocations;
        }


        public bool IsValidLocation(ILocation newLocation, IEnumerable<ISquare> squares)
        {
            return squares.Any(s => s.Location.Equals(newLocation));
        }

       
    }
}
