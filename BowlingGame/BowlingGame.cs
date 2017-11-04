namespace BowlingGame
{
    public partial class BowlingGameTest
    {
        public class BowlingGame
        {

            public int FinalScoreByResult(string result)
            {
                int finalScore = 0;
                string[] frameResults = result.Split(' ');

                for (var i = 0; i < frameResults.Length; i++)
                {
                    if (IsLastFrame(i))
                    {
                        finalScore += GetLastFrameScore(frameResults, i);
                    }
                    else
                    {
                        finalScore += GetFrameScore(frameResults, i);
                    }
                }

                return finalScore;
            }
            private int GetFrameScore(string[] frameResults, int current)
            {
                if (IsStrike(frameResults[current]))
                {
                    return GetScoreWhenStrike(frameResults, current);
                }
                if (IsSpare(frameResults[current]))
                {
                    return GetScoreWhenSpare(frameResults, current);
                }
                return GetScoreByFrame(frameResults[current]);
            }
            private int GetLastFrameScore(string[] frameResults, int current)
            {
                if (IsStrike(frameResults[current]))
                {
                    return GetScoreByFrame(frameResults[current]);
                }
                if (IsSpare(frameResults[current]))
                {
                    return GetScoreByFrame(frameResults[current]) + int.Parse(frameResults[current][2].ToString());
                }
                return GetScoreByFrame(frameResults[current]);
                
            }
            private int GetScoreWhenStrike(string[] frameResults, int current)
            {
                return GetScoreByFrame(frameResults[current])
                       + GetScoreForNext2Rolls(frameResults[current + 1] + " " + frameResults[current + 2]);
            }
            private int GetScoreWhenSpare(string[] frameResults, int current)
            {
                if (IsStrike(frameResults[current + 1]))
                {
                    return GetScoreByFrame(frameResults[current]) + GetScoreByFrame(frameResults[current + 1]);
                }
                return GetScoreByFrame(frameResults[current]) + int.Parse(frameResults[current + 1][0].ToString());
            }
            private static bool IsLastFrame(int current)
            {
                return current > 8;
            }
            private int GetScoreForNext2Rolls(string frameResults)
            {
                string[] pinResult = frameResults.Split(' ');
                if (IsStrike(pinResult[0]))
                {
                    if (IsStrike(pinResult[1]))
                        return GetScoreByFrame(pinResult[0]) + GetScoreByFrame(pinResult[1]);
                    return GetScoreByFrame(pinResult[0]) + int.Parse(pinResult[1][0].ToString());
                }
                return GetScoreByFrame(pinResult[0]);
            }
            private bool IsStrike(string frameResult)
            {
                return frameResult.Contains("X");
            }
            private bool IsSpare(string frameResult)
            {
                return frameResult.Contains("/");
            }
            private int GetScoreByFrame(string frameResult)
            {
                if (frameResult.Contains("X"))
                    return 10;
                if (frameResult.Contains("/"))
                    return 10;
                if (frameResult.Contains("-"))
                    return int.Parse(frameResult[0].ToString());
                if (frameResult.Length == 1)
                    return int.Parse(frameResult[0].ToString());
                return int.Parse(frameResult[0].ToString()) + int.Parse(frameResult[1].ToString());
            }
        }
    }
}
