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
                    if (pinResults[i].Contains("-"))
                        finalScore += int.Parse(pinResults[i][0].ToString());
                }




                return finalScore;
            }
        }
    }
}
