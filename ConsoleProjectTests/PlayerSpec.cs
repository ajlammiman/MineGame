using System;
using NUnit.Framework;

namespace GameTests
{
    [TestFixture, Category("Player Tests")]
    public partial class PlayerTests
    {
        [Test]
        public void player_loses_a_life()
        {
            given_a_player_makes_a_move_to_a_mined_square();
            then_one_life_is_lost();
        }

        [Test]
        public void player_makes_a_move()
        {
            given_a_player_makes_a_move();
            then_location_is_changed();
        }

        [Test]
        public void player_moves_off_board()
        {
            given_a_player_makes_a_move_off_the_board();
            then_the_move_is_not_allowed();
        }
    }
}
