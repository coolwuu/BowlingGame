using System;
using System.Collections.Generic;

namespace BowlingGame
{
    public partial class BowlingGameTest
    {
        public class BowlingGame
        {

            public int FinalScoreByResult(string result)
            {
                int finalScore = 0;
                string[] pinResults = result.Split(' ');

                for (var i = 0; i < pinResults.Length; i++)
                {
                    if (IsLastFrame(i))
                    {
                        finalScore += GetLastFrameScore(pinResults, i);
                    }
                    else
                    {
                        finalScore += GetFrameScore(pinResults, i);
                    }
                }

                return finalScore;
            }

            private int GetFrameScore(string[] pinResults, int i)
            {
                int score = 0;
                if (isStrike(pinResults[i]))
                {
                    score += GetScoreWhenStrike(pinResults, i);
                    return score;
                }
                if (isSpare(pinResults[i]))
                {
                    score += GetScoreWhenSpare(pinResults, i);
                    return score;
                }
                score += GetScoreByFrame(pinResults[i]);
                return score;
            }

            private int GetLastFrameScore(string[] pinResults, int i)
            {
                int score = 0;
                if (isStrike(pinResults[i]))
                {
                    score += GetScoreByFrame(pinResults[i]);
                    return score;
                }
                if (isSpare(pinResults[i]))
                {
                    score += GetScoreByFrame(pinResults[i]) + int.Parse(pinResults[i][2].ToString());
                    return score;
                }

                return GetScoreByFrame(pinResults[i]);
                
            }

            private int GetScoreWhenStrike(string[] pinResults, int i)
            {
                return GetScoreByFrame(pinResults[i])
                       + GetNext2ThrowsScore(pinResults[i + 1] + " " + pinResults[i + 2]);
            }
            private int GetScoreWhenSpare(string[] pinResults, int i)
            {
                int score = 0;
                if (isStrike(pinResults[i + 1]))
                {
                    score += GetScoreByFrame(pinResults[i]) + GetScoreByFrame(pinResults[i + 1]);
                    return score;
                }
                score += GetScoreByFrame(pinResults[i]) + int.Parse(pinResults[i + 1][0].ToString());
                return score;
            }
            private static bool IsLastFrame(int i)
            {
                return i > 8;
            }
            private int GetNext2ThrowsScore(string pinResults)
            {
                string[] pinResult = pinResults.Split(' ');
                if (isStrike(pinResult[0]))
                {
                    if (isStrike(pinResult[1]))
                        return GetScoreByFrame(pinResult[0]) + GetScoreByFrame(pinResult[1]);
                    return GetScoreByFrame(pinResult[0]) + int.Parse(pinResult[1][0].ToString());
                }
                return GetScoreByFrame(pinResult[0]);
            }
            private bool isStrike(string result)
            {
                return result.Contains("X");
            }
            private bool isSpare(string result)
            {
                return result.Contains("/");
            }
            private int GetScoreByFrame(string pinResult)
            {
                if (pinResult.Contains("X"))
                    return 10;
                if (pinResult.Contains("/"))
                    return 10;
                if (pinResult.Contains("-"))
                    return int.Parse(pinResult[0].ToString());
                if (pinResult.Length == 1)
                    return int.Parse(pinResult[0].ToString());
                return int.Parse(pinResult[0].ToString()) + int.Parse(pinResult[1].ToString());
            }
        }
    }
}
