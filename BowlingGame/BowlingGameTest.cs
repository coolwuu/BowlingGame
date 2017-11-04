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

            var actual = Game.FinalScoreByResult(result);
            Assert.AreEqual(0,actual);
        }

        [Test]
        public void get_1_pin_every_frame_should_return_score_correctly()
        {

            string result = "1- 1- 1- 1- 1- 1- 1- 1- 1- 1-";

            var actual = Game.FinalScoreByResult(result);
            Assert.AreEqual(10, actual);
        }
    }
}
