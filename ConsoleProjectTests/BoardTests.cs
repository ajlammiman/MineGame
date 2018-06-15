using Core;
using Game;
using NUnit.Framework;
using System.Collections.Generic;

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
        public void Board_CreatesBoardReturnsListOfSqaures()
        {
            var squares = CreateBoardForTest(0, 0, 0);
            
            Assert.That(squares, Is.EqualTo(new List<ISquare>()));
        }
        
        [Test]
        public void Board_CreatesBoardReturnsCorrectDimeensions()
        {
            var squares = CreateBoardForTest(8,8,0);

            Assert.That(squares.Count, Is.EqualTo(64));
        }

        [Test]
        public void Board_TestThatValidLocationReturnsTrue()
        {
            var board = new Board();
            var squares = CreateBoardForTest(8, 8, 0);
            var location = new Location { XLocation = 2, YLocation = 4 };

            Assert.That(board.IsValidLocation(location, squares), Is.EqualTo(true));
        }

        [Test]
        public void Board_TestThatInValidLocationReturnsFalse()
        {
            var board = new Board();
            var squares = CreateBoardForTest(8, 8, 0);
            var location = new Location { XLocation = 70, YLocation = 70 };

            Assert.That(board.IsValidLocation(location, squares), Is.EqualTo(false));
        }

        private List<ISquare> CreateBoardForTest(int width, int height, int mines)
        {
            var board = new Board();
            var squares = (List<ISquare>)board.CreateBoard<Square, Location>(width, height);

            return squares;
        }
    }
}
