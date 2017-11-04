using NUnit.Framework;

namespace BowlingGame
{
    public class BowlingGameTest
    {
        public BowlingGame Game = new BowlingGame();

        [Test]
        public void all_0_point_should_return_score_correctly()
        {
            
            string result = "0- 0- 0- 0- 0- 0- 0- 0- 0- 0-";

            var actual = Game.FinalScoreByResult(result);
            Assert.AreEqual(0,actual);
        }

        public class BowlingGame
        {
            public int FinalScoreByResult(string result)
            {
                return 0;
            }
        }
    }
}
