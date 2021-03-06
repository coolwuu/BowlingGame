﻿using NUnit.Framework;

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

        [Test]
        public void get_strike_at_1st_and_2nd_frame_should_return_score_correctly()
        {

            string result = "X X 1- 1- 1- 1- 1- 1- 1- 1-";
            int expectedScore = 40;

            Assert.AreEqual(expectedScore, Game.FinalScoreByResult(result));
        }

        [Test]
        public void get_all_strike_should_return_score_correctly()
        {

            string result = "X X X X X X X X X X X X";
            int expectedScore = 300;

            Assert.AreEqual(expectedScore, Game.FinalScoreByResult(result));
        }

        [Test]
        public void get_spare_at_1st_frame_should_return_score_correctly()
        {

            string result = "1/ 1- 1- 1- 1- 1- 1- 1- 1- 1-";
            int expectedScore = 20;

            Assert.AreEqual(expectedScore, Game.FinalScoreByResult(result));
        }

        [Test]
        public void get_spare_at_every_frame_should_return_score_correctly()
        {

            string result = "1/ 1/ 1/ 1/ 1/ 1/ 1/ 1/ 1/ 1/1";
            int expectedScore = 110;

            Assert.AreEqual(expectedScore, Game.FinalScoreByResult(result));
        }

        [Test]
        public void get_Spares_Strikes_should_return_score_correctly()
        {

            string result = "12 34 34 14 7/ X 90 24 63 X X X";
            int expectedScore = 115;

            Assert.AreEqual(expectedScore, Game.FinalScoreByResult(result));
        }

        [Test]
        public void situation1_should_return_score_correctly()
        {

            string result = "12 34 34 14 7/ X 90 24 63 X X 8";
            int expectedScore = 113;

            Assert.AreEqual(expectedScore, Game.FinalScoreByResult(result));
        }

        [Test]
        public void situation2_should_return_score_correctly()
        {

            string result = "12 34 34 14 7/ X X X 63 9-";
            int expectedScore = 135;

            Assert.AreEqual(expectedScore, Game.FinalScoreByResult(result));
        }
    }
}
