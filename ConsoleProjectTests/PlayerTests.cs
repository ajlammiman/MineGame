﻿using Game;
using NUnit.Framework;

namespace GameTests
{
    [TestFixture, Category("Player Tests")]
    public partial class PlayerTests
    {
        private Board board { get; set; }
        private Player player { get; set; }
        private int livesBeforeMove { get; set; }

        [OneTimeSetUp]
        public void init()
        {
            board = new Board(1, 1, 1);
            board.CreateBoard<Square, Location>();
            board.AddMines<Location>();
            player = new Player(board, 2);
        }

        public void given_a_player_makes_a_move_onto_a_square_with_a_mine()
        {
            livesBeforeMove = player.lives;
            var newLocation = new Location() { XLocation = 1, YLocation = 1 };
            player.MoveLocation(newLocation);
        }

        public void then_one_life_is_lost()
        {
            Assert.That(player.lives, Is.EqualTo(livesBeforeMove - 1));
        }
    }
}