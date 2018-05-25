using Core;
using Game;
using NUnit.Framework;
using System.Collections.Generic;

namespace ConsoleProjectTests
{
    [TestFixture, Category("Board Tests")]
    class BoardTests
    {
        [Test]
        public void Board_ImplementsCorrectInterface()
        {
            var board = new Board(0,0,0);
            IBoard iBoard = null;

            Assert.That(board, Is.EqualTo(iBoard));
        }

        [Test]
        public void Board_CreatesBoardReturnsListOfSqaures()
        {

            int boardWidth = 0;
            int boardHeight = 0;
            int mines = 0;

            var board = new Board(boardWidth, boardHeight, mines);
            var newBoard = board.CreateBoard<Square>(boardWidth, boardHeight);
           
            Assert.That(newBoard, Is.EqualTo(new List<ISquare>()));
        }
        
        [Test]
        public void Board_CreatesBoardReturnsCorrectDimeensions()
        {
            int boardWidth = 8;
            int boardHeight = 8;
            int mines = 0;

            var board = new Board(boardWidth, boardHeight, mines);
            var newBoard = board.CreateBoard<Square>(boardWidth, boardHeight);

            Assert.That(newBoard.Count, Is.EqualTo(64));
        }


    }
}
