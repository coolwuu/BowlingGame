using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace BowlingGame
{
    public class BowlingGameTest
    {
        [Test]
        public void all_0_point_should_return_score_correctly()
        {
            var bowlingGame = new BowlingGame();
            string result = "0- 0- 0- 0- 0- 0- 0- 0- 0- 0-";

            var actual = bowlingGame.FinalScoreByResult(result);

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
