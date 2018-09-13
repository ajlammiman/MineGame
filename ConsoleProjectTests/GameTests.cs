using System.Runtime.CompilerServices;
using NUnit.Framework;
using MineGame;

namespace GameTests
{
    public partial class GameSpecs
    {
        private Game game { get; set; }
        private Player player { get; set; }
        private Location startLocation { get; set; }

        [OneTimeSetUp]
        public void Init()
        {
            var board = new Board(0,5,5);
            var player = new Player(board, 3);
            startLocation = new Location {XLocation = 2, YLocation = 2};
            player.currentLocation = startLocation;

            game = new Game(player, board, startLocation);
        }

        private void given_a_move_left_is_made()
        {
            game.MakeMove(Move.Left);
        }

        private void given_a_move_right_is_made()
        {
            game.MakeMove(Move.Right);
        }

        private void given_a_move_up_is_made()
        {
            game.MakeMove(Move.Up);
        }

        private void given_a_move_down_is_made()
        {
            game.MakeMove(Move.Down);
        }

        private void given_a_non_move_key_is_pressed()
        {
            throw new System.NotImplementedException();
        }

        private void given_no_mines_on_the_board()
        {
            throw new System.NotImplementedException();
        }

        private void and_the_move_is_out_of_bounds()
        {
            throw new System.NotImplementedException();
        }

        private void and_the_move_to_a_square_with_a_mine()
        {
            throw new System.NotImplementedException();
        }

        private void and_the_player_moves_across_the_board_to_the_other_side()
        {
            throw new System.NotImplementedException();
        }

        private void then_the_move_is_to_the_left()
        {
            var newLocation = player.currentLocation;
            Assert.That(newLocation.XLocation == startLocation.XLocation - 1);
            Assert.That(newLocation.YLocation == startLocation.YLocation);
        }

        private void then_the_move_is_to_the_right()
        {
            var newLocation = player.currentLocation;
            Assert.That(newLocation.XLocation == startLocation.XLocation + 1);
            Assert.That(newLocation.YLocation == startLocation.YLocation);
        }

        private void then_the_move_is_up()
        {
            var newLocation = player.currentLocation;
            Assert.That(newLocation.YLocation == startLocation.XLocation + 1);
            Assert.That(newLocation.XLocation == startLocation.YLocation);
        }

        private void then_the_move_is_down()
        {
            var newLocation = player.currentLocation;
            Assert.That(newLocation.YLocation == startLocation.XLocation - 1);
            Assert.That(newLocation.XLocation == startLocation.YLocation);
        }

        private void then_a_move_is_not_made()
        {
            throw new System.NotImplementedException();
        }

        private void then_a_move_is_not_allowed()
        {
            throw new System.NotImplementedException();
        }

        private void then_a_life_is_lost()
        {
            throw new System.NotImplementedException();
        }

        private void then_last_life_is_lost_and_game_ends()
        {
            throw new System.NotImplementedException();
        }

        private void then_the_game_is_won()
        {
            throw new System.NotImplementedException();
        }
    }
}
