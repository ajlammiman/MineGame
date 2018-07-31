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
            given_a_player_makes_a_move_onto_a_square_with_a_mine();
            then_one_life_is_lost();
        }

    }
}
