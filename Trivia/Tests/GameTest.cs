using System;
using System.IO;
using ApprovalTests;
using ApprovalTests.Reporters;
using Trivia;
using Xunit;


namespace Tests
{
    [UseReporter(typeof(DiffReporter))]
    public class GameTest
    {
        [Fact]
        public void Golden_master_with_one_player()
        {
            var fakeconsole = new StringWriter();
            Console.SetOut(fakeconsole);
            var game = new Game();
            game.AddPlayer("Cedric");
            game.Roll(12);
            game.WrongAnswer();
            game.Roll(2);
            game.Roll(13);
            game.WasCorrectlyAnswered();
            game.Roll(13);
            Approvals.Verify(fakeconsole.ToString());
        }
        
        [Fact]
        public void Golden_master_with_two_players()
        {
            var fakeconsole = new StringWriter();
            Console.SetOut(fakeconsole);
            var game = new Game();
            game.AddPlayer("Cedric");
            game.AddPlayer("Eloïse");
            game.Roll(1);
            game.WasCorrectlyAnswered();
            game.Roll(2);
            game.WasCorrectlyAnswered();
            game.Roll(2);
            game.WasCorrectlyAnswered();
            game.Roll(2);
            game.WasCorrectlyAnswered();
            game.Roll(2);
            game.WasCorrectlyAnswered();
            game.Roll(2);
            game.WasCorrectlyAnswered();
            game.Roll(2);
            game.WasCorrectlyAnswered();
            game.Roll(2);
            game.WasCorrectlyAnswered();
            game.Roll(2);
            game.WasCorrectlyAnswered();
            game.Roll(2);
            game.WasCorrectlyAnswered();
            Approvals.Verify(fakeconsole.ToString());
        }
        
        [Fact]
        public void Golden_master_with_two_players_with_first_wrong_answer()
        {
            var fakeconsole = new StringWriter();
            Console.SetOut(fakeconsole);
            var game = new Game();
            game.AddPlayer("Cedric");
            game.AddPlayer("Eloïse");
            game.Roll(1);
            game.WrongAnswer();
            game.Roll(2);
            game.WasCorrectlyAnswered();
            game.Roll(2);
            game.WasCorrectlyAnswered();
            game.Roll(2);
            game.WasCorrectlyAnswered();
            game.Roll(2);
            game.WasCorrectlyAnswered();
            game.Roll(2);
            game.WasCorrectlyAnswered();
            game.Roll(2);
            game.WasCorrectlyAnswered();
            game.Roll(2);
            game.WasCorrectlyAnswered();
            game.Roll(2);
            game.WasCorrectlyAnswered();
            game.Roll(2);
            game.WasCorrectlyAnswered();
            Approvals.Verify(fakeconsole.ToString());
        }
    }
}
