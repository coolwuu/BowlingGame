using NUnit.Framework;

namespace BowlingGame
{
    public partial class BowlingGameTest
    {
        public BowlingGame Game = new BowlingGame();

        [Test]
        public void get_0_pin_every_frame_should_return_score_correctly()
        {
            
            string result = "0- 0- 0- 0- 0- 0- 0- 0- 0- 0-";
            int expectedScore = 0;
            
            Assert.AreEqual(expectedScore,Game.FinalScoreByResult(result));
        }

        [Test]
        public void get_1_pin_every_frame_should_return_score_correctly()
        {

            string result = "1- 1- 1- 1- 1- 1- 1- 1- 1- 1-";
            int expectedScore = 10;

            Assert.AreEqual(expectedScore, Game.FinalScoreByResult(result));
        }

        [Test]
        public void get_strike_at_1st_frame_should_return_score_correctly()
        {

            string result = "X 1- 1- 1- 1- 1- 1- 1- 1- 1-";
            int expectedScore = 20;

            Assert.AreEqual(expectedScore, Game.FinalScoreByResult(result));
        }
    }
}
