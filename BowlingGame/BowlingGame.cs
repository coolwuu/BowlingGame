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

                for (var i = 0; i < pinResults.Length; i++)
                {
                    if (i > 8)
                    {
                        if (isStrike(pinResults[i]))
                        {
                            finalScore += GetScoreByFrame(pinResults[i]);
                            continue;
                        }
                        finalScore += GetScoreByFrame(pinResults[i]);
                    }
                    else
                    {
                        if (isStrike(pinResults[i]))
                        {
                            finalScore += GetScoreByFrame(pinResults[i])
                                          + GetNext2ThrowsScore(pinResults[i + 1] + " " + pinResults[i + 2]);

                        }
                        else
                            finalScore += GetScoreByFrame(pinResults[i]);
                    }
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
