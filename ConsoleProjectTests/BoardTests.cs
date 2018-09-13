using Core;
using MineGame;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace GameTests
{
    [TestFixture, Category("Board Tests")]
    class BoardTests
    {
        [Test]
        public void Board_ImplementsCorrectInterface()
        {
            Board board = null;
            IBoard iBoard = null;

            Assert.That(board, Is.EqualTo(iBoard));
        }

        
        [Test]
        public void Board_CreatesBoardReturnsCorrectDimeensions()
        {
            var board = CreateBoardForTest(8,8,0);

            Assert.That(board.Squares.Count(), Is.EqualTo(64));
        }

        [Test]
        public void Board_TestThatValidLocationReturnsTrue()
        {
            var board = CreateBoardForTest(8, 8, 0);
            var location = new Location { XLocation = 2, YLocation = 4 };

            Assert.That(board.IsValidLocation(location), Is.EqualTo(true));
        }

        [Test]
        public void Board_TestThatInValidLocationReturnsFalse()
        {
            var board = CreateBoardForTest(8, 8, 0);
            var location = new Location { XLocation = 70, YLocation = 70 };

            Assert.That(board.IsValidLocation(location), Is.EqualTo(false));
        }

        [Test]
        public void Board_TestThatBoardCreatesRightNumberOfMines()
        {
            var board = CreateBoardForTest(1, 1, 1);
            var locations = new List<ILocation>();

            board.AddMines<Location>();
            
            Assert.That(board.Squares.Where(s => s.IsMine).Count, Is.EqualTo(1));
        }
        
        private IBoard CreateBoardForTest(int width, int height, int mines)
        {
            var board = new Board(mines, height, width);
            board.CreateBoard<Square, Location>();
            return board;
        }
    }
}
