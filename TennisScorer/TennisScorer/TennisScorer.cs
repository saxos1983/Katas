namespace Tennis
{
    public class TennisScorer : ITennisScorer
    {
        private int scoreA;
        private int scoreB;

        private const string GameA = "gameA";
        private const string GameB = "gameB";
        private const string AdvantageA = "advantageA";
        private const string AdvantageB = "advantageB";

        private static readonly string[][] PlayerScores = new[]
            {
                new[] {"love",  "15:0",     "30:0",     "40:0",     GameA},
                new[] {"0:15",  "15:15",    "30:15",    "40:15",    GameA},
                new[] {"0:30",  "15:30",    "30:30",    "40:30",    GameA},
                new[] {"0:40",  "15:40",    "30:40",    "deuce",    AdvantageA},
                new[] { GameB,   GameB,     GameB,      AdvantageB}
            };

        public void AchievesScore(Player player)
        {
            switch (player)
            {
                case Player.PlayerA:
                    UpdateGameScore(ref scoreA, ref scoreB);
                    break;
                case Player.PlayerB:
                    UpdateGameScore(ref scoreB, ref scoreA);
                    break;
            }
        }

        public string GameScore
        {
            get { return PlayerScores[scoreB][scoreA]; }
        }

        private void UpdateGameScore(ref int playerToAddScore, ref int opponentScore)
        {
            if (GameScore == AdvantageA || GameScore == AdvantageB)
            {
                opponentScore--;
            }
            else if (GameScore != GameA && GameScore != GameB)
            {
                playerToAddScore++;
            }
        }
    }
}