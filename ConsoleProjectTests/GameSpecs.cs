using NUnit.Framework;

namespace GameTests
{
    [TestFixture, Category("Game Tests")]
    public partial class GameSpecs
    {
        [Test]
        public void pressing_a_move_left_key_produces_a_move_left()
        {
            given_a_move_left_is_made();
            then_the_move_is_to_the_left();
        }

        [Test]
        public void pressing_a_move_right_key_produces_a_move_right()
        {
            given_a_move_right_is_made();
            then_the_move_is_to_the_right();
        }

        [Test]
        public void pressing_a_move_up_key_produces_a_move_up()
        {
            given_a_move_up_is_made();
            then_the_move_is_up();
        }

        [Test]
        public void pressing_a_move_down_key_produces_a_move_down()
        {
            given_a_move_down_is_made();
            then_the_move_is_down();
        }

        [Test, Ignore("")]
        public void pressing_a_non_move_key_does_not_make_a_move()
        {
            given_a_non_move_key_is_pressed();
            then_a_move_is_not_made();
        }

        [Test, Ignore("")]
        public void moving_out_of_bounds_is_not_allowed()
        {
            given_a_move_down_is_made();
            and_the_move_is_out_of_bounds();
            then_a_move_is_not_allowed();
        }


        [Test, Ignore("")]
        public void a_loss_of_life_produces_a_message()
        {
            given_a_move_right_is_made();
            and_the_move_to_a_square_with_a_mine();
            then_a_life_is_lost();
        }

        [Test, Ignore("")]
        public void a_loss_of_all_lives_ends_the_game()
        {
            given_a_move_right_is_made();
            and_the_move_to_a_square_with_a_mine();
            then_last_life_is_lost_and_game_ends();
        }

        [Test, Ignore("")]
        public void crossing_the_board_wins_the_game()
        {
            given_no_mines_on_the_board();
            and_the_player_moves_across_the_board_to_the_other_side();
            then_the_game_is_won();
        }
    }
}
