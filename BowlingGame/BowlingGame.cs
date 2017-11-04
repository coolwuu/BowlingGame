using System;

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

                for(var i = 0; i< pinResults.Length;i++)
                {
                    if (pinResults[i].Contains("X"))
                    {
                        finalScore += GetScoreByFrame(pinResults[i]);
                        finalScore += GetNext2ThrowsScore(pinResults[i+1]+" "+pinResults[i+2]);
                    }
                    if (pinResults[i].Contains("-"))
                        finalScore += int.Parse(pinResults[i][0].ToString());
                }
                
                return finalScore;
            }

            private int GetNext2ThrowsScore(string pinResults)
            {
                string[] pinResult = pinResults.Split(' ');
                if (isStrike(pinResult[0]))
                {
                    if (isStrike(pinResult[1]))
                        return GetScoreByFrame(pinResult[0])+GetScoreByFrame(pinResult[1]);
                    return GetScoreByFrame(pinResult[0]) + int.Parse(pinResult[1][0].ToString());
                }
                return GetScoreByFrame(pinResult[0]);
            }

            private bool isStrike(string result)
            {
                return result.Contains("X");
            }

            private int GetScoreByFrame(string pinResult)
            {
                if (pinResult.Contains("X"))
                    return 10;
                if (pinResult.Contains("/"))
                    return 10;
                return int.Parse(pinResult[0].ToString());
            }
        }
    }
}
