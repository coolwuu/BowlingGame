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

                foreach (var pinResult in pinResults)
                {
                    if (pinResult.Contains("-"))
                        finalScore += int.Parse(pinResult[0].ToString());
                }




                return finalScore;
            }
        }
    }
}
