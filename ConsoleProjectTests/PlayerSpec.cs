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
            given_a_player_makes_a_move();
            then_one_life_is_lost();
        }

        [Test]
        public void player_makes_a_move()
        {
            given_a_player_makes_a_move();
            then_location_is_changed();
        }

    }
}
