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
            board.Squares = new Square[]
            {
                new Square()
                {
                    Location  = new Location() { XLocation = 1, YLocation = 1},
                    IsMine = true
                },
                new Square()
                {
                    Location  = new Location() { XLocation = 1, YLocation = 2}
                }
            };
            player = new Player(board, 2);
        }

        public void given_a_player_makes_a_move_to_a_mined_square()
        {
            livesBeforeMove = player.lives;
            player.MoveLocation(new Location() { XLocation = 1, YLocation = 1 });

        }

        private void given_a_player_makes_a_move()
        {
            player.MoveLocation(new Location() { XLocation = 1, YLocation = 2 });
        }

        public void then_one_life_is_lost()
        {
            Assert.That(player.lives, Is.EqualTo(livesBeforeMove - 1));
        }

        private void then_location_is_changed()
        {
            Assert.That(player.currentLocation, Is.EqualTo(board.Squares[1].Location));
        }
    }
}
